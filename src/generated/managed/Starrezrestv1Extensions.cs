//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Starrezrestv1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryResponseItem[], ApiConnectionActionConfiguration> SelectEntry(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyaddressTypeId = null, Expression<Func<bodybirthGenderEnumInput>> bodybirthGenderEnum = null, Expression<Func<int>> bodybookingId = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<string>> bodyconferenceEmail = null, Expression<Func<int>> bodycontactId = null, Expression<Func<int>> bodycreatedBySecurityUserId = null, Expression<Func<string>> bodydateCreatedvalue = null, Expression<Func<bodydateCreatedOperatorInput>> bodydateCreatedOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<bool>> bodydirectoryFlagPrivacy = null, Expression<Func<string>> bodydOBvalue = null, Expression<Func<bodydOBOperatorInput>> bodydOBOperator = null, Expression<Func<int>> bodyentryApplicationId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<int>> bodyeventId = null, Expression<Func<bodygenderEnumInput>> bodygenderEnum = null, Expression<Func<string>> bodyiD1 = null, Expression<Func<string>> bodyiD2 = null, Expression<Func<string>> bodyiD3 = null, Expression<Func<int>> bodyiD4 = null, Expression<Func<int>> bodyiD5 = null, Expression<Func<string>> bodylastCheckInOutDatevalue = null, Expression<Func<bodylastCheckInOutDateOperatorInput>> bodylastCheckInOutDateOperator = null, Expression<Func<string>> bodynameFirst = null, Expression<Func<string>> bodynameInitials = null, Expression<Func<string>> bodynameLast = null, Expression<Func<string>> bodynameOther = null, Expression<Func<string>> bodynamePreferred = null, Expression<Func<string>> bodynameSharer = null, Expression<Func<string>> bodynameTitle = null, Expression<Func<string>> bodynameWeb = null, Expression<Func<int>> bodypinNumber = null, Expression<Func<string>> bodyportalAuthProviderUserId = null, Expression<Func<string>> bodyportalEmail = null, Expression<Func<string>> bodyposition = null, Expression<Func<bodypreviousEntryStatusEnumInput>> bodypreviousEntryStatusEnum = null, Expression<Func<bodytaxExemptionEnumInput>> bodytaxExemptionEnum = null, Expression<Func<bool>> bodytesting = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyaddressTypeId = WorkflowExpression.Compile(bodyaddressTypeId, nameof(bodyaddressTypeId), required: false);
            var __workflow_bodybirthGenderEnum = WorkflowExpression.Compile(bodybirthGenderEnum, nameof(bodybirthGenderEnum), required: false);
            var __workflow_bodybookingId = WorkflowExpression.Compile(bodybookingId, nameof(bodybookingId), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyconferenceEmail = WorkflowExpression.Compile(bodyconferenceEmail, nameof(bodyconferenceEmail), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodycreatedBySecurityUserId = WorkflowExpression.Compile(bodycreatedBySecurityUserId, nameof(bodycreatedBySecurityUserId), required: false);
            var __workflow_bodydateCreatedvalue = WorkflowExpression.Compile(bodydateCreatedvalue, nameof(bodydateCreatedvalue), required: false);
            var __workflow_bodydateCreatedOperator = WorkflowExpression.Compile(bodydateCreatedOperator, nameof(bodydateCreatedOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydirectoryFlagPrivacy = WorkflowExpression.Compile(bodydirectoryFlagPrivacy, nameof(bodydirectoryFlagPrivacy), required: false);
            var __workflow_bodydOBvalue = WorkflowExpression.Compile(bodydOBvalue, nameof(bodydOBvalue), required: false);
            var __workflow_bodydOBOperator = WorkflowExpression.Compile(bodydOBOperator, nameof(bodydOBOperator), required: false);
            var __workflow_bodyentryApplicationId = WorkflowExpression.Compile(bodyentryApplicationId, nameof(bodyentryApplicationId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodygenderEnum = WorkflowExpression.Compile(bodygenderEnum, nameof(bodygenderEnum), required: false);
            var __workflow_bodyiD1 = WorkflowExpression.Compile(bodyiD1, nameof(bodyiD1), required: false);
            var __workflow_bodyiD2 = WorkflowExpression.Compile(bodyiD2, nameof(bodyiD2), required: false);
            var __workflow_bodyiD3 = WorkflowExpression.Compile(bodyiD3, nameof(bodyiD3), required: false);
            var __workflow_bodyiD4 = WorkflowExpression.Compile(bodyiD4, nameof(bodyiD4), required: false);
            var __workflow_bodyiD5 = WorkflowExpression.Compile(bodyiD5, nameof(bodyiD5), required: false);
            var __workflow_bodylastCheckInOutDatevalue = WorkflowExpression.Compile(bodylastCheckInOutDatevalue, nameof(bodylastCheckInOutDatevalue), required: false);
            var __workflow_bodylastCheckInOutDateOperator = WorkflowExpression.Compile(bodylastCheckInOutDateOperator, nameof(bodylastCheckInOutDateOperator), required: false);
            var __workflow_bodynameFirst = WorkflowExpression.Compile(bodynameFirst, nameof(bodynameFirst), required: false);
            var __workflow_bodynameInitials = WorkflowExpression.Compile(bodynameInitials, nameof(bodynameInitials), required: false);
            var __workflow_bodynameLast = WorkflowExpression.Compile(bodynameLast, nameof(bodynameLast), required: false);
            var __workflow_bodynameOther = WorkflowExpression.Compile(bodynameOther, nameof(bodynameOther), required: false);
            var __workflow_bodynamePreferred = WorkflowExpression.Compile(bodynamePreferred, nameof(bodynamePreferred), required: false);
            var __workflow_bodynameSharer = WorkflowExpression.Compile(bodynameSharer, nameof(bodynameSharer), required: false);
            var __workflow_bodynameTitle = WorkflowExpression.Compile(bodynameTitle, nameof(bodynameTitle), required: false);
            var __workflow_bodynameWeb = WorkflowExpression.Compile(bodynameWeb, nameof(bodynameWeb), required: false);
            var __workflow_bodypinNumber = WorkflowExpression.Compile(bodypinNumber, nameof(bodypinNumber), required: false);
            var __workflow_bodyportalAuthProviderUserId = WorkflowExpression.Compile(bodyportalAuthProviderUserId, nameof(bodyportalAuthProviderUserId), required: false);
            var __workflow_bodyportalEmail = WorkflowExpression.Compile(bodyportalEmail, nameof(bodyportalEmail), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodypreviousEntryStatusEnum = WorkflowExpression.Compile(bodypreviousEntryStatusEnum, nameof(bodypreviousEntryStatusEnum), required: false);
            var __workflow_bodytaxExemptionEnum = WorkflowExpression.Compile(bodytaxExemptionEnum, nameof(bodytaxExemptionEnum), required: false);
            var __workflow_bodytesting = WorkflowExpression.Compile(bodytesting, nameof(bodytesting), required: false);
            return new DeferredBodyAction<SelectEntryResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaddressTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingId != null)
                {
                    body["BookingID"] = ExpressionConverter.ConvertO(__workflow_bodybookingId);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["CategoryID"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = ExpressionConverter.ConvertO(__workflow_bodyconferenceEmail);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (__workflow_bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (__workflow_bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(__workflow_bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                var dOBObject = new JObject();
                var dOBObjectpropCount = 0;
                if (__workflow_bodydOBvalue != null)
                {
                    dOBObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydOBvalue);
                    dOBObjectpropCount++;
                }

                if (__workflow_bodydOBOperator != null)
                {
                    dOBObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydOBOperator);
                    dOBObjectpropCount++;
                }

                if (dOBObjectpropCount > 0)
                {
                    body["DOB"] = dOBObject;
                    bodypropCount++;
                }

                if (__workflow_bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryApplicationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["EventID"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                if (__workflow_bodygenderEnum != null)
                {
                    body["GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodygenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyiD1 != null)
                {
                    body["ID1"] = ExpressionConverter.ConvertO(__workflow_bodyiD1);
                    bodypropCount++;
                }

                if (__workflow_bodyiD2 != null)
                {
                    body["ID2"] = ExpressionConverter.ConvertO(__workflow_bodyiD2);
                    bodypropCount++;
                }

                if (__workflow_bodyiD3 != null)
                {
                    body["ID3"] = ExpressionConverter.ConvertO(__workflow_bodyiD3);
                    bodypropCount++;
                }

                if (__workflow_bodyiD4 != null)
                {
                    body["ID4"] = ExpressionConverter.ConvertO(__workflow_bodyiD4);
                    bodypropCount++;
                }

                if (__workflow_bodyiD5 != null)
                {
                    body["ID5"] = ExpressionConverter.ConvertO(__workflow_bodyiD5);
                    bodypropCount++;
                }

                var lastCheckInOutDateObject = new JObject();
                var lastCheckInOutDateObjectpropCount = 0;
                if (__workflow_bodylastCheckInOutDatevalue != null)
                {
                    lastCheckInOutDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodylastCheckInOutDatevalue);
                    lastCheckInOutDateObjectpropCount++;
                }

                if (__workflow_bodylastCheckInOutDateOperator != null)
                {
                    lastCheckInOutDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodylastCheckInOutDateOperator);
                    lastCheckInOutDateObjectpropCount++;
                }

                if (lastCheckInOutDateObjectpropCount > 0)
                {
                    body["LastCheckInOutDate"] = lastCheckInOutDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodynameFirst != null)
                {
                    body["NameFirst"] = ExpressionConverter.ConvertO(__workflow_bodynameFirst);
                    bodypropCount++;
                }

                if (__workflow_bodynameInitials != null)
                {
                    body["NameInitials"] = ExpressionConverter.ConvertO(__workflow_bodynameInitials);
                    bodypropCount++;
                }

                if (__workflow_bodynameLast != null)
                {
                    body["NameLast"] = ExpressionConverter.ConvertO(__workflow_bodynameLast);
                    bodypropCount++;
                }

                if (__workflow_bodynameOther != null)
                {
                    body["NameOther"] = ExpressionConverter.ConvertO(__workflow_bodynameOther);
                    bodypropCount++;
                }

                if (__workflow_bodynamePreferred != null)
                {
                    body["NamePreferred"] = ExpressionConverter.ConvertO(__workflow_bodynamePreferred);
                    bodypropCount++;
                }

                if (__workflow_bodynameSharer != null)
                {
                    body["NameSharer"] = ExpressionConverter.ConvertO(__workflow_bodynameSharer);
                    bodypropCount++;
                }

                if (__workflow_bodynameTitle != null)
                {
                    body["NameTitle"] = ExpressionConverter.ConvertO(__workflow_bodynameTitle);
                    bodypropCount++;
                }

                if (__workflow_bodynameWeb != null)
                {
                    body["NameWeb"] = ExpressionConverter.ConvertO(__workflow_bodynameWeb);
                    bodypropCount++;
                }

                if (__workflow_bodypinNumber != null)
                {
                    body["PinNumber"] = ExpressionConverter.ConvertO(__workflow_bodypinNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(__workflow_bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyportalEmail != null)
                {
                    body["PortalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyportalEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["Position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytesting != null)
                {
                    body["Testing"] = ExpressionConverter.ConvertO(__workflow_bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryResponse, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<string>> bodynameFirst, Expression<Func<string>> bodynameLast, Expression<Func<int>> bodyaddressTypeId = null, Expression<Func<bodybirthGenderEnumInput>> bodybirthGenderEnum = null, Expression<Func<int>> bodybookingId = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<string>> bodyconferenceEmail = null, Expression<Func<int>> bodycontactId = null, Expression<Func<bool>> bodydirectoryFlagPrivacy = null, Expression<Func<string>> bodydOB = null, Expression<Func<int>> bodyentryApplicationId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<int>> bodyeventId = null, Expression<Func<bodygenderEnumInput>> bodygenderEnum = null, Expression<Func<string>> bodyiD1 = null, Expression<Func<string>> bodyiD2 = null, Expression<Func<string>> bodyiD3 = null, Expression<Func<int>> bodyiD4 = null, Expression<Func<int>> bodyiD5 = null, Expression<Func<string>> bodylastCheckInOutDate = null, Expression<Func<string>> bodynameInitials = null, Expression<Func<string>> bodynameOther = null, Expression<Func<string>> bodynamePreferred = null, Expression<Func<string>> bodynameSharer = null, Expression<Func<string>> bodynameTitle = null, Expression<Func<string>> bodynameWeb = null, Expression<Func<string>> bodypassword = null, Expression<Func<int>> bodypinNumber = null, Expression<Func<string>> bodyportalAuthProviderUserId = null, Expression<Func<string>> bodyportalEmail = null, Expression<Func<string>> bodyposition = null, Expression<Func<bodypreviousEntryStatusEnumInput>> bodypreviousEntryStatusEnum = null, Expression<Func<bodytaxExemptionEnumInput>> bodytaxExemptionEnum = null, Expression<Func<bool>> bodytesting = null)
        {
            var __workflow_bodynameFirst = WorkflowExpression.Compile(bodynameFirst, nameof(bodynameFirst), required: true);
            var __workflow_bodynameLast = WorkflowExpression.Compile(bodynameLast, nameof(bodynameLast), required: true);
            var __workflow_bodyaddressTypeId = WorkflowExpression.Compile(bodyaddressTypeId, nameof(bodyaddressTypeId), required: false);
            var __workflow_bodybirthGenderEnum = WorkflowExpression.Compile(bodybirthGenderEnum, nameof(bodybirthGenderEnum), required: false);
            var __workflow_bodybookingId = WorkflowExpression.Compile(bodybookingId, nameof(bodybookingId), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyconferenceEmail = WorkflowExpression.Compile(bodyconferenceEmail, nameof(bodyconferenceEmail), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodydirectoryFlagPrivacy = WorkflowExpression.Compile(bodydirectoryFlagPrivacy, nameof(bodydirectoryFlagPrivacy), required: false);
            var __workflow_bodydOB = WorkflowExpression.Compile(bodydOB, nameof(bodydOB), required: false);
            var __workflow_bodyentryApplicationId = WorkflowExpression.Compile(bodyentryApplicationId, nameof(bodyentryApplicationId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodygenderEnum = WorkflowExpression.Compile(bodygenderEnum, nameof(bodygenderEnum), required: false);
            var __workflow_bodyiD1 = WorkflowExpression.Compile(bodyiD1, nameof(bodyiD1), required: false);
            var __workflow_bodyiD2 = WorkflowExpression.Compile(bodyiD2, nameof(bodyiD2), required: false);
            var __workflow_bodyiD3 = WorkflowExpression.Compile(bodyiD3, nameof(bodyiD3), required: false);
            var __workflow_bodyiD4 = WorkflowExpression.Compile(bodyiD4, nameof(bodyiD4), required: false);
            var __workflow_bodyiD5 = WorkflowExpression.Compile(bodyiD5, nameof(bodyiD5), required: false);
            var __workflow_bodylastCheckInOutDate = WorkflowExpression.Compile(bodylastCheckInOutDate, nameof(bodylastCheckInOutDate), required: false);
            var __workflow_bodynameInitials = WorkflowExpression.Compile(bodynameInitials, nameof(bodynameInitials), required: false);
            var __workflow_bodynameOther = WorkflowExpression.Compile(bodynameOther, nameof(bodynameOther), required: false);
            var __workflow_bodynamePreferred = WorkflowExpression.Compile(bodynamePreferred, nameof(bodynamePreferred), required: false);
            var __workflow_bodynameSharer = WorkflowExpression.Compile(bodynameSharer, nameof(bodynameSharer), required: false);
            var __workflow_bodynameTitle = WorkflowExpression.Compile(bodynameTitle, nameof(bodynameTitle), required: false);
            var __workflow_bodynameWeb = WorkflowExpression.Compile(bodynameWeb, nameof(bodynameWeb), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypinNumber = WorkflowExpression.Compile(bodypinNumber, nameof(bodypinNumber), required: false);
            var __workflow_bodyportalAuthProviderUserId = WorkflowExpression.Compile(bodyportalAuthProviderUserId, nameof(bodyportalAuthProviderUserId), required: false);
            var __workflow_bodyportalEmail = WorkflowExpression.Compile(bodyportalEmail, nameof(bodyportalEmail), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodypreviousEntryStatusEnum = WorkflowExpression.Compile(bodypreviousEntryStatusEnum, nameof(bodypreviousEntryStatusEnum), required: false);
            var __workflow_bodytaxExemptionEnum = WorkflowExpression.Compile(bodytaxExemptionEnum, nameof(bodytaxExemptionEnum), required: false);
            var __workflow_bodytesting = WorkflowExpression.Compile(bodytesting, nameof(bodytesting), required: false);
            return new DeferredBodyAction<CreateEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaddressTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingId != null)
                {
                    body["BookingID"] = ExpressionConverter.ConvertO(__workflow_bodybookingId);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["CategoryID"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = ExpressionConverter.ConvertO(__workflow_bodyconferenceEmail);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(__workflow_bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                if (__workflow_bodydOB != null)
                {
                    body["DOB"] = ExpressionConverter.ConvertO(__workflow_bodydOB);
                    bodypropCount++;
                }

                if (__workflow_bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryApplicationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["EventID"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                if (__workflow_bodygenderEnum != null)
                {
                    body["GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodygenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyiD1 != null)
                {
                    body["ID1"] = ExpressionConverter.ConvertO(__workflow_bodyiD1);
                    bodypropCount++;
                }

                if (__workflow_bodyiD2 != null)
                {
                    body["ID2"] = ExpressionConverter.ConvertO(__workflow_bodyiD2);
                    bodypropCount++;
                }

                if (__workflow_bodyiD3 != null)
                {
                    body["ID3"] = ExpressionConverter.ConvertO(__workflow_bodyiD3);
                    bodypropCount++;
                }

                if (__workflow_bodyiD4 != null)
                {
                    body["ID4"] = ExpressionConverter.ConvertO(__workflow_bodyiD4);
                    bodypropCount++;
                }

                if (__workflow_bodyiD5 != null)
                {
                    body["ID5"] = ExpressionConverter.ConvertO(__workflow_bodyiD5);
                    bodypropCount++;
                }

                if (__workflow_bodylastCheckInOutDate != null)
                {
                    body["LastCheckInOutDate"] = ExpressionConverter.ConvertO(__workflow_bodylastCheckInOutDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["NameFirst"] = ExpressionConverter.ConvertO(__workflow_bodynameFirst);
                if (__workflow_bodynameInitials != null)
                {
                    body["NameInitials"] = ExpressionConverter.ConvertO(__workflow_bodynameInitials);
                    bodypropCount++;
                }

                bodypropCount++;
                body["NameLast"] = ExpressionConverter.ConvertO(__workflow_bodynameLast);
                if (__workflow_bodynameOther != null)
                {
                    body["NameOther"] = ExpressionConverter.ConvertO(__workflow_bodynameOther);
                    bodypropCount++;
                }

                if (__workflow_bodynamePreferred != null)
                {
                    body["NamePreferred"] = ExpressionConverter.ConvertO(__workflow_bodynamePreferred);
                    bodypropCount++;
                }

                if (__workflow_bodynameSharer != null)
                {
                    body["NameSharer"] = ExpressionConverter.ConvertO(__workflow_bodynameSharer);
                    bodypropCount++;
                }

                if (__workflow_bodynameTitle != null)
                {
                    body["NameTitle"] = ExpressionConverter.ConvertO(__workflow_bodynameTitle);
                    bodypropCount++;
                }

                if (__workflow_bodynameWeb != null)
                {
                    body["NameWeb"] = ExpressionConverter.ConvertO(__workflow_bodynameWeb);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypinNumber != null)
                {
                    body["PinNumber"] = ExpressionConverter.ConvertO(__workflow_bodypinNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(__workflow_bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyportalEmail != null)
                {
                    body["PortalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyportalEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["Position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytesting != null)
                {
                    body["Testing"] = ExpressionConverter.ConvertO(__workflow_bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryResponse, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<int>> entryId, Expression<Func<int>> bodyaddressTypeId = null, Expression<Func<bodybirthGenderEnumInput>> bodybirthGenderEnum = null, Expression<Func<int>> bodybookingId = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<string>> bodyconferenceEmail = null, Expression<Func<int>> bodycontactId = null, Expression<Func<bool>> bodydirectoryFlagPrivacy = null, Expression<Func<string>> bodydOB = null, Expression<Func<int>> bodyentryApplicationId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<int>> bodyeventId = null, Expression<Func<bodygenderEnumInput>> bodygenderEnum = null, Expression<Func<string>> bodyiD1 = null, Expression<Func<string>> bodyiD2 = null, Expression<Func<string>> bodyiD3 = null, Expression<Func<int>> bodyiD4 = null, Expression<Func<int>> bodyiD5 = null, Expression<Func<string>> bodylastCheckInOutDate = null, Expression<Func<string>> bodynameFirst = null, Expression<Func<string>> bodynameInitials = null, Expression<Func<string>> bodynameLast = null, Expression<Func<string>> bodynameOther = null, Expression<Func<string>> bodynamePreferred = null, Expression<Func<string>> bodynameSharer = null, Expression<Func<string>> bodynameTitle = null, Expression<Func<string>> bodynameWeb = null, Expression<Func<string>> bodypassword = null, Expression<Func<int>> bodypinNumber = null, Expression<Func<string>> bodyportalAuthProviderUserId = null, Expression<Func<string>> bodyportalEmail = null, Expression<Func<string>> bodyposition = null, Expression<Func<bodypreviousEntryStatusEnumInput>> bodypreviousEntryStatusEnum = null, Expression<Func<bodytaxExemptionEnumInput>> bodytaxExemptionEnum = null, Expression<Func<bool>> bodytesting = null)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            var __workflow_bodyaddressTypeId = WorkflowExpression.Compile(bodyaddressTypeId, nameof(bodyaddressTypeId), required: false);
            var __workflow_bodybirthGenderEnum = WorkflowExpression.Compile(bodybirthGenderEnum, nameof(bodybirthGenderEnum), required: false);
            var __workflow_bodybookingId = WorkflowExpression.Compile(bodybookingId, nameof(bodybookingId), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyconferenceEmail = WorkflowExpression.Compile(bodyconferenceEmail, nameof(bodyconferenceEmail), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodydirectoryFlagPrivacy = WorkflowExpression.Compile(bodydirectoryFlagPrivacy, nameof(bodydirectoryFlagPrivacy), required: false);
            var __workflow_bodydOB = WorkflowExpression.Compile(bodydOB, nameof(bodydOB), required: false);
            var __workflow_bodyentryApplicationId = WorkflowExpression.Compile(bodyentryApplicationId, nameof(bodyentryApplicationId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodygenderEnum = WorkflowExpression.Compile(bodygenderEnum, nameof(bodygenderEnum), required: false);
            var __workflow_bodyiD1 = WorkflowExpression.Compile(bodyiD1, nameof(bodyiD1), required: false);
            var __workflow_bodyiD2 = WorkflowExpression.Compile(bodyiD2, nameof(bodyiD2), required: false);
            var __workflow_bodyiD3 = WorkflowExpression.Compile(bodyiD3, nameof(bodyiD3), required: false);
            var __workflow_bodyiD4 = WorkflowExpression.Compile(bodyiD4, nameof(bodyiD4), required: false);
            var __workflow_bodyiD5 = WorkflowExpression.Compile(bodyiD5, nameof(bodyiD5), required: false);
            var __workflow_bodylastCheckInOutDate = WorkflowExpression.Compile(bodylastCheckInOutDate, nameof(bodylastCheckInOutDate), required: false);
            var __workflow_bodynameFirst = WorkflowExpression.Compile(bodynameFirst, nameof(bodynameFirst), required: false);
            var __workflow_bodynameInitials = WorkflowExpression.Compile(bodynameInitials, nameof(bodynameInitials), required: false);
            var __workflow_bodynameLast = WorkflowExpression.Compile(bodynameLast, nameof(bodynameLast), required: false);
            var __workflow_bodynameOther = WorkflowExpression.Compile(bodynameOther, nameof(bodynameOther), required: false);
            var __workflow_bodynamePreferred = WorkflowExpression.Compile(bodynamePreferred, nameof(bodynamePreferred), required: false);
            var __workflow_bodynameSharer = WorkflowExpression.Compile(bodynameSharer, nameof(bodynameSharer), required: false);
            var __workflow_bodynameTitle = WorkflowExpression.Compile(bodynameTitle, nameof(bodynameTitle), required: false);
            var __workflow_bodynameWeb = WorkflowExpression.Compile(bodynameWeb, nameof(bodynameWeb), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypinNumber = WorkflowExpression.Compile(bodypinNumber, nameof(bodypinNumber), required: false);
            var __workflow_bodyportalAuthProviderUserId = WorkflowExpression.Compile(bodyportalAuthProviderUserId, nameof(bodyportalAuthProviderUserId), required: false);
            var __workflow_bodyportalEmail = WorkflowExpression.Compile(bodyportalEmail, nameof(bodyportalEmail), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodypreviousEntryStatusEnum = WorkflowExpression.Compile(bodypreviousEntryStatusEnum, nameof(bodypreviousEntryStatusEnum), required: false);
            var __workflow_bodytaxExemptionEnum = WorkflowExpression.Compile(bodytaxExemptionEnum, nameof(bodytaxExemptionEnum), required: false);
            var __workflow_bodytesting = WorkflowExpression.Compile(bodytesting, nameof(bodytesting), required: false);
            return new DeferredBodyAction<UpdateEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entry.json/{0}", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaddressTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingId != null)
                {
                    body["BookingID"] = ExpressionConverter.ConvertO(__workflow_bodybookingId);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["CategoryID"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = ExpressionConverter.ConvertO(__workflow_bodyconferenceEmail);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(__workflow_bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                if (__workflow_bodydOB != null)
                {
                    body["DOB"] = ExpressionConverter.ConvertO(__workflow_bodydOB);
                    bodypropCount++;
                }

                if (__workflow_bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryApplicationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["EventID"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                if (__workflow_bodygenderEnum != null)
                {
                    body["GenderEnum"] = ExpressionConverter.ConvertO(__workflow_bodygenderEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyiD1 != null)
                {
                    body["ID1"] = ExpressionConverter.ConvertO(__workflow_bodyiD1);
                    bodypropCount++;
                }

                if (__workflow_bodyiD2 != null)
                {
                    body["ID2"] = ExpressionConverter.ConvertO(__workflow_bodyiD2);
                    bodypropCount++;
                }

                if (__workflow_bodyiD3 != null)
                {
                    body["ID3"] = ExpressionConverter.ConvertO(__workflow_bodyiD3);
                    bodypropCount++;
                }

                if (__workflow_bodyiD4 != null)
                {
                    body["ID4"] = ExpressionConverter.ConvertO(__workflow_bodyiD4);
                    bodypropCount++;
                }

                if (__workflow_bodyiD5 != null)
                {
                    body["ID5"] = ExpressionConverter.ConvertO(__workflow_bodyiD5);
                    bodypropCount++;
                }

                if (__workflow_bodylastCheckInOutDate != null)
                {
                    body["LastCheckInOutDate"] = ExpressionConverter.ConvertO(__workflow_bodylastCheckInOutDate);
                    bodypropCount++;
                }

                if (__workflow_bodynameFirst != null)
                {
                    body["NameFirst"] = ExpressionConverter.ConvertO(__workflow_bodynameFirst);
                    bodypropCount++;
                }

                if (__workflow_bodynameInitials != null)
                {
                    body["NameInitials"] = ExpressionConverter.ConvertO(__workflow_bodynameInitials);
                    bodypropCount++;
                }

                if (__workflow_bodynameLast != null)
                {
                    body["NameLast"] = ExpressionConverter.ConvertO(__workflow_bodynameLast);
                    bodypropCount++;
                }

                if (__workflow_bodynameOther != null)
                {
                    body["NameOther"] = ExpressionConverter.ConvertO(__workflow_bodynameOther);
                    bodypropCount++;
                }

                if (__workflow_bodynamePreferred != null)
                {
                    body["NamePreferred"] = ExpressionConverter.ConvertO(__workflow_bodynamePreferred);
                    bodypropCount++;
                }

                if (__workflow_bodynameSharer != null)
                {
                    body["NameSharer"] = ExpressionConverter.ConvertO(__workflow_bodynameSharer);
                    bodypropCount++;
                }

                if (__workflow_bodynameTitle != null)
                {
                    body["NameTitle"] = ExpressionConverter.ConvertO(__workflow_bodynameTitle);
                    bodypropCount++;
                }

                if (__workflow_bodynameWeb != null)
                {
                    body["NameWeb"] = ExpressionConverter.ConvertO(__workflow_bodynameWeb);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["Password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypinNumber != null)
                {
                    body["PinNumber"] = ExpressionConverter.ConvertO(__workflow_bodypinNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(__workflow_bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyportalEmail != null)
                {
                    body["PortalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyportalEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["Position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytesting != null)
                {
                    body["Testing"] = ExpressionConverter.ConvertO(__workflow_bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Delete(Expression<Func<tableNameInput>> tableName, Expression<Func<int>> rowId)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/delete/{0}.json/{1}", __workflow_tableName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryCustomFieldResponseItem[], ApiConnectionActionConfiguration> SelectEntryCustomField(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodycustomFieldDefinitionId = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<int>> bodyentryCustomFieldId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<bodyfieldDataTypeEnumInput>> bodyfieldDataTypeEnum = null, Expression<Func<bool>> bodyvalueBoolean = null, Expression<Func<string>> bodyvalueDatevalue = null, Expression<Func<bodyvalueDateOperatorInput>> bodyvalueDateOperator = null, Expression<Func<int>> bodyvalueInteger = null, Expression<Func<double>> bodyvalueMoney = null, Expression<Func<string>> bodyvalueString = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodycustomFieldDefinitionId = WorkflowExpression.Compile(bodycustomFieldDefinitionId, nameof(bodycustomFieldDefinitionId), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodyentryCustomFieldId = WorkflowExpression.Compile(bodyentryCustomFieldId, nameof(bodyentryCustomFieldId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyfieldDataTypeEnum = WorkflowExpression.Compile(bodyfieldDataTypeEnum, nameof(bodyfieldDataTypeEnum), required: false);
            var __workflow_bodyvalueBoolean = WorkflowExpression.Compile(bodyvalueBoolean, nameof(bodyvalueBoolean), required: false);
            var __workflow_bodyvalueDatevalue = WorkflowExpression.Compile(bodyvalueDatevalue, nameof(bodyvalueDatevalue), required: false);
            var __workflow_bodyvalueDateOperator = WorkflowExpression.Compile(bodyvalueDateOperator, nameof(bodyvalueDateOperator), required: false);
            var __workflow_bodyvalueInteger = WorkflowExpression.Compile(bodyvalueInteger, nameof(bodyvalueInteger), required: false);
            var __workflow_bodyvalueMoney = WorkflowExpression.Compile(bodyvalueMoney, nameof(bodyvalueMoney), required: false);
            var __workflow_bodyvalueString = WorkflowExpression.Compile(bodyvalueString, nameof(bodyvalueString), required: false);
            return new DeferredBodyAction<SelectEntryCustomFieldResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryCustomField.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldDefinitionId != null)
                {
                    body["CustomFieldDefinitionID"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldDefinitionId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyentryCustomFieldId != null)
                {
                    body["EntryCustomFieldID"] = ExpressionConverter.ConvertO(__workflow_bodyentryCustomFieldId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldDataTypeEnum != null)
                {
                    body["FieldDataTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyfieldDataTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueBoolean != null)
                {
                    body["ValueBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyvalueBoolean);
                    bodypropCount++;
                }

                var valueDateObject = new JObject();
                var valueDateObjectpropCount = 0;
                if (__workflow_bodyvalueDatevalue != null)
                {
                    valueDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyvalueDatevalue);
                    valueDateObjectpropCount++;
                }

                if (__workflow_bodyvalueDateOperator != null)
                {
                    valueDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyvalueDateOperator);
                    valueDateObjectpropCount++;
                }

                if (valueDateObjectpropCount > 0)
                {
                    body["ValueDate"] = valueDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyvalueInteger != null)
                {
                    body["ValueInteger"] = ExpressionConverter.ConvertO(__workflow_bodyvalueInteger);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueMoney != null)
                {
                    body["ValueMoney"] = ExpressionConverter.ConvertO(__workflow_bodyvalueMoney);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueString != null)
                {
                    body["ValueString"] = ExpressionConverter.ConvertO(__workflow_bodyvalueString);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryCustomFieldResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryCustomFieldResponse, ApiConnectionActionConfiguration> UpdateEntryCustomField(Expression<Func<int>> entryCustomFieldId, Expression<Func<int>> bodycustomFieldDefinitionId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<bodyfieldDataTypeEnumInput>> bodyfieldDataTypeEnum = null, Expression<Func<bool>> bodyvalueBoolean = null, Expression<Func<string>> bodyvalueDate = null, Expression<Func<int>> bodyvalueInteger = null, Expression<Func<double>> bodyvalueMoney = null, Expression<Func<string>> bodyvalueString = null)
        {
            var __workflow_entryCustomFieldId = WorkflowExpression.Compile(entryCustomFieldId, nameof(entryCustomFieldId), required: true);
            var __workflow_bodycustomFieldDefinitionId = WorkflowExpression.Compile(bodycustomFieldDefinitionId, nameof(bodycustomFieldDefinitionId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyfieldDataTypeEnum = WorkflowExpression.Compile(bodyfieldDataTypeEnum, nameof(bodyfieldDataTypeEnum), required: false);
            var __workflow_bodyvalueBoolean = WorkflowExpression.Compile(bodyvalueBoolean, nameof(bodyvalueBoolean), required: false);
            var __workflow_bodyvalueDate = WorkflowExpression.Compile(bodyvalueDate, nameof(bodyvalueDate), required: false);
            var __workflow_bodyvalueInteger = WorkflowExpression.Compile(bodyvalueInteger, nameof(bodyvalueInteger), required: false);
            var __workflow_bodyvalueMoney = WorkflowExpression.Compile(bodyvalueMoney, nameof(bodyvalueMoney), required: false);
            var __workflow_bodyvalueString = WorkflowExpression.Compile(bodyvalueString, nameof(bodyvalueString), required: false);
            return new DeferredBodyAction<UpdateEntryCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryCustomField.json/{0}", __workflow_entryCustomFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomFieldDefinitionId != null)
                {
                    body["CustomFieldDefinitionID"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldDefinitionId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldDataTypeEnum != null)
                {
                    body["FieldDataTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyfieldDataTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueBoolean != null)
                {
                    body["ValueBoolean"] = ExpressionConverter.ConvertO(__workflow_bodyvalueBoolean);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueDate != null)
                {
                    body["ValueDate"] = ExpressionConverter.ConvertO(__workflow_bodyvalueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueInteger != null)
                {
                    body["ValueInteger"] = ExpressionConverter.ConvertO(__workflow_bodyvalueInteger);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueMoney != null)
                {
                    body["ValueMoney"] = ExpressionConverter.ConvertO(__workflow_bodyvalueMoney);
                    bodypropCount++;
                }

                if (__workflow_bodyvalueString != null)
                {
                    body["ValueString"] = ExpressionConverter.ConvertO(__workflow_bodyvalueString);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermResponseItem[], ApiConnectionActionConfiguration> SelectTerm(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodyactiveDateClosevalue = null, Expression<Func<bodyactiveDateCloseOperatorInput>> bodyactiveDateCloseOperator = null, Expression<Func<string>> bodyactiveDateOpenvalue = null, Expression<Func<bodyactiveDateOpenOperatorInput>> bodyactiveDateOpenOperator = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodyrecordTypeEnumInput>> bodyrecordTypeEnum = null, Expression<Func<string>> bodytermCode = null, Expression<Func<int>> bodytermId = null, Expression<Func<int>> bodytermTypeId = null, Expression<Func<string>> bodywebDescription = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyactive = WorkflowExpression.Compile(bodyactive, nameof(bodyactive), required: false);
            var __workflow_bodyactiveDateClosevalue = WorkflowExpression.Compile(bodyactiveDateClosevalue, nameof(bodyactiveDateClosevalue), required: false);
            var __workflow_bodyactiveDateCloseOperator = WorkflowExpression.Compile(bodyactiveDateCloseOperator, nameof(bodyactiveDateCloseOperator), required: false);
            var __workflow_bodyactiveDateOpenvalue = WorkflowExpression.Compile(bodyactiveDateOpenvalue, nameof(bodyactiveDateOpenvalue), required: false);
            var __workflow_bodyactiveDateOpenOperator = WorkflowExpression.Compile(bodyactiveDateOpenOperator, nameof(bodyactiveDateOpenOperator), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyrecordTypeEnum = WorkflowExpression.Compile(bodyrecordTypeEnum, nameof(bodyrecordTypeEnum), required: false);
            var __workflow_bodytermCode = WorkflowExpression.Compile(bodytermCode, nameof(bodytermCode), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodytermTypeId = WorkflowExpression.Compile(bodytermTypeId, nameof(bodytermTypeId), required: false);
            var __workflow_bodywebDescription = WorkflowExpression.Compile(bodywebDescription, nameof(bodywebDescription), required: false);
            return new DeferredBodyAction<SelectTermResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Term.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyactive != null)
                {
                    body["Active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                var activeDateCloseObject = new JObject();
                var activeDateCloseObjectpropCount = 0;
                if (__workflow_bodyactiveDateClosevalue != null)
                {
                    activeDateCloseObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateClosevalue);
                    activeDateCloseObjectpropCount++;
                }

                if (__workflow_bodyactiveDateCloseOperator != null)
                {
                    activeDateCloseObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateCloseOperator);
                    activeDateCloseObjectpropCount++;
                }

                if (activeDateCloseObjectpropCount > 0)
                {
                    body["ActiveDateClose"] = activeDateCloseObject;
                    bodypropCount++;
                }

                var activeDateOpenObject = new JObject();
                var activeDateOpenObjectpropCount = 0;
                if (__workflow_bodyactiveDateOpenvalue != null)
                {
                    activeDateOpenObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateOpenvalue);
                    activeDateOpenObjectpropCount++;
                }

                if (__workflow_bodyactiveDateOpenOperator != null)
                {
                    activeDateOpenObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateOpenOperator);
                    activeDateOpenObjectpropCount++;
                }

                if (activeDateOpenObjectpropCount > 0)
                {
                    body["ActiveDateOpen"] = activeDateOpenObject;
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["CategoryID"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodytermCode != null)
                {
                    body["TermCode"] = ExpressionConverter.ConvertO(__workflow_bodytermCode);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodytermTypeId != null)
                {
                    body["TermTypeID"] = ExpressionConverter.ConvertO(__workflow_bodytermTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodywebDescription != null)
                {
                    body["WebDescription"] = ExpressionConverter.ConvertO(__workflow_bodywebDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectTermResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryAddressResponseItem[], ApiConnectionActionConfiguration> SelectEntryAddress(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodyactiveDateEndvalue = null, Expression<Func<bodyactiveDateEndOperatorInput>> bodyactiveDateEndOperator = null, Expression<Func<string>> bodyactiveDateStartvalue = null, Expression<Func<bodyactiveDateStartOperatorInput>> bodyactiveDateStartOperator = null, Expression<Func<int>> bodyaddressTypeId = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycontactName = null, Expression<Func<string>> bodycontactName2 = null, Expression<Func<int>> bodycountryId = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyentryAddressId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyphoneMobileCell = null, Expression<Func<string>> bodyphoneOther = null, Expression<Func<string>> bodyphoneOther2 = null, Expression<Func<string>> bodyreference = null, Expression<Func<string>> bodyrelationship = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodyzipPostcode = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyactiveDateEndvalue = WorkflowExpression.Compile(bodyactiveDateEndvalue, nameof(bodyactiveDateEndvalue), required: false);
            var __workflow_bodyactiveDateEndOperator = WorkflowExpression.Compile(bodyactiveDateEndOperator, nameof(bodyactiveDateEndOperator), required: false);
            var __workflow_bodyactiveDateStartvalue = WorkflowExpression.Compile(bodyactiveDateStartvalue, nameof(bodyactiveDateStartvalue), required: false);
            var __workflow_bodyactiveDateStartOperator = WorkflowExpression.Compile(bodyactiveDateStartOperator, nameof(bodyactiveDateStartOperator), required: false);
            var __workflow_bodyaddressTypeId = WorkflowExpression.Compile(bodyaddressTypeId, nameof(bodyaddressTypeId), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: false);
            var __workflow_bodycontactName2 = WorkflowExpression.Compile(bodycontactName2, nameof(bodycontactName2), required: false);
            var __workflow_bodycountryId = WorkflowExpression.Compile(bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyentryAddressId = WorkflowExpression.Compile(bodyentryAddressId, nameof(bodyentryAddressId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyphoneMobileCell = WorkflowExpression.Compile(bodyphoneMobileCell, nameof(bodyphoneMobileCell), required: false);
            var __workflow_bodyphoneOther = WorkflowExpression.Compile(bodyphoneOther, nameof(bodyphoneOther), required: false);
            var __workflow_bodyphoneOther2 = WorkflowExpression.Compile(bodyphoneOther2, nameof(bodyphoneOther2), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyrelationship = WorkflowExpression.Compile(bodyrelationship, nameof(bodyrelationship), required: false);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodystateProvince = WorkflowExpression.Compile(bodystateProvince, nameof(bodystateProvince), required: false);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodystreet2 = WorkflowExpression.Compile(bodystreet2, nameof(bodystreet2), required: false);
            var __workflow_bodyzipPostcode = WorkflowExpression.Compile(bodyzipPostcode, nameof(bodyzipPostcode), required: false);
            return new DeferredBodyAction<SelectEntryAddressResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                var activeDateEndObject = new JObject();
                var activeDateEndObjectpropCount = 0;
                if (__workflow_bodyactiveDateEndvalue != null)
                {
                    activeDateEndObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateEndvalue);
                    activeDateEndObjectpropCount++;
                }

                if (__workflow_bodyactiveDateEndOperator != null)
                {
                    activeDateEndObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateEndOperator);
                    activeDateEndObjectpropCount++;
                }

                if (activeDateEndObjectpropCount > 0)
                {
                    body["ActiveDateEnd"] = activeDateEndObject;
                    bodypropCount++;
                }

                var activeDateStartObject = new JObject();
                var activeDateStartObjectpropCount = 0;
                if (__workflow_bodyactiveDateStartvalue != null)
                {
                    activeDateStartObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateStartvalue);
                    activeDateStartObjectpropCount++;
                }

                if (__workflow_bodyactiveDateStartOperator != null)
                {
                    activeDateStartObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateStartOperator);
                    activeDateStartObjectpropCount++;
                }

                if (activeDateStartObjectpropCount > 0)
                {
                    body["ActiveDateStart"] = activeDateStartObject;
                    bodypropCount++;
                }

                if (__workflow_bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaddressTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactName2 != null)
                {
                    body["ContactName2"] = ExpressionConverter.ConvertO(__workflow_bodycontactName2);
                    bodypropCount++;
                }

                if (__workflow_bodycountryId != null)
                {
                    body["CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyentryAddressId != null)
                {
                    body["EntryAddressID"] = ExpressionConverter.ConvertO(__workflow_bodyentryAddressId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["Phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneMobileCell != null)
                {
                    body["PhoneMobileCell"] = ExpressionConverter.ConvertO(__workflow_bodyphoneMobileCell);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneOther != null)
                {
                    body["PhoneOther"] = ExpressionConverter.ConvertO(__workflow_bodyphoneOther);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneOther2 != null)
                {
                    body["PhoneOther2"] = ExpressionConverter.ConvertO(__workflow_bodyphoneOther2);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["Reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyrelationship != null)
                {
                    body["Relationship"] = ExpressionConverter.ConvertO(__workflow_bodyrelationship);
                    bodypropCount++;
                }

                if (__workflow_bodysalutation != null)
                {
                    body["Salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodystateProvince != null)
                {
                    body["StateProvince"] = ExpressionConverter.ConvertO(__workflow_bodystateProvince);
                    bodypropCount++;
                }

                if (__workflow_bodystreet != null)
                {
                    body["Street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodystreet2 != null)
                {
                    body["Street2"] = ExpressionConverter.ConvertO(__workflow_bodystreet2);
                    bodypropCount++;
                }

                if (__workflow_bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryAddressResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryAddressResponse, ApiConnectionActionConfiguration> UpdateEntryAddress(Expression<Func<int>> entryAddressId, Expression<Func<string>> bodyactiveDateEnd = null, Expression<Func<string>> bodyactiveDateStart = null, Expression<Func<int>> bodyaddressTypeId = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycontactName = null, Expression<Func<string>> bodycontactName2 = null, Expression<Func<int>> bodycountryId = null, Expression<Func<string>> bodyemail = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodyphoneMobileCell = null, Expression<Func<string>> bodyphoneOther = null, Expression<Func<string>> bodyphoneOther2 = null, Expression<Func<string>> bodyreference = null, Expression<Func<string>> bodyrelationship = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodyzipPostcode = null)
        {
            var __workflow_entryAddressId = WorkflowExpression.Compile(entryAddressId, nameof(entryAddressId), required: true);
            var __workflow_bodyactiveDateEnd = WorkflowExpression.Compile(bodyactiveDateEnd, nameof(bodyactiveDateEnd), required: false);
            var __workflow_bodyactiveDateStart = WorkflowExpression.Compile(bodyactiveDateStart, nameof(bodyactiveDateStart), required: false);
            var __workflow_bodyaddressTypeId = WorkflowExpression.Compile(bodyaddressTypeId, nameof(bodyaddressTypeId), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: false);
            var __workflow_bodycontactName2 = WorkflowExpression.Compile(bodycontactName2, nameof(bodycontactName2), required: false);
            var __workflow_bodycountryId = WorkflowExpression.Compile(bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyphoneMobileCell = WorkflowExpression.Compile(bodyphoneMobileCell, nameof(bodyphoneMobileCell), required: false);
            var __workflow_bodyphoneOther = WorkflowExpression.Compile(bodyphoneOther, nameof(bodyphoneOther), required: false);
            var __workflow_bodyphoneOther2 = WorkflowExpression.Compile(bodyphoneOther2, nameof(bodyphoneOther2), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyrelationship = WorkflowExpression.Compile(bodyrelationship, nameof(bodyrelationship), required: false);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodystateProvince = WorkflowExpression.Compile(bodystateProvince, nameof(bodystateProvince), required: false);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodystreet2 = WorkflowExpression.Compile(bodystreet2, nameof(bodystreet2), required: false);
            var __workflow_bodyzipPostcode = WorkflowExpression.Compile(bodyzipPostcode, nameof(bodyzipPostcode), required: false);
            return new DeferredBodyAction<UpdateEntryAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryAddress.json/{0}", __workflow_entryAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyactiveDateEnd != null)
                {
                    body["ActiveDateEnd"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodyactiveDateStart != null)
                {
                    body["ActiveDateStart"] = ExpressionConverter.ConvertO(__workflow_bodyactiveDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaddressTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactName2 != null)
                {
                    body["ContactName2"] = ExpressionConverter.ConvertO(__workflow_bodycontactName2);
                    bodypropCount++;
                }

                if (__workflow_bodycountryId != null)
                {
                    body["CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryId);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["Phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneMobileCell != null)
                {
                    body["PhoneMobileCell"] = ExpressionConverter.ConvertO(__workflow_bodyphoneMobileCell);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneOther != null)
                {
                    body["PhoneOther"] = ExpressionConverter.ConvertO(__workflow_bodyphoneOther);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneOther2 != null)
                {
                    body["PhoneOther2"] = ExpressionConverter.ConvertO(__workflow_bodyphoneOther2);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["Reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyrelationship != null)
                {
                    body["Relationship"] = ExpressionConverter.ConvertO(__workflow_bodyrelationship);
                    bodypropCount++;
                }

                if (__workflow_bodysalutation != null)
                {
                    body["Salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodystateProvince != null)
                {
                    body["StateProvince"] = ExpressionConverter.ConvertO(__workflow_bodystateProvince);
                    bodypropCount++;
                }

                if (__workflow_bodystreet != null)
                {
                    body["Street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodystreet2 != null)
                {
                    body["Street2"] = ExpressionConverter.ConvertO(__workflow_bodystreet2);
                    bodypropCount++;
                }

                if (__workflow_bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryApplicationResponseItem[], ApiConnectionActionConfiguration> SelectEntryApplication(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bodyallocateOptionEnumInput>> bodyallocateOptionEnum = null, Expression<Func<string>> bodyapplicationDatevalue = null, Expression<Func<bodyapplicationDateOperatorInput>> bodyapplicationDateOperator = null, Expression<Func<int>> bodyapplicationStatusId = null, Expression<Func<string>> bodycancelDatevalue = null, Expression<Func<bodycancelDateOperatorInput>> bodycancelDateOperator = null, Expression<Func<int>> bodyclassificationId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycommentsInternal = null, Expression<Func<string>> bodycompleteDatevalue = null, Expression<Func<bodycompleteDateOperatorInput>> bodycompleteDateOperator = null, Expression<Func<string>> bodycontractSignedDatevalue = null, Expression<Func<bodycontractSignedDateOperatorInput>> bodycontractSignedDateOperator = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomDate3value = null, Expression<Func<bodycustomDate3OperatorInput>> bodycustomDate3Operator = null, Expression<Func<string>> bodycustomDate4value = null, Expression<Func<bodycustomDate4OperatorInput>> bodycustomDate4Operator = null, Expression<Func<string>> bodydateCreatedvalue = null, Expression<Func<bodydateCreatedOperatorInput>> bodydateCreatedOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodyenquiryDatevalue = null, Expression<Func<bodyenquiryDateOperatorInput>> bodyenquiryDateOperator = null, Expression<Func<int>> bodyentryApplicationId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyexpectedArrivalDatevalue = null, Expression<Func<bodyexpectedArrivalDateOperatorInput>> bodyexpectedArrivalDateOperator = null, Expression<Func<string>> bodyexpectedArrivalDateLatestvalue = null, Expression<Func<bodyexpectedArrivalDateLatestOperatorInput>> bodyexpectedArrivalDateLatestOperator = null, Expression<Func<string>> bodyexpectedDepartureDatevalue = null, Expression<Func<bodyexpectedDepartureDateOperatorInput>> bodyexpectedDepartureDateOperator = null, Expression<Func<string>> bodyofferedDatevalue = null, Expression<Func<bodyofferedDateOperatorInput>> bodyofferedDateOperator = null, Expression<Func<string>> bodyofferReplyDatevalue = null, Expression<Func<bodyofferReplyDateOperatorInput>> bodyofferReplyDateOperator = null, Expression<Func<bodyofferReplyEnumInput>> bodyofferReplyEnum = null, Expression<Func<string>> bodyofferReplyReason = null, Expression<Func<string>> bodyofferSentDatevalue = null, Expression<Func<bodyofferSentDateOperatorInput>> bodyofferSentDateOperator = null, Expression<Func<bool>> bodyportalTrackingOnly = null, Expression<Func<string>> bodypreferenceComments = null, Expression<Func<string>> bodyrating = null, Expression<Func<string>> bodyreceivedDatevalue = null, Expression<Func<bodyreceivedDateOperatorInput>> bodyreceivedDateOperator = null, Expression<Func<bool>> bodyreceivedDeposit = null, Expression<Func<bool>> bodyreceivedDepositWaived = null, Expression<Func<int>> bodyreceivedDepositPaymentId = null, Expression<Func<int>> bodyreceivedDepositWebPaymentId = null, Expression<Func<double>> bodyreceivedDepositAmount = null, Expression<Func<string>> bodyreceivedDepositDatevalue = null, Expression<Func<bodyreceivedDepositDateOperatorInput>> bodyreceivedDepositDateOperator = null, Expression<Func<bool>> bodyreceivedFee = null, Expression<Func<int>> bodyreceivedFeePaymentId = null, Expression<Func<int>> bodyreceivedFeeWebPaymentId = null, Expression<Func<double>> bodyreceivedFeeAmount = null, Expression<Func<string>> bodyreceivedFeeDatevalue = null, Expression<Func<bodyreceivedFeeDateOperatorInput>> bodyreceivedFeeDateOperator = null, Expression<Func<string>> bodyreceivedPhotoDatevalue = null, Expression<Func<bodyreceivedPhotoDateOperatorInput>> bodyreceivedPhotoDateOperator = null, Expression<Func<bool>> bodyreturning = null, Expression<Func<string>> bodyroomMateDescription = null, Expression<Func<int>> bodyroommateGroupId = null, Expression<Func<int>> bodyroomMateGroupSortOrder = null, Expression<Func<bool>> bodyroomMateShowInSearch = null, Expression<Func<string>> bodyroomPreferenceComments = null, Expression<Func<int>> bodyroomSelectionNumber = null, Expression<Func<string>> bodyroomSelectionTimeslot = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodytermId = null, Expression<Func<bool>> bodyweb = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyallocateOptionEnum = WorkflowExpression.Compile(bodyallocateOptionEnum, nameof(bodyallocateOptionEnum), required: false);
            var __workflow_bodyapplicationDatevalue = WorkflowExpression.Compile(bodyapplicationDatevalue, nameof(bodyapplicationDatevalue), required: false);
            var __workflow_bodyapplicationDateOperator = WorkflowExpression.Compile(bodyapplicationDateOperator, nameof(bodyapplicationDateOperator), required: false);
            var __workflow_bodyapplicationStatusId = WorkflowExpression.Compile(bodyapplicationStatusId, nameof(bodyapplicationStatusId), required: false);
            var __workflow_bodycancelDatevalue = WorkflowExpression.Compile(bodycancelDatevalue, nameof(bodycancelDatevalue), required: false);
            var __workflow_bodycancelDateOperator = WorkflowExpression.Compile(bodycancelDateOperator, nameof(bodycancelDateOperator), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycommentsInternal = WorkflowExpression.Compile(bodycommentsInternal, nameof(bodycommentsInternal), required: false);
            var __workflow_bodycompleteDatevalue = WorkflowExpression.Compile(bodycompleteDatevalue, nameof(bodycompleteDatevalue), required: false);
            var __workflow_bodycompleteDateOperator = WorkflowExpression.Compile(bodycompleteDateOperator, nameof(bodycompleteDateOperator), required: false);
            var __workflow_bodycontractSignedDatevalue = WorkflowExpression.Compile(bodycontractSignedDatevalue, nameof(bodycontractSignedDatevalue), required: false);
            var __workflow_bodycontractSignedDateOperator = WorkflowExpression.Compile(bodycontractSignedDateOperator, nameof(bodycontractSignedDateOperator), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomDate3value = WorkflowExpression.Compile(bodycustomDate3value, nameof(bodycustomDate3value), required: false);
            var __workflow_bodycustomDate3Operator = WorkflowExpression.Compile(bodycustomDate3Operator, nameof(bodycustomDate3Operator), required: false);
            var __workflow_bodycustomDate4value = WorkflowExpression.Compile(bodycustomDate4value, nameof(bodycustomDate4value), required: false);
            var __workflow_bodycustomDate4Operator = WorkflowExpression.Compile(bodycustomDate4Operator, nameof(bodycustomDate4Operator), required: false);
            var __workflow_bodydateCreatedvalue = WorkflowExpression.Compile(bodydateCreatedvalue, nameof(bodydateCreatedvalue), required: false);
            var __workflow_bodydateCreatedOperator = WorkflowExpression.Compile(bodydateCreatedOperator, nameof(bodydateCreatedOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodyenquiryDatevalue = WorkflowExpression.Compile(bodyenquiryDatevalue, nameof(bodyenquiryDatevalue), required: false);
            var __workflow_bodyenquiryDateOperator = WorkflowExpression.Compile(bodyenquiryDateOperator, nameof(bodyenquiryDateOperator), required: false);
            var __workflow_bodyentryApplicationId = WorkflowExpression.Compile(bodyentryApplicationId, nameof(bodyentryApplicationId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyexpectedArrivalDatevalue = WorkflowExpression.Compile(bodyexpectedArrivalDatevalue, nameof(bodyexpectedArrivalDatevalue), required: false);
            var __workflow_bodyexpectedArrivalDateOperator = WorkflowExpression.Compile(bodyexpectedArrivalDateOperator, nameof(bodyexpectedArrivalDateOperator), required: false);
            var __workflow_bodyexpectedArrivalDateLatestvalue = WorkflowExpression.Compile(bodyexpectedArrivalDateLatestvalue, nameof(bodyexpectedArrivalDateLatestvalue), required: false);
            var __workflow_bodyexpectedArrivalDateLatestOperator = WorkflowExpression.Compile(bodyexpectedArrivalDateLatestOperator, nameof(bodyexpectedArrivalDateLatestOperator), required: false);
            var __workflow_bodyexpectedDepartureDatevalue = WorkflowExpression.Compile(bodyexpectedDepartureDatevalue, nameof(bodyexpectedDepartureDatevalue), required: false);
            var __workflow_bodyexpectedDepartureDateOperator = WorkflowExpression.Compile(bodyexpectedDepartureDateOperator, nameof(bodyexpectedDepartureDateOperator), required: false);
            var __workflow_bodyofferedDatevalue = WorkflowExpression.Compile(bodyofferedDatevalue, nameof(bodyofferedDatevalue), required: false);
            var __workflow_bodyofferedDateOperator = WorkflowExpression.Compile(bodyofferedDateOperator, nameof(bodyofferedDateOperator), required: false);
            var __workflow_bodyofferReplyDatevalue = WorkflowExpression.Compile(bodyofferReplyDatevalue, nameof(bodyofferReplyDatevalue), required: false);
            var __workflow_bodyofferReplyDateOperator = WorkflowExpression.Compile(bodyofferReplyDateOperator, nameof(bodyofferReplyDateOperator), required: false);
            var __workflow_bodyofferReplyEnum = WorkflowExpression.Compile(bodyofferReplyEnum, nameof(bodyofferReplyEnum), required: false);
            var __workflow_bodyofferReplyReason = WorkflowExpression.Compile(bodyofferReplyReason, nameof(bodyofferReplyReason), required: false);
            var __workflow_bodyofferSentDatevalue = WorkflowExpression.Compile(bodyofferSentDatevalue, nameof(bodyofferSentDatevalue), required: false);
            var __workflow_bodyofferSentDateOperator = WorkflowExpression.Compile(bodyofferSentDateOperator, nameof(bodyofferSentDateOperator), required: false);
            var __workflow_bodyportalTrackingOnly = WorkflowExpression.Compile(bodyportalTrackingOnly, nameof(bodyportalTrackingOnly), required: false);
            var __workflow_bodypreferenceComments = WorkflowExpression.Compile(bodypreferenceComments, nameof(bodypreferenceComments), required: false);
            var __workflow_bodyrating = WorkflowExpression.Compile(bodyrating, nameof(bodyrating), required: false);
            var __workflow_bodyreceivedDatevalue = WorkflowExpression.Compile(bodyreceivedDatevalue, nameof(bodyreceivedDatevalue), required: false);
            var __workflow_bodyreceivedDateOperator = WorkflowExpression.Compile(bodyreceivedDateOperator, nameof(bodyreceivedDateOperator), required: false);
            var __workflow_bodyreceivedDeposit = WorkflowExpression.Compile(bodyreceivedDeposit, nameof(bodyreceivedDeposit), required: false);
            var __workflow_bodyreceivedDepositWaived = WorkflowExpression.Compile(bodyreceivedDepositWaived, nameof(bodyreceivedDepositWaived), required: false);
            var __workflow_bodyreceivedDepositPaymentId = WorkflowExpression.Compile(bodyreceivedDepositPaymentId, nameof(bodyreceivedDepositPaymentId), required: false);
            var __workflow_bodyreceivedDepositWebPaymentId = WorkflowExpression.Compile(bodyreceivedDepositWebPaymentId, nameof(bodyreceivedDepositWebPaymentId), required: false);
            var __workflow_bodyreceivedDepositAmount = WorkflowExpression.Compile(bodyreceivedDepositAmount, nameof(bodyreceivedDepositAmount), required: false);
            var __workflow_bodyreceivedDepositDatevalue = WorkflowExpression.Compile(bodyreceivedDepositDatevalue, nameof(bodyreceivedDepositDatevalue), required: false);
            var __workflow_bodyreceivedDepositDateOperator = WorkflowExpression.Compile(bodyreceivedDepositDateOperator, nameof(bodyreceivedDepositDateOperator), required: false);
            var __workflow_bodyreceivedFee = WorkflowExpression.Compile(bodyreceivedFee, nameof(bodyreceivedFee), required: false);
            var __workflow_bodyreceivedFeePaymentId = WorkflowExpression.Compile(bodyreceivedFeePaymentId, nameof(bodyreceivedFeePaymentId), required: false);
            var __workflow_bodyreceivedFeeWebPaymentId = WorkflowExpression.Compile(bodyreceivedFeeWebPaymentId, nameof(bodyreceivedFeeWebPaymentId), required: false);
            var __workflow_bodyreceivedFeeAmount = WorkflowExpression.Compile(bodyreceivedFeeAmount, nameof(bodyreceivedFeeAmount), required: false);
            var __workflow_bodyreceivedFeeDatevalue = WorkflowExpression.Compile(bodyreceivedFeeDatevalue, nameof(bodyreceivedFeeDatevalue), required: false);
            var __workflow_bodyreceivedFeeDateOperator = WorkflowExpression.Compile(bodyreceivedFeeDateOperator, nameof(bodyreceivedFeeDateOperator), required: false);
            var __workflow_bodyreceivedPhotoDatevalue = WorkflowExpression.Compile(bodyreceivedPhotoDatevalue, nameof(bodyreceivedPhotoDatevalue), required: false);
            var __workflow_bodyreceivedPhotoDateOperator = WorkflowExpression.Compile(bodyreceivedPhotoDateOperator, nameof(bodyreceivedPhotoDateOperator), required: false);
            var __workflow_bodyreturning = WorkflowExpression.Compile(bodyreturning, nameof(bodyreturning), required: false);
            var __workflow_bodyroomMateDescription = WorkflowExpression.Compile(bodyroomMateDescription, nameof(bodyroomMateDescription), required: false);
            var __workflow_bodyroommateGroupId = WorkflowExpression.Compile(bodyroommateGroupId, nameof(bodyroommateGroupId), required: false);
            var __workflow_bodyroomMateGroupSortOrder = WorkflowExpression.Compile(bodyroomMateGroupSortOrder, nameof(bodyroomMateGroupSortOrder), required: false);
            var __workflow_bodyroomMateShowInSearch = WorkflowExpression.Compile(bodyroomMateShowInSearch, nameof(bodyroomMateShowInSearch), required: false);
            var __workflow_bodyroomPreferenceComments = WorkflowExpression.Compile(bodyroomPreferenceComments, nameof(bodyroomPreferenceComments), required: false);
            var __workflow_bodyroomSelectionNumber = WorkflowExpression.Compile(bodyroomSelectionNumber, nameof(bodyroomSelectionNumber), required: false);
            var __workflow_bodyroomSelectionTimeslot = WorkflowExpression.Compile(bodyroomSelectionTimeslot, nameof(bodyroomSelectionTimeslot), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyweb = WorkflowExpression.Compile(bodyweb, nameof(bodyweb), required: false);
            return new DeferredBodyAction<SelectEntryApplicationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryApplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodyallocateOptionEnum);
                    bodypropCount++;
                }

                var applicationDateObject = new JObject();
                var applicationDateObjectpropCount = 0;
                if (__workflow_bodyapplicationDatevalue != null)
                {
                    applicationDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationDatevalue);
                    applicationDateObjectpropCount++;
                }

                if (__workflow_bodyapplicationDateOperator != null)
                {
                    applicationDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationDateOperator);
                    applicationDateObjectpropCount++;
                }

                if (applicationDateObjectpropCount > 0)
                {
                    body["ApplicationDate"] = applicationDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationStatusId);
                    bodypropCount++;
                }

                var cancelDateObject = new JObject();
                var cancelDateObjectpropCount = 0;
                if (__workflow_bodycancelDatevalue != null)
                {
                    cancelDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycancelDatevalue);
                    cancelDateObjectpropCount++;
                }

                if (__workflow_bodycancelDateOperator != null)
                {
                    cancelDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycancelDateOperator);
                    cancelDateObjectpropCount++;
                }

                if (cancelDateObjectpropCount > 0)
                {
                    body["CancelDate"] = cancelDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["ClassificationID"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = ExpressionConverter.ConvertO(__workflow_bodycommentsInternal);
                    bodypropCount++;
                }

                var completeDateObject = new JObject();
                var completeDateObjectpropCount = 0;
                if (__workflow_bodycompleteDatevalue != null)
                {
                    completeDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDatevalue);
                    completeDateObjectpropCount++;
                }

                if (__workflow_bodycompleteDateOperator != null)
                {
                    completeDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDateOperator);
                    completeDateObjectpropCount++;
                }

                if (completeDateObjectpropCount > 0)
                {
                    body["CompleteDate"] = completeDateObject;
                    bodypropCount++;
                }

                var contractSignedDateObject = new JObject();
                var contractSignedDateObjectpropCount = 0;
                if (__workflow_bodycontractSignedDatevalue != null)
                {
                    contractSignedDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignedDatevalue);
                    contractSignedDateObjectpropCount++;
                }

                if (__workflow_bodycontractSignedDateOperator != null)
                {
                    contractSignedDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignedDateOperator);
                    contractSignedDateObjectpropCount++;
                }

                if (contractSignedDateObjectpropCount > 0)
                {
                    body["ContractSignedDate"] = contractSignedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                var customDate3Object = new JObject();
                var customDate3ObjectpropCount = 0;
                if (__workflow_bodycustomDate3value != null)
                {
                    customDate3Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3value);
                    customDate3ObjectpropCount++;
                }

                if (__workflow_bodycustomDate3Operator != null)
                {
                    customDate3Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3Operator);
                    customDate3ObjectpropCount++;
                }

                if (customDate3ObjectpropCount > 0)
                {
                    body["CustomDate3"] = customDate3Object;
                    bodypropCount++;
                }

                var customDate4Object = new JObject();
                var customDate4ObjectpropCount = 0;
                if (__workflow_bodycustomDate4value != null)
                {
                    customDate4Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4value);
                    customDate4ObjectpropCount++;
                }

                if (__workflow_bodycustomDate4Operator != null)
                {
                    customDate4Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4Operator);
                    customDate4ObjectpropCount++;
                }

                if (customDate4ObjectpropCount > 0)
                {
                    body["CustomDate4"] = customDate4Object;
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (__workflow_bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (__workflow_bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var enquiryDateObject = new JObject();
                var enquiryDateObjectpropCount = 0;
                if (__workflow_bodyenquiryDatevalue != null)
                {
                    enquiryDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyenquiryDatevalue);
                    enquiryDateObjectpropCount++;
                }

                if (__workflow_bodyenquiryDateOperator != null)
                {
                    enquiryDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyenquiryDateOperator);
                    enquiryDateObjectpropCount++;
                }

                if (enquiryDateObjectpropCount > 0)
                {
                    body["EnquiryDate"] = enquiryDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryApplicationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                var expectedArrivalDateObject = new JObject();
                var expectedArrivalDateObjectpropCount = 0;
                if (__workflow_bodyexpectedArrivalDatevalue != null)
                {
                    expectedArrivalDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDatevalue);
                    expectedArrivalDateObjectpropCount++;
                }

                if (__workflow_bodyexpectedArrivalDateOperator != null)
                {
                    expectedArrivalDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDateOperator);
                    expectedArrivalDateObjectpropCount++;
                }

                if (expectedArrivalDateObjectpropCount > 0)
                {
                    body["ExpectedArrivalDate"] = expectedArrivalDateObject;
                    bodypropCount++;
                }

                var expectedArrivalDateLatestObject = new JObject();
                var expectedArrivalDateLatestObjectpropCount = 0;
                if (__workflow_bodyexpectedArrivalDateLatestvalue != null)
                {
                    expectedArrivalDateLatestObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDateLatestvalue);
                    expectedArrivalDateLatestObjectpropCount++;
                }

                if (__workflow_bodyexpectedArrivalDateLatestOperator != null)
                {
                    expectedArrivalDateLatestObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDateLatestOperator);
                    expectedArrivalDateLatestObjectpropCount++;
                }

                if (expectedArrivalDateLatestObjectpropCount > 0)
                {
                    body["ExpectedArrivalDateLatest"] = expectedArrivalDateLatestObject;
                    bodypropCount++;
                }

                var expectedDepartureDateObject = new JObject();
                var expectedDepartureDateObjectpropCount = 0;
                if (__workflow_bodyexpectedDepartureDatevalue != null)
                {
                    expectedDepartureDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDepartureDatevalue);
                    expectedDepartureDateObjectpropCount++;
                }

                if (__workflow_bodyexpectedDepartureDateOperator != null)
                {
                    expectedDepartureDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDepartureDateOperator);
                    expectedDepartureDateObjectpropCount++;
                }

                if (expectedDepartureDateObjectpropCount > 0)
                {
                    body["ExpectedDepartureDate"] = expectedDepartureDateObject;
                    bodypropCount++;
                }

                var offeredDateObject = new JObject();
                var offeredDateObjectpropCount = 0;
                if (__workflow_bodyofferedDatevalue != null)
                {
                    offeredDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyofferedDatevalue);
                    offeredDateObjectpropCount++;
                }

                if (__workflow_bodyofferedDateOperator != null)
                {
                    offeredDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyofferedDateOperator);
                    offeredDateObjectpropCount++;
                }

                if (offeredDateObjectpropCount > 0)
                {
                    body["OfferedDate"] = offeredDateObject;
                    bodypropCount++;
                }

                var offerReplyDateObject = new JObject();
                var offerReplyDateObjectpropCount = 0;
                if (__workflow_bodyofferReplyDatevalue != null)
                {
                    offerReplyDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyDatevalue);
                    offerReplyDateObjectpropCount++;
                }

                if (__workflow_bodyofferReplyDateOperator != null)
                {
                    offerReplyDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyDateOperator);
                    offerReplyDateObjectpropCount++;
                }

                if (offerReplyDateObjectpropCount > 0)
                {
                    body["OfferReplyDate"] = offerReplyDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyReason);
                    bodypropCount++;
                }

                var offerSentDateObject = new JObject();
                var offerSentDateObjectpropCount = 0;
                if (__workflow_bodyofferSentDatevalue != null)
                {
                    offerSentDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyofferSentDatevalue);
                    offerSentDateObjectpropCount++;
                }

                if (__workflow_bodyofferSentDateOperator != null)
                {
                    offerSentDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyofferSentDateOperator);
                    offerSentDateObjectpropCount++;
                }

                if (offerSentDateObjectpropCount > 0)
                {
                    body["OfferSentDate"] = offerSentDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(__workflow_bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (__workflow_bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodypreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyrating != null)
                {
                    body["Rating"] = ExpressionConverter.ConvertO(__workflow_bodyrating);
                    bodypropCount++;
                }

                var receivedDateObject = new JObject();
                var receivedDateObjectpropCount = 0;
                if (__workflow_bodyreceivedDatevalue != null)
                {
                    receivedDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDatevalue);
                    receivedDateObjectpropCount++;
                }

                if (__workflow_bodyreceivedDateOperator != null)
                {
                    receivedDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDateOperator);
                    receivedDateObjectpropCount++;
                }

                if (receivedDateObjectpropCount > 0)
                {
                    body["ReceivedDate"] = receivedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                var receivedDepositDateObject = new JObject();
                var receivedDepositDateObjectpropCount = 0;
                if (__workflow_bodyreceivedDepositDatevalue != null)
                {
                    receivedDepositDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositDatevalue);
                    receivedDepositDateObjectpropCount++;
                }

                if (__workflow_bodyreceivedDepositDateOperator != null)
                {
                    receivedDepositDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositDateOperator);
                    receivedDepositDateObjectpropCount++;
                }

                if (receivedDepositDateObjectpropCount > 0)
                {
                    body["ReceivedDepositDate"] = receivedDepositDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFee);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                var receivedFeeDateObject = new JObject();
                var receivedFeeDateObjectpropCount = 0;
                if (__workflow_bodyreceivedFeeDatevalue != null)
                {
                    receivedFeeDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeDatevalue);
                    receivedFeeDateObjectpropCount++;
                }

                if (__workflow_bodyreceivedFeeDateOperator != null)
                {
                    receivedFeeDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeDateOperator);
                    receivedFeeDateObjectpropCount++;
                }

                if (receivedFeeDateObjectpropCount > 0)
                {
                    body["ReceivedFeeDate"] = receivedFeeDateObject;
                    bodypropCount++;
                }

                var receivedPhotoDateObject = new JObject();
                var receivedPhotoDateObjectpropCount = 0;
                if (__workflow_bodyreceivedPhotoDatevalue != null)
                {
                    receivedPhotoDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedPhotoDatevalue);
                    receivedPhotoDateObjectpropCount++;
                }

                if (__workflow_bodyreceivedPhotoDateOperator != null)
                {
                    receivedPhotoDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedPhotoDateOperator);
                    receivedPhotoDateObjectpropCount++;
                }

                if (receivedPhotoDateObjectpropCount > 0)
                {
                    body["ReceivedPhotoDate"] = receivedPhotoDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreturning != null)
                {
                    body["Returning"] = ExpressionConverter.ConvertO(__workflow_bodyreturning);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = ExpressionConverter.ConvertO(__workflow_bodyroommateGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (__workflow_bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyweb != null)
                {
                    body["Web"] = ExpressionConverter.ConvertO(__workflow_bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryApplicationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryApplicationResponse, ApiConnectionActionConfiguration> CreateEntryApplication(Expression<Func<int>> bodyentryId, Expression<Func<bodyallocateOptionEnumInput>> bodyallocateOptionEnum = null, Expression<Func<string>> bodyapplicationDate = null, Expression<Func<int>> bodyapplicationStatusId = null, Expression<Func<string>> bodycancelDate = null, Expression<Func<int>> bodyclassificationId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycommentsInternal = null, Expression<Func<string>> bodycompleteDate = null, Expression<Func<string>> bodycontractSignedDate = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomDate3 = null, Expression<Func<string>> bodycustomDate4 = null, Expression<Func<string>> bodyenquiryDate = null, Expression<Func<string>> bodyexpectedArrivalDate = null, Expression<Func<string>> bodyexpectedArrivalDateLatest = null, Expression<Func<string>> bodyexpectedDepartureDate = null, Expression<Func<string>> bodyofferedDate = null, Expression<Func<string>> bodyofferReplyDate = null, Expression<Func<bodyofferReplyEnumInput>> bodyofferReplyEnum = null, Expression<Func<string>> bodyofferReplyReason = null, Expression<Func<string>> bodyofferSentDate = null, Expression<Func<bool>> bodyportalTrackingOnly = null, Expression<Func<string>> bodypreferenceComments = null, Expression<Func<string>> bodyrating = null, Expression<Func<string>> bodyreceivedDate = null, Expression<Func<bool>> bodyreceivedDeposit = null, Expression<Func<int>> bodyreceivedDepositPaymentId = null, Expression<Func<int>> bodyreceivedDepositWebPaymentId = null, Expression<Func<double>> bodyreceivedDepositAmount = null, Expression<Func<string>> bodyreceivedDepositDate = null, Expression<Func<bool>> bodyreceivedDepositWaived = null, Expression<Func<bool>> bodyreceivedFee = null, Expression<Func<int>> bodyreceivedFeePaymentId = null, Expression<Func<int>> bodyreceivedFeeWebPaymentId = null, Expression<Func<double>> bodyreceivedFeeAmount = null, Expression<Func<string>> bodyreceivedFeeDate = null, Expression<Func<string>> bodyreceivedPhotoDate = null, Expression<Func<bool>> bodyreturning = null, Expression<Func<string>> bodyroomMateDescription = null, Expression<Func<int>> bodyroommateGroupId = null, Expression<Func<int>> bodyroomMateGroupSortOrder = null, Expression<Func<bool>> bodyroomMateShowInSearch = null, Expression<Func<string>> bodyroomPreferenceComments = null, Expression<Func<int>> bodyroomSelectionNumber = null, Expression<Func<string>> bodyroomSelectionTimeslot = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodytermId = null, Expression<Func<bool>> bodyweb = null)
        {
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: true);
            var __workflow_bodyallocateOptionEnum = WorkflowExpression.Compile(bodyallocateOptionEnum, nameof(bodyallocateOptionEnum), required: false);
            var __workflow_bodyapplicationDate = WorkflowExpression.Compile(bodyapplicationDate, nameof(bodyapplicationDate), required: false);
            var __workflow_bodyapplicationStatusId = WorkflowExpression.Compile(bodyapplicationStatusId, nameof(bodyapplicationStatusId), required: false);
            var __workflow_bodycancelDate = WorkflowExpression.Compile(bodycancelDate, nameof(bodycancelDate), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycommentsInternal = WorkflowExpression.Compile(bodycommentsInternal, nameof(bodycommentsInternal), required: false);
            var __workflow_bodycompleteDate = WorkflowExpression.Compile(bodycompleteDate, nameof(bodycompleteDate), required: false);
            var __workflow_bodycontractSignedDate = WorkflowExpression.Compile(bodycontractSignedDate, nameof(bodycontractSignedDate), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomDate3 = WorkflowExpression.Compile(bodycustomDate3, nameof(bodycustomDate3), required: false);
            var __workflow_bodycustomDate4 = WorkflowExpression.Compile(bodycustomDate4, nameof(bodycustomDate4), required: false);
            var __workflow_bodyenquiryDate = WorkflowExpression.Compile(bodyenquiryDate, nameof(bodyenquiryDate), required: false);
            var __workflow_bodyexpectedArrivalDate = WorkflowExpression.Compile(bodyexpectedArrivalDate, nameof(bodyexpectedArrivalDate), required: false);
            var __workflow_bodyexpectedArrivalDateLatest = WorkflowExpression.Compile(bodyexpectedArrivalDateLatest, nameof(bodyexpectedArrivalDateLatest), required: false);
            var __workflow_bodyexpectedDepartureDate = WorkflowExpression.Compile(bodyexpectedDepartureDate, nameof(bodyexpectedDepartureDate), required: false);
            var __workflow_bodyofferedDate = WorkflowExpression.Compile(bodyofferedDate, nameof(bodyofferedDate), required: false);
            var __workflow_bodyofferReplyDate = WorkflowExpression.Compile(bodyofferReplyDate, nameof(bodyofferReplyDate), required: false);
            var __workflow_bodyofferReplyEnum = WorkflowExpression.Compile(bodyofferReplyEnum, nameof(bodyofferReplyEnum), required: false);
            var __workflow_bodyofferReplyReason = WorkflowExpression.Compile(bodyofferReplyReason, nameof(bodyofferReplyReason), required: false);
            var __workflow_bodyofferSentDate = WorkflowExpression.Compile(bodyofferSentDate, nameof(bodyofferSentDate), required: false);
            var __workflow_bodyportalTrackingOnly = WorkflowExpression.Compile(bodyportalTrackingOnly, nameof(bodyportalTrackingOnly), required: false);
            var __workflow_bodypreferenceComments = WorkflowExpression.Compile(bodypreferenceComments, nameof(bodypreferenceComments), required: false);
            var __workflow_bodyrating = WorkflowExpression.Compile(bodyrating, nameof(bodyrating), required: false);
            var __workflow_bodyreceivedDate = WorkflowExpression.Compile(bodyreceivedDate, nameof(bodyreceivedDate), required: false);
            var __workflow_bodyreceivedDeposit = WorkflowExpression.Compile(bodyreceivedDeposit, nameof(bodyreceivedDeposit), required: false);
            var __workflow_bodyreceivedDepositPaymentId = WorkflowExpression.Compile(bodyreceivedDepositPaymentId, nameof(bodyreceivedDepositPaymentId), required: false);
            var __workflow_bodyreceivedDepositWebPaymentId = WorkflowExpression.Compile(bodyreceivedDepositWebPaymentId, nameof(bodyreceivedDepositWebPaymentId), required: false);
            var __workflow_bodyreceivedDepositAmount = WorkflowExpression.Compile(bodyreceivedDepositAmount, nameof(bodyreceivedDepositAmount), required: false);
            var __workflow_bodyreceivedDepositDate = WorkflowExpression.Compile(bodyreceivedDepositDate, nameof(bodyreceivedDepositDate), required: false);
            var __workflow_bodyreceivedDepositWaived = WorkflowExpression.Compile(bodyreceivedDepositWaived, nameof(bodyreceivedDepositWaived), required: false);
            var __workflow_bodyreceivedFee = WorkflowExpression.Compile(bodyreceivedFee, nameof(bodyreceivedFee), required: false);
            var __workflow_bodyreceivedFeePaymentId = WorkflowExpression.Compile(bodyreceivedFeePaymentId, nameof(bodyreceivedFeePaymentId), required: false);
            var __workflow_bodyreceivedFeeWebPaymentId = WorkflowExpression.Compile(bodyreceivedFeeWebPaymentId, nameof(bodyreceivedFeeWebPaymentId), required: false);
            var __workflow_bodyreceivedFeeAmount = WorkflowExpression.Compile(bodyreceivedFeeAmount, nameof(bodyreceivedFeeAmount), required: false);
            var __workflow_bodyreceivedFeeDate = WorkflowExpression.Compile(bodyreceivedFeeDate, nameof(bodyreceivedFeeDate), required: false);
            var __workflow_bodyreceivedPhotoDate = WorkflowExpression.Compile(bodyreceivedPhotoDate, nameof(bodyreceivedPhotoDate), required: false);
            var __workflow_bodyreturning = WorkflowExpression.Compile(bodyreturning, nameof(bodyreturning), required: false);
            var __workflow_bodyroomMateDescription = WorkflowExpression.Compile(bodyroomMateDescription, nameof(bodyroomMateDescription), required: false);
            var __workflow_bodyroommateGroupId = WorkflowExpression.Compile(bodyroommateGroupId, nameof(bodyroommateGroupId), required: false);
            var __workflow_bodyroomMateGroupSortOrder = WorkflowExpression.Compile(bodyroomMateGroupSortOrder, nameof(bodyroomMateGroupSortOrder), required: false);
            var __workflow_bodyroomMateShowInSearch = WorkflowExpression.Compile(bodyroomMateShowInSearch, nameof(bodyroomMateShowInSearch), required: false);
            var __workflow_bodyroomPreferenceComments = WorkflowExpression.Compile(bodyroomPreferenceComments, nameof(bodyroomPreferenceComments), required: false);
            var __workflow_bodyroomSelectionNumber = WorkflowExpression.Compile(bodyroomSelectionNumber, nameof(bodyroomSelectionNumber), required: false);
            var __workflow_bodyroomSelectionTimeslot = WorkflowExpression.Compile(bodyroomSelectionTimeslot, nameof(bodyroomSelectionTimeslot), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyweb = WorkflowExpression.Compile(bodyweb, nameof(bodyweb), required: false);
            return new DeferredBodyAction<CreateEntryApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entryapplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodyallocateOptionEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyapplicationDate != null)
                {
                    body["ApplicationDate"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodycancelDate != null)
                {
                    body["CancelDate"] = ExpressionConverter.ConvertO(__workflow_bodycancelDate);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["ClassificationID"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = ExpressionConverter.ConvertO(__workflow_bodycommentsInternal);
                    bodypropCount++;
                }

                if (__workflow_bodycompleteDate != null)
                {
                    body["CompleteDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractSignedDate != null)
                {
                    body["ContractSignedDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignedDate);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate3 != null)
                {
                    body["CustomDate3"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate4 != null)
                {
                    body["CustomDate4"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4);
                    bodypropCount++;
                }

                if (__workflow_bodyenquiryDate != null)
                {
                    body["EnquiryDate"] = ExpressionConverter.ConvertO(__workflow_bodyenquiryDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                if (__workflow_bodyexpectedArrivalDate != null)
                {
                    body["ExpectedArrivalDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedArrivalDateLatest != null)
                {
                    body["ExpectedArrivalDateLatest"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDateLatest);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDepartureDate != null)
                {
                    body["ExpectedDepartureDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDepartureDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferedDate != null)
                {
                    body["OfferedDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyDate != null)
                {
                    body["OfferReplyDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyReason);
                    bodypropCount++;
                }

                if (__workflow_bodyofferSentDate != null)
                {
                    body["OfferSentDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferSentDate);
                    bodypropCount++;
                }

                if (__workflow_bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(__workflow_bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (__workflow_bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodypreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyrating != null)
                {
                    body["Rating"] = ExpressionConverter.ConvertO(__workflow_bodyrating);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDate != null)
                {
                    body["ReceivedDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositDate != null)
                {
                    body["ReceivedDepositDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFee);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeDate != null)
                {
                    body["ReceivedFeeDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedPhotoDate != null)
                {
                    body["ReceivedPhotoDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedPhotoDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreturning != null)
                {
                    body["Returning"] = ExpressionConverter.ConvertO(__workflow_bodyreturning);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = ExpressionConverter.ConvertO(__workflow_bodyroommateGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (__workflow_bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyweb != null)
                {
                    body["Web"] = ExpressionConverter.ConvertO(__workflow_bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEntryApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryApplicationResponse, ApiConnectionActionConfiguration> UpdateEntryApplication(Expression<Func<int>> entryApplicationId, Expression<Func<bodyallocateOptionEnumInput>> bodyallocateOptionEnum = null, Expression<Func<string>> bodyapplicationDate = null, Expression<Func<int>> bodyapplicationStatusId = null, Expression<Func<string>> bodycancelDate = null, Expression<Func<int>> bodyclassificationId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycommentsInternal = null, Expression<Func<string>> bodycompleteDate = null, Expression<Func<string>> bodycontractSignedDate = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomDate3 = null, Expression<Func<string>> bodycustomDate4 = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyenquiryDate = null, Expression<Func<string>> bodyexpectedArrivalDate = null, Expression<Func<string>> bodyexpectedArrivalDateLatest = null, Expression<Func<string>> bodyexpectedDepartureDate = null, Expression<Func<string>> bodyofferedDate = null, Expression<Func<string>> bodyofferReplyDate = null, Expression<Func<bodyofferReplyEnumInput>> bodyofferReplyEnum = null, Expression<Func<string>> bodyofferReplyReason = null, Expression<Func<string>> bodyofferSentDate = null, Expression<Func<bool>> bodyportalTrackingOnly = null, Expression<Func<string>> bodypreferenceComments = null, Expression<Func<string>> bodyrating = null, Expression<Func<string>> bodyreceivedDate = null, Expression<Func<bool>> bodyreceivedDeposit = null, Expression<Func<int>> bodyreceivedDepositPaymentId = null, Expression<Func<int>> bodyreceivedDepositWebPaymentId = null, Expression<Func<double>> bodyreceivedDepositAmount = null, Expression<Func<string>> bodyreceivedDepositDate = null, Expression<Func<bool>> bodyreceivedDepositWaived = null, Expression<Func<bool>> bodyreceivedFee = null, Expression<Func<int>> bodyreceivedFeePaymentId = null, Expression<Func<int>> bodyreceivedFeeWebPaymentId = null, Expression<Func<double>> bodyreceivedFeeAmount = null, Expression<Func<string>> bodyreceivedFeeDate = null, Expression<Func<string>> bodyreceivedPhotoDate = null, Expression<Func<bool>> bodyreturning = null, Expression<Func<string>> bodyroomMateDescription = null, Expression<Func<int>> bodyroommateGroupId = null, Expression<Func<int>> bodyroomMateGroupSortOrder = null, Expression<Func<bool>> bodyroomMateShowInSearch = null, Expression<Func<string>> bodyroomPreferenceComments = null, Expression<Func<int>> bodyroomSelectionNumber = null, Expression<Func<string>> bodyroomSelectionTimeslot = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodytermId = null, Expression<Func<bool>> bodyweb = null)
        {
            var __workflow_entryApplicationId = WorkflowExpression.Compile(entryApplicationId, nameof(entryApplicationId), required: true);
            var __workflow_bodyallocateOptionEnum = WorkflowExpression.Compile(bodyallocateOptionEnum, nameof(bodyallocateOptionEnum), required: false);
            var __workflow_bodyapplicationDate = WorkflowExpression.Compile(bodyapplicationDate, nameof(bodyapplicationDate), required: false);
            var __workflow_bodyapplicationStatusId = WorkflowExpression.Compile(bodyapplicationStatusId, nameof(bodyapplicationStatusId), required: false);
            var __workflow_bodycancelDate = WorkflowExpression.Compile(bodycancelDate, nameof(bodycancelDate), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycommentsInternal = WorkflowExpression.Compile(bodycommentsInternal, nameof(bodycommentsInternal), required: false);
            var __workflow_bodycompleteDate = WorkflowExpression.Compile(bodycompleteDate, nameof(bodycompleteDate), required: false);
            var __workflow_bodycontractSignedDate = WorkflowExpression.Compile(bodycontractSignedDate, nameof(bodycontractSignedDate), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomDate3 = WorkflowExpression.Compile(bodycustomDate3, nameof(bodycustomDate3), required: false);
            var __workflow_bodycustomDate4 = WorkflowExpression.Compile(bodycustomDate4, nameof(bodycustomDate4), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyenquiryDate = WorkflowExpression.Compile(bodyenquiryDate, nameof(bodyenquiryDate), required: false);
            var __workflow_bodyexpectedArrivalDate = WorkflowExpression.Compile(bodyexpectedArrivalDate, nameof(bodyexpectedArrivalDate), required: false);
            var __workflow_bodyexpectedArrivalDateLatest = WorkflowExpression.Compile(bodyexpectedArrivalDateLatest, nameof(bodyexpectedArrivalDateLatest), required: false);
            var __workflow_bodyexpectedDepartureDate = WorkflowExpression.Compile(bodyexpectedDepartureDate, nameof(bodyexpectedDepartureDate), required: false);
            var __workflow_bodyofferedDate = WorkflowExpression.Compile(bodyofferedDate, nameof(bodyofferedDate), required: false);
            var __workflow_bodyofferReplyDate = WorkflowExpression.Compile(bodyofferReplyDate, nameof(bodyofferReplyDate), required: false);
            var __workflow_bodyofferReplyEnum = WorkflowExpression.Compile(bodyofferReplyEnum, nameof(bodyofferReplyEnum), required: false);
            var __workflow_bodyofferReplyReason = WorkflowExpression.Compile(bodyofferReplyReason, nameof(bodyofferReplyReason), required: false);
            var __workflow_bodyofferSentDate = WorkflowExpression.Compile(bodyofferSentDate, nameof(bodyofferSentDate), required: false);
            var __workflow_bodyportalTrackingOnly = WorkflowExpression.Compile(bodyportalTrackingOnly, nameof(bodyportalTrackingOnly), required: false);
            var __workflow_bodypreferenceComments = WorkflowExpression.Compile(bodypreferenceComments, nameof(bodypreferenceComments), required: false);
            var __workflow_bodyrating = WorkflowExpression.Compile(bodyrating, nameof(bodyrating), required: false);
            var __workflow_bodyreceivedDate = WorkflowExpression.Compile(bodyreceivedDate, nameof(bodyreceivedDate), required: false);
            var __workflow_bodyreceivedDeposit = WorkflowExpression.Compile(bodyreceivedDeposit, nameof(bodyreceivedDeposit), required: false);
            var __workflow_bodyreceivedDepositPaymentId = WorkflowExpression.Compile(bodyreceivedDepositPaymentId, nameof(bodyreceivedDepositPaymentId), required: false);
            var __workflow_bodyreceivedDepositWebPaymentId = WorkflowExpression.Compile(bodyreceivedDepositWebPaymentId, nameof(bodyreceivedDepositWebPaymentId), required: false);
            var __workflow_bodyreceivedDepositAmount = WorkflowExpression.Compile(bodyreceivedDepositAmount, nameof(bodyreceivedDepositAmount), required: false);
            var __workflow_bodyreceivedDepositDate = WorkflowExpression.Compile(bodyreceivedDepositDate, nameof(bodyreceivedDepositDate), required: false);
            var __workflow_bodyreceivedDepositWaived = WorkflowExpression.Compile(bodyreceivedDepositWaived, nameof(bodyreceivedDepositWaived), required: false);
            var __workflow_bodyreceivedFee = WorkflowExpression.Compile(bodyreceivedFee, nameof(bodyreceivedFee), required: false);
            var __workflow_bodyreceivedFeePaymentId = WorkflowExpression.Compile(bodyreceivedFeePaymentId, nameof(bodyreceivedFeePaymentId), required: false);
            var __workflow_bodyreceivedFeeWebPaymentId = WorkflowExpression.Compile(bodyreceivedFeeWebPaymentId, nameof(bodyreceivedFeeWebPaymentId), required: false);
            var __workflow_bodyreceivedFeeAmount = WorkflowExpression.Compile(bodyreceivedFeeAmount, nameof(bodyreceivedFeeAmount), required: false);
            var __workflow_bodyreceivedFeeDate = WorkflowExpression.Compile(bodyreceivedFeeDate, nameof(bodyreceivedFeeDate), required: false);
            var __workflow_bodyreceivedPhotoDate = WorkflowExpression.Compile(bodyreceivedPhotoDate, nameof(bodyreceivedPhotoDate), required: false);
            var __workflow_bodyreturning = WorkflowExpression.Compile(bodyreturning, nameof(bodyreturning), required: false);
            var __workflow_bodyroomMateDescription = WorkflowExpression.Compile(bodyroomMateDescription, nameof(bodyroomMateDescription), required: false);
            var __workflow_bodyroommateGroupId = WorkflowExpression.Compile(bodyroommateGroupId, nameof(bodyroommateGroupId), required: false);
            var __workflow_bodyroomMateGroupSortOrder = WorkflowExpression.Compile(bodyroomMateGroupSortOrder, nameof(bodyroomMateGroupSortOrder), required: false);
            var __workflow_bodyroomMateShowInSearch = WorkflowExpression.Compile(bodyroomMateShowInSearch, nameof(bodyroomMateShowInSearch), required: false);
            var __workflow_bodyroomPreferenceComments = WorkflowExpression.Compile(bodyroomPreferenceComments, nameof(bodyroomPreferenceComments), required: false);
            var __workflow_bodyroomSelectionNumber = WorkflowExpression.Compile(bodyroomSelectionNumber, nameof(bodyroomSelectionNumber), required: false);
            var __workflow_bodyroomSelectionTimeslot = WorkflowExpression.Compile(bodyroomSelectionTimeslot, nameof(bodyroomSelectionTimeslot), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyweb = WorkflowExpression.Compile(bodyweb, nameof(bodyweb), required: false);
            return new DeferredBodyAction<UpdateEntryApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryapplication.json/{0}", __workflow_entryApplicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(__workflow_bodyallocateOptionEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyapplicationDate != null)
                {
                    body["ApplicationDate"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodycancelDate != null)
                {
                    body["CancelDate"] = ExpressionConverter.ConvertO(__workflow_bodycancelDate);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["ClassificationID"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = ExpressionConverter.ConvertO(__workflow_bodycommentsInternal);
                    bodypropCount++;
                }

                if (__workflow_bodycompleteDate != null)
                {
                    body["CompleteDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractSignedDate != null)
                {
                    body["ContractSignedDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignedDate);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate3 != null)
                {
                    body["CustomDate3"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate4 != null)
                {
                    body["CustomDate4"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyenquiryDate != null)
                {
                    body["EnquiryDate"] = ExpressionConverter.ConvertO(__workflow_bodyenquiryDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedArrivalDate != null)
                {
                    body["ExpectedArrivalDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedArrivalDateLatest != null)
                {
                    body["ExpectedArrivalDateLatest"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedArrivalDateLatest);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDepartureDate != null)
                {
                    body["ExpectedDepartureDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDepartureDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferedDate != null)
                {
                    body["OfferedDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyDate != null)
                {
                    body["OfferReplyDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyDate);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = ExpressionConverter.ConvertO(__workflow_bodyofferReplyReason);
                    bodypropCount++;
                }

                if (__workflow_bodyofferSentDate != null)
                {
                    body["OfferSentDate"] = ExpressionConverter.ConvertO(__workflow_bodyofferSentDate);
                    bodypropCount++;
                }

                if (__workflow_bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(__workflow_bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (__workflow_bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodypreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyrating != null)
                {
                    body["Rating"] = ExpressionConverter.ConvertO(__workflow_bodyrating);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDate != null)
                {
                    body["ReceivedDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositDate != null)
                {
                    body["ReceivedDepositDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFee);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedFeeDate != null)
                {
                    body["ReceivedFeeDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedFeeDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreceivedPhotoDate != null)
                {
                    body["ReceivedPhotoDate"] = ExpressionConverter.ConvertO(__workflow_bodyreceivedPhotoDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreturning != null)
                {
                    body["Returning"] = ExpressionConverter.ConvertO(__workflow_bodyreturning);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = ExpressionConverter.ConvertO(__workflow_bodyroommateGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(__workflow_bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (__workflow_bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(__workflow_bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(__workflow_bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyweb != null)
                {
                    body["Web"] = ExpressionConverter.ConvertO(__workflow_bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermSessionResponseItem[], ApiConnectionActionConfiguration> SelectTermSession(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodybookingTypeId = null, Expression<Func<int>> bodycancelBookingDefaultEndBookingReasonId = null, Expression<Func<bodycancelBookingUpdateEndBookingReasonBooleanAskEnumInput>> bodycancelBookingUpdateEndBookingReasonBooleanAskEnum = null, Expression<Func<string>> bodycheckInDatevalue = null, Expression<Func<bodycheckInDateOperatorInput>> bodycheckInDateOperator = null, Expression<Func<bodycheckInDateActualDecreaseBooleanAskEnumInput>> bodycheckInDateActualDecreaseBooleanAskEnum = null, Expression<Func<bodycheckInDateActualIncreaseBooleanAskEnumInput>> bodycheckInDateActualIncreaseBooleanAskEnum = null, Expression<Func<int>> bodycheckInDefaultStartBookingReasonId = null, Expression<Func<bodycheckInUpdateStartBookingReasonBooleanAskEnumInput>> bodycheckInUpdateStartBookingReasonBooleanAskEnum = null, Expression<Func<string>> bodycheckOutDatevalue = null, Expression<Func<bodycheckOutDateOperatorInput>> bodycheckOutDateOperator = null, Expression<Func<bodycheckOutDateActualDecreaseBooleanAskEnumInput>> bodycheckOutDateActualDecreaseBooleanAskEnum = null, Expression<Func<bodycheckOutDateActualIncreaseBooleanAskEnumInput>> bodycheckOutDateActualIncreaseBooleanAskEnum = null, Expression<Func<int>> bodycheckOutDefaultEndBookingReasonId = null, Expression<Func<bodycheckOutUpdateEndBookingReasonBooleanAskEnumInput>> bodycheckOutUpdateEndBookingReasonBooleanAskEnum = null, Expression<Func<bodycontractDateCheckInDecreaseBooleanAskEnumInput>> bodycontractDateCheckInDecreaseBooleanAskEnum = null, Expression<Func<bodycontractDateCheckInIncreaseBooleanAskEnumInput>> bodycontractDateCheckInIncreaseBooleanAskEnum = null, Expression<Func<bodycontractDateCheckOutDecreaseBooleanAskEnumInput>> bodycontractDateCheckOutDecreaseBooleanAskEnum = null, Expression<Func<bodycontractDateCheckOutIncreaseBooleanAskEnumInput>> bodycontractDateCheckOutIncreaseBooleanAskEnum = null, Expression<Func<string>> bodycontractDateEndvalue = null, Expression<Func<bodycontractDateEndOperatorInput>> bodycontractDateEndOperator = null, Expression<Func<string>> bodycontractDateStartvalue = null, Expression<Func<bodycontractDateStartOperatorInput>> bodycontractDateStartOperator = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyendBookingReasonId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<string>> bodyeTA = null, Expression<Func<string>> bodyeTD = null, Expression<Func<int>> bodyhousekeepingId = null, Expression<Func<bodyrecordTypeEnumInput>> bodyrecordTypeEnum = null, Expression<Func<bool>> bodyroomLocationFixed = null, Expression<Func<int>> bodyroomLocationId = null, Expression<Func<double>> bodyroomRateAmount = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<int>> bodyroomTypeId = null, Expression<Func<int>> bodystartBookingReasonId = null, Expression<Func<int>> bodytermId = null, Expression<Func<string>> bodytermSessionCode = null, Expression<Func<int>> bodytermSessionId = null, Expression<Func<bool>> bodyuseActiveBookingAsTemplate = null, Expression<Func<string>> bodywebDescription = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodybookingTypeId = WorkflowExpression.Compile(bodybookingTypeId, nameof(bodybookingTypeId), required: false);
            var __workflow_bodycancelBookingDefaultEndBookingReasonId = WorkflowExpression.Compile(bodycancelBookingDefaultEndBookingReasonId, nameof(bodycancelBookingDefaultEndBookingReasonId), required: false);
            var __workflow_bodycancelBookingUpdateEndBookingReasonBooleanAskEnum = WorkflowExpression.Compile(bodycancelBookingUpdateEndBookingReasonBooleanAskEnum, nameof(bodycancelBookingUpdateEndBookingReasonBooleanAskEnum), required: false);
            var __workflow_bodycheckInDatevalue = WorkflowExpression.Compile(bodycheckInDatevalue, nameof(bodycheckInDatevalue), required: false);
            var __workflow_bodycheckInDateOperator = WorkflowExpression.Compile(bodycheckInDateOperator, nameof(bodycheckInDateOperator), required: false);
            var __workflow_bodycheckInDateActualDecreaseBooleanAskEnum = WorkflowExpression.Compile(bodycheckInDateActualDecreaseBooleanAskEnum, nameof(bodycheckInDateActualDecreaseBooleanAskEnum), required: false);
            var __workflow_bodycheckInDateActualIncreaseBooleanAskEnum = WorkflowExpression.Compile(bodycheckInDateActualIncreaseBooleanAskEnum, nameof(bodycheckInDateActualIncreaseBooleanAskEnum), required: false);
            var __workflow_bodycheckInDefaultStartBookingReasonId = WorkflowExpression.Compile(bodycheckInDefaultStartBookingReasonId, nameof(bodycheckInDefaultStartBookingReasonId), required: false);
            var __workflow_bodycheckInUpdateStartBookingReasonBooleanAskEnum = WorkflowExpression.Compile(bodycheckInUpdateStartBookingReasonBooleanAskEnum, nameof(bodycheckInUpdateStartBookingReasonBooleanAskEnum), required: false);
            var __workflow_bodycheckOutDatevalue = WorkflowExpression.Compile(bodycheckOutDatevalue, nameof(bodycheckOutDatevalue), required: false);
            var __workflow_bodycheckOutDateOperator = WorkflowExpression.Compile(bodycheckOutDateOperator, nameof(bodycheckOutDateOperator), required: false);
            var __workflow_bodycheckOutDateActualDecreaseBooleanAskEnum = WorkflowExpression.Compile(bodycheckOutDateActualDecreaseBooleanAskEnum, nameof(bodycheckOutDateActualDecreaseBooleanAskEnum), required: false);
            var __workflow_bodycheckOutDateActualIncreaseBooleanAskEnum = WorkflowExpression.Compile(bodycheckOutDateActualIncreaseBooleanAskEnum, nameof(bodycheckOutDateActualIncreaseBooleanAskEnum), required: false);
            var __workflow_bodycheckOutDefaultEndBookingReasonId = WorkflowExpression.Compile(bodycheckOutDefaultEndBookingReasonId, nameof(bodycheckOutDefaultEndBookingReasonId), required: false);
            var __workflow_bodycheckOutUpdateEndBookingReasonBooleanAskEnum = WorkflowExpression.Compile(bodycheckOutUpdateEndBookingReasonBooleanAskEnum, nameof(bodycheckOutUpdateEndBookingReasonBooleanAskEnum), required: false);
            var __workflow_bodycontractDateCheckInDecreaseBooleanAskEnum = WorkflowExpression.Compile(bodycontractDateCheckInDecreaseBooleanAskEnum, nameof(bodycontractDateCheckInDecreaseBooleanAskEnum), required: false);
            var __workflow_bodycontractDateCheckInIncreaseBooleanAskEnum = WorkflowExpression.Compile(bodycontractDateCheckInIncreaseBooleanAskEnum, nameof(bodycontractDateCheckInIncreaseBooleanAskEnum), required: false);
            var __workflow_bodycontractDateCheckOutDecreaseBooleanAskEnum = WorkflowExpression.Compile(bodycontractDateCheckOutDecreaseBooleanAskEnum, nameof(bodycontractDateCheckOutDecreaseBooleanAskEnum), required: false);
            var __workflow_bodycontractDateCheckOutIncreaseBooleanAskEnum = WorkflowExpression.Compile(bodycontractDateCheckOutIncreaseBooleanAskEnum, nameof(bodycontractDateCheckOutIncreaseBooleanAskEnum), required: false);
            var __workflow_bodycontractDateEndvalue = WorkflowExpression.Compile(bodycontractDateEndvalue, nameof(bodycontractDateEndvalue), required: false);
            var __workflow_bodycontractDateEndOperator = WorkflowExpression.Compile(bodycontractDateEndOperator, nameof(bodycontractDateEndOperator), required: false);
            var __workflow_bodycontractDateStartvalue = WorkflowExpression.Compile(bodycontractDateStartvalue, nameof(bodycontractDateStartvalue), required: false);
            var __workflow_bodycontractDateStartOperator = WorkflowExpression.Compile(bodycontractDateStartOperator, nameof(bodycontractDateStartOperator), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyendBookingReasonId = WorkflowExpression.Compile(bodyendBookingReasonId, nameof(bodyendBookingReasonId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeTA = WorkflowExpression.Compile(bodyeTA, nameof(bodyeTA), required: false);
            var __workflow_bodyeTD = WorkflowExpression.Compile(bodyeTD, nameof(bodyeTD), required: false);
            var __workflow_bodyhousekeepingId = WorkflowExpression.Compile(bodyhousekeepingId, nameof(bodyhousekeepingId), required: false);
            var __workflow_bodyrecordTypeEnum = WorkflowExpression.Compile(bodyrecordTypeEnum, nameof(bodyrecordTypeEnum), required: false);
            var __workflow_bodyroomLocationFixed = WorkflowExpression.Compile(bodyroomLocationFixed, nameof(bodyroomLocationFixed), required: false);
            var __workflow_bodyroomLocationId = WorkflowExpression.Compile(bodyroomLocationId, nameof(bodyroomLocationId), required: false);
            var __workflow_bodyroomRateAmount = WorkflowExpression.Compile(bodyroomRateAmount, nameof(bodyroomRateAmount), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomTypeId = WorkflowExpression.Compile(bodyroomTypeId, nameof(bodyroomTypeId), required: false);
            var __workflow_bodystartBookingReasonId = WorkflowExpression.Compile(bodystartBookingReasonId, nameof(bodystartBookingReasonId), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodytermSessionCode = WorkflowExpression.Compile(bodytermSessionCode, nameof(bodytermSessionCode), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            var __workflow_bodyuseActiveBookingAsTemplate = WorkflowExpression.Compile(bodyuseActiveBookingAsTemplate, nameof(bodyuseActiveBookingAsTemplate), required: false);
            var __workflow_bodywebDescription = WorkflowExpression.Compile(bodywebDescription, nameof(bodywebDescription), required: false);
            return new DeferredBodyAction<SelectTermSessionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/TermSession.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = ExpressionConverter.ConvertO(__workflow_bodybookingTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycancelBookingDefaultEndBookingReasonId != null)
                {
                    body["CancelBookingDefaultEnd_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodycancelBookingDefaultEndBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodycancelBookingUpdateEndBookingReasonBooleanAskEnum != null)
                {
                    body["CancelBookingUpdateEndBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycancelBookingUpdateEndBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                var checkInDateObject = new JObject();
                var checkInDateObjectpropCount = 0;
                if (__workflow_bodycheckInDatevalue != null)
                {
                    checkInDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDatevalue);
                    checkInDateObjectpropCount++;
                }

                if (__workflow_bodycheckInDateOperator != null)
                {
                    checkInDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateOperator);
                    checkInDateObjectpropCount++;
                }

                if (checkInDateObjectpropCount > 0)
                {
                    body["CheckInDate"] = checkInDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDateActualDecreaseBooleanAskEnum != null)
                {
                    body["CheckInDateActualDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActualDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDateActualIncreaseBooleanAskEnum != null)
                {
                    body["CheckInDateActualIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActualIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDefaultStartBookingReasonId != null)
                {
                    body["CheckInDefaultStart_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDefaultStartBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInUpdateStartBookingReasonBooleanAskEnum != null)
                {
                    body["CheckInUpdateStartBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckInUpdateStartBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                var checkOutDateObject = new JObject();
                var checkOutDateObjectpropCount = 0;
                if (__workflow_bodycheckOutDatevalue != null)
                {
                    checkOutDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDatevalue);
                    checkOutDateObjectpropCount++;
                }

                if (__workflow_bodycheckOutDateOperator != null)
                {
                    checkOutDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateOperator);
                    checkOutDateObjectpropCount++;
                }

                if (checkOutDateObjectpropCount > 0)
                {
                    body["CheckOutDate"] = checkOutDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDateActualDecreaseBooleanAskEnum != null)
                {
                    body["CheckOutDateActualDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActualDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDateActualIncreaseBooleanAskEnum != null)
                {
                    body["CheckOutDateActualIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActualIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDefaultEndBookingReasonId != null)
                {
                    body["CheckOutDefaultEnd_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDefaultEndBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutUpdateEndBookingReasonBooleanAskEnum != null)
                {
                    body["CheckOutUpdateEndBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutUpdateEndBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateCheckInDecreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckInDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateCheckInDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateCheckInIncreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckInIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateCheckInIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateCheckOutDecreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckOutDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateCheckOutDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateCheckOutIncreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckOutIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateCheckOutIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                var contractDateEndObject = new JObject();
                var contractDateEndObjectpropCount = 0;
                if (__workflow_bodycontractDateEndvalue != null)
                {
                    contractDateEndObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEndvalue);
                    contractDateEndObjectpropCount++;
                }

                if (__workflow_bodycontractDateEndOperator != null)
                {
                    contractDateEndObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEndOperator);
                    contractDateEndObjectpropCount++;
                }

                if (contractDateEndObjectpropCount > 0)
                {
                    body["ContractDateEnd"] = contractDateEndObject;
                    bodypropCount++;
                }

                var contractDateStartObject = new JObject();
                var contractDateStartObjectpropCount = 0;
                if (__workflow_bodycontractDateStartvalue != null)
                {
                    contractDateStartObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStartvalue);
                    contractDateStartObjectpropCount++;
                }

                if (__workflow_bodycontractDateStartOperator != null)
                {
                    contractDateStartObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStartOperator);
                    contractDateStartObjectpropCount++;
                }

                if (contractDateStartObjectpropCount > 0)
                {
                    body["ContractDateStart"] = contractDateStartObject;
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeTA != null)
                {
                    body["ETA"] = ExpressionConverter.ConvertO(__workflow_bodyeTA);
                    bodypropCount++;
                }

                if (__workflow_bodyeTD != null)
                {
                    body["ETD"] = ExpressionConverter.ConvertO(__workflow_bodyeTD);
                    bodypropCount++;
                }

                if (__workflow_bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = ExpressionConverter.ConvertO(__workflow_bodyhousekeepingId);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyroomTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionCode != null)
                {
                    body["TermSessionCode"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionCode);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                if (__workflow_bodyuseActiveBookingAsTemplate != null)
                {
                    body["UseActiveBookingAsTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyuseActiveBookingAsTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodywebDescription != null)
                {
                    body["WebDescription"] = ExpressionConverter.ConvertO(__workflow_bodywebDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectTermSessionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryDetailResponseItem[], ApiConnectionActionConfiguration> SelectEntryDetail(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyacademicHold = null, Expression<Func<int>> bodyaccountPaymentTypeId = null, Expression<Func<bool>> bodyaccountHold = null, Expression<Func<string>> bodyaccountBankName = null, Expression<Func<string>> bodyaccountBankNumber = null, Expression<Func<string>> bodyaccountCode = null, Expression<Func<string>> bodyaccountComments = null, Expression<Func<string>> bodyaccountDetail1 = null, Expression<Func<string>> bodyaccountDetail2 = null, Expression<Func<string>> bodyaccountDetail3 = null, Expression<Func<string>> bodyaccountDetail4 = null, Expression<Func<string>> bodyaccountDueDatevalue = null, Expression<Func<bodyaccountDueDateOperatorInput>> bodyaccountDueDateOperator = null, Expression<Func<bool>> bodyathlete = null, Expression<Func<string>> bodyathleteTeam = null, Expression<Func<bodyattendeeStatusEnumInput>> bodyattendeeStatusEnum = null, Expression<Func<string>> bodycareer = null, Expression<Func<string>> bodycareerComments = null, Expression<Func<int>> bodycitizenshipCountryId = null, Expression<Func<int>> bodyclassificationId = null, Expression<Func<bool>> bodyclassificationOverride = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycountryOfBirthCountryId = null, Expression<Func<int>> bodycountryOfResidenceCountryId = null, Expression<Func<double>> bodycumulativeGPA = null, Expression<Func<double>> bodycumulativeHours = null, Expression<Func<double>> bodycurrentGPA = null, Expression<Func<double>> bodycurrentHours = null, Expression<Func<string>> bodycurrentMajor = null, Expression<Func<string>> bodycurrentMinor = null, Expression<Func<string>> bodydateEntryvalue = null, Expression<Func<bodydateEntryOperatorInput>> bodydateEntryOperator = null, Expression<Func<string>> bodydateExitvalue = null, Expression<Func<bodydateExitOperatorInput>> bodydateExitOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<string>> bodydeceasedDatevalue = null, Expression<Func<bodydeceasedDateOperatorInput>> bodydeceasedDateOperator = null, Expression<Func<string>> bodydietary = null, Expression<Func<string>> bodydisability = null, Expression<Func<string>> bodyemploymentDetails = null, Expression<Func<string>> bodyenrollmentClass = null, Expression<Func<string>> bodyenrollmentLevel = null, Expression<Func<string>> bodyenrollmentStatus = null, Expression<Func<string>> bodyenrollmentTerm = null, Expression<Func<int>> bodyenrollmentYear = null, Expression<Func<int>> bodyentryDetailId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<int>> bodyeventRegistrationFeeId = null, Expression<Func<string>> bodyexpectedGraduationDatevalue = null, Expression<Func<bodyexpectedGraduationDateOperatorInput>> bodyexpectedGraduationDateOperator = null, Expression<Func<string>> bodyfinancialComments = null, Expression<Func<int>> bodyfinancialSupportId = null, Expression<Func<string>> bodyhearAboutUs = null, Expression<Func<bool>> bodyhonorsIndicator = null, Expression<Func<bool>> bodyimmunizationsHold = null, Expression<Func<bool>> bodyincidentHold = null, Expression<Func<string>> bodyincidentHoldComments = null, Expression<Func<bool>> bodyinternational = null, Expression<Func<string>> bodyinternationalDetails = null, Expression<Func<bool>> bodylivingWithDependents = null, Expression<Func<bool>> bodymarried = null, Expression<Func<string>> bodymedical = null, Expression<Func<int>> bodynationalityId = null, Expression<Func<string>> bodyoccupation = null, Expression<Func<string>> bodyphotoPath = null, Expression<Func<string>> bodypreviousMemberName = null, Expression<Func<string>> bodypreviousMemberRelationship = null, Expression<Func<string>> bodypreviousMembership = null, Expression<Func<string>> bodypreviousMembershipYears = null, Expression<Func<string>> bodypreviousMemberYears = null, Expression<Func<string>> bodyprofileInterests = null, Expression<Func<int>> bodyregionOfBirthId = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyresidency = null, Expression<Func<string>> bodyresidentStatus = null, Expression<Func<int>> bodyresidentYear = null, Expression<Func<string>> bodysituationResponseComments = null, Expression<Func<string>> bodysituationResponseDetail = null, Expression<Func<bodysituationResponseEnumInput>> bodysituationResponseEnum = null, Expression<Func<string>> bodysituationResponseExpiryDatevalue = null, Expression<Func<bodysituationResponseExpiryDateOperatorInput>> bodysituationResponseExpiryDateOperator = null, Expression<Func<string>> bodysituationResponseModifiedDatevalue = null, Expression<Func<bodysituationResponseModifiedDateOperatorInput>> bodysituationResponseModifiedDateOperator = null, Expression<Func<string>> bodysituationResponseSituation = null, Expression<Func<string>> bodyspecialNeeds = null, Expression<Func<int>> bodystaffId = null, Expression<Func<bool>> bodyusesScreenReader = null, Expression<Func<string>> bodyvehicleDetails = null, Expression<Func<string>> bodyvehiclePermit = null, Expression<Func<string>> bodyvehicleRegistration = null, Expression<Func<string>> bodyveteranStatus = null, Expression<Func<bool>> bodyvisa = null, Expression<Func<string>> bodyvisaDetails = null, Expression<Func<bool>> bodyvisitorHold = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyacademicHold = WorkflowExpression.Compile(bodyacademicHold, nameof(bodyacademicHold), required: false);
            var __workflow_bodyaccountPaymentTypeId = WorkflowExpression.Compile(bodyaccountPaymentTypeId, nameof(bodyaccountPaymentTypeId), required: false);
            var __workflow_bodyaccountHold = WorkflowExpression.Compile(bodyaccountHold, nameof(bodyaccountHold), required: false);
            var __workflow_bodyaccountBankName = WorkflowExpression.Compile(bodyaccountBankName, nameof(bodyaccountBankName), required: false);
            var __workflow_bodyaccountBankNumber = WorkflowExpression.Compile(bodyaccountBankNumber, nameof(bodyaccountBankNumber), required: false);
            var __workflow_bodyaccountCode = WorkflowExpression.Compile(bodyaccountCode, nameof(bodyaccountCode), required: false);
            var __workflow_bodyaccountComments = WorkflowExpression.Compile(bodyaccountComments, nameof(bodyaccountComments), required: false);
            var __workflow_bodyaccountDetail1 = WorkflowExpression.Compile(bodyaccountDetail1, nameof(bodyaccountDetail1), required: false);
            var __workflow_bodyaccountDetail2 = WorkflowExpression.Compile(bodyaccountDetail2, nameof(bodyaccountDetail2), required: false);
            var __workflow_bodyaccountDetail3 = WorkflowExpression.Compile(bodyaccountDetail3, nameof(bodyaccountDetail3), required: false);
            var __workflow_bodyaccountDetail4 = WorkflowExpression.Compile(bodyaccountDetail4, nameof(bodyaccountDetail4), required: false);
            var __workflow_bodyaccountDueDatevalue = WorkflowExpression.Compile(bodyaccountDueDatevalue, nameof(bodyaccountDueDatevalue), required: false);
            var __workflow_bodyaccountDueDateOperator = WorkflowExpression.Compile(bodyaccountDueDateOperator, nameof(bodyaccountDueDateOperator), required: false);
            var __workflow_bodyathlete = WorkflowExpression.Compile(bodyathlete, nameof(bodyathlete), required: false);
            var __workflow_bodyathleteTeam = WorkflowExpression.Compile(bodyathleteTeam, nameof(bodyathleteTeam), required: false);
            var __workflow_bodyattendeeStatusEnum = WorkflowExpression.Compile(bodyattendeeStatusEnum, nameof(bodyattendeeStatusEnum), required: false);
            var __workflow_bodycareer = WorkflowExpression.Compile(bodycareer, nameof(bodycareer), required: false);
            var __workflow_bodycareerComments = WorkflowExpression.Compile(bodycareerComments, nameof(bodycareerComments), required: false);
            var __workflow_bodycitizenshipCountryId = WorkflowExpression.Compile(bodycitizenshipCountryId, nameof(bodycitizenshipCountryId), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodyclassificationOverride = WorkflowExpression.Compile(bodyclassificationOverride, nameof(bodyclassificationOverride), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycountryOfBirthCountryId = WorkflowExpression.Compile(bodycountryOfBirthCountryId, nameof(bodycountryOfBirthCountryId), required: false);
            var __workflow_bodycountryOfResidenceCountryId = WorkflowExpression.Compile(bodycountryOfResidenceCountryId, nameof(bodycountryOfResidenceCountryId), required: false);
            var __workflow_bodycumulativeGPA = WorkflowExpression.Compile(bodycumulativeGPA, nameof(bodycumulativeGPA), required: false);
            var __workflow_bodycumulativeHours = WorkflowExpression.Compile(bodycumulativeHours, nameof(bodycumulativeHours), required: false);
            var __workflow_bodycurrentGPA = WorkflowExpression.Compile(bodycurrentGPA, nameof(bodycurrentGPA), required: false);
            var __workflow_bodycurrentHours = WorkflowExpression.Compile(bodycurrentHours, nameof(bodycurrentHours), required: false);
            var __workflow_bodycurrentMajor = WorkflowExpression.Compile(bodycurrentMajor, nameof(bodycurrentMajor), required: false);
            var __workflow_bodycurrentMinor = WorkflowExpression.Compile(bodycurrentMinor, nameof(bodycurrentMinor), required: false);
            var __workflow_bodydateEntryvalue = WorkflowExpression.Compile(bodydateEntryvalue, nameof(bodydateEntryvalue), required: false);
            var __workflow_bodydateEntryOperator = WorkflowExpression.Compile(bodydateEntryOperator, nameof(bodydateEntryOperator), required: false);
            var __workflow_bodydateExitvalue = WorkflowExpression.Compile(bodydateExitvalue, nameof(bodydateExitvalue), required: false);
            var __workflow_bodydateExitOperator = WorkflowExpression.Compile(bodydateExitOperator, nameof(bodydateExitOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydeceased = WorkflowExpression.Compile(bodydeceased, nameof(bodydeceased), required: false);
            var __workflow_bodydeceasedDatevalue = WorkflowExpression.Compile(bodydeceasedDatevalue, nameof(bodydeceasedDatevalue), required: false);
            var __workflow_bodydeceasedDateOperator = WorkflowExpression.Compile(bodydeceasedDateOperator, nameof(bodydeceasedDateOperator), required: false);
            var __workflow_bodydietary = WorkflowExpression.Compile(bodydietary, nameof(bodydietary), required: false);
            var __workflow_bodydisability = WorkflowExpression.Compile(bodydisability, nameof(bodydisability), required: false);
            var __workflow_bodyemploymentDetails = WorkflowExpression.Compile(bodyemploymentDetails, nameof(bodyemploymentDetails), required: false);
            var __workflow_bodyenrollmentClass = WorkflowExpression.Compile(bodyenrollmentClass, nameof(bodyenrollmentClass), required: false);
            var __workflow_bodyenrollmentLevel = WorkflowExpression.Compile(bodyenrollmentLevel, nameof(bodyenrollmentLevel), required: false);
            var __workflow_bodyenrollmentStatus = WorkflowExpression.Compile(bodyenrollmentStatus, nameof(bodyenrollmentStatus), required: false);
            var __workflow_bodyenrollmentTerm = WorkflowExpression.Compile(bodyenrollmentTerm, nameof(bodyenrollmentTerm), required: false);
            var __workflow_bodyenrollmentYear = WorkflowExpression.Compile(bodyenrollmentYear, nameof(bodyenrollmentYear), required: false);
            var __workflow_bodyentryDetailId = WorkflowExpression.Compile(bodyentryDetailId, nameof(bodyentryDetailId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodyeventRegistrationFeeId = WorkflowExpression.Compile(bodyeventRegistrationFeeId, nameof(bodyeventRegistrationFeeId), required: false);
            var __workflow_bodyexpectedGraduationDatevalue = WorkflowExpression.Compile(bodyexpectedGraduationDatevalue, nameof(bodyexpectedGraduationDatevalue), required: false);
            var __workflow_bodyexpectedGraduationDateOperator = WorkflowExpression.Compile(bodyexpectedGraduationDateOperator, nameof(bodyexpectedGraduationDateOperator), required: false);
            var __workflow_bodyfinancialComments = WorkflowExpression.Compile(bodyfinancialComments, nameof(bodyfinancialComments), required: false);
            var __workflow_bodyfinancialSupportId = WorkflowExpression.Compile(bodyfinancialSupportId, nameof(bodyfinancialSupportId), required: false);
            var __workflow_bodyhearAboutUs = WorkflowExpression.Compile(bodyhearAboutUs, nameof(bodyhearAboutUs), required: false);
            var __workflow_bodyhonorsIndicator = WorkflowExpression.Compile(bodyhonorsIndicator, nameof(bodyhonorsIndicator), required: false);
            var __workflow_bodyimmunizationsHold = WorkflowExpression.Compile(bodyimmunizationsHold, nameof(bodyimmunizationsHold), required: false);
            var __workflow_bodyincidentHold = WorkflowExpression.Compile(bodyincidentHold, nameof(bodyincidentHold), required: false);
            var __workflow_bodyincidentHoldComments = WorkflowExpression.Compile(bodyincidentHoldComments, nameof(bodyincidentHoldComments), required: false);
            var __workflow_bodyinternational = WorkflowExpression.Compile(bodyinternational, nameof(bodyinternational), required: false);
            var __workflow_bodyinternationalDetails = WorkflowExpression.Compile(bodyinternationalDetails, nameof(bodyinternationalDetails), required: false);
            var __workflow_bodylivingWithDependents = WorkflowExpression.Compile(bodylivingWithDependents, nameof(bodylivingWithDependents), required: false);
            var __workflow_bodymarried = WorkflowExpression.Compile(bodymarried, nameof(bodymarried), required: false);
            var __workflow_bodymedical = WorkflowExpression.Compile(bodymedical, nameof(bodymedical), required: false);
            var __workflow_bodynationalityId = WorkflowExpression.Compile(bodynationalityId, nameof(bodynationalityId), required: false);
            var __workflow_bodyoccupation = WorkflowExpression.Compile(bodyoccupation, nameof(bodyoccupation), required: false);
            var __workflow_bodyphotoPath = WorkflowExpression.Compile(bodyphotoPath, nameof(bodyphotoPath), required: false);
            var __workflow_bodypreviousMemberName = WorkflowExpression.Compile(bodypreviousMemberName, nameof(bodypreviousMemberName), required: false);
            var __workflow_bodypreviousMemberRelationship = WorkflowExpression.Compile(bodypreviousMemberRelationship, nameof(bodypreviousMemberRelationship), required: false);
            var __workflow_bodypreviousMembership = WorkflowExpression.Compile(bodypreviousMembership, nameof(bodypreviousMembership), required: false);
            var __workflow_bodypreviousMembershipYears = WorkflowExpression.Compile(bodypreviousMembershipYears, nameof(bodypreviousMembershipYears), required: false);
            var __workflow_bodypreviousMemberYears = WorkflowExpression.Compile(bodypreviousMemberYears, nameof(bodypreviousMemberYears), required: false);
            var __workflow_bodyprofileInterests = WorkflowExpression.Compile(bodyprofileInterests, nameof(bodyprofileInterests), required: false);
            var __workflow_bodyregionOfBirthId = WorkflowExpression.Compile(bodyregionOfBirthId, nameof(bodyregionOfBirthId), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyresidency = WorkflowExpression.Compile(bodyresidency, nameof(bodyresidency), required: false);
            var __workflow_bodyresidentStatus = WorkflowExpression.Compile(bodyresidentStatus, nameof(bodyresidentStatus), required: false);
            var __workflow_bodyresidentYear = WorkflowExpression.Compile(bodyresidentYear, nameof(bodyresidentYear), required: false);
            var __workflow_bodysituationResponseComments = WorkflowExpression.Compile(bodysituationResponseComments, nameof(bodysituationResponseComments), required: false);
            var __workflow_bodysituationResponseDetail = WorkflowExpression.Compile(bodysituationResponseDetail, nameof(bodysituationResponseDetail), required: false);
            var __workflow_bodysituationResponseEnum = WorkflowExpression.Compile(bodysituationResponseEnum, nameof(bodysituationResponseEnum), required: false);
            var __workflow_bodysituationResponseExpiryDatevalue = WorkflowExpression.Compile(bodysituationResponseExpiryDatevalue, nameof(bodysituationResponseExpiryDatevalue), required: false);
            var __workflow_bodysituationResponseExpiryDateOperator = WorkflowExpression.Compile(bodysituationResponseExpiryDateOperator, nameof(bodysituationResponseExpiryDateOperator), required: false);
            var __workflow_bodysituationResponseModifiedDatevalue = WorkflowExpression.Compile(bodysituationResponseModifiedDatevalue, nameof(bodysituationResponseModifiedDatevalue), required: false);
            var __workflow_bodysituationResponseModifiedDateOperator = WorkflowExpression.Compile(bodysituationResponseModifiedDateOperator, nameof(bodysituationResponseModifiedDateOperator), required: false);
            var __workflow_bodysituationResponseSituation = WorkflowExpression.Compile(bodysituationResponseSituation, nameof(bodysituationResponseSituation), required: false);
            var __workflow_bodyspecialNeeds = WorkflowExpression.Compile(bodyspecialNeeds, nameof(bodyspecialNeeds), required: false);
            var __workflow_bodystaffId = WorkflowExpression.Compile(bodystaffId, nameof(bodystaffId), required: false);
            var __workflow_bodyusesScreenReader = WorkflowExpression.Compile(bodyusesScreenReader, nameof(bodyusesScreenReader), required: false);
            var __workflow_bodyvehicleDetails = WorkflowExpression.Compile(bodyvehicleDetails, nameof(bodyvehicleDetails), required: false);
            var __workflow_bodyvehiclePermit = WorkflowExpression.Compile(bodyvehiclePermit, nameof(bodyvehiclePermit), required: false);
            var __workflow_bodyvehicleRegistration = WorkflowExpression.Compile(bodyvehicleRegistration, nameof(bodyvehicleRegistration), required: false);
            var __workflow_bodyveteranStatus = WorkflowExpression.Compile(bodyveteranStatus, nameof(bodyveteranStatus), required: false);
            var __workflow_bodyvisa = WorkflowExpression.Compile(bodyvisa, nameof(bodyvisa), required: false);
            var __workflow_bodyvisaDetails = WorkflowExpression.Compile(bodyvisaDetails, nameof(bodyvisaDetails), required: false);
            var __workflow_bodyvisitorHold = WorkflowExpression.Compile(bodyvisitorHold, nameof(bodyvisitorHold), required: false);
            return new DeferredBodyAction<SelectEntryDetailResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryDetail.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyacademicHold != null)
                {
                    body["AcademicHold"] = ExpressionConverter.ConvertO(__workflow_bodyacademicHold);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountPaymentTypeId != null)
                {
                    body["Account_PaymentTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaccountPaymentTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountHold != null)
                {
                    body["AccountHold"] = ExpressionConverter.ConvertO(__workflow_bodyaccountHold);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountBankName != null)
                {
                    body["AccountBankName"] = ExpressionConverter.ConvertO(__workflow_bodyaccountBankName);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountBankNumber != null)
                {
                    body["AccountBankNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaccountBankNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountCode != null)
                {
                    body["AccountCode"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCode);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountComments != null)
                {
                    body["AccountComments"] = ExpressionConverter.ConvertO(__workflow_bodyaccountComments);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail1 != null)
                {
                    body["AccountDetail1"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail1);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail2 != null)
                {
                    body["AccountDetail2"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail2);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail3 != null)
                {
                    body["AccountDetail3"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail3);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail4 != null)
                {
                    body["AccountDetail4"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail4);
                    bodypropCount++;
                }

                var accountDueDateObject = new JObject();
                var accountDueDateObjectpropCount = 0;
                if (__workflow_bodyaccountDueDatevalue != null)
                {
                    accountDueDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDueDatevalue);
                    accountDueDateObjectpropCount++;
                }

                if (__workflow_bodyaccountDueDateOperator != null)
                {
                    accountDueDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDueDateOperator);
                    accountDueDateObjectpropCount++;
                }

                if (accountDueDateObjectpropCount > 0)
                {
                    body["AccountDueDate"] = accountDueDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyathlete != null)
                {
                    body["Athlete"] = ExpressionConverter.ConvertO(__workflow_bodyathlete);
                    bodypropCount++;
                }

                if (__workflow_bodyathleteTeam != null)
                {
                    body["AthleteTeam"] = ExpressionConverter.ConvertO(__workflow_bodyathleteTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyattendeeStatusEnum != null)
                {
                    body["AttendeeStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyattendeeStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycareer != null)
                {
                    body["Career"] = ExpressionConverter.ConvertO(__workflow_bodycareer);
                    bodypropCount++;
                }

                if (__workflow_bodycareerComments != null)
                {
                    body["CareerComments"] = ExpressionConverter.ConvertO(__workflow_bodycareerComments);
                    bodypropCount++;
                }

                if (__workflow_bodycitizenshipCountryId != null)
                {
                    body["Citizenship_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycitizenshipCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["ClassificationID"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationOverride != null)
                {
                    body["ClassificationOverride"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationOverride);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycountryOfBirthCountryId != null)
                {
                    body["CountryOfBirth_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryOfBirthCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycountryOfResidenceCountryId != null)
                {
                    body["CountryOfResidence_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryOfResidenceCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycumulativeGPA != null)
                {
                    body["CumulativeGPA"] = ExpressionConverter.ConvertO(__workflow_bodycumulativeGPA);
                    bodypropCount++;
                }

                if (__workflow_bodycumulativeHours != null)
                {
                    body["CumulativeHours"] = ExpressionConverter.ConvertO(__workflow_bodycumulativeHours);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentGPA != null)
                {
                    body["CurrentGPA"] = ExpressionConverter.ConvertO(__workflow_bodycurrentGPA);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentHours != null)
                {
                    body["CurrentHours"] = ExpressionConverter.ConvertO(__workflow_bodycurrentHours);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentMajor != null)
                {
                    body["CurrentMajor"] = ExpressionConverter.ConvertO(__workflow_bodycurrentMajor);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentMinor != null)
                {
                    body["CurrentMinor"] = ExpressionConverter.ConvertO(__workflow_bodycurrentMinor);
                    bodypropCount++;
                }

                var dateEntryObject = new JObject();
                var dateEntryObjectpropCount = 0;
                if (__workflow_bodydateEntryvalue != null)
                {
                    dateEntryObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateEntryvalue);
                    dateEntryObjectpropCount++;
                }

                if (__workflow_bodydateEntryOperator != null)
                {
                    dateEntryObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateEntryOperator);
                    dateEntryObjectpropCount++;
                }

                if (dateEntryObjectpropCount > 0)
                {
                    body["DateEntry"] = dateEntryObject;
                    bodypropCount++;
                }

                var dateExitObject = new JObject();
                var dateExitObjectpropCount = 0;
                if (__workflow_bodydateExitvalue != null)
                {
                    dateExitObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateExitvalue);
                    dateExitObjectpropCount++;
                }

                if (__workflow_bodydateExitOperator != null)
                {
                    dateExitObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateExitOperator);
                    dateExitObjectpropCount++;
                }

                if (dateExitObjectpropCount > 0)
                {
                    body["DateExit"] = dateExitObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydeceased != null)
                {
                    body["Deceased"] = ExpressionConverter.ConvertO(__workflow_bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (__workflow_bodydeceasedDatevalue != null)
                {
                    deceasedDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDatevalue);
                    deceasedDateObjectpropCount++;
                }

                if (__workflow_bodydeceasedDateOperator != null)
                {
                    deceasedDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDateOperator);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["DeceasedDate"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodydietary != null)
                {
                    body["Dietary"] = ExpressionConverter.ConvertO(__workflow_bodydietary);
                    bodypropCount++;
                }

                if (__workflow_bodydisability != null)
                {
                    body["Disability"] = ExpressionConverter.ConvertO(__workflow_bodydisability);
                    bodypropCount++;
                }

                if (__workflow_bodyemploymentDetails != null)
                {
                    body["EmploymentDetails"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentClass != null)
                {
                    body["EnrollmentClass"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentClass);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentLevel != null)
                {
                    body["EnrollmentLevel"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentLevel);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentStatus != null)
                {
                    body["EnrollmentStatus"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentTerm != null)
                {
                    body["EnrollmentTerm"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentTerm);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentYear != null)
                {
                    body["EnrollmentYear"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentYear);
                    bodypropCount++;
                }

                if (__workflow_bodyentryDetailId != null)
                {
                    body["EntryDetailID"] = ExpressionConverter.ConvertO(__workflow_bodyentryDetailId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["Ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodyeventRegistrationFeeId != null)
                {
                    body["EventRegistrationFeeID"] = ExpressionConverter.ConvertO(__workflow_bodyeventRegistrationFeeId);
                    bodypropCount++;
                }

                var expectedGraduationDateObject = new JObject();
                var expectedGraduationDateObjectpropCount = 0;
                if (__workflow_bodyexpectedGraduationDatevalue != null)
                {
                    expectedGraduationDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedGraduationDatevalue);
                    expectedGraduationDateObjectpropCount++;
                }

                if (__workflow_bodyexpectedGraduationDateOperator != null)
                {
                    expectedGraduationDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedGraduationDateOperator);
                    expectedGraduationDateObjectpropCount++;
                }

                if (expectedGraduationDateObjectpropCount > 0)
                {
                    body["ExpectedGraduationDate"] = expectedGraduationDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialComments != null)
                {
                    body["FinancialComments"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialComments);
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialSupportId != null)
                {
                    body["FinancialSupportID"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialSupportId);
                    bodypropCount++;
                }

                if (__workflow_bodyhearAboutUs != null)
                {
                    body["HearAboutUs"] = ExpressionConverter.ConvertO(__workflow_bodyhearAboutUs);
                    bodypropCount++;
                }

                if (__workflow_bodyhonorsIndicator != null)
                {
                    body["HonorsIndicator"] = ExpressionConverter.ConvertO(__workflow_bodyhonorsIndicator);
                    bodypropCount++;
                }

                if (__workflow_bodyimmunizationsHold != null)
                {
                    body["ImmunizationsHold"] = ExpressionConverter.ConvertO(__workflow_bodyimmunizationsHold);
                    bodypropCount++;
                }

                if (__workflow_bodyincidentHold != null)
                {
                    body["IncidentHold"] = ExpressionConverter.ConvertO(__workflow_bodyincidentHold);
                    bodypropCount++;
                }

                if (__workflow_bodyincidentHoldComments != null)
                {
                    body["IncidentHoldComments"] = ExpressionConverter.ConvertO(__workflow_bodyincidentHoldComments);
                    bodypropCount++;
                }

                if (__workflow_bodyinternational != null)
                {
                    body["International"] = ExpressionConverter.ConvertO(__workflow_bodyinternational);
                    bodypropCount++;
                }

                if (__workflow_bodyinternationalDetails != null)
                {
                    body["InternationalDetails"] = ExpressionConverter.ConvertO(__workflow_bodyinternationalDetails);
                    bodypropCount++;
                }

                if (__workflow_bodylivingWithDependents != null)
                {
                    body["LivingWithDependents"] = ExpressionConverter.ConvertO(__workflow_bodylivingWithDependents);
                    bodypropCount++;
                }

                if (__workflow_bodymarried != null)
                {
                    body["Married"] = ExpressionConverter.ConvertO(__workflow_bodymarried);
                    bodypropCount++;
                }

                if (__workflow_bodymedical != null)
                {
                    body["Medical"] = ExpressionConverter.ConvertO(__workflow_bodymedical);
                    bodypropCount++;
                }

                if (__workflow_bodynationalityId != null)
                {
                    body["NationalityID"] = ExpressionConverter.ConvertO(__workflow_bodynationalityId);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupation != null)
                {
                    body["Occupation"] = ExpressionConverter.ConvertO(__workflow_bodyoccupation);
                    bodypropCount++;
                }

                if (__workflow_bodyphotoPath != null)
                {
                    body["PhotoPath"] = ExpressionConverter.ConvertO(__workflow_bodyphotoPath);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberName != null)
                {
                    body["PreviousMemberName"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberName);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberRelationship != null)
                {
                    body["PreviousMemberRelationship"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberRelationship);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMembership != null)
                {
                    body["PreviousMembership"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMembership);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMembershipYears != null)
                {
                    body["PreviousMembershipYears"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMembershipYears);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberYears != null)
                {
                    body["PreviousMemberYears"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberYears);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileInterests != null)
                {
                    body["ProfileInterests"] = ExpressionConverter.ConvertO(__workflow_bodyprofileInterests);
                    bodypropCount++;
                }

                if (__workflow_bodyregionOfBirthId != null)
                {
                    body["RegionOfBirthID"] = ExpressionConverter.ConvertO(__workflow_bodyregionOfBirthId);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["Religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                if (__workflow_bodyresidency != null)
                {
                    body["Residency"] = ExpressionConverter.ConvertO(__workflow_bodyresidency);
                    bodypropCount++;
                }

                if (__workflow_bodyresidentStatus != null)
                {
                    body["ResidentStatus"] = ExpressionConverter.ConvertO(__workflow_bodyresidentStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyresidentYear != null)
                {
                    body["ResidentYear"] = ExpressionConverter.ConvertO(__workflow_bodyresidentYear);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseComments != null)
                {
                    body["SituationResponseComments"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseComments);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseDetail != null)
                {
                    body["SituationResponseDetail"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseDetail);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseEnum != null)
                {
                    body["SituationResponseEnum"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseEnum);
                    bodypropCount++;
                }

                var situationResponseExpiryDateObject = new JObject();
                var situationResponseExpiryDateObjectpropCount = 0;
                if (__workflow_bodysituationResponseExpiryDatevalue != null)
                {
                    situationResponseExpiryDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseExpiryDatevalue);
                    situationResponseExpiryDateObjectpropCount++;
                }

                if (__workflow_bodysituationResponseExpiryDateOperator != null)
                {
                    situationResponseExpiryDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseExpiryDateOperator);
                    situationResponseExpiryDateObjectpropCount++;
                }

                if (situationResponseExpiryDateObjectpropCount > 0)
                {
                    body["SituationResponseExpiryDate"] = situationResponseExpiryDateObject;
                    bodypropCount++;
                }

                var situationResponseModifiedDateObject = new JObject();
                var situationResponseModifiedDateObjectpropCount = 0;
                if (__workflow_bodysituationResponseModifiedDatevalue != null)
                {
                    situationResponseModifiedDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseModifiedDatevalue);
                    situationResponseModifiedDateObjectpropCount++;
                }

                if (__workflow_bodysituationResponseModifiedDateOperator != null)
                {
                    situationResponseModifiedDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseModifiedDateOperator);
                    situationResponseModifiedDateObjectpropCount++;
                }

                if (situationResponseModifiedDateObjectpropCount > 0)
                {
                    body["SituationResponseModifiedDate"] = situationResponseModifiedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseSituation != null)
                {
                    body["SituationResponseSituation"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseSituation);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialNeeds != null)
                {
                    body["SpecialNeeds"] = ExpressionConverter.ConvertO(__workflow_bodyspecialNeeds);
                    bodypropCount++;
                }

                if (__workflow_bodystaffId != null)
                {
                    body["StaffID"] = ExpressionConverter.ConvertO(__workflow_bodystaffId);
                    bodypropCount++;
                }

                if (__workflow_bodyusesScreenReader != null)
                {
                    body["UsesScreenReader"] = ExpressionConverter.ConvertO(__workflow_bodyusesScreenReader);
                    bodypropCount++;
                }

                if (__workflow_bodyvehicleDetails != null)
                {
                    body["VehicleDetails"] = ExpressionConverter.ConvertO(__workflow_bodyvehicleDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyvehiclePermit != null)
                {
                    body["VehiclePermit"] = ExpressionConverter.ConvertO(__workflow_bodyvehiclePermit);
                    bodypropCount++;
                }

                if (__workflow_bodyvehicleRegistration != null)
                {
                    body["VehicleRegistration"] = ExpressionConverter.ConvertO(__workflow_bodyvehicleRegistration);
                    bodypropCount++;
                }

                if (__workflow_bodyveteranStatus != null)
                {
                    body["VeteranStatus"] = ExpressionConverter.ConvertO(__workflow_bodyveteranStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyvisa != null)
                {
                    body["Visa"] = ExpressionConverter.ConvertO(__workflow_bodyvisa);
                    bodypropCount++;
                }

                if (__workflow_bodyvisaDetails != null)
                {
                    body["VisaDetails"] = ExpressionConverter.ConvertO(__workflow_bodyvisaDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyvisitorHold != null)
                {
                    body["VisitorHold"] = ExpressionConverter.ConvertO(__workflow_bodyvisitorHold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryDetailResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryDetailResponse, ApiConnectionActionConfiguration> UpdateEntryDetail(Expression<Func<int>> entryDetailId, Expression<Func<bool>> bodyacademicHold = null, Expression<Func<int>> bodyaccountPaymentTypeId = null, Expression<Func<string>> bodyaccountBankName = null, Expression<Func<string>> bodyaccountBankNumber = null, Expression<Func<string>> bodyaccountCode = null, Expression<Func<string>> bodyaccountComments = null, Expression<Func<string>> bodyaccountDetail1 = null, Expression<Func<string>> bodyaccountDetail2 = null, Expression<Func<string>> bodyaccountDetail3 = null, Expression<Func<string>> bodyaccountDetail4 = null, Expression<Func<string>> bodyaccountDueDate = null, Expression<Func<bool>> bodyaccountHold = null, Expression<Func<bool>> bodyathlete = null, Expression<Func<string>> bodyathleteTeam = null, Expression<Func<bodyattendeeStatusEnumInput>> bodyattendeeStatusEnum = null, Expression<Func<string>> bodycareer = null, Expression<Func<string>> bodycareerComments = null, Expression<Func<int>> bodycitizenshipCountryId = null, Expression<Func<int>> bodyclassificationId = null, Expression<Func<bool>> bodyclassificationOverride = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycountryOfBirthCountryId = null, Expression<Func<int>> bodycountryOfResidenceCountryId = null, Expression<Func<double>> bodycumulativeGPA = null, Expression<Func<double>> bodycumulativeHours = null, Expression<Func<double>> bodycurrentGPA = null, Expression<Func<double>> bodycurrentHours = null, Expression<Func<string>> bodycurrentMajor = null, Expression<Func<string>> bodycurrentMinor = null, Expression<Func<string>> bodydateEntry = null, Expression<Func<string>> bodydateExit = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<string>> bodydeceasedDate = null, Expression<Func<string>> bodydietary = null, Expression<Func<string>> bodydisability = null, Expression<Func<string>> bodyemploymentDetails = null, Expression<Func<string>> bodyenrollmentClass = null, Expression<Func<string>> bodyenrollmentLevel = null, Expression<Func<string>> bodyenrollmentStatus = null, Expression<Func<string>> bodyenrollmentTerm = null, Expression<Func<int>> bodyenrollmentYear = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<int>> bodyeventRegistrationFeeId = null, Expression<Func<string>> bodyexpectedGraduationDate = null, Expression<Func<string>> bodyfinancialComments = null, Expression<Func<int>> bodyfinancialSupportId = null, Expression<Func<string>> bodyhearAboutUs = null, Expression<Func<bool>> bodyhonorsIndicator = null, Expression<Func<bool>> bodyimmunizationsHold = null, Expression<Func<bool>> bodyincidentHold = null, Expression<Func<string>> bodyincidentHoldComments = null, Expression<Func<bool>> bodyinternational = null, Expression<Func<string>> bodyinternationalDetails = null, Expression<Func<bool>> bodylivingWithDependents = null, Expression<Func<bool>> bodymarried = null, Expression<Func<string>> bodymedical = null, Expression<Func<int>> bodynationalityId = null, Expression<Func<string>> bodyoccupation = null, Expression<Func<string>> bodyphotoPath = null, Expression<Func<string>> bodypreviousMemberName = null, Expression<Func<string>> bodypreviousMemberRelationship = null, Expression<Func<string>> bodypreviousMembership = null, Expression<Func<string>> bodypreviousMembershipYears = null, Expression<Func<string>> bodypreviousMemberYears = null, Expression<Func<string>> bodyprofileInterests = null, Expression<Func<int>> bodyregionOfBirthId = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyresidency = null, Expression<Func<string>> bodyresidentStatus = null, Expression<Func<int>> bodyresidentYear = null, Expression<Func<string>> bodysituationResponseComments = null, Expression<Func<string>> bodysituationResponseDetail = null, Expression<Func<bodysituationResponseEnumInput>> bodysituationResponseEnum = null, Expression<Func<string>> bodysituationResponseExpiryDate = null, Expression<Func<string>> bodysituationResponseModifiedDate = null, Expression<Func<string>> bodysituationResponseSituation = null, Expression<Func<string>> bodyspecialNeeds = null, Expression<Func<int>> bodystaffId = null, Expression<Func<bool>> bodyusesScreenReader = null, Expression<Func<string>> bodyvehicleDetails = null, Expression<Func<string>> bodyvehiclePermit = null, Expression<Func<string>> bodyvehicleRegistration = null, Expression<Func<string>> bodyveteranStatus = null, Expression<Func<bool>> bodyvisa = null, Expression<Func<string>> bodyvisaDetails = null, Expression<Func<bool>> bodyvisitorHold = null)
        {
            var __workflow_entryDetailId = WorkflowExpression.Compile(entryDetailId, nameof(entryDetailId), required: true);
            var __workflow_bodyacademicHold = WorkflowExpression.Compile(bodyacademicHold, nameof(bodyacademicHold), required: false);
            var __workflow_bodyaccountPaymentTypeId = WorkflowExpression.Compile(bodyaccountPaymentTypeId, nameof(bodyaccountPaymentTypeId), required: false);
            var __workflow_bodyaccountBankName = WorkflowExpression.Compile(bodyaccountBankName, nameof(bodyaccountBankName), required: false);
            var __workflow_bodyaccountBankNumber = WorkflowExpression.Compile(bodyaccountBankNumber, nameof(bodyaccountBankNumber), required: false);
            var __workflow_bodyaccountCode = WorkflowExpression.Compile(bodyaccountCode, nameof(bodyaccountCode), required: false);
            var __workflow_bodyaccountComments = WorkflowExpression.Compile(bodyaccountComments, nameof(bodyaccountComments), required: false);
            var __workflow_bodyaccountDetail1 = WorkflowExpression.Compile(bodyaccountDetail1, nameof(bodyaccountDetail1), required: false);
            var __workflow_bodyaccountDetail2 = WorkflowExpression.Compile(bodyaccountDetail2, nameof(bodyaccountDetail2), required: false);
            var __workflow_bodyaccountDetail3 = WorkflowExpression.Compile(bodyaccountDetail3, nameof(bodyaccountDetail3), required: false);
            var __workflow_bodyaccountDetail4 = WorkflowExpression.Compile(bodyaccountDetail4, nameof(bodyaccountDetail4), required: false);
            var __workflow_bodyaccountDueDate = WorkflowExpression.Compile(bodyaccountDueDate, nameof(bodyaccountDueDate), required: false);
            var __workflow_bodyaccountHold = WorkflowExpression.Compile(bodyaccountHold, nameof(bodyaccountHold), required: false);
            var __workflow_bodyathlete = WorkflowExpression.Compile(bodyathlete, nameof(bodyathlete), required: false);
            var __workflow_bodyathleteTeam = WorkflowExpression.Compile(bodyathleteTeam, nameof(bodyathleteTeam), required: false);
            var __workflow_bodyattendeeStatusEnum = WorkflowExpression.Compile(bodyattendeeStatusEnum, nameof(bodyattendeeStatusEnum), required: false);
            var __workflow_bodycareer = WorkflowExpression.Compile(bodycareer, nameof(bodycareer), required: false);
            var __workflow_bodycareerComments = WorkflowExpression.Compile(bodycareerComments, nameof(bodycareerComments), required: false);
            var __workflow_bodycitizenshipCountryId = WorkflowExpression.Compile(bodycitizenshipCountryId, nameof(bodycitizenshipCountryId), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodyclassificationOverride = WorkflowExpression.Compile(bodyclassificationOverride, nameof(bodyclassificationOverride), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycountryOfBirthCountryId = WorkflowExpression.Compile(bodycountryOfBirthCountryId, nameof(bodycountryOfBirthCountryId), required: false);
            var __workflow_bodycountryOfResidenceCountryId = WorkflowExpression.Compile(bodycountryOfResidenceCountryId, nameof(bodycountryOfResidenceCountryId), required: false);
            var __workflow_bodycumulativeGPA = WorkflowExpression.Compile(bodycumulativeGPA, nameof(bodycumulativeGPA), required: false);
            var __workflow_bodycumulativeHours = WorkflowExpression.Compile(bodycumulativeHours, nameof(bodycumulativeHours), required: false);
            var __workflow_bodycurrentGPA = WorkflowExpression.Compile(bodycurrentGPA, nameof(bodycurrentGPA), required: false);
            var __workflow_bodycurrentHours = WorkflowExpression.Compile(bodycurrentHours, nameof(bodycurrentHours), required: false);
            var __workflow_bodycurrentMajor = WorkflowExpression.Compile(bodycurrentMajor, nameof(bodycurrentMajor), required: false);
            var __workflow_bodycurrentMinor = WorkflowExpression.Compile(bodycurrentMinor, nameof(bodycurrentMinor), required: false);
            var __workflow_bodydateEntry = WorkflowExpression.Compile(bodydateEntry, nameof(bodydateEntry), required: false);
            var __workflow_bodydateExit = WorkflowExpression.Compile(bodydateExit, nameof(bodydateExit), required: false);
            var __workflow_bodydeceased = WorkflowExpression.Compile(bodydeceased, nameof(bodydeceased), required: false);
            var __workflow_bodydeceasedDate = WorkflowExpression.Compile(bodydeceasedDate, nameof(bodydeceasedDate), required: false);
            var __workflow_bodydietary = WorkflowExpression.Compile(bodydietary, nameof(bodydietary), required: false);
            var __workflow_bodydisability = WorkflowExpression.Compile(bodydisability, nameof(bodydisability), required: false);
            var __workflow_bodyemploymentDetails = WorkflowExpression.Compile(bodyemploymentDetails, nameof(bodyemploymentDetails), required: false);
            var __workflow_bodyenrollmentClass = WorkflowExpression.Compile(bodyenrollmentClass, nameof(bodyenrollmentClass), required: false);
            var __workflow_bodyenrollmentLevel = WorkflowExpression.Compile(bodyenrollmentLevel, nameof(bodyenrollmentLevel), required: false);
            var __workflow_bodyenrollmentStatus = WorkflowExpression.Compile(bodyenrollmentStatus, nameof(bodyenrollmentStatus), required: false);
            var __workflow_bodyenrollmentTerm = WorkflowExpression.Compile(bodyenrollmentTerm, nameof(bodyenrollmentTerm), required: false);
            var __workflow_bodyenrollmentYear = WorkflowExpression.Compile(bodyenrollmentYear, nameof(bodyenrollmentYear), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodyeventRegistrationFeeId = WorkflowExpression.Compile(bodyeventRegistrationFeeId, nameof(bodyeventRegistrationFeeId), required: false);
            var __workflow_bodyexpectedGraduationDate = WorkflowExpression.Compile(bodyexpectedGraduationDate, nameof(bodyexpectedGraduationDate), required: false);
            var __workflow_bodyfinancialComments = WorkflowExpression.Compile(bodyfinancialComments, nameof(bodyfinancialComments), required: false);
            var __workflow_bodyfinancialSupportId = WorkflowExpression.Compile(bodyfinancialSupportId, nameof(bodyfinancialSupportId), required: false);
            var __workflow_bodyhearAboutUs = WorkflowExpression.Compile(bodyhearAboutUs, nameof(bodyhearAboutUs), required: false);
            var __workflow_bodyhonorsIndicator = WorkflowExpression.Compile(bodyhonorsIndicator, nameof(bodyhonorsIndicator), required: false);
            var __workflow_bodyimmunizationsHold = WorkflowExpression.Compile(bodyimmunizationsHold, nameof(bodyimmunizationsHold), required: false);
            var __workflow_bodyincidentHold = WorkflowExpression.Compile(bodyincidentHold, nameof(bodyincidentHold), required: false);
            var __workflow_bodyincidentHoldComments = WorkflowExpression.Compile(bodyincidentHoldComments, nameof(bodyincidentHoldComments), required: false);
            var __workflow_bodyinternational = WorkflowExpression.Compile(bodyinternational, nameof(bodyinternational), required: false);
            var __workflow_bodyinternationalDetails = WorkflowExpression.Compile(bodyinternationalDetails, nameof(bodyinternationalDetails), required: false);
            var __workflow_bodylivingWithDependents = WorkflowExpression.Compile(bodylivingWithDependents, nameof(bodylivingWithDependents), required: false);
            var __workflow_bodymarried = WorkflowExpression.Compile(bodymarried, nameof(bodymarried), required: false);
            var __workflow_bodymedical = WorkflowExpression.Compile(bodymedical, nameof(bodymedical), required: false);
            var __workflow_bodynationalityId = WorkflowExpression.Compile(bodynationalityId, nameof(bodynationalityId), required: false);
            var __workflow_bodyoccupation = WorkflowExpression.Compile(bodyoccupation, nameof(bodyoccupation), required: false);
            var __workflow_bodyphotoPath = WorkflowExpression.Compile(bodyphotoPath, nameof(bodyphotoPath), required: false);
            var __workflow_bodypreviousMemberName = WorkflowExpression.Compile(bodypreviousMemberName, nameof(bodypreviousMemberName), required: false);
            var __workflow_bodypreviousMemberRelationship = WorkflowExpression.Compile(bodypreviousMemberRelationship, nameof(bodypreviousMemberRelationship), required: false);
            var __workflow_bodypreviousMembership = WorkflowExpression.Compile(bodypreviousMembership, nameof(bodypreviousMembership), required: false);
            var __workflow_bodypreviousMembershipYears = WorkflowExpression.Compile(bodypreviousMembershipYears, nameof(bodypreviousMembershipYears), required: false);
            var __workflow_bodypreviousMemberYears = WorkflowExpression.Compile(bodypreviousMemberYears, nameof(bodypreviousMemberYears), required: false);
            var __workflow_bodyprofileInterests = WorkflowExpression.Compile(bodyprofileInterests, nameof(bodyprofileInterests), required: false);
            var __workflow_bodyregionOfBirthId = WorkflowExpression.Compile(bodyregionOfBirthId, nameof(bodyregionOfBirthId), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyresidency = WorkflowExpression.Compile(bodyresidency, nameof(bodyresidency), required: false);
            var __workflow_bodyresidentStatus = WorkflowExpression.Compile(bodyresidentStatus, nameof(bodyresidentStatus), required: false);
            var __workflow_bodyresidentYear = WorkflowExpression.Compile(bodyresidentYear, nameof(bodyresidentYear), required: false);
            var __workflow_bodysituationResponseComments = WorkflowExpression.Compile(bodysituationResponseComments, nameof(bodysituationResponseComments), required: false);
            var __workflow_bodysituationResponseDetail = WorkflowExpression.Compile(bodysituationResponseDetail, nameof(bodysituationResponseDetail), required: false);
            var __workflow_bodysituationResponseEnum = WorkflowExpression.Compile(bodysituationResponseEnum, nameof(bodysituationResponseEnum), required: false);
            var __workflow_bodysituationResponseExpiryDate = WorkflowExpression.Compile(bodysituationResponseExpiryDate, nameof(bodysituationResponseExpiryDate), required: false);
            var __workflow_bodysituationResponseModifiedDate = WorkflowExpression.Compile(bodysituationResponseModifiedDate, nameof(bodysituationResponseModifiedDate), required: false);
            var __workflow_bodysituationResponseSituation = WorkflowExpression.Compile(bodysituationResponseSituation, nameof(bodysituationResponseSituation), required: false);
            var __workflow_bodyspecialNeeds = WorkflowExpression.Compile(bodyspecialNeeds, nameof(bodyspecialNeeds), required: false);
            var __workflow_bodystaffId = WorkflowExpression.Compile(bodystaffId, nameof(bodystaffId), required: false);
            var __workflow_bodyusesScreenReader = WorkflowExpression.Compile(bodyusesScreenReader, nameof(bodyusesScreenReader), required: false);
            var __workflow_bodyvehicleDetails = WorkflowExpression.Compile(bodyvehicleDetails, nameof(bodyvehicleDetails), required: false);
            var __workflow_bodyvehiclePermit = WorkflowExpression.Compile(bodyvehiclePermit, nameof(bodyvehiclePermit), required: false);
            var __workflow_bodyvehicleRegistration = WorkflowExpression.Compile(bodyvehicleRegistration, nameof(bodyvehicleRegistration), required: false);
            var __workflow_bodyveteranStatus = WorkflowExpression.Compile(bodyveteranStatus, nameof(bodyveteranStatus), required: false);
            var __workflow_bodyvisa = WorkflowExpression.Compile(bodyvisa, nameof(bodyvisa), required: false);
            var __workflow_bodyvisaDetails = WorkflowExpression.Compile(bodyvisaDetails, nameof(bodyvisaDetails), required: false);
            var __workflow_bodyvisitorHold = WorkflowExpression.Compile(bodyvisitorHold, nameof(bodyvisitorHold), required: false);
            return new DeferredBodyAction<UpdateEntryDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entrydetail.json/{0}", __workflow_entryDetailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyacademicHold != null)
                {
                    body["AcademicHold"] = ExpressionConverter.ConvertO(__workflow_bodyacademicHold);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountPaymentTypeId != null)
                {
                    body["Account_PaymentTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyaccountPaymentTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountBankName != null)
                {
                    body["AccountBankName"] = ExpressionConverter.ConvertO(__workflow_bodyaccountBankName);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountBankNumber != null)
                {
                    body["AccountBankNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaccountBankNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountCode != null)
                {
                    body["AccountCode"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCode);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountComments != null)
                {
                    body["AccountComments"] = ExpressionConverter.ConvertO(__workflow_bodyaccountComments);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail1 != null)
                {
                    body["AccountDetail1"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail1);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail2 != null)
                {
                    body["AccountDetail2"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail2);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail3 != null)
                {
                    body["AccountDetail3"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail3);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDetail4 != null)
                {
                    body["AccountDetail4"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDetail4);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDueDate != null)
                {
                    body["AccountDueDate"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountHold != null)
                {
                    body["AccountHold"] = ExpressionConverter.ConvertO(__workflow_bodyaccountHold);
                    bodypropCount++;
                }

                if (__workflow_bodyathlete != null)
                {
                    body["Athlete"] = ExpressionConverter.ConvertO(__workflow_bodyathlete);
                    bodypropCount++;
                }

                if (__workflow_bodyathleteTeam != null)
                {
                    body["AthleteTeam"] = ExpressionConverter.ConvertO(__workflow_bodyathleteTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyattendeeStatusEnum != null)
                {
                    body["AttendeeStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyattendeeStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodycareer != null)
                {
                    body["Career"] = ExpressionConverter.ConvertO(__workflow_bodycareer);
                    bodypropCount++;
                }

                if (__workflow_bodycareerComments != null)
                {
                    body["CareerComments"] = ExpressionConverter.ConvertO(__workflow_bodycareerComments);
                    bodypropCount++;
                }

                if (__workflow_bodycitizenshipCountryId != null)
                {
                    body["Citizenship_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycitizenshipCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["ClassificationID"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationOverride != null)
                {
                    body["ClassificationOverride"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationOverride);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycountryOfBirthCountryId != null)
                {
                    body["CountryOfBirth_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryOfBirthCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycountryOfResidenceCountryId != null)
                {
                    body["CountryOfResidence_CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryOfResidenceCountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycumulativeGPA != null)
                {
                    body["CumulativeGPA"] = ExpressionConverter.ConvertO(__workflow_bodycumulativeGPA);
                    bodypropCount++;
                }

                if (__workflow_bodycumulativeHours != null)
                {
                    body["CumulativeHours"] = ExpressionConverter.ConvertO(__workflow_bodycumulativeHours);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentGPA != null)
                {
                    body["CurrentGPA"] = ExpressionConverter.ConvertO(__workflow_bodycurrentGPA);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentHours != null)
                {
                    body["CurrentHours"] = ExpressionConverter.ConvertO(__workflow_bodycurrentHours);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentMajor != null)
                {
                    body["CurrentMajor"] = ExpressionConverter.ConvertO(__workflow_bodycurrentMajor);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentMinor != null)
                {
                    body["CurrentMinor"] = ExpressionConverter.ConvertO(__workflow_bodycurrentMinor);
                    bodypropCount++;
                }

                if (__workflow_bodydateEntry != null)
                {
                    body["DateEntry"] = ExpressionConverter.ConvertO(__workflow_bodydateEntry);
                    bodypropCount++;
                }

                if (__workflow_bodydateExit != null)
                {
                    body["DateExit"] = ExpressionConverter.ConvertO(__workflow_bodydateExit);
                    bodypropCount++;
                }

                if (__workflow_bodydeceased != null)
                {
                    body["Deceased"] = ExpressionConverter.ConvertO(__workflow_bodydeceased);
                    bodypropCount++;
                }

                if (__workflow_bodydeceasedDate != null)
                {
                    body["DeceasedDate"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDate);
                    bodypropCount++;
                }

                if (__workflow_bodydietary != null)
                {
                    body["Dietary"] = ExpressionConverter.ConvertO(__workflow_bodydietary);
                    bodypropCount++;
                }

                if (__workflow_bodydisability != null)
                {
                    body["Disability"] = ExpressionConverter.ConvertO(__workflow_bodydisability);
                    bodypropCount++;
                }

                if (__workflow_bodyemploymentDetails != null)
                {
                    body["EmploymentDetails"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentClass != null)
                {
                    body["EnrollmentClass"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentClass);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentLevel != null)
                {
                    body["EnrollmentLevel"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentLevel);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentStatus != null)
                {
                    body["EnrollmentStatus"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentTerm != null)
                {
                    body["EnrollmentTerm"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentTerm);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentYear != null)
                {
                    body["EnrollmentYear"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentYear);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["Ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodyeventRegistrationFeeId != null)
                {
                    body["EventRegistrationFeeID"] = ExpressionConverter.ConvertO(__workflow_bodyeventRegistrationFeeId);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedGraduationDate != null)
                {
                    body["ExpectedGraduationDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedGraduationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialComments != null)
                {
                    body["FinancialComments"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialComments);
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialSupportId != null)
                {
                    body["FinancialSupportID"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialSupportId);
                    bodypropCount++;
                }

                if (__workflow_bodyhearAboutUs != null)
                {
                    body["HearAboutUs"] = ExpressionConverter.ConvertO(__workflow_bodyhearAboutUs);
                    bodypropCount++;
                }

                if (__workflow_bodyhonorsIndicator != null)
                {
                    body["HonorsIndicator"] = ExpressionConverter.ConvertO(__workflow_bodyhonorsIndicator);
                    bodypropCount++;
                }

                if (__workflow_bodyimmunizationsHold != null)
                {
                    body["ImmunizationsHold"] = ExpressionConverter.ConvertO(__workflow_bodyimmunizationsHold);
                    bodypropCount++;
                }

                if (__workflow_bodyincidentHold != null)
                {
                    body["IncidentHold"] = ExpressionConverter.ConvertO(__workflow_bodyincidentHold);
                    bodypropCount++;
                }

                if (__workflow_bodyincidentHoldComments != null)
                {
                    body["IncidentHoldComments"] = ExpressionConverter.ConvertO(__workflow_bodyincidentHoldComments);
                    bodypropCount++;
                }

                if (__workflow_bodyinternational != null)
                {
                    body["International"] = ExpressionConverter.ConvertO(__workflow_bodyinternational);
                    bodypropCount++;
                }

                if (__workflow_bodyinternationalDetails != null)
                {
                    body["InternationalDetails"] = ExpressionConverter.ConvertO(__workflow_bodyinternationalDetails);
                    bodypropCount++;
                }

                if (__workflow_bodylivingWithDependents != null)
                {
                    body["LivingWithDependents"] = ExpressionConverter.ConvertO(__workflow_bodylivingWithDependents);
                    bodypropCount++;
                }

                if (__workflow_bodymarried != null)
                {
                    body["Married"] = ExpressionConverter.ConvertO(__workflow_bodymarried);
                    bodypropCount++;
                }

                if (__workflow_bodymedical != null)
                {
                    body["Medical"] = ExpressionConverter.ConvertO(__workflow_bodymedical);
                    bodypropCount++;
                }

                if (__workflow_bodynationalityId != null)
                {
                    body["NationalityID"] = ExpressionConverter.ConvertO(__workflow_bodynationalityId);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupation != null)
                {
                    body["Occupation"] = ExpressionConverter.ConvertO(__workflow_bodyoccupation);
                    bodypropCount++;
                }

                if (__workflow_bodyphotoPath != null)
                {
                    body["PhotoPath"] = ExpressionConverter.ConvertO(__workflow_bodyphotoPath);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberName != null)
                {
                    body["PreviousMemberName"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberName);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberRelationship != null)
                {
                    body["PreviousMemberRelationship"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberRelationship);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMembership != null)
                {
                    body["PreviousMembership"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMembership);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMembershipYears != null)
                {
                    body["PreviousMembershipYears"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMembershipYears);
                    bodypropCount++;
                }

                if (__workflow_bodypreviousMemberYears != null)
                {
                    body["PreviousMemberYears"] = ExpressionConverter.ConvertO(__workflow_bodypreviousMemberYears);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileInterests != null)
                {
                    body["ProfileInterests"] = ExpressionConverter.ConvertO(__workflow_bodyprofileInterests);
                    bodypropCount++;
                }

                if (__workflow_bodyregionOfBirthId != null)
                {
                    body["RegionOfBirthID"] = ExpressionConverter.ConvertO(__workflow_bodyregionOfBirthId);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["Religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                if (__workflow_bodyresidency != null)
                {
                    body["Residency"] = ExpressionConverter.ConvertO(__workflow_bodyresidency);
                    bodypropCount++;
                }

                if (__workflow_bodyresidentStatus != null)
                {
                    body["ResidentStatus"] = ExpressionConverter.ConvertO(__workflow_bodyresidentStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyresidentYear != null)
                {
                    body["ResidentYear"] = ExpressionConverter.ConvertO(__workflow_bodyresidentYear);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseComments != null)
                {
                    body["SituationResponseComments"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseComments);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseDetail != null)
                {
                    body["SituationResponseDetail"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseDetail);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseEnum != null)
                {
                    body["SituationResponseEnum"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseEnum);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseExpiryDate != null)
                {
                    body["SituationResponseExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseExpiryDate);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseModifiedDate != null)
                {
                    body["SituationResponseModifiedDate"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseModifiedDate);
                    bodypropCount++;
                }

                if (__workflow_bodysituationResponseSituation != null)
                {
                    body["SituationResponseSituation"] = ExpressionConverter.ConvertO(__workflow_bodysituationResponseSituation);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialNeeds != null)
                {
                    body["SpecialNeeds"] = ExpressionConverter.ConvertO(__workflow_bodyspecialNeeds);
                    bodypropCount++;
                }

                if (__workflow_bodystaffId != null)
                {
                    body["StaffID"] = ExpressionConverter.ConvertO(__workflow_bodystaffId);
                    bodypropCount++;
                }

                if (__workflow_bodyusesScreenReader != null)
                {
                    body["UsesScreenReader"] = ExpressionConverter.ConvertO(__workflow_bodyusesScreenReader);
                    bodypropCount++;
                }

                if (__workflow_bodyvehicleDetails != null)
                {
                    body["VehicleDetails"] = ExpressionConverter.ConvertO(__workflow_bodyvehicleDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyvehiclePermit != null)
                {
                    body["VehiclePermit"] = ExpressionConverter.ConvertO(__workflow_bodyvehiclePermit);
                    bodypropCount++;
                }

                if (__workflow_bodyvehicleRegistration != null)
                {
                    body["VehicleRegistration"] = ExpressionConverter.ConvertO(__workflow_bodyvehicleRegistration);
                    bodypropCount++;
                }

                if (__workflow_bodyveteranStatus != null)
                {
                    body["VeteranStatus"] = ExpressionConverter.ConvertO(__workflow_bodyveteranStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyvisa != null)
                {
                    body["Visa"] = ExpressionConverter.ConvertO(__workflow_bodyvisa);
                    bodypropCount++;
                }

                if (__workflow_bodyvisaDetails != null)
                {
                    body["VisaDetails"] = ExpressionConverter.ConvertO(__workflow_bodyvisaDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyvisitorHold != null)
                {
                    body["VisitorHold"] = ExpressionConverter.ConvertO(__workflow_bodyvisitorHold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryEnrollmentResponseItem[], ApiConnectionActionConfiguration> SelectEntryEnrollment(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycourseId = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateEndvalue = null, Expression<Func<bodydateEndOperatorInput>> bodydateEndOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydateStartvalue = null, Expression<Func<bodydateStartOperatorInput>> bodydateStartOperator = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyenrollmentField = null, Expression<Func<int>> bodyenrollmentOrder = null, Expression<Func<bodyenrollmentTypeEnumInput>> bodyenrollmentTypeEnum = null, Expression<Func<int>> bodyentryEnrollmentId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<bool>> bodyfullTime = null, Expression<Func<string>> bodygraduationDatevalue = null, Expression<Func<bodygraduationDateOperatorInput>> bodygraduationDateOperator = null, Expression<Func<string>> bodyinstitution = null, Expression<Func<bool>> bodyisEnrolled = null, Expression<Func<string>> bodymajor = null, Expression<Func<string>> bodymajorCategory = null, Expression<Func<string>> bodyminor = null, Expression<Func<bool>> bodypostGrad = null, Expression<Func<int>> bodysequence = null, Expression<Func<string>> bodysubjects = null, Expression<Func<int>> bodytermId = null, Expression<Func<string>> bodyyears = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateEndvalue = WorkflowExpression.Compile(bodydateEndvalue, nameof(bodydateEndvalue), required: false);
            var __workflow_bodydateEndOperator = WorkflowExpression.Compile(bodydateEndOperator, nameof(bodydateEndOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydateStartvalue = WorkflowExpression.Compile(bodydateStartvalue, nameof(bodydateStartvalue), required: false);
            var __workflow_bodydateStartOperator = WorkflowExpression.Compile(bodydateStartOperator, nameof(bodydateStartOperator), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyenrollmentField = WorkflowExpression.Compile(bodyenrollmentField, nameof(bodyenrollmentField), required: false);
            var __workflow_bodyenrollmentOrder = WorkflowExpression.Compile(bodyenrollmentOrder, nameof(bodyenrollmentOrder), required: false);
            var __workflow_bodyenrollmentTypeEnum = WorkflowExpression.Compile(bodyenrollmentTypeEnum, nameof(bodyenrollmentTypeEnum), required: false);
            var __workflow_bodyentryEnrollmentId = WorkflowExpression.Compile(bodyentryEnrollmentId, nameof(bodyentryEnrollmentId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyfullTime = WorkflowExpression.Compile(bodyfullTime, nameof(bodyfullTime), required: false);
            var __workflow_bodygraduationDatevalue = WorkflowExpression.Compile(bodygraduationDatevalue, nameof(bodygraduationDatevalue), required: false);
            var __workflow_bodygraduationDateOperator = WorkflowExpression.Compile(bodygraduationDateOperator, nameof(bodygraduationDateOperator), required: false);
            var __workflow_bodyinstitution = WorkflowExpression.Compile(bodyinstitution, nameof(bodyinstitution), required: false);
            var __workflow_bodyisEnrolled = WorkflowExpression.Compile(bodyisEnrolled, nameof(bodyisEnrolled), required: false);
            var __workflow_bodymajor = WorkflowExpression.Compile(bodymajor, nameof(bodymajor), required: false);
            var __workflow_bodymajorCategory = WorkflowExpression.Compile(bodymajorCategory, nameof(bodymajorCategory), required: false);
            var __workflow_bodyminor = WorkflowExpression.Compile(bodyminor, nameof(bodyminor), required: false);
            var __workflow_bodypostGrad = WorkflowExpression.Compile(bodypostGrad, nameof(bodypostGrad), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            var __workflow_bodysubjects = WorkflowExpression.Compile(bodysubjects, nameof(bodysubjects), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyyears = WorkflowExpression.Compile(bodyyears, nameof(bodyyears), required: false);
            return new DeferredBodyAction<SelectEntryEnrollmentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryEnrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodycampus != null)
                {
                    body["Campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycourseId != null)
                {
                    body["CourseID"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                var dateEndObject = new JObject();
                var dateEndObjectpropCount = 0;
                if (__workflow_bodydateEndvalue != null)
                {
                    dateEndObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateEndvalue);
                    dateEndObjectpropCount++;
                }

                if (__workflow_bodydateEndOperator != null)
                {
                    dateEndObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateEndOperator);
                    dateEndObjectpropCount++;
                }

                if (dateEndObjectpropCount > 0)
                {
                    body["DateEnd"] = dateEndObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateStartObject = new JObject();
                var dateStartObjectpropCount = 0;
                if (__workflow_bodydateStartvalue != null)
                {
                    dateStartObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateStartvalue);
                    dateStartObjectpropCount++;
                }

                if (__workflow_bodydateStartOperator != null)
                {
                    dateStartObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateStartOperator);
                    dateStartObjectpropCount++;
                }

                if (dateStartObjectpropCount > 0)
                {
                    body["DateStart"] = dateStartObject;
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["Department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentField);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyentryEnrollmentId != null)
                {
                    body["EntryEnrollmentID"] = ExpressionConverter.ConvertO(__workflow_bodyentryEnrollmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["Faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyfullTime != null)
                {
                    body["FullTime"] = ExpressionConverter.ConvertO(__workflow_bodyfullTime);
                    bodypropCount++;
                }

                var graduationDateObject = new JObject();
                var graduationDateObjectpropCount = 0;
                if (__workflow_bodygraduationDatevalue != null)
                {
                    graduationDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodygraduationDatevalue);
                    graduationDateObjectpropCount++;
                }

                if (__workflow_bodygraduationDateOperator != null)
                {
                    graduationDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodygraduationDateOperator);
                    graduationDateObjectpropCount++;
                }

                if (graduationDateObjectpropCount > 0)
                {
                    body["GraduationDate"] = graduationDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinstitution != null)
                {
                    body["Institution"] = ExpressionConverter.ConvertO(__workflow_bodyinstitution);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = ExpressionConverter.ConvertO(__workflow_bodyisEnrolled);
                    bodypropCount++;
                }

                if (__workflow_bodymajor != null)
                {
                    body["Major"] = ExpressionConverter.ConvertO(__workflow_bodymajor);
                    bodypropCount++;
                }

                if (__workflow_bodymajorCategory != null)
                {
                    body["MajorCategory"] = ExpressionConverter.ConvertO(__workflow_bodymajorCategory);
                    bodypropCount++;
                }

                if (__workflow_bodyminor != null)
                {
                    body["Minor"] = ExpressionConverter.ConvertO(__workflow_bodyminor);
                    bodypropCount++;
                }

                if (__workflow_bodypostGrad != null)
                {
                    body["PostGrad"] = ExpressionConverter.ConvertO(__workflow_bodypostGrad);
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["Sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (__workflow_bodysubjects != null)
                {
                    body["Subjects"] = ExpressionConverter.ConvertO(__workflow_bodysubjects);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyyears != null)
                {
                    body["Years"] = ExpressionConverter.ConvertO(__workflow_bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectEntryEnrollmentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryEnrollmentResponse, ApiConnectionActionConfiguration> CreateEntryEnrollment(Expression<Func<int>> bodyentryId, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycourseId = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateEnd = null, Expression<Func<string>> bodydateStart = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyenrollmentField = null, Expression<Func<int>> bodyenrollmentOrder = null, Expression<Func<bodyenrollmentTypeEnumInput>> bodyenrollmentTypeEnum = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<bool>> bodyfullTime = null, Expression<Func<string>> bodygraduationDate = null, Expression<Func<string>> bodyinstitution = null, Expression<Func<bool>> bodyisEnrolled = null, Expression<Func<string>> bodymajor = null, Expression<Func<string>> bodymajorCategory = null, Expression<Func<string>> bodyminor = null, Expression<Func<bool>> bodypostGrad = null, Expression<Func<int>> bodysequence = null, Expression<Func<string>> bodysubjects = null, Expression<Func<int>> bodytermId = null, Expression<Func<string>> bodyyears = null)
        {
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: true);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateEnd = WorkflowExpression.Compile(bodydateEnd, nameof(bodydateEnd), required: false);
            var __workflow_bodydateStart = WorkflowExpression.Compile(bodydateStart, nameof(bodydateStart), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyenrollmentField = WorkflowExpression.Compile(bodyenrollmentField, nameof(bodyenrollmentField), required: false);
            var __workflow_bodyenrollmentOrder = WorkflowExpression.Compile(bodyenrollmentOrder, nameof(bodyenrollmentOrder), required: false);
            var __workflow_bodyenrollmentTypeEnum = WorkflowExpression.Compile(bodyenrollmentTypeEnum, nameof(bodyenrollmentTypeEnum), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyfullTime = WorkflowExpression.Compile(bodyfullTime, nameof(bodyfullTime), required: false);
            var __workflow_bodygraduationDate = WorkflowExpression.Compile(bodygraduationDate, nameof(bodygraduationDate), required: false);
            var __workflow_bodyinstitution = WorkflowExpression.Compile(bodyinstitution, nameof(bodyinstitution), required: false);
            var __workflow_bodyisEnrolled = WorkflowExpression.Compile(bodyisEnrolled, nameof(bodyisEnrolled), required: false);
            var __workflow_bodymajor = WorkflowExpression.Compile(bodymajor, nameof(bodymajor), required: false);
            var __workflow_bodymajorCategory = WorkflowExpression.Compile(bodymajorCategory, nameof(bodymajorCategory), required: false);
            var __workflow_bodyminor = WorkflowExpression.Compile(bodyminor, nameof(bodyminor), required: false);
            var __workflow_bodypostGrad = WorkflowExpression.Compile(bodypostGrad, nameof(bodypostGrad), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            var __workflow_bodysubjects = WorkflowExpression.Compile(bodysubjects, nameof(bodysubjects), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyyears = WorkflowExpression.Compile(bodyyears, nameof(bodyyears), required: false);
            return new DeferredBodyAction<CreateEntryEnrollmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entryenrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampus != null)
                {
                    body["Campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycourseId != null)
                {
                    body["CourseID"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodydateEnd != null)
                {
                    body["DateEnd"] = ExpressionConverter.ConvertO(__workflow_bodydateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodydateStart != null)
                {
                    body["DateStart"] = ExpressionConverter.ConvertO(__workflow_bodydateStart);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["Department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentField);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                if (__workflow_bodyfaculty != null)
                {
                    body["Faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyfullTime != null)
                {
                    body["FullTime"] = ExpressionConverter.ConvertO(__workflow_bodyfullTime);
                    bodypropCount++;
                }

                if (__workflow_bodygraduationDate != null)
                {
                    body["GraduationDate"] = ExpressionConverter.ConvertO(__workflow_bodygraduationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyinstitution != null)
                {
                    body["Institution"] = ExpressionConverter.ConvertO(__workflow_bodyinstitution);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = ExpressionConverter.ConvertO(__workflow_bodyisEnrolled);
                    bodypropCount++;
                }

                if (__workflow_bodymajor != null)
                {
                    body["Major"] = ExpressionConverter.ConvertO(__workflow_bodymajor);
                    bodypropCount++;
                }

                if (__workflow_bodymajorCategory != null)
                {
                    body["MajorCategory"] = ExpressionConverter.ConvertO(__workflow_bodymajorCategory);
                    bodypropCount++;
                }

                if (__workflow_bodyminor != null)
                {
                    body["Minor"] = ExpressionConverter.ConvertO(__workflow_bodyminor);
                    bodypropCount++;
                }

                if (__workflow_bodypostGrad != null)
                {
                    body["PostGrad"] = ExpressionConverter.ConvertO(__workflow_bodypostGrad);
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["Sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (__workflow_bodysubjects != null)
                {
                    body["Subjects"] = ExpressionConverter.ConvertO(__workflow_bodysubjects);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyyears != null)
                {
                    body["Years"] = ExpressionConverter.ConvertO(__workflow_bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEntryEnrollmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryEnrollmentResponse, ApiConnectionActionConfiguration> UpdateEntryEnrollment(Expression<Func<int>> entryEnrollmentId, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycourseId = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateEnd = null, Expression<Func<string>> bodydateStart = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyenrollmentField = null, Expression<Func<int>> bodyenrollmentOrder = null, Expression<Func<bodyenrollmentTypeEnumInput>> bodyenrollmentTypeEnum = null, Expression<Func<int>> bodyentryId = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<bool>> bodyfullTime = null, Expression<Func<string>> bodygraduationDate = null, Expression<Func<string>> bodyinstitution = null, Expression<Func<bool>> bodyisEnrolled = null, Expression<Func<string>> bodymajor = null, Expression<Func<string>> bodymajorCategory = null, Expression<Func<string>> bodyminor = null, Expression<Func<bool>> bodypostGrad = null, Expression<Func<int>> bodysequence = null, Expression<Func<string>> bodysubjects = null, Expression<Func<int>> bodytermId = null, Expression<Func<string>> bodyyears = null)
        {
            var __workflow_entryEnrollmentId = WorkflowExpression.Compile(entryEnrollmentId, nameof(entryEnrollmentId), required: true);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycourseId = WorkflowExpression.Compile(bodycourseId, nameof(bodycourseId), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateEnd = WorkflowExpression.Compile(bodydateEnd, nameof(bodydateEnd), required: false);
            var __workflow_bodydateStart = WorkflowExpression.Compile(bodydateStart, nameof(bodydateStart), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyenrollmentField = WorkflowExpression.Compile(bodyenrollmentField, nameof(bodyenrollmentField), required: false);
            var __workflow_bodyenrollmentOrder = WorkflowExpression.Compile(bodyenrollmentOrder, nameof(bodyenrollmentOrder), required: false);
            var __workflow_bodyenrollmentTypeEnum = WorkflowExpression.Compile(bodyenrollmentTypeEnum, nameof(bodyenrollmentTypeEnum), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyfullTime = WorkflowExpression.Compile(bodyfullTime, nameof(bodyfullTime), required: false);
            var __workflow_bodygraduationDate = WorkflowExpression.Compile(bodygraduationDate, nameof(bodygraduationDate), required: false);
            var __workflow_bodyinstitution = WorkflowExpression.Compile(bodyinstitution, nameof(bodyinstitution), required: false);
            var __workflow_bodyisEnrolled = WorkflowExpression.Compile(bodyisEnrolled, nameof(bodyisEnrolled), required: false);
            var __workflow_bodymajor = WorkflowExpression.Compile(bodymajor, nameof(bodymajor), required: false);
            var __workflow_bodymajorCategory = WorkflowExpression.Compile(bodymajorCategory, nameof(bodymajorCategory), required: false);
            var __workflow_bodyminor = WorkflowExpression.Compile(bodyminor, nameof(bodyminor), required: false);
            var __workflow_bodypostGrad = WorkflowExpression.Compile(bodypostGrad, nameof(bodypostGrad), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            var __workflow_bodysubjects = WorkflowExpression.Compile(bodysubjects, nameof(bodysubjects), required: false);
            var __workflow_bodytermId = WorkflowExpression.Compile(bodytermId, nameof(bodytermId), required: false);
            var __workflow_bodyyears = WorkflowExpression.Compile(bodyyears, nameof(bodyyears), required: false);
            return new DeferredBodyAction<UpdateEntryEnrollmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryenrollment.json/{0}", __workflow_entryEnrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampus != null)
                {
                    body["Campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycourseId != null)
                {
                    body["CourseID"] = ExpressionConverter.ConvertO(__workflow_bodycourseId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodydateEnd != null)
                {
                    body["DateEnd"] = ExpressionConverter.ConvertO(__workflow_bodydateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodydateStart != null)
                {
                    body["DateStart"] = ExpressionConverter.ConvertO(__workflow_bodydateStart);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["Department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentField);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["Faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyfullTime != null)
                {
                    body["FullTime"] = ExpressionConverter.ConvertO(__workflow_bodyfullTime);
                    bodypropCount++;
                }

                if (__workflow_bodygraduationDate != null)
                {
                    body["GraduationDate"] = ExpressionConverter.ConvertO(__workflow_bodygraduationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyinstitution != null)
                {
                    body["Institution"] = ExpressionConverter.ConvertO(__workflow_bodyinstitution);
                    bodypropCount++;
                }

                if (__workflow_bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = ExpressionConverter.ConvertO(__workflow_bodyisEnrolled);
                    bodypropCount++;
                }

                if (__workflow_bodymajor != null)
                {
                    body["Major"] = ExpressionConverter.ConvertO(__workflow_bodymajor);
                    bodypropCount++;
                }

                if (__workflow_bodymajorCategory != null)
                {
                    body["MajorCategory"] = ExpressionConverter.ConvertO(__workflow_bodymajorCategory);
                    bodypropCount++;
                }

                if (__workflow_bodyminor != null)
                {
                    body["Minor"] = ExpressionConverter.ConvertO(__workflow_bodyminor);
                    bodypropCount++;
                }

                if (__workflow_bodypostGrad != null)
                {
                    body["PostGrad"] = ExpressionConverter.ConvertO(__workflow_bodypostGrad);
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["Sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (__workflow_bodysubjects != null)
                {
                    body["Subjects"] = ExpressionConverter.ConvertO(__workflow_bodysubjects);
                    bodypropCount++;
                }

                if (__workflow_bodytermId != null)
                {
                    body["TermID"] = ExpressionConverter.ConvertO(__workflow_bodytermId);
                    bodypropCount++;
                }

                if (__workflow_bodyyears != null)
                {
                    body["Years"] = ExpressionConverter.ConvertO(__workflow_bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEntryEnrollmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectBookingResponseItem[], ApiConnectionActionConfiguration> SelectBooking(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyadditionalOccupantCount = null, Expression<Func<string>> bodyautoAllocationDetail = null, Expression<Func<int>> bodybookingId = null, Expression<Func<bodybookingLinkTypeEnumInput>> bodybookingLinkTypeEnum = null, Expression<Func<int>> bodybookingTypeId = null, Expression<Func<string>> bodycheckInDatevalue = null, Expression<Func<bodycheckInDateOperatorInput>> bodycheckInDateOperator = null, Expression<Func<string>> bodycheckInDateActualvalue = null, Expression<Func<bodycheckInDateActualOperatorInput>> bodycheckInDateActualOperator = null, Expression<Func<string>> bodycheckOutDatevalue = null, Expression<Func<bodycheckOutDateOperatorInput>> bodycheckOutDateOperator = null, Expression<Func<string>> bodycheckOutDateActualvalue = null, Expression<Func<bodycheckOutDateActualOperatorInput>> bodycheckOutDateActualOperator = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycontractDateEndvalue = null, Expression<Func<bodycontractDateEndOperatorInput>> bodycontractDateEndOperator = null, Expression<Func<string>> bodycontractDateStartvalue = null, Expression<Func<bodycontractDateStartOperatorInput>> bodycontractDateStartOperator = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomDate3value = null, Expression<Func<bodycustomDate3OperatorInput>> bodycustomDate3Operator = null, Expression<Func<string>> bodycustomDate4value = null, Expression<Func<bodycustomDate4OperatorInput>> bodycustomDate4Operator = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodycustomString7 = null, Expression<Func<string>> bodycustomString8 = null, Expression<Func<string>> bodycustomString9 = null, Expression<Func<string>> bodycustomString10 = null, Expression<Func<string>> bodydateBilledvalue = null, Expression<Func<bodydateBilledOperatorInput>> bodydateBilledOperator = null, Expression<Func<string>> bodydateChargedTovalue = null, Expression<Func<bodydateChargedToOperatorInput>> bodydateChargedToOperator = null, Expression<Func<string>> bodydateCreatedvalue = null, Expression<Func<bodydateCreatedOperatorInput>> bodydateCreatedOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydateModifiedBillingvalue = null, Expression<Func<bodydateModifiedBillingOperatorInput>> bodydateModifiedBillingOperator = null, Expression<Func<int>> bodyemotionalSupportAnimalCount = null, Expression<Func<int>> bodyendBookingReasonId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<int>> bodyentryInvitationId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<string>> bodyeTA = null, Expression<Func<string>> bodyeTD = null, Expression<Func<double>> bodyexcess = null, Expression<Func<int>> bodygroupId = null, Expression<Func<int>> bodyhousekeepingId = null, Expression<Func<int>> bodynumberOfChildren = null, Expression<Func<int>> bodynumberOfChildrenFree = null, Expression<Func<int>> bodynumberOfGuests = null, Expression<Func<int>> bodynumberOfGuestsFree = null, Expression<Func<string>> bodypaidTovalue = null, Expression<Func<bodypaidToOperatorInput>> bodypaidToOperator = null, Expression<Func<int>> bodypetCount = null, Expression<Func<bool>> bodyresvChargeToEntry = null, Expression<Func<bool>> bodyroomLocationFixed = null, Expression<Func<int>> bodyroomLocationId = null, Expression<Func<double>> bodyroomRateAmount = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<int>> bodyroomTypeId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodyserviceAnimalCount = null, Expression<Func<string>> bodyspecialRequirement = null, Expression<Func<int>> bodystartBookingReasonId = null, Expression<Func<int>> bodytermSessionId = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyadditionalOccupantCount = WorkflowExpression.Compile(bodyadditionalOccupantCount, nameof(bodyadditionalOccupantCount), required: false);
            var __workflow_bodyautoAllocationDetail = WorkflowExpression.Compile(bodyautoAllocationDetail, nameof(bodyautoAllocationDetail), required: false);
            var __workflow_bodybookingId = WorkflowExpression.Compile(bodybookingId, nameof(bodybookingId), required: false);
            var __workflow_bodybookingLinkTypeEnum = WorkflowExpression.Compile(bodybookingLinkTypeEnum, nameof(bodybookingLinkTypeEnum), required: false);
            var __workflow_bodybookingTypeId = WorkflowExpression.Compile(bodybookingTypeId, nameof(bodybookingTypeId), required: false);
            var __workflow_bodycheckInDatevalue = WorkflowExpression.Compile(bodycheckInDatevalue, nameof(bodycheckInDatevalue), required: false);
            var __workflow_bodycheckInDateOperator = WorkflowExpression.Compile(bodycheckInDateOperator, nameof(bodycheckInDateOperator), required: false);
            var __workflow_bodycheckInDateActualvalue = WorkflowExpression.Compile(bodycheckInDateActualvalue, nameof(bodycheckInDateActualvalue), required: false);
            var __workflow_bodycheckInDateActualOperator = WorkflowExpression.Compile(bodycheckInDateActualOperator, nameof(bodycheckInDateActualOperator), required: false);
            var __workflow_bodycheckOutDatevalue = WorkflowExpression.Compile(bodycheckOutDatevalue, nameof(bodycheckOutDatevalue), required: false);
            var __workflow_bodycheckOutDateOperator = WorkflowExpression.Compile(bodycheckOutDateOperator, nameof(bodycheckOutDateOperator), required: false);
            var __workflow_bodycheckOutDateActualvalue = WorkflowExpression.Compile(bodycheckOutDateActualvalue, nameof(bodycheckOutDateActualvalue), required: false);
            var __workflow_bodycheckOutDateActualOperator = WorkflowExpression.Compile(bodycheckOutDateActualOperator, nameof(bodycheckOutDateActualOperator), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycontractDateEndvalue = WorkflowExpression.Compile(bodycontractDateEndvalue, nameof(bodycontractDateEndvalue), required: false);
            var __workflow_bodycontractDateEndOperator = WorkflowExpression.Compile(bodycontractDateEndOperator, nameof(bodycontractDateEndOperator), required: false);
            var __workflow_bodycontractDateStartvalue = WorkflowExpression.Compile(bodycontractDateStartvalue, nameof(bodycontractDateStartvalue), required: false);
            var __workflow_bodycontractDateStartOperator = WorkflowExpression.Compile(bodycontractDateStartOperator, nameof(bodycontractDateStartOperator), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomDate3value = WorkflowExpression.Compile(bodycustomDate3value, nameof(bodycustomDate3value), required: false);
            var __workflow_bodycustomDate3Operator = WorkflowExpression.Compile(bodycustomDate3Operator, nameof(bodycustomDate3Operator), required: false);
            var __workflow_bodycustomDate4value = WorkflowExpression.Compile(bodycustomDate4value, nameof(bodycustomDate4value), required: false);
            var __workflow_bodycustomDate4Operator = WorkflowExpression.Compile(bodycustomDate4Operator, nameof(bodycustomDate4Operator), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodycustomString7 = WorkflowExpression.Compile(bodycustomString7, nameof(bodycustomString7), required: false);
            var __workflow_bodycustomString8 = WorkflowExpression.Compile(bodycustomString8, nameof(bodycustomString8), required: false);
            var __workflow_bodycustomString9 = WorkflowExpression.Compile(bodycustomString9, nameof(bodycustomString9), required: false);
            var __workflow_bodycustomString10 = WorkflowExpression.Compile(bodycustomString10, nameof(bodycustomString10), required: false);
            var __workflow_bodydateBilledvalue = WorkflowExpression.Compile(bodydateBilledvalue, nameof(bodydateBilledvalue), required: false);
            var __workflow_bodydateBilledOperator = WorkflowExpression.Compile(bodydateBilledOperator, nameof(bodydateBilledOperator), required: false);
            var __workflow_bodydateChargedTovalue = WorkflowExpression.Compile(bodydateChargedTovalue, nameof(bodydateChargedTovalue), required: false);
            var __workflow_bodydateChargedToOperator = WorkflowExpression.Compile(bodydateChargedToOperator, nameof(bodydateChargedToOperator), required: false);
            var __workflow_bodydateCreatedvalue = WorkflowExpression.Compile(bodydateCreatedvalue, nameof(bodydateCreatedvalue), required: false);
            var __workflow_bodydateCreatedOperator = WorkflowExpression.Compile(bodydateCreatedOperator, nameof(bodydateCreatedOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydateModifiedBillingvalue = WorkflowExpression.Compile(bodydateModifiedBillingvalue, nameof(bodydateModifiedBillingvalue), required: false);
            var __workflow_bodydateModifiedBillingOperator = WorkflowExpression.Compile(bodydateModifiedBillingOperator, nameof(bodydateModifiedBillingOperator), required: false);
            var __workflow_bodyemotionalSupportAnimalCount = WorkflowExpression.Compile(bodyemotionalSupportAnimalCount, nameof(bodyemotionalSupportAnimalCount), required: false);
            var __workflow_bodyendBookingReasonId = WorkflowExpression.Compile(bodyendBookingReasonId, nameof(bodyendBookingReasonId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyentryInvitationId = WorkflowExpression.Compile(bodyentryInvitationId, nameof(bodyentryInvitationId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeTA = WorkflowExpression.Compile(bodyeTA, nameof(bodyeTA), required: false);
            var __workflow_bodyeTD = WorkflowExpression.Compile(bodyeTD, nameof(bodyeTD), required: false);
            var __workflow_bodyexcess = WorkflowExpression.Compile(bodyexcess, nameof(bodyexcess), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyhousekeepingId = WorkflowExpression.Compile(bodyhousekeepingId, nameof(bodyhousekeepingId), required: false);
            var __workflow_bodynumberOfChildren = WorkflowExpression.Compile(bodynumberOfChildren, nameof(bodynumberOfChildren), required: false);
            var __workflow_bodynumberOfChildrenFree = WorkflowExpression.Compile(bodynumberOfChildrenFree, nameof(bodynumberOfChildrenFree), required: false);
            var __workflow_bodynumberOfGuests = WorkflowExpression.Compile(bodynumberOfGuests, nameof(bodynumberOfGuests), required: false);
            var __workflow_bodynumberOfGuestsFree = WorkflowExpression.Compile(bodynumberOfGuestsFree, nameof(bodynumberOfGuestsFree), required: false);
            var __workflow_bodypaidTovalue = WorkflowExpression.Compile(bodypaidTovalue, nameof(bodypaidTovalue), required: false);
            var __workflow_bodypaidToOperator = WorkflowExpression.Compile(bodypaidToOperator, nameof(bodypaidToOperator), required: false);
            var __workflow_bodypetCount = WorkflowExpression.Compile(bodypetCount, nameof(bodypetCount), required: false);
            var __workflow_bodyresvChargeToEntry = WorkflowExpression.Compile(bodyresvChargeToEntry, nameof(bodyresvChargeToEntry), required: false);
            var __workflow_bodyroomLocationFixed = WorkflowExpression.Compile(bodyroomLocationFixed, nameof(bodyroomLocationFixed), required: false);
            var __workflow_bodyroomLocationId = WorkflowExpression.Compile(bodyroomLocationId, nameof(bodyroomLocationId), required: false);
            var __workflow_bodyroomRateAmount = WorkflowExpression.Compile(bodyroomRateAmount, nameof(bodyroomRateAmount), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomTypeId = WorkflowExpression.Compile(bodyroomTypeId, nameof(bodyroomTypeId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodyserviceAnimalCount = WorkflowExpression.Compile(bodyserviceAnimalCount, nameof(bodyserviceAnimalCount), required: false);
            var __workflow_bodyspecialRequirement = WorkflowExpression.Compile(bodyspecialRequirement, nameof(bodyspecialRequirement), required: false);
            var __workflow_bodystartBookingReasonId = WorkflowExpression.Compile(bodystartBookingReasonId, nameof(bodystartBookingReasonId), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            return new DeferredBodyAction<SelectBookingResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (__workflow_bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(__workflow_bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (__workflow_bodybookingId != null)
                {
                    body["BookingID"] = ExpressionConverter.ConvertO(__workflow_bodybookingId);
                    bodypropCount++;
                }

                if (__workflow_bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = ExpressionConverter.ConvertO(__workflow_bodybookingTypeId);
                    bodypropCount++;
                }

                var checkInDateObject = new JObject();
                var checkInDateObjectpropCount = 0;
                if (__workflow_bodycheckInDatevalue != null)
                {
                    checkInDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDatevalue);
                    checkInDateObjectpropCount++;
                }

                if (__workflow_bodycheckInDateOperator != null)
                {
                    checkInDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateOperator);
                    checkInDateObjectpropCount++;
                }

                if (checkInDateObjectpropCount > 0)
                {
                    body["CheckInDate"] = checkInDateObject;
                    bodypropCount++;
                }

                var checkInDateActualObject = new JObject();
                var checkInDateActualObjectpropCount = 0;
                if (__workflow_bodycheckInDateActualvalue != null)
                {
                    checkInDateActualObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActualvalue);
                    checkInDateActualObjectpropCount++;
                }

                if (__workflow_bodycheckInDateActualOperator != null)
                {
                    checkInDateActualObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActualOperator);
                    checkInDateActualObjectpropCount++;
                }

                if (checkInDateActualObjectpropCount > 0)
                {
                    body["CheckInDateActual"] = checkInDateActualObject;
                    bodypropCount++;
                }

                var checkOutDateObject = new JObject();
                var checkOutDateObjectpropCount = 0;
                if (__workflow_bodycheckOutDatevalue != null)
                {
                    checkOutDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDatevalue);
                    checkOutDateObjectpropCount++;
                }

                if (__workflow_bodycheckOutDateOperator != null)
                {
                    checkOutDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateOperator);
                    checkOutDateObjectpropCount++;
                }

                if (checkOutDateObjectpropCount > 0)
                {
                    body["CheckOutDate"] = checkOutDateObject;
                    bodypropCount++;
                }

                var checkOutDateActualObject = new JObject();
                var checkOutDateActualObjectpropCount = 0;
                if (__workflow_bodycheckOutDateActualvalue != null)
                {
                    checkOutDateActualObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActualvalue);
                    checkOutDateActualObjectpropCount++;
                }

                if (__workflow_bodycheckOutDateActualOperator != null)
                {
                    checkOutDateActualObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActualOperator);
                    checkOutDateActualObjectpropCount++;
                }

                if (checkOutDateActualObjectpropCount > 0)
                {
                    body["CheckOutDateActual"] = checkOutDateActualObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                var contractDateEndObject = new JObject();
                var contractDateEndObjectpropCount = 0;
                if (__workflow_bodycontractDateEndvalue != null)
                {
                    contractDateEndObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEndvalue);
                    contractDateEndObjectpropCount++;
                }

                if (__workflow_bodycontractDateEndOperator != null)
                {
                    contractDateEndObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEndOperator);
                    contractDateEndObjectpropCount++;
                }

                if (contractDateEndObjectpropCount > 0)
                {
                    body["ContractDateEnd"] = contractDateEndObject;
                    bodypropCount++;
                }

                var contractDateStartObject = new JObject();
                var contractDateStartObjectpropCount = 0;
                if (__workflow_bodycontractDateStartvalue != null)
                {
                    contractDateStartObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStartvalue);
                    contractDateStartObjectpropCount++;
                }

                if (__workflow_bodycontractDateStartOperator != null)
                {
                    contractDateStartObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStartOperator);
                    contractDateStartObjectpropCount++;
                }

                if (contractDateStartObjectpropCount > 0)
                {
                    body["ContractDateStart"] = contractDateStartObject;
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                var customDate3Object = new JObject();
                var customDate3ObjectpropCount = 0;
                if (__workflow_bodycustomDate3value != null)
                {
                    customDate3Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3value);
                    customDate3ObjectpropCount++;
                }

                if (__workflow_bodycustomDate3Operator != null)
                {
                    customDate3Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3Operator);
                    customDate3ObjectpropCount++;
                }

                if (customDate3ObjectpropCount > 0)
                {
                    body["CustomDate3"] = customDate3Object;
                    bodypropCount++;
                }

                var customDate4Object = new JObject();
                var customDate4ObjectpropCount = 0;
                if (__workflow_bodycustomDate4value != null)
                {
                    customDate4Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4value);
                    customDate4ObjectpropCount++;
                }

                if (__workflow_bodycustomDate4Operator != null)
                {
                    customDate4Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4Operator);
                    customDate4ObjectpropCount++;
                }

                if (customDate4ObjectpropCount > 0)
                {
                    body["CustomDate4"] = customDate4Object;
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString7 != null)
                {
                    body["CustomString7"] = ExpressionConverter.ConvertO(__workflow_bodycustomString7);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString8 != null)
                {
                    body["CustomString8"] = ExpressionConverter.ConvertO(__workflow_bodycustomString8);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString9 != null)
                {
                    body["CustomString9"] = ExpressionConverter.ConvertO(__workflow_bodycustomString9);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString10 != null)
                {
                    body["CustomString10"] = ExpressionConverter.ConvertO(__workflow_bodycustomString10);
                    bodypropCount++;
                }

                var dateBilledObject = new JObject();
                var dateBilledObjectpropCount = 0;
                if (__workflow_bodydateBilledvalue != null)
                {
                    dateBilledObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateBilledvalue);
                    dateBilledObjectpropCount++;
                }

                if (__workflow_bodydateBilledOperator != null)
                {
                    dateBilledObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateBilledOperator);
                    dateBilledObjectpropCount++;
                }

                if (dateBilledObjectpropCount > 0)
                {
                    body["DateBilled"] = dateBilledObject;
                    bodypropCount++;
                }

                var dateChargedToObject = new JObject();
                var dateChargedToObjectpropCount = 0;
                if (__workflow_bodydateChargedTovalue != null)
                {
                    dateChargedToObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateChargedTovalue);
                    dateChargedToObjectpropCount++;
                }

                if (__workflow_bodydateChargedToOperator != null)
                {
                    dateChargedToObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateChargedToOperator);
                    dateChargedToObjectpropCount++;
                }

                if (dateChargedToObjectpropCount > 0)
                {
                    body["DateChargedTo"] = dateChargedToObject;
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (__workflow_bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (__workflow_bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateModifiedBillingObject = new JObject();
                var dateModifiedBillingObjectpropCount = 0;
                if (__workflow_bodydateModifiedBillingvalue != null)
                {
                    dateModifiedBillingObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedBillingvalue);
                    dateModifiedBillingObjectpropCount++;
                }

                if (__workflow_bodydateModifiedBillingOperator != null)
                {
                    dateModifiedBillingObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedBillingOperator);
                    dateModifiedBillingObjectpropCount++;
                }

                if (dateModifiedBillingObjectpropCount > 0)
                {
                    body["DateModifiedBilling"] = dateModifiedBillingObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryInvitationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeTA != null)
                {
                    body["ETA"] = ExpressionConverter.ConvertO(__workflow_bodyeTA);
                    bodypropCount++;
                }

                if (__workflow_bodyeTD != null)
                {
                    body["ETD"] = ExpressionConverter.ConvertO(__workflow_bodyeTD);
                    bodypropCount++;
                }

                if (__workflow_bodyexcess != null)
                {
                    body["Excess"] = ExpressionConverter.ConvertO(__workflow_bodyexcess);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["GroupID"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = ExpressionConverter.ConvertO(__workflow_bodyhousekeepingId);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildren);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuests);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                var paidToObject = new JObject();
                var paidToObjectpropCount = 0;
                if (__workflow_bodypaidTovalue != null)
                {
                    paidToObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodypaidTovalue);
                    paidToObjectpropCount++;
                }

                if (__workflow_bodypaidToOperator != null)
                {
                    paidToObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodypaidToOperator);
                    paidToObjectpropCount++;
                }

                if (paidToObjectpropCount > 0)
                {
                    body["PaidTo"] = paidToObject;
                    bodypropCount++;
                }

                if (__workflow_bodypetCount != null)
                {
                    body["PetCount"] = ExpressionConverter.ConvertO(__workflow_bodypetCount);
                    bodypropCount++;
                }

                if (__workflow_bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(__workflow_bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyroomTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = ExpressionConverter.ConvertO(__workflow_bodyspecialRequirement);
                    bodypropCount++;
                }

                if (__workflow_bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectBookingResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateBookingResponse, ApiConnectionActionConfiguration> CreateBooking(Expression<Func<int>> bodyentryId, Expression<Func<int>> bodyadditionalOccupantCount = null, Expression<Func<string>> bodyautoAllocationDetail = null, Expression<Func<bodybookingLinkTypeEnumInput>> bodybookingLinkTypeEnum = null, Expression<Func<int>> bodybookingTypeId = null, Expression<Func<string>> bodycheckInDate = null, Expression<Func<string>> bodycheckInDateActual = null, Expression<Func<string>> bodycheckOutDate = null, Expression<Func<string>> bodycheckOutDateActual = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycontractDateEnd = null, Expression<Func<string>> bodycontractDateStart = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomDate3 = null, Expression<Func<string>> bodycustomDate4 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodycustomString7 = null, Expression<Func<string>> bodycustomString8 = null, Expression<Func<string>> bodycustomString9 = null, Expression<Func<string>> bodycustomString10 = null, Expression<Func<string>> bodydateBilled = null, Expression<Func<string>> bodydateChargedTo = null, Expression<Func<int>> bodyemotionalSupportAnimalCount = null, Expression<Func<int>> bodyendBookingReasonId = null, Expression<Func<int>> bodyentryInvitationId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<string>> bodyeTA = null, Expression<Func<string>> bodyeTD = null, Expression<Func<double>> bodyexcess = null, Expression<Func<int>> bodygroupId = null, Expression<Func<int>> bodyhousekeepingId = null, Expression<Func<int>> bodynumberOfChildren = null, Expression<Func<int>> bodynumberOfChildrenFree = null, Expression<Func<int>> bodynumberOfGuests = null, Expression<Func<int>> bodynumberOfGuestsFree = null, Expression<Func<string>> bodypaidTo = null, Expression<Func<int>> bodypetCount = null, Expression<Func<bool>> bodyresvChargeToEntry = null, Expression<Func<bool>> bodyroomLocationFixed = null, Expression<Func<int>> bodyroomLocationId = null, Expression<Func<double>> bodyroomRateAmount = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<int>> bodyroomTypeId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodyserviceAnimalCount = null, Expression<Func<string>> bodyspecialRequirement = null, Expression<Func<int>> bodystartBookingReasonId = null, Expression<Func<int>> bodytermSessionId = null)
        {
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: true);
            var __workflow_bodyadditionalOccupantCount = WorkflowExpression.Compile(bodyadditionalOccupantCount, nameof(bodyadditionalOccupantCount), required: false);
            var __workflow_bodyautoAllocationDetail = WorkflowExpression.Compile(bodyautoAllocationDetail, nameof(bodyautoAllocationDetail), required: false);
            var __workflow_bodybookingLinkTypeEnum = WorkflowExpression.Compile(bodybookingLinkTypeEnum, nameof(bodybookingLinkTypeEnum), required: false);
            var __workflow_bodybookingTypeId = WorkflowExpression.Compile(bodybookingTypeId, nameof(bodybookingTypeId), required: false);
            var __workflow_bodycheckInDate = WorkflowExpression.Compile(bodycheckInDate, nameof(bodycheckInDate), required: false);
            var __workflow_bodycheckInDateActual = WorkflowExpression.Compile(bodycheckInDateActual, nameof(bodycheckInDateActual), required: false);
            var __workflow_bodycheckOutDate = WorkflowExpression.Compile(bodycheckOutDate, nameof(bodycheckOutDate), required: false);
            var __workflow_bodycheckOutDateActual = WorkflowExpression.Compile(bodycheckOutDateActual, nameof(bodycheckOutDateActual), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycontractDateEnd = WorkflowExpression.Compile(bodycontractDateEnd, nameof(bodycontractDateEnd), required: false);
            var __workflow_bodycontractDateStart = WorkflowExpression.Compile(bodycontractDateStart, nameof(bodycontractDateStart), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomDate3 = WorkflowExpression.Compile(bodycustomDate3, nameof(bodycustomDate3), required: false);
            var __workflow_bodycustomDate4 = WorkflowExpression.Compile(bodycustomDate4, nameof(bodycustomDate4), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodycustomString7 = WorkflowExpression.Compile(bodycustomString7, nameof(bodycustomString7), required: false);
            var __workflow_bodycustomString8 = WorkflowExpression.Compile(bodycustomString8, nameof(bodycustomString8), required: false);
            var __workflow_bodycustomString9 = WorkflowExpression.Compile(bodycustomString9, nameof(bodycustomString9), required: false);
            var __workflow_bodycustomString10 = WorkflowExpression.Compile(bodycustomString10, nameof(bodycustomString10), required: false);
            var __workflow_bodydateBilled = WorkflowExpression.Compile(bodydateBilled, nameof(bodydateBilled), required: false);
            var __workflow_bodydateChargedTo = WorkflowExpression.Compile(bodydateChargedTo, nameof(bodydateChargedTo), required: false);
            var __workflow_bodyemotionalSupportAnimalCount = WorkflowExpression.Compile(bodyemotionalSupportAnimalCount, nameof(bodyemotionalSupportAnimalCount), required: false);
            var __workflow_bodyendBookingReasonId = WorkflowExpression.Compile(bodyendBookingReasonId, nameof(bodyendBookingReasonId), required: false);
            var __workflow_bodyentryInvitationId = WorkflowExpression.Compile(bodyentryInvitationId, nameof(bodyentryInvitationId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeTA = WorkflowExpression.Compile(bodyeTA, nameof(bodyeTA), required: false);
            var __workflow_bodyeTD = WorkflowExpression.Compile(bodyeTD, nameof(bodyeTD), required: false);
            var __workflow_bodyexcess = WorkflowExpression.Compile(bodyexcess, nameof(bodyexcess), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyhousekeepingId = WorkflowExpression.Compile(bodyhousekeepingId, nameof(bodyhousekeepingId), required: false);
            var __workflow_bodynumberOfChildren = WorkflowExpression.Compile(bodynumberOfChildren, nameof(bodynumberOfChildren), required: false);
            var __workflow_bodynumberOfChildrenFree = WorkflowExpression.Compile(bodynumberOfChildrenFree, nameof(bodynumberOfChildrenFree), required: false);
            var __workflow_bodynumberOfGuests = WorkflowExpression.Compile(bodynumberOfGuests, nameof(bodynumberOfGuests), required: false);
            var __workflow_bodynumberOfGuestsFree = WorkflowExpression.Compile(bodynumberOfGuestsFree, nameof(bodynumberOfGuestsFree), required: false);
            var __workflow_bodypaidTo = WorkflowExpression.Compile(bodypaidTo, nameof(bodypaidTo), required: false);
            var __workflow_bodypetCount = WorkflowExpression.Compile(bodypetCount, nameof(bodypetCount), required: false);
            var __workflow_bodyresvChargeToEntry = WorkflowExpression.Compile(bodyresvChargeToEntry, nameof(bodyresvChargeToEntry), required: false);
            var __workflow_bodyroomLocationFixed = WorkflowExpression.Compile(bodyroomLocationFixed, nameof(bodyroomLocationFixed), required: false);
            var __workflow_bodyroomLocationId = WorkflowExpression.Compile(bodyroomLocationId, nameof(bodyroomLocationId), required: false);
            var __workflow_bodyroomRateAmount = WorkflowExpression.Compile(bodyroomRateAmount, nameof(bodyroomRateAmount), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomTypeId = WorkflowExpression.Compile(bodyroomTypeId, nameof(bodyroomTypeId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodyserviceAnimalCount = WorkflowExpression.Compile(bodyserviceAnimalCount, nameof(bodyserviceAnimalCount), required: false);
            var __workflow_bodyspecialRequirement = WorkflowExpression.Compile(bodyspecialRequirement, nameof(bodyspecialRequirement), required: false);
            var __workflow_bodystartBookingReasonId = WorkflowExpression.Compile(bodystartBookingReasonId, nameof(bodystartBookingReasonId), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            return new DeferredBodyAction<CreateBookingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (__workflow_bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(__workflow_bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (__workflow_bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = ExpressionConverter.ConvertO(__workflow_bodybookingTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDate != null)
                {
                    body["CheckInDate"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDate);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDateActual != null)
                {
                    body["CheckInDateActual"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActual);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDate != null)
                {
                    body["CheckOutDate"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDate);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDateActual != null)
                {
                    body["CheckOutDateActual"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActual);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateEnd != null)
                {
                    body["ContractDateEnd"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateStart != null)
                {
                    body["ContractDateStart"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate3 != null)
                {
                    body["CustomDate3"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate4 != null)
                {
                    body["CustomDate4"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString7 != null)
                {
                    body["CustomString7"] = ExpressionConverter.ConvertO(__workflow_bodycustomString7);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString8 != null)
                {
                    body["CustomString8"] = ExpressionConverter.ConvertO(__workflow_bodycustomString8);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString9 != null)
                {
                    body["CustomString9"] = ExpressionConverter.ConvertO(__workflow_bodycustomString9);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString10 != null)
                {
                    body["CustomString10"] = ExpressionConverter.ConvertO(__workflow_bodycustomString10);
                    bodypropCount++;
                }

                if (__workflow_bodydateBilled != null)
                {
                    body["DateBilled"] = ExpressionConverter.ConvertO(__workflow_bodydateBilled);
                    bodypropCount++;
                }

                if (__workflow_bodydateChargedTo != null)
                {
                    body["DateChargedTo"] = ExpressionConverter.ConvertO(__workflow_bodydateChargedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodyendBookingReasonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                if (__workflow_bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryInvitationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeTA != null)
                {
                    body["ETA"] = ExpressionConverter.ConvertO(__workflow_bodyeTA);
                    bodypropCount++;
                }

                if (__workflow_bodyeTD != null)
                {
                    body["ETD"] = ExpressionConverter.ConvertO(__workflow_bodyeTD);
                    bodypropCount++;
                }

                if (__workflow_bodyexcess != null)
                {
                    body["Excess"] = ExpressionConverter.ConvertO(__workflow_bodyexcess);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["GroupID"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = ExpressionConverter.ConvertO(__workflow_bodyhousekeepingId);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildren);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuests);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                if (__workflow_bodypaidTo != null)
                {
                    body["PaidTo"] = ExpressionConverter.ConvertO(__workflow_bodypaidTo);
                    bodypropCount++;
                }

                if (__workflow_bodypetCount != null)
                {
                    body["PetCount"] = ExpressionConverter.ConvertO(__workflow_bodypetCount);
                    bodypropCount++;
                }

                if (__workflow_bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(__workflow_bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyroomTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = ExpressionConverter.ConvertO(__workflow_bodyspecialRequirement);
                    bodypropCount++;
                }

                if (__workflow_bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBookingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateBookingResponse, ApiConnectionActionConfiguration> UpdateBooking(Expression<Func<int>> bookingId, Expression<Func<int>> bodyadditionalOccupantCount = null, Expression<Func<string>> bodyautoAllocationDetail = null, Expression<Func<bodybookingLinkTypeEnumInput>> bodybookingLinkTypeEnum = null, Expression<Func<int>> bodybookingTypeId = null, Expression<Func<string>> bodycheckInDate = null, Expression<Func<string>> bodycheckInDateActual = null, Expression<Func<string>> bodycheckOutDate = null, Expression<Func<string>> bodycheckOutDateActual = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodycontractDateEnd = null, Expression<Func<string>> bodycontractDateStart = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<bool>> bodycustomBit3 = null, Expression<Func<bool>> bodycustomBit4 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomDate3 = null, Expression<Func<string>> bodycustomDate4 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodycustomString7 = null, Expression<Func<string>> bodycustomString8 = null, Expression<Func<string>> bodycustomString9 = null, Expression<Func<string>> bodycustomString10 = null, Expression<Func<string>> bodydateBilled = null, Expression<Func<string>> bodydateChargedTo = null, Expression<Func<int>> bodyemotionalSupportAnimalCount = null, Expression<Func<int>> bodyendBookingReasonId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<int>> bodyentryInvitationId = null, Expression<Func<bodyentryStatusEnumInput>> bodyentryStatusEnum = null, Expression<Func<string>> bodyeTA = null, Expression<Func<string>> bodyeTD = null, Expression<Func<double>> bodyexcess = null, Expression<Func<int>> bodygroupId = null, Expression<Func<int>> bodyhousekeepingId = null, Expression<Func<int>> bodynumberOfChildren = null, Expression<Func<int>> bodynumberOfChildrenFree = null, Expression<Func<int>> bodynumberOfGuests = null, Expression<Func<int>> bodynumberOfGuestsFree = null, Expression<Func<string>> bodypaidTo = null, Expression<Func<int>> bodypetCount = null, Expression<Func<bool>> bodyresvChargeToEntry = null, Expression<Func<bool>> bodyroomLocationFixed = null, Expression<Func<int>> bodyroomLocationId = null, Expression<Func<double>> bodyroomRateAmount = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<int>> bodyroomTypeId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodyserviceAnimalCount = null, Expression<Func<string>> bodyspecialRequirement = null, Expression<Func<int>> bodystartBookingReasonId = null, Expression<Func<int>> bodytermSessionId = null)
        {
            var __workflow_bookingId = WorkflowExpression.Compile(bookingId, nameof(bookingId), required: true);
            var __workflow_bodyadditionalOccupantCount = WorkflowExpression.Compile(bodyadditionalOccupantCount, nameof(bodyadditionalOccupantCount), required: false);
            var __workflow_bodyautoAllocationDetail = WorkflowExpression.Compile(bodyautoAllocationDetail, nameof(bodyautoAllocationDetail), required: false);
            var __workflow_bodybookingLinkTypeEnum = WorkflowExpression.Compile(bodybookingLinkTypeEnum, nameof(bodybookingLinkTypeEnum), required: false);
            var __workflow_bodybookingTypeId = WorkflowExpression.Compile(bodybookingTypeId, nameof(bodybookingTypeId), required: false);
            var __workflow_bodycheckInDate = WorkflowExpression.Compile(bodycheckInDate, nameof(bodycheckInDate), required: false);
            var __workflow_bodycheckInDateActual = WorkflowExpression.Compile(bodycheckInDateActual, nameof(bodycheckInDateActual), required: false);
            var __workflow_bodycheckOutDate = WorkflowExpression.Compile(bodycheckOutDate, nameof(bodycheckOutDate), required: false);
            var __workflow_bodycheckOutDateActual = WorkflowExpression.Compile(bodycheckOutDateActual, nameof(bodycheckOutDateActual), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycontractDateEnd = WorkflowExpression.Compile(bodycontractDateEnd, nameof(bodycontractDateEnd), required: false);
            var __workflow_bodycontractDateStart = WorkflowExpression.Compile(bodycontractDateStart, nameof(bodycontractDateStart), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomBit3 = WorkflowExpression.Compile(bodycustomBit3, nameof(bodycustomBit3), required: false);
            var __workflow_bodycustomBit4 = WorkflowExpression.Compile(bodycustomBit4, nameof(bodycustomBit4), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomDate3 = WorkflowExpression.Compile(bodycustomDate3, nameof(bodycustomDate3), required: false);
            var __workflow_bodycustomDate4 = WorkflowExpression.Compile(bodycustomDate4, nameof(bodycustomDate4), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodycustomString7 = WorkflowExpression.Compile(bodycustomString7, nameof(bodycustomString7), required: false);
            var __workflow_bodycustomString8 = WorkflowExpression.Compile(bodycustomString8, nameof(bodycustomString8), required: false);
            var __workflow_bodycustomString9 = WorkflowExpression.Compile(bodycustomString9, nameof(bodycustomString9), required: false);
            var __workflow_bodycustomString10 = WorkflowExpression.Compile(bodycustomString10, nameof(bodycustomString10), required: false);
            var __workflow_bodydateBilled = WorkflowExpression.Compile(bodydateBilled, nameof(bodydateBilled), required: false);
            var __workflow_bodydateChargedTo = WorkflowExpression.Compile(bodydateChargedTo, nameof(bodydateChargedTo), required: false);
            var __workflow_bodyemotionalSupportAnimalCount = WorkflowExpression.Compile(bodyemotionalSupportAnimalCount, nameof(bodyemotionalSupportAnimalCount), required: false);
            var __workflow_bodyendBookingReasonId = WorkflowExpression.Compile(bodyendBookingReasonId, nameof(bodyendBookingReasonId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyentryInvitationId = WorkflowExpression.Compile(bodyentryInvitationId, nameof(bodyentryInvitationId), required: false);
            var __workflow_bodyentryStatusEnum = WorkflowExpression.Compile(bodyentryStatusEnum, nameof(bodyentryStatusEnum), required: false);
            var __workflow_bodyeTA = WorkflowExpression.Compile(bodyeTA, nameof(bodyeTA), required: false);
            var __workflow_bodyeTD = WorkflowExpression.Compile(bodyeTD, nameof(bodyeTD), required: false);
            var __workflow_bodyexcess = WorkflowExpression.Compile(bodyexcess, nameof(bodyexcess), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyhousekeepingId = WorkflowExpression.Compile(bodyhousekeepingId, nameof(bodyhousekeepingId), required: false);
            var __workflow_bodynumberOfChildren = WorkflowExpression.Compile(bodynumberOfChildren, nameof(bodynumberOfChildren), required: false);
            var __workflow_bodynumberOfChildrenFree = WorkflowExpression.Compile(bodynumberOfChildrenFree, nameof(bodynumberOfChildrenFree), required: false);
            var __workflow_bodynumberOfGuests = WorkflowExpression.Compile(bodynumberOfGuests, nameof(bodynumberOfGuests), required: false);
            var __workflow_bodynumberOfGuestsFree = WorkflowExpression.Compile(bodynumberOfGuestsFree, nameof(bodynumberOfGuestsFree), required: false);
            var __workflow_bodypaidTo = WorkflowExpression.Compile(bodypaidTo, nameof(bodypaidTo), required: false);
            var __workflow_bodypetCount = WorkflowExpression.Compile(bodypetCount, nameof(bodypetCount), required: false);
            var __workflow_bodyresvChargeToEntry = WorkflowExpression.Compile(bodyresvChargeToEntry, nameof(bodyresvChargeToEntry), required: false);
            var __workflow_bodyroomLocationFixed = WorkflowExpression.Compile(bodyroomLocationFixed, nameof(bodyroomLocationFixed), required: false);
            var __workflow_bodyroomLocationId = WorkflowExpression.Compile(bodyroomLocationId, nameof(bodyroomLocationId), required: false);
            var __workflow_bodyroomRateAmount = WorkflowExpression.Compile(bodyroomRateAmount, nameof(bodyroomRateAmount), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomTypeId = WorkflowExpression.Compile(bodyroomTypeId, nameof(bodyroomTypeId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodyserviceAnimalCount = WorkflowExpression.Compile(bodyserviceAnimalCount, nameof(bodyserviceAnimalCount), required: false);
            var __workflow_bodyspecialRequirement = WorkflowExpression.Compile(bodyspecialRequirement, nameof(bodyspecialRequirement), required: false);
            var __workflow_bodystartBookingReasonId = WorkflowExpression.Compile(bodystartBookingReasonId, nameof(bodystartBookingReasonId), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            return new DeferredBodyAction<UpdateBookingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/booking.json/{0}", __workflow_bookingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (__workflow_bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(__workflow_bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (__workflow_bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = ExpressionConverter.ConvertO(__workflow_bodybookingTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDate != null)
                {
                    body["CheckInDate"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDate);
                    bodypropCount++;
                }

                if (__workflow_bodycheckInDateActual != null)
                {
                    body["CheckInDateActual"] = ExpressionConverter.ConvertO(__workflow_bodycheckInDateActual);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDate != null)
                {
                    body["CheckOutDate"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDate);
                    bodypropCount++;
                }

                if (__workflow_bodycheckOutDateActual != null)
                {
                    body["CheckOutDateActual"] = ExpressionConverter.ConvertO(__workflow_bodycheckOutDateActual);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateEnd != null)
                {
                    body["ContractDateEnd"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDateStart != null)
                {
                    body["ContractDateStart"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit3 != null)
                {
                    body["CustomBit3"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit4 != null)
                {
                    body["CustomBit4"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate3 != null)
                {
                    body["CustomDate3"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate4 != null)
                {
                    body["CustomDate4"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString7 != null)
                {
                    body["CustomString7"] = ExpressionConverter.ConvertO(__workflow_bodycustomString7);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString8 != null)
                {
                    body["CustomString8"] = ExpressionConverter.ConvertO(__workflow_bodycustomString8);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString9 != null)
                {
                    body["CustomString9"] = ExpressionConverter.ConvertO(__workflow_bodycustomString9);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString10 != null)
                {
                    body["CustomString10"] = ExpressionConverter.ConvertO(__workflow_bodycustomString10);
                    bodypropCount++;
                }

                if (__workflow_bodydateBilled != null)
                {
                    body["DateBilled"] = ExpressionConverter.ConvertO(__workflow_bodydateBilled);
                    bodypropCount++;
                }

                if (__workflow_bodydateChargedTo != null)
                {
                    body["DateChargedTo"] = ExpressionConverter.ConvertO(__workflow_bodydateChargedTo);
                    bodypropCount++;
                }

                if (__workflow_bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = ExpressionConverter.ConvertO(__workflow_bodyentryInvitationId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = ExpressionConverter.ConvertO(__workflow_bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyeTA != null)
                {
                    body["ETA"] = ExpressionConverter.ConvertO(__workflow_bodyeTA);
                    bodypropCount++;
                }

                if (__workflow_bodyeTD != null)
                {
                    body["ETD"] = ExpressionConverter.ConvertO(__workflow_bodyeTD);
                    bodypropCount++;
                }

                if (__workflow_bodyexcess != null)
                {
                    body["Excess"] = ExpressionConverter.ConvertO(__workflow_bodyexcess);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["GroupID"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = ExpressionConverter.ConvertO(__workflow_bodyhousekeepingId);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildren);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuests);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                if (__workflow_bodypaidTo != null)
                {
                    body["PaidTo"] = ExpressionConverter.ConvertO(__workflow_bodypaidTo);
                    bodypropCount++;
                }

                if (__workflow_bodypetCount != null)
                {
                    body["PetCount"] = ExpressionConverter.ConvertO(__workflow_bodypetCount);
                    bodypropCount++;
                }

                if (__workflow_bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(__workflow_bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = ExpressionConverter.ConvertO(__workflow_bodyroomTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(__workflow_bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = ExpressionConverter.ConvertO(__workflow_bodyspecialRequirement);
                    bodypropCount++;
                }

                if (__workflow_bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(__workflow_bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateBookingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpace(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyallocateExclude = null, Expression<Func<int>> bodyallocateSortOrder = null, Expression<Func<int>> bodybathrooms = null, Expression<Func<int>> bodybedCapacity = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyextensionId = null, Expression<Func<bool>> bodyhold = null, Expression<Func<bool>> bodynetworked = null, Expression<Func<bodyrecordTypeEnumInput>> bodyrecordTypeEnum = null, Expression<Func<int>> bodyroomBaseId = null, Expression<Func<int>> bodyroomId = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<bodyroomSpaceTypeEnumInput>> bodyroomSpaceTypeEnum = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodysortOrder = null, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodywebDescription = null, Expression<Func<string>> bodyzipPostcode = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyallocateExclude = WorkflowExpression.Compile(bodyallocateExclude, nameof(bodyallocateExclude), required: false);
            var __workflow_bodyallocateSortOrder = WorkflowExpression.Compile(bodyallocateSortOrder, nameof(bodyallocateSortOrder), required: false);
            var __workflow_bodybathrooms = WorkflowExpression.Compile(bodybathrooms, nameof(bodybathrooms), required: false);
            var __workflow_bodybedCapacity = WorkflowExpression.Compile(bodybedCapacity, nameof(bodybedCapacity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyextensionId = WorkflowExpression.Compile(bodyextensionId, nameof(bodyextensionId), required: false);
            var __workflow_bodyhold = WorkflowExpression.Compile(bodyhold, nameof(bodyhold), required: false);
            var __workflow_bodynetworked = WorkflowExpression.Compile(bodynetworked, nameof(bodynetworked), required: false);
            var __workflow_bodyrecordTypeEnum = WorkflowExpression.Compile(bodyrecordTypeEnum, nameof(bodyrecordTypeEnum), required: false);
            var __workflow_bodyroomBaseId = WorkflowExpression.Compile(bodyroomBaseId, nameof(bodyroomBaseId), required: false);
            var __workflow_bodyroomId = WorkflowExpression.Compile(bodyroomId, nameof(bodyroomId), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomSpaceTypeEnum = WorkflowExpression.Compile(bodyroomSpaceTypeEnum, nameof(bodyroomSpaceTypeEnum), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodysortOrder = WorkflowExpression.Compile(bodysortOrder, nameof(bodysortOrder), required: false);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodystreet2 = WorkflowExpression.Compile(bodystreet2, nameof(bodystreet2), required: false);
            var __workflow_bodywebDescription = WorkflowExpression.Compile(bodywebDescription, nameof(bodywebDescription), required: false);
            var __workflow_bodyzipPostcode = WorkflowExpression.Compile(bodyzipPostcode, nameof(bodyzipPostcode), required: false);
            return new DeferredBodyAction<SelectRoomSpaceResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomSpace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyallocateExclude != null)
                {
                    body["AllocateExclude"] = ExpressionConverter.ConvertO(__workflow_bodyallocateExclude);
                    bodypropCount++;
                }

                if (__workflow_bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodybathrooms != null)
                {
                    body["Bathrooms"] = ExpressionConverter.ConvertO(__workflow_bodybathrooms);
                    bodypropCount++;
                }

                if (__workflow_bodybedCapacity != null)
                {
                    body["BedCapacity"] = ExpressionConverter.ConvertO(__workflow_bodybedCapacity);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyextensionId != null)
                {
                    body["ExtensionID"] = ExpressionConverter.ConvertO(__workflow_bodyextensionId);
                    bodypropCount++;
                }

                if (__workflow_bodyhold != null)
                {
                    body["Hold"] = ExpressionConverter.ConvertO(__workflow_bodyhold);
                    bodypropCount++;
                }

                if (__workflow_bodynetworked != null)
                {
                    body["Networked"] = ExpressionConverter.ConvertO(__workflow_bodynetworked);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyroomBaseId != null)
                {
                    body["RoomBaseID"] = ExpressionConverter.ConvertO(__workflow_bodyroomBaseId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomId != null)
                {
                    body["RoomID"] = ExpressionConverter.ConvertO(__workflow_bodyroomId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceTypeEnum != null)
                {
                    body["RoomSpaceTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["SortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodystreet != null)
                {
                    body["Street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodystreet2 != null)
                {
                    body["Street2"] = ExpressionConverter.ConvertO(__workflow_bodystreet2);
                    bodypropCount++;
                }

                if (__workflow_bodywebDescription != null)
                {
                    body["WebDescription"] = ExpressionConverter.ConvertO(__workflow_bodywebDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectRoomSpaceResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceResponse, ApiConnectionActionConfiguration> CreateRoomSpace(Expression<Func<bool>> bodyallocateExclude = null, Expression<Func<int>> bodyallocateSortOrder = null, Expression<Func<int>> bodybathrooms = null, Expression<Func<int>> bodybedCapacity = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyextensionId = null, Expression<Func<bool>> bodyhold = null, Expression<Func<bool>> bodynetworked = null, Expression<Func<bodyrecordTypeEnumInput>> bodyrecordTypeEnum = null, Expression<Func<int>> bodyroomBaseId = null, Expression<Func<int>> bodyroomId = null, Expression<Func<int>> bodyroomRateId = null, Expression<Func<bodyroomSpaceTypeEnumInput>> bodyroomSpaceTypeEnum = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodysortOrder = null, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodywebDescription = null, Expression<Func<string>> bodyzipPostcode = null)
        {
            var __workflow_bodyallocateExclude = WorkflowExpression.Compile(bodyallocateExclude, nameof(bodyallocateExclude), required: false);
            var __workflow_bodyallocateSortOrder = WorkflowExpression.Compile(bodyallocateSortOrder, nameof(bodyallocateSortOrder), required: false);
            var __workflow_bodybathrooms = WorkflowExpression.Compile(bodybathrooms, nameof(bodybathrooms), required: false);
            var __workflow_bodybedCapacity = WorkflowExpression.Compile(bodybedCapacity, nameof(bodybedCapacity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyextensionId = WorkflowExpression.Compile(bodyextensionId, nameof(bodyextensionId), required: false);
            var __workflow_bodyhold = WorkflowExpression.Compile(bodyhold, nameof(bodyhold), required: false);
            var __workflow_bodynetworked = WorkflowExpression.Compile(bodynetworked, nameof(bodynetworked), required: false);
            var __workflow_bodyrecordTypeEnum = WorkflowExpression.Compile(bodyrecordTypeEnum, nameof(bodyrecordTypeEnum), required: false);
            var __workflow_bodyroomBaseId = WorkflowExpression.Compile(bodyroomBaseId, nameof(bodyroomBaseId), required: false);
            var __workflow_bodyroomId = WorkflowExpression.Compile(bodyroomId, nameof(bodyroomId), required: false);
            var __workflow_bodyroomRateId = WorkflowExpression.Compile(bodyroomRateId, nameof(bodyroomRateId), required: false);
            var __workflow_bodyroomSpaceTypeEnum = WorkflowExpression.Compile(bodyroomSpaceTypeEnum, nameof(bodyroomSpaceTypeEnum), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodysortOrder = WorkflowExpression.Compile(bodysortOrder, nameof(bodysortOrder), required: false);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodystreet2 = WorkflowExpression.Compile(bodystreet2, nameof(bodystreet2), required: false);
            var __workflow_bodywebDescription = WorkflowExpression.Compile(bodywebDescription, nameof(bodywebDescription), required: false);
            var __workflow_bodyzipPostcode = WorkflowExpression.Compile(bodyzipPostcode, nameof(bodyzipPostcode), required: false);
            return new DeferredBodyAction<CreateRoomSpaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/roomspace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyallocateExclude != null)
                {
                    body["AllocateExclude"] = ExpressionConverter.ConvertO(__workflow_bodyallocateExclude);
                    bodypropCount++;
                }

                if (__workflow_bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodybathrooms != null)
                {
                    body["Bathrooms"] = ExpressionConverter.ConvertO(__workflow_bodybathrooms);
                    bodypropCount++;
                }

                if (__workflow_bodybedCapacity != null)
                {
                    body["BedCapacity"] = ExpressionConverter.ConvertO(__workflow_bodybedCapacity);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyextensionId != null)
                {
                    body["ExtensionID"] = ExpressionConverter.ConvertO(__workflow_bodyextensionId);
                    bodypropCount++;
                }

                if (__workflow_bodyhold != null)
                {
                    body["Hold"] = ExpressionConverter.ConvertO(__workflow_bodyhold);
                    bodypropCount++;
                }

                if (__workflow_bodynetworked != null)
                {
                    body["Networked"] = ExpressionConverter.ConvertO(__workflow_bodynetworked);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyroomBaseId != null)
                {
                    body["RoomBaseID"] = ExpressionConverter.ConvertO(__workflow_bodyroomBaseId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomId != null)
                {
                    body["RoomID"] = ExpressionConverter.ConvertO(__workflow_bodyroomId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomRateId != null)
                {
                    body["RoomRateID"] = ExpressionConverter.ConvertO(__workflow_bodyroomRateId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceTypeEnum != null)
                {
                    body["RoomSpaceTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodysortOrder != null)
                {
                    body["SortOrder"] = ExpressionConverter.ConvertO(__workflow_bodysortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodystreet != null)
                {
                    body["Street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                if (__workflow_bodystreet2 != null)
                {
                    body["Street2"] = ExpressionConverter.ConvertO(__workflow_bodystreet2);
                    bodypropCount++;
                }

                if (__workflow_bodywebDescription != null)
                {
                    body["WebDescription"] = ExpressionConverter.ConvertO(__workflow_bodywebDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateRoomSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomLocationResponseItem[], ApiConnectionActionConfiguration> SelectRoomLocation(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyallocateSortOrder = null, Expression<Func<int>> bodycategoryId = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycountryId = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodygenderTypeEnumInput>> bodygenderTypeEnum = null, Expression<Func<bool>> bodylease = null, Expression<Func<bool>> bodymanagedExternally = null, Expression<Func<bool>> bodynonResidential = null, Expression<Func<bodyrecordTypeEnumInput>> bodyrecordTypeEnum = null, Expression<Func<int>> bodyroomLocationAreaId = null, Expression<Func<int>> bodyroomLocationId = null, Expression<Func<string>> bodystateProvince = null, Expression<Func<bool>> bodyviewOnWeb = null, Expression<Func<string>> bodywebComments = null, Expression<Func<string>> bodywebDescription = null, Expression<Func<string>> bodywebImageAltText = null, Expression<Func<string>> bodywebImageLocation = null, Expression<Func<string>> bodyzipPostcode = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyallocateSortOrder = WorkflowExpression.Compile(bodyallocateSortOrder, nameof(bodyallocateSortOrder), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycountryId = WorkflowExpression.Compile(bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodygenderTypeEnum = WorkflowExpression.Compile(bodygenderTypeEnum, nameof(bodygenderTypeEnum), required: false);
            var __workflow_bodylease = WorkflowExpression.Compile(bodylease, nameof(bodylease), required: false);
            var __workflow_bodymanagedExternally = WorkflowExpression.Compile(bodymanagedExternally, nameof(bodymanagedExternally), required: false);
            var __workflow_bodynonResidential = WorkflowExpression.Compile(bodynonResidential, nameof(bodynonResidential), required: false);
            var __workflow_bodyrecordTypeEnum = WorkflowExpression.Compile(bodyrecordTypeEnum, nameof(bodyrecordTypeEnum), required: false);
            var __workflow_bodyroomLocationAreaId = WorkflowExpression.Compile(bodyroomLocationAreaId, nameof(bodyroomLocationAreaId), required: false);
            var __workflow_bodyroomLocationId = WorkflowExpression.Compile(bodyroomLocationId, nameof(bodyroomLocationId), required: false);
            var __workflow_bodystateProvince = WorkflowExpression.Compile(bodystateProvince, nameof(bodystateProvince), required: false);
            var __workflow_bodyviewOnWeb = WorkflowExpression.Compile(bodyviewOnWeb, nameof(bodyviewOnWeb), required: false);
            var __workflow_bodywebComments = WorkflowExpression.Compile(bodywebComments, nameof(bodywebComments), required: false);
            var __workflow_bodywebDescription = WorkflowExpression.Compile(bodywebDescription, nameof(bodywebDescription), required: false);
            var __workflow_bodywebImageAltText = WorkflowExpression.Compile(bodywebImageAltText, nameof(bodywebImageAltText), required: false);
            var __workflow_bodywebImageLocation = WorkflowExpression.Compile(bodywebImageLocation, nameof(bodywebImageLocation), required: false);
            var __workflow_bodyzipPostcode = WorkflowExpression.Compile(bodyzipPostcode, nameof(bodyzipPostcode), required: false);
            return new DeferredBodyAction<SelectRoomLocationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomLocation.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = ExpressionConverter.ConvertO(__workflow_bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["CategoryID"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycountryId != null)
                {
                    body["CountryID"] = ExpressionConverter.ConvertO(__workflow_bodycountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodygenderTypeEnum != null)
                {
                    body["GenderTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodygenderTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodylease != null)
                {
                    body["Lease"] = ExpressionConverter.ConvertO(__workflow_bodylease);
                    bodypropCount++;
                }

                if (__workflow_bodymanagedExternally != null)
                {
                    body["ManagedExternally"] = ExpressionConverter.ConvertO(__workflow_bodymanagedExternally);
                    bodypropCount++;
                }

                if (__workflow_bodynonResidential != null)
                {
                    body["NonResidential"] = ExpressionConverter.ConvertO(__workflow_bodynonResidential);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationAreaId != null)
                {
                    body["RoomLocationAreaID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationAreaId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = ExpressionConverter.ConvertO(__workflow_bodyroomLocationId);
                    bodypropCount++;
                }

                if (__workflow_bodystateProvince != null)
                {
                    body["StateProvince"] = ExpressionConverter.ConvertO(__workflow_bodystateProvince);
                    bodypropCount++;
                }

                if (__workflow_bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = ExpressionConverter.ConvertO(__workflow_bodyviewOnWeb);
                    bodypropCount++;
                }

                if (__workflow_bodywebComments != null)
                {
                    body["WebComments"] = ExpressionConverter.ConvertO(__workflow_bodywebComments);
                    bodypropCount++;
                }

                if (__workflow_bodywebDescription != null)
                {
                    body["WebDescription"] = ExpressionConverter.ConvertO(__workflow_bodywebDescription);
                    bodypropCount++;
                }

                if (__workflow_bodywebImageAltText != null)
                {
                    body["WebImageAltText"] = ExpressionConverter.ConvertO(__workflow_bodywebImageAltText);
                    bodypropCount++;
                }

                if (__workflow_bodywebImageLocation != null)
                {
                    body["WebImageLocation"] = ExpressionConverter.ConvertO(__workflow_bodywebImageLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectRoomLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTransactionResponseItem[], ApiConnectionActionConfiguration> SelectTransaction(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<double>> bodyamount = null, Expression<Func<bodycallTypeEnumInput>> bodycallTypeEnum = null, Expression<Func<int>> bodychargeGroupId = null, Expression<Func<int>> bodychargeItemId = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodycreatedBySecurityUserId = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDatevalue = null, Expression<Func<bodydueDateOperatorInput>> bodydueDateOperator = null, Expression<Func<int>> bodyduration = null, Expression<Func<int>> bodyendOfSessionId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<double>> bodyexcess = null, Expression<Func<int>> bodyextension = null, Expression<Func<int>> bodyexternalId = null, Expression<Func<string>> bodyexternalReceiptId = null, Expression<Func<int>> bodyinvoiceId = null, Expression<Func<string>> bodypaidFromvalue = null, Expression<Func<bodypaidFromOperatorInput>> bodypaidFromOperator = null, Expression<Func<string>> bodypaidTovalue = null, Expression<Func<bodypaidToOperatorInput>> bodypaidToOperator = null, Expression<Func<int>> bodypaymentId = null, Expression<Func<string>> bodyprocessedDatevalue = null, Expression<Func<bodyprocessedDateOperatorInput>> bodyprocessedDateOperator = null, Expression<Func<int>> bodyreferenceBookingId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodytableId = null, Expression<Func<string>> bodytableName = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodytagFinance = null, Expression<Func<double>> bodytaxAmount = null, Expression<Func<double>> bodytaxAmount2 = null, Expression<Func<double>> bodytaxAmount3 = null, Expression<Func<int>> bodytermSessionId = null, Expression<Func<string>> bodytransactionDatevalue = null, Expression<Func<bodytransactionDateOperatorInput>> bodytransactionDateOperator = null, Expression<Func<int>> bodytransactionId = null, Expression<Func<bodytransactionTypeEnumInput>> bodytransactionTypeEnum = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodycallTypeEnum = WorkflowExpression.Compile(bodycallTypeEnum, nameof(bodycallTypeEnum), required: false);
            var __workflow_bodychargeGroupId = WorkflowExpression.Compile(bodychargeGroupId, nameof(bodychargeGroupId), required: false);
            var __workflow_bodychargeItemId = WorkflowExpression.Compile(bodychargeItemId, nameof(bodychargeItemId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodycreatedBySecurityUserId = WorkflowExpression.Compile(bodycreatedBySecurityUserId, nameof(bodycreatedBySecurityUserId), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydueDatevalue = WorkflowExpression.Compile(bodydueDatevalue, nameof(bodydueDatevalue), required: false);
            var __workflow_bodydueDateOperator = WorkflowExpression.Compile(bodydueDateOperator, nameof(bodydueDateOperator), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodyendOfSessionId = WorkflowExpression.Compile(bodyendOfSessionId, nameof(bodyendOfSessionId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyexcess = WorkflowExpression.Compile(bodyexcess, nameof(bodyexcess), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalReceiptId = WorkflowExpression.Compile(bodyexternalReceiptId, nameof(bodyexternalReceiptId), required: false);
            var __workflow_bodyinvoiceId = WorkflowExpression.Compile(bodyinvoiceId, nameof(bodyinvoiceId), required: false);
            var __workflow_bodypaidFromvalue = WorkflowExpression.Compile(bodypaidFromvalue, nameof(bodypaidFromvalue), required: false);
            var __workflow_bodypaidFromOperator = WorkflowExpression.Compile(bodypaidFromOperator, nameof(bodypaidFromOperator), required: false);
            var __workflow_bodypaidTovalue = WorkflowExpression.Compile(bodypaidTovalue, nameof(bodypaidTovalue), required: false);
            var __workflow_bodypaidToOperator = WorkflowExpression.Compile(bodypaidToOperator, nameof(bodypaidToOperator), required: false);
            var __workflow_bodypaymentId = WorkflowExpression.Compile(bodypaymentId, nameof(bodypaymentId), required: false);
            var __workflow_bodyprocessedDatevalue = WorkflowExpression.Compile(bodyprocessedDatevalue, nameof(bodyprocessedDatevalue), required: false);
            var __workflow_bodyprocessedDateOperator = WorkflowExpression.Compile(bodyprocessedDateOperator, nameof(bodyprocessedDateOperator), required: false);
            var __workflow_bodyreferenceBookingId = WorkflowExpression.Compile(bodyreferenceBookingId, nameof(bodyreferenceBookingId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodytableId = WorkflowExpression.Compile(bodytableId, nameof(bodytableId), required: false);
            var __workflow_bodytableName = WorkflowExpression.Compile(bodytableName, nameof(bodytableName), required: false);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: false);
            var __workflow_bodytagFinance = WorkflowExpression.Compile(bodytagFinance, nameof(bodytagFinance), required: false);
            var __workflow_bodytaxAmount = WorkflowExpression.Compile(bodytaxAmount, nameof(bodytaxAmount), required: false);
            var __workflow_bodytaxAmount2 = WorkflowExpression.Compile(bodytaxAmount2, nameof(bodytaxAmount2), required: false);
            var __workflow_bodytaxAmount3 = WorkflowExpression.Compile(bodytaxAmount3, nameof(bodytaxAmount3), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            var __workflow_bodytransactionDatevalue = WorkflowExpression.Compile(bodytransactionDatevalue, nameof(bodytransactionDatevalue), required: false);
            var __workflow_bodytransactionDateOperator = WorkflowExpression.Compile(bodytransactionDateOperator, nameof(bodytransactionDateOperator), required: false);
            var __workflow_bodytransactionId = WorkflowExpression.Compile(bodytransactionId, nameof(bodytransactionId), required: false);
            var __workflow_bodytransactionTypeEnum = WorkflowExpression.Compile(bodytransactionTypeEnum, nameof(bodytransactionTypeEnum), required: false);
            return new DeferredBodyAction<SelectTransactionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["Amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodycallTypeEnum != null)
                {
                    body["CallTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodycallTypeEnum);
                    bodypropCount++;
                }

                if (__workflow_bodychargeGroupId != null)
                {
                    body["ChargeGroupID"] = ExpressionConverter.ConvertO(__workflow_bodychargeGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodychargeItemId != null)
                {
                    body["ChargeItemID"] = ExpressionConverter.ConvertO(__workflow_bodychargeItemId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var dueDateObject = new JObject();
                var dueDateObjectpropCount = 0;
                if (__workflow_bodydueDatevalue != null)
                {
                    dueDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydueDatevalue);
                    dueDateObjectpropCount++;
                }

                if (__workflow_bodydueDateOperator != null)
                {
                    dueDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydueDateOperator);
                    dueDateObjectpropCount++;
                }

                if (dueDateObjectpropCount > 0)
                {
                    body["DueDate"] = dueDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["Duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodyendOfSessionId != null)
                {
                    body["EndOfSessionID"] = ExpressionConverter.ConvertO(__workflow_bodyendOfSessionId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyexcess != null)
                {
                    body["Excess"] = ExpressionConverter.ConvertO(__workflow_bodyexcess);
                    bodypropCount++;
                }

                if (__workflow_bodyextension != null)
                {
                    body["Extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["ExternalID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReceiptId != null)
                {
                    body["ExternalReceiptID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReceiptId);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceId != null)
                {
                    body["InvoiceID"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceId);
                    bodypropCount++;
                }

                var paidFromObject = new JObject();
                var paidFromObjectpropCount = 0;
                if (__workflow_bodypaidFromvalue != null)
                {
                    paidFromObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodypaidFromvalue);
                    paidFromObjectpropCount++;
                }

                if (__workflow_bodypaidFromOperator != null)
                {
                    paidFromObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodypaidFromOperator);
                    paidFromObjectpropCount++;
                }

                if (paidFromObjectpropCount > 0)
                {
                    body["PaidFrom"] = paidFromObject;
                    bodypropCount++;
                }

                var paidToObject = new JObject();
                var paidToObjectpropCount = 0;
                if (__workflow_bodypaidTovalue != null)
                {
                    paidToObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodypaidTovalue);
                    paidToObjectpropCount++;
                }

                if (__workflow_bodypaidToOperator != null)
                {
                    paidToObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodypaidToOperator);
                    paidToObjectpropCount++;
                }

                if (paidToObjectpropCount > 0)
                {
                    body["PaidTo"] = paidToObject;
                    bodypropCount++;
                }

                if (__workflow_bodypaymentId != null)
                {
                    body["PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodypaymentId);
                    bodypropCount++;
                }

                var processedDateObject = new JObject();
                var processedDateObjectpropCount = 0;
                if (__workflow_bodyprocessedDatevalue != null)
                {
                    processedDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodyprocessedDatevalue);
                    processedDateObjectpropCount++;
                }

                if (__workflow_bodyprocessedDateOperator != null)
                {
                    processedDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodyprocessedDateOperator);
                    processedDateObjectpropCount++;
                }

                if (processedDateObjectpropCount > 0)
                {
                    body["ProcessedDate"] = processedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceBookingId != null)
                {
                    body["Reference_BookingID"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceBookingId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodytableId != null)
                {
                    body["TableID"] = ExpressionConverter.ConvertO(__workflow_bodytableId);
                    bodypropCount++;
                }

                if (__workflow_bodytableName != null)
                {
                    body["TableName"] = ExpressionConverter.ConvertO(__workflow_bodytableName);
                    bodypropCount++;
                }

                if (__workflow_bodytag != null)
                {
                    body["Tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                    bodypropCount++;
                }

                if (__workflow_bodytagFinance != null)
                {
                    body["TagFinance"] = ExpressionConverter.ConvertO(__workflow_bodytagFinance);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount != null)
                {
                    body["TaxAmount"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount2 != null)
                {
                    body["TaxAmount2"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount2);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount3 != null)
                {
                    body["TaxAmount3"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount3);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                var transactionDateObject = new JObject();
                var transactionDateObjectpropCount = 0;
                if (__workflow_bodytransactionDatevalue != null)
                {
                    transactionDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodytransactionDatevalue);
                    transactionDateObjectpropCount++;
                }

                if (__workflow_bodytransactionDateOperator != null)
                {
                    transactionDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodytransactionDateOperator);
                    transactionDateObjectpropCount++;
                }

                if (transactionDateObjectpropCount > 0)
                {
                    body["TransactionDate"] = transactionDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodytransactionId != null)
                {
                    body["TransactionID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionId);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionTypeEnum != null)
                {
                    body["TransactionTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodytransactionTypeEnum);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectTransactionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<double>> bodyamount, Expression<Func<int>> bodychargeGroupId, Expression<Func<bodycallTypeEnumInput>> bodycallTypeEnum = null, Expression<Func<int>> bodychargeItemId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydueDate = null, Expression<Func<int>> bodyduration = null, Expression<Func<int>> bodyendOfSessionId = null, Expression<Func<int>> bodyentryId = null, Expression<Func<double>> bodyexcess = null, Expression<Func<int>> bodyextension = null, Expression<Func<int>> bodyexternalId = null, Expression<Func<string>> bodyexternalReceiptId = null, Expression<Func<int>> bodyinvoiceId = null, Expression<Func<string>> bodypaidFrom = null, Expression<Func<string>> bodypaidTo = null, Expression<Func<int>> bodypaymentId = null, Expression<Func<string>> bodyprocessedDate = null, Expression<Func<int>> bodyreferenceBookingId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<int>> bodytableId = null, Expression<Func<string>> bodytableName = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodytagFinance = null, Expression<Func<double>> bodytaxAmount = null, Expression<Func<double>> bodytaxAmount2 = null, Expression<Func<double>> bodytaxAmount3 = null, Expression<Func<int>> bodytermSessionId = null, Expression<Func<string>> bodytransactionDate = null, Expression<Func<bodytransactionTypeEnumInput>> bodytransactionTypeEnum = null)
        {
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: true);
            var __workflow_bodychargeGroupId = WorkflowExpression.Compile(bodychargeGroupId, nameof(bodychargeGroupId), required: true);
            var __workflow_bodycallTypeEnum = WorkflowExpression.Compile(bodycallTypeEnum, nameof(bodycallTypeEnum), required: false);
            var __workflow_bodychargeItemId = WorkflowExpression.Compile(bodychargeItemId, nameof(bodychargeItemId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodyendOfSessionId = WorkflowExpression.Compile(bodyendOfSessionId, nameof(bodyendOfSessionId), required: false);
            var __workflow_bodyentryId = WorkflowExpression.Compile(bodyentryId, nameof(bodyentryId), required: false);
            var __workflow_bodyexcess = WorkflowExpression.Compile(bodyexcess, nameof(bodyexcess), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalReceiptId = WorkflowExpression.Compile(bodyexternalReceiptId, nameof(bodyexternalReceiptId), required: false);
            var __workflow_bodyinvoiceId = WorkflowExpression.Compile(bodyinvoiceId, nameof(bodyinvoiceId), required: false);
            var __workflow_bodypaidFrom = WorkflowExpression.Compile(bodypaidFrom, nameof(bodypaidFrom), required: false);
            var __workflow_bodypaidTo = WorkflowExpression.Compile(bodypaidTo, nameof(bodypaidTo), required: false);
            var __workflow_bodypaymentId = WorkflowExpression.Compile(bodypaymentId, nameof(bodypaymentId), required: false);
            var __workflow_bodyprocessedDate = WorkflowExpression.Compile(bodyprocessedDate, nameof(bodyprocessedDate), required: false);
            var __workflow_bodyreferenceBookingId = WorkflowExpression.Compile(bodyreferenceBookingId, nameof(bodyreferenceBookingId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodytableId = WorkflowExpression.Compile(bodytableId, nameof(bodytableId), required: false);
            var __workflow_bodytableName = WorkflowExpression.Compile(bodytableName, nameof(bodytableName), required: false);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: false);
            var __workflow_bodytagFinance = WorkflowExpression.Compile(bodytagFinance, nameof(bodytagFinance), required: false);
            var __workflow_bodytaxAmount = WorkflowExpression.Compile(bodytaxAmount, nameof(bodytaxAmount), required: false);
            var __workflow_bodytaxAmount2 = WorkflowExpression.Compile(bodytaxAmount2, nameof(bodytaxAmount2), required: false);
            var __workflow_bodytaxAmount3 = WorkflowExpression.Compile(bodytaxAmount3, nameof(bodytaxAmount3), required: false);
            var __workflow_bodytermSessionId = WorkflowExpression.Compile(bodytermSessionId, nameof(bodytermSessionId), required: false);
            var __workflow_bodytransactionDate = WorkflowExpression.Compile(bodytransactionDate, nameof(bodytransactionDate), required: false);
            var __workflow_bodytransactionTypeEnum = WorkflowExpression.Compile(bodytransactionTypeEnum, nameof(bodytransactionTypeEnum), required: false);
            return new DeferredBodyAction<CreateTransactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                if (__workflow_bodycallTypeEnum != null)
                {
                    body["CallTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodycallTypeEnum);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ChargeGroupID"] = ExpressionConverter.ConvertO(__workflow_bodychargeGroupId);
                if (__workflow_bodychargeItemId != null)
                {
                    body["ChargeItemID"] = ExpressionConverter.ConvertO(__workflow_bodychargeItemId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["Comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["Duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodyendOfSessionId != null)
                {
                    body["EndOfSessionID"] = ExpressionConverter.ConvertO(__workflow_bodyendOfSessionId);
                    bodypropCount++;
                }

                if (__workflow_bodyentryId != null)
                {
                    body["EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyentryId);
                    bodypropCount++;
                }

                if (__workflow_bodyexcess != null)
                {
                    body["Excess"] = ExpressionConverter.ConvertO(__workflow_bodyexcess);
                    bodypropCount++;
                }

                if (__workflow_bodyextension != null)
                {
                    body["Extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["ExternalID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReceiptId != null)
                {
                    body["ExternalReceiptID"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReceiptId);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceId != null)
                {
                    body["InvoiceID"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceId);
                    bodypropCount++;
                }

                if (__workflow_bodypaidFrom != null)
                {
                    body["PaidFrom"] = ExpressionConverter.ConvertO(__workflow_bodypaidFrom);
                    bodypropCount++;
                }

                if (__workflow_bodypaidTo != null)
                {
                    body["PaidTo"] = ExpressionConverter.ConvertO(__workflow_bodypaidTo);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentId != null)
                {
                    body["PaymentID"] = ExpressionConverter.ConvertO(__workflow_bodypaymentId);
                    bodypropCount++;
                }

                if (__workflow_bodyprocessedDate != null)
                {
                    body["ProcessedDate"] = ExpressionConverter.ConvertO(__workflow_bodyprocessedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceBookingId != null)
                {
                    body["Reference_BookingID"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceBookingId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodytableId != null)
                {
                    body["TableID"] = ExpressionConverter.ConvertO(__workflow_bodytableId);
                    bodypropCount++;
                }

                if (__workflow_bodytableName != null)
                {
                    body["TableName"] = ExpressionConverter.ConvertO(__workflow_bodytableName);
                    bodypropCount++;
                }

                if (__workflow_bodytag != null)
                {
                    body["Tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                    bodypropCount++;
                }

                if (__workflow_bodytagFinance != null)
                {
                    body["TagFinance"] = ExpressionConverter.ConvertO(__workflow_bodytagFinance);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount != null)
                {
                    body["TaxAmount"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount2 != null)
                {
                    body["TaxAmount2"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount2);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAmount3 != null)
                {
                    body["TaxAmount3"] = ExpressionConverter.ConvertO(__workflow_bodytaxAmount3);
                    bodypropCount++;
                }

                if (__workflow_bodytermSessionId != null)
                {
                    body["TermSessionID"] = ExpressionConverter.ConvertO(__workflow_bodytermSessionId);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionDate != null)
                {
                    body["TransactionDate"] = ExpressionConverter.ConvertO(__workflow_bodytransactionDate);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionTypeEnum != null)
                {
                    body["TransactionTypeEnum"] = ExpressionConverter.ConvertO(__workflow_bodytransactionTypeEnum);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTransactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceMaintenanceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpaceMaintenance(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodyaccountCode = null, Expression<Func<string>> bodycause = null, Expression<Func<bool>> bodycharge = null, Expression<Func<int>> bodychargeEntryId = null, Expression<Func<double>> bodychargeAmount = null, Expression<Func<bool>> bodychargeInvoiced = null, Expression<Func<string>> bodychargeInvoiceNumber = null, Expression<Func<string>> bodychargeType = null, Expression<Func<string>> bodycompleteDatevalue = null, Expression<Func<bodycompleteDateOperatorInput>> bodycompleteDateOperator = null, Expression<Func<int>> bodycontactId = null, Expression<Func<string>> bodycontractDatevalue = null, Expression<Func<bodycontractDateOperatorInput>> bodycontractDateOperator = null, Expression<Func<double>> bodycontractorCost = null, Expression<Func<double>> bodycontractorCostEstimate = null, Expression<Func<string>> bodycontractorDatevalue = null, Expression<Func<bodycontractorDateOperatorInput>> bodycontractorDateOperator = null, Expression<Func<string>> bodycontractorETA = null, Expression<Func<string>> bodycontractorOrderNumber = null, Expression<Func<int>> bodycreatedBySecurityUserId = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1value = null, Expression<Func<bodycustomDate1OperatorInput>> bodycustomDate1Operator = null, Expression<Func<string>> bodycustomDate2value = null, Expression<Func<bodycustomDate2OperatorInput>> bodycustomDate2Operator = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateCreatedvalue = null, Expression<Func<bodydateCreatedOperatorInput>> bodydateCreatedOperator = null, Expression<Func<string>> bodydateDuevalue = null, Expression<Func<bodydateDueOperatorInput>> bodydateDueOperator = null, Expression<Func<string>> bodydateModifiedvalue = null, Expression<Func<bodydateModifiedOperatorInput>> bodydateModifiedOperator = null, Expression<Func<string>> bodydateReportedvalue = null, Expression<Func<bodydateReportedOperatorInput>> bodydateReportedOperator = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyjobSent = null, Expression<Func<string>> bodyjobStatus = null, Expression<Func<string>> bodylocation = null, Expression<Func<int>> bodyoccupantEntryId = null, Expression<Func<string>> bodyoccupantEntryName = null, Expression<Func<bool>> bodyoccupantPresent = null, Expression<Func<string>> bodyoccupantPresentReason = null, Expression<Func<string>> bodyotherServiceNumber = null, Expression<Func<int>> bodypriorityId = null, Expression<Func<string>> bodyrepairDescription = null, Expression<Func<string>> bodyreportedByName = null, Expression<Func<string>> bodyreportedByPhone = null, Expression<Func<int>> bodyroomSpaceClosedId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<int>> bodyroomSpaceMaintenanceCategoryId = null, Expression<Func<int>> bodyroomSpaceMaintenanceId = null, Expression<Func<int>> bodyroomSpaceMaintenanceItemId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<string>> bodystartDatevalue = null, Expression<Func<bodystartDateOperatorInput>> bodystartDateOperator = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytechnician = null, Expression<Func<bool>> bodyviewOnWeb = null)
        {
            var __workflow_bodyPageSize = WorkflowExpression.Compile(bodyPageSize, nameof(bodyPageSize), required: true);
            var __workflow_bodyPageIndex = WorkflowExpression.Compile(bodyPageIndex, nameof(bodyPageIndex), required: true);
            var __workflow_bodyReturnEmptyArrayOnNoResult = WorkflowExpression.Compile(bodyReturnEmptyArrayOnNoResult, nameof(bodyReturnEmptyArrayOnNoResult), required: false);
            var __workflow_bodyOrderby = WorkflowExpression.Compile(bodyOrderby, nameof(bodyOrderby), required: false);
            var __workflow_bodyaccountCode = WorkflowExpression.Compile(bodyaccountCode, nameof(bodyaccountCode), required: false);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: false);
            var __workflow_bodycharge = WorkflowExpression.Compile(bodycharge, nameof(bodycharge), required: false);
            var __workflow_bodychargeEntryId = WorkflowExpression.Compile(bodychargeEntryId, nameof(bodychargeEntryId), required: false);
            var __workflow_bodychargeAmount = WorkflowExpression.Compile(bodychargeAmount, nameof(bodychargeAmount), required: false);
            var __workflow_bodychargeInvoiced = WorkflowExpression.Compile(bodychargeInvoiced, nameof(bodychargeInvoiced), required: false);
            var __workflow_bodychargeInvoiceNumber = WorkflowExpression.Compile(bodychargeInvoiceNumber, nameof(bodychargeInvoiceNumber), required: false);
            var __workflow_bodychargeType = WorkflowExpression.Compile(bodychargeType, nameof(bodychargeType), required: false);
            var __workflow_bodycompleteDatevalue = WorkflowExpression.Compile(bodycompleteDatevalue, nameof(bodycompleteDatevalue), required: false);
            var __workflow_bodycompleteDateOperator = WorkflowExpression.Compile(bodycompleteDateOperator, nameof(bodycompleteDateOperator), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodycontractDatevalue = WorkflowExpression.Compile(bodycontractDatevalue, nameof(bodycontractDatevalue), required: false);
            var __workflow_bodycontractDateOperator = WorkflowExpression.Compile(bodycontractDateOperator, nameof(bodycontractDateOperator), required: false);
            var __workflow_bodycontractorCost = WorkflowExpression.Compile(bodycontractorCost, nameof(bodycontractorCost), required: false);
            var __workflow_bodycontractorCostEstimate = WorkflowExpression.Compile(bodycontractorCostEstimate, nameof(bodycontractorCostEstimate), required: false);
            var __workflow_bodycontractorDatevalue = WorkflowExpression.Compile(bodycontractorDatevalue, nameof(bodycontractorDatevalue), required: false);
            var __workflow_bodycontractorDateOperator = WorkflowExpression.Compile(bodycontractorDateOperator, nameof(bodycontractorDateOperator), required: false);
            var __workflow_bodycontractorETA = WorkflowExpression.Compile(bodycontractorETA, nameof(bodycontractorETA), required: false);
            var __workflow_bodycontractorOrderNumber = WorkflowExpression.Compile(bodycontractorOrderNumber, nameof(bodycontractorOrderNumber), required: false);
            var __workflow_bodycreatedBySecurityUserId = WorkflowExpression.Compile(bodycreatedBySecurityUserId, nameof(bodycreatedBySecurityUserId), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1value = WorkflowExpression.Compile(bodycustomDate1value, nameof(bodycustomDate1value), required: false);
            var __workflow_bodycustomDate1Operator = WorkflowExpression.Compile(bodycustomDate1Operator, nameof(bodycustomDate1Operator), required: false);
            var __workflow_bodycustomDate2value = WorkflowExpression.Compile(bodycustomDate2value, nameof(bodycustomDate2value), required: false);
            var __workflow_bodycustomDate2Operator = WorkflowExpression.Compile(bodycustomDate2Operator, nameof(bodycustomDate2Operator), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateCreatedvalue = WorkflowExpression.Compile(bodydateCreatedvalue, nameof(bodydateCreatedvalue), required: false);
            var __workflow_bodydateCreatedOperator = WorkflowExpression.Compile(bodydateCreatedOperator, nameof(bodydateCreatedOperator), required: false);
            var __workflow_bodydateDuevalue = WorkflowExpression.Compile(bodydateDuevalue, nameof(bodydateDuevalue), required: false);
            var __workflow_bodydateDueOperator = WorkflowExpression.Compile(bodydateDueOperator, nameof(bodydateDueOperator), required: false);
            var __workflow_bodydateModifiedvalue = WorkflowExpression.Compile(bodydateModifiedvalue, nameof(bodydateModifiedvalue), required: false);
            var __workflow_bodydateModifiedOperator = WorkflowExpression.Compile(bodydateModifiedOperator, nameof(bodydateModifiedOperator), required: false);
            var __workflow_bodydateReportedvalue = WorkflowExpression.Compile(bodydateReportedvalue, nameof(bodydateReportedvalue), required: false);
            var __workflow_bodydateReportedOperator = WorkflowExpression.Compile(bodydateReportedOperator, nameof(bodydateReportedOperator), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyjobSent = WorkflowExpression.Compile(bodyjobSent, nameof(bodyjobSent), required: false);
            var __workflow_bodyjobStatus = WorkflowExpression.Compile(bodyjobStatus, nameof(bodyjobStatus), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyoccupantEntryId = WorkflowExpression.Compile(bodyoccupantEntryId, nameof(bodyoccupantEntryId), required: false);
            var __workflow_bodyoccupantEntryName = WorkflowExpression.Compile(bodyoccupantEntryName, nameof(bodyoccupantEntryName), required: false);
            var __workflow_bodyoccupantPresent = WorkflowExpression.Compile(bodyoccupantPresent, nameof(bodyoccupantPresent), required: false);
            var __workflow_bodyoccupantPresentReason = WorkflowExpression.Compile(bodyoccupantPresentReason, nameof(bodyoccupantPresentReason), required: false);
            var __workflow_bodyotherServiceNumber = WorkflowExpression.Compile(bodyotherServiceNumber, nameof(bodyotherServiceNumber), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyrepairDescription = WorkflowExpression.Compile(bodyrepairDescription, nameof(bodyrepairDescription), required: false);
            var __workflow_bodyreportedByName = WorkflowExpression.Compile(bodyreportedByName, nameof(bodyreportedByName), required: false);
            var __workflow_bodyreportedByPhone = WorkflowExpression.Compile(bodyreportedByPhone, nameof(bodyreportedByPhone), required: false);
            var __workflow_bodyroomSpaceClosedId = WorkflowExpression.Compile(bodyroomSpaceClosedId, nameof(bodyroomSpaceClosedId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomSpaceMaintenanceCategoryId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceCategoryId, nameof(bodyroomSpaceMaintenanceCategoryId), required: false);
            var __workflow_bodyroomSpaceMaintenanceId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceId, nameof(bodyroomSpaceMaintenanceId), required: false);
            var __workflow_bodyroomSpaceMaintenanceItemId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceItemId, nameof(bodyroomSpaceMaintenanceItemId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodystartDatevalue = WorkflowExpression.Compile(bodystartDatevalue, nameof(bodystartDatevalue), required: false);
            var __workflow_bodystartDateOperator = WorkflowExpression.Compile(bodystartDateOperator, nameof(bodystartDateOperator), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytechnician = WorkflowExpression.Compile(bodytechnician, nameof(bodytechnician), required: false);
            var __workflow_bodyviewOnWeb = WorkflowExpression.Compile(bodyviewOnWeb, nameof(bodyviewOnWeb), required: false);
            return new DeferredBodyAction<SelectRoomSpaceMaintenanceResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomSpaceMaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (__workflow_bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(__workflow_bodyReturnEmptyArrayOnNoResult);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["_returnEmptyArrayOnNoResult"] = true;
                    bodypropCount++;
                }

                bodypropCount++;
                body["_pageSize"] = ExpressionConverter.ConvertO(__workflow_bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = ExpressionConverter.ConvertO(__workflow_bodyPageIndex);
                if (__workflow_bodyOrderby != null)
                {
                    body["_orderby"] = ExpressionConverter.ConvertO(__workflow_bodyOrderby);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountCode != null)
                {
                    body["AccountCode"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCode);
                    bodypropCount++;
                }

                if (__workflow_bodycause != null)
                {
                    body["Cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                    bodypropCount++;
                }

                if (__workflow_bodycharge != null)
                {
                    body["Charge"] = ExpressionConverter.ConvertO(__workflow_bodycharge);
                    bodypropCount++;
                }

                if (__workflow_bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodychargeEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodychargeAmount != null)
                {
                    body["ChargeAmount"] = ExpressionConverter.ConvertO(__workflow_bodychargeAmount);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiced);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodychargeType != null)
                {
                    body["ChargeType"] = ExpressionConverter.ConvertO(__workflow_bodychargeType);
                    bodypropCount++;
                }

                var completeDateObject = new JObject();
                var completeDateObjectpropCount = 0;
                if (__workflow_bodycompleteDatevalue != null)
                {
                    completeDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDatevalue);
                    completeDateObjectpropCount++;
                }

                if (__workflow_bodycompleteDateOperator != null)
                {
                    completeDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDateOperator);
                    completeDateObjectpropCount++;
                }

                if (completeDateObjectpropCount > 0)
                {
                    body["CompleteDate"] = completeDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                var contractDateObject = new JObject();
                var contractDateObjectpropCount = 0;
                if (__workflow_bodycontractDatevalue != null)
                {
                    contractDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractDatevalue);
                    contractDateObjectpropCount++;
                }

                if (__workflow_bodycontractDateOperator != null)
                {
                    contractDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractDateOperator);
                    contractDateObjectpropCount++;
                }

                if (contractDateObjectpropCount > 0)
                {
                    body["ContractDate"] = contractDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCost != null)
                {
                    body["ContractorCost"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCost);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCostEstimate);
                    bodypropCount++;
                }

                var contractorDateObject = new JObject();
                var contractorDateObjectpropCount = 0;
                if (__workflow_bodycontractorDatevalue != null)
                {
                    contractorDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodycontractorDatevalue);
                    contractorDateObjectpropCount++;
                }

                if (__workflow_bodycontractorDateOperator != null)
                {
                    contractorDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycontractorDateOperator);
                    contractorDateObjectpropCount++;
                }

                if (contractorDateObjectpropCount > 0)
                {
                    body["ContractorDate"] = contractorDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontractorETA != null)
                {
                    body["ContractorETA"] = ExpressionConverter.ConvertO(__workflow_bodycontractorETA);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (__workflow_bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (__workflow_bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (__workflow_bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (__workflow_bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (__workflow_bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (__workflow_bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateDueObject = new JObject();
                var dateDueObjectpropCount = 0;
                if (__workflow_bodydateDuevalue != null)
                {
                    dateDueObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateDuevalue);
                    dateDueObjectpropCount++;
                }

                if (__workflow_bodydateDueOperator != null)
                {
                    dateDueObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateDueOperator);
                    dateDueObjectpropCount++;
                }

                if (dateDueObjectpropCount > 0)
                {
                    body["DateDue"] = dateDueObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (__workflow_bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (__workflow_bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateReportedObject = new JObject();
                var dateReportedObjectpropCount = 0;
                if (__workflow_bodydateReportedvalue != null)
                {
                    dateReportedObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodydateReportedvalue);
                    dateReportedObjectpropCount++;
                }

                if (__workflow_bodydateReportedOperator != null)
                {
                    dateReportedObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodydateReportedOperator);
                    dateReportedObjectpropCount++;
                }

                if (dateReportedObjectpropCount > 0)
                {
                    body["DateReported"] = dateReportedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyjobSent != null)
                {
                    body["JobSent"] = ExpressionConverter.ConvertO(__workflow_bodyjobSent);
                    bodypropCount++;
                }

                if (__workflow_bodyjobStatus != null)
                {
                    body["JobStatus"] = ExpressionConverter.ConvertO(__workflow_bodyjobStatus);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["Location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresent);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (__workflow_bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["PriorityID"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyrepairDescription != null)
                {
                    body["RepairDescription"] = ExpressionConverter.ConvertO(__workflow_bodyrepairDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByName != null)
                {
                    body["ReportedByName"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByName);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceId != null)
                {
                    body["RoomSpaceMaintenanceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodystartDatevalue != null)
                {
                    startDateObject["Value"] = ExpressionConverter.ConvertO(__workflow_bodystartDatevalue);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodystartDateOperator != null)
                {
                    startDateObject["_operator"] = ExpressionConverter.ConvertO(__workflow_bodystartDateOperator);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["StartDate"] = startDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytechnician != null)
                {
                    body["Technician"] = ExpressionConverter.ConvertO(__workflow_bodytechnician);
                    bodypropCount++;
                }

                if (__workflow_bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = ExpressionConverter.ConvertO(__workflow_bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SelectRoomSpaceMaintenanceResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> CreateRoomSpaceMaintenance(Expression<Func<int>> bodyroomSpaceId, Expression<Func<string>> bodyaccountCode = null, Expression<Func<string>> bodycause = null, Expression<Func<bool>> bodycharge = null, Expression<Func<int>> bodychargeEntryId = null, Expression<Func<double>> bodychargeAmount = null, Expression<Func<bool>> bodychargeInvoiced = null, Expression<Func<string>> bodychargeInvoiceNumber = null, Expression<Func<string>> bodychargeType = null, Expression<Func<string>> bodycompleteDate = null, Expression<Func<int>> bodycontactId = null, Expression<Func<string>> bodycontractDate = null, Expression<Func<double>> bodycontractorCost = null, Expression<Func<double>> bodycontractorCostEstimate = null, Expression<Func<string>> bodycontractorDate = null, Expression<Func<string>> bodycontractorETA = null, Expression<Func<string>> bodycontractorOrderNumber = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateDue = null, Expression<Func<string>> bodydateReported = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyjobSent = null, Expression<Func<string>> bodyjobStatus = null, Expression<Func<string>> bodylocation = null, Expression<Func<int>> bodyoccupantEntryId = null, Expression<Func<string>> bodyoccupantEntryName = null, Expression<Func<bool>> bodyoccupantPresent = null, Expression<Func<string>> bodyoccupantPresentReason = null, Expression<Func<string>> bodyotherServiceNumber = null, Expression<Func<int>> bodypriorityId = null, Expression<Func<string>> bodyrepairDescription = null, Expression<Func<string>> bodyreportedByName = null, Expression<Func<string>> bodyreportedByPhone = null, Expression<Func<int>> bodyroomSpaceClosedId = null, Expression<Func<int>> bodyroomSpaceMaintenanceCategoryId = null, Expression<Func<int>> bodyroomSpaceMaintenanceItemId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytechnician = null, Expression<Func<bool>> bodyviewOnWeb = null)
        {
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: true);
            var __workflow_bodyaccountCode = WorkflowExpression.Compile(bodyaccountCode, nameof(bodyaccountCode), required: false);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: false);
            var __workflow_bodycharge = WorkflowExpression.Compile(bodycharge, nameof(bodycharge), required: false);
            var __workflow_bodychargeEntryId = WorkflowExpression.Compile(bodychargeEntryId, nameof(bodychargeEntryId), required: false);
            var __workflow_bodychargeAmount = WorkflowExpression.Compile(bodychargeAmount, nameof(bodychargeAmount), required: false);
            var __workflow_bodychargeInvoiced = WorkflowExpression.Compile(bodychargeInvoiced, nameof(bodychargeInvoiced), required: false);
            var __workflow_bodychargeInvoiceNumber = WorkflowExpression.Compile(bodychargeInvoiceNumber, nameof(bodychargeInvoiceNumber), required: false);
            var __workflow_bodychargeType = WorkflowExpression.Compile(bodychargeType, nameof(bodychargeType), required: false);
            var __workflow_bodycompleteDate = WorkflowExpression.Compile(bodycompleteDate, nameof(bodycompleteDate), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodycontractDate = WorkflowExpression.Compile(bodycontractDate, nameof(bodycontractDate), required: false);
            var __workflow_bodycontractorCost = WorkflowExpression.Compile(bodycontractorCost, nameof(bodycontractorCost), required: false);
            var __workflow_bodycontractorCostEstimate = WorkflowExpression.Compile(bodycontractorCostEstimate, nameof(bodycontractorCostEstimate), required: false);
            var __workflow_bodycontractorDate = WorkflowExpression.Compile(bodycontractorDate, nameof(bodycontractorDate), required: false);
            var __workflow_bodycontractorETA = WorkflowExpression.Compile(bodycontractorETA, nameof(bodycontractorETA), required: false);
            var __workflow_bodycontractorOrderNumber = WorkflowExpression.Compile(bodycontractorOrderNumber, nameof(bodycontractorOrderNumber), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateDue = WorkflowExpression.Compile(bodydateDue, nameof(bodydateDue), required: false);
            var __workflow_bodydateReported = WorkflowExpression.Compile(bodydateReported, nameof(bodydateReported), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyjobSent = WorkflowExpression.Compile(bodyjobSent, nameof(bodyjobSent), required: false);
            var __workflow_bodyjobStatus = WorkflowExpression.Compile(bodyjobStatus, nameof(bodyjobStatus), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyoccupantEntryId = WorkflowExpression.Compile(bodyoccupantEntryId, nameof(bodyoccupantEntryId), required: false);
            var __workflow_bodyoccupantEntryName = WorkflowExpression.Compile(bodyoccupantEntryName, nameof(bodyoccupantEntryName), required: false);
            var __workflow_bodyoccupantPresent = WorkflowExpression.Compile(bodyoccupantPresent, nameof(bodyoccupantPresent), required: false);
            var __workflow_bodyoccupantPresentReason = WorkflowExpression.Compile(bodyoccupantPresentReason, nameof(bodyoccupantPresentReason), required: false);
            var __workflow_bodyotherServiceNumber = WorkflowExpression.Compile(bodyotherServiceNumber, nameof(bodyotherServiceNumber), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyrepairDescription = WorkflowExpression.Compile(bodyrepairDescription, nameof(bodyrepairDescription), required: false);
            var __workflow_bodyreportedByName = WorkflowExpression.Compile(bodyreportedByName, nameof(bodyreportedByName), required: false);
            var __workflow_bodyreportedByPhone = WorkflowExpression.Compile(bodyreportedByPhone, nameof(bodyreportedByPhone), required: false);
            var __workflow_bodyroomSpaceClosedId = WorkflowExpression.Compile(bodyroomSpaceClosedId, nameof(bodyroomSpaceClosedId), required: false);
            var __workflow_bodyroomSpaceMaintenanceCategoryId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceCategoryId, nameof(bodyroomSpaceMaintenanceCategoryId), required: false);
            var __workflow_bodyroomSpaceMaintenanceItemId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceItemId, nameof(bodyroomSpaceMaintenanceItemId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytechnician = WorkflowExpression.Compile(bodytechnician, nameof(bodytechnician), required: false);
            var __workflow_bodyviewOnWeb = WorkflowExpression.Compile(bodyviewOnWeb, nameof(bodyviewOnWeb), required: false);
            return new DeferredBodyAction<CreateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/roomspacemaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountCode != null)
                {
                    body["AccountCode"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCode);
                    bodypropCount++;
                }

                if (__workflow_bodycause != null)
                {
                    body["Cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                    bodypropCount++;
                }

                if (__workflow_bodycharge != null)
                {
                    body["Charge"] = ExpressionConverter.ConvertO(__workflow_bodycharge);
                    bodypropCount++;
                }

                if (__workflow_bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodychargeEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodychargeAmount != null)
                {
                    body["ChargeAmount"] = ExpressionConverter.ConvertO(__workflow_bodychargeAmount);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiced);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodychargeType != null)
                {
                    body["ChargeType"] = ExpressionConverter.ConvertO(__workflow_bodychargeType);
                    bodypropCount++;
                }

                if (__workflow_bodycompleteDate != null)
                {
                    body["CompleteDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDate != null)
                {
                    body["ContractDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCost != null)
                {
                    body["ContractorCost"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCost);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCostEstimate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorDate != null)
                {
                    body["ContractorDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractorDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorETA != null)
                {
                    body["ContractorETA"] = ExpressionConverter.ConvertO(__workflow_bodycontractorETA);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodydateDue != null)
                {
                    body["DateDue"] = ExpressionConverter.ConvertO(__workflow_bodydateDue);
                    bodypropCount++;
                }

                if (__workflow_bodydateReported != null)
                {
                    body["DateReported"] = ExpressionConverter.ConvertO(__workflow_bodydateReported);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyjobSent != null)
                {
                    body["JobSent"] = ExpressionConverter.ConvertO(__workflow_bodyjobSent);
                    bodypropCount++;
                }

                if (__workflow_bodyjobStatus != null)
                {
                    body["JobStatus"] = ExpressionConverter.ConvertO(__workflow_bodyjobStatus);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["Location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresent);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (__workflow_bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["PriorityID"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyrepairDescription != null)
                {
                    body["RepairDescription"] = ExpressionConverter.ConvertO(__workflow_bodyrepairDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByName != null)
                {
                    body["ReportedByName"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByName);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                if (__workflow_bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytechnician != null)
                {
                    body["Technician"] = ExpressionConverter.ConvertO(__workflow_bodytechnician);
                    bodypropCount++;
                }

                if (__workflow_bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = ExpressionConverter.ConvertO(__workflow_bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateRoomSpaceMaintenanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> UpdateRoomSpaceMaintenance(Expression<Func<int>> roomSpaceMaintenanceId, Expression<Func<string>> bodyaccountCode = null, Expression<Func<string>> bodycause = null, Expression<Func<bool>> bodycharge = null, Expression<Func<int>> bodychargeEntryId = null, Expression<Func<double>> bodychargeAmount = null, Expression<Func<bool>> bodychargeInvoiced = null, Expression<Func<string>> bodychargeInvoiceNumber = null, Expression<Func<string>> bodychargeType = null, Expression<Func<string>> bodycompleteDate = null, Expression<Func<int>> bodycontactId = null, Expression<Func<string>> bodycontractDate = null, Expression<Func<double>> bodycontractorCost = null, Expression<Func<double>> bodycontractorCostEstimate = null, Expression<Func<string>> bodycontractorDate = null, Expression<Func<string>> bodycontractorETA = null, Expression<Func<string>> bodycontractorOrderNumber = null, Expression<Func<bool>> bodycustomBit1 = null, Expression<Func<bool>> bodycustomBit2 = null, Expression<Func<string>> bodycustomDate1 = null, Expression<Func<string>> bodycustomDate2 = null, Expression<Func<string>> bodycustomString1 = null, Expression<Func<string>> bodycustomString2 = null, Expression<Func<string>> bodycustomString3 = null, Expression<Func<string>> bodycustomString4 = null, Expression<Func<string>> bodycustomString5 = null, Expression<Func<string>> bodycustomString6 = null, Expression<Func<string>> bodydateDue = null, Expression<Func<string>> bodydateReported = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyjobSent = null, Expression<Func<string>> bodyjobStatus = null, Expression<Func<string>> bodylocation = null, Expression<Func<int>> bodyoccupantEntryId = null, Expression<Func<string>> bodyoccupantEntryName = null, Expression<Func<bool>> bodyoccupantPresent = null, Expression<Func<string>> bodyoccupantPresentReason = null, Expression<Func<string>> bodyotherServiceNumber = null, Expression<Func<int>> bodypriorityId = null, Expression<Func<string>> bodyrepairDescription = null, Expression<Func<string>> bodyreportedByName = null, Expression<Func<string>> bodyreportedByPhone = null, Expression<Func<int>> bodyroomSpaceClosedId = null, Expression<Func<int>> bodyroomSpaceId = null, Expression<Func<int>> bodyroomSpaceMaintenanceCategoryId = null, Expression<Func<int>> bodyroomSpaceMaintenanceItemId = null, Expression<Func<int>> bodysecurityUserId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytechnician = null, Expression<Func<bool>> bodyviewOnWeb = null)
        {
            var __workflow_roomSpaceMaintenanceId = WorkflowExpression.Compile(roomSpaceMaintenanceId, nameof(roomSpaceMaintenanceId), required: true);
            var __workflow_bodyaccountCode = WorkflowExpression.Compile(bodyaccountCode, nameof(bodyaccountCode), required: false);
            var __workflow_bodycause = WorkflowExpression.Compile(bodycause, nameof(bodycause), required: false);
            var __workflow_bodycharge = WorkflowExpression.Compile(bodycharge, nameof(bodycharge), required: false);
            var __workflow_bodychargeEntryId = WorkflowExpression.Compile(bodychargeEntryId, nameof(bodychargeEntryId), required: false);
            var __workflow_bodychargeAmount = WorkflowExpression.Compile(bodychargeAmount, nameof(bodychargeAmount), required: false);
            var __workflow_bodychargeInvoiced = WorkflowExpression.Compile(bodychargeInvoiced, nameof(bodychargeInvoiced), required: false);
            var __workflow_bodychargeInvoiceNumber = WorkflowExpression.Compile(bodychargeInvoiceNumber, nameof(bodychargeInvoiceNumber), required: false);
            var __workflow_bodychargeType = WorkflowExpression.Compile(bodychargeType, nameof(bodychargeType), required: false);
            var __workflow_bodycompleteDate = WorkflowExpression.Compile(bodycompleteDate, nameof(bodycompleteDate), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodycontractDate = WorkflowExpression.Compile(bodycontractDate, nameof(bodycontractDate), required: false);
            var __workflow_bodycontractorCost = WorkflowExpression.Compile(bodycontractorCost, nameof(bodycontractorCost), required: false);
            var __workflow_bodycontractorCostEstimate = WorkflowExpression.Compile(bodycontractorCostEstimate, nameof(bodycontractorCostEstimate), required: false);
            var __workflow_bodycontractorDate = WorkflowExpression.Compile(bodycontractorDate, nameof(bodycontractorDate), required: false);
            var __workflow_bodycontractorETA = WorkflowExpression.Compile(bodycontractorETA, nameof(bodycontractorETA), required: false);
            var __workflow_bodycontractorOrderNumber = WorkflowExpression.Compile(bodycontractorOrderNumber, nameof(bodycontractorOrderNumber), required: false);
            var __workflow_bodycustomBit1 = WorkflowExpression.Compile(bodycustomBit1, nameof(bodycustomBit1), required: false);
            var __workflow_bodycustomBit2 = WorkflowExpression.Compile(bodycustomBit2, nameof(bodycustomBit2), required: false);
            var __workflow_bodycustomDate1 = WorkflowExpression.Compile(bodycustomDate1, nameof(bodycustomDate1), required: false);
            var __workflow_bodycustomDate2 = WorkflowExpression.Compile(bodycustomDate2, nameof(bodycustomDate2), required: false);
            var __workflow_bodycustomString1 = WorkflowExpression.Compile(bodycustomString1, nameof(bodycustomString1), required: false);
            var __workflow_bodycustomString2 = WorkflowExpression.Compile(bodycustomString2, nameof(bodycustomString2), required: false);
            var __workflow_bodycustomString3 = WorkflowExpression.Compile(bodycustomString3, nameof(bodycustomString3), required: false);
            var __workflow_bodycustomString4 = WorkflowExpression.Compile(bodycustomString4, nameof(bodycustomString4), required: false);
            var __workflow_bodycustomString5 = WorkflowExpression.Compile(bodycustomString5, nameof(bodycustomString5), required: false);
            var __workflow_bodycustomString6 = WorkflowExpression.Compile(bodycustomString6, nameof(bodycustomString6), required: false);
            var __workflow_bodydateDue = WorkflowExpression.Compile(bodydateDue, nameof(bodydateDue), required: false);
            var __workflow_bodydateReported = WorkflowExpression.Compile(bodydateReported, nameof(bodydateReported), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyjobSent = WorkflowExpression.Compile(bodyjobSent, nameof(bodyjobSent), required: false);
            var __workflow_bodyjobStatus = WorkflowExpression.Compile(bodyjobStatus, nameof(bodyjobStatus), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyoccupantEntryId = WorkflowExpression.Compile(bodyoccupantEntryId, nameof(bodyoccupantEntryId), required: false);
            var __workflow_bodyoccupantEntryName = WorkflowExpression.Compile(bodyoccupantEntryName, nameof(bodyoccupantEntryName), required: false);
            var __workflow_bodyoccupantPresent = WorkflowExpression.Compile(bodyoccupantPresent, nameof(bodyoccupantPresent), required: false);
            var __workflow_bodyoccupantPresentReason = WorkflowExpression.Compile(bodyoccupantPresentReason, nameof(bodyoccupantPresentReason), required: false);
            var __workflow_bodyotherServiceNumber = WorkflowExpression.Compile(bodyotherServiceNumber, nameof(bodyotherServiceNumber), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyrepairDescription = WorkflowExpression.Compile(bodyrepairDescription, nameof(bodyrepairDescription), required: false);
            var __workflow_bodyreportedByName = WorkflowExpression.Compile(bodyreportedByName, nameof(bodyreportedByName), required: false);
            var __workflow_bodyreportedByPhone = WorkflowExpression.Compile(bodyreportedByPhone, nameof(bodyreportedByPhone), required: false);
            var __workflow_bodyroomSpaceClosedId = WorkflowExpression.Compile(bodyroomSpaceClosedId, nameof(bodyroomSpaceClosedId), required: false);
            var __workflow_bodyroomSpaceId = WorkflowExpression.Compile(bodyroomSpaceId, nameof(bodyroomSpaceId), required: false);
            var __workflow_bodyroomSpaceMaintenanceCategoryId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceCategoryId, nameof(bodyroomSpaceMaintenanceCategoryId), required: false);
            var __workflow_bodyroomSpaceMaintenanceItemId = WorkflowExpression.Compile(bodyroomSpaceMaintenanceItemId, nameof(bodyroomSpaceMaintenanceItemId), required: false);
            var __workflow_bodysecurityUserId = WorkflowExpression.Compile(bodysecurityUserId, nameof(bodysecurityUserId), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytechnician = WorkflowExpression.Compile(bodytechnician, nameof(bodytechnician), required: false);
            var __workflow_bodyviewOnWeb = WorkflowExpression.Compile(bodyviewOnWeb, nameof(bodyviewOnWeb), required: false);
            return new DeferredBodyAction<UpdateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/roomspacemaintenance.json/{0}", __workflow_roomSpaceMaintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountCode != null)
                {
                    body["AccountCode"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCode);
                    bodypropCount++;
                }

                if (__workflow_bodycause != null)
                {
                    body["Cause"] = ExpressionConverter.ConvertO(__workflow_bodycause);
                    bodypropCount++;
                }

                if (__workflow_bodycharge != null)
                {
                    body["Charge"] = ExpressionConverter.ConvertO(__workflow_bodycharge);
                    bodypropCount++;
                }

                if (__workflow_bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodychargeEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodychargeAmount != null)
                {
                    body["ChargeAmount"] = ExpressionConverter.ConvertO(__workflow_bodychargeAmount);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiced);
                    bodypropCount++;
                }

                if (__workflow_bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodychargeType != null)
                {
                    body["ChargeType"] = ExpressionConverter.ConvertO(__workflow_bodychargeType);
                    bodypropCount++;
                }

                if (__workflow_bodycompleteDate != null)
                {
                    body["CompleteDate"] = ExpressionConverter.ConvertO(__workflow_bodycompleteDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodycontractDate != null)
                {
                    body["ContractDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCost != null)
                {
                    body["ContractorCost"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCost);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(__workflow_bodycontractorCostEstimate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorDate != null)
                {
                    body["ContractorDate"] = ExpressionConverter.ConvertO(__workflow_bodycontractorDate);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorETA != null)
                {
                    body["ContractorETA"] = ExpressionConverter.ConvertO(__workflow_bodycontractorETA);
                    bodypropCount++;
                }

                if (__workflow_bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(__workflow_bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit1 != null)
                {
                    body["CustomBit1"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBit2 != null)
                {
                    body["CustomBit2"] = ExpressionConverter.ConvertO(__workflow_bodycustomBit2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate1 != null)
                {
                    body["CustomDate1"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDate2 != null)
                {
                    body["CustomDate2"] = ExpressionConverter.ConvertO(__workflow_bodycustomDate2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString1 != null)
                {
                    body["CustomString1"] = ExpressionConverter.ConvertO(__workflow_bodycustomString1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString2 != null)
                {
                    body["CustomString2"] = ExpressionConverter.ConvertO(__workflow_bodycustomString2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString3 != null)
                {
                    body["CustomString3"] = ExpressionConverter.ConvertO(__workflow_bodycustomString3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString4 != null)
                {
                    body["CustomString4"] = ExpressionConverter.ConvertO(__workflow_bodycustomString4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString5 != null)
                {
                    body["CustomString5"] = ExpressionConverter.ConvertO(__workflow_bodycustomString5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomString6 != null)
                {
                    body["CustomString6"] = ExpressionConverter.ConvertO(__workflow_bodycustomString6);
                    bodypropCount++;
                }

                if (__workflow_bodydateDue != null)
                {
                    body["DateDue"] = ExpressionConverter.ConvertO(__workflow_bodydateDue);
                    bodypropCount++;
                }

                if (__workflow_bodydateReported != null)
                {
                    body["DateReported"] = ExpressionConverter.ConvertO(__workflow_bodydateReported);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyjobSent != null)
                {
                    body["JobSent"] = ExpressionConverter.ConvertO(__workflow_bodyjobSent);
                    bodypropCount++;
                }

                if (__workflow_bodyjobStatus != null)
                {
                    body["JobStatus"] = ExpressionConverter.ConvertO(__workflow_bodyjobStatus);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["Location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresent);
                    bodypropCount++;
                }

                if (__workflow_bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = ExpressionConverter.ConvertO(__workflow_bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (__workflow_bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["PriorityID"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyrepairDescription != null)
                {
                    body["RepairDescription"] = ExpressionConverter.ConvertO(__workflow_bodyrepairDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByName != null)
                {
                    body["ReportedByName"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByName);
                    bodypropCount++;
                }

                if (__workflow_bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = ExpressionConverter.ConvertO(__workflow_bodyreportedByPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(__workflow_bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = ExpressionConverter.ConvertO(__workflow_bodysecurityUserId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["StartDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytechnician != null)
                {
                    body["Technician"] = ExpressionConverter.ConvertO(__workflow_bodytechnician);
                    bodypropCount++;
                }

                if (__workflow_bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = ExpressionConverter.ConvertO(__workflow_bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRoomSpaceMaintenanceResponse>(callPayload);
            });
        }
    }

    public class Starrezrestv1Triggers([ConnectionName] string connectionId)
    {
    }

    public class SelectEntryResponseItem
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public enum bodyPageSizeInput
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodybirthGenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateCreatedOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateModifiedOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydOBOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyentryStatusEnumInput
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylastCheckInOutDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypreviousEntryStatusEnumInput
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytaxExemptionEnumInput
    {
        FullExemption,
        None,
        Tax1Exempt,
        Tax2Exempt,
        Tax3Exempt
    }

    public class CreateEntryResponse
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public class UpdateEntryResponse
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tableNameInput
    {
        Booking,
        Entry,
        EntryAddress,
        EntryApplication,
        EntryCustomField,
        EntryDetail,
        EntryEnrollment,
        RoomLocation,
        RoomSpace,
        RoomSpaceMaintenance,
        Term,
        TermSession,
        Transaction
    }

    public class SelectEntryCustomFieldResponseItem
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int CustomFieldDefinitionId { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string FieldDataTypeEnum { get; set; }
        public bool ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int ValueInteger { get; set; }
        public double ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfieldDataTypeEnumInput
    {
        Boolean,
        Date,
        DateTime,
        Integer,
        Money,
        String,
        StringLong
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvalueDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryCustomFieldResponse
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int CustomFieldDefinitionId { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string FieldDataTypeEnum { get; set; }
        public bool ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int ValueInteger { get; set; }
        public double ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    public class SelectTermResponseItem
    {
        public bool Active { get; set; }
        public string ActiveDateClose { get; set; }
        public string ActiveDateOpen { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string Comments { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string RecordTypeEnum { get; set; }
        public string TermCode { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }

        [JsonProperty("TermTypeID")]
        public int TermTypeId { get; set; }
        public string WebDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactiveDateCloseOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactiveDateOpenOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecordTypeEnumInput
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    public class SelectEntryAddressResponseItem
    {
        public string ActiveDateEnd { get; set; }
        public string ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string DateModified { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryAddressID")]
        public int EntryAddressId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactiveDateEndOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactiveDateStartOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryAddressResponse
    {
        public string ActiveDateEnd { get; set; }
        public string ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryAddressID")]
        public int EntryAddressId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectEntryApplicationResponseItem
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EnquiryDate { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyallocateOptionEnumInput
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyapplicationDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycancelDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycompleteDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractSignedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycustomDate1OperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycustomDate2OperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycustomDate3OperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycustomDate4OperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenquiryDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexpectedArrivalDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexpectedArrivalDateLatestOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexpectedDepartureDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyofferedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyofferReplyDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyofferReplyEnumInput
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyofferSentDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceivedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceivedDepositDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceivedFeeDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceivedPhotoDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateEntryApplicationResponse
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }
        public string EnquiryDate { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    public class UpdateEntryApplicationResponse
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EnquiryDate { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    public class SelectTermSessionResponseItem
    {
        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }

        [JsonProperty("CancelBookingDefaultEnd_BookingReasonID")]
        public int CancelBookingDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CancelBookingUpdateEndBookingReason_BooleanAskEnum")]
        public string CancelBookingUpdateEndBookingReasonBooleanAskEnum { get; set; }
        public string CheckInDate { get; set; }

        [JsonProperty("CheckInDateActualDecrease_BooleanAskEnum")]
        public string CheckInDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDateActualIncrease_BooleanAskEnum")]
        public string CheckInDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDefaultStart_BookingReasonID")]
        public int CheckInDefaultStartBookingReasonId { get; set; }

        [JsonProperty("CheckInUpdateStartBookingReason_BooleanAskEnum")]
        public string CheckInUpdateStartBookingReasonBooleanAskEnum { get; set; }
        public string CheckOutDate { get; set; }

        [JsonProperty("CheckOutDateActualDecrease_BooleanAskEnum")]
        public string CheckOutDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDateActualIncrease_BooleanAskEnum")]
        public string CheckOutDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDefaultEnd_BookingReasonID")]
        public int CheckOutDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CheckOutUpdateEndBookingReason_BooleanAskEnum")]
        public string CheckOutUpdateEndBookingReasonBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInDecrease_BooleanAskEnum")]
        public string ContractDateCheckInDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInIncrease_BooleanAskEnum")]
        public string ContractDateCheckInIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutDecrease_BooleanAskEnum")]
        public string ContractDateCheckOutDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutIncrease_BooleanAskEnum")]
        public string ContractDateCheckOutIncreaseBooleanAskEnum { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public string RecordTypeEnum { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string TermSessionCode { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public bool UseActiveBookingAsTemplate { get; set; }
        public string WebDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycancelBookingUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckInDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckInDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckInDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckInUpdateStartBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckOutDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckOutDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckOutDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckOutUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateCheckInDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateCheckInIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateCheckOutDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateCheckOutIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateEndOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateStartOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailResponseItem
    {
        public bool AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int AccountPaymentTypeId { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public string AccountDueDate { get; set; }
        public bool AccountHold { get; set; }
        public bool Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public string AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryId { get; set; }
        public double CumulativeGPA { get; set; }
        public double CumulativeHours { get; set; }
        public double CurrentGPA { get; set; }
        public double CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public string DateEntry { get; set; }
        public string DateExit { get; set; }
        public string DateModified { get; set; }
        public bool Deceased { get; set; }
        public string DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int EnrollmentYear { get; set; }

        [JsonProperty("EntryDetailID")]
        public int EntryDetailId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int EventRegistrationFeeId { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool HonorsIndicator { get; set; }
        public bool ImmunizationsHold { get; set; }
        public bool IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool International { get; set; }
        public string InternationalDetails { get; set; }
        public bool LivingWithDependents { get; set; }
        public bool Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public string SituationResponseEnum { get; set; }
        public string SituationResponseExpiryDate { get; set; }
        public string SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int StaffId { get; set; }
        public bool UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool VisitorHold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaccountDueDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyattendeeStatusEnumInput
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateEntryOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateExitOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydeceasedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyexpectedGraduationDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysituationResponseEnumInput
    {
        NoResponse,
        NotOkay,
        Okay
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysituationResponseExpiryDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysituationResponseModifiedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryDetailResponse
    {
        public bool AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int AccountPaymentTypeId { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public string AccountDueDate { get; set; }
        public bool AccountHold { get; set; }
        public bool Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public string AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryId { get; set; }
        public double CumulativeGPA { get; set; }
        public double CumulativeHours { get; set; }
        public double CurrentGPA { get; set; }
        public double CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public string DateEntry { get; set; }
        public string DateExit { get; set; }
        public bool Deceased { get; set; }
        public string DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int EnrollmentYear { get; set; }

        [JsonProperty("EntryDetailID")]
        public int EntryDetailId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int EventRegistrationFeeId { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool HonorsIndicator { get; set; }
        public bool ImmunizationsHold { get; set; }
        public bool IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool International { get; set; }
        public string InternationalDetails { get; set; }
        public bool LivingWithDependents { get; set; }
        public bool Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public string SituationResponseEnum { get; set; }
        public string SituationResponseExpiryDate { get; set; }
        public string SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int StaffId { get; set; }
        public bool UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool VisitorHold { get; set; }
    }

    public class SelectEntryEnrollmentResponseItem
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateModified { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateEndOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateStartOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenrollmentTypeEnumInput
    {
        Current,
        Preferred,
        Previous
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygraduationDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateEntryEnrollmentResponse
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    public class UpdateEntryEnrollmentResponse
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    public class SelectBookingResponseItem
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodybookingLinkTypeEnumInput
    {
        None,
        Child,
        Parent,
        Reference
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckInDateActualOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycheckOutDateActualOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateBilledOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateChargedToOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateModifiedBillingOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypaidToOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateBookingResponse
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    public class UpdateBookingResponse
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    public class SelectRoomSpaceResponseItem
    {
        public bool AllocateExclude { get; set; }
        public int AllocateSortOrder { get; set; }
        public int Bathrooms { get; set; }
        public int BedCapacity { get; set; }
        public string Comments { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int ExtensionId { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }
        public string RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyroomSpaceTypeEnumInput
    {
        Admin,
        Bed,
        BedClosed,
        Public,
        Shared
    }

    public class CreateRoomSpaceResponse
    {
        public bool AllocateExclude { get; set; }
        public int AllocateSortOrder { get; set; }
        public int Bathrooms { get; set; }
        public int BedCapacity { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int ExtensionId { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }
        public string RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectRoomLocationResponseItem
    {
        public int AllocateSortOrder { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string GenderTypeEnum { get; set; }
        public bool Lease { get; set; }
        public bool ManagedExternally { get; set; }
        public bool NonResidential { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomLocationAreaID")]
        public int RoomLocationAreaId { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public string StateProvince { get; set; }
        public bool ViewOnWeb { get; set; }
        public string WebComments { get; set; }
        public string WebDescription { get; set; }
        public string WebImageAltText { get; set; }
        public string WebImageLocation { get; set; }
        public string ZipPostcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygenderTypeEnumInput
    {
        [EnumMember(Value = "CoEd")]
        CoEducation,
        DynamicGender,
        Female,
        Male,
        Neutral
    }

    public class SelectTransactionResponseItem
    {
        public double Amount { get; set; }
        public string CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int ChargeItemId { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int InvoiceId { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int PaymentId { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public string TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int TransactionId { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycallTypeEnumInput
    {
        Fixed,
        Free,
        International,
        Local,
        LongDistance,
        Mobile,
        None,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydueDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypaidFromOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyprocessedDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytransactionDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytransactionTypeEnumInput
    {
        Adjustment,
        Charge,
        Payment,
        Refund,
        Telephone,
        Transfer
    }

    public class CreateTransactionResponse
    {
        public double Amount { get; set; }
        public string CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int ChargeItemId { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int InvoiceId { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int PaymentId { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public string TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int TransactionId { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

    public class SelectRoomSpaceMaintenanceResponseItem
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontractorDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateDueOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydateReportedOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystartDateOperatorInput
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateRoomSpaceMaintenanceResponse
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

    public class UpdateRoomSpaceMaintenanceResponse
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1;

    public partial class WorkflowManagedActions
    {
        public Starrezrestv1Actions Starrezrestv1(string connectionId) => new Starrezrestv1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Starrezrestv1Triggers Starrezrestv1(string connectionId) => new Starrezrestv1Triggers(connectionId);
    }
}