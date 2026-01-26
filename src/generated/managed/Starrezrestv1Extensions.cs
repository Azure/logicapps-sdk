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
        public IBodyWorkflowAction<SelectEntryResponseItem[]> SelectEntry(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyAddressTypeID = null, Expression<Func<bodyBirthGenderEnumInput>> bodyBirthGenderEnum = null, Expression<Func<int>> bodyBookingID = null, Expression<Func<int>> bodyCategoryID = null, Expression<Func<string>> bodyConferenceEmail = null, Expression<Func<int>> bodyContactID = null, Expression<Func<int>> bodyCreatedBySecurityUserID = null, Expression<Func<string>> bodyDateCreatedValue = null, Expression<Func<bodyDateCreatedOperatorInput>> bodyDateCreatedOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<bool>> bodyDirectoryFlagPrivacy = null, Expression<Func<string>> bodyDOBValue = null, Expression<Func<bodyDOBOperatorInput>> bodyDOBOperator = null, Expression<Func<int>> bodyEntryApplicationID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<int>> bodyEventID = null, Expression<Func<bodyGenderEnumInput>> bodyGenderEnum = null, Expression<Func<string>> bodyID1 = null, Expression<Func<string>> bodyID2 = null, Expression<Func<string>> bodyID3 = null, Expression<Func<int>> bodyID4 = null, Expression<Func<int>> bodyID5 = null, Expression<Func<string>> bodyLastCheckInOutDateValue = null, Expression<Func<bodyLastCheckInOutDateOperatorInput>> bodyLastCheckInOutDateOperator = null, Expression<Func<string>> bodyNameFirst = null, Expression<Func<string>> bodyNameInitials = null, Expression<Func<string>> bodyNameLast = null, Expression<Func<string>> bodyNameOther = null, Expression<Func<string>> bodyNamePreferred = null, Expression<Func<string>> bodyNameSharer = null, Expression<Func<string>> bodyNameTitle = null, Expression<Func<string>> bodyNameWeb = null, Expression<Func<int>> bodyPinNumber = null, Expression<Func<string>> bodyPortalAuthProviderUserID = null, Expression<Func<string>> bodyPortalEmail = null, Expression<Func<string>> bodyPosition = null, Expression<Func<bodyPreviousEntryStatusEnumInput>> bodyPreviousEntryStatusEnum = null, Expression<Func<bodyTaxExemptionEnumInput>> bodyTaxExemptionEnum = null, Expression<Func<bool>> bodyTesting = null)
        {
            var apiCallPath = "/select/entry.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAddressTypeID != null)
            {
                body["AddressTypeID"] = ExpressionConverter.ConvertO(bodyAddressTypeID);
                bodypropCount++;
            }

            if (bodyBirthGenderEnum != null)
            {
                body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(bodyBirthGenderEnum);
                bodypropCount++;
            }

            if (bodyBookingID != null)
            {
                body["BookingID"] = ExpressionConverter.ConvertO(bodyBookingID);
                bodypropCount++;
            }

            if (bodyCategoryID != null)
            {
                body["CategoryID"] = ExpressionConverter.ConvertO(bodyCategoryID);
                bodypropCount++;
            }

            if (bodyConferenceEmail != null)
            {
                body["ConferenceEmail"] = ExpressionConverter.ConvertO(bodyConferenceEmail);
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            if (bodyCreatedBySecurityUserID != null)
            {
                body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(bodyCreatedBySecurityUserID);
                bodypropCount++;
            }

            var DateCreatedObject = new JObject();
            var DateCreatedObjectpropCount = 0;
            if (bodyDateCreatedValue != null)
            {
                DateCreatedObject["Value"] = ExpressionConverter.ConvertO(bodyDateCreatedValue);
                DateCreatedObjectpropCount++;
            }

            if (bodyDateCreatedOperator != null)
            {
                DateCreatedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateCreatedOperator);
                DateCreatedObjectpropCount++;
            }

            if (DateCreatedObjectpropCount > 0)
            {
                body["DateCreated"] = DateCreatedObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDirectoryFlagPrivacy != null)
            {
                body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(bodyDirectoryFlagPrivacy);
                bodypropCount++;
            }

            var DOBObject = new JObject();
            var DOBObjectpropCount = 0;
            if (bodyDOBValue != null)
            {
                DOBObject["Value"] = ExpressionConverter.ConvertO(bodyDOBValue);
                DOBObjectpropCount++;
            }

            if (bodyDOBOperator != null)
            {
                DOBObject["_operator"] = ExpressionConverter.ConvertO(bodyDOBOperator);
                DOBObjectpropCount++;
            }

            if (DOBObjectpropCount > 0)
            {
                body["DOB"] = DOBObject;
                bodypropCount++;
            }

            if (bodyEntryApplicationID != null)
            {
                body["EntryApplicationID"] = ExpressionConverter.ConvertO(bodyEntryApplicationID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyEventID != null)
            {
                body["EventID"] = ExpressionConverter.ConvertO(bodyEventID);
                bodypropCount++;
            }

            if (bodyGenderEnum != null)
            {
                body["GenderEnum"] = ExpressionConverter.ConvertO(bodyGenderEnum);
                bodypropCount++;
            }

            if (bodyID1 != null)
            {
                body["ID1"] = ExpressionConverter.ConvertO(bodyID1);
                bodypropCount++;
            }

            if (bodyID2 != null)
            {
                body["ID2"] = ExpressionConverter.ConvertO(bodyID2);
                bodypropCount++;
            }

            if (bodyID3 != null)
            {
                body["ID3"] = ExpressionConverter.ConvertO(bodyID3);
                bodypropCount++;
            }

            if (bodyID4 != null)
            {
                body["ID4"] = ExpressionConverter.ConvertO(bodyID4);
                bodypropCount++;
            }

            if (bodyID5 != null)
            {
                body["ID5"] = ExpressionConverter.ConvertO(bodyID5);
                bodypropCount++;
            }

            var LastCheckInOutDateObject = new JObject();
            var LastCheckInOutDateObjectpropCount = 0;
            if (bodyLastCheckInOutDateValue != null)
            {
                LastCheckInOutDateObject["Value"] = ExpressionConverter.ConvertO(bodyLastCheckInOutDateValue);
                LastCheckInOutDateObjectpropCount++;
            }

            if (bodyLastCheckInOutDateOperator != null)
            {
                LastCheckInOutDateObject["_operator"] = ExpressionConverter.ConvertO(bodyLastCheckInOutDateOperator);
                LastCheckInOutDateObjectpropCount++;
            }

            if (LastCheckInOutDateObjectpropCount > 0)
            {
                body["LastCheckInOutDate"] = LastCheckInOutDateObject;
                bodypropCount++;
            }

            if (bodyNameFirst != null)
            {
                body["NameFirst"] = ExpressionConverter.ConvertO(bodyNameFirst);
                bodypropCount++;
            }

            if (bodyNameInitials != null)
            {
                body["NameInitials"] = ExpressionConverter.ConvertO(bodyNameInitials);
                bodypropCount++;
            }

            if (bodyNameLast != null)
            {
                body["NameLast"] = ExpressionConverter.ConvertO(bodyNameLast);
                bodypropCount++;
            }

            if (bodyNameOther != null)
            {
                body["NameOther"] = ExpressionConverter.ConvertO(bodyNameOther);
                bodypropCount++;
            }

            if (bodyNamePreferred != null)
            {
                body["NamePreferred"] = ExpressionConverter.ConvertO(bodyNamePreferred);
                bodypropCount++;
            }

            if (bodyNameSharer != null)
            {
                body["NameSharer"] = ExpressionConverter.ConvertO(bodyNameSharer);
                bodypropCount++;
            }

            if (bodyNameTitle != null)
            {
                body["NameTitle"] = ExpressionConverter.ConvertO(bodyNameTitle);
                bodypropCount++;
            }

            if (bodyNameWeb != null)
            {
                body["NameWeb"] = ExpressionConverter.ConvertO(bodyNameWeb);
                bodypropCount++;
            }

            if (bodyPinNumber != null)
            {
                body["PinNumber"] = ExpressionConverter.ConvertO(bodyPinNumber);
                bodypropCount++;
            }

            if (bodyPortalAuthProviderUserID != null)
            {
                body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(bodyPortalAuthProviderUserID);
                bodypropCount++;
            }

            if (bodyPortalEmail != null)
            {
                body["PortalEmail"] = ExpressionConverter.ConvertO(bodyPortalEmail);
                bodypropCount++;
            }

            if (bodyPosition != null)
            {
                body["Position"] = ExpressionConverter.ConvertO(bodyPosition);
                bodypropCount++;
            }

            if (bodyPreviousEntryStatusEnum != null)
            {
                body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyPreviousEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyTaxExemptionEnum != null)
            {
                body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(bodyTaxExemptionEnum);
                bodypropCount++;
            }

            if (bodyTesting != null)
            {
                body["Testing"] = ExpressionConverter.ConvertO(bodyTesting);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry(Expression<Func<string>> bodyNameFirst, Expression<Func<string>> bodyNameLast, Expression<Func<int>> bodyAddressTypeID = null, Expression<Func<bodyBirthGenderEnumInput>> bodyBirthGenderEnum = null, Expression<Func<int>> bodyBookingID = null, Expression<Func<int>> bodyCategoryID = null, Expression<Func<string>> bodyConferenceEmail = null, Expression<Func<int>> bodyContactID = null, Expression<Func<bool>> bodyDirectoryFlagPrivacy = null, Expression<Func<string>> bodyDOB = null, Expression<Func<int>> bodyEntryApplicationID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<int>> bodyEventID = null, Expression<Func<bodyGenderEnumInput>> bodyGenderEnum = null, Expression<Func<string>> bodyID1 = null, Expression<Func<string>> bodyID2 = null, Expression<Func<string>> bodyID3 = null, Expression<Func<int>> bodyID4 = null, Expression<Func<int>> bodyID5 = null, Expression<Func<string>> bodyLastCheckInOutDate = null, Expression<Func<string>> bodyNameInitials = null, Expression<Func<string>> bodyNameOther = null, Expression<Func<string>> bodyNamePreferred = null, Expression<Func<string>> bodyNameSharer = null, Expression<Func<string>> bodyNameTitle = null, Expression<Func<string>> bodyNameWeb = null, Expression<Func<string>> bodyPassword = null, Expression<Func<int>> bodyPinNumber = null, Expression<Func<string>> bodyPortalAuthProviderUserID = null, Expression<Func<string>> bodyPortalEmail = null, Expression<Func<string>> bodyPosition = null, Expression<Func<bodyPreviousEntryStatusEnumInput>> bodyPreviousEntryStatusEnum = null, Expression<Func<bodyTaxExemptionEnumInput>> bodyTaxExemptionEnum = null, Expression<Func<bool>> bodyTesting = null)
        {
            var apiCallPath = "/create/entry.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddressTypeID != null)
            {
                body["AddressTypeID"] = ExpressionConverter.ConvertO(bodyAddressTypeID);
                bodypropCount++;
            }

            if (bodyBirthGenderEnum != null)
            {
                body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(bodyBirthGenderEnum);
                bodypropCount++;
            }

            if (bodyBookingID != null)
            {
                body["BookingID"] = ExpressionConverter.ConvertO(bodyBookingID);
                bodypropCount++;
            }

            if (bodyCategoryID != null)
            {
                body["CategoryID"] = ExpressionConverter.ConvertO(bodyCategoryID);
                bodypropCount++;
            }

            if (bodyConferenceEmail != null)
            {
                body["ConferenceEmail"] = ExpressionConverter.ConvertO(bodyConferenceEmail);
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            if (bodyDirectoryFlagPrivacy != null)
            {
                body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(bodyDirectoryFlagPrivacy);
                bodypropCount++;
            }

            if (bodyDOB != null)
            {
                body["DOB"] = ExpressionConverter.ConvertO(bodyDOB);
                bodypropCount++;
            }

            if (bodyEntryApplicationID != null)
            {
                body["EntryApplicationID"] = ExpressionConverter.ConvertO(bodyEntryApplicationID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyEventID != null)
            {
                body["EventID"] = ExpressionConverter.ConvertO(bodyEventID);
                bodypropCount++;
            }

            if (bodyGenderEnum != null)
            {
                body["GenderEnum"] = ExpressionConverter.ConvertO(bodyGenderEnum);
                bodypropCount++;
            }

            if (bodyID1 != null)
            {
                body["ID1"] = ExpressionConverter.ConvertO(bodyID1);
                bodypropCount++;
            }

            if (bodyID2 != null)
            {
                body["ID2"] = ExpressionConverter.ConvertO(bodyID2);
                bodypropCount++;
            }

            if (bodyID3 != null)
            {
                body["ID3"] = ExpressionConverter.ConvertO(bodyID3);
                bodypropCount++;
            }

            if (bodyID4 != null)
            {
                body["ID4"] = ExpressionConverter.ConvertO(bodyID4);
                bodypropCount++;
            }

            if (bodyID5 != null)
            {
                body["ID5"] = ExpressionConverter.ConvertO(bodyID5);
                bodypropCount++;
            }

            if (bodyLastCheckInOutDate != null)
            {
                body["LastCheckInOutDate"] = ExpressionConverter.ConvertO(bodyLastCheckInOutDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["NameFirst"] = ExpressionConverter.ConvertO(bodyNameFirst);
            if (bodyNameInitials != null)
            {
                body["NameInitials"] = ExpressionConverter.ConvertO(bodyNameInitials);
                bodypropCount++;
            }

            bodypropCount++;
            body["NameLast"] = ExpressionConverter.ConvertO(bodyNameLast);
            if (bodyNameOther != null)
            {
                body["NameOther"] = ExpressionConverter.ConvertO(bodyNameOther);
                bodypropCount++;
            }

            if (bodyNamePreferred != null)
            {
                body["NamePreferred"] = ExpressionConverter.ConvertO(bodyNamePreferred);
                bodypropCount++;
            }

            if (bodyNameSharer != null)
            {
                body["NameSharer"] = ExpressionConverter.ConvertO(bodyNameSharer);
                bodypropCount++;
            }

            if (bodyNameTitle != null)
            {
                body["NameTitle"] = ExpressionConverter.ConvertO(bodyNameTitle);
                bodypropCount++;
            }

            if (bodyNameWeb != null)
            {
                body["NameWeb"] = ExpressionConverter.ConvertO(bodyNameWeb);
                bodypropCount++;
            }

            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyPinNumber != null)
            {
                body["PinNumber"] = ExpressionConverter.ConvertO(bodyPinNumber);
                bodypropCount++;
            }

            if (bodyPortalAuthProviderUserID != null)
            {
                body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(bodyPortalAuthProviderUserID);
                bodypropCount++;
            }

            if (bodyPortalEmail != null)
            {
                body["PortalEmail"] = ExpressionConverter.ConvertO(bodyPortalEmail);
                bodypropCount++;
            }

            if (bodyPosition != null)
            {
                body["Position"] = ExpressionConverter.ConvertO(bodyPosition);
                bodypropCount++;
            }

            if (bodyPreviousEntryStatusEnum != null)
            {
                body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyPreviousEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyTaxExemptionEnum != null)
            {
                body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(bodyTaxExemptionEnum);
                bodypropCount++;
            }

            if (bodyTesting != null)
            {
                body["Testing"] = ExpressionConverter.ConvertO(bodyTesting);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryResponse> UpdateEntry(Expression<Func<int>> entryID, Expression<Func<int>> bodyAddressTypeID = null, Expression<Func<bodyBirthGenderEnumInput>> bodyBirthGenderEnum = null, Expression<Func<int>> bodyBookingID = null, Expression<Func<int>> bodyCategoryID = null, Expression<Func<string>> bodyConferenceEmail = null, Expression<Func<int>> bodyContactID = null, Expression<Func<bool>> bodyDirectoryFlagPrivacy = null, Expression<Func<string>> bodyDOB = null, Expression<Func<int>> bodyEntryApplicationID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<int>> bodyEventID = null, Expression<Func<bodyGenderEnumInput>> bodyGenderEnum = null, Expression<Func<string>> bodyID1 = null, Expression<Func<string>> bodyID2 = null, Expression<Func<string>> bodyID3 = null, Expression<Func<int>> bodyID4 = null, Expression<Func<int>> bodyID5 = null, Expression<Func<string>> bodyLastCheckInOutDate = null, Expression<Func<string>> bodyNameFirst = null, Expression<Func<string>> bodyNameInitials = null, Expression<Func<string>> bodyNameLast = null, Expression<Func<string>> bodyNameOther = null, Expression<Func<string>> bodyNamePreferred = null, Expression<Func<string>> bodyNameSharer = null, Expression<Func<string>> bodyNameTitle = null, Expression<Func<string>> bodyNameWeb = null, Expression<Func<string>> bodyPassword = null, Expression<Func<int>> bodyPinNumber = null, Expression<Func<string>> bodyPortalAuthProviderUserID = null, Expression<Func<string>> bodyPortalEmail = null, Expression<Func<string>> bodyPosition = null, Expression<Func<bodyPreviousEntryStatusEnumInput>> bodyPreviousEntryStatusEnum = null, Expression<Func<bodyTaxExemptionEnumInput>> bodyTaxExemptionEnum = null, Expression<Func<bool>> bodyTesting = null)
        {
            var apiCallPath = String.Format("/update/entry.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddressTypeID != null)
            {
                body["AddressTypeID"] = ExpressionConverter.ConvertO(bodyAddressTypeID);
                bodypropCount++;
            }

            if (bodyBirthGenderEnum != null)
            {
                body["Birth_GenderEnum"] = ExpressionConverter.ConvertO(bodyBirthGenderEnum);
                bodypropCount++;
            }

            if (bodyBookingID != null)
            {
                body["BookingID"] = ExpressionConverter.ConvertO(bodyBookingID);
                bodypropCount++;
            }

            if (bodyCategoryID != null)
            {
                body["CategoryID"] = ExpressionConverter.ConvertO(bodyCategoryID);
                bodypropCount++;
            }

            if (bodyConferenceEmail != null)
            {
                body["ConferenceEmail"] = ExpressionConverter.ConvertO(bodyConferenceEmail);
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            if (bodyDirectoryFlagPrivacy != null)
            {
                body["DirectoryFlagPrivacy"] = ExpressionConverter.ConvertO(bodyDirectoryFlagPrivacy);
                bodypropCount++;
            }

            if (bodyDOB != null)
            {
                body["DOB"] = ExpressionConverter.ConvertO(bodyDOB);
                bodypropCount++;
            }

            if (bodyEntryApplicationID != null)
            {
                body["EntryApplicationID"] = ExpressionConverter.ConvertO(bodyEntryApplicationID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyEventID != null)
            {
                body["EventID"] = ExpressionConverter.ConvertO(bodyEventID);
                bodypropCount++;
            }

            if (bodyGenderEnum != null)
            {
                body["GenderEnum"] = ExpressionConverter.ConvertO(bodyGenderEnum);
                bodypropCount++;
            }

            if (bodyID1 != null)
            {
                body["ID1"] = ExpressionConverter.ConvertO(bodyID1);
                bodypropCount++;
            }

            if (bodyID2 != null)
            {
                body["ID2"] = ExpressionConverter.ConvertO(bodyID2);
                bodypropCount++;
            }

            if (bodyID3 != null)
            {
                body["ID3"] = ExpressionConverter.ConvertO(bodyID3);
                bodypropCount++;
            }

            if (bodyID4 != null)
            {
                body["ID4"] = ExpressionConverter.ConvertO(bodyID4);
                bodypropCount++;
            }

            if (bodyID5 != null)
            {
                body["ID5"] = ExpressionConverter.ConvertO(bodyID5);
                bodypropCount++;
            }

            if (bodyLastCheckInOutDate != null)
            {
                body["LastCheckInOutDate"] = ExpressionConverter.ConvertO(bodyLastCheckInOutDate);
                bodypropCount++;
            }

            if (bodyNameFirst != null)
            {
                body["NameFirst"] = ExpressionConverter.ConvertO(bodyNameFirst);
                bodypropCount++;
            }

            if (bodyNameInitials != null)
            {
                body["NameInitials"] = ExpressionConverter.ConvertO(bodyNameInitials);
                bodypropCount++;
            }

            if (bodyNameLast != null)
            {
                body["NameLast"] = ExpressionConverter.ConvertO(bodyNameLast);
                bodypropCount++;
            }

            if (bodyNameOther != null)
            {
                body["NameOther"] = ExpressionConverter.ConvertO(bodyNameOther);
                bodypropCount++;
            }

            if (bodyNamePreferred != null)
            {
                body["NamePreferred"] = ExpressionConverter.ConvertO(bodyNamePreferred);
                bodypropCount++;
            }

            if (bodyNameSharer != null)
            {
                body["NameSharer"] = ExpressionConverter.ConvertO(bodyNameSharer);
                bodypropCount++;
            }

            if (bodyNameTitle != null)
            {
                body["NameTitle"] = ExpressionConverter.ConvertO(bodyNameTitle);
                bodypropCount++;
            }

            if (bodyNameWeb != null)
            {
                body["NameWeb"] = ExpressionConverter.ConvertO(bodyNameWeb);
                bodypropCount++;
            }

            if (bodyPassword != null)
            {
                body["Password"] = ExpressionConverter.ConvertO(bodyPassword);
                bodypropCount++;
            }

            if (bodyPinNumber != null)
            {
                body["PinNumber"] = ExpressionConverter.ConvertO(bodyPinNumber);
                bodypropCount++;
            }

            if (bodyPortalAuthProviderUserID != null)
            {
                body["PortalAuthProviderUserID"] = ExpressionConverter.ConvertO(bodyPortalAuthProviderUserID);
                bodypropCount++;
            }

            if (bodyPortalEmail != null)
            {
                body["PortalEmail"] = ExpressionConverter.ConvertO(bodyPortalEmail);
                bodypropCount++;
            }

            if (bodyPosition != null)
            {
                body["Position"] = ExpressionConverter.ConvertO(bodyPosition);
                bodypropCount++;
            }

            if (bodyPreviousEntryStatusEnum != null)
            {
                body["Previous_EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyPreviousEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyTaxExemptionEnum != null)
            {
                body["TaxExemptionEnum"] = ExpressionConverter.ConvertO(bodyTaxExemptionEnum);
                bodypropCount++;
            }

            if (bodyTesting != null)
            {
                body["Testing"] = ExpressionConverter.ConvertO(bodyTesting);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<JToken> Delete(Expression<Func<tableNameInput>> tableName, Expression<Func<int>> rowID)
        {
            var apiCallPath = String.Format("/delete/{0}.json/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(rowID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryCustomFieldResponseItem[]> SelectEntryCustomField(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyCustomFieldDefinitionID = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<int>> bodyEntryCustomFieldID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<bodyFieldDataTypeEnumInput>> bodyFieldDataTypeEnum = null, Expression<Func<bool>> bodyValueBoolean = null, Expression<Func<string>> bodyValueDateValue = null, Expression<Func<bodyValueDateOperatorInput>> bodyValueDateOperator = null, Expression<Func<int>> bodyValueInteger = null, Expression<Func<double>> bodyValueMoney = null, Expression<Func<string>> bodyValueString = null)
        {
            var apiCallPath = "/select/EntryCustomField.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyCustomFieldDefinitionID != null)
            {
                body["CustomFieldDefinitionID"] = ExpressionConverter.ConvertO(bodyCustomFieldDefinitionID);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyEntryCustomFieldID != null)
            {
                body["EntryCustomFieldID"] = ExpressionConverter.ConvertO(bodyEntryCustomFieldID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyFieldDataTypeEnum != null)
            {
                body["FieldDataTypeEnum"] = ExpressionConverter.ConvertO(bodyFieldDataTypeEnum);
                bodypropCount++;
            }

            if (bodyValueBoolean != null)
            {
                body["ValueBoolean"] = ExpressionConverter.ConvertO(bodyValueBoolean);
                bodypropCount++;
            }

            var ValueDateObject = new JObject();
            var ValueDateObjectpropCount = 0;
            if (bodyValueDateValue != null)
            {
                ValueDateObject["Value"] = ExpressionConverter.ConvertO(bodyValueDateValue);
                ValueDateObjectpropCount++;
            }

            if (bodyValueDateOperator != null)
            {
                ValueDateObject["_operator"] = ExpressionConverter.ConvertO(bodyValueDateOperator);
                ValueDateObjectpropCount++;
            }

            if (ValueDateObjectpropCount > 0)
            {
                body["ValueDate"] = ValueDateObject;
                bodypropCount++;
            }

            if (bodyValueInteger != null)
            {
                body["ValueInteger"] = ExpressionConverter.ConvertO(bodyValueInteger);
                bodypropCount++;
            }

            if (bodyValueMoney != null)
            {
                body["ValueMoney"] = ExpressionConverter.ConvertO(bodyValueMoney);
                bodypropCount++;
            }

            if (bodyValueString != null)
            {
                body["ValueString"] = ExpressionConverter.ConvertO(bodyValueString);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryCustomFieldResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryCustomFieldResponse> UpdateEntryCustomField(Expression<Func<int>> entryCustomFieldID, Expression<Func<int>> bodyCustomFieldDefinitionID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<bodyFieldDataTypeEnumInput>> bodyFieldDataTypeEnum = null, Expression<Func<bool>> bodyValueBoolean = null, Expression<Func<string>> bodyValueDate = null, Expression<Func<int>> bodyValueInteger = null, Expression<Func<double>> bodyValueMoney = null, Expression<Func<string>> bodyValueString = null)
        {
            var apiCallPath = String.Format("/update/entryCustomField.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryCustomFieldID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCustomFieldDefinitionID != null)
            {
                body["CustomFieldDefinitionID"] = ExpressionConverter.ConvertO(bodyCustomFieldDefinitionID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyFieldDataTypeEnum != null)
            {
                body["FieldDataTypeEnum"] = ExpressionConverter.ConvertO(bodyFieldDataTypeEnum);
                bodypropCount++;
            }

            if (bodyValueBoolean != null)
            {
                body["ValueBoolean"] = ExpressionConverter.ConvertO(bodyValueBoolean);
                bodypropCount++;
            }

            if (bodyValueDate != null)
            {
                body["ValueDate"] = ExpressionConverter.ConvertO(bodyValueDate);
                bodypropCount++;
            }

            if (bodyValueInteger != null)
            {
                body["ValueInteger"] = ExpressionConverter.ConvertO(bodyValueInteger);
                bodypropCount++;
            }

            if (bodyValueMoney != null)
            {
                body["ValueMoney"] = ExpressionConverter.ConvertO(bodyValueMoney);
                bodypropCount++;
            }

            if (bodyValueString != null)
            {
                body["ValueString"] = ExpressionConverter.ConvertO(bodyValueString);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryCustomFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermResponseItem[]> SelectTerm(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyActive = null, Expression<Func<string>> bodyActiveDateCloseValue = null, Expression<Func<bodyActiveDateCloseOperatorInput>> bodyActiveDateCloseOperator = null, Expression<Func<string>> bodyActiveDateOpenValue = null, Expression<Func<bodyActiveDateOpenOperatorInput>> bodyActiveDateOpenOperator = null, Expression<Func<int>> bodyCategoryID = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bodyRecordTypeEnumInput>> bodyRecordTypeEnum = null, Expression<Func<string>> bodyTermCode = null, Expression<Func<int>> bodyTermID = null, Expression<Func<int>> bodyTermTypeID = null, Expression<Func<string>> bodyWebDescription = null)
        {
            var apiCallPath = "/select/Term.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyActive != null)
            {
                body["Active"] = ExpressionConverter.ConvertO(bodyActive);
                bodypropCount++;
            }

            var ActiveDateCloseObject = new JObject();
            var ActiveDateCloseObjectpropCount = 0;
            if (bodyActiveDateCloseValue != null)
            {
                ActiveDateCloseObject["Value"] = ExpressionConverter.ConvertO(bodyActiveDateCloseValue);
                ActiveDateCloseObjectpropCount++;
            }

            if (bodyActiveDateCloseOperator != null)
            {
                ActiveDateCloseObject["_operator"] = ExpressionConverter.ConvertO(bodyActiveDateCloseOperator);
                ActiveDateCloseObjectpropCount++;
            }

            if (ActiveDateCloseObjectpropCount > 0)
            {
                body["ActiveDateClose"] = ActiveDateCloseObject;
                bodypropCount++;
            }

            var ActiveDateOpenObject = new JObject();
            var ActiveDateOpenObjectpropCount = 0;
            if (bodyActiveDateOpenValue != null)
            {
                ActiveDateOpenObject["Value"] = ExpressionConverter.ConvertO(bodyActiveDateOpenValue);
                ActiveDateOpenObjectpropCount++;
            }

            if (bodyActiveDateOpenOperator != null)
            {
                ActiveDateOpenObject["_operator"] = ExpressionConverter.ConvertO(bodyActiveDateOpenOperator);
                ActiveDateOpenObjectpropCount++;
            }

            if (ActiveDateOpenObjectpropCount > 0)
            {
                body["ActiveDateOpen"] = ActiveDateOpenObject;
                bodypropCount++;
            }

            if (bodyCategoryID != null)
            {
                body["CategoryID"] = ExpressionConverter.ConvertO(bodyCategoryID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyRecordTypeEnum != null)
            {
                body["RecordTypeEnum"] = ExpressionConverter.ConvertO(bodyRecordTypeEnum);
                bodypropCount++;
            }

            if (bodyTermCode != null)
            {
                body["TermCode"] = ExpressionConverter.ConvertO(bodyTermCode);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyTermTypeID != null)
            {
                body["TermTypeID"] = ExpressionConverter.ConvertO(bodyTermTypeID);
                bodypropCount++;
            }

            if (bodyWebDescription != null)
            {
                body["WebDescription"] = ExpressionConverter.ConvertO(bodyWebDescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectTermResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryAddressResponseItem[]> SelectEntryAddress(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodyActiveDateEndValue = null, Expression<Func<bodyActiveDateEndOperatorInput>> bodyActiveDateEndOperator = null, Expression<Func<string>> bodyActiveDateStartValue = null, Expression<Func<bodyActiveDateStartOperatorInput>> bodyActiveDateStartOperator = null, Expression<Func<int>> bodyAddressTypeID = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyContactName = null, Expression<Func<string>> bodyContactName2 = null, Expression<Func<int>> bodyCountryID = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyEmail = null, Expression<Func<int>> bodyEntryAddressID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyPhone = null, Expression<Func<string>> bodyPhoneMobileCell = null, Expression<Func<string>> bodyPhoneOther = null, Expression<Func<string>> bodyPhoneOther2 = null, Expression<Func<string>> bodyReference = null, Expression<Func<string>> bodyRelationship = null, Expression<Func<string>> bodySalutation = null, Expression<Func<string>> bodyStateProvince = null, Expression<Func<string>> bodyStreet = null, Expression<Func<string>> bodyStreet2 = null, Expression<Func<string>> bodyZipPostcode = null)
        {
            var apiCallPath = "/select/EntryAddress.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            var ActiveDateEndObject = new JObject();
            var ActiveDateEndObjectpropCount = 0;
            if (bodyActiveDateEndValue != null)
            {
                ActiveDateEndObject["Value"] = ExpressionConverter.ConvertO(bodyActiveDateEndValue);
                ActiveDateEndObjectpropCount++;
            }

            if (bodyActiveDateEndOperator != null)
            {
                ActiveDateEndObject["_operator"] = ExpressionConverter.ConvertO(bodyActiveDateEndOperator);
                ActiveDateEndObjectpropCount++;
            }

            if (ActiveDateEndObjectpropCount > 0)
            {
                body["ActiveDateEnd"] = ActiveDateEndObject;
                bodypropCount++;
            }

            var ActiveDateStartObject = new JObject();
            var ActiveDateStartObjectpropCount = 0;
            if (bodyActiveDateStartValue != null)
            {
                ActiveDateStartObject["Value"] = ExpressionConverter.ConvertO(bodyActiveDateStartValue);
                ActiveDateStartObjectpropCount++;
            }

            if (bodyActiveDateStartOperator != null)
            {
                ActiveDateStartObject["_operator"] = ExpressionConverter.ConvertO(bodyActiveDateStartOperator);
                ActiveDateStartObjectpropCount++;
            }

            if (ActiveDateStartObjectpropCount > 0)
            {
                body["ActiveDateStart"] = ActiveDateStartObject;
                bodypropCount++;
            }

            if (bodyAddressTypeID != null)
            {
                body["AddressTypeID"] = ExpressionConverter.ConvertO(bodyAddressTypeID);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyContactName != null)
            {
                body["ContactName"] = ExpressionConverter.ConvertO(bodyContactName);
                bodypropCount++;
            }

            if (bodyContactName2 != null)
            {
                body["ContactName2"] = ExpressionConverter.ConvertO(bodyContactName2);
                bodypropCount++;
            }

            if (bodyCountryID != null)
            {
                body["CountryID"] = ExpressionConverter.ConvertO(bodyCountryID);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyEntryAddressID != null)
            {
                body["EntryAddressID"] = ExpressionConverter.ConvertO(bodyEntryAddressID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyPhone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyPhone);
                bodypropCount++;
            }

            if (bodyPhoneMobileCell != null)
            {
                body["PhoneMobileCell"] = ExpressionConverter.ConvertO(bodyPhoneMobileCell);
                bodypropCount++;
            }

            if (bodyPhoneOther != null)
            {
                body["PhoneOther"] = ExpressionConverter.ConvertO(bodyPhoneOther);
                bodypropCount++;
            }

            if (bodyPhoneOther2 != null)
            {
                body["PhoneOther2"] = ExpressionConverter.ConvertO(bodyPhoneOther2);
                bodypropCount++;
            }

            if (bodyReference != null)
            {
                body["Reference"] = ExpressionConverter.ConvertO(bodyReference);
                bodypropCount++;
            }

            if (bodyRelationship != null)
            {
                body["Relationship"] = ExpressionConverter.ConvertO(bodyRelationship);
                bodypropCount++;
            }

            if (bodySalutation != null)
            {
                body["Salutation"] = ExpressionConverter.ConvertO(bodySalutation);
                bodypropCount++;
            }

            if (bodyStateProvince != null)
            {
                body["StateProvince"] = ExpressionConverter.ConvertO(bodyStateProvince);
                bodypropCount++;
            }

            if (bodyStreet != null)
            {
                body["Street"] = ExpressionConverter.ConvertO(bodyStreet);
                bodypropCount++;
            }

            if (bodyStreet2 != null)
            {
                body["Street2"] = ExpressionConverter.ConvertO(bodyStreet2);
                bodypropCount++;
            }

            if (bodyZipPostcode != null)
            {
                body["ZipPostcode"] = ExpressionConverter.ConvertO(bodyZipPostcode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryAddressResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryAddressResponse> UpdateEntryAddress(Expression<Func<int>> entryAddressID, Expression<Func<string>> bodyActiveDateEnd = null, Expression<Func<string>> bodyActiveDateStart = null, Expression<Func<int>> bodyAddressTypeID = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyContactName = null, Expression<Func<string>> bodyContactName2 = null, Expression<Func<int>> bodyCountryID = null, Expression<Func<string>> bodyEmail = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyPhone = null, Expression<Func<string>> bodyPhoneMobileCell = null, Expression<Func<string>> bodyPhoneOther = null, Expression<Func<string>> bodyPhoneOther2 = null, Expression<Func<string>> bodyReference = null, Expression<Func<string>> bodyRelationship = null, Expression<Func<string>> bodySalutation = null, Expression<Func<string>> bodyStateProvince = null, Expression<Func<string>> bodyStreet = null, Expression<Func<string>> bodyStreet2 = null, Expression<Func<string>> bodyZipPostcode = null)
        {
            var apiCallPath = String.Format("/update/entryAddress.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryAddressID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyActiveDateEnd != null)
            {
                body["ActiveDateEnd"] = ExpressionConverter.ConvertO(bodyActiveDateEnd);
                bodypropCount++;
            }

            if (bodyActiveDateStart != null)
            {
                body["ActiveDateStart"] = ExpressionConverter.ConvertO(bodyActiveDateStart);
                bodypropCount++;
            }

            if (bodyAddressTypeID != null)
            {
                body["AddressTypeID"] = ExpressionConverter.ConvertO(bodyAddressTypeID);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyContactName != null)
            {
                body["ContactName"] = ExpressionConverter.ConvertO(bodyContactName);
                bodypropCount++;
            }

            if (bodyContactName2 != null)
            {
                body["ContactName2"] = ExpressionConverter.ConvertO(bodyContactName2);
                bodypropCount++;
            }

            if (bodyCountryID != null)
            {
                body["CountryID"] = ExpressionConverter.ConvertO(bodyCountryID);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyPhone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyPhone);
                bodypropCount++;
            }

            if (bodyPhoneMobileCell != null)
            {
                body["PhoneMobileCell"] = ExpressionConverter.ConvertO(bodyPhoneMobileCell);
                bodypropCount++;
            }

            if (bodyPhoneOther != null)
            {
                body["PhoneOther"] = ExpressionConverter.ConvertO(bodyPhoneOther);
                bodypropCount++;
            }

            if (bodyPhoneOther2 != null)
            {
                body["PhoneOther2"] = ExpressionConverter.ConvertO(bodyPhoneOther2);
                bodypropCount++;
            }

            if (bodyReference != null)
            {
                body["Reference"] = ExpressionConverter.ConvertO(bodyReference);
                bodypropCount++;
            }

            if (bodyRelationship != null)
            {
                body["Relationship"] = ExpressionConverter.ConvertO(bodyRelationship);
                bodypropCount++;
            }

            if (bodySalutation != null)
            {
                body["Salutation"] = ExpressionConverter.ConvertO(bodySalutation);
                bodypropCount++;
            }

            if (bodyStateProvince != null)
            {
                body["StateProvince"] = ExpressionConverter.ConvertO(bodyStateProvince);
                bodypropCount++;
            }

            if (bodyStreet != null)
            {
                body["Street"] = ExpressionConverter.ConvertO(bodyStreet);
                bodypropCount++;
            }

            if (bodyStreet2 != null)
            {
                body["Street2"] = ExpressionConverter.ConvertO(bodyStreet2);
                bodypropCount++;
            }

            if (bodyZipPostcode != null)
            {
                body["ZipPostcode"] = ExpressionConverter.ConvertO(bodyZipPostcode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryApplicationResponseItem[]> SelectEntryApplication(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bodyAllocateOptionEnumInput>> bodyAllocateOptionEnum = null, Expression<Func<string>> bodyApplicationDateValue = null, Expression<Func<bodyApplicationDateOperatorInput>> bodyApplicationDateOperator = null, Expression<Func<int>> bodyApplicationStatusID = null, Expression<Func<string>> bodyCancelDateValue = null, Expression<Func<bodyCancelDateOperatorInput>> bodyCancelDateOperator = null, Expression<Func<int>> bodyClassificationID = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyCommentsInternal = null, Expression<Func<string>> bodyCompleteDateValue = null, Expression<Func<bodyCompleteDateOperatorInput>> bodyCompleteDateOperator = null, Expression<Func<string>> bodyContractSignedDateValue = null, Expression<Func<bodyContractSignedDateOperatorInput>> bodyContractSignedDateOperator = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomDate3Value = null, Expression<Func<bodyCustomDate3OperatorInput>> bodyCustomDate3Operator = null, Expression<Func<string>> bodyCustomDate4Value = null, Expression<Func<bodyCustomDate4OperatorInput>> bodyCustomDate4Operator = null, Expression<Func<string>> bodyDateCreatedValue = null, Expression<Func<bodyDateCreatedOperatorInput>> bodyDateCreatedOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyEnquiryDateValue = null, Expression<Func<bodyEnquiryDateOperatorInput>> bodyEnquiryDateOperator = null, Expression<Func<int>> bodyEntryApplicationID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyExpectedArrivalDateValue = null, Expression<Func<bodyExpectedArrivalDateOperatorInput>> bodyExpectedArrivalDateOperator = null, Expression<Func<string>> bodyExpectedArrivalDateLatestValue = null, Expression<Func<bodyExpectedArrivalDateLatestOperatorInput>> bodyExpectedArrivalDateLatestOperator = null, Expression<Func<string>> bodyExpectedDepartureDateValue = null, Expression<Func<bodyExpectedDepartureDateOperatorInput>> bodyExpectedDepartureDateOperator = null, Expression<Func<string>> bodyOfferedDateValue = null, Expression<Func<bodyOfferedDateOperatorInput>> bodyOfferedDateOperator = null, Expression<Func<string>> bodyOfferReplyDateValue = null, Expression<Func<bodyOfferReplyDateOperatorInput>> bodyOfferReplyDateOperator = null, Expression<Func<bodyOfferReplyEnumInput>> bodyOfferReplyEnum = null, Expression<Func<string>> bodyOfferReplyReason = null, Expression<Func<string>> bodyOfferSentDateValue = null, Expression<Func<bodyOfferSentDateOperatorInput>> bodyOfferSentDateOperator = null, Expression<Func<bool>> bodyPortalTrackingOnly = null, Expression<Func<string>> bodyPreferenceComments = null, Expression<Func<string>> bodyRating = null, Expression<Func<string>> bodyReceivedDateValue = null, Expression<Func<bodyReceivedDateOperatorInput>> bodyReceivedDateOperator = null, Expression<Func<bool>> bodyReceivedDeposit = null, Expression<Func<bool>> bodyReceivedDepositWaived = null, Expression<Func<int>> bodyReceivedDepositPaymentID = null, Expression<Func<int>> bodyReceivedDepositWebPaymentID = null, Expression<Func<double>> bodyReceivedDepositAmount = null, Expression<Func<string>> bodyReceivedDepositDateValue = null, Expression<Func<bodyReceivedDepositDateOperatorInput>> bodyReceivedDepositDateOperator = null, Expression<Func<bool>> bodyReceivedFee = null, Expression<Func<int>> bodyReceivedFeePaymentID = null, Expression<Func<int>> bodyReceivedFeeWebPaymentID = null, Expression<Func<double>> bodyReceivedFeeAmount = null, Expression<Func<string>> bodyReceivedFeeDateValue = null, Expression<Func<bodyReceivedFeeDateOperatorInput>> bodyReceivedFeeDateOperator = null, Expression<Func<string>> bodyReceivedPhotoDateValue = null, Expression<Func<bodyReceivedPhotoDateOperatorInput>> bodyReceivedPhotoDateOperator = null, Expression<Func<bool>> bodyReturning = null, Expression<Func<string>> bodyRoomMateDescription = null, Expression<Func<int>> bodyRoommateGroupID = null, Expression<Func<int>> bodyRoomMateGroupSortOrder = null, Expression<Func<bool>> bodyRoomMateShowInSearch = null, Expression<Func<string>> bodyRoomPreferenceComments = null, Expression<Func<int>> bodyRoomSelectionNumber = null, Expression<Func<string>> bodyRoomSelectionTimeslot = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyTermID = null, Expression<Func<bool>> bodyWeb = null)
        {
            var apiCallPath = "/select/EntryApplication.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAllocateOptionEnum != null)
            {
                body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(bodyAllocateOptionEnum);
                bodypropCount++;
            }

            var ApplicationDateObject = new JObject();
            var ApplicationDateObjectpropCount = 0;
            if (bodyApplicationDateValue != null)
            {
                ApplicationDateObject["Value"] = ExpressionConverter.ConvertO(bodyApplicationDateValue);
                ApplicationDateObjectpropCount++;
            }

            if (bodyApplicationDateOperator != null)
            {
                ApplicationDateObject["_operator"] = ExpressionConverter.ConvertO(bodyApplicationDateOperator);
                ApplicationDateObjectpropCount++;
            }

            if (ApplicationDateObjectpropCount > 0)
            {
                body["ApplicationDate"] = ApplicationDateObject;
                bodypropCount++;
            }

            if (bodyApplicationStatusID != null)
            {
                body["ApplicationStatusID"] = ExpressionConverter.ConvertO(bodyApplicationStatusID);
                bodypropCount++;
            }

            var CancelDateObject = new JObject();
            var CancelDateObjectpropCount = 0;
            if (bodyCancelDateValue != null)
            {
                CancelDateObject["Value"] = ExpressionConverter.ConvertO(bodyCancelDateValue);
                CancelDateObjectpropCount++;
            }

            if (bodyCancelDateOperator != null)
            {
                CancelDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCancelDateOperator);
                CancelDateObjectpropCount++;
            }

            if (CancelDateObjectpropCount > 0)
            {
                body["CancelDate"] = CancelDateObject;
                bodypropCount++;
            }

            if (bodyClassificationID != null)
            {
                body["ClassificationID"] = ExpressionConverter.ConvertO(bodyClassificationID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCommentsInternal != null)
            {
                body["CommentsInternal"] = ExpressionConverter.ConvertO(bodyCommentsInternal);
                bodypropCount++;
            }

            var CompleteDateObject = new JObject();
            var CompleteDateObjectpropCount = 0;
            if (bodyCompleteDateValue != null)
            {
                CompleteDateObject["Value"] = ExpressionConverter.ConvertO(bodyCompleteDateValue);
                CompleteDateObjectpropCount++;
            }

            if (bodyCompleteDateOperator != null)
            {
                CompleteDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCompleteDateOperator);
                CompleteDateObjectpropCount++;
            }

            if (CompleteDateObjectpropCount > 0)
            {
                body["CompleteDate"] = CompleteDateObject;
                bodypropCount++;
            }

            var ContractSignedDateObject = new JObject();
            var ContractSignedDateObjectpropCount = 0;
            if (bodyContractSignedDateValue != null)
            {
                ContractSignedDateObject["Value"] = ExpressionConverter.ConvertO(bodyContractSignedDateValue);
                ContractSignedDateObjectpropCount++;
            }

            if (bodyContractSignedDateOperator != null)
            {
                ContractSignedDateObject["_operator"] = ExpressionConverter.ConvertO(bodyContractSignedDateOperator);
                ContractSignedDateObjectpropCount++;
            }

            if (ContractSignedDateObjectpropCount > 0)
            {
                body["ContractSignedDate"] = ContractSignedDateObject;
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            var CustomDate3Object = new JObject();
            var CustomDate3ObjectpropCount = 0;
            if (bodyCustomDate3Value != null)
            {
                CustomDate3Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate3Value);
                CustomDate3ObjectpropCount++;
            }

            if (bodyCustomDate3Operator != null)
            {
                CustomDate3Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate3Operator);
                CustomDate3ObjectpropCount++;
            }

            if (CustomDate3ObjectpropCount > 0)
            {
                body["CustomDate3"] = CustomDate3Object;
                bodypropCount++;
            }

            var CustomDate4Object = new JObject();
            var CustomDate4ObjectpropCount = 0;
            if (bodyCustomDate4Value != null)
            {
                CustomDate4Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate4Value);
                CustomDate4ObjectpropCount++;
            }

            if (bodyCustomDate4Operator != null)
            {
                CustomDate4Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate4Operator);
                CustomDate4ObjectpropCount++;
            }

            if (CustomDate4ObjectpropCount > 0)
            {
                body["CustomDate4"] = CustomDate4Object;
                bodypropCount++;
            }

            var DateCreatedObject = new JObject();
            var DateCreatedObjectpropCount = 0;
            if (bodyDateCreatedValue != null)
            {
                DateCreatedObject["Value"] = ExpressionConverter.ConvertO(bodyDateCreatedValue);
                DateCreatedObjectpropCount++;
            }

            if (bodyDateCreatedOperator != null)
            {
                DateCreatedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateCreatedOperator);
                DateCreatedObjectpropCount++;
            }

            if (DateCreatedObjectpropCount > 0)
            {
                body["DateCreated"] = DateCreatedObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            var EnquiryDateObject = new JObject();
            var EnquiryDateObjectpropCount = 0;
            if (bodyEnquiryDateValue != null)
            {
                EnquiryDateObject["Value"] = ExpressionConverter.ConvertO(bodyEnquiryDateValue);
                EnquiryDateObjectpropCount++;
            }

            if (bodyEnquiryDateOperator != null)
            {
                EnquiryDateObject["_operator"] = ExpressionConverter.ConvertO(bodyEnquiryDateOperator);
                EnquiryDateObjectpropCount++;
            }

            if (EnquiryDateObjectpropCount > 0)
            {
                body["EnquiryDate"] = EnquiryDateObject;
                bodypropCount++;
            }

            if (bodyEntryApplicationID != null)
            {
                body["EntryApplicationID"] = ExpressionConverter.ConvertO(bodyEntryApplicationID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            var ExpectedArrivalDateObject = new JObject();
            var ExpectedArrivalDateObjectpropCount = 0;
            if (bodyExpectedArrivalDateValue != null)
            {
                ExpectedArrivalDateObject["Value"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateValue);
                ExpectedArrivalDateObjectpropCount++;
            }

            if (bodyExpectedArrivalDateOperator != null)
            {
                ExpectedArrivalDateObject["_operator"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateOperator);
                ExpectedArrivalDateObjectpropCount++;
            }

            if (ExpectedArrivalDateObjectpropCount > 0)
            {
                body["ExpectedArrivalDate"] = ExpectedArrivalDateObject;
                bodypropCount++;
            }

            var ExpectedArrivalDateLatestObject = new JObject();
            var ExpectedArrivalDateLatestObjectpropCount = 0;
            if (bodyExpectedArrivalDateLatestValue != null)
            {
                ExpectedArrivalDateLatestObject["Value"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateLatestValue);
                ExpectedArrivalDateLatestObjectpropCount++;
            }

            if (bodyExpectedArrivalDateLatestOperator != null)
            {
                ExpectedArrivalDateLatestObject["_operator"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateLatestOperator);
                ExpectedArrivalDateLatestObjectpropCount++;
            }

            if (ExpectedArrivalDateLatestObjectpropCount > 0)
            {
                body["ExpectedArrivalDateLatest"] = ExpectedArrivalDateLatestObject;
                bodypropCount++;
            }

            var ExpectedDepartureDateObject = new JObject();
            var ExpectedDepartureDateObjectpropCount = 0;
            if (bodyExpectedDepartureDateValue != null)
            {
                ExpectedDepartureDateObject["Value"] = ExpressionConverter.ConvertO(bodyExpectedDepartureDateValue);
                ExpectedDepartureDateObjectpropCount++;
            }

            if (bodyExpectedDepartureDateOperator != null)
            {
                ExpectedDepartureDateObject["_operator"] = ExpressionConverter.ConvertO(bodyExpectedDepartureDateOperator);
                ExpectedDepartureDateObjectpropCount++;
            }

            if (ExpectedDepartureDateObjectpropCount > 0)
            {
                body["ExpectedDepartureDate"] = ExpectedDepartureDateObject;
                bodypropCount++;
            }

            var OfferedDateObject = new JObject();
            var OfferedDateObjectpropCount = 0;
            if (bodyOfferedDateValue != null)
            {
                OfferedDateObject["Value"] = ExpressionConverter.ConvertO(bodyOfferedDateValue);
                OfferedDateObjectpropCount++;
            }

            if (bodyOfferedDateOperator != null)
            {
                OfferedDateObject["_operator"] = ExpressionConverter.ConvertO(bodyOfferedDateOperator);
                OfferedDateObjectpropCount++;
            }

            if (OfferedDateObjectpropCount > 0)
            {
                body["OfferedDate"] = OfferedDateObject;
                bodypropCount++;
            }

            var OfferReplyDateObject = new JObject();
            var OfferReplyDateObjectpropCount = 0;
            if (bodyOfferReplyDateValue != null)
            {
                OfferReplyDateObject["Value"] = ExpressionConverter.ConvertO(bodyOfferReplyDateValue);
                OfferReplyDateObjectpropCount++;
            }

            if (bodyOfferReplyDateOperator != null)
            {
                OfferReplyDateObject["_operator"] = ExpressionConverter.ConvertO(bodyOfferReplyDateOperator);
                OfferReplyDateObjectpropCount++;
            }

            if (OfferReplyDateObjectpropCount > 0)
            {
                body["OfferReplyDate"] = OfferReplyDateObject;
                bodypropCount++;
            }

            if (bodyOfferReplyEnum != null)
            {
                body["OfferReplyEnum"] = ExpressionConverter.ConvertO(bodyOfferReplyEnum);
                bodypropCount++;
            }

            if (bodyOfferReplyReason != null)
            {
                body["OfferReplyReason"] = ExpressionConverter.ConvertO(bodyOfferReplyReason);
                bodypropCount++;
            }

            var OfferSentDateObject = new JObject();
            var OfferSentDateObjectpropCount = 0;
            if (bodyOfferSentDateValue != null)
            {
                OfferSentDateObject["Value"] = ExpressionConverter.ConvertO(bodyOfferSentDateValue);
                OfferSentDateObjectpropCount++;
            }

            if (bodyOfferSentDateOperator != null)
            {
                OfferSentDateObject["_operator"] = ExpressionConverter.ConvertO(bodyOfferSentDateOperator);
                OfferSentDateObjectpropCount++;
            }

            if (OfferSentDateObjectpropCount > 0)
            {
                body["OfferSentDate"] = OfferSentDateObject;
                bodypropCount++;
            }

            if (bodyPortalTrackingOnly != null)
            {
                body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(bodyPortalTrackingOnly);
                bodypropCount++;
            }

            if (bodyPreferenceComments != null)
            {
                body["PreferenceComments"] = ExpressionConverter.ConvertO(bodyPreferenceComments);
                bodypropCount++;
            }

            if (bodyRating != null)
            {
                body["Rating"] = ExpressionConverter.ConvertO(bodyRating);
                bodypropCount++;
            }

            var ReceivedDateObject = new JObject();
            var ReceivedDateObjectpropCount = 0;
            if (bodyReceivedDateValue != null)
            {
                ReceivedDateObject["Value"] = ExpressionConverter.ConvertO(bodyReceivedDateValue);
                ReceivedDateObjectpropCount++;
            }

            if (bodyReceivedDateOperator != null)
            {
                ReceivedDateObject["_operator"] = ExpressionConverter.ConvertO(bodyReceivedDateOperator);
                ReceivedDateObjectpropCount++;
            }

            if (ReceivedDateObjectpropCount > 0)
            {
                body["ReceivedDate"] = ReceivedDateObject;
                bodypropCount++;
            }

            if (bodyReceivedDeposit != null)
            {
                body["ReceivedDeposit"] = ExpressionConverter.ConvertO(bodyReceivedDeposit);
                bodypropCount++;
            }

            if (bodyReceivedDepositWaived != null)
            {
                body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(bodyReceivedDepositWaived);
                bodypropCount++;
            }

            if (bodyReceivedDepositPaymentID != null)
            {
                body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositWebPaymentID != null)
            {
                body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositAmount != null)
            {
                body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(bodyReceivedDepositAmount);
                bodypropCount++;
            }

            var ReceivedDepositDateObject = new JObject();
            var ReceivedDepositDateObjectpropCount = 0;
            if (bodyReceivedDepositDateValue != null)
            {
                ReceivedDepositDateObject["Value"] = ExpressionConverter.ConvertO(bodyReceivedDepositDateValue);
                ReceivedDepositDateObjectpropCount++;
            }

            if (bodyReceivedDepositDateOperator != null)
            {
                ReceivedDepositDateObject["_operator"] = ExpressionConverter.ConvertO(bodyReceivedDepositDateOperator);
                ReceivedDepositDateObjectpropCount++;
            }

            if (ReceivedDepositDateObjectpropCount > 0)
            {
                body["ReceivedDepositDate"] = ReceivedDepositDateObject;
                bodypropCount++;
            }

            if (bodyReceivedFee != null)
            {
                body["ReceivedFee"] = ExpressionConverter.ConvertO(bodyReceivedFee);
                bodypropCount++;
            }

            if (bodyReceivedFeePaymentID != null)
            {
                body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeePaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeWebPaymentID != null)
            {
                body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeeWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeAmount != null)
            {
                body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(bodyReceivedFeeAmount);
                bodypropCount++;
            }

            var ReceivedFeeDateObject = new JObject();
            var ReceivedFeeDateObjectpropCount = 0;
            if (bodyReceivedFeeDateValue != null)
            {
                ReceivedFeeDateObject["Value"] = ExpressionConverter.ConvertO(bodyReceivedFeeDateValue);
                ReceivedFeeDateObjectpropCount++;
            }

            if (bodyReceivedFeeDateOperator != null)
            {
                ReceivedFeeDateObject["_operator"] = ExpressionConverter.ConvertO(bodyReceivedFeeDateOperator);
                ReceivedFeeDateObjectpropCount++;
            }

            if (ReceivedFeeDateObjectpropCount > 0)
            {
                body["ReceivedFeeDate"] = ReceivedFeeDateObject;
                bodypropCount++;
            }

            var ReceivedPhotoDateObject = new JObject();
            var ReceivedPhotoDateObjectpropCount = 0;
            if (bodyReceivedPhotoDateValue != null)
            {
                ReceivedPhotoDateObject["Value"] = ExpressionConverter.ConvertO(bodyReceivedPhotoDateValue);
                ReceivedPhotoDateObjectpropCount++;
            }

            if (bodyReceivedPhotoDateOperator != null)
            {
                ReceivedPhotoDateObject["_operator"] = ExpressionConverter.ConvertO(bodyReceivedPhotoDateOperator);
                ReceivedPhotoDateObjectpropCount++;
            }

            if (ReceivedPhotoDateObjectpropCount > 0)
            {
                body["ReceivedPhotoDate"] = ReceivedPhotoDateObject;
                bodypropCount++;
            }

            if (bodyReturning != null)
            {
                body["Returning"] = ExpressionConverter.ConvertO(bodyReturning);
                bodypropCount++;
            }

            if (bodyRoomMateDescription != null)
            {
                body["RoomMateDescription"] = ExpressionConverter.ConvertO(bodyRoomMateDescription);
                bodypropCount++;
            }

            if (bodyRoommateGroupID != null)
            {
                body["RoommateGroupID"] = ExpressionConverter.ConvertO(bodyRoommateGroupID);
                bodypropCount++;
            }

            if (bodyRoomMateGroupSortOrder != null)
            {
                body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(bodyRoomMateGroupSortOrder);
                bodypropCount++;
            }

            if (bodyRoomMateShowInSearch != null)
            {
                body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(bodyRoomMateShowInSearch);
                bodypropCount++;
            }

            if (bodyRoomPreferenceComments != null)
            {
                body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(bodyRoomPreferenceComments);
                bodypropCount++;
            }

            if (bodyRoomSelectionNumber != null)
            {
                body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(bodyRoomSelectionNumber);
                bodypropCount++;
            }

            if (bodyRoomSelectionTimeslot != null)
            {
                body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(bodyRoomSelectionTimeslot);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyWeb != null)
            {
                body["Web"] = ExpressionConverter.ConvertO(bodyWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryApplicationResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryApplicationResponse> CreateEntryApplication(Expression<Func<int>> bodyEntryID, Expression<Func<bodyAllocateOptionEnumInput>> bodyAllocateOptionEnum = null, Expression<Func<string>> bodyApplicationDate = null, Expression<Func<int>> bodyApplicationStatusID = null, Expression<Func<string>> bodyCancelDate = null, Expression<Func<int>> bodyClassificationID = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyCommentsInternal = null, Expression<Func<string>> bodyCompleteDate = null, Expression<Func<string>> bodyContractSignedDate = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomDate3 = null, Expression<Func<string>> bodyCustomDate4 = null, Expression<Func<string>> bodyEnquiryDate = null, Expression<Func<string>> bodyExpectedArrivalDate = null, Expression<Func<string>> bodyExpectedArrivalDateLatest = null, Expression<Func<string>> bodyExpectedDepartureDate = null, Expression<Func<string>> bodyOfferedDate = null, Expression<Func<string>> bodyOfferReplyDate = null, Expression<Func<bodyOfferReplyEnumInput>> bodyOfferReplyEnum = null, Expression<Func<string>> bodyOfferReplyReason = null, Expression<Func<string>> bodyOfferSentDate = null, Expression<Func<bool>> bodyPortalTrackingOnly = null, Expression<Func<string>> bodyPreferenceComments = null, Expression<Func<string>> bodyRating = null, Expression<Func<string>> bodyReceivedDate = null, Expression<Func<bool>> bodyReceivedDeposit = null, Expression<Func<int>> bodyReceivedDepositPaymentID = null, Expression<Func<int>> bodyReceivedDepositWebPaymentID = null, Expression<Func<double>> bodyReceivedDepositAmount = null, Expression<Func<string>> bodyReceivedDepositDate = null, Expression<Func<bool>> bodyReceivedDepositWaived = null, Expression<Func<bool>> bodyReceivedFee = null, Expression<Func<int>> bodyReceivedFeePaymentID = null, Expression<Func<int>> bodyReceivedFeeWebPaymentID = null, Expression<Func<double>> bodyReceivedFeeAmount = null, Expression<Func<string>> bodyReceivedFeeDate = null, Expression<Func<string>> bodyReceivedPhotoDate = null, Expression<Func<bool>> bodyReturning = null, Expression<Func<string>> bodyRoomMateDescription = null, Expression<Func<int>> bodyRoommateGroupID = null, Expression<Func<int>> bodyRoomMateGroupSortOrder = null, Expression<Func<bool>> bodyRoomMateShowInSearch = null, Expression<Func<string>> bodyRoomPreferenceComments = null, Expression<Func<int>> bodyRoomSelectionNumber = null, Expression<Func<string>> bodyRoomSelectionTimeslot = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyTermID = null, Expression<Func<bool>> bodyWeb = null)
        {
            var apiCallPath = "/create/entryapplication.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAllocateOptionEnum != null)
            {
                body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(bodyAllocateOptionEnum);
                bodypropCount++;
            }

            if (bodyApplicationDate != null)
            {
                body["ApplicationDate"] = ExpressionConverter.ConvertO(bodyApplicationDate);
                bodypropCount++;
            }

            if (bodyApplicationStatusID != null)
            {
                body["ApplicationStatusID"] = ExpressionConverter.ConvertO(bodyApplicationStatusID);
                bodypropCount++;
            }

            if (bodyCancelDate != null)
            {
                body["CancelDate"] = ExpressionConverter.ConvertO(bodyCancelDate);
                bodypropCount++;
            }

            if (bodyClassificationID != null)
            {
                body["ClassificationID"] = ExpressionConverter.ConvertO(bodyClassificationID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCommentsInternal != null)
            {
                body["CommentsInternal"] = ExpressionConverter.ConvertO(bodyCommentsInternal);
                bodypropCount++;
            }

            if (bodyCompleteDate != null)
            {
                body["CompleteDate"] = ExpressionConverter.ConvertO(bodyCompleteDate);
                bodypropCount++;
            }

            if (bodyContractSignedDate != null)
            {
                body["ContractSignedDate"] = ExpressionConverter.ConvertO(bodyContractSignedDate);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomDate3 != null)
            {
                body["CustomDate3"] = ExpressionConverter.ConvertO(bodyCustomDate3);
                bodypropCount++;
            }

            if (bodyCustomDate4 != null)
            {
                body["CustomDate4"] = ExpressionConverter.ConvertO(bodyCustomDate4);
                bodypropCount++;
            }

            if (bodyEnquiryDate != null)
            {
                body["EnquiryDate"] = ExpressionConverter.ConvertO(bodyEnquiryDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
            if (bodyExpectedArrivalDate != null)
            {
                body["ExpectedArrivalDate"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDate);
                bodypropCount++;
            }

            if (bodyExpectedArrivalDateLatest != null)
            {
                body["ExpectedArrivalDateLatest"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateLatest);
                bodypropCount++;
            }

            if (bodyExpectedDepartureDate != null)
            {
                body["ExpectedDepartureDate"] = ExpressionConverter.ConvertO(bodyExpectedDepartureDate);
                bodypropCount++;
            }

            if (bodyOfferedDate != null)
            {
                body["OfferedDate"] = ExpressionConverter.ConvertO(bodyOfferedDate);
                bodypropCount++;
            }

            if (bodyOfferReplyDate != null)
            {
                body["OfferReplyDate"] = ExpressionConverter.ConvertO(bodyOfferReplyDate);
                bodypropCount++;
            }

            if (bodyOfferReplyEnum != null)
            {
                body["OfferReplyEnum"] = ExpressionConverter.ConvertO(bodyOfferReplyEnum);
                bodypropCount++;
            }

            if (bodyOfferReplyReason != null)
            {
                body["OfferReplyReason"] = ExpressionConverter.ConvertO(bodyOfferReplyReason);
                bodypropCount++;
            }

            if (bodyOfferSentDate != null)
            {
                body["OfferSentDate"] = ExpressionConverter.ConvertO(bodyOfferSentDate);
                bodypropCount++;
            }

            if (bodyPortalTrackingOnly != null)
            {
                body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(bodyPortalTrackingOnly);
                bodypropCount++;
            }

            if (bodyPreferenceComments != null)
            {
                body["PreferenceComments"] = ExpressionConverter.ConvertO(bodyPreferenceComments);
                bodypropCount++;
            }

            if (bodyRating != null)
            {
                body["Rating"] = ExpressionConverter.ConvertO(bodyRating);
                bodypropCount++;
            }

            if (bodyReceivedDate != null)
            {
                body["ReceivedDate"] = ExpressionConverter.ConvertO(bodyReceivedDate);
                bodypropCount++;
            }

            if (bodyReceivedDeposit != null)
            {
                body["ReceivedDeposit"] = ExpressionConverter.ConvertO(bodyReceivedDeposit);
                bodypropCount++;
            }

            if (bodyReceivedDepositPaymentID != null)
            {
                body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositWebPaymentID != null)
            {
                body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositAmount != null)
            {
                body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(bodyReceivedDepositAmount);
                bodypropCount++;
            }

            if (bodyReceivedDepositDate != null)
            {
                body["ReceivedDepositDate"] = ExpressionConverter.ConvertO(bodyReceivedDepositDate);
                bodypropCount++;
            }

            if (bodyReceivedDepositWaived != null)
            {
                body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(bodyReceivedDepositWaived);
                bodypropCount++;
            }

            if (bodyReceivedFee != null)
            {
                body["ReceivedFee"] = ExpressionConverter.ConvertO(bodyReceivedFee);
                bodypropCount++;
            }

            if (bodyReceivedFeePaymentID != null)
            {
                body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeePaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeWebPaymentID != null)
            {
                body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeeWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeAmount != null)
            {
                body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(bodyReceivedFeeAmount);
                bodypropCount++;
            }

            if (bodyReceivedFeeDate != null)
            {
                body["ReceivedFeeDate"] = ExpressionConverter.ConvertO(bodyReceivedFeeDate);
                bodypropCount++;
            }

            if (bodyReceivedPhotoDate != null)
            {
                body["ReceivedPhotoDate"] = ExpressionConverter.ConvertO(bodyReceivedPhotoDate);
                bodypropCount++;
            }

            if (bodyReturning != null)
            {
                body["Returning"] = ExpressionConverter.ConvertO(bodyReturning);
                bodypropCount++;
            }

            if (bodyRoomMateDescription != null)
            {
                body["RoomMateDescription"] = ExpressionConverter.ConvertO(bodyRoomMateDescription);
                bodypropCount++;
            }

            if (bodyRoommateGroupID != null)
            {
                body["RoommateGroupID"] = ExpressionConverter.ConvertO(bodyRoommateGroupID);
                bodypropCount++;
            }

            if (bodyRoomMateGroupSortOrder != null)
            {
                body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(bodyRoomMateGroupSortOrder);
                bodypropCount++;
            }

            if (bodyRoomMateShowInSearch != null)
            {
                body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(bodyRoomMateShowInSearch);
                bodypropCount++;
            }

            if (bodyRoomPreferenceComments != null)
            {
                body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(bodyRoomPreferenceComments);
                bodypropCount++;
            }

            if (bodyRoomSelectionNumber != null)
            {
                body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(bodyRoomSelectionNumber);
                bodypropCount++;
            }

            if (bodyRoomSelectionTimeslot != null)
            {
                body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(bodyRoomSelectionTimeslot);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyWeb != null)
            {
                body["Web"] = ExpressionConverter.ConvertO(bodyWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEntryApplicationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryApplicationResponse> UpdateEntryApplication(Expression<Func<int>> entryApplicationID, Expression<Func<bodyAllocateOptionEnumInput>> bodyAllocateOptionEnum = null, Expression<Func<string>> bodyApplicationDate = null, Expression<Func<int>> bodyApplicationStatusID = null, Expression<Func<string>> bodyCancelDate = null, Expression<Func<int>> bodyClassificationID = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyCommentsInternal = null, Expression<Func<string>> bodyCompleteDate = null, Expression<Func<string>> bodyContractSignedDate = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomDate3 = null, Expression<Func<string>> bodyCustomDate4 = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyEnquiryDate = null, Expression<Func<string>> bodyExpectedArrivalDate = null, Expression<Func<string>> bodyExpectedArrivalDateLatest = null, Expression<Func<string>> bodyExpectedDepartureDate = null, Expression<Func<string>> bodyOfferedDate = null, Expression<Func<string>> bodyOfferReplyDate = null, Expression<Func<bodyOfferReplyEnumInput>> bodyOfferReplyEnum = null, Expression<Func<string>> bodyOfferReplyReason = null, Expression<Func<string>> bodyOfferSentDate = null, Expression<Func<bool>> bodyPortalTrackingOnly = null, Expression<Func<string>> bodyPreferenceComments = null, Expression<Func<string>> bodyRating = null, Expression<Func<string>> bodyReceivedDate = null, Expression<Func<bool>> bodyReceivedDeposit = null, Expression<Func<int>> bodyReceivedDepositPaymentID = null, Expression<Func<int>> bodyReceivedDepositWebPaymentID = null, Expression<Func<double>> bodyReceivedDepositAmount = null, Expression<Func<string>> bodyReceivedDepositDate = null, Expression<Func<bool>> bodyReceivedDepositWaived = null, Expression<Func<bool>> bodyReceivedFee = null, Expression<Func<int>> bodyReceivedFeePaymentID = null, Expression<Func<int>> bodyReceivedFeeWebPaymentID = null, Expression<Func<double>> bodyReceivedFeeAmount = null, Expression<Func<string>> bodyReceivedFeeDate = null, Expression<Func<string>> bodyReceivedPhotoDate = null, Expression<Func<bool>> bodyReturning = null, Expression<Func<string>> bodyRoomMateDescription = null, Expression<Func<int>> bodyRoommateGroupID = null, Expression<Func<int>> bodyRoomMateGroupSortOrder = null, Expression<Func<bool>> bodyRoomMateShowInSearch = null, Expression<Func<string>> bodyRoomPreferenceComments = null, Expression<Func<int>> bodyRoomSelectionNumber = null, Expression<Func<string>> bodyRoomSelectionTimeslot = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyTermID = null, Expression<Func<bool>> bodyWeb = null)
        {
            var apiCallPath = String.Format("/update/entryapplication.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryApplicationID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAllocateOptionEnum != null)
            {
                body["AllocateOptionEnum"] = ExpressionConverter.ConvertO(bodyAllocateOptionEnum);
                bodypropCount++;
            }

            if (bodyApplicationDate != null)
            {
                body["ApplicationDate"] = ExpressionConverter.ConvertO(bodyApplicationDate);
                bodypropCount++;
            }

            if (bodyApplicationStatusID != null)
            {
                body["ApplicationStatusID"] = ExpressionConverter.ConvertO(bodyApplicationStatusID);
                bodypropCount++;
            }

            if (bodyCancelDate != null)
            {
                body["CancelDate"] = ExpressionConverter.ConvertO(bodyCancelDate);
                bodypropCount++;
            }

            if (bodyClassificationID != null)
            {
                body["ClassificationID"] = ExpressionConverter.ConvertO(bodyClassificationID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCommentsInternal != null)
            {
                body["CommentsInternal"] = ExpressionConverter.ConvertO(bodyCommentsInternal);
                bodypropCount++;
            }

            if (bodyCompleteDate != null)
            {
                body["CompleteDate"] = ExpressionConverter.ConvertO(bodyCompleteDate);
                bodypropCount++;
            }

            if (bodyContractSignedDate != null)
            {
                body["ContractSignedDate"] = ExpressionConverter.ConvertO(bodyContractSignedDate);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomDate3 != null)
            {
                body["CustomDate3"] = ExpressionConverter.ConvertO(bodyCustomDate3);
                bodypropCount++;
            }

            if (bodyCustomDate4 != null)
            {
                body["CustomDate4"] = ExpressionConverter.ConvertO(bodyCustomDate4);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEnquiryDate != null)
            {
                body["EnquiryDate"] = ExpressionConverter.ConvertO(bodyEnquiryDate);
                bodypropCount++;
            }

            if (bodyExpectedArrivalDate != null)
            {
                body["ExpectedArrivalDate"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDate);
                bodypropCount++;
            }

            if (bodyExpectedArrivalDateLatest != null)
            {
                body["ExpectedArrivalDateLatest"] = ExpressionConverter.ConvertO(bodyExpectedArrivalDateLatest);
                bodypropCount++;
            }

            if (bodyExpectedDepartureDate != null)
            {
                body["ExpectedDepartureDate"] = ExpressionConverter.ConvertO(bodyExpectedDepartureDate);
                bodypropCount++;
            }

            if (bodyOfferedDate != null)
            {
                body["OfferedDate"] = ExpressionConverter.ConvertO(bodyOfferedDate);
                bodypropCount++;
            }

            if (bodyOfferReplyDate != null)
            {
                body["OfferReplyDate"] = ExpressionConverter.ConvertO(bodyOfferReplyDate);
                bodypropCount++;
            }

            if (bodyOfferReplyEnum != null)
            {
                body["OfferReplyEnum"] = ExpressionConverter.ConvertO(bodyOfferReplyEnum);
                bodypropCount++;
            }

            if (bodyOfferReplyReason != null)
            {
                body["OfferReplyReason"] = ExpressionConverter.ConvertO(bodyOfferReplyReason);
                bodypropCount++;
            }

            if (bodyOfferSentDate != null)
            {
                body["OfferSentDate"] = ExpressionConverter.ConvertO(bodyOfferSentDate);
                bodypropCount++;
            }

            if (bodyPortalTrackingOnly != null)
            {
                body["PortalTrackingOnly"] = ExpressionConverter.ConvertO(bodyPortalTrackingOnly);
                bodypropCount++;
            }

            if (bodyPreferenceComments != null)
            {
                body["PreferenceComments"] = ExpressionConverter.ConvertO(bodyPreferenceComments);
                bodypropCount++;
            }

            if (bodyRating != null)
            {
                body["Rating"] = ExpressionConverter.ConvertO(bodyRating);
                bodypropCount++;
            }

            if (bodyReceivedDate != null)
            {
                body["ReceivedDate"] = ExpressionConverter.ConvertO(bodyReceivedDate);
                bodypropCount++;
            }

            if (bodyReceivedDeposit != null)
            {
                body["ReceivedDeposit"] = ExpressionConverter.ConvertO(bodyReceivedDeposit);
                bodypropCount++;
            }

            if (bodyReceivedDepositPaymentID != null)
            {
                body["ReceivedDeposit_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositWebPaymentID != null)
            {
                body["ReceivedDeposit_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedDepositWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedDepositAmount != null)
            {
                body["ReceivedDepositAmount"] = ExpressionConverter.ConvertO(bodyReceivedDepositAmount);
                bodypropCount++;
            }

            if (bodyReceivedDepositDate != null)
            {
                body["ReceivedDepositDate"] = ExpressionConverter.ConvertO(bodyReceivedDepositDate);
                bodypropCount++;
            }

            if (bodyReceivedDepositWaived != null)
            {
                body["ReceivedDepositWaived"] = ExpressionConverter.ConvertO(bodyReceivedDepositWaived);
                bodypropCount++;
            }

            if (bodyReceivedFee != null)
            {
                body["ReceivedFee"] = ExpressionConverter.ConvertO(bodyReceivedFee);
                bodypropCount++;
            }

            if (bodyReceivedFeePaymentID != null)
            {
                body["ReceivedFee_PaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeePaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeWebPaymentID != null)
            {
                body["ReceivedFee_WebPaymentID"] = ExpressionConverter.ConvertO(bodyReceivedFeeWebPaymentID);
                bodypropCount++;
            }

            if (bodyReceivedFeeAmount != null)
            {
                body["ReceivedFeeAmount"] = ExpressionConverter.ConvertO(bodyReceivedFeeAmount);
                bodypropCount++;
            }

            if (bodyReceivedFeeDate != null)
            {
                body["ReceivedFeeDate"] = ExpressionConverter.ConvertO(bodyReceivedFeeDate);
                bodypropCount++;
            }

            if (bodyReceivedPhotoDate != null)
            {
                body["ReceivedPhotoDate"] = ExpressionConverter.ConvertO(bodyReceivedPhotoDate);
                bodypropCount++;
            }

            if (bodyReturning != null)
            {
                body["Returning"] = ExpressionConverter.ConvertO(bodyReturning);
                bodypropCount++;
            }

            if (bodyRoomMateDescription != null)
            {
                body["RoomMateDescription"] = ExpressionConverter.ConvertO(bodyRoomMateDescription);
                bodypropCount++;
            }

            if (bodyRoommateGroupID != null)
            {
                body["RoommateGroupID"] = ExpressionConverter.ConvertO(bodyRoommateGroupID);
                bodypropCount++;
            }

            if (bodyRoomMateGroupSortOrder != null)
            {
                body["RoomMateGroupSortOrder"] = ExpressionConverter.ConvertO(bodyRoomMateGroupSortOrder);
                bodypropCount++;
            }

            if (bodyRoomMateShowInSearch != null)
            {
                body["RoomMateShowInSearch"] = ExpressionConverter.ConvertO(bodyRoomMateShowInSearch);
                bodypropCount++;
            }

            if (bodyRoomPreferenceComments != null)
            {
                body["RoomPreferenceComments"] = ExpressionConverter.ConvertO(bodyRoomPreferenceComments);
                bodypropCount++;
            }

            if (bodyRoomSelectionNumber != null)
            {
                body["RoomSelectionNumber"] = ExpressionConverter.ConvertO(bodyRoomSelectionNumber);
                bodypropCount++;
            }

            if (bodyRoomSelectionTimeslot != null)
            {
                body["RoomSelectionTimeslot"] = ExpressionConverter.ConvertO(bodyRoomSelectionTimeslot);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyWeb != null)
            {
                body["Web"] = ExpressionConverter.ConvertO(bodyWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryApplicationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermSessionResponseItem[]> SelectTermSession(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyBookingTypeID = null, Expression<Func<int>> bodyCancelBookingDefaultEndBookingReasonID = null, Expression<Func<bodyCancelBookingUpdateEndBookingReasonBooleanAskEnumInput>> bodyCancelBookingUpdateEndBookingReasonBooleanAskEnum = null, Expression<Func<string>> bodyCheckInDateValue = null, Expression<Func<bodyCheckInDateOperatorInput>> bodyCheckInDateOperator = null, Expression<Func<bodyCheckInDateActualDecreaseBooleanAskEnumInput>> bodyCheckInDateActualDecreaseBooleanAskEnum = null, Expression<Func<bodyCheckInDateActualIncreaseBooleanAskEnumInput>> bodyCheckInDateActualIncreaseBooleanAskEnum = null, Expression<Func<int>> bodyCheckInDefaultStartBookingReasonID = null, Expression<Func<bodyCheckInUpdateStartBookingReasonBooleanAskEnumInput>> bodyCheckInUpdateStartBookingReasonBooleanAskEnum = null, Expression<Func<string>> bodyCheckOutDateValue = null, Expression<Func<bodyCheckOutDateOperatorInput>> bodyCheckOutDateOperator = null, Expression<Func<bodyCheckOutDateActualDecreaseBooleanAskEnumInput>> bodyCheckOutDateActualDecreaseBooleanAskEnum = null, Expression<Func<bodyCheckOutDateActualIncreaseBooleanAskEnumInput>> bodyCheckOutDateActualIncreaseBooleanAskEnum = null, Expression<Func<int>> bodyCheckOutDefaultEndBookingReasonID = null, Expression<Func<bodyCheckOutUpdateEndBookingReasonBooleanAskEnumInput>> bodyCheckOutUpdateEndBookingReasonBooleanAskEnum = null, Expression<Func<bodyContractDateCheckInDecreaseBooleanAskEnumInput>> bodyContractDateCheckInDecreaseBooleanAskEnum = null, Expression<Func<bodyContractDateCheckInIncreaseBooleanAskEnumInput>> bodyContractDateCheckInIncreaseBooleanAskEnum = null, Expression<Func<bodyContractDateCheckOutDecreaseBooleanAskEnumInput>> bodyContractDateCheckOutDecreaseBooleanAskEnum = null, Expression<Func<bodyContractDateCheckOutIncreaseBooleanAskEnumInput>> bodyContractDateCheckOutIncreaseBooleanAskEnum = null, Expression<Func<string>> bodyContractDateEndValue = null, Expression<Func<bodyContractDateEndOperatorInput>> bodyContractDateEndOperator = null, Expression<Func<string>> bodyContractDateStartValue = null, Expression<Func<bodyContractDateStartOperatorInput>> bodyContractDateStartOperator = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyEndBookingReasonID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<string>> bodyETA = null, Expression<Func<string>> bodyETD = null, Expression<Func<int>> bodyHousekeepingID = null, Expression<Func<bodyRecordTypeEnumInput>> bodyRecordTypeEnum = null, Expression<Func<bool>> bodyRoomLocationFixed = null, Expression<Func<int>> bodyRoomLocationID = null, Expression<Func<double>> bodyRoomRateAmount = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<int>> bodyRoomTypeID = null, Expression<Func<int>> bodyStartBookingReasonID = null, Expression<Func<int>> bodyTermID = null, Expression<Func<string>> bodyTermSessionCode = null, Expression<Func<int>> bodyTermSessionID = null, Expression<Func<bool>> bodyUseActiveBookingAsTemplate = null, Expression<Func<string>> bodyWebDescription = null)
        {
            var apiCallPath = "/select/TermSession.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyBookingTypeID != null)
            {
                body["BookingTypeID"] = ExpressionConverter.ConvertO(bodyBookingTypeID);
                bodypropCount++;
            }

            if (bodyCancelBookingDefaultEndBookingReasonID != null)
            {
                body["CancelBookingDefaultEnd_BookingReasonID"] = ExpressionConverter.ConvertO(bodyCancelBookingDefaultEndBookingReasonID);
                bodypropCount++;
            }

            if (bodyCancelBookingUpdateEndBookingReasonBooleanAskEnum != null)
            {
                body["CancelBookingUpdateEndBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCancelBookingUpdateEndBookingReasonBooleanAskEnum);
                bodypropCount++;
            }

            var CheckInDateObject = new JObject();
            var CheckInDateObjectpropCount = 0;
            if (bodyCheckInDateValue != null)
            {
                CheckInDateObject["Value"] = ExpressionConverter.ConvertO(bodyCheckInDateValue);
                CheckInDateObjectpropCount++;
            }

            if (bodyCheckInDateOperator != null)
            {
                CheckInDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckInDateOperator);
                CheckInDateObjectpropCount++;
            }

            if (CheckInDateObjectpropCount > 0)
            {
                body["CheckInDate"] = CheckInDateObject;
                bodypropCount++;
            }

            if (bodyCheckInDateActualDecreaseBooleanAskEnum != null)
            {
                body["CheckInDateActualDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckInDateActualDecreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyCheckInDateActualIncreaseBooleanAskEnum != null)
            {
                body["CheckInDateActualIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckInDateActualIncreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyCheckInDefaultStartBookingReasonID != null)
            {
                body["CheckInDefaultStart_BookingReasonID"] = ExpressionConverter.ConvertO(bodyCheckInDefaultStartBookingReasonID);
                bodypropCount++;
            }

            if (bodyCheckInUpdateStartBookingReasonBooleanAskEnum != null)
            {
                body["CheckInUpdateStartBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckInUpdateStartBookingReasonBooleanAskEnum);
                bodypropCount++;
            }

            var CheckOutDateObject = new JObject();
            var CheckOutDateObjectpropCount = 0;
            if (bodyCheckOutDateValue != null)
            {
                CheckOutDateObject["Value"] = ExpressionConverter.ConvertO(bodyCheckOutDateValue);
                CheckOutDateObjectpropCount++;
            }

            if (bodyCheckOutDateOperator != null)
            {
                CheckOutDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckOutDateOperator);
                CheckOutDateObjectpropCount++;
            }

            if (CheckOutDateObjectpropCount > 0)
            {
                body["CheckOutDate"] = CheckOutDateObject;
                bodypropCount++;
            }

            if (bodyCheckOutDateActualDecreaseBooleanAskEnum != null)
            {
                body["CheckOutDateActualDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckOutDateActualDecreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyCheckOutDateActualIncreaseBooleanAskEnum != null)
            {
                body["CheckOutDateActualIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckOutDateActualIncreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyCheckOutDefaultEndBookingReasonID != null)
            {
                body["CheckOutDefaultEnd_BookingReasonID"] = ExpressionConverter.ConvertO(bodyCheckOutDefaultEndBookingReasonID);
                bodypropCount++;
            }

            if (bodyCheckOutUpdateEndBookingReasonBooleanAskEnum != null)
            {
                body["CheckOutUpdateEndBookingReason_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyCheckOutUpdateEndBookingReasonBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyContractDateCheckInDecreaseBooleanAskEnum != null)
            {
                body["ContractDateCheckInDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyContractDateCheckInDecreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyContractDateCheckInIncreaseBooleanAskEnum != null)
            {
                body["ContractDateCheckInIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyContractDateCheckInIncreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyContractDateCheckOutDecreaseBooleanAskEnum != null)
            {
                body["ContractDateCheckOutDecrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyContractDateCheckOutDecreaseBooleanAskEnum);
                bodypropCount++;
            }

            if (bodyContractDateCheckOutIncreaseBooleanAskEnum != null)
            {
                body["ContractDateCheckOutIncrease_BooleanAskEnum"] = ExpressionConverter.ConvertO(bodyContractDateCheckOutIncreaseBooleanAskEnum);
                bodypropCount++;
            }

            var ContractDateEndObject = new JObject();
            var ContractDateEndObjectpropCount = 0;
            if (bodyContractDateEndValue != null)
            {
                ContractDateEndObject["Value"] = ExpressionConverter.ConvertO(bodyContractDateEndValue);
                ContractDateEndObjectpropCount++;
            }

            if (bodyContractDateEndOperator != null)
            {
                ContractDateEndObject["_operator"] = ExpressionConverter.ConvertO(bodyContractDateEndOperator);
                ContractDateEndObjectpropCount++;
            }

            if (ContractDateEndObjectpropCount > 0)
            {
                body["ContractDateEnd"] = ContractDateEndObject;
                bodypropCount++;
            }

            var ContractDateStartObject = new JObject();
            var ContractDateStartObjectpropCount = 0;
            if (bodyContractDateStartValue != null)
            {
                ContractDateStartObject["Value"] = ExpressionConverter.ConvertO(bodyContractDateStartValue);
                ContractDateStartObjectpropCount++;
            }

            if (bodyContractDateStartOperator != null)
            {
                ContractDateStartObject["_operator"] = ExpressionConverter.ConvertO(bodyContractDateStartOperator);
                ContractDateStartObjectpropCount++;
            }

            if (ContractDateStartObjectpropCount > 0)
            {
                body["ContractDateStart"] = ContractDateStartObject;
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyEndBookingReasonID != null)
            {
                body["End_BookingReasonID"] = ExpressionConverter.ConvertO(bodyEndBookingReasonID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyETA != null)
            {
                body["ETA"] = ExpressionConverter.ConvertO(bodyETA);
                bodypropCount++;
            }

            if (bodyETD != null)
            {
                body["ETD"] = ExpressionConverter.ConvertO(bodyETD);
                bodypropCount++;
            }

            if (bodyHousekeepingID != null)
            {
                body["HousekeepingID"] = ExpressionConverter.ConvertO(bodyHousekeepingID);
                bodypropCount++;
            }

            if (bodyRecordTypeEnum != null)
            {
                body["RecordTypeEnum"] = ExpressionConverter.ConvertO(bodyRecordTypeEnum);
                bodypropCount++;
            }

            if (bodyRoomLocationFixed != null)
            {
                body["RoomLocationFixed"] = ExpressionConverter.ConvertO(bodyRoomLocationFixed);
                bodypropCount++;
            }

            if (bodyRoomLocationID != null)
            {
                body["RoomLocationID"] = ExpressionConverter.ConvertO(bodyRoomLocationID);
                bodypropCount++;
            }

            if (bodyRoomRateAmount != null)
            {
                body["RoomRateAmount"] = ExpressionConverter.ConvertO(bodyRoomRateAmount);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomTypeID != null)
            {
                body["RoomTypeID"] = ExpressionConverter.ConvertO(bodyRoomTypeID);
                bodypropCount++;
            }

            if (bodyStartBookingReasonID != null)
            {
                body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(bodyStartBookingReasonID);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyTermSessionCode != null)
            {
                body["TermSessionCode"] = ExpressionConverter.ConvertO(bodyTermSessionCode);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            if (bodyUseActiveBookingAsTemplate != null)
            {
                body["UseActiveBookingAsTemplate"] = ExpressionConverter.ConvertO(bodyUseActiveBookingAsTemplate);
                bodypropCount++;
            }

            if (bodyWebDescription != null)
            {
                body["WebDescription"] = ExpressionConverter.ConvertO(bodyWebDescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectTermSessionResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryDetailResponseItem[]> SelectEntryDetail(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyAcademicHold = null, Expression<Func<int>> bodyAccountPaymentTypeID = null, Expression<Func<bool>> bodyAccountHold = null, Expression<Func<string>> bodyAccountBankName = null, Expression<Func<string>> bodyAccountBankNumber = null, Expression<Func<string>> bodyAccountCode = null, Expression<Func<string>> bodyAccountComments = null, Expression<Func<string>> bodyAccountDetail1 = null, Expression<Func<string>> bodyAccountDetail2 = null, Expression<Func<string>> bodyAccountDetail3 = null, Expression<Func<string>> bodyAccountDetail4 = null, Expression<Func<string>> bodyAccountDueDateValue = null, Expression<Func<bodyAccountDueDateOperatorInput>> bodyAccountDueDateOperator = null, Expression<Func<bool>> bodyAthlete = null, Expression<Func<string>> bodyAthleteTeam = null, Expression<Func<bodyAttendeeStatusEnumInput>> bodyAttendeeStatusEnum = null, Expression<Func<string>> bodyCareer = null, Expression<Func<string>> bodyCareerComments = null, Expression<Func<int>> bodyCitizenshipCountryID = null, Expression<Func<int>> bodyClassificationID = null, Expression<Func<bool>> bodyClassificationOverride = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCountryOfBirthCountryID = null, Expression<Func<int>> bodyCountryOfResidenceCountryID = null, Expression<Func<double>> bodyCumulativeGPA = null, Expression<Func<double>> bodyCumulativeHours = null, Expression<Func<double>> bodyCurrentGPA = null, Expression<Func<double>> bodyCurrentHours = null, Expression<Func<string>> bodyCurrentMajor = null, Expression<Func<string>> bodyCurrentMinor = null, Expression<Func<string>> bodyDateEntryValue = null, Expression<Func<bodyDateEntryOperatorInput>> bodyDateEntryOperator = null, Expression<Func<string>> bodyDateExitValue = null, Expression<Func<bodyDateExitOperatorInput>> bodyDateExitOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<bool>> bodyDeceased = null, Expression<Func<string>> bodyDeceasedDateValue = null, Expression<Func<bodyDeceasedDateOperatorInput>> bodyDeceasedDateOperator = null, Expression<Func<string>> bodyDietary = null, Expression<Func<string>> bodyDisability = null, Expression<Func<string>> bodyEmploymentDetails = null, Expression<Func<string>> bodyEnrollmentClass = null, Expression<Func<string>> bodyEnrollmentLevel = null, Expression<Func<string>> bodyEnrollmentStatus = null, Expression<Func<string>> bodyEnrollmentTerm = null, Expression<Func<int>> bodyEnrollmentYear = null, Expression<Func<int>> bodyEntryDetailID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyEthnicity = null, Expression<Func<int>> bodyEventRegistrationFeeID = null, Expression<Func<string>> bodyExpectedGraduationDateValue = null, Expression<Func<bodyExpectedGraduationDateOperatorInput>> bodyExpectedGraduationDateOperator = null, Expression<Func<string>> bodyFinancialComments = null, Expression<Func<int>> bodyFinancialSupportID = null, Expression<Func<string>> bodyHearAboutUs = null, Expression<Func<bool>> bodyHonorsIndicator = null, Expression<Func<bool>> bodyImmunizationsHold = null, Expression<Func<bool>> bodyIncidentHold = null, Expression<Func<string>> bodyIncidentHoldComments = null, Expression<Func<bool>> bodyInternational = null, Expression<Func<string>> bodyInternationalDetails = null, Expression<Func<bool>> bodyLivingWithDependents = null, Expression<Func<bool>> bodyMarried = null, Expression<Func<string>> bodyMedical = null, Expression<Func<int>> bodyNationalityID = null, Expression<Func<string>> bodyOccupation = null, Expression<Func<string>> bodyPhotoPath = null, Expression<Func<string>> bodyPreviousMemberName = null, Expression<Func<string>> bodyPreviousMemberRelationship = null, Expression<Func<string>> bodyPreviousMembership = null, Expression<Func<string>> bodyPreviousMembershipYears = null, Expression<Func<string>> bodyPreviousMemberYears = null, Expression<Func<string>> bodyProfileInterests = null, Expression<Func<int>> bodyRegionOfBirthID = null, Expression<Func<string>> bodyReligion = null, Expression<Func<string>> bodyResidency = null, Expression<Func<string>> bodyResidentStatus = null, Expression<Func<int>> bodyResidentYear = null, Expression<Func<string>> bodySituationResponseComments = null, Expression<Func<string>> bodySituationResponseDetail = null, Expression<Func<bodySituationResponseEnumInput>> bodySituationResponseEnum = null, Expression<Func<string>> bodySituationResponseExpiryDateValue = null, Expression<Func<bodySituationResponseExpiryDateOperatorInput>> bodySituationResponseExpiryDateOperator = null, Expression<Func<string>> bodySituationResponseModifiedDateValue = null, Expression<Func<bodySituationResponseModifiedDateOperatorInput>> bodySituationResponseModifiedDateOperator = null, Expression<Func<string>> bodySituationResponseSituation = null, Expression<Func<string>> bodySpecialNeeds = null, Expression<Func<int>> bodyStaffID = null, Expression<Func<bool>> bodyUsesScreenReader = null, Expression<Func<string>> bodyVehicleDetails = null, Expression<Func<string>> bodyVehiclePermit = null, Expression<Func<string>> bodyVehicleRegistration = null, Expression<Func<string>> bodyVeteranStatus = null, Expression<Func<bool>> bodyVisa = null, Expression<Func<string>> bodyVisaDetails = null, Expression<Func<bool>> bodyVisitorHold = null)
        {
            var apiCallPath = "/select/EntryDetail.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAcademicHold != null)
            {
                body["AcademicHold"] = ExpressionConverter.ConvertO(bodyAcademicHold);
                bodypropCount++;
            }

            if (bodyAccountPaymentTypeID != null)
            {
                body["Account_PaymentTypeID"] = ExpressionConverter.ConvertO(bodyAccountPaymentTypeID);
                bodypropCount++;
            }

            if (bodyAccountHold != null)
            {
                body["AccountHold"] = ExpressionConverter.ConvertO(bodyAccountHold);
                bodypropCount++;
            }

            if (bodyAccountBankName != null)
            {
                body["AccountBankName"] = ExpressionConverter.ConvertO(bodyAccountBankName);
                bodypropCount++;
            }

            if (bodyAccountBankNumber != null)
            {
                body["AccountBankNumber"] = ExpressionConverter.ConvertO(bodyAccountBankNumber);
                bodypropCount++;
            }

            if (bodyAccountCode != null)
            {
                body["AccountCode"] = ExpressionConverter.ConvertO(bodyAccountCode);
                bodypropCount++;
            }

            if (bodyAccountComments != null)
            {
                body["AccountComments"] = ExpressionConverter.ConvertO(bodyAccountComments);
                bodypropCount++;
            }

            if (bodyAccountDetail1 != null)
            {
                body["AccountDetail1"] = ExpressionConverter.ConvertO(bodyAccountDetail1);
                bodypropCount++;
            }

            if (bodyAccountDetail2 != null)
            {
                body["AccountDetail2"] = ExpressionConverter.ConvertO(bodyAccountDetail2);
                bodypropCount++;
            }

            if (bodyAccountDetail3 != null)
            {
                body["AccountDetail3"] = ExpressionConverter.ConvertO(bodyAccountDetail3);
                bodypropCount++;
            }

            if (bodyAccountDetail4 != null)
            {
                body["AccountDetail4"] = ExpressionConverter.ConvertO(bodyAccountDetail4);
                bodypropCount++;
            }

            var AccountDueDateObject = new JObject();
            var AccountDueDateObjectpropCount = 0;
            if (bodyAccountDueDateValue != null)
            {
                AccountDueDateObject["Value"] = ExpressionConverter.ConvertO(bodyAccountDueDateValue);
                AccountDueDateObjectpropCount++;
            }

            if (bodyAccountDueDateOperator != null)
            {
                AccountDueDateObject["_operator"] = ExpressionConverter.ConvertO(bodyAccountDueDateOperator);
                AccountDueDateObjectpropCount++;
            }

            if (AccountDueDateObjectpropCount > 0)
            {
                body["AccountDueDate"] = AccountDueDateObject;
                bodypropCount++;
            }

            if (bodyAthlete != null)
            {
                body["Athlete"] = ExpressionConverter.ConvertO(bodyAthlete);
                bodypropCount++;
            }

            if (bodyAthleteTeam != null)
            {
                body["AthleteTeam"] = ExpressionConverter.ConvertO(bodyAthleteTeam);
                bodypropCount++;
            }

            if (bodyAttendeeStatusEnum != null)
            {
                body["AttendeeStatusEnum"] = ExpressionConverter.ConvertO(bodyAttendeeStatusEnum);
                bodypropCount++;
            }

            if (bodyCareer != null)
            {
                body["Career"] = ExpressionConverter.ConvertO(bodyCareer);
                bodypropCount++;
            }

            if (bodyCareerComments != null)
            {
                body["CareerComments"] = ExpressionConverter.ConvertO(bodyCareerComments);
                bodypropCount++;
            }

            if (bodyCitizenshipCountryID != null)
            {
                body["Citizenship_CountryID"] = ExpressionConverter.ConvertO(bodyCitizenshipCountryID);
                bodypropCount++;
            }

            if (bodyClassificationID != null)
            {
                body["ClassificationID"] = ExpressionConverter.ConvertO(bodyClassificationID);
                bodypropCount++;
            }

            if (bodyClassificationOverride != null)
            {
                body["ClassificationOverride"] = ExpressionConverter.ConvertO(bodyClassificationOverride);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCountryOfBirthCountryID != null)
            {
                body["CountryOfBirth_CountryID"] = ExpressionConverter.ConvertO(bodyCountryOfBirthCountryID);
                bodypropCount++;
            }

            if (bodyCountryOfResidenceCountryID != null)
            {
                body["CountryOfResidence_CountryID"] = ExpressionConverter.ConvertO(bodyCountryOfResidenceCountryID);
                bodypropCount++;
            }

            if (bodyCumulativeGPA != null)
            {
                body["CumulativeGPA"] = ExpressionConverter.ConvertO(bodyCumulativeGPA);
                bodypropCount++;
            }

            if (bodyCumulativeHours != null)
            {
                body["CumulativeHours"] = ExpressionConverter.ConvertO(bodyCumulativeHours);
                bodypropCount++;
            }

            if (bodyCurrentGPA != null)
            {
                body["CurrentGPA"] = ExpressionConverter.ConvertO(bodyCurrentGPA);
                bodypropCount++;
            }

            if (bodyCurrentHours != null)
            {
                body["CurrentHours"] = ExpressionConverter.ConvertO(bodyCurrentHours);
                bodypropCount++;
            }

            if (bodyCurrentMajor != null)
            {
                body["CurrentMajor"] = ExpressionConverter.ConvertO(bodyCurrentMajor);
                bodypropCount++;
            }

            if (bodyCurrentMinor != null)
            {
                body["CurrentMinor"] = ExpressionConverter.ConvertO(bodyCurrentMinor);
                bodypropCount++;
            }

            var DateEntryObject = new JObject();
            var DateEntryObjectpropCount = 0;
            if (bodyDateEntryValue != null)
            {
                DateEntryObject["Value"] = ExpressionConverter.ConvertO(bodyDateEntryValue);
                DateEntryObjectpropCount++;
            }

            if (bodyDateEntryOperator != null)
            {
                DateEntryObject["_operator"] = ExpressionConverter.ConvertO(bodyDateEntryOperator);
                DateEntryObjectpropCount++;
            }

            if (DateEntryObjectpropCount > 0)
            {
                body["DateEntry"] = DateEntryObject;
                bodypropCount++;
            }

            var DateExitObject = new JObject();
            var DateExitObjectpropCount = 0;
            if (bodyDateExitValue != null)
            {
                DateExitObject["Value"] = ExpressionConverter.ConvertO(bodyDateExitValue);
                DateExitObjectpropCount++;
            }

            if (bodyDateExitOperator != null)
            {
                DateExitObject["_operator"] = ExpressionConverter.ConvertO(bodyDateExitOperator);
                DateExitObjectpropCount++;
            }

            if (DateExitObjectpropCount > 0)
            {
                body["DateExit"] = DateExitObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDeceased != null)
            {
                body["Deceased"] = ExpressionConverter.ConvertO(bodyDeceased);
                bodypropCount++;
            }

            var DeceasedDateObject = new JObject();
            var DeceasedDateObjectpropCount = 0;
            if (bodyDeceasedDateValue != null)
            {
                DeceasedDateObject["Value"] = ExpressionConverter.ConvertO(bodyDeceasedDateValue);
                DeceasedDateObjectpropCount++;
            }

            if (bodyDeceasedDateOperator != null)
            {
                DeceasedDateObject["_operator"] = ExpressionConverter.ConvertO(bodyDeceasedDateOperator);
                DeceasedDateObjectpropCount++;
            }

            if (DeceasedDateObjectpropCount > 0)
            {
                body["DeceasedDate"] = DeceasedDateObject;
                bodypropCount++;
            }

            if (bodyDietary != null)
            {
                body["Dietary"] = ExpressionConverter.ConvertO(bodyDietary);
                bodypropCount++;
            }

            if (bodyDisability != null)
            {
                body["Disability"] = ExpressionConverter.ConvertO(bodyDisability);
                bodypropCount++;
            }

            if (bodyEmploymentDetails != null)
            {
                body["EmploymentDetails"] = ExpressionConverter.ConvertO(bodyEmploymentDetails);
                bodypropCount++;
            }

            if (bodyEnrollmentClass != null)
            {
                body["EnrollmentClass"] = ExpressionConverter.ConvertO(bodyEnrollmentClass);
                bodypropCount++;
            }

            if (bodyEnrollmentLevel != null)
            {
                body["EnrollmentLevel"] = ExpressionConverter.ConvertO(bodyEnrollmentLevel);
                bodypropCount++;
            }

            if (bodyEnrollmentStatus != null)
            {
                body["EnrollmentStatus"] = ExpressionConverter.ConvertO(bodyEnrollmentStatus);
                bodypropCount++;
            }

            if (bodyEnrollmentTerm != null)
            {
                body["EnrollmentTerm"] = ExpressionConverter.ConvertO(bodyEnrollmentTerm);
                bodypropCount++;
            }

            if (bodyEnrollmentYear != null)
            {
                body["EnrollmentYear"] = ExpressionConverter.ConvertO(bodyEnrollmentYear);
                bodypropCount++;
            }

            if (bodyEntryDetailID != null)
            {
                body["EntryDetailID"] = ExpressionConverter.ConvertO(bodyEntryDetailID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEthnicity != null)
            {
                body["Ethnicity"] = ExpressionConverter.ConvertO(bodyEthnicity);
                bodypropCount++;
            }

            if (bodyEventRegistrationFeeID != null)
            {
                body["EventRegistrationFeeID"] = ExpressionConverter.ConvertO(bodyEventRegistrationFeeID);
                bodypropCount++;
            }

            var ExpectedGraduationDateObject = new JObject();
            var ExpectedGraduationDateObjectpropCount = 0;
            if (bodyExpectedGraduationDateValue != null)
            {
                ExpectedGraduationDateObject["Value"] = ExpressionConverter.ConvertO(bodyExpectedGraduationDateValue);
                ExpectedGraduationDateObjectpropCount++;
            }

            if (bodyExpectedGraduationDateOperator != null)
            {
                ExpectedGraduationDateObject["_operator"] = ExpressionConverter.ConvertO(bodyExpectedGraduationDateOperator);
                ExpectedGraduationDateObjectpropCount++;
            }

            if (ExpectedGraduationDateObjectpropCount > 0)
            {
                body["ExpectedGraduationDate"] = ExpectedGraduationDateObject;
                bodypropCount++;
            }

            if (bodyFinancialComments != null)
            {
                body["FinancialComments"] = ExpressionConverter.ConvertO(bodyFinancialComments);
                bodypropCount++;
            }

            if (bodyFinancialSupportID != null)
            {
                body["FinancialSupportID"] = ExpressionConverter.ConvertO(bodyFinancialSupportID);
                bodypropCount++;
            }

            if (bodyHearAboutUs != null)
            {
                body["HearAboutUs"] = ExpressionConverter.ConvertO(bodyHearAboutUs);
                bodypropCount++;
            }

            if (bodyHonorsIndicator != null)
            {
                body["HonorsIndicator"] = ExpressionConverter.ConvertO(bodyHonorsIndicator);
                bodypropCount++;
            }

            if (bodyImmunizationsHold != null)
            {
                body["ImmunizationsHold"] = ExpressionConverter.ConvertO(bodyImmunizationsHold);
                bodypropCount++;
            }

            if (bodyIncidentHold != null)
            {
                body["IncidentHold"] = ExpressionConverter.ConvertO(bodyIncidentHold);
                bodypropCount++;
            }

            if (bodyIncidentHoldComments != null)
            {
                body["IncidentHoldComments"] = ExpressionConverter.ConvertO(bodyIncidentHoldComments);
                bodypropCount++;
            }

            if (bodyInternational != null)
            {
                body["International"] = ExpressionConverter.ConvertO(bodyInternational);
                bodypropCount++;
            }

            if (bodyInternationalDetails != null)
            {
                body["InternationalDetails"] = ExpressionConverter.ConvertO(bodyInternationalDetails);
                bodypropCount++;
            }

            if (bodyLivingWithDependents != null)
            {
                body["LivingWithDependents"] = ExpressionConverter.ConvertO(bodyLivingWithDependents);
                bodypropCount++;
            }

            if (bodyMarried != null)
            {
                body["Married"] = ExpressionConverter.ConvertO(bodyMarried);
                bodypropCount++;
            }

            if (bodyMedical != null)
            {
                body["Medical"] = ExpressionConverter.ConvertO(bodyMedical);
                bodypropCount++;
            }

            if (bodyNationalityID != null)
            {
                body["NationalityID"] = ExpressionConverter.ConvertO(bodyNationalityID);
                bodypropCount++;
            }

            if (bodyOccupation != null)
            {
                body["Occupation"] = ExpressionConverter.ConvertO(bodyOccupation);
                bodypropCount++;
            }

            if (bodyPhotoPath != null)
            {
                body["PhotoPath"] = ExpressionConverter.ConvertO(bodyPhotoPath);
                bodypropCount++;
            }

            if (bodyPreviousMemberName != null)
            {
                body["PreviousMemberName"] = ExpressionConverter.ConvertO(bodyPreviousMemberName);
                bodypropCount++;
            }

            if (bodyPreviousMemberRelationship != null)
            {
                body["PreviousMemberRelationship"] = ExpressionConverter.ConvertO(bodyPreviousMemberRelationship);
                bodypropCount++;
            }

            if (bodyPreviousMembership != null)
            {
                body["PreviousMembership"] = ExpressionConverter.ConvertO(bodyPreviousMembership);
                bodypropCount++;
            }

            if (bodyPreviousMembershipYears != null)
            {
                body["PreviousMembershipYears"] = ExpressionConverter.ConvertO(bodyPreviousMembershipYears);
                bodypropCount++;
            }

            if (bodyPreviousMemberYears != null)
            {
                body["PreviousMemberYears"] = ExpressionConverter.ConvertO(bodyPreviousMemberYears);
                bodypropCount++;
            }

            if (bodyProfileInterests != null)
            {
                body["ProfileInterests"] = ExpressionConverter.ConvertO(bodyProfileInterests);
                bodypropCount++;
            }

            if (bodyRegionOfBirthID != null)
            {
                body["RegionOfBirthID"] = ExpressionConverter.ConvertO(bodyRegionOfBirthID);
                bodypropCount++;
            }

            if (bodyReligion != null)
            {
                body["Religion"] = ExpressionConverter.ConvertO(bodyReligion);
                bodypropCount++;
            }

            if (bodyResidency != null)
            {
                body["Residency"] = ExpressionConverter.ConvertO(bodyResidency);
                bodypropCount++;
            }

            if (bodyResidentStatus != null)
            {
                body["ResidentStatus"] = ExpressionConverter.ConvertO(bodyResidentStatus);
                bodypropCount++;
            }

            if (bodyResidentYear != null)
            {
                body["ResidentYear"] = ExpressionConverter.ConvertO(bodyResidentYear);
                bodypropCount++;
            }

            if (bodySituationResponseComments != null)
            {
                body["SituationResponseComments"] = ExpressionConverter.ConvertO(bodySituationResponseComments);
                bodypropCount++;
            }

            if (bodySituationResponseDetail != null)
            {
                body["SituationResponseDetail"] = ExpressionConverter.ConvertO(bodySituationResponseDetail);
                bodypropCount++;
            }

            if (bodySituationResponseEnum != null)
            {
                body["SituationResponseEnum"] = ExpressionConverter.ConvertO(bodySituationResponseEnum);
                bodypropCount++;
            }

            var SituationResponseExpiryDateObject = new JObject();
            var SituationResponseExpiryDateObjectpropCount = 0;
            if (bodySituationResponseExpiryDateValue != null)
            {
                SituationResponseExpiryDateObject["Value"] = ExpressionConverter.ConvertO(bodySituationResponseExpiryDateValue);
                SituationResponseExpiryDateObjectpropCount++;
            }

            if (bodySituationResponseExpiryDateOperator != null)
            {
                SituationResponseExpiryDateObject["_operator"] = ExpressionConverter.ConvertO(bodySituationResponseExpiryDateOperator);
                SituationResponseExpiryDateObjectpropCount++;
            }

            if (SituationResponseExpiryDateObjectpropCount > 0)
            {
                body["SituationResponseExpiryDate"] = SituationResponseExpiryDateObject;
                bodypropCount++;
            }

            var SituationResponseModifiedDateObject = new JObject();
            var SituationResponseModifiedDateObjectpropCount = 0;
            if (bodySituationResponseModifiedDateValue != null)
            {
                SituationResponseModifiedDateObject["Value"] = ExpressionConverter.ConvertO(bodySituationResponseModifiedDateValue);
                SituationResponseModifiedDateObjectpropCount++;
            }

            if (bodySituationResponseModifiedDateOperator != null)
            {
                SituationResponseModifiedDateObject["_operator"] = ExpressionConverter.ConvertO(bodySituationResponseModifiedDateOperator);
                SituationResponseModifiedDateObjectpropCount++;
            }

            if (SituationResponseModifiedDateObjectpropCount > 0)
            {
                body["SituationResponseModifiedDate"] = SituationResponseModifiedDateObject;
                bodypropCount++;
            }

            if (bodySituationResponseSituation != null)
            {
                body["SituationResponseSituation"] = ExpressionConverter.ConvertO(bodySituationResponseSituation);
                bodypropCount++;
            }

            if (bodySpecialNeeds != null)
            {
                body["SpecialNeeds"] = ExpressionConverter.ConvertO(bodySpecialNeeds);
                bodypropCount++;
            }

            if (bodyStaffID != null)
            {
                body["StaffID"] = ExpressionConverter.ConvertO(bodyStaffID);
                bodypropCount++;
            }

            if (bodyUsesScreenReader != null)
            {
                body["UsesScreenReader"] = ExpressionConverter.ConvertO(bodyUsesScreenReader);
                bodypropCount++;
            }

            if (bodyVehicleDetails != null)
            {
                body["VehicleDetails"] = ExpressionConverter.ConvertO(bodyVehicleDetails);
                bodypropCount++;
            }

            if (bodyVehiclePermit != null)
            {
                body["VehiclePermit"] = ExpressionConverter.ConvertO(bodyVehiclePermit);
                bodypropCount++;
            }

            if (bodyVehicleRegistration != null)
            {
                body["VehicleRegistration"] = ExpressionConverter.ConvertO(bodyVehicleRegistration);
                bodypropCount++;
            }

            if (bodyVeteranStatus != null)
            {
                body["VeteranStatus"] = ExpressionConverter.ConvertO(bodyVeteranStatus);
                bodypropCount++;
            }

            if (bodyVisa != null)
            {
                body["Visa"] = ExpressionConverter.ConvertO(bodyVisa);
                bodypropCount++;
            }

            if (bodyVisaDetails != null)
            {
                body["VisaDetails"] = ExpressionConverter.ConvertO(bodyVisaDetails);
                bodypropCount++;
            }

            if (bodyVisitorHold != null)
            {
                body["VisitorHold"] = ExpressionConverter.ConvertO(bodyVisitorHold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryDetailResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryDetailResponse> UpdateEntryDetail(Expression<Func<int>> entryDetailID, Expression<Func<bool>> bodyAcademicHold = null, Expression<Func<int>> bodyAccountPaymentTypeID = null, Expression<Func<string>> bodyAccountBankName = null, Expression<Func<string>> bodyAccountBankNumber = null, Expression<Func<string>> bodyAccountCode = null, Expression<Func<string>> bodyAccountComments = null, Expression<Func<string>> bodyAccountDetail1 = null, Expression<Func<string>> bodyAccountDetail2 = null, Expression<Func<string>> bodyAccountDetail3 = null, Expression<Func<string>> bodyAccountDetail4 = null, Expression<Func<string>> bodyAccountDueDate = null, Expression<Func<bool>> bodyAccountHold = null, Expression<Func<bool>> bodyAthlete = null, Expression<Func<string>> bodyAthleteTeam = null, Expression<Func<bodyAttendeeStatusEnumInput>> bodyAttendeeStatusEnum = null, Expression<Func<string>> bodyCareer = null, Expression<Func<string>> bodyCareerComments = null, Expression<Func<int>> bodyCitizenshipCountryID = null, Expression<Func<int>> bodyClassificationID = null, Expression<Func<bool>> bodyClassificationOverride = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCountryOfBirthCountryID = null, Expression<Func<int>> bodyCountryOfResidenceCountryID = null, Expression<Func<double>> bodyCumulativeGPA = null, Expression<Func<double>> bodyCumulativeHours = null, Expression<Func<double>> bodyCurrentGPA = null, Expression<Func<double>> bodyCurrentHours = null, Expression<Func<string>> bodyCurrentMajor = null, Expression<Func<string>> bodyCurrentMinor = null, Expression<Func<string>> bodyDateEntry = null, Expression<Func<string>> bodyDateExit = null, Expression<Func<bool>> bodyDeceased = null, Expression<Func<string>> bodyDeceasedDate = null, Expression<Func<string>> bodyDietary = null, Expression<Func<string>> bodyDisability = null, Expression<Func<string>> bodyEmploymentDetails = null, Expression<Func<string>> bodyEnrollmentClass = null, Expression<Func<string>> bodyEnrollmentLevel = null, Expression<Func<string>> bodyEnrollmentStatus = null, Expression<Func<string>> bodyEnrollmentTerm = null, Expression<Func<int>> bodyEnrollmentYear = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyEthnicity = null, Expression<Func<int>> bodyEventRegistrationFeeID = null, Expression<Func<string>> bodyExpectedGraduationDate = null, Expression<Func<string>> bodyFinancialComments = null, Expression<Func<int>> bodyFinancialSupportID = null, Expression<Func<string>> bodyHearAboutUs = null, Expression<Func<bool>> bodyHonorsIndicator = null, Expression<Func<bool>> bodyImmunizationsHold = null, Expression<Func<bool>> bodyIncidentHold = null, Expression<Func<string>> bodyIncidentHoldComments = null, Expression<Func<bool>> bodyInternational = null, Expression<Func<string>> bodyInternationalDetails = null, Expression<Func<bool>> bodyLivingWithDependents = null, Expression<Func<bool>> bodyMarried = null, Expression<Func<string>> bodyMedical = null, Expression<Func<int>> bodyNationalityID = null, Expression<Func<string>> bodyOccupation = null, Expression<Func<string>> bodyPhotoPath = null, Expression<Func<string>> bodyPreviousMemberName = null, Expression<Func<string>> bodyPreviousMemberRelationship = null, Expression<Func<string>> bodyPreviousMembership = null, Expression<Func<string>> bodyPreviousMembershipYears = null, Expression<Func<string>> bodyPreviousMemberYears = null, Expression<Func<string>> bodyProfileInterests = null, Expression<Func<int>> bodyRegionOfBirthID = null, Expression<Func<string>> bodyReligion = null, Expression<Func<string>> bodyResidency = null, Expression<Func<string>> bodyResidentStatus = null, Expression<Func<int>> bodyResidentYear = null, Expression<Func<string>> bodySituationResponseComments = null, Expression<Func<string>> bodySituationResponseDetail = null, Expression<Func<bodySituationResponseEnumInput>> bodySituationResponseEnum = null, Expression<Func<string>> bodySituationResponseExpiryDate = null, Expression<Func<string>> bodySituationResponseModifiedDate = null, Expression<Func<string>> bodySituationResponseSituation = null, Expression<Func<string>> bodySpecialNeeds = null, Expression<Func<int>> bodyStaffID = null, Expression<Func<bool>> bodyUsesScreenReader = null, Expression<Func<string>> bodyVehicleDetails = null, Expression<Func<string>> bodyVehiclePermit = null, Expression<Func<string>> bodyVehicleRegistration = null, Expression<Func<string>> bodyVeteranStatus = null, Expression<Func<bool>> bodyVisa = null, Expression<Func<string>> bodyVisaDetails = null, Expression<Func<bool>> bodyVisitorHold = null)
        {
            var apiCallPath = String.Format("/update/entrydetail.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryDetailID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAcademicHold != null)
            {
                body["AcademicHold"] = ExpressionConverter.ConvertO(bodyAcademicHold);
                bodypropCount++;
            }

            if (bodyAccountPaymentTypeID != null)
            {
                body["Account_PaymentTypeID"] = ExpressionConverter.ConvertO(bodyAccountPaymentTypeID);
                bodypropCount++;
            }

            if (bodyAccountBankName != null)
            {
                body["AccountBankName"] = ExpressionConverter.ConvertO(bodyAccountBankName);
                bodypropCount++;
            }

            if (bodyAccountBankNumber != null)
            {
                body["AccountBankNumber"] = ExpressionConverter.ConvertO(bodyAccountBankNumber);
                bodypropCount++;
            }

            if (bodyAccountCode != null)
            {
                body["AccountCode"] = ExpressionConverter.ConvertO(bodyAccountCode);
                bodypropCount++;
            }

            if (bodyAccountComments != null)
            {
                body["AccountComments"] = ExpressionConverter.ConvertO(bodyAccountComments);
                bodypropCount++;
            }

            if (bodyAccountDetail1 != null)
            {
                body["AccountDetail1"] = ExpressionConverter.ConvertO(bodyAccountDetail1);
                bodypropCount++;
            }

            if (bodyAccountDetail2 != null)
            {
                body["AccountDetail2"] = ExpressionConverter.ConvertO(bodyAccountDetail2);
                bodypropCount++;
            }

            if (bodyAccountDetail3 != null)
            {
                body["AccountDetail3"] = ExpressionConverter.ConvertO(bodyAccountDetail3);
                bodypropCount++;
            }

            if (bodyAccountDetail4 != null)
            {
                body["AccountDetail4"] = ExpressionConverter.ConvertO(bodyAccountDetail4);
                bodypropCount++;
            }

            if (bodyAccountDueDate != null)
            {
                body["AccountDueDate"] = ExpressionConverter.ConvertO(bodyAccountDueDate);
                bodypropCount++;
            }

            if (bodyAccountHold != null)
            {
                body["AccountHold"] = ExpressionConverter.ConvertO(bodyAccountHold);
                bodypropCount++;
            }

            if (bodyAthlete != null)
            {
                body["Athlete"] = ExpressionConverter.ConvertO(bodyAthlete);
                bodypropCount++;
            }

            if (bodyAthleteTeam != null)
            {
                body["AthleteTeam"] = ExpressionConverter.ConvertO(bodyAthleteTeam);
                bodypropCount++;
            }

            if (bodyAttendeeStatusEnum != null)
            {
                body["AttendeeStatusEnum"] = ExpressionConverter.ConvertO(bodyAttendeeStatusEnum);
                bodypropCount++;
            }

            if (bodyCareer != null)
            {
                body["Career"] = ExpressionConverter.ConvertO(bodyCareer);
                bodypropCount++;
            }

            if (bodyCareerComments != null)
            {
                body["CareerComments"] = ExpressionConverter.ConvertO(bodyCareerComments);
                bodypropCount++;
            }

            if (bodyCitizenshipCountryID != null)
            {
                body["Citizenship_CountryID"] = ExpressionConverter.ConvertO(bodyCitizenshipCountryID);
                bodypropCount++;
            }

            if (bodyClassificationID != null)
            {
                body["ClassificationID"] = ExpressionConverter.ConvertO(bodyClassificationID);
                bodypropCount++;
            }

            if (bodyClassificationOverride != null)
            {
                body["ClassificationOverride"] = ExpressionConverter.ConvertO(bodyClassificationOverride);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCountryOfBirthCountryID != null)
            {
                body["CountryOfBirth_CountryID"] = ExpressionConverter.ConvertO(bodyCountryOfBirthCountryID);
                bodypropCount++;
            }

            if (bodyCountryOfResidenceCountryID != null)
            {
                body["CountryOfResidence_CountryID"] = ExpressionConverter.ConvertO(bodyCountryOfResidenceCountryID);
                bodypropCount++;
            }

            if (bodyCumulativeGPA != null)
            {
                body["CumulativeGPA"] = ExpressionConverter.ConvertO(bodyCumulativeGPA);
                bodypropCount++;
            }

            if (bodyCumulativeHours != null)
            {
                body["CumulativeHours"] = ExpressionConverter.ConvertO(bodyCumulativeHours);
                bodypropCount++;
            }

            if (bodyCurrentGPA != null)
            {
                body["CurrentGPA"] = ExpressionConverter.ConvertO(bodyCurrentGPA);
                bodypropCount++;
            }

            if (bodyCurrentHours != null)
            {
                body["CurrentHours"] = ExpressionConverter.ConvertO(bodyCurrentHours);
                bodypropCount++;
            }

            if (bodyCurrentMajor != null)
            {
                body["CurrentMajor"] = ExpressionConverter.ConvertO(bodyCurrentMajor);
                bodypropCount++;
            }

            if (bodyCurrentMinor != null)
            {
                body["CurrentMinor"] = ExpressionConverter.ConvertO(bodyCurrentMinor);
                bodypropCount++;
            }

            if (bodyDateEntry != null)
            {
                body["DateEntry"] = ExpressionConverter.ConvertO(bodyDateEntry);
                bodypropCount++;
            }

            if (bodyDateExit != null)
            {
                body["DateExit"] = ExpressionConverter.ConvertO(bodyDateExit);
                bodypropCount++;
            }

            if (bodyDeceased != null)
            {
                body["Deceased"] = ExpressionConverter.ConvertO(bodyDeceased);
                bodypropCount++;
            }

            if (bodyDeceasedDate != null)
            {
                body["DeceasedDate"] = ExpressionConverter.ConvertO(bodyDeceasedDate);
                bodypropCount++;
            }

            if (bodyDietary != null)
            {
                body["Dietary"] = ExpressionConverter.ConvertO(bodyDietary);
                bodypropCount++;
            }

            if (bodyDisability != null)
            {
                body["Disability"] = ExpressionConverter.ConvertO(bodyDisability);
                bodypropCount++;
            }

            if (bodyEmploymentDetails != null)
            {
                body["EmploymentDetails"] = ExpressionConverter.ConvertO(bodyEmploymentDetails);
                bodypropCount++;
            }

            if (bodyEnrollmentClass != null)
            {
                body["EnrollmentClass"] = ExpressionConverter.ConvertO(bodyEnrollmentClass);
                bodypropCount++;
            }

            if (bodyEnrollmentLevel != null)
            {
                body["EnrollmentLevel"] = ExpressionConverter.ConvertO(bodyEnrollmentLevel);
                bodypropCount++;
            }

            if (bodyEnrollmentStatus != null)
            {
                body["EnrollmentStatus"] = ExpressionConverter.ConvertO(bodyEnrollmentStatus);
                bodypropCount++;
            }

            if (bodyEnrollmentTerm != null)
            {
                body["EnrollmentTerm"] = ExpressionConverter.ConvertO(bodyEnrollmentTerm);
                bodypropCount++;
            }

            if (bodyEnrollmentYear != null)
            {
                body["EnrollmentYear"] = ExpressionConverter.ConvertO(bodyEnrollmentYear);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEthnicity != null)
            {
                body["Ethnicity"] = ExpressionConverter.ConvertO(bodyEthnicity);
                bodypropCount++;
            }

            if (bodyEventRegistrationFeeID != null)
            {
                body["EventRegistrationFeeID"] = ExpressionConverter.ConvertO(bodyEventRegistrationFeeID);
                bodypropCount++;
            }

            if (bodyExpectedGraduationDate != null)
            {
                body["ExpectedGraduationDate"] = ExpressionConverter.ConvertO(bodyExpectedGraduationDate);
                bodypropCount++;
            }

            if (bodyFinancialComments != null)
            {
                body["FinancialComments"] = ExpressionConverter.ConvertO(bodyFinancialComments);
                bodypropCount++;
            }

            if (bodyFinancialSupportID != null)
            {
                body["FinancialSupportID"] = ExpressionConverter.ConvertO(bodyFinancialSupportID);
                bodypropCount++;
            }

            if (bodyHearAboutUs != null)
            {
                body["HearAboutUs"] = ExpressionConverter.ConvertO(bodyHearAboutUs);
                bodypropCount++;
            }

            if (bodyHonorsIndicator != null)
            {
                body["HonorsIndicator"] = ExpressionConverter.ConvertO(bodyHonorsIndicator);
                bodypropCount++;
            }

            if (bodyImmunizationsHold != null)
            {
                body["ImmunizationsHold"] = ExpressionConverter.ConvertO(bodyImmunizationsHold);
                bodypropCount++;
            }

            if (bodyIncidentHold != null)
            {
                body["IncidentHold"] = ExpressionConverter.ConvertO(bodyIncidentHold);
                bodypropCount++;
            }

            if (bodyIncidentHoldComments != null)
            {
                body["IncidentHoldComments"] = ExpressionConverter.ConvertO(bodyIncidentHoldComments);
                bodypropCount++;
            }

            if (bodyInternational != null)
            {
                body["International"] = ExpressionConverter.ConvertO(bodyInternational);
                bodypropCount++;
            }

            if (bodyInternationalDetails != null)
            {
                body["InternationalDetails"] = ExpressionConverter.ConvertO(bodyInternationalDetails);
                bodypropCount++;
            }

            if (bodyLivingWithDependents != null)
            {
                body["LivingWithDependents"] = ExpressionConverter.ConvertO(bodyLivingWithDependents);
                bodypropCount++;
            }

            if (bodyMarried != null)
            {
                body["Married"] = ExpressionConverter.ConvertO(bodyMarried);
                bodypropCount++;
            }

            if (bodyMedical != null)
            {
                body["Medical"] = ExpressionConverter.ConvertO(bodyMedical);
                bodypropCount++;
            }

            if (bodyNationalityID != null)
            {
                body["NationalityID"] = ExpressionConverter.ConvertO(bodyNationalityID);
                bodypropCount++;
            }

            if (bodyOccupation != null)
            {
                body["Occupation"] = ExpressionConverter.ConvertO(bodyOccupation);
                bodypropCount++;
            }

            if (bodyPhotoPath != null)
            {
                body["PhotoPath"] = ExpressionConverter.ConvertO(bodyPhotoPath);
                bodypropCount++;
            }

            if (bodyPreviousMemberName != null)
            {
                body["PreviousMemberName"] = ExpressionConverter.ConvertO(bodyPreviousMemberName);
                bodypropCount++;
            }

            if (bodyPreviousMemberRelationship != null)
            {
                body["PreviousMemberRelationship"] = ExpressionConverter.ConvertO(bodyPreviousMemberRelationship);
                bodypropCount++;
            }

            if (bodyPreviousMembership != null)
            {
                body["PreviousMembership"] = ExpressionConverter.ConvertO(bodyPreviousMembership);
                bodypropCount++;
            }

            if (bodyPreviousMembershipYears != null)
            {
                body["PreviousMembershipYears"] = ExpressionConverter.ConvertO(bodyPreviousMembershipYears);
                bodypropCount++;
            }

            if (bodyPreviousMemberYears != null)
            {
                body["PreviousMemberYears"] = ExpressionConverter.ConvertO(bodyPreviousMemberYears);
                bodypropCount++;
            }

            if (bodyProfileInterests != null)
            {
                body["ProfileInterests"] = ExpressionConverter.ConvertO(bodyProfileInterests);
                bodypropCount++;
            }

            if (bodyRegionOfBirthID != null)
            {
                body["RegionOfBirthID"] = ExpressionConverter.ConvertO(bodyRegionOfBirthID);
                bodypropCount++;
            }

            if (bodyReligion != null)
            {
                body["Religion"] = ExpressionConverter.ConvertO(bodyReligion);
                bodypropCount++;
            }

            if (bodyResidency != null)
            {
                body["Residency"] = ExpressionConverter.ConvertO(bodyResidency);
                bodypropCount++;
            }

            if (bodyResidentStatus != null)
            {
                body["ResidentStatus"] = ExpressionConverter.ConvertO(bodyResidentStatus);
                bodypropCount++;
            }

            if (bodyResidentYear != null)
            {
                body["ResidentYear"] = ExpressionConverter.ConvertO(bodyResidentYear);
                bodypropCount++;
            }

            if (bodySituationResponseComments != null)
            {
                body["SituationResponseComments"] = ExpressionConverter.ConvertO(bodySituationResponseComments);
                bodypropCount++;
            }

            if (bodySituationResponseDetail != null)
            {
                body["SituationResponseDetail"] = ExpressionConverter.ConvertO(bodySituationResponseDetail);
                bodypropCount++;
            }

            if (bodySituationResponseEnum != null)
            {
                body["SituationResponseEnum"] = ExpressionConverter.ConvertO(bodySituationResponseEnum);
                bodypropCount++;
            }

            if (bodySituationResponseExpiryDate != null)
            {
                body["SituationResponseExpiryDate"] = ExpressionConverter.ConvertO(bodySituationResponseExpiryDate);
                bodypropCount++;
            }

            if (bodySituationResponseModifiedDate != null)
            {
                body["SituationResponseModifiedDate"] = ExpressionConverter.ConvertO(bodySituationResponseModifiedDate);
                bodypropCount++;
            }

            if (bodySituationResponseSituation != null)
            {
                body["SituationResponseSituation"] = ExpressionConverter.ConvertO(bodySituationResponseSituation);
                bodypropCount++;
            }

            if (bodySpecialNeeds != null)
            {
                body["SpecialNeeds"] = ExpressionConverter.ConvertO(bodySpecialNeeds);
                bodypropCount++;
            }

            if (bodyStaffID != null)
            {
                body["StaffID"] = ExpressionConverter.ConvertO(bodyStaffID);
                bodypropCount++;
            }

            if (bodyUsesScreenReader != null)
            {
                body["UsesScreenReader"] = ExpressionConverter.ConvertO(bodyUsesScreenReader);
                bodypropCount++;
            }

            if (bodyVehicleDetails != null)
            {
                body["VehicleDetails"] = ExpressionConverter.ConvertO(bodyVehicleDetails);
                bodypropCount++;
            }

            if (bodyVehiclePermit != null)
            {
                body["VehiclePermit"] = ExpressionConverter.ConvertO(bodyVehiclePermit);
                bodypropCount++;
            }

            if (bodyVehicleRegistration != null)
            {
                body["VehicleRegistration"] = ExpressionConverter.ConvertO(bodyVehicleRegistration);
                bodypropCount++;
            }

            if (bodyVeteranStatus != null)
            {
                body["VeteranStatus"] = ExpressionConverter.ConvertO(bodyVeteranStatus);
                bodypropCount++;
            }

            if (bodyVisa != null)
            {
                body["Visa"] = ExpressionConverter.ConvertO(bodyVisa);
                bodypropCount++;
            }

            if (bodyVisaDetails != null)
            {
                body["VisaDetails"] = ExpressionConverter.ConvertO(bodyVisaDetails);
                bodypropCount++;
            }

            if (bodyVisitorHold != null)
            {
                body["VisitorHold"] = ExpressionConverter.ConvertO(bodyVisitorHold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryDetailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryEnrollmentResponseItem[]> SelectEntryEnrollment(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodyCampus = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCourseID = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateEndValue = null, Expression<Func<bodyDateEndOperatorInput>> bodyDateEndOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDateStartValue = null, Expression<Func<bodyDateStartOperatorInput>> bodyDateStartOperator = null, Expression<Func<string>> bodyDepartment = null, Expression<Func<string>> bodyEnrollmentField = null, Expression<Func<int>> bodyEnrollmentOrder = null, Expression<Func<bodyEnrollmentTypeEnumInput>> bodyEnrollmentTypeEnum = null, Expression<Func<int>> bodyEntryEnrollmentID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyFaculty = null, Expression<Func<bool>> bodyFullTime = null, Expression<Func<string>> bodyGraduationDateValue = null, Expression<Func<bodyGraduationDateOperatorInput>> bodyGraduationDateOperator = null, Expression<Func<string>> bodyInstitution = null, Expression<Func<bool>> bodyIsEnrolled = null, Expression<Func<string>> bodyMajor = null, Expression<Func<string>> bodyMajorCategory = null, Expression<Func<string>> bodyMinor = null, Expression<Func<bool>> bodyPostGrad = null, Expression<Func<int>> bodySequence = null, Expression<Func<string>> bodySubjects = null, Expression<Func<int>> bodyTermID = null, Expression<Func<string>> bodyYears = null)
        {
            var apiCallPath = "/select/EntryEnrollment.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyCampus != null)
            {
                body["Campus"] = ExpressionConverter.ConvertO(bodyCampus);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCourseID != null)
            {
                body["CourseID"] = ExpressionConverter.ConvertO(bodyCourseID);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            var DateEndObject = new JObject();
            var DateEndObjectpropCount = 0;
            if (bodyDateEndValue != null)
            {
                DateEndObject["Value"] = ExpressionConverter.ConvertO(bodyDateEndValue);
                DateEndObjectpropCount++;
            }

            if (bodyDateEndOperator != null)
            {
                DateEndObject["_operator"] = ExpressionConverter.ConvertO(bodyDateEndOperator);
                DateEndObjectpropCount++;
            }

            if (DateEndObjectpropCount > 0)
            {
                body["DateEnd"] = DateEndObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            var DateStartObject = new JObject();
            var DateStartObjectpropCount = 0;
            if (bodyDateStartValue != null)
            {
                DateStartObject["Value"] = ExpressionConverter.ConvertO(bodyDateStartValue);
                DateStartObjectpropCount++;
            }

            if (bodyDateStartOperator != null)
            {
                DateStartObject["_operator"] = ExpressionConverter.ConvertO(bodyDateStartOperator);
                DateStartObjectpropCount++;
            }

            if (DateStartObjectpropCount > 0)
            {
                body["DateStart"] = DateStartObject;
                bodypropCount++;
            }

            if (bodyDepartment != null)
            {
                body["Department"] = ExpressionConverter.ConvertO(bodyDepartment);
                bodypropCount++;
            }

            if (bodyEnrollmentField != null)
            {
                body["EnrollmentField"] = ExpressionConverter.ConvertO(bodyEnrollmentField);
                bodypropCount++;
            }

            if (bodyEnrollmentOrder != null)
            {
                body["EnrollmentOrder"] = ExpressionConverter.ConvertO(bodyEnrollmentOrder);
                bodypropCount++;
            }

            if (bodyEnrollmentTypeEnum != null)
            {
                body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(bodyEnrollmentTypeEnum);
                bodypropCount++;
            }

            if (bodyEntryEnrollmentID != null)
            {
                body["EntryEnrollmentID"] = ExpressionConverter.ConvertO(bodyEntryEnrollmentID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyFaculty != null)
            {
                body["Faculty"] = ExpressionConverter.ConvertO(bodyFaculty);
                bodypropCount++;
            }

            if (bodyFullTime != null)
            {
                body["FullTime"] = ExpressionConverter.ConvertO(bodyFullTime);
                bodypropCount++;
            }

            var GraduationDateObject = new JObject();
            var GraduationDateObjectpropCount = 0;
            if (bodyGraduationDateValue != null)
            {
                GraduationDateObject["Value"] = ExpressionConverter.ConvertO(bodyGraduationDateValue);
                GraduationDateObjectpropCount++;
            }

            if (bodyGraduationDateOperator != null)
            {
                GraduationDateObject["_operator"] = ExpressionConverter.ConvertO(bodyGraduationDateOperator);
                GraduationDateObjectpropCount++;
            }

            if (GraduationDateObjectpropCount > 0)
            {
                body["GraduationDate"] = GraduationDateObject;
                bodypropCount++;
            }

            if (bodyInstitution != null)
            {
                body["Institution"] = ExpressionConverter.ConvertO(bodyInstitution);
                bodypropCount++;
            }

            if (bodyIsEnrolled != null)
            {
                body["IsEnrolled"] = ExpressionConverter.ConvertO(bodyIsEnrolled);
                bodypropCount++;
            }

            if (bodyMajor != null)
            {
                body["Major"] = ExpressionConverter.ConvertO(bodyMajor);
                bodypropCount++;
            }

            if (bodyMajorCategory != null)
            {
                body["MajorCategory"] = ExpressionConverter.ConvertO(bodyMajorCategory);
                bodypropCount++;
            }

            if (bodyMinor != null)
            {
                body["Minor"] = ExpressionConverter.ConvertO(bodyMinor);
                bodypropCount++;
            }

            if (bodyPostGrad != null)
            {
                body["PostGrad"] = ExpressionConverter.ConvertO(bodyPostGrad);
                bodypropCount++;
            }

            if (bodySequence != null)
            {
                body["Sequence"] = ExpressionConverter.ConvertO(bodySequence);
                bodypropCount++;
            }

            if (bodySubjects != null)
            {
                body["Subjects"] = ExpressionConverter.ConvertO(bodySubjects);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyYears != null)
            {
                body["Years"] = ExpressionConverter.ConvertO(bodyYears);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectEntryEnrollmentResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryEnrollmentResponse> CreateEntryEnrollment(Expression<Func<int>> bodyEntryID, Expression<Func<string>> bodyCampus = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCourseID = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateEnd = null, Expression<Func<string>> bodyDateStart = null, Expression<Func<string>> bodyDepartment = null, Expression<Func<string>> bodyEnrollmentField = null, Expression<Func<int>> bodyEnrollmentOrder = null, Expression<Func<bodyEnrollmentTypeEnumInput>> bodyEnrollmentTypeEnum = null, Expression<Func<string>> bodyFaculty = null, Expression<Func<bool>> bodyFullTime = null, Expression<Func<string>> bodyGraduationDate = null, Expression<Func<string>> bodyInstitution = null, Expression<Func<bool>> bodyIsEnrolled = null, Expression<Func<string>> bodyMajor = null, Expression<Func<string>> bodyMajorCategory = null, Expression<Func<string>> bodyMinor = null, Expression<Func<bool>> bodyPostGrad = null, Expression<Func<int>> bodySequence = null, Expression<Func<string>> bodySubjects = null, Expression<Func<int>> bodyTermID = null, Expression<Func<string>> bodyYears = null)
        {
            var apiCallPath = "/create/entryenrollment.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCampus != null)
            {
                body["Campus"] = ExpressionConverter.ConvertO(bodyCampus);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCourseID != null)
            {
                body["CourseID"] = ExpressionConverter.ConvertO(bodyCourseID);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyDateEnd != null)
            {
                body["DateEnd"] = ExpressionConverter.ConvertO(bodyDateEnd);
                bodypropCount++;
            }

            if (bodyDateStart != null)
            {
                body["DateStart"] = ExpressionConverter.ConvertO(bodyDateStart);
                bodypropCount++;
            }

            if (bodyDepartment != null)
            {
                body["Department"] = ExpressionConverter.ConvertO(bodyDepartment);
                bodypropCount++;
            }

            if (bodyEnrollmentField != null)
            {
                body["EnrollmentField"] = ExpressionConverter.ConvertO(bodyEnrollmentField);
                bodypropCount++;
            }

            if (bodyEnrollmentOrder != null)
            {
                body["EnrollmentOrder"] = ExpressionConverter.ConvertO(bodyEnrollmentOrder);
                bodypropCount++;
            }

            if (bodyEnrollmentTypeEnum != null)
            {
                body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(bodyEnrollmentTypeEnum);
                bodypropCount++;
            }

            bodypropCount++;
            body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
            if (bodyFaculty != null)
            {
                body["Faculty"] = ExpressionConverter.ConvertO(bodyFaculty);
                bodypropCount++;
            }

            if (bodyFullTime != null)
            {
                body["FullTime"] = ExpressionConverter.ConvertO(bodyFullTime);
                bodypropCount++;
            }

            if (bodyGraduationDate != null)
            {
                body["GraduationDate"] = ExpressionConverter.ConvertO(bodyGraduationDate);
                bodypropCount++;
            }

            if (bodyInstitution != null)
            {
                body["Institution"] = ExpressionConverter.ConvertO(bodyInstitution);
                bodypropCount++;
            }

            if (bodyIsEnrolled != null)
            {
                body["IsEnrolled"] = ExpressionConverter.ConvertO(bodyIsEnrolled);
                bodypropCount++;
            }

            if (bodyMajor != null)
            {
                body["Major"] = ExpressionConverter.ConvertO(bodyMajor);
                bodypropCount++;
            }

            if (bodyMajorCategory != null)
            {
                body["MajorCategory"] = ExpressionConverter.ConvertO(bodyMajorCategory);
                bodypropCount++;
            }

            if (bodyMinor != null)
            {
                body["Minor"] = ExpressionConverter.ConvertO(bodyMinor);
                bodypropCount++;
            }

            if (bodyPostGrad != null)
            {
                body["PostGrad"] = ExpressionConverter.ConvertO(bodyPostGrad);
                bodypropCount++;
            }

            if (bodySequence != null)
            {
                body["Sequence"] = ExpressionConverter.ConvertO(bodySequence);
                bodypropCount++;
            }

            if (bodySubjects != null)
            {
                body["Subjects"] = ExpressionConverter.ConvertO(bodySubjects);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyYears != null)
            {
                body["Years"] = ExpressionConverter.ConvertO(bodyYears);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEntryEnrollmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryEnrollmentResponse> UpdateEntryEnrollment(Expression<Func<int>> entryEnrollmentID, Expression<Func<string>> bodyCampus = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCourseID = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateEnd = null, Expression<Func<string>> bodyDateStart = null, Expression<Func<string>> bodyDepartment = null, Expression<Func<string>> bodyEnrollmentField = null, Expression<Func<int>> bodyEnrollmentOrder = null, Expression<Func<bodyEnrollmentTypeEnumInput>> bodyEnrollmentTypeEnum = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<string>> bodyFaculty = null, Expression<Func<bool>> bodyFullTime = null, Expression<Func<string>> bodyGraduationDate = null, Expression<Func<string>> bodyInstitution = null, Expression<Func<bool>> bodyIsEnrolled = null, Expression<Func<string>> bodyMajor = null, Expression<Func<string>> bodyMajorCategory = null, Expression<Func<string>> bodyMinor = null, Expression<Func<bool>> bodyPostGrad = null, Expression<Func<int>> bodySequence = null, Expression<Func<string>> bodySubjects = null, Expression<Func<int>> bodyTermID = null, Expression<Func<string>> bodyYears = null)
        {
            var apiCallPath = String.Format("/update/entryenrollment.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(entryEnrollmentID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCampus != null)
            {
                body["Campus"] = ExpressionConverter.ConvertO(bodyCampus);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCourseID != null)
            {
                body["CourseID"] = ExpressionConverter.ConvertO(bodyCourseID);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyDateEnd != null)
            {
                body["DateEnd"] = ExpressionConverter.ConvertO(bodyDateEnd);
                bodypropCount++;
            }

            if (bodyDateStart != null)
            {
                body["DateStart"] = ExpressionConverter.ConvertO(bodyDateStart);
                bodypropCount++;
            }

            if (bodyDepartment != null)
            {
                body["Department"] = ExpressionConverter.ConvertO(bodyDepartment);
                bodypropCount++;
            }

            if (bodyEnrollmentField != null)
            {
                body["EnrollmentField"] = ExpressionConverter.ConvertO(bodyEnrollmentField);
                bodypropCount++;
            }

            if (bodyEnrollmentOrder != null)
            {
                body["EnrollmentOrder"] = ExpressionConverter.ConvertO(bodyEnrollmentOrder);
                bodypropCount++;
            }

            if (bodyEnrollmentTypeEnum != null)
            {
                body["EnrollmentTypeEnum"] = ExpressionConverter.ConvertO(bodyEnrollmentTypeEnum);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyFaculty != null)
            {
                body["Faculty"] = ExpressionConverter.ConvertO(bodyFaculty);
                bodypropCount++;
            }

            if (bodyFullTime != null)
            {
                body["FullTime"] = ExpressionConverter.ConvertO(bodyFullTime);
                bodypropCount++;
            }

            if (bodyGraduationDate != null)
            {
                body["GraduationDate"] = ExpressionConverter.ConvertO(bodyGraduationDate);
                bodypropCount++;
            }

            if (bodyInstitution != null)
            {
                body["Institution"] = ExpressionConverter.ConvertO(bodyInstitution);
                bodypropCount++;
            }

            if (bodyIsEnrolled != null)
            {
                body["IsEnrolled"] = ExpressionConverter.ConvertO(bodyIsEnrolled);
                bodypropCount++;
            }

            if (bodyMajor != null)
            {
                body["Major"] = ExpressionConverter.ConvertO(bodyMajor);
                bodypropCount++;
            }

            if (bodyMajorCategory != null)
            {
                body["MajorCategory"] = ExpressionConverter.ConvertO(bodyMajorCategory);
                bodypropCount++;
            }

            if (bodyMinor != null)
            {
                body["Minor"] = ExpressionConverter.ConvertO(bodyMinor);
                bodypropCount++;
            }

            if (bodyPostGrad != null)
            {
                body["PostGrad"] = ExpressionConverter.ConvertO(bodyPostGrad);
                bodypropCount++;
            }

            if (bodySequence != null)
            {
                body["Sequence"] = ExpressionConverter.ConvertO(bodySequence);
                bodypropCount++;
            }

            if (bodySubjects != null)
            {
                body["Subjects"] = ExpressionConverter.ConvertO(bodySubjects);
                bodypropCount++;
            }

            if (bodyTermID != null)
            {
                body["TermID"] = ExpressionConverter.ConvertO(bodyTermID);
                bodypropCount++;
            }

            if (bodyYears != null)
            {
                body["Years"] = ExpressionConverter.ConvertO(bodyYears);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEntryEnrollmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectBookingResponseItem[]> SelectBooking(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyAdditionalOccupantCount = null, Expression<Func<string>> bodyAutoAllocationDetail = null, Expression<Func<int>> bodyBookingID = null, Expression<Func<bodyBookingLinkTypeEnumInput>> bodyBookingLinkTypeEnum = null, Expression<Func<int>> bodyBookingTypeID = null, Expression<Func<string>> bodyCheckInDateValue = null, Expression<Func<bodyCheckInDateOperatorInput>> bodyCheckInDateOperator = null, Expression<Func<string>> bodyCheckInDateActualValue = null, Expression<Func<bodyCheckInDateActualOperatorInput>> bodyCheckInDateActualOperator = null, Expression<Func<string>> bodyCheckOutDateValue = null, Expression<Func<bodyCheckOutDateOperatorInput>> bodyCheckOutDateOperator = null, Expression<Func<string>> bodyCheckOutDateActualValue = null, Expression<Func<bodyCheckOutDateActualOperatorInput>> bodyCheckOutDateActualOperator = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyContractDateEndValue = null, Expression<Func<bodyContractDateEndOperatorInput>> bodyContractDateEndOperator = null, Expression<Func<string>> bodyContractDateStartValue = null, Expression<Func<bodyContractDateStartOperatorInput>> bodyContractDateStartOperator = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomDate3Value = null, Expression<Func<bodyCustomDate3OperatorInput>> bodyCustomDate3Operator = null, Expression<Func<string>> bodyCustomDate4Value = null, Expression<Func<bodyCustomDate4OperatorInput>> bodyCustomDate4Operator = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyCustomString7 = null, Expression<Func<string>> bodyCustomString8 = null, Expression<Func<string>> bodyCustomString9 = null, Expression<Func<string>> bodyCustomString10 = null, Expression<Func<string>> bodyDateBilledValue = null, Expression<Func<bodyDateBilledOperatorInput>> bodyDateBilledOperator = null, Expression<Func<string>> bodyDateChargedToValue = null, Expression<Func<bodyDateChargedToOperatorInput>> bodyDateChargedToOperator = null, Expression<Func<string>> bodyDateCreatedValue = null, Expression<Func<bodyDateCreatedOperatorInput>> bodyDateCreatedOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDateModifiedBillingValue = null, Expression<Func<bodyDateModifiedBillingOperatorInput>> bodyDateModifiedBillingOperator = null, Expression<Func<int>> bodyEmotionalSupportAnimalCount = null, Expression<Func<int>> bodyEndBookingReasonID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<int>> bodyEntryInvitationID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<string>> bodyETA = null, Expression<Func<string>> bodyETD = null, Expression<Func<double>> bodyExcess = null, Expression<Func<int>> bodyGroupID = null, Expression<Func<int>> bodyHousekeepingID = null, Expression<Func<int>> bodyNumberOfChildren = null, Expression<Func<int>> bodyNumberOfChildrenFree = null, Expression<Func<int>> bodyNumberOfGuests = null, Expression<Func<int>> bodyNumberOfGuestsFree = null, Expression<Func<string>> bodyPaidToValue = null, Expression<Func<bodyPaidToOperatorInput>> bodyPaidToOperator = null, Expression<Func<int>> bodyPetCount = null, Expression<Func<bool>> bodyResvChargeToEntry = null, Expression<Func<bool>> bodyRoomLocationFixed = null, Expression<Func<int>> bodyRoomLocationID = null, Expression<Func<double>> bodyRoomRateAmount = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<int>> bodyRoomTypeID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyServiceAnimalCount = null, Expression<Func<string>> bodySpecialRequirement = null, Expression<Func<int>> bodyStartBookingReasonID = null, Expression<Func<int>> bodyTermSessionID = null)
        {
            var apiCallPath = "/select/Booking.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAdditionalOccupantCount != null)
            {
                body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(bodyAdditionalOccupantCount);
                bodypropCount++;
            }

            if (bodyAutoAllocationDetail != null)
            {
                body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(bodyAutoAllocationDetail);
                bodypropCount++;
            }

            if (bodyBookingID != null)
            {
                body["BookingID"] = ExpressionConverter.ConvertO(bodyBookingID);
                bodypropCount++;
            }

            if (bodyBookingLinkTypeEnum != null)
            {
                body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(bodyBookingLinkTypeEnum);
                bodypropCount++;
            }

            if (bodyBookingTypeID != null)
            {
                body["BookingTypeID"] = ExpressionConverter.ConvertO(bodyBookingTypeID);
                bodypropCount++;
            }

            var CheckInDateObject = new JObject();
            var CheckInDateObjectpropCount = 0;
            if (bodyCheckInDateValue != null)
            {
                CheckInDateObject["Value"] = ExpressionConverter.ConvertO(bodyCheckInDateValue);
                CheckInDateObjectpropCount++;
            }

            if (bodyCheckInDateOperator != null)
            {
                CheckInDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckInDateOperator);
                CheckInDateObjectpropCount++;
            }

            if (CheckInDateObjectpropCount > 0)
            {
                body["CheckInDate"] = CheckInDateObject;
                bodypropCount++;
            }

            var CheckInDateActualObject = new JObject();
            var CheckInDateActualObjectpropCount = 0;
            if (bodyCheckInDateActualValue != null)
            {
                CheckInDateActualObject["Value"] = ExpressionConverter.ConvertO(bodyCheckInDateActualValue);
                CheckInDateActualObjectpropCount++;
            }

            if (bodyCheckInDateActualOperator != null)
            {
                CheckInDateActualObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckInDateActualOperator);
                CheckInDateActualObjectpropCount++;
            }

            if (CheckInDateActualObjectpropCount > 0)
            {
                body["CheckInDateActual"] = CheckInDateActualObject;
                bodypropCount++;
            }

            var CheckOutDateObject = new JObject();
            var CheckOutDateObjectpropCount = 0;
            if (bodyCheckOutDateValue != null)
            {
                CheckOutDateObject["Value"] = ExpressionConverter.ConvertO(bodyCheckOutDateValue);
                CheckOutDateObjectpropCount++;
            }

            if (bodyCheckOutDateOperator != null)
            {
                CheckOutDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckOutDateOperator);
                CheckOutDateObjectpropCount++;
            }

            if (CheckOutDateObjectpropCount > 0)
            {
                body["CheckOutDate"] = CheckOutDateObject;
                bodypropCount++;
            }

            var CheckOutDateActualObject = new JObject();
            var CheckOutDateActualObjectpropCount = 0;
            if (bodyCheckOutDateActualValue != null)
            {
                CheckOutDateActualObject["Value"] = ExpressionConverter.ConvertO(bodyCheckOutDateActualValue);
                CheckOutDateActualObjectpropCount++;
            }

            if (bodyCheckOutDateActualOperator != null)
            {
                CheckOutDateActualObject["_operator"] = ExpressionConverter.ConvertO(bodyCheckOutDateActualOperator);
                CheckOutDateActualObjectpropCount++;
            }

            if (CheckOutDateActualObjectpropCount > 0)
            {
                body["CheckOutDateActual"] = CheckOutDateActualObject;
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            var ContractDateEndObject = new JObject();
            var ContractDateEndObjectpropCount = 0;
            if (bodyContractDateEndValue != null)
            {
                ContractDateEndObject["Value"] = ExpressionConverter.ConvertO(bodyContractDateEndValue);
                ContractDateEndObjectpropCount++;
            }

            if (bodyContractDateEndOperator != null)
            {
                ContractDateEndObject["_operator"] = ExpressionConverter.ConvertO(bodyContractDateEndOperator);
                ContractDateEndObjectpropCount++;
            }

            if (ContractDateEndObjectpropCount > 0)
            {
                body["ContractDateEnd"] = ContractDateEndObject;
                bodypropCount++;
            }

            var ContractDateStartObject = new JObject();
            var ContractDateStartObjectpropCount = 0;
            if (bodyContractDateStartValue != null)
            {
                ContractDateStartObject["Value"] = ExpressionConverter.ConvertO(bodyContractDateStartValue);
                ContractDateStartObjectpropCount++;
            }

            if (bodyContractDateStartOperator != null)
            {
                ContractDateStartObject["_operator"] = ExpressionConverter.ConvertO(bodyContractDateStartOperator);
                ContractDateStartObjectpropCount++;
            }

            if (ContractDateStartObjectpropCount > 0)
            {
                body["ContractDateStart"] = ContractDateStartObject;
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            var CustomDate3Object = new JObject();
            var CustomDate3ObjectpropCount = 0;
            if (bodyCustomDate3Value != null)
            {
                CustomDate3Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate3Value);
                CustomDate3ObjectpropCount++;
            }

            if (bodyCustomDate3Operator != null)
            {
                CustomDate3Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate3Operator);
                CustomDate3ObjectpropCount++;
            }

            if (CustomDate3ObjectpropCount > 0)
            {
                body["CustomDate3"] = CustomDate3Object;
                bodypropCount++;
            }

            var CustomDate4Object = new JObject();
            var CustomDate4ObjectpropCount = 0;
            if (bodyCustomDate4Value != null)
            {
                CustomDate4Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate4Value);
                CustomDate4ObjectpropCount++;
            }

            if (bodyCustomDate4Operator != null)
            {
                CustomDate4Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate4Operator);
                CustomDate4ObjectpropCount++;
            }

            if (CustomDate4ObjectpropCount > 0)
            {
                body["CustomDate4"] = CustomDate4Object;
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyCustomString7 != null)
            {
                body["CustomString7"] = ExpressionConverter.ConvertO(bodyCustomString7);
                bodypropCount++;
            }

            if (bodyCustomString8 != null)
            {
                body["CustomString8"] = ExpressionConverter.ConvertO(bodyCustomString8);
                bodypropCount++;
            }

            if (bodyCustomString9 != null)
            {
                body["CustomString9"] = ExpressionConverter.ConvertO(bodyCustomString9);
                bodypropCount++;
            }

            if (bodyCustomString10 != null)
            {
                body["CustomString10"] = ExpressionConverter.ConvertO(bodyCustomString10);
                bodypropCount++;
            }

            var DateBilledObject = new JObject();
            var DateBilledObjectpropCount = 0;
            if (bodyDateBilledValue != null)
            {
                DateBilledObject["Value"] = ExpressionConverter.ConvertO(bodyDateBilledValue);
                DateBilledObjectpropCount++;
            }

            if (bodyDateBilledOperator != null)
            {
                DateBilledObject["_operator"] = ExpressionConverter.ConvertO(bodyDateBilledOperator);
                DateBilledObjectpropCount++;
            }

            if (DateBilledObjectpropCount > 0)
            {
                body["DateBilled"] = DateBilledObject;
                bodypropCount++;
            }

            var DateChargedToObject = new JObject();
            var DateChargedToObjectpropCount = 0;
            if (bodyDateChargedToValue != null)
            {
                DateChargedToObject["Value"] = ExpressionConverter.ConvertO(bodyDateChargedToValue);
                DateChargedToObjectpropCount++;
            }

            if (bodyDateChargedToOperator != null)
            {
                DateChargedToObject["_operator"] = ExpressionConverter.ConvertO(bodyDateChargedToOperator);
                DateChargedToObjectpropCount++;
            }

            if (DateChargedToObjectpropCount > 0)
            {
                body["DateChargedTo"] = DateChargedToObject;
                bodypropCount++;
            }

            var DateCreatedObject = new JObject();
            var DateCreatedObjectpropCount = 0;
            if (bodyDateCreatedValue != null)
            {
                DateCreatedObject["Value"] = ExpressionConverter.ConvertO(bodyDateCreatedValue);
                DateCreatedObjectpropCount++;
            }

            if (bodyDateCreatedOperator != null)
            {
                DateCreatedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateCreatedOperator);
                DateCreatedObjectpropCount++;
            }

            if (DateCreatedObjectpropCount > 0)
            {
                body["DateCreated"] = DateCreatedObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            var DateModifiedBillingObject = new JObject();
            var DateModifiedBillingObjectpropCount = 0;
            if (bodyDateModifiedBillingValue != null)
            {
                DateModifiedBillingObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedBillingValue);
                DateModifiedBillingObjectpropCount++;
            }

            if (bodyDateModifiedBillingOperator != null)
            {
                DateModifiedBillingObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedBillingOperator);
                DateModifiedBillingObjectpropCount++;
            }

            if (DateModifiedBillingObjectpropCount > 0)
            {
                body["DateModifiedBilling"] = DateModifiedBillingObject;
                bodypropCount++;
            }

            if (bodyEmotionalSupportAnimalCount != null)
            {
                body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(bodyEmotionalSupportAnimalCount);
                bodypropCount++;
            }

            if (bodyEndBookingReasonID != null)
            {
                body["End_BookingReasonID"] = ExpressionConverter.ConvertO(bodyEndBookingReasonID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEntryInvitationID != null)
            {
                body["EntryInvitationID"] = ExpressionConverter.ConvertO(bodyEntryInvitationID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyETA != null)
            {
                body["ETA"] = ExpressionConverter.ConvertO(bodyETA);
                bodypropCount++;
            }

            if (bodyETD != null)
            {
                body["ETD"] = ExpressionConverter.ConvertO(bodyETD);
                bodypropCount++;
            }

            if (bodyExcess != null)
            {
                body["Excess"] = ExpressionConverter.ConvertO(bodyExcess);
                bodypropCount++;
            }

            if (bodyGroupID != null)
            {
                body["GroupID"] = ExpressionConverter.ConvertO(bodyGroupID);
                bodypropCount++;
            }

            if (bodyHousekeepingID != null)
            {
                body["HousekeepingID"] = ExpressionConverter.ConvertO(bodyHousekeepingID);
                bodypropCount++;
            }

            if (bodyNumberOfChildren != null)
            {
                body["NumberOfChildren"] = ExpressionConverter.ConvertO(bodyNumberOfChildren);
                bodypropCount++;
            }

            if (bodyNumberOfChildrenFree != null)
            {
                body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(bodyNumberOfChildrenFree);
                bodypropCount++;
            }

            if (bodyNumberOfGuests != null)
            {
                body["NumberOfGuests"] = ExpressionConverter.ConvertO(bodyNumberOfGuests);
                bodypropCount++;
            }

            if (bodyNumberOfGuestsFree != null)
            {
                body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(bodyNumberOfGuestsFree);
                bodypropCount++;
            }

            var PaidToObject = new JObject();
            var PaidToObjectpropCount = 0;
            if (bodyPaidToValue != null)
            {
                PaidToObject["Value"] = ExpressionConverter.ConvertO(bodyPaidToValue);
                PaidToObjectpropCount++;
            }

            if (bodyPaidToOperator != null)
            {
                PaidToObject["_operator"] = ExpressionConverter.ConvertO(bodyPaidToOperator);
                PaidToObjectpropCount++;
            }

            if (PaidToObjectpropCount > 0)
            {
                body["PaidTo"] = PaidToObject;
                bodypropCount++;
            }

            if (bodyPetCount != null)
            {
                body["PetCount"] = ExpressionConverter.ConvertO(bodyPetCount);
                bodypropCount++;
            }

            if (bodyResvChargeToEntry != null)
            {
                body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(bodyResvChargeToEntry);
                bodypropCount++;
            }

            if (bodyRoomLocationFixed != null)
            {
                body["RoomLocationFixed"] = ExpressionConverter.ConvertO(bodyRoomLocationFixed);
                bodypropCount++;
            }

            if (bodyRoomLocationID != null)
            {
                body["RoomLocationID"] = ExpressionConverter.ConvertO(bodyRoomLocationID);
                bodypropCount++;
            }

            if (bodyRoomRateAmount != null)
            {
                body["RoomRateAmount"] = ExpressionConverter.ConvertO(bodyRoomRateAmount);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomTypeID != null)
            {
                body["RoomTypeID"] = ExpressionConverter.ConvertO(bodyRoomTypeID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyServiceAnimalCount != null)
            {
                body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(bodyServiceAnimalCount);
                bodypropCount++;
            }

            if (bodySpecialRequirement != null)
            {
                body["SpecialRequirement"] = ExpressionConverter.ConvertO(bodySpecialRequirement);
                bodypropCount++;
            }

            if (bodyStartBookingReasonID != null)
            {
                body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(bodyStartBookingReasonID);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectBookingResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateBookingResponse> CreateBooking(Expression<Func<int>> bodyEntryID, Expression<Func<int>> bodyAdditionalOccupantCount = null, Expression<Func<string>> bodyAutoAllocationDetail = null, Expression<Func<bodyBookingLinkTypeEnumInput>> bodyBookingLinkTypeEnum = null, Expression<Func<int>> bodyBookingTypeID = null, Expression<Func<string>> bodyCheckInDate = null, Expression<Func<string>> bodyCheckInDateActual = null, Expression<Func<string>> bodyCheckOutDate = null, Expression<Func<string>> bodyCheckOutDateActual = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyContractDateEnd = null, Expression<Func<string>> bodyContractDateStart = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomDate3 = null, Expression<Func<string>> bodyCustomDate4 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyCustomString7 = null, Expression<Func<string>> bodyCustomString8 = null, Expression<Func<string>> bodyCustomString9 = null, Expression<Func<string>> bodyCustomString10 = null, Expression<Func<string>> bodyDateBilled = null, Expression<Func<string>> bodyDateChargedTo = null, Expression<Func<int>> bodyEmotionalSupportAnimalCount = null, Expression<Func<int>> bodyEndBookingReasonID = null, Expression<Func<int>> bodyEntryInvitationID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<string>> bodyETA = null, Expression<Func<string>> bodyETD = null, Expression<Func<double>> bodyExcess = null, Expression<Func<int>> bodyGroupID = null, Expression<Func<int>> bodyHousekeepingID = null, Expression<Func<int>> bodyNumberOfChildren = null, Expression<Func<int>> bodyNumberOfChildrenFree = null, Expression<Func<int>> bodyNumberOfGuests = null, Expression<Func<int>> bodyNumberOfGuestsFree = null, Expression<Func<string>> bodyPaidTo = null, Expression<Func<int>> bodyPetCount = null, Expression<Func<bool>> bodyResvChargeToEntry = null, Expression<Func<bool>> bodyRoomLocationFixed = null, Expression<Func<int>> bodyRoomLocationID = null, Expression<Func<double>> bodyRoomRateAmount = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<int>> bodyRoomTypeID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyServiceAnimalCount = null, Expression<Func<string>> bodySpecialRequirement = null, Expression<Func<int>> bodyStartBookingReasonID = null, Expression<Func<int>> bodyTermSessionID = null)
        {
            var apiCallPath = "/create/booking.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAdditionalOccupantCount != null)
            {
                body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(bodyAdditionalOccupantCount);
                bodypropCount++;
            }

            if (bodyAutoAllocationDetail != null)
            {
                body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(bodyAutoAllocationDetail);
                bodypropCount++;
            }

            if (bodyBookingLinkTypeEnum != null)
            {
                body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(bodyBookingLinkTypeEnum);
                bodypropCount++;
            }

            if (bodyBookingTypeID != null)
            {
                body["BookingTypeID"] = ExpressionConverter.ConvertO(bodyBookingTypeID);
                bodypropCount++;
            }

            if (bodyCheckInDate != null)
            {
                body["CheckInDate"] = ExpressionConverter.ConvertO(bodyCheckInDate);
                bodypropCount++;
            }

            if (bodyCheckInDateActual != null)
            {
                body["CheckInDateActual"] = ExpressionConverter.ConvertO(bodyCheckInDateActual);
                bodypropCount++;
            }

            if (bodyCheckOutDate != null)
            {
                body["CheckOutDate"] = ExpressionConverter.ConvertO(bodyCheckOutDate);
                bodypropCount++;
            }

            if (bodyCheckOutDateActual != null)
            {
                body["CheckOutDateActual"] = ExpressionConverter.ConvertO(bodyCheckOutDateActual);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyContractDateEnd != null)
            {
                body["ContractDateEnd"] = ExpressionConverter.ConvertO(bodyContractDateEnd);
                bodypropCount++;
            }

            if (bodyContractDateStart != null)
            {
                body["ContractDateStart"] = ExpressionConverter.ConvertO(bodyContractDateStart);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomDate3 != null)
            {
                body["CustomDate3"] = ExpressionConverter.ConvertO(bodyCustomDate3);
                bodypropCount++;
            }

            if (bodyCustomDate4 != null)
            {
                body["CustomDate4"] = ExpressionConverter.ConvertO(bodyCustomDate4);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyCustomString7 != null)
            {
                body["CustomString7"] = ExpressionConverter.ConvertO(bodyCustomString7);
                bodypropCount++;
            }

            if (bodyCustomString8 != null)
            {
                body["CustomString8"] = ExpressionConverter.ConvertO(bodyCustomString8);
                bodypropCount++;
            }

            if (bodyCustomString9 != null)
            {
                body["CustomString9"] = ExpressionConverter.ConvertO(bodyCustomString9);
                bodypropCount++;
            }

            if (bodyCustomString10 != null)
            {
                body["CustomString10"] = ExpressionConverter.ConvertO(bodyCustomString10);
                bodypropCount++;
            }

            if (bodyDateBilled != null)
            {
                body["DateBilled"] = ExpressionConverter.ConvertO(bodyDateBilled);
                bodypropCount++;
            }

            if (bodyDateChargedTo != null)
            {
                body["DateChargedTo"] = ExpressionConverter.ConvertO(bodyDateChargedTo);
                bodypropCount++;
            }

            if (bodyEmotionalSupportAnimalCount != null)
            {
                body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(bodyEmotionalSupportAnimalCount);
                bodypropCount++;
            }

            if (bodyEndBookingReasonID != null)
            {
                body["End_BookingReasonID"] = ExpressionConverter.ConvertO(bodyEndBookingReasonID);
                bodypropCount++;
            }

            bodypropCount++;
            body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
            if (bodyEntryInvitationID != null)
            {
                body["EntryInvitationID"] = ExpressionConverter.ConvertO(bodyEntryInvitationID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyETA != null)
            {
                body["ETA"] = ExpressionConverter.ConvertO(bodyETA);
                bodypropCount++;
            }

            if (bodyETD != null)
            {
                body["ETD"] = ExpressionConverter.ConvertO(bodyETD);
                bodypropCount++;
            }

            if (bodyExcess != null)
            {
                body["Excess"] = ExpressionConverter.ConvertO(bodyExcess);
                bodypropCount++;
            }

            if (bodyGroupID != null)
            {
                body["GroupID"] = ExpressionConverter.ConvertO(bodyGroupID);
                bodypropCount++;
            }

            if (bodyHousekeepingID != null)
            {
                body["HousekeepingID"] = ExpressionConverter.ConvertO(bodyHousekeepingID);
                bodypropCount++;
            }

            if (bodyNumberOfChildren != null)
            {
                body["NumberOfChildren"] = ExpressionConverter.ConvertO(bodyNumberOfChildren);
                bodypropCount++;
            }

            if (bodyNumberOfChildrenFree != null)
            {
                body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(bodyNumberOfChildrenFree);
                bodypropCount++;
            }

            if (bodyNumberOfGuests != null)
            {
                body["NumberOfGuests"] = ExpressionConverter.ConvertO(bodyNumberOfGuests);
                bodypropCount++;
            }

            if (bodyNumberOfGuestsFree != null)
            {
                body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(bodyNumberOfGuestsFree);
                bodypropCount++;
            }

            if (bodyPaidTo != null)
            {
                body["PaidTo"] = ExpressionConverter.ConvertO(bodyPaidTo);
                bodypropCount++;
            }

            if (bodyPetCount != null)
            {
                body["PetCount"] = ExpressionConverter.ConvertO(bodyPetCount);
                bodypropCount++;
            }

            if (bodyResvChargeToEntry != null)
            {
                body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(bodyResvChargeToEntry);
                bodypropCount++;
            }

            if (bodyRoomLocationFixed != null)
            {
                body["RoomLocationFixed"] = ExpressionConverter.ConvertO(bodyRoomLocationFixed);
                bodypropCount++;
            }

            if (bodyRoomLocationID != null)
            {
                body["RoomLocationID"] = ExpressionConverter.ConvertO(bodyRoomLocationID);
                bodypropCount++;
            }

            if (bodyRoomRateAmount != null)
            {
                body["RoomRateAmount"] = ExpressionConverter.ConvertO(bodyRoomRateAmount);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomTypeID != null)
            {
                body["RoomTypeID"] = ExpressionConverter.ConvertO(bodyRoomTypeID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyServiceAnimalCount != null)
            {
                body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(bodyServiceAnimalCount);
                bodypropCount++;
            }

            if (bodySpecialRequirement != null)
            {
                body["SpecialRequirement"] = ExpressionConverter.ConvertO(bodySpecialRequirement);
                bodypropCount++;
            }

            if (bodyStartBookingReasonID != null)
            {
                body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(bodyStartBookingReasonID);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateBookingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateBookingResponse> UpdateBooking(Expression<Func<int>> bookingID, Expression<Func<int>> bodyAdditionalOccupantCount = null, Expression<Func<string>> bodyAutoAllocationDetail = null, Expression<Func<bodyBookingLinkTypeEnumInput>> bodyBookingLinkTypeEnum = null, Expression<Func<int>> bodyBookingTypeID = null, Expression<Func<string>> bodyCheckInDate = null, Expression<Func<string>> bodyCheckInDateActual = null, Expression<Func<string>> bodyCheckOutDate = null, Expression<Func<string>> bodyCheckOutDateActual = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyContractDateEnd = null, Expression<Func<string>> bodyContractDateStart = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<bool>> bodyCustomBit3 = null, Expression<Func<bool>> bodyCustomBit4 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomDate3 = null, Expression<Func<string>> bodyCustomDate4 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyCustomString7 = null, Expression<Func<string>> bodyCustomString8 = null, Expression<Func<string>> bodyCustomString9 = null, Expression<Func<string>> bodyCustomString10 = null, Expression<Func<string>> bodyDateBilled = null, Expression<Func<string>> bodyDateChargedTo = null, Expression<Func<int>> bodyEmotionalSupportAnimalCount = null, Expression<Func<int>> bodyEndBookingReasonID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<int>> bodyEntryInvitationID = null, Expression<Func<bodyEntryStatusEnumInput>> bodyEntryStatusEnum = null, Expression<Func<string>> bodyETA = null, Expression<Func<string>> bodyETD = null, Expression<Func<double>> bodyExcess = null, Expression<Func<int>> bodyGroupID = null, Expression<Func<int>> bodyHousekeepingID = null, Expression<Func<int>> bodyNumberOfChildren = null, Expression<Func<int>> bodyNumberOfChildrenFree = null, Expression<Func<int>> bodyNumberOfGuests = null, Expression<Func<int>> bodyNumberOfGuestsFree = null, Expression<Func<string>> bodyPaidTo = null, Expression<Func<int>> bodyPetCount = null, Expression<Func<bool>> bodyResvChargeToEntry = null, Expression<Func<bool>> bodyRoomLocationFixed = null, Expression<Func<int>> bodyRoomLocationID = null, Expression<Func<double>> bodyRoomRateAmount = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<int>> bodyRoomTypeID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyServiceAnimalCount = null, Expression<Func<string>> bodySpecialRequirement = null, Expression<Func<int>> bodyStartBookingReasonID = null, Expression<Func<int>> bodyTermSessionID = null)
        {
            var apiCallPath = String.Format("/update/booking.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(bookingID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAdditionalOccupantCount != null)
            {
                body["AdditionalOccupantCount"] = ExpressionConverter.ConvertO(bodyAdditionalOccupantCount);
                bodypropCount++;
            }

            if (bodyAutoAllocationDetail != null)
            {
                body["AutoAllocationDetail"] = ExpressionConverter.ConvertO(bodyAutoAllocationDetail);
                bodypropCount++;
            }

            if (bodyBookingLinkTypeEnum != null)
            {
                body["BookingLinkTypeEnum"] = ExpressionConverter.ConvertO(bodyBookingLinkTypeEnum);
                bodypropCount++;
            }

            if (bodyBookingTypeID != null)
            {
                body["BookingTypeID"] = ExpressionConverter.ConvertO(bodyBookingTypeID);
                bodypropCount++;
            }

            if (bodyCheckInDate != null)
            {
                body["CheckInDate"] = ExpressionConverter.ConvertO(bodyCheckInDate);
                bodypropCount++;
            }

            if (bodyCheckInDateActual != null)
            {
                body["CheckInDateActual"] = ExpressionConverter.ConvertO(bodyCheckInDateActual);
                bodypropCount++;
            }

            if (bodyCheckOutDate != null)
            {
                body["CheckOutDate"] = ExpressionConverter.ConvertO(bodyCheckOutDate);
                bodypropCount++;
            }

            if (bodyCheckOutDateActual != null)
            {
                body["CheckOutDateActual"] = ExpressionConverter.ConvertO(bodyCheckOutDateActual);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyContractDateEnd != null)
            {
                body["ContractDateEnd"] = ExpressionConverter.ConvertO(bodyContractDateEnd);
                bodypropCount++;
            }

            if (bodyContractDateStart != null)
            {
                body["ContractDateStart"] = ExpressionConverter.ConvertO(bodyContractDateStart);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomBit3 != null)
            {
                body["CustomBit3"] = ExpressionConverter.ConvertO(bodyCustomBit3);
                bodypropCount++;
            }

            if (bodyCustomBit4 != null)
            {
                body["CustomBit4"] = ExpressionConverter.ConvertO(bodyCustomBit4);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomDate3 != null)
            {
                body["CustomDate3"] = ExpressionConverter.ConvertO(bodyCustomDate3);
                bodypropCount++;
            }

            if (bodyCustomDate4 != null)
            {
                body["CustomDate4"] = ExpressionConverter.ConvertO(bodyCustomDate4);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyCustomString7 != null)
            {
                body["CustomString7"] = ExpressionConverter.ConvertO(bodyCustomString7);
                bodypropCount++;
            }

            if (bodyCustomString8 != null)
            {
                body["CustomString8"] = ExpressionConverter.ConvertO(bodyCustomString8);
                bodypropCount++;
            }

            if (bodyCustomString9 != null)
            {
                body["CustomString9"] = ExpressionConverter.ConvertO(bodyCustomString9);
                bodypropCount++;
            }

            if (bodyCustomString10 != null)
            {
                body["CustomString10"] = ExpressionConverter.ConvertO(bodyCustomString10);
                bodypropCount++;
            }

            if (bodyDateBilled != null)
            {
                body["DateBilled"] = ExpressionConverter.ConvertO(bodyDateBilled);
                bodypropCount++;
            }

            if (bodyDateChargedTo != null)
            {
                body["DateChargedTo"] = ExpressionConverter.ConvertO(bodyDateChargedTo);
                bodypropCount++;
            }

            if (bodyEmotionalSupportAnimalCount != null)
            {
                body["EmotionalSupportAnimalCount"] = ExpressionConverter.ConvertO(bodyEmotionalSupportAnimalCount);
                bodypropCount++;
            }

            if (bodyEndBookingReasonID != null)
            {
                body["End_BookingReasonID"] = ExpressionConverter.ConvertO(bodyEndBookingReasonID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyEntryInvitationID != null)
            {
                body["EntryInvitationID"] = ExpressionConverter.ConvertO(bodyEntryInvitationID);
                bodypropCount++;
            }

            if (bodyEntryStatusEnum != null)
            {
                body["EntryStatusEnum"] = ExpressionConverter.ConvertO(bodyEntryStatusEnum);
                bodypropCount++;
            }

            if (bodyETA != null)
            {
                body["ETA"] = ExpressionConverter.ConvertO(bodyETA);
                bodypropCount++;
            }

            if (bodyETD != null)
            {
                body["ETD"] = ExpressionConverter.ConvertO(bodyETD);
                bodypropCount++;
            }

            if (bodyExcess != null)
            {
                body["Excess"] = ExpressionConverter.ConvertO(bodyExcess);
                bodypropCount++;
            }

            if (bodyGroupID != null)
            {
                body["GroupID"] = ExpressionConverter.ConvertO(bodyGroupID);
                bodypropCount++;
            }

            if (bodyHousekeepingID != null)
            {
                body["HousekeepingID"] = ExpressionConverter.ConvertO(bodyHousekeepingID);
                bodypropCount++;
            }

            if (bodyNumberOfChildren != null)
            {
                body["NumberOfChildren"] = ExpressionConverter.ConvertO(bodyNumberOfChildren);
                bodypropCount++;
            }

            if (bodyNumberOfChildrenFree != null)
            {
                body["NumberOfChildrenFree"] = ExpressionConverter.ConvertO(bodyNumberOfChildrenFree);
                bodypropCount++;
            }

            if (bodyNumberOfGuests != null)
            {
                body["NumberOfGuests"] = ExpressionConverter.ConvertO(bodyNumberOfGuests);
                bodypropCount++;
            }

            if (bodyNumberOfGuestsFree != null)
            {
                body["NumberOfGuestsFree"] = ExpressionConverter.ConvertO(bodyNumberOfGuestsFree);
                bodypropCount++;
            }

            if (bodyPaidTo != null)
            {
                body["PaidTo"] = ExpressionConverter.ConvertO(bodyPaidTo);
                bodypropCount++;
            }

            if (bodyPetCount != null)
            {
                body["PetCount"] = ExpressionConverter.ConvertO(bodyPetCount);
                bodypropCount++;
            }

            if (bodyResvChargeToEntry != null)
            {
                body["ResvChargeToEntry"] = ExpressionConverter.ConvertO(bodyResvChargeToEntry);
                bodypropCount++;
            }

            if (bodyRoomLocationFixed != null)
            {
                body["RoomLocationFixed"] = ExpressionConverter.ConvertO(bodyRoomLocationFixed);
                bodypropCount++;
            }

            if (bodyRoomLocationID != null)
            {
                body["RoomLocationID"] = ExpressionConverter.ConvertO(bodyRoomLocationID);
                bodypropCount++;
            }

            if (bodyRoomRateAmount != null)
            {
                body["RoomRateAmount"] = ExpressionConverter.ConvertO(bodyRoomRateAmount);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomTypeID != null)
            {
                body["RoomTypeID"] = ExpressionConverter.ConvertO(bodyRoomTypeID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyServiceAnimalCount != null)
            {
                body["ServiceAnimalCount"] = ExpressionConverter.ConvertO(bodyServiceAnimalCount);
                bodypropCount++;
            }

            if (bodySpecialRequirement != null)
            {
                body["SpecialRequirement"] = ExpressionConverter.ConvertO(bodySpecialRequirement);
                bodypropCount++;
            }

            if (bodyStartBookingReasonID != null)
            {
                body["Start_BookingReasonID"] = ExpressionConverter.ConvertO(bodyStartBookingReasonID);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateBookingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceResponseItem[]> SelectRoomSpace(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<bool>> bodyAllocateExclude = null, Expression<Func<int>> bodyAllocateSortOrder = null, Expression<Func<int>> bodyBathrooms = null, Expression<Func<int>> bodyBedCapacity = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyExtensionID = null, Expression<Func<bool>> bodyHold = null, Expression<Func<bool>> bodyNetworked = null, Expression<Func<bodyRecordTypeEnumInput>> bodyRecordTypeEnum = null, Expression<Func<int>> bodyRoomBaseID = null, Expression<Func<int>> bodyRoomID = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<bodyRoomSpaceTypeEnumInput>> bodyRoomSpaceTypeEnum = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodySortOrder = null, Expression<Func<string>> bodyStreet = null, Expression<Func<string>> bodyStreet2 = null, Expression<Func<string>> bodyWebDescription = null, Expression<Func<string>> bodyZipPostcode = null)
        {
            var apiCallPath = "/select/RoomSpace.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAllocateExclude != null)
            {
                body["AllocateExclude"] = ExpressionConverter.ConvertO(bodyAllocateExclude);
                bodypropCount++;
            }

            if (bodyAllocateSortOrder != null)
            {
                body["AllocateSortOrder"] = ExpressionConverter.ConvertO(bodyAllocateSortOrder);
                bodypropCount++;
            }

            if (bodyBathrooms != null)
            {
                body["Bathrooms"] = ExpressionConverter.ConvertO(bodyBathrooms);
                bodypropCount++;
            }

            if (bodyBedCapacity != null)
            {
                body["BedCapacity"] = ExpressionConverter.ConvertO(bodyBedCapacity);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyExtensionID != null)
            {
                body["ExtensionID"] = ExpressionConverter.ConvertO(bodyExtensionID);
                bodypropCount++;
            }

            if (bodyHold != null)
            {
                body["Hold"] = ExpressionConverter.ConvertO(bodyHold);
                bodypropCount++;
            }

            if (bodyNetworked != null)
            {
                body["Networked"] = ExpressionConverter.ConvertO(bodyNetworked);
                bodypropCount++;
            }

            if (bodyRecordTypeEnum != null)
            {
                body["RecordTypeEnum"] = ExpressionConverter.ConvertO(bodyRecordTypeEnum);
                bodypropCount++;
            }

            if (bodyRoomBaseID != null)
            {
                body["RoomBaseID"] = ExpressionConverter.ConvertO(bodyRoomBaseID);
                bodypropCount++;
            }

            if (bodyRoomID != null)
            {
                body["RoomID"] = ExpressionConverter.ConvertO(bodyRoomID);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomSpaceTypeEnum != null)
            {
                body["RoomSpaceTypeEnum"] = ExpressionConverter.ConvertO(bodyRoomSpaceTypeEnum);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodySortOrder != null)
            {
                body["SortOrder"] = ExpressionConverter.ConvertO(bodySortOrder);
                bodypropCount++;
            }

            if (bodyStreet != null)
            {
                body["Street"] = ExpressionConverter.ConvertO(bodyStreet);
                bodypropCount++;
            }

            if (bodyStreet2 != null)
            {
                body["Street2"] = ExpressionConverter.ConvertO(bodyStreet2);
                bodypropCount++;
            }

            if (bodyWebDescription != null)
            {
                body["WebDescription"] = ExpressionConverter.ConvertO(bodyWebDescription);
                bodypropCount++;
            }

            if (bodyZipPostcode != null)
            {
                body["ZipPostcode"] = ExpressionConverter.ConvertO(bodyZipPostcode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectRoomSpaceResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceResponse> CreateRoomSpace(Expression<Func<bool>> bodyAllocateExclude = null, Expression<Func<int>> bodyAllocateSortOrder = null, Expression<Func<int>> bodyBathrooms = null, Expression<Func<int>> bodyBedCapacity = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyExtensionID = null, Expression<Func<bool>> bodyHold = null, Expression<Func<bool>> bodyNetworked = null, Expression<Func<bodyRecordTypeEnumInput>> bodyRecordTypeEnum = null, Expression<Func<int>> bodyRoomBaseID = null, Expression<Func<int>> bodyRoomID = null, Expression<Func<int>> bodyRoomRateID = null, Expression<Func<bodyRoomSpaceTypeEnumInput>> bodyRoomSpaceTypeEnum = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodySortOrder = null, Expression<Func<string>> bodyStreet = null, Expression<Func<string>> bodyStreet2 = null, Expression<Func<string>> bodyWebDescription = null, Expression<Func<string>> bodyZipPostcode = null)
        {
            var apiCallPath = "/create/roomspace.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAllocateExclude != null)
            {
                body["AllocateExclude"] = ExpressionConverter.ConvertO(bodyAllocateExclude);
                bodypropCount++;
            }

            if (bodyAllocateSortOrder != null)
            {
                body["AllocateSortOrder"] = ExpressionConverter.ConvertO(bodyAllocateSortOrder);
                bodypropCount++;
            }

            if (bodyBathrooms != null)
            {
                body["Bathrooms"] = ExpressionConverter.ConvertO(bodyBathrooms);
                bodypropCount++;
            }

            if (bodyBedCapacity != null)
            {
                body["BedCapacity"] = ExpressionConverter.ConvertO(bodyBedCapacity);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyExtensionID != null)
            {
                body["ExtensionID"] = ExpressionConverter.ConvertO(bodyExtensionID);
                bodypropCount++;
            }

            if (bodyHold != null)
            {
                body["Hold"] = ExpressionConverter.ConvertO(bodyHold);
                bodypropCount++;
            }

            if (bodyNetworked != null)
            {
                body["Networked"] = ExpressionConverter.ConvertO(bodyNetworked);
                bodypropCount++;
            }

            if (bodyRecordTypeEnum != null)
            {
                body["RecordTypeEnum"] = ExpressionConverter.ConvertO(bodyRecordTypeEnum);
                bodypropCount++;
            }

            if (bodyRoomBaseID != null)
            {
                body["RoomBaseID"] = ExpressionConverter.ConvertO(bodyRoomBaseID);
                bodypropCount++;
            }

            if (bodyRoomID != null)
            {
                body["RoomID"] = ExpressionConverter.ConvertO(bodyRoomID);
                bodypropCount++;
            }

            if (bodyRoomRateID != null)
            {
                body["RoomRateID"] = ExpressionConverter.ConvertO(bodyRoomRateID);
                bodypropCount++;
            }

            if (bodyRoomSpaceTypeEnum != null)
            {
                body["RoomSpaceTypeEnum"] = ExpressionConverter.ConvertO(bodyRoomSpaceTypeEnum);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodySortOrder != null)
            {
                body["SortOrder"] = ExpressionConverter.ConvertO(bodySortOrder);
                bodypropCount++;
            }

            if (bodyStreet != null)
            {
                body["Street"] = ExpressionConverter.ConvertO(bodyStreet);
                bodypropCount++;
            }

            if (bodyStreet2 != null)
            {
                body["Street2"] = ExpressionConverter.ConvertO(bodyStreet2);
                bodypropCount++;
            }

            if (bodyWebDescription != null)
            {
                body["WebDescription"] = ExpressionConverter.ConvertO(bodyWebDescription);
                bodypropCount++;
            }

            if (bodyZipPostcode != null)
            {
                body["ZipPostcode"] = ExpressionConverter.ConvertO(bodyZipPostcode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRoomSpaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomLocationResponseItem[]> SelectRoomLocation(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<int>> bodyAllocateSortOrder = null, Expression<Func<int>> bodyCategoryID = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCountryID = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bodyGenderTypeEnumInput>> bodyGenderTypeEnum = null, Expression<Func<bool>> bodyLease = null, Expression<Func<bool>> bodyManagedExternally = null, Expression<Func<bool>> bodyNonResidential = null, Expression<Func<bodyRecordTypeEnumInput>> bodyRecordTypeEnum = null, Expression<Func<int>> bodyRoomLocationAreaID = null, Expression<Func<int>> bodyRoomLocationID = null, Expression<Func<string>> bodyStateProvince = null, Expression<Func<bool>> bodyViewOnWeb = null, Expression<Func<string>> bodyWebComments = null, Expression<Func<string>> bodyWebDescription = null, Expression<Func<string>> bodyWebImageAltText = null, Expression<Func<string>> bodyWebImageLocation = null, Expression<Func<string>> bodyZipPostcode = null)
        {
            var apiCallPath = "/select/RoomLocation.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAllocateSortOrder != null)
            {
                body["AllocateSortOrder"] = ExpressionConverter.ConvertO(bodyAllocateSortOrder);
                bodypropCount++;
            }

            if (bodyCategoryID != null)
            {
                body["CategoryID"] = ExpressionConverter.ConvertO(bodyCategoryID);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCountryID != null)
            {
                body["CountryID"] = ExpressionConverter.ConvertO(bodyCountryID);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyGenderTypeEnum != null)
            {
                body["GenderTypeEnum"] = ExpressionConverter.ConvertO(bodyGenderTypeEnum);
                bodypropCount++;
            }

            if (bodyLease != null)
            {
                body["Lease"] = ExpressionConverter.ConvertO(bodyLease);
                bodypropCount++;
            }

            if (bodyManagedExternally != null)
            {
                body["ManagedExternally"] = ExpressionConverter.ConvertO(bodyManagedExternally);
                bodypropCount++;
            }

            if (bodyNonResidential != null)
            {
                body["NonResidential"] = ExpressionConverter.ConvertO(bodyNonResidential);
                bodypropCount++;
            }

            if (bodyRecordTypeEnum != null)
            {
                body["RecordTypeEnum"] = ExpressionConverter.ConvertO(bodyRecordTypeEnum);
                bodypropCount++;
            }

            if (bodyRoomLocationAreaID != null)
            {
                body["RoomLocationAreaID"] = ExpressionConverter.ConvertO(bodyRoomLocationAreaID);
                bodypropCount++;
            }

            if (bodyRoomLocationID != null)
            {
                body["RoomLocationID"] = ExpressionConverter.ConvertO(bodyRoomLocationID);
                bodypropCount++;
            }

            if (bodyStateProvince != null)
            {
                body["StateProvince"] = ExpressionConverter.ConvertO(bodyStateProvince);
                bodypropCount++;
            }

            if (bodyViewOnWeb != null)
            {
                body["ViewOnWeb"] = ExpressionConverter.ConvertO(bodyViewOnWeb);
                bodypropCount++;
            }

            if (bodyWebComments != null)
            {
                body["WebComments"] = ExpressionConverter.ConvertO(bodyWebComments);
                bodypropCount++;
            }

            if (bodyWebDescription != null)
            {
                body["WebDescription"] = ExpressionConverter.ConvertO(bodyWebDescription);
                bodypropCount++;
            }

            if (bodyWebImageAltText != null)
            {
                body["WebImageAltText"] = ExpressionConverter.ConvertO(bodyWebImageAltText);
                bodypropCount++;
            }

            if (bodyWebImageLocation != null)
            {
                body["WebImageLocation"] = ExpressionConverter.ConvertO(bodyWebImageLocation);
                bodypropCount++;
            }

            if (bodyZipPostcode != null)
            {
                body["ZipPostcode"] = ExpressionConverter.ConvertO(bodyZipPostcode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectRoomLocationResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTransactionResponseItem[]> SelectTransaction(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<double>> bodyAmount = null, Expression<Func<bodyCallTypeEnumInput>> bodyCallTypeEnum = null, Expression<Func<int>> bodyChargeGroupID = null, Expression<Func<int>> bodyChargeItemID = null, Expression<Func<string>> bodyComments = null, Expression<Func<int>> bodyCreatedBySecurityUserID = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyDueDateValue = null, Expression<Func<bodyDueDateOperatorInput>> bodyDueDateOperator = null, Expression<Func<int>> bodyDuration = null, Expression<Func<int>> bodyEndOfSessionID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<double>> bodyExcess = null, Expression<Func<int>> bodyExtension = null, Expression<Func<int>> bodyExternalID = null, Expression<Func<string>> bodyExternalReceiptID = null, Expression<Func<int>> bodyInvoiceID = null, Expression<Func<string>> bodyPaidFromValue = null, Expression<Func<bodyPaidFromOperatorInput>> bodyPaidFromOperator = null, Expression<Func<string>> bodyPaidToValue = null, Expression<Func<bodyPaidToOperatorInput>> bodyPaidToOperator = null, Expression<Func<int>> bodyPaymentID = null, Expression<Func<string>> bodyProcessedDateValue = null, Expression<Func<bodyProcessedDateOperatorInput>> bodyProcessedDateOperator = null, Expression<Func<int>> bodyReferenceBookingID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyTableID = null, Expression<Func<string>> bodyTableName = null, Expression<Func<string>> bodyTag = null, Expression<Func<string>> bodyTagFinance = null, Expression<Func<double>> bodyTaxAmount = null, Expression<Func<double>> bodyTaxAmount2 = null, Expression<Func<double>> bodyTaxAmount3 = null, Expression<Func<int>> bodyTermSessionID = null, Expression<Func<string>> bodyTransactionDateValue = null, Expression<Func<bodyTransactionDateOperatorInput>> bodyTransactionDateOperator = null, Expression<Func<int>> bodyTransactionID = null, Expression<Func<bodyTransactionTypeEnumInput>> bodyTransactionTypeEnum = null)
        {
            var apiCallPath = "/select/Transaction.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAmount != null)
            {
                body["Amount"] = ExpressionConverter.ConvertO(bodyAmount);
                bodypropCount++;
            }

            if (bodyCallTypeEnum != null)
            {
                body["CallTypeEnum"] = ExpressionConverter.ConvertO(bodyCallTypeEnum);
                bodypropCount++;
            }

            if (bodyChargeGroupID != null)
            {
                body["ChargeGroupID"] = ExpressionConverter.ConvertO(bodyChargeGroupID);
                bodypropCount++;
            }

            if (bodyChargeItemID != null)
            {
                body["ChargeItemID"] = ExpressionConverter.ConvertO(bodyChargeItemID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyCreatedBySecurityUserID != null)
            {
                body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(bodyCreatedBySecurityUserID);
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            var DueDateObject = new JObject();
            var DueDateObjectpropCount = 0;
            if (bodyDueDateValue != null)
            {
                DueDateObject["Value"] = ExpressionConverter.ConvertO(bodyDueDateValue);
                DueDateObjectpropCount++;
            }

            if (bodyDueDateOperator != null)
            {
                DueDateObject["_operator"] = ExpressionConverter.ConvertO(bodyDueDateOperator);
                DueDateObjectpropCount++;
            }

            if (DueDateObjectpropCount > 0)
            {
                body["DueDate"] = DueDateObject;
                bodypropCount++;
            }

            if (bodyDuration != null)
            {
                body["Duration"] = ExpressionConverter.ConvertO(bodyDuration);
                bodypropCount++;
            }

            if (bodyEndOfSessionID != null)
            {
                body["EndOfSessionID"] = ExpressionConverter.ConvertO(bodyEndOfSessionID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyExcess != null)
            {
                body["Excess"] = ExpressionConverter.ConvertO(bodyExcess);
                bodypropCount++;
            }

            if (bodyExtension != null)
            {
                body["Extension"] = ExpressionConverter.ConvertO(bodyExtension);
                bodypropCount++;
            }

            if (bodyExternalID != null)
            {
                body["ExternalID"] = ExpressionConverter.ConvertO(bodyExternalID);
                bodypropCount++;
            }

            if (bodyExternalReceiptID != null)
            {
                body["ExternalReceiptID"] = ExpressionConverter.ConvertO(bodyExternalReceiptID);
                bodypropCount++;
            }

            if (bodyInvoiceID != null)
            {
                body["InvoiceID"] = ExpressionConverter.ConvertO(bodyInvoiceID);
                bodypropCount++;
            }

            var PaidFromObject = new JObject();
            var PaidFromObjectpropCount = 0;
            if (bodyPaidFromValue != null)
            {
                PaidFromObject["Value"] = ExpressionConverter.ConvertO(bodyPaidFromValue);
                PaidFromObjectpropCount++;
            }

            if (bodyPaidFromOperator != null)
            {
                PaidFromObject["_operator"] = ExpressionConverter.ConvertO(bodyPaidFromOperator);
                PaidFromObjectpropCount++;
            }

            if (PaidFromObjectpropCount > 0)
            {
                body["PaidFrom"] = PaidFromObject;
                bodypropCount++;
            }

            var PaidToObject = new JObject();
            var PaidToObjectpropCount = 0;
            if (bodyPaidToValue != null)
            {
                PaidToObject["Value"] = ExpressionConverter.ConvertO(bodyPaidToValue);
                PaidToObjectpropCount++;
            }

            if (bodyPaidToOperator != null)
            {
                PaidToObject["_operator"] = ExpressionConverter.ConvertO(bodyPaidToOperator);
                PaidToObjectpropCount++;
            }

            if (PaidToObjectpropCount > 0)
            {
                body["PaidTo"] = PaidToObject;
                bodypropCount++;
            }

            if (bodyPaymentID != null)
            {
                body["PaymentID"] = ExpressionConverter.ConvertO(bodyPaymentID);
                bodypropCount++;
            }

            var ProcessedDateObject = new JObject();
            var ProcessedDateObjectpropCount = 0;
            if (bodyProcessedDateValue != null)
            {
                ProcessedDateObject["Value"] = ExpressionConverter.ConvertO(bodyProcessedDateValue);
                ProcessedDateObjectpropCount++;
            }

            if (bodyProcessedDateOperator != null)
            {
                ProcessedDateObject["_operator"] = ExpressionConverter.ConvertO(bodyProcessedDateOperator);
                ProcessedDateObjectpropCount++;
            }

            if (ProcessedDateObjectpropCount > 0)
            {
                body["ProcessedDate"] = ProcessedDateObject;
                bodypropCount++;
            }

            if (bodyReferenceBookingID != null)
            {
                body["Reference_BookingID"] = ExpressionConverter.ConvertO(bodyReferenceBookingID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyTableID != null)
            {
                body["TableID"] = ExpressionConverter.ConvertO(bodyTableID);
                bodypropCount++;
            }

            if (bodyTableName != null)
            {
                body["TableName"] = ExpressionConverter.ConvertO(bodyTableName);
                bodypropCount++;
            }

            if (bodyTag != null)
            {
                body["Tag"] = ExpressionConverter.ConvertO(bodyTag);
                bodypropCount++;
            }

            if (bodyTagFinance != null)
            {
                body["TagFinance"] = ExpressionConverter.ConvertO(bodyTagFinance);
                bodypropCount++;
            }

            if (bodyTaxAmount != null)
            {
                body["TaxAmount"] = ExpressionConverter.ConvertO(bodyTaxAmount);
                bodypropCount++;
            }

            if (bodyTaxAmount2 != null)
            {
                body["TaxAmount2"] = ExpressionConverter.ConvertO(bodyTaxAmount2);
                bodypropCount++;
            }

            if (bodyTaxAmount3 != null)
            {
                body["TaxAmount3"] = ExpressionConverter.ConvertO(bodyTaxAmount3);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            var TransactionDateObject = new JObject();
            var TransactionDateObjectpropCount = 0;
            if (bodyTransactionDateValue != null)
            {
                TransactionDateObject["Value"] = ExpressionConverter.ConvertO(bodyTransactionDateValue);
                TransactionDateObjectpropCount++;
            }

            if (bodyTransactionDateOperator != null)
            {
                TransactionDateObject["_operator"] = ExpressionConverter.ConvertO(bodyTransactionDateOperator);
                TransactionDateObjectpropCount++;
            }

            if (TransactionDateObjectpropCount > 0)
            {
                body["TransactionDate"] = TransactionDateObject;
                bodypropCount++;
            }

            if (bodyTransactionID != null)
            {
                body["TransactionID"] = ExpressionConverter.ConvertO(bodyTransactionID);
                bodypropCount++;
            }

            if (bodyTransactionTypeEnum != null)
            {
                body["TransactionTypeEnum"] = ExpressionConverter.ConvertO(bodyTransactionTypeEnum);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectTransactionResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateTransactionResponse> CreateTransaction(Expression<Func<double>> bodyAmount, Expression<Func<int>> bodyChargeGroupID, Expression<Func<bodyCallTypeEnumInput>> bodyCallTypeEnum = null, Expression<Func<int>> bodyChargeItemID = null, Expression<Func<string>> bodyComments = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyDueDate = null, Expression<Func<int>> bodyDuration = null, Expression<Func<int>> bodyEndOfSessionID = null, Expression<Func<int>> bodyEntryID = null, Expression<Func<double>> bodyExcess = null, Expression<Func<int>> bodyExtension = null, Expression<Func<int>> bodyExternalID = null, Expression<Func<string>> bodyExternalReceiptID = null, Expression<Func<int>> bodyInvoiceID = null, Expression<Func<string>> bodyPaidFrom = null, Expression<Func<string>> bodyPaidTo = null, Expression<Func<int>> bodyPaymentID = null, Expression<Func<string>> bodyProcessedDate = null, Expression<Func<int>> bodyReferenceBookingID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<int>> bodyTableID = null, Expression<Func<string>> bodyTableName = null, Expression<Func<string>> bodyTag = null, Expression<Func<string>> bodyTagFinance = null, Expression<Func<double>> bodyTaxAmount = null, Expression<Func<double>> bodyTaxAmount2 = null, Expression<Func<double>> bodyTaxAmount3 = null, Expression<Func<int>> bodyTermSessionID = null, Expression<Func<string>> bodyTransactionDate = null, Expression<Func<bodyTransactionTypeEnumInput>> bodyTransactionTypeEnum = null)
        {
            var apiCallPath = "/create/transaction.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Amount"] = ExpressionConverter.ConvertO(bodyAmount);
            if (bodyCallTypeEnum != null)
            {
                body["CallTypeEnum"] = ExpressionConverter.ConvertO(bodyCallTypeEnum);
                bodypropCount++;
            }

            bodypropCount++;
            body["ChargeGroupID"] = ExpressionConverter.ConvertO(bodyChargeGroupID);
            if (bodyChargeItemID != null)
            {
                body["ChargeItemID"] = ExpressionConverter.ConvertO(bodyChargeItemID);
                bodypropCount++;
            }

            if (bodyComments != null)
            {
                body["Comments"] = ExpressionConverter.ConvertO(bodyComments);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyDueDate != null)
            {
                body["DueDate"] = ExpressionConverter.ConvertO(bodyDueDate);
                bodypropCount++;
            }

            if (bodyDuration != null)
            {
                body["Duration"] = ExpressionConverter.ConvertO(bodyDuration);
                bodypropCount++;
            }

            if (bodyEndOfSessionID != null)
            {
                body["EndOfSessionID"] = ExpressionConverter.ConvertO(bodyEndOfSessionID);
                bodypropCount++;
            }

            if (bodyEntryID != null)
            {
                body["EntryID"] = ExpressionConverter.ConvertO(bodyEntryID);
                bodypropCount++;
            }

            if (bodyExcess != null)
            {
                body["Excess"] = ExpressionConverter.ConvertO(bodyExcess);
                bodypropCount++;
            }

            if (bodyExtension != null)
            {
                body["Extension"] = ExpressionConverter.ConvertO(bodyExtension);
                bodypropCount++;
            }

            if (bodyExternalID != null)
            {
                body["ExternalID"] = ExpressionConverter.ConvertO(bodyExternalID);
                bodypropCount++;
            }

            if (bodyExternalReceiptID != null)
            {
                body["ExternalReceiptID"] = ExpressionConverter.ConvertO(bodyExternalReceiptID);
                bodypropCount++;
            }

            if (bodyInvoiceID != null)
            {
                body["InvoiceID"] = ExpressionConverter.ConvertO(bodyInvoiceID);
                bodypropCount++;
            }

            if (bodyPaidFrom != null)
            {
                body["PaidFrom"] = ExpressionConverter.ConvertO(bodyPaidFrom);
                bodypropCount++;
            }

            if (bodyPaidTo != null)
            {
                body["PaidTo"] = ExpressionConverter.ConvertO(bodyPaidTo);
                bodypropCount++;
            }

            if (bodyPaymentID != null)
            {
                body["PaymentID"] = ExpressionConverter.ConvertO(bodyPaymentID);
                bodypropCount++;
            }

            if (bodyProcessedDate != null)
            {
                body["ProcessedDate"] = ExpressionConverter.ConvertO(bodyProcessedDate);
                bodypropCount++;
            }

            if (bodyReferenceBookingID != null)
            {
                body["Reference_BookingID"] = ExpressionConverter.ConvertO(bodyReferenceBookingID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyTableID != null)
            {
                body["TableID"] = ExpressionConverter.ConvertO(bodyTableID);
                bodypropCount++;
            }

            if (bodyTableName != null)
            {
                body["TableName"] = ExpressionConverter.ConvertO(bodyTableName);
                bodypropCount++;
            }

            if (bodyTag != null)
            {
                body["Tag"] = ExpressionConverter.ConvertO(bodyTag);
                bodypropCount++;
            }

            if (bodyTagFinance != null)
            {
                body["TagFinance"] = ExpressionConverter.ConvertO(bodyTagFinance);
                bodypropCount++;
            }

            if (bodyTaxAmount != null)
            {
                body["TaxAmount"] = ExpressionConverter.ConvertO(bodyTaxAmount);
                bodypropCount++;
            }

            if (bodyTaxAmount2 != null)
            {
                body["TaxAmount2"] = ExpressionConverter.ConvertO(bodyTaxAmount2);
                bodypropCount++;
            }

            if (bodyTaxAmount3 != null)
            {
                body["TaxAmount3"] = ExpressionConverter.ConvertO(bodyTaxAmount3);
                bodypropCount++;
            }

            if (bodyTermSessionID != null)
            {
                body["TermSessionID"] = ExpressionConverter.ConvertO(bodyTermSessionID);
                bodypropCount++;
            }

            if (bodyTransactionDate != null)
            {
                body["TransactionDate"] = ExpressionConverter.ConvertO(bodyTransactionDate);
                bodypropCount++;
            }

            if (bodyTransactionTypeEnum != null)
            {
                body["TransactionTypeEnum"] = ExpressionConverter.ConvertO(bodyTransactionTypeEnum);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTransactionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceMaintenanceResponseItem[]> SelectRoomSpaceMaintenance(Expression<Func<bodyPageSizeInput>> bodyPageSize, Expression<Func<int>> bodyPageIndex, Expression<Func<bool>> bodyReturnEmptyArrayOnNoResult = null, Expression<Func<string>> bodyOrderby = null, Expression<Func<string>> bodyAccountCode = null, Expression<Func<string>> bodyCause = null, Expression<Func<bool>> bodyCharge = null, Expression<Func<int>> bodyChargeEntryID = null, Expression<Func<double>> bodyChargeAmount = null, Expression<Func<bool>> bodyChargeInvoiced = null, Expression<Func<string>> bodyChargeInvoiceNumber = null, Expression<Func<string>> bodyChargeType = null, Expression<Func<string>> bodyCompleteDateValue = null, Expression<Func<bodyCompleteDateOperatorInput>> bodyCompleteDateOperator = null, Expression<Func<int>> bodyContactID = null, Expression<Func<string>> bodyContractDateValue = null, Expression<Func<bodyContractDateOperatorInput>> bodyContractDateOperator = null, Expression<Func<double>> bodyContractorCost = null, Expression<Func<double>> bodyContractorCostEstimate = null, Expression<Func<string>> bodyContractorDateValue = null, Expression<Func<bodyContractorDateOperatorInput>> bodyContractorDateOperator = null, Expression<Func<string>> bodyContractorETA = null, Expression<Func<string>> bodyContractorOrderNumber = null, Expression<Func<int>> bodyCreatedBySecurityUserID = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1Value = null, Expression<Func<bodyCustomDate1OperatorInput>> bodyCustomDate1Operator = null, Expression<Func<string>> bodyCustomDate2Value = null, Expression<Func<bodyCustomDate2OperatorInput>> bodyCustomDate2Operator = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateCreatedValue = null, Expression<Func<bodyDateCreatedOperatorInput>> bodyDateCreatedOperator = null, Expression<Func<string>> bodyDateDueValue = null, Expression<Func<bodyDateDueOperatorInput>> bodyDateDueOperator = null, Expression<Func<string>> bodyDateModifiedValue = null, Expression<Func<bodyDateModifiedOperatorInput>> bodyDateModifiedOperator = null, Expression<Func<string>> bodyDateReportedValue = null, Expression<Func<bodyDateReportedOperatorInput>> bodyDateReportedOperator = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bool>> bodyJobSent = null, Expression<Func<string>> bodyJobStatus = null, Expression<Func<string>> bodyLocation = null, Expression<Func<int>> bodyOccupantEntryID = null, Expression<Func<string>> bodyOccupantEntryName = null, Expression<Func<bool>> bodyOccupantPresent = null, Expression<Func<string>> bodyOccupantPresentReason = null, Expression<Func<string>> bodyOtherServiceNumber = null, Expression<Func<int>> bodyPriorityID = null, Expression<Func<string>> bodyRepairDescription = null, Expression<Func<string>> bodyReportedByName = null, Expression<Func<string>> bodyReportedByPhone = null, Expression<Func<int>> bodyRoomSpaceClosedID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceCategoryID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceItemID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<string>> bodyStartDateValue = null, Expression<Func<bodyStartDateOperatorInput>> bodyStartDateOperator = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyTechnician = null, Expression<Func<bool>> bodyViewOnWeb = null)
        {
            var apiCallPath = "/select/RoomSpaceMaintenance.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyReturnEmptyArrayOnNoResult != null)
            {
                body["_returnEmptyArrayOnNoResult"] = ExpressionConverter.ConvertO(bodyReturnEmptyArrayOnNoResult);
                bodypropCount++;
            }

            bodypropCount++;
            body["_pageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["_pageIndex"] = ExpressionConverter.ConvertO(bodyPageIndex);
            if (bodyOrderby != null)
            {
                body["_orderby"] = ExpressionConverter.ConvertO(bodyOrderby);
                bodypropCount++;
            }

            if (bodyAccountCode != null)
            {
                body["AccountCode"] = ExpressionConverter.ConvertO(bodyAccountCode);
                bodypropCount++;
            }

            if (bodyCause != null)
            {
                body["Cause"] = ExpressionConverter.ConvertO(bodyCause);
                bodypropCount++;
            }

            if (bodyCharge != null)
            {
                body["Charge"] = ExpressionConverter.ConvertO(bodyCharge);
                bodypropCount++;
            }

            if (bodyChargeEntryID != null)
            {
                body["Charge_EntryID"] = ExpressionConverter.ConvertO(bodyChargeEntryID);
                bodypropCount++;
            }

            if (bodyChargeAmount != null)
            {
                body["ChargeAmount"] = ExpressionConverter.ConvertO(bodyChargeAmount);
                bodypropCount++;
            }

            if (bodyChargeInvoiced != null)
            {
                body["ChargeInvoiced"] = ExpressionConverter.ConvertO(bodyChargeInvoiced);
                bodypropCount++;
            }

            if (bodyChargeInvoiceNumber != null)
            {
                body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(bodyChargeInvoiceNumber);
                bodypropCount++;
            }

            if (bodyChargeType != null)
            {
                body["ChargeType"] = ExpressionConverter.ConvertO(bodyChargeType);
                bodypropCount++;
            }

            var CompleteDateObject = new JObject();
            var CompleteDateObjectpropCount = 0;
            if (bodyCompleteDateValue != null)
            {
                CompleteDateObject["Value"] = ExpressionConverter.ConvertO(bodyCompleteDateValue);
                CompleteDateObjectpropCount++;
            }

            if (bodyCompleteDateOperator != null)
            {
                CompleteDateObject["_operator"] = ExpressionConverter.ConvertO(bodyCompleteDateOperator);
                CompleteDateObjectpropCount++;
            }

            if (CompleteDateObjectpropCount > 0)
            {
                body["CompleteDate"] = CompleteDateObject;
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            var ContractDateObject = new JObject();
            var ContractDateObjectpropCount = 0;
            if (bodyContractDateValue != null)
            {
                ContractDateObject["Value"] = ExpressionConverter.ConvertO(bodyContractDateValue);
                ContractDateObjectpropCount++;
            }

            if (bodyContractDateOperator != null)
            {
                ContractDateObject["_operator"] = ExpressionConverter.ConvertO(bodyContractDateOperator);
                ContractDateObjectpropCount++;
            }

            if (ContractDateObjectpropCount > 0)
            {
                body["ContractDate"] = ContractDateObject;
                bodypropCount++;
            }

            if (bodyContractorCost != null)
            {
                body["ContractorCost"] = ExpressionConverter.ConvertO(bodyContractorCost);
                bodypropCount++;
            }

            if (bodyContractorCostEstimate != null)
            {
                body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(bodyContractorCostEstimate);
                bodypropCount++;
            }

            var ContractorDateObject = new JObject();
            var ContractorDateObjectpropCount = 0;
            if (bodyContractorDateValue != null)
            {
                ContractorDateObject["Value"] = ExpressionConverter.ConvertO(bodyContractorDateValue);
                ContractorDateObjectpropCount++;
            }

            if (bodyContractorDateOperator != null)
            {
                ContractorDateObject["_operator"] = ExpressionConverter.ConvertO(bodyContractorDateOperator);
                ContractorDateObjectpropCount++;
            }

            if (ContractorDateObjectpropCount > 0)
            {
                body["ContractorDate"] = ContractorDateObject;
                bodypropCount++;
            }

            if (bodyContractorETA != null)
            {
                body["ContractorETA"] = ExpressionConverter.ConvertO(bodyContractorETA);
                bodypropCount++;
            }

            if (bodyContractorOrderNumber != null)
            {
                body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(bodyContractorOrderNumber);
                bodypropCount++;
            }

            if (bodyCreatedBySecurityUserID != null)
            {
                body["CreatedBy_SecurityUserID"] = ExpressionConverter.ConvertO(bodyCreatedBySecurityUserID);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            var CustomDate1Object = new JObject();
            var CustomDate1ObjectpropCount = 0;
            if (bodyCustomDate1Value != null)
            {
                CustomDate1Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate1Value);
                CustomDate1ObjectpropCount++;
            }

            if (bodyCustomDate1Operator != null)
            {
                CustomDate1Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate1Operator);
                CustomDate1ObjectpropCount++;
            }

            if (CustomDate1ObjectpropCount > 0)
            {
                body["CustomDate1"] = CustomDate1Object;
                bodypropCount++;
            }

            var CustomDate2Object = new JObject();
            var CustomDate2ObjectpropCount = 0;
            if (bodyCustomDate2Value != null)
            {
                CustomDate2Object["Value"] = ExpressionConverter.ConvertO(bodyCustomDate2Value);
                CustomDate2ObjectpropCount++;
            }

            if (bodyCustomDate2Operator != null)
            {
                CustomDate2Object["_operator"] = ExpressionConverter.ConvertO(bodyCustomDate2Operator);
                CustomDate2ObjectpropCount++;
            }

            if (CustomDate2ObjectpropCount > 0)
            {
                body["CustomDate2"] = CustomDate2Object;
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            var DateCreatedObject = new JObject();
            var DateCreatedObjectpropCount = 0;
            if (bodyDateCreatedValue != null)
            {
                DateCreatedObject["Value"] = ExpressionConverter.ConvertO(bodyDateCreatedValue);
                DateCreatedObjectpropCount++;
            }

            if (bodyDateCreatedOperator != null)
            {
                DateCreatedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateCreatedOperator);
                DateCreatedObjectpropCount++;
            }

            if (DateCreatedObjectpropCount > 0)
            {
                body["DateCreated"] = DateCreatedObject;
                bodypropCount++;
            }

            var DateDueObject = new JObject();
            var DateDueObjectpropCount = 0;
            if (bodyDateDueValue != null)
            {
                DateDueObject["Value"] = ExpressionConverter.ConvertO(bodyDateDueValue);
                DateDueObjectpropCount++;
            }

            if (bodyDateDueOperator != null)
            {
                DateDueObject["_operator"] = ExpressionConverter.ConvertO(bodyDateDueOperator);
                DateDueObjectpropCount++;
            }

            if (DateDueObjectpropCount > 0)
            {
                body["DateDue"] = DateDueObject;
                bodypropCount++;
            }

            var DateModifiedObject = new JObject();
            var DateModifiedObjectpropCount = 0;
            if (bodyDateModifiedValue != null)
            {
                DateModifiedObject["Value"] = ExpressionConverter.ConvertO(bodyDateModifiedValue);
                DateModifiedObjectpropCount++;
            }

            if (bodyDateModifiedOperator != null)
            {
                DateModifiedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateModifiedOperator);
                DateModifiedObjectpropCount++;
            }

            if (DateModifiedObjectpropCount > 0)
            {
                body["DateModified"] = DateModifiedObject;
                bodypropCount++;
            }

            var DateReportedObject = new JObject();
            var DateReportedObjectpropCount = 0;
            if (bodyDateReportedValue != null)
            {
                DateReportedObject["Value"] = ExpressionConverter.ConvertO(bodyDateReportedValue);
                DateReportedObjectpropCount++;
            }

            if (bodyDateReportedOperator != null)
            {
                DateReportedObject["_operator"] = ExpressionConverter.ConvertO(bodyDateReportedOperator);
                DateReportedObjectpropCount++;
            }

            if (DateReportedObjectpropCount > 0)
            {
                body["DateReported"] = DateReportedObject;
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyJobSent != null)
            {
                body["JobSent"] = ExpressionConverter.ConvertO(bodyJobSent);
                bodypropCount++;
            }

            if (bodyJobStatus != null)
            {
                body["JobStatus"] = ExpressionConverter.ConvertO(bodyJobStatus);
                bodypropCount++;
            }

            if (bodyLocation != null)
            {
                body["Location"] = ExpressionConverter.ConvertO(bodyLocation);
                bodypropCount++;
            }

            if (bodyOccupantEntryID != null)
            {
                body["Occupant_EntryID"] = ExpressionConverter.ConvertO(bodyOccupantEntryID);
                bodypropCount++;
            }

            if (bodyOccupantEntryName != null)
            {
                body["OccupantEntryName"] = ExpressionConverter.ConvertO(bodyOccupantEntryName);
                bodypropCount++;
            }

            if (bodyOccupantPresent != null)
            {
                body["OccupantPresent"] = ExpressionConverter.ConvertO(bodyOccupantPresent);
                bodypropCount++;
            }

            if (bodyOccupantPresentReason != null)
            {
                body["OccupantPresentReason"] = ExpressionConverter.ConvertO(bodyOccupantPresentReason);
                bodypropCount++;
            }

            if (bodyOtherServiceNumber != null)
            {
                body["OtherServiceNumber"] = ExpressionConverter.ConvertO(bodyOtherServiceNumber);
                bodypropCount++;
            }

            if (bodyPriorityID != null)
            {
                body["PriorityID"] = ExpressionConverter.ConvertO(bodyPriorityID);
                bodypropCount++;
            }

            if (bodyRepairDescription != null)
            {
                body["RepairDescription"] = ExpressionConverter.ConvertO(bodyRepairDescription);
                bodypropCount++;
            }

            if (bodyReportedByName != null)
            {
                body["ReportedByName"] = ExpressionConverter.ConvertO(bodyReportedByName);
                bodypropCount++;
            }

            if (bodyReportedByPhone != null)
            {
                body["ReportedByPhone"] = ExpressionConverter.ConvertO(bodyReportedByPhone);
                bodypropCount++;
            }

            if (bodyRoomSpaceClosedID != null)
            {
                body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(bodyRoomSpaceClosedID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceCategoryID != null)
            {
                body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceCategoryID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceID != null)
            {
                body["RoomSpaceMaintenanceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceItemID != null)
            {
                body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceItemID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            var StartDateObject = new JObject();
            var StartDateObjectpropCount = 0;
            if (bodyStartDateValue != null)
            {
                StartDateObject["Value"] = ExpressionConverter.ConvertO(bodyStartDateValue);
                StartDateObjectpropCount++;
            }

            if (bodyStartDateOperator != null)
            {
                StartDateObject["_operator"] = ExpressionConverter.ConvertO(bodyStartDateOperator);
                StartDateObjectpropCount++;
            }

            if (StartDateObjectpropCount > 0)
            {
                body["StartDate"] = StartDateObject;
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyTechnician != null)
            {
                body["Technician"] = ExpressionConverter.ConvertO(bodyTechnician);
                bodypropCount++;
            }

            if (bodyViewOnWeb != null)
            {
                body["ViewOnWeb"] = ExpressionConverter.ConvertO(bodyViewOnWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SelectRoomSpaceMaintenanceResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceMaintenanceResponse> CreateRoomSpaceMaintenance(Expression<Func<int>> bodyRoomSpaceID, Expression<Func<string>> bodyAccountCode = null, Expression<Func<string>> bodyCause = null, Expression<Func<bool>> bodyCharge = null, Expression<Func<int>> bodyChargeEntryID = null, Expression<Func<double>> bodyChargeAmount = null, Expression<Func<bool>> bodyChargeInvoiced = null, Expression<Func<string>> bodyChargeInvoiceNumber = null, Expression<Func<string>> bodyChargeType = null, Expression<Func<string>> bodyCompleteDate = null, Expression<Func<int>> bodyContactID = null, Expression<Func<string>> bodyContractDate = null, Expression<Func<double>> bodyContractorCost = null, Expression<Func<double>> bodyContractorCostEstimate = null, Expression<Func<string>> bodyContractorDate = null, Expression<Func<string>> bodyContractorETA = null, Expression<Func<string>> bodyContractorOrderNumber = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateDue = null, Expression<Func<string>> bodyDateReported = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bool>> bodyJobSent = null, Expression<Func<string>> bodyJobStatus = null, Expression<Func<string>> bodyLocation = null, Expression<Func<int>> bodyOccupantEntryID = null, Expression<Func<string>> bodyOccupantEntryName = null, Expression<Func<bool>> bodyOccupantPresent = null, Expression<Func<string>> bodyOccupantPresentReason = null, Expression<Func<string>> bodyOtherServiceNumber = null, Expression<Func<int>> bodyPriorityID = null, Expression<Func<string>> bodyRepairDescription = null, Expression<Func<string>> bodyReportedByName = null, Expression<Func<string>> bodyReportedByPhone = null, Expression<Func<int>> bodyRoomSpaceClosedID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceCategoryID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceItemID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<string>> bodyStartDate = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyTechnician = null, Expression<Func<bool>> bodyViewOnWeb = null)
        {
            var apiCallPath = "/create/roomspacemaintenance.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountCode != null)
            {
                body["AccountCode"] = ExpressionConverter.ConvertO(bodyAccountCode);
                bodypropCount++;
            }

            if (bodyCause != null)
            {
                body["Cause"] = ExpressionConverter.ConvertO(bodyCause);
                bodypropCount++;
            }

            if (bodyCharge != null)
            {
                body["Charge"] = ExpressionConverter.ConvertO(bodyCharge);
                bodypropCount++;
            }

            if (bodyChargeEntryID != null)
            {
                body["Charge_EntryID"] = ExpressionConverter.ConvertO(bodyChargeEntryID);
                bodypropCount++;
            }

            if (bodyChargeAmount != null)
            {
                body["ChargeAmount"] = ExpressionConverter.ConvertO(bodyChargeAmount);
                bodypropCount++;
            }

            if (bodyChargeInvoiced != null)
            {
                body["ChargeInvoiced"] = ExpressionConverter.ConvertO(bodyChargeInvoiced);
                bodypropCount++;
            }

            if (bodyChargeInvoiceNumber != null)
            {
                body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(bodyChargeInvoiceNumber);
                bodypropCount++;
            }

            if (bodyChargeType != null)
            {
                body["ChargeType"] = ExpressionConverter.ConvertO(bodyChargeType);
                bodypropCount++;
            }

            if (bodyCompleteDate != null)
            {
                body["CompleteDate"] = ExpressionConverter.ConvertO(bodyCompleteDate);
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            if (bodyContractDate != null)
            {
                body["ContractDate"] = ExpressionConverter.ConvertO(bodyContractDate);
                bodypropCount++;
            }

            if (bodyContractorCost != null)
            {
                body["ContractorCost"] = ExpressionConverter.ConvertO(bodyContractorCost);
                bodypropCount++;
            }

            if (bodyContractorCostEstimate != null)
            {
                body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(bodyContractorCostEstimate);
                bodypropCount++;
            }

            if (bodyContractorDate != null)
            {
                body["ContractorDate"] = ExpressionConverter.ConvertO(bodyContractorDate);
                bodypropCount++;
            }

            if (bodyContractorETA != null)
            {
                body["ContractorETA"] = ExpressionConverter.ConvertO(bodyContractorETA);
                bodypropCount++;
            }

            if (bodyContractorOrderNumber != null)
            {
                body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(bodyContractorOrderNumber);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyDateDue != null)
            {
                body["DateDue"] = ExpressionConverter.ConvertO(bodyDateDue);
                bodypropCount++;
            }

            if (bodyDateReported != null)
            {
                body["DateReported"] = ExpressionConverter.ConvertO(bodyDateReported);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyJobSent != null)
            {
                body["JobSent"] = ExpressionConverter.ConvertO(bodyJobSent);
                bodypropCount++;
            }

            if (bodyJobStatus != null)
            {
                body["JobStatus"] = ExpressionConverter.ConvertO(bodyJobStatus);
                bodypropCount++;
            }

            if (bodyLocation != null)
            {
                body["Location"] = ExpressionConverter.ConvertO(bodyLocation);
                bodypropCount++;
            }

            if (bodyOccupantEntryID != null)
            {
                body["Occupant_EntryID"] = ExpressionConverter.ConvertO(bodyOccupantEntryID);
                bodypropCount++;
            }

            if (bodyOccupantEntryName != null)
            {
                body["OccupantEntryName"] = ExpressionConverter.ConvertO(bodyOccupantEntryName);
                bodypropCount++;
            }

            if (bodyOccupantPresent != null)
            {
                body["OccupantPresent"] = ExpressionConverter.ConvertO(bodyOccupantPresent);
                bodypropCount++;
            }

            if (bodyOccupantPresentReason != null)
            {
                body["OccupantPresentReason"] = ExpressionConverter.ConvertO(bodyOccupantPresentReason);
                bodypropCount++;
            }

            if (bodyOtherServiceNumber != null)
            {
                body["OtherServiceNumber"] = ExpressionConverter.ConvertO(bodyOtherServiceNumber);
                bodypropCount++;
            }

            if (bodyPriorityID != null)
            {
                body["PriorityID"] = ExpressionConverter.ConvertO(bodyPriorityID);
                bodypropCount++;
            }

            if (bodyRepairDescription != null)
            {
                body["RepairDescription"] = ExpressionConverter.ConvertO(bodyRepairDescription);
                bodypropCount++;
            }

            if (bodyReportedByName != null)
            {
                body["ReportedByName"] = ExpressionConverter.ConvertO(bodyReportedByName);
                bodypropCount++;
            }

            if (bodyReportedByPhone != null)
            {
                body["ReportedByPhone"] = ExpressionConverter.ConvertO(bodyReportedByPhone);
                bodypropCount++;
            }

            if (bodyRoomSpaceClosedID != null)
            {
                body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(bodyRoomSpaceClosedID);
                bodypropCount++;
            }

            bodypropCount++;
            body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
            if (bodyRoomSpaceMaintenanceCategoryID != null)
            {
                body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceCategoryID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceItemID != null)
            {
                body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceItemID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyStartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodyStartDate);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyTechnician != null)
            {
                body["Technician"] = ExpressionConverter.ConvertO(bodyTechnician);
                bodypropCount++;
            }

            if (bodyViewOnWeb != null)
            {
                body["ViewOnWeb"] = ExpressionConverter.ConvertO(bodyViewOnWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRoomSpaceMaintenanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateRoomSpaceMaintenanceResponse> UpdateRoomSpaceMaintenance(Expression<Func<int>> roomSpaceMaintenanceID, Expression<Func<string>> bodyAccountCode = null, Expression<Func<string>> bodyCause = null, Expression<Func<bool>> bodyCharge = null, Expression<Func<int>> bodyChargeEntryID = null, Expression<Func<double>> bodyChargeAmount = null, Expression<Func<bool>> bodyChargeInvoiced = null, Expression<Func<string>> bodyChargeInvoiceNumber = null, Expression<Func<string>> bodyChargeType = null, Expression<Func<string>> bodyCompleteDate = null, Expression<Func<int>> bodyContactID = null, Expression<Func<string>> bodyContractDate = null, Expression<Func<double>> bodyContractorCost = null, Expression<Func<double>> bodyContractorCostEstimate = null, Expression<Func<string>> bodyContractorDate = null, Expression<Func<string>> bodyContractorETA = null, Expression<Func<string>> bodyContractorOrderNumber = null, Expression<Func<bool>> bodyCustomBit1 = null, Expression<Func<bool>> bodyCustomBit2 = null, Expression<Func<string>> bodyCustomDate1 = null, Expression<Func<string>> bodyCustomDate2 = null, Expression<Func<string>> bodyCustomString1 = null, Expression<Func<string>> bodyCustomString2 = null, Expression<Func<string>> bodyCustomString3 = null, Expression<Func<string>> bodyCustomString4 = null, Expression<Func<string>> bodyCustomString5 = null, Expression<Func<string>> bodyCustomString6 = null, Expression<Func<string>> bodyDateDue = null, Expression<Func<string>> bodyDateReported = null, Expression<Func<string>> bodyDescription = null, Expression<Func<bool>> bodyJobSent = null, Expression<Func<string>> bodyJobStatus = null, Expression<Func<string>> bodyLocation = null, Expression<Func<int>> bodyOccupantEntryID = null, Expression<Func<string>> bodyOccupantEntryName = null, Expression<Func<bool>> bodyOccupantPresent = null, Expression<Func<string>> bodyOccupantPresentReason = null, Expression<Func<string>> bodyOtherServiceNumber = null, Expression<Func<int>> bodyPriorityID = null, Expression<Func<string>> bodyRepairDescription = null, Expression<Func<string>> bodyReportedByName = null, Expression<Func<string>> bodyReportedByPhone = null, Expression<Func<int>> bodyRoomSpaceClosedID = null, Expression<Func<int>> bodyRoomSpaceID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceCategoryID = null, Expression<Func<int>> bodyRoomSpaceMaintenanceItemID = null, Expression<Func<int>> bodySecurityUserID = null, Expression<Func<string>> bodyStartDate = null, Expression<Func<string>> bodyStatus = null, Expression<Func<string>> bodyTechnician = null, Expression<Func<bool>> bodyViewOnWeb = null)
        {
            var apiCallPath = String.Format("/update/roomspacemaintenance.json/{0}", ExpressionConverter.ConvertWithUrlEncoding(roomSpaceMaintenanceID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountCode != null)
            {
                body["AccountCode"] = ExpressionConverter.ConvertO(bodyAccountCode);
                bodypropCount++;
            }

            if (bodyCause != null)
            {
                body["Cause"] = ExpressionConverter.ConvertO(bodyCause);
                bodypropCount++;
            }

            if (bodyCharge != null)
            {
                body["Charge"] = ExpressionConverter.ConvertO(bodyCharge);
                bodypropCount++;
            }

            if (bodyChargeEntryID != null)
            {
                body["Charge_EntryID"] = ExpressionConverter.ConvertO(bodyChargeEntryID);
                bodypropCount++;
            }

            if (bodyChargeAmount != null)
            {
                body["ChargeAmount"] = ExpressionConverter.ConvertO(bodyChargeAmount);
                bodypropCount++;
            }

            if (bodyChargeInvoiced != null)
            {
                body["ChargeInvoiced"] = ExpressionConverter.ConvertO(bodyChargeInvoiced);
                bodypropCount++;
            }

            if (bodyChargeInvoiceNumber != null)
            {
                body["ChargeInvoiceNumber"] = ExpressionConverter.ConvertO(bodyChargeInvoiceNumber);
                bodypropCount++;
            }

            if (bodyChargeType != null)
            {
                body["ChargeType"] = ExpressionConverter.ConvertO(bodyChargeType);
                bodypropCount++;
            }

            if (bodyCompleteDate != null)
            {
                body["CompleteDate"] = ExpressionConverter.ConvertO(bodyCompleteDate);
                bodypropCount++;
            }

            if (bodyContactID != null)
            {
                body["ContactID"] = ExpressionConverter.ConvertO(bodyContactID);
                bodypropCount++;
            }

            if (bodyContractDate != null)
            {
                body["ContractDate"] = ExpressionConverter.ConvertO(bodyContractDate);
                bodypropCount++;
            }

            if (bodyContractorCost != null)
            {
                body["ContractorCost"] = ExpressionConverter.ConvertO(bodyContractorCost);
                bodypropCount++;
            }

            if (bodyContractorCostEstimate != null)
            {
                body["ContractorCostEstimate"] = ExpressionConverter.ConvertO(bodyContractorCostEstimate);
                bodypropCount++;
            }

            if (bodyContractorDate != null)
            {
                body["ContractorDate"] = ExpressionConverter.ConvertO(bodyContractorDate);
                bodypropCount++;
            }

            if (bodyContractorETA != null)
            {
                body["ContractorETA"] = ExpressionConverter.ConvertO(bodyContractorETA);
                bodypropCount++;
            }

            if (bodyContractorOrderNumber != null)
            {
                body["ContractorOrderNumber"] = ExpressionConverter.ConvertO(bodyContractorOrderNumber);
                bodypropCount++;
            }

            if (bodyCustomBit1 != null)
            {
                body["CustomBit1"] = ExpressionConverter.ConvertO(bodyCustomBit1);
                bodypropCount++;
            }

            if (bodyCustomBit2 != null)
            {
                body["CustomBit2"] = ExpressionConverter.ConvertO(bodyCustomBit2);
                bodypropCount++;
            }

            if (bodyCustomDate1 != null)
            {
                body["CustomDate1"] = ExpressionConverter.ConvertO(bodyCustomDate1);
                bodypropCount++;
            }

            if (bodyCustomDate2 != null)
            {
                body["CustomDate2"] = ExpressionConverter.ConvertO(bodyCustomDate2);
                bodypropCount++;
            }

            if (bodyCustomString1 != null)
            {
                body["CustomString1"] = ExpressionConverter.ConvertO(bodyCustomString1);
                bodypropCount++;
            }

            if (bodyCustomString2 != null)
            {
                body["CustomString2"] = ExpressionConverter.ConvertO(bodyCustomString2);
                bodypropCount++;
            }

            if (bodyCustomString3 != null)
            {
                body["CustomString3"] = ExpressionConverter.ConvertO(bodyCustomString3);
                bodypropCount++;
            }

            if (bodyCustomString4 != null)
            {
                body["CustomString4"] = ExpressionConverter.ConvertO(bodyCustomString4);
                bodypropCount++;
            }

            if (bodyCustomString5 != null)
            {
                body["CustomString5"] = ExpressionConverter.ConvertO(bodyCustomString5);
                bodypropCount++;
            }

            if (bodyCustomString6 != null)
            {
                body["CustomString6"] = ExpressionConverter.ConvertO(bodyCustomString6);
                bodypropCount++;
            }

            if (bodyDateDue != null)
            {
                body["DateDue"] = ExpressionConverter.ConvertO(bodyDateDue);
                bodypropCount++;
            }

            if (bodyDateReported != null)
            {
                body["DateReported"] = ExpressionConverter.ConvertO(bodyDateReported);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyJobSent != null)
            {
                body["JobSent"] = ExpressionConverter.ConvertO(bodyJobSent);
                bodypropCount++;
            }

            if (bodyJobStatus != null)
            {
                body["JobStatus"] = ExpressionConverter.ConvertO(bodyJobStatus);
                bodypropCount++;
            }

            if (bodyLocation != null)
            {
                body["Location"] = ExpressionConverter.ConvertO(bodyLocation);
                bodypropCount++;
            }

            if (bodyOccupantEntryID != null)
            {
                body["Occupant_EntryID"] = ExpressionConverter.ConvertO(bodyOccupantEntryID);
                bodypropCount++;
            }

            if (bodyOccupantEntryName != null)
            {
                body["OccupantEntryName"] = ExpressionConverter.ConvertO(bodyOccupantEntryName);
                bodypropCount++;
            }

            if (bodyOccupantPresent != null)
            {
                body["OccupantPresent"] = ExpressionConverter.ConvertO(bodyOccupantPresent);
                bodypropCount++;
            }

            if (bodyOccupantPresentReason != null)
            {
                body["OccupantPresentReason"] = ExpressionConverter.ConvertO(bodyOccupantPresentReason);
                bodypropCount++;
            }

            if (bodyOtherServiceNumber != null)
            {
                body["OtherServiceNumber"] = ExpressionConverter.ConvertO(bodyOtherServiceNumber);
                bodypropCount++;
            }

            if (bodyPriorityID != null)
            {
                body["PriorityID"] = ExpressionConverter.ConvertO(bodyPriorityID);
                bodypropCount++;
            }

            if (bodyRepairDescription != null)
            {
                body["RepairDescription"] = ExpressionConverter.ConvertO(bodyRepairDescription);
                bodypropCount++;
            }

            if (bodyReportedByName != null)
            {
                body["ReportedByName"] = ExpressionConverter.ConvertO(bodyReportedByName);
                bodypropCount++;
            }

            if (bodyReportedByPhone != null)
            {
                body["ReportedByPhone"] = ExpressionConverter.ConvertO(bodyReportedByPhone);
                bodypropCount++;
            }

            if (bodyRoomSpaceClosedID != null)
            {
                body["RoomSpaceClosedID"] = ExpressionConverter.ConvertO(bodyRoomSpaceClosedID);
                bodypropCount++;
            }

            if (bodyRoomSpaceID != null)
            {
                body["RoomSpaceID"] = ExpressionConverter.ConvertO(bodyRoomSpaceID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceCategoryID != null)
            {
                body["RoomSpaceMaintenanceCategoryID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceCategoryID);
                bodypropCount++;
            }

            if (bodyRoomSpaceMaintenanceItemID != null)
            {
                body["RoomSpaceMaintenanceItemID"] = ExpressionConverter.ConvertO(bodyRoomSpaceMaintenanceItemID);
                bodypropCount++;
            }

            if (bodySecurityUserID != null)
            {
                body["SecurityUserID"] = ExpressionConverter.ConvertO(bodySecurityUserID);
                bodypropCount++;
            }

            if (bodyStartDate != null)
            {
                body["StartDate"] = ExpressionConverter.ConvertO(bodyStartDate);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyTechnician != null)
            {
                body["Technician"] = ExpressionConverter.ConvertO(bodyTechnician);
                bodypropCount++;
            }

            if (bodyViewOnWeb != null)
            {
                body["ViewOnWeb"] = ExpressionConverter.ConvertO(bodyViewOnWeb);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateRoomSpaceMaintenanceResponse>(callPayload);
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
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "1000")]
        _1000
    }

    public enum bodyBirthGenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public enum bodyDateCreatedOperatorInput
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

    public enum bodyDateModifiedOperatorInput
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

    public enum bodyDOBOperatorInput
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

    public enum bodyEntryStatusEnumInput
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

    public enum bodyGenderEnumInput
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public enum bodyLastCheckInOutDateOperatorInput
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

    public enum bodyPreviousEntryStatusEnumInput
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

    public enum bodyTaxExemptionEnumInput
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

    public enum bodyFieldDataTypeEnumInput
    {
        Boolean,
        Date,
        DateTime,
        Integer,
        Money,
        String,
        StringLong
    }

    public enum bodyValueDateOperatorInput
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

    public enum bodyActiveDateCloseOperatorInput
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

    public enum bodyActiveDateOpenOperatorInput
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

    public enum bodyRecordTypeEnumInput
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

    public enum bodyActiveDateEndOperatorInput
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

    public enum bodyActiveDateStartOperatorInput
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

    public enum bodyAllocateOptionEnumInput
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    public enum bodyApplicationDateOperatorInput
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

    public enum bodyCancelDateOperatorInput
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

    public enum bodyCompleteDateOperatorInput
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

    public enum bodyContractSignedDateOperatorInput
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

    public enum bodyCustomDate1OperatorInput
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

    public enum bodyCustomDate2OperatorInput
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

    public enum bodyCustomDate3OperatorInput
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

    public enum bodyCustomDate4OperatorInput
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

    public enum bodyEnquiryDateOperatorInput
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

    public enum bodyExpectedArrivalDateOperatorInput
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

    public enum bodyExpectedArrivalDateLatestOperatorInput
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

    public enum bodyExpectedDepartureDateOperatorInput
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

    public enum bodyOfferedDateOperatorInput
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

    public enum bodyOfferReplyDateOperatorInput
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

    public enum bodyOfferReplyEnumInput
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    public enum bodyOfferSentDateOperatorInput
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

    public enum bodyReceivedDateOperatorInput
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

    public enum bodyReceivedDepositDateOperatorInput
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

    public enum bodyReceivedFeeDateOperatorInput
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

    public enum bodyReceivedPhotoDateOperatorInput
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

    public enum bodyCancelBookingUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckInDateOperatorInput
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

    public enum bodyCheckInDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckInDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckInUpdateStartBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckOutDateOperatorInput
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

    public enum bodyCheckOutDateActualDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckOutDateActualIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyCheckOutUpdateEndBookingReasonBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyContractDateCheckInDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyContractDateCheckInIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyContractDateCheckOutDecreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyContractDateCheckOutIncreaseBooleanAskEnumInput
    {
        Ask,
        No,
        Yes
    }

    public enum bodyContractDateEndOperatorInput
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

    public enum bodyContractDateStartOperatorInput
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

    public enum bodyAccountDueDateOperatorInput
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

    public enum bodyAttendeeStatusEnumInput
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

    public enum bodyDateEntryOperatorInput
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

    public enum bodyDateExitOperatorInput
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

    public enum bodyDeceasedDateOperatorInput
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

    public enum bodyExpectedGraduationDateOperatorInput
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

    public enum bodySituationResponseEnumInput
    {
        NoResponse,
        NotOkay,
        Okay
    }

    public enum bodySituationResponseExpiryDateOperatorInput
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

    public enum bodySituationResponseModifiedDateOperatorInput
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

    public enum bodyDateEndOperatorInput
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

    public enum bodyDateStartOperatorInput
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

    public enum bodyEnrollmentTypeEnumInput
    {
        Current,
        Preferred,
        Previous
    }

    public enum bodyGraduationDateOperatorInput
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

    public enum bodyBookingLinkTypeEnumInput
    {
        None,
        Child,
        Parent,
        Reference
    }

    public enum bodyCheckInDateActualOperatorInput
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

    public enum bodyCheckOutDateActualOperatorInput
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

    public enum bodyDateBilledOperatorInput
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

    public enum bodyDateChargedToOperatorInput
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

    public enum bodyDateModifiedBillingOperatorInput
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

    public enum bodyPaidToOperatorInput
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

    public enum bodyRoomSpaceTypeEnumInput
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

    public enum bodyGenderTypeEnumInput
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

    public enum bodyCallTypeEnumInput
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

    public enum bodyDueDateOperatorInput
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

    public enum bodyPaidFromOperatorInput
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

    public enum bodyProcessedDateOperatorInput
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

    public enum bodyTransactionDateOperatorInput
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

    public enum bodyTransactionTypeEnumInput
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

    public enum bodyContractDateOperatorInput
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

    public enum bodyContractorDateOperatorInput
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

    public enum bodyDateDueOperatorInput
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

    public enum bodyDateReportedOperatorInput
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

    public enum bodyStartDateOperatorInput
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