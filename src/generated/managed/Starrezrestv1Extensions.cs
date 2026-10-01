//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Starrezrestv1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryResponseItem[]> SelectEntry([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<int> bodyaddressTypeId = null, [WorkflowExpression] Func<bodybirthGenderEnumInput> bodybirthGenderEnum = null, [WorkflowExpression] Func<int> bodybookingId = null, [WorkflowExpression] Func<int> bodycategoryId = null, [WorkflowExpression] Func<string> bodyconferenceEmail = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<int> bodycreatedBySecurityUserId = null, [WorkflowExpression] Func<string> bodydateCreatedvalue = null, [WorkflowExpression] Func<bodydateCreatedOperatorInput> bodydateCreatedOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<bool> bodydirectoryFlagPrivacy = null, [WorkflowExpression] Func<string> bodydOBvalue = null, [WorkflowExpression] Func<bodydOBOperatorInput> bodydOBOperator = null, [WorkflowExpression] Func<int> bodyentryApplicationId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<int> bodyeventId = null, [WorkflowExpression] Func<bodygenderEnumInput> bodygenderEnum = null, [WorkflowExpression] Func<string> bodyiD1 = null, [WorkflowExpression] Func<string> bodyiD2 = null, [WorkflowExpression] Func<string> bodyiD3 = null, [WorkflowExpression] Func<int> bodyiD4 = null, [WorkflowExpression] Func<int> bodyiD5 = null, [WorkflowExpression] Func<string> bodylastCheckInOutDatevalue = null, [WorkflowExpression] Func<bodylastCheckInOutDateOperatorInput> bodylastCheckInOutDateOperator = null, [WorkflowExpression] Func<string> bodynameFirst = null, [WorkflowExpression] Func<string> bodynameInitials = null, [WorkflowExpression] Func<string> bodynameLast = null, [WorkflowExpression] Func<string> bodynameOther = null, [WorkflowExpression] Func<string> bodynamePreferred = null, [WorkflowExpression] Func<string> bodynameSharer = null, [WorkflowExpression] Func<string> bodynameTitle = null, [WorkflowExpression] Func<string> bodynameWeb = null, [WorkflowExpression] Func<int> bodypinNumber = null, [WorkflowExpression] Func<string> bodyportalAuthProviderUserId = null, [WorkflowExpression] Func<string> bodyportalEmail = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bodypreviousEntryStatusEnumInput> bodypreviousEntryStatusEnum = null, [WorkflowExpression] Func<bodytaxExemptionEnumInput> bodytaxExemptionEnum = null, [WorkflowExpression] Func<bool> bodytesting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = SourceExpressionConverter.ConvertToken(bodyaddressTypeId);
                    bodypropCount++;
                }

                if (bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = SourceExpressionConverter.Convert(bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (bodybookingId != null)
                {
                    body["BookingID"] = SourceExpressionConverter.ConvertToken(bodybookingId);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["CategoryID"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = SourceExpressionConverter.ConvertToken(bodyconferenceEmail);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = SourceExpressionConverter.Convert(bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = SourceExpressionConverter.ConvertToken(bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                var dOBObject = new JObject();
                var dOBObjectpropCount = 0;
                if (bodydOBvalue != null)
                {
                    dOBObject["Value"] = SourceExpressionConverter.ConvertToken(bodydOBvalue);
                    dOBObjectpropCount++;
                }

                if (bodydOBOperator != null)
                {
                    dOBObject["_operator"] = SourceExpressionConverter.Convert(bodydOBOperator);
                    dOBObjectpropCount++;
                }

                if (dOBObjectpropCount > 0)
                {
                    body["DOB"] = dOBObject;
                    bodypropCount++;
                }

                if (bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = SourceExpressionConverter.ConvertToken(bodyentryApplicationId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["EventID"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodygenderEnum != null)
                {
                    body["GenderEnum"] = SourceExpressionConverter.Convert(bodygenderEnum);
                    bodypropCount++;
                }

                if (bodyiD1 != null)
                {
                    body["ID1"] = SourceExpressionConverter.ConvertToken(bodyiD1);
                    bodypropCount++;
                }

                if (bodyiD2 != null)
                {
                    body["ID2"] = SourceExpressionConverter.ConvertToken(bodyiD2);
                    bodypropCount++;
                }

                if (bodyiD3 != null)
                {
                    body["ID3"] = SourceExpressionConverter.ConvertToken(bodyiD3);
                    bodypropCount++;
                }

                if (bodyiD4 != null)
                {
                    body["ID4"] = SourceExpressionConverter.ConvertToken(bodyiD4);
                    bodypropCount++;
                }

                if (bodyiD5 != null)
                {
                    body["ID5"] = SourceExpressionConverter.ConvertToken(bodyiD5);
                    bodypropCount++;
                }

                var lastCheckInOutDateObject = new JObject();
                var lastCheckInOutDateObjectpropCount = 0;
                if (bodylastCheckInOutDatevalue != null)
                {
                    lastCheckInOutDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodylastCheckInOutDatevalue);
                    lastCheckInOutDateObjectpropCount++;
                }

                if (bodylastCheckInOutDateOperator != null)
                {
                    lastCheckInOutDateObject["_operator"] = SourceExpressionConverter.Convert(bodylastCheckInOutDateOperator);
                    lastCheckInOutDateObjectpropCount++;
                }

                if (lastCheckInOutDateObjectpropCount > 0)
                {
                    body["LastCheckInOutDate"] = lastCheckInOutDateObject;
                    bodypropCount++;
                }

                if (bodynameFirst != null)
                {
                    body["NameFirst"] = SourceExpressionConverter.ConvertToken(bodynameFirst);
                    bodypropCount++;
                }

                if (bodynameInitials != null)
                {
                    body["NameInitials"] = SourceExpressionConverter.ConvertToken(bodynameInitials);
                    bodypropCount++;
                }

                if (bodynameLast != null)
                {
                    body["NameLast"] = SourceExpressionConverter.ConvertToken(bodynameLast);
                    bodypropCount++;
                }

                if (bodynameOther != null)
                {
                    body["NameOther"] = SourceExpressionConverter.ConvertToken(bodynameOther);
                    bodypropCount++;
                }

                if (bodynamePreferred != null)
                {
                    body["NamePreferred"] = SourceExpressionConverter.ConvertToken(bodynamePreferred);
                    bodypropCount++;
                }

                if (bodynameSharer != null)
                {
                    body["NameSharer"] = SourceExpressionConverter.ConvertToken(bodynameSharer);
                    bodypropCount++;
                }

                if (bodynameTitle != null)
                {
                    body["NameTitle"] = SourceExpressionConverter.ConvertToken(bodynameTitle);
                    bodypropCount++;
                }

                if (bodynameWeb != null)
                {
                    body["NameWeb"] = SourceExpressionConverter.ConvertToken(bodynameWeb);
                    bodypropCount++;
                }

                if (bodypinNumber != null)
                {
                    body["PinNumber"] = SourceExpressionConverter.ConvertToken(bodypinNumber);
                    bodypropCount++;
                }

                if (bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = SourceExpressionConverter.ConvertToken(bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (bodyportalEmail != null)
                {
                    body["PortalEmail"] = SourceExpressionConverter.ConvertToken(bodyportalEmail);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["Position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = SourceExpressionConverter.Convert(bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = SourceExpressionConverter.Convert(bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (bodytesting != null)
                {
                    body["Testing"] = SourceExpressionConverter.ConvertToken(bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry([WorkflowExpression] Func<string> bodynameFirst, [WorkflowExpression] Func<string> bodynameLast, [WorkflowExpression] Func<int> bodyaddressTypeId = null, [WorkflowExpression] Func<bodybirthGenderEnumInput> bodybirthGenderEnum = null, [WorkflowExpression] Func<int> bodybookingId = null, [WorkflowExpression] Func<int> bodycategoryId = null, [WorkflowExpression] Func<string> bodyconferenceEmail = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<bool> bodydirectoryFlagPrivacy = null, [WorkflowExpression] Func<string> bodydOB = null, [WorkflowExpression] Func<int> bodyentryApplicationId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<int> bodyeventId = null, [WorkflowExpression] Func<bodygenderEnumInput> bodygenderEnum = null, [WorkflowExpression] Func<string> bodyiD1 = null, [WorkflowExpression] Func<string> bodyiD2 = null, [WorkflowExpression] Func<string> bodyiD3 = null, [WorkflowExpression] Func<int> bodyiD4 = null, [WorkflowExpression] Func<int> bodyiD5 = null, [WorkflowExpression] Func<string> bodylastCheckInOutDate = null, [WorkflowExpression] Func<string> bodynameInitials = null, [WorkflowExpression] Func<string> bodynameOther = null, [WorkflowExpression] Func<string> bodynamePreferred = null, [WorkflowExpression] Func<string> bodynameSharer = null, [WorkflowExpression] Func<string> bodynameTitle = null, [WorkflowExpression] Func<string> bodynameWeb = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<int> bodypinNumber = null, [WorkflowExpression] Func<string> bodyportalAuthProviderUserId = null, [WorkflowExpression] Func<string> bodyportalEmail = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bodypreviousEntryStatusEnumInput> bodypreviousEntryStatusEnum = null, [WorkflowExpression] Func<bodytaxExemptionEnumInput> bodytaxExemptionEnum = null, [WorkflowExpression] Func<bool> bodytesting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = SourceExpressionConverter.ConvertToken(bodyaddressTypeId);
                    bodypropCount++;
                }

                if (bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = SourceExpressionConverter.Convert(bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (bodybookingId != null)
                {
                    body["BookingID"] = SourceExpressionConverter.ConvertToken(bodybookingId);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["CategoryID"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = SourceExpressionConverter.ConvertToken(bodyconferenceEmail);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = SourceExpressionConverter.ConvertToken(bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                if (bodydOB != null)
                {
                    body["DOB"] = SourceExpressionConverter.ConvertToken(bodydOB);
                    bodypropCount++;
                }

                if (bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = SourceExpressionConverter.ConvertToken(bodyentryApplicationId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["EventID"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodygenderEnum != null)
                {
                    body["GenderEnum"] = SourceExpressionConverter.Convert(bodygenderEnum);
                    bodypropCount++;
                }

                if (bodyiD1 != null)
                {
                    body["ID1"] = SourceExpressionConverter.ConvertToken(bodyiD1);
                    bodypropCount++;
                }

                if (bodyiD2 != null)
                {
                    body["ID2"] = SourceExpressionConverter.ConvertToken(bodyiD2);
                    bodypropCount++;
                }

                if (bodyiD3 != null)
                {
                    body["ID3"] = SourceExpressionConverter.ConvertToken(bodyiD3);
                    bodypropCount++;
                }

                if (bodyiD4 != null)
                {
                    body["ID4"] = SourceExpressionConverter.ConvertToken(bodyiD4);
                    bodypropCount++;
                }

                if (bodyiD5 != null)
                {
                    body["ID5"] = SourceExpressionConverter.ConvertToken(bodyiD5);
                    bodypropCount++;
                }

                if (bodylastCheckInOutDate != null)
                {
                    body["LastCheckInOutDate"] = SourceExpressionConverter.ConvertToken(bodylastCheckInOutDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["NameFirst"] = SourceExpressionConverter.ConvertToken(bodynameFirst);
                if (bodynameInitials != null)
                {
                    body["NameInitials"] = SourceExpressionConverter.ConvertToken(bodynameInitials);
                    bodypropCount++;
                }

                bodypropCount++;
                body["NameLast"] = SourceExpressionConverter.ConvertToken(bodynameLast);
                if (bodynameOther != null)
                {
                    body["NameOther"] = SourceExpressionConverter.ConvertToken(bodynameOther);
                    bodypropCount++;
                }

                if (bodynamePreferred != null)
                {
                    body["NamePreferred"] = SourceExpressionConverter.ConvertToken(bodynamePreferred);
                    bodypropCount++;
                }

                if (bodynameSharer != null)
                {
                    body["NameSharer"] = SourceExpressionConverter.ConvertToken(bodynameSharer);
                    bodypropCount++;
                }

                if (bodynameTitle != null)
                {
                    body["NameTitle"] = SourceExpressionConverter.ConvertToken(bodynameTitle);
                    bodypropCount++;
                }

                if (bodynameWeb != null)
                {
                    body["NameWeb"] = SourceExpressionConverter.ConvertToken(bodynameWeb);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["Password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypinNumber != null)
                {
                    body["PinNumber"] = SourceExpressionConverter.ConvertToken(bodypinNumber);
                    bodypropCount++;
                }

                if (bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = SourceExpressionConverter.ConvertToken(bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (bodyportalEmail != null)
                {
                    body["PortalEmail"] = SourceExpressionConverter.ConvertToken(bodyportalEmail);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["Position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = SourceExpressionConverter.Convert(bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = SourceExpressionConverter.Convert(bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (bodytesting != null)
                {
                    body["Testing"] = SourceExpressionConverter.ConvertToken(bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryResponse> UpdateEntry([WorkflowExpression] Func<int> entryId, [WorkflowExpression] Func<int> bodyaddressTypeId = null, [WorkflowExpression] Func<bodybirthGenderEnumInput> bodybirthGenderEnum = null, [WorkflowExpression] Func<int> bodybookingId = null, [WorkflowExpression] Func<int> bodycategoryId = null, [WorkflowExpression] Func<string> bodyconferenceEmail = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<bool> bodydirectoryFlagPrivacy = null, [WorkflowExpression] Func<string> bodydOB = null, [WorkflowExpression] Func<int> bodyentryApplicationId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<int> bodyeventId = null, [WorkflowExpression] Func<bodygenderEnumInput> bodygenderEnum = null, [WorkflowExpression] Func<string> bodyiD1 = null, [WorkflowExpression] Func<string> bodyiD2 = null, [WorkflowExpression] Func<string> bodyiD3 = null, [WorkflowExpression] Func<int> bodyiD4 = null, [WorkflowExpression] Func<int> bodyiD5 = null, [WorkflowExpression] Func<string> bodylastCheckInOutDate = null, [WorkflowExpression] Func<string> bodynameFirst = null, [WorkflowExpression] Func<string> bodynameInitials = null, [WorkflowExpression] Func<string> bodynameLast = null, [WorkflowExpression] Func<string> bodynameOther = null, [WorkflowExpression] Func<string> bodynamePreferred = null, [WorkflowExpression] Func<string> bodynameSharer = null, [WorkflowExpression] Func<string> bodynameTitle = null, [WorkflowExpression] Func<string> bodynameWeb = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<int> bodypinNumber = null, [WorkflowExpression] Func<string> bodyportalAuthProviderUserId = null, [WorkflowExpression] Func<string> bodyportalEmail = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bodypreviousEntryStatusEnumInput> bodypreviousEntryStatusEnum = null, [WorkflowExpression] Func<bodytaxExemptionEnumInput> bodytaxExemptionEnum = null, [WorkflowExpression] Func<bool> bodytesting = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entry.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = SourceExpressionConverter.ConvertToken(bodyaddressTypeId);
                    bodypropCount++;
                }

                if (bodybirthGenderEnum != null)
                {
                    body["Birth_GenderEnum"] = SourceExpressionConverter.Convert(bodybirthGenderEnum);
                    bodypropCount++;
                }

                if (bodybookingId != null)
                {
                    body["BookingID"] = SourceExpressionConverter.ConvertToken(bodybookingId);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["CategoryID"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodyconferenceEmail != null)
                {
                    body["ConferenceEmail"] = SourceExpressionConverter.ConvertToken(bodyconferenceEmail);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodydirectoryFlagPrivacy != null)
                {
                    body["DirectoryFlagPrivacy"] = SourceExpressionConverter.ConvertToken(bodydirectoryFlagPrivacy);
                    bodypropCount++;
                }

                if (bodydOB != null)
                {
                    body["DOB"] = SourceExpressionConverter.ConvertToken(bodydOB);
                    bodypropCount++;
                }

                if (bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = SourceExpressionConverter.ConvertToken(bodyentryApplicationId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["EventID"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodygenderEnum != null)
                {
                    body["GenderEnum"] = SourceExpressionConverter.Convert(bodygenderEnum);
                    bodypropCount++;
                }

                if (bodyiD1 != null)
                {
                    body["ID1"] = SourceExpressionConverter.ConvertToken(bodyiD1);
                    bodypropCount++;
                }

                if (bodyiD2 != null)
                {
                    body["ID2"] = SourceExpressionConverter.ConvertToken(bodyiD2);
                    bodypropCount++;
                }

                if (bodyiD3 != null)
                {
                    body["ID3"] = SourceExpressionConverter.ConvertToken(bodyiD3);
                    bodypropCount++;
                }

                if (bodyiD4 != null)
                {
                    body["ID4"] = SourceExpressionConverter.ConvertToken(bodyiD4);
                    bodypropCount++;
                }

                if (bodyiD5 != null)
                {
                    body["ID5"] = SourceExpressionConverter.ConvertToken(bodyiD5);
                    bodypropCount++;
                }

                if (bodylastCheckInOutDate != null)
                {
                    body["LastCheckInOutDate"] = SourceExpressionConverter.ConvertToken(bodylastCheckInOutDate);
                    bodypropCount++;
                }

                if (bodynameFirst != null)
                {
                    body["NameFirst"] = SourceExpressionConverter.ConvertToken(bodynameFirst);
                    bodypropCount++;
                }

                if (bodynameInitials != null)
                {
                    body["NameInitials"] = SourceExpressionConverter.ConvertToken(bodynameInitials);
                    bodypropCount++;
                }

                if (bodynameLast != null)
                {
                    body["NameLast"] = SourceExpressionConverter.ConvertToken(bodynameLast);
                    bodypropCount++;
                }

                if (bodynameOther != null)
                {
                    body["NameOther"] = SourceExpressionConverter.ConvertToken(bodynameOther);
                    bodypropCount++;
                }

                if (bodynamePreferred != null)
                {
                    body["NamePreferred"] = SourceExpressionConverter.ConvertToken(bodynamePreferred);
                    bodypropCount++;
                }

                if (bodynameSharer != null)
                {
                    body["NameSharer"] = SourceExpressionConverter.ConvertToken(bodynameSharer);
                    bodypropCount++;
                }

                if (bodynameTitle != null)
                {
                    body["NameTitle"] = SourceExpressionConverter.ConvertToken(bodynameTitle);
                    bodypropCount++;
                }

                if (bodynameWeb != null)
                {
                    body["NameWeb"] = SourceExpressionConverter.ConvertToken(bodynameWeb);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["Password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypinNumber != null)
                {
                    body["PinNumber"] = SourceExpressionConverter.ConvertToken(bodypinNumber);
                    bodypropCount++;
                }

                if (bodyportalAuthProviderUserId != null)
                {
                    body["PortalAuthProviderUserID"] = SourceExpressionConverter.ConvertToken(bodyportalAuthProviderUserId);
                    bodypropCount++;
                }

                if (bodyportalEmail != null)
                {
                    body["PortalEmail"] = SourceExpressionConverter.ConvertToken(bodyportalEmail);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["Position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypreviousEntryStatusEnum != null)
                {
                    body["Previous_EntryStatusEnum"] = SourceExpressionConverter.Convert(bodypreviousEntryStatusEnum);
                    bodypropCount++;
                }

                if (bodytaxExemptionEnum != null)
                {
                    body["TaxExemptionEnum"] = SourceExpressionConverter.Convert(bodytaxExemptionEnum);
                    bodypropCount++;
                }

                if (bodytesting != null)
                {
                    body["Testing"] = SourceExpressionConverter.ConvertToken(bodytesting);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<JToken> Delete([WorkflowExpression] Func<tableNameInput> tableName, [WorkflowExpression] Func<int> rowId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/delete/{0}.json/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryCustomFieldResponseItem[]> SelectEntryCustomField([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<int> bodycustomFieldDefinitionId = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<int> bodyentryCustomFieldId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<bodyfieldDataTypeEnumInput> bodyfieldDataTypeEnum = null, [WorkflowExpression] Func<bool> bodyvalueBoolean = null, [WorkflowExpression] Func<string> bodyvalueDatevalue = null, [WorkflowExpression] Func<bodyvalueDateOperatorInput> bodyvalueDateOperator = null, [WorkflowExpression] Func<int> bodyvalueInteger = null, [WorkflowExpression] Func<double> bodyvalueMoney = null, [WorkflowExpression] Func<string> bodyvalueString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/EntryCustomField.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodycustomFieldDefinitionId != null)
                {
                    body["CustomFieldDefinitionID"] = SourceExpressionConverter.ConvertToken(bodycustomFieldDefinitionId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodyentryCustomFieldId != null)
                {
                    body["EntryCustomFieldID"] = SourceExpressionConverter.ConvertToken(bodyentryCustomFieldId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyfieldDataTypeEnum != null)
                {
                    body["FieldDataTypeEnum"] = SourceExpressionConverter.Convert(bodyfieldDataTypeEnum);
                    bodypropCount++;
                }

                if (bodyvalueBoolean != null)
                {
                    body["ValueBoolean"] = SourceExpressionConverter.ConvertToken(bodyvalueBoolean);
                    bodypropCount++;
                }

                var valueDateObject = new JObject();
                var valueDateObjectpropCount = 0;
                if (bodyvalueDatevalue != null)
                {
                    valueDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyvalueDatevalue);
                    valueDateObjectpropCount++;
                }

                if (bodyvalueDateOperator != null)
                {
                    valueDateObject["_operator"] = SourceExpressionConverter.Convert(bodyvalueDateOperator);
                    valueDateObjectpropCount++;
                }

                if (valueDateObjectpropCount > 0)
                {
                    body["ValueDate"] = valueDateObject;
                    bodypropCount++;
                }

                if (bodyvalueInteger != null)
                {
                    body["ValueInteger"] = SourceExpressionConverter.ConvertToken(bodyvalueInteger);
                    bodypropCount++;
                }

                if (bodyvalueMoney != null)
                {
                    body["ValueMoney"] = SourceExpressionConverter.ConvertToken(bodyvalueMoney);
                    bodypropCount++;
                }

                if (bodyvalueString != null)
                {
                    body["ValueString"] = SourceExpressionConverter.ConvertToken(bodyvalueString);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryCustomFieldResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryCustomFieldResponse> UpdateEntryCustomField([WorkflowExpression] Func<int> entryCustomFieldId, [WorkflowExpression] Func<int> bodycustomFieldDefinitionId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<bodyfieldDataTypeEnumInput> bodyfieldDataTypeEnum = null, [WorkflowExpression] Func<bool> bodyvalueBoolean = null, [WorkflowExpression] Func<string> bodyvalueDate = null, [WorkflowExpression] Func<int> bodyvalueInteger = null, [WorkflowExpression] Func<double> bodyvalueMoney = null, [WorkflowExpression] Func<string> bodyvalueString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entryCustomField.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryCustomFieldId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomFieldDefinitionId != null)
                {
                    body["CustomFieldDefinitionID"] = SourceExpressionConverter.ConvertToken(bodycustomFieldDefinitionId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyfieldDataTypeEnum != null)
                {
                    body["FieldDataTypeEnum"] = SourceExpressionConverter.Convert(bodyfieldDataTypeEnum);
                    bodypropCount++;
                }

                if (bodyvalueBoolean != null)
                {
                    body["ValueBoolean"] = SourceExpressionConverter.ConvertToken(bodyvalueBoolean);
                    bodypropCount++;
                }

                if (bodyvalueDate != null)
                {
                    body["ValueDate"] = SourceExpressionConverter.ConvertToken(bodyvalueDate);
                    bodypropCount++;
                }

                if (bodyvalueInteger != null)
                {
                    body["ValueInteger"] = SourceExpressionConverter.ConvertToken(bodyvalueInteger);
                    bodypropCount++;
                }

                if (bodyvalueMoney != null)
                {
                    body["ValueMoney"] = SourceExpressionConverter.ConvertToken(bodyvalueMoney);
                    bodypropCount++;
                }

                if (bodyvalueString != null)
                {
                    body["ValueString"] = SourceExpressionConverter.ConvertToken(bodyvalueString);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryCustomFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermResponseItem[]> SelectTerm([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodyactiveDateClosevalue = null, [WorkflowExpression] Func<bodyactiveDateCloseOperatorInput> bodyactiveDateCloseOperator = null, [WorkflowExpression] Func<string> bodyactiveDateOpenvalue = null, [WorkflowExpression] Func<bodyactiveDateOpenOperatorInput> bodyactiveDateOpenOperator = null, [WorkflowExpression] Func<int> bodycategoryId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyrecordTypeEnumInput> bodyrecordTypeEnum = null, [WorkflowExpression] Func<string> bodytermCode = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<int> bodytermTypeId = null, [WorkflowExpression] Func<string> bodywebDescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/Term.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["Active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                var activeDateCloseObject = new JObject();
                var activeDateCloseObjectpropCount = 0;
                if (bodyactiveDateClosevalue != null)
                {
                    activeDateCloseObject["Value"] = SourceExpressionConverter.ConvertToken(bodyactiveDateClosevalue);
                    activeDateCloseObjectpropCount++;
                }

                if (bodyactiveDateCloseOperator != null)
                {
                    activeDateCloseObject["_operator"] = SourceExpressionConverter.Convert(bodyactiveDateCloseOperator);
                    activeDateCloseObjectpropCount++;
                }

                if (activeDateCloseObjectpropCount > 0)
                {
                    body["ActiveDateClose"] = activeDateCloseObject;
                    bodypropCount++;
                }

                var activeDateOpenObject = new JObject();
                var activeDateOpenObjectpropCount = 0;
                if (bodyactiveDateOpenvalue != null)
                {
                    activeDateOpenObject["Value"] = SourceExpressionConverter.ConvertToken(bodyactiveDateOpenvalue);
                    activeDateOpenObjectpropCount++;
                }

                if (bodyactiveDateOpenOperator != null)
                {
                    activeDateOpenObject["_operator"] = SourceExpressionConverter.Convert(bodyactiveDateOpenOperator);
                    activeDateOpenObjectpropCount++;
                }

                if (activeDateOpenObjectpropCount > 0)
                {
                    body["ActiveDateOpen"] = activeDateOpenObject;
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["CategoryID"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = SourceExpressionConverter.Convert(bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (bodytermCode != null)
                {
                    body["TermCode"] = SourceExpressionConverter.ConvertToken(bodytermCode);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodytermTypeId != null)
                {
                    body["TermTypeID"] = SourceExpressionConverter.ConvertToken(bodytermTypeId);
                    bodypropCount++;
                }

                if (bodywebDescription != null)
                {
                    body["WebDescription"] = SourceExpressionConverter.ConvertToken(bodywebDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectTermResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryAddressResponseItem[]> SelectEntryAddress([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<string> bodyactiveDateEndvalue = null, [WorkflowExpression] Func<bodyactiveDateEndOperatorInput> bodyactiveDateEndOperator = null, [WorkflowExpression] Func<string> bodyactiveDateStartvalue = null, [WorkflowExpression] Func<bodyactiveDateStartOperatorInput> bodyactiveDateStartOperator = null, [WorkflowExpression] Func<int> bodyaddressTypeId = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactName2 = null, [WorkflowExpression] Func<int> bodycountryId = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyentryAddressId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyphoneMobileCell = null, [WorkflowExpression] Func<string> bodyphoneOther = null, [WorkflowExpression] Func<string> bodyphoneOther2 = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodyrelationship = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodystreet2 = null, [WorkflowExpression] Func<string> bodyzipPostcode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/EntryAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                var activeDateEndObject = new JObject();
                var activeDateEndObjectpropCount = 0;
                if (bodyactiveDateEndvalue != null)
                {
                    activeDateEndObject["Value"] = SourceExpressionConverter.ConvertToken(bodyactiveDateEndvalue);
                    activeDateEndObjectpropCount++;
                }

                if (bodyactiveDateEndOperator != null)
                {
                    activeDateEndObject["_operator"] = SourceExpressionConverter.Convert(bodyactiveDateEndOperator);
                    activeDateEndObjectpropCount++;
                }

                if (activeDateEndObjectpropCount > 0)
                {
                    body["ActiveDateEnd"] = activeDateEndObject;
                    bodypropCount++;
                }

                var activeDateStartObject = new JObject();
                var activeDateStartObjectpropCount = 0;
                if (bodyactiveDateStartvalue != null)
                {
                    activeDateStartObject["Value"] = SourceExpressionConverter.ConvertToken(bodyactiveDateStartvalue);
                    activeDateStartObjectpropCount++;
                }

                if (bodyactiveDateStartOperator != null)
                {
                    activeDateStartObject["_operator"] = SourceExpressionConverter.Convert(bodyactiveDateStartOperator);
                    activeDateStartObjectpropCount++;
                }

                if (activeDateStartObjectpropCount > 0)
                {
                    body["ActiveDateStart"] = activeDateStartObject;
                    bodypropCount++;
                }

                if (bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = SourceExpressionConverter.ConvertToken(bodyaddressTypeId);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactName2 != null)
                {
                    body["ContactName2"] = SourceExpressionConverter.ConvertToken(bodycontactName2);
                    bodypropCount++;
                }

                if (bodycountryId != null)
                {
                    body["CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyentryAddressId != null)
                {
                    body["EntryAddressID"] = SourceExpressionConverter.ConvertToken(bodyentryAddressId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["Phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyphoneMobileCell != null)
                {
                    body["PhoneMobileCell"] = SourceExpressionConverter.ConvertToken(bodyphoneMobileCell);
                    bodypropCount++;
                }

                if (bodyphoneOther != null)
                {
                    body["PhoneOther"] = SourceExpressionConverter.ConvertToken(bodyphoneOther);
                    bodypropCount++;
                }

                if (bodyphoneOther2 != null)
                {
                    body["PhoneOther2"] = SourceExpressionConverter.ConvertToken(bodyphoneOther2);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["Reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyrelationship != null)
                {
                    body["Relationship"] = SourceExpressionConverter.ConvertToken(bodyrelationship);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["Salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["StateProvince"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
                    bodypropCount++;
                }

                if (bodystreet != null)
                {
                    body["Street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodystreet2 != null)
                {
                    body["Street2"] = SourceExpressionConverter.ConvertToken(bodystreet2);
                    bodypropCount++;
                }

                if (bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = SourceExpressionConverter.ConvertToken(bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryAddressResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryAddressResponse> UpdateEntryAddress([WorkflowExpression] Func<int> entryAddressId, [WorkflowExpression] Func<string> bodyactiveDateEnd = null, [WorkflowExpression] Func<string> bodyactiveDateStart = null, [WorkflowExpression] Func<int> bodyaddressTypeId = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactName2 = null, [WorkflowExpression] Func<int> bodycountryId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyphoneMobileCell = null, [WorkflowExpression] Func<string> bodyphoneOther = null, [WorkflowExpression] Func<string> bodyphoneOther2 = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodyrelationship = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodystreet2 = null, [WorkflowExpression] Func<string> bodyzipPostcode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entryAddress.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryAddressId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyactiveDateEnd != null)
                {
                    body["ActiveDateEnd"] = SourceExpressionConverter.ConvertToken(bodyactiveDateEnd);
                    bodypropCount++;
                }

                if (bodyactiveDateStart != null)
                {
                    body["ActiveDateStart"] = SourceExpressionConverter.ConvertToken(bodyactiveDateStart);
                    bodypropCount++;
                }

                if (bodyaddressTypeId != null)
                {
                    body["AddressTypeID"] = SourceExpressionConverter.ConvertToken(bodyaddressTypeId);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactName2 != null)
                {
                    body["ContactName2"] = SourceExpressionConverter.ConvertToken(bodycontactName2);
                    bodypropCount++;
                }

                if (bodycountryId != null)
                {
                    body["CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["Phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyphoneMobileCell != null)
                {
                    body["PhoneMobileCell"] = SourceExpressionConverter.ConvertToken(bodyphoneMobileCell);
                    bodypropCount++;
                }

                if (bodyphoneOther != null)
                {
                    body["PhoneOther"] = SourceExpressionConverter.ConvertToken(bodyphoneOther);
                    bodypropCount++;
                }

                if (bodyphoneOther2 != null)
                {
                    body["PhoneOther2"] = SourceExpressionConverter.ConvertToken(bodyphoneOther2);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["Reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyrelationship != null)
                {
                    body["Relationship"] = SourceExpressionConverter.ConvertToken(bodyrelationship);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["Salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["StateProvince"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
                    bodypropCount++;
                }

                if (bodystreet != null)
                {
                    body["Street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodystreet2 != null)
                {
                    body["Street2"] = SourceExpressionConverter.ConvertToken(bodystreet2);
                    bodypropCount++;
                }

                if (bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = SourceExpressionConverter.ConvertToken(bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryApplicationResponseItem[]> SelectEntryApplication([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<bodyallocateOptionEnumInput> bodyallocateOptionEnum = null, [WorkflowExpression] Func<string> bodyapplicationDatevalue = null, [WorkflowExpression] Func<bodyapplicationDateOperatorInput> bodyapplicationDateOperator = null, [WorkflowExpression] Func<int> bodyapplicationStatusId = null, [WorkflowExpression] Func<string> bodycancelDatevalue = null, [WorkflowExpression] Func<bodycancelDateOperatorInput> bodycancelDateOperator = null, [WorkflowExpression] Func<int> bodyclassificationId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycommentsInternal = null, [WorkflowExpression] Func<string> bodycompleteDatevalue = null, [WorkflowExpression] Func<bodycompleteDateOperatorInput> bodycompleteDateOperator = null, [WorkflowExpression] Func<string> bodycontractSignedDatevalue = null, [WorkflowExpression] Func<bodycontractSignedDateOperatorInput> bodycontractSignedDateOperator = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomDate3value = null, [WorkflowExpression] Func<bodycustomDate3OperatorInput> bodycustomDate3Operator = null, [WorkflowExpression] Func<string> bodycustomDate4value = null, [WorkflowExpression] Func<bodycustomDate4OperatorInput> bodycustomDate4Operator = null, [WorkflowExpression] Func<string> bodydateCreatedvalue = null, [WorkflowExpression] Func<bodydateCreatedOperatorInput> bodydateCreatedOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodyenquiryDatevalue = null, [WorkflowExpression] Func<bodyenquiryDateOperatorInput> bodyenquiryDateOperator = null, [WorkflowExpression] Func<int> bodyentryApplicationId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDatevalue = null, [WorkflowExpression] Func<bodyexpectedArrivalDateOperatorInput> bodyexpectedArrivalDateOperator = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDateLatestvalue = null, [WorkflowExpression] Func<bodyexpectedArrivalDateLatestOperatorInput> bodyexpectedArrivalDateLatestOperator = null, [WorkflowExpression] Func<string> bodyexpectedDepartureDatevalue = null, [WorkflowExpression] Func<bodyexpectedDepartureDateOperatorInput> bodyexpectedDepartureDateOperator = null, [WorkflowExpression] Func<string> bodyofferedDatevalue = null, [WorkflowExpression] Func<bodyofferedDateOperatorInput> bodyofferedDateOperator = null, [WorkflowExpression] Func<string> bodyofferReplyDatevalue = null, [WorkflowExpression] Func<bodyofferReplyDateOperatorInput> bodyofferReplyDateOperator = null, [WorkflowExpression] Func<bodyofferReplyEnumInput> bodyofferReplyEnum = null, [WorkflowExpression] Func<string> bodyofferReplyReason = null, [WorkflowExpression] Func<string> bodyofferSentDatevalue = null, [WorkflowExpression] Func<bodyofferSentDateOperatorInput> bodyofferSentDateOperator = null, [WorkflowExpression] Func<bool> bodyportalTrackingOnly = null, [WorkflowExpression] Func<string> bodypreferenceComments = null, [WorkflowExpression] Func<string> bodyrating = null, [WorkflowExpression] Func<string> bodyreceivedDatevalue = null, [WorkflowExpression] Func<bodyreceivedDateOperatorInput> bodyreceivedDateOperator = null, [WorkflowExpression] Func<bool> bodyreceivedDeposit = null, [WorkflowExpression] Func<bool> bodyreceivedDepositWaived = null, [WorkflowExpression] Func<int> bodyreceivedDepositPaymentId = null, [WorkflowExpression] Func<int> bodyreceivedDepositWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedDepositAmount = null, [WorkflowExpression] Func<string> bodyreceivedDepositDatevalue = null, [WorkflowExpression] Func<bodyreceivedDepositDateOperatorInput> bodyreceivedDepositDateOperator = null, [WorkflowExpression] Func<bool> bodyreceivedFee = null, [WorkflowExpression] Func<int> bodyreceivedFeePaymentId = null, [WorkflowExpression] Func<int> bodyreceivedFeeWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedFeeAmount = null, [WorkflowExpression] Func<string> bodyreceivedFeeDatevalue = null, [WorkflowExpression] Func<bodyreceivedFeeDateOperatorInput> bodyreceivedFeeDateOperator = null, [WorkflowExpression] Func<string> bodyreceivedPhotoDatevalue = null, [WorkflowExpression] Func<bodyreceivedPhotoDateOperatorInput> bodyreceivedPhotoDateOperator = null, [WorkflowExpression] Func<bool> bodyreturning = null, [WorkflowExpression] Func<string> bodyroomMateDescription = null, [WorkflowExpression] Func<int> bodyroommateGroupId = null, [WorkflowExpression] Func<int> bodyroomMateGroupSortOrder = null, [WorkflowExpression] Func<bool> bodyroomMateShowInSearch = null, [WorkflowExpression] Func<string> bodyroomPreferenceComments = null, [WorkflowExpression] Func<int> bodyroomSelectionNumber = null, [WorkflowExpression] Func<string> bodyroomSelectionTimeslot = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<bool> bodyweb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/EntryApplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = SourceExpressionConverter.Convert(bodyallocateOptionEnum);
                    bodypropCount++;
                }

                var applicationDateObject = new JObject();
                var applicationDateObjectpropCount = 0;
                if (bodyapplicationDatevalue != null)
                {
                    applicationDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyapplicationDatevalue);
                    applicationDateObjectpropCount++;
                }

                if (bodyapplicationDateOperator != null)
                {
                    applicationDateObject["_operator"] = SourceExpressionConverter.Convert(bodyapplicationDateOperator);
                    applicationDateObjectpropCount++;
                }

                if (applicationDateObjectpropCount > 0)
                {
                    body["ApplicationDate"] = applicationDateObject;
                    bodypropCount++;
                }

                if (bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = SourceExpressionConverter.ConvertToken(bodyapplicationStatusId);
                    bodypropCount++;
                }

                var cancelDateObject = new JObject();
                var cancelDateObjectpropCount = 0;
                if (bodycancelDatevalue != null)
                {
                    cancelDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycancelDatevalue);
                    cancelDateObjectpropCount++;
                }

                if (bodycancelDateOperator != null)
                {
                    cancelDateObject["_operator"] = SourceExpressionConverter.Convert(bodycancelDateOperator);
                    cancelDateObjectpropCount++;
                }

                if (cancelDateObjectpropCount > 0)
                {
                    body["CancelDate"] = cancelDateObject;
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["ClassificationID"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = SourceExpressionConverter.ConvertToken(bodycommentsInternal);
                    bodypropCount++;
                }

                var completeDateObject = new JObject();
                var completeDateObjectpropCount = 0;
                if (bodycompleteDatevalue != null)
                {
                    completeDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycompleteDatevalue);
                    completeDateObjectpropCount++;
                }

                if (bodycompleteDateOperator != null)
                {
                    completeDateObject["_operator"] = SourceExpressionConverter.Convert(bodycompleteDateOperator);
                    completeDateObjectpropCount++;
                }

                if (completeDateObjectpropCount > 0)
                {
                    body["CompleteDate"] = completeDateObject;
                    bodypropCount++;
                }

                var contractSignedDateObject = new JObject();
                var contractSignedDateObjectpropCount = 0;
                if (bodycontractSignedDatevalue != null)
                {
                    contractSignedDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractSignedDatevalue);
                    contractSignedDateObjectpropCount++;
                }

                if (bodycontractSignedDateOperator != null)
                {
                    contractSignedDateObject["_operator"] = SourceExpressionConverter.Convert(bodycontractSignedDateOperator);
                    contractSignedDateObjectpropCount++;
                }

                if (contractSignedDateObjectpropCount > 0)
                {
                    body["ContractSignedDate"] = contractSignedDateObject;
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                var customDate3Object = new JObject();
                var customDate3ObjectpropCount = 0;
                if (bodycustomDate3value != null)
                {
                    customDate3Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate3value);
                    customDate3ObjectpropCount++;
                }

                if (bodycustomDate3Operator != null)
                {
                    customDate3Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate3Operator);
                    customDate3ObjectpropCount++;
                }

                if (customDate3ObjectpropCount > 0)
                {
                    body["CustomDate3"] = customDate3Object;
                    bodypropCount++;
                }

                var customDate4Object = new JObject();
                var customDate4ObjectpropCount = 0;
                if (bodycustomDate4value != null)
                {
                    customDate4Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate4value);
                    customDate4ObjectpropCount++;
                }

                if (bodycustomDate4Operator != null)
                {
                    customDate4Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate4Operator);
                    customDate4ObjectpropCount++;
                }

                if (customDate4ObjectpropCount > 0)
                {
                    body["CustomDate4"] = customDate4Object;
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = SourceExpressionConverter.Convert(bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var enquiryDateObject = new JObject();
                var enquiryDateObjectpropCount = 0;
                if (bodyenquiryDatevalue != null)
                {
                    enquiryDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyenquiryDatevalue);
                    enquiryDateObjectpropCount++;
                }

                if (bodyenquiryDateOperator != null)
                {
                    enquiryDateObject["_operator"] = SourceExpressionConverter.Convert(bodyenquiryDateOperator);
                    enquiryDateObjectpropCount++;
                }

                if (enquiryDateObjectpropCount > 0)
                {
                    body["EnquiryDate"] = enquiryDateObject;
                    bodypropCount++;
                }

                if (bodyentryApplicationId != null)
                {
                    body["EntryApplicationID"] = SourceExpressionConverter.ConvertToken(bodyentryApplicationId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                var expectedArrivalDateObject = new JObject();
                var expectedArrivalDateObjectpropCount = 0;
                if (bodyexpectedArrivalDatevalue != null)
                {
                    expectedArrivalDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDatevalue);
                    expectedArrivalDateObjectpropCount++;
                }

                if (bodyexpectedArrivalDateOperator != null)
                {
                    expectedArrivalDateObject["_operator"] = SourceExpressionConverter.Convert(bodyexpectedArrivalDateOperator);
                    expectedArrivalDateObjectpropCount++;
                }

                if (expectedArrivalDateObjectpropCount > 0)
                {
                    body["ExpectedArrivalDate"] = expectedArrivalDateObject;
                    bodypropCount++;
                }

                var expectedArrivalDateLatestObject = new JObject();
                var expectedArrivalDateLatestObjectpropCount = 0;
                if (bodyexpectedArrivalDateLatestvalue != null)
                {
                    expectedArrivalDateLatestObject["Value"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDateLatestvalue);
                    expectedArrivalDateLatestObjectpropCount++;
                }

                if (bodyexpectedArrivalDateLatestOperator != null)
                {
                    expectedArrivalDateLatestObject["_operator"] = SourceExpressionConverter.Convert(bodyexpectedArrivalDateLatestOperator);
                    expectedArrivalDateLatestObjectpropCount++;
                }

                if (expectedArrivalDateLatestObjectpropCount > 0)
                {
                    body["ExpectedArrivalDateLatest"] = expectedArrivalDateLatestObject;
                    bodypropCount++;
                }

                var expectedDepartureDateObject = new JObject();
                var expectedDepartureDateObjectpropCount = 0;
                if (bodyexpectedDepartureDatevalue != null)
                {
                    expectedDepartureDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyexpectedDepartureDatevalue);
                    expectedDepartureDateObjectpropCount++;
                }

                if (bodyexpectedDepartureDateOperator != null)
                {
                    expectedDepartureDateObject["_operator"] = SourceExpressionConverter.Convert(bodyexpectedDepartureDateOperator);
                    expectedDepartureDateObjectpropCount++;
                }

                if (expectedDepartureDateObjectpropCount > 0)
                {
                    body["ExpectedDepartureDate"] = expectedDepartureDateObject;
                    bodypropCount++;
                }

                var offeredDateObject = new JObject();
                var offeredDateObjectpropCount = 0;
                if (bodyofferedDatevalue != null)
                {
                    offeredDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyofferedDatevalue);
                    offeredDateObjectpropCount++;
                }

                if (bodyofferedDateOperator != null)
                {
                    offeredDateObject["_operator"] = SourceExpressionConverter.Convert(bodyofferedDateOperator);
                    offeredDateObjectpropCount++;
                }

                if (offeredDateObjectpropCount > 0)
                {
                    body["OfferedDate"] = offeredDateObject;
                    bodypropCount++;
                }

                var offerReplyDateObject = new JObject();
                var offerReplyDateObjectpropCount = 0;
                if (bodyofferReplyDatevalue != null)
                {
                    offerReplyDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyofferReplyDatevalue);
                    offerReplyDateObjectpropCount++;
                }

                if (bodyofferReplyDateOperator != null)
                {
                    offerReplyDateObject["_operator"] = SourceExpressionConverter.Convert(bodyofferReplyDateOperator);
                    offerReplyDateObjectpropCount++;
                }

                if (offerReplyDateObjectpropCount > 0)
                {
                    body["OfferReplyDate"] = offerReplyDateObject;
                    bodypropCount++;
                }

                if (bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = SourceExpressionConverter.Convert(bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = SourceExpressionConverter.ConvertToken(bodyofferReplyReason);
                    bodypropCount++;
                }

                var offerSentDateObject = new JObject();
                var offerSentDateObjectpropCount = 0;
                if (bodyofferSentDatevalue != null)
                {
                    offerSentDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyofferSentDatevalue);
                    offerSentDateObjectpropCount++;
                }

                if (bodyofferSentDateOperator != null)
                {
                    offerSentDateObject["_operator"] = SourceExpressionConverter.Convert(bodyofferSentDateOperator);
                    offerSentDateObjectpropCount++;
                }

                if (offerSentDateObjectpropCount > 0)
                {
                    body["OfferSentDate"] = offerSentDateObject;
                    bodypropCount++;
                }

                if (bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = SourceExpressionConverter.ConvertToken(bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = SourceExpressionConverter.ConvertToken(bodypreferenceComments);
                    bodypropCount++;
                }

                if (bodyrating != null)
                {
                    body["Rating"] = SourceExpressionConverter.ConvertToken(bodyrating);
                    bodypropCount++;
                }

                var receivedDateObject = new JObject();
                var receivedDateObjectpropCount = 0;
                if (bodyreceivedDatevalue != null)
                {
                    receivedDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyreceivedDatevalue);
                    receivedDateObjectpropCount++;
                }

                if (bodyreceivedDateOperator != null)
                {
                    receivedDateObject["_operator"] = SourceExpressionConverter.Convert(bodyreceivedDateOperator);
                    receivedDateObjectpropCount++;
                }

                if (receivedDateObjectpropCount > 0)
                {
                    body["ReceivedDate"] = receivedDateObject;
                    bodypropCount++;
                }

                if (bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = SourceExpressionConverter.ConvertToken(bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                var receivedDepositDateObject = new JObject();
                var receivedDepositDateObjectpropCount = 0;
                if (bodyreceivedDepositDatevalue != null)
                {
                    receivedDepositDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositDatevalue);
                    receivedDepositDateObjectpropCount++;
                }

                if (bodyreceivedDepositDateOperator != null)
                {
                    receivedDepositDateObject["_operator"] = SourceExpressionConverter.Convert(bodyreceivedDepositDateOperator);
                    receivedDepositDateObjectpropCount++;
                }

                if (receivedDepositDateObjectpropCount > 0)
                {
                    body["ReceivedDepositDate"] = receivedDepositDateObject;
                    bodypropCount++;
                }

                if (bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = SourceExpressionConverter.ConvertToken(bodyreceivedFee);
                    bodypropCount++;
                }

                if (bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                var receivedFeeDateObject = new JObject();
                var receivedFeeDateObjectpropCount = 0;
                if (bodyreceivedFeeDatevalue != null)
                {
                    receivedFeeDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeDatevalue);
                    receivedFeeDateObjectpropCount++;
                }

                if (bodyreceivedFeeDateOperator != null)
                {
                    receivedFeeDateObject["_operator"] = SourceExpressionConverter.Convert(bodyreceivedFeeDateOperator);
                    receivedFeeDateObjectpropCount++;
                }

                if (receivedFeeDateObjectpropCount > 0)
                {
                    body["ReceivedFeeDate"] = receivedFeeDateObject;
                    bodypropCount++;
                }

                var receivedPhotoDateObject = new JObject();
                var receivedPhotoDateObjectpropCount = 0;
                if (bodyreceivedPhotoDatevalue != null)
                {
                    receivedPhotoDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyreceivedPhotoDatevalue);
                    receivedPhotoDateObjectpropCount++;
                }

                if (bodyreceivedPhotoDateOperator != null)
                {
                    receivedPhotoDateObject["_operator"] = SourceExpressionConverter.Convert(bodyreceivedPhotoDateOperator);
                    receivedPhotoDateObjectpropCount++;
                }

                if (receivedPhotoDateObjectpropCount > 0)
                {
                    body["ReceivedPhotoDate"] = receivedPhotoDateObject;
                    bodypropCount++;
                }

                if (bodyreturning != null)
                {
                    body["Returning"] = SourceExpressionConverter.ConvertToken(bodyreturning);
                    bodypropCount++;
                }

                if (bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = SourceExpressionConverter.ConvertToken(bodyroomMateDescription);
                    bodypropCount++;
                }

                if (bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = SourceExpressionConverter.ConvertToken(bodyroommateGroupId);
                    bodypropCount++;
                }

                if (bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = SourceExpressionConverter.ConvertToken(bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = SourceExpressionConverter.ConvertToken(bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = SourceExpressionConverter.ConvertToken(bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyweb != null)
                {
                    body["Web"] = SourceExpressionConverter.ConvertToken(bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryApplicationResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryApplicationResponse> CreateEntryApplication([WorkflowExpression] Func<int> bodyentryId, [WorkflowExpression] Func<bodyallocateOptionEnumInput> bodyallocateOptionEnum = null, [WorkflowExpression] Func<string> bodyapplicationDate = null, [WorkflowExpression] Func<int> bodyapplicationStatusId = null, [WorkflowExpression] Func<string> bodycancelDate = null, [WorkflowExpression] Func<int> bodyclassificationId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycommentsInternal = null, [WorkflowExpression] Func<string> bodycompleteDate = null, [WorkflowExpression] Func<string> bodycontractSignedDate = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomDate3 = null, [WorkflowExpression] Func<string> bodycustomDate4 = null, [WorkflowExpression] Func<string> bodyenquiryDate = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDate = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDateLatest = null, [WorkflowExpression] Func<string> bodyexpectedDepartureDate = null, [WorkflowExpression] Func<string> bodyofferedDate = null, [WorkflowExpression] Func<string> bodyofferReplyDate = null, [WorkflowExpression] Func<bodyofferReplyEnumInput> bodyofferReplyEnum = null, [WorkflowExpression] Func<string> bodyofferReplyReason = null, [WorkflowExpression] Func<string> bodyofferSentDate = null, [WorkflowExpression] Func<bool> bodyportalTrackingOnly = null, [WorkflowExpression] Func<string> bodypreferenceComments = null, [WorkflowExpression] Func<string> bodyrating = null, [WorkflowExpression] Func<string> bodyreceivedDate = null, [WorkflowExpression] Func<bool> bodyreceivedDeposit = null, [WorkflowExpression] Func<int> bodyreceivedDepositPaymentId = null, [WorkflowExpression] Func<int> bodyreceivedDepositWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedDepositAmount = null, [WorkflowExpression] Func<string> bodyreceivedDepositDate = null, [WorkflowExpression] Func<bool> bodyreceivedDepositWaived = null, [WorkflowExpression] Func<bool> bodyreceivedFee = null, [WorkflowExpression] Func<int> bodyreceivedFeePaymentId = null, [WorkflowExpression] Func<int> bodyreceivedFeeWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedFeeAmount = null, [WorkflowExpression] Func<string> bodyreceivedFeeDate = null, [WorkflowExpression] Func<string> bodyreceivedPhotoDate = null, [WorkflowExpression] Func<bool> bodyreturning = null, [WorkflowExpression] Func<string> bodyroomMateDescription = null, [WorkflowExpression] Func<int> bodyroommateGroupId = null, [WorkflowExpression] Func<int> bodyroomMateGroupSortOrder = null, [WorkflowExpression] Func<bool> bodyroomMateShowInSearch = null, [WorkflowExpression] Func<string> bodyroomPreferenceComments = null, [WorkflowExpression] Func<int> bodyroomSelectionNumber = null, [WorkflowExpression] Func<string> bodyroomSelectionTimeslot = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<bool> bodyweb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/entryapplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = SourceExpressionConverter.Convert(bodyallocateOptionEnum);
                    bodypropCount++;
                }

                if (bodyapplicationDate != null)
                {
                    body["ApplicationDate"] = SourceExpressionConverter.ConvertToken(bodyapplicationDate);
                    bodypropCount++;
                }

                if (bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = SourceExpressionConverter.ConvertToken(bodyapplicationStatusId);
                    bodypropCount++;
                }

                if (bodycancelDate != null)
                {
                    body["CancelDate"] = SourceExpressionConverter.ConvertToken(bodycancelDate);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["ClassificationID"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = SourceExpressionConverter.ConvertToken(bodycommentsInternal);
                    bodypropCount++;
                }

                if (bodycompleteDate != null)
                {
                    body["CompleteDate"] = SourceExpressionConverter.ConvertToken(bodycompleteDate);
                    bodypropCount++;
                }

                if (bodycontractSignedDate != null)
                {
                    body["ContractSignedDate"] = SourceExpressionConverter.ConvertToken(bodycontractSignedDate);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomDate3 != null)
                {
                    body["CustomDate3"] = SourceExpressionConverter.ConvertToken(bodycustomDate3);
                    bodypropCount++;
                }

                if (bodycustomDate4 != null)
                {
                    body["CustomDate4"] = SourceExpressionConverter.ConvertToken(bodycustomDate4);
                    bodypropCount++;
                }

                if (bodyenquiryDate != null)
                {
                    body["EnquiryDate"] = SourceExpressionConverter.ConvertToken(bodyenquiryDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                if (bodyexpectedArrivalDate != null)
                {
                    body["ExpectedArrivalDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDate);
                    bodypropCount++;
                }

                if (bodyexpectedArrivalDateLatest != null)
                {
                    body["ExpectedArrivalDateLatest"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDateLatest);
                    bodypropCount++;
                }

                if (bodyexpectedDepartureDate != null)
                {
                    body["ExpectedDepartureDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedDepartureDate);
                    bodypropCount++;
                }

                if (bodyofferedDate != null)
                {
                    body["OfferedDate"] = SourceExpressionConverter.ConvertToken(bodyofferedDate);
                    bodypropCount++;
                }

                if (bodyofferReplyDate != null)
                {
                    body["OfferReplyDate"] = SourceExpressionConverter.ConvertToken(bodyofferReplyDate);
                    bodypropCount++;
                }

                if (bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = SourceExpressionConverter.Convert(bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = SourceExpressionConverter.ConvertToken(bodyofferReplyReason);
                    bodypropCount++;
                }

                if (bodyofferSentDate != null)
                {
                    body["OfferSentDate"] = SourceExpressionConverter.ConvertToken(bodyofferSentDate);
                    bodypropCount++;
                }

                if (bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = SourceExpressionConverter.ConvertToken(bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = SourceExpressionConverter.ConvertToken(bodypreferenceComments);
                    bodypropCount++;
                }

                if (bodyrating != null)
                {
                    body["Rating"] = SourceExpressionConverter.ConvertToken(bodyrating);
                    bodypropCount++;
                }

                if (bodyreceivedDate != null)
                {
                    body["ReceivedDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedDate);
                    bodypropCount++;
                }

                if (bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = SourceExpressionConverter.ConvertToken(bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                if (bodyreceivedDepositDate != null)
                {
                    body["ReceivedDepositDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositDate);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = SourceExpressionConverter.ConvertToken(bodyreceivedFee);
                    bodypropCount++;
                }

                if (bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                if (bodyreceivedFeeDate != null)
                {
                    body["ReceivedFeeDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeDate);
                    bodypropCount++;
                }

                if (bodyreceivedPhotoDate != null)
                {
                    body["ReceivedPhotoDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedPhotoDate);
                    bodypropCount++;
                }

                if (bodyreturning != null)
                {
                    body["Returning"] = SourceExpressionConverter.ConvertToken(bodyreturning);
                    bodypropCount++;
                }

                if (bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = SourceExpressionConverter.ConvertToken(bodyroomMateDescription);
                    bodypropCount++;
                }

                if (bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = SourceExpressionConverter.ConvertToken(bodyroommateGroupId);
                    bodypropCount++;
                }

                if (bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = SourceExpressionConverter.ConvertToken(bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = SourceExpressionConverter.ConvertToken(bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = SourceExpressionConverter.ConvertToken(bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyweb != null)
                {
                    body["Web"] = SourceExpressionConverter.ConvertToken(bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEntryApplicationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryApplicationResponse> UpdateEntryApplication([WorkflowExpression] Func<int> entryApplicationId, [WorkflowExpression] Func<bodyallocateOptionEnumInput> bodyallocateOptionEnum = null, [WorkflowExpression] Func<string> bodyapplicationDate = null, [WorkflowExpression] Func<int> bodyapplicationStatusId = null, [WorkflowExpression] Func<string> bodycancelDate = null, [WorkflowExpression] Func<int> bodyclassificationId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycommentsInternal = null, [WorkflowExpression] Func<string> bodycompleteDate = null, [WorkflowExpression] Func<string> bodycontractSignedDate = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomDate3 = null, [WorkflowExpression] Func<string> bodycustomDate4 = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyenquiryDate = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDate = null, [WorkflowExpression] Func<string> bodyexpectedArrivalDateLatest = null, [WorkflowExpression] Func<string> bodyexpectedDepartureDate = null, [WorkflowExpression] Func<string> bodyofferedDate = null, [WorkflowExpression] Func<string> bodyofferReplyDate = null, [WorkflowExpression] Func<bodyofferReplyEnumInput> bodyofferReplyEnum = null, [WorkflowExpression] Func<string> bodyofferReplyReason = null, [WorkflowExpression] Func<string> bodyofferSentDate = null, [WorkflowExpression] Func<bool> bodyportalTrackingOnly = null, [WorkflowExpression] Func<string> bodypreferenceComments = null, [WorkflowExpression] Func<string> bodyrating = null, [WorkflowExpression] Func<string> bodyreceivedDate = null, [WorkflowExpression] Func<bool> bodyreceivedDeposit = null, [WorkflowExpression] Func<int> bodyreceivedDepositPaymentId = null, [WorkflowExpression] Func<int> bodyreceivedDepositWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedDepositAmount = null, [WorkflowExpression] Func<string> bodyreceivedDepositDate = null, [WorkflowExpression] Func<bool> bodyreceivedDepositWaived = null, [WorkflowExpression] Func<bool> bodyreceivedFee = null, [WorkflowExpression] Func<int> bodyreceivedFeePaymentId = null, [WorkflowExpression] Func<int> bodyreceivedFeeWebPaymentId = null, [WorkflowExpression] Func<double> bodyreceivedFeeAmount = null, [WorkflowExpression] Func<string> bodyreceivedFeeDate = null, [WorkflowExpression] Func<string> bodyreceivedPhotoDate = null, [WorkflowExpression] Func<bool> bodyreturning = null, [WorkflowExpression] Func<string> bodyroomMateDescription = null, [WorkflowExpression] Func<int> bodyroommateGroupId = null, [WorkflowExpression] Func<int> bodyroomMateGroupSortOrder = null, [WorkflowExpression] Func<bool> bodyroomMateShowInSearch = null, [WorkflowExpression] Func<string> bodyroomPreferenceComments = null, [WorkflowExpression] Func<int> bodyroomSelectionNumber = null, [WorkflowExpression] Func<string> bodyroomSelectionTimeslot = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<bool> bodyweb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entryapplication.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryApplicationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyallocateOptionEnum != null)
                {
                    body["AllocateOptionEnum"] = SourceExpressionConverter.Convert(bodyallocateOptionEnum);
                    bodypropCount++;
                }

                if (bodyapplicationDate != null)
                {
                    body["ApplicationDate"] = SourceExpressionConverter.ConvertToken(bodyapplicationDate);
                    bodypropCount++;
                }

                if (bodyapplicationStatusId != null)
                {
                    body["ApplicationStatusID"] = SourceExpressionConverter.ConvertToken(bodyapplicationStatusId);
                    bodypropCount++;
                }

                if (bodycancelDate != null)
                {
                    body["CancelDate"] = SourceExpressionConverter.ConvertToken(bodycancelDate);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["ClassificationID"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycommentsInternal != null)
                {
                    body["CommentsInternal"] = SourceExpressionConverter.ConvertToken(bodycommentsInternal);
                    bodypropCount++;
                }

                if (bodycompleteDate != null)
                {
                    body["CompleteDate"] = SourceExpressionConverter.ConvertToken(bodycompleteDate);
                    bodypropCount++;
                }

                if (bodycontractSignedDate != null)
                {
                    body["ContractSignedDate"] = SourceExpressionConverter.ConvertToken(bodycontractSignedDate);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomDate3 != null)
                {
                    body["CustomDate3"] = SourceExpressionConverter.ConvertToken(bodycustomDate3);
                    bodypropCount++;
                }

                if (bodycustomDate4 != null)
                {
                    body["CustomDate4"] = SourceExpressionConverter.ConvertToken(bodycustomDate4);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyenquiryDate != null)
                {
                    body["EnquiryDate"] = SourceExpressionConverter.ConvertToken(bodyenquiryDate);
                    bodypropCount++;
                }

                if (bodyexpectedArrivalDate != null)
                {
                    body["ExpectedArrivalDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDate);
                    bodypropCount++;
                }

                if (bodyexpectedArrivalDateLatest != null)
                {
                    body["ExpectedArrivalDateLatest"] = SourceExpressionConverter.ConvertToken(bodyexpectedArrivalDateLatest);
                    bodypropCount++;
                }

                if (bodyexpectedDepartureDate != null)
                {
                    body["ExpectedDepartureDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedDepartureDate);
                    bodypropCount++;
                }

                if (bodyofferedDate != null)
                {
                    body["OfferedDate"] = SourceExpressionConverter.ConvertToken(bodyofferedDate);
                    bodypropCount++;
                }

                if (bodyofferReplyDate != null)
                {
                    body["OfferReplyDate"] = SourceExpressionConverter.ConvertToken(bodyofferReplyDate);
                    bodypropCount++;
                }

                if (bodyofferReplyEnum != null)
                {
                    body["OfferReplyEnum"] = SourceExpressionConverter.Convert(bodyofferReplyEnum);
                    bodypropCount++;
                }

                if (bodyofferReplyReason != null)
                {
                    body["OfferReplyReason"] = SourceExpressionConverter.ConvertToken(bodyofferReplyReason);
                    bodypropCount++;
                }

                if (bodyofferSentDate != null)
                {
                    body["OfferSentDate"] = SourceExpressionConverter.ConvertToken(bodyofferSentDate);
                    bodypropCount++;
                }

                if (bodyportalTrackingOnly != null)
                {
                    body["PortalTrackingOnly"] = SourceExpressionConverter.ConvertToken(bodyportalTrackingOnly);
                    bodypropCount++;
                }

                if (bodypreferenceComments != null)
                {
                    body["PreferenceComments"] = SourceExpressionConverter.ConvertToken(bodypreferenceComments);
                    bodypropCount++;
                }

                if (bodyrating != null)
                {
                    body["Rating"] = SourceExpressionConverter.ConvertToken(bodyrating);
                    bodypropCount++;
                }

                if (bodyreceivedDate != null)
                {
                    body["ReceivedDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedDate);
                    bodypropCount++;
                }

                if (bodyreceivedDeposit != null)
                {
                    body["ReceivedDeposit"] = SourceExpressionConverter.ConvertToken(bodyreceivedDeposit);
                    bodypropCount++;
                }

                if (bodyreceivedDepositPaymentId != null)
                {
                    body["ReceivedDeposit_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWebPaymentId != null)
                {
                    body["ReceivedDeposit_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedDepositAmount != null)
                {
                    body["ReceivedDepositAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositAmount);
                    bodypropCount++;
                }

                if (bodyreceivedDepositDate != null)
                {
                    body["ReceivedDepositDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositDate);
                    bodypropCount++;
                }

                if (bodyreceivedDepositWaived != null)
                {
                    body["ReceivedDepositWaived"] = SourceExpressionConverter.ConvertToken(bodyreceivedDepositWaived);
                    bodypropCount++;
                }

                if (bodyreceivedFee != null)
                {
                    body["ReceivedFee"] = SourceExpressionConverter.ConvertToken(bodyreceivedFee);
                    bodypropCount++;
                }

                if (bodyreceivedFeePaymentId != null)
                {
                    body["ReceivedFee_PaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeePaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeWebPaymentId != null)
                {
                    body["ReceivedFee_WebPaymentID"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeWebPaymentId);
                    bodypropCount++;
                }

                if (bodyreceivedFeeAmount != null)
                {
                    body["ReceivedFeeAmount"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeAmount);
                    bodypropCount++;
                }

                if (bodyreceivedFeeDate != null)
                {
                    body["ReceivedFeeDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedFeeDate);
                    bodypropCount++;
                }

                if (bodyreceivedPhotoDate != null)
                {
                    body["ReceivedPhotoDate"] = SourceExpressionConverter.ConvertToken(bodyreceivedPhotoDate);
                    bodypropCount++;
                }

                if (bodyreturning != null)
                {
                    body["Returning"] = SourceExpressionConverter.ConvertToken(bodyreturning);
                    bodypropCount++;
                }

                if (bodyroomMateDescription != null)
                {
                    body["RoomMateDescription"] = SourceExpressionConverter.ConvertToken(bodyroomMateDescription);
                    bodypropCount++;
                }

                if (bodyroommateGroupId != null)
                {
                    body["RoommateGroupID"] = SourceExpressionConverter.ConvertToken(bodyroommateGroupId);
                    bodypropCount++;
                }

                if (bodyroomMateGroupSortOrder != null)
                {
                    body["RoomMateGroupSortOrder"] = SourceExpressionConverter.ConvertToken(bodyroomMateGroupSortOrder);
                    bodypropCount++;
                }

                if (bodyroomMateShowInSearch != null)
                {
                    body["RoomMateShowInSearch"] = SourceExpressionConverter.ConvertToken(bodyroomMateShowInSearch);
                    bodypropCount++;
                }

                if (bodyroomPreferenceComments != null)
                {
                    body["RoomPreferenceComments"] = SourceExpressionConverter.ConvertToken(bodyroomPreferenceComments);
                    bodypropCount++;
                }

                if (bodyroomSelectionNumber != null)
                {
                    body["RoomSelectionNumber"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionNumber);
                    bodypropCount++;
                }

                if (bodyroomSelectionTimeslot != null)
                {
                    body["RoomSelectionTimeslot"] = SourceExpressionConverter.ConvertToken(bodyroomSelectionTimeslot);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyweb != null)
                {
                    body["Web"] = SourceExpressionConverter.ConvertToken(bodyweb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryApplicationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermSessionResponseItem[]> SelectTermSession([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<int> bodybookingTypeId = null, [WorkflowExpression] Func<int> bodycancelBookingDefaultEndBookingReasonId = null, [WorkflowExpression] Func<bodycancelBookingUpdateEndBookingReasonBooleanAskEnumInput> bodycancelBookingUpdateEndBookingReasonBooleanAskEnum = null, [WorkflowExpression] Func<string> bodycheckInDatevalue = null, [WorkflowExpression] Func<bodycheckInDateOperatorInput> bodycheckInDateOperator = null, [WorkflowExpression] Func<bodycheckInDateActualDecreaseBooleanAskEnumInput> bodycheckInDateActualDecreaseBooleanAskEnum = null, [WorkflowExpression] Func<bodycheckInDateActualIncreaseBooleanAskEnumInput> bodycheckInDateActualIncreaseBooleanAskEnum = null, [WorkflowExpression] Func<int> bodycheckInDefaultStartBookingReasonId = null, [WorkflowExpression] Func<bodycheckInUpdateStartBookingReasonBooleanAskEnumInput> bodycheckInUpdateStartBookingReasonBooleanAskEnum = null, [WorkflowExpression] Func<string> bodycheckOutDatevalue = null, [WorkflowExpression] Func<bodycheckOutDateOperatorInput> bodycheckOutDateOperator = null, [WorkflowExpression] Func<bodycheckOutDateActualDecreaseBooleanAskEnumInput> bodycheckOutDateActualDecreaseBooleanAskEnum = null, [WorkflowExpression] Func<bodycheckOutDateActualIncreaseBooleanAskEnumInput> bodycheckOutDateActualIncreaseBooleanAskEnum = null, [WorkflowExpression] Func<int> bodycheckOutDefaultEndBookingReasonId = null, [WorkflowExpression] Func<bodycheckOutUpdateEndBookingReasonBooleanAskEnumInput> bodycheckOutUpdateEndBookingReasonBooleanAskEnum = null, [WorkflowExpression] Func<bodycontractDateCheckInDecreaseBooleanAskEnumInput> bodycontractDateCheckInDecreaseBooleanAskEnum = null, [WorkflowExpression] Func<bodycontractDateCheckInIncreaseBooleanAskEnumInput> bodycontractDateCheckInIncreaseBooleanAskEnum = null, [WorkflowExpression] Func<bodycontractDateCheckOutDecreaseBooleanAskEnumInput> bodycontractDateCheckOutDecreaseBooleanAskEnum = null, [WorkflowExpression] Func<bodycontractDateCheckOutIncreaseBooleanAskEnumInput> bodycontractDateCheckOutIncreaseBooleanAskEnum = null, [WorkflowExpression] Func<string> bodycontractDateEndvalue = null, [WorkflowExpression] Func<bodycontractDateEndOperatorInput> bodycontractDateEndOperator = null, [WorkflowExpression] Func<string> bodycontractDateStartvalue = null, [WorkflowExpression] Func<bodycontractDateStartOperatorInput> bodycontractDateStartOperator = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyendBookingReasonId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<string> bodyeTA = null, [WorkflowExpression] Func<string> bodyeTD = null, [WorkflowExpression] Func<int> bodyhousekeepingId = null, [WorkflowExpression] Func<bodyrecordTypeEnumInput> bodyrecordTypeEnum = null, [WorkflowExpression] Func<bool> bodyroomLocationFixed = null, [WorkflowExpression] Func<int> bodyroomLocationId = null, [WorkflowExpression] Func<double> bodyroomRateAmount = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<int> bodyroomTypeId = null, [WorkflowExpression] Func<int> bodystartBookingReasonId = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<string> bodytermSessionCode = null, [WorkflowExpression] Func<int> bodytermSessionId = null, [WorkflowExpression] Func<bool> bodyuseActiveBookingAsTemplate = null, [WorkflowExpression] Func<string> bodywebDescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/TermSession.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = SourceExpressionConverter.ConvertToken(bodybookingTypeId);
                    bodypropCount++;
                }

                if (bodycancelBookingDefaultEndBookingReasonId != null)
                {
                    body["CancelBookingDefaultEnd_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodycancelBookingDefaultEndBookingReasonId);
                    bodypropCount++;
                }

                if (bodycancelBookingUpdateEndBookingReasonBooleanAskEnum != null)
                {
                    body["CancelBookingUpdateEndBookingReason_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycancelBookingUpdateEndBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                var checkInDateObject = new JObject();
                var checkInDateObjectpropCount = 0;
                if (bodycheckInDatevalue != null)
                {
                    checkInDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckInDatevalue);
                    checkInDateObjectpropCount++;
                }

                if (bodycheckInDateOperator != null)
                {
                    checkInDateObject["_operator"] = SourceExpressionConverter.Convert(bodycheckInDateOperator);
                    checkInDateObjectpropCount++;
                }

                if (checkInDateObjectpropCount > 0)
                {
                    body["CheckInDate"] = checkInDateObject;
                    bodypropCount++;
                }

                if (bodycheckInDateActualDecreaseBooleanAskEnum != null)
                {
                    body["CheckInDateActualDecrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckInDateActualDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycheckInDateActualIncreaseBooleanAskEnum != null)
                {
                    body["CheckInDateActualIncrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckInDateActualIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycheckInDefaultStartBookingReasonId != null)
                {
                    body["CheckInDefaultStart_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodycheckInDefaultStartBookingReasonId);
                    bodypropCount++;
                }

                if (bodycheckInUpdateStartBookingReasonBooleanAskEnum != null)
                {
                    body["CheckInUpdateStartBookingReason_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckInUpdateStartBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                var checkOutDateObject = new JObject();
                var checkOutDateObjectpropCount = 0;
                if (bodycheckOutDatevalue != null)
                {
                    checkOutDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckOutDatevalue);
                    checkOutDateObjectpropCount++;
                }

                if (bodycheckOutDateOperator != null)
                {
                    checkOutDateObject["_operator"] = SourceExpressionConverter.Convert(bodycheckOutDateOperator);
                    checkOutDateObjectpropCount++;
                }

                if (checkOutDateObjectpropCount > 0)
                {
                    body["CheckOutDate"] = checkOutDateObject;
                    bodypropCount++;
                }

                if (bodycheckOutDateActualDecreaseBooleanAskEnum != null)
                {
                    body["CheckOutDateActualDecrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckOutDateActualDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycheckOutDateActualIncreaseBooleanAskEnum != null)
                {
                    body["CheckOutDateActualIncrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckOutDateActualIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycheckOutDefaultEndBookingReasonId != null)
                {
                    body["CheckOutDefaultEnd_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodycheckOutDefaultEndBookingReasonId);
                    bodypropCount++;
                }

                if (bodycheckOutUpdateEndBookingReasonBooleanAskEnum != null)
                {
                    body["CheckOutUpdateEndBookingReason_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycheckOutUpdateEndBookingReasonBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycontractDateCheckInDecreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckInDecrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycontractDateCheckInDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycontractDateCheckInIncreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckInIncrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycontractDateCheckInIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycontractDateCheckOutDecreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckOutDecrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycontractDateCheckOutDecreaseBooleanAskEnum);
                    bodypropCount++;
                }

                if (bodycontractDateCheckOutIncreaseBooleanAskEnum != null)
                {
                    body["ContractDateCheckOutIncrease_BooleanAskEnum"] = SourceExpressionConverter.Convert(bodycontractDateCheckOutIncreaseBooleanAskEnum);
                    bodypropCount++;
                }

                var contractDateEndObject = new JObject();
                var contractDateEndObjectpropCount = 0;
                if (bodycontractDateEndvalue != null)
                {
                    contractDateEndObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractDateEndvalue);
                    contractDateEndObjectpropCount++;
                }

                if (bodycontractDateEndOperator != null)
                {
                    contractDateEndObject["_operator"] = SourceExpressionConverter.Convert(bodycontractDateEndOperator);
                    contractDateEndObjectpropCount++;
                }

                if (contractDateEndObjectpropCount > 0)
                {
                    body["ContractDateEnd"] = contractDateEndObject;
                    bodypropCount++;
                }

                var contractDateStartObject = new JObject();
                var contractDateStartObjectpropCount = 0;
                if (bodycontractDateStartvalue != null)
                {
                    contractDateStartObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractDateStartvalue);
                    contractDateStartObjectpropCount++;
                }

                if (bodycontractDateStartOperator != null)
                {
                    contractDateStartObject["_operator"] = SourceExpressionConverter.Convert(bodycontractDateStartOperator);
                    contractDateStartObjectpropCount++;
                }

                if (contractDateStartObjectpropCount > 0)
                {
                    body["ContractDateStart"] = contractDateStartObject;
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeTA != null)
                {
                    body["ETA"] = SourceExpressionConverter.ConvertToken(bodyeTA);
                    bodypropCount++;
                }

                if (bodyeTD != null)
                {
                    body["ETD"] = SourceExpressionConverter.ConvertToken(bodyeTD);
                    bodypropCount++;
                }

                if (bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = SourceExpressionConverter.ConvertToken(bodyhousekeepingId);
                    bodypropCount++;
                }

                if (bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = SourceExpressionConverter.Convert(bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = SourceExpressionConverter.ConvertToken(bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationId);
                    bodypropCount++;
                }

                if (bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = SourceExpressionConverter.ConvertToken(bodyroomRateAmount);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = SourceExpressionConverter.ConvertToken(bodyroomTypeId);
                    bodypropCount++;
                }

                if (bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodytermSessionCode != null)
                {
                    body["TermSessionCode"] = SourceExpressionConverter.ConvertToken(bodytermSessionCode);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                if (bodyuseActiveBookingAsTemplate != null)
                {
                    body["UseActiveBookingAsTemplate"] = SourceExpressionConverter.ConvertToken(bodyuseActiveBookingAsTemplate);
                    bodypropCount++;
                }

                if (bodywebDescription != null)
                {
                    body["WebDescription"] = SourceExpressionConverter.ConvertToken(bodywebDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectTermSessionResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryDetailResponseItem[]> SelectEntryDetail([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<bool> bodyacademicHold = null, [WorkflowExpression] Func<int> bodyaccountPaymentTypeId = null, [WorkflowExpression] Func<bool> bodyaccountHold = null, [WorkflowExpression] Func<string> bodyaccountBankName = null, [WorkflowExpression] Func<string> bodyaccountBankNumber = null, [WorkflowExpression] Func<string> bodyaccountCode = null, [WorkflowExpression] Func<string> bodyaccountComments = null, [WorkflowExpression] Func<string> bodyaccountDetail1 = null, [WorkflowExpression] Func<string> bodyaccountDetail2 = null, [WorkflowExpression] Func<string> bodyaccountDetail3 = null, [WorkflowExpression] Func<string> bodyaccountDetail4 = null, [WorkflowExpression] Func<string> bodyaccountDueDatevalue = null, [WorkflowExpression] Func<bodyaccountDueDateOperatorInput> bodyaccountDueDateOperator = null, [WorkflowExpression] Func<bool> bodyathlete = null, [WorkflowExpression] Func<string> bodyathleteTeam = null, [WorkflowExpression] Func<bodyattendeeStatusEnumInput> bodyattendeeStatusEnum = null, [WorkflowExpression] Func<string> bodycareer = null, [WorkflowExpression] Func<string> bodycareerComments = null, [WorkflowExpression] Func<int> bodycitizenshipCountryId = null, [WorkflowExpression] Func<int> bodyclassificationId = null, [WorkflowExpression] Func<bool> bodyclassificationOverride = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycountryOfBirthCountryId = null, [WorkflowExpression] Func<int> bodycountryOfResidenceCountryId = null, [WorkflowExpression] Func<double> bodycumulativeGPA = null, [WorkflowExpression] Func<double> bodycumulativeHours = null, [WorkflowExpression] Func<double> bodycurrentGPA = null, [WorkflowExpression] Func<double> bodycurrentHours = null, [WorkflowExpression] Func<string> bodycurrentMajor = null, [WorkflowExpression] Func<string> bodycurrentMinor = null, [WorkflowExpression] Func<string> bodydateEntryvalue = null, [WorkflowExpression] Func<bodydateEntryOperatorInput> bodydateEntryOperator = null, [WorkflowExpression] Func<string> bodydateExitvalue = null, [WorkflowExpression] Func<bodydateExitOperatorInput> bodydateExitOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<string> bodydeceasedDatevalue = null, [WorkflowExpression] Func<bodydeceasedDateOperatorInput> bodydeceasedDateOperator = null, [WorkflowExpression] Func<string> bodydietary = null, [WorkflowExpression] Func<string> bodydisability = null, [WorkflowExpression] Func<string> bodyemploymentDetails = null, [WorkflowExpression] Func<string> bodyenrollmentClass = null, [WorkflowExpression] Func<string> bodyenrollmentLevel = null, [WorkflowExpression] Func<string> bodyenrollmentStatus = null, [WorkflowExpression] Func<string> bodyenrollmentTerm = null, [WorkflowExpression] Func<int> bodyenrollmentYear = null, [WorkflowExpression] Func<int> bodyentryDetailId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<int> bodyeventRegistrationFeeId = null, [WorkflowExpression] Func<string> bodyexpectedGraduationDatevalue = null, [WorkflowExpression] Func<bodyexpectedGraduationDateOperatorInput> bodyexpectedGraduationDateOperator = null, [WorkflowExpression] Func<string> bodyfinancialComments = null, [WorkflowExpression] Func<int> bodyfinancialSupportId = null, [WorkflowExpression] Func<string> bodyhearAboutUs = null, [WorkflowExpression] Func<bool> bodyhonorsIndicator = null, [WorkflowExpression] Func<bool> bodyimmunizationsHold = null, [WorkflowExpression] Func<bool> bodyincidentHold = null, [WorkflowExpression] Func<string> bodyincidentHoldComments = null, [WorkflowExpression] Func<bool> bodyinternational = null, [WorkflowExpression] Func<string> bodyinternationalDetails = null, [WorkflowExpression] Func<bool> bodylivingWithDependents = null, [WorkflowExpression] Func<bool> bodymarried = null, [WorkflowExpression] Func<string> bodymedical = null, [WorkflowExpression] Func<int> bodynationalityId = null, [WorkflowExpression] Func<string> bodyoccupation = null, [WorkflowExpression] Func<string> bodyphotoPath = null, [WorkflowExpression] Func<string> bodypreviousMemberName = null, [WorkflowExpression] Func<string> bodypreviousMemberRelationship = null, [WorkflowExpression] Func<string> bodypreviousMembership = null, [WorkflowExpression] Func<string> bodypreviousMembershipYears = null, [WorkflowExpression] Func<string> bodypreviousMemberYears = null, [WorkflowExpression] Func<string> bodyprofileInterests = null, [WorkflowExpression] Func<int> bodyregionOfBirthId = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<string> bodyresidency = null, [WorkflowExpression] Func<string> bodyresidentStatus = null, [WorkflowExpression] Func<int> bodyresidentYear = null, [WorkflowExpression] Func<string> bodysituationResponseComments = null, [WorkflowExpression] Func<string> bodysituationResponseDetail = null, [WorkflowExpression] Func<bodysituationResponseEnumInput> bodysituationResponseEnum = null, [WorkflowExpression] Func<string> bodysituationResponseExpiryDatevalue = null, [WorkflowExpression] Func<bodysituationResponseExpiryDateOperatorInput> bodysituationResponseExpiryDateOperator = null, [WorkflowExpression] Func<string> bodysituationResponseModifiedDatevalue = null, [WorkflowExpression] Func<bodysituationResponseModifiedDateOperatorInput> bodysituationResponseModifiedDateOperator = null, [WorkflowExpression] Func<string> bodysituationResponseSituation = null, [WorkflowExpression] Func<string> bodyspecialNeeds = null, [WorkflowExpression] Func<int> bodystaffId = null, [WorkflowExpression] Func<bool> bodyusesScreenReader = null, [WorkflowExpression] Func<string> bodyvehicleDetails = null, [WorkflowExpression] Func<string> bodyvehiclePermit = null, [WorkflowExpression] Func<string> bodyvehicleRegistration = null, [WorkflowExpression] Func<string> bodyveteranStatus = null, [WorkflowExpression] Func<bool> bodyvisa = null, [WorkflowExpression] Func<string> bodyvisaDetails = null, [WorkflowExpression] Func<bool> bodyvisitorHold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/EntryDetail.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyacademicHold != null)
                {
                    body["AcademicHold"] = SourceExpressionConverter.ConvertToken(bodyacademicHold);
                    bodypropCount++;
                }

                if (bodyaccountPaymentTypeId != null)
                {
                    body["Account_PaymentTypeID"] = SourceExpressionConverter.ConvertToken(bodyaccountPaymentTypeId);
                    bodypropCount++;
                }

                if (bodyaccountHold != null)
                {
                    body["AccountHold"] = SourceExpressionConverter.ConvertToken(bodyaccountHold);
                    bodypropCount++;
                }

                if (bodyaccountBankName != null)
                {
                    body["AccountBankName"] = SourceExpressionConverter.ConvertToken(bodyaccountBankName);
                    bodypropCount++;
                }

                if (bodyaccountBankNumber != null)
                {
                    body["AccountBankNumber"] = SourceExpressionConverter.ConvertToken(bodyaccountBankNumber);
                    bodypropCount++;
                }

                if (bodyaccountCode != null)
                {
                    body["AccountCode"] = SourceExpressionConverter.ConvertToken(bodyaccountCode);
                    bodypropCount++;
                }

                if (bodyaccountComments != null)
                {
                    body["AccountComments"] = SourceExpressionConverter.ConvertToken(bodyaccountComments);
                    bodypropCount++;
                }

                if (bodyaccountDetail1 != null)
                {
                    body["AccountDetail1"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail1);
                    bodypropCount++;
                }

                if (bodyaccountDetail2 != null)
                {
                    body["AccountDetail2"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail2);
                    bodypropCount++;
                }

                if (bodyaccountDetail3 != null)
                {
                    body["AccountDetail3"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail3);
                    bodypropCount++;
                }

                if (bodyaccountDetail4 != null)
                {
                    body["AccountDetail4"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail4);
                    bodypropCount++;
                }

                var accountDueDateObject = new JObject();
                var accountDueDateObjectpropCount = 0;
                if (bodyaccountDueDatevalue != null)
                {
                    accountDueDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyaccountDueDatevalue);
                    accountDueDateObjectpropCount++;
                }

                if (bodyaccountDueDateOperator != null)
                {
                    accountDueDateObject["_operator"] = SourceExpressionConverter.Convert(bodyaccountDueDateOperator);
                    accountDueDateObjectpropCount++;
                }

                if (accountDueDateObjectpropCount > 0)
                {
                    body["AccountDueDate"] = accountDueDateObject;
                    bodypropCount++;
                }

                if (bodyathlete != null)
                {
                    body["Athlete"] = SourceExpressionConverter.ConvertToken(bodyathlete);
                    bodypropCount++;
                }

                if (bodyathleteTeam != null)
                {
                    body["AthleteTeam"] = SourceExpressionConverter.ConvertToken(bodyathleteTeam);
                    bodypropCount++;
                }

                if (bodyattendeeStatusEnum != null)
                {
                    body["AttendeeStatusEnum"] = SourceExpressionConverter.Convert(bodyattendeeStatusEnum);
                    bodypropCount++;
                }

                if (bodycareer != null)
                {
                    body["Career"] = SourceExpressionConverter.ConvertToken(bodycareer);
                    bodypropCount++;
                }

                if (bodycareerComments != null)
                {
                    body["CareerComments"] = SourceExpressionConverter.ConvertToken(bodycareerComments);
                    bodypropCount++;
                }

                if (bodycitizenshipCountryId != null)
                {
                    body["Citizenship_CountryID"] = SourceExpressionConverter.ConvertToken(bodycitizenshipCountryId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["ClassificationID"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
                    bodypropCount++;
                }

                if (bodyclassificationOverride != null)
                {
                    body["ClassificationOverride"] = SourceExpressionConverter.ConvertToken(bodyclassificationOverride);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycountryOfBirthCountryId != null)
                {
                    body["CountryOfBirth_CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryOfBirthCountryId);
                    bodypropCount++;
                }

                if (bodycountryOfResidenceCountryId != null)
                {
                    body["CountryOfResidence_CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryOfResidenceCountryId);
                    bodypropCount++;
                }

                if (bodycumulativeGPA != null)
                {
                    body["CumulativeGPA"] = SourceExpressionConverter.ConvertToken(bodycumulativeGPA);
                    bodypropCount++;
                }

                if (bodycumulativeHours != null)
                {
                    body["CumulativeHours"] = SourceExpressionConverter.ConvertToken(bodycumulativeHours);
                    bodypropCount++;
                }

                if (bodycurrentGPA != null)
                {
                    body["CurrentGPA"] = SourceExpressionConverter.ConvertToken(bodycurrentGPA);
                    bodypropCount++;
                }

                if (bodycurrentHours != null)
                {
                    body["CurrentHours"] = SourceExpressionConverter.ConvertToken(bodycurrentHours);
                    bodypropCount++;
                }

                if (bodycurrentMajor != null)
                {
                    body["CurrentMajor"] = SourceExpressionConverter.ConvertToken(bodycurrentMajor);
                    bodypropCount++;
                }

                if (bodycurrentMinor != null)
                {
                    body["CurrentMinor"] = SourceExpressionConverter.ConvertToken(bodycurrentMinor);
                    bodypropCount++;
                }

                var dateEntryObject = new JObject();
                var dateEntryObjectpropCount = 0;
                if (bodydateEntryvalue != null)
                {
                    dateEntryObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateEntryvalue);
                    dateEntryObjectpropCount++;
                }

                if (bodydateEntryOperator != null)
                {
                    dateEntryObject["_operator"] = SourceExpressionConverter.Convert(bodydateEntryOperator);
                    dateEntryObjectpropCount++;
                }

                if (dateEntryObjectpropCount > 0)
                {
                    body["DateEntry"] = dateEntryObject;
                    bodypropCount++;
                }

                var dateExitObject = new JObject();
                var dateExitObjectpropCount = 0;
                if (bodydateExitvalue != null)
                {
                    dateExitObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateExitvalue);
                    dateExitObjectpropCount++;
                }

                if (bodydateExitOperator != null)
                {
                    dateExitObject["_operator"] = SourceExpressionConverter.Convert(bodydateExitOperator);
                    dateExitObjectpropCount++;
                }

                if (dateExitObjectpropCount > 0)
                {
                    body["DateExit"] = dateExitObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydeceased != null)
                {
                    body["Deceased"] = SourceExpressionConverter.ConvertToken(bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (bodydeceasedDatevalue != null)
                {
                    deceasedDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodydeceasedDatevalue);
                    deceasedDateObjectpropCount++;
                }

                if (bodydeceasedDateOperator != null)
                {
                    deceasedDateObject["_operator"] = SourceExpressionConverter.Convert(bodydeceasedDateOperator);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["DeceasedDate"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (bodydietary != null)
                {
                    body["Dietary"] = SourceExpressionConverter.ConvertToken(bodydietary);
                    bodypropCount++;
                }

                if (bodydisability != null)
                {
                    body["Disability"] = SourceExpressionConverter.ConvertToken(bodydisability);
                    bodypropCount++;
                }

                if (bodyemploymentDetails != null)
                {
                    body["EmploymentDetails"] = SourceExpressionConverter.ConvertToken(bodyemploymentDetails);
                    bodypropCount++;
                }

                if (bodyenrollmentClass != null)
                {
                    body["EnrollmentClass"] = SourceExpressionConverter.ConvertToken(bodyenrollmentClass);
                    bodypropCount++;
                }

                if (bodyenrollmentLevel != null)
                {
                    body["EnrollmentLevel"] = SourceExpressionConverter.ConvertToken(bodyenrollmentLevel);
                    bodypropCount++;
                }

                if (bodyenrollmentStatus != null)
                {
                    body["EnrollmentStatus"] = SourceExpressionConverter.ConvertToken(bodyenrollmentStatus);
                    bodypropCount++;
                }

                if (bodyenrollmentTerm != null)
                {
                    body["EnrollmentTerm"] = SourceExpressionConverter.ConvertToken(bodyenrollmentTerm);
                    bodypropCount++;
                }

                if (bodyenrollmentYear != null)
                {
                    body["EnrollmentYear"] = SourceExpressionConverter.ConvertToken(bodyenrollmentYear);
                    bodypropCount++;
                }

                if (bodyentryDetailId != null)
                {
                    body["EntryDetailID"] = SourceExpressionConverter.ConvertToken(bodyentryDetailId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["Ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodyeventRegistrationFeeId != null)
                {
                    body["EventRegistrationFeeID"] = SourceExpressionConverter.ConvertToken(bodyeventRegistrationFeeId);
                    bodypropCount++;
                }

                var expectedGraduationDateObject = new JObject();
                var expectedGraduationDateObjectpropCount = 0;
                if (bodyexpectedGraduationDatevalue != null)
                {
                    expectedGraduationDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyexpectedGraduationDatevalue);
                    expectedGraduationDateObjectpropCount++;
                }

                if (bodyexpectedGraduationDateOperator != null)
                {
                    expectedGraduationDateObject["_operator"] = SourceExpressionConverter.Convert(bodyexpectedGraduationDateOperator);
                    expectedGraduationDateObjectpropCount++;
                }

                if (expectedGraduationDateObjectpropCount > 0)
                {
                    body["ExpectedGraduationDate"] = expectedGraduationDateObject;
                    bodypropCount++;
                }

                if (bodyfinancialComments != null)
                {
                    body["FinancialComments"] = SourceExpressionConverter.ConvertToken(bodyfinancialComments);
                    bodypropCount++;
                }

                if (bodyfinancialSupportId != null)
                {
                    body["FinancialSupportID"] = SourceExpressionConverter.ConvertToken(bodyfinancialSupportId);
                    bodypropCount++;
                }

                if (bodyhearAboutUs != null)
                {
                    body["HearAboutUs"] = SourceExpressionConverter.ConvertToken(bodyhearAboutUs);
                    bodypropCount++;
                }

                if (bodyhonorsIndicator != null)
                {
                    body["HonorsIndicator"] = SourceExpressionConverter.ConvertToken(bodyhonorsIndicator);
                    bodypropCount++;
                }

                if (bodyimmunizationsHold != null)
                {
                    body["ImmunizationsHold"] = SourceExpressionConverter.ConvertToken(bodyimmunizationsHold);
                    bodypropCount++;
                }

                if (bodyincidentHold != null)
                {
                    body["IncidentHold"] = SourceExpressionConverter.ConvertToken(bodyincidentHold);
                    bodypropCount++;
                }

                if (bodyincidentHoldComments != null)
                {
                    body["IncidentHoldComments"] = SourceExpressionConverter.ConvertToken(bodyincidentHoldComments);
                    bodypropCount++;
                }

                if (bodyinternational != null)
                {
                    body["International"] = SourceExpressionConverter.ConvertToken(bodyinternational);
                    bodypropCount++;
                }

                if (bodyinternationalDetails != null)
                {
                    body["InternationalDetails"] = SourceExpressionConverter.ConvertToken(bodyinternationalDetails);
                    bodypropCount++;
                }

                if (bodylivingWithDependents != null)
                {
                    body["LivingWithDependents"] = SourceExpressionConverter.ConvertToken(bodylivingWithDependents);
                    bodypropCount++;
                }

                if (bodymarried != null)
                {
                    body["Married"] = SourceExpressionConverter.ConvertToken(bodymarried);
                    bodypropCount++;
                }

                if (bodymedical != null)
                {
                    body["Medical"] = SourceExpressionConverter.ConvertToken(bodymedical);
                    bodypropCount++;
                }

                if (bodynationalityId != null)
                {
                    body["NationalityID"] = SourceExpressionConverter.ConvertToken(bodynationalityId);
                    bodypropCount++;
                }

                if (bodyoccupation != null)
                {
                    body["Occupation"] = SourceExpressionConverter.ConvertToken(bodyoccupation);
                    bodypropCount++;
                }

                if (bodyphotoPath != null)
                {
                    body["PhotoPath"] = SourceExpressionConverter.ConvertToken(bodyphotoPath);
                    bodypropCount++;
                }

                if (bodypreviousMemberName != null)
                {
                    body["PreviousMemberName"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberName);
                    bodypropCount++;
                }

                if (bodypreviousMemberRelationship != null)
                {
                    body["PreviousMemberRelationship"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberRelationship);
                    bodypropCount++;
                }

                if (bodypreviousMembership != null)
                {
                    body["PreviousMembership"] = SourceExpressionConverter.ConvertToken(bodypreviousMembership);
                    bodypropCount++;
                }

                if (bodypreviousMembershipYears != null)
                {
                    body["PreviousMembershipYears"] = SourceExpressionConverter.ConvertToken(bodypreviousMembershipYears);
                    bodypropCount++;
                }

                if (bodypreviousMemberYears != null)
                {
                    body["PreviousMemberYears"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberYears);
                    bodypropCount++;
                }

                if (bodyprofileInterests != null)
                {
                    body["ProfileInterests"] = SourceExpressionConverter.ConvertToken(bodyprofileInterests);
                    bodypropCount++;
                }

                if (bodyregionOfBirthId != null)
                {
                    body["RegionOfBirthID"] = SourceExpressionConverter.ConvertToken(bodyregionOfBirthId);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["Religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                if (bodyresidency != null)
                {
                    body["Residency"] = SourceExpressionConverter.ConvertToken(bodyresidency);
                    bodypropCount++;
                }

                if (bodyresidentStatus != null)
                {
                    body["ResidentStatus"] = SourceExpressionConverter.ConvertToken(bodyresidentStatus);
                    bodypropCount++;
                }

                if (bodyresidentYear != null)
                {
                    body["ResidentYear"] = SourceExpressionConverter.ConvertToken(bodyresidentYear);
                    bodypropCount++;
                }

                if (bodysituationResponseComments != null)
                {
                    body["SituationResponseComments"] = SourceExpressionConverter.ConvertToken(bodysituationResponseComments);
                    bodypropCount++;
                }

                if (bodysituationResponseDetail != null)
                {
                    body["SituationResponseDetail"] = SourceExpressionConverter.ConvertToken(bodysituationResponseDetail);
                    bodypropCount++;
                }

                if (bodysituationResponseEnum != null)
                {
                    body["SituationResponseEnum"] = SourceExpressionConverter.Convert(bodysituationResponseEnum);
                    bodypropCount++;
                }

                var situationResponseExpiryDateObject = new JObject();
                var situationResponseExpiryDateObjectpropCount = 0;
                if (bodysituationResponseExpiryDatevalue != null)
                {
                    situationResponseExpiryDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodysituationResponseExpiryDatevalue);
                    situationResponseExpiryDateObjectpropCount++;
                }

                if (bodysituationResponseExpiryDateOperator != null)
                {
                    situationResponseExpiryDateObject["_operator"] = SourceExpressionConverter.Convert(bodysituationResponseExpiryDateOperator);
                    situationResponseExpiryDateObjectpropCount++;
                }

                if (situationResponseExpiryDateObjectpropCount > 0)
                {
                    body["SituationResponseExpiryDate"] = situationResponseExpiryDateObject;
                    bodypropCount++;
                }

                var situationResponseModifiedDateObject = new JObject();
                var situationResponseModifiedDateObjectpropCount = 0;
                if (bodysituationResponseModifiedDatevalue != null)
                {
                    situationResponseModifiedDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodysituationResponseModifiedDatevalue);
                    situationResponseModifiedDateObjectpropCount++;
                }

                if (bodysituationResponseModifiedDateOperator != null)
                {
                    situationResponseModifiedDateObject["_operator"] = SourceExpressionConverter.Convert(bodysituationResponseModifiedDateOperator);
                    situationResponseModifiedDateObjectpropCount++;
                }

                if (situationResponseModifiedDateObjectpropCount > 0)
                {
                    body["SituationResponseModifiedDate"] = situationResponseModifiedDateObject;
                    bodypropCount++;
                }

                if (bodysituationResponseSituation != null)
                {
                    body["SituationResponseSituation"] = SourceExpressionConverter.ConvertToken(bodysituationResponseSituation);
                    bodypropCount++;
                }

                if (bodyspecialNeeds != null)
                {
                    body["SpecialNeeds"] = SourceExpressionConverter.ConvertToken(bodyspecialNeeds);
                    bodypropCount++;
                }

                if (bodystaffId != null)
                {
                    body["StaffID"] = SourceExpressionConverter.ConvertToken(bodystaffId);
                    bodypropCount++;
                }

                if (bodyusesScreenReader != null)
                {
                    body["UsesScreenReader"] = SourceExpressionConverter.ConvertToken(bodyusesScreenReader);
                    bodypropCount++;
                }

                if (bodyvehicleDetails != null)
                {
                    body["VehicleDetails"] = SourceExpressionConverter.ConvertToken(bodyvehicleDetails);
                    bodypropCount++;
                }

                if (bodyvehiclePermit != null)
                {
                    body["VehiclePermit"] = SourceExpressionConverter.ConvertToken(bodyvehiclePermit);
                    bodypropCount++;
                }

                if (bodyvehicleRegistration != null)
                {
                    body["VehicleRegistration"] = SourceExpressionConverter.ConvertToken(bodyvehicleRegistration);
                    bodypropCount++;
                }

                if (bodyveteranStatus != null)
                {
                    body["VeteranStatus"] = SourceExpressionConverter.ConvertToken(bodyveteranStatus);
                    bodypropCount++;
                }

                if (bodyvisa != null)
                {
                    body["Visa"] = SourceExpressionConverter.ConvertToken(bodyvisa);
                    bodypropCount++;
                }

                if (bodyvisaDetails != null)
                {
                    body["VisaDetails"] = SourceExpressionConverter.ConvertToken(bodyvisaDetails);
                    bodypropCount++;
                }

                if (bodyvisitorHold != null)
                {
                    body["VisitorHold"] = SourceExpressionConverter.ConvertToken(bodyvisitorHold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryDetailResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryDetailResponse> UpdateEntryDetail([WorkflowExpression] Func<int> entryDetailId, [WorkflowExpression] Func<bool> bodyacademicHold = null, [WorkflowExpression] Func<int> bodyaccountPaymentTypeId = null, [WorkflowExpression] Func<string> bodyaccountBankName = null, [WorkflowExpression] Func<string> bodyaccountBankNumber = null, [WorkflowExpression] Func<string> bodyaccountCode = null, [WorkflowExpression] Func<string> bodyaccountComments = null, [WorkflowExpression] Func<string> bodyaccountDetail1 = null, [WorkflowExpression] Func<string> bodyaccountDetail2 = null, [WorkflowExpression] Func<string> bodyaccountDetail3 = null, [WorkflowExpression] Func<string> bodyaccountDetail4 = null, [WorkflowExpression] Func<string> bodyaccountDueDate = null, [WorkflowExpression] Func<bool> bodyaccountHold = null, [WorkflowExpression] Func<bool> bodyathlete = null, [WorkflowExpression] Func<string> bodyathleteTeam = null, [WorkflowExpression] Func<bodyattendeeStatusEnumInput> bodyattendeeStatusEnum = null, [WorkflowExpression] Func<string> bodycareer = null, [WorkflowExpression] Func<string> bodycareerComments = null, [WorkflowExpression] Func<int> bodycitizenshipCountryId = null, [WorkflowExpression] Func<int> bodyclassificationId = null, [WorkflowExpression] Func<bool> bodyclassificationOverride = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycountryOfBirthCountryId = null, [WorkflowExpression] Func<int> bodycountryOfResidenceCountryId = null, [WorkflowExpression] Func<double> bodycumulativeGPA = null, [WorkflowExpression] Func<double> bodycumulativeHours = null, [WorkflowExpression] Func<double> bodycurrentGPA = null, [WorkflowExpression] Func<double> bodycurrentHours = null, [WorkflowExpression] Func<string> bodycurrentMajor = null, [WorkflowExpression] Func<string> bodycurrentMinor = null, [WorkflowExpression] Func<string> bodydateEntry = null, [WorkflowExpression] Func<string> bodydateExit = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<string> bodydeceasedDate = null, [WorkflowExpression] Func<string> bodydietary = null, [WorkflowExpression] Func<string> bodydisability = null, [WorkflowExpression] Func<string> bodyemploymentDetails = null, [WorkflowExpression] Func<string> bodyenrollmentClass = null, [WorkflowExpression] Func<string> bodyenrollmentLevel = null, [WorkflowExpression] Func<string> bodyenrollmentStatus = null, [WorkflowExpression] Func<string> bodyenrollmentTerm = null, [WorkflowExpression] Func<int> bodyenrollmentYear = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<int> bodyeventRegistrationFeeId = null, [WorkflowExpression] Func<string> bodyexpectedGraduationDate = null, [WorkflowExpression] Func<string> bodyfinancialComments = null, [WorkflowExpression] Func<int> bodyfinancialSupportId = null, [WorkflowExpression] Func<string> bodyhearAboutUs = null, [WorkflowExpression] Func<bool> bodyhonorsIndicator = null, [WorkflowExpression] Func<bool> bodyimmunizationsHold = null, [WorkflowExpression] Func<bool> bodyincidentHold = null, [WorkflowExpression] Func<string> bodyincidentHoldComments = null, [WorkflowExpression] Func<bool> bodyinternational = null, [WorkflowExpression] Func<string> bodyinternationalDetails = null, [WorkflowExpression] Func<bool> bodylivingWithDependents = null, [WorkflowExpression] Func<bool> bodymarried = null, [WorkflowExpression] Func<string> bodymedical = null, [WorkflowExpression] Func<int> bodynationalityId = null, [WorkflowExpression] Func<string> bodyoccupation = null, [WorkflowExpression] Func<string> bodyphotoPath = null, [WorkflowExpression] Func<string> bodypreviousMemberName = null, [WorkflowExpression] Func<string> bodypreviousMemberRelationship = null, [WorkflowExpression] Func<string> bodypreviousMembership = null, [WorkflowExpression] Func<string> bodypreviousMembershipYears = null, [WorkflowExpression] Func<string> bodypreviousMemberYears = null, [WorkflowExpression] Func<string> bodyprofileInterests = null, [WorkflowExpression] Func<int> bodyregionOfBirthId = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<string> bodyresidency = null, [WorkflowExpression] Func<string> bodyresidentStatus = null, [WorkflowExpression] Func<int> bodyresidentYear = null, [WorkflowExpression] Func<string> bodysituationResponseComments = null, [WorkflowExpression] Func<string> bodysituationResponseDetail = null, [WorkflowExpression] Func<bodysituationResponseEnumInput> bodysituationResponseEnum = null, [WorkflowExpression] Func<string> bodysituationResponseExpiryDate = null, [WorkflowExpression] Func<string> bodysituationResponseModifiedDate = null, [WorkflowExpression] Func<string> bodysituationResponseSituation = null, [WorkflowExpression] Func<string> bodyspecialNeeds = null, [WorkflowExpression] Func<int> bodystaffId = null, [WorkflowExpression] Func<bool> bodyusesScreenReader = null, [WorkflowExpression] Func<string> bodyvehicleDetails = null, [WorkflowExpression] Func<string> bodyvehiclePermit = null, [WorkflowExpression] Func<string> bodyvehicleRegistration = null, [WorkflowExpression] Func<string> bodyveteranStatus = null, [WorkflowExpression] Func<bool> bodyvisa = null, [WorkflowExpression] Func<string> bodyvisaDetails = null, [WorkflowExpression] Func<bool> bodyvisitorHold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entrydetail.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryDetailId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyacademicHold != null)
                {
                    body["AcademicHold"] = SourceExpressionConverter.ConvertToken(bodyacademicHold);
                    bodypropCount++;
                }

                if (bodyaccountPaymentTypeId != null)
                {
                    body["Account_PaymentTypeID"] = SourceExpressionConverter.ConvertToken(bodyaccountPaymentTypeId);
                    bodypropCount++;
                }

                if (bodyaccountBankName != null)
                {
                    body["AccountBankName"] = SourceExpressionConverter.ConvertToken(bodyaccountBankName);
                    bodypropCount++;
                }

                if (bodyaccountBankNumber != null)
                {
                    body["AccountBankNumber"] = SourceExpressionConverter.ConvertToken(bodyaccountBankNumber);
                    bodypropCount++;
                }

                if (bodyaccountCode != null)
                {
                    body["AccountCode"] = SourceExpressionConverter.ConvertToken(bodyaccountCode);
                    bodypropCount++;
                }

                if (bodyaccountComments != null)
                {
                    body["AccountComments"] = SourceExpressionConverter.ConvertToken(bodyaccountComments);
                    bodypropCount++;
                }

                if (bodyaccountDetail1 != null)
                {
                    body["AccountDetail1"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail1);
                    bodypropCount++;
                }

                if (bodyaccountDetail2 != null)
                {
                    body["AccountDetail2"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail2);
                    bodypropCount++;
                }

                if (bodyaccountDetail3 != null)
                {
                    body["AccountDetail3"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail3);
                    bodypropCount++;
                }

                if (bodyaccountDetail4 != null)
                {
                    body["AccountDetail4"] = SourceExpressionConverter.ConvertToken(bodyaccountDetail4);
                    bodypropCount++;
                }

                if (bodyaccountDueDate != null)
                {
                    body["AccountDueDate"] = SourceExpressionConverter.ConvertToken(bodyaccountDueDate);
                    bodypropCount++;
                }

                if (bodyaccountHold != null)
                {
                    body["AccountHold"] = SourceExpressionConverter.ConvertToken(bodyaccountHold);
                    bodypropCount++;
                }

                if (bodyathlete != null)
                {
                    body["Athlete"] = SourceExpressionConverter.ConvertToken(bodyathlete);
                    bodypropCount++;
                }

                if (bodyathleteTeam != null)
                {
                    body["AthleteTeam"] = SourceExpressionConverter.ConvertToken(bodyathleteTeam);
                    bodypropCount++;
                }

                if (bodyattendeeStatusEnum != null)
                {
                    body["AttendeeStatusEnum"] = SourceExpressionConverter.Convert(bodyattendeeStatusEnum);
                    bodypropCount++;
                }

                if (bodycareer != null)
                {
                    body["Career"] = SourceExpressionConverter.ConvertToken(bodycareer);
                    bodypropCount++;
                }

                if (bodycareerComments != null)
                {
                    body["CareerComments"] = SourceExpressionConverter.ConvertToken(bodycareerComments);
                    bodypropCount++;
                }

                if (bodycitizenshipCountryId != null)
                {
                    body["Citizenship_CountryID"] = SourceExpressionConverter.ConvertToken(bodycitizenshipCountryId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["ClassificationID"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
                    bodypropCount++;
                }

                if (bodyclassificationOverride != null)
                {
                    body["ClassificationOverride"] = SourceExpressionConverter.ConvertToken(bodyclassificationOverride);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycountryOfBirthCountryId != null)
                {
                    body["CountryOfBirth_CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryOfBirthCountryId);
                    bodypropCount++;
                }

                if (bodycountryOfResidenceCountryId != null)
                {
                    body["CountryOfResidence_CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryOfResidenceCountryId);
                    bodypropCount++;
                }

                if (bodycumulativeGPA != null)
                {
                    body["CumulativeGPA"] = SourceExpressionConverter.ConvertToken(bodycumulativeGPA);
                    bodypropCount++;
                }

                if (bodycumulativeHours != null)
                {
                    body["CumulativeHours"] = SourceExpressionConverter.ConvertToken(bodycumulativeHours);
                    bodypropCount++;
                }

                if (bodycurrentGPA != null)
                {
                    body["CurrentGPA"] = SourceExpressionConverter.ConvertToken(bodycurrentGPA);
                    bodypropCount++;
                }

                if (bodycurrentHours != null)
                {
                    body["CurrentHours"] = SourceExpressionConverter.ConvertToken(bodycurrentHours);
                    bodypropCount++;
                }

                if (bodycurrentMajor != null)
                {
                    body["CurrentMajor"] = SourceExpressionConverter.ConvertToken(bodycurrentMajor);
                    bodypropCount++;
                }

                if (bodycurrentMinor != null)
                {
                    body["CurrentMinor"] = SourceExpressionConverter.ConvertToken(bodycurrentMinor);
                    bodypropCount++;
                }

                if (bodydateEntry != null)
                {
                    body["DateEntry"] = SourceExpressionConverter.ConvertToken(bodydateEntry);
                    bodypropCount++;
                }

                if (bodydateExit != null)
                {
                    body["DateExit"] = SourceExpressionConverter.ConvertToken(bodydateExit);
                    bodypropCount++;
                }

                if (bodydeceased != null)
                {
                    body["Deceased"] = SourceExpressionConverter.ConvertToken(bodydeceased);
                    bodypropCount++;
                }

                if (bodydeceasedDate != null)
                {
                    body["DeceasedDate"] = SourceExpressionConverter.ConvertToken(bodydeceasedDate);
                    bodypropCount++;
                }

                if (bodydietary != null)
                {
                    body["Dietary"] = SourceExpressionConverter.ConvertToken(bodydietary);
                    bodypropCount++;
                }

                if (bodydisability != null)
                {
                    body["Disability"] = SourceExpressionConverter.ConvertToken(bodydisability);
                    bodypropCount++;
                }

                if (bodyemploymentDetails != null)
                {
                    body["EmploymentDetails"] = SourceExpressionConverter.ConvertToken(bodyemploymentDetails);
                    bodypropCount++;
                }

                if (bodyenrollmentClass != null)
                {
                    body["EnrollmentClass"] = SourceExpressionConverter.ConvertToken(bodyenrollmentClass);
                    bodypropCount++;
                }

                if (bodyenrollmentLevel != null)
                {
                    body["EnrollmentLevel"] = SourceExpressionConverter.ConvertToken(bodyenrollmentLevel);
                    bodypropCount++;
                }

                if (bodyenrollmentStatus != null)
                {
                    body["EnrollmentStatus"] = SourceExpressionConverter.ConvertToken(bodyenrollmentStatus);
                    bodypropCount++;
                }

                if (bodyenrollmentTerm != null)
                {
                    body["EnrollmentTerm"] = SourceExpressionConverter.ConvertToken(bodyenrollmentTerm);
                    bodypropCount++;
                }

                if (bodyenrollmentYear != null)
                {
                    body["EnrollmentYear"] = SourceExpressionConverter.ConvertToken(bodyenrollmentYear);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["Ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodyeventRegistrationFeeId != null)
                {
                    body["EventRegistrationFeeID"] = SourceExpressionConverter.ConvertToken(bodyeventRegistrationFeeId);
                    bodypropCount++;
                }

                if (bodyexpectedGraduationDate != null)
                {
                    body["ExpectedGraduationDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedGraduationDate);
                    bodypropCount++;
                }

                if (bodyfinancialComments != null)
                {
                    body["FinancialComments"] = SourceExpressionConverter.ConvertToken(bodyfinancialComments);
                    bodypropCount++;
                }

                if (bodyfinancialSupportId != null)
                {
                    body["FinancialSupportID"] = SourceExpressionConverter.ConvertToken(bodyfinancialSupportId);
                    bodypropCount++;
                }

                if (bodyhearAboutUs != null)
                {
                    body["HearAboutUs"] = SourceExpressionConverter.ConvertToken(bodyhearAboutUs);
                    bodypropCount++;
                }

                if (bodyhonorsIndicator != null)
                {
                    body["HonorsIndicator"] = SourceExpressionConverter.ConvertToken(bodyhonorsIndicator);
                    bodypropCount++;
                }

                if (bodyimmunizationsHold != null)
                {
                    body["ImmunizationsHold"] = SourceExpressionConverter.ConvertToken(bodyimmunizationsHold);
                    bodypropCount++;
                }

                if (bodyincidentHold != null)
                {
                    body["IncidentHold"] = SourceExpressionConverter.ConvertToken(bodyincidentHold);
                    bodypropCount++;
                }

                if (bodyincidentHoldComments != null)
                {
                    body["IncidentHoldComments"] = SourceExpressionConverter.ConvertToken(bodyincidentHoldComments);
                    bodypropCount++;
                }

                if (bodyinternational != null)
                {
                    body["International"] = SourceExpressionConverter.ConvertToken(bodyinternational);
                    bodypropCount++;
                }

                if (bodyinternationalDetails != null)
                {
                    body["InternationalDetails"] = SourceExpressionConverter.ConvertToken(bodyinternationalDetails);
                    bodypropCount++;
                }

                if (bodylivingWithDependents != null)
                {
                    body["LivingWithDependents"] = SourceExpressionConverter.ConvertToken(bodylivingWithDependents);
                    bodypropCount++;
                }

                if (bodymarried != null)
                {
                    body["Married"] = SourceExpressionConverter.ConvertToken(bodymarried);
                    bodypropCount++;
                }

                if (bodymedical != null)
                {
                    body["Medical"] = SourceExpressionConverter.ConvertToken(bodymedical);
                    bodypropCount++;
                }

                if (bodynationalityId != null)
                {
                    body["NationalityID"] = SourceExpressionConverter.ConvertToken(bodynationalityId);
                    bodypropCount++;
                }

                if (bodyoccupation != null)
                {
                    body["Occupation"] = SourceExpressionConverter.ConvertToken(bodyoccupation);
                    bodypropCount++;
                }

                if (bodyphotoPath != null)
                {
                    body["PhotoPath"] = SourceExpressionConverter.ConvertToken(bodyphotoPath);
                    bodypropCount++;
                }

                if (bodypreviousMemberName != null)
                {
                    body["PreviousMemberName"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberName);
                    bodypropCount++;
                }

                if (bodypreviousMemberRelationship != null)
                {
                    body["PreviousMemberRelationship"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberRelationship);
                    bodypropCount++;
                }

                if (bodypreviousMembership != null)
                {
                    body["PreviousMembership"] = SourceExpressionConverter.ConvertToken(bodypreviousMembership);
                    bodypropCount++;
                }

                if (bodypreviousMembershipYears != null)
                {
                    body["PreviousMembershipYears"] = SourceExpressionConverter.ConvertToken(bodypreviousMembershipYears);
                    bodypropCount++;
                }

                if (bodypreviousMemberYears != null)
                {
                    body["PreviousMemberYears"] = SourceExpressionConverter.ConvertToken(bodypreviousMemberYears);
                    bodypropCount++;
                }

                if (bodyprofileInterests != null)
                {
                    body["ProfileInterests"] = SourceExpressionConverter.ConvertToken(bodyprofileInterests);
                    bodypropCount++;
                }

                if (bodyregionOfBirthId != null)
                {
                    body["RegionOfBirthID"] = SourceExpressionConverter.ConvertToken(bodyregionOfBirthId);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["Religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                if (bodyresidency != null)
                {
                    body["Residency"] = SourceExpressionConverter.ConvertToken(bodyresidency);
                    bodypropCount++;
                }

                if (bodyresidentStatus != null)
                {
                    body["ResidentStatus"] = SourceExpressionConverter.ConvertToken(bodyresidentStatus);
                    bodypropCount++;
                }

                if (bodyresidentYear != null)
                {
                    body["ResidentYear"] = SourceExpressionConverter.ConvertToken(bodyresidentYear);
                    bodypropCount++;
                }

                if (bodysituationResponseComments != null)
                {
                    body["SituationResponseComments"] = SourceExpressionConverter.ConvertToken(bodysituationResponseComments);
                    bodypropCount++;
                }

                if (bodysituationResponseDetail != null)
                {
                    body["SituationResponseDetail"] = SourceExpressionConverter.ConvertToken(bodysituationResponseDetail);
                    bodypropCount++;
                }

                if (bodysituationResponseEnum != null)
                {
                    body["SituationResponseEnum"] = SourceExpressionConverter.Convert(bodysituationResponseEnum);
                    bodypropCount++;
                }

                if (bodysituationResponseExpiryDate != null)
                {
                    body["SituationResponseExpiryDate"] = SourceExpressionConverter.ConvertToken(bodysituationResponseExpiryDate);
                    bodypropCount++;
                }

                if (bodysituationResponseModifiedDate != null)
                {
                    body["SituationResponseModifiedDate"] = SourceExpressionConverter.ConvertToken(bodysituationResponseModifiedDate);
                    bodypropCount++;
                }

                if (bodysituationResponseSituation != null)
                {
                    body["SituationResponseSituation"] = SourceExpressionConverter.ConvertToken(bodysituationResponseSituation);
                    bodypropCount++;
                }

                if (bodyspecialNeeds != null)
                {
                    body["SpecialNeeds"] = SourceExpressionConverter.ConvertToken(bodyspecialNeeds);
                    bodypropCount++;
                }

                if (bodystaffId != null)
                {
                    body["StaffID"] = SourceExpressionConverter.ConvertToken(bodystaffId);
                    bodypropCount++;
                }

                if (bodyusesScreenReader != null)
                {
                    body["UsesScreenReader"] = SourceExpressionConverter.ConvertToken(bodyusesScreenReader);
                    bodypropCount++;
                }

                if (bodyvehicleDetails != null)
                {
                    body["VehicleDetails"] = SourceExpressionConverter.ConvertToken(bodyvehicleDetails);
                    bodypropCount++;
                }

                if (bodyvehiclePermit != null)
                {
                    body["VehiclePermit"] = SourceExpressionConverter.ConvertToken(bodyvehiclePermit);
                    bodypropCount++;
                }

                if (bodyvehicleRegistration != null)
                {
                    body["VehicleRegistration"] = SourceExpressionConverter.ConvertToken(bodyvehicleRegistration);
                    bodypropCount++;
                }

                if (bodyveteranStatus != null)
                {
                    body["VeteranStatus"] = SourceExpressionConverter.ConvertToken(bodyveteranStatus);
                    bodypropCount++;
                }

                if (bodyvisa != null)
                {
                    body["Visa"] = SourceExpressionConverter.ConvertToken(bodyvisa);
                    bodypropCount++;
                }

                if (bodyvisaDetails != null)
                {
                    body["VisaDetails"] = SourceExpressionConverter.ConvertToken(bodyvisaDetails);
                    bodypropCount++;
                }

                if (bodyvisitorHold != null)
                {
                    body["VisitorHold"] = SourceExpressionConverter.ConvertToken(bodyvisitorHold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryEnrollmentResponseItem[]> SelectEntryEnrollment([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycourseId = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateEndvalue = null, [WorkflowExpression] Func<bodydateEndOperatorInput> bodydateEndOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydateStartvalue = null, [WorkflowExpression] Func<bodydateStartOperatorInput> bodydateStartOperator = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyenrollmentField = null, [WorkflowExpression] Func<int> bodyenrollmentOrder = null, [WorkflowExpression] Func<bodyenrollmentTypeEnumInput> bodyenrollmentTypeEnum = null, [WorkflowExpression] Func<int> bodyentryEnrollmentId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<bool> bodyfullTime = null, [WorkflowExpression] Func<string> bodygraduationDatevalue = null, [WorkflowExpression] Func<bodygraduationDateOperatorInput> bodygraduationDateOperator = null, [WorkflowExpression] Func<string> bodyinstitution = null, [WorkflowExpression] Func<bool> bodyisEnrolled = null, [WorkflowExpression] Func<string> bodymajor = null, [WorkflowExpression] Func<string> bodymajorCategory = null, [WorkflowExpression] Func<string> bodyminor = null, [WorkflowExpression] Func<bool> bodypostGrad = null, [WorkflowExpression] Func<int> bodysequence = null, [WorkflowExpression] Func<string> bodysubjects = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<string> bodyyears = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/EntryEnrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodycampus != null)
                {
                    body["Campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycourseId != null)
                {
                    body["CourseID"] = SourceExpressionConverter.ConvertToken(bodycourseId);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                var dateEndObject = new JObject();
                var dateEndObjectpropCount = 0;
                if (bodydateEndvalue != null)
                {
                    dateEndObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateEndvalue);
                    dateEndObjectpropCount++;
                }

                if (bodydateEndOperator != null)
                {
                    dateEndObject["_operator"] = SourceExpressionConverter.Convert(bodydateEndOperator);
                    dateEndObjectpropCount++;
                }

                if (dateEndObjectpropCount > 0)
                {
                    body["DateEnd"] = dateEndObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateStartObject = new JObject();
                var dateStartObjectpropCount = 0;
                if (bodydateStartvalue != null)
                {
                    dateStartObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateStartvalue);
                    dateStartObjectpropCount++;
                }

                if (bodydateStartOperator != null)
                {
                    dateStartObject["_operator"] = SourceExpressionConverter.Convert(bodydateStartOperator);
                    dateStartObjectpropCount++;
                }

                if (dateStartObjectpropCount > 0)
                {
                    body["DateStart"] = dateStartObject;
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["Department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = SourceExpressionConverter.ConvertToken(bodyenrollmentField);
                    bodypropCount++;
                }

                if (bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = SourceExpressionConverter.ConvertToken(bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = SourceExpressionConverter.Convert(bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                if (bodyentryEnrollmentId != null)
                {
                    body["EntryEnrollmentID"] = SourceExpressionConverter.ConvertToken(bodyentryEnrollmentId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["Faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyfullTime != null)
                {
                    body["FullTime"] = SourceExpressionConverter.ConvertToken(bodyfullTime);
                    bodypropCount++;
                }

                var graduationDateObject = new JObject();
                var graduationDateObjectpropCount = 0;
                if (bodygraduationDatevalue != null)
                {
                    graduationDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodygraduationDatevalue);
                    graduationDateObjectpropCount++;
                }

                if (bodygraduationDateOperator != null)
                {
                    graduationDateObject["_operator"] = SourceExpressionConverter.Convert(bodygraduationDateOperator);
                    graduationDateObjectpropCount++;
                }

                if (graduationDateObjectpropCount > 0)
                {
                    body["GraduationDate"] = graduationDateObject;
                    bodypropCount++;
                }

                if (bodyinstitution != null)
                {
                    body["Institution"] = SourceExpressionConverter.ConvertToken(bodyinstitution);
                    bodypropCount++;
                }

                if (bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = SourceExpressionConverter.ConvertToken(bodyisEnrolled);
                    bodypropCount++;
                }

                if (bodymajor != null)
                {
                    body["Major"] = SourceExpressionConverter.ConvertToken(bodymajor);
                    bodypropCount++;
                }

                if (bodymajorCategory != null)
                {
                    body["MajorCategory"] = SourceExpressionConverter.ConvertToken(bodymajorCategory);
                    bodypropCount++;
                }

                if (bodyminor != null)
                {
                    body["Minor"] = SourceExpressionConverter.ConvertToken(bodyminor);
                    bodypropCount++;
                }

                if (bodypostGrad != null)
                {
                    body["PostGrad"] = SourceExpressionConverter.ConvertToken(bodypostGrad);
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["Sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodysubjects != null)
                {
                    body["Subjects"] = SourceExpressionConverter.ConvertToken(bodysubjects);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyyears != null)
                {
                    body["Years"] = SourceExpressionConverter.ConvertToken(bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectEntryEnrollmentResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryEnrollmentResponse> CreateEntryEnrollment([WorkflowExpression] Func<int> bodyentryId, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycourseId = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateEnd = null, [WorkflowExpression] Func<string> bodydateStart = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyenrollmentField = null, [WorkflowExpression] Func<int> bodyenrollmentOrder = null, [WorkflowExpression] Func<bodyenrollmentTypeEnumInput> bodyenrollmentTypeEnum = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<bool> bodyfullTime = null, [WorkflowExpression] Func<string> bodygraduationDate = null, [WorkflowExpression] Func<string> bodyinstitution = null, [WorkflowExpression] Func<bool> bodyisEnrolled = null, [WorkflowExpression] Func<string> bodymajor = null, [WorkflowExpression] Func<string> bodymajorCategory = null, [WorkflowExpression] Func<string> bodyminor = null, [WorkflowExpression] Func<bool> bodypostGrad = null, [WorkflowExpression] Func<int> bodysequence = null, [WorkflowExpression] Func<string> bodysubjects = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<string> bodyyears = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/entryenrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycampus != null)
                {
                    body["Campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycourseId != null)
                {
                    body["CourseID"] = SourceExpressionConverter.ConvertToken(bodycourseId);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodydateEnd != null)
                {
                    body["DateEnd"] = SourceExpressionConverter.ConvertToken(bodydateEnd);
                    bodypropCount++;
                }

                if (bodydateStart != null)
                {
                    body["DateStart"] = SourceExpressionConverter.ConvertToken(bodydateStart);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["Department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = SourceExpressionConverter.ConvertToken(bodyenrollmentField);
                    bodypropCount++;
                }

                if (bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = SourceExpressionConverter.ConvertToken(bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = SourceExpressionConverter.Convert(bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                if (bodyfaculty != null)
                {
                    body["Faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyfullTime != null)
                {
                    body["FullTime"] = SourceExpressionConverter.ConvertToken(bodyfullTime);
                    bodypropCount++;
                }

                if (bodygraduationDate != null)
                {
                    body["GraduationDate"] = SourceExpressionConverter.ConvertToken(bodygraduationDate);
                    bodypropCount++;
                }

                if (bodyinstitution != null)
                {
                    body["Institution"] = SourceExpressionConverter.ConvertToken(bodyinstitution);
                    bodypropCount++;
                }

                if (bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = SourceExpressionConverter.ConvertToken(bodyisEnrolled);
                    bodypropCount++;
                }

                if (bodymajor != null)
                {
                    body["Major"] = SourceExpressionConverter.ConvertToken(bodymajor);
                    bodypropCount++;
                }

                if (bodymajorCategory != null)
                {
                    body["MajorCategory"] = SourceExpressionConverter.ConvertToken(bodymajorCategory);
                    bodypropCount++;
                }

                if (bodyminor != null)
                {
                    body["Minor"] = SourceExpressionConverter.ConvertToken(bodyminor);
                    bodypropCount++;
                }

                if (bodypostGrad != null)
                {
                    body["PostGrad"] = SourceExpressionConverter.ConvertToken(bodypostGrad);
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["Sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodysubjects != null)
                {
                    body["Subjects"] = SourceExpressionConverter.ConvertToken(bodysubjects);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyyears != null)
                {
                    body["Years"] = SourceExpressionConverter.ConvertToken(bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEntryEnrollmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryEnrollmentResponse> UpdateEntryEnrollment([WorkflowExpression] Func<int> entryEnrollmentId, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycourseId = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateEnd = null, [WorkflowExpression] Func<string> bodydateStart = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyenrollmentField = null, [WorkflowExpression] Func<int> bodyenrollmentOrder = null, [WorkflowExpression] Func<bodyenrollmentTypeEnumInput> bodyenrollmentTypeEnum = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<bool> bodyfullTime = null, [WorkflowExpression] Func<string> bodygraduationDate = null, [WorkflowExpression] Func<string> bodyinstitution = null, [WorkflowExpression] Func<bool> bodyisEnrolled = null, [WorkflowExpression] Func<string> bodymajor = null, [WorkflowExpression] Func<string> bodymajorCategory = null, [WorkflowExpression] Func<string> bodyminor = null, [WorkflowExpression] Func<bool> bodypostGrad = null, [WorkflowExpression] Func<int> bodysequence = null, [WorkflowExpression] Func<string> bodysubjects = null, [WorkflowExpression] Func<int> bodytermId = null, [WorkflowExpression] Func<string> bodyyears = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/entryenrollment.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(entryEnrollmentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycampus != null)
                {
                    body["Campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycourseId != null)
                {
                    body["CourseID"] = SourceExpressionConverter.ConvertToken(bodycourseId);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodydateEnd != null)
                {
                    body["DateEnd"] = SourceExpressionConverter.ConvertToken(bodydateEnd);
                    bodypropCount++;
                }

                if (bodydateStart != null)
                {
                    body["DateStart"] = SourceExpressionConverter.ConvertToken(bodydateStart);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["Department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyenrollmentField != null)
                {
                    body["EnrollmentField"] = SourceExpressionConverter.ConvertToken(bodyenrollmentField);
                    bodypropCount++;
                }

                if (bodyenrollmentOrder != null)
                {
                    body["EnrollmentOrder"] = SourceExpressionConverter.ConvertToken(bodyenrollmentOrder);
                    bodypropCount++;
                }

                if (bodyenrollmentTypeEnum != null)
                {
                    body["EnrollmentTypeEnum"] = SourceExpressionConverter.Convert(bodyenrollmentTypeEnum);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["Faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyfullTime != null)
                {
                    body["FullTime"] = SourceExpressionConverter.ConvertToken(bodyfullTime);
                    bodypropCount++;
                }

                if (bodygraduationDate != null)
                {
                    body["GraduationDate"] = SourceExpressionConverter.ConvertToken(bodygraduationDate);
                    bodypropCount++;
                }

                if (bodyinstitution != null)
                {
                    body["Institution"] = SourceExpressionConverter.ConvertToken(bodyinstitution);
                    bodypropCount++;
                }

                if (bodyisEnrolled != null)
                {
                    body["IsEnrolled"] = SourceExpressionConverter.ConvertToken(bodyisEnrolled);
                    bodypropCount++;
                }

                if (bodymajor != null)
                {
                    body["Major"] = SourceExpressionConverter.ConvertToken(bodymajor);
                    bodypropCount++;
                }

                if (bodymajorCategory != null)
                {
                    body["MajorCategory"] = SourceExpressionConverter.ConvertToken(bodymajorCategory);
                    bodypropCount++;
                }

                if (bodyminor != null)
                {
                    body["Minor"] = SourceExpressionConverter.ConvertToken(bodyminor);
                    bodypropCount++;
                }

                if (bodypostGrad != null)
                {
                    body["PostGrad"] = SourceExpressionConverter.ConvertToken(bodypostGrad);
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["Sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodysubjects != null)
                {
                    body["Subjects"] = SourceExpressionConverter.ConvertToken(bodysubjects);
                    bodypropCount++;
                }

                if (bodytermId != null)
                {
                    body["TermID"] = SourceExpressionConverter.ConvertToken(bodytermId);
                    bodypropCount++;
                }

                if (bodyyears != null)
                {
                    body["Years"] = SourceExpressionConverter.ConvertToken(bodyyears);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEntryEnrollmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectBookingResponseItem[]> SelectBooking([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<int> bodyadditionalOccupantCount = null, [WorkflowExpression] Func<string> bodyautoAllocationDetail = null, [WorkflowExpression] Func<int> bodybookingId = null, [WorkflowExpression] Func<bodybookingLinkTypeEnumInput> bodybookingLinkTypeEnum = null, [WorkflowExpression] Func<int> bodybookingTypeId = null, [WorkflowExpression] Func<string> bodycheckInDatevalue = null, [WorkflowExpression] Func<bodycheckInDateOperatorInput> bodycheckInDateOperator = null, [WorkflowExpression] Func<string> bodycheckInDateActualvalue = null, [WorkflowExpression] Func<bodycheckInDateActualOperatorInput> bodycheckInDateActualOperator = null, [WorkflowExpression] Func<string> bodycheckOutDatevalue = null, [WorkflowExpression] Func<bodycheckOutDateOperatorInput> bodycheckOutDateOperator = null, [WorkflowExpression] Func<string> bodycheckOutDateActualvalue = null, [WorkflowExpression] Func<bodycheckOutDateActualOperatorInput> bodycheckOutDateActualOperator = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycontractDateEndvalue = null, [WorkflowExpression] Func<bodycontractDateEndOperatorInput> bodycontractDateEndOperator = null, [WorkflowExpression] Func<string> bodycontractDateStartvalue = null, [WorkflowExpression] Func<bodycontractDateStartOperatorInput> bodycontractDateStartOperator = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomDate3value = null, [WorkflowExpression] Func<bodycustomDate3OperatorInput> bodycustomDate3Operator = null, [WorkflowExpression] Func<string> bodycustomDate4value = null, [WorkflowExpression] Func<bodycustomDate4OperatorInput> bodycustomDate4Operator = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodycustomString7 = null, [WorkflowExpression] Func<string> bodycustomString8 = null, [WorkflowExpression] Func<string> bodycustomString9 = null, [WorkflowExpression] Func<string> bodycustomString10 = null, [WorkflowExpression] Func<string> bodydateBilledvalue = null, [WorkflowExpression] Func<bodydateBilledOperatorInput> bodydateBilledOperator = null, [WorkflowExpression] Func<string> bodydateChargedTovalue = null, [WorkflowExpression] Func<bodydateChargedToOperatorInput> bodydateChargedToOperator = null, [WorkflowExpression] Func<string> bodydateCreatedvalue = null, [WorkflowExpression] Func<bodydateCreatedOperatorInput> bodydateCreatedOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydateModifiedBillingvalue = null, [WorkflowExpression] Func<bodydateModifiedBillingOperatorInput> bodydateModifiedBillingOperator = null, [WorkflowExpression] Func<int> bodyemotionalSupportAnimalCount = null, [WorkflowExpression] Func<int> bodyendBookingReasonId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<int> bodyentryInvitationId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<string> bodyeTA = null, [WorkflowExpression] Func<string> bodyeTD = null, [WorkflowExpression] Func<double> bodyexcess = null, [WorkflowExpression] Func<int> bodygroupId = null, [WorkflowExpression] Func<int> bodyhousekeepingId = null, [WorkflowExpression] Func<int> bodynumberOfChildren = null, [WorkflowExpression] Func<int> bodynumberOfChildrenFree = null, [WorkflowExpression] Func<int> bodynumberOfGuests = null, [WorkflowExpression] Func<int> bodynumberOfGuestsFree = null, [WorkflowExpression] Func<string> bodypaidTovalue = null, [WorkflowExpression] Func<bodypaidToOperatorInput> bodypaidToOperator = null, [WorkflowExpression] Func<int> bodypetCount = null, [WorkflowExpression] Func<bool> bodyresvChargeToEntry = null, [WorkflowExpression] Func<bool> bodyroomLocationFixed = null, [WorkflowExpression] Func<int> bodyroomLocationId = null, [WorkflowExpression] Func<double> bodyroomRateAmount = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<int> bodyroomTypeId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodyserviceAnimalCount = null, [WorkflowExpression] Func<string> bodyspecialRequirement = null, [WorkflowExpression] Func<int> bodystartBookingReasonId = null, [WorkflowExpression] Func<int> bodytermSessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/Booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = SourceExpressionConverter.ConvertToken(bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = SourceExpressionConverter.ConvertToken(bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (bodybookingId != null)
                {
                    body["BookingID"] = SourceExpressionConverter.ConvertToken(bodybookingId);
                    bodypropCount++;
                }

                if (bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = SourceExpressionConverter.Convert(bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = SourceExpressionConverter.ConvertToken(bodybookingTypeId);
                    bodypropCount++;
                }

                var checkInDateObject = new JObject();
                var checkInDateObjectpropCount = 0;
                if (bodycheckInDatevalue != null)
                {
                    checkInDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckInDatevalue);
                    checkInDateObjectpropCount++;
                }

                if (bodycheckInDateOperator != null)
                {
                    checkInDateObject["_operator"] = SourceExpressionConverter.Convert(bodycheckInDateOperator);
                    checkInDateObjectpropCount++;
                }

                if (checkInDateObjectpropCount > 0)
                {
                    body["CheckInDate"] = checkInDateObject;
                    bodypropCount++;
                }

                var checkInDateActualObject = new JObject();
                var checkInDateActualObjectpropCount = 0;
                if (bodycheckInDateActualvalue != null)
                {
                    checkInDateActualObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckInDateActualvalue);
                    checkInDateActualObjectpropCount++;
                }

                if (bodycheckInDateActualOperator != null)
                {
                    checkInDateActualObject["_operator"] = SourceExpressionConverter.Convert(bodycheckInDateActualOperator);
                    checkInDateActualObjectpropCount++;
                }

                if (checkInDateActualObjectpropCount > 0)
                {
                    body["CheckInDateActual"] = checkInDateActualObject;
                    bodypropCount++;
                }

                var checkOutDateObject = new JObject();
                var checkOutDateObjectpropCount = 0;
                if (bodycheckOutDatevalue != null)
                {
                    checkOutDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckOutDatevalue);
                    checkOutDateObjectpropCount++;
                }

                if (bodycheckOutDateOperator != null)
                {
                    checkOutDateObject["_operator"] = SourceExpressionConverter.Convert(bodycheckOutDateOperator);
                    checkOutDateObjectpropCount++;
                }

                if (checkOutDateObjectpropCount > 0)
                {
                    body["CheckOutDate"] = checkOutDateObject;
                    bodypropCount++;
                }

                var checkOutDateActualObject = new JObject();
                var checkOutDateActualObjectpropCount = 0;
                if (bodycheckOutDateActualvalue != null)
                {
                    checkOutDateActualObject["Value"] = SourceExpressionConverter.ConvertToken(bodycheckOutDateActualvalue);
                    checkOutDateActualObjectpropCount++;
                }

                if (bodycheckOutDateActualOperator != null)
                {
                    checkOutDateActualObject["_operator"] = SourceExpressionConverter.Convert(bodycheckOutDateActualOperator);
                    checkOutDateActualObjectpropCount++;
                }

                if (checkOutDateActualObjectpropCount > 0)
                {
                    body["CheckOutDateActual"] = checkOutDateActualObject;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                var contractDateEndObject = new JObject();
                var contractDateEndObjectpropCount = 0;
                if (bodycontractDateEndvalue != null)
                {
                    contractDateEndObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractDateEndvalue);
                    contractDateEndObjectpropCount++;
                }

                if (bodycontractDateEndOperator != null)
                {
                    contractDateEndObject["_operator"] = SourceExpressionConverter.Convert(bodycontractDateEndOperator);
                    contractDateEndObjectpropCount++;
                }

                if (contractDateEndObjectpropCount > 0)
                {
                    body["ContractDateEnd"] = contractDateEndObject;
                    bodypropCount++;
                }

                var contractDateStartObject = new JObject();
                var contractDateStartObjectpropCount = 0;
                if (bodycontractDateStartvalue != null)
                {
                    contractDateStartObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractDateStartvalue);
                    contractDateStartObjectpropCount++;
                }

                if (bodycontractDateStartOperator != null)
                {
                    contractDateStartObject["_operator"] = SourceExpressionConverter.Convert(bodycontractDateStartOperator);
                    contractDateStartObjectpropCount++;
                }

                if (contractDateStartObjectpropCount > 0)
                {
                    body["ContractDateStart"] = contractDateStartObject;
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                var customDate3Object = new JObject();
                var customDate3ObjectpropCount = 0;
                if (bodycustomDate3value != null)
                {
                    customDate3Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate3value);
                    customDate3ObjectpropCount++;
                }

                if (bodycustomDate3Operator != null)
                {
                    customDate3Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate3Operator);
                    customDate3ObjectpropCount++;
                }

                if (customDate3ObjectpropCount > 0)
                {
                    body["CustomDate3"] = customDate3Object;
                    bodypropCount++;
                }

                var customDate4Object = new JObject();
                var customDate4ObjectpropCount = 0;
                if (bodycustomDate4value != null)
                {
                    customDate4Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate4value);
                    customDate4ObjectpropCount++;
                }

                if (bodycustomDate4Operator != null)
                {
                    customDate4Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate4Operator);
                    customDate4ObjectpropCount++;
                }

                if (customDate4ObjectpropCount > 0)
                {
                    body["CustomDate4"] = customDate4Object;
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodycustomString7 != null)
                {
                    body["CustomString7"] = SourceExpressionConverter.ConvertToken(bodycustomString7);
                    bodypropCount++;
                }

                if (bodycustomString8 != null)
                {
                    body["CustomString8"] = SourceExpressionConverter.ConvertToken(bodycustomString8);
                    bodypropCount++;
                }

                if (bodycustomString9 != null)
                {
                    body["CustomString9"] = SourceExpressionConverter.ConvertToken(bodycustomString9);
                    bodypropCount++;
                }

                if (bodycustomString10 != null)
                {
                    body["CustomString10"] = SourceExpressionConverter.ConvertToken(bodycustomString10);
                    bodypropCount++;
                }

                var dateBilledObject = new JObject();
                var dateBilledObjectpropCount = 0;
                if (bodydateBilledvalue != null)
                {
                    dateBilledObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateBilledvalue);
                    dateBilledObjectpropCount++;
                }

                if (bodydateBilledOperator != null)
                {
                    dateBilledObject["_operator"] = SourceExpressionConverter.Convert(bodydateBilledOperator);
                    dateBilledObjectpropCount++;
                }

                if (dateBilledObjectpropCount > 0)
                {
                    body["DateBilled"] = dateBilledObject;
                    bodypropCount++;
                }

                var dateChargedToObject = new JObject();
                var dateChargedToObjectpropCount = 0;
                if (bodydateChargedTovalue != null)
                {
                    dateChargedToObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateChargedTovalue);
                    dateChargedToObjectpropCount++;
                }

                if (bodydateChargedToOperator != null)
                {
                    dateChargedToObject["_operator"] = SourceExpressionConverter.Convert(bodydateChargedToOperator);
                    dateChargedToObjectpropCount++;
                }

                if (dateChargedToObjectpropCount > 0)
                {
                    body["DateChargedTo"] = dateChargedToObject;
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = SourceExpressionConverter.Convert(bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateModifiedBillingObject = new JObject();
                var dateModifiedBillingObjectpropCount = 0;
                if (bodydateModifiedBillingvalue != null)
                {
                    dateModifiedBillingObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedBillingvalue);
                    dateModifiedBillingObjectpropCount++;
                }

                if (bodydateModifiedBillingOperator != null)
                {
                    dateModifiedBillingObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedBillingOperator);
                    dateModifiedBillingObjectpropCount++;
                }

                if (dateModifiedBillingObjectpropCount > 0)
                {
                    body["DateModifiedBilling"] = dateModifiedBillingObject;
                    bodypropCount++;
                }

                if (bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = SourceExpressionConverter.ConvertToken(bodyentryInvitationId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeTA != null)
                {
                    body["ETA"] = SourceExpressionConverter.ConvertToken(bodyeTA);
                    bodypropCount++;
                }

                if (bodyeTD != null)
                {
                    body["ETD"] = SourceExpressionConverter.ConvertToken(bodyeTD);
                    bodypropCount++;
                }

                if (bodyexcess != null)
                {
                    body["Excess"] = SourceExpressionConverter.ConvertToken(bodyexcess);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["GroupID"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = SourceExpressionConverter.ConvertToken(bodyhousekeepingId);
                    bodypropCount++;
                }

                if (bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildren);
                    bodypropCount++;
                }

                if (bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuests);
                    bodypropCount++;
                }

                if (bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                var paidToObject = new JObject();
                var paidToObjectpropCount = 0;
                if (bodypaidTovalue != null)
                {
                    paidToObject["Value"] = SourceExpressionConverter.ConvertToken(bodypaidTovalue);
                    paidToObjectpropCount++;
                }

                if (bodypaidToOperator != null)
                {
                    paidToObject["_operator"] = SourceExpressionConverter.Convert(bodypaidToOperator);
                    paidToObjectpropCount++;
                }

                if (paidToObjectpropCount > 0)
                {
                    body["PaidTo"] = paidToObject;
                    bodypropCount++;
                }

                if (bodypetCount != null)
                {
                    body["PetCount"] = SourceExpressionConverter.ConvertToken(bodypetCount);
                    bodypropCount++;
                }

                if (bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = SourceExpressionConverter.ConvertToken(bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = SourceExpressionConverter.ConvertToken(bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationId);
                    bodypropCount++;
                }

                if (bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = SourceExpressionConverter.ConvertToken(bodyroomRateAmount);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = SourceExpressionConverter.ConvertToken(bodyroomTypeId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = SourceExpressionConverter.ConvertToken(bodyspecialRequirement);
                    bodypropCount++;
                }

                if (bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectBookingResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateBookingResponse> CreateBooking([WorkflowExpression] Func<int> bodyentryId, [WorkflowExpression] Func<int> bodyadditionalOccupantCount = null, [WorkflowExpression] Func<string> bodyautoAllocationDetail = null, [WorkflowExpression] Func<bodybookingLinkTypeEnumInput> bodybookingLinkTypeEnum = null, [WorkflowExpression] Func<int> bodybookingTypeId = null, [WorkflowExpression] Func<string> bodycheckInDate = null, [WorkflowExpression] Func<string> bodycheckInDateActual = null, [WorkflowExpression] Func<string> bodycheckOutDate = null, [WorkflowExpression] Func<string> bodycheckOutDateActual = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycontractDateEnd = null, [WorkflowExpression] Func<string> bodycontractDateStart = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomDate3 = null, [WorkflowExpression] Func<string> bodycustomDate4 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodycustomString7 = null, [WorkflowExpression] Func<string> bodycustomString8 = null, [WorkflowExpression] Func<string> bodycustomString9 = null, [WorkflowExpression] Func<string> bodycustomString10 = null, [WorkflowExpression] Func<string> bodydateBilled = null, [WorkflowExpression] Func<string> bodydateChargedTo = null, [WorkflowExpression] Func<int> bodyemotionalSupportAnimalCount = null, [WorkflowExpression] Func<int> bodyendBookingReasonId = null, [WorkflowExpression] Func<int> bodyentryInvitationId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<string> bodyeTA = null, [WorkflowExpression] Func<string> bodyeTD = null, [WorkflowExpression] Func<double> bodyexcess = null, [WorkflowExpression] Func<int> bodygroupId = null, [WorkflowExpression] Func<int> bodyhousekeepingId = null, [WorkflowExpression] Func<int> bodynumberOfChildren = null, [WorkflowExpression] Func<int> bodynumberOfChildrenFree = null, [WorkflowExpression] Func<int> bodynumberOfGuests = null, [WorkflowExpression] Func<int> bodynumberOfGuestsFree = null, [WorkflowExpression] Func<string> bodypaidTo = null, [WorkflowExpression] Func<int> bodypetCount = null, [WorkflowExpression] Func<bool> bodyresvChargeToEntry = null, [WorkflowExpression] Func<bool> bodyroomLocationFixed = null, [WorkflowExpression] Func<int> bodyroomLocationId = null, [WorkflowExpression] Func<double> bodyroomRateAmount = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<int> bodyroomTypeId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodyserviceAnimalCount = null, [WorkflowExpression] Func<string> bodyspecialRequirement = null, [WorkflowExpression] Func<int> bodystartBookingReasonId = null, [WorkflowExpression] Func<int> bodytermSessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = SourceExpressionConverter.ConvertToken(bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = SourceExpressionConverter.ConvertToken(bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = SourceExpressionConverter.Convert(bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = SourceExpressionConverter.ConvertToken(bodybookingTypeId);
                    bodypropCount++;
                }

                if (bodycheckInDate != null)
                {
                    body["CheckInDate"] = SourceExpressionConverter.ConvertToken(bodycheckInDate);
                    bodypropCount++;
                }

                if (bodycheckInDateActual != null)
                {
                    body["CheckInDateActual"] = SourceExpressionConverter.ConvertToken(bodycheckInDateActual);
                    bodypropCount++;
                }

                if (bodycheckOutDate != null)
                {
                    body["CheckOutDate"] = SourceExpressionConverter.ConvertToken(bodycheckOutDate);
                    bodypropCount++;
                }

                if (bodycheckOutDateActual != null)
                {
                    body["CheckOutDateActual"] = SourceExpressionConverter.ConvertToken(bodycheckOutDateActual);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycontractDateEnd != null)
                {
                    body["ContractDateEnd"] = SourceExpressionConverter.ConvertToken(bodycontractDateEnd);
                    bodypropCount++;
                }

                if (bodycontractDateStart != null)
                {
                    body["ContractDateStart"] = SourceExpressionConverter.ConvertToken(bodycontractDateStart);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomDate3 != null)
                {
                    body["CustomDate3"] = SourceExpressionConverter.ConvertToken(bodycustomDate3);
                    bodypropCount++;
                }

                if (bodycustomDate4 != null)
                {
                    body["CustomDate4"] = SourceExpressionConverter.ConvertToken(bodycustomDate4);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodycustomString7 != null)
                {
                    body["CustomString7"] = SourceExpressionConverter.ConvertToken(bodycustomString7);
                    bodypropCount++;
                }

                if (bodycustomString8 != null)
                {
                    body["CustomString8"] = SourceExpressionConverter.ConvertToken(bodycustomString8);
                    bodypropCount++;
                }

                if (bodycustomString9 != null)
                {
                    body["CustomString9"] = SourceExpressionConverter.ConvertToken(bodycustomString9);
                    bodypropCount++;
                }

                if (bodycustomString10 != null)
                {
                    body["CustomString10"] = SourceExpressionConverter.ConvertToken(bodycustomString10);
                    bodypropCount++;
                }

                if (bodydateBilled != null)
                {
                    body["DateBilled"] = SourceExpressionConverter.ConvertToken(bodydateBilled);
                    bodypropCount++;
                }

                if (bodydateChargedTo != null)
                {
                    body["DateChargedTo"] = SourceExpressionConverter.ConvertToken(bodydateChargedTo);
                    bodypropCount++;
                }

                if (bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodyendBookingReasonId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                if (bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = SourceExpressionConverter.ConvertToken(bodyentryInvitationId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeTA != null)
                {
                    body["ETA"] = SourceExpressionConverter.ConvertToken(bodyeTA);
                    bodypropCount++;
                }

                if (bodyeTD != null)
                {
                    body["ETD"] = SourceExpressionConverter.ConvertToken(bodyeTD);
                    bodypropCount++;
                }

                if (bodyexcess != null)
                {
                    body["Excess"] = SourceExpressionConverter.ConvertToken(bodyexcess);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["GroupID"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = SourceExpressionConverter.ConvertToken(bodyhousekeepingId);
                    bodypropCount++;
                }

                if (bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildren);
                    bodypropCount++;
                }

                if (bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuests);
                    bodypropCount++;
                }

                if (bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                if (bodypaidTo != null)
                {
                    body["PaidTo"] = SourceExpressionConverter.ConvertToken(bodypaidTo);
                    bodypropCount++;
                }

                if (bodypetCount != null)
                {
                    body["PetCount"] = SourceExpressionConverter.ConvertToken(bodypetCount);
                    bodypropCount++;
                }

                if (bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = SourceExpressionConverter.ConvertToken(bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = SourceExpressionConverter.ConvertToken(bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationId);
                    bodypropCount++;
                }

                if (bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = SourceExpressionConverter.ConvertToken(bodyroomRateAmount);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = SourceExpressionConverter.ConvertToken(bodyroomTypeId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = SourceExpressionConverter.ConvertToken(bodyspecialRequirement);
                    bodypropCount++;
                }

                if (bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBookingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateBookingResponse> UpdateBooking([WorkflowExpression] Func<int> bookingId, [WorkflowExpression] Func<int> bodyadditionalOccupantCount = null, [WorkflowExpression] Func<string> bodyautoAllocationDetail = null, [WorkflowExpression] Func<bodybookingLinkTypeEnumInput> bodybookingLinkTypeEnum = null, [WorkflowExpression] Func<int> bodybookingTypeId = null, [WorkflowExpression] Func<string> bodycheckInDate = null, [WorkflowExpression] Func<string> bodycheckInDateActual = null, [WorkflowExpression] Func<string> bodycheckOutDate = null, [WorkflowExpression] Func<string> bodycheckOutDateActual = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodycontractDateEnd = null, [WorkflowExpression] Func<string> bodycontractDateStart = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<bool> bodycustomBit3 = null, [WorkflowExpression] Func<bool> bodycustomBit4 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomDate3 = null, [WorkflowExpression] Func<string> bodycustomDate4 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodycustomString7 = null, [WorkflowExpression] Func<string> bodycustomString8 = null, [WorkflowExpression] Func<string> bodycustomString9 = null, [WorkflowExpression] Func<string> bodycustomString10 = null, [WorkflowExpression] Func<string> bodydateBilled = null, [WorkflowExpression] Func<string> bodydateChargedTo = null, [WorkflowExpression] Func<int> bodyemotionalSupportAnimalCount = null, [WorkflowExpression] Func<int> bodyendBookingReasonId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<int> bodyentryInvitationId = null, [WorkflowExpression] Func<bodyentryStatusEnumInput> bodyentryStatusEnum = null, [WorkflowExpression] Func<string> bodyeTA = null, [WorkflowExpression] Func<string> bodyeTD = null, [WorkflowExpression] Func<double> bodyexcess = null, [WorkflowExpression] Func<int> bodygroupId = null, [WorkflowExpression] Func<int> bodyhousekeepingId = null, [WorkflowExpression] Func<int> bodynumberOfChildren = null, [WorkflowExpression] Func<int> bodynumberOfChildrenFree = null, [WorkflowExpression] Func<int> bodynumberOfGuests = null, [WorkflowExpression] Func<int> bodynumberOfGuestsFree = null, [WorkflowExpression] Func<string> bodypaidTo = null, [WorkflowExpression] Func<int> bodypetCount = null, [WorkflowExpression] Func<bool> bodyresvChargeToEntry = null, [WorkflowExpression] Func<bool> bodyroomLocationFixed = null, [WorkflowExpression] Func<int> bodyroomLocationId = null, [WorkflowExpression] Func<double> bodyroomRateAmount = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<int> bodyroomTypeId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodyserviceAnimalCount = null, [WorkflowExpression] Func<string> bodyspecialRequirement = null, [WorkflowExpression] Func<int> bodystartBookingReasonId = null, [WorkflowExpression] Func<int> bodytermSessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/booking.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(bookingId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadditionalOccupantCount != null)
                {
                    body["AdditionalOccupantCount"] = SourceExpressionConverter.ConvertToken(bodyadditionalOccupantCount);
                    bodypropCount++;
                }

                if (bodyautoAllocationDetail != null)
                {
                    body["AutoAllocationDetail"] = SourceExpressionConverter.ConvertToken(bodyautoAllocationDetail);
                    bodypropCount++;
                }

                if (bodybookingLinkTypeEnum != null)
                {
                    body["BookingLinkTypeEnum"] = SourceExpressionConverter.Convert(bodybookingLinkTypeEnum);
                    bodypropCount++;
                }

                if (bodybookingTypeId != null)
                {
                    body["BookingTypeID"] = SourceExpressionConverter.ConvertToken(bodybookingTypeId);
                    bodypropCount++;
                }

                if (bodycheckInDate != null)
                {
                    body["CheckInDate"] = SourceExpressionConverter.ConvertToken(bodycheckInDate);
                    bodypropCount++;
                }

                if (bodycheckInDateActual != null)
                {
                    body["CheckInDateActual"] = SourceExpressionConverter.ConvertToken(bodycheckInDateActual);
                    bodypropCount++;
                }

                if (bodycheckOutDate != null)
                {
                    body["CheckOutDate"] = SourceExpressionConverter.ConvertToken(bodycheckOutDate);
                    bodypropCount++;
                }

                if (bodycheckOutDateActual != null)
                {
                    body["CheckOutDateActual"] = SourceExpressionConverter.ConvertToken(bodycheckOutDateActual);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycontractDateEnd != null)
                {
                    body["ContractDateEnd"] = SourceExpressionConverter.ConvertToken(bodycontractDateEnd);
                    bodypropCount++;
                }

                if (bodycontractDateStart != null)
                {
                    body["ContractDateStart"] = SourceExpressionConverter.ConvertToken(bodycontractDateStart);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomBit3 != null)
                {
                    body["CustomBit3"] = SourceExpressionConverter.ConvertToken(bodycustomBit3);
                    bodypropCount++;
                }

                if (bodycustomBit4 != null)
                {
                    body["CustomBit4"] = SourceExpressionConverter.ConvertToken(bodycustomBit4);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomDate3 != null)
                {
                    body["CustomDate3"] = SourceExpressionConverter.ConvertToken(bodycustomDate3);
                    bodypropCount++;
                }

                if (bodycustomDate4 != null)
                {
                    body["CustomDate4"] = SourceExpressionConverter.ConvertToken(bodycustomDate4);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodycustomString7 != null)
                {
                    body["CustomString7"] = SourceExpressionConverter.ConvertToken(bodycustomString7);
                    bodypropCount++;
                }

                if (bodycustomString8 != null)
                {
                    body["CustomString8"] = SourceExpressionConverter.ConvertToken(bodycustomString8);
                    bodypropCount++;
                }

                if (bodycustomString9 != null)
                {
                    body["CustomString9"] = SourceExpressionConverter.ConvertToken(bodycustomString9);
                    bodypropCount++;
                }

                if (bodycustomString10 != null)
                {
                    body["CustomString10"] = SourceExpressionConverter.ConvertToken(bodycustomString10);
                    bodypropCount++;
                }

                if (bodydateBilled != null)
                {
                    body["DateBilled"] = SourceExpressionConverter.ConvertToken(bodydateBilled);
                    bodypropCount++;
                }

                if (bodydateChargedTo != null)
                {
                    body["DateChargedTo"] = SourceExpressionConverter.ConvertToken(bodydateChargedTo);
                    bodypropCount++;
                }

                if (bodyemotionalSupportAnimalCount != null)
                {
                    body["EmotionalSupportAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyemotionalSupportAnimalCount);
                    bodypropCount++;
                }

                if (bodyendBookingReasonId != null)
                {
                    body["End_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodyendBookingReasonId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyentryInvitationId != null)
                {
                    body["EntryInvitationID"] = SourceExpressionConverter.ConvertToken(bodyentryInvitationId);
                    bodypropCount++;
                }

                if (bodyentryStatusEnum != null)
                {
                    body["EntryStatusEnum"] = SourceExpressionConverter.Convert(bodyentryStatusEnum);
                    bodypropCount++;
                }

                if (bodyeTA != null)
                {
                    body["ETA"] = SourceExpressionConverter.ConvertToken(bodyeTA);
                    bodypropCount++;
                }

                if (bodyeTD != null)
                {
                    body["ETD"] = SourceExpressionConverter.ConvertToken(bodyeTD);
                    bodypropCount++;
                }

                if (bodyexcess != null)
                {
                    body["Excess"] = SourceExpressionConverter.ConvertToken(bodyexcess);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["GroupID"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyhousekeepingId != null)
                {
                    body["HousekeepingID"] = SourceExpressionConverter.ConvertToken(bodyhousekeepingId);
                    bodypropCount++;
                }

                if (bodynumberOfChildren != null)
                {
                    body["NumberOfChildren"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildren);
                    bodypropCount++;
                }

                if (bodynumberOfChildrenFree != null)
                {
                    body["NumberOfChildrenFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfChildrenFree);
                    bodypropCount++;
                }

                if (bodynumberOfGuests != null)
                {
                    body["NumberOfGuests"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuests);
                    bodypropCount++;
                }

                if (bodynumberOfGuestsFree != null)
                {
                    body["NumberOfGuestsFree"] = SourceExpressionConverter.ConvertToken(bodynumberOfGuestsFree);
                    bodypropCount++;
                }

                if (bodypaidTo != null)
                {
                    body["PaidTo"] = SourceExpressionConverter.ConvertToken(bodypaidTo);
                    bodypropCount++;
                }

                if (bodypetCount != null)
                {
                    body["PetCount"] = SourceExpressionConverter.ConvertToken(bodypetCount);
                    bodypropCount++;
                }

                if (bodyresvChargeToEntry != null)
                {
                    body["ResvChargeToEntry"] = SourceExpressionConverter.ConvertToken(bodyresvChargeToEntry);
                    bodypropCount++;
                }

                if (bodyroomLocationFixed != null)
                {
                    body["RoomLocationFixed"] = SourceExpressionConverter.ConvertToken(bodyroomLocationFixed);
                    bodypropCount++;
                }

                if (bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationId);
                    bodypropCount++;
                }

                if (bodyroomRateAmount != null)
                {
                    body["RoomRateAmount"] = SourceExpressionConverter.ConvertToken(bodyroomRateAmount);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomTypeId != null)
                {
                    body["RoomTypeID"] = SourceExpressionConverter.ConvertToken(bodyroomTypeId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodyserviceAnimalCount != null)
                {
                    body["ServiceAnimalCount"] = SourceExpressionConverter.ConvertToken(bodyserviceAnimalCount);
                    bodypropCount++;
                }

                if (bodyspecialRequirement != null)
                {
                    body["SpecialRequirement"] = SourceExpressionConverter.ConvertToken(bodyspecialRequirement);
                    bodypropCount++;
                }

                if (bodystartBookingReasonId != null)
                {
                    body["Start_BookingReasonID"] = SourceExpressionConverter.ConvertToken(bodystartBookingReasonId);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateBookingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceResponseItem[]> SelectRoomSpace([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<bool> bodyallocateExclude = null, [WorkflowExpression] Func<int> bodyallocateSortOrder = null, [WorkflowExpression] Func<int> bodybathrooms = null, [WorkflowExpression] Func<int> bodybedCapacity = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyextensionId = null, [WorkflowExpression] Func<bool> bodyhold = null, [WorkflowExpression] Func<bool> bodynetworked = null, [WorkflowExpression] Func<bodyrecordTypeEnumInput> bodyrecordTypeEnum = null, [WorkflowExpression] Func<int> bodyroomBaseId = null, [WorkflowExpression] Func<int> bodyroomId = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<bodyroomSpaceTypeEnumInput> bodyroomSpaceTypeEnum = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodysortOrder = null, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodystreet2 = null, [WorkflowExpression] Func<string> bodywebDescription = null, [WorkflowExpression] Func<string> bodyzipPostcode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/RoomSpace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyallocateExclude != null)
                {
                    body["AllocateExclude"] = SourceExpressionConverter.ConvertToken(bodyallocateExclude);
                    bodypropCount++;
                }

                if (bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = SourceExpressionConverter.ConvertToken(bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (bodybathrooms != null)
                {
                    body["Bathrooms"] = SourceExpressionConverter.ConvertToken(bodybathrooms);
                    bodypropCount++;
                }

                if (bodybedCapacity != null)
                {
                    body["BedCapacity"] = SourceExpressionConverter.ConvertToken(bodybedCapacity);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyextensionId != null)
                {
                    body["ExtensionID"] = SourceExpressionConverter.ConvertToken(bodyextensionId);
                    bodypropCount++;
                }

                if (bodyhold != null)
                {
                    body["Hold"] = SourceExpressionConverter.ConvertToken(bodyhold);
                    bodypropCount++;
                }

                if (bodynetworked != null)
                {
                    body["Networked"] = SourceExpressionConverter.ConvertToken(bodynetworked);
                    bodypropCount++;
                }

                if (bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = SourceExpressionConverter.Convert(bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (bodyroomBaseId != null)
                {
                    body["RoomBaseID"] = SourceExpressionConverter.ConvertToken(bodyroomBaseId);
                    bodypropCount++;
                }

                if (bodyroomId != null)
                {
                    body["RoomID"] = SourceExpressionConverter.ConvertToken(bodyroomId);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomSpaceTypeEnum != null)
                {
                    body["RoomSpaceTypeEnum"] = SourceExpressionConverter.Convert(bodyroomSpaceTypeEnum);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["SortOrder"] = SourceExpressionConverter.ConvertToken(bodysortOrder);
                    bodypropCount++;
                }

                if (bodystreet != null)
                {
                    body["Street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodystreet2 != null)
                {
                    body["Street2"] = SourceExpressionConverter.ConvertToken(bodystreet2);
                    bodypropCount++;
                }

                if (bodywebDescription != null)
                {
                    body["WebDescription"] = SourceExpressionConverter.ConvertToken(bodywebDescription);
                    bodypropCount++;
                }

                if (bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = SourceExpressionConverter.ConvertToken(bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectRoomSpaceResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceResponse> CreateRoomSpace([WorkflowExpression] Func<bool> bodyallocateExclude = null, [WorkflowExpression] Func<int> bodyallocateSortOrder = null, [WorkflowExpression] Func<int> bodybathrooms = null, [WorkflowExpression] Func<int> bodybedCapacity = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyextensionId = null, [WorkflowExpression] Func<bool> bodyhold = null, [WorkflowExpression] Func<bool> bodynetworked = null, [WorkflowExpression] Func<bodyrecordTypeEnumInput> bodyrecordTypeEnum = null, [WorkflowExpression] Func<int> bodyroomBaseId = null, [WorkflowExpression] Func<int> bodyroomId = null, [WorkflowExpression] Func<int> bodyroomRateId = null, [WorkflowExpression] Func<bodyroomSpaceTypeEnumInput> bodyroomSpaceTypeEnum = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodysortOrder = null, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodystreet2 = null, [WorkflowExpression] Func<string> bodywebDescription = null, [WorkflowExpression] Func<string> bodyzipPostcode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/roomspace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyallocateExclude != null)
                {
                    body["AllocateExclude"] = SourceExpressionConverter.ConvertToken(bodyallocateExclude);
                    bodypropCount++;
                }

                if (bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = SourceExpressionConverter.ConvertToken(bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (bodybathrooms != null)
                {
                    body["Bathrooms"] = SourceExpressionConverter.ConvertToken(bodybathrooms);
                    bodypropCount++;
                }

                if (bodybedCapacity != null)
                {
                    body["BedCapacity"] = SourceExpressionConverter.ConvertToken(bodybedCapacity);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyextensionId != null)
                {
                    body["ExtensionID"] = SourceExpressionConverter.ConvertToken(bodyextensionId);
                    bodypropCount++;
                }

                if (bodyhold != null)
                {
                    body["Hold"] = SourceExpressionConverter.ConvertToken(bodyhold);
                    bodypropCount++;
                }

                if (bodynetworked != null)
                {
                    body["Networked"] = SourceExpressionConverter.ConvertToken(bodynetworked);
                    bodypropCount++;
                }

                if (bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = SourceExpressionConverter.Convert(bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (bodyroomBaseId != null)
                {
                    body["RoomBaseID"] = SourceExpressionConverter.ConvertToken(bodyroomBaseId);
                    bodypropCount++;
                }

                if (bodyroomId != null)
                {
                    body["RoomID"] = SourceExpressionConverter.ConvertToken(bodyroomId);
                    bodypropCount++;
                }

                if (bodyroomRateId != null)
                {
                    body["RoomRateID"] = SourceExpressionConverter.ConvertToken(bodyroomRateId);
                    bodypropCount++;
                }

                if (bodyroomSpaceTypeEnum != null)
                {
                    body["RoomSpaceTypeEnum"] = SourceExpressionConverter.Convert(bodyroomSpaceTypeEnum);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    body["SortOrder"] = SourceExpressionConverter.ConvertToken(bodysortOrder);
                    bodypropCount++;
                }

                if (bodystreet != null)
                {
                    body["Street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                if (bodystreet2 != null)
                {
                    body["Street2"] = SourceExpressionConverter.ConvertToken(bodystreet2);
                    bodypropCount++;
                }

                if (bodywebDescription != null)
                {
                    body["WebDescription"] = SourceExpressionConverter.ConvertToken(bodywebDescription);
                    bodypropCount++;
                }

                if (bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = SourceExpressionConverter.ConvertToken(bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateRoomSpaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomLocationResponseItem[]> SelectRoomLocation([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<int> bodyallocateSortOrder = null, [WorkflowExpression] Func<int> bodycategoryId = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycountryId = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodygenderTypeEnumInput> bodygenderTypeEnum = null, [WorkflowExpression] Func<bool> bodylease = null, [WorkflowExpression] Func<bool> bodymanagedExternally = null, [WorkflowExpression] Func<bool> bodynonResidential = null, [WorkflowExpression] Func<bodyrecordTypeEnumInput> bodyrecordTypeEnum = null, [WorkflowExpression] Func<int> bodyroomLocationAreaId = null, [WorkflowExpression] Func<int> bodyroomLocationId = null, [WorkflowExpression] Func<string> bodystateProvince = null, [WorkflowExpression] Func<bool> bodyviewOnWeb = null, [WorkflowExpression] Func<string> bodywebComments = null, [WorkflowExpression] Func<string> bodywebDescription = null, [WorkflowExpression] Func<string> bodywebImageAltText = null, [WorkflowExpression] Func<string> bodywebImageLocation = null, [WorkflowExpression] Func<string> bodyzipPostcode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/RoomLocation.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyallocateSortOrder != null)
                {
                    body["AllocateSortOrder"] = SourceExpressionConverter.ConvertToken(bodyallocateSortOrder);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["CategoryID"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycountryId != null)
                {
                    body["CountryID"] = SourceExpressionConverter.ConvertToken(bodycountryId);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodygenderTypeEnum != null)
                {
                    body["GenderTypeEnum"] = SourceExpressionConverter.Convert(bodygenderTypeEnum);
                    bodypropCount++;
                }

                if (bodylease != null)
                {
                    body["Lease"] = SourceExpressionConverter.ConvertToken(bodylease);
                    bodypropCount++;
                }

                if (bodymanagedExternally != null)
                {
                    body["ManagedExternally"] = SourceExpressionConverter.ConvertToken(bodymanagedExternally);
                    bodypropCount++;
                }

                if (bodynonResidential != null)
                {
                    body["NonResidential"] = SourceExpressionConverter.ConvertToken(bodynonResidential);
                    bodypropCount++;
                }

                if (bodyrecordTypeEnum != null)
                {
                    body["RecordTypeEnum"] = SourceExpressionConverter.Convert(bodyrecordTypeEnum);
                    bodypropCount++;
                }

                if (bodyroomLocationAreaId != null)
                {
                    body["RoomLocationAreaID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationAreaId);
                    bodypropCount++;
                }

                if (bodyroomLocationId != null)
                {
                    body["RoomLocationID"] = SourceExpressionConverter.ConvertToken(bodyroomLocationId);
                    bodypropCount++;
                }

                if (bodystateProvince != null)
                {
                    body["StateProvince"] = SourceExpressionConverter.ConvertToken(bodystateProvince);
                    bodypropCount++;
                }

                if (bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = SourceExpressionConverter.ConvertToken(bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodywebComments != null)
                {
                    body["WebComments"] = SourceExpressionConverter.ConvertToken(bodywebComments);
                    bodypropCount++;
                }

                if (bodywebDescription != null)
                {
                    body["WebDescription"] = SourceExpressionConverter.ConvertToken(bodywebDescription);
                    bodypropCount++;
                }

                if (bodywebImageAltText != null)
                {
                    body["WebImageAltText"] = SourceExpressionConverter.ConvertToken(bodywebImageAltText);
                    bodypropCount++;
                }

                if (bodywebImageLocation != null)
                {
                    body["WebImageLocation"] = SourceExpressionConverter.ConvertToken(bodywebImageLocation);
                    bodypropCount++;
                }

                if (bodyzipPostcode != null)
                {
                    body["ZipPostcode"] = SourceExpressionConverter.ConvertToken(bodyzipPostcode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectRoomLocationResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTransactionResponseItem[]> SelectTransaction([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<bodycallTypeEnumInput> bodycallTypeEnum = null, [WorkflowExpression] Func<int> bodychargeGroupId = null, [WorkflowExpression] Func<int> bodychargeItemId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodycreatedBySecurityUserId = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDatevalue = null, [WorkflowExpression] Func<bodydueDateOperatorInput> bodydueDateOperator = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<int> bodyendOfSessionId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<double> bodyexcess = null, [WorkflowExpression] Func<int> bodyextension = null, [WorkflowExpression] Func<int> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalReceiptId = null, [WorkflowExpression] Func<int> bodyinvoiceId = null, [WorkflowExpression] Func<string> bodypaidFromvalue = null, [WorkflowExpression] Func<bodypaidFromOperatorInput> bodypaidFromOperator = null, [WorkflowExpression] Func<string> bodypaidTovalue = null, [WorkflowExpression] Func<bodypaidToOperatorInput> bodypaidToOperator = null, [WorkflowExpression] Func<int> bodypaymentId = null, [WorkflowExpression] Func<string> bodyprocessedDatevalue = null, [WorkflowExpression] Func<bodyprocessedDateOperatorInput> bodyprocessedDateOperator = null, [WorkflowExpression] Func<int> bodyreferenceBookingId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodytableId = null, [WorkflowExpression] Func<string> bodytableName = null, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodytagFinance = null, [WorkflowExpression] Func<double> bodytaxAmount = null, [WorkflowExpression] Func<double> bodytaxAmount2 = null, [WorkflowExpression] Func<double> bodytaxAmount3 = null, [WorkflowExpression] Func<int> bodytermSessionId = null, [WorkflowExpression] Func<string> bodytransactionDatevalue = null, [WorkflowExpression] Func<bodytransactionDateOperatorInput> bodytransactionDateOperator = null, [WorkflowExpression] Func<int> bodytransactionId = null, [WorkflowExpression] Func<bodytransactionTypeEnumInput> bodytransactionTypeEnum = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/Transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["Amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodycallTypeEnum != null)
                {
                    body["CallTypeEnum"] = SourceExpressionConverter.Convert(bodycallTypeEnum);
                    bodypropCount++;
                }

                if (bodychargeGroupId != null)
                {
                    body["ChargeGroupID"] = SourceExpressionConverter.ConvertToken(bodychargeGroupId);
                    bodypropCount++;
                }

                if (bodychargeItemId != null)
                {
                    body["ChargeItemID"] = SourceExpressionConverter.ConvertToken(bodychargeItemId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var dueDateObject = new JObject();
                var dueDateObjectpropCount = 0;
                if (bodydueDatevalue != null)
                {
                    dueDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodydueDatevalue);
                    dueDateObjectpropCount++;
                }

                if (bodydueDateOperator != null)
                {
                    dueDateObject["_operator"] = SourceExpressionConverter.Convert(bodydueDateOperator);
                    dueDateObjectpropCount++;
                }

                if (dueDateObjectpropCount > 0)
                {
                    body["DueDate"] = dueDateObject;
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["Duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodyendOfSessionId != null)
                {
                    body["EndOfSessionID"] = SourceExpressionConverter.ConvertToken(bodyendOfSessionId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyexcess != null)
                {
                    body["Excess"] = SourceExpressionConverter.ConvertToken(bodyexcess);
                    bodypropCount++;
                }

                if (bodyextension != null)
                {
                    body["Extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["ExternalID"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalReceiptId != null)
                {
                    body["ExternalReceiptID"] = SourceExpressionConverter.ConvertToken(bodyexternalReceiptId);
                    bodypropCount++;
                }

                if (bodyinvoiceId != null)
                {
                    body["InvoiceID"] = SourceExpressionConverter.ConvertToken(bodyinvoiceId);
                    bodypropCount++;
                }

                var paidFromObject = new JObject();
                var paidFromObjectpropCount = 0;
                if (bodypaidFromvalue != null)
                {
                    paidFromObject["Value"] = SourceExpressionConverter.ConvertToken(bodypaidFromvalue);
                    paidFromObjectpropCount++;
                }

                if (bodypaidFromOperator != null)
                {
                    paidFromObject["_operator"] = SourceExpressionConverter.Convert(bodypaidFromOperator);
                    paidFromObjectpropCount++;
                }

                if (paidFromObjectpropCount > 0)
                {
                    body["PaidFrom"] = paidFromObject;
                    bodypropCount++;
                }

                var paidToObject = new JObject();
                var paidToObjectpropCount = 0;
                if (bodypaidTovalue != null)
                {
                    paidToObject["Value"] = SourceExpressionConverter.ConvertToken(bodypaidTovalue);
                    paidToObjectpropCount++;
                }

                if (bodypaidToOperator != null)
                {
                    paidToObject["_operator"] = SourceExpressionConverter.Convert(bodypaidToOperator);
                    paidToObjectpropCount++;
                }

                if (paidToObjectpropCount > 0)
                {
                    body["PaidTo"] = paidToObject;
                    bodypropCount++;
                }

                if (bodypaymentId != null)
                {
                    body["PaymentID"] = SourceExpressionConverter.ConvertToken(bodypaymentId);
                    bodypropCount++;
                }

                var processedDateObject = new JObject();
                var processedDateObjectpropCount = 0;
                if (bodyprocessedDatevalue != null)
                {
                    processedDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodyprocessedDatevalue);
                    processedDateObjectpropCount++;
                }

                if (bodyprocessedDateOperator != null)
                {
                    processedDateObject["_operator"] = SourceExpressionConverter.Convert(bodyprocessedDateOperator);
                    processedDateObjectpropCount++;
                }

                if (processedDateObjectpropCount > 0)
                {
                    body["ProcessedDate"] = processedDateObject;
                    bodypropCount++;
                }

                if (bodyreferenceBookingId != null)
                {
                    body["Reference_BookingID"] = SourceExpressionConverter.ConvertToken(bodyreferenceBookingId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodytableId != null)
                {
                    body["TableID"] = SourceExpressionConverter.ConvertToken(bodytableId);
                    bodypropCount++;
                }

                if (bodytableName != null)
                {
                    body["TableName"] = SourceExpressionConverter.ConvertToken(bodytableName);
                    bodypropCount++;
                }

                if (bodytag != null)
                {
                    body["Tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                    bodypropCount++;
                }

                if (bodytagFinance != null)
                {
                    body["TagFinance"] = SourceExpressionConverter.ConvertToken(bodytagFinance);
                    bodypropCount++;
                }

                if (bodytaxAmount != null)
                {
                    body["TaxAmount"] = SourceExpressionConverter.ConvertToken(bodytaxAmount);
                    bodypropCount++;
                }

                if (bodytaxAmount2 != null)
                {
                    body["TaxAmount2"] = SourceExpressionConverter.ConvertToken(bodytaxAmount2);
                    bodypropCount++;
                }

                if (bodytaxAmount3 != null)
                {
                    body["TaxAmount3"] = SourceExpressionConverter.ConvertToken(bodytaxAmount3);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                var transactionDateObject = new JObject();
                var transactionDateObjectpropCount = 0;
                if (bodytransactionDatevalue != null)
                {
                    transactionDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodytransactionDatevalue);
                    transactionDateObjectpropCount++;
                }

                if (bodytransactionDateOperator != null)
                {
                    transactionDateObject["_operator"] = SourceExpressionConverter.Convert(bodytransactionDateOperator);
                    transactionDateObjectpropCount++;
                }

                if (transactionDateObjectpropCount > 0)
                {
                    body["TransactionDate"] = transactionDateObject;
                    bodypropCount++;
                }

                if (bodytransactionId != null)
                {
                    body["TransactionID"] = SourceExpressionConverter.ConvertToken(bodytransactionId);
                    bodypropCount++;
                }

                if (bodytransactionTypeEnum != null)
                {
                    body["TransactionTypeEnum"] = SourceExpressionConverter.Convert(bodytransactionTypeEnum);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectTransactionResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateTransactionResponse> CreateTransaction([WorkflowExpression] Func<double> bodyamount, [WorkflowExpression] Func<int> bodychargeGroupId, [WorkflowExpression] Func<bodycallTypeEnumInput> bodycallTypeEnum = null, [WorkflowExpression] Func<int> bodychargeItemId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<int> bodyendOfSessionId = null, [WorkflowExpression] Func<int> bodyentryId = null, [WorkflowExpression] Func<double> bodyexcess = null, [WorkflowExpression] Func<int> bodyextension = null, [WorkflowExpression] Func<int> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalReceiptId = null, [WorkflowExpression] Func<int> bodyinvoiceId = null, [WorkflowExpression] Func<string> bodypaidFrom = null, [WorkflowExpression] Func<string> bodypaidTo = null, [WorkflowExpression] Func<int> bodypaymentId = null, [WorkflowExpression] Func<string> bodyprocessedDate = null, [WorkflowExpression] Func<int> bodyreferenceBookingId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<int> bodytableId = null, [WorkflowExpression] Func<string> bodytableName = null, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodytagFinance = null, [WorkflowExpression] Func<double> bodytaxAmount = null, [WorkflowExpression] Func<double> bodytaxAmount2 = null, [WorkflowExpression] Func<double> bodytaxAmount3 = null, [WorkflowExpression] Func<int> bodytermSessionId = null, [WorkflowExpression] Func<string> bodytransactionDate = null, [WorkflowExpression] Func<bodytransactionTypeEnumInput> bodytransactionTypeEnum = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                if (bodycallTypeEnum != null)
                {
                    body["CallTypeEnum"] = SourceExpressionConverter.Convert(bodycallTypeEnum);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ChargeGroupID"] = SourceExpressionConverter.ConvertToken(bodychargeGroupId);
                if (bodychargeItemId != null)
                {
                    body["ChargeItemID"] = SourceExpressionConverter.ConvertToken(bodychargeItemId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["Comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["DueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["Duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodyendOfSessionId != null)
                {
                    body["EndOfSessionID"] = SourceExpressionConverter.ConvertToken(bodyendOfSessionId);
                    bodypropCount++;
                }

                if (bodyentryId != null)
                {
                    body["EntryID"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyexcess != null)
                {
                    body["Excess"] = SourceExpressionConverter.ConvertToken(bodyexcess);
                    bodypropCount++;
                }

                if (bodyextension != null)
                {
                    body["Extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["ExternalID"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalReceiptId != null)
                {
                    body["ExternalReceiptID"] = SourceExpressionConverter.ConvertToken(bodyexternalReceiptId);
                    bodypropCount++;
                }

                if (bodyinvoiceId != null)
                {
                    body["InvoiceID"] = SourceExpressionConverter.ConvertToken(bodyinvoiceId);
                    bodypropCount++;
                }

                if (bodypaidFrom != null)
                {
                    body["PaidFrom"] = SourceExpressionConverter.ConvertToken(bodypaidFrom);
                    bodypropCount++;
                }

                if (bodypaidTo != null)
                {
                    body["PaidTo"] = SourceExpressionConverter.ConvertToken(bodypaidTo);
                    bodypropCount++;
                }

                if (bodypaymentId != null)
                {
                    body["PaymentID"] = SourceExpressionConverter.ConvertToken(bodypaymentId);
                    bodypropCount++;
                }

                if (bodyprocessedDate != null)
                {
                    body["ProcessedDate"] = SourceExpressionConverter.ConvertToken(bodyprocessedDate);
                    bodypropCount++;
                }

                if (bodyreferenceBookingId != null)
                {
                    body["Reference_BookingID"] = SourceExpressionConverter.ConvertToken(bodyreferenceBookingId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodytableId != null)
                {
                    body["TableID"] = SourceExpressionConverter.ConvertToken(bodytableId);
                    bodypropCount++;
                }

                if (bodytableName != null)
                {
                    body["TableName"] = SourceExpressionConverter.ConvertToken(bodytableName);
                    bodypropCount++;
                }

                if (bodytag != null)
                {
                    body["Tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                    bodypropCount++;
                }

                if (bodytagFinance != null)
                {
                    body["TagFinance"] = SourceExpressionConverter.ConvertToken(bodytagFinance);
                    bodypropCount++;
                }

                if (bodytaxAmount != null)
                {
                    body["TaxAmount"] = SourceExpressionConverter.ConvertToken(bodytaxAmount);
                    bodypropCount++;
                }

                if (bodytaxAmount2 != null)
                {
                    body["TaxAmount2"] = SourceExpressionConverter.ConvertToken(bodytaxAmount2);
                    bodypropCount++;
                }

                if (bodytaxAmount3 != null)
                {
                    body["TaxAmount3"] = SourceExpressionConverter.ConvertToken(bodytaxAmount3);
                    bodypropCount++;
                }

                if (bodytermSessionId != null)
                {
                    body["TermSessionID"] = SourceExpressionConverter.ConvertToken(bodytermSessionId);
                    bodypropCount++;
                }

                if (bodytransactionDate != null)
                {
                    body["TransactionDate"] = SourceExpressionConverter.ConvertToken(bodytransactionDate);
                    bodypropCount++;
                }

                if (bodytransactionTypeEnum != null)
                {
                    body["TransactionTypeEnum"] = SourceExpressionConverter.Convert(bodytransactionTypeEnum);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTransactionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceMaintenanceResponseItem[]> SelectRoomSpaceMaintenance([WorkflowExpression] Func<bodyPageSizeInput> bodyPageSize, [WorkflowExpression] Func<int> bodyPageIndex, [WorkflowExpression] Func<bool> bodyReturnEmptyArrayOnNoResult = null, [WorkflowExpression] Func<string> bodyOrderby = null, [WorkflowExpression] Func<string> bodyaccountCode = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<bool> bodycharge = null, [WorkflowExpression] Func<int> bodychargeEntryId = null, [WorkflowExpression] Func<double> bodychargeAmount = null, [WorkflowExpression] Func<bool> bodychargeInvoiced = null, [WorkflowExpression] Func<string> bodychargeInvoiceNumber = null, [WorkflowExpression] Func<string> bodychargeType = null, [WorkflowExpression] Func<string> bodycompleteDatevalue = null, [WorkflowExpression] Func<bodycompleteDateOperatorInput> bodycompleteDateOperator = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<string> bodycontractDatevalue = null, [WorkflowExpression] Func<bodycontractDateOperatorInput> bodycontractDateOperator = null, [WorkflowExpression] Func<double> bodycontractorCost = null, [WorkflowExpression] Func<double> bodycontractorCostEstimate = null, [WorkflowExpression] Func<string> bodycontractorDatevalue = null, [WorkflowExpression] Func<bodycontractorDateOperatorInput> bodycontractorDateOperator = null, [WorkflowExpression] Func<string> bodycontractorETA = null, [WorkflowExpression] Func<string> bodycontractorOrderNumber = null, [WorkflowExpression] Func<int> bodycreatedBySecurityUserId = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1value = null, [WorkflowExpression] Func<bodycustomDate1OperatorInput> bodycustomDate1Operator = null, [WorkflowExpression] Func<string> bodycustomDate2value = null, [WorkflowExpression] Func<bodycustomDate2OperatorInput> bodycustomDate2Operator = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateCreatedvalue = null, [WorkflowExpression] Func<bodydateCreatedOperatorInput> bodydateCreatedOperator = null, [WorkflowExpression] Func<string> bodydateDuevalue = null, [WorkflowExpression] Func<bodydateDueOperatorInput> bodydateDueOperator = null, [WorkflowExpression] Func<string> bodydateModifiedvalue = null, [WorkflowExpression] Func<bodydateModifiedOperatorInput> bodydateModifiedOperator = null, [WorkflowExpression] Func<string> bodydateReportedvalue = null, [WorkflowExpression] Func<bodydateReportedOperatorInput> bodydateReportedOperator = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyjobSent = null, [WorkflowExpression] Func<string> bodyjobStatus = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<int> bodyoccupantEntryId = null, [WorkflowExpression] Func<string> bodyoccupantEntryName = null, [WorkflowExpression] Func<bool> bodyoccupantPresent = null, [WorkflowExpression] Func<string> bodyoccupantPresentReason = null, [WorkflowExpression] Func<string> bodyotherServiceNumber = null, [WorkflowExpression] Func<int> bodypriorityId = null, [WorkflowExpression] Func<string> bodyrepairDescription = null, [WorkflowExpression] Func<string> bodyreportedByName = null, [WorkflowExpression] Func<string> bodyreportedByPhone = null, [WorkflowExpression] Func<int> bodyroomSpaceClosedId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceCategoryId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceItemId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<string> bodystartDatevalue = null, [WorkflowExpression] Func<bodystartDateOperatorInput> bodystartDateOperator = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytechnician = null, [WorkflowExpression] Func<bool> bodyviewOnWeb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/select/RoomSpaceMaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyReturnEmptyArrayOnNoResult != null)
                {
                    if (bodyReturnEmptyArrayOnNoResult != null)
                    {
                        body["_returnEmptyArrayOnNoResult"] = SourceExpressionConverter.ConvertToken(bodyReturnEmptyArrayOnNoResult);
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
                body["_pageSize"] = SourceExpressionConverter.Convert(bodyPageSize);
                bodypropCount++;
                body["_pageIndex"] = SourceExpressionConverter.ConvertToken(bodyPageIndex);
                if (bodyOrderby != null)
                {
                    body["_orderby"] = SourceExpressionConverter.ConvertToken(bodyOrderby);
                    bodypropCount++;
                }

                if (bodyaccountCode != null)
                {
                    body["AccountCode"] = SourceExpressionConverter.ConvertToken(bodyaccountCode);
                    bodypropCount++;
                }

                if (bodycause != null)
                {
                    body["Cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                    bodypropCount++;
                }

                if (bodycharge != null)
                {
                    body["Charge"] = SourceExpressionConverter.ConvertToken(bodycharge);
                    bodypropCount++;
                }

                if (bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = SourceExpressionConverter.ConvertToken(bodychargeEntryId);
                    bodypropCount++;
                }

                if (bodychargeAmount != null)
                {
                    body["ChargeAmount"] = SourceExpressionConverter.ConvertToken(bodychargeAmount);
                    bodypropCount++;
                }

                if (bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiced);
                    bodypropCount++;
                }

                if (bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (bodychargeType != null)
                {
                    body["ChargeType"] = SourceExpressionConverter.ConvertToken(bodychargeType);
                    bodypropCount++;
                }

                var completeDateObject = new JObject();
                var completeDateObjectpropCount = 0;
                if (bodycompleteDatevalue != null)
                {
                    completeDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycompleteDatevalue);
                    completeDateObjectpropCount++;
                }

                if (bodycompleteDateOperator != null)
                {
                    completeDateObject["_operator"] = SourceExpressionConverter.Convert(bodycompleteDateOperator);
                    completeDateObjectpropCount++;
                }

                if (completeDateObjectpropCount > 0)
                {
                    body["CompleteDate"] = completeDateObject;
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                var contractDateObject = new JObject();
                var contractDateObjectpropCount = 0;
                if (bodycontractDatevalue != null)
                {
                    contractDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractDatevalue);
                    contractDateObjectpropCount++;
                }

                if (bodycontractDateOperator != null)
                {
                    contractDateObject["_operator"] = SourceExpressionConverter.Convert(bodycontractDateOperator);
                    contractDateObjectpropCount++;
                }

                if (contractDateObjectpropCount > 0)
                {
                    body["ContractDate"] = contractDateObject;
                    bodypropCount++;
                }

                if (bodycontractorCost != null)
                {
                    body["ContractorCost"] = SourceExpressionConverter.ConvertToken(bodycontractorCost);
                    bodypropCount++;
                }

                if (bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = SourceExpressionConverter.ConvertToken(bodycontractorCostEstimate);
                    bodypropCount++;
                }

                var contractorDateObject = new JObject();
                var contractorDateObjectpropCount = 0;
                if (bodycontractorDatevalue != null)
                {
                    contractorDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodycontractorDatevalue);
                    contractorDateObjectpropCount++;
                }

                if (bodycontractorDateOperator != null)
                {
                    contractorDateObject["_operator"] = SourceExpressionConverter.Convert(bodycontractorDateOperator);
                    contractorDateObjectpropCount++;
                }

                if (contractorDateObjectpropCount > 0)
                {
                    body["ContractorDate"] = contractorDateObject;
                    bodypropCount++;
                }

                if (bodycontractorETA != null)
                {
                    body["ContractorETA"] = SourceExpressionConverter.ConvertToken(bodycontractorETA);
                    bodypropCount++;
                }

                if (bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = SourceExpressionConverter.ConvertToken(bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (bodycreatedBySecurityUserId != null)
                {
                    body["CreatedBy_SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodycreatedBySecurityUserId);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                var customDate1Object = new JObject();
                var customDate1ObjectpropCount = 0;
                if (bodycustomDate1value != null)
                {
                    customDate1Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate1value);
                    customDate1ObjectpropCount++;
                }

                if (bodycustomDate1Operator != null)
                {
                    customDate1Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate1Operator);
                    customDate1ObjectpropCount++;
                }

                if (customDate1ObjectpropCount > 0)
                {
                    body["CustomDate1"] = customDate1Object;
                    bodypropCount++;
                }

                var customDate2Object = new JObject();
                var customDate2ObjectpropCount = 0;
                if (bodycustomDate2value != null)
                {
                    customDate2Object["Value"] = SourceExpressionConverter.ConvertToken(bodycustomDate2value);
                    customDate2ObjectpropCount++;
                }

                if (bodycustomDate2Operator != null)
                {
                    customDate2Object["_operator"] = SourceExpressionConverter.Convert(bodycustomDate2Operator);
                    customDate2ObjectpropCount++;
                }

                if (customDate2ObjectpropCount > 0)
                {
                    body["CustomDate2"] = customDate2Object;
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                var dateCreatedObject = new JObject();
                var dateCreatedObjectpropCount = 0;
                if (bodydateCreatedvalue != null)
                {
                    dateCreatedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateCreatedvalue);
                    dateCreatedObjectpropCount++;
                }

                if (bodydateCreatedOperator != null)
                {
                    dateCreatedObject["_operator"] = SourceExpressionConverter.Convert(bodydateCreatedOperator);
                    dateCreatedObjectpropCount++;
                }

                if (dateCreatedObjectpropCount > 0)
                {
                    body["DateCreated"] = dateCreatedObject;
                    bodypropCount++;
                }

                var dateDueObject = new JObject();
                var dateDueObjectpropCount = 0;
                if (bodydateDuevalue != null)
                {
                    dateDueObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateDuevalue);
                    dateDueObjectpropCount++;
                }

                if (bodydateDueOperator != null)
                {
                    dateDueObject["_operator"] = SourceExpressionConverter.Convert(bodydateDueOperator);
                    dateDueObjectpropCount++;
                }

                if (dateDueObjectpropCount > 0)
                {
                    body["DateDue"] = dateDueObject;
                    bodypropCount++;
                }

                var dateModifiedObject = new JObject();
                var dateModifiedObjectpropCount = 0;
                if (bodydateModifiedvalue != null)
                {
                    dateModifiedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateModifiedvalue);
                    dateModifiedObjectpropCount++;
                }

                if (bodydateModifiedOperator != null)
                {
                    dateModifiedObject["_operator"] = SourceExpressionConverter.Convert(bodydateModifiedOperator);
                    dateModifiedObjectpropCount++;
                }

                if (dateModifiedObjectpropCount > 0)
                {
                    body["DateModified"] = dateModifiedObject;
                    bodypropCount++;
                }

                var dateReportedObject = new JObject();
                var dateReportedObjectpropCount = 0;
                if (bodydateReportedvalue != null)
                {
                    dateReportedObject["Value"] = SourceExpressionConverter.ConvertToken(bodydateReportedvalue);
                    dateReportedObjectpropCount++;
                }

                if (bodydateReportedOperator != null)
                {
                    dateReportedObject["_operator"] = SourceExpressionConverter.Convert(bodydateReportedOperator);
                    dateReportedObjectpropCount++;
                }

                if (dateReportedObjectpropCount > 0)
                {
                    body["DateReported"] = dateReportedObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyjobSent != null)
                {
                    body["JobSent"] = SourceExpressionConverter.ConvertToken(bodyjobSent);
                    bodypropCount++;
                }

                if (bodyjobStatus != null)
                {
                    body["JobStatus"] = SourceExpressionConverter.ConvertToken(bodyjobStatus);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["Location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresent);
                    bodypropCount++;
                }

                if (bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = SourceExpressionConverter.ConvertToken(bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["PriorityID"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyrepairDescription != null)
                {
                    body["RepairDescription"] = SourceExpressionConverter.ConvertToken(bodyrepairDescription);
                    bodypropCount++;
                }

                if (bodyreportedByName != null)
                {
                    body["ReportedByName"] = SourceExpressionConverter.ConvertToken(bodyreportedByName);
                    bodypropCount++;
                }

                if (bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = SourceExpressionConverter.ConvertToken(bodyreportedByPhone);
                    bodypropCount++;
                }

                if (bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceId != null)
                {
                    body["RoomSpaceMaintenanceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodystartDatevalue != null)
                {
                    startDateObject["Value"] = SourceExpressionConverter.ConvertToken(bodystartDatevalue);
                    startDateObjectpropCount++;
                }

                if (bodystartDateOperator != null)
                {
                    startDateObject["_operator"] = SourceExpressionConverter.Convert(bodystartDateOperator);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["StartDate"] = startDateObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodytechnician != null)
                {
                    body["Technician"] = SourceExpressionConverter.ConvertToken(bodytechnician);
                    bodypropCount++;
                }

                if (bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = SourceExpressionConverter.ConvertToken(bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SelectRoomSpaceMaintenanceResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceMaintenanceResponse> CreateRoomSpaceMaintenance([WorkflowExpression] Func<int> bodyroomSpaceId, [WorkflowExpression] Func<string> bodyaccountCode = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<bool> bodycharge = null, [WorkflowExpression] Func<int> bodychargeEntryId = null, [WorkflowExpression] Func<double> bodychargeAmount = null, [WorkflowExpression] Func<bool> bodychargeInvoiced = null, [WorkflowExpression] Func<string> bodychargeInvoiceNumber = null, [WorkflowExpression] Func<string> bodychargeType = null, [WorkflowExpression] Func<string> bodycompleteDate = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<string> bodycontractDate = null, [WorkflowExpression] Func<double> bodycontractorCost = null, [WorkflowExpression] Func<double> bodycontractorCostEstimate = null, [WorkflowExpression] Func<string> bodycontractorDate = null, [WorkflowExpression] Func<string> bodycontractorETA = null, [WorkflowExpression] Func<string> bodycontractorOrderNumber = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateDue = null, [WorkflowExpression] Func<string> bodydateReported = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyjobSent = null, [WorkflowExpression] Func<string> bodyjobStatus = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<int> bodyoccupantEntryId = null, [WorkflowExpression] Func<string> bodyoccupantEntryName = null, [WorkflowExpression] Func<bool> bodyoccupantPresent = null, [WorkflowExpression] Func<string> bodyoccupantPresentReason = null, [WorkflowExpression] Func<string> bodyotherServiceNumber = null, [WorkflowExpression] Func<int> bodypriorityId = null, [WorkflowExpression] Func<string> bodyrepairDescription = null, [WorkflowExpression] Func<string> bodyreportedByName = null, [WorkflowExpression] Func<string> bodyreportedByPhone = null, [WorkflowExpression] Func<int> bodyroomSpaceClosedId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceCategoryId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceItemId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytechnician = null, [WorkflowExpression] Func<bool> bodyviewOnWeb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create/roomspacemaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountCode != null)
                {
                    body["AccountCode"] = SourceExpressionConverter.ConvertToken(bodyaccountCode);
                    bodypropCount++;
                }

                if (bodycause != null)
                {
                    body["Cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                    bodypropCount++;
                }

                if (bodycharge != null)
                {
                    body["Charge"] = SourceExpressionConverter.ConvertToken(bodycharge);
                    bodypropCount++;
                }

                if (bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = SourceExpressionConverter.ConvertToken(bodychargeEntryId);
                    bodypropCount++;
                }

                if (bodychargeAmount != null)
                {
                    body["ChargeAmount"] = SourceExpressionConverter.ConvertToken(bodychargeAmount);
                    bodypropCount++;
                }

                if (bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiced);
                    bodypropCount++;
                }

                if (bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (bodychargeType != null)
                {
                    body["ChargeType"] = SourceExpressionConverter.ConvertToken(bodychargeType);
                    bodypropCount++;
                }

                if (bodycompleteDate != null)
                {
                    body["CompleteDate"] = SourceExpressionConverter.ConvertToken(bodycompleteDate);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodycontractDate != null)
                {
                    body["ContractDate"] = SourceExpressionConverter.ConvertToken(bodycontractDate);
                    bodypropCount++;
                }

                if (bodycontractorCost != null)
                {
                    body["ContractorCost"] = SourceExpressionConverter.ConvertToken(bodycontractorCost);
                    bodypropCount++;
                }

                if (bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = SourceExpressionConverter.ConvertToken(bodycontractorCostEstimate);
                    bodypropCount++;
                }

                if (bodycontractorDate != null)
                {
                    body["ContractorDate"] = SourceExpressionConverter.ConvertToken(bodycontractorDate);
                    bodypropCount++;
                }

                if (bodycontractorETA != null)
                {
                    body["ContractorETA"] = SourceExpressionConverter.ConvertToken(bodycontractorETA);
                    bodypropCount++;
                }

                if (bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = SourceExpressionConverter.ConvertToken(bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodydateDue != null)
                {
                    body["DateDue"] = SourceExpressionConverter.ConvertToken(bodydateDue);
                    bodypropCount++;
                }

                if (bodydateReported != null)
                {
                    body["DateReported"] = SourceExpressionConverter.ConvertToken(bodydateReported);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyjobSent != null)
                {
                    body["JobSent"] = SourceExpressionConverter.ConvertToken(bodyjobSent);
                    bodypropCount++;
                }

                if (bodyjobStatus != null)
                {
                    body["JobStatus"] = SourceExpressionConverter.ConvertToken(bodyjobStatus);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["Location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresent);
                    bodypropCount++;
                }

                if (bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = SourceExpressionConverter.ConvertToken(bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["PriorityID"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyrepairDescription != null)
                {
                    body["RepairDescription"] = SourceExpressionConverter.ConvertToken(bodyrepairDescription);
                    bodypropCount++;
                }

                if (bodyreportedByName != null)
                {
                    body["ReportedByName"] = SourceExpressionConverter.ConvertToken(bodyreportedByName);
                    bodypropCount++;
                }

                if (bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = SourceExpressionConverter.ConvertToken(bodyreportedByPhone);
                    bodypropCount++;
                }

                if (bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                if (bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["StartDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodytechnician != null)
                {
                    body["Technician"] = SourceExpressionConverter.ConvertToken(bodytechnician);
                    bodypropCount++;
                }

                if (bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = SourceExpressionConverter.ConvertToken(bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateRoomSpaceMaintenanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateRoomSpaceMaintenanceResponse> UpdateRoomSpaceMaintenance([WorkflowExpression] Func<int> roomSpaceMaintenanceId, [WorkflowExpression] Func<string> bodyaccountCode = null, [WorkflowExpression] Func<string> bodycause = null, [WorkflowExpression] Func<bool> bodycharge = null, [WorkflowExpression] Func<int> bodychargeEntryId = null, [WorkflowExpression] Func<double> bodychargeAmount = null, [WorkflowExpression] Func<bool> bodychargeInvoiced = null, [WorkflowExpression] Func<string> bodychargeInvoiceNumber = null, [WorkflowExpression] Func<string> bodychargeType = null, [WorkflowExpression] Func<string> bodycompleteDate = null, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<string> bodycontractDate = null, [WorkflowExpression] Func<double> bodycontractorCost = null, [WorkflowExpression] Func<double> bodycontractorCostEstimate = null, [WorkflowExpression] Func<string> bodycontractorDate = null, [WorkflowExpression] Func<string> bodycontractorETA = null, [WorkflowExpression] Func<string> bodycontractorOrderNumber = null, [WorkflowExpression] Func<bool> bodycustomBit1 = null, [WorkflowExpression] Func<bool> bodycustomBit2 = null, [WorkflowExpression] Func<string> bodycustomDate1 = null, [WorkflowExpression] Func<string> bodycustomDate2 = null, [WorkflowExpression] Func<string> bodycustomString1 = null, [WorkflowExpression] Func<string> bodycustomString2 = null, [WorkflowExpression] Func<string> bodycustomString3 = null, [WorkflowExpression] Func<string> bodycustomString4 = null, [WorkflowExpression] Func<string> bodycustomString5 = null, [WorkflowExpression] Func<string> bodycustomString6 = null, [WorkflowExpression] Func<string> bodydateDue = null, [WorkflowExpression] Func<string> bodydateReported = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyjobSent = null, [WorkflowExpression] Func<string> bodyjobStatus = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<int> bodyoccupantEntryId = null, [WorkflowExpression] Func<string> bodyoccupantEntryName = null, [WorkflowExpression] Func<bool> bodyoccupantPresent = null, [WorkflowExpression] Func<string> bodyoccupantPresentReason = null, [WorkflowExpression] Func<string> bodyotherServiceNumber = null, [WorkflowExpression] Func<int> bodypriorityId = null, [WorkflowExpression] Func<string> bodyrepairDescription = null, [WorkflowExpression] Func<string> bodyreportedByName = null, [WorkflowExpression] Func<string> bodyreportedByPhone = null, [WorkflowExpression] Func<int> bodyroomSpaceClosedId = null, [WorkflowExpression] Func<int> bodyroomSpaceId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceCategoryId = null, [WorkflowExpression] Func<int> bodyroomSpaceMaintenanceItemId = null, [WorkflowExpression] Func<int> bodysecurityUserId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytechnician = null, [WorkflowExpression] Func<bool> bodyviewOnWeb = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/update/roomspacemaintenance.json/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(roomSpaceMaintenanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountCode != null)
                {
                    body["AccountCode"] = SourceExpressionConverter.ConvertToken(bodyaccountCode);
                    bodypropCount++;
                }

                if (bodycause != null)
                {
                    body["Cause"] = SourceExpressionConverter.ConvertToken(bodycause);
                    bodypropCount++;
                }

                if (bodycharge != null)
                {
                    body["Charge"] = SourceExpressionConverter.ConvertToken(bodycharge);
                    bodypropCount++;
                }

                if (bodychargeEntryId != null)
                {
                    body["Charge_EntryID"] = SourceExpressionConverter.ConvertToken(bodychargeEntryId);
                    bodypropCount++;
                }

                if (bodychargeAmount != null)
                {
                    body["ChargeAmount"] = SourceExpressionConverter.ConvertToken(bodychargeAmount);
                    bodypropCount++;
                }

                if (bodychargeInvoiced != null)
                {
                    body["ChargeInvoiced"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiced);
                    bodypropCount++;
                }

                if (bodychargeInvoiceNumber != null)
                {
                    body["ChargeInvoiceNumber"] = SourceExpressionConverter.ConvertToken(bodychargeInvoiceNumber);
                    bodypropCount++;
                }

                if (bodychargeType != null)
                {
                    body["ChargeType"] = SourceExpressionConverter.ConvertToken(bodychargeType);
                    bodypropCount++;
                }

                if (bodycompleteDate != null)
                {
                    body["CompleteDate"] = SourceExpressionConverter.ConvertToken(bodycompleteDate);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodycontractDate != null)
                {
                    body["ContractDate"] = SourceExpressionConverter.ConvertToken(bodycontractDate);
                    bodypropCount++;
                }

                if (bodycontractorCost != null)
                {
                    body["ContractorCost"] = SourceExpressionConverter.ConvertToken(bodycontractorCost);
                    bodypropCount++;
                }

                if (bodycontractorCostEstimate != null)
                {
                    body["ContractorCostEstimate"] = SourceExpressionConverter.ConvertToken(bodycontractorCostEstimate);
                    bodypropCount++;
                }

                if (bodycontractorDate != null)
                {
                    body["ContractorDate"] = SourceExpressionConverter.ConvertToken(bodycontractorDate);
                    bodypropCount++;
                }

                if (bodycontractorETA != null)
                {
                    body["ContractorETA"] = SourceExpressionConverter.ConvertToken(bodycontractorETA);
                    bodypropCount++;
                }

                if (bodycontractorOrderNumber != null)
                {
                    body["ContractorOrderNumber"] = SourceExpressionConverter.ConvertToken(bodycontractorOrderNumber);
                    bodypropCount++;
                }

                if (bodycustomBit1 != null)
                {
                    body["CustomBit1"] = SourceExpressionConverter.ConvertToken(bodycustomBit1);
                    bodypropCount++;
                }

                if (bodycustomBit2 != null)
                {
                    body["CustomBit2"] = SourceExpressionConverter.ConvertToken(bodycustomBit2);
                    bodypropCount++;
                }

                if (bodycustomDate1 != null)
                {
                    body["CustomDate1"] = SourceExpressionConverter.ConvertToken(bodycustomDate1);
                    bodypropCount++;
                }

                if (bodycustomDate2 != null)
                {
                    body["CustomDate2"] = SourceExpressionConverter.ConvertToken(bodycustomDate2);
                    bodypropCount++;
                }

                if (bodycustomString1 != null)
                {
                    body["CustomString1"] = SourceExpressionConverter.ConvertToken(bodycustomString1);
                    bodypropCount++;
                }

                if (bodycustomString2 != null)
                {
                    body["CustomString2"] = SourceExpressionConverter.ConvertToken(bodycustomString2);
                    bodypropCount++;
                }

                if (bodycustomString3 != null)
                {
                    body["CustomString3"] = SourceExpressionConverter.ConvertToken(bodycustomString3);
                    bodypropCount++;
                }

                if (bodycustomString4 != null)
                {
                    body["CustomString4"] = SourceExpressionConverter.ConvertToken(bodycustomString4);
                    bodypropCount++;
                }

                if (bodycustomString5 != null)
                {
                    body["CustomString5"] = SourceExpressionConverter.ConvertToken(bodycustomString5);
                    bodypropCount++;
                }

                if (bodycustomString6 != null)
                {
                    body["CustomString6"] = SourceExpressionConverter.ConvertToken(bodycustomString6);
                    bodypropCount++;
                }

                if (bodydateDue != null)
                {
                    body["DateDue"] = SourceExpressionConverter.ConvertToken(bodydateDue);
                    bodypropCount++;
                }

                if (bodydateReported != null)
                {
                    body["DateReported"] = SourceExpressionConverter.ConvertToken(bodydateReported);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyjobSent != null)
                {
                    body["JobSent"] = SourceExpressionConverter.ConvertToken(bodyjobSent);
                    bodypropCount++;
                }

                if (bodyjobStatus != null)
                {
                    body["JobStatus"] = SourceExpressionConverter.ConvertToken(bodyjobStatus);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["Location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyoccupantEntryId != null)
                {
                    body["Occupant_EntryID"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryId);
                    bodypropCount++;
                }

                if (bodyoccupantEntryName != null)
                {
                    body["OccupantEntryName"] = SourceExpressionConverter.ConvertToken(bodyoccupantEntryName);
                    bodypropCount++;
                }

                if (bodyoccupantPresent != null)
                {
                    body["OccupantPresent"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresent);
                    bodypropCount++;
                }

                if (bodyoccupantPresentReason != null)
                {
                    body["OccupantPresentReason"] = SourceExpressionConverter.ConvertToken(bodyoccupantPresentReason);
                    bodypropCount++;
                }

                if (bodyotherServiceNumber != null)
                {
                    body["OtherServiceNumber"] = SourceExpressionConverter.ConvertToken(bodyotherServiceNumber);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["PriorityID"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyrepairDescription != null)
                {
                    body["RepairDescription"] = SourceExpressionConverter.ConvertToken(bodyrepairDescription);
                    bodypropCount++;
                }

                if (bodyreportedByName != null)
                {
                    body["ReportedByName"] = SourceExpressionConverter.ConvertToken(bodyreportedByName);
                    bodypropCount++;
                }

                if (bodyreportedByPhone != null)
                {
                    body["ReportedByPhone"] = SourceExpressionConverter.ConvertToken(bodyreportedByPhone);
                    bodypropCount++;
                }

                if (bodyroomSpaceClosedId != null)
                {
                    body["RoomSpaceClosedID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceClosedId);
                    bodypropCount++;
                }

                if (bodyroomSpaceId != null)
                {
                    body["RoomSpaceID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceCategoryId != null)
                {
                    body["RoomSpaceMaintenanceCategoryID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceCategoryId);
                    bodypropCount++;
                }

                if (bodyroomSpaceMaintenanceItemId != null)
                {
                    body["RoomSpaceMaintenanceItemID"] = SourceExpressionConverter.ConvertToken(bodyroomSpaceMaintenanceItemId);
                    bodypropCount++;
                }

                if (bodysecurityUserId != null)
                {
                    body["SecurityUserID"] = SourceExpressionConverter.ConvertToken(bodysecurityUserId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["StartDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodytechnician != null)
                {
                    body["Technician"] = SourceExpressionConverter.ConvertToken(bodytechnician);
                    bodypropCount++;
                }

                if (bodyviewOnWeb != null)
                {
                    body["ViewOnWeb"] = SourceExpressionConverter.ConvertToken(bodyviewOnWeb);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateRoomSpaceMaintenanceResponse>(BuildSourceInput);
        }
    }

    public class Starrezrestv1Triggers([ConnectionName] string connectionId)
    {
    }

    public class SelectEntryResponseItem
    {
        public int AddressTypeID { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }
        public int BookingID { get; set; }
        public int CategoryID { get; set; }
        public string ConferenceEmail { get; set; }
        public int ContactID { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserID { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }
        public int EntryApplicationID { get; set; }
        public int EntryID { get; set; }
        public string EntryStatusEnum { get; set; }
        public int EventID { get; set; }
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
        public string PortalAuthProviderUserID { get; set; }
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

    public enum bodybirthGenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

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

    public enum bodygenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

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
        public int AddressTypeID { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }
        public int BookingID { get; set; }
        public int CategoryID { get; set; }
        public string ConferenceEmail { get; set; }
        public int ContactID { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }
        public int EntryApplicationID { get; set; }
        public int EntryID { get; set; }
        public string EntryStatusEnum { get; set; }
        public int EventID { get; set; }
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
        public string PortalAuthProviderUserID { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public class UpdateEntryResponse
    {
        public int AddressTypeID { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }
        public int BookingID { get; set; }
        public int CategoryID { get; set; }
        public string ConferenceEmail { get; set; }
        public int ContactID { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }
        public int EntryApplicationID { get; set; }
        public int EntryID { get; set; }
        public string EntryStatusEnum { get; set; }
        public int EventID { get; set; }
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
        public string PortalAuthProviderUserID { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

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
        public int CustomFieldDefinitionID { get; set; }
        public string DateModified { get; set; }
        public int EntryCustomFieldID { get; set; }
        public int EntryID { get; set; }
        public string FieldDataTypeEnum { get; set; }
        public bool ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int ValueInteger { get; set; }
        public double ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

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
        public int CustomFieldDefinitionID { get; set; }
        public int EntryCustomFieldID { get; set; }
        public int EntryID { get; set; }
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
        public int CategoryID { get; set; }
        public string Comments { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string RecordTypeEnum { get; set; }
        public string TermCode { get; set; }
        public int TermID { get; set; }
        public int TermTypeID { get; set; }
        public string WebDescription { get; set; }
    }

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
        public int AddressTypeID { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }
        public int CountryID { get; set; }
        public string DateModified { get; set; }
        public string Email { get; set; }
        public int EntryAddressID { get; set; }
        public int EntryID { get; set; }
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
        public int AddressTypeID { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }
        public int CountryID { get; set; }
        public string Email { get; set; }
        public int EntryAddressID { get; set; }
        public int EntryID { get; set; }
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
        public int ApplicationStatusID { get; set; }
        public string CancelDate { get; set; }
        public int ClassificationID { get; set; }
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
        public int EntryApplicationID { get; set; }
        public int EntryID { get; set; }
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
        public int ReceivedDepositWebPaymentID { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentID { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentID { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentID { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }
        public int RoommateGroupID { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }
        public int SecurityUserID { get; set; }
        public int TermID { get; set; }
        public bool Web { get; set; }
    }

    public enum bodyallocateOptionEnumInput
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

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

    public enum bodyofferReplyEnumInput
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

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
        public int ApplicationStatusID { get; set; }
        public string CancelDate { get; set; }
        public int ClassificationID { get; set; }
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
        public int EntryApplicationID { get; set; }
        public string EnquiryDate { get; set; }
        public int EntryID { get; set; }
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
        public int ReceivedDepositPaymentID { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentID { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentID { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentID { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }
        public int RoommateGroupID { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }
        public int SecurityUserID { get; set; }
        public int TermID { get; set; }
        public bool Web { get; set; }
    }

    public class UpdateEntryApplicationResponse
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }
        public int ApplicationStatusID { get; set; }
        public string CancelDate { get; set; }
        public int ClassificationID { get; set; }
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
        public int EntryApplicationID { get; set; }
        public int EntryID { get; set; }
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
        public int ReceivedDepositPaymentID { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentID { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentID { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentID { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }
        public int RoommateGroupID { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }
        public int SecurityUserID { get; set; }
        public int TermID { get; set; }
        public bool Web { get; set; }
    }

    public class SelectTermSessionResponseItem
    {
        public int BookingTypeID { get; set; }

        [JsonProperty("CancelBookingDefaultEnd_BookingReasonID")]
        public int CancelBookingDefaultEndBookingReasonID { get; set; }

        [JsonProperty("CancelBookingUpdateEndBookingReason_BooleanAskEnum")]
        public string CancelBookingUpdateEndBookingReasonBooleanAskEnum { get; set; }
        public string CheckInDate { get; set; }

        [JsonProperty("CheckInDateActualDecrease_BooleanAskEnum")]
        public string CheckInDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDateActualIncrease_BooleanAskEnum")]
        public string CheckInDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDefaultStart_BookingReasonID")]
        public int CheckInDefaultStartBookingReasonID { get; set; }

        [JsonProperty("CheckInUpdateStartBookingReason_BooleanAskEnum")]
        public string CheckInUpdateStartBookingReasonBooleanAskEnum { get; set; }
        public string CheckOutDate { get; set; }

        [JsonProperty("CheckOutDateActualDecrease_BooleanAskEnum")]
        public string CheckOutDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDateActualIncrease_BooleanAskEnum")]
        public string CheckOutDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDefaultEnd_BookingReasonID")]
        public int CheckOutDefaultEndBookingReasonID { get; set; }

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
        public int EndBookingReasonID { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public int HousekeepingID { get; set; }
        public string RecordTypeEnum { get; set; }
        public bool RoomLocationFixed { get; set; }
        public int RoomLocationID { get; set; }
        public double RoomRateAmount { get; set; }
        public int RoomRateID { get; set; }
        public int RoomTypeID { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonID { get; set; }
        public int TermID { get; set; }
        public string TermSessionCode { get; set; }
        public int TermSessionID { get; set; }
        public bool UseActiveBookingAsTemplate { get; set; }
        public string WebDescription { get; set; }
    }

    public enum bodycancelBookingUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

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

    public enum bodycheckInDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycheckInDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycheckInUpdateStartBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

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

    public enum bodycheckOutDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycheckOutDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycheckOutUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycontractDateCheckInDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycontractDateCheckInIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycontractDateCheckOutDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodycontractDateCheckOutIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

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
        public int AccountPaymentTypeID { get; set; }
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
        public int CitizenshipCountryID { get; set; }
        public int ClassificationID { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryID { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryID { get; set; }
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
        public int EntryDetailID { get; set; }
        public int EntryID { get; set; }
        public string Ethnicity { get; set; }
        public int EventRegistrationFeeID { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }
        public int FinancialSupportID { get; set; }
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
        public int NationalityID { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }
        public int RegionOfBirthID { get; set; }
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
        public int StaffID { get; set; }
        public bool UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool VisitorHold { get; set; }
    }

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

    public enum bodyattendeeStatusEnumInput
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

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

    public enum bodysituationResponseEnumInput
    {
        NoResponse,
        NotOkay,
        Okay
    }

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
        public int AccountPaymentTypeID { get; set; }
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
        public int CitizenshipCountryID { get; set; }
        public int ClassificationID { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryID { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryID { get; set; }
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
        public int EntryDetailID { get; set; }
        public int EntryID { get; set; }
        public string Ethnicity { get; set; }
        public int EventRegistrationFeeID { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }
        public int FinancialSupportID { get; set; }
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
        public int NationalityID { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }
        public int RegionOfBirthID { get; set; }
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
        public int StaffID { get; set; }
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
        public int CourseID { get; set; }
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
        public int EntryEnrollmentID { get; set; }
        public int EntryID { get; set; }
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
        public int TermID { get; set; }
        public string Years { get; set; }
    }

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

    public enum bodyenrollmentTypeEnumInput
    {
        Current,
        Preferred,
        Previous
    }

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
        public int CourseID { get; set; }
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
        public int EntryEnrollmentID { get; set; }
        public int EntryID { get; set; }
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
        public int TermID { get; set; }
        public string Years { get; set; }
    }

    public class UpdateEntryEnrollmentResponse
    {
        public string Campus { get; set; }
        public string Comments { get; set; }
        public int CourseID { get; set; }
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
        public int EntryEnrollmentID { get; set; }
        public int EntryID { get; set; }
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
        public int TermID { get; set; }
        public string Years { get; set; }
    }

    public class SelectBookingResponseItem
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public int BookingID { get; set; }
        public string BookingLinkTypeEnum { get; set; }
        public int BookingTypeID { get; set; }
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
        public int EndBookingReasonID { get; set; }
        public int EntryID { get; set; }
        public int EntryInvitationID { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }
        public int GroupID { get; set; }
        public int HousekeepingID { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }
        public int RoomLocationID { get; set; }
        public double RoomRateAmount { get; set; }
        public int RoomRateID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomTypeID { get; set; }
        public int SecurityUserID { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonID { get; set; }
        public int TermSessionID { get; set; }
    }

    public enum bodybookingLinkTypeEnumInput
    {
        None,
        Child,
        Parent,
        Reference
    }

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
        public int BookingID { get; set; }
        public string BookingLinkTypeEnum { get; set; }
        public int BookingTypeID { get; set; }
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
        public int EndBookingReasonID { get; set; }
        public int EntryID { get; set; }
        public int EntryInvitationID { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }
        public int GroupID { get; set; }
        public int HousekeepingID { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }
        public int RoomLocationID { get; set; }
        public double RoomRateAmount { get; set; }
        public int RoomRateID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomTypeID { get; set; }
        public int SecurityUserID { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonID { get; set; }
        public int TermSessionID { get; set; }
    }

    public class UpdateBookingResponse
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public int BookingID { get; set; }
        public string BookingLinkTypeEnum { get; set; }
        public int BookingTypeID { get; set; }
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
        public int EndBookingReasonID { get; set; }
        public int EntryID { get; set; }
        public int EntryInvitationID { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }
        public int GroupID { get; set; }
        public int HousekeepingID { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }
        public int RoomLocationID { get; set; }
        public double RoomRateAmount { get; set; }
        public int RoomRateID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomTypeID { get; set; }
        public int SecurityUserID { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonID { get; set; }
        public int TermSessionID { get; set; }
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
        public int ExtensionID { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }
        public int RoomBaseID { get; set; }
        public int RoomID { get; set; }
        public int RoomRateID { get; set; }
        public int RoomSpaceID { get; set; }
        public string RoomSpaceTypeEnum { get; set; }
        public int SecurityUserID { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

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
        public int ExtensionID { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }
        public int RoomBaseID { get; set; }
        public int RoomID { get; set; }
        public int RoomRateID { get; set; }
        public int RoomSpaceID { get; set; }
        public string RoomSpaceTypeEnum { get; set; }
        public int SecurityUserID { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectRoomLocationResponseItem
    {
        public int AllocateSortOrder { get; set; }
        public int CategoryID { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public int CountryID { get; set; }
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
        public int RoomLocationAreaID { get; set; }
        public int RoomLocationID { get; set; }
        public string StateProvince { get; set; }
        public bool ViewOnWeb { get; set; }
        public string WebComments { get; set; }
        public string WebDescription { get; set; }
        public string WebImageAltText { get; set; }
        public string WebImageLocation { get; set; }
        public string ZipPostcode { get; set; }
    }

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
        public int ChargeGroupID { get; set; }
        public int ChargeItemID { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserID { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }
        public int EndOfSessionID { get; set; }
        public int EntryID { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }
        public int ExternalID { get; set; }
        public string ExternalReceiptID { get; set; }
        public int InvoiceID { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }
        public int PaymentID { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingID { get; set; }
        public int SecurityUserID { get; set; }
        public int TableID { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }
        public int TermSessionID { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionID { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

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
        public int ChargeGroupID { get; set; }
        public int ChargeItemID { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }
        public int EndOfSessionID { get; set; }
        public int EntryID { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }
        public int ExternalID { get; set; }
        public string ExternalReceiptID { get; set; }
        public int InvoiceID { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }
        public int PaymentID { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingID { get; set; }
        public int SecurityUserID { get; set; }
        public int TableID { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }
        public int TermSessionID { get; set; }
        public string TransactionDate { get; set; }
        public int TransactionID { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

    public class SelectRoomSpaceMaintenanceResponseItem
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryID { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }
        public int ContactID { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserID { get; set; }
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
        public int OccupantEntryID { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }
        public int PriorityID { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }
        public int RoomSpaceClosedID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomSpaceMaintenanceCategoryID { get; set; }
        public int RoomSpaceMaintenanceID { get; set; }
        public int RoomSpaceMaintenanceItemID { get; set; }
        public int SecurityUserID { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

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
        public int ChargeEntryID { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }
        public int ContactID { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserID { get; set; }
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
        public int OccupantEntryID { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }
        public int PriorityID { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }
        public int RoomSpaceClosedID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomSpaceMaintenanceCategoryID { get; set; }
        public int RoomSpaceMaintenanceID { get; set; }
        public int RoomSpaceMaintenanceItemID { get; set; }
        public int SecurityUserID { get; set; }
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
        public int ChargeEntryID { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }
        public int ContactID { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserID { get; set; }
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
        public int OccupantEntryID { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }
        public int PriorityID { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }
        public int RoomSpaceClosedID { get; set; }
        public int RoomSpaceID { get; set; }
        public int RoomSpaceMaintenanceCategoryID { get; set; }
        public int RoomSpaceMaintenanceID { get; set; }
        public int RoomSpaceMaintenanceItemID { get; set; }
        public int SecurityUserID { get; set; }
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