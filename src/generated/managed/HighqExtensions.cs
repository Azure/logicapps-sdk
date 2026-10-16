//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HighqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction InsertDocument(Expression<Func<string>> version, Expression<Func<object>> file, Expression<Func<string>> parentfolderid, Expression<Func<string>> filename, Expression<Func<bool>> overrideduplicate = null, Expression<Func<string>> versionnote = null, Expression<Func<string>> progressiveoperkey = null, Expression<Func<string>> dmsdatabasename = null, Expression<Func<string>> dmseditdate = null, Expression<Func<string>> dmsparentfolderid = null, Expression<Func<string>> dmsdocid = null, Expression<Func<string>> dmsversion = null, Expression<Func<string>> notification = null, Expression<Func<string>> batchid = null, Expression<Func<string>> rootfolderid = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_parentfolderid = WorkflowExpression.Compile(parentfolderid, nameof(parentfolderid), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            var __workflow_overrideduplicate = WorkflowExpression.Compile(overrideduplicate, nameof(overrideduplicate), required: false);
            var __workflow_versionnote = WorkflowExpression.Compile(versionnote, nameof(versionnote), required: false);
            var __workflow_progressiveoperkey = WorkflowExpression.Compile(progressiveoperkey, nameof(progressiveoperkey), required: false);
            var __workflow_dmsdatabasename = WorkflowExpression.Compile(dmsdatabasename, nameof(dmsdatabasename), required: false);
            var __workflow_dmseditdate = WorkflowExpression.Compile(dmseditdate, nameof(dmseditdate), required: false);
            var __workflow_dmsparentfolderid = WorkflowExpression.Compile(dmsparentfolderid, nameof(dmsparentfolderid), required: false);
            var __workflow_dmsdocid = WorkflowExpression.Compile(dmsdocid, nameof(dmsdocid), required: false);
            var __workflow_dmsversion = WorkflowExpression.Compile(dmsversion, nameof(dmsversion), required: false);
            var __workflow_notification = WorkflowExpression.Compile(notification, nameof(notification), required: false);
            var __workflow_batchid = WorkflowExpression.Compile(batchid, nameof(batchid), required: false);
            var __workflow_rootfolderid = WorkflowExpression.Compile(rootfolderid, nameof(rootfolderid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/files/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentfolderid"] = ExpressionConverter.Convert(__workflow_parentfolderid);
                if (__workflow_overrideduplicate != null)
                    callPayload.Queries["overrideduplicate"] = ExpressionConverter.Convert(__workflow_overrideduplicate);
                if (__workflow_batchid != null)
                    callPayload.Queries["batchid"] = ExpressionConverter.Convert(__workflow_batchid);
                if (__workflow_rootfolderid != null)
                    callPayload.Queries["rootfolderid"] = ExpressionConverter.Convert(__workflow_rootfolderid);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction MoveDocuments(Expression<Func<string>> version, Expression<Func<string>> targetfolder, Expression<Func<string>> fileidcsvfileidCSV = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_targetfolder = WorkflowExpression.Compile(targetfolder, nameof(targetfolder), required: true);
            var __workflow_fileidcsvfileidCSV = WorkflowExpression.Compile(fileidcsvfileidCSV, nameof(fileidcsvfileidCSV), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/files/move", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["targetfolder"] = ExpressionConverter.Convert(__workflow_targetfolder);
                var fileidcsv = new JObject();
                var fileidcsvpropCount = 0;
                if (__workflow_fileidcsvfileidCSV != null)
                {
                    fileidcsv["fileidCSV"] = ExpressionConverter.ConvertO(__workflow_fileidcsvfileidCSV);
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
        public IBodyWorkflowAction<Site> CreateSite(Expression<Func<string>> version, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodysitename = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysitedescription = null, Expression<Func<string>> bodyenabledmodules = null, Expression<Func<string>> bodysitefolderID = null, Expression<Func<string>> bodysitefolderpermission = null, Expression<Func<string>> bodymodulehomeenable = null, Expression<Func<string>> bodymoduleactivityenable = null, Expression<Func<string>> bodymoduleactivitymicroblog = null, Expression<Func<string>> bodymoduledocumentdocid = null, Expression<Func<string>> bodymoduleblogblogTitle = null, Expression<Func<string>> bodymoduleblogblogContent = null, Expression<Func<int>> bodymoduleblogshowComment = null, Expression<Func<string[]>> bodymoduleblogtagList = null, Expression<Func<int>> bodymoduleblogstatus = null, Expression<Func<int>> bodymoduleblogsiteID = null, Expression<Func<string>> bodymoduleblogauthor = null, Expression<Func<string[]>> bodymoduleblogcategoryList = null, Expression<Func<int>> bodymoduleblognotificationTypeID = null, Expression<Func<string>> bodymoduleblogmessage = null, Expression<Func<int>> bodymoduleblogmessageCode = null, Expression<Func<string>> bodymoduleblogexternalID = null, Expression<Func<string>> bodymoduleblogpublishDate = null, Expression<Func<string>> bodymoduleblogprocesstype = null, Expression<Func<string>> bodymoduleblogenable = null, Expression<Func<int>> bodymodulewikiwikiid = null, Expression<Func<int>> bodymodulewikicurrentversionid = null, Expression<Func<int>> bodymodulewikiparentwikiid = null, Expression<Func<string>> bodymodulewikiwikititle = null, Expression<Func<string>> bodymodulewikiwikicontent = null, Expression<Func<int>> bodymodulewikishowcomment = null, Expression<Func<string>> bodymodulewikicreateddate = null, Expression<Func<string>> bodymodulewikimodifieddate = null, Expression<Func<string>> bodymodulewikitaglist = null, Expression<Func<string>> bodymodulewikiwikipath = null, Expression<Func<int>> bodymodulewikiwikidraftid = null, Expression<Func<string>> bodymodulewikidrafttype = null, Expression<Func<int>> bodymodulewikistatus = null, Expression<Func<int>> bodymodulewikiwikiversionid = null, Expression<Func<string>> bodymoduletaskindex = null, Expression<Func<int>> bodymoduletaskparenttaskid = null, Expression<Func<int>> bodymoduletasktaskid = null, Expression<Func<string>> bodymoduletasktitle = null, Expression<Func<string>> bodymoduletaskdescription = null, Expression<Func<string>> bodymoduletaskduedate = null, Expression<Func<string>> bodymoduletaskstartdate = null, Expression<Func<string>> bodymoduletaskmattermaptaskid = null, Expression<Func<string>> bodymoduletasktype = null, Expression<Func<string>> bodymoduletaskdependenton = null, Expression<Func<string>> bodymoduletaskdaysfromdependent = null, Expression<Func<int>> bodymoduletaskignoreweekend = null, Expression<Func<int>> bodymoduletaskduration = null, Expression<Func<string>> bodymoduletaskresource = null, Expression<Func<string>> bodymoduleEventeventTitle = null, Expression<Func<string>> bodymoduleEventeventContent = null, Expression<Func<int>> bodymoduleEventshowComment = null, Expression<Func<string[]>> bodymoduleEventtagList = null, Expression<Func<int>> bodymoduleEventstatus = null, Expression<Func<int>> bodymoduleEventsiteID = null, Expression<Func<string>> bodymoduleEventcontact = null, Expression<Func<string[]>> bodymoduleEventcategoryList = null, Expression<Func<int>> bodymoduleEventnotificationTypeID = null, Expression<Func<string>> bodymoduleEventmessage = null, Expression<Func<int>> bodymoduleEventmessageCode = null, Expression<Func<string>> bodymoduleEventexternalID = null, Expression<Func<string>> bodymoduleEventstartDate = null, Expression<Func<string>> bodymoduleEventendDate = null, Expression<Func<string>> bodymoduleEventstartTime = null, Expression<Func<string>> bodymoduleEventendTime = null, Expression<Func<string>> bodymoduleEventlocation = null, Expression<Func<string>> bodymoduleEventauthor = null, Expression<Func<string>> bodymoduleEventprocesstype = null, Expression<Func<string>> bodymoduleEventenable = null, Expression<Func<int>> bodymoduleisheetid = null, Expression<Func<string>> bodymoduleisheettitle = null, Expression<Func<string>> bodymoduleisheetdescription = null, Expression<Func<string>> bodymoduleisheetstatus = null, Expression<Func<string>> bodymoduleisheetaccesstype = null, Expression<Func<string>> bodymoduleisheettype = null, Expression<Func<string>> bodymoduleisheetviewlink = null, Expression<Func<string>> bodymoduleisheetallowsections = null, Expression<Func<string>> bodymoduleisheetallowlookup = null, Expression<Func<string>> bodymoduleisheetdisplayisheet = null, Expression<Func<string>> bodymoduleisheetsearchasdefaultview = null, Expression<Func<string>> bodymoduleisheetenableversion = null, Expression<Func<string>> bodymoduleisheetenablesheetalerter = null, Expression<Func<string>> bodymoduleisheetalertercondition = null, Expression<Func<string>> bodymoduleisheetoverrideitemmodifieddate = null, Expression<Func<string>> bodymoduleisheetenablebulkinsertupdate = null, Expression<Func<string>> bodymoduleisheetfielddescriptions = null, Expression<Func<string>> bodymoduleisheetenablerowlocking = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, Expression<Func<string>> bodymoduleisheetallowchoicelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowscorelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowIsheetComments = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimit = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimitEnabled = null, Expression<Func<string>> bodymoduleisheetenableIsheetAddRecordFormSharing = null, Expression<Func<string>> bodymoduleisheetrecordcount = null, Expression<Func<int>> bodymoduleisheetsheettypeid = null, Expression<Func<string>> bodymoduleqaenable = null, Expression<Func<PersonDBO[]>> bodymodulepeopleperson = null, Expression<Func<string>> bodymodulecontractexpressenable = null, Expression<Func<string>> bodyadminnote = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyenddate = null, Expression<Func<string>> bodycreateddate = null, Expression<Func<string>> bodyarchiveddate = null, Expression<Func<string>> bodyclientno = null, Expression<Func<string>> bodymatterno = null, Expression<Func<string>> bodylandingpage = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodystatusid = null, Expression<Func<string>> bodysize = null, Expression<Func<string>> bodybillingnotes = null, Expression<Func<string>> bodybillingnextinvoicedate = null, Expression<Func<string>> bodybillinglastinvoicedate = null, Expression<Func<string>> bodyfilepagecount = null, Expression<Func<string>> bodymaxpagecount = null, Expression<Func<string>> bodysitehttplink = null, Expression<Func<int>> bodyisSyncable = null, Expression<Func<string>> bodyenforceusergroups = null, Expression<Func<string>> bodycsvSiteCategory = null, Expression<Func<string>> bodysiteNameInDefaultLanguage = null, Expression<Func<int>> bodyvisible = null, Expression<Func<string>> bodysiteLogoName = null, Expression<Func<int>> bodysiteLogoFileSize = null, Expression<Func<int>> bodysiteLogoHeight = null, Expression<Func<int>> bodysiteLogoWidth = null, Expression<Func<int>> bodysiteStatus = null, Expression<Func<int>> bodyapplySiteTerms = null, Expression<Func<string>> bodysiteTerm = null, Expression<Func<int>> bodytermType = null, Expression<Func<int>> bodynextLoginSiteTerms = null, Expression<Func<int>> bodydefaultSiteTermsEnable = null, Expression<Func<int>> bodyadvancedQAPermission = null, Expression<Func<int>> bodyisInternal = null, Expression<Func<int>> bodypsm = null, Expression<Func<string>> bodysiteLabelDisplay = null, Expression<Func<int>> bodyallowSiteAdministration = null, Expression<Func<int>> bodysiteLevelPasswordEnable = null, Expression<Func<int>> bodysiteLevelPasscodeEnable = null, Expression<Func<int>> bodypasscodeUsingAuthApp = null, Expression<Func<string>> bodysitePassword = null, Expression<Func<int>> bodyipRestrictionEnable = null, Expression<Func<string>> bodyavailableIP = null, Expression<Func<int>> bodyhighqDrive = null, Expression<Func<int>> bodyapplySiteHomePage = null, Expression<Func<string>> bodysiteHomePage = null, Expression<Func<int>> bodysiteHomePageType = null, Expression<Func<int>> bodynextLoginSiteHomePage = null, Expression<Func<int>> bodyapplyDisplayContent = null, Expression<Func<string>> bodydisplayContent = null, Expression<Func<int>> bodyrssSecurity = null, Expression<Func<int>> bodyencryptedPassword = null, Expression<Func<string>> bodyavailableIPRangeCSV = null, Expression<Func<int>> bodysiteModuleID = null, Expression<Func<int>> bodyicalSecurity = null, Expression<Func<string>> bodydefaultDisplayContent = null, Expression<Func<int>> bodydefaultEmailAlert = null, Expression<Func<int>> bodyexcelReportFooter = null, Expression<Func<string>> bodyexcelReportFooterText = null, Expression<Func<string>> bodyannouncementMLJSON = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<int>> bodytemplateLicence = null, Expression<Func<string>> bodyopenChannelAppID = null, Expression<Func<int>> bodyitemid = null, Expression<Func<int>> bodysitemetadatasheetid = null, Expression<Func<bool>> bodymysite = null, Expression<Func<string>> bodylastaccesseddate = null, Expression<Func<int>> bodydefaultViewerMetaDataTab = null, Expression<Func<int>> bodydocumentMetadataViewId = null, Expression<Func<int>> bodyfolderMetadataViewId = null, Expression<Func<int>> bodydocSort = null, Expression<Func<int>> bodyfolderSort = null, Expression<Func<int>> bodydefaultFolderRenderView = null, Expression<Func<int>> bodyisTaskAttachmentDefault = null, Expression<Func<int>> bodytaskAttachmentDefaultFolderId = null, Expression<Func<string>> bodyfavourite = null, Expression<Func<bool>> bodyenabledocumentredaction = null, Expression<Func<int>> bodymentiongroups = null, Expression<Func<bool>> bodyenablefilerelationships = null, Expression<Func<int>> bodyfilerelationshipsitepermissionlevel = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodysitename = WorkflowExpression.Compile(bodysitename, nameof(bodysitename), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodysitedescription = WorkflowExpression.Compile(bodysitedescription, nameof(bodysitedescription), required: false);
            var __workflow_bodyenabledmodules = WorkflowExpression.Compile(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            var __workflow_bodysitefolderID = WorkflowExpression.Compile(bodysitefolderID, nameof(bodysitefolderID), required: false);
            var __workflow_bodysitefolderpermission = WorkflowExpression.Compile(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            var __workflow_bodymodulehomeenable = WorkflowExpression.Compile(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            var __workflow_bodymoduleactivityenable = WorkflowExpression.Compile(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            var __workflow_bodymoduleactivitymicroblog = WorkflowExpression.Compile(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            var __workflow_bodymoduledocumentdocid = WorkflowExpression.Compile(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            var __workflow_bodymoduleblogblogTitle = WorkflowExpression.Compile(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            var __workflow_bodymoduleblogblogContent = WorkflowExpression.Compile(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            var __workflow_bodymoduleblogshowComment = WorkflowExpression.Compile(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            var __workflow_bodymoduleblogtagList = WorkflowExpression.Compile(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            var __workflow_bodymoduleblogstatus = WorkflowExpression.Compile(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            var __workflow_bodymoduleblogsiteID = WorkflowExpression.Compile(bodymoduleblogsiteID, nameof(bodymoduleblogsiteID), required: false);
            var __workflow_bodymoduleblogauthor = WorkflowExpression.Compile(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            var __workflow_bodymoduleblogcategoryList = WorkflowExpression.Compile(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            var __workflow_bodymoduleblognotificationTypeID = WorkflowExpression.Compile(bodymoduleblognotificationTypeID, nameof(bodymoduleblognotificationTypeID), required: false);
            var __workflow_bodymoduleblogmessage = WorkflowExpression.Compile(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            var __workflow_bodymoduleblogmessageCode = WorkflowExpression.Compile(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            var __workflow_bodymoduleblogexternalID = WorkflowExpression.Compile(bodymoduleblogexternalID, nameof(bodymoduleblogexternalID), required: false);
            var __workflow_bodymoduleblogpublishDate = WorkflowExpression.Compile(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            var __workflow_bodymoduleblogprocesstype = WorkflowExpression.Compile(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            var __workflow_bodymoduleblogenable = WorkflowExpression.Compile(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            var __workflow_bodymodulewikiwikiid = WorkflowExpression.Compile(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            var __workflow_bodymodulewikicurrentversionid = WorkflowExpression.Compile(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            var __workflow_bodymodulewikiparentwikiid = WorkflowExpression.Compile(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            var __workflow_bodymodulewikiwikititle = WorkflowExpression.Compile(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            var __workflow_bodymodulewikiwikicontent = WorkflowExpression.Compile(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            var __workflow_bodymodulewikishowcomment = WorkflowExpression.Compile(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            var __workflow_bodymodulewikicreateddate = WorkflowExpression.Compile(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            var __workflow_bodymodulewikimodifieddate = WorkflowExpression.Compile(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            var __workflow_bodymodulewikitaglist = WorkflowExpression.Compile(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            var __workflow_bodymodulewikiwikipath = WorkflowExpression.Compile(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            var __workflow_bodymodulewikiwikidraftid = WorkflowExpression.Compile(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            var __workflow_bodymodulewikidrafttype = WorkflowExpression.Compile(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            var __workflow_bodymodulewikistatus = WorkflowExpression.Compile(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            var __workflow_bodymodulewikiwikiversionid = WorkflowExpression.Compile(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            var __workflow_bodymoduletaskindex = WorkflowExpression.Compile(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            var __workflow_bodymoduletaskparenttaskid = WorkflowExpression.Compile(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            var __workflow_bodymoduletasktaskid = WorkflowExpression.Compile(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            var __workflow_bodymoduletasktitle = WorkflowExpression.Compile(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            var __workflow_bodymoduletaskdescription = WorkflowExpression.Compile(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            var __workflow_bodymoduletaskduedate = WorkflowExpression.Compile(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            var __workflow_bodymoduletaskstartdate = WorkflowExpression.Compile(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            var __workflow_bodymoduletaskmattermaptaskid = WorkflowExpression.Compile(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            var __workflow_bodymoduletasktype = WorkflowExpression.Compile(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            var __workflow_bodymoduletaskdependenton = WorkflowExpression.Compile(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            var __workflow_bodymoduletaskdaysfromdependent = WorkflowExpression.Compile(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            var __workflow_bodymoduletaskignoreweekend = WorkflowExpression.Compile(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            var __workflow_bodymoduletaskduration = WorkflowExpression.Compile(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            var __workflow_bodymoduletaskresource = WorkflowExpression.Compile(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            var __workflow_bodymoduleEventeventTitle = WorkflowExpression.Compile(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            var __workflow_bodymoduleEventeventContent = WorkflowExpression.Compile(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            var __workflow_bodymoduleEventshowComment = WorkflowExpression.Compile(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            var __workflow_bodymoduleEventtagList = WorkflowExpression.Compile(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            var __workflow_bodymoduleEventstatus = WorkflowExpression.Compile(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            var __workflow_bodymoduleEventsiteID = WorkflowExpression.Compile(bodymoduleEventsiteID, nameof(bodymoduleEventsiteID), required: false);
            var __workflow_bodymoduleEventcontact = WorkflowExpression.Compile(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            var __workflow_bodymoduleEventcategoryList = WorkflowExpression.Compile(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            var __workflow_bodymoduleEventnotificationTypeID = WorkflowExpression.Compile(bodymoduleEventnotificationTypeID, nameof(bodymoduleEventnotificationTypeID), required: false);
            var __workflow_bodymoduleEventmessage = WorkflowExpression.Compile(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            var __workflow_bodymoduleEventmessageCode = WorkflowExpression.Compile(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            var __workflow_bodymoduleEventexternalID = WorkflowExpression.Compile(bodymoduleEventexternalID, nameof(bodymoduleEventexternalID), required: false);
            var __workflow_bodymoduleEventstartDate = WorkflowExpression.Compile(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            var __workflow_bodymoduleEventendDate = WorkflowExpression.Compile(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            var __workflow_bodymoduleEventstartTime = WorkflowExpression.Compile(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            var __workflow_bodymoduleEventendTime = WorkflowExpression.Compile(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            var __workflow_bodymoduleEventlocation = WorkflowExpression.Compile(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            var __workflow_bodymoduleEventauthor = WorkflowExpression.Compile(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            var __workflow_bodymoduleEventprocesstype = WorkflowExpression.Compile(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            var __workflow_bodymoduleEventenable = WorkflowExpression.Compile(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            var __workflow_bodymoduleisheetid = WorkflowExpression.Compile(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            var __workflow_bodymoduleisheettitle = WorkflowExpression.Compile(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            var __workflow_bodymoduleisheetdescription = WorkflowExpression.Compile(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            var __workflow_bodymoduleisheetstatus = WorkflowExpression.Compile(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            var __workflow_bodymoduleisheetaccesstype = WorkflowExpression.Compile(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            var __workflow_bodymoduleisheettype = WorkflowExpression.Compile(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            var __workflow_bodymoduleisheetviewlink = WorkflowExpression.Compile(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            var __workflow_bodymoduleisheetallowsections = WorkflowExpression.Compile(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            var __workflow_bodymoduleisheetallowlookup = WorkflowExpression.Compile(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            var __workflow_bodymoduleisheetdisplayisheet = WorkflowExpression.Compile(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            var __workflow_bodymoduleisheetsearchasdefaultview = WorkflowExpression.Compile(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            var __workflow_bodymoduleisheetenableversion = WorkflowExpression.Compile(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            var __workflow_bodymoduleisheetenablesheetalerter = WorkflowExpression.Compile(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            var __workflow_bodymoduleisheetalertercondition = WorkflowExpression.Compile(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            var __workflow_bodymoduleisheetoverrideitemmodifieddate = WorkflowExpression.Compile(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            var __workflow_bodymoduleisheetenablebulkinsertupdate = WorkflowExpression.Compile(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            var __workflow_bodymoduleisheetfielddescriptions = WorkflowExpression.Compile(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            var __workflow_bodymoduleisheetenablerowlocking = WorkflowExpression.Compile(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            var __workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled = WorkflowExpression.Compile(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            var __workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval = WorkflowExpression.Compile(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            var __workflow_bodymoduleisheetallowchoicelistvaluesforreuse = WorkflowExpression.Compile(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            var __workflow_bodymoduleisheetallowscorelistvaluesforreuse = WorkflowExpression.Compile(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            var __workflow_bodymoduleisheetallowIsheetComments = WorkflowExpression.Compile(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            var __workflow_bodymoduleisheetshareRecordsLimit = WorkflowExpression.Compile(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            var __workflow_bodymoduleisheetshareRecordsLimitEnabled = WorkflowExpression.Compile(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            var __workflow_bodymoduleisheetenableIsheetAddRecordFormSharing = WorkflowExpression.Compile(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            var __workflow_bodymoduleisheetrecordcount = WorkflowExpression.Compile(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            var __workflow_bodymoduleisheetsheettypeid = WorkflowExpression.Compile(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            var __workflow_bodymoduleqaenable = WorkflowExpression.Compile(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            var __workflow_bodymodulepeopleperson = WorkflowExpression.Compile(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            var __workflow_bodymodulecontractexpressenable = WorkflowExpression.Compile(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            var __workflow_bodyadminnote = WorkflowExpression.Compile(bodyadminnote, nameof(bodyadminnote), required: false);
            var __workflow_bodystartdate = WorkflowExpression.Compile(bodystartdate, nameof(bodystartdate), required: false);
            var __workflow_bodyenddate = WorkflowExpression.Compile(bodyenddate, nameof(bodyenddate), required: false);
            var __workflow_bodycreateddate = WorkflowExpression.Compile(bodycreateddate, nameof(bodycreateddate), required: false);
            var __workflow_bodyarchiveddate = WorkflowExpression.Compile(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            var __workflow_bodyclientno = WorkflowExpression.Compile(bodyclientno, nameof(bodyclientno), required: false);
            var __workflow_bodymatterno = WorkflowExpression.Compile(bodymatterno, nameof(bodymatterno), required: false);
            var __workflow_bodylandingpage = WorkflowExpression.Compile(bodylandingpage, nameof(bodylandingpage), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodystatusid = WorkflowExpression.Compile(bodystatusid, nameof(bodystatusid), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            var __workflow_bodybillingnotes = WorkflowExpression.Compile(bodybillingnotes, nameof(bodybillingnotes), required: false);
            var __workflow_bodybillingnextinvoicedate = WorkflowExpression.Compile(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            var __workflow_bodybillinglastinvoicedate = WorkflowExpression.Compile(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            var __workflow_bodyfilepagecount = WorkflowExpression.Compile(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            var __workflow_bodymaxpagecount = WorkflowExpression.Compile(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            var __workflow_bodysitehttplink = WorkflowExpression.Compile(bodysitehttplink, nameof(bodysitehttplink), required: false);
            var __workflow_bodyisSyncable = WorkflowExpression.Compile(bodyisSyncable, nameof(bodyisSyncable), required: false);
            var __workflow_bodyenforceusergroups = WorkflowExpression.Compile(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            var __workflow_bodycsvSiteCategory = WorkflowExpression.Compile(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            var __workflow_bodysiteNameInDefaultLanguage = WorkflowExpression.Compile(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            var __workflow_bodyvisible = WorkflowExpression.Compile(bodyvisible, nameof(bodyvisible), required: false);
            var __workflow_bodysiteLogoName = WorkflowExpression.Compile(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            var __workflow_bodysiteLogoFileSize = WorkflowExpression.Compile(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            var __workflow_bodysiteLogoHeight = WorkflowExpression.Compile(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            var __workflow_bodysiteLogoWidth = WorkflowExpression.Compile(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            var __workflow_bodysiteStatus = WorkflowExpression.Compile(bodysiteStatus, nameof(bodysiteStatus), required: false);
            var __workflow_bodyapplySiteTerms = WorkflowExpression.Compile(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            var __workflow_bodysiteTerm = WorkflowExpression.Compile(bodysiteTerm, nameof(bodysiteTerm), required: false);
            var __workflow_bodytermType = WorkflowExpression.Compile(bodytermType, nameof(bodytermType), required: false);
            var __workflow_bodynextLoginSiteTerms = WorkflowExpression.Compile(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            var __workflow_bodydefaultSiteTermsEnable = WorkflowExpression.Compile(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            var __workflow_bodyadvancedQAPermission = WorkflowExpression.Compile(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            var __workflow_bodyisInternal = WorkflowExpression.Compile(bodyisInternal, nameof(bodyisInternal), required: false);
            var __workflow_bodypsm = WorkflowExpression.Compile(bodypsm, nameof(bodypsm), required: false);
            var __workflow_bodysiteLabelDisplay = WorkflowExpression.Compile(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            var __workflow_bodyallowSiteAdministration = WorkflowExpression.Compile(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            var __workflow_bodysiteLevelPasswordEnable = WorkflowExpression.Compile(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            var __workflow_bodysiteLevelPasscodeEnable = WorkflowExpression.Compile(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            var __workflow_bodypasscodeUsingAuthApp = WorkflowExpression.Compile(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            var __workflow_bodysitePassword = WorkflowExpression.Compile(bodysitePassword, nameof(bodysitePassword), required: false);
            var __workflow_bodyipRestrictionEnable = WorkflowExpression.Compile(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            var __workflow_bodyavailableIP = WorkflowExpression.Compile(bodyavailableIP, nameof(bodyavailableIP), required: false);
            var __workflow_bodyhighqDrive = WorkflowExpression.Compile(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            var __workflow_bodyapplySiteHomePage = WorkflowExpression.Compile(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            var __workflow_bodysiteHomePage = WorkflowExpression.Compile(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            var __workflow_bodysiteHomePageType = WorkflowExpression.Compile(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            var __workflow_bodynextLoginSiteHomePage = WorkflowExpression.Compile(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            var __workflow_bodyapplyDisplayContent = WorkflowExpression.Compile(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            var __workflow_bodydisplayContent = WorkflowExpression.Compile(bodydisplayContent, nameof(bodydisplayContent), required: false);
            var __workflow_bodyrssSecurity = WorkflowExpression.Compile(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            var __workflow_bodyencryptedPassword = WorkflowExpression.Compile(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            var __workflow_bodyavailableIPRangeCSV = WorkflowExpression.Compile(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            var __workflow_bodysiteModuleID = WorkflowExpression.Compile(bodysiteModuleID, nameof(bodysiteModuleID), required: false);
            var __workflow_bodyicalSecurity = WorkflowExpression.Compile(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            var __workflow_bodydefaultDisplayContent = WorkflowExpression.Compile(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            var __workflow_bodydefaultEmailAlert = WorkflowExpression.Compile(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            var __workflow_bodyexcelReportFooter = WorkflowExpression.Compile(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            var __workflow_bodyexcelReportFooterText = WorkflowExpression.Compile(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            var __workflow_bodyannouncementMLJSON = WorkflowExpression.Compile(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            var __workflow_bodytemplateType = WorkflowExpression.Compile(bodytemplateType, nameof(bodytemplateType), required: false);
            var __workflow_bodytemplateLicence = WorkflowExpression.Compile(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            var __workflow_bodyopenChannelAppID = WorkflowExpression.Compile(bodyopenChannelAppID, nameof(bodyopenChannelAppID), required: false);
            var __workflow_bodyitemid = WorkflowExpression.Compile(bodyitemid, nameof(bodyitemid), required: false);
            var __workflow_bodysitemetadatasheetid = WorkflowExpression.Compile(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            var __workflow_bodymysite = WorkflowExpression.Compile(bodymysite, nameof(bodymysite), required: false);
            var __workflow_bodylastaccesseddate = WorkflowExpression.Compile(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            var __workflow_bodydefaultViewerMetaDataTab = WorkflowExpression.Compile(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            var __workflow_bodydocumentMetadataViewId = WorkflowExpression.Compile(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            var __workflow_bodyfolderMetadataViewId = WorkflowExpression.Compile(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            var __workflow_bodydocSort = WorkflowExpression.Compile(bodydocSort, nameof(bodydocSort), required: false);
            var __workflow_bodyfolderSort = WorkflowExpression.Compile(bodyfolderSort, nameof(bodyfolderSort), required: false);
            var __workflow_bodydefaultFolderRenderView = WorkflowExpression.Compile(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            var __workflow_bodyisTaskAttachmentDefault = WorkflowExpression.Compile(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            var __workflow_bodytaskAttachmentDefaultFolderId = WorkflowExpression.Compile(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            var __workflow_bodyfavourite = WorkflowExpression.Compile(bodyfavourite, nameof(bodyfavourite), required: false);
            var __workflow_bodyenabledocumentredaction = WorkflowExpression.Compile(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            var __workflow_bodymentiongroups = WorkflowExpression.Compile(bodymentiongroups, nameof(bodymentiongroups), required: false);
            var __workflow_bodyenablefilerelationships = WorkflowExpression.Compile(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            var __workflow_bodyfilerelationshipsitepermissionlevel = WorkflowExpression.Compile(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            return new DeferredBodyAction<Site>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sites", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodysitename != null)
                {
                    body["sitename"] = ExpressionConverter.ConvertO(__workflow_bodysitename);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodysitedescription != null)
                {
                    body["sitedescription"] = ExpressionConverter.ConvertO(__workflow_bodysitedescription);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledmodules != null)
                {
                    body["enabledmodules"] = ExpressionConverter.ConvertO(__workflow_bodyenabledmodules);
                    bodypropCount++;
                }

                if (__workflow_bodysitefolderID != null)
                {
                    body["sitefolderID"] = ExpressionConverter.ConvertO(__workflow_bodysitefolderID);
                    bodypropCount++;
                }

                if (__workflow_bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = ExpressionConverter.ConvertO(__workflow_bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (__workflow_bodymodulehomeenable != null)
                {
                    homeObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymodulehomeenable);
                    homeObjectpropCount++;
                }

                if (homeObjectpropCount > 0)
                {
                    moduleObject["home"] = homeObject;
                    moduleObjectpropCount++;
                }

                var activityObject = new JObject();
                var activityObjectpropCount = 0;
                if (__workflow_bodymoduleactivityenable != null)
                {
                    activityObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (__workflow_bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = ExpressionConverter.ConvertO(__workflow_bodymoduleactivitymicroblog);
                    activityObjectpropCount++;
                }

                if (activityObjectpropCount > 0)
                {
                    moduleObject["activity"] = activityObject;
                    moduleObjectpropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodymoduledocumentdocid != null)
                {
                    documentObject["docid"] = ExpressionConverter.ConvertO(__workflow_bodymoduledocumentdocid);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    moduleObject["document"] = documentObject;
                    moduleObjectpropCount++;
                }

                var blogObject = new JObject();
                var blogObjectpropCount = 0;
                if (__workflow_bodymoduleblogblogTitle != null)
                {
                    blogObject["blogTitle"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogstatus != null)
                {
                    blogObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogsiteID != null)
                {
                    blogObject["siteID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogsiteID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogauthor != null)
                {
                    blogObject["author"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblognotificationTypeID != null)
                {
                    blogObject["notificationTypeID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblognotificationTypeID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogmessage != null)
                {
                    blogObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogexternalID != null)
                {
                    blogObject["externalID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogexternalID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogenable != null)
                {
                    blogObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogenable);
                    blogObjectpropCount++;
                }

                if (blogObjectpropCount > 0)
                {
                    moduleObject["blog"] = blogObject;
                    moduleObjectpropCount++;
                }

                var wikiObject = new JObject();
                var wikiObjectpropCount = 0;
                if (__workflow_bodymodulewikiwikiid != null)
                {
                    wikiObject["wikiid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikistatus != null)
                {
                    wikiObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikiversionid);
                    wikiObjectpropCount++;
                }

                if (wikiObjectpropCount > 0)
                {
                    moduleObject["wiki"] = wikiObject;
                    moduleObjectpropCount++;
                }

                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (__workflow_bodymoduletaskindex != null)
                {
                    taskObject["index"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktitle != null)
                {
                    taskObject["title"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdescription != null)
                {
                    taskObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktype != null)
                {
                    taskObject["type"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskduration != null)
                {
                    taskObject["duration"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskresource != null)
                {
                    taskObject["resource"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskresource);
                    taskObjectpropCount++;
                }

                if (taskObjectpropCount > 0)
                {
                    moduleObject["task"] = taskObject;
                    moduleObjectpropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (__workflow_bodymoduleEventeventTitle != null)
                {
                    @eventObject["eventTitle"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventsiteID != null)
                {
                    @eventObject["siteID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventsiteID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventnotificationTypeID != null)
                {
                    @eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventnotificationTypeID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventexternalID != null)
                {
                    @eventObject["externalID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventexternalID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventenable);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    moduleObject["event"] = @eventObject;
                    moduleObjectpropCount++;
                }

                var isheetObject = new JObject();
                var isheetObjectpropCount = 0;
                if (__workflow_bodymoduleisheetid != null)
                {
                    isheetObject["id"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheettype != null)
                {
                    isheetObject["type"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsheettypeid);
                    isheetObjectpropCount++;
                }

                if (isheetObjectpropCount > 0)
                {
                    moduleObject["isheet"] = isheetObject;
                    moduleObjectpropCount++;
                }

                var qaObject = new JObject();
                var qaObjectpropCount = 0;
                if (__workflow_bodymoduleqaenable != null)
                {
                    qaObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleqaenable);
                    qaObjectpropCount++;
                }

                if (qaObjectpropCount > 0)
                {
                    moduleObject["qa"] = qaObject;
                    moduleObjectpropCount++;
                }

                var peopleObject = new JObject();
                var peopleObjectpropCount = 0;
                if (__workflow_bodymodulepeopleperson != null)
                {
                    peopleObject["person"] = ExpressionConverter.ConvertO(__workflow_bodymodulepeopleperson);
                    peopleObjectpropCount++;
                }

                if (peopleObjectpropCount > 0)
                {
                    moduleObject["people"] = peopleObject;
                    moduleObjectpropCount++;
                }

                var contractexpressObject = new JObject();
                var contractexpressObjectpropCount = 0;
                if (__workflow_bodymodulecontractexpressenable != null)
                {
                    contractexpressObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymodulecontractexpressenable);
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

                if (__workflow_bodyadminnote != null)
                {
                    body["adminnote"] = ExpressionConverter.ConvertO(__workflow_bodyadminnote);
                    bodypropCount++;
                }

                if (__workflow_bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(__workflow_bodystartdate);
                    bodypropCount++;
                }

                if (__workflow_bodyenddate != null)
                {
                    body["enddate"] = ExpressionConverter.ConvertO(__workflow_bodyenddate);
                    bodypropCount++;
                }

                if (__workflow_bodycreateddate != null)
                {
                    body["createddate"] = ExpressionConverter.ConvertO(__workflow_bodycreateddate);
                    bodypropCount++;
                }

                if (__workflow_bodyarchiveddate != null)
                {
                    body["archiveddate"] = ExpressionConverter.ConvertO(__workflow_bodyarchiveddate);
                    bodypropCount++;
                }

                if (__workflow_bodyclientno != null)
                {
                    body["clientno"] = ExpressionConverter.ConvertO(__workflow_bodyclientno);
                    bodypropCount++;
                }

                if (__workflow_bodymatterno != null)
                {
                    body["matterno"] = ExpressionConverter.ConvertO(__workflow_bodymatterno);
                    bodypropCount++;
                }

                if (__workflow_bodylandingpage != null)
                {
                    body["landingpage"] = ExpressionConverter.ConvertO(__workflow_bodylandingpage);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodystatusid != null)
                {
                    body["statusid"] = ExpressionConverter.ConvertO(__workflow_bodystatusid);
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                    bodypropCount++;
                }

                if (__workflow_bodybillingnotes != null)
                {
                    body["billingnotes"] = ExpressionConverter.ConvertO(__workflow_bodybillingnotes);
                    bodypropCount++;
                }

                if (__workflow_bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = ExpressionConverter.ConvertO(__workflow_bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (__workflow_bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = ExpressionConverter.ConvertO(__workflow_bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (__workflow_bodyfilepagecount != null)
                {
                    body["filepagecount"] = ExpressionConverter.ConvertO(__workflow_bodyfilepagecount);
                    bodypropCount++;
                }

                if (__workflow_bodymaxpagecount != null)
                {
                    body["maxpagecount"] = ExpressionConverter.ConvertO(__workflow_bodymaxpagecount);
                    bodypropCount++;
                }

                if (__workflow_bodysitehttplink != null)
                {
                    body["sitehttplink"] = ExpressionConverter.ConvertO(__workflow_bodysitehttplink);
                    bodypropCount++;
                }

                if (__workflow_bodyisSyncable != null)
                {
                    body["isSyncable"] = ExpressionConverter.ConvertO(__workflow_bodyisSyncable);
                    bodypropCount++;
                }

                if (__workflow_bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = ExpressionConverter.ConvertO(__workflow_bodyenforceusergroups);
                    bodypropCount++;
                }

                if (__workflow_bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = ExpressionConverter.ConvertO(__workflow_bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (__workflow_bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = ExpressionConverter.ConvertO(__workflow_bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyvisible != null)
                {
                    body["visible"] = ExpressionConverter.ConvertO(__workflow_bodyvisible);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoName != null)
                {
                    body["siteLogoName"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoName);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (__workflow_bodysiteStatus != null)
                {
                    body["siteStatus"] = ExpressionConverter.ConvertO(__workflow_bodysiteStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = ExpressionConverter.ConvertO(__workflow_bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (__workflow_bodysiteTerm != null)
                {
                    body["siteTerm"] = ExpressionConverter.ConvertO(__workflow_bodysiteTerm);
                    bodypropCount++;
                }

                if (__workflow_bodytermType != null)
                {
                    body["termType"] = ExpressionConverter.ConvertO(__workflow_bodytermType);
                    bodypropCount++;
                }

                if (__workflow_bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = ExpressionConverter.ConvertO(__workflow_bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (__workflow_bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (__workflow_bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(__workflow_bodyisInternal);
                    bodypropCount++;
                }

                if (__workflow_bodypsm != null)
                {
                    body["psm"] = ExpressionConverter.ConvertO(__workflow_bodypsm);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = ExpressionConverter.ConvertO(__workflow_bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = ExpressionConverter.ConvertO(__workflow_bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = ExpressionConverter.ConvertO(__workflow_bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = ExpressionConverter.ConvertO(__workflow_bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (__workflow_bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = ExpressionConverter.ConvertO(__workflow_bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (__workflow_bodysitePassword != null)
                {
                    body["sitePassword"] = ExpressionConverter.ConvertO(__workflow_bodysitePassword);
                    bodypropCount++;
                }

                if (__workflow_bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = ExpressionConverter.ConvertO(__workflow_bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableIP != null)
                {
                    body["availableIP"] = ExpressionConverter.ConvertO(__workflow_bodyavailableIP);
                    bodypropCount++;
                }

                if (__workflow_bodyhighqDrive != null)
                {
                    body["highqDrive"] = ExpressionConverter.ConvertO(__workflow_bodyhighqDrive);
                    bodypropCount++;
                }

                if (__workflow_bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodysiteHomePage != null)
                {
                    body["siteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodysiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = ExpressionConverter.ConvertO(__workflow_bodysiteHomePageType);
                    bodypropCount++;
                }

                if (__workflow_bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = ExpressionConverter.ConvertO(__workflow_bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayContent != null)
                {
                    body["displayContent"] = ExpressionConverter.ConvertO(__workflow_bodydisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrssSecurity != null)
                {
                    body["rssSecurity"] = ExpressionConverter.ConvertO(__workflow_bodyrssSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = ExpressionConverter.ConvertO(__workflow_bodyencryptedPassword);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = ExpressionConverter.ConvertO(__workflow_bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (__workflow_bodysiteModuleID != null)
                {
                    body["siteModuleID"] = ExpressionConverter.ConvertO(__workflow_bodysiteModuleID);
                    bodypropCount++;
                }

                if (__workflow_bodyicalSecurity != null)
                {
                    body["icalSecurity"] = ExpressionConverter.ConvertO(__workflow_bodyicalSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = ExpressionConverter.ConvertO(__workflow_bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = ExpressionConverter.ConvertO(__workflow_bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (__workflow_bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = ExpressionConverter.ConvertO(__workflow_bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = ExpressionConverter.ConvertO(__workflow_bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (__workflow_bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = ExpressionConverter.ConvertO(__workflow_bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateType != null)
                {
                    body["templateType"] = ExpressionConverter.ConvertO(__workflow_bodytemplateType);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateLicence != null)
                {
                    body["templateLicence"] = ExpressionConverter.ConvertO(__workflow_bodytemplateLicence);
                    bodypropCount++;
                }

                if (__workflow_bodyopenChannelAppID != null)
                {
                    body["openChannelAppID"] = ExpressionConverter.ConvertO(__workflow_bodyopenChannelAppID);
                    bodypropCount++;
                }

                if (__workflow_bodyitemid != null)
                {
                    body["itemid"] = ExpressionConverter.ConvertO(__workflow_bodyitemid);
                    bodypropCount++;
                }

                if (__workflow_bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = ExpressionConverter.ConvertO(__workflow_bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (__workflow_bodymysite != null)
                {
                    body["mysite"] = ExpressionConverter.ConvertO(__workflow_bodymysite);
                    bodypropCount++;
                }

                if (__workflow_bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = ExpressionConverter.ConvertO(__workflow_bodylastaccesseddate);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = ExpressionConverter.ConvertO(__workflow_bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (__workflow_bodydocSort != null)
                {
                    body["docSort"] = ExpressionConverter.ConvertO(__workflow_bodydocSort);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderSort != null)
                {
                    body["folderSort"] = ExpressionConverter.ConvertO(__workflow_bodyfolderSort);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = ExpressionConverter.ConvertO(__workflow_bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = ExpressionConverter.ConvertO(__workflow_bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (__workflow_bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = ExpressionConverter.ConvertO(__workflow_bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyfavourite != null)
                {
                    body["favourite"] = ExpressionConverter.ConvertO(__workflow_bodyfavourite);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = ExpressionConverter.ConvertO(__workflow_bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (__workflow_bodymentiongroups != null)
                {
                    body["mentiongroups"] = ExpressionConverter.ConvertO(__workflow_bodymentiongroups);
                    bodypropCount++;
                }

                if (__workflow_bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = ExpressionConverter.ConvertO(__workflow_bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (__workflow_bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = ExpressionConverter.ConvertO(__workflow_bodyfilerelationshipsitepermissionlevel);
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
        public IWorkflowAction UpdateSite(Expression<Func<string>> version, Expression<Func<string>> siteid, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodysitename = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysitedescription = null, Expression<Func<string>> bodyenabledmodules = null, Expression<Func<string>> bodysitefolderID = null, Expression<Func<string>> bodysitefolderpermission = null, Expression<Func<string>> bodymodulehomeenable = null, Expression<Func<string>> bodymoduleactivityenable = null, Expression<Func<string>> bodymoduleactivitymicroblog = null, Expression<Func<string>> bodymoduledocumentdocid = null, Expression<Func<string>> bodymoduleblogblogTitle = null, Expression<Func<string>> bodymoduleblogblogContent = null, Expression<Func<int>> bodymoduleblogshowComment = null, Expression<Func<string[]>> bodymoduleblogtagList = null, Expression<Func<int>> bodymoduleblogstatus = null, Expression<Func<int>> bodymoduleblogsiteID = null, Expression<Func<string>> bodymoduleblogauthor = null, Expression<Func<string[]>> bodymoduleblogcategoryList = null, Expression<Func<int>> bodymoduleblognotificationTypeID = null, Expression<Func<string>> bodymoduleblogmessage = null, Expression<Func<int>> bodymoduleblogmessageCode = null, Expression<Func<string>> bodymoduleblogexternalID = null, Expression<Func<string>> bodymoduleblogpublishDate = null, Expression<Func<string>> bodymoduleblogprocesstype = null, Expression<Func<string>> bodymoduleblogenable = null, Expression<Func<int>> bodymodulewikiwikiid = null, Expression<Func<int>> bodymodulewikicurrentversionid = null, Expression<Func<int>> bodymodulewikiparentwikiid = null, Expression<Func<string>> bodymodulewikiwikititle = null, Expression<Func<string>> bodymodulewikiwikicontent = null, Expression<Func<int>> bodymodulewikishowcomment = null, Expression<Func<string>> bodymodulewikicreateddate = null, Expression<Func<string>> bodymodulewikimodifieddate = null, Expression<Func<string>> bodymodulewikitaglist = null, Expression<Func<string>> bodymodulewikiwikipath = null, Expression<Func<int>> bodymodulewikiwikidraftid = null, Expression<Func<string>> bodymodulewikidrafttype = null, Expression<Func<int>> bodymodulewikistatus = null, Expression<Func<int>> bodymodulewikiwikiversionid = null, Expression<Func<string>> bodymoduletaskindex = null, Expression<Func<int>> bodymoduletaskparenttaskid = null, Expression<Func<int>> bodymoduletasktaskid = null, Expression<Func<string>> bodymoduletasktitle = null, Expression<Func<string>> bodymoduletaskdescription = null, Expression<Func<string>> bodymoduletaskduedate = null, Expression<Func<string>> bodymoduletaskstartdate = null, Expression<Func<string>> bodymoduletaskmattermaptaskid = null, Expression<Func<string>> bodymoduletasktype = null, Expression<Func<string>> bodymoduletaskdependenton = null, Expression<Func<string>> bodymoduletaskdaysfromdependent = null, Expression<Func<int>> bodymoduletaskignoreweekend = null, Expression<Func<int>> bodymoduletaskduration = null, Expression<Func<string>> bodymoduletaskresource = null, Expression<Func<string>> bodymoduleEventeventTitle = null, Expression<Func<string>> bodymoduleEventeventContent = null, Expression<Func<int>> bodymoduleEventshowComment = null, Expression<Func<string[]>> bodymoduleEventtagList = null, Expression<Func<int>> bodymoduleEventstatus = null, Expression<Func<int>> bodymoduleEventsiteID = null, Expression<Func<string>> bodymoduleEventcontact = null, Expression<Func<string[]>> bodymoduleEventcategoryList = null, Expression<Func<int>> bodymoduleEventnotificationTypeID = null, Expression<Func<string>> bodymoduleEventmessage = null, Expression<Func<int>> bodymoduleEventmessageCode = null, Expression<Func<string>> bodymoduleEventexternalID = null, Expression<Func<string>> bodymoduleEventstartDate = null, Expression<Func<string>> bodymoduleEventendDate = null, Expression<Func<string>> bodymoduleEventstartTime = null, Expression<Func<string>> bodymoduleEventendTime = null, Expression<Func<string>> bodymoduleEventlocation = null, Expression<Func<string>> bodymoduleEventauthor = null, Expression<Func<string>> bodymoduleEventprocesstype = null, Expression<Func<string>> bodymoduleEventenable = null, Expression<Func<int>> bodymoduleisheetid = null, Expression<Func<string>> bodymoduleisheettitle = null, Expression<Func<string>> bodymoduleisheetdescription = null, Expression<Func<string>> bodymoduleisheetstatus = null, Expression<Func<string>> bodymoduleisheetaccesstype = null, Expression<Func<string>> bodymoduleisheettype = null, Expression<Func<string>> bodymoduleisheetviewlink = null, Expression<Func<string>> bodymoduleisheetallowsections = null, Expression<Func<string>> bodymoduleisheetallowlookup = null, Expression<Func<string>> bodymoduleisheetdisplayisheet = null, Expression<Func<string>> bodymoduleisheetsearchasdefaultview = null, Expression<Func<string>> bodymoduleisheetenableversion = null, Expression<Func<string>> bodymoduleisheetenablesheetalerter = null, Expression<Func<string>> bodymoduleisheetalertercondition = null, Expression<Func<string>> bodymoduleisheetoverrideitemmodifieddate = null, Expression<Func<string>> bodymoduleisheetenablebulkinsertupdate = null, Expression<Func<string>> bodymoduleisheetfielddescriptions = null, Expression<Func<string>> bodymoduleisheetenablerowlocking = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, Expression<Func<string>> bodymoduleisheetallowchoicelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowscorelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowIsheetComments = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimit = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimitEnabled = null, Expression<Func<string>> bodymoduleisheetenableIsheetAddRecordFormSharing = null, Expression<Func<string>> bodymoduleisheetrecordcount = null, Expression<Func<int>> bodymoduleisheetsheettypeid = null, Expression<Func<string>> bodymoduleqaenable = null, Expression<Func<PersonDBO[]>> bodymodulepeopleperson = null, Expression<Func<string>> bodymodulecontractexpressenable = null, Expression<Func<string>> bodyadminnote = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyenddate = null, Expression<Func<string>> bodycreateddate = null, Expression<Func<string>> bodyarchiveddate = null, Expression<Func<string>> bodyclientno = null, Expression<Func<string>> bodymatterno = null, Expression<Func<string>> bodylandingpage = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodystatusid = null, Expression<Func<string>> bodysize = null, Expression<Func<string>> bodybillingnotes = null, Expression<Func<string>> bodybillingnextinvoicedate = null, Expression<Func<string>> bodybillinglastinvoicedate = null, Expression<Func<string>> bodyfilepagecount = null, Expression<Func<string>> bodymaxpagecount = null, Expression<Func<string>> bodysitehttplink = null, Expression<Func<int>> bodyisSyncable = null, Expression<Func<string>> bodyenforceusergroups = null, Expression<Func<string>> bodycsvSiteCategory = null, Expression<Func<string>> bodysiteNameInDefaultLanguage = null, Expression<Func<int>> bodyvisible = null, Expression<Func<string>> bodysiteLogoName = null, Expression<Func<int>> bodysiteLogoFileSize = null, Expression<Func<int>> bodysiteLogoHeight = null, Expression<Func<int>> bodysiteLogoWidth = null, Expression<Func<int>> bodysiteStatus = null, Expression<Func<int>> bodyapplySiteTerms = null, Expression<Func<string>> bodysiteTerm = null, Expression<Func<int>> bodytermType = null, Expression<Func<int>> bodynextLoginSiteTerms = null, Expression<Func<int>> bodydefaultSiteTermsEnable = null, Expression<Func<int>> bodyadvancedQAPermission = null, Expression<Func<int>> bodyisInternal = null, Expression<Func<int>> bodypsm = null, Expression<Func<string>> bodysiteLabelDisplay = null, Expression<Func<int>> bodyallowSiteAdministration = null, Expression<Func<int>> bodysiteLevelPasswordEnable = null, Expression<Func<int>> bodysiteLevelPasscodeEnable = null, Expression<Func<int>> bodypasscodeUsingAuthApp = null, Expression<Func<string>> bodysitePassword = null, Expression<Func<int>> bodyipRestrictionEnable = null, Expression<Func<string>> bodyavailableIP = null, Expression<Func<int>> bodyhighqDrive = null, Expression<Func<int>> bodyapplySiteHomePage = null, Expression<Func<string>> bodysiteHomePage = null, Expression<Func<int>> bodysiteHomePageType = null, Expression<Func<int>> bodynextLoginSiteHomePage = null, Expression<Func<int>> bodyapplyDisplayContent = null, Expression<Func<string>> bodydisplayContent = null, Expression<Func<int>> bodyrssSecurity = null, Expression<Func<int>> bodyencryptedPassword = null, Expression<Func<string>> bodyavailableIPRangeCSV = null, Expression<Func<int>> bodysiteModuleID = null, Expression<Func<int>> bodyicalSecurity = null, Expression<Func<string>> bodydefaultDisplayContent = null, Expression<Func<int>> bodydefaultEmailAlert = null, Expression<Func<int>> bodyexcelReportFooter = null, Expression<Func<string>> bodyexcelReportFooterText = null, Expression<Func<string>> bodyannouncementMLJSON = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<int>> bodytemplateLicence = null, Expression<Func<string>> bodyopenChannelAppID = null, Expression<Func<int>> bodyitemid = null, Expression<Func<int>> bodysitemetadatasheetid = null, Expression<Func<bool>> bodymysite = null, Expression<Func<string>> bodylastaccesseddate = null, Expression<Func<int>> bodydefaultViewerMetaDataTab = null, Expression<Func<int>> bodydocumentMetadataViewId = null, Expression<Func<int>> bodyfolderMetadataViewId = null, Expression<Func<int>> bodydocSort = null, Expression<Func<int>> bodyfolderSort = null, Expression<Func<int>> bodydefaultFolderRenderView = null, Expression<Func<int>> bodyisTaskAttachmentDefault = null, Expression<Func<int>> bodytaskAttachmentDefaultFolderId = null, Expression<Func<string>> bodyfavourite = null, Expression<Func<bool>> bodyenabledocumentredaction = null, Expression<Func<int>> bodymentiongroups = null, Expression<Func<bool>> bodyenablefilerelationships = null, Expression<Func<int>> bodyfilerelationshipsitepermissionlevel = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_siteid = WorkflowExpression.Compile(siteid, nameof(siteid), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodysitename = WorkflowExpression.Compile(bodysitename, nameof(bodysitename), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodysitedescription = WorkflowExpression.Compile(bodysitedescription, nameof(bodysitedescription), required: false);
            var __workflow_bodyenabledmodules = WorkflowExpression.Compile(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            var __workflow_bodysitefolderID = WorkflowExpression.Compile(bodysitefolderID, nameof(bodysitefolderID), required: false);
            var __workflow_bodysitefolderpermission = WorkflowExpression.Compile(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            var __workflow_bodymodulehomeenable = WorkflowExpression.Compile(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            var __workflow_bodymoduleactivityenable = WorkflowExpression.Compile(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            var __workflow_bodymoduleactivitymicroblog = WorkflowExpression.Compile(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            var __workflow_bodymoduledocumentdocid = WorkflowExpression.Compile(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            var __workflow_bodymoduleblogblogTitle = WorkflowExpression.Compile(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            var __workflow_bodymoduleblogblogContent = WorkflowExpression.Compile(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            var __workflow_bodymoduleblogshowComment = WorkflowExpression.Compile(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            var __workflow_bodymoduleblogtagList = WorkflowExpression.Compile(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            var __workflow_bodymoduleblogstatus = WorkflowExpression.Compile(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            var __workflow_bodymoduleblogsiteID = WorkflowExpression.Compile(bodymoduleblogsiteID, nameof(bodymoduleblogsiteID), required: false);
            var __workflow_bodymoduleblogauthor = WorkflowExpression.Compile(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            var __workflow_bodymoduleblogcategoryList = WorkflowExpression.Compile(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            var __workflow_bodymoduleblognotificationTypeID = WorkflowExpression.Compile(bodymoduleblognotificationTypeID, nameof(bodymoduleblognotificationTypeID), required: false);
            var __workflow_bodymoduleblogmessage = WorkflowExpression.Compile(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            var __workflow_bodymoduleblogmessageCode = WorkflowExpression.Compile(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            var __workflow_bodymoduleblogexternalID = WorkflowExpression.Compile(bodymoduleblogexternalID, nameof(bodymoduleblogexternalID), required: false);
            var __workflow_bodymoduleblogpublishDate = WorkflowExpression.Compile(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            var __workflow_bodymoduleblogprocesstype = WorkflowExpression.Compile(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            var __workflow_bodymoduleblogenable = WorkflowExpression.Compile(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            var __workflow_bodymodulewikiwikiid = WorkflowExpression.Compile(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            var __workflow_bodymodulewikicurrentversionid = WorkflowExpression.Compile(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            var __workflow_bodymodulewikiparentwikiid = WorkflowExpression.Compile(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            var __workflow_bodymodulewikiwikititle = WorkflowExpression.Compile(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            var __workflow_bodymodulewikiwikicontent = WorkflowExpression.Compile(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            var __workflow_bodymodulewikishowcomment = WorkflowExpression.Compile(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            var __workflow_bodymodulewikicreateddate = WorkflowExpression.Compile(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            var __workflow_bodymodulewikimodifieddate = WorkflowExpression.Compile(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            var __workflow_bodymodulewikitaglist = WorkflowExpression.Compile(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            var __workflow_bodymodulewikiwikipath = WorkflowExpression.Compile(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            var __workflow_bodymodulewikiwikidraftid = WorkflowExpression.Compile(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            var __workflow_bodymodulewikidrafttype = WorkflowExpression.Compile(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            var __workflow_bodymodulewikistatus = WorkflowExpression.Compile(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            var __workflow_bodymodulewikiwikiversionid = WorkflowExpression.Compile(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            var __workflow_bodymoduletaskindex = WorkflowExpression.Compile(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            var __workflow_bodymoduletaskparenttaskid = WorkflowExpression.Compile(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            var __workflow_bodymoduletasktaskid = WorkflowExpression.Compile(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            var __workflow_bodymoduletasktitle = WorkflowExpression.Compile(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            var __workflow_bodymoduletaskdescription = WorkflowExpression.Compile(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            var __workflow_bodymoduletaskduedate = WorkflowExpression.Compile(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            var __workflow_bodymoduletaskstartdate = WorkflowExpression.Compile(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            var __workflow_bodymoduletaskmattermaptaskid = WorkflowExpression.Compile(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            var __workflow_bodymoduletasktype = WorkflowExpression.Compile(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            var __workflow_bodymoduletaskdependenton = WorkflowExpression.Compile(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            var __workflow_bodymoduletaskdaysfromdependent = WorkflowExpression.Compile(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            var __workflow_bodymoduletaskignoreweekend = WorkflowExpression.Compile(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            var __workflow_bodymoduletaskduration = WorkflowExpression.Compile(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            var __workflow_bodymoduletaskresource = WorkflowExpression.Compile(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            var __workflow_bodymoduleEventeventTitle = WorkflowExpression.Compile(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            var __workflow_bodymoduleEventeventContent = WorkflowExpression.Compile(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            var __workflow_bodymoduleEventshowComment = WorkflowExpression.Compile(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            var __workflow_bodymoduleEventtagList = WorkflowExpression.Compile(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            var __workflow_bodymoduleEventstatus = WorkflowExpression.Compile(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            var __workflow_bodymoduleEventsiteID = WorkflowExpression.Compile(bodymoduleEventsiteID, nameof(bodymoduleEventsiteID), required: false);
            var __workflow_bodymoduleEventcontact = WorkflowExpression.Compile(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            var __workflow_bodymoduleEventcategoryList = WorkflowExpression.Compile(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            var __workflow_bodymoduleEventnotificationTypeID = WorkflowExpression.Compile(bodymoduleEventnotificationTypeID, nameof(bodymoduleEventnotificationTypeID), required: false);
            var __workflow_bodymoduleEventmessage = WorkflowExpression.Compile(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            var __workflow_bodymoduleEventmessageCode = WorkflowExpression.Compile(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            var __workflow_bodymoduleEventexternalID = WorkflowExpression.Compile(bodymoduleEventexternalID, nameof(bodymoduleEventexternalID), required: false);
            var __workflow_bodymoduleEventstartDate = WorkflowExpression.Compile(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            var __workflow_bodymoduleEventendDate = WorkflowExpression.Compile(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            var __workflow_bodymoduleEventstartTime = WorkflowExpression.Compile(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            var __workflow_bodymoduleEventendTime = WorkflowExpression.Compile(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            var __workflow_bodymoduleEventlocation = WorkflowExpression.Compile(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            var __workflow_bodymoduleEventauthor = WorkflowExpression.Compile(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            var __workflow_bodymoduleEventprocesstype = WorkflowExpression.Compile(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            var __workflow_bodymoduleEventenable = WorkflowExpression.Compile(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            var __workflow_bodymoduleisheetid = WorkflowExpression.Compile(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            var __workflow_bodymoduleisheettitle = WorkflowExpression.Compile(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            var __workflow_bodymoduleisheetdescription = WorkflowExpression.Compile(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            var __workflow_bodymoduleisheetstatus = WorkflowExpression.Compile(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            var __workflow_bodymoduleisheetaccesstype = WorkflowExpression.Compile(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            var __workflow_bodymoduleisheettype = WorkflowExpression.Compile(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            var __workflow_bodymoduleisheetviewlink = WorkflowExpression.Compile(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            var __workflow_bodymoduleisheetallowsections = WorkflowExpression.Compile(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            var __workflow_bodymoduleisheetallowlookup = WorkflowExpression.Compile(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            var __workflow_bodymoduleisheetdisplayisheet = WorkflowExpression.Compile(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            var __workflow_bodymoduleisheetsearchasdefaultview = WorkflowExpression.Compile(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            var __workflow_bodymoduleisheetenableversion = WorkflowExpression.Compile(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            var __workflow_bodymoduleisheetenablesheetalerter = WorkflowExpression.Compile(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            var __workflow_bodymoduleisheetalertercondition = WorkflowExpression.Compile(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            var __workflow_bodymoduleisheetoverrideitemmodifieddate = WorkflowExpression.Compile(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            var __workflow_bodymoduleisheetenablebulkinsertupdate = WorkflowExpression.Compile(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            var __workflow_bodymoduleisheetfielddescriptions = WorkflowExpression.Compile(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            var __workflow_bodymoduleisheetenablerowlocking = WorkflowExpression.Compile(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            var __workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled = WorkflowExpression.Compile(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            var __workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval = WorkflowExpression.Compile(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            var __workflow_bodymoduleisheetallowchoicelistvaluesforreuse = WorkflowExpression.Compile(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            var __workflow_bodymoduleisheetallowscorelistvaluesforreuse = WorkflowExpression.Compile(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            var __workflow_bodymoduleisheetallowIsheetComments = WorkflowExpression.Compile(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            var __workflow_bodymoduleisheetshareRecordsLimit = WorkflowExpression.Compile(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            var __workflow_bodymoduleisheetshareRecordsLimitEnabled = WorkflowExpression.Compile(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            var __workflow_bodymoduleisheetenableIsheetAddRecordFormSharing = WorkflowExpression.Compile(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            var __workflow_bodymoduleisheetrecordcount = WorkflowExpression.Compile(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            var __workflow_bodymoduleisheetsheettypeid = WorkflowExpression.Compile(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            var __workflow_bodymoduleqaenable = WorkflowExpression.Compile(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            var __workflow_bodymodulepeopleperson = WorkflowExpression.Compile(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            var __workflow_bodymodulecontractexpressenable = WorkflowExpression.Compile(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            var __workflow_bodyadminnote = WorkflowExpression.Compile(bodyadminnote, nameof(bodyadminnote), required: false);
            var __workflow_bodystartdate = WorkflowExpression.Compile(bodystartdate, nameof(bodystartdate), required: false);
            var __workflow_bodyenddate = WorkflowExpression.Compile(bodyenddate, nameof(bodyenddate), required: false);
            var __workflow_bodycreateddate = WorkflowExpression.Compile(bodycreateddate, nameof(bodycreateddate), required: false);
            var __workflow_bodyarchiveddate = WorkflowExpression.Compile(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            var __workflow_bodyclientno = WorkflowExpression.Compile(bodyclientno, nameof(bodyclientno), required: false);
            var __workflow_bodymatterno = WorkflowExpression.Compile(bodymatterno, nameof(bodymatterno), required: false);
            var __workflow_bodylandingpage = WorkflowExpression.Compile(bodylandingpage, nameof(bodylandingpage), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodystatusid = WorkflowExpression.Compile(bodystatusid, nameof(bodystatusid), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            var __workflow_bodybillingnotes = WorkflowExpression.Compile(bodybillingnotes, nameof(bodybillingnotes), required: false);
            var __workflow_bodybillingnextinvoicedate = WorkflowExpression.Compile(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            var __workflow_bodybillinglastinvoicedate = WorkflowExpression.Compile(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            var __workflow_bodyfilepagecount = WorkflowExpression.Compile(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            var __workflow_bodymaxpagecount = WorkflowExpression.Compile(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            var __workflow_bodysitehttplink = WorkflowExpression.Compile(bodysitehttplink, nameof(bodysitehttplink), required: false);
            var __workflow_bodyisSyncable = WorkflowExpression.Compile(bodyisSyncable, nameof(bodyisSyncable), required: false);
            var __workflow_bodyenforceusergroups = WorkflowExpression.Compile(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            var __workflow_bodycsvSiteCategory = WorkflowExpression.Compile(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            var __workflow_bodysiteNameInDefaultLanguage = WorkflowExpression.Compile(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            var __workflow_bodyvisible = WorkflowExpression.Compile(bodyvisible, nameof(bodyvisible), required: false);
            var __workflow_bodysiteLogoName = WorkflowExpression.Compile(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            var __workflow_bodysiteLogoFileSize = WorkflowExpression.Compile(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            var __workflow_bodysiteLogoHeight = WorkflowExpression.Compile(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            var __workflow_bodysiteLogoWidth = WorkflowExpression.Compile(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            var __workflow_bodysiteStatus = WorkflowExpression.Compile(bodysiteStatus, nameof(bodysiteStatus), required: false);
            var __workflow_bodyapplySiteTerms = WorkflowExpression.Compile(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            var __workflow_bodysiteTerm = WorkflowExpression.Compile(bodysiteTerm, nameof(bodysiteTerm), required: false);
            var __workflow_bodytermType = WorkflowExpression.Compile(bodytermType, nameof(bodytermType), required: false);
            var __workflow_bodynextLoginSiteTerms = WorkflowExpression.Compile(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            var __workflow_bodydefaultSiteTermsEnable = WorkflowExpression.Compile(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            var __workflow_bodyadvancedQAPermission = WorkflowExpression.Compile(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            var __workflow_bodyisInternal = WorkflowExpression.Compile(bodyisInternal, nameof(bodyisInternal), required: false);
            var __workflow_bodypsm = WorkflowExpression.Compile(bodypsm, nameof(bodypsm), required: false);
            var __workflow_bodysiteLabelDisplay = WorkflowExpression.Compile(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            var __workflow_bodyallowSiteAdministration = WorkflowExpression.Compile(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            var __workflow_bodysiteLevelPasswordEnable = WorkflowExpression.Compile(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            var __workflow_bodysiteLevelPasscodeEnable = WorkflowExpression.Compile(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            var __workflow_bodypasscodeUsingAuthApp = WorkflowExpression.Compile(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            var __workflow_bodysitePassword = WorkflowExpression.Compile(bodysitePassword, nameof(bodysitePassword), required: false);
            var __workflow_bodyipRestrictionEnable = WorkflowExpression.Compile(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            var __workflow_bodyavailableIP = WorkflowExpression.Compile(bodyavailableIP, nameof(bodyavailableIP), required: false);
            var __workflow_bodyhighqDrive = WorkflowExpression.Compile(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            var __workflow_bodyapplySiteHomePage = WorkflowExpression.Compile(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            var __workflow_bodysiteHomePage = WorkflowExpression.Compile(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            var __workflow_bodysiteHomePageType = WorkflowExpression.Compile(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            var __workflow_bodynextLoginSiteHomePage = WorkflowExpression.Compile(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            var __workflow_bodyapplyDisplayContent = WorkflowExpression.Compile(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            var __workflow_bodydisplayContent = WorkflowExpression.Compile(bodydisplayContent, nameof(bodydisplayContent), required: false);
            var __workflow_bodyrssSecurity = WorkflowExpression.Compile(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            var __workflow_bodyencryptedPassword = WorkflowExpression.Compile(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            var __workflow_bodyavailableIPRangeCSV = WorkflowExpression.Compile(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            var __workflow_bodysiteModuleID = WorkflowExpression.Compile(bodysiteModuleID, nameof(bodysiteModuleID), required: false);
            var __workflow_bodyicalSecurity = WorkflowExpression.Compile(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            var __workflow_bodydefaultDisplayContent = WorkflowExpression.Compile(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            var __workflow_bodydefaultEmailAlert = WorkflowExpression.Compile(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            var __workflow_bodyexcelReportFooter = WorkflowExpression.Compile(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            var __workflow_bodyexcelReportFooterText = WorkflowExpression.Compile(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            var __workflow_bodyannouncementMLJSON = WorkflowExpression.Compile(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            var __workflow_bodytemplateType = WorkflowExpression.Compile(bodytemplateType, nameof(bodytemplateType), required: false);
            var __workflow_bodytemplateLicence = WorkflowExpression.Compile(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            var __workflow_bodyopenChannelAppID = WorkflowExpression.Compile(bodyopenChannelAppID, nameof(bodyopenChannelAppID), required: false);
            var __workflow_bodyitemid = WorkflowExpression.Compile(bodyitemid, nameof(bodyitemid), required: false);
            var __workflow_bodysitemetadatasheetid = WorkflowExpression.Compile(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            var __workflow_bodymysite = WorkflowExpression.Compile(bodymysite, nameof(bodymysite), required: false);
            var __workflow_bodylastaccesseddate = WorkflowExpression.Compile(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            var __workflow_bodydefaultViewerMetaDataTab = WorkflowExpression.Compile(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            var __workflow_bodydocumentMetadataViewId = WorkflowExpression.Compile(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            var __workflow_bodyfolderMetadataViewId = WorkflowExpression.Compile(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            var __workflow_bodydocSort = WorkflowExpression.Compile(bodydocSort, nameof(bodydocSort), required: false);
            var __workflow_bodyfolderSort = WorkflowExpression.Compile(bodyfolderSort, nameof(bodyfolderSort), required: false);
            var __workflow_bodydefaultFolderRenderView = WorkflowExpression.Compile(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            var __workflow_bodyisTaskAttachmentDefault = WorkflowExpression.Compile(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            var __workflow_bodytaskAttachmentDefaultFolderId = WorkflowExpression.Compile(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            var __workflow_bodyfavourite = WorkflowExpression.Compile(bodyfavourite, nameof(bodyfavourite), required: false);
            var __workflow_bodyenabledocumentredaction = WorkflowExpression.Compile(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            var __workflow_bodymentiongroups = WorkflowExpression.Compile(bodymentiongroups, nameof(bodymentiongroups), required: false);
            var __workflow_bodyenablefilerelationships = WorkflowExpression.Compile(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            var __workflow_bodyfilerelationshipsitepermissionlevel = WorkflowExpression.Compile(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/sites/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_siteid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodysitename != null)
                {
                    body["sitename"] = ExpressionConverter.ConvertO(__workflow_bodysitename);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodysitedescription != null)
                {
                    body["sitedescription"] = ExpressionConverter.ConvertO(__workflow_bodysitedescription);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledmodules != null)
                {
                    body["enabledmodules"] = ExpressionConverter.ConvertO(__workflow_bodyenabledmodules);
                    bodypropCount++;
                }

                if (__workflow_bodysitefolderID != null)
                {
                    body["sitefolderID"] = ExpressionConverter.ConvertO(__workflow_bodysitefolderID);
                    bodypropCount++;
                }

                if (__workflow_bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = ExpressionConverter.ConvertO(__workflow_bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (__workflow_bodymodulehomeenable != null)
                {
                    homeObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymodulehomeenable);
                    homeObjectpropCount++;
                }

                if (homeObjectpropCount > 0)
                {
                    moduleObject["home"] = homeObject;
                    moduleObjectpropCount++;
                }

                var activityObject = new JObject();
                var activityObjectpropCount = 0;
                if (__workflow_bodymoduleactivityenable != null)
                {
                    activityObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (__workflow_bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = ExpressionConverter.ConvertO(__workflow_bodymoduleactivitymicroblog);
                    activityObjectpropCount++;
                }

                if (activityObjectpropCount > 0)
                {
                    moduleObject["activity"] = activityObject;
                    moduleObjectpropCount++;
                }

                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodymoduledocumentdocid != null)
                {
                    documentObject["docid"] = ExpressionConverter.ConvertO(__workflow_bodymoduledocumentdocid);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    moduleObject["document"] = documentObject;
                    moduleObjectpropCount++;
                }

                var blogObject = new JObject();
                var blogObjectpropCount = 0;
                if (__workflow_bodymoduleblogblogTitle != null)
                {
                    blogObject["blogTitle"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogstatus != null)
                {
                    blogObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogsiteID != null)
                {
                    blogObject["siteID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogsiteID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogauthor != null)
                {
                    blogObject["author"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblognotificationTypeID != null)
                {
                    blogObject["notificationTypeID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblognotificationTypeID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogmessage != null)
                {
                    blogObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogexternalID != null)
                {
                    blogObject["externalID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogexternalID);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (__workflow_bodymoduleblogenable != null)
                {
                    blogObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleblogenable);
                    blogObjectpropCount++;
                }

                if (blogObjectpropCount > 0)
                {
                    moduleObject["blog"] = blogObject;
                    moduleObjectpropCount++;
                }

                var wikiObject = new JObject();
                var wikiObjectpropCount = 0;
                if (__workflow_bodymodulewikiwikiid != null)
                {
                    wikiObject["wikiid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikistatus != null)
                {
                    wikiObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (__workflow_bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = ExpressionConverter.ConvertO(__workflow_bodymodulewikiwikiversionid);
                    wikiObjectpropCount++;
                }

                if (wikiObjectpropCount > 0)
                {
                    moduleObject["wiki"] = wikiObject;
                    moduleObjectpropCount++;
                }

                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (__workflow_bodymoduletaskindex != null)
                {
                    taskObject["index"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktitle != null)
                {
                    taskObject["title"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdescription != null)
                {
                    taskObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletasktype != null)
                {
                    taskObject["type"] = ExpressionConverter.ConvertO(__workflow_bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskduration != null)
                {
                    taskObject["duration"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (__workflow_bodymoduletaskresource != null)
                {
                    taskObject["resource"] = ExpressionConverter.ConvertO(__workflow_bodymoduletaskresource);
                    taskObjectpropCount++;
                }

                if (taskObjectpropCount > 0)
                {
                    moduleObject["task"] = taskObject;
                    moduleObjectpropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (__workflow_bodymoduleEventeventTitle != null)
                {
                    @eventObject["eventTitle"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventsiteID != null)
                {
                    @eventObject["siteID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventsiteID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventnotificationTypeID != null)
                {
                    @eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventnotificationTypeID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventexternalID != null)
                {
                    @eventObject["externalID"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventexternalID);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleEventenable);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    moduleObject["event"] = @eventObject;
                    moduleObjectpropCount++;
                }

                var isheetObject = new JObject();
                var isheetObjectpropCount = 0;
                if (__workflow_bodymoduleisheetid != null)
                {
                    isheetObject["id"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheettype != null)
                {
                    isheetObject["type"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (__workflow_bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = ExpressionConverter.ConvertO(__workflow_bodymoduleisheetsheettypeid);
                    isheetObjectpropCount++;
                }

                if (isheetObjectpropCount > 0)
                {
                    moduleObject["isheet"] = isheetObject;
                    moduleObjectpropCount++;
                }

                var qaObject = new JObject();
                var qaObjectpropCount = 0;
                if (__workflow_bodymoduleqaenable != null)
                {
                    qaObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymoduleqaenable);
                    qaObjectpropCount++;
                }

                if (qaObjectpropCount > 0)
                {
                    moduleObject["qa"] = qaObject;
                    moduleObjectpropCount++;
                }

                var peopleObject = new JObject();
                var peopleObjectpropCount = 0;
                if (__workflow_bodymodulepeopleperson != null)
                {
                    peopleObject["person"] = ExpressionConverter.ConvertO(__workflow_bodymodulepeopleperson);
                    peopleObjectpropCount++;
                }

                if (peopleObjectpropCount > 0)
                {
                    moduleObject["people"] = peopleObject;
                    moduleObjectpropCount++;
                }

                var contractexpressObject = new JObject();
                var contractexpressObjectpropCount = 0;
                if (__workflow_bodymodulecontractexpressenable != null)
                {
                    contractexpressObject["enable"] = ExpressionConverter.ConvertO(__workflow_bodymodulecontractexpressenable);
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

                if (__workflow_bodyadminnote != null)
                {
                    body["adminnote"] = ExpressionConverter.ConvertO(__workflow_bodyadminnote);
                    bodypropCount++;
                }

                if (__workflow_bodystartdate != null)
                {
                    body["startdate"] = ExpressionConverter.ConvertO(__workflow_bodystartdate);
                    bodypropCount++;
                }

                if (__workflow_bodyenddate != null)
                {
                    body["enddate"] = ExpressionConverter.ConvertO(__workflow_bodyenddate);
                    bodypropCount++;
                }

                if (__workflow_bodycreateddate != null)
                {
                    body["createddate"] = ExpressionConverter.ConvertO(__workflow_bodycreateddate);
                    bodypropCount++;
                }

                if (__workflow_bodyarchiveddate != null)
                {
                    body["archiveddate"] = ExpressionConverter.ConvertO(__workflow_bodyarchiveddate);
                    bodypropCount++;
                }

                if (__workflow_bodyclientno != null)
                {
                    body["clientno"] = ExpressionConverter.ConvertO(__workflow_bodyclientno);
                    bodypropCount++;
                }

                if (__workflow_bodymatterno != null)
                {
                    body["matterno"] = ExpressionConverter.ConvertO(__workflow_bodymatterno);
                    bodypropCount++;
                }

                if (__workflow_bodylandingpage != null)
                {
                    body["landingpage"] = ExpressionConverter.ConvertO(__workflow_bodylandingpage);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodystatusid != null)
                {
                    body["statusid"] = ExpressionConverter.ConvertO(__workflow_bodystatusid);
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                    bodypropCount++;
                }

                if (__workflow_bodybillingnotes != null)
                {
                    body["billingnotes"] = ExpressionConverter.ConvertO(__workflow_bodybillingnotes);
                    bodypropCount++;
                }

                if (__workflow_bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = ExpressionConverter.ConvertO(__workflow_bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (__workflow_bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = ExpressionConverter.ConvertO(__workflow_bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (__workflow_bodyfilepagecount != null)
                {
                    body["filepagecount"] = ExpressionConverter.ConvertO(__workflow_bodyfilepagecount);
                    bodypropCount++;
                }

                if (__workflow_bodymaxpagecount != null)
                {
                    body["maxpagecount"] = ExpressionConverter.ConvertO(__workflow_bodymaxpagecount);
                    bodypropCount++;
                }

                if (__workflow_bodysitehttplink != null)
                {
                    body["sitehttplink"] = ExpressionConverter.ConvertO(__workflow_bodysitehttplink);
                    bodypropCount++;
                }

                if (__workflow_bodyisSyncable != null)
                {
                    body["isSyncable"] = ExpressionConverter.ConvertO(__workflow_bodyisSyncable);
                    bodypropCount++;
                }

                if (__workflow_bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = ExpressionConverter.ConvertO(__workflow_bodyenforceusergroups);
                    bodypropCount++;
                }

                if (__workflow_bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = ExpressionConverter.ConvertO(__workflow_bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (__workflow_bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = ExpressionConverter.ConvertO(__workflow_bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyvisible != null)
                {
                    body["visible"] = ExpressionConverter.ConvertO(__workflow_bodyvisible);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoName != null)
                {
                    body["siteLogoName"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoName);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = ExpressionConverter.ConvertO(__workflow_bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (__workflow_bodysiteStatus != null)
                {
                    body["siteStatus"] = ExpressionConverter.ConvertO(__workflow_bodysiteStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = ExpressionConverter.ConvertO(__workflow_bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (__workflow_bodysiteTerm != null)
                {
                    body["siteTerm"] = ExpressionConverter.ConvertO(__workflow_bodysiteTerm);
                    bodypropCount++;
                }

                if (__workflow_bodytermType != null)
                {
                    body["termType"] = ExpressionConverter.ConvertO(__workflow_bodytermType);
                    bodypropCount++;
                }

                if (__workflow_bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = ExpressionConverter.ConvertO(__workflow_bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (__workflow_bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = ExpressionConverter.ConvertO(__workflow_bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (__workflow_bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(__workflow_bodyisInternal);
                    bodypropCount++;
                }

                if (__workflow_bodypsm != null)
                {
                    body["psm"] = ExpressionConverter.ConvertO(__workflow_bodypsm);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = ExpressionConverter.ConvertO(__workflow_bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (__workflow_bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = ExpressionConverter.ConvertO(__workflow_bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = ExpressionConverter.ConvertO(__workflow_bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (__workflow_bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = ExpressionConverter.ConvertO(__workflow_bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (__workflow_bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = ExpressionConverter.ConvertO(__workflow_bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (__workflow_bodysitePassword != null)
                {
                    body["sitePassword"] = ExpressionConverter.ConvertO(__workflow_bodysitePassword);
                    bodypropCount++;
                }

                if (__workflow_bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = ExpressionConverter.ConvertO(__workflow_bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableIP != null)
                {
                    body["availableIP"] = ExpressionConverter.ConvertO(__workflow_bodyavailableIP);
                    bodypropCount++;
                }

                if (__workflow_bodyhighqDrive != null)
                {
                    body["highqDrive"] = ExpressionConverter.ConvertO(__workflow_bodyhighqDrive);
                    bodypropCount++;
                }

                if (__workflow_bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodysiteHomePage != null)
                {
                    body["siteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodysiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = ExpressionConverter.ConvertO(__workflow_bodysiteHomePageType);
                    bodypropCount++;
                }

                if (__workflow_bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = ExpressionConverter.ConvertO(__workflow_bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = ExpressionConverter.ConvertO(__workflow_bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayContent != null)
                {
                    body["displayContent"] = ExpressionConverter.ConvertO(__workflow_bodydisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrssSecurity != null)
                {
                    body["rssSecurity"] = ExpressionConverter.ConvertO(__workflow_bodyrssSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = ExpressionConverter.ConvertO(__workflow_bodyencryptedPassword);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = ExpressionConverter.ConvertO(__workflow_bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (__workflow_bodysiteModuleID != null)
                {
                    body["siteModuleID"] = ExpressionConverter.ConvertO(__workflow_bodysiteModuleID);
                    bodypropCount++;
                }

                if (__workflow_bodyicalSecurity != null)
                {
                    body["icalSecurity"] = ExpressionConverter.ConvertO(__workflow_bodyicalSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = ExpressionConverter.ConvertO(__workflow_bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = ExpressionConverter.ConvertO(__workflow_bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (__workflow_bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = ExpressionConverter.ConvertO(__workflow_bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = ExpressionConverter.ConvertO(__workflow_bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (__workflow_bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = ExpressionConverter.ConvertO(__workflow_bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateType != null)
                {
                    body["templateType"] = ExpressionConverter.ConvertO(__workflow_bodytemplateType);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateLicence != null)
                {
                    body["templateLicence"] = ExpressionConverter.ConvertO(__workflow_bodytemplateLicence);
                    bodypropCount++;
                }

                if (__workflow_bodyopenChannelAppID != null)
                {
                    body["openChannelAppID"] = ExpressionConverter.ConvertO(__workflow_bodyopenChannelAppID);
                    bodypropCount++;
                }

                if (__workflow_bodyitemid != null)
                {
                    body["itemid"] = ExpressionConverter.ConvertO(__workflow_bodyitemid);
                    bodypropCount++;
                }

                if (__workflow_bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = ExpressionConverter.ConvertO(__workflow_bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (__workflow_bodymysite != null)
                {
                    body["mysite"] = ExpressionConverter.ConvertO(__workflow_bodymysite);
                    bodypropCount++;
                }

                if (__workflow_bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = ExpressionConverter.ConvertO(__workflow_bodylastaccesseddate);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = ExpressionConverter.ConvertO(__workflow_bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (__workflow_bodydocSort != null)
                {
                    body["docSort"] = ExpressionConverter.ConvertO(__workflow_bodydocSort);
                    bodypropCount++;
                }

                if (__workflow_bodyfolderSort != null)
                {
                    body["folderSort"] = ExpressionConverter.ConvertO(__workflow_bodyfolderSort);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = ExpressionConverter.ConvertO(__workflow_bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = ExpressionConverter.ConvertO(__workflow_bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (__workflow_bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = ExpressionConverter.ConvertO(__workflow_bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyfavourite != null)
                {
                    body["favourite"] = ExpressionConverter.ConvertO(__workflow_bodyfavourite);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = ExpressionConverter.ConvertO(__workflow_bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (__workflow_bodymentiongroups != null)
                {
                    body["mentiongroups"] = ExpressionConverter.ConvertO(__workflow_bodymentiongroups);
                    bodypropCount++;
                }

                if (__workflow_bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = ExpressionConverter.ConvertO(__workflow_bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (__workflow_bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = ExpressionConverter.ConvertO(__workflow_bodyfilerelationshipsitepermissionlevel);
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
