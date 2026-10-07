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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> __BuildCreateConstituentAddress(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodycountry, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotMail = null, WorkflowExpression<string> bodydoNotMailReason = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<int> bodyseasonalStartmonth = null, WorkflowExpression<int> bodyseasonalStartday = null, WorkflowExpression<int> bodyseasonalEndmonth = null, WorkflowExpression<int> bodyseasonalEndday = null, WorkflowExpression<string> bodyhistoricalStartDate = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodyregion = null, WorkflowExpression<string> bodydPC = null, WorkflowExpression<string> bodycART = null, WorkflowExpression<string> bodylOT = null, WorkflowExpression<string> bodycongressionalDistrict = null, WorkflowExpression<string> bodystateHouseDistrict = null, WorkflowExpression<string> bodystateSenateDistrict = null, WorkflowExpression<string> bodylocalPrecinct = null, WorkflowExpression<bodyoriginInput> bodyorigin = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodyrecentlyMoved = null, WorkflowExpression<string> bodyoldAddress = null, WorkflowExpression<bool> bodyomitFromValidation = null, WorkflowExpression<bool> bodycopyToSpouse = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            WorkflowExpression.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowExpression.Validate(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowExpression.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowExpression.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowExpression.Validate(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            WorkflowExpression.Validate(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            WorkflowExpression.Validate(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            WorkflowExpression.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodyrecentlyMoved, nameof(bodyrecentlyMoved), required: false);
            WorkflowExpression.Validate(bodyoldAddress, nameof(bodyoldAddress), required: false);
            WorkflowExpression.Validate(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            WorkflowExpression.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAddress(WorkflowExpression<string> constituentAddressId)
        {
            WorkflowExpression.Validate(constituentAddressId, nameof(constituentAddressId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAddress(WorkflowExpression<string> constituentAddressId, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotMail = null, WorkflowExpression<string> bodydoNotMailReason = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<int> bodyseasonalStartmonth = null, WorkflowExpression<int> bodyseasonalStartday = null, WorkflowExpression<int> bodyseasonalEndmonth = null, WorkflowExpression<int> bodyseasonalEndday = null, WorkflowExpression<string> bodyhistoricalStartDate = null, WorkflowExpression<string> bodyhistoricalEndDate = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodyregion = null, WorkflowExpression<string> bodydPC = null, WorkflowExpression<string> bodycART = null, WorkflowExpression<string> bodylOT = null, WorkflowExpression<string> bodycongressionalDistrict = null, WorkflowExpression<string> bodystateHouseDistrict = null, WorkflowExpression<string> bodystateSenateDistrict = null, WorkflowExpression<string> bodylocalPrecinct = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodyomitFromValidation = null, WorkflowExpression<bool> bodyupdateContacts = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(constituentAddressId, nameof(constituentAddressId), required: true);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            WorkflowExpression.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowExpression.Validate(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            WorkflowExpression.Validate(bodyhistoricalEndDate, nameof(bodyhistoricalEndDate), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowExpression.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowExpression.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowExpression.Validate(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            WorkflowExpression.Validate(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            WorkflowExpression.Validate(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            WorkflowExpression.Validate(bodyupdateContacts, nameof(bodyupdateContacts), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> __BuildCreateConstituentAlternateLookupID(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodyalternateLookupID)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyalternateLookupID, nameof(bodyalternateLookupID), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAlternateLookupID(WorkflowExpression<string> alternateLookupId)
        {
            WorkflowExpression.Validate(alternateLookupId, nameof(alternateLookupId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAlternateLookupID(WorkflowExpression<string> alternateLookupId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodyalternateLookupID = null)
        {
            WorkflowExpression.Validate(alternateLookupId, nameof(alternateLookupId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyalternateLookupID, nameof(bodyalternateLookupID), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> __BuildCreateConstituentAppealResponse(WorkflowExpression<string> bodyconstituentAppealID, WorkflowExpression<string> bodycategory, WorkflowExpression<string> bodyresponse, WorkflowExpression<string> bodydate = null)
        {
            WorkflowExpression.Validate(bodyconstituentAppealID, nameof(bodyconstituentAppealID), required: true);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowExpression.Validate(bodyresponse, nameof(bodyresponse), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> __BuildCreateConstituentAppeal(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodyappealID, WorkflowExpression<string> bodymailing = null, WorkflowExpression<string> bodydateSent = null, WorkflowExpression<string> bodypackage = null, WorkflowExpression<string> bodysourceCode = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodyappealID, nameof(bodyappealID), required: true);
            WorkflowExpression.Validate(bodymailing, nameof(bodymailing), required: false);
            WorkflowExpression.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowExpression.Validate(bodypackage, nameof(bodypackage), required: false);
            WorkflowExpression.Validate(bodysourceCode, nameof(bodysourceCode), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAppeal(WorkflowExpression<string> constituentAppealId)
        {
            WorkflowExpression.Validate(constituentAppealId, nameof(constituentAppealId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAppeal(WorkflowExpression<string> constituentAppealId, WorkflowExpression<string> bodyappealID = null, WorkflowExpression<string> bodymailing = null, WorkflowExpression<string> bodydateSent = null, WorkflowExpression<string> bodypackage = null, WorkflowExpression<string> bodysourceCode = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(constituentAppealId, nameof(constituentAppealId), required: true);
            WorkflowExpression.Validate(bodyappealID, nameof(bodyappealID), required: false);
            WorkflowExpression.Validate(bodymailing, nameof(bodymailing), required: false);
            WorkflowExpression.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowExpression.Validate(bodypackage, nameof(bodypackage), required: false);
            WorkflowExpression.Validate(bodysourceCode, nameof(bodysourceCode), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> __BuildListConstituentAppeals(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAttribute(WorkflowExpression<string> constituentAttributeId)
        {
            WorkflowExpression.Validate(constituentAttributeId, nameof(constituentAttributeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence> __BuildCreateConstituentCorrespondence(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodycorrespondenceCode, WorkflowExpression<string> bodydateSent, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: true);
            WorkflowExpression.Validate(bodydateSent, nameof(bodydateSent), required: true);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentCorrespondence(WorkflowExpression<string> constituentCorrespondenceId)
        {
            WorkflowExpression.Validate(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentCorrespondence(WorkflowExpression<string> constituentCorrespondenceId, WorkflowExpression<string> bodycorrespondenceCode = null, WorkflowExpression<string> bodydateSent = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            WorkflowExpression.Validate(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: false);
            WorkflowExpression.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> __BuildCreateConstituentNote(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodydate, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyauthorID = null, WorkflowExpression<string> bodynote = null, WorkflowExpression<string> bodyhTML = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyauthorID, nameof(bodyauthorID), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodyhTML, nameof(bodyhTML), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentNote(WorkflowExpression<string> constituentNoteId)
        {
            WorkflowExpression.Validate(constituentNoteId, nameof(constituentNoteId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentNote(WorkflowExpression<string> constituentNoteId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodydate = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyauthorID = null, WorkflowExpression<string> bodynote = null, WorkflowExpression<string> bodyhTML = null)
        {
            WorkflowExpression.Validate(constituentNoteId, nameof(constituentNoteId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyauthorID, nameof(bodyauthorID), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodyhTML, nameof(bodyhTML), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> __BuildSearchConstituent(WorkflowExpression<string> keyName = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lookupId = null, WorkflowExpression<string> emailAddress = null, WorkflowExpression<string> phoneNumber = null, WorkflowExpression<string> country = null, WorkflowExpression<string> addressBlock = null, WorkflowExpression<string> city = null, WorkflowExpression<string> state = null, WorkflowExpression<string> postCode = null, WorkflowExpression<int> classof = null, WorkflowExpression<bool> exactMatchOnly = null, WorkflowExpression<string> middleName = null, WorkflowExpression<string> constituency = null, WorkflowExpression<string> sourcecode = null, WorkflowExpression<bool> includeIndividuals = null, WorkflowExpression<bool> includeOrganizations = null, WorkflowExpression<bool> includeGroups = null, WorkflowExpression<bool> excludeHouseholds = null, WorkflowExpression<bool> checkNickname = null, WorkflowExpression<bool> checkAliases = null, WorkflowExpression<bool> checkAlternateLookupIds = null, WorkflowExpression<bool> onlyPrimaryAddress = null, WorkflowExpression<bool> includeDeceased = null, WorkflowExpression<bool> includeInactive = null, WorkflowExpression<bool> fuzzySearchOnName = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(keyName, nameof(keyName), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lookupId, nameof(lookupId), required: false);
            WorkflowExpression.Validate(emailAddress, nameof(emailAddress), required: false);
            WorkflowExpression.Validate(phoneNumber, nameof(phoneNumber), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(addressBlock, nameof(addressBlock), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            WorkflowExpression.Validate(postCode, nameof(postCode), required: false);
            WorkflowExpression.Validate(classof, nameof(classof), required: false);
            WorkflowExpression.Validate(exactMatchOnly, nameof(exactMatchOnly), required: false);
            WorkflowExpression.Validate(middleName, nameof(middleName), required: false);
            WorkflowExpression.Validate(constituency, nameof(constituency), required: false);
            WorkflowExpression.Validate(sourcecode, nameof(sourcecode), required: false);
            WorkflowExpression.Validate(includeIndividuals, nameof(includeIndividuals), required: false);
            WorkflowExpression.Validate(includeOrganizations, nameof(includeOrganizations), required: false);
            WorkflowExpression.Validate(includeGroups, nameof(includeGroups), required: false);
            WorkflowExpression.Validate(excludeHouseholds, nameof(excludeHouseholds), required: false);
            WorkflowExpression.Validate(checkNickname, nameof(checkNickname), required: false);
            WorkflowExpression.Validate(checkAliases, nameof(checkAliases), required: false);
            WorkflowExpression.Validate(checkAlternateLookupIds, nameof(checkAlternateLookupIds), required: false);
            WorkflowExpression.Validate(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            WorkflowExpression.Validate(includeDeceased, nameof(includeDeceased), required: false);
            WorkflowExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            WorkflowExpression.Validate(fuzzySearchOnName, nameof(fuzzySearchOnName), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituent(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAddressCollection> __BuildListConstituentAddresses(WorkflowExpression<string> constituentId, WorkflowExpression<bool> includeFormer = null)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowExpression.Validate(includeFormer, nameof(includeFormer), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> __BuildListConstituentAlternateLookupIDs(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAttributeCollection> __BuildListConstituentAttributes(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> __BuildGetConstituentPrimaryContactInfo(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEducationCollection> __BuildListConstituentEducations(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> __BuildListConstituentEmailAddresses(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgPhoneCollection> __BuildListConstituentPhones(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> __BuildGetConstituentProfilePicture(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> __BuildListConstituentEmploymentHistory(WorkflowExpression<string> constituentId, WorkflowExpression<bool> includeInactive = null)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowExpression.Validate(includeInactive, nameof(includeInactive), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> __BuildListConstituentSolicitCodes(WorkflowExpression<string> constituentId, WorkflowExpression<bool> showExpired = null, WorkflowExpression<dateRangeInput> dateRange = null)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowExpression.Validate(showExpired, nameof(showExpired), required: false);
            WorkflowExpression.Validate(dateRange, nameof(dateRange), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgTributeCollection> __BuildListConstituentTributes(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> __BuildGetConstituentSummaryProfile(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> __BuildCreateConstituentEducation(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodyeducationalInstitution, WorkflowExpression<string> bodystatus, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<string> bodyprogram = null, WorkflowExpression<string> bodydegree = null, WorkflowExpression<string> bodyhonorAwarded = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<int> bodysourceDateyear = null, WorkflowExpression<int> bodysourceDatemonth = null, WorkflowExpression<int> bodysourceDateday = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<int> bodydateGraduatedyear = null, WorkflowExpression<int> bodydateGraduatedmonth = null, WorkflowExpression<int> bodydateGraduatedday = null, WorkflowExpression<int> bodyclassOf = null, WorkflowExpression<int> bodypreferredClassOf = null, WorkflowExpression<bool> bodyaffiliated = null, WorkflowExpression<int> bodyfromyear = null, WorkflowExpression<int> bodyfrommonth = null, WorkflowExpression<int> bodyfromday = null, WorkflowExpression<int> bodytoyear = null, WorkflowExpression<int> bodytomonth = null, WorkflowExpression<int> bodytoday = null, WorkflowExpression<string> bodyreason = null, WorkflowExpression<string> bodylevel = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: true);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodyprogram, nameof(bodyprogram), required: false);
            WorkflowExpression.Validate(bodydegree, nameof(bodydegree), required: false);
            WorkflowExpression.Validate(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            WorkflowExpression.Validate(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            WorkflowExpression.Validate(bodysourceDateday, nameof(bodysourceDateday), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            WorkflowExpression.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            WorkflowExpression.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            WorkflowExpression.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            WorkflowExpression.Validate(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            WorkflowExpression.Validate(bodyaffiliated, nameof(bodyaffiliated), required: false);
            WorkflowExpression.Validate(bodyfromyear, nameof(bodyfromyear), required: false);
            WorkflowExpression.Validate(bodyfrommonth, nameof(bodyfrommonth), required: false);
            WorkflowExpression.Validate(bodyfromday, nameof(bodyfromday), required: false);
            WorkflowExpression.Validate(bodytoyear, nameof(bodytoyear), required: false);
            WorkflowExpression.Validate(bodytomonth, nameof(bodytomonth), required: false);
            WorkflowExpression.Validate(bodytoday, nameof(bodytoday), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEducation(WorkflowExpression<string> educationalHistoryId)
        {
            WorkflowExpression.Validate(educationalHistoryId, nameof(educationalHistoryId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEducation(WorkflowExpression<string> educationalHistoryId, WorkflowExpression<string> bodyeducationalInstitution = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<string> bodyprogram = null, WorkflowExpression<string> bodydegree = null, WorkflowExpression<string> bodyhonorAwarded = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<int> bodysourceDateyear = null, WorkflowExpression<int> bodysourceDatemonth = null, WorkflowExpression<int> bodysourceDateday = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<int> bodydateGraduatedyear = null, WorkflowExpression<int> bodydateGraduatedmonth = null, WorkflowExpression<int> bodydateGraduatedday = null, WorkflowExpression<int> bodyclassOf = null, WorkflowExpression<int> bodypreferredClassOf = null, WorkflowExpression<bool> bodyaffiliated = null, WorkflowExpression<int> bodyfromyear = null, WorkflowExpression<int> bodyfrommonth = null, WorkflowExpression<int> bodyfromday = null, WorkflowExpression<int> bodytoyear = null, WorkflowExpression<int> bodytomonth = null, WorkflowExpression<int> bodytoday = null, WorkflowExpression<string> bodyreason = null, WorkflowExpression<string> bodylevel = null)
        {
            WorkflowExpression.Validate(educationalHistoryId, nameof(educationalHistoryId), required: true);
            WorkflowExpression.Validate(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodyprogram, nameof(bodyprogram), required: false);
            WorkflowExpression.Validate(bodydegree, nameof(bodydegree), required: false);
            WorkflowExpression.Validate(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            WorkflowExpression.Validate(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            WorkflowExpression.Validate(bodysourceDateday, nameof(bodysourceDateday), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            WorkflowExpression.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            WorkflowExpression.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            WorkflowExpression.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            WorkflowExpression.Validate(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            WorkflowExpression.Validate(bodyaffiliated, nameof(bodyaffiliated), required: false);
            WorkflowExpression.Validate(bodyfromyear, nameof(bodyfromyear), required: false);
            WorkflowExpression.Validate(bodyfrommonth, nameof(bodyfrommonth), required: false);
            WorkflowExpression.Validate(bodyfromday, nameof(bodyfromday), required: false);
            WorkflowExpression.Validate(bodytoyear, nameof(bodytoyear), required: false);
            WorkflowExpression.Validate(bodytomonth, nameof(bodytomonth), required: false);
            WorkflowExpression.Validate(bodytoday, nameof(bodytoday), required: false);
            WorkflowExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> __BuildCreateConstituentEmailAddress(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodyemailAddress, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotEmail = null, WorkflowExpression<string> bodydoNotEmailReason = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<bodyoriginInput> bodyorigin = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodycopyToSpouse = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            WorkflowExpression.Validate(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEmailAddress(WorkflowExpression<string> emailAddressId)
        {
            WorkflowExpression.Validate(emailAddressId, nameof(emailAddressId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEmailAddress(WorkflowExpression<string> emailAddressId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotEmail = null, WorkflowExpression<string> bodydoNotEmailReason = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodycopyToSpouse = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(emailAddressId, nameof(emailAddressId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            WorkflowExpression.Validate(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> __BuildCreateFundraiserConstituency(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodydateFrom = null, WorkflowExpression<string> bodydateTo = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodydateFrom, nameof(bodydateFrom), required: false);
            WorkflowExpression.Validate(bodydateTo, nameof(bodydateTo), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFundraiserConstituency(WorkflowExpression<string> fundraiserConstituencyId)
        {
            WorkflowExpression.Validate(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditFundraiserConstituency(WorkflowExpression<string> fundraiserConstituencyId, WorkflowExpression<string> bodydateFrom = null, WorkflowExpression<string> bodydateTo = null)
        {
            WorkflowExpression.Validate(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            WorkflowExpression.Validate(bodydateFrom, nameof(bodydateFrom), required: false);
            WorkflowExpression.Validate(bodydateTo, nameof(bodydateTo), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> __BuildCreateIndividualConstituent(WorkflowExpression<string> bodylastName, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodysuffix = null, WorkflowExpression<string> bodyaddressType = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<bool> bodydoNotSendMail = null, WorkflowExpression<string> bodydoNotMailReason = null, WorkflowExpression<string> bodydPC = null, WorkflowExpression<string> bodycART = null, WorkflowExpression<string> bodylOT = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodycongressionalDistrict = null, WorkflowExpression<string> bodyphoneType = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodyemailType = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodytitle2 = null, WorkflowExpression<string> bodysuffix2 = null, WorkflowExpression<string> bodynickname = null, WorkflowExpression<string> bodymaidenName = null, WorkflowExpression<string> bodymaritalStatus = null, WorkflowExpression<int> bodybirthdateyear = null, WorkflowExpression<int> bodybirthdatemonth = null, WorkflowExpression<int> bodybirthdateday = null, WorkflowExpression<string> bodygender = null)
        {
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodysuffix, nameof(bodysuffix), required: false);
            WorkflowExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            WorkflowExpression.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowExpression.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowExpression.Validate(bodyphoneType, nameof(bodyphoneType), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyemailType, nameof(bodyemailType), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodytitle2, nameof(bodytitle2), required: false);
            WorkflowExpression.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            WorkflowExpression.Validate(bodynickname, nameof(bodynickname), required: false);
            WorkflowExpression.Validate(bodymaidenName, nameof(bodymaidenName), required: false);
            WorkflowExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowExpression.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            WorkflowExpression.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            WorkflowExpression.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            WorkflowExpression.Validate(bodygender, nameof(bodygender), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgIndividualConstituent> __BuildGetIndividualConstituent(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditIndividualConstituent(WorkflowExpression<string> constituentId, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodysuffix = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodytitle2 = null, WorkflowExpression<string> bodysuffix2 = null, WorkflowExpression<string> bodynickname = null, WorkflowExpression<string> bodymaidenName = null, WorkflowExpression<string> bodymaritalStatus = null, WorkflowExpression<int> bodybirthdateyear = null, WorkflowExpression<int> bodybirthdatemonth = null, WorkflowExpression<int> bodybirthdateday = null, WorkflowExpression<string> bodygender = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<bool> bodygivesAnonymously = null, WorkflowExpression<bool> bodydeceased = null, WorkflowExpression<string> bodyprofilePicture = null, WorkflowExpression<string> bodyprofileThumbnail = null)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodysuffix, nameof(bodysuffix), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodytitle2, nameof(bodytitle2), required: false);
            WorkflowExpression.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            WorkflowExpression.Validate(bodynickname, nameof(bodynickname), required: false);
            WorkflowExpression.Validate(bodymaidenName, nameof(bodymaidenName), required: false);
            WorkflowExpression.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowExpression.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            WorkflowExpression.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            WorkflowExpression.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            WorkflowExpression.Validate(bodygender, nameof(bodygender), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            WorkflowExpression.Validate(bodydeceased, nameof(bodydeceased), required: false);
            WorkflowExpression.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowExpression.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> __BuildCreateConstituentInteraction(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodysummary, WorkflowExpression<bodystatusInput> bodystatus, WorkflowExpression<string> bodyexpectedDate, WorkflowExpression<string> bodycontactMethod, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodysubcategory = null, WorkflowExpression<int> bodyexpectedStarthour = null, WorkflowExpression<int> bodyexpectedStartminute = null, WorkflowExpression<int> bodyexpectedEndhour = null, WorkflowExpression<int> bodyexpectedEndminute = null, WorkflowExpression<string> bodyactualDate = null, WorkflowExpression<int> bodyactualStarthour = null, WorkflowExpression<int> bodyactualStartminute = null, WorkflowExpression<int> bodyactualEndhour = null, WorkflowExpression<int> bodyactualEndminute = null, WorkflowExpression<string> bodytimeZone = null, WorkflowExpression<bool> bodyallDayEvent = null, WorkflowExpression<string> bodyownerID = null, WorkflowExpression<string> bodyeventID = null, WorkflowExpression<string> bodylocation = null, WorkflowExpression<string> bodyotherLocation = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<ConmgNewConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: true);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            WorkflowExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: true);
            WorkflowExpression.Validate(bodycontactMethod, nameof(bodycontactMethod), required: true);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowExpression.Validate(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            WorkflowExpression.Validate(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            WorkflowExpression.Validate(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            WorkflowExpression.Validate(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            WorkflowExpression.Validate(bodyactualDate, nameof(bodyactualDate), required: false);
            WorkflowExpression.Validate(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            WorkflowExpression.Validate(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            WorkflowExpression.Validate(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            WorkflowExpression.Validate(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowExpression.Validate(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            WorkflowExpression.Validate(bodyownerID, nameof(bodyownerID), required: false);
            WorkflowExpression.Validate(bodyeventID, nameof(bodyeventID), required: false);
            WorkflowExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowExpression.Validate(bodyotherLocation, nameof(bodyotherLocation), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentInteraction> __BuildGetConstituentInteraction(WorkflowExpression<string> constituentInteractionId)
        {
            WorkflowExpression.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentInteraction(WorkflowExpression<string> constituentInteractionId)
        {
            WorkflowExpression.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentInteraction(WorkflowExpression<string> constituentInteractionId, WorkflowExpression<string> bodysummary = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodysubcategory = null, WorkflowExpression<string> bodyexpectedDate = null, WorkflowExpression<int> bodyexpectedStarthour = null, WorkflowExpression<int> bodyexpectedStartminute = null, WorkflowExpression<int> bodyexpectedEndhour = null, WorkflowExpression<int> bodyexpectedEndminute = null, WorkflowExpression<string> bodyactualDate = null, WorkflowExpression<int> bodyactualStarthour = null, WorkflowExpression<int> bodyactualStartminute = null, WorkflowExpression<int> bodyactualEndhour = null, WorkflowExpression<int> bodyactualEndminute = null, WorkflowExpression<string> bodytimeZone = null, WorkflowExpression<bool> bodyallDayEvent = null, WorkflowExpression<string> bodyownerID = null, WorkflowExpression<string> bodycontactMethod = null, WorkflowExpression<string> bodyeventID = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<ConmgUpdateConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            WorkflowExpression.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowExpression.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            WorkflowExpression.Validate(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            WorkflowExpression.Validate(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            WorkflowExpression.Validate(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            WorkflowExpression.Validate(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            WorkflowExpression.Validate(bodyactualDate, nameof(bodyactualDate), required: false);
            WorkflowExpression.Validate(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            WorkflowExpression.Validate(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            WorkflowExpression.Validate(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            WorkflowExpression.Validate(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowExpression.Validate(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            WorkflowExpression.Validate(bodyownerID, nameof(bodyownerID), required: false);
            WorkflowExpression.Validate(bodycontactMethod, nameof(bodycontactMethod), required: false);
            WorkflowExpression.Validate(bodyeventID, nameof(bodyeventID), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgMergedConstituent> __BuildMergeTwoConstituents(WorkflowExpression<string> bodysourceConstituentID, WorkflowExpression<string> bodytargetConstituentID, WorkflowExpression<string> bodyconfiguration, WorkflowExpression<bool> bodydeleteSource, WorkflowExpression<bodydeleteActionInput> bodydeleteAction, WorkflowExpression<string> bodyinactiveReason = null, WorkflowExpression<string> bodyinactivityDetails = null)
        {
            WorkflowExpression.Validate(bodysourceConstituentID, nameof(bodysourceConstituentID), required: true);
            WorkflowExpression.Validate(bodytargetConstituentID, nameof(bodytargetConstituentID), required: true);
            WorkflowExpression.Validate(bodyconfiguration, nameof(bodyconfiguration), required: true);
            WorkflowExpression.Validate(bodydeleteSource, nameof(bodydeleteSource), required: true);
            WorkflowExpression.Validate(bodydeleteAction, nameof(bodydeleteAction), required: true);
            WorkflowExpression.Validate(bodyinactiveReason, nameof(bodyinactiveReason), required: false);
            WorkflowExpression.Validate(bodyinactivityDetails, nameof(bodyinactivityDetails), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> __BuildCreateOrganizationConstituent(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyindustry = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<int> bodynoOfSubsidiaryOrgs = null, WorkflowExpression<string> bodyparentOrg = null, WorkflowExpression<string> bodyaddressType = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<bool> bodydoNotSendMail = null, WorkflowExpression<string> bodydoNotMailReason = null, WorkflowExpression<string> bodydPC = null, WorkflowExpression<string> bodycART = null, WorkflowExpression<string> bodylOT = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodycongressionalDistrict = null, WorkflowExpression<string> bodyphoneType = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodyemailType = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodywebAddress = null, WorkflowExpression<bool> bodyisPrimaryOrganization = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyprofilePicture = null, WorkflowExpression<string> bodyprofileThumbnail = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            WorkflowExpression.Validate(bodyparentOrg, nameof(bodyparentOrg), required: false);
            WorkflowExpression.Validate(bodyaddressType, nameof(bodyaddressType), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            WorkflowExpression.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowExpression.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowExpression.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowExpression.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowExpression.Validate(bodyphoneType, nameof(bodyphoneType), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyemailType, nameof(bodyemailType), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodywebAddress, nameof(bodywebAddress), required: false);
            WorkflowExpression.Validate(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowExpression.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> __BuildGetOrganizationConstituent(WorkflowExpression<string> constituentId)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditOrganizationConstituent(WorkflowExpression<string> constituentId, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyindustry = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<int> bodynoOfSubsidiaryOrgs = null, WorkflowExpression<string> bodyparentOrg = null, WorkflowExpression<string> bodywebAddress = null, WorkflowExpression<bool> bodyisPrimaryOrganization = null, WorkflowExpression<string> bodyprofilePicture = null, WorkflowExpression<string> bodyprofileThumbnail = null)
        {
            WorkflowExpression.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            WorkflowExpression.Validate(bodyparentOrg, nameof(bodyparentOrg), required: false);
            WorkflowExpression.Validate(bodywebAddress, nameof(bodywebAddress), required: false);
            WorkflowExpression.Validate(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            WorkflowExpression.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowExpression.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> __BuildCreateConstituentPhone(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodynumber, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<int> bodycallAfterhour = null, WorkflowExpression<int> bodycallAfterminute = null, WorkflowExpression<int> bodycallBeforehour = null, WorkflowExpression<int> bodycallBeforeminute = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotCall = null, WorkflowExpression<string> bodydoNotCallReason = null, WorkflowExpression<bool> bodydoNotText = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<int> bodyseasonalStartmonth = null, WorkflowExpression<int> bodyseasonalStartday = null, WorkflowExpression<int> bodyseasonalEndmonth = null, WorkflowExpression<int> bodyseasonalEndday = null, WorkflowExpression<bodyoriginInput> bodyorigin = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodycopyToSpouse = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            WorkflowExpression.Validate(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            WorkflowExpression.Validate(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            WorkflowExpression.Validate(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            WorkflowExpression.Validate(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            WorkflowExpression.Validate(bodydoNotText, nameof(bodydoNotText), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowExpression.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentPhone(WorkflowExpression<string> constituentPhoneId)
        {
            WorkflowExpression.Validate(constituentPhoneId, nameof(constituentPhoneId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentPhone(WorkflowExpression<string> constituentPhoneId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodynumber = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<int> bodycallAfterhour = null, WorkflowExpression<int> bodycallAfterminute = null, WorkflowExpression<int> bodycallBeforehour = null, WorkflowExpression<int> bodycallBeforeminute = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodyprimary = null, WorkflowExpression<bool> bodydoNotCall = null, WorkflowExpression<string> bodydoNotCallReason = null, WorkflowExpression<bool> bodydoNotText = null, WorkflowExpression<bool> bodyisConfidential = null, WorkflowExpression<int> bodyseasonalStartmonth = null, WorkflowExpression<int> bodyseasonalStartday = null, WorkflowExpression<int> bodyseasonalEndmonth = null, WorkflowExpression<int> bodyseasonalEndday = null, WorkflowExpression<string> bodyinformationSource = null, WorkflowExpression<string> bodyinfoSourceComments = null, WorkflowExpression<bool> bodycopyToSpouse = null, WorkflowExpression<bool> bodycopyToHousehold = null)
        {
            WorkflowExpression.Validate(constituentPhoneId, nameof(constituentPhoneId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            WorkflowExpression.Validate(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            WorkflowExpression.Validate(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            WorkflowExpression.Validate(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowExpression.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            WorkflowExpression.Validate(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            WorkflowExpression.Validate(bodydoNotText, nameof(bodydoNotText), required: false);
            WorkflowExpression.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowExpression.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowExpression.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowExpression.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowExpression.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowExpression.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowExpression.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowExpression.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> __BuildCreateConstituentEmploymentHistory(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodyrelationship, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodycareerLevel = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodysyncEndDate = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodydivision = null, WorkflowExpression<string> bodycareerLevel2 = null, WorkflowExpression<string> bodyresponsibilities = null, WorkflowExpression<bool> bodyisPrivate = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodycareerLevel, nameof(bodycareerLevel), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowExpression.Validate(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            WorkflowExpression.Validate(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEmploymentHistory(WorkflowExpression<string> relationshipJobInfoId)
        {
            WorkflowExpression.Validate(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEmploymentHistory(WorkflowExpression<string> relationshipJobInfoId, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodycareerLevel = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodysyncEndDate = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodydivision = null, WorkflowExpression<string> bodycareerLevel2 = null, WorkflowExpression<string> bodyresponsibilities = null, WorkflowExpression<bool> bodyisPrivate = null)
        {
            WorkflowExpression.Validate(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodycareerLevel, nameof(bodycareerLevel), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowExpression.Validate(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            WorkflowExpression.Validate(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> __BuildCreateConstituentSolicitCode(WorkflowExpression<string> bodyconstituentID, WorkflowExpression<string> bodysolicitCode, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowExpression.Validate(bodysolicitCode, nameof(bodysolicitCode), required: true);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentSolicitCode(WorkflowExpression<string> constituentSolicitCodeId)
        {
            WorkflowExpression.Validate(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentSolicitCode(WorkflowExpression<string> constituentSolicitCodeId, WorkflowExpression<string> bodysolicitCode = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            WorkflowExpression.Validate(bodysolicitCode, nameof(bodysolicitCode), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
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