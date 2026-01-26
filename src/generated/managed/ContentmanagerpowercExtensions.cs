//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Contentmanagerpowerc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ContentmanagerpowercActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMBobResponse> CMObjectSearch(Expression<Func<string>> searchqueryString, Expression<Func<string>> userToImpersonate = null, Expression<Func<searchTrimTypeInput>> searchTrimType = null, Expression<Func<bool>> searchapplyDefaults = null, Expression<Func<bool>> searchcountResults = null, Expression<Func<string>> searchdescendantProperties = null, Expression<Func<bool>> searchexcludeCount = null, Expression<Func<string>> searchFilter = null, Expression<Func<int>> searchfromSearch = null, Expression<Func<bool>> searchincludePropertyDefs = null, Expression<Func<string>> searchOptions = null, Expression<Func<int>> searchpageSize = null, Expression<Func<searchpropertyValueInput>> searchpropertyValue = null, Expression<Func<string>> searchpropertySets = null, Expression<Func<int>> searchpurpose = null, Expression<Func<int>> searchpurposeExtra = null, Expression<Func<string>> searchsortBy = null, Expression<Func<int>> searchstart = null, Expression<Func<searchstringDisplayTypeInput>> searchstringDisplayType = null, Expression<Func<string>> properties = null)
        {
            var apiCallPath = "/Search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["properties"] = Convert.ToString("Uri,NameString");
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var search = new JObject();
            var searchpropCount = 0;
            if (searchTrimType != null)
            {
                search["TrimType"] = ExpressionConverter.ConvertO(searchTrimType);
                searchpropCount++;
            }

            searchpropCount++;
            search["q"] = ExpressionConverter.ConvertO(searchqueryString);
            if (searchapplyDefaults != null)
            {
                search["ApplyDefaults"] = ExpressionConverter.ConvertO(searchapplyDefaults);
                searchpropCount++;
            }

            if (searchcountResults != null)
            {
                search["CountResults"] = ExpressionConverter.ConvertO(searchcountResults);
                searchpropCount++;
            }

            if (searchdescendantProperties != null)
            {
                search["DescendantProperties"] = ExpressionConverter.ConvertO(searchdescendantProperties);
                searchpropCount++;
            }

            if (searchexcludeCount != null)
            {
                search["ExcludeCount"] = ExpressionConverter.ConvertO(searchexcludeCount);
                searchpropCount++;
            }

            if (searchFilter != null)
            {
                search["Filter"] = ExpressionConverter.ConvertO(searchFilter);
                searchpropCount++;
            }

            if (searchfromSearch != null)
            {
                search["FromSearch"] = ExpressionConverter.ConvertO(searchfromSearch);
                searchpropCount++;
            }

            if (searchincludePropertyDefs != null)
            {
                search["IncludePropertyDefs"] = ExpressionConverter.ConvertO(searchincludePropertyDefs);
                searchpropCount++;
            }

            if (searchOptions != null)
            {
                search["Options"] = ExpressionConverter.ConvertO(searchOptions);
                searchpropCount++;
            }

            if (searchpageSize != null)
            {
                search["pageSize"] = ExpressionConverter.ConvertO(searchpageSize);
                searchpropCount++;
            }

            if (searchpropertyValue != null)
            {
                search["PropertyValue"] = ExpressionConverter.ConvertO(searchpropertyValue);
                searchpropCount++;
            }

            if (searchpropertySets != null)
            {
                search["PropertySets"] = ExpressionConverter.ConvertO(searchpropertySets);
                searchpropCount++;
            }

            if (searchpurpose != null)
            {
                search["purpose"] = ExpressionConverter.ConvertO(searchpurpose);
                searchpropCount++;
            }

            if (searchpurposeExtra != null)
            {
                search["purposeExtra"] = ExpressionConverter.ConvertO(searchpurposeExtra);
                searchpropCount++;
            }

            if (searchsortBy != null)
            {
                search["sortBy"] = ExpressionConverter.ConvertO(searchsortBy);
                searchpropCount++;
            }

            if (searchstart != null)
            {
                search["start"] = ExpressionConverter.ConvertO(searchstart);
                searchpropCount++;
            }

            if (searchstringDisplayType != null)
            {
                search["StringDisplayType"] = ExpressionConverter.ConvertO(searchstringDisplayType);
                searchpropCount++;
            }

            if (searchpropCount > 0)
            {
                callPayload.Body = search;
            }

            return new ApiConnectionAction<CMBobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<JToken> RecordSearchAdvanced(Expression<Func<string>> q, Expression<Func<string>> properties, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/FindRecordAdvanced";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            callPayload.Headers["parseResponse"] = Convert.ToString(false);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSearch(Expression<Func<string>> q, Expression<Func<string>> properties, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/Record";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdate(Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> recorduniqueIdentifier = null, Expression<Func<string>> recordquery = null, Expression<Func<string>> recordtitleFreeTextPart = null, Expression<Func<string>> recordproperties = null, Expression<Func<string>> recordauthor = null, Expression<Func<string>> recordcontainer = null, Expression<Func<string>> recordclassification = null, Expression<Func<string>> recordaddressee = null, Expression<Func<string>> recordalternativeContainer = null, Expression<Func<string>> recordassignee = null, Expression<Func<bool>> recordautoRenderToPDFOnSave = null, Expression<Func<bool>> recordbypassRecordTypeAccessControls = null, Expression<Func<string>> recordcheckInAs = null, Expression<Func<string>> recordclient = null, Expression<Func<string>> recordclientRecord = null, Expression<Func<string>> recordcopyDocumentFromRecord = null, Expression<Func<string>> recordcreator = null, Expression<Func<string>> recorddateCreated = null, Expression<Func<string>> recorddateDue = null, Expression<Func<string>> recorddatePublished = null, Expression<Func<string>> recorddateReceived = null, Expression<Func<string>> recordexternalReference = null, Expression<Func<bool>> recordfailOnWarnings = null, Expression<Func<string>> recordfileNameInUploadsFolder = null, Expression<Func<bool>> recordfinalizeOnSave = null, Expression<Func<string>> recordforeignBarcode = null, Expression<Func<string>> recordgPSLocation = null, Expression<Func<string>> recordhomeLocation = null, Expression<Func<string>> recordhomeSpace = null, Expression<Func<bool>> recordisEnclosed = null, Expression<Func<string>> recordjurisdiction = null, Expression<Func<bool>> recordkeepCheckedOut = null, Expression<Func<string>> recordlongNumber = null, Expression<Func<string>> recordmediaType = null, Expression<Func<string>> recordnotes = null, Expression<Func<recordnotesUpdateTypeInput>> recordnotesUpdateType = null, Expression<Func<string>> recordotherContact = null, Expression<Func<string>> recordownerLocation = null, Expression<Func<string>> recordrelatedRecord = null, Expression<Func<string>> recordrepresentative = null, Expression<Func<string>> recordreviewDate = null, Expression<Func<string>> recordreviewDueDate = null, Expression<Func<recordreviewStateInput>> recordreviewState = null, Expression<Func<string>> recordsecurity = null)
        {
            var apiCallPath = "/Record";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            if (recorduniqueIdentifier != null)
            {
                record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
                recordpropCount++;
            }

            if (recordquery != null)
            {
                record["q"] = ExpressionConverter.ConvertO(recordquery);
                recordpropCount++;
            }

            if (recordtitleFreeTextPart != null)
            {
                record["RecordTypedTitle"] = ExpressionConverter.ConvertO(recordtitleFreeTextPart);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordauthor != null)
            {
                record["RecordAuthor"] = ExpressionConverter.ConvertO(recordauthor);
                recordpropCount++;
            }

            if (recordcontainer != null)
            {
                record["RecordContainer"] = ExpressionConverter.ConvertO(recordcontainer);
                recordpropCount++;
            }

            if (recordclassification != null)
            {
                record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
                recordpropCount++;
            }

            if (recordaddressee != null)
            {
                record["RecordAddressee"] = ExpressionConverter.ConvertO(recordaddressee);
                recordpropCount++;
            }

            if (recordalternativeContainer != null)
            {
                record["RecordAlternativeContainer"] = ExpressionConverter.ConvertO(recordalternativeContainer);
                recordpropCount++;
            }

            if (recordassignee != null)
            {
                record["RecordAssignee"] = ExpressionConverter.ConvertO(recordassignee);
                recordpropCount++;
            }

            if (recordautoRenderToPDFOnSave != null)
            {
                record["RecordAutoRenderToPDFOnSave"] = ExpressionConverter.ConvertO(recordautoRenderToPDFOnSave);
                recordpropCount++;
            }

            if (recordbypassRecordTypeAccessControls != null)
            {
                record["RecordBypassRecordTypeAccessControls"] = ExpressionConverter.ConvertO(recordbypassRecordTypeAccessControls);
                recordpropCount++;
            }

            if (recordcheckInAs != null)
            {
                record["CheckinAs"] = ExpressionConverter.ConvertO(recordcheckInAs);
                recordpropCount++;
            }

            if (recordclient != null)
            {
                record["RecordClient"] = ExpressionConverter.ConvertO(recordclient);
                recordpropCount++;
            }

            if (recordclientRecord != null)
            {
                record["RecordClientRecord"] = ExpressionConverter.ConvertO(recordclientRecord);
                recordpropCount++;
            }

            if (recordcopyDocumentFromRecord != null)
            {
                record["CopyDocumentFromRecord"] = ExpressionConverter.ConvertO(recordcopyDocumentFromRecord);
                recordpropCount++;
            }

            if (recordcreator != null)
            {
                record["RecordCreator"] = ExpressionConverter.ConvertO(recordcreator);
                recordpropCount++;
            }

            if (recorddateCreated != null)
            {
                record["RecordDateCreated"] = ExpressionConverter.ConvertO(recorddateCreated);
                recordpropCount++;
            }

            if (recorddateDue != null)
            {
                record["RecordDateDue"] = ExpressionConverter.ConvertO(recorddateDue);
                recordpropCount++;
            }

            if (recorddatePublished != null)
            {
                record["RecordDatePublished"] = ExpressionConverter.ConvertO(recorddatePublished);
                recordpropCount++;
            }

            if (recorddateReceived != null)
            {
                record["RecordDateReceived"] = ExpressionConverter.ConvertO(recorddateReceived);
                recordpropCount++;
            }

            if (recordexternalReference != null)
            {
                record["RecordExternalReference"] = ExpressionConverter.ConvertO(recordexternalReference);
                recordpropCount++;
            }

            if (recordfailOnWarnings != null)
            {
                record["FailOnWarnings"] = ExpressionConverter.ConvertO(recordfailOnWarnings);
                recordpropCount++;
            }

            if (recordfileNameInUploadsFolder != null)
            {
                record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileNameInUploadsFolder);
                recordpropCount++;
            }

            if (recordfinalizeOnSave != null)
            {
                record["RecordFinalizeOnSave"] = ExpressionConverter.ConvertO(recordfinalizeOnSave);
                recordpropCount++;
            }

            if (recordforeignBarcode != null)
            {
                record["RecordForeignBarcode"] = ExpressionConverter.ConvertO(recordforeignBarcode);
                recordpropCount++;
            }

            if (recordgPSLocation != null)
            {
                record["RecordGpsLocation"] = ExpressionConverter.ConvertO(recordgPSLocation);
                recordpropCount++;
            }

            if (recordhomeLocation != null)
            {
                record["RecordHomeLocation"] = ExpressionConverter.ConvertO(recordhomeLocation);
                recordpropCount++;
            }

            if (recordhomeSpace != null)
            {
                record["RecordHomeSpace"] = ExpressionConverter.ConvertO(recordhomeSpace);
                recordpropCount++;
            }

            if (recordisEnclosed != null)
            {
                record["RecordIsEnclosed"] = ExpressionConverter.ConvertO(recordisEnclosed);
                recordpropCount++;
            }

            if (recordjurisdiction != null)
            {
                record["RecordJurisdictions"] = ExpressionConverter.ConvertO(recordjurisdiction);
                recordpropCount++;
            }

            if (recordkeepCheckedOut != null)
            {
                record["keepBookedOut"] = ExpressionConverter.ConvertO(recordkeepCheckedOut);
                recordpropCount++;
            }

            if (recordlongNumber != null)
            {
                record["RecordLongNumber"] = ExpressionConverter.ConvertO(recordlongNumber);
                recordpropCount++;
            }

            if (recordmediaType != null)
            {
                record["RecordMediaType"] = ExpressionConverter.ConvertO(recordmediaType);
                recordpropCount++;
            }

            if (recordnotes != null)
            {
                record["RecordNotes"] = ExpressionConverter.ConvertO(recordnotes);
                recordpropCount++;
            }

            if (recordnotesUpdateType != null)
            {
                record["NotesUpdateType"] = ExpressionConverter.ConvertO(recordnotesUpdateType);
                recordpropCount++;
            }

            if (recordotherContact != null)
            {
                record["RecordOtherContact"] = ExpressionConverter.ConvertO(recordotherContact);
                recordpropCount++;
            }

            if (recordownerLocation != null)
            {
                record["RecordOwnerLocation"] = ExpressionConverter.ConvertO(recordownerLocation);
                recordpropCount++;
            }

            if (recordrelatedRecord != null)
            {
                record["RecordRelatedRecord"] = ExpressionConverter.ConvertO(recordrelatedRecord);
                recordpropCount++;
            }

            if (recordrepresentative != null)
            {
                record["RecordRepresentative"] = ExpressionConverter.ConvertO(recordrepresentative);
                recordpropCount++;
            }

            if (recordreviewDate != null)
            {
                record["RecordReviewDate"] = ExpressionConverter.ConvertO(recordreviewDate);
                recordpropCount++;
            }

            if (recordreviewDueDate != null)
            {
                record["RecordReviewDueDate"] = ExpressionConverter.ConvertO(recordreviewDueDate);
                recordpropCount++;
            }

            if (recordreviewState != null)
            {
                record["RecordReviewState"] = ExpressionConverter.ConvertO(recordreviewState);
                recordpropCount++;
            }

            if (recordsecurity != null)
            {
                record["RecordSecurity"] = ExpressionConverter.ConvertO(recordsecurity);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> DeleteRecord(Expression<Func<int>> uri, Expression<Func<bool>> deleteRecordDetailsdeleteContents, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> deleteRecordDetailsnewHomeForContents = null)
        {
            var apiCallPath = String.Format("/DeleteRecord/{0}", ExpressionConverter.ConvertWithUrlEncoding(uri, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var deleteRecordDetails = new JObject();
            var deleteRecordDetailspropCount = 0;
            deleteRecordDetailspropCount++;
            deleteRecordDetails["DeleteContents"] = ExpressionConverter.ConvertO(deleteRecordDetailsdeleteContents);
            if (deleteRecordDetailsnewHomeForContents != null)
            {
                deleteRecordDetails["NewHomeForContents"] = ExpressionConverter.ConvertO(deleteRecordDetailsnewHomeForContents);
                deleteRecordDetailspropCount++;
            }

            if (deleteRecordDetailspropCount > 0)
            {
                callPayload.Body = deleteRecordDetails;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCreate(Expression<Func<string>> recordrecordType, Expression<Func<string>> recordtitleFreeTextPart, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null, Expression<Func<string>> recordauthor = null, Expression<Func<string>> recordaddressee = null, Expression<Func<string>> recordalternativeContainer = null, Expression<Func<string>> recordassignee = null, Expression<Func<bool>> recordautoRenderToPDFOnSave = null, Expression<Func<bool>> recordbypassRecordTypeAccessControls = null, Expression<Func<string>> recordcheckInAs = null, Expression<Func<string>> recordclassification = null, Expression<Func<string>> recordclient = null, Expression<Func<string>> recordclientRecord = null, Expression<Func<string>> recordcontainer = null, Expression<Func<string>> recordcopyDocumentFromRecord = null, Expression<Func<string>> recordcreator = null, Expression<Func<string>> recorddateCreated = null, Expression<Func<string>> recorddateDue = null, Expression<Func<string>> recorddatePublished = null, Expression<Func<string>> recorddateReceived = null, Expression<Func<string>> recordexternalReference = null, Expression<Func<bool>> recordfailOnWarnings = null, Expression<Func<string>> recordfileNameInUploadsFolder = null, Expression<Func<bool>> recordfinalizeOnSave = null, Expression<Func<string>> recordforeignBarcode = null, Expression<Func<string>> recordgPSLocation = null, Expression<Func<string>> recordhomeLocation = null, Expression<Func<string>> recordhomeSpace = null, Expression<Func<bool>> recordisEnclosed = null, Expression<Func<string>> recordjurisdiction = null, Expression<Func<bool>> recordkeepCheckedOut = null, Expression<Func<string>> recordlastActionDate = null, Expression<Func<string>> recordlongNumber = null, Expression<Func<string>> recordmediaType = null, Expression<Func<string>> recordnotes = null, Expression<Func<recordnotesUpdateTypeInput>> recordnotesUpdateType = null, Expression<Func<string>> recordotherContact = null, Expression<Func<string>> recordownerLocation = null, Expression<Func<string>> recordrelatedRecord = null, Expression<Func<string>> recordrepresentative = null, Expression<Func<string>> recordreviewDate = null, Expression<Func<string>> recordreviewDueDate = null, Expression<Func<recordreviewStateInput>> recordreviewState = null, Expression<Func<string>> recordsecurity = null)
        {
            var apiCallPath = "/CreateRecord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["RecordRecordType"] = ExpressionConverter.ConvertO(recordrecordType);
            recordpropCount++;
            record["RecordTypedTitle"] = ExpressionConverter.ConvertO(recordtitleFreeTextPart);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordauthor != null)
            {
                record["RecordAuthor"] = ExpressionConverter.ConvertO(recordauthor);
                recordpropCount++;
            }

            if (recordaddressee != null)
            {
                record["RecordAddressee"] = ExpressionConverter.ConvertO(recordaddressee);
                recordpropCount++;
            }

            if (recordalternativeContainer != null)
            {
                record["RecordAlternativeContainer"] = ExpressionConverter.ConvertO(recordalternativeContainer);
                recordpropCount++;
            }

            if (recordassignee != null)
            {
                record["RecordAssignee"] = ExpressionConverter.ConvertO(recordassignee);
                recordpropCount++;
            }

            if (recordautoRenderToPDFOnSave != null)
            {
                record["RecordAutoRenderToPDFOnSave"] = ExpressionConverter.ConvertO(recordautoRenderToPDFOnSave);
                recordpropCount++;
            }

            if (recordbypassRecordTypeAccessControls != null)
            {
                record["RecordBypassRecordTypeAccessControls"] = ExpressionConverter.ConvertO(recordbypassRecordTypeAccessControls);
                recordpropCount++;
            }

            if (recordcheckInAs != null)
            {
                record["CheckinAs"] = ExpressionConverter.ConvertO(recordcheckInAs);
                recordpropCount++;
            }

            if (recordclassification != null)
            {
                record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
                recordpropCount++;
            }

            if (recordclient != null)
            {
                record["RecordClient"] = ExpressionConverter.ConvertO(recordclient);
                recordpropCount++;
            }

            if (recordclientRecord != null)
            {
                record["RecordClientRecord"] = ExpressionConverter.ConvertO(recordclientRecord);
                recordpropCount++;
            }

            if (recordcontainer != null)
            {
                record["RecordContainer"] = ExpressionConverter.ConvertO(recordcontainer);
                recordpropCount++;
            }

            if (recordcopyDocumentFromRecord != null)
            {
                record["CopyDocumentFromRecord"] = ExpressionConverter.ConvertO(recordcopyDocumentFromRecord);
                recordpropCount++;
            }

            if (recordcreator != null)
            {
                record["RecordCreator"] = ExpressionConverter.ConvertO(recordcreator);
                recordpropCount++;
            }

            if (recorddateCreated != null)
            {
                record["RecordDateCreated"] = ExpressionConverter.ConvertO(recorddateCreated);
                recordpropCount++;
            }

            if (recorddateDue != null)
            {
                record["RecordDateDue"] = ExpressionConverter.ConvertO(recorddateDue);
                recordpropCount++;
            }

            if (recorddatePublished != null)
            {
                record["RecordDatePublished"] = ExpressionConverter.ConvertO(recorddatePublished);
                recordpropCount++;
            }

            if (recorddateReceived != null)
            {
                record["RecordDateReceived"] = ExpressionConverter.ConvertO(recorddateReceived);
                recordpropCount++;
            }

            if (recordexternalReference != null)
            {
                record["RecordExternalReference"] = ExpressionConverter.ConvertO(recordexternalReference);
                recordpropCount++;
            }

            if (recordfailOnWarnings != null)
            {
                record["FailOnWarnings"] = ExpressionConverter.ConvertO(recordfailOnWarnings);
                recordpropCount++;
            }

            if (recordfileNameInUploadsFolder != null)
            {
                record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileNameInUploadsFolder);
                recordpropCount++;
            }

            if (recordfinalizeOnSave != null)
            {
                record["RecordFinalizeOnSave"] = ExpressionConverter.ConvertO(recordfinalizeOnSave);
                recordpropCount++;
            }

            if (recordforeignBarcode != null)
            {
                record["RecordForeignBarcode"] = ExpressionConverter.ConvertO(recordforeignBarcode);
                recordpropCount++;
            }

            if (recordgPSLocation != null)
            {
                record["RecordGpsLocation"] = ExpressionConverter.ConvertO(recordgPSLocation);
                recordpropCount++;
            }

            if (recordhomeLocation != null)
            {
                record["RecordHomeLocation"] = ExpressionConverter.ConvertO(recordhomeLocation);
                recordpropCount++;
            }

            if (recordhomeSpace != null)
            {
                record["RecordHomeSpace"] = ExpressionConverter.ConvertO(recordhomeSpace);
                recordpropCount++;
            }

            if (recordisEnclosed != null)
            {
                record["RecordIsEnclosed"] = ExpressionConverter.ConvertO(recordisEnclosed);
                recordpropCount++;
            }

            if (recordjurisdiction != null)
            {
                record["RecordJurisdictions"] = ExpressionConverter.ConvertO(recordjurisdiction);
                recordpropCount++;
            }

            if (recordkeepCheckedOut != null)
            {
                record["keepBookedOut"] = ExpressionConverter.ConvertO(recordkeepCheckedOut);
                recordpropCount++;
            }

            if (recordlastActionDate != null)
            {
                record["RecordLastActionDate"] = ExpressionConverter.ConvertO(recordlastActionDate);
                recordpropCount++;
            }

            if (recordlongNumber != null)
            {
                record["RecordLongNumber"] = ExpressionConverter.ConvertO(recordlongNumber);
                recordpropCount++;
            }

            if (recordmediaType != null)
            {
                record["RecordMediaType"] = ExpressionConverter.ConvertO(recordmediaType);
                recordpropCount++;
            }

            if (recordnotes != null)
            {
                record["RecordNotes"] = ExpressionConverter.ConvertO(recordnotes);
                recordpropCount++;
            }

            if (recordnotesUpdateType != null)
            {
                record["NotesUpdateType"] = ExpressionConverter.ConvertO(recordnotesUpdateType);
                recordpropCount++;
            }

            if (recordotherContact != null)
            {
                record["RecordOtherContact"] = ExpressionConverter.ConvertO(recordotherContact);
                recordpropCount++;
            }

            if (recordownerLocation != null)
            {
                record["RecordOwnerLocation"] = ExpressionConverter.ConvertO(recordownerLocation);
                recordpropCount++;
            }

            if (recordrelatedRecord != null)
            {
                record["RecordRelatedRecord"] = ExpressionConverter.ConvertO(recordrelatedRecord);
                recordpropCount++;
            }

            if (recordrepresentative != null)
            {
                record["RecordRepresentative"] = ExpressionConverter.ConvertO(recordrepresentative);
                recordpropCount++;
            }

            if (recordreviewDate != null)
            {
                record["RecordReviewDate"] = ExpressionConverter.ConvertO(recordreviewDate);
                recordpropCount++;
            }

            if (recordreviewDueDate != null)
            {
                record["RecordReviewDueDate"] = ExpressionConverter.ConvertO(recordreviewDueDate);
                recordpropCount++;
            }

            if (recordreviewState != null)
            {
                record["RecordReviewState"] = ExpressionConverter.ConvertO(recordreviewState);
                recordpropCount++;
            }

            if (recordsecurity != null)
            {
                record["RecordSecurity"] = ExpressionConverter.ConvertO(recordsecurity);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCreateContainer(Expression<Func<string>> recordrecordType, Expression<Func<string>> recordtitleFreeTextPart, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordclassification = null, Expression<Func<string>> recordcontainer = null, Expression<Func<string>> recordproperties = null, Expression<Func<string>> recordauthor = null, Expression<Func<string>> recordaddressee = null, Expression<Func<string>> recordalternativeContainer = null, Expression<Func<string>> recordassignee = null, Expression<Func<bool>> recordbypassRecordTypeAccessControls = null, Expression<Func<string>> recordclient = null, Expression<Func<string>> recordcreator = null, Expression<Func<string>> recorddateCreated = null, Expression<Func<string>> recorddateDue = null, Expression<Func<string>> recorddatePublished = null, Expression<Func<string>> recordexternalReference = null, Expression<Func<bool>> recordfailOnWarnings = null, Expression<Func<string>> recordfileNameInUploadsFolder = null, Expression<Func<string>> recordforeignBarcode = null, Expression<Func<string>> recordgPSLocation = null, Expression<Func<string>> recordhomeLocation = null, Expression<Func<string>> recordhomeSpace = null, Expression<Func<bool>> recordisEnclosed = null, Expression<Func<string>> recordjurisdiction = null, Expression<Func<string>> recordlastActionDate = null, Expression<Func<string>> recordlongNumber = null, Expression<Func<string>> recordnotes = null, Expression<Func<recordnotesUpdateTypeInput>> recordnotesUpdateType = null, Expression<Func<string>> recordotherContact = null, Expression<Func<string>> recordownerLocation = null, Expression<Func<string>> recordrelatedRecord = null, Expression<Func<string>> recordrepresentative = null, Expression<Func<string>> recordreviewDate = null, Expression<Func<string>> recordreviewDueDate = null, Expression<Func<recordreviewStateInput>> recordreviewState = null, Expression<Func<string>> recordsecurity = null)
        {
            var apiCallPath = "/CreateRecordContainer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["RecordRecordType"] = ExpressionConverter.ConvertO(recordrecordType);
            recordpropCount++;
            record["RecordTypedTitle"] = ExpressionConverter.ConvertO(recordtitleFreeTextPart);
            if (recordclassification != null)
            {
                record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
                recordpropCount++;
            }

            if (recordcontainer != null)
            {
                record["RecordContainer"] = ExpressionConverter.ConvertO(recordcontainer);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordauthor != null)
            {
                record["RecordAuthor"] = ExpressionConverter.ConvertO(recordauthor);
                recordpropCount++;
            }

            if (recordaddressee != null)
            {
                record["RecordAddressee"] = ExpressionConverter.ConvertO(recordaddressee);
                recordpropCount++;
            }

            if (recordalternativeContainer != null)
            {
                record["RecordAlternativeContainer"] = ExpressionConverter.ConvertO(recordalternativeContainer);
                recordpropCount++;
            }

            if (recordassignee != null)
            {
                record["RecordAssignee"] = ExpressionConverter.ConvertO(recordassignee);
                recordpropCount++;
            }

            if (recordbypassRecordTypeAccessControls != null)
            {
                record["RecordBypassRecordTypeAccessControls"] = ExpressionConverter.ConvertO(recordbypassRecordTypeAccessControls);
                recordpropCount++;
            }

            if (recordclient != null)
            {
                record["RecordClient"] = ExpressionConverter.ConvertO(recordclient);
                recordpropCount++;
            }

            if (recordcreator != null)
            {
                record["RecordCreator"] = ExpressionConverter.ConvertO(recordcreator);
                recordpropCount++;
            }

            if (recorddateCreated != null)
            {
                record["RecordDateCreated"] = ExpressionConverter.ConvertO(recorddateCreated);
                recordpropCount++;
            }

            if (recorddateDue != null)
            {
                record["RecordDateDue"] = ExpressionConverter.ConvertO(recorddateDue);
                recordpropCount++;
            }

            if (recorddatePublished != null)
            {
                record["RecordDatePublished"] = ExpressionConverter.ConvertO(recorddatePublished);
                recordpropCount++;
            }

            if (recordexternalReference != null)
            {
                record["RecordExternalReference"] = ExpressionConverter.ConvertO(recordexternalReference);
                recordpropCount++;
            }

            if (recordfailOnWarnings != null)
            {
                record["FailOnWarnings"] = ExpressionConverter.ConvertO(recordfailOnWarnings);
                recordpropCount++;
            }

            if (recordfileNameInUploadsFolder != null)
            {
                record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileNameInUploadsFolder);
                recordpropCount++;
            }

            if (recordforeignBarcode != null)
            {
                record["RecordForeignBarcode"] = ExpressionConverter.ConvertO(recordforeignBarcode);
                recordpropCount++;
            }

            if (recordgPSLocation != null)
            {
                record["RecordGpsLocation"] = ExpressionConverter.ConvertO(recordgPSLocation);
                recordpropCount++;
            }

            if (recordhomeLocation != null)
            {
                record["RecordHomeLocation"] = ExpressionConverter.ConvertO(recordhomeLocation);
                recordpropCount++;
            }

            if (recordhomeSpace != null)
            {
                record["RecordHomeSpace"] = ExpressionConverter.ConvertO(recordhomeSpace);
                recordpropCount++;
            }

            if (recordisEnclosed != null)
            {
                record["RecordIsEnclosed"] = ExpressionConverter.ConvertO(recordisEnclosed);
                recordpropCount++;
            }

            if (recordjurisdiction != null)
            {
                record["RecordJurisdictions"] = ExpressionConverter.ConvertO(recordjurisdiction);
                recordpropCount++;
            }

            if (recordlastActionDate != null)
            {
                record["RecordLastActionDate"] = ExpressionConverter.ConvertO(recordlastActionDate);
                recordpropCount++;
            }

            if (recordlongNumber != null)
            {
                record["RecordLongNumber"] = ExpressionConverter.ConvertO(recordlongNumber);
                recordpropCount++;
            }

            if (recordnotes != null)
            {
                record["RecordNotes"] = ExpressionConverter.ConvertO(recordnotes);
                recordpropCount++;
            }

            if (recordnotesUpdateType != null)
            {
                record["NotesUpdateType"] = ExpressionConverter.ConvertO(recordnotesUpdateType);
                recordpropCount++;
            }

            if (recordotherContact != null)
            {
                record["RecordOtherContact"] = ExpressionConverter.ConvertO(recordotherContact);
                recordpropCount++;
            }

            if (recordownerLocation != null)
            {
                record["RecordOwnerLocation"] = ExpressionConverter.ConvertO(recordownerLocation);
                recordpropCount++;
            }

            if (recordrelatedRecord != null)
            {
                record["RecordRelatedRecord"] = ExpressionConverter.ConvertO(recordrelatedRecord);
                recordpropCount++;
            }

            if (recordrepresentative != null)
            {
                record["RecordRepresentative"] = ExpressionConverter.ConvertO(recordrepresentative);
                recordpropCount++;
            }

            if (recordreviewDate != null)
            {
                record["RecordReviewDate"] = ExpressionConverter.ConvertO(recordreviewDate);
                recordpropCount++;
            }

            if (recordreviewDueDate != null)
            {
                record["RecordReviewDueDate"] = ExpressionConverter.ConvertO(recordreviewDueDate);
                recordpropCount++;
            }

            if (recordreviewState != null)
            {
                record["RecordReviewState"] = ExpressionConverter.ConvertO(recordreviewState);
                recordpropCount++;
            }

            if (recordsecurity != null)
            {
                record["RecordSecurity"] = ExpressionConverter.ConvertO(recordsecurity);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCreateAdvanced(Expression<Func<string>> recordrecordType, Expression<Func<string>> recordtitleFreeTextPart, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordclassification = null, Expression<Func<string>> recordauthor = null, Expression<Func<string>> recordproperties = null, Expression<Func<string>> recordaccessionNumber = null, Expression<Func<string>> recordaddressee = null, Expression<Func<string>> recordalternativeContainer = null, Expression<Func<string>> recordassignee = null, Expression<Func<string>> recordautoClassificationConfidenceLevel = null, Expression<Func<bool>> recordautoRenderToPDFOnSave = null, Expression<Func<bool>> recordbypassRecordTypeAccessControls = null, Expression<Func<bool>> recordbypassSave = null, Expression<Func<string>> recordchangePositionWithinFavourites = null, Expression<Func<string>> recordchangePositionWithinUserLabel = null, Expression<Func<string>> recordcheckInAs = null, Expression<Func<recordclassOfRecordInput>> recordclassOfRecord = null, Expression<Func<string>> recordclient = null, Expression<Func<string>> recordclientRecord = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordconsignment = null, Expression<Func<string>> recordconsignmentObject = null, Expression<Func<string>> recordcontainer = null, Expression<Func<string>> recordcopyDocumentFromRecord = null, Expression<Func<string>> recordcreator = null, Expression<Func<string>> recorddateCreated = null, Expression<Func<string>> recorddateDue = null, Expression<Func<string>> recorddatePublished = null, Expression<Func<string>> recorddateReceived = null, Expression<Func<string>> recordeditor = null, Expression<Func<string>> recordexternalReference = null, Expression<Func<bool>> recordfailOnWarnings = null, Expression<Func<string>> recordfileNameInUploadsFolder = null, Expression<Func<bool>> recordfinalizeOnSave = null, Expression<Func<string>> recordforeignBarcode = null, Expression<Func<string>> recordgPSLocation = null, Expression<Func<string>> recordhomeLocation = null, Expression<Func<string>> recordhomeSpace = null, Expression<Func<string>> recordinitiateTemplate = null, Expression<Func<bool>> recordisEnclosed = null, Expression<Func<string>> recordjurisdiction = null, Expression<Func<bool>> recordkeepCheckedOut = null, Expression<Func<string>> recordlastActionDate = null, Expression<Func<string>> recordlongNumber = null, Expression<Func<string>> recordmakeActive = null, Expression<Func<string>> recordmakeInactive = null, Expression<Func<bool>> recordmakeNewRevision = null, Expression<Func<string>> recordmanualDestructionDate = null, Expression<Func<string>> recordmatterRecord = null, Expression<Func<string>> recordmediaType = null, Expression<Func<string>> recordmyAuthorizationComments = null, Expression<Func<bool>> recordmyAuthorizationComplete = null, Expression<Func<string>> recordmyReviewComments = null, Expression<Func<bool>> recordmyReviewComplete = null, Expression<Func<bool>> recordneedsAuthorization = null, Expression<Func<bool>> recordneedsReview = null, Expression<Func<string>> recordnewPartCreationRule = null, Expression<Func<string>> recordnotes = null, Expression<Func<recordnotesUpdateTypeInput>> recordnotesUpdateType = null, Expression<Func<string>> recordotherContact = null, Expression<Func<string>> recordownerLocation = null, Expression<Func<bool>> recordpreserverHierarchyOnDataEntry = null, Expression<Func<string>> recordpreviousPartRecord = null, Expression<Func<string>> recordpriority = null, Expression<Func<recordrecordNewTypeInput>> recordrecordNewType = null, Expression<Func<string>> recordrelatedRecord = null, Expression<Func<string>> recordrepresentative = null, Expression<Func<string>> recordretentionSchedule = null, Expression<Func<string>> recordreviewDate = null, Expression<Func<string>> recordreviewDueDate = null, Expression<Func<recordreviewStateInput>> recordreviewState = null, Expression<Func<string>> recordsecurity = null, Expression<Func<string>> recordseriesRecord = null, Expression<Func<string>> recordpropertySets = null, Expression<Func<string>> recordqueryString = null)
        {
            var apiCallPath = "/CreateRecordAdvanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["RecordRecordType"] = ExpressionConverter.ConvertO(recordrecordType);
            recordpropCount++;
            record["RecordTypedTitle"] = ExpressionConverter.ConvertO(recordtitleFreeTextPart);
            if (recordclassification != null)
            {
                record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
                recordpropCount++;
            }

            if (recordauthor != null)
            {
                record["RecordAuthor"] = ExpressionConverter.ConvertO(recordauthor);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordaccessionNumber != null)
            {
                record["RecordAccessionNumber"] = ExpressionConverter.ConvertO(recordaccessionNumber);
                recordpropCount++;
            }

            if (recordaddressee != null)
            {
                record["RecordAddressee"] = ExpressionConverter.ConvertO(recordaddressee);
                recordpropCount++;
            }

            if (recordalternativeContainer != null)
            {
                record["RecordAlternativeContainer"] = ExpressionConverter.ConvertO(recordalternativeContainer);
                recordpropCount++;
            }

            if (recordassignee != null)
            {
                record["RecordAssignee"] = ExpressionConverter.ConvertO(recordassignee);
                recordpropCount++;
            }

            if (recordautoClassificationConfidenceLevel != null)
            {
                record["RecordAutoClassificationConfidenceLevel"] = ExpressionConverter.ConvertO(recordautoClassificationConfidenceLevel);
                recordpropCount++;
            }

            if (recordautoRenderToPDFOnSave != null)
            {
                record["RecordAutoRenderToPDFOnSave"] = ExpressionConverter.ConvertO(recordautoRenderToPDFOnSave);
                recordpropCount++;
            }

            if (recordbypassRecordTypeAccessControls != null)
            {
                record["RecordBypassRecordTypeAccessControls"] = ExpressionConverter.ConvertO(recordbypassRecordTypeAccessControls);
                recordpropCount++;
            }

            if (recordbypassSave != null)
            {
                record["ByPassSave"] = ExpressionConverter.ConvertO(recordbypassSave);
                recordpropCount++;
            }

            if (recordchangePositionWithinFavourites != null)
            {
                record["ChangePositionWithinFavorites"] = ExpressionConverter.ConvertO(recordchangePositionWithinFavourites);
                recordpropCount++;
            }

            if (recordchangePositionWithinUserLabel != null)
            {
                record["ChangePositionWithinUserLabel"] = ExpressionConverter.ConvertO(recordchangePositionWithinUserLabel);
                recordpropCount++;
            }

            if (recordcheckInAs != null)
            {
                record["CheckinAs"] = ExpressionConverter.ConvertO(recordcheckInAs);
                recordpropCount++;
            }

            if (recordclassOfRecord != null)
            {
                record["RecordClassOfRecord"] = ExpressionConverter.ConvertO(recordclassOfRecord);
                recordpropCount++;
            }

            if (recordclient != null)
            {
                record["RecordClient"] = ExpressionConverter.ConvertO(recordclient);
                recordpropCount++;
            }

            if (recordclientRecord != null)
            {
                record["RecordClientRecord"] = ExpressionConverter.ConvertO(recordclientRecord);
                recordpropCount++;
            }

            if (recordcomments != null)
            {
                record["comments"] = ExpressionConverter.ConvertO(recordcomments);
                recordpropCount++;
            }

            if (recordconsignment != null)
            {
                record["RecordConsignment"] = ExpressionConverter.ConvertO(recordconsignment);
                recordpropCount++;
            }

            if (recordconsignmentObject != null)
            {
                record["RecordConsignmentObject"] = ExpressionConverter.ConvertO(recordconsignmentObject);
                recordpropCount++;
            }

            if (recordcontainer != null)
            {
                record["RecordContainer"] = ExpressionConverter.ConvertO(recordcontainer);
                recordpropCount++;
            }

            if (recordcopyDocumentFromRecord != null)
            {
                record["CopyDocumentFromRecord"] = ExpressionConverter.ConvertO(recordcopyDocumentFromRecord);
                recordpropCount++;
            }

            if (recordcreator != null)
            {
                record["RecordCreator"] = ExpressionConverter.ConvertO(recordcreator);
                recordpropCount++;
            }

            if (recorddateCreated != null)
            {
                record["RecordDateCreated"] = ExpressionConverter.ConvertO(recorddateCreated);
                recordpropCount++;
            }

            if (recorddateDue != null)
            {
                record["RecordDateDue"] = ExpressionConverter.ConvertO(recorddateDue);
                recordpropCount++;
            }

            if (recorddatePublished != null)
            {
                record["RecordDatePublished"] = ExpressionConverter.ConvertO(recorddatePublished);
                recordpropCount++;
            }

            if (recorddateReceived != null)
            {
                record["RecordDateReceived"] = ExpressionConverter.ConvertO(recorddateReceived);
                recordpropCount++;
            }

            if (recordeditor != null)
            {
                record["RecordEditor"] = ExpressionConverter.ConvertO(recordeditor);
                recordpropCount++;
            }

            if (recordexternalReference != null)
            {
                record["RecordExternalReference"] = ExpressionConverter.ConvertO(recordexternalReference);
                recordpropCount++;
            }

            if (recordfailOnWarnings != null)
            {
                record["FailOnWarnings"] = ExpressionConverter.ConvertO(recordfailOnWarnings);
                recordpropCount++;
            }

            if (recordfileNameInUploadsFolder != null)
            {
                record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileNameInUploadsFolder);
                recordpropCount++;
            }

            if (recordfinalizeOnSave != null)
            {
                record["RecordFinalizeOnSave"] = ExpressionConverter.ConvertO(recordfinalizeOnSave);
                recordpropCount++;
            }

            if (recordforeignBarcode != null)
            {
                record["RecordForeignBarcode"] = ExpressionConverter.ConvertO(recordforeignBarcode);
                recordpropCount++;
            }

            if (recordgPSLocation != null)
            {
                record["RecordGpsLocation"] = ExpressionConverter.ConvertO(recordgPSLocation);
                recordpropCount++;
            }

            if (recordhomeLocation != null)
            {
                record["RecordHomeLocation"] = ExpressionConverter.ConvertO(recordhomeLocation);
                recordpropCount++;
            }

            if (recordhomeSpace != null)
            {
                record["RecordHomeSpace"] = ExpressionConverter.ConvertO(recordhomeSpace);
                recordpropCount++;
            }

            if (recordinitiateTemplate != null)
            {
                record["RecordInitiateTemplate"] = ExpressionConverter.ConvertO(recordinitiateTemplate);
                recordpropCount++;
            }

            if (recordisEnclosed != null)
            {
                record["RecordIsEnclosed"] = ExpressionConverter.ConvertO(recordisEnclosed);
                recordpropCount++;
            }

            if (recordjurisdiction != null)
            {
                record["RecordJurisdictions"] = ExpressionConverter.ConvertO(recordjurisdiction);
                recordpropCount++;
            }

            if (recordkeepCheckedOut != null)
            {
                record["keepBookedOut"] = ExpressionConverter.ConvertO(recordkeepCheckedOut);
                recordpropCount++;
            }

            if (recordlastActionDate != null)
            {
                record["RecordLastActionDate"] = ExpressionConverter.ConvertO(recordlastActionDate);
                recordpropCount++;
            }

            if (recordlongNumber != null)
            {
                record["RecordLongNumber"] = ExpressionConverter.ConvertO(recordlongNumber);
                recordpropCount++;
            }

            if (recordmakeActive != null)
            {
                record["MakeActive"] = ExpressionConverter.ConvertO(recordmakeActive);
                recordpropCount++;
            }

            if (recordmakeInactive != null)
            {
                record["MakeInactive"] = ExpressionConverter.ConvertO(recordmakeInactive);
                recordpropCount++;
            }

            if (recordmakeNewRevision != null)
            {
                record["makeNewRevision"] = ExpressionConverter.ConvertO(recordmakeNewRevision);
                recordpropCount++;
            }

            if (recordmanualDestructionDate != null)
            {
                record["RecordManualDestructionDate"] = ExpressionConverter.ConvertO(recordmanualDestructionDate);
                recordpropCount++;
            }

            if (recordmatterRecord != null)
            {
                record["RecordMatterRecord"] = ExpressionConverter.ConvertO(recordmatterRecord);
                recordpropCount++;
            }

            if (recordmediaType != null)
            {
                record["RecordMediaType"] = ExpressionConverter.ConvertO(recordmediaType);
                recordpropCount++;
            }

            if (recordmyAuthorizationComments != null)
            {
                record["RecordMyAuthorizationComments"] = ExpressionConverter.ConvertO(recordmyAuthorizationComments);
                recordpropCount++;
            }

            if (recordmyAuthorizationComplete != null)
            {
                record["RecordMyAuthorizationComplete"] = ExpressionConverter.ConvertO(recordmyAuthorizationComplete);
                recordpropCount++;
            }

            if (recordmyReviewComments != null)
            {
                record["RecordMyReviewComments"] = ExpressionConverter.ConvertO(recordmyReviewComments);
                recordpropCount++;
            }

            if (recordmyReviewComplete != null)
            {
                record["RecordMyReviewComplete"] = ExpressionConverter.ConvertO(recordmyReviewComplete);
                recordpropCount++;
            }

            if (recordneedsAuthorization != null)
            {
                record["RecordNeedsAuthorization"] = ExpressionConverter.ConvertO(recordneedsAuthorization);
                recordpropCount++;
            }

            if (recordneedsReview != null)
            {
                record["RecordNeedsReview"] = ExpressionConverter.ConvertO(recordneedsReview);
                recordpropCount++;
            }

            if (recordnewPartCreationRule != null)
            {
                record["RecordNewPartCreationRule"] = ExpressionConverter.ConvertO(recordnewPartCreationRule);
                recordpropCount++;
            }

            if (recordnotes != null)
            {
                record["RecordNotes"] = ExpressionConverter.ConvertO(recordnotes);
                recordpropCount++;
            }

            if (recordnotesUpdateType != null)
            {
                record["NotesUpdateType"] = ExpressionConverter.ConvertO(recordnotesUpdateType);
                recordpropCount++;
            }

            if (recordotherContact != null)
            {
                record["RecordOtherContact"] = ExpressionConverter.ConvertO(recordotherContact);
                recordpropCount++;
            }

            if (recordownerLocation != null)
            {
                record["RecordOwnerLocation"] = ExpressionConverter.ConvertO(recordownerLocation);
                recordpropCount++;
            }

            if (recordpreserverHierarchyOnDataEntry != null)
            {
                record["RecordPreserveHierarchyOnDataEntry"] = ExpressionConverter.ConvertO(recordpreserverHierarchyOnDataEntry);
                recordpropCount++;
            }

            if (recordpreviousPartRecord != null)
            {
                record["RecordPrevPartRecord"] = ExpressionConverter.ConvertO(recordpreviousPartRecord);
                recordpropCount++;
            }

            if (recordpriority != null)
            {
                record["RecordPriority"] = ExpressionConverter.ConvertO(recordpriority);
                recordpropCount++;
            }

            if (recordrecordNewType != null)
            {
                record["RecordNewType"] = ExpressionConverter.ConvertO(recordrecordNewType);
                recordpropCount++;
            }

            if (recordrelatedRecord != null)
            {
                record["RecordRelatedRecord"] = ExpressionConverter.ConvertO(recordrelatedRecord);
                recordpropCount++;
            }

            if (recordrepresentative != null)
            {
                record["RecordRepresentative"] = ExpressionConverter.ConvertO(recordrepresentative);
                recordpropCount++;
            }

            if (recordretentionSchedule != null)
            {
                record["RecordRetentionSchedule"] = ExpressionConverter.ConvertO(recordretentionSchedule);
                recordpropCount++;
            }

            if (recordreviewDate != null)
            {
                record["RecordReviewDate"] = ExpressionConverter.ConvertO(recordreviewDate);
                recordpropCount++;
            }

            if (recordreviewDueDate != null)
            {
                record["RecordReviewDueDate"] = ExpressionConverter.ConvertO(recordreviewDueDate);
                recordpropCount++;
            }

            if (recordreviewState != null)
            {
                record["RecordReviewState"] = ExpressionConverter.ConvertO(recordreviewState);
                recordpropCount++;
            }

            if (recordsecurity != null)
            {
                record["RecordSecurity"] = ExpressionConverter.ConvertO(recordsecurity);
                recordpropCount++;
            }

            if (recordseriesRecord != null)
            {
                record["RecordSeriesRecord"] = ExpressionConverter.ConvertO(recordseriesRecord);
                recordpropCount++;
            }

            if (recordpropertySets != null)
            {
                record["propertySets"] = ExpressionConverter.ConvertO(recordpropertySets);
                recordpropCount++;
            }

            if (recordqueryString != null)
            {
                record["q"] = ExpressionConverter.ConvertO(recordqueryString);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdateAdvanced(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordrecordType = null, Expression<Func<string>> recordclassification = null, Expression<Func<string>> recordproperties = null, Expression<Func<string>> recordauthor = null, Expression<Func<string>> recordaccessionNumber = null, Expression<Func<string>> recordaddressee = null, Expression<Func<string>> recordalternativeContainer = null, Expression<Func<string>> recordassignee = null, Expression<Func<string>> recordautoClassificationConfidenceLevel = null, Expression<Func<bool>> recordautoRenderToPDFOnSave = null, Expression<Func<bool>> recordbypassRecordTypeAccessControls = null, Expression<Func<bool>> recordbypassSave = null, Expression<Func<string>> recordchangePositionWithinFavourites = null, Expression<Func<string>> recordchangePositionWithinUserLabel = null, Expression<Func<string>> recordcheckInAs = null, Expression<Func<recordclassOfRecordInput>> recordclassOfRecord = null, Expression<Func<string>> recordclient = null, Expression<Func<string>> recordclientRecord = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordconsignment = null, Expression<Func<string>> recordconsignmentObject = null, Expression<Func<string>> recordcontainer = null, Expression<Func<string>> recordcopyDocumentFromRecord = null, Expression<Func<string>> recordcreator = null, Expression<Func<string>> recorddateCreated = null, Expression<Func<string>> recorddateDue = null, Expression<Func<string>> recorddatePublished = null, Expression<Func<string>> recorddateReceived = null, Expression<Func<string>> recordeditor = null, Expression<Func<string>> recordelectronicDocumentStore = null, Expression<Func<string>> recordexternalReference = null, Expression<Func<bool>> recordfailOnWarnings = null, Expression<Func<string>> recordfileNameInUploadsFolder = null, Expression<Func<bool>> recordfinalizeOnSave = null, Expression<Func<string>> recordforeignBarcode = null, Expression<Func<string>> recordgPSLocation = null, Expression<Func<string>> recordhomeLocation = null, Expression<Func<string>> recordhomeSpace = null, Expression<Func<bool>> recordisEnclosed = null, Expression<Func<string>> recordjurisdiction = null, Expression<Func<bool>> recordkeepCheckedOut = null, Expression<Func<string>> recordlastActionDate = null, Expression<Func<string>> recordlongNumber = null, Expression<Func<string>> recordmakeActive = null, Expression<Func<string>> recordmakeInactive = null, Expression<Func<bool>> recordmakeNewRevision = null, Expression<Func<string>> recordmanualDestructionDate = null, Expression<Func<string>> recordmatterRecord = null, Expression<Func<string>> recordmediaType = null, Expression<Func<string>> recordmyAuthorizationComments = null, Expression<Func<bool>> recordmyAuthorizationComplete = null, Expression<Func<string>> recordmyReviewComments = null, Expression<Func<bool>> recordmyReviewComplete = null, Expression<Func<bool>> recordneedsAuthorization = null, Expression<Func<bool>> recordneedsReview = null, Expression<Func<string>> recordnewPartCreationRule = null, Expression<Func<string>> recordnotes = null, Expression<Func<recordnotesUpdateTypeInput>> recordnotesUpdateType = null, Expression<Func<string>> recordotherContact = null, Expression<Func<string>> recordownerLocation = null, Expression<Func<bool>> recordpreserverHierarchyOnDataEntry = null, Expression<Func<string>> recordpreviousPartRecord = null, Expression<Func<string>> recordpriority = null, Expression<Func<recordrecordNewTypeInput>> recordrecordNewType = null, Expression<Func<string>> recordrelatedRecord = null, Expression<Func<string>> recordrepresentative = null, Expression<Func<string>> recordretentionSchedule = null, Expression<Func<string>> recordreviewDate = null, Expression<Func<string>> recordreviewDueDate = null, Expression<Func<recordreviewStateInput>> recordreviewState = null, Expression<Func<string>> recordsecurity = null, Expression<Func<string>> recordseriesRecord = null, Expression<Func<string>> recordtitleFreeTextPart = null, Expression<Func<string>> recordqueryString = null)
        {
            var apiCallPath = "/UpdateRecordAdvanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordrecordType != null)
            {
                record["RecordRecordType"] = ExpressionConverter.ConvertO(recordrecordType);
                recordpropCount++;
            }

            if (recordclassification != null)
            {
                record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordauthor != null)
            {
                record["RecordAuthor"] = ExpressionConverter.ConvertO(recordauthor);
                recordpropCount++;
            }

            if (recordaccessionNumber != null)
            {
                record["RecordAccessionNumber"] = ExpressionConverter.ConvertO(recordaccessionNumber);
                recordpropCount++;
            }

            if (recordaddressee != null)
            {
                record["RecordAddressee"] = ExpressionConverter.ConvertO(recordaddressee);
                recordpropCount++;
            }

            if (recordalternativeContainer != null)
            {
                record["RecordAlternativeContainer"] = ExpressionConverter.ConvertO(recordalternativeContainer);
                recordpropCount++;
            }

            if (recordassignee != null)
            {
                record["RecordAssignee"] = ExpressionConverter.ConvertO(recordassignee);
                recordpropCount++;
            }

            if (recordautoClassificationConfidenceLevel != null)
            {
                record["RecordAutoClassificationConfidenceLevel"] = ExpressionConverter.ConvertO(recordautoClassificationConfidenceLevel);
                recordpropCount++;
            }

            if (recordautoRenderToPDFOnSave != null)
            {
                record["RecordAutoRenderToPDFOnSave"] = ExpressionConverter.ConvertO(recordautoRenderToPDFOnSave);
                recordpropCount++;
            }

            if (recordbypassRecordTypeAccessControls != null)
            {
                record["RecordBypassRecordTypeAccessControls"] = ExpressionConverter.ConvertO(recordbypassRecordTypeAccessControls);
                recordpropCount++;
            }

            if (recordbypassSave != null)
            {
                record["ByPassSave"] = ExpressionConverter.ConvertO(recordbypassSave);
                recordpropCount++;
            }

            if (recordchangePositionWithinFavourites != null)
            {
                record["ChangePositionWithinFavorites"] = ExpressionConverter.ConvertO(recordchangePositionWithinFavourites);
                recordpropCount++;
            }

            if (recordchangePositionWithinUserLabel != null)
            {
                record["ChangePositionWithinUserLabel"] = ExpressionConverter.ConvertO(recordchangePositionWithinUserLabel);
                recordpropCount++;
            }

            if (recordcheckInAs != null)
            {
                record["CheckinAs"] = ExpressionConverter.ConvertO(recordcheckInAs);
                recordpropCount++;
            }

            if (recordclassOfRecord != null)
            {
                record["RecordClassOfRecord"] = ExpressionConverter.ConvertO(recordclassOfRecord);
                recordpropCount++;
            }

            if (recordclient != null)
            {
                record["RecordClient"] = ExpressionConverter.ConvertO(recordclient);
                recordpropCount++;
            }

            if (recordclientRecord != null)
            {
                record["RecordClientRecord"] = ExpressionConverter.ConvertO(recordclientRecord);
                recordpropCount++;
            }

            if (recordcomments != null)
            {
                record["comments"] = ExpressionConverter.ConvertO(recordcomments);
                recordpropCount++;
            }

            if (recordconsignment != null)
            {
                record["RecordConsignment"] = ExpressionConverter.ConvertO(recordconsignment);
                recordpropCount++;
            }

            if (recordconsignmentObject != null)
            {
                record["RecordConsignmentObject"] = ExpressionConverter.ConvertO(recordconsignmentObject);
                recordpropCount++;
            }

            if (recordcontainer != null)
            {
                record["RecordContainer"] = ExpressionConverter.ConvertO(recordcontainer);
                recordpropCount++;
            }

            if (recordcopyDocumentFromRecord != null)
            {
                record["CopyDocumentFromRecord"] = ExpressionConverter.ConvertO(recordcopyDocumentFromRecord);
                recordpropCount++;
            }

            if (recordcreator != null)
            {
                record["RecordCreator"] = ExpressionConverter.ConvertO(recordcreator);
                recordpropCount++;
            }

            if (recorddateCreated != null)
            {
                record["RecordDateCreated"] = ExpressionConverter.ConvertO(recorddateCreated);
                recordpropCount++;
            }

            if (recorddateDue != null)
            {
                record["RecordDateDue"] = ExpressionConverter.ConvertO(recorddateDue);
                recordpropCount++;
            }

            if (recorddatePublished != null)
            {
                record["RecordDatePublished"] = ExpressionConverter.ConvertO(recorddatePublished);
                recordpropCount++;
            }

            if (recorddateReceived != null)
            {
                record["RecordDateReceived"] = ExpressionConverter.ConvertO(recorddateReceived);
                recordpropCount++;
            }

            if (recordeditor != null)
            {
                record["RecordEditor"] = ExpressionConverter.ConvertO(recordeditor);
                recordpropCount++;
            }

            if (recordelectronicDocumentStore != null)
            {
                record["RecordEStore"] = ExpressionConverter.ConvertO(recordelectronicDocumentStore);
                recordpropCount++;
            }

            if (recordexternalReference != null)
            {
                record["RecordExternalReference"] = ExpressionConverter.ConvertO(recordexternalReference);
                recordpropCount++;
            }

            if (recordfailOnWarnings != null)
            {
                record["FailOnWarnings"] = ExpressionConverter.ConvertO(recordfailOnWarnings);
                recordpropCount++;
            }

            if (recordfileNameInUploadsFolder != null)
            {
                record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileNameInUploadsFolder);
                recordpropCount++;
            }

            if (recordfinalizeOnSave != null)
            {
                record["RecordFinalizeOnSave"] = ExpressionConverter.ConvertO(recordfinalizeOnSave);
                recordpropCount++;
            }

            if (recordforeignBarcode != null)
            {
                record["RecordForeignBarcode"] = ExpressionConverter.ConvertO(recordforeignBarcode);
                recordpropCount++;
            }

            if (recordgPSLocation != null)
            {
                record["RecordGpsLocation"] = ExpressionConverter.ConvertO(recordgPSLocation);
                recordpropCount++;
            }

            if (recordhomeLocation != null)
            {
                record["RecordHomeLocation"] = ExpressionConverter.ConvertO(recordhomeLocation);
                recordpropCount++;
            }

            if (recordhomeSpace != null)
            {
                record["RecordHomeSpace"] = ExpressionConverter.ConvertO(recordhomeSpace);
                recordpropCount++;
            }

            if (recordisEnclosed != null)
            {
                record["RecordIsEnclosed"] = ExpressionConverter.ConvertO(recordisEnclosed);
                recordpropCount++;
            }

            if (recordjurisdiction != null)
            {
                record["RecordJurisdictions"] = ExpressionConverter.ConvertO(recordjurisdiction);
                recordpropCount++;
            }

            if (recordkeepCheckedOut != null)
            {
                record["keepBookedOut"] = ExpressionConverter.ConvertO(recordkeepCheckedOut);
                recordpropCount++;
            }

            if (recordlastActionDate != null)
            {
                record["RecordLastActionDate"] = ExpressionConverter.ConvertO(recordlastActionDate);
                recordpropCount++;
            }

            if (recordlongNumber != null)
            {
                record["RecordLongNumber"] = ExpressionConverter.ConvertO(recordlongNumber);
                recordpropCount++;
            }

            if (recordmakeActive != null)
            {
                record["MakeActive"] = ExpressionConverter.ConvertO(recordmakeActive);
                recordpropCount++;
            }

            if (recordmakeInactive != null)
            {
                record["MakeInactive"] = ExpressionConverter.ConvertO(recordmakeInactive);
                recordpropCount++;
            }

            if (recordmakeNewRevision != null)
            {
                record["makeNewRevision"] = ExpressionConverter.ConvertO(recordmakeNewRevision);
                recordpropCount++;
            }

            if (recordmanualDestructionDate != null)
            {
                record["RecordManualDestructionDate"] = ExpressionConverter.ConvertO(recordmanualDestructionDate);
                recordpropCount++;
            }

            if (recordmatterRecord != null)
            {
                record["RecordMatterRecord"] = ExpressionConverter.ConvertO(recordmatterRecord);
                recordpropCount++;
            }

            if (recordmediaType != null)
            {
                record["RecordMediaType"] = ExpressionConverter.ConvertO(recordmediaType);
                recordpropCount++;
            }

            if (recordmyAuthorizationComments != null)
            {
                record["RecordMyAuthorizationComments"] = ExpressionConverter.ConvertO(recordmyAuthorizationComments);
                recordpropCount++;
            }

            if (recordmyAuthorizationComplete != null)
            {
                record["RecordMyAuthorizationComplete"] = ExpressionConverter.ConvertO(recordmyAuthorizationComplete);
                recordpropCount++;
            }

            if (recordmyReviewComments != null)
            {
                record["RecordMyReviewComments"] = ExpressionConverter.ConvertO(recordmyReviewComments);
                recordpropCount++;
            }

            if (recordmyReviewComplete != null)
            {
                record["RecordMyReviewComplete"] = ExpressionConverter.ConvertO(recordmyReviewComplete);
                recordpropCount++;
            }

            if (recordneedsAuthorization != null)
            {
                record["RecordNeedsAuthorization"] = ExpressionConverter.ConvertO(recordneedsAuthorization);
                recordpropCount++;
            }

            if (recordneedsReview != null)
            {
                record["RecordNeedsReview"] = ExpressionConverter.ConvertO(recordneedsReview);
                recordpropCount++;
            }

            if (recordnewPartCreationRule != null)
            {
                record["RecordNewPartCreationRule"] = ExpressionConverter.ConvertO(recordnewPartCreationRule);
                recordpropCount++;
            }

            if (recordnotes != null)
            {
                record["RecordNotes"] = ExpressionConverter.ConvertO(recordnotes);
                recordpropCount++;
            }

            if (recordnotesUpdateType != null)
            {
                record["NotesUpdateType"] = ExpressionConverter.ConvertO(recordnotesUpdateType);
                recordpropCount++;
            }

            if (recordotherContact != null)
            {
                record["RecordOtherContact"] = ExpressionConverter.ConvertO(recordotherContact);
                recordpropCount++;
            }

            if (recordownerLocation != null)
            {
                record["RecordOwnerLocation"] = ExpressionConverter.ConvertO(recordownerLocation);
                recordpropCount++;
            }

            if (recordpreserverHierarchyOnDataEntry != null)
            {
                record["RecordPreserveHierarchyOnDataEntry"] = ExpressionConverter.ConvertO(recordpreserverHierarchyOnDataEntry);
                recordpropCount++;
            }

            if (recordpreviousPartRecord != null)
            {
                record["RecordPrevPartRecord"] = ExpressionConverter.ConvertO(recordpreviousPartRecord);
                recordpropCount++;
            }

            if (recordpriority != null)
            {
                record["RecordPriority"] = ExpressionConverter.ConvertO(recordpriority);
                recordpropCount++;
            }

            if (recordrecordNewType != null)
            {
                record["RecordNewType"] = ExpressionConverter.ConvertO(recordrecordNewType);
                recordpropCount++;
            }

            if (recordrelatedRecord != null)
            {
                record["RecordRelatedRecord"] = ExpressionConverter.ConvertO(recordrelatedRecord);
                recordpropCount++;
            }

            if (recordrepresentative != null)
            {
                record["RecordRepresentative"] = ExpressionConverter.ConvertO(recordrepresentative);
                recordpropCount++;
            }

            if (recordretentionSchedule != null)
            {
                record["RecordRetentionSchedule"] = ExpressionConverter.ConvertO(recordretentionSchedule);
                recordpropCount++;
            }

            if (recordreviewDate != null)
            {
                record["RecordReviewDate"] = ExpressionConverter.ConvertO(recordreviewDate);
                recordpropCount++;
            }

            if (recordreviewDueDate != null)
            {
                record["RecordReviewDueDate"] = ExpressionConverter.ConvertO(recordreviewDueDate);
                recordpropCount++;
            }

            if (recordreviewState != null)
            {
                record["RecordReviewState"] = ExpressionConverter.ConvertO(recordreviewState);
                recordpropCount++;
            }

            if (recordsecurity != null)
            {
                record["RecordSecurity"] = ExpressionConverter.ConvertO(recordsecurity);
                recordpropCount++;
            }

            if (recordseriesRecord != null)
            {
                record["RecordSeriesRecord"] = ExpressionConverter.ConvertO(recordseriesRecord);
                recordpropCount++;
            }

            if (recordtitleFreeTextPart != null)
            {
                record["RecordTypedTitle"] = ExpressionConverter.ConvertO(recordtitleFreeTextPart);
                recordpropCount++;
            }

            if (recordqueryString != null)
            {
                record["q"] = ExpressionConverter.ConvertO(recordqueryString);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdateFinalise(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordSetAsFinalremoveOldRevisions = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/UpdateRecordFinalise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            var SetAsFinalObject = new JObject();
            var SetAsFinalObjectpropCount = 0;
            if (recordSetAsFinalremoveOldRevisions != null)
            {
                SetAsFinalObject["SetAsFinalRemoveOldRevisions"] = ExpressionConverter.ConvertO(recordSetAsFinalremoveOldRevisions);
                SetAsFinalObjectpropCount++;
            }

            if (SetAsFinalObjectpropCount > 0)
            {
                record["SetAsFinal"] = SetAsFinalObject;
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdateUnfinalise(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/UpdateRecordUnfinalise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordElecAttach(Expression<Func<object>> file, Expression<Func<string>> uri, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/AddAttachment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSearchByID(Expression<Func<string>> id, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> descendantProperties = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var apiCallPath = String.Format("/Record/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (includePropertyDefs != null)
                callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(includePropertyDefs);
            if (descendantProperties != null)
                callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(descendantProperties);
            callPayload.Queries["properties"] = Convert.ToString("RecordNumber");
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (propertySets != null)
                callPayload.Queries["propertySets"] = ExpressionConverter.Convert(propertySets);
            if (propertyValue != null)
                callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(propertyValue);
            if (stringDisplayType != null)
                callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(stringDisplayType);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<string> RecordElecDownload(Expression<Func<string>> uri, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/RecordElecDownload";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["uri"] = ExpressionConverter.Convert(uri);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordReassignAction(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordnewAssignee, Expression<Func<int>> recordactionToReassign, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordReassignAction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["NewAssignee"] = ExpressionConverter.ConvertO(recordnewAssignee);
            recordpropCount++;
            record["RecordActionUri"] = ExpressionConverter.ConvertO(recordactionToReassign);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse> RecordClose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<bool>> recordencloseContents = null, Expression<Func<bool>> recordfinalizeContents = null, Expression<Func<bool>> recordlogErrorsOnly = null, Expression<Func<bool>> recordlogResults = null, Expression<Func<bool>> recordpurgeContentRevisions = null, Expression<Func<string>> recordspecificCloseDate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordClose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcontinueOnError != null)
            {
                record["ContinueOnError"] = ExpressionConverter.ConvertO(recordcontinueOnError);
                recordpropCount++;
            }

            if (recordencloseContents != null)
            {
                record["EncloseContents"] = ExpressionConverter.ConvertO(recordencloseContents);
                recordpropCount++;
            }

            if (recordfinalizeContents != null)
            {
                record["FinalizeContents"] = ExpressionConverter.ConvertO(recordfinalizeContents);
                recordpropCount++;
            }

            if (recordlogErrorsOnly != null)
            {
                record["LogErrorsOnly"] = ExpressionConverter.ConvertO(recordlogErrorsOnly);
                recordpropCount++;
            }

            if (recordlogResults != null)
            {
                record["LogResults"] = ExpressionConverter.ConvertO(recordlogResults);
                recordpropCount++;
            }

            if (recordpurgeContentRevisions != null)
            {
                record["PurgeContentRevisions"] = ExpressionConverter.ConvertO(recordpurgeContentRevisions);
                recordpropCount++;
            }

            if (recordspecificCloseDate != null)
            {
                record["SpecificCloseDate"] = ExpressionConverter.ConvertO(recordspecificCloseDate);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLogResponse> RecordReopen(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<bool>> recordlogResults = null, Expression<Func<bool>> recordunfinalizeContents = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordReopen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcontinueOnError != null)
            {
                record["ContinueOnError"] = ExpressionConverter.ConvertO(recordcontinueOnError);
                recordpropCount++;
            }

            if (recordlogResults != null)
            {
                record["LogResults"] = ExpressionConverter.ConvertO(recordlogResults);
                recordpropCount++;
            }

            if (recordunfinalizeContents != null)
            {
                record["UnfinalizeContents"] = ExpressionConverter.ConvertO(recordunfinalizeContents);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<GetFileFromUrlResponse> GetFileFromUrl(Expression<Func<string>> url, Expression<Func<string>> filename = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/GetFileFromUrl";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            if (filename != null)
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
            if (contentType != null)
                callPayload.Queries["contentType"] = ExpressionConverter.Convert(contentType);
            return new ApiConnectionAction<GetFileFromUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IWorkflowAction RecordElecUpload(Expression<Func<string>> recordfileName, Expression<Func<string>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = "/UploadFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["RecordFilePath"] = ExpressionConverter.ConvertO(recordfileName);
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdateAdditionalFields(Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> additionalFielduniqueIdentifier = null, Expression<Func<CMFieldDictionary[]>> additionalFieldField = null, Expression<Func<string>> additionalFieldproperties = null)
        {
            var apiCallPath = "/UpdateRecordAdditionalFields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var additionalField = new JObject();
            var additionalFieldpropCount = 0;
            if (additionalFielduniqueIdentifier != null)
            {
                additionalField["Uri"] = ExpressionConverter.ConvertO(additionalFielduniqueIdentifier);
                additionalFieldpropCount++;
            }

            if (additionalFieldField != null)
            {
                additionalField["Field"] = ExpressionConverter.ConvertO(additionalFieldField);
                additionalFieldpropCount++;
            }

            if (additionalFieldproperties != null)
            {
                additionalField["Properties"] = ExpressionConverter.ConvertO(additionalFieldproperties);
                additionalFieldpropCount++;
            }

            if (additionalFieldpropCount > 0)
            {
                callPayload.Body = additionalField;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUpdateClassification(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordclassification, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/UpdateRecordClassification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["RecordClassification"] = ExpressionConverter.ConvertO(recordclassification);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachAction(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<int>> recordactionToAttach, Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> recordassigneeUniqueID = null, Expression<Func<recordassigneeOptionInput>> recordassigneeOption = null, Expression<Func<string>> recordscheduleStartDate = null, Expression<Func<int>> recordexistingAction = null, Expression<Func<recordinsertPositionInput>> recordinsertPosition = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordAttachAction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["ActionToAttach"] = ExpressionConverter.ConvertO(recordactionToAttach);
            if (recordassigneeUniqueID != null)
            {
                record["NewAssignee"] = ExpressionConverter.ConvertO(recordassigneeUniqueID);
                recordpropCount++;
            }

            if (recordassigneeOption != null)
            {
                record["AssigneeOption"] = ExpressionConverter.ConvertO(recordassigneeOption);
                recordpropCount++;
            }

            if (recordscheduleStartDate != null)
            {
                record["ScheduleStartDate"] = ExpressionConverter.ConvertO(recordscheduleStartDate);
                recordpropCount++;
            }

            if (recordexistingAction != null)
            {
                record["RecordAction"] = ExpressionConverter.ConvertO(recordexistingAction);
                recordpropCount++;
            }

            if (recordinsertPosition != null)
            {
                record["InsertPos"] = ExpressionConverter.ConvertO(recordinsertPosition);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCompleteActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<recordcompleteInput>> recordcomplete, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcompletePreviousActions = null, Expression<Func<string>> recordcompletionDate = null, Expression<Func<int>> recordrecordActionUniqueID = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordCompleteActions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["Complete"] = ExpressionConverter.ConvertO(recordcomplete);
            if (recordcompletePreviousActions != null)
            {
                record["CompletePrevious"] = ExpressionConverter.ConvertO(recordcompletePreviousActions);
                recordpropCount++;
            }

            if (recordcompletionDate != null)
            {
                record["CompletionDate"] = ExpressionConverter.ConvertO(recordcompletionDate);
                recordpropCount++;
            }

            if (recordrecordActionUniqueID != null)
            {
                record["RecordActionUri"] = ExpressionConverter.ConvertO(recordrecordActionUniqueID);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRemoveAllActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordRemoveAllActions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRescheduleActions(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordfromBaseDate = null, Expression<Func<bool>> recorduseActualDurations = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordRescheduleActions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordfromBaseDate != null)
            {
                record["FromBaseDate"] = ExpressionConverter.ConvertO(recordfromBaseDate);
                recordpropCount++;
            }

            if (recorduseActualDurations != null)
            {
                record["UseActualDurations"] = ExpressionConverter.ConvertO(recorduseActualDurations);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordDispose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<recordmethodOfDisposalInput>> recordmethodOfDisposal = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordDispose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcontinueOnError != null)
            {
                record["ContinueOnError"] = ExpressionConverter.ConvertO(recordcontinueOnError);
                recordpropCount++;
            }

            if (recordmethodOfDisposal != null)
            {
                record["MethodOfDisposal"] = ExpressionConverter.ConvertO(recordmethodOfDisposal);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUndispose(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> recordcontinueOnError = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordUndispose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcontinueOnError != null)
            {
                record["ContinueOnError"] = ExpressionConverter.ConvertO(recordcontinueOnError);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordCheckout(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordsaveCheckoutPathAs = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordCheckout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcomments != null)
            {
                record["Comments"] = ExpressionConverter.ConvertO(recordcomments);
                recordpropCount++;
            }

            if (recordsaveCheckoutPathAs != null)
            {
                record["SaveCheckoutPathAs"] = ExpressionConverter.ConvertO(recordsaveCheckoutPathAs);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordUndoCheckout(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordcomments = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordUndoCheckout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordcomments != null)
            {
                record["Comments"] = ExpressionConverter.ConvertO(recordcomments);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachContact(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordcontactType, Expression<Func<string>> recordcontactLocation, Expression<Func<bool>> recordsetAsPrimaryContact, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordAttachContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["ContactType"] = ExpressionConverter.ConvertO(recordcontactType);
            recordpropCount++;
            record["ContactLocation"] = ExpressionConverter.ConvertO(recordcontactLocation);
            recordpropCount++;
            record["IsPrimary"] = ExpressionConverter.ConvertO(recordsetAsPrimaryContact);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordAttachKeyword(Expression<Func<int>> recordrecord, Expression<Func<string>> recordthesaurusTerm, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordAttachKeyword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recordrecord);
            recordpropCount++;
            record["Keyword"] = ExpressionConverter.ConvertO(recordthesaurusTerm);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSetUserLabel(Expression<Func<int>> recordrecord, Expression<Func<string>> recorduserLabel, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordfavouriteType = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordSetUserLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recordrecord);
            recordpropCount++;
            record["UserLabel"] = ExpressionConverter.ConvertO(recorduserLabel);
            if (recordfavouriteType != null)
            {
                record["FavouriteType"] = ExpressionConverter.ConvertO(recordfavouriteType);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordRequestRendition(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordrenditionType, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordRequestRendition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            recordpropCount++;
            record["RenditionType"] = ExpressionConverter.ConvertO(recordrenditionType);
            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RecordSetAssignee(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> recordnewAssignee = null, Expression<Func<recordassigneeTypeInput>> recordassigneeType = null, Expression<Func<string>> recorddueForReturnByDate = null, Expression<Func<string>> recordactualTimeChangeOccurred = null, Expression<Func<string>> recordproperties = null)
        {
            var apiCallPath = "/RecordSetAssignee";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            if (recordnewAssignee != null)
            {
                record["NewAssignee"] = ExpressionConverter.ConvertO(recordnewAssignee);
                recordpropCount++;
            }

            if (recordassigneeType != null)
            {
                record["AssigneeType"] = ExpressionConverter.ConvertO(recordassigneeType);
                recordpropCount++;
            }

            if (recorddueForReturnByDate != null)
            {
                record["DueForReturnByDate"] = ExpressionConverter.ConvertO(recorddueForReturnByDate);
                recordpropCount++;
            }

            if (recordactualTimeChangeOccurred != null)
            {
                record["ActualTimeChangeOccurred"] = ExpressionConverter.ConvertO(recordactualTimeChangeOccurred);
                recordpropCount++;
            }

            if (recordproperties != null)
            {
                record["Properties"] = ExpressionConverter.ConvertO(recordproperties);
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationSearch(Expression<Func<string>> q, Expression<Func<string>> userToImpersonate = null, Expression<Func<bool>> applyDefaults = null, Expression<Func<bool>> countResults = null, Expression<Func<bool>> excludeCount = null, Expression<Func<string>> filter = null, Expression<Func<string>> fromSearch = null, Expression<Func<string>> descendantProperties = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> options = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<string>> pageSize = null, Expression<Func<string>> purpose = null, Expression<Func<string>> purposeExtra = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> start = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var apiCallPath = "/Location";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (applyDefaults != null)
                callPayload.Queries["ApplyDefaults"] = ExpressionConverter.Convert(applyDefaults);
            if (countResults != null)
                callPayload.Queries["CountResults"] = ExpressionConverter.Convert(countResults);
            if (excludeCount != null)
                callPayload.Queries["ExcludeCount"] = ExpressionConverter.Convert(excludeCount);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (fromSearch != null)
                callPayload.Queries["fromSearch"] = ExpressionConverter.Convert(fromSearch);
            if (descendantProperties != null)
                callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(descendantProperties);
            if (includePropertyDefs != null)
                callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(includePropertyDefs);
            if (options != null)
                callPayload.Queries["Options"] = ExpressionConverter.Convert(options);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (propertySets != null)
                callPayload.Queries["propertySets"] = ExpressionConverter.Convert(propertySets);
            if (propertyValue != null)
                callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(propertyValue);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (purpose != null)
                callPayload.Queries["purpose"] = ExpressionConverter.Convert(purpose);
            if (purposeExtra != null)
                callPayload.Queries["purposeExtra"] = ExpressionConverter.Convert(purposeExtra);
            if (sortBy != null)
                callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (stringDisplayType != null)
                callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(stringDisplayType);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationUpdate(Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> updateLocationuniqueIdentifier = null, Expression<Func<string>> updateLocationqueryString = null, Expression<Func<string>> updateLocationname = null, Expression<Func<string>> updateLocationuniqueName = null, Expression<Func<string>> updateLocationiDNumber = null, Expression<Func<string>> updateLocationbusinessPhone = null, Expression<Func<string>> updateLocationmobilePhone = null, Expression<Func<string>> updateLocationfax = null, Expression<Func<string>> updateLocationhomePhone = null, Expression<Func<int>> updateLocationsameAsAddress = null, Expression<Func<bool>> updateLocationaddRelationshipmakeDefault = null, Expression<Func<int>> updateLocationaddRelationshiprelatedUniqueID = null, Expression<Func<updateLocationaddRelationshiptypeInput>> updateLocationaddRelationshiptype = null, Expression<Func<string>> updateLocationemailAddress = null, Expression<Func<string>> updateLocationSetActiveDateRangefrom = null, Expression<Func<string>> updateLocationSetActiveDateRangeto = null, Expression<Func<string>> updateLocationnotes = null, Expression<Func<updateLocationnotesUpdateTypeInput>> updateLocationnotesUpdateType = null, Expression<Func<int>> updateLocationremoveRelationshiprelatedUniqueID = null)
        {
            var apiCallPath = "/Location";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var updateLocation = new JObject();
            var updateLocationpropCount = 0;
            if (updateLocationuniqueIdentifier != null)
            {
                updateLocation["Uri"] = ExpressionConverter.ConvertO(updateLocationuniqueIdentifier);
                updateLocationpropCount++;
            }

            if (updateLocationqueryString != null)
            {
                updateLocation["q"] = ExpressionConverter.ConvertO(updateLocationqueryString);
                updateLocationpropCount++;
            }

            if (updateLocationname != null)
            {
                updateLocation["LocationSortName"] = ExpressionConverter.ConvertO(updateLocationname);
                updateLocationpropCount++;
            }

            if (updateLocationuniqueName != null)
            {
                updateLocation["LocationNickName"] = ExpressionConverter.ConvertO(updateLocationuniqueName);
                updateLocationpropCount++;
            }

            if (updateLocationiDNumber != null)
            {
                updateLocation["LocationIdNumber"] = ExpressionConverter.ConvertO(updateLocationiDNumber);
                updateLocationpropCount++;
            }

            if (updateLocationbusinessPhone != null)
            {
                updateLocation["LocationPhoneNumber"] = ExpressionConverter.ConvertO(updateLocationbusinessPhone);
                updateLocationpropCount++;
            }

            if (updateLocationmobilePhone != null)
            {
                updateLocation["LocationMobileNumber"] = ExpressionConverter.ConvertO(updateLocationmobilePhone);
                updateLocationpropCount++;
            }

            if (updateLocationfax != null)
            {
                updateLocation["LocationFaxNumber"] = ExpressionConverter.ConvertO(updateLocationfax);
                updateLocationpropCount++;
            }

            if (updateLocationhomePhone != null)
            {
                updateLocation["LocationAfterHoursPhoneNumber"] = ExpressionConverter.ConvertO(updateLocationhomePhone);
                updateLocationpropCount++;
            }

            if (updateLocationsameAsAddress != null)
            {
                updateLocation["LocationUseAddressOf"] = ExpressionConverter.ConvertO(updateLocationsameAsAddress);
                updateLocationpropCount++;
            }

            var AddRelationshipObject = new JObject();
            var AddRelationshipObjectpropCount = 0;
            if (updateLocationaddRelationshipmakeDefault != null)
            {
                AddRelationshipObject["AddRelationshipMakeThisTheDefaultRelationship"] = ExpressionConverter.ConvertO(updateLocationaddRelationshipmakeDefault);
                AddRelationshipObjectpropCount++;
            }

            if (updateLocationaddRelationshiprelatedUniqueID != null)
            {
                AddRelationshipObject["AddRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(updateLocationaddRelationshiprelatedUniqueID);
                AddRelationshipObjectpropCount++;
            }

            if (updateLocationaddRelationshiptype != null)
            {
                AddRelationshipObject["AddRelationshipRelationshipType"] = ExpressionConverter.ConvertO(updateLocationaddRelationshiptype);
                AddRelationshipObjectpropCount++;
            }

            if (AddRelationshipObjectpropCount > 0)
            {
                updateLocation["AddRelationship"] = AddRelationshipObject;
                updateLocationpropCount++;
            }

            if (updateLocationemailAddress != null)
            {
                updateLocation["LocationEmailAddress"] = ExpressionConverter.ConvertO(updateLocationemailAddress);
                updateLocationpropCount++;
            }

            var SetActiveDateRangeObject = new JObject();
            var SetActiveDateRangeObjectpropCount = 0;
            if (updateLocationSetActiveDateRangefrom != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidFromDate"] = ExpressionConverter.ConvertO(updateLocationSetActiveDateRangefrom);
                SetActiveDateRangeObjectpropCount++;
            }

            if (updateLocationSetActiveDateRangeto != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidToDate"] = ExpressionConverter.ConvertO(updateLocationSetActiveDateRangeto);
                SetActiveDateRangeObjectpropCount++;
            }

            if (SetActiveDateRangeObjectpropCount > 0)
            {
                updateLocation["SetActiveDateRange"] = SetActiveDateRangeObject;
                updateLocationpropCount++;
            }

            if (updateLocationnotes != null)
            {
                updateLocation["LocationNotes"] = ExpressionConverter.ConvertO(updateLocationnotes);
                updateLocationpropCount++;
            }

            if (updateLocationnotesUpdateType != null)
            {
                updateLocation["NotesUpdateType"] = ExpressionConverter.ConvertO(updateLocationnotesUpdateType);
                updateLocationpropCount++;
            }

            var RemoveRelationshipObject = new JObject();
            var RemoveRelationshipObjectpropCount = 0;
            if (updateLocationremoveRelationshiprelatedUniqueID != null)
            {
                RemoveRelationshipObject["RemoveRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(updateLocationremoveRelationshiprelatedUniqueID);
                RemoveRelationshipObjectpropCount++;
            }

            if (RemoveRelationshipObjectpropCount > 0)
            {
                updateLocation["RemoveRelationship"] = RemoveRelationshipObject;
                updateLocationpropCount++;
            }

            if (updateLocationpropCount > 0)
            {
                callPayload.Body = updateLocation;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationCreate(Expression<Func<string>> createLocationname, Expression<Func<string>> userToImpersonate = null, Expression<Func<createLocationlocationTypeInput>> createLocationlocationType = null, Expression<Func<string>> createLocationuniqueName = null, Expression<Func<string>> createLocationiDNumber = null, Expression<Func<bool>> createLocationinternal = null, Expression<Func<string>> createLocationbusinessPhone = null, Expression<Func<string>> createLocationmobilePhone = null, Expression<Func<string>> createLocationfax = null, Expression<Func<string>> createLocationhomePhone = null, Expression<Func<int>> createLocationsameAsAddress = null, Expression<Func<CMLocationAddress[]>> createLocationunnamed = null, Expression<Func<bool>> createLocationaddRelationshipmakeDefault = null, Expression<Func<int>> createLocationaddRelationshiprelatedUniqueID = null, Expression<Func<createLocationaddRelationshiptypeInput>> createLocationaddRelationshiptype = null, Expression<Func<string>> createLocationemailAddress = null, Expression<Func<string>> createLocationSetActiveDateRangefrom = null, Expression<Func<string>> createLocationSetActiveDateRangeto = null, Expression<Func<string>> createLocationnotes = null, Expression<Func<createLocationnotesUpdateTypeInput>> createLocationnotesUpdateType = null)
        {
            var apiCallPath = "/CreateLocation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var createLocation = new JObject();
            var createLocationpropCount = 0;
            if (createLocationlocationType != null)
            {
                createLocation["LocationTypeOfLocation"] = ExpressionConverter.ConvertO(createLocationlocationType);
                createLocationpropCount++;
            }

            createLocationpropCount++;
            createLocation["LocationSortName"] = ExpressionConverter.ConvertO(createLocationname);
            if (createLocationuniqueName != null)
            {
                createLocation["LocationNickName"] = ExpressionConverter.ConvertO(createLocationuniqueName);
                createLocationpropCount++;
            }

            if (createLocationiDNumber != null)
            {
                createLocation["LocationIdNumber"] = ExpressionConverter.ConvertO(createLocationiDNumber);
                createLocationpropCount++;
            }

            if (createLocationinternal != null)
            {
                createLocation["LocationIsWithin"] = ExpressionConverter.ConvertO(createLocationinternal);
                createLocationpropCount++;
            }

            if (createLocationbusinessPhone != null)
            {
                createLocation["LocationPhoneNumber"] = ExpressionConverter.ConvertO(createLocationbusinessPhone);
                createLocationpropCount++;
            }

            if (createLocationmobilePhone != null)
            {
                createLocation["LocationMobileNumber"] = ExpressionConverter.ConvertO(createLocationmobilePhone);
                createLocationpropCount++;
            }

            if (createLocationfax != null)
            {
                createLocation["LocationFaxNumber"] = ExpressionConverter.ConvertO(createLocationfax);
                createLocationpropCount++;
            }

            if (createLocationhomePhone != null)
            {
                createLocation["LocationAfterHoursPhoneNumber"] = ExpressionConverter.ConvertO(createLocationhomePhone);
                createLocationpropCount++;
            }

            if (createLocationsameAsAddress != null)
            {
                createLocation["LocationUseAddressOf"] = ExpressionConverter.ConvertO(createLocationsameAsAddress);
                createLocationpropCount++;
            }

            if (createLocationunnamed != null)
            {
                createLocation["ChildAddresses"] = ExpressionConverter.ConvertO(createLocationunnamed);
                createLocationpropCount++;
            }

            var AddRelationshipObject = new JObject();
            var AddRelationshipObjectpropCount = 0;
            if (createLocationaddRelationshipmakeDefault != null)
            {
                AddRelationshipObject["AddRelationshipMakeThisTheDefaultRelationship"] = ExpressionConverter.ConvertO(createLocationaddRelationshipmakeDefault);
                AddRelationshipObjectpropCount++;
            }

            if (createLocationaddRelationshiprelatedUniqueID != null)
            {
                AddRelationshipObject["AddRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(createLocationaddRelationshiprelatedUniqueID);
                AddRelationshipObjectpropCount++;
            }

            if (createLocationaddRelationshiptype != null)
            {
                AddRelationshipObject["AddRelationshipRelationshipType"] = ExpressionConverter.ConvertO(createLocationaddRelationshiptype);
                AddRelationshipObjectpropCount++;
            }

            if (AddRelationshipObjectpropCount > 0)
            {
                createLocation["AddRelationship"] = AddRelationshipObject;
                createLocationpropCount++;
            }

            if (createLocationemailAddress != null)
            {
                createLocation["LocationEmailAddress"] = ExpressionConverter.ConvertO(createLocationemailAddress);
                createLocationpropCount++;
            }

            var SetActiveDateRangeObject = new JObject();
            var SetActiveDateRangeObjectpropCount = 0;
            if (createLocationSetActiveDateRangefrom != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidFromDate"] = ExpressionConverter.ConvertO(createLocationSetActiveDateRangefrom);
                SetActiveDateRangeObjectpropCount++;
            }

            if (createLocationSetActiveDateRangeto != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidToDate"] = ExpressionConverter.ConvertO(createLocationSetActiveDateRangeto);
                SetActiveDateRangeObjectpropCount++;
            }

            if (SetActiveDateRangeObjectpropCount > 0)
            {
                createLocation["SetActiveDateRange"] = SetActiveDateRangeObject;
                createLocationpropCount++;
            }

            if (createLocationnotes != null)
            {
                createLocation["LocationNotes"] = ExpressionConverter.ConvertO(createLocationnotes);
                createLocationpropCount++;
            }

            if (createLocationnotesUpdateType != null)
            {
                createLocation["NotesUpdateType"] = ExpressionConverter.ConvertO(createLocationnotesUpdateType);
                createLocationpropCount++;
            }

            if (createLocationpropCount > 0)
            {
                callPayload.Body = createLocation;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationCreatePerson(Expression<Func<string>> userToImpersonate = null, Expression<Func<createLocationtitleInput>> createLocationtitle = null, Expression<Func<string>> createLocationlastName = null, Expression<Func<string>> createLocationfirstName = null, Expression<Func<bool>> createLocationinternal = null, Expression<Func<string>> createLocationjobTitle = null, Expression<Func<string>> createLocationdateOfBirth = null, Expression<Func<string>> createLocationsalutation = null, Expression<Func<string>> createLocationuniqueName = null, Expression<Func<string>> createLocationiDNumber = null, Expression<Func<string>> createLocationbusinessPhone = null, Expression<Func<string>> createLocationmobilePhone = null, Expression<Func<string>> createLocationfax = null, Expression<Func<string>> createLocationhomePhone = null, Expression<Func<int>> createLocationsameAsAddress = null, Expression<Func<CMLocationAddress[]>> createLocationunnamed = null, Expression<Func<bool>> createLocationaddRelationshipmakeDefault = null, Expression<Func<int>> createLocationaddRelationshiprelatedUniqueID = null, Expression<Func<createLocationaddRelationshiptypeInput>> createLocationaddRelationshiptype = null, Expression<Func<string>> createLocationemailAddress = null, Expression<Func<string>> createLocationgender = null, Expression<Func<bool>> createLocationacceptingLogins = null, Expression<Func<string>> createLocationnetworkLogin = null, Expression<Func<string>> createLocationadditionalNetworkLogin = null, Expression<Func<string>> createLocationloginExpiresOn = null, Expression<Func<int>> createLocationuserProfileOf = null, Expression<Func<string>> createLocationuserType = null, Expression<Func<string>> createLocationsecurityString = null, Expression<Func<string>> createLocationSetActiveDateRangefrom = null, Expression<Func<string>> createLocationSetActiveDateRangeto = null, Expression<Func<string>> createLocationnotes = null, Expression<Func<createLocationnotesUpdateTypeInput>> createLocationnotesUpdateType = null)
        {
            var apiCallPath = "/CreatePersonLocation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var createLocation = new JObject();
            var createLocationpropCount = 0;
            createLocation["LocationTypeOfLocation"] = "Person";
            createLocationpropCount++;
            if (createLocationtitle != null)
            {
                createLocation["LocationHonorific"] = ExpressionConverter.ConvertO(createLocationtitle);
                createLocationpropCount++;
            }

            if (createLocationlastName != null)
            {
                createLocation["LocationSurname"] = ExpressionConverter.ConvertO(createLocationlastName);
                createLocationpropCount++;
            }

            if (createLocationfirstName != null)
            {
                createLocation["LocationGivenNames"] = ExpressionConverter.ConvertO(createLocationfirstName);
                createLocationpropCount++;
            }

            if (createLocationinternal != null)
            {
                createLocation["LocationIsWithin"] = ExpressionConverter.ConvertO(createLocationinternal);
                createLocationpropCount++;
            }

            if (createLocationjobTitle != null)
            {
                createLocation["LocationJobDescription"] = ExpressionConverter.ConvertO(createLocationjobTitle);
                createLocationpropCount++;
            }

            if (createLocationdateOfBirth != null)
            {
                createLocation["LocationDateOfBirth"] = ExpressionConverter.ConvertO(createLocationdateOfBirth);
                createLocationpropCount++;
            }

            if (createLocationsalutation != null)
            {
                createLocation["LocationSalutation"] = ExpressionConverter.ConvertO(createLocationsalutation);
                createLocationpropCount++;
            }

            if (createLocationuniqueName != null)
            {
                createLocation["LocationNickName"] = ExpressionConverter.ConvertO(createLocationuniqueName);
                createLocationpropCount++;
            }

            if (createLocationiDNumber != null)
            {
                createLocation["LocationIdNumber"] = ExpressionConverter.ConvertO(createLocationiDNumber);
                createLocationpropCount++;
            }

            if (createLocationbusinessPhone != null)
            {
                createLocation["LocationPhoneNumber"] = ExpressionConverter.ConvertO(createLocationbusinessPhone);
                createLocationpropCount++;
            }

            if (createLocationmobilePhone != null)
            {
                createLocation["LocationMobileNumber"] = ExpressionConverter.ConvertO(createLocationmobilePhone);
                createLocationpropCount++;
            }

            if (createLocationfax != null)
            {
                createLocation["LocationFaxNumber"] = ExpressionConverter.ConvertO(createLocationfax);
                createLocationpropCount++;
            }

            if (createLocationhomePhone != null)
            {
                createLocation["LocationAfterHoursPhoneNumber"] = ExpressionConverter.ConvertO(createLocationhomePhone);
                createLocationpropCount++;
            }

            if (createLocationsameAsAddress != null)
            {
                createLocation["LocationUseAddressOf"] = ExpressionConverter.ConvertO(createLocationsameAsAddress);
                createLocationpropCount++;
            }

            if (createLocationunnamed != null)
            {
                createLocation["ChildAddresses"] = ExpressionConverter.ConvertO(createLocationunnamed);
                createLocationpropCount++;
            }

            var AddRelationshipObject = new JObject();
            var AddRelationshipObjectpropCount = 0;
            if (createLocationaddRelationshipmakeDefault != null)
            {
                AddRelationshipObject["AddRelationshipMakeThisTheDefaultRelationship"] = ExpressionConverter.ConvertO(createLocationaddRelationshipmakeDefault);
                AddRelationshipObjectpropCount++;
            }

            if (createLocationaddRelationshiprelatedUniqueID != null)
            {
                AddRelationshipObject["AddRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(createLocationaddRelationshiprelatedUniqueID);
                AddRelationshipObjectpropCount++;
            }

            if (createLocationaddRelationshiptype != null)
            {
                AddRelationshipObject["AddRelationshipRelationshipType"] = ExpressionConverter.ConvertO(createLocationaddRelationshiptype);
                AddRelationshipObjectpropCount++;
            }

            if (AddRelationshipObjectpropCount > 0)
            {
                createLocation["AddRelationship"] = AddRelationshipObject;
                createLocationpropCount++;
            }

            if (createLocationemailAddress != null)
            {
                createLocation["LocationEmailAddress"] = ExpressionConverter.ConvertO(createLocationemailAddress);
                createLocationpropCount++;
            }

            if (createLocationgender != null)
            {
                createLocation["LocationGenderValue"] = ExpressionConverter.ConvertO(createLocationgender);
                createLocationpropCount++;
            }

            if (createLocationacceptingLogins != null)
            {
                createLocation["LocationCanLogin"] = ExpressionConverter.ConvertO(createLocationacceptingLogins);
                createLocationpropCount++;
            }

            if (createLocationnetworkLogin != null)
            {
                createLocation["LocationLogsInAs"] = ExpressionConverter.ConvertO(createLocationnetworkLogin);
                createLocationpropCount++;
            }

            if (createLocationadditionalNetworkLogin != null)
            {
                createLocation["LocationAdditionalLogin"] = ExpressionConverter.ConvertO(createLocationadditionalNetworkLogin);
                createLocationpropCount++;
            }

            if (createLocationloginExpiresOn != null)
            {
                createLocation["LocationLoginExpires"] = ExpressionConverter.ConvertO(createLocationloginExpiresOn);
                createLocationpropCount++;
            }

            if (createLocationuserProfileOf != null)
            {
                createLocation["LocationUseProfileOf"] = ExpressionConverter.ConvertO(createLocationuserProfileOf);
                createLocationpropCount++;
            }

            if (createLocationuserType != null)
            {
                createLocation["LocationUserType"] = ExpressionConverter.ConvertO(createLocationuserType);
                createLocationpropCount++;
            }

            if (createLocationsecurityString != null)
            {
                createLocation["LocationSecurityString"] = ExpressionConverter.ConvertO(createLocationsecurityString);
                createLocationpropCount++;
            }

            var SetActiveDateRangeObject = new JObject();
            var SetActiveDateRangeObjectpropCount = 0;
            if (createLocationSetActiveDateRangefrom != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidFromDate"] = ExpressionConverter.ConvertO(createLocationSetActiveDateRangefrom);
                SetActiveDateRangeObjectpropCount++;
            }

            if (createLocationSetActiveDateRangeto != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidToDate"] = ExpressionConverter.ConvertO(createLocationSetActiveDateRangeto);
                SetActiveDateRangeObjectpropCount++;
            }

            if (SetActiveDateRangeObjectpropCount > 0)
            {
                createLocation["SetActiveDateRange"] = SetActiveDateRangeObject;
                createLocationpropCount++;
            }

            if (createLocationnotes != null)
            {
                createLocation["LocationNotes"] = ExpressionConverter.ConvertO(createLocationnotes);
                createLocationpropCount++;
            }

            if (createLocationnotesUpdateType != null)
            {
                createLocation["NotesUpdateType"] = ExpressionConverter.ConvertO(createLocationnotesUpdateType);
                createLocationpropCount++;
            }

            if (createLocationpropCount > 0)
            {
                callPayload.Body = createLocation;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationUpdatePerson(Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> updateLocationuniqueIdentifier = null, Expression<Func<string>> updateLocationqueryString = null, Expression<Func<updateLocationtitleInput>> updateLocationtitle = null, Expression<Func<string>> updateLocationlastName = null, Expression<Func<string>> updateLocationfirstName = null, Expression<Func<bool>> updateLocationinternal = null, Expression<Func<string>> updateLocationjobTitle = null, Expression<Func<string>> updateLocationdateOfBirth = null, Expression<Func<string>> updateLocationsalutation = null, Expression<Func<string>> updateLocationuniqueName = null, Expression<Func<string>> updateLocationiDNumber = null, Expression<Func<string>> updateLocationbusinessPhone = null, Expression<Func<string>> updateLocationmobilePhone = null, Expression<Func<string>> updateLocationfax = null, Expression<Func<string>> updateLocationhomePhone = null, Expression<Func<int>> updateLocationsameAsAddress = null, Expression<Func<bool>> updateLocationaddRelationshipmakeDefault = null, Expression<Func<int>> updateLocationaddRelationshiprelatedUniqueID = null, Expression<Func<updateLocationaddRelationshiptypeInput>> updateLocationaddRelationshiptype = null, Expression<Func<string>> updateLocationemailAddress = null, Expression<Func<string>> updateLocationgender = null, Expression<Func<bool>> updateLocationacceptingLogins = null, Expression<Func<string>> updateLocationnetworkLogin = null, Expression<Func<string>> updateLocationadditionalNetworkLogin = null, Expression<Func<string>> updateLocationloginExpiresOn = null, Expression<Func<int>> updateLocationuserProfileOf = null, Expression<Func<string>> updateLocationuserType = null, Expression<Func<string>> updateLocationsecurityString = null, Expression<Func<string>> updateLocationSetActiveDateRangefrom = null, Expression<Func<string>> updateLocationSetActiveDateRangeto = null, Expression<Func<string>> updateLocationnotes = null, Expression<Func<updateLocationnotesUpdateTypeInput>> updateLocationnotesUpdateType = null, Expression<Func<int>> updateLocationremoveRelationshiprelatedUniqueID = null)
        {
            var apiCallPath = "/UpdatePersonLocation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var updateLocation = new JObject();
            var updateLocationpropCount = 0;
            if (updateLocationuniqueIdentifier != null)
            {
                updateLocation["Uri"] = ExpressionConverter.ConvertO(updateLocationuniqueIdentifier);
                updateLocationpropCount++;
            }

            if (updateLocationqueryString != null)
            {
                updateLocation["q"] = ExpressionConverter.ConvertO(updateLocationqueryString);
                updateLocationpropCount++;
            }

            if (updateLocationtitle != null)
            {
                updateLocation["LocationHonorific"] = ExpressionConverter.ConvertO(updateLocationtitle);
                updateLocationpropCount++;
            }

            if (updateLocationlastName != null)
            {
                updateLocation["LocationSurname"] = ExpressionConverter.ConvertO(updateLocationlastName);
                updateLocationpropCount++;
            }

            if (updateLocationfirstName != null)
            {
                updateLocation["LocationGivenNames"] = ExpressionConverter.ConvertO(updateLocationfirstName);
                updateLocationpropCount++;
            }

            if (updateLocationinternal != null)
            {
                updateLocation["LocationIsWithin"] = ExpressionConverter.ConvertO(updateLocationinternal);
                updateLocationpropCount++;
            }

            if (updateLocationjobTitle != null)
            {
                updateLocation["LocationJobDescription"] = ExpressionConverter.ConvertO(updateLocationjobTitle);
                updateLocationpropCount++;
            }

            if (updateLocationdateOfBirth != null)
            {
                updateLocation["LocationDateOfBirth"] = ExpressionConverter.ConvertO(updateLocationdateOfBirth);
                updateLocationpropCount++;
            }

            if (updateLocationsalutation != null)
            {
                updateLocation["LocationSalutation"] = ExpressionConverter.ConvertO(updateLocationsalutation);
                updateLocationpropCount++;
            }

            if (updateLocationuniqueName != null)
            {
                updateLocation["LocationNickName"] = ExpressionConverter.ConvertO(updateLocationuniqueName);
                updateLocationpropCount++;
            }

            if (updateLocationiDNumber != null)
            {
                updateLocation["LocationIdNumber"] = ExpressionConverter.ConvertO(updateLocationiDNumber);
                updateLocationpropCount++;
            }

            if (updateLocationbusinessPhone != null)
            {
                updateLocation["LocationPhoneNumber"] = ExpressionConverter.ConvertO(updateLocationbusinessPhone);
                updateLocationpropCount++;
            }

            if (updateLocationmobilePhone != null)
            {
                updateLocation["LocationMobileNumber"] = ExpressionConverter.ConvertO(updateLocationmobilePhone);
                updateLocationpropCount++;
            }

            if (updateLocationfax != null)
            {
                updateLocation["LocationFaxNumber"] = ExpressionConverter.ConvertO(updateLocationfax);
                updateLocationpropCount++;
            }

            if (updateLocationhomePhone != null)
            {
                updateLocation["LocationAfterHoursPhoneNumber"] = ExpressionConverter.ConvertO(updateLocationhomePhone);
                updateLocationpropCount++;
            }

            if (updateLocationsameAsAddress != null)
            {
                updateLocation["LocationUseAddressOf"] = ExpressionConverter.ConvertO(updateLocationsameAsAddress);
                updateLocationpropCount++;
            }

            var AddRelationshipObject = new JObject();
            var AddRelationshipObjectpropCount = 0;
            if (updateLocationaddRelationshipmakeDefault != null)
            {
                AddRelationshipObject["AddRelationshipMakeThisTheDefaultRelationship"] = ExpressionConverter.ConvertO(updateLocationaddRelationshipmakeDefault);
                AddRelationshipObjectpropCount++;
            }

            if (updateLocationaddRelationshiprelatedUniqueID != null)
            {
                AddRelationshipObject["AddRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(updateLocationaddRelationshiprelatedUniqueID);
                AddRelationshipObjectpropCount++;
            }

            if (updateLocationaddRelationshiptype != null)
            {
                AddRelationshipObject["AddRelationshipRelationshipType"] = ExpressionConverter.ConvertO(updateLocationaddRelationshiptype);
                AddRelationshipObjectpropCount++;
            }

            if (AddRelationshipObjectpropCount > 0)
            {
                updateLocation["AddRelationship"] = AddRelationshipObject;
                updateLocationpropCount++;
            }

            if (updateLocationemailAddress != null)
            {
                updateLocation["LocationEmailAddress"] = ExpressionConverter.ConvertO(updateLocationemailAddress);
                updateLocationpropCount++;
            }

            if (updateLocationgender != null)
            {
                updateLocation["LocationGenderValue"] = ExpressionConverter.ConvertO(updateLocationgender);
                updateLocationpropCount++;
            }

            if (updateLocationacceptingLogins != null)
            {
                updateLocation["LocationCanLogin"] = ExpressionConverter.ConvertO(updateLocationacceptingLogins);
                updateLocationpropCount++;
            }

            if (updateLocationnetworkLogin != null)
            {
                updateLocation["LocationLogsInAs"] = ExpressionConverter.ConvertO(updateLocationnetworkLogin);
                updateLocationpropCount++;
            }

            if (updateLocationadditionalNetworkLogin != null)
            {
                updateLocation["LocationAdditionalLogin"] = ExpressionConverter.ConvertO(updateLocationadditionalNetworkLogin);
                updateLocationpropCount++;
            }

            if (updateLocationloginExpiresOn != null)
            {
                updateLocation["LocationLoginExpires"] = ExpressionConverter.ConvertO(updateLocationloginExpiresOn);
                updateLocationpropCount++;
            }

            if (updateLocationuserProfileOf != null)
            {
                updateLocation["LocationUseProfileOf"] = ExpressionConverter.ConvertO(updateLocationuserProfileOf);
                updateLocationpropCount++;
            }

            if (updateLocationuserType != null)
            {
                updateLocation["LocationUserType"] = ExpressionConverter.ConvertO(updateLocationuserType);
                updateLocationpropCount++;
            }

            if (updateLocationsecurityString != null)
            {
                updateLocation["LocationSecurityString"] = ExpressionConverter.ConvertO(updateLocationsecurityString);
                updateLocationpropCount++;
            }

            var SetActiveDateRangeObject = new JObject();
            var SetActiveDateRangeObjectpropCount = 0;
            if (updateLocationSetActiveDateRangefrom != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidFromDate"] = ExpressionConverter.ConvertO(updateLocationSetActiveDateRangefrom);
                SetActiveDateRangeObjectpropCount++;
            }

            if (updateLocationSetActiveDateRangeto != null)
            {
                SetActiveDateRangeObject["SetActiveDateRangeValidToDate"] = ExpressionConverter.ConvertO(updateLocationSetActiveDateRangeto);
                SetActiveDateRangeObjectpropCount++;
            }

            if (SetActiveDateRangeObjectpropCount > 0)
            {
                updateLocation["SetActiveDateRange"] = SetActiveDateRangeObject;
                updateLocationpropCount++;
            }

            if (updateLocationnotes != null)
            {
                updateLocation["LocationNotes"] = ExpressionConverter.ConvertO(updateLocationnotes);
                updateLocationpropCount++;
            }

            if (updateLocationnotesUpdateType != null)
            {
                updateLocation["NotesUpdateType"] = ExpressionConverter.ConvertO(updateLocationnotesUpdateType);
                updateLocationpropCount++;
            }

            var RemoveRelationshipObject = new JObject();
            var RemoveRelationshipObjectpropCount = 0;
            if (updateLocationremoveRelationshiprelatedUniqueID != null)
            {
                RemoveRelationshipObject["RemoveRelationshipRelatedLocation"] = ExpressionConverter.ConvertO(updateLocationremoveRelationshiprelatedUniqueID);
                RemoveRelationshipObjectpropCount++;
            }

            if (RemoveRelationshipObjectpropCount > 0)
            {
                updateLocation["RemoveRelationship"] = RemoveRelationshipObject;
                updateLocationpropCount++;
            }

            if (updateLocationpropCount > 0)
            {
                callPayload.Body = updateLocation;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> UpdateLocationAddress(Expression<Func<int>> updateLocationuniqueIdentifier, Expression<Func<string>> userToImpersonate = null, Expression<Func<CMUpdatableLocationAddress[]>> updateLocationunnamed = null)
        {
            var apiCallPath = "/UpdateLocationAddress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var updateLocation = new JObject();
            var updateLocationpropCount = 0;
            updateLocationpropCount++;
            updateLocation["Uri"] = ExpressionConverter.ConvertO(updateLocationuniqueIdentifier);
            if (updateLocationunnamed != null)
            {
                updateLocation["ChildAddresses"] = ExpressionConverter.ConvertO(updateLocationunnamed);
                updateLocationpropCount++;
            }

            if (updateLocationpropCount > 0)
            {
                callPayload.Body = updateLocation;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationSearchByID(Expression<Func<string>> id, Expression<Func<string>> userToImpersonate = null, Expression<Func<string>> descendantProperties = null, Expression<Func<bool>> includePropertyDefs = null, Expression<Func<string>> properties = null, Expression<Func<string>> propertySets = null, Expression<Func<propertyValueInput>> propertyValue = null, Expression<Func<stringDisplayTypeInput>> stringDisplayType = null)
        {
            var apiCallPath = String.Format("/Location/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (descendantProperties != null)
                callPayload.Queries["descendantProperties"] = ExpressionConverter.Convert(descendantProperties);
            if (includePropertyDefs != null)
                callPayload.Queries["IncludePropertyDefs"] = ExpressionConverter.Convert(includePropertyDefs);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (propertySets != null)
                callPayload.Queries["propertySets"] = ExpressionConverter.Convert(propertySets);
            if (propertyValue != null)
                callPayload.Queries["PropertyValue"] = ExpressionConverter.Convert(propertyValue);
            if (stringDisplayType != null)
                callPayload.Queries["stringDisplayType"] = ExpressionConverter.Convert(stringDisplayType);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationAddressUri> FindLocationChildAddressUri(Expression<Func<string>> locationUri, Expression<Func<typeInput>> type = null, Expression<Func<string>> userToImpersonate = null)
        {
            var apiCallPath = String.Format("/FindLocationChildAddressUri/{0}", ExpressionConverter.ConvertWithUrlEncoding(locationUri, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            return new ApiConnectionAction<CMLocationAddressUri>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMLocationsResponse> LocationUpdateAdditionalFields(Expression<Func<string>> userToImpersonate = null, Expression<Func<int>> additionalFielduniqueIdentifier = null, Expression<Func<CMFieldDictionaryLocation[]>> additionalFieldField = null)
        {
            var apiCallPath = "/UpdateLocationAdditionalFields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userToImpersonate != null)
                callPayload.Headers["userToImpersonate"] = ExpressionConverter.Convert(userToImpersonate);
            var additionalField = new JObject();
            var additionalFieldpropCount = 0;
            if (additionalFielduniqueIdentifier != null)
            {
                additionalField["Uri"] = ExpressionConverter.ConvertO(additionalFielduniqueIdentifier);
                additionalFieldpropCount++;
            }

            if (additionalFieldField != null)
            {
                additionalField["Field"] = ExpressionConverter.ConvertO(additionalFieldField);
                additionalFieldpropCount++;
            }

            if (additionalFieldpropCount > 0)
            {
                callPayload.Body = additionalField;
            }

            return new ApiConnectionAction<CMLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMEventData> ReadEventData(Expression<Func<string>> rawEventDatacontent = null)
        {
            var apiCallPath = "/ReadEventData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rawEventData = new JObject();
            var rawEventDatapropCount = 0;
            if (rawEventDatacontent != null)
            {
                rawEventData["Content"] = ExpressionConverter.ConvertO(rawEventDatacontent);
                rawEventDatapropCount++;
            }

            if (rawEventDatapropCount > 0)
            {
                callPayload.Body = rawEventData;
            }

            return new ApiConnectionAction<CMEventData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> AddAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordAccessControlListFunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesAddContentscontributeContents = null)
        {
            var apiCallPath = "/AddAccessControl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            var AccessControlListObject = new JObject();
            var AccessControlListObjectpropCount = 0;
            if (recordAccessControlListFunctionEnum != null)
            {
                AccessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionEnum);
                AccessControlListObjectpropCount++;
            }

            var FunctionProfilesObject = new JObject();
            var FunctionProfilesObjectpropCount = 0;
            var ViewDocumentObject = new JObject();
            var ViewDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewDocumentviewDocument != null)
            {
                ViewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewDocumentviewDocument);
                ViewDocumentObjectpropCount++;
            }

            if (ViewDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewDocument"] = ViewDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var ViewRecordObject = new JObject();
            var ViewRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewRecordviewMetadata != null)
            {
                ViewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewRecordviewMetadata);
                ViewRecordObjectpropCount++;
            }

            if (ViewRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewRecord"] = ViewRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateDocumentObject = new JObject();
            var UpdateDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument != null)
            {
                UpdateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument);
                UpdateDocumentObjectpropCount++;
            }

            if (UpdateDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateDocument"] = UpdateDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateMetadataObject = new JObject();
            var UpdateMetadataObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata != null)
            {
                UpdateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata);
                UpdateMetadataObjectpropCount++;
            }

            if (UpdateMetadataObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateMetadata"] = UpdateMetadataObject;
                FunctionProfilesObjectpropCount++;
            }

            var ModifyAccessObject = new JObject();
            var ModifyAccessObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess != null)
            {
                ModifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess);
                ModifyAccessObjectpropCount++;
            }

            if (ModifyAccessObjectpropCount > 0)
            {
                FunctionProfilesObject["ModifyAccess"] = ModifyAccessObject;
                FunctionProfilesObjectpropCount++;
            }

            var DestroyRecordObject = new JObject();
            var DestroyRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord != null)
            {
                DestroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord);
                DestroyRecordObjectpropCount++;
            }

            if (DestroyRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["DestroyRecord"] = DestroyRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var AddContentsObject = new JObject();
            var AddContentsObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesAddContentscontributeContents != null)
            {
                AddContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesAddContentscontributeContents);
                AddContentsObjectpropCount++;
            }

            if (AddContentsObjectpropCount > 0)
            {
                FunctionProfilesObject["AddContents"] = AddContentsObject;
                FunctionProfilesObjectpropCount++;
            }

            if (FunctionProfilesObjectpropCount > 0)
            {
                AccessControlListObject["FunctionProfiles"] = FunctionProfilesObject;
                AccessControlListObjectpropCount++;
            }

            if (AccessControlListObjectpropCount > 0)
            {
                record["AccessControlList"] = AccessControlListObject;
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> RemoveAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordAccessControlListFunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesAddContentscontributeContents = null)
        {
            var apiCallPath = "/RemoveAccessControl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            var AccessControlListObject = new JObject();
            var AccessControlListObjectpropCount = 0;
            if (recordAccessControlListFunctionEnum != null)
            {
                AccessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionEnum);
                AccessControlListObjectpropCount++;
            }

            var FunctionProfilesObject = new JObject();
            var FunctionProfilesObjectpropCount = 0;
            var ViewDocumentObject = new JObject();
            var ViewDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewDocumentviewDocument != null)
            {
                ViewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewDocumentviewDocument);
                ViewDocumentObjectpropCount++;
            }

            if (ViewDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewDocument"] = ViewDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var ViewRecordObject = new JObject();
            var ViewRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewRecordviewMetadata != null)
            {
                ViewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewRecordviewMetadata);
                ViewRecordObjectpropCount++;
            }

            if (ViewRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewRecord"] = ViewRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateDocumentObject = new JObject();
            var UpdateDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument != null)
            {
                UpdateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument);
                UpdateDocumentObjectpropCount++;
            }

            if (UpdateDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateDocument"] = UpdateDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateMetadataObject = new JObject();
            var UpdateMetadataObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata != null)
            {
                UpdateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata);
                UpdateMetadataObjectpropCount++;
            }

            if (UpdateMetadataObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateMetadata"] = UpdateMetadataObject;
                FunctionProfilesObjectpropCount++;
            }

            var ModifyAccessObject = new JObject();
            var ModifyAccessObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess != null)
            {
                ModifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess);
                ModifyAccessObjectpropCount++;
            }

            if (ModifyAccessObjectpropCount > 0)
            {
                FunctionProfilesObject["ModifyAccess"] = ModifyAccessObject;
                FunctionProfilesObjectpropCount++;
            }

            var DestroyRecordObject = new JObject();
            var DestroyRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord != null)
            {
                DestroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord);
                DestroyRecordObjectpropCount++;
            }

            if (DestroyRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["DestroyRecord"] = DestroyRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var AddContentsObject = new JObject();
            var AddContentsObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesAddContentscontributeContents != null)
            {
                AddContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesAddContentscontributeContents);
                AddContentsObjectpropCount++;
            }

            if (AddContentsObjectpropCount > 0)
            {
                FunctionProfilesObject["AddContents"] = AddContentsObject;
                FunctionProfilesObjectpropCount++;
            }

            if (FunctionProfilesObjectpropCount > 0)
            {
                AccessControlListObject["FunctionProfiles"] = FunctionProfilesObject;
                AccessControlListObjectpropCount++;
            }

            if (AccessControlListObjectpropCount > 0)
            {
                record["AccessControlList"] = AccessControlListObject;
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> SetAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordAccessControlListFunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesAddContentscontributeContents = null)
        {
            var apiCallPath = "/SetAccessControl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            var AccessControlListObject = new JObject();
            var AccessControlListObjectpropCount = 0;
            if (recordAccessControlListFunctionEnum != null)
            {
                AccessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionEnum);
                AccessControlListObjectpropCount++;
            }

            var FunctionProfilesObject = new JObject();
            var FunctionProfilesObjectpropCount = 0;
            var ViewDocumentObject = new JObject();
            var ViewDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewDocumentviewDocument != null)
            {
                ViewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewDocumentviewDocument);
                ViewDocumentObjectpropCount++;
            }

            if (ViewDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewDocument"] = ViewDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var ViewRecordObject = new JObject();
            var ViewRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewRecordviewMetadata != null)
            {
                ViewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewRecordviewMetadata);
                ViewRecordObjectpropCount++;
            }

            if (ViewRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewRecord"] = ViewRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateDocumentObject = new JObject();
            var UpdateDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument != null)
            {
                UpdateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument);
                UpdateDocumentObjectpropCount++;
            }

            if (UpdateDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateDocument"] = UpdateDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateMetadataObject = new JObject();
            var UpdateMetadataObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata != null)
            {
                UpdateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata);
                UpdateMetadataObjectpropCount++;
            }

            if (UpdateMetadataObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateMetadata"] = UpdateMetadataObject;
                FunctionProfilesObjectpropCount++;
            }

            var ModifyAccessObject = new JObject();
            var ModifyAccessObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess != null)
            {
                ModifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess);
                ModifyAccessObjectpropCount++;
            }

            if (ModifyAccessObjectpropCount > 0)
            {
                FunctionProfilesObject["ModifyAccess"] = ModifyAccessObject;
                FunctionProfilesObjectpropCount++;
            }

            var DestroyRecordObject = new JObject();
            var DestroyRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord != null)
            {
                DestroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord);
                DestroyRecordObjectpropCount++;
            }

            if (DestroyRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["DestroyRecord"] = DestroyRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var AddContentsObject = new JObject();
            var AddContentsObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesAddContentscontributeContents != null)
            {
                AddContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesAddContentscontributeContents);
                AddContentsObjectpropCount++;
            }

            if (AddContentsObjectpropCount > 0)
            {
                FunctionProfilesObject["AddContents"] = AddContentsObject;
                FunctionProfilesObjectpropCount++;
            }

            if (FunctionProfilesObjectpropCount > 0)
            {
                AccessControlListObject["FunctionProfiles"] = FunctionProfilesObject;
                AccessControlListObjectpropCount++;
            }

            if (AccessControlListObjectpropCount > 0)
            {
                record["AccessControlList"] = AccessControlListObject;
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "contentmanagerpowerc")]
        public IBodyWorkflowAction<CMRecordsResponse> InheritAccessControl(Expression<Func<int>> recorduniqueIdentifier, Expression<Func<string>> recordAccessControlListFunctionEnum = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewDocumentviewDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesViewRecordviewMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord = null, Expression<Func<AccessLocationsItem[]>> recordAccessControlListFunctionProfilesAddContentscontributeContents = null)
        {
            var apiCallPath = "/InheritAccessControl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            var record = new JObject();
            var recordpropCount = 0;
            recordpropCount++;
            record["Uri"] = ExpressionConverter.ConvertO(recorduniqueIdentifier);
            var AccessControlListObject = new JObject();
            var AccessControlListObjectpropCount = 0;
            if (recordAccessControlListFunctionEnum != null)
            {
                AccessControlListObject["FunctionEnum"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionEnum);
                AccessControlListObjectpropCount++;
            }

            var FunctionProfilesObject = new JObject();
            var FunctionProfilesObjectpropCount = 0;
            var ViewDocumentObject = new JObject();
            var ViewDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewDocumentviewDocument != null)
            {
                ViewDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewDocumentviewDocument);
                ViewDocumentObjectpropCount++;
            }

            if (ViewDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewDocument"] = ViewDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var ViewRecordObject = new JObject();
            var ViewRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesViewRecordviewMetadata != null)
            {
                ViewRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesViewRecordviewMetadata);
                ViewRecordObjectpropCount++;
            }

            if (ViewRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["ViewRecord"] = ViewRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateDocumentObject = new JObject();
            var UpdateDocumentObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument != null)
            {
                UpdateDocumentObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateDocumentupdateDocument);
                UpdateDocumentObjectpropCount++;
            }

            if (UpdateDocumentObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateDocument"] = UpdateDocumentObject;
                FunctionProfilesObjectpropCount++;
            }

            var UpdateMetadataObject = new JObject();
            var UpdateMetadataObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata != null)
            {
                UpdateMetadataObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesUpdateMetadataupdateRecordMetadata);
                UpdateMetadataObjectpropCount++;
            }

            if (UpdateMetadataObjectpropCount > 0)
            {
                FunctionProfilesObject["UpdateMetadata"] = UpdateMetadataObject;
                FunctionProfilesObjectpropCount++;
            }

            var ModifyAccessObject = new JObject();
            var ModifyAccessObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess != null)
            {
                ModifyAccessObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesModifyAccessmodifyRecordAccess);
                ModifyAccessObjectpropCount++;
            }

            if (ModifyAccessObjectpropCount > 0)
            {
                FunctionProfilesObject["ModifyAccess"] = ModifyAccessObject;
                FunctionProfilesObjectpropCount++;
            }

            var DestroyRecordObject = new JObject();
            var DestroyRecordObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord != null)
            {
                DestroyRecordObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesDestroyRecorddestroyRecord);
                DestroyRecordObjectpropCount++;
            }

            if (DestroyRecordObjectpropCount > 0)
            {
                FunctionProfilesObject["DestroyRecord"] = DestroyRecordObject;
                FunctionProfilesObjectpropCount++;
            }

            var AddContentsObject = new JObject();
            var AddContentsObjectpropCount = 0;
            if (recordAccessControlListFunctionProfilesAddContentscontributeContents != null)
            {
                AddContentsObject["AccessLocations"] = ExpressionConverter.ConvertO(recordAccessControlListFunctionProfilesAddContentscontributeContents);
                AddContentsObjectpropCount++;
            }

            if (AddContentsObjectpropCount > 0)
            {
                FunctionProfilesObject["AddContents"] = AddContentsObject;
                FunctionProfilesObjectpropCount++;
            }

            if (FunctionProfilesObjectpropCount > 0)
            {
                AccessControlListObject["FunctionProfiles"] = FunctionProfilesObject;
                AccessControlListObjectpropCount++;
            }

            if (AccessControlListObjectpropCount > 0)
            {
                record["AccessControlList"] = AccessControlListObject;
                recordpropCount++;
            }

            if (recordpropCount > 0)
            {
                callPayload.Body = record;
            }

            return new ApiConnectionAction<CMRecordsResponse>(callPayload);
        }
    }

    public class ContentmanagerpowercTriggers([ConnectionName] string connectionId)
    {
    }

    public class CMBobResponse
    {
        public CMBob[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMBob
    {
        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }

        [JsonProperty("NameString")]
        public string Name { get; set; }
    }

    public class CMUpdateErrorResponse
    {
        public string ErrorCode { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string NameExtra { get; set; }
    }

    public enum CMTrimType
    {
        Record,
        Location,
        Classification,
        ActionDef,
        ActionDefStep,
        Activity,
        ActivityAuthorization,
        ActivityDocument,
        ActivityEmailRecipient,
        ActivityEscalation,
        ActivityResult,
        ActivityStartCondition,
        AgendaItem,
        AgendaItemAttachment,
        AgendaItemType,
        AgendaItemTypeAttachment,
        Alert,
        AlertSubscriber,
        ArchiveEvent,
        ArchiveEventOccurrence,
        AutoPartRule,
        Census,
        CheckinPlace,
        CheckinStyle,
        ClassificationOnlyRecordType,
        [EnumMember(Value = "ClassificationSapBusinessObject")]
        ClassificationSAPBusinessObject,
        Communication,
        CommunicationDetail,
        Consignment,
        ConsignmentApprover,
        ConsignmentIssue,
        ConsignmentRejection,
        Database,
        DocumentQueue,
        ElectronicStore,
        FieldDefinition,
        History,
        Hold,
        HtmlLayout,
        Jurisdiction,
        JurisdictionMember,
        [EnumMember(Value = "Keyword")]
        ThesaurusTerm,
        LocationAddress,
        LocationEAddress,
        LookupItem,
        LookupSet,
        MailTemplate,
        Meeting,
        MeetingDocument,
        MeetingInvitation,
        MeetingType,
        MeetingTypeUsualParticipant,
        MetadataRule,
        MinuteItem,
        MinuteItemActionArising,
        MinuteItemType,
        Notification,
        OfflineRecord,
        Origin,
        OriginHistory,
        RecordAction,
        RecordClientMatterParty,
        RecordClientMatterRole,
        RecordHold,
        RecordJurisdiction,
        [EnumMember(Value = "RecordKeyword")]
        RecordThesaurusTerm,
        RecordLinkedDocument,
        RecordLocation,
        RecordRelationship,
        RecordRendition,
        RecordRevision,
        [EnumMember(Value = "RecordSapComponent")]
        RecordSAPComponent,
        RecordType,
        RecordTypeAutoSubFolder,
        Report,
        ReportBitmap,
        Request,
        SavedSearch,
        Schedule,
        ScheduledTask,
        ScheduledTaskHistory,
        ScheduleTrigger,
        SearchForm,
        SecurityCaveat,
        SecurityGuide,
        SecurityLevel,
        SharePointItem,
        Space,
        StopWord,
        TodoItem,
        TodoItemItemReference,
        Unknown,
        UserLabel,
        Word,
        Workflow,
        WorkflowDocument,
        WorkflowTemplate,
        WorkflowTemplateDocument,
        WorkingCopy,
        ZipCode
    }

    public class CMResponseStatus
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public CMResponseError[] Errors { get; set; }
        public JToken Meta { get; set; }
    }

    public class CMResponseError
    {
        public string ErrorCode { get; set; }
        public string FieldName { get; set; }
        public string Message { get; set; }
        public JToken Meta { get; set; }
    }

    public enum searchTrimTypeInput
    {
        Record,
        Location,
        Classification,
        ActionDef,
        ActionDefStep,
        Activity,
        ActivityAuthorization,
        ActivityDocument,
        ActivityEmailRecipient,
        ActivityEscalation,
        ActivityResult,
        ActivityStartCondition,
        AgendaItem,
        AgendaItemAttachment,
        AgendaItemType,
        AgendaItemTypeAttachment,
        Alert,
        AlertSubscriber,
        ArchiveEvent,
        ArchiveEventOccurrence,
        AutoPartRule,
        Census,
        CheckinPlace,
        CheckinStyle,
        ClassificationOnlyRecordType,
        [EnumMember(Value = "ClassificationSapBusinessObject")]
        ClassificationSAPBusinessObject,
        Communication,
        CommunicationDetail,
        Consignment,
        ConsignmentApprover,
        ConsignmentIssue,
        ConsignmentRejection,
        Database,
        DocumentQueue,
        ElectronicStore,
        FieldDefinition,
        History,
        Hold,
        HtmlLayout,
        Jurisdiction,
        JurisdictionMember,
        [EnumMember(Value = "Keyword")]
        ThesaurusTerm,
        LocationAddress,
        LocationEAddress,
        LookupItem,
        LookupSet,
        MailTemplate,
        Meeting,
        MeetingDocument,
        MeetingInvitation,
        MeetingType,
        MeetingTypeUsualParticipant,
        MetadataRule,
        MinuteItem,
        MinuteItemActionArising,
        MinuteItemType,
        Notification,
        OfflineRecord,
        Origin,
        OriginHistory,
        RecordAction,
        RecordClientMatterParty,
        RecordClientMatterRole,
        RecordHold,
        RecordJurisdiction,
        [EnumMember(Value = "RecordKeyword")]
        RecordThesaurusTerm,
        RecordLinkedDocument,
        RecordLocation,
        RecordRelationship,
        RecordRendition,
        RecordRevision,
        [EnumMember(Value = "RecordSapComponent")]
        RecordSAPComponent,
        RecordType,
        RecordTypeAutoSubFolder,
        Report,
        ReportBitmap,
        Request,
        SavedSearch,
        Schedule,
        ScheduledTask,
        ScheduledTaskHistory,
        ScheduleTrigger,
        SearchForm,
        SecurityCaveat,
        SecurityGuide,
        SecurityLevel,
        SharePointItem,
        Space,
        StopWord,
        TodoItem,
        TodoItemItemReference,
        Unknown,
        UserLabel,
        Word,
        Workflow,
        WorkflowDocument,
        WorkflowTemplate,
        WorkflowTemplateDocument,
        WorkingCopy,
        ZipCode
    }

    public enum searchpropertyValueInput
    {
        Raw,
        String,
        Both
    }

    public enum searchstringDisplayTypeInput
    {
        Default,
        ViewPane,
        TreeColumn,
        Reporter,
        DataEntry,
        ErrorMessage,
        Export,
        Merge,
        WebService,
        WebPublish
    }

    public class CMRecordsResponse
    {
        public CMRecord[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMRecord
    {
        [JsonProperty("RecordFilePath")]
        public string FilePath { get; set; }

        [JsonProperty("RecordAccessionNumber")]
        public int AccessionNumber { get; set; }

        [JsonProperty("RecordAddressee")]
        public int Addressee { get; set; }

        [JsonProperty("RecordAlternativeContainer")]
        public int AlternativeContainer { get; set; }

        [JsonProperty("RecordAssignee")]
        public int Assignee { get; set; }

        [JsonProperty("RecordAuthor")]
        public int Author { get; set; }

        [JsonProperty("RecordAuthorizationMethod")]
        public CMRecordAuthorizationMethodType AuthorizationMethod { get; set; }

        [JsonProperty("RecordAutoClassificationConfidenceLevel")]
        public int AutoClassificationConfidenceLevel { get; set; }

        [JsonProperty("RecordAutoRenderToPDFOnSave")]
        public bool AutoRenderToPDFOnSave { get; set; }

        [JsonProperty("RecordBlueprintTitle")]
        public string BluePrintTitle { get; set; }

        [JsonProperty("RecordBypassRecordTypeAccessControls")]
        public bool BypassRecordTypeAccessControls { get; set; }

        [JsonProperty("RecordCheckedInBy")]
        public int CheckedInBy { get; set; }

        [JsonProperty("RecordCheckedOutTo")]
        public int CheckedOutTo { get; set; }

        [JsonProperty("RecordClassification")]
        public int Classification { get; set; }

        [JsonProperty("RecordClassOfRecord")]
        public CMRecordClassOfRecordType ClassOfRecord { get; set; }

        [JsonProperty("RecordClient")]
        public int Client { get; set; }

        [JsonProperty("RecordClientRecord")]
        public int ClientRecord { get; set; }

        [JsonProperty("RecordConsignment")]
        public string Consignment { get; set; }

        [JsonProperty("RecordConsignmentObject")]
        public string ConsignmentObject { get; set; }

        [JsonProperty("RecordContainer")]
        public int Container { get; set; }

        [JsonProperty("RecordCreator")]
        public int Creator { get; set; }

        [JsonProperty("RecordCurrentVersion")]
        public string CurrentVersion { get; set; }

        [JsonProperty("RecordDateClosed")]
        public string DateClosed { get; set; }

        [JsonProperty("RecordDateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("RecordDateDue")]
        public string DateDue { get; set; }

        [JsonProperty("RecordDateFinalized")]
        public string DateFinalized { get; set; }

        [JsonProperty("RecordDateImported")]
        public string DateImported { get; set; }

        [JsonProperty("RecordDateInactive")]
        public string DateInactive { get; set; }

        [JsonProperty("RecordDateModified")]
        public string DateModified { get; set; }

        [JsonProperty("RecordDatePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("RecordDateReceived")]
        public string DateReceived { get; set; }

        [JsonProperty("RecordDateRegistered")]
        public string DateRegistered { get; set; }

        [JsonProperty("RecordDocumentAttachPending")]
        public bool DocumentAttachPending { get; set; }

        [JsonProperty("RecordDocumentSize")]
        public int DocumentSize { get; set; }

        [JsonProperty("RecordDocumentType")]
        public string DocumentType { get; set; }

        [JsonProperty("RecordEditor")]
        public int Editor { get; set; }

        [JsonProperty("RecordEStore")]
        public int ElectronicDocumentStore { get; set; }

        [JsonProperty("RecordExtension")]
        public string DocumentExtension { get; set; }

        [JsonProperty("RecordExternalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty("RecordFinalizeOnSave")]
        public bool FinalizeOnSave { get; set; }

        [JsonProperty("RecordFolderOrigin")]
        public int FolderOrigin { get; set; }

        [JsonProperty("RecordForeignBarcode")]
        public string ForeignBarcode { get; set; }

        [JsonProperty("RecordGeneratedTitle")]
        public string GeneratedTitle { get; set; }

        [JsonProperty("RecordGpsLocation")]
        public string GPSLocation { get; set; }

        [JsonProperty("RecordHomeLocation")]
        public int HomeLocation { get; set; }

        [JsonProperty("RecordHomeSpace")]
        public int HomeSpace { get; set; }

        [JsonProperty("RecordInitiateTemplate")]
        public string InitiateTemplate { get; set; }

        [JsonProperty("RecordIsEnclosed")]
        public bool IsEnclosed { get; set; }

        [JsonProperty("RecordJurisdictions")]
        public string Jurisdiction { get; set; }

        [JsonProperty("RecordLastActionDate")]
        public string LastActionDate { get; set; }

        [JsonProperty("RecordLastPartRecord")]
        public int LastPartRecord { get; set; }

        [JsonProperty("RecordLatestVersion")]
        public int LatestVersion { get; set; }

        [JsonProperty("RecordLongNumber")]
        public string ExpandedNumber { get; set; }
        public string RecordNumber { get; set; }

        [JsonProperty("RecordManualDestructionDate")]
        public string ManualDestructionDate { get; set; }

        [JsonProperty("RecordMatterRecord")]
        public int MatterRecord { get; set; }

        [JsonProperty("RecordMediaType")]
        public string MediaType { get; set; }

        [JsonProperty("RecordMeeting")]
        public int Meeting { get; set; }

        [JsonProperty("RecordMimeType")]
        public string MimeType { get; set; }

        [JsonProperty("RecordMyAuthorizationComments")]
        public string MyAuthorizationComments { get; set; }

        [JsonProperty("RecordMyAuthorizationComplete")]
        public bool MyAuthorizationComplete { get; set; }

        [JsonProperty("RecordMyReviewComments")]
        public string MyReviewComments { get; set; }

        [JsonProperty("RecordMyReviewComplete")]
        public bool MyReviewComplete { get; set; }

        [JsonProperty("RecordNbrPages")]
        public int NumberPages { get; set; }

        [JsonProperty("RecordNeedsAuthorization")]
        public bool NeedsAuthorization { get; set; }

        [JsonProperty("RecordNeedsReview")]
        public bool NeedsReview { get; set; }

        [JsonProperty("RecordNewPartCreationRule")]
        public string NewPartCreationRule { get; set; }

        [JsonProperty("RecordNextPartRecord")]
        public int NextPartRecord { get; set; }
        public CMRecordNotesUpdateTypeType NotesUpdateType { get; set; }

        [JsonProperty("RecordNotes")]
        public string Notes { get; set; }

        [JsonProperty("RecordOriginatedFrom")]
        public string OriginatedFrom { get; set; }

        [JsonProperty("RecordOriginatedFromRun")]
        public string OriginatedFromRun { get; set; }

        [JsonProperty("RecordOtherContact")]
        public int OtherContact { get; set; }

        [JsonProperty("RecordOwnerLocation")]
        public int OwnerLocation { get; set; }

        [JsonProperty("RecordPreserveHierarchyOnDataEntry")]
        public bool PreserverHierarchyOnDataEntry { get; set; }

        [JsonProperty("RecordPrevPartRecord")]
        public int PreviousPartRecord { get; set; }

        [JsonProperty("RecordPrimaryContact")]
        public int PrimaryContact { get; set; }

        [JsonProperty("RecordPriority")]
        public string Priority { get; set; }

        [JsonProperty("RecordRecordType")]
        public int RecordType { get; set; }

        [JsonProperty("RecordRelatedRecord")]
        public int RelatedRecord { get; set; }

        [JsonProperty("RecordRepresentative")]
        public int Representative { get; set; }

        [JsonProperty("RecordRetentionSchedule")]
        public int RetentionSchedule { get; set; }

        [JsonProperty("RecordReviewDate")]
        public string ReviewDate { get; set; }

        [JsonProperty("RecordReviewDueDate")]
        public string ReviewDueDate { get; set; }

        [JsonProperty("RecordReviewState")]
        public string ReviewState { get; set; }

        [JsonProperty("RecordRootPartRecord")]
        public int RootPartRecord { get; set; }

        [JsonProperty("RecordSecurity")]
        public string Security { get; set; }

        [JsonProperty("RecordSeriesRecord")]
        public int SeriesRecord { get; set; }

        [JsonProperty("RecordTitle")]
        public string Title { get; set; }

        [JsonProperty("RecordTypedTitle")]
        public string TitleFreeTextPart { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }

        [JsonProperty("Fields")]
        public JToken AdditionalFields { get; set; }
    }

    public enum CMRecordAuthorizationMethodType
    {
        Simple,
        Challenge,
        Docusign
    }

    public enum CMRecordClassOfRecordType
    {
        Vital,
        Corporate,
        WorkGroup,
        Personal,
        Reference,
        Temporary
    }

    public enum CMRecordNotesUpdateTypeType
    {
        Overwrite,
        AppendOnly,
        AppendWithNewLine,
        AppendWithUserStamp,
        PrependOnly,
        PrependWithNewLine,
        PrependWithUserStamp
    }

    public enum recordnotesUpdateTypeInput
    {
        Overwrite,
        AppendOnly,
        AppendWithNewLine,
        AppendWithUserStamp,
        PrependOnly,
        PrependWithNewLine,
        PrependWithUserStamp
    }

    public enum recordreviewStateInput
    {
        None,
        Editing,
        Reviewing,
        Authorizing,
        Finalizing,
        Complete
    }

    public enum recordclassOfRecordInput
    {
        Vital,
        Corporate,
        WorkGroup,
        Personal,
        Reference,
        Temporary
    }

    public enum recordrecordNewTypeInput
    {
        Default,
        Copy,
        Part,
        Version
    }

    public enum propertyValueInput
    {
        Raw,
        String,
        Both
    }

    public enum stringDisplayTypeInput
    {
        Default,
        DataEntry,
        ErrorMessage,
        Export,
        Merge,
        Reporter,
        TreeColumn,
        ViewPane,
        WebPublish,
        WebService
    }

    public class CMLogResponse
    {
        public CMLogMessage[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMLogMessage
    {
        public string LogMessage { get; set; }
        public CMTrimType TrimType { get; set; }

        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }
    }

    public class GetFileFromUrlResponse
    {
        public string Filepath { get; set; }
        public string Message { get; set; }
    }

    public class CMFieldDictionary
    {
        [JsonProperty("SearchClause")]
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public enum recordassigneeOptionInput
    {
        OverrideExisting,
        OnlyIfNoneSpecified
    }

    public enum recordinsertPositionInput
    {
        Before,
        After
    }

    public enum recordcompleteInput
    {
        Current,
        All,
        [EnumMember(Value = "ForUri")]
        ForUniqueIdentifier
    }

    public enum recordmethodOfDisposalInput
    {
        None,
        Archived,
        Transferred,
        Destroyed
    }

    public enum recordassigneeTypeInput
    {
        AtLocation,
        AtHome,
        Missing,
        EarliestRequestor
    }

    public class CMLocationsResponse
    {
        public CMLocation[] Results { get; set; }
        public CMUpdateErrorResponse[] UpdateErrorResults { get; set; }
        public int TotalResults { get; set; }
        public string CountStringEx { get; set; }
        public int MinimumCount { get; set; }
        public int Count { get; set; }
        public bool HasMoreItems { get; set; }
        public string SearchTitle { get; set; }
        public string HitHighlightString { get; set; }
        public CMTrimType TrimType { get; set; }
        public CMResponseStatus ResponseStatus { get; set; }
    }

    public class CMLocation
    {
        [JsonProperty("Uri")]
        public int UniqueIdentifier { get; set; }

        [JsonProperty("NameString")]
        public string Name { get; set; }
        public string LocationFullFormattedName { get; set; }
        public string LocationSortName { get; set; }
    }

    public enum updateLocationaddRelationshiptypeInput
    {
        MemberOf,
        BossedBy,
        OtherOf,
        HasMembers,
        BossOf,
        HasOthers,
        DelegateOf,
        HasDelegates,
        AdministratorOf,
        AdministeredBy
    }

    public enum updateLocationnotesUpdateTypeInput
    {
        Overwrite,
        AppendOnly,
        AppendWithNewLine,
        AppendWithUserStamp,
        PrependOnly,
        PrependWithNewLine,
        PrependWithUserStamp
    }

    public enum createLocationlocationTypeInput
    {
        Unknown,
        Organization,
        Group,
        Position,
        ProjectTeam,
        Committee,
        Venue,
        Workgroup,
        StorageProvider
    }

    public class CMLocationAddress
    {
        [JsonProperty("LocationAddressAddressType")]
        public CMLocationAddressAddressTypeType AddressType { get; set; }

        [JsonProperty("LocationAddressAddressLines")]
        public string Street { get; set; }

        [JsonProperty("LocationAddressCity")]
        public string SuburbCity { get; set; }

        [JsonProperty("LocationAddressState")]
        public string State { get; set; }

        [JsonProperty("LocationAddressPostcode")]
        public string Postcode { get; set; }

        [JsonProperty("LocationAddressCountry")]
        public string Country { get; set; }
    }

    public enum CMLocationAddressAddressTypeType
    {
        Street,
        [EnumMember(Value = "Postal")]
        Mailing
    }

    public enum createLocationaddRelationshiptypeInput
    {
        MemberOf,
        BossedBy,
        OtherOf,
        HasMembers,
        BossOf,
        HasOthers,
        DelegateOf,
        HasDelegates,
        AdministratorOf,
        AdministeredBy
    }

    public enum createLocationnotesUpdateTypeInput
    {
        Overwrite,
        AppendOnly,
        AppendWithNewLine,
        AppendWithUserStamp,
        PrependOnly,
        PrependWithNewLine,
        PrependWithUserStamp
    }

    public enum createLocationtitleInput
    {
        Mr,
        [EnumMember(Value = "Mr.")]
        Mr,
        Mrs,
        [EnumMember(Value = "Mrs.")]
        Mrs,
        Miss,
        [EnumMember(Value = "Miss.")]
        Miss,
        Ms,
        [EnumMember(Value = "Ms.")]
        Ms,
        Dr,
        [EnumMember(Value = "Dr.")]
        Dr,
        Mx,
        [EnumMember(Value = "Mx.")]
        Mx,
        Prof,
        [EnumMember(Value = "Prof.")]
        Prof,
        Sir,
        [EnumMember(Value = "Sir.")]
        Sir
    }

    public enum updateLocationtitleInput
    {
        Mr,
        [EnumMember(Value = "Mr.")]
        Mr,
        Mrs,
        [EnumMember(Value = "Mrs.")]
        Mrs,
        Miss,
        [EnumMember(Value = "Miss.")]
        Miss,
        Ms,
        [EnumMember(Value = "Ms.")]
        Ms,
        Dr,
        [EnumMember(Value = "Dr.")]
        Dr,
        Mx,
        [EnumMember(Value = "Mx.")]
        Mx,
        Prof,
        [EnumMember(Value = "Prof.")]
        Prof,
        Sir,
        [EnumMember(Value = "Sir.")]
        Sir
    }

    public class CMUpdatableLocationAddress
    {
        [JsonProperty("Uri")]
        public int UniqueID { get; set; }

        [JsonProperty("LocationAddressAddressType")]
        public CMUpdatableLocationAddressTypeType Type { get; set; }

        [JsonProperty("LocationAddressAddressLines")]
        public string Street { get; set; }

        [JsonProperty("LocationAddressCity")]
        public string SuburbCity { get; set; }

        [JsonProperty("LocationAddressState")]
        public string State { get; set; }

        [JsonProperty("LocationAddressPostcode")]
        public string Postcode { get; set; }

        [JsonProperty("LocationAddressCountry")]
        public string Country { get; set; }
    }

    public enum CMUpdatableLocationAddressTypeType
    {
        Street,
        [EnumMember(Value = "Postal")]
        Mailing
    }

    public class CMLocationAddressUri
    {
        [JsonProperty("Uri")]
        public int UniqueID { get; set; }
    }

    public enum typeInput
    {
        Street,
        [EnumMember(Value = "Postal")]
        Mailing
    }

    public class CMFieldDictionaryLocation
    {
        [JsonProperty("SearchClause")]
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CMEventData
    {
        [JsonProperty("OnlineEventUri")]
        public int EventUniqueIdentifier { get; set; }

        [JsonProperty("EventType")]
        public int EventTypeID { get; set; }

        [JsonProperty("EventTypeString")]
        public string EventType { get; set; }
        public string EventDate { get; set; }

        [JsonProperty("ObjectType")]
        public int ObjectTypeID { get; set; }

        [JsonProperty("ObjectTypeString")]
        public string ObjectType { get; set; }

        [JsonProperty("ObjectUri")]
        public int ObjectUniqueID { get; set; }

        [JsonProperty("RelatedObjectType")]
        public int RelatedObjectTypeID { get; set; }

        [JsonProperty("RelatedObjectTypeString")]
        public string RelatedObjectType { get; set; }

        [JsonProperty("RelatedObjectUri")]
        public int RelatedObjectUniqueID { get; set; }
        public string FromMachine { get; set; }
        public string ConnectionIPAddress { get; set; }
        public string ClientIPAddress { get; set; }
        public int FromTimeZone { get; set; }
        public string LoginName { get; set; }

        [JsonProperty("LoginUri")]
        public int LoginUniqueID { get; set; }
        public string ExtraDetails { get; set; }
    }

    public class AccessLocationsItem
    {
        [JsonProperty("Uri")]
        public int UniqueID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Contentmanagerpowerc;

    public partial class WorkflowManagedActions
    {
        public ContentmanagerpowercActions Contentmanagerpowerc(string connectionId) => new ContentmanagerpowercActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ContentmanagerpowercTriggers Contentmanagerpowerc(string connectionId) => new ContentmanagerpowercTriggers(connectionId);
    }
}