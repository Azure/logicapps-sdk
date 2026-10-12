//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HighqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        [WorkflowExpressionFactory(nameof(__BuildInsertDocument))]
        public IWorkflowAction InsertDocument([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> parentfolderid, [WorkflowExpression] Func<string> filename, [WorkflowExpression] Func<bool> overrideduplicate = null, [WorkflowExpression] Func<string> versionnote = null, [WorkflowExpression] Func<string> progressiveoperkey = null, [WorkflowExpression] Func<string> dmsdatabasename = null, [WorkflowExpression] Func<string> dmseditdate = null, [WorkflowExpression] Func<string> dmsparentfolderid = null, [WorkflowExpression] Func<string> dmsdocid = null, [WorkflowExpression] Func<string> dmsversion = null, [WorkflowExpression] Func<string> notification = null, [WorkflowExpression] Func<string> batchid = null, [WorkflowExpression] Func<string> rootfolderid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildInsertDocument(WorkflowExpression<string> version, WorkflowExpression<object> file, WorkflowExpression<string> parentfolderid, WorkflowExpression<string> filename, WorkflowExpression<bool> overrideduplicate = null, WorkflowExpression<string> versionnote = null, WorkflowExpression<string> progressiveoperkey = null, WorkflowExpression<string> dmsdatabasename = null, WorkflowExpression<string> dmseditdate = null, WorkflowExpression<string> dmsparentfolderid = null, WorkflowExpression<string> dmsdocid = null, WorkflowExpression<string> dmsversion = null, WorkflowExpression<string> notification = null, WorkflowExpression<string> batchid = null, WorkflowExpression<string> rootfolderid = null)
        {
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(parentfolderid, nameof(parentfolderid), required: true);
            WorkflowExpression.Validate(filename, nameof(filename), required: true);
            WorkflowExpression.Validate(overrideduplicate, nameof(overrideduplicate), required: false);
            WorkflowExpression.Validate(versionnote, nameof(versionnote), required: false);
            WorkflowExpression.Validate(progressiveoperkey, nameof(progressiveoperkey), required: false);
            WorkflowExpression.Validate(dmsdatabasename, nameof(dmsdatabasename), required: false);
            WorkflowExpression.Validate(dmseditdate, nameof(dmseditdate), required: false);
            WorkflowExpression.Validate(dmsparentfolderid, nameof(dmsparentfolderid), required: false);
            WorkflowExpression.Validate(dmsdocid, nameof(dmsdocid), required: false);
            WorkflowExpression.Validate(dmsversion, nameof(dmsversion), required: false);
            WorkflowExpression.Validate(notification, nameof(notification), required: false);
            WorkflowExpression.Validate(batchid, nameof(batchid), required: false);
            WorkflowExpression.Validate(rootfolderid, nameof(rootfolderid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/files/content", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentfolderid"] = ExpressionConverter.Convert(parentfolderid);
                if (overrideduplicate != null)
                    callPayload.Queries["overrideduplicate"] = ExpressionConverter.Convert(overrideduplicate);
                if (batchid != null)
                    callPayload.Queries["batchid"] = ExpressionConverter.Convert(batchid);
                if (rootfolderid != null)
                    callPayload.Queries["rootfolderid"] = ExpressionConverter.Convert(rootfolderid);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        [WorkflowExpressionFactory(nameof(__BuildMoveDocuments))]
        public IWorkflowAction MoveDocuments([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> targetfolder, [WorkflowExpression] Func<string> fileidcsvfileidCSV = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMoveDocuments(WorkflowExpression<string> version, WorkflowExpression<string> targetfolder, WorkflowExpression<string> fileidcsvfileidCSV = null)
        {
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(targetfolder, nameof(targetfolder), required: true);
            WorkflowExpression.Validate(fileidcsvfileidCSV, nameof(fileidcsvfileidCSV), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/files/move", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["targetfolder"] = ExpressionConverter.Convert(targetfolder);
                var fileidcsv = new JObject();
                var fileidcsvpropCount = 0;
                if (fileidcsvfileidCSV != null)
                {
                    fileidcsv["fileidCSV"] = ExpressionConverter.ConvertO(fileidcsvfileidCSV);
                    fileidcsvpropCount++;
                }

                if (fileidcsvpropCount > 0)
                {
                    callPayload.Body = fileidcsv;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSite))]
        public IBodyWorkflowAction<Site> CreateSite([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodysitename = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysitedescription = null, [WorkflowExpression] Func<string> bodyenabledmodules = null, [WorkflowExpression] Func<string> bodysitefolderID = null, [WorkflowExpression] Func<string> bodysitefolderpermission = null, [WorkflowExpression] Func<string> bodymodulehomeenable = null, [WorkflowExpression] Func<string> bodymoduleactivityenable = null, [WorkflowExpression] Func<string> bodymoduleactivitymicroblog = null, [WorkflowExpression] Func<string> bodymoduledocumentdocid = null, [WorkflowExpression] Func<string> bodymoduleblogblogTitle = null, [WorkflowExpression] Func<string> bodymoduleblogblogContent = null, [WorkflowExpression] Func<int> bodymoduleblogshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleblogtagList = null, [WorkflowExpression] Func<int> bodymoduleblogstatus = null, [WorkflowExpression] Func<int> bodymoduleblogsiteID = null, [WorkflowExpression] Func<string> bodymoduleblogauthor = null, [WorkflowExpression] Func<string[]> bodymoduleblogcategoryList = null, [WorkflowExpression] Func<int> bodymoduleblognotificationTypeID = null, [WorkflowExpression] Func<string> bodymoduleblogmessage = null, [WorkflowExpression] Func<int> bodymoduleblogmessageCode = null, [WorkflowExpression] Func<string> bodymoduleblogexternalID = null, [WorkflowExpression] Func<string> bodymoduleblogpublishDate = null, [WorkflowExpression] Func<string> bodymoduleblogprocesstype = null, [WorkflowExpression] Func<string> bodymoduleblogenable = null, [WorkflowExpression] Func<int> bodymodulewikiwikiid = null, [WorkflowExpression] Func<int> bodymodulewikicurrentversionid = null, [WorkflowExpression] Func<int> bodymodulewikiparentwikiid = null, [WorkflowExpression] Func<string> bodymodulewikiwikititle = null, [WorkflowExpression] Func<string> bodymodulewikiwikicontent = null, [WorkflowExpression] Func<int> bodymodulewikishowcomment = null, [WorkflowExpression] Func<string> bodymodulewikicreateddate = null, [WorkflowExpression] Func<string> bodymodulewikimodifieddate = null, [WorkflowExpression] Func<string> bodymodulewikitaglist = null, [WorkflowExpression] Func<string> bodymodulewikiwikipath = null, [WorkflowExpression] Func<int> bodymodulewikiwikidraftid = null, [WorkflowExpression] Func<string> bodymodulewikidrafttype = null, [WorkflowExpression] Func<int> bodymodulewikistatus = null, [WorkflowExpression] Func<int> bodymodulewikiwikiversionid = null, [WorkflowExpression] Func<string> bodymoduletaskindex = null, [WorkflowExpression] Func<int> bodymoduletaskparenttaskid = null, [WorkflowExpression] Func<int> bodymoduletasktaskid = null, [WorkflowExpression] Func<string> bodymoduletasktitle = null, [WorkflowExpression] Func<string> bodymoduletaskdescription = null, [WorkflowExpression] Func<string> bodymoduletaskduedate = null, [WorkflowExpression] Func<string> bodymoduletaskstartdate = null, [WorkflowExpression] Func<string> bodymoduletaskmattermaptaskid = null, [WorkflowExpression] Func<string> bodymoduletasktype = null, [WorkflowExpression] Func<string> bodymoduletaskdependenton = null, [WorkflowExpression] Func<string> bodymoduletaskdaysfromdependent = null, [WorkflowExpression] Func<int> bodymoduletaskignoreweekend = null, [WorkflowExpression] Func<int> bodymoduletaskduration = null, [WorkflowExpression] Func<string> bodymoduletaskresource = null, [WorkflowExpression] Func<string> bodymoduleEventeventTitle = null, [WorkflowExpression] Func<string> bodymoduleEventeventContent = null, [WorkflowExpression] Func<int> bodymoduleEventshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleEventtagList = null, [WorkflowExpression] Func<int> bodymoduleEventstatus = null, [WorkflowExpression] Func<int> bodymoduleEventsiteID = null, [WorkflowExpression] Func<string> bodymoduleEventcontact = null, [WorkflowExpression] Func<string[]> bodymoduleEventcategoryList = null, [WorkflowExpression] Func<int> bodymoduleEventnotificationTypeID = null, [WorkflowExpression] Func<string> bodymoduleEventmessage = null, [WorkflowExpression] Func<int> bodymoduleEventmessageCode = null, [WorkflowExpression] Func<string> bodymoduleEventexternalID = null, [WorkflowExpression] Func<string> bodymoduleEventstartDate = null, [WorkflowExpression] Func<string> bodymoduleEventendDate = null, [WorkflowExpression] Func<string> bodymoduleEventstartTime = null, [WorkflowExpression] Func<string> bodymoduleEventendTime = null, [WorkflowExpression] Func<string> bodymoduleEventlocation = null, [WorkflowExpression] Func<string> bodymoduleEventauthor = null, [WorkflowExpression] Func<string> bodymoduleEventprocesstype = null, [WorkflowExpression] Func<string> bodymoduleEventenable = null, [WorkflowExpression] Func<int> bodymoduleisheetid = null, [WorkflowExpression] Func<string> bodymoduleisheettitle = null, [WorkflowExpression] Func<string> bodymoduleisheetdescription = null, [WorkflowExpression] Func<string> bodymoduleisheetstatus = null, [WorkflowExpression] Func<string> bodymoduleisheetaccesstype = null, [WorkflowExpression] Func<string> bodymoduleisheettype = null, [WorkflowExpression] Func<string> bodymoduleisheetviewlink = null, [WorkflowExpression] Func<string> bodymoduleisheetallowsections = null, [WorkflowExpression] Func<string> bodymoduleisheetallowlookup = null, [WorkflowExpression] Func<string> bodymoduleisheetdisplayisheet = null, [WorkflowExpression] Func<string> bodymoduleisheetsearchasdefaultview = null, [WorkflowExpression] Func<string> bodymoduleisheetenableversion = null, [WorkflowExpression] Func<string> bodymoduleisheetenablesheetalerter = null, [WorkflowExpression] Func<string> bodymoduleisheetalertercondition = null, [WorkflowExpression] Func<string> bodymoduleisheetoverrideitemmodifieddate = null, [WorkflowExpression] Func<string> bodymoduleisheetenablebulkinsertupdate = null, [WorkflowExpression] Func<string> bodymoduleisheetfielddescriptions = null, [WorkflowExpression] Func<string> bodymoduleisheetenablerowlocking = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, [WorkflowExpression] Func<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowscorelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowIsheetComments = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimit = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimitEnabled = null, [WorkflowExpression] Func<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, [WorkflowExpression] Func<string> bodymoduleisheetrecordcount = null, [WorkflowExpression] Func<int> bodymoduleisheetsheettypeid = null, [WorkflowExpression] Func<string> bodymoduleqaenable = null, [WorkflowExpression] Func<PersonDBO[]> bodymodulepeopleperson = null, [WorkflowExpression] Func<string> bodymodulecontractexpressenable = null, [WorkflowExpression] Func<string> bodyadminnote = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyenddate = null, [WorkflowExpression] Func<string> bodycreateddate = null, [WorkflowExpression] Func<string> bodyarchiveddate = null, [WorkflowExpression] Func<string> bodyclientno = null, [WorkflowExpression] Func<string> bodymatterno = null, [WorkflowExpression] Func<string> bodylandingpage = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodystatusid = null, [WorkflowExpression] Func<string> bodysize = null, [WorkflowExpression] Func<string> bodybillingnotes = null, [WorkflowExpression] Func<string> bodybillingnextinvoicedate = null, [WorkflowExpression] Func<string> bodybillinglastinvoicedate = null, [WorkflowExpression] Func<string> bodyfilepagecount = null, [WorkflowExpression] Func<string> bodymaxpagecount = null, [WorkflowExpression] Func<string> bodysitehttplink = null, [WorkflowExpression] Func<int> bodyisSyncable = null, [WorkflowExpression] Func<string> bodyenforceusergroups = null, [WorkflowExpression] Func<string> bodycsvSiteCategory = null, [WorkflowExpression] Func<string> bodysiteNameInDefaultLanguage = null, [WorkflowExpression] Func<int> bodyvisible = null, [WorkflowExpression] Func<string> bodysiteLogoName = null, [WorkflowExpression] Func<int> bodysiteLogoFileSize = null, [WorkflowExpression] Func<int> bodysiteLogoHeight = null, [WorkflowExpression] Func<int> bodysiteLogoWidth = null, [WorkflowExpression] Func<int> bodysiteStatus = null, [WorkflowExpression] Func<int> bodyapplySiteTerms = null, [WorkflowExpression] Func<string> bodysiteTerm = null, [WorkflowExpression] Func<int> bodytermType = null, [WorkflowExpression] Func<int> bodynextLoginSiteTerms = null, [WorkflowExpression] Func<int> bodydefaultSiteTermsEnable = null, [WorkflowExpression] Func<int> bodyadvancedQAPermission = null, [WorkflowExpression] Func<int> bodyisInternal = null, [WorkflowExpression] Func<int> bodypsm = null, [WorkflowExpression] Func<string> bodysiteLabelDisplay = null, [WorkflowExpression] Func<int> bodyallowSiteAdministration = null, [WorkflowExpression] Func<int> bodysiteLevelPasswordEnable = null, [WorkflowExpression] Func<int> bodysiteLevelPasscodeEnable = null, [WorkflowExpression] Func<int> bodypasscodeUsingAuthApp = null, [WorkflowExpression] Func<string> bodysitePassword = null, [WorkflowExpression] Func<int> bodyipRestrictionEnable = null, [WorkflowExpression] Func<string> bodyavailableIP = null, [WorkflowExpression] Func<int> bodyhighqDrive = null, [WorkflowExpression] Func<int> bodyapplySiteHomePage = null, [WorkflowExpression] Func<string> bodysiteHomePage = null, [WorkflowExpression] Func<int> bodysiteHomePageType = null, [WorkflowExpression] Func<int> bodynextLoginSiteHomePage = null, [WorkflowExpression] Func<int> bodyapplyDisplayContent = null, [WorkflowExpression] Func<string> bodydisplayContent = null, [WorkflowExpression] Func<int> bodyrssSecurity = null, [WorkflowExpression] Func<int> bodyencryptedPassword = null, [WorkflowExpression] Func<string> bodyavailableIPRangeCSV = null, [WorkflowExpression] Func<int> bodysiteModuleID = null, [WorkflowExpression] Func<int> bodyicalSecurity = null, [WorkflowExpression] Func<string> bodydefaultDisplayContent = null, [WorkflowExpression] Func<int> bodydefaultEmailAlert = null, [WorkflowExpression] Func<int> bodyexcelReportFooter = null, [WorkflowExpression] Func<string> bodyexcelReportFooterText = null, [WorkflowExpression] Func<string> bodyannouncementMLJSON = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<int> bodytemplateLicence = null, [WorkflowExpression] Func<string> bodyopenChannelAppID = null, [WorkflowExpression] Func<int> bodyitemid = null, [WorkflowExpression] Func<int> bodysitemetadatasheetid = null, [WorkflowExpression] Func<bool> bodymysite = null, [WorkflowExpression] Func<string> bodylastaccesseddate = null, [WorkflowExpression] Func<int> bodydefaultViewerMetaDataTab = null, [WorkflowExpression] Func<int> bodydocumentMetadataViewId = null, [WorkflowExpression] Func<int> bodyfolderMetadataViewId = null, [WorkflowExpression] Func<int> bodydocSort = null, [WorkflowExpression] Func<int> bodyfolderSort = null, [WorkflowExpression] Func<int> bodydefaultFolderRenderView = null, [WorkflowExpression] Func<int> bodyisTaskAttachmentDefault = null, [WorkflowExpression] Func<int> bodytaskAttachmentDefaultFolderId = null, [WorkflowExpression] Func<string> bodyfavourite = null, [WorkflowExpression] Func<bool> bodyenabledocumentredaction = null, [WorkflowExpression] Func<int> bodymentiongroups = null, [WorkflowExpression] Func<bool> bodyenablefilerelationships = null, [WorkflowExpression] Func<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Site> __BuildCreateSite(WorkflowExpression<string> version, WorkflowExpression<int> bodyid = null, WorkflowExpression<string> bodysitename = null, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string> bodysitedescription = null, WorkflowExpression<string> bodyenabledmodules = null, WorkflowExpression<string> bodysitefolderID = null, WorkflowExpression<string> bodysitefolderpermission = null, WorkflowExpression<string> bodymodulehomeenable = null, WorkflowExpression<string> bodymoduleactivityenable = null, WorkflowExpression<string> bodymoduleactivitymicroblog = null, WorkflowExpression<string> bodymoduledocumentdocid = null, WorkflowExpression<string> bodymoduleblogblogTitle = null, WorkflowExpression<string> bodymoduleblogblogContent = null, WorkflowExpression<int> bodymoduleblogshowComment = null, WorkflowExpression<string[]> bodymoduleblogtagList = null, WorkflowExpression<int> bodymoduleblogstatus = null, WorkflowExpression<int> bodymoduleblogsiteID = null, WorkflowExpression<string> bodymoduleblogauthor = null, WorkflowExpression<string[]> bodymoduleblogcategoryList = null, WorkflowExpression<int> bodymoduleblognotificationTypeID = null, WorkflowExpression<string> bodymoduleblogmessage = null, WorkflowExpression<int> bodymoduleblogmessageCode = null, WorkflowExpression<string> bodymoduleblogexternalID = null, WorkflowExpression<string> bodymoduleblogpublishDate = null, WorkflowExpression<string> bodymoduleblogprocesstype = null, WorkflowExpression<string> bodymoduleblogenable = null, WorkflowExpression<int> bodymodulewikiwikiid = null, WorkflowExpression<int> bodymodulewikicurrentversionid = null, WorkflowExpression<int> bodymodulewikiparentwikiid = null, WorkflowExpression<string> bodymodulewikiwikititle = null, WorkflowExpression<string> bodymodulewikiwikicontent = null, WorkflowExpression<int> bodymodulewikishowcomment = null, WorkflowExpression<string> bodymodulewikicreateddate = null, WorkflowExpression<string> bodymodulewikimodifieddate = null, WorkflowExpression<string> bodymodulewikitaglist = null, WorkflowExpression<string> bodymodulewikiwikipath = null, WorkflowExpression<int> bodymodulewikiwikidraftid = null, WorkflowExpression<string> bodymodulewikidrafttype = null, WorkflowExpression<int> bodymodulewikistatus = null, WorkflowExpression<int> bodymodulewikiwikiversionid = null, WorkflowExpression<string> bodymoduletaskindex = null, WorkflowExpression<int> bodymoduletaskparenttaskid = null, WorkflowExpression<int> bodymoduletasktaskid = null, WorkflowExpression<string> bodymoduletasktitle = null, WorkflowExpression<string> bodymoduletaskdescription = null, WorkflowExpression<string> bodymoduletaskduedate = null, WorkflowExpression<string> bodymoduletaskstartdate = null, WorkflowExpression<string> bodymoduletaskmattermaptaskid = null, WorkflowExpression<string> bodymoduletasktype = null, WorkflowExpression<string> bodymoduletaskdependenton = null, WorkflowExpression<string> bodymoduletaskdaysfromdependent = null, WorkflowExpression<int> bodymoduletaskignoreweekend = null, WorkflowExpression<int> bodymoduletaskduration = null, WorkflowExpression<string> bodymoduletaskresource = null, WorkflowExpression<string> bodymoduleEventeventTitle = null, WorkflowExpression<string> bodymoduleEventeventContent = null, WorkflowExpression<int> bodymoduleEventshowComment = null, WorkflowExpression<string[]> bodymoduleEventtagList = null, WorkflowExpression<int> bodymoduleEventstatus = null, WorkflowExpression<int> bodymoduleEventsiteID = null, WorkflowExpression<string> bodymoduleEventcontact = null, WorkflowExpression<string[]> bodymoduleEventcategoryList = null, WorkflowExpression<int> bodymoduleEventnotificationTypeID = null, WorkflowExpression<string> bodymoduleEventmessage = null, WorkflowExpression<int> bodymoduleEventmessageCode = null, WorkflowExpression<string> bodymoduleEventexternalID = null, WorkflowExpression<string> bodymoduleEventstartDate = null, WorkflowExpression<string> bodymoduleEventendDate = null, WorkflowExpression<string> bodymoduleEventstartTime = null, WorkflowExpression<string> bodymoduleEventendTime = null, WorkflowExpression<string> bodymoduleEventlocation = null, WorkflowExpression<string> bodymoduleEventauthor = null, WorkflowExpression<string> bodymoduleEventprocesstype = null, WorkflowExpression<string> bodymoduleEventenable = null, WorkflowExpression<int> bodymoduleisheetid = null, WorkflowExpression<string> bodymoduleisheettitle = null, WorkflowExpression<string> bodymoduleisheetdescription = null, WorkflowExpression<string> bodymoduleisheetstatus = null, WorkflowExpression<string> bodymoduleisheetaccesstype = null, WorkflowExpression<string> bodymoduleisheettype = null, WorkflowExpression<string> bodymoduleisheetviewlink = null, WorkflowExpression<string> bodymoduleisheetallowsections = null, WorkflowExpression<string> bodymoduleisheetallowlookup = null, WorkflowExpression<string> bodymoduleisheetdisplayisheet = null, WorkflowExpression<string> bodymoduleisheetsearchasdefaultview = null, WorkflowExpression<string> bodymoduleisheetenableversion = null, WorkflowExpression<string> bodymoduleisheetenablesheetalerter = null, WorkflowExpression<string> bodymoduleisheetalertercondition = null, WorkflowExpression<string> bodymoduleisheetoverrideitemmodifieddate = null, WorkflowExpression<string> bodymoduleisheetenablebulkinsertupdate = null, WorkflowExpression<string> bodymoduleisheetfielddescriptions = null, WorkflowExpression<string> bodymoduleisheetenablerowlocking = null, WorkflowExpression<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, WorkflowExpression<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, WorkflowExpression<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, WorkflowExpression<string> bodymoduleisheetallowscorelistvaluesforreuse = null, WorkflowExpression<string> bodymoduleisheetallowIsheetComments = null, WorkflowExpression<int> bodymoduleisheetshareRecordsLimit = null, WorkflowExpression<int> bodymoduleisheetshareRecordsLimitEnabled = null, WorkflowExpression<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, WorkflowExpression<string> bodymoduleisheetrecordcount = null, WorkflowExpression<int> bodymoduleisheetsheettypeid = null, WorkflowExpression<string> bodymoduleqaenable = null, WorkflowExpression<PersonDBO[]> bodymodulepeopleperson = null, WorkflowExpression<string> bodymodulecontractexpressenable = null, WorkflowExpression<string> bodyadminnote = null, WorkflowExpression<string> bodystartdate = null, WorkflowExpression<string> bodyenddate = null, WorkflowExpression<string> bodycreateddate = null, WorkflowExpression<string> bodyarchiveddate = null, WorkflowExpression<string> bodyclientno = null, WorkflowExpression<string> bodymatterno = null, WorkflowExpression<string> bodylandingpage = null, WorkflowExpression<string> bodylink = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<int> bodystatusid = null, WorkflowExpression<string> bodysize = null, WorkflowExpression<string> bodybillingnotes = null, WorkflowExpression<string> bodybillingnextinvoicedate = null, WorkflowExpression<string> bodybillinglastinvoicedate = null, WorkflowExpression<string> bodyfilepagecount = null, WorkflowExpression<string> bodymaxpagecount = null, WorkflowExpression<string> bodysitehttplink = null, WorkflowExpression<int> bodyisSyncable = null, WorkflowExpression<string> bodyenforceusergroups = null, WorkflowExpression<string> bodycsvSiteCategory = null, WorkflowExpression<string> bodysiteNameInDefaultLanguage = null, WorkflowExpression<int> bodyvisible = null, WorkflowExpression<string> bodysiteLogoName = null, WorkflowExpression<int> bodysiteLogoFileSize = null, WorkflowExpression<int> bodysiteLogoHeight = null, WorkflowExpression<int> bodysiteLogoWidth = null, WorkflowExpression<int> bodysiteStatus = null, WorkflowExpression<int> bodyapplySiteTerms = null, WorkflowExpression<string> bodysiteTerm = null, WorkflowExpression<int> bodytermType = null, WorkflowExpression<int> bodynextLoginSiteTerms = null, WorkflowExpression<int> bodydefaultSiteTermsEnable = null, WorkflowExpression<int> bodyadvancedQAPermission = null, WorkflowExpression<int> bodyisInternal = null, WorkflowExpression<int> bodypsm = null, WorkflowExpression<string> bodysiteLabelDisplay = null, WorkflowExpression<int> bodyallowSiteAdministration = null, WorkflowExpression<int> bodysiteLevelPasswordEnable = null, WorkflowExpression<int> bodysiteLevelPasscodeEnable = null, WorkflowExpression<int> bodypasscodeUsingAuthApp = null, WorkflowExpression<string> bodysitePassword = null, WorkflowExpression<int> bodyipRestrictionEnable = null, WorkflowExpression<string> bodyavailableIP = null, WorkflowExpression<int> bodyhighqDrive = null, WorkflowExpression<int> bodyapplySiteHomePage = null, WorkflowExpression<string> bodysiteHomePage = null, WorkflowExpression<int> bodysiteHomePageType = null, WorkflowExpression<int> bodynextLoginSiteHomePage = null, WorkflowExpression<int> bodyapplyDisplayContent = null, WorkflowExpression<string> bodydisplayContent = null, WorkflowExpression<int> bodyrssSecurity = null, WorkflowExpression<int> bodyencryptedPassword = null, WorkflowExpression<string> bodyavailableIPRangeCSV = null, WorkflowExpression<int> bodysiteModuleID = null, WorkflowExpression<int> bodyicalSecurity = null, WorkflowExpression<string> bodydefaultDisplayContent = null, WorkflowExpression<int> bodydefaultEmailAlert = null, WorkflowExpression<int> bodyexcelReportFooter = null, WorkflowExpression<string> bodyexcelReportFooterText = null, WorkflowExpression<string> bodyannouncementMLJSON = null, WorkflowExpression<int> bodytemplateType = null, WorkflowExpression<int> bodytemplateLicence = null, WorkflowExpression<string> bodyopenChannelAppID = null, WorkflowExpression<int> bodyitemid = null, WorkflowExpression<int> bodysitemetadatasheetid = null, WorkflowExpression<bool> bodymysite = null, WorkflowExpression<string> bodylastaccesseddate = null, WorkflowExpression<int> bodydefaultViewerMetaDataTab = null, WorkflowExpression<int> bodydocumentMetadataViewId = null, WorkflowExpression<int> bodyfolderMetadataViewId = null, WorkflowExpression<int> bodydocSort = null, WorkflowExpression<int> bodyfolderSort = null, WorkflowExpression<int> bodydefaultFolderRenderView = null, WorkflowExpression<int> bodyisTaskAttachmentDefault = null, WorkflowExpression<int> bodytaskAttachmentDefaultFolderId = null, WorkflowExpression<string> bodyfavourite = null, WorkflowExpression<bool> bodyenabledocumentredaction = null, WorkflowExpression<int> bodymentiongroups = null, WorkflowExpression<bool> bodyenablefilerelationships = null, WorkflowExpression<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodysitename, nameof(bodysitename), required: false);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodysitedescription, nameof(bodysitedescription), required: false);
            WorkflowExpression.Validate(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            WorkflowExpression.Validate(bodysitefolderID, nameof(bodysitefolderID), required: false);
            WorkflowExpression.Validate(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            WorkflowExpression.Validate(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            WorkflowExpression.Validate(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            WorkflowExpression.Validate(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            WorkflowExpression.Validate(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            WorkflowExpression.Validate(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            WorkflowExpression.Validate(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            WorkflowExpression.Validate(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            WorkflowExpression.Validate(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            WorkflowExpression.Validate(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            WorkflowExpression.Validate(bodymoduleblogsiteID, nameof(bodymoduleblogsiteID), required: false);
            WorkflowExpression.Validate(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            WorkflowExpression.Validate(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            WorkflowExpression.Validate(bodymoduleblognotificationTypeID, nameof(bodymoduleblognotificationTypeID), required: false);
            WorkflowExpression.Validate(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            WorkflowExpression.Validate(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            WorkflowExpression.Validate(bodymoduleblogexternalID, nameof(bodymoduleblogexternalID), required: false);
            WorkflowExpression.Validate(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            WorkflowExpression.Validate(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            WorkflowExpression.Validate(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            WorkflowExpression.Validate(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            WorkflowExpression.Validate(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            WorkflowExpression.Validate(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            WorkflowExpression.Validate(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            WorkflowExpression.Validate(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            WorkflowExpression.Validate(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            WorkflowExpression.Validate(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            WorkflowExpression.Validate(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            WorkflowExpression.Validate(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            WorkflowExpression.Validate(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            WorkflowExpression.Validate(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            WorkflowExpression.Validate(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            WorkflowExpression.Validate(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            WorkflowExpression.Validate(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            WorkflowExpression.Validate(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            WorkflowExpression.Validate(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            WorkflowExpression.Validate(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            WorkflowExpression.Validate(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            WorkflowExpression.Validate(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            WorkflowExpression.Validate(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            WorkflowExpression.Validate(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            WorkflowExpression.Validate(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            WorkflowExpression.Validate(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            WorkflowExpression.Validate(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            WorkflowExpression.Validate(bodymoduleEventsiteID, nameof(bodymoduleEventsiteID), required: false);
            WorkflowExpression.Validate(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            WorkflowExpression.Validate(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            WorkflowExpression.Validate(bodymoduleEventnotificationTypeID, nameof(bodymoduleEventnotificationTypeID), required: false);
            WorkflowExpression.Validate(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            WorkflowExpression.Validate(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            WorkflowExpression.Validate(bodymoduleEventexternalID, nameof(bodymoduleEventexternalID), required: false);
            WorkflowExpression.Validate(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            WorkflowExpression.Validate(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            WorkflowExpression.Validate(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            WorkflowExpression.Validate(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            WorkflowExpression.Validate(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            WorkflowExpression.Validate(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            WorkflowExpression.Validate(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            WorkflowExpression.Validate(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            WorkflowExpression.Validate(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            WorkflowExpression.Validate(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            WorkflowExpression.Validate(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            WorkflowExpression.Validate(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            WorkflowExpression.Validate(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            WorkflowExpression.Validate(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            WorkflowExpression.Validate(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            WorkflowExpression.Validate(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            WorkflowExpression.Validate(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            WorkflowExpression.Validate(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            WorkflowExpression.Validate(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            WorkflowExpression.Validate(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            WorkflowExpression.Validate(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            WorkflowExpression.Validate(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            WorkflowExpression.Validate(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            WorkflowExpression.Validate(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            WorkflowExpression.Validate(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            WorkflowExpression.Validate(bodyadminnote, nameof(bodyadminnote), required: false);
            WorkflowExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            WorkflowExpression.Validate(bodyenddate, nameof(bodyenddate), required: false);
            WorkflowExpression.Validate(bodycreateddate, nameof(bodycreateddate), required: false);
            WorkflowExpression.Validate(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            WorkflowExpression.Validate(bodyclientno, nameof(bodyclientno), required: false);
            WorkflowExpression.Validate(bodymatterno, nameof(bodymatterno), required: false);
            WorkflowExpression.Validate(bodylandingpage, nameof(bodylandingpage), required: false);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodystatusid, nameof(bodystatusid), required: false);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: false);
            WorkflowExpression.Validate(bodybillingnotes, nameof(bodybillingnotes), required: false);
            WorkflowExpression.Validate(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            WorkflowExpression.Validate(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            WorkflowExpression.Validate(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            WorkflowExpression.Validate(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            WorkflowExpression.Validate(bodysitehttplink, nameof(bodysitehttplink), required: false);
            WorkflowExpression.Validate(bodyisSyncable, nameof(bodyisSyncable), required: false);
            WorkflowExpression.Validate(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            WorkflowExpression.Validate(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            WorkflowExpression.Validate(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            WorkflowExpression.Validate(bodyvisible, nameof(bodyvisible), required: false);
            WorkflowExpression.Validate(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            WorkflowExpression.Validate(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            WorkflowExpression.Validate(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            WorkflowExpression.Validate(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            WorkflowExpression.Validate(bodysiteStatus, nameof(bodysiteStatus), required: false);
            WorkflowExpression.Validate(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            WorkflowExpression.Validate(bodysiteTerm, nameof(bodysiteTerm), required: false);
            WorkflowExpression.Validate(bodytermType, nameof(bodytermType), required: false);
            WorkflowExpression.Validate(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            WorkflowExpression.Validate(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            WorkflowExpression.Validate(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            WorkflowExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            WorkflowExpression.Validate(bodypsm, nameof(bodypsm), required: false);
            WorkflowExpression.Validate(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            WorkflowExpression.Validate(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            WorkflowExpression.Validate(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            WorkflowExpression.Validate(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            WorkflowExpression.Validate(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            WorkflowExpression.Validate(bodysitePassword, nameof(bodysitePassword), required: false);
            WorkflowExpression.Validate(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            WorkflowExpression.Validate(bodyavailableIP, nameof(bodyavailableIP), required: false);
            WorkflowExpression.Validate(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            WorkflowExpression.Validate(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            WorkflowExpression.Validate(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            WorkflowExpression.Validate(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            WorkflowExpression.Validate(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            WorkflowExpression.Validate(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            WorkflowExpression.Validate(bodydisplayContent, nameof(bodydisplayContent), required: false);
            WorkflowExpression.Validate(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            WorkflowExpression.Validate(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            WorkflowExpression.Validate(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            WorkflowExpression.Validate(bodysiteModuleID, nameof(bodysiteModuleID), required: false);
            WorkflowExpression.Validate(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            WorkflowExpression.Validate(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            WorkflowExpression.Validate(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            WorkflowExpression.Validate(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            WorkflowExpression.Validate(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            WorkflowExpression.Validate(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            WorkflowExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            WorkflowExpression.Validate(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            WorkflowExpression.Validate(bodyopenChannelAppID, nameof(bodyopenChannelAppID), required: false);
            WorkflowExpression.Validate(bodyitemid, nameof(bodyitemid), required: false);
            WorkflowExpression.Validate(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            WorkflowExpression.Validate(bodymysite, nameof(bodymysite), required: false);
            WorkflowExpression.Validate(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            WorkflowExpression.Validate(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            WorkflowExpression.Validate(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            WorkflowExpression.Validate(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            WorkflowExpression.Validate(bodydocSort, nameof(bodydocSort), required: false);
            WorkflowExpression.Validate(bodyfolderSort, nameof(bodyfolderSort), required: false);
            WorkflowExpression.Validate(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            WorkflowExpression.Validate(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            WorkflowExpression.Validate(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            WorkflowExpression.Validate(bodyfavourite, nameof(bodyfavourite), required: false);
            WorkflowExpression.Validate(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            WorkflowExpression.Validate(bodymentiongroups, nameof(bodymentiongroups), required: false);
            WorkflowExpression.Validate(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            WorkflowExpression.Validate(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            return new DeferredBodyAction<Site>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sites", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodysitename != null)
                {
                    body["sitename"] = ExpressionConverter.ConvertO(bodysitename);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodysitedescription != null)
                {
                    body["sitedescription"] = ExpressionConverter.ConvertO(bodysitedescription);
                    bodypropCount++;
                }

                if (bodyenabledmodules != null)
                {
                    body["enabledmodules"] = ExpressionConverter.ConvertO(bodyenabledmodules);
                    bodypropCount++;
                }

                if (bodysitefolderID != null)
                {
                    body["sitefolderID"] = ExpressionConverter.ConvertO(bodysitefolderID);
                    bodypropCount++;
                }

                if (bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = ExpressionConverter.ConvertO(bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (bodymodulehomeenable != null)
                {
                    homeObject["enable"] = ExpressionConverter.ConvertO(bodymodulehomeenable);
                    homeObjectpropCount++;
                }

                if (homeObjectpropCount > 0)
                {
                    moduleObject["home"] = homeObject;
                    moduleObjectpropCount++;
                }

                var activityObject = new JObject();
                var activityObjectpropCount = 0;
                if (bodymoduleactivityenable != null)
                {
                    activityObject["enable"] = ExpressionConverter.ConvertO(bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = ExpressionConverter.ConvertO(bodymoduleactivitymicroblog);
                    activityObjectpropCount++;
                }

                if (activityObjectpropCount > 0)
                {
                    moduleObject["activity"] = activityObject;
                    moduleObjectpropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodymoduledocumentdocid != null)
                {
                    documentObject["docid"] = ExpressionConverter.ConvertO(bodymoduledocumentdocid);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    moduleObject["document"] = documentObject;
                    moduleObjectpropCount++;
                }

                var blogObject = new JObject();
                var blogObjectpropCount = 0;
                if (bodymoduleblogblogTitle != null)
                {
                    blogObject["blogTitle"] = ExpressionConverter.ConvertO(bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = ExpressionConverter.ConvertO(bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogstatus != null)
                {
                    blogObject["status"] = ExpressionConverter.ConvertO(bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogsiteID != null)
                {
                    blogObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleblogsiteID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogauthor != null)
                {
                    blogObject["author"] = ExpressionConverter.ConvertO(bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblognotificationTypeID != null)
                {
                    blogObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleblognotificationTypeID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessage != null)
                {
                    blogObject["message"] = ExpressionConverter.ConvertO(bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogexternalID != null)
                {
                    blogObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleblogexternalID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = ExpressionConverter.ConvertO(bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogenable != null)
                {
                    blogObject["enable"] = ExpressionConverter.ConvertO(bodymoduleblogenable);
                    blogObjectpropCount++;
                }

                if (blogObjectpropCount > 0)
                {
                    moduleObject["blog"] = blogObject;
                    moduleObjectpropCount++;
                }

                var wikiObject = new JObject();
                var wikiObjectpropCount = 0;
                if (bodymodulewikiwikiid != null)
                {
                    wikiObject["wikiid"] = ExpressionConverter.ConvertO(bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = ExpressionConverter.ConvertO(bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = ExpressionConverter.ConvertO(bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = ExpressionConverter.ConvertO(bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = ExpressionConverter.ConvertO(bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = ExpressionConverter.ConvertO(bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = ExpressionConverter.ConvertO(bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = ExpressionConverter.ConvertO(bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = ExpressionConverter.ConvertO(bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = ExpressionConverter.ConvertO(bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = ExpressionConverter.ConvertO(bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = ExpressionConverter.ConvertO(bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikistatus != null)
                {
                    wikiObject["status"] = ExpressionConverter.ConvertO(bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = ExpressionConverter.ConvertO(bodymodulewikiwikiversionid);
                    wikiObjectpropCount++;
                }

                if (wikiObjectpropCount > 0)
                {
                    moduleObject["wiki"] = wikiObject;
                    moduleObjectpropCount++;
                }

                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (bodymoduletaskindex != null)
                {
                    taskObject["index"] = ExpressionConverter.ConvertO(bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = ExpressionConverter.ConvertO(bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = ExpressionConverter.ConvertO(bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktitle != null)
                {
                    taskObject["title"] = ExpressionConverter.ConvertO(bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdescription != null)
                {
                    taskObject["description"] = ExpressionConverter.ConvertO(bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = ExpressionConverter.ConvertO(bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = ExpressionConverter.ConvertO(bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = ExpressionConverter.ConvertO(bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktype != null)
                {
                    taskObject["type"] = ExpressionConverter.ConvertO(bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = ExpressionConverter.ConvertO(bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = ExpressionConverter.ConvertO(bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = ExpressionConverter.ConvertO(bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduration != null)
                {
                    taskObject["duration"] = ExpressionConverter.ConvertO(bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskresource != null)
                {
                    taskObject["resource"] = ExpressionConverter.ConvertO(bodymoduletaskresource);
                    taskObjectpropCount++;
                }

                if (taskObjectpropCount > 0)
                {
                    moduleObject["task"] = taskObject;
                    moduleObjectpropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (bodymoduleEventeventTitle != null)
                {
                    @eventObject["eventTitle"] = ExpressionConverter.ConvertO(bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = ExpressionConverter.ConvertO(bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = ExpressionConverter.ConvertO(bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventsiteID != null)
                {
                    @eventObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleEventsiteID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = ExpressionConverter.ConvertO(bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventnotificationTypeID != null)
                {
                    @eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleEventnotificationTypeID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = ExpressionConverter.ConvertO(bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventexternalID != null)
                {
                    @eventObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleEventexternalID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = ExpressionConverter.ConvertO(bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = ExpressionConverter.ConvertO(bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = ExpressionConverter.ConvertO(bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = ExpressionConverter.ConvertO(bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = ExpressionConverter.ConvertO(bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = ExpressionConverter.ConvertO(bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = ExpressionConverter.ConvertO(bodymoduleEventenable);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    moduleObject["event"] = @eventObject;
                    moduleObjectpropCount++;
                }

                var isheetObject = new JObject();
                var isheetObjectpropCount = 0;
                if (bodymoduleisheetid != null)
                {
                    isheetObject["id"] = ExpressionConverter.ConvertO(bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = ExpressionConverter.ConvertO(bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = ExpressionConverter.ConvertO(bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = ExpressionConverter.ConvertO(bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = ExpressionConverter.ConvertO(bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettype != null)
                {
                    isheetObject["type"] = ExpressionConverter.ConvertO(bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = ExpressionConverter.ConvertO(bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = ExpressionConverter.ConvertO(bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = ExpressionConverter.ConvertO(bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = ExpressionConverter.ConvertO(bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = ExpressionConverter.ConvertO(bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = ExpressionConverter.ConvertO(bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = ExpressionConverter.ConvertO(bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = ExpressionConverter.ConvertO(bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = ExpressionConverter.ConvertO(bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = ExpressionConverter.ConvertO(bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = ExpressionConverter.ConvertO(bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = ExpressionConverter.ConvertO(bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = ExpressionConverter.ConvertO(bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = ExpressionConverter.ConvertO(bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = ExpressionConverter.ConvertO(bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = ExpressionConverter.ConvertO(bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = ExpressionConverter.ConvertO(bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = ExpressionConverter.ConvertO(bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = ExpressionConverter.ConvertO(bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = ExpressionConverter.ConvertO(bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = ExpressionConverter.ConvertO(bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = ExpressionConverter.ConvertO(bodymoduleisheetsheettypeid);
                    isheetObjectpropCount++;
                }

                if (isheetObjectpropCount > 0)
                {
                    moduleObject["isheet"] = isheetObject;
                    moduleObjectpropCount++;
                }

                var qaObject = new JObject();
                var qaObjectpropCount = 0;
                if (bodymoduleqaenable != null)
                {
                    qaObject["enable"] = ExpressionConverter.ConvertO(bodymoduleqaenable);
                    qaObjectpropCount++;
                }

                if (qaObjectpropCount > 0)
                {
                    moduleObject["qa"] = qaObject;
                    moduleObjectpropCount++;
                }

                var peopleObject = new JObject();
                var peopleObjectpropCount = 0;
                if (bodymodulepeopleperson != null)
                {
                    peopleObject["person"] = ExpressionConverter.ConvertO(bodymodulepeopleperson);
                    peopleObjectpropCount++;
                }

                if (peopleObjectpropCount > 0)
                {
                    moduleObject["people"] = peopleObject;
                    moduleObjectpropCount++;
                }

                var contractexpressObject = new JObject();
                var contractexpressObjectpropCount = 0;
                if (bodymodulecontractexpressenable != null)
                {
                    contractexpressObject["enable"] = ExpressionConverter.ConvertO(bodymodulecontractexpressenable);
                    contractexpressObjectpropCount++;
                }

                if (contractexpressObjectpropCount > 0)
                {
                    moduleObject["contractexpress"] = contractexpressObject;
                    moduleObjectpropCount++;
                }

                if (moduleObjectpropCount > 0)
                {
                    body["module"] = moduleObject;
                    bodypropCount++;
                }

                if (bodyadminnote != null)
                {
                    body["adminnote"] = ExpressionConverter.ConvertO(bodyadminnote);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(bodystartdate);
                    bodypropCount++;
                }

                if (bodyenddate != null)
                {
                    body["enddate"] = ExpressionConverter.ConvertO(bodyenddate);
                    bodypropCount++;
                }

                if (bodycreateddate != null)
                {
                    body["createddate"] = ExpressionConverter.ConvertO(bodycreateddate);
                    bodypropCount++;
                }

                if (bodyarchiveddate != null)
                {
                    body["archiveddate"] = ExpressionConverter.ConvertO(bodyarchiveddate);
                    bodypropCount++;
                }

                if (bodyclientno != null)
                {
                    body["clientno"] = ExpressionConverter.ConvertO(bodyclientno);
                    bodypropCount++;
                }

                if (bodymatterno != null)
                {
                    body["matterno"] = ExpressionConverter.ConvertO(bodymatterno);
                    bodypropCount++;
                }

                if (bodylandingpage != null)
                {
                    body["landingpage"] = ExpressionConverter.ConvertO(bodylandingpage);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(bodylink);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusid != null)
                {
                    body["statusid"] = ExpressionConverter.ConvertO(bodystatusid);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(bodysize);
                    bodypropCount++;
                }

                if (bodybillingnotes != null)
                {
                    body["billingnotes"] = ExpressionConverter.ConvertO(bodybillingnotes);
                    bodypropCount++;
                }

                if (bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = ExpressionConverter.ConvertO(bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = ExpressionConverter.ConvertO(bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (bodyfilepagecount != null)
                {
                    body["filepagecount"] = ExpressionConverter.ConvertO(bodyfilepagecount);
                    bodypropCount++;
                }

                if (bodymaxpagecount != null)
                {
                    body["maxpagecount"] = ExpressionConverter.ConvertO(bodymaxpagecount);
                    bodypropCount++;
                }

                if (bodysitehttplink != null)
                {
                    body["sitehttplink"] = ExpressionConverter.ConvertO(bodysitehttplink);
                    bodypropCount++;
                }

                if (bodyisSyncable != null)
                {
                    body["isSyncable"] = ExpressionConverter.ConvertO(bodyisSyncable);
                    bodypropCount++;
                }

                if (bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = ExpressionConverter.ConvertO(bodyenforceusergroups);
                    bodypropCount++;
                }

                if (bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = ExpressionConverter.ConvertO(bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = ExpressionConverter.ConvertO(bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (bodyvisible != null)
                {
                    body["visible"] = ExpressionConverter.ConvertO(bodyvisible);
                    bodypropCount++;
                }

                if (bodysiteLogoName != null)
                {
                    body["siteLogoName"] = ExpressionConverter.ConvertO(bodysiteLogoName);
                    bodypropCount++;
                }

                if (bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = ExpressionConverter.ConvertO(bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = ExpressionConverter.ConvertO(bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = ExpressionConverter.ConvertO(bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (bodysiteStatus != null)
                {
                    body["siteStatus"] = ExpressionConverter.ConvertO(bodysiteStatus);
                    bodypropCount++;
                }

                if (bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = ExpressionConverter.ConvertO(bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (bodysiteTerm != null)
                {
                    body["siteTerm"] = ExpressionConverter.ConvertO(bodysiteTerm);
                    bodypropCount++;
                }

                if (bodytermType != null)
                {
                    body["termType"] = ExpressionConverter.ConvertO(bodytermType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = ExpressionConverter.ConvertO(bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = ExpressionConverter.ConvertO(bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = ExpressionConverter.ConvertO(bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypsm != null)
                {
                    body["psm"] = ExpressionConverter.ConvertO(bodypsm);
                    bodypropCount++;
                }

                if (bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = ExpressionConverter.ConvertO(bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = ExpressionConverter.ConvertO(bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = ExpressionConverter.ConvertO(bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = ExpressionConverter.ConvertO(bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = ExpressionConverter.ConvertO(bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (bodysitePassword != null)
                {
                    body["sitePassword"] = ExpressionConverter.ConvertO(bodysitePassword);
                    bodypropCount++;
                }

                if (bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = ExpressionConverter.ConvertO(bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (bodyavailableIP != null)
                {
                    body["availableIP"] = ExpressionConverter.ConvertO(bodyavailableIP);
                    bodypropCount++;
                }

                if (bodyhighqDrive != null)
                {
                    body["highqDrive"] = ExpressionConverter.ConvertO(bodyhighqDrive);
                    bodypropCount++;
                }

                if (bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = ExpressionConverter.ConvertO(bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePage != null)
                {
                    body["siteHomePage"] = ExpressionConverter.ConvertO(bodysiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = ExpressionConverter.ConvertO(bodysiteHomePageType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = ExpressionConverter.ConvertO(bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = ExpressionConverter.ConvertO(bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (bodydisplayContent != null)
                {
                    body["displayContent"] = ExpressionConverter.ConvertO(bodydisplayContent);
                    bodypropCount++;
                }

                if (bodyrssSecurity != null)
                {
                    body["rssSecurity"] = ExpressionConverter.ConvertO(bodyrssSecurity);
                    bodypropCount++;
                }

                if (bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = ExpressionConverter.ConvertO(bodyencryptedPassword);
                    bodypropCount++;
                }

                if (bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = ExpressionConverter.ConvertO(bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (bodysiteModuleID != null)
                {
                    body["siteModuleID"] = ExpressionConverter.ConvertO(bodysiteModuleID);
                    bodypropCount++;
                }

                if (bodyicalSecurity != null)
                {
                    body["icalSecurity"] = ExpressionConverter.ConvertO(bodyicalSecurity);
                    bodypropCount++;
                }

                if (bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = ExpressionConverter.ConvertO(bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = ExpressionConverter.ConvertO(bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = ExpressionConverter.ConvertO(bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = ExpressionConverter.ConvertO(bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = ExpressionConverter.ConvertO(bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["templateType"] = ExpressionConverter.ConvertO(bodytemplateType);
                    bodypropCount++;
                }

                if (bodytemplateLicence != null)
                {
                    body["templateLicence"] = ExpressionConverter.ConvertO(bodytemplateLicence);
                    bodypropCount++;
                }

                if (bodyopenChannelAppID != null)
                {
                    body["openChannelAppID"] = ExpressionConverter.ConvertO(bodyopenChannelAppID);
                    bodypropCount++;
                }

                if (bodyitemid != null)
                {
                    body["itemid"] = ExpressionConverter.ConvertO(bodyitemid);
                    bodypropCount++;
                }

                if (bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = ExpressionConverter.ConvertO(bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (bodymysite != null)
                {
                    body["mysite"] = ExpressionConverter.ConvertO(bodymysite);
                    bodypropCount++;
                }

                if (bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = ExpressionConverter.ConvertO(bodylastaccesseddate);
                    bodypropCount++;
                }

                if (bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = ExpressionConverter.ConvertO(bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = ExpressionConverter.ConvertO(bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = ExpressionConverter.ConvertO(bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (bodydocSort != null)
                {
                    body["docSort"] = ExpressionConverter.ConvertO(bodydocSort);
                    bodypropCount++;
                }

                if (bodyfolderSort != null)
                {
                    body["folderSort"] = ExpressionConverter.ConvertO(bodyfolderSort);
                    bodypropCount++;
                }

                if (bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = ExpressionConverter.ConvertO(bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = ExpressionConverter.ConvertO(bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = ExpressionConverter.ConvertO(bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (bodyfavourite != null)
                {
                    body["favourite"] = ExpressionConverter.ConvertO(bodyfavourite);
                    bodypropCount++;
                }

                if (bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = ExpressionConverter.ConvertO(bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (bodymentiongroups != null)
                {
                    body["mentiongroups"] = ExpressionConverter.ConvertO(bodymentiongroups);
                    bodypropCount++;
                }

                if (bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = ExpressionConverter.ConvertO(bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = ExpressionConverter.ConvertO(bodyfilerelationshipsitepermissionlevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Site>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSite))]
        public IWorkflowAction UpdateSite([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> siteid, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodysitename = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysitedescription = null, [WorkflowExpression] Func<string> bodyenabledmodules = null, [WorkflowExpression] Func<string> bodysitefolderID = null, [WorkflowExpression] Func<string> bodysitefolderpermission = null, [WorkflowExpression] Func<string> bodymodulehomeenable = null, [WorkflowExpression] Func<string> bodymoduleactivityenable = null, [WorkflowExpression] Func<string> bodymoduleactivitymicroblog = null, [WorkflowExpression] Func<string> bodymoduledocumentdocid = null, [WorkflowExpression] Func<string> bodymoduleblogblogTitle = null, [WorkflowExpression] Func<string> bodymoduleblogblogContent = null, [WorkflowExpression] Func<int> bodymoduleblogshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleblogtagList = null, [WorkflowExpression] Func<int> bodymoduleblogstatus = null, [WorkflowExpression] Func<int> bodymoduleblogsiteID = null, [WorkflowExpression] Func<string> bodymoduleblogauthor = null, [WorkflowExpression] Func<string[]> bodymoduleblogcategoryList = null, [WorkflowExpression] Func<int> bodymoduleblognotificationTypeID = null, [WorkflowExpression] Func<string> bodymoduleblogmessage = null, [WorkflowExpression] Func<int> bodymoduleblogmessageCode = null, [WorkflowExpression] Func<string> bodymoduleblogexternalID = null, [WorkflowExpression] Func<string> bodymoduleblogpublishDate = null, [WorkflowExpression] Func<string> bodymoduleblogprocesstype = null, [WorkflowExpression] Func<string> bodymoduleblogenable = null, [WorkflowExpression] Func<int> bodymodulewikiwikiid = null, [WorkflowExpression] Func<int> bodymodulewikicurrentversionid = null, [WorkflowExpression] Func<int> bodymodulewikiparentwikiid = null, [WorkflowExpression] Func<string> bodymodulewikiwikititle = null, [WorkflowExpression] Func<string> bodymodulewikiwikicontent = null, [WorkflowExpression] Func<int> bodymodulewikishowcomment = null, [WorkflowExpression] Func<string> bodymodulewikicreateddate = null, [WorkflowExpression] Func<string> bodymodulewikimodifieddate = null, [WorkflowExpression] Func<string> bodymodulewikitaglist = null, [WorkflowExpression] Func<string> bodymodulewikiwikipath = null, [WorkflowExpression] Func<int> bodymodulewikiwikidraftid = null, [WorkflowExpression] Func<string> bodymodulewikidrafttype = null, [WorkflowExpression] Func<int> bodymodulewikistatus = null, [WorkflowExpression] Func<int> bodymodulewikiwikiversionid = null, [WorkflowExpression] Func<string> bodymoduletaskindex = null, [WorkflowExpression] Func<int> bodymoduletaskparenttaskid = null, [WorkflowExpression] Func<int> bodymoduletasktaskid = null, [WorkflowExpression] Func<string> bodymoduletasktitle = null, [WorkflowExpression] Func<string> bodymoduletaskdescription = null, [WorkflowExpression] Func<string> bodymoduletaskduedate = null, [WorkflowExpression] Func<string> bodymoduletaskstartdate = null, [WorkflowExpression] Func<string> bodymoduletaskmattermaptaskid = null, [WorkflowExpression] Func<string> bodymoduletasktype = null, [WorkflowExpression] Func<string> bodymoduletaskdependenton = null, [WorkflowExpression] Func<string> bodymoduletaskdaysfromdependent = null, [WorkflowExpression] Func<int> bodymoduletaskignoreweekend = null, [WorkflowExpression] Func<int> bodymoduletaskduration = null, [WorkflowExpression] Func<string> bodymoduletaskresource = null, [WorkflowExpression] Func<string> bodymoduleEventeventTitle = null, [WorkflowExpression] Func<string> bodymoduleEventeventContent = null, [WorkflowExpression] Func<int> bodymoduleEventshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleEventtagList = null, [WorkflowExpression] Func<int> bodymoduleEventstatus = null, [WorkflowExpression] Func<int> bodymoduleEventsiteID = null, [WorkflowExpression] Func<string> bodymoduleEventcontact = null, [WorkflowExpression] Func<string[]> bodymoduleEventcategoryList = null, [WorkflowExpression] Func<int> bodymoduleEventnotificationTypeID = null, [WorkflowExpression] Func<string> bodymoduleEventmessage = null, [WorkflowExpression] Func<int> bodymoduleEventmessageCode = null, [WorkflowExpression] Func<string> bodymoduleEventexternalID = null, [WorkflowExpression] Func<string> bodymoduleEventstartDate = null, [WorkflowExpression] Func<string> bodymoduleEventendDate = null, [WorkflowExpression] Func<string> bodymoduleEventstartTime = null, [WorkflowExpression] Func<string> bodymoduleEventendTime = null, [WorkflowExpression] Func<string> bodymoduleEventlocation = null, [WorkflowExpression] Func<string> bodymoduleEventauthor = null, [WorkflowExpression] Func<string> bodymoduleEventprocesstype = null, [WorkflowExpression] Func<string> bodymoduleEventenable = null, [WorkflowExpression] Func<int> bodymoduleisheetid = null, [WorkflowExpression] Func<string> bodymoduleisheettitle = null, [WorkflowExpression] Func<string> bodymoduleisheetdescription = null, [WorkflowExpression] Func<string> bodymoduleisheetstatus = null, [WorkflowExpression] Func<string> bodymoduleisheetaccesstype = null, [WorkflowExpression] Func<string> bodymoduleisheettype = null, [WorkflowExpression] Func<string> bodymoduleisheetviewlink = null, [WorkflowExpression] Func<string> bodymoduleisheetallowsections = null, [WorkflowExpression] Func<string> bodymoduleisheetallowlookup = null, [WorkflowExpression] Func<string> bodymoduleisheetdisplayisheet = null, [WorkflowExpression] Func<string> bodymoduleisheetsearchasdefaultview = null, [WorkflowExpression] Func<string> bodymoduleisheetenableversion = null, [WorkflowExpression] Func<string> bodymoduleisheetenablesheetalerter = null, [WorkflowExpression] Func<string> bodymoduleisheetalertercondition = null, [WorkflowExpression] Func<string> bodymoduleisheetoverrideitemmodifieddate = null, [WorkflowExpression] Func<string> bodymoduleisheetenablebulkinsertupdate = null, [WorkflowExpression] Func<string> bodymoduleisheetfielddescriptions = null, [WorkflowExpression] Func<string> bodymoduleisheetenablerowlocking = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, [WorkflowExpression] Func<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowscorelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowIsheetComments = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimit = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimitEnabled = null, [WorkflowExpression] Func<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, [WorkflowExpression] Func<string> bodymoduleisheetrecordcount = null, [WorkflowExpression] Func<int> bodymoduleisheetsheettypeid = null, [WorkflowExpression] Func<string> bodymoduleqaenable = null, [WorkflowExpression] Func<PersonDBO[]> bodymodulepeopleperson = null, [WorkflowExpression] Func<string> bodymodulecontractexpressenable = null, [WorkflowExpression] Func<string> bodyadminnote = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyenddate = null, [WorkflowExpression] Func<string> bodycreateddate = null, [WorkflowExpression] Func<string> bodyarchiveddate = null, [WorkflowExpression] Func<string> bodyclientno = null, [WorkflowExpression] Func<string> bodymatterno = null, [WorkflowExpression] Func<string> bodylandingpage = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodystatusid = null, [WorkflowExpression] Func<string> bodysize = null, [WorkflowExpression] Func<string> bodybillingnotes = null, [WorkflowExpression] Func<string> bodybillingnextinvoicedate = null, [WorkflowExpression] Func<string> bodybillinglastinvoicedate = null, [WorkflowExpression] Func<string> bodyfilepagecount = null, [WorkflowExpression] Func<string> bodymaxpagecount = null, [WorkflowExpression] Func<string> bodysitehttplink = null, [WorkflowExpression] Func<int> bodyisSyncable = null, [WorkflowExpression] Func<string> bodyenforceusergroups = null, [WorkflowExpression] Func<string> bodycsvSiteCategory = null, [WorkflowExpression] Func<string> bodysiteNameInDefaultLanguage = null, [WorkflowExpression] Func<int> bodyvisible = null, [WorkflowExpression] Func<string> bodysiteLogoName = null, [WorkflowExpression] Func<int> bodysiteLogoFileSize = null, [WorkflowExpression] Func<int> bodysiteLogoHeight = null, [WorkflowExpression] Func<int> bodysiteLogoWidth = null, [WorkflowExpression] Func<int> bodysiteStatus = null, [WorkflowExpression] Func<int> bodyapplySiteTerms = null, [WorkflowExpression] Func<string> bodysiteTerm = null, [WorkflowExpression] Func<int> bodytermType = null, [WorkflowExpression] Func<int> bodynextLoginSiteTerms = null, [WorkflowExpression] Func<int> bodydefaultSiteTermsEnable = null, [WorkflowExpression] Func<int> bodyadvancedQAPermission = null, [WorkflowExpression] Func<int> bodyisInternal = null, [WorkflowExpression] Func<int> bodypsm = null, [WorkflowExpression] Func<string> bodysiteLabelDisplay = null, [WorkflowExpression] Func<int> bodyallowSiteAdministration = null, [WorkflowExpression] Func<int> bodysiteLevelPasswordEnable = null, [WorkflowExpression] Func<int> bodysiteLevelPasscodeEnable = null, [WorkflowExpression] Func<int> bodypasscodeUsingAuthApp = null, [WorkflowExpression] Func<string> bodysitePassword = null, [WorkflowExpression] Func<int> bodyipRestrictionEnable = null, [WorkflowExpression] Func<string> bodyavailableIP = null, [WorkflowExpression] Func<int> bodyhighqDrive = null, [WorkflowExpression] Func<int> bodyapplySiteHomePage = null, [WorkflowExpression] Func<string> bodysiteHomePage = null, [WorkflowExpression] Func<int> bodysiteHomePageType = null, [WorkflowExpression] Func<int> bodynextLoginSiteHomePage = null, [WorkflowExpression] Func<int> bodyapplyDisplayContent = null, [WorkflowExpression] Func<string> bodydisplayContent = null, [WorkflowExpression] Func<int> bodyrssSecurity = null, [WorkflowExpression] Func<int> bodyencryptedPassword = null, [WorkflowExpression] Func<string> bodyavailableIPRangeCSV = null, [WorkflowExpression] Func<int> bodysiteModuleID = null, [WorkflowExpression] Func<int> bodyicalSecurity = null, [WorkflowExpression] Func<string> bodydefaultDisplayContent = null, [WorkflowExpression] Func<int> bodydefaultEmailAlert = null, [WorkflowExpression] Func<int> bodyexcelReportFooter = null, [WorkflowExpression] Func<string> bodyexcelReportFooterText = null, [WorkflowExpression] Func<string> bodyannouncementMLJSON = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<int> bodytemplateLicence = null, [WorkflowExpression] Func<string> bodyopenChannelAppID = null, [WorkflowExpression] Func<int> bodyitemid = null, [WorkflowExpression] Func<int> bodysitemetadatasheetid = null, [WorkflowExpression] Func<bool> bodymysite = null, [WorkflowExpression] Func<string> bodylastaccesseddate = null, [WorkflowExpression] Func<int> bodydefaultViewerMetaDataTab = null, [WorkflowExpression] Func<int> bodydocumentMetadataViewId = null, [WorkflowExpression] Func<int> bodyfolderMetadataViewId = null, [WorkflowExpression] Func<int> bodydocSort = null, [WorkflowExpression] Func<int> bodyfolderSort = null, [WorkflowExpression] Func<int> bodydefaultFolderRenderView = null, [WorkflowExpression] Func<int> bodyisTaskAttachmentDefault = null, [WorkflowExpression] Func<int> bodytaskAttachmentDefaultFolderId = null, [WorkflowExpression] Func<string> bodyfavourite = null, [WorkflowExpression] Func<bool> bodyenabledocumentredaction = null, [WorkflowExpression] Func<int> bodymentiongroups = null, [WorkflowExpression] Func<bool> bodyenablefilerelationships = null, [WorkflowExpression] Func<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateSite(WorkflowExpression<string> version, WorkflowExpression<string> siteid, WorkflowExpression<int> bodyid = null, WorkflowExpression<string> bodysitename = null, WorkflowExpression<string> bodyrole = null, WorkflowExpression<string> bodysitedescription = null, WorkflowExpression<string> bodyenabledmodules = null, WorkflowExpression<string> bodysitefolderID = null, WorkflowExpression<string> bodysitefolderpermission = null, WorkflowExpression<string> bodymodulehomeenable = null, WorkflowExpression<string> bodymoduleactivityenable = null, WorkflowExpression<string> bodymoduleactivitymicroblog = null, WorkflowExpression<string> bodymoduledocumentdocid = null, WorkflowExpression<string> bodymoduleblogblogTitle = null, WorkflowExpression<string> bodymoduleblogblogContent = null, WorkflowExpression<int> bodymoduleblogshowComment = null, WorkflowExpression<string[]> bodymoduleblogtagList = null, WorkflowExpression<int> bodymoduleblogstatus = null, WorkflowExpression<int> bodymoduleblogsiteID = null, WorkflowExpression<string> bodymoduleblogauthor = null, WorkflowExpression<string[]> bodymoduleblogcategoryList = null, WorkflowExpression<int> bodymoduleblognotificationTypeID = null, WorkflowExpression<string> bodymoduleblogmessage = null, WorkflowExpression<int> bodymoduleblogmessageCode = null, WorkflowExpression<string> bodymoduleblogexternalID = null, WorkflowExpression<string> bodymoduleblogpublishDate = null, WorkflowExpression<string> bodymoduleblogprocesstype = null, WorkflowExpression<string> bodymoduleblogenable = null, WorkflowExpression<int> bodymodulewikiwikiid = null, WorkflowExpression<int> bodymodulewikicurrentversionid = null, WorkflowExpression<int> bodymodulewikiparentwikiid = null, WorkflowExpression<string> bodymodulewikiwikititle = null, WorkflowExpression<string> bodymodulewikiwikicontent = null, WorkflowExpression<int> bodymodulewikishowcomment = null, WorkflowExpression<string> bodymodulewikicreateddate = null, WorkflowExpression<string> bodymodulewikimodifieddate = null, WorkflowExpression<string> bodymodulewikitaglist = null, WorkflowExpression<string> bodymodulewikiwikipath = null, WorkflowExpression<int> bodymodulewikiwikidraftid = null, WorkflowExpression<string> bodymodulewikidrafttype = null, WorkflowExpression<int> bodymodulewikistatus = null, WorkflowExpression<int> bodymodulewikiwikiversionid = null, WorkflowExpression<string> bodymoduletaskindex = null, WorkflowExpression<int> bodymoduletaskparenttaskid = null, WorkflowExpression<int> bodymoduletasktaskid = null, WorkflowExpression<string> bodymoduletasktitle = null, WorkflowExpression<string> bodymoduletaskdescription = null, WorkflowExpression<string> bodymoduletaskduedate = null, WorkflowExpression<string> bodymoduletaskstartdate = null, WorkflowExpression<string> bodymoduletaskmattermaptaskid = null, WorkflowExpression<string> bodymoduletasktype = null, WorkflowExpression<string> bodymoduletaskdependenton = null, WorkflowExpression<string> bodymoduletaskdaysfromdependent = null, WorkflowExpression<int> bodymoduletaskignoreweekend = null, WorkflowExpression<int> bodymoduletaskduration = null, WorkflowExpression<string> bodymoduletaskresource = null, WorkflowExpression<string> bodymoduleEventeventTitle = null, WorkflowExpression<string> bodymoduleEventeventContent = null, WorkflowExpression<int> bodymoduleEventshowComment = null, WorkflowExpression<string[]> bodymoduleEventtagList = null, WorkflowExpression<int> bodymoduleEventstatus = null, WorkflowExpression<int> bodymoduleEventsiteID = null, WorkflowExpression<string> bodymoduleEventcontact = null, WorkflowExpression<string[]> bodymoduleEventcategoryList = null, WorkflowExpression<int> bodymoduleEventnotificationTypeID = null, WorkflowExpression<string> bodymoduleEventmessage = null, WorkflowExpression<int> bodymoduleEventmessageCode = null, WorkflowExpression<string> bodymoduleEventexternalID = null, WorkflowExpression<string> bodymoduleEventstartDate = null, WorkflowExpression<string> bodymoduleEventendDate = null, WorkflowExpression<string> bodymoduleEventstartTime = null, WorkflowExpression<string> bodymoduleEventendTime = null, WorkflowExpression<string> bodymoduleEventlocation = null, WorkflowExpression<string> bodymoduleEventauthor = null, WorkflowExpression<string> bodymoduleEventprocesstype = null, WorkflowExpression<string> bodymoduleEventenable = null, WorkflowExpression<int> bodymoduleisheetid = null, WorkflowExpression<string> bodymoduleisheettitle = null, WorkflowExpression<string> bodymoduleisheetdescription = null, WorkflowExpression<string> bodymoduleisheetstatus = null, WorkflowExpression<string> bodymoduleisheetaccesstype = null, WorkflowExpression<string> bodymoduleisheettype = null, WorkflowExpression<string> bodymoduleisheetviewlink = null, WorkflowExpression<string> bodymoduleisheetallowsections = null, WorkflowExpression<string> bodymoduleisheetallowlookup = null, WorkflowExpression<string> bodymoduleisheetdisplayisheet = null, WorkflowExpression<string> bodymoduleisheetsearchasdefaultview = null, WorkflowExpression<string> bodymoduleisheetenableversion = null, WorkflowExpression<string> bodymoduleisheetenablesheetalerter = null, WorkflowExpression<string> bodymoduleisheetalertercondition = null, WorkflowExpression<string> bodymoduleisheetoverrideitemmodifieddate = null, WorkflowExpression<string> bodymoduleisheetenablebulkinsertupdate = null, WorkflowExpression<string> bodymoduleisheetfielddescriptions = null, WorkflowExpression<string> bodymoduleisheetenablerowlocking = null, WorkflowExpression<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, WorkflowExpression<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, WorkflowExpression<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, WorkflowExpression<string> bodymoduleisheetallowscorelistvaluesforreuse = null, WorkflowExpression<string> bodymoduleisheetallowIsheetComments = null, WorkflowExpression<int> bodymoduleisheetshareRecordsLimit = null, WorkflowExpression<int> bodymoduleisheetshareRecordsLimitEnabled = null, WorkflowExpression<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, WorkflowExpression<string> bodymoduleisheetrecordcount = null, WorkflowExpression<int> bodymoduleisheetsheettypeid = null, WorkflowExpression<string> bodymoduleqaenable = null, WorkflowExpression<PersonDBO[]> bodymodulepeopleperson = null, WorkflowExpression<string> bodymodulecontractexpressenable = null, WorkflowExpression<string> bodyadminnote = null, WorkflowExpression<string> bodystartdate = null, WorkflowExpression<string> bodyenddate = null, WorkflowExpression<string> bodycreateddate = null, WorkflowExpression<string> bodyarchiveddate = null, WorkflowExpression<string> bodyclientno = null, WorkflowExpression<string> bodymatterno = null, WorkflowExpression<string> bodylandingpage = null, WorkflowExpression<string> bodylink = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<int> bodystatusid = null, WorkflowExpression<string> bodysize = null, WorkflowExpression<string> bodybillingnotes = null, WorkflowExpression<string> bodybillingnextinvoicedate = null, WorkflowExpression<string> bodybillinglastinvoicedate = null, WorkflowExpression<string> bodyfilepagecount = null, WorkflowExpression<string> bodymaxpagecount = null, WorkflowExpression<string> bodysitehttplink = null, WorkflowExpression<int> bodyisSyncable = null, WorkflowExpression<string> bodyenforceusergroups = null, WorkflowExpression<string> bodycsvSiteCategory = null, WorkflowExpression<string> bodysiteNameInDefaultLanguage = null, WorkflowExpression<int> bodyvisible = null, WorkflowExpression<string> bodysiteLogoName = null, WorkflowExpression<int> bodysiteLogoFileSize = null, WorkflowExpression<int> bodysiteLogoHeight = null, WorkflowExpression<int> bodysiteLogoWidth = null, WorkflowExpression<int> bodysiteStatus = null, WorkflowExpression<int> bodyapplySiteTerms = null, WorkflowExpression<string> bodysiteTerm = null, WorkflowExpression<int> bodytermType = null, WorkflowExpression<int> bodynextLoginSiteTerms = null, WorkflowExpression<int> bodydefaultSiteTermsEnable = null, WorkflowExpression<int> bodyadvancedQAPermission = null, WorkflowExpression<int> bodyisInternal = null, WorkflowExpression<int> bodypsm = null, WorkflowExpression<string> bodysiteLabelDisplay = null, WorkflowExpression<int> bodyallowSiteAdministration = null, WorkflowExpression<int> bodysiteLevelPasswordEnable = null, WorkflowExpression<int> bodysiteLevelPasscodeEnable = null, WorkflowExpression<int> bodypasscodeUsingAuthApp = null, WorkflowExpression<string> bodysitePassword = null, WorkflowExpression<int> bodyipRestrictionEnable = null, WorkflowExpression<string> bodyavailableIP = null, WorkflowExpression<int> bodyhighqDrive = null, WorkflowExpression<int> bodyapplySiteHomePage = null, WorkflowExpression<string> bodysiteHomePage = null, WorkflowExpression<int> bodysiteHomePageType = null, WorkflowExpression<int> bodynextLoginSiteHomePage = null, WorkflowExpression<int> bodyapplyDisplayContent = null, WorkflowExpression<string> bodydisplayContent = null, WorkflowExpression<int> bodyrssSecurity = null, WorkflowExpression<int> bodyencryptedPassword = null, WorkflowExpression<string> bodyavailableIPRangeCSV = null, WorkflowExpression<int> bodysiteModuleID = null, WorkflowExpression<int> bodyicalSecurity = null, WorkflowExpression<string> bodydefaultDisplayContent = null, WorkflowExpression<int> bodydefaultEmailAlert = null, WorkflowExpression<int> bodyexcelReportFooter = null, WorkflowExpression<string> bodyexcelReportFooterText = null, WorkflowExpression<string> bodyannouncementMLJSON = null, WorkflowExpression<int> bodytemplateType = null, WorkflowExpression<int> bodytemplateLicence = null, WorkflowExpression<string> bodyopenChannelAppID = null, WorkflowExpression<int> bodyitemid = null, WorkflowExpression<int> bodysitemetadatasheetid = null, WorkflowExpression<bool> bodymysite = null, WorkflowExpression<string> bodylastaccesseddate = null, WorkflowExpression<int> bodydefaultViewerMetaDataTab = null, WorkflowExpression<int> bodydocumentMetadataViewId = null, WorkflowExpression<int> bodyfolderMetadataViewId = null, WorkflowExpression<int> bodydocSort = null, WorkflowExpression<int> bodyfolderSort = null, WorkflowExpression<int> bodydefaultFolderRenderView = null, WorkflowExpression<int> bodyisTaskAttachmentDefault = null, WorkflowExpression<int> bodytaskAttachmentDefaultFolderId = null, WorkflowExpression<string> bodyfavourite = null, WorkflowExpression<bool> bodyenabledocumentredaction = null, WorkflowExpression<int> bodymentiongroups = null, WorkflowExpression<bool> bodyenablefilerelationships = null, WorkflowExpression<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(siteid, nameof(siteid), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodysitename, nameof(bodysitename), required: false);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodysitedescription, nameof(bodysitedescription), required: false);
            WorkflowExpression.Validate(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            WorkflowExpression.Validate(bodysitefolderID, nameof(bodysitefolderID), required: false);
            WorkflowExpression.Validate(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            WorkflowExpression.Validate(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            WorkflowExpression.Validate(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            WorkflowExpression.Validate(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            WorkflowExpression.Validate(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            WorkflowExpression.Validate(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            WorkflowExpression.Validate(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            WorkflowExpression.Validate(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            WorkflowExpression.Validate(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            WorkflowExpression.Validate(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            WorkflowExpression.Validate(bodymoduleblogsiteID, nameof(bodymoduleblogsiteID), required: false);
            WorkflowExpression.Validate(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            WorkflowExpression.Validate(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            WorkflowExpression.Validate(bodymoduleblognotificationTypeID, nameof(bodymoduleblognotificationTypeID), required: false);
            WorkflowExpression.Validate(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            WorkflowExpression.Validate(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            WorkflowExpression.Validate(bodymoduleblogexternalID, nameof(bodymoduleblogexternalID), required: false);
            WorkflowExpression.Validate(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            WorkflowExpression.Validate(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            WorkflowExpression.Validate(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            WorkflowExpression.Validate(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            WorkflowExpression.Validate(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            WorkflowExpression.Validate(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            WorkflowExpression.Validate(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            WorkflowExpression.Validate(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            WorkflowExpression.Validate(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            WorkflowExpression.Validate(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            WorkflowExpression.Validate(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            WorkflowExpression.Validate(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            WorkflowExpression.Validate(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            WorkflowExpression.Validate(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            WorkflowExpression.Validate(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            WorkflowExpression.Validate(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            WorkflowExpression.Validate(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            WorkflowExpression.Validate(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            WorkflowExpression.Validate(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            WorkflowExpression.Validate(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            WorkflowExpression.Validate(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            WorkflowExpression.Validate(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            WorkflowExpression.Validate(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            WorkflowExpression.Validate(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            WorkflowExpression.Validate(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            WorkflowExpression.Validate(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            WorkflowExpression.Validate(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            WorkflowExpression.Validate(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            WorkflowExpression.Validate(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            WorkflowExpression.Validate(bodymoduleEventsiteID, nameof(bodymoduleEventsiteID), required: false);
            WorkflowExpression.Validate(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            WorkflowExpression.Validate(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            WorkflowExpression.Validate(bodymoduleEventnotificationTypeID, nameof(bodymoduleEventnotificationTypeID), required: false);
            WorkflowExpression.Validate(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            WorkflowExpression.Validate(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            WorkflowExpression.Validate(bodymoduleEventexternalID, nameof(bodymoduleEventexternalID), required: false);
            WorkflowExpression.Validate(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            WorkflowExpression.Validate(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            WorkflowExpression.Validate(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            WorkflowExpression.Validate(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            WorkflowExpression.Validate(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            WorkflowExpression.Validate(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            WorkflowExpression.Validate(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            WorkflowExpression.Validate(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            WorkflowExpression.Validate(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            WorkflowExpression.Validate(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            WorkflowExpression.Validate(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            WorkflowExpression.Validate(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            WorkflowExpression.Validate(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            WorkflowExpression.Validate(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            WorkflowExpression.Validate(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            WorkflowExpression.Validate(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            WorkflowExpression.Validate(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            WorkflowExpression.Validate(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            WorkflowExpression.Validate(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            WorkflowExpression.Validate(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            WorkflowExpression.Validate(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            WorkflowExpression.Validate(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            WorkflowExpression.Validate(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            WorkflowExpression.Validate(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            WorkflowExpression.Validate(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            WorkflowExpression.Validate(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            WorkflowExpression.Validate(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            WorkflowExpression.Validate(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            WorkflowExpression.Validate(bodyadminnote, nameof(bodyadminnote), required: false);
            WorkflowExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            WorkflowExpression.Validate(bodyenddate, nameof(bodyenddate), required: false);
            WorkflowExpression.Validate(bodycreateddate, nameof(bodycreateddate), required: false);
            WorkflowExpression.Validate(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            WorkflowExpression.Validate(bodyclientno, nameof(bodyclientno), required: false);
            WorkflowExpression.Validate(bodymatterno, nameof(bodymatterno), required: false);
            WorkflowExpression.Validate(bodylandingpage, nameof(bodylandingpage), required: false);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodystatusid, nameof(bodystatusid), required: false);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: false);
            WorkflowExpression.Validate(bodybillingnotes, nameof(bodybillingnotes), required: false);
            WorkflowExpression.Validate(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            WorkflowExpression.Validate(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            WorkflowExpression.Validate(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            WorkflowExpression.Validate(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            WorkflowExpression.Validate(bodysitehttplink, nameof(bodysitehttplink), required: false);
            WorkflowExpression.Validate(bodyisSyncable, nameof(bodyisSyncable), required: false);
            WorkflowExpression.Validate(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            WorkflowExpression.Validate(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            WorkflowExpression.Validate(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            WorkflowExpression.Validate(bodyvisible, nameof(bodyvisible), required: false);
            WorkflowExpression.Validate(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            WorkflowExpression.Validate(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            WorkflowExpression.Validate(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            WorkflowExpression.Validate(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            WorkflowExpression.Validate(bodysiteStatus, nameof(bodysiteStatus), required: false);
            WorkflowExpression.Validate(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            WorkflowExpression.Validate(bodysiteTerm, nameof(bodysiteTerm), required: false);
            WorkflowExpression.Validate(bodytermType, nameof(bodytermType), required: false);
            WorkflowExpression.Validate(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            WorkflowExpression.Validate(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            WorkflowExpression.Validate(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            WorkflowExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            WorkflowExpression.Validate(bodypsm, nameof(bodypsm), required: false);
            WorkflowExpression.Validate(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            WorkflowExpression.Validate(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            WorkflowExpression.Validate(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            WorkflowExpression.Validate(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            WorkflowExpression.Validate(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            WorkflowExpression.Validate(bodysitePassword, nameof(bodysitePassword), required: false);
            WorkflowExpression.Validate(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            WorkflowExpression.Validate(bodyavailableIP, nameof(bodyavailableIP), required: false);
            WorkflowExpression.Validate(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            WorkflowExpression.Validate(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            WorkflowExpression.Validate(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            WorkflowExpression.Validate(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            WorkflowExpression.Validate(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            WorkflowExpression.Validate(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            WorkflowExpression.Validate(bodydisplayContent, nameof(bodydisplayContent), required: false);
            WorkflowExpression.Validate(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            WorkflowExpression.Validate(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            WorkflowExpression.Validate(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            WorkflowExpression.Validate(bodysiteModuleID, nameof(bodysiteModuleID), required: false);
            WorkflowExpression.Validate(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            WorkflowExpression.Validate(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            WorkflowExpression.Validate(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            WorkflowExpression.Validate(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            WorkflowExpression.Validate(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            WorkflowExpression.Validate(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            WorkflowExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            WorkflowExpression.Validate(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            WorkflowExpression.Validate(bodyopenChannelAppID, nameof(bodyopenChannelAppID), required: false);
            WorkflowExpression.Validate(bodyitemid, nameof(bodyitemid), required: false);
            WorkflowExpression.Validate(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            WorkflowExpression.Validate(bodymysite, nameof(bodymysite), required: false);
            WorkflowExpression.Validate(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            WorkflowExpression.Validate(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            WorkflowExpression.Validate(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            WorkflowExpression.Validate(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            WorkflowExpression.Validate(bodydocSort, nameof(bodydocSort), required: false);
            WorkflowExpression.Validate(bodyfolderSort, nameof(bodyfolderSort), required: false);
            WorkflowExpression.Validate(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            WorkflowExpression.Validate(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            WorkflowExpression.Validate(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            WorkflowExpression.Validate(bodyfavourite, nameof(bodyfavourite), required: false);
            WorkflowExpression.Validate(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            WorkflowExpression.Validate(bodymentiongroups, nameof(bodymentiongroups), required: false);
            WorkflowExpression.Validate(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            WorkflowExpression.Validate(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sites/{1}", ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(siteid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodysitename != null)
                {
                    body["sitename"] = ExpressionConverter.ConvertO(bodysitename);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodysitedescription != null)
                {
                    body["sitedescription"] = ExpressionConverter.ConvertO(bodysitedescription);
                    bodypropCount++;
                }

                if (bodyenabledmodules != null)
                {
                    body["enabledmodules"] = ExpressionConverter.ConvertO(bodyenabledmodules);
                    bodypropCount++;
                }

                if (bodysitefolderID != null)
                {
                    body["sitefolderID"] = ExpressionConverter.ConvertO(bodysitefolderID);
                    bodypropCount++;
                }

                if (bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = ExpressionConverter.ConvertO(bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (bodymodulehomeenable != null)
                {
                    homeObject["enable"] = ExpressionConverter.ConvertO(bodymodulehomeenable);
                    homeObjectpropCount++;
                }

                if (homeObjectpropCount > 0)
                {
                    moduleObject["home"] = homeObject;
                    moduleObjectpropCount++;
                }

                var activityObject = new JObject();
                var activityObjectpropCount = 0;
                if (bodymoduleactivityenable != null)
                {
                    activityObject["enable"] = ExpressionConverter.ConvertO(bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = ExpressionConverter.ConvertO(bodymoduleactivitymicroblog);
                    activityObjectpropCount++;
                }

                if (activityObjectpropCount > 0)
                {
                    moduleObject["activity"] = activityObject;
                    moduleObjectpropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodymoduledocumentdocid != null)
                {
                    documentObject["docid"] = ExpressionConverter.ConvertO(bodymoduledocumentdocid);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    moduleObject["document"] = documentObject;
                    moduleObjectpropCount++;
                }

                var blogObject = new JObject();
                var blogObjectpropCount = 0;
                if (bodymoduleblogblogTitle != null)
                {
                    blogObject["blogTitle"] = ExpressionConverter.ConvertO(bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = ExpressionConverter.ConvertO(bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogstatus != null)
                {
                    blogObject["status"] = ExpressionConverter.ConvertO(bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogsiteID != null)
                {
                    blogObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleblogsiteID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogauthor != null)
                {
                    blogObject["author"] = ExpressionConverter.ConvertO(bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblognotificationTypeID != null)
                {
                    blogObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleblognotificationTypeID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessage != null)
                {
                    blogObject["message"] = ExpressionConverter.ConvertO(bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogexternalID != null)
                {
                    blogObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleblogexternalID);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = ExpressionConverter.ConvertO(bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogenable != null)
                {
                    blogObject["enable"] = ExpressionConverter.ConvertO(bodymoduleblogenable);
                    blogObjectpropCount++;
                }

                if (blogObjectpropCount > 0)
                {
                    moduleObject["blog"] = blogObject;
                    moduleObjectpropCount++;
                }

                var wikiObject = new JObject();
                var wikiObjectpropCount = 0;
                if (bodymodulewikiwikiid != null)
                {
                    wikiObject["wikiid"] = ExpressionConverter.ConvertO(bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = ExpressionConverter.ConvertO(bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = ExpressionConverter.ConvertO(bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = ExpressionConverter.ConvertO(bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = ExpressionConverter.ConvertO(bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = ExpressionConverter.ConvertO(bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = ExpressionConverter.ConvertO(bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = ExpressionConverter.ConvertO(bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = ExpressionConverter.ConvertO(bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = ExpressionConverter.ConvertO(bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = ExpressionConverter.ConvertO(bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = ExpressionConverter.ConvertO(bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikistatus != null)
                {
                    wikiObject["status"] = ExpressionConverter.ConvertO(bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = ExpressionConverter.ConvertO(bodymodulewikiwikiversionid);
                    wikiObjectpropCount++;
                }

                if (wikiObjectpropCount > 0)
                {
                    moduleObject["wiki"] = wikiObject;
                    moduleObjectpropCount++;
                }

                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (bodymoduletaskindex != null)
                {
                    taskObject["index"] = ExpressionConverter.ConvertO(bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = ExpressionConverter.ConvertO(bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = ExpressionConverter.ConvertO(bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktitle != null)
                {
                    taskObject["title"] = ExpressionConverter.ConvertO(bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdescription != null)
                {
                    taskObject["description"] = ExpressionConverter.ConvertO(bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = ExpressionConverter.ConvertO(bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = ExpressionConverter.ConvertO(bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = ExpressionConverter.ConvertO(bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktype != null)
                {
                    taskObject["type"] = ExpressionConverter.ConvertO(bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = ExpressionConverter.ConvertO(bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = ExpressionConverter.ConvertO(bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = ExpressionConverter.ConvertO(bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduration != null)
                {
                    taskObject["duration"] = ExpressionConverter.ConvertO(bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskresource != null)
                {
                    taskObject["resource"] = ExpressionConverter.ConvertO(bodymoduletaskresource);
                    taskObjectpropCount++;
                }

                if (taskObjectpropCount > 0)
                {
                    moduleObject["task"] = taskObject;
                    moduleObjectpropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (bodymoduleEventeventTitle != null)
                {
                    @eventObject["eventTitle"] = ExpressionConverter.ConvertO(bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = ExpressionConverter.ConvertO(bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = ExpressionConverter.ConvertO(bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventsiteID != null)
                {
                    @eventObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleEventsiteID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = ExpressionConverter.ConvertO(bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventnotificationTypeID != null)
                {
                    @eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleEventnotificationTypeID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = ExpressionConverter.ConvertO(bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventexternalID != null)
                {
                    @eventObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleEventexternalID);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = ExpressionConverter.ConvertO(bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = ExpressionConverter.ConvertO(bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = ExpressionConverter.ConvertO(bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = ExpressionConverter.ConvertO(bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = ExpressionConverter.ConvertO(bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = ExpressionConverter.ConvertO(bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = ExpressionConverter.ConvertO(bodymoduleEventenable);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    moduleObject["event"] = @eventObject;
                    moduleObjectpropCount++;
                }

                var isheetObject = new JObject();
                var isheetObjectpropCount = 0;
                if (bodymoduleisheetid != null)
                {
                    isheetObject["id"] = ExpressionConverter.ConvertO(bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = ExpressionConverter.ConvertO(bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = ExpressionConverter.ConvertO(bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = ExpressionConverter.ConvertO(bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = ExpressionConverter.ConvertO(bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettype != null)
                {
                    isheetObject["type"] = ExpressionConverter.ConvertO(bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = ExpressionConverter.ConvertO(bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = ExpressionConverter.ConvertO(bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = ExpressionConverter.ConvertO(bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = ExpressionConverter.ConvertO(bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = ExpressionConverter.ConvertO(bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = ExpressionConverter.ConvertO(bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = ExpressionConverter.ConvertO(bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = ExpressionConverter.ConvertO(bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = ExpressionConverter.ConvertO(bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = ExpressionConverter.ConvertO(bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = ExpressionConverter.ConvertO(bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = ExpressionConverter.ConvertO(bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = ExpressionConverter.ConvertO(bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = ExpressionConverter.ConvertO(bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = ExpressionConverter.ConvertO(bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = ExpressionConverter.ConvertO(bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = ExpressionConverter.ConvertO(bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = ExpressionConverter.ConvertO(bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = ExpressionConverter.ConvertO(bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = ExpressionConverter.ConvertO(bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = ExpressionConverter.ConvertO(bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = ExpressionConverter.ConvertO(bodymoduleisheetsheettypeid);
                    isheetObjectpropCount++;
                }

                if (isheetObjectpropCount > 0)
                {
                    moduleObject["isheet"] = isheetObject;
                    moduleObjectpropCount++;
                }

                var qaObject = new JObject();
                var qaObjectpropCount = 0;
                if (bodymoduleqaenable != null)
                {
                    qaObject["enable"] = ExpressionConverter.ConvertO(bodymoduleqaenable);
                    qaObjectpropCount++;
                }

                if (qaObjectpropCount > 0)
                {
                    moduleObject["qa"] = qaObject;
                    moduleObjectpropCount++;
                }

                var peopleObject = new JObject();
                var peopleObjectpropCount = 0;
                if (bodymodulepeopleperson != null)
                {
                    peopleObject["person"] = ExpressionConverter.ConvertO(bodymodulepeopleperson);
                    peopleObjectpropCount++;
                }

                if (peopleObjectpropCount > 0)
                {
                    moduleObject["people"] = peopleObject;
                    moduleObjectpropCount++;
                }

                var contractexpressObject = new JObject();
                var contractexpressObjectpropCount = 0;
                if (bodymodulecontractexpressenable != null)
                {
                    contractexpressObject["enable"] = ExpressionConverter.ConvertO(bodymodulecontractexpressenable);
                    contractexpressObjectpropCount++;
                }

                if (contractexpressObjectpropCount > 0)
                {
                    moduleObject["contractexpress"] = contractexpressObject;
                    moduleObjectpropCount++;
                }

                if (moduleObjectpropCount > 0)
                {
                    body["module"] = moduleObject;
                    bodypropCount++;
                }

                if (bodyadminnote != null)
                {
                    body["adminnote"] = ExpressionConverter.ConvertO(bodyadminnote);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(bodystartdate);
                    bodypropCount++;
                }

                if (bodyenddate != null)
                {
                    body["enddate"] = ExpressionConverter.ConvertO(bodyenddate);
                    bodypropCount++;
                }

                if (bodycreateddate != null)
                {
                    body["createddate"] = ExpressionConverter.ConvertO(bodycreateddate);
                    bodypropCount++;
                }

                if (bodyarchiveddate != null)
                {
                    body["archiveddate"] = ExpressionConverter.ConvertO(bodyarchiveddate);
                    bodypropCount++;
                }

                if (bodyclientno != null)
                {
                    body["clientno"] = ExpressionConverter.ConvertO(bodyclientno);
                    bodypropCount++;
                }

                if (bodymatterno != null)
                {
                    body["matterno"] = ExpressionConverter.ConvertO(bodymatterno);
                    bodypropCount++;
                }

                if (bodylandingpage != null)
                {
                    body["landingpage"] = ExpressionConverter.ConvertO(bodylandingpage);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(bodylink);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusid != null)
                {
                    body["statusid"] = ExpressionConverter.ConvertO(bodystatusid);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(bodysize);
                    bodypropCount++;
                }

                if (bodybillingnotes != null)
                {
                    body["billingnotes"] = ExpressionConverter.ConvertO(bodybillingnotes);
                    bodypropCount++;
                }

                if (bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = ExpressionConverter.ConvertO(bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = ExpressionConverter.ConvertO(bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (bodyfilepagecount != null)
                {
                    body["filepagecount"] = ExpressionConverter.ConvertO(bodyfilepagecount);
                    bodypropCount++;
                }

                if (bodymaxpagecount != null)
                {
                    body["maxpagecount"] = ExpressionConverter.ConvertO(bodymaxpagecount);
                    bodypropCount++;
                }

                if (bodysitehttplink != null)
                {
                    body["sitehttplink"] = ExpressionConverter.ConvertO(bodysitehttplink);
                    bodypropCount++;
                }

                if (bodyisSyncable != null)
                {
                    body["isSyncable"] = ExpressionConverter.ConvertO(bodyisSyncable);
                    bodypropCount++;
                }

                if (bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = ExpressionConverter.ConvertO(bodyenforceusergroups);
                    bodypropCount++;
                }

                if (bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = ExpressionConverter.ConvertO(bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = ExpressionConverter.ConvertO(bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (bodyvisible != null)
                {
                    body["visible"] = ExpressionConverter.ConvertO(bodyvisible);
                    bodypropCount++;
                }

                if (bodysiteLogoName != null)
                {
                    body["siteLogoName"] = ExpressionConverter.ConvertO(bodysiteLogoName);
                    bodypropCount++;
                }

                if (bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = ExpressionConverter.ConvertO(bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = ExpressionConverter.ConvertO(bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = ExpressionConverter.ConvertO(bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (bodysiteStatus != null)
                {
                    body["siteStatus"] = ExpressionConverter.ConvertO(bodysiteStatus);
                    bodypropCount++;
                }

                if (bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = ExpressionConverter.ConvertO(bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (bodysiteTerm != null)
                {
                    body["siteTerm"] = ExpressionConverter.ConvertO(bodysiteTerm);
                    bodypropCount++;
                }

                if (bodytermType != null)
                {
                    body["termType"] = ExpressionConverter.ConvertO(bodytermType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = ExpressionConverter.ConvertO(bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = ExpressionConverter.ConvertO(bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = ExpressionConverter.ConvertO(bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypsm != null)
                {
                    body["psm"] = ExpressionConverter.ConvertO(bodypsm);
                    bodypropCount++;
                }

                if (bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = ExpressionConverter.ConvertO(bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = ExpressionConverter.ConvertO(bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = ExpressionConverter.ConvertO(bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = ExpressionConverter.ConvertO(bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = ExpressionConverter.ConvertO(bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (bodysitePassword != null)
                {
                    body["sitePassword"] = ExpressionConverter.ConvertO(bodysitePassword);
                    bodypropCount++;
                }

                if (bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = ExpressionConverter.ConvertO(bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (bodyavailableIP != null)
                {
                    body["availableIP"] = ExpressionConverter.ConvertO(bodyavailableIP);
                    bodypropCount++;
                }

                if (bodyhighqDrive != null)
                {
                    body["highqDrive"] = ExpressionConverter.ConvertO(bodyhighqDrive);
                    bodypropCount++;
                }

                if (bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = ExpressionConverter.ConvertO(bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePage != null)
                {
                    body["siteHomePage"] = ExpressionConverter.ConvertO(bodysiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = ExpressionConverter.ConvertO(bodysiteHomePageType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = ExpressionConverter.ConvertO(bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = ExpressionConverter.ConvertO(bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (bodydisplayContent != null)
                {
                    body["displayContent"] = ExpressionConverter.ConvertO(bodydisplayContent);
                    bodypropCount++;
                }

                if (bodyrssSecurity != null)
                {
                    body["rssSecurity"] = ExpressionConverter.ConvertO(bodyrssSecurity);
                    bodypropCount++;
                }

                if (bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = ExpressionConverter.ConvertO(bodyencryptedPassword);
                    bodypropCount++;
                }

                if (bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = ExpressionConverter.ConvertO(bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (bodysiteModuleID != null)
                {
                    body["siteModuleID"] = ExpressionConverter.ConvertO(bodysiteModuleID);
                    bodypropCount++;
                }

                if (bodyicalSecurity != null)
                {
                    body["icalSecurity"] = ExpressionConverter.ConvertO(bodyicalSecurity);
                    bodypropCount++;
                }

                if (bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = ExpressionConverter.ConvertO(bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = ExpressionConverter.ConvertO(bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = ExpressionConverter.ConvertO(bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = ExpressionConverter.ConvertO(bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = ExpressionConverter.ConvertO(bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["templateType"] = ExpressionConverter.ConvertO(bodytemplateType);
                    bodypropCount++;
                }

                if (bodytemplateLicence != null)
                {
                    body["templateLicence"] = ExpressionConverter.ConvertO(bodytemplateLicence);
                    bodypropCount++;
                }

                if (bodyopenChannelAppID != null)
                {
                    body["openChannelAppID"] = ExpressionConverter.ConvertO(bodyopenChannelAppID);
                    bodypropCount++;
                }

                if (bodyitemid != null)
                {
                    body["itemid"] = ExpressionConverter.ConvertO(bodyitemid);
                    bodypropCount++;
                }

                if (bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = ExpressionConverter.ConvertO(bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (bodymysite != null)
                {
                    body["mysite"] = ExpressionConverter.ConvertO(bodymysite);
                    bodypropCount++;
                }

                if (bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = ExpressionConverter.ConvertO(bodylastaccesseddate);
                    bodypropCount++;
                }

                if (bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = ExpressionConverter.ConvertO(bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = ExpressionConverter.ConvertO(bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = ExpressionConverter.ConvertO(bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (bodydocSort != null)
                {
                    body["docSort"] = ExpressionConverter.ConvertO(bodydocSort);
                    bodypropCount++;
                }

                if (bodyfolderSort != null)
                {
                    body["folderSort"] = ExpressionConverter.ConvertO(bodyfolderSort);
                    bodypropCount++;
                }

                if (bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = ExpressionConverter.ConvertO(bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = ExpressionConverter.ConvertO(bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = ExpressionConverter.ConvertO(bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (bodyfavourite != null)
                {
                    body["favourite"] = ExpressionConverter.ConvertO(bodyfavourite);
                    bodypropCount++;
                }

                if (bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = ExpressionConverter.ConvertO(bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (bodymentiongroups != null)
                {
                    body["mentiongroups"] = ExpressionConverter.ConvertO(bodymentiongroups);
                    bodypropCount++;
                }

                if (bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = ExpressionConverter.ConvertO(bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = ExpressionConverter.ConvertO(bodyfilerelationshipsitepermissionlevel);
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

    public class HighqTriggers([ConnectionName] string connectionId)
    {
    }

    public class Site
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sitename")]
        public string Sitename { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("sitedescription")]
        public string Sitedescription { get; set; }

        [JsonProperty("enabledmodules")]
        public string Enabledmodules { get; set; }

        [JsonProperty("sitefolderID")]
        public string SitefolderID { get; set; }

        [JsonProperty("sitefolderpermission")]
        public string Sitefolderpermission { get; set; }

        [JsonProperty("module")]
        public ModuleDBO Module { get; set; }

        [JsonProperty("adminnote")]
        public string Adminnote { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }

        [JsonProperty("createddate")]
        public string Createddate { get; set; }

        [JsonProperty("archiveddate")]
        public string Archiveddate { get; set; }

        [JsonProperty("clientno")]
        public string Clientno { get; set; }

        [JsonProperty("matterno")]
        public string Matterno { get; set; }

        [JsonProperty("landingpage")]
        public string Landingpage { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusid")]
        public int Statusid { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("billingnotes")]
        public string Billingnotes { get; set; }

        [JsonProperty("billingnextinvoicedate")]
        public string Billingnextinvoicedate { get; set; }

        [JsonProperty("billinglastinvoicedate")]
        public string Billinglastinvoicedate { get; set; }

        [JsonProperty("filepagecount")]
        public string Filepagecount { get; set; }

        [JsonProperty("maxpagecount")]
        public string Maxpagecount { get; set; }

        [JsonProperty("sitehttplink")]
        public string Sitehttplink { get; set; }

        [JsonProperty("isSyncable")]
        public int IsSyncable { get; set; }

        [JsonProperty("enforceusergroups")]
        public string Enforceusergroups { get; set; }

        [JsonProperty("csvSiteCategory")]
        public string CsvSiteCategory { get; set; }

        [JsonProperty("siteNameInDefaultLanguage")]
        public string SiteNameInDefaultLanguage { get; set; }

        [JsonProperty("visible")]
        public int Visible { get; set; }

        [JsonProperty("siteLogoName")]
        public string SiteLogoName { get; set; }

        [JsonProperty("siteLogoFileSize")]
        public int SiteLogoFileSize { get; set; }

        [JsonProperty("siteLogoHeight")]
        public int SiteLogoHeight { get; set; }

        [JsonProperty("siteLogoWidth")]
        public int SiteLogoWidth { get; set; }

        [JsonProperty("siteStatus")]
        public int SiteStatus { get; set; }

        [JsonProperty("applySiteTerms")]
        public int ApplySiteTerms { get; set; }

        [JsonProperty("siteTerm")]
        public string SiteTerm { get; set; }

        [JsonProperty("termType")]
        public int TermType { get; set; }

        [JsonProperty("nextLoginSiteTerms")]
        public int NextLoginSiteTerms { get; set; }

        [JsonProperty("defaultSiteTermsEnable")]
        public int DefaultSiteTermsEnable { get; set; }

        [JsonProperty("advancedQAPermission")]
        public int AdvancedQAPermission { get; set; }

        [JsonProperty("isInternal")]
        public int IsInternal { get; set; }

        [JsonProperty("psm")]
        public int Psm { get; set; }

        [JsonProperty("siteLabelDisplay")]
        public string SiteLabelDisplay { get; set; }

        [JsonProperty("allowSiteAdministration")]
        public int AllowSiteAdministration { get; set; }

        [JsonProperty("siteLevelPasswordEnable")]
        public int SiteLevelPasswordEnable { get; set; }

        [JsonProperty("siteLevelPasscodeEnable")]
        public int SiteLevelPasscodeEnable { get; set; }

        [JsonProperty("passcodeUsingAuthApp")]
        public int PasscodeUsingAuthApp { get; set; }

        [JsonProperty("sitePassword")]
        public string SitePassword { get; set; }

        [JsonProperty("ipRestrictionEnable")]
        public int IpRestrictionEnable { get; set; }

        [JsonProperty("availableIP")]
        public string AvailableIP { get; set; }

        [JsonProperty("highqDrive")]
        public int HighqDrive { get; set; }

        [JsonProperty("applySiteHomePage")]
        public int ApplySiteHomePage { get; set; }

        [JsonProperty("siteHomePage")]
        public string SiteHomePage { get; set; }

        [JsonProperty("siteHomePageType")]
        public int SiteHomePageType { get; set; }

        [JsonProperty("nextLoginSiteHomePage")]
        public int NextLoginSiteHomePage { get; set; }

        [JsonProperty("applyDisplayContent")]
        public int ApplyDisplayContent { get; set; }

        [JsonProperty("displayContent")]
        public string DisplayContent { get; set; }

        [JsonProperty("rssSecurity")]
        public int RssSecurity { get; set; }

        [JsonProperty("encryptedPassword")]
        public int EncryptedPassword { get; set; }

        [JsonProperty("availableIPRangeCSV")]
        public string AvailableIPRangeCSV { get; set; }

        [JsonProperty("siteModuleID")]
        public int SiteModuleID { get; set; }

        [JsonProperty("icalSecurity")]
        public int IcalSecurity { get; set; }

        [JsonProperty("defaultDisplayContent")]
        public string DefaultDisplayContent { get; set; }

        [JsonProperty("defaultEmailAlert")]
        public int DefaultEmailAlert { get; set; }

        [JsonProperty("excelReportFooter")]
        public int ExcelReportFooter { get; set; }

        [JsonProperty("excelReportFooterText")]
        public string ExcelReportFooterText { get; set; }

        [JsonProperty("announcementMLJSON")]
        public string AnnouncementMLJSON { get; set; }

        [JsonProperty("templateType")]
        public int TemplateType { get; set; }

        [JsonProperty("templateLicence")]
        public int TemplateLicence { get; set; }

        [JsonProperty("openChannelAppID")]
        public string OpenChannelAppID { get; set; }

        [JsonProperty("itemid")]
        public int Itemid { get; set; }

        [JsonProperty("sitemetadatasheetid")]
        public int Sitemetadatasheetid { get; set; }

        [JsonProperty("mysite")]
        public bool Mysite { get; set; }

        [JsonProperty("lastaccesseddate")]
        public string Lastaccesseddate { get; set; }

        [JsonProperty("defaultViewerMetaDataTab")]
        public int DefaultViewerMetaDataTab { get; set; }

        [JsonProperty("documentMetadataViewId")]
        public int DocumentMetadataViewId { get; set; }

        [JsonProperty("folderMetadataViewId")]
        public int FolderMetadataViewId { get; set; }

        [JsonProperty("docSort")]
        public int DocSort { get; set; }

        [JsonProperty("folderSort")]
        public int FolderSort { get; set; }

        [JsonProperty("defaultFolderRenderView")]
        public int DefaultFolderRenderView { get; set; }

        [JsonProperty("isTaskAttachmentDefault")]
        public int IsTaskAttachmentDefault { get; set; }

        [JsonProperty("taskAttachmentDefaultFolderId")]
        public int TaskAttachmentDefaultFolderId { get; set; }

        [JsonProperty("favourite")]
        public string Favourite { get; set; }

        [JsonProperty("enabledocumentredaction")]
        public bool Enabledocumentredaction { get; set; }

        [JsonProperty("mentiongroups")]
        public int Mentiongroups { get; set; }

        [JsonProperty("enablefilerelationships")]
        public bool Enablefilerelationships { get; set; }

        [JsonProperty("filerelationshipsitepermissionlevel")]
        public int Filerelationshipsitepermissionlevel { get; set; }
    }

    public class ModuleDBO
    {
        [JsonProperty("home")]
        public HomeDBO Home { get; set; }

        [JsonProperty("activity")]
        public ActivityDBO Activity { get; set; }

        [JsonProperty("document")]
        public DocumentDBO Document { get; set; }

        [JsonProperty("blog")]
        public BlogDBO Blog { get; set; }

        [JsonProperty("wiki")]
        public WikiDBO Wiki { get; set; }

        [JsonProperty("task")]
        public TaskDBO TaskObject { get; set; }

        [JsonProperty("event")]
        public EventDBO Event { get; set; }

        [JsonProperty("isheet")]
        public ISheetDBO Isheet { get; set; }

        [JsonProperty("qa")]
        public QaDBO Qa { get; set; }

        [JsonProperty("people")]
        public PeopleDBO People { get; set; }

        [JsonProperty("contractexpress")]
        public ContractExpressDBO Contractexpress { get; set; }
    }

    public class HomeDBO
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }
    }

    public class ActivityDBO
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("microblog")]
        public string Microblog { get; set; }
    }

    public class DocumentDBO
    {
        [JsonProperty("docid")]
        public string Docid { get; set; }
    }

    public class BlogDBO
    {
        [JsonProperty("blogTitle")]
        public string BlogTitle { get; set; }

        [JsonProperty("blogContent")]
        public string BlogContent { get; set; }

        [JsonProperty("showComment")]
        public int ShowComment { get; set; }

        [JsonProperty("tagList")]
        public string[] TagList { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("siteID")]
        public int SiteID { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("categoryList")]
        public string[] CategoryList { get; set; }

        [JsonProperty("notificationTypeID")]
        public int NotificationTypeID { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageCode")]
        public int MessageCode { get; set; }

        [JsonProperty("externalID")]
        public string ExternalID { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("processtype")]
        public string Processtype { get; set; }

        [JsonProperty("enable")]
        public string Enable { get; set; }
    }

    public class WikiDBO
    {
        [JsonProperty("wikiid")]
        public int Wikiid { get; set; }

        [JsonProperty("currentversionid")]
        public int Currentversionid { get; set; }

        [JsonProperty("parentwikiid")]
        public int Parentwikiid { get; set; }

        [JsonProperty("wikititle")]
        public string Wikititle { get; set; }

        [JsonProperty("wikicontent")]
        public string Wikicontent { get; set; }

        [JsonProperty("showcomment")]
        public int Showcomment { get; set; }

        [JsonProperty("createddate")]
        public string Createddate { get; set; }

        [JsonProperty("modifieddate")]
        public string Modifieddate { get; set; }

        [JsonProperty("taglist")]
        public string Taglist { get; set; }

        [JsonProperty("wikipath")]
        public string Wikipath { get; set; }

        [JsonProperty("wikidraftid")]
        public int Wikidraftid { get; set; }

        [JsonProperty("drafttype")]
        public string Drafttype { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("wikiversionid")]
        public int Wikiversionid { get; set; }
    }

    public class TaskDBO
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("parenttaskid")]
        public int Parenttaskid { get; set; }

        [JsonProperty("taskid")]
        public int Taskid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("mattermaptaskid")]
        public string Mattermaptaskid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("dependenton")]
        public string Dependenton { get; set; }

        [JsonProperty("daysfromdependent")]
        public string Daysfromdependent { get; set; }

        [JsonProperty("ignoreweekend")]
        public int Ignoreweekend { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class EventDBO
    {
        [JsonProperty("eventTitle")]
        public string EventTitle { get; set; }

        [JsonProperty("eventContent")]
        public string EventContent { get; set; }

        [JsonProperty("showComment")]
        public int ShowComment { get; set; }

        [JsonProperty("tagList")]
        public string[] TagList { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("siteID")]
        public int SiteID { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("categoryList")]
        public string[] CategoryList { get; set; }

        [JsonProperty("notificationTypeID")]
        public int NotificationTypeID { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageCode")]
        public int MessageCode { get; set; }

        [JsonProperty("externalID")]
        public string ExternalID { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("processtype")]
        public string Processtype { get; set; }

        [JsonProperty("enable")]
        public string Enable { get; set; }
    }

    public class ISheetDBO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("accesstype")]
        public string Accesstype { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("viewlink")]
        public string Viewlink { get; set; }

        [JsonProperty("allowsections")]
        public string Allowsections { get; set; }

        [JsonProperty("allowlookup")]
        public string Allowlookup { get; set; }

        [JsonProperty("displayisheet")]
        public string Displayisheet { get; set; }

        [JsonProperty("searchasdefaultview")]
        public string Searchasdefaultview { get; set; }

        [JsonProperty("enableversion")]
        public string Enableversion { get; set; }

        [JsonProperty("enablesheetalerter")]
        public string Enablesheetalerter { get; set; }

        [JsonProperty("alertercondition")]
        public string Alertercondition { get; set; }

        [JsonProperty("overrideitemmodifieddate")]
        public string Overrideitemmodifieddate { get; set; }

        [JsonProperty("enablebulkinsertupdate")]
        public string Enablebulkinsertupdate { get; set; }

        [JsonProperty("fielddescriptions")]
        public string Fielddescriptions { get; set; }

        [JsonProperty("enablerowlocking")]
        public string Enablerowlocking { get; set; }

        [JsonProperty("setcharlimittruncatemultilinetextenabled")]
        public string Setcharlimittruncatemultilinetextenabled { get; set; }

        [JsonProperty("setcharlimittruncatemultilinetextval")]
        public string Setcharlimittruncatemultilinetextval { get; set; }

        [JsonProperty("allowchoicelistvaluesforreuse")]
        public string Allowchoicelistvaluesforreuse { get; set; }

        [JsonProperty("allowscorelistvaluesforreuse")]
        public string Allowscorelistvaluesforreuse { get; set; }

        [JsonProperty("allowIsheetComments")]
        public string AllowIsheetComments { get; set; }

        [JsonProperty("shareRecordsLimit")]
        public int ShareRecordsLimit { get; set; }

        [JsonProperty("shareRecordsLimitEnabled")]
        public int ShareRecordsLimitEnabled { get; set; }

        [JsonProperty("enableIsheetAddRecordFormSharing")]
        public string EnableIsheetAddRecordFormSharing { get; set; }

        [JsonProperty("recordcount")]
        public string Recordcount { get; set; }

        [JsonProperty("sheettypeid")]
        public int Sheettypeid { get; set; }
    }

    public class QaDBO
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }
    }

    public class PeopleDBO
    {
        [JsonProperty("person")]
        public PersonDBO[] Person { get; set; }
    }

    public class PersonDBO
    {
        [JsonProperty("userid")]
        public int Userid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("httpavatar")]
        public string Httpavatar { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("userlink")]
        public string Userlink { get; set; }

        [JsonProperty("httplink")]
        public string Httplink { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }
    }

    public class ContractExpressDBO
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Highq;

    public partial class WorkflowManagedActions
    {
        public HighqActions Highq(string connectionId) => new HighqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HighqTriggers Highq(string connectionId) => new HighqTriggers(connectionId);
    }
}