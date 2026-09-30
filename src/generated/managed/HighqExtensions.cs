//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HighqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction MoveDocuments([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> targetfolder, [WorkflowExpression] Func<string> fileidcsvfileidCSV = null)
        {
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(targetfolder, nameof(targetfolder), required: true);
            SourceExpression.Validate(fileidcsvfileidCSV, nameof(fileidcsvfileidCSV), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/files/move", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["targetfolder"] = SourceExpressionConverter.ConvertO(targetfolder);
                var fileidcsv = new JObject();
                var fileidcsvpropCount = 0;
                if (fileidcsvfileidCSV != null)
                {
                    fileidcsv["fileidCSV"] = SourceExpressionConverter.ConvertToken(fileidcsvfileidCSV);
                    fileidcsvpropCount++;
                }

                if (fileidcsvpropCount > 0)
                {
                    callPayload.Body = fileidcsv;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IBodyWorkflowAction<Site> CreateSite([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodysitename = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysitedescription = null, [WorkflowExpression] Func<string> bodyenabledmodules = null, [WorkflowExpression] Func<string> bodysitefolderId = null, [WorkflowExpression] Func<string> bodysitefolderpermission = null, [WorkflowExpression] Func<string> bodymodulehomeenable = null, [WorkflowExpression] Func<string> bodymoduleactivityenable = null, [WorkflowExpression] Func<string> bodymoduleactivitymicroblog = null, [WorkflowExpression] Func<string> bodymoduledocumentdocid = null, [WorkflowExpression] Func<string> bodymoduleblogblogTitle = null, [WorkflowExpression] Func<string> bodymoduleblogblogContent = null, [WorkflowExpression] Func<int> bodymoduleblogshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleblogtagList = null, [WorkflowExpression] Func<int> bodymoduleblogstatus = null, [WorkflowExpression] Func<int> bodymoduleblogsiteId = null, [WorkflowExpression] Func<string> bodymoduleblogauthor = null, [WorkflowExpression] Func<string[]> bodymoduleblogcategoryList = null, [WorkflowExpression] Func<int> bodymoduleblognotificationTypeId = null, [WorkflowExpression] Func<string> bodymoduleblogmessage = null, [WorkflowExpression] Func<int> bodymoduleblogmessageCode = null, [WorkflowExpression] Func<string> bodymoduleblogexternalId = null, [WorkflowExpression] Func<string> bodymoduleblogpublishDate = null, [WorkflowExpression] Func<string> bodymoduleblogprocesstype = null, [WorkflowExpression] Func<string> bodymoduleblogenable = null, [WorkflowExpression] Func<int> bodymodulewikiwikiid = null, [WorkflowExpression] Func<int> bodymodulewikicurrentversionid = null, [WorkflowExpression] Func<int> bodymodulewikiparentwikiid = null, [WorkflowExpression] Func<string> bodymodulewikiwikititle = null, [WorkflowExpression] Func<string> bodymodulewikiwikicontent = null, [WorkflowExpression] Func<int> bodymodulewikishowcomment = null, [WorkflowExpression] Func<string> bodymodulewikicreateddate = null, [WorkflowExpression] Func<string> bodymodulewikimodifieddate = null, [WorkflowExpression] Func<string> bodymodulewikitaglist = null, [WorkflowExpression] Func<string> bodymodulewikiwikipath = null, [WorkflowExpression] Func<int> bodymodulewikiwikidraftid = null, [WorkflowExpression] Func<string> bodymodulewikidrafttype = null, [WorkflowExpression] Func<int> bodymodulewikistatus = null, [WorkflowExpression] Func<int> bodymodulewikiwikiversionid = null, [WorkflowExpression] Func<string> bodymoduletaskindex = null, [WorkflowExpression] Func<int> bodymoduletaskparenttaskid = null, [WorkflowExpression] Func<int> bodymoduletasktaskid = null, [WorkflowExpression] Func<string> bodymoduletasktitle = null, [WorkflowExpression] Func<string> bodymoduletaskdescription = null, [WorkflowExpression] Func<string> bodymoduletaskduedate = null, [WorkflowExpression] Func<string> bodymoduletaskstartdate = null, [WorkflowExpression] Func<string> bodymoduletaskmattermaptaskid = null, [WorkflowExpression] Func<string> bodymoduletasktype = null, [WorkflowExpression] Func<string> bodymoduletaskdependenton = null, [WorkflowExpression] Func<string> bodymoduletaskdaysfromdependent = null, [WorkflowExpression] Func<int> bodymoduletaskignoreweekend = null, [WorkflowExpression] Func<int> bodymoduletaskduration = null, [WorkflowExpression] Func<string> bodymoduletaskresource = null, [WorkflowExpression] Func<string> bodymoduleEventeventTitle = null, [WorkflowExpression] Func<string> bodymoduleEventeventContent = null, [WorkflowExpression] Func<int> bodymoduleEventshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleEventtagList = null, [WorkflowExpression] Func<int> bodymoduleEventstatus = null, [WorkflowExpression] Func<int> bodymoduleEventsiteId = null, [WorkflowExpression] Func<string> bodymoduleEventcontact = null, [WorkflowExpression] Func<string[]> bodymoduleEventcategoryList = null, [WorkflowExpression] Func<int> bodymoduleEventnotificationTypeId = null, [WorkflowExpression] Func<string> bodymoduleEventmessage = null, [WorkflowExpression] Func<int> bodymoduleEventmessageCode = null, [WorkflowExpression] Func<string> bodymoduleEventexternalId = null, [WorkflowExpression] Func<string> bodymoduleEventstartDate = null, [WorkflowExpression] Func<string> bodymoduleEventendDate = null, [WorkflowExpression] Func<string> bodymoduleEventstartTime = null, [WorkflowExpression] Func<string> bodymoduleEventendTime = null, [WorkflowExpression] Func<string> bodymoduleEventlocation = null, [WorkflowExpression] Func<string> bodymoduleEventauthor = null, [WorkflowExpression] Func<string> bodymoduleEventprocesstype = null, [WorkflowExpression] Func<string> bodymoduleEventenable = null, [WorkflowExpression] Func<int> bodymoduleisheetid = null, [WorkflowExpression] Func<string> bodymoduleisheettitle = null, [WorkflowExpression] Func<string> bodymoduleisheetdescription = null, [WorkflowExpression] Func<string> bodymoduleisheetstatus = null, [WorkflowExpression] Func<string> bodymoduleisheetaccesstype = null, [WorkflowExpression] Func<string> bodymoduleisheettype = null, [WorkflowExpression] Func<string> bodymoduleisheetviewlink = null, [WorkflowExpression] Func<string> bodymoduleisheetallowsections = null, [WorkflowExpression] Func<string> bodymoduleisheetallowlookup = null, [WorkflowExpression] Func<string> bodymoduleisheetdisplayisheet = null, [WorkflowExpression] Func<string> bodymoduleisheetsearchasdefaultview = null, [WorkflowExpression] Func<string> bodymoduleisheetenableversion = null, [WorkflowExpression] Func<string> bodymoduleisheetenablesheetalerter = null, [WorkflowExpression] Func<string> bodymoduleisheetalertercondition = null, [WorkflowExpression] Func<string> bodymoduleisheetoverrideitemmodifieddate = null, [WorkflowExpression] Func<string> bodymoduleisheetenablebulkinsertupdate = null, [WorkflowExpression] Func<string> bodymoduleisheetfielddescriptions = null, [WorkflowExpression] Func<string> bodymoduleisheetenablerowlocking = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, [WorkflowExpression] Func<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowscorelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowIsheetComments = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimit = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimitEnabled = null, [WorkflowExpression] Func<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, [WorkflowExpression] Func<string> bodymoduleisheetrecordcount = null, [WorkflowExpression] Func<int> bodymoduleisheetsheettypeid = null, [WorkflowExpression] Func<string> bodymoduleqaenable = null, [WorkflowExpression] Func<PersonDBO[]> bodymodulepeopleperson = null, [WorkflowExpression] Func<string> bodymodulecontractexpressenable = null, [WorkflowExpression] Func<string> bodyadminnote = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyenddate = null, [WorkflowExpression] Func<string> bodycreateddate = null, [WorkflowExpression] Func<string> bodyarchiveddate = null, [WorkflowExpression] Func<string> bodyclientno = null, [WorkflowExpression] Func<string> bodymatterno = null, [WorkflowExpression] Func<string> bodylandingpage = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodystatusid = null, [WorkflowExpression] Func<string> bodysize = null, [WorkflowExpression] Func<string> bodybillingnotes = null, [WorkflowExpression] Func<string> bodybillingnextinvoicedate = null, [WorkflowExpression] Func<string> bodybillinglastinvoicedate = null, [WorkflowExpression] Func<string> bodyfilepagecount = null, [WorkflowExpression] Func<string> bodymaxpagecount = null, [WorkflowExpression] Func<string> bodysitehttplink = null, [WorkflowExpression] Func<int> bodyisSyncable = null, [WorkflowExpression] Func<string> bodyenforceusergroups = null, [WorkflowExpression] Func<string> bodycsvSiteCategory = null, [WorkflowExpression] Func<string> bodysiteNameInDefaultLanguage = null, [WorkflowExpression] Func<int> bodyvisible = null, [WorkflowExpression] Func<string> bodysiteLogoName = null, [WorkflowExpression] Func<int> bodysiteLogoFileSize = null, [WorkflowExpression] Func<int> bodysiteLogoHeight = null, [WorkflowExpression] Func<int> bodysiteLogoWidth = null, [WorkflowExpression] Func<int> bodysiteStatus = null, [WorkflowExpression] Func<int> bodyapplySiteTerms = null, [WorkflowExpression] Func<string> bodysiteTerm = null, [WorkflowExpression] Func<int> bodytermType = null, [WorkflowExpression] Func<int> bodynextLoginSiteTerms = null, [WorkflowExpression] Func<int> bodydefaultSiteTermsEnable = null, [WorkflowExpression] Func<int> bodyadvancedQAPermission = null, [WorkflowExpression] Func<int> bodyisInternal = null, [WorkflowExpression] Func<int> bodypsm = null, [WorkflowExpression] Func<string> bodysiteLabelDisplay = null, [WorkflowExpression] Func<int> bodyallowSiteAdministration = null, [WorkflowExpression] Func<int> bodysiteLevelPasswordEnable = null, [WorkflowExpression] Func<int> bodysiteLevelPasscodeEnable = null, [WorkflowExpression] Func<int> bodypasscodeUsingAuthApp = null, [WorkflowExpression] Func<string> bodysitePassword = null, [WorkflowExpression] Func<int> bodyipRestrictionEnable = null, [WorkflowExpression] Func<string> bodyavailableIP = null, [WorkflowExpression] Func<int> bodyhighqDrive = null, [WorkflowExpression] Func<int> bodyapplySiteHomePage = null, [WorkflowExpression] Func<string> bodysiteHomePage = null, [WorkflowExpression] Func<int> bodysiteHomePageType = null, [WorkflowExpression] Func<int> bodynextLoginSiteHomePage = null, [WorkflowExpression] Func<int> bodyapplyDisplayContent = null, [WorkflowExpression] Func<string> bodydisplayContent = null, [WorkflowExpression] Func<int> bodyrssSecurity = null, [WorkflowExpression] Func<int> bodyencryptedPassword = null, [WorkflowExpression] Func<string> bodyavailableIPRangeCSV = null, [WorkflowExpression] Func<int> bodysiteModuleId = null, [WorkflowExpression] Func<int> bodyicalSecurity = null, [WorkflowExpression] Func<string> bodydefaultDisplayContent = null, [WorkflowExpression] Func<int> bodydefaultEmailAlert = null, [WorkflowExpression] Func<int> bodyexcelReportFooter = null, [WorkflowExpression] Func<string> bodyexcelReportFooterText = null, [WorkflowExpression] Func<string> bodyannouncementMLJSON = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<int> bodytemplateLicence = null, [WorkflowExpression] Func<string> bodyopenChannelAppId = null, [WorkflowExpression] Func<int> bodyitemid = null, [WorkflowExpression] Func<int> bodysitemetadatasheetid = null, [WorkflowExpression] Func<bool> bodymysite = null, [WorkflowExpression] Func<string> bodylastaccesseddate = null, [WorkflowExpression] Func<int> bodydefaultViewerMetaDataTab = null, [WorkflowExpression] Func<int> bodydocumentMetadataViewId = null, [WorkflowExpression] Func<int> bodyfolderMetadataViewId = null, [WorkflowExpression] Func<int> bodydocSort = null, [WorkflowExpression] Func<int> bodyfolderSort = null, [WorkflowExpression] Func<int> bodydefaultFolderRenderView = null, [WorkflowExpression] Func<int> bodyisTaskAttachmentDefault = null, [WorkflowExpression] Func<int> bodytaskAttachmentDefaultFolderId = null, [WorkflowExpression] Func<string> bodyfavourite = null, [WorkflowExpression] Func<bool> bodyenabledocumentredaction = null, [WorkflowExpression] Func<int> bodymentiongroups = null, [WorkflowExpression] Func<bool> bodyenablefilerelationships = null, [WorkflowExpression] Func<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodysitename, nameof(bodysitename), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodysitedescription, nameof(bodysitedescription), required: false);
            SourceExpression.Validate(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            SourceExpression.Validate(bodysitefolderId, nameof(bodysitefolderId), required: false);
            SourceExpression.Validate(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            SourceExpression.Validate(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            SourceExpression.Validate(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            SourceExpression.Validate(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            SourceExpression.Validate(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            SourceExpression.Validate(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            SourceExpression.Validate(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            SourceExpression.Validate(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            SourceExpression.Validate(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            SourceExpression.Validate(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            SourceExpression.Validate(bodymoduleblogsiteId, nameof(bodymoduleblogsiteId), required: false);
            SourceExpression.Validate(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            SourceExpression.Validate(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            SourceExpression.Validate(bodymoduleblognotificationTypeId, nameof(bodymoduleblognotificationTypeId), required: false);
            SourceExpression.Validate(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            SourceExpression.Validate(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            SourceExpression.Validate(bodymoduleblogexternalId, nameof(bodymoduleblogexternalId), required: false);
            SourceExpression.Validate(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            SourceExpression.Validate(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            SourceExpression.Validate(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            SourceExpression.Validate(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            SourceExpression.Validate(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            SourceExpression.Validate(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            SourceExpression.Validate(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            SourceExpression.Validate(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            SourceExpression.Validate(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            SourceExpression.Validate(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            SourceExpression.Validate(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            SourceExpression.Validate(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            SourceExpression.Validate(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            SourceExpression.Validate(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            SourceExpression.Validate(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            SourceExpression.Validate(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            SourceExpression.Validate(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            SourceExpression.Validate(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            SourceExpression.Validate(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            SourceExpression.Validate(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            SourceExpression.Validate(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            SourceExpression.Validate(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            SourceExpression.Validate(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            SourceExpression.Validate(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            SourceExpression.Validate(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            SourceExpression.Validate(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            SourceExpression.Validate(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            SourceExpression.Validate(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            SourceExpression.Validate(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            SourceExpression.Validate(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            SourceExpression.Validate(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            SourceExpression.Validate(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            SourceExpression.Validate(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            SourceExpression.Validate(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            SourceExpression.Validate(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            SourceExpression.Validate(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            SourceExpression.Validate(bodymoduleEventsiteId, nameof(bodymoduleEventsiteId), required: false);
            SourceExpression.Validate(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            SourceExpression.Validate(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            SourceExpression.Validate(bodymoduleEventnotificationTypeId, nameof(bodymoduleEventnotificationTypeId), required: false);
            SourceExpression.Validate(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            SourceExpression.Validate(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            SourceExpression.Validate(bodymoduleEventexternalId, nameof(bodymoduleEventexternalId), required: false);
            SourceExpression.Validate(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            SourceExpression.Validate(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            SourceExpression.Validate(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            SourceExpression.Validate(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            SourceExpression.Validate(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            SourceExpression.Validate(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            SourceExpression.Validate(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            SourceExpression.Validate(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            SourceExpression.Validate(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            SourceExpression.Validate(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            SourceExpression.Validate(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            SourceExpression.Validate(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            SourceExpression.Validate(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            SourceExpression.Validate(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            SourceExpression.Validate(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            SourceExpression.Validate(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            SourceExpression.Validate(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            SourceExpression.Validate(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            SourceExpression.Validate(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            SourceExpression.Validate(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            SourceExpression.Validate(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            SourceExpression.Validate(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            SourceExpression.Validate(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            SourceExpression.Validate(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            SourceExpression.Validate(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            SourceExpression.Validate(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            SourceExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            SourceExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            SourceExpression.Validate(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            SourceExpression.Validate(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            SourceExpression.Validate(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            SourceExpression.Validate(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            SourceExpression.Validate(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            SourceExpression.Validate(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            SourceExpression.Validate(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            SourceExpression.Validate(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            SourceExpression.Validate(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            SourceExpression.Validate(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            SourceExpression.Validate(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            SourceExpression.Validate(bodyadminnote, nameof(bodyadminnote), required: false);
            SourceExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            SourceExpression.Validate(bodyenddate, nameof(bodyenddate), required: false);
            SourceExpression.Validate(bodycreateddate, nameof(bodycreateddate), required: false);
            SourceExpression.Validate(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            SourceExpression.Validate(bodyclientno, nameof(bodyclientno), required: false);
            SourceExpression.Validate(bodymatterno, nameof(bodymatterno), required: false);
            SourceExpression.Validate(bodylandingpage, nameof(bodylandingpage), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodystatusid, nameof(bodystatusid), required: false);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: false);
            SourceExpression.Validate(bodybillingnotes, nameof(bodybillingnotes), required: false);
            SourceExpression.Validate(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            SourceExpression.Validate(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            SourceExpression.Validate(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            SourceExpression.Validate(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            SourceExpression.Validate(bodysitehttplink, nameof(bodysitehttplink), required: false);
            SourceExpression.Validate(bodyisSyncable, nameof(bodyisSyncable), required: false);
            SourceExpression.Validate(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            SourceExpression.Validate(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            SourceExpression.Validate(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            SourceExpression.Validate(bodyvisible, nameof(bodyvisible), required: false);
            SourceExpression.Validate(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            SourceExpression.Validate(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            SourceExpression.Validate(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            SourceExpression.Validate(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            SourceExpression.Validate(bodysiteStatus, nameof(bodysiteStatus), required: false);
            SourceExpression.Validate(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            SourceExpression.Validate(bodysiteTerm, nameof(bodysiteTerm), required: false);
            SourceExpression.Validate(bodytermType, nameof(bodytermType), required: false);
            SourceExpression.Validate(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            SourceExpression.Validate(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            SourceExpression.Validate(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            SourceExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            SourceExpression.Validate(bodypsm, nameof(bodypsm), required: false);
            SourceExpression.Validate(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            SourceExpression.Validate(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            SourceExpression.Validate(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            SourceExpression.Validate(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            SourceExpression.Validate(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            SourceExpression.Validate(bodysitePassword, nameof(bodysitePassword), required: false);
            SourceExpression.Validate(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            SourceExpression.Validate(bodyavailableIP, nameof(bodyavailableIP), required: false);
            SourceExpression.Validate(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            SourceExpression.Validate(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            SourceExpression.Validate(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            SourceExpression.Validate(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            SourceExpression.Validate(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            SourceExpression.Validate(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            SourceExpression.Validate(bodydisplayContent, nameof(bodydisplayContent), required: false);
            SourceExpression.Validate(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            SourceExpression.Validate(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            SourceExpression.Validate(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            SourceExpression.Validate(bodysiteModuleId, nameof(bodysiteModuleId), required: false);
            SourceExpression.Validate(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            SourceExpression.Validate(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            SourceExpression.Validate(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            SourceExpression.Validate(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            SourceExpression.Validate(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            SourceExpression.Validate(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            SourceExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            SourceExpression.Validate(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            SourceExpression.Validate(bodyopenChannelAppId, nameof(bodyopenChannelAppId), required: false);
            SourceExpression.Validate(bodyitemid, nameof(bodyitemid), required: false);
            SourceExpression.Validate(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            SourceExpression.Validate(bodymysite, nameof(bodymysite), required: false);
            SourceExpression.Validate(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            SourceExpression.Validate(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            SourceExpression.Validate(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            SourceExpression.Validate(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            SourceExpression.Validate(bodydocSort, nameof(bodydocSort), required: false);
            SourceExpression.Validate(bodyfolderSort, nameof(bodyfolderSort), required: false);
            SourceExpression.Validate(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            SourceExpression.Validate(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            SourceExpression.Validate(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            SourceExpression.Validate(bodyfavourite, nameof(bodyfavourite), required: false);
            SourceExpression.Validate(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            SourceExpression.Validate(bodymentiongroups, nameof(bodymentiongroups), required: false);
            SourceExpression.Validate(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            SourceExpression.Validate(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/sites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodysitename != null)
                {
                    body["sitename"] = SourceExpressionConverter.ConvertToken(bodysitename);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodysitedescription != null)
                {
                    body["sitedescription"] = SourceExpressionConverter.ConvertToken(bodysitedescription);
                    bodypropCount++;
                }

                if (bodyenabledmodules != null)
                {
                    body["enabledmodules"] = SourceExpressionConverter.ConvertToken(bodyenabledmodules);
                    bodypropCount++;
                }

                if (bodysitefolderId != null)
                {
                    body["sitefolderID"] = SourceExpressionConverter.ConvertToken(bodysitefolderId);
                    bodypropCount++;
                }

                if (bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = SourceExpressionConverter.ConvertToken(bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (bodymodulehomeenable != null)
                {
                    homeObject["enable"] = SourceExpressionConverter.ConvertToken(bodymodulehomeenable);
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
                    activityObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = SourceExpressionConverter.ConvertToken(bodymoduleactivitymicroblog);
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
                    documentObject["docid"] = SourceExpressionConverter.ConvertToken(bodymoduledocumentdocid);
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
                    blogObject["blogTitle"] = SourceExpressionConverter.ConvertToken(bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = SourceExpressionConverter.ConvertToken(bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = SourceExpressionConverter.ConvertToken(bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = SourceExpressionConverter.ConvertToken(bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogstatus != null)
                {
                    blogObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogsiteId != null)
                {
                    blogObject["siteID"] = SourceExpressionConverter.ConvertToken(bodymoduleblogsiteId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogauthor != null)
                {
                    blogObject["author"] = SourceExpressionConverter.ConvertToken(bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = SourceExpressionConverter.ConvertToken(bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblognotificationTypeId != null)
                {
                    blogObject["notificationTypeID"] = SourceExpressionConverter.ConvertToken(bodymoduleblognotificationTypeId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessage != null)
                {
                    blogObject["message"] = SourceExpressionConverter.ConvertToken(bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = SourceExpressionConverter.ConvertToken(bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogexternalId != null)
                {
                    blogObject["externalID"] = SourceExpressionConverter.ConvertToken(bodymoduleblogexternalId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = SourceExpressionConverter.ConvertToken(bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = SourceExpressionConverter.ConvertToken(bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogenable != null)
                {
                    blogObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleblogenable);
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
                    wikiObject["wikiid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = SourceExpressionConverter.ConvertToken(bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = SourceExpressionConverter.ConvertToken(bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = SourceExpressionConverter.ConvertToken(bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = SourceExpressionConverter.ConvertToken(bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = SourceExpressionConverter.ConvertToken(bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = SourceExpressionConverter.ConvertToken(bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikistatus != null)
                {
                    wikiObject["status"] = SourceExpressionConverter.ConvertToken(bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikiversionid);
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
                    taskObject["index"] = SourceExpressionConverter.ConvertToken(bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = SourceExpressionConverter.ConvertToken(bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = SourceExpressionConverter.ConvertToken(bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktitle != null)
                {
                    taskObject["title"] = SourceExpressionConverter.ConvertToken(bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdescription != null)
                {
                    taskObject["description"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = SourceExpressionConverter.ConvertToken(bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = SourceExpressionConverter.ConvertToken(bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = SourceExpressionConverter.ConvertToken(bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktype != null)
                {
                    taskObject["type"] = SourceExpressionConverter.ConvertToken(bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = SourceExpressionConverter.ConvertToken(bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduration != null)
                {
                    taskObject["duration"] = SourceExpressionConverter.ConvertToken(bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskresource != null)
                {
                    taskObject["resource"] = SourceExpressionConverter.ConvertToken(bodymoduletaskresource);
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
                    @eventObject["eventTitle"] = SourceExpressionConverter.ConvertToken(bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = SourceExpressionConverter.ConvertToken(bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = SourceExpressionConverter.ConvertToken(bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = SourceExpressionConverter.ConvertToken(bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventsiteId != null)
                {
                    @eventObject["siteID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventsiteId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = SourceExpressionConverter.ConvertToken(bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = SourceExpressionConverter.ConvertToken(bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventnotificationTypeId != null)
                {
                    @eventObject["notificationTypeID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventnotificationTypeId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = SourceExpressionConverter.ConvertToken(bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = SourceExpressionConverter.ConvertToken(bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventexternalId != null)
                {
                    @eventObject["externalID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventexternalId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = SourceExpressionConverter.ConvertToken(bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = SourceExpressionConverter.ConvertToken(bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = SourceExpressionConverter.ConvertToken(bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = SourceExpressionConverter.ConvertToken(bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = SourceExpressionConverter.ConvertToken(bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleEventenable);
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
                    isheetObject["id"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = SourceExpressionConverter.ConvertToken(bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettype != null)
                {
                    isheetObject["type"] = SourceExpressionConverter.ConvertToken(bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsheettypeid);
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
                    qaObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleqaenable);
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
                    peopleObject["person"] = SourceExpressionConverter.ConvertToken(bodymodulepeopleperson);
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
                    contractexpressObject["enable"] = SourceExpressionConverter.ConvertToken(bodymodulecontractexpressenable);
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
                    body["adminnote"] = SourceExpressionConverter.ConvertToken(bodyadminnote);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = SourceExpressionConverter.ConvertToken(bodystartdate);
                    bodypropCount++;
                }

                if (bodyenddate != null)
                {
                    body["enddate"] = SourceExpressionConverter.ConvertToken(bodyenddate);
                    bodypropCount++;
                }

                if (bodycreateddate != null)
                {
                    body["createddate"] = SourceExpressionConverter.ConvertToken(bodycreateddate);
                    bodypropCount++;
                }

                if (bodyarchiveddate != null)
                {
                    body["archiveddate"] = SourceExpressionConverter.ConvertToken(bodyarchiveddate);
                    bodypropCount++;
                }

                if (bodyclientno != null)
                {
                    body["clientno"] = SourceExpressionConverter.ConvertToken(bodyclientno);
                    bodypropCount++;
                }

                if (bodymatterno != null)
                {
                    body["matterno"] = SourceExpressionConverter.ConvertToken(bodymatterno);
                    bodypropCount++;
                }

                if (bodylandingpage != null)
                {
                    body["landingpage"] = SourceExpressionConverter.ConvertToken(bodylandingpage);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusid != null)
                {
                    body["statusid"] = SourceExpressionConverter.ConvertToken(bodystatusid);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodybillingnotes != null)
                {
                    body["billingnotes"] = SourceExpressionConverter.ConvertToken(bodybillingnotes);
                    bodypropCount++;
                }

                if (bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = SourceExpressionConverter.ConvertToken(bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = SourceExpressionConverter.ConvertToken(bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (bodyfilepagecount != null)
                {
                    body["filepagecount"] = SourceExpressionConverter.ConvertToken(bodyfilepagecount);
                    bodypropCount++;
                }

                if (bodymaxpagecount != null)
                {
                    body["maxpagecount"] = SourceExpressionConverter.ConvertToken(bodymaxpagecount);
                    bodypropCount++;
                }

                if (bodysitehttplink != null)
                {
                    body["sitehttplink"] = SourceExpressionConverter.ConvertToken(bodysitehttplink);
                    bodypropCount++;
                }

                if (bodyisSyncable != null)
                {
                    body["isSyncable"] = SourceExpressionConverter.ConvertToken(bodyisSyncable);
                    bodypropCount++;
                }

                if (bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = SourceExpressionConverter.ConvertToken(bodyenforceusergroups);
                    bodypropCount++;
                }

                if (bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = SourceExpressionConverter.ConvertToken(bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = SourceExpressionConverter.ConvertToken(bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (bodyvisible != null)
                {
                    body["visible"] = SourceExpressionConverter.ConvertToken(bodyvisible);
                    bodypropCount++;
                }

                if (bodysiteLogoName != null)
                {
                    body["siteLogoName"] = SourceExpressionConverter.ConvertToken(bodysiteLogoName);
                    bodypropCount++;
                }

                if (bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = SourceExpressionConverter.ConvertToken(bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = SourceExpressionConverter.ConvertToken(bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = SourceExpressionConverter.ConvertToken(bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (bodysiteStatus != null)
                {
                    body["siteStatus"] = SourceExpressionConverter.ConvertToken(bodysiteStatus);
                    bodypropCount++;
                }

                if (bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = SourceExpressionConverter.ConvertToken(bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (bodysiteTerm != null)
                {
                    body["siteTerm"] = SourceExpressionConverter.ConvertToken(bodysiteTerm);
                    bodypropCount++;
                }

                if (bodytermType != null)
                {
                    body["termType"] = SourceExpressionConverter.ConvertToken(bodytermType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = SourceExpressionConverter.ConvertToken(bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = SourceExpressionConverter.ConvertToken(bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = SourceExpressionConverter.ConvertToken(bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = SourceExpressionConverter.ConvertToken(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypsm != null)
                {
                    body["psm"] = SourceExpressionConverter.ConvertToken(bodypsm);
                    bodypropCount++;
                }

                if (bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = SourceExpressionConverter.ConvertToken(bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = SourceExpressionConverter.ConvertToken(bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = SourceExpressionConverter.ConvertToken(bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = SourceExpressionConverter.ConvertToken(bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = SourceExpressionConverter.ConvertToken(bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (bodysitePassword != null)
                {
                    body["sitePassword"] = SourceExpressionConverter.ConvertToken(bodysitePassword);
                    bodypropCount++;
                }

                if (bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = SourceExpressionConverter.ConvertToken(bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (bodyavailableIP != null)
                {
                    body["availableIP"] = SourceExpressionConverter.ConvertToken(bodyavailableIP);
                    bodypropCount++;
                }

                if (bodyhighqDrive != null)
                {
                    body["highqDrive"] = SourceExpressionConverter.ConvertToken(bodyhighqDrive);
                    bodypropCount++;
                }

                if (bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = SourceExpressionConverter.ConvertToken(bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePage != null)
                {
                    body["siteHomePage"] = SourceExpressionConverter.ConvertToken(bodysiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = SourceExpressionConverter.ConvertToken(bodysiteHomePageType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = SourceExpressionConverter.ConvertToken(bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = SourceExpressionConverter.ConvertToken(bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (bodydisplayContent != null)
                {
                    body["displayContent"] = SourceExpressionConverter.ConvertToken(bodydisplayContent);
                    bodypropCount++;
                }

                if (bodyrssSecurity != null)
                {
                    body["rssSecurity"] = SourceExpressionConverter.ConvertToken(bodyrssSecurity);
                    bodypropCount++;
                }

                if (bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = SourceExpressionConverter.ConvertToken(bodyencryptedPassword);
                    bodypropCount++;
                }

                if (bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = SourceExpressionConverter.ConvertToken(bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (bodysiteModuleId != null)
                {
                    body["siteModuleID"] = SourceExpressionConverter.ConvertToken(bodysiteModuleId);
                    bodypropCount++;
                }

                if (bodyicalSecurity != null)
                {
                    body["icalSecurity"] = SourceExpressionConverter.ConvertToken(bodyicalSecurity);
                    bodypropCount++;
                }

                if (bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = SourceExpressionConverter.ConvertToken(bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = SourceExpressionConverter.ConvertToken(bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = SourceExpressionConverter.ConvertToken(bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = SourceExpressionConverter.ConvertToken(bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = SourceExpressionConverter.ConvertToken(bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["templateType"] = SourceExpressionConverter.ConvertToken(bodytemplateType);
                    bodypropCount++;
                }

                if (bodytemplateLicence != null)
                {
                    body["templateLicence"] = SourceExpressionConverter.ConvertToken(bodytemplateLicence);
                    bodypropCount++;
                }

                if (bodyopenChannelAppId != null)
                {
                    body["openChannelAppID"] = SourceExpressionConverter.ConvertToken(bodyopenChannelAppId);
                    bodypropCount++;
                }

                if (bodyitemid != null)
                {
                    body["itemid"] = SourceExpressionConverter.ConvertToken(bodyitemid);
                    bodypropCount++;
                }

                if (bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = SourceExpressionConverter.ConvertToken(bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (bodymysite != null)
                {
                    body["mysite"] = SourceExpressionConverter.ConvertToken(bodymysite);
                    bodypropCount++;
                }

                if (bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = SourceExpressionConverter.ConvertToken(bodylastaccesseddate);
                    bodypropCount++;
                }

                if (bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = SourceExpressionConverter.ConvertToken(bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = SourceExpressionConverter.ConvertToken(bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = SourceExpressionConverter.ConvertToken(bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (bodydocSort != null)
                {
                    body["docSort"] = SourceExpressionConverter.ConvertToken(bodydocSort);
                    bodypropCount++;
                }

                if (bodyfolderSort != null)
                {
                    body["folderSort"] = SourceExpressionConverter.ConvertToken(bodyfolderSort);
                    bodypropCount++;
                }

                if (bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = SourceExpressionConverter.ConvertToken(bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = SourceExpressionConverter.ConvertToken(bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = SourceExpressionConverter.ConvertToken(bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (bodyfavourite != null)
                {
                    body["favourite"] = SourceExpressionConverter.ConvertToken(bodyfavourite);
                    bodypropCount++;
                }

                if (bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = SourceExpressionConverter.ConvertToken(bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (bodymentiongroups != null)
                {
                    body["mentiongroups"] = SourceExpressionConverter.ConvertToken(bodymentiongroups);
                    bodypropCount++;
                }

                if (bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = SourceExpressionConverter.ConvertToken(bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = SourceExpressionConverter.ConvertToken(bodyfilerelationshipsitepermissionlevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Site>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction UpdateSite([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> siteid, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodysitename = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysitedescription = null, [WorkflowExpression] Func<string> bodyenabledmodules = null, [WorkflowExpression] Func<string> bodysitefolderId = null, [WorkflowExpression] Func<string> bodysitefolderpermission = null, [WorkflowExpression] Func<string> bodymodulehomeenable = null, [WorkflowExpression] Func<string> bodymoduleactivityenable = null, [WorkflowExpression] Func<string> bodymoduleactivitymicroblog = null, [WorkflowExpression] Func<string> bodymoduledocumentdocid = null, [WorkflowExpression] Func<string> bodymoduleblogblogTitle = null, [WorkflowExpression] Func<string> bodymoduleblogblogContent = null, [WorkflowExpression] Func<int> bodymoduleblogshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleblogtagList = null, [WorkflowExpression] Func<int> bodymoduleblogstatus = null, [WorkflowExpression] Func<int> bodymoduleblogsiteId = null, [WorkflowExpression] Func<string> bodymoduleblogauthor = null, [WorkflowExpression] Func<string[]> bodymoduleblogcategoryList = null, [WorkflowExpression] Func<int> bodymoduleblognotificationTypeId = null, [WorkflowExpression] Func<string> bodymoduleblogmessage = null, [WorkflowExpression] Func<int> bodymoduleblogmessageCode = null, [WorkflowExpression] Func<string> bodymoduleblogexternalId = null, [WorkflowExpression] Func<string> bodymoduleblogpublishDate = null, [WorkflowExpression] Func<string> bodymoduleblogprocesstype = null, [WorkflowExpression] Func<string> bodymoduleblogenable = null, [WorkflowExpression] Func<int> bodymodulewikiwikiid = null, [WorkflowExpression] Func<int> bodymodulewikicurrentversionid = null, [WorkflowExpression] Func<int> bodymodulewikiparentwikiid = null, [WorkflowExpression] Func<string> bodymodulewikiwikititle = null, [WorkflowExpression] Func<string> bodymodulewikiwikicontent = null, [WorkflowExpression] Func<int> bodymodulewikishowcomment = null, [WorkflowExpression] Func<string> bodymodulewikicreateddate = null, [WorkflowExpression] Func<string> bodymodulewikimodifieddate = null, [WorkflowExpression] Func<string> bodymodulewikitaglist = null, [WorkflowExpression] Func<string> bodymodulewikiwikipath = null, [WorkflowExpression] Func<int> bodymodulewikiwikidraftid = null, [WorkflowExpression] Func<string> bodymodulewikidrafttype = null, [WorkflowExpression] Func<int> bodymodulewikistatus = null, [WorkflowExpression] Func<int> bodymodulewikiwikiversionid = null, [WorkflowExpression] Func<string> bodymoduletaskindex = null, [WorkflowExpression] Func<int> bodymoduletaskparenttaskid = null, [WorkflowExpression] Func<int> bodymoduletasktaskid = null, [WorkflowExpression] Func<string> bodymoduletasktitle = null, [WorkflowExpression] Func<string> bodymoduletaskdescription = null, [WorkflowExpression] Func<string> bodymoduletaskduedate = null, [WorkflowExpression] Func<string> bodymoduletaskstartdate = null, [WorkflowExpression] Func<string> bodymoduletaskmattermaptaskid = null, [WorkflowExpression] Func<string> bodymoduletasktype = null, [WorkflowExpression] Func<string> bodymoduletaskdependenton = null, [WorkflowExpression] Func<string> bodymoduletaskdaysfromdependent = null, [WorkflowExpression] Func<int> bodymoduletaskignoreweekend = null, [WorkflowExpression] Func<int> bodymoduletaskduration = null, [WorkflowExpression] Func<string> bodymoduletaskresource = null, [WorkflowExpression] Func<string> bodymoduleEventeventTitle = null, [WorkflowExpression] Func<string> bodymoduleEventeventContent = null, [WorkflowExpression] Func<int> bodymoduleEventshowComment = null, [WorkflowExpression] Func<string[]> bodymoduleEventtagList = null, [WorkflowExpression] Func<int> bodymoduleEventstatus = null, [WorkflowExpression] Func<int> bodymoduleEventsiteId = null, [WorkflowExpression] Func<string> bodymoduleEventcontact = null, [WorkflowExpression] Func<string[]> bodymoduleEventcategoryList = null, [WorkflowExpression] Func<int> bodymoduleEventnotificationTypeId = null, [WorkflowExpression] Func<string> bodymoduleEventmessage = null, [WorkflowExpression] Func<int> bodymoduleEventmessageCode = null, [WorkflowExpression] Func<string> bodymoduleEventexternalId = null, [WorkflowExpression] Func<string> bodymoduleEventstartDate = null, [WorkflowExpression] Func<string> bodymoduleEventendDate = null, [WorkflowExpression] Func<string> bodymoduleEventstartTime = null, [WorkflowExpression] Func<string> bodymoduleEventendTime = null, [WorkflowExpression] Func<string> bodymoduleEventlocation = null, [WorkflowExpression] Func<string> bodymoduleEventauthor = null, [WorkflowExpression] Func<string> bodymoduleEventprocesstype = null, [WorkflowExpression] Func<string> bodymoduleEventenable = null, [WorkflowExpression] Func<int> bodymoduleisheetid = null, [WorkflowExpression] Func<string> bodymoduleisheettitle = null, [WorkflowExpression] Func<string> bodymoduleisheetdescription = null, [WorkflowExpression] Func<string> bodymoduleisheetstatus = null, [WorkflowExpression] Func<string> bodymoduleisheetaccesstype = null, [WorkflowExpression] Func<string> bodymoduleisheettype = null, [WorkflowExpression] Func<string> bodymoduleisheetviewlink = null, [WorkflowExpression] Func<string> bodymoduleisheetallowsections = null, [WorkflowExpression] Func<string> bodymoduleisheetallowlookup = null, [WorkflowExpression] Func<string> bodymoduleisheetdisplayisheet = null, [WorkflowExpression] Func<string> bodymoduleisheetsearchasdefaultview = null, [WorkflowExpression] Func<string> bodymoduleisheetenableversion = null, [WorkflowExpression] Func<string> bodymoduleisheetenablesheetalerter = null, [WorkflowExpression] Func<string> bodymoduleisheetalertercondition = null, [WorkflowExpression] Func<string> bodymoduleisheetoverrideitemmodifieddate = null, [WorkflowExpression] Func<string> bodymoduleisheetenablebulkinsertupdate = null, [WorkflowExpression] Func<string> bodymoduleisheetfielddescriptions = null, [WorkflowExpression] Func<string> bodymoduleisheetenablerowlocking = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, [WorkflowExpression] Func<string> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, [WorkflowExpression] Func<string> bodymoduleisheetallowchoicelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowscorelistvaluesforreuse = null, [WorkflowExpression] Func<string> bodymoduleisheetallowIsheetComments = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimit = null, [WorkflowExpression] Func<int> bodymoduleisheetshareRecordsLimitEnabled = null, [WorkflowExpression] Func<string> bodymoduleisheetenableIsheetAddRecordFormSharing = null, [WorkflowExpression] Func<string> bodymoduleisheetrecordcount = null, [WorkflowExpression] Func<int> bodymoduleisheetsheettypeid = null, [WorkflowExpression] Func<string> bodymoduleqaenable = null, [WorkflowExpression] Func<PersonDBO[]> bodymodulepeopleperson = null, [WorkflowExpression] Func<string> bodymodulecontractexpressenable = null, [WorkflowExpression] Func<string> bodyadminnote = null, [WorkflowExpression] Func<string> bodystartdate = null, [WorkflowExpression] Func<string> bodyenddate = null, [WorkflowExpression] Func<string> bodycreateddate = null, [WorkflowExpression] Func<string> bodyarchiveddate = null, [WorkflowExpression] Func<string> bodyclientno = null, [WorkflowExpression] Func<string> bodymatterno = null, [WorkflowExpression] Func<string> bodylandingpage = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodystatusid = null, [WorkflowExpression] Func<string> bodysize = null, [WorkflowExpression] Func<string> bodybillingnotes = null, [WorkflowExpression] Func<string> bodybillingnextinvoicedate = null, [WorkflowExpression] Func<string> bodybillinglastinvoicedate = null, [WorkflowExpression] Func<string> bodyfilepagecount = null, [WorkflowExpression] Func<string> bodymaxpagecount = null, [WorkflowExpression] Func<string> bodysitehttplink = null, [WorkflowExpression] Func<int> bodyisSyncable = null, [WorkflowExpression] Func<string> bodyenforceusergroups = null, [WorkflowExpression] Func<string> bodycsvSiteCategory = null, [WorkflowExpression] Func<string> bodysiteNameInDefaultLanguage = null, [WorkflowExpression] Func<int> bodyvisible = null, [WorkflowExpression] Func<string> bodysiteLogoName = null, [WorkflowExpression] Func<int> bodysiteLogoFileSize = null, [WorkflowExpression] Func<int> bodysiteLogoHeight = null, [WorkflowExpression] Func<int> bodysiteLogoWidth = null, [WorkflowExpression] Func<int> bodysiteStatus = null, [WorkflowExpression] Func<int> bodyapplySiteTerms = null, [WorkflowExpression] Func<string> bodysiteTerm = null, [WorkflowExpression] Func<int> bodytermType = null, [WorkflowExpression] Func<int> bodynextLoginSiteTerms = null, [WorkflowExpression] Func<int> bodydefaultSiteTermsEnable = null, [WorkflowExpression] Func<int> bodyadvancedQAPermission = null, [WorkflowExpression] Func<int> bodyisInternal = null, [WorkflowExpression] Func<int> bodypsm = null, [WorkflowExpression] Func<string> bodysiteLabelDisplay = null, [WorkflowExpression] Func<int> bodyallowSiteAdministration = null, [WorkflowExpression] Func<int> bodysiteLevelPasswordEnable = null, [WorkflowExpression] Func<int> bodysiteLevelPasscodeEnable = null, [WorkflowExpression] Func<int> bodypasscodeUsingAuthApp = null, [WorkflowExpression] Func<string> bodysitePassword = null, [WorkflowExpression] Func<int> bodyipRestrictionEnable = null, [WorkflowExpression] Func<string> bodyavailableIP = null, [WorkflowExpression] Func<int> bodyhighqDrive = null, [WorkflowExpression] Func<int> bodyapplySiteHomePage = null, [WorkflowExpression] Func<string> bodysiteHomePage = null, [WorkflowExpression] Func<int> bodysiteHomePageType = null, [WorkflowExpression] Func<int> bodynextLoginSiteHomePage = null, [WorkflowExpression] Func<int> bodyapplyDisplayContent = null, [WorkflowExpression] Func<string> bodydisplayContent = null, [WorkflowExpression] Func<int> bodyrssSecurity = null, [WorkflowExpression] Func<int> bodyencryptedPassword = null, [WorkflowExpression] Func<string> bodyavailableIPRangeCSV = null, [WorkflowExpression] Func<int> bodysiteModuleId = null, [WorkflowExpression] Func<int> bodyicalSecurity = null, [WorkflowExpression] Func<string> bodydefaultDisplayContent = null, [WorkflowExpression] Func<int> bodydefaultEmailAlert = null, [WorkflowExpression] Func<int> bodyexcelReportFooter = null, [WorkflowExpression] Func<string> bodyexcelReportFooterText = null, [WorkflowExpression] Func<string> bodyannouncementMLJSON = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<int> bodytemplateLicence = null, [WorkflowExpression] Func<string> bodyopenChannelAppId = null, [WorkflowExpression] Func<int> bodyitemid = null, [WorkflowExpression] Func<int> bodysitemetadatasheetid = null, [WorkflowExpression] Func<bool> bodymysite = null, [WorkflowExpression] Func<string> bodylastaccesseddate = null, [WorkflowExpression] Func<int> bodydefaultViewerMetaDataTab = null, [WorkflowExpression] Func<int> bodydocumentMetadataViewId = null, [WorkflowExpression] Func<int> bodyfolderMetadataViewId = null, [WorkflowExpression] Func<int> bodydocSort = null, [WorkflowExpression] Func<int> bodyfolderSort = null, [WorkflowExpression] Func<int> bodydefaultFolderRenderView = null, [WorkflowExpression] Func<int> bodyisTaskAttachmentDefault = null, [WorkflowExpression] Func<int> bodytaskAttachmentDefaultFolderId = null, [WorkflowExpression] Func<string> bodyfavourite = null, [WorkflowExpression] Func<bool> bodyenabledocumentredaction = null, [WorkflowExpression] Func<int> bodymentiongroups = null, [WorkflowExpression] Func<bool> bodyenablefilerelationships = null, [WorkflowExpression] Func<int> bodyfilerelationshipsitepermissionlevel = null)
        {
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(siteid, nameof(siteid), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodysitename, nameof(bodysitename), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodysitedescription, nameof(bodysitedescription), required: false);
            SourceExpression.Validate(bodyenabledmodules, nameof(bodyenabledmodules), required: false);
            SourceExpression.Validate(bodysitefolderId, nameof(bodysitefolderId), required: false);
            SourceExpression.Validate(bodysitefolderpermission, nameof(bodysitefolderpermission), required: false);
            SourceExpression.Validate(bodymodulehomeenable, nameof(bodymodulehomeenable), required: false);
            SourceExpression.Validate(bodymoduleactivityenable, nameof(bodymoduleactivityenable), required: false);
            SourceExpression.Validate(bodymoduleactivitymicroblog, nameof(bodymoduleactivitymicroblog), required: false);
            SourceExpression.Validate(bodymoduledocumentdocid, nameof(bodymoduledocumentdocid), required: false);
            SourceExpression.Validate(bodymoduleblogblogTitle, nameof(bodymoduleblogblogTitle), required: false);
            SourceExpression.Validate(bodymoduleblogblogContent, nameof(bodymoduleblogblogContent), required: false);
            SourceExpression.Validate(bodymoduleblogshowComment, nameof(bodymoduleblogshowComment), required: false);
            SourceExpression.Validate(bodymoduleblogtagList, nameof(bodymoduleblogtagList), required: false);
            SourceExpression.Validate(bodymoduleblogstatus, nameof(bodymoduleblogstatus), required: false);
            SourceExpression.Validate(bodymoduleblogsiteId, nameof(bodymoduleblogsiteId), required: false);
            SourceExpression.Validate(bodymoduleblogauthor, nameof(bodymoduleblogauthor), required: false);
            SourceExpression.Validate(bodymoduleblogcategoryList, nameof(bodymoduleblogcategoryList), required: false);
            SourceExpression.Validate(bodymoduleblognotificationTypeId, nameof(bodymoduleblognotificationTypeId), required: false);
            SourceExpression.Validate(bodymoduleblogmessage, nameof(bodymoduleblogmessage), required: false);
            SourceExpression.Validate(bodymoduleblogmessageCode, nameof(bodymoduleblogmessageCode), required: false);
            SourceExpression.Validate(bodymoduleblogexternalId, nameof(bodymoduleblogexternalId), required: false);
            SourceExpression.Validate(bodymoduleblogpublishDate, nameof(bodymoduleblogpublishDate), required: false);
            SourceExpression.Validate(bodymoduleblogprocesstype, nameof(bodymoduleblogprocesstype), required: false);
            SourceExpression.Validate(bodymoduleblogenable, nameof(bodymoduleblogenable), required: false);
            SourceExpression.Validate(bodymodulewikiwikiid, nameof(bodymodulewikiwikiid), required: false);
            SourceExpression.Validate(bodymodulewikicurrentversionid, nameof(bodymodulewikicurrentversionid), required: false);
            SourceExpression.Validate(bodymodulewikiparentwikiid, nameof(bodymodulewikiparentwikiid), required: false);
            SourceExpression.Validate(bodymodulewikiwikititle, nameof(bodymodulewikiwikititle), required: false);
            SourceExpression.Validate(bodymodulewikiwikicontent, nameof(bodymodulewikiwikicontent), required: false);
            SourceExpression.Validate(bodymodulewikishowcomment, nameof(bodymodulewikishowcomment), required: false);
            SourceExpression.Validate(bodymodulewikicreateddate, nameof(bodymodulewikicreateddate), required: false);
            SourceExpression.Validate(bodymodulewikimodifieddate, nameof(bodymodulewikimodifieddate), required: false);
            SourceExpression.Validate(bodymodulewikitaglist, nameof(bodymodulewikitaglist), required: false);
            SourceExpression.Validate(bodymodulewikiwikipath, nameof(bodymodulewikiwikipath), required: false);
            SourceExpression.Validate(bodymodulewikiwikidraftid, nameof(bodymodulewikiwikidraftid), required: false);
            SourceExpression.Validate(bodymodulewikidrafttype, nameof(bodymodulewikidrafttype), required: false);
            SourceExpression.Validate(bodymodulewikistatus, nameof(bodymodulewikistatus), required: false);
            SourceExpression.Validate(bodymodulewikiwikiversionid, nameof(bodymodulewikiwikiversionid), required: false);
            SourceExpression.Validate(bodymoduletaskindex, nameof(bodymoduletaskindex), required: false);
            SourceExpression.Validate(bodymoduletaskparenttaskid, nameof(bodymoduletaskparenttaskid), required: false);
            SourceExpression.Validate(bodymoduletasktaskid, nameof(bodymoduletasktaskid), required: false);
            SourceExpression.Validate(bodymoduletasktitle, nameof(bodymoduletasktitle), required: false);
            SourceExpression.Validate(bodymoduletaskdescription, nameof(bodymoduletaskdescription), required: false);
            SourceExpression.Validate(bodymoduletaskduedate, nameof(bodymoduletaskduedate), required: false);
            SourceExpression.Validate(bodymoduletaskstartdate, nameof(bodymoduletaskstartdate), required: false);
            SourceExpression.Validate(bodymoduletaskmattermaptaskid, nameof(bodymoduletaskmattermaptaskid), required: false);
            SourceExpression.Validate(bodymoduletasktype, nameof(bodymoduletasktype), required: false);
            SourceExpression.Validate(bodymoduletaskdependenton, nameof(bodymoduletaskdependenton), required: false);
            SourceExpression.Validate(bodymoduletaskdaysfromdependent, nameof(bodymoduletaskdaysfromdependent), required: false);
            SourceExpression.Validate(bodymoduletaskignoreweekend, nameof(bodymoduletaskignoreweekend), required: false);
            SourceExpression.Validate(bodymoduletaskduration, nameof(bodymoduletaskduration), required: false);
            SourceExpression.Validate(bodymoduletaskresource, nameof(bodymoduletaskresource), required: false);
            SourceExpression.Validate(bodymoduleEventeventTitle, nameof(bodymoduleEventeventTitle), required: false);
            SourceExpression.Validate(bodymoduleEventeventContent, nameof(bodymoduleEventeventContent), required: false);
            SourceExpression.Validate(bodymoduleEventshowComment, nameof(bodymoduleEventshowComment), required: false);
            SourceExpression.Validate(bodymoduleEventtagList, nameof(bodymoduleEventtagList), required: false);
            SourceExpression.Validate(bodymoduleEventstatus, nameof(bodymoduleEventstatus), required: false);
            SourceExpression.Validate(bodymoduleEventsiteId, nameof(bodymoduleEventsiteId), required: false);
            SourceExpression.Validate(bodymoduleEventcontact, nameof(bodymoduleEventcontact), required: false);
            SourceExpression.Validate(bodymoduleEventcategoryList, nameof(bodymoduleEventcategoryList), required: false);
            SourceExpression.Validate(bodymoduleEventnotificationTypeId, nameof(bodymoduleEventnotificationTypeId), required: false);
            SourceExpression.Validate(bodymoduleEventmessage, nameof(bodymoduleEventmessage), required: false);
            SourceExpression.Validate(bodymoduleEventmessageCode, nameof(bodymoduleEventmessageCode), required: false);
            SourceExpression.Validate(bodymoduleEventexternalId, nameof(bodymoduleEventexternalId), required: false);
            SourceExpression.Validate(bodymoduleEventstartDate, nameof(bodymoduleEventstartDate), required: false);
            SourceExpression.Validate(bodymoduleEventendDate, nameof(bodymoduleEventendDate), required: false);
            SourceExpression.Validate(bodymoduleEventstartTime, nameof(bodymoduleEventstartTime), required: false);
            SourceExpression.Validate(bodymoduleEventendTime, nameof(bodymoduleEventendTime), required: false);
            SourceExpression.Validate(bodymoduleEventlocation, nameof(bodymoduleEventlocation), required: false);
            SourceExpression.Validate(bodymoduleEventauthor, nameof(bodymoduleEventauthor), required: false);
            SourceExpression.Validate(bodymoduleEventprocesstype, nameof(bodymoduleEventprocesstype), required: false);
            SourceExpression.Validate(bodymoduleEventenable, nameof(bodymoduleEventenable), required: false);
            SourceExpression.Validate(bodymoduleisheetid, nameof(bodymoduleisheetid), required: false);
            SourceExpression.Validate(bodymoduleisheettitle, nameof(bodymoduleisheettitle), required: false);
            SourceExpression.Validate(bodymoduleisheetdescription, nameof(bodymoduleisheetdescription), required: false);
            SourceExpression.Validate(bodymoduleisheetstatus, nameof(bodymoduleisheetstatus), required: false);
            SourceExpression.Validate(bodymoduleisheetaccesstype, nameof(bodymoduleisheetaccesstype), required: false);
            SourceExpression.Validate(bodymoduleisheettype, nameof(bodymoduleisheettype), required: false);
            SourceExpression.Validate(bodymoduleisheetviewlink, nameof(bodymoduleisheetviewlink), required: false);
            SourceExpression.Validate(bodymoduleisheetallowsections, nameof(bodymoduleisheetallowsections), required: false);
            SourceExpression.Validate(bodymoduleisheetallowlookup, nameof(bodymoduleisheetallowlookup), required: false);
            SourceExpression.Validate(bodymoduleisheetdisplayisheet, nameof(bodymoduleisheetdisplayisheet), required: false);
            SourceExpression.Validate(bodymoduleisheetsearchasdefaultview, nameof(bodymoduleisheetsearchasdefaultview), required: false);
            SourceExpression.Validate(bodymoduleisheetenableversion, nameof(bodymoduleisheetenableversion), required: false);
            SourceExpression.Validate(bodymoduleisheetenablesheetalerter, nameof(bodymoduleisheetenablesheetalerter), required: false);
            SourceExpression.Validate(bodymoduleisheetalertercondition, nameof(bodymoduleisheetalertercondition), required: false);
            SourceExpression.Validate(bodymoduleisheetoverrideitemmodifieddate, nameof(bodymoduleisheetoverrideitemmodifieddate), required: false);
            SourceExpression.Validate(bodymoduleisheetenablebulkinsertupdate, nameof(bodymoduleisheetenablebulkinsertupdate), required: false);
            SourceExpression.Validate(bodymoduleisheetfielddescriptions, nameof(bodymoduleisheetfielddescriptions), required: false);
            SourceExpression.Validate(bodymoduleisheetenablerowlocking, nameof(bodymoduleisheetenablerowlocking), required: false);
            SourceExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextenabled, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextenabled), required: false);
            SourceExpression.Validate(bodymoduleisheetsetcharlimittruncatemultilinetextval, nameof(bodymoduleisheetsetcharlimittruncatemultilinetextval), required: false);
            SourceExpression.Validate(bodymoduleisheetallowchoicelistvaluesforreuse, nameof(bodymoduleisheetallowchoicelistvaluesforreuse), required: false);
            SourceExpression.Validate(bodymoduleisheetallowscorelistvaluesforreuse, nameof(bodymoduleisheetallowscorelistvaluesforreuse), required: false);
            SourceExpression.Validate(bodymoduleisheetallowIsheetComments, nameof(bodymoduleisheetallowIsheetComments), required: false);
            SourceExpression.Validate(bodymoduleisheetshareRecordsLimit, nameof(bodymoduleisheetshareRecordsLimit), required: false);
            SourceExpression.Validate(bodymoduleisheetshareRecordsLimitEnabled, nameof(bodymoduleisheetshareRecordsLimitEnabled), required: false);
            SourceExpression.Validate(bodymoduleisheetenableIsheetAddRecordFormSharing, nameof(bodymoduleisheetenableIsheetAddRecordFormSharing), required: false);
            SourceExpression.Validate(bodymoduleisheetrecordcount, nameof(bodymoduleisheetrecordcount), required: false);
            SourceExpression.Validate(bodymoduleisheetsheettypeid, nameof(bodymoduleisheetsheettypeid), required: false);
            SourceExpression.Validate(bodymoduleqaenable, nameof(bodymoduleqaenable), required: false);
            SourceExpression.Validate(bodymodulepeopleperson, nameof(bodymodulepeopleperson), required: false);
            SourceExpression.Validate(bodymodulecontractexpressenable, nameof(bodymodulecontractexpressenable), required: false);
            SourceExpression.Validate(bodyadminnote, nameof(bodyadminnote), required: false);
            SourceExpression.Validate(bodystartdate, nameof(bodystartdate), required: false);
            SourceExpression.Validate(bodyenddate, nameof(bodyenddate), required: false);
            SourceExpression.Validate(bodycreateddate, nameof(bodycreateddate), required: false);
            SourceExpression.Validate(bodyarchiveddate, nameof(bodyarchiveddate), required: false);
            SourceExpression.Validate(bodyclientno, nameof(bodyclientno), required: false);
            SourceExpression.Validate(bodymatterno, nameof(bodymatterno), required: false);
            SourceExpression.Validate(bodylandingpage, nameof(bodylandingpage), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodystatusid, nameof(bodystatusid), required: false);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: false);
            SourceExpression.Validate(bodybillingnotes, nameof(bodybillingnotes), required: false);
            SourceExpression.Validate(bodybillingnextinvoicedate, nameof(bodybillingnextinvoicedate), required: false);
            SourceExpression.Validate(bodybillinglastinvoicedate, nameof(bodybillinglastinvoicedate), required: false);
            SourceExpression.Validate(bodyfilepagecount, nameof(bodyfilepagecount), required: false);
            SourceExpression.Validate(bodymaxpagecount, nameof(bodymaxpagecount), required: false);
            SourceExpression.Validate(bodysitehttplink, nameof(bodysitehttplink), required: false);
            SourceExpression.Validate(bodyisSyncable, nameof(bodyisSyncable), required: false);
            SourceExpression.Validate(bodyenforceusergroups, nameof(bodyenforceusergroups), required: false);
            SourceExpression.Validate(bodycsvSiteCategory, nameof(bodycsvSiteCategory), required: false);
            SourceExpression.Validate(bodysiteNameInDefaultLanguage, nameof(bodysiteNameInDefaultLanguage), required: false);
            SourceExpression.Validate(bodyvisible, nameof(bodyvisible), required: false);
            SourceExpression.Validate(bodysiteLogoName, nameof(bodysiteLogoName), required: false);
            SourceExpression.Validate(bodysiteLogoFileSize, nameof(bodysiteLogoFileSize), required: false);
            SourceExpression.Validate(bodysiteLogoHeight, nameof(bodysiteLogoHeight), required: false);
            SourceExpression.Validate(bodysiteLogoWidth, nameof(bodysiteLogoWidth), required: false);
            SourceExpression.Validate(bodysiteStatus, nameof(bodysiteStatus), required: false);
            SourceExpression.Validate(bodyapplySiteTerms, nameof(bodyapplySiteTerms), required: false);
            SourceExpression.Validate(bodysiteTerm, nameof(bodysiteTerm), required: false);
            SourceExpression.Validate(bodytermType, nameof(bodytermType), required: false);
            SourceExpression.Validate(bodynextLoginSiteTerms, nameof(bodynextLoginSiteTerms), required: false);
            SourceExpression.Validate(bodydefaultSiteTermsEnable, nameof(bodydefaultSiteTermsEnable), required: false);
            SourceExpression.Validate(bodyadvancedQAPermission, nameof(bodyadvancedQAPermission), required: false);
            SourceExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            SourceExpression.Validate(bodypsm, nameof(bodypsm), required: false);
            SourceExpression.Validate(bodysiteLabelDisplay, nameof(bodysiteLabelDisplay), required: false);
            SourceExpression.Validate(bodyallowSiteAdministration, nameof(bodyallowSiteAdministration), required: false);
            SourceExpression.Validate(bodysiteLevelPasswordEnable, nameof(bodysiteLevelPasswordEnable), required: false);
            SourceExpression.Validate(bodysiteLevelPasscodeEnable, nameof(bodysiteLevelPasscodeEnable), required: false);
            SourceExpression.Validate(bodypasscodeUsingAuthApp, nameof(bodypasscodeUsingAuthApp), required: false);
            SourceExpression.Validate(bodysitePassword, nameof(bodysitePassword), required: false);
            SourceExpression.Validate(bodyipRestrictionEnable, nameof(bodyipRestrictionEnable), required: false);
            SourceExpression.Validate(bodyavailableIP, nameof(bodyavailableIP), required: false);
            SourceExpression.Validate(bodyhighqDrive, nameof(bodyhighqDrive), required: false);
            SourceExpression.Validate(bodyapplySiteHomePage, nameof(bodyapplySiteHomePage), required: false);
            SourceExpression.Validate(bodysiteHomePage, nameof(bodysiteHomePage), required: false);
            SourceExpression.Validate(bodysiteHomePageType, nameof(bodysiteHomePageType), required: false);
            SourceExpression.Validate(bodynextLoginSiteHomePage, nameof(bodynextLoginSiteHomePage), required: false);
            SourceExpression.Validate(bodyapplyDisplayContent, nameof(bodyapplyDisplayContent), required: false);
            SourceExpression.Validate(bodydisplayContent, nameof(bodydisplayContent), required: false);
            SourceExpression.Validate(bodyrssSecurity, nameof(bodyrssSecurity), required: false);
            SourceExpression.Validate(bodyencryptedPassword, nameof(bodyencryptedPassword), required: false);
            SourceExpression.Validate(bodyavailableIPRangeCSV, nameof(bodyavailableIPRangeCSV), required: false);
            SourceExpression.Validate(bodysiteModuleId, nameof(bodysiteModuleId), required: false);
            SourceExpression.Validate(bodyicalSecurity, nameof(bodyicalSecurity), required: false);
            SourceExpression.Validate(bodydefaultDisplayContent, nameof(bodydefaultDisplayContent), required: false);
            SourceExpression.Validate(bodydefaultEmailAlert, nameof(bodydefaultEmailAlert), required: false);
            SourceExpression.Validate(bodyexcelReportFooter, nameof(bodyexcelReportFooter), required: false);
            SourceExpression.Validate(bodyexcelReportFooterText, nameof(bodyexcelReportFooterText), required: false);
            SourceExpression.Validate(bodyannouncementMLJSON, nameof(bodyannouncementMLJSON), required: false);
            SourceExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            SourceExpression.Validate(bodytemplateLicence, nameof(bodytemplateLicence), required: false);
            SourceExpression.Validate(bodyopenChannelAppId, nameof(bodyopenChannelAppId), required: false);
            SourceExpression.Validate(bodyitemid, nameof(bodyitemid), required: false);
            SourceExpression.Validate(bodysitemetadatasheetid, nameof(bodysitemetadatasheetid), required: false);
            SourceExpression.Validate(bodymysite, nameof(bodymysite), required: false);
            SourceExpression.Validate(bodylastaccesseddate, nameof(bodylastaccesseddate), required: false);
            SourceExpression.Validate(bodydefaultViewerMetaDataTab, nameof(bodydefaultViewerMetaDataTab), required: false);
            SourceExpression.Validate(bodydocumentMetadataViewId, nameof(bodydocumentMetadataViewId), required: false);
            SourceExpression.Validate(bodyfolderMetadataViewId, nameof(bodyfolderMetadataViewId), required: false);
            SourceExpression.Validate(bodydocSort, nameof(bodydocSort), required: false);
            SourceExpression.Validate(bodyfolderSort, nameof(bodyfolderSort), required: false);
            SourceExpression.Validate(bodydefaultFolderRenderView, nameof(bodydefaultFolderRenderView), required: false);
            SourceExpression.Validate(bodyisTaskAttachmentDefault, nameof(bodyisTaskAttachmentDefault), required: false);
            SourceExpression.Validate(bodytaskAttachmentDefaultFolderId, nameof(bodytaskAttachmentDefaultFolderId), required: false);
            SourceExpression.Validate(bodyfavourite, nameof(bodyfavourite), required: false);
            SourceExpression.Validate(bodyenabledocumentredaction, nameof(bodyenabledocumentredaction), required: false);
            SourceExpression.Validate(bodymentiongroups, nameof(bodymentiongroups), required: false);
            SourceExpression.Validate(bodyenablefilerelationships, nameof(bodyenablefilerelationships), required: false);
            SourceExpression.Validate(bodyfilerelationshipsitepermissionlevel, nameof(bodyfilerelationshipsitepermissionlevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/sites/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(siteid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodysitename != null)
                {
                    body["sitename"] = SourceExpressionConverter.ConvertToken(bodysitename);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodysitedescription != null)
                {
                    body["sitedescription"] = SourceExpressionConverter.ConvertToken(bodysitedescription);
                    bodypropCount++;
                }

                if (bodyenabledmodules != null)
                {
                    body["enabledmodules"] = SourceExpressionConverter.ConvertToken(bodyenabledmodules);
                    bodypropCount++;
                }

                if (bodysitefolderId != null)
                {
                    body["sitefolderID"] = SourceExpressionConverter.ConvertToken(bodysitefolderId);
                    bodypropCount++;
                }

                if (bodysitefolderpermission != null)
                {
                    body["sitefolderpermission"] = SourceExpressionConverter.ConvertToken(bodysitefolderpermission);
                    bodypropCount++;
                }

                var moduleObject = new JObject();
                var moduleObjectpropCount = 0;
                var homeObject = new JObject();
                var homeObjectpropCount = 0;
                if (bodymodulehomeenable != null)
                {
                    homeObject["enable"] = SourceExpressionConverter.ConvertToken(bodymodulehomeenable);
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
                    activityObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleactivityenable);
                    activityObjectpropCount++;
                }

                if (bodymoduleactivitymicroblog != null)
                {
                    activityObject["microblog"] = SourceExpressionConverter.ConvertToken(bodymoduleactivitymicroblog);
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
                    documentObject["docid"] = SourceExpressionConverter.ConvertToken(bodymoduledocumentdocid);
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
                    blogObject["blogTitle"] = SourceExpressionConverter.ConvertToken(bodymoduleblogblogTitle);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogblogContent != null)
                {
                    blogObject["blogContent"] = SourceExpressionConverter.ConvertToken(bodymoduleblogblogContent);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogshowComment != null)
                {
                    blogObject["showComment"] = SourceExpressionConverter.ConvertToken(bodymoduleblogshowComment);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogtagList != null)
                {
                    blogObject["tagList"] = SourceExpressionConverter.ConvertToken(bodymoduleblogtagList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogstatus != null)
                {
                    blogObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleblogstatus);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogsiteId != null)
                {
                    blogObject["siteID"] = SourceExpressionConverter.ConvertToken(bodymoduleblogsiteId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogauthor != null)
                {
                    blogObject["author"] = SourceExpressionConverter.ConvertToken(bodymoduleblogauthor);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogcategoryList != null)
                {
                    blogObject["categoryList"] = SourceExpressionConverter.ConvertToken(bodymoduleblogcategoryList);
                    blogObjectpropCount++;
                }

                if (bodymoduleblognotificationTypeId != null)
                {
                    blogObject["notificationTypeID"] = SourceExpressionConverter.ConvertToken(bodymoduleblognotificationTypeId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessage != null)
                {
                    blogObject["message"] = SourceExpressionConverter.ConvertToken(bodymoduleblogmessage);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogmessageCode != null)
                {
                    blogObject["messageCode"] = SourceExpressionConverter.ConvertToken(bodymoduleblogmessageCode);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogexternalId != null)
                {
                    blogObject["externalID"] = SourceExpressionConverter.ConvertToken(bodymoduleblogexternalId);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogpublishDate != null)
                {
                    blogObject["publishDate"] = SourceExpressionConverter.ConvertToken(bodymoduleblogpublishDate);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogprocesstype != null)
                {
                    blogObject["processtype"] = SourceExpressionConverter.ConvertToken(bodymoduleblogprocesstype);
                    blogObjectpropCount++;
                }

                if (bodymoduleblogenable != null)
                {
                    blogObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleblogenable);
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
                    wikiObject["wikiid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicurrentversionid != null)
                {
                    wikiObject["currentversionid"] = SourceExpressionConverter.ConvertToken(bodymodulewikicurrentversionid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiparentwikiid != null)
                {
                    wikiObject["parentwikiid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiparentwikiid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikititle != null)
                {
                    wikiObject["wikititle"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikititle);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikicontent != null)
                {
                    wikiObject["wikicontent"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikicontent);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikishowcomment != null)
                {
                    wikiObject["showcomment"] = SourceExpressionConverter.ConvertToken(bodymodulewikishowcomment);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikicreateddate != null)
                {
                    wikiObject["createddate"] = SourceExpressionConverter.ConvertToken(bodymodulewikicreateddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikimodifieddate != null)
                {
                    wikiObject["modifieddate"] = SourceExpressionConverter.ConvertToken(bodymodulewikimodifieddate);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikitaglist != null)
                {
                    wikiObject["taglist"] = SourceExpressionConverter.ConvertToken(bodymodulewikitaglist);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikipath != null)
                {
                    wikiObject["wikipath"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikipath);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikidraftid != null)
                {
                    wikiObject["wikidraftid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikidraftid);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikidrafttype != null)
                {
                    wikiObject["drafttype"] = SourceExpressionConverter.ConvertToken(bodymodulewikidrafttype);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikistatus != null)
                {
                    wikiObject["status"] = SourceExpressionConverter.ConvertToken(bodymodulewikistatus);
                    wikiObjectpropCount++;
                }

                if (bodymodulewikiwikiversionid != null)
                {
                    wikiObject["wikiversionid"] = SourceExpressionConverter.ConvertToken(bodymodulewikiwikiversionid);
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
                    taskObject["index"] = SourceExpressionConverter.ConvertToken(bodymoduletaskindex);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskparenttaskid != null)
                {
                    taskObject["parenttaskid"] = SourceExpressionConverter.ConvertToken(bodymoduletaskparenttaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktaskid != null)
                {
                    taskObject["taskid"] = SourceExpressionConverter.ConvertToken(bodymoduletasktaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktitle != null)
                {
                    taskObject["title"] = SourceExpressionConverter.ConvertToken(bodymoduletasktitle);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdescription != null)
                {
                    taskObject["description"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdescription);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduedate != null)
                {
                    taskObject["duedate"] = SourceExpressionConverter.ConvertToken(bodymoduletaskduedate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskstartdate != null)
                {
                    taskObject["startdate"] = SourceExpressionConverter.ConvertToken(bodymoduletaskstartdate);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskmattermaptaskid != null)
                {
                    taskObject["mattermaptaskid"] = SourceExpressionConverter.ConvertToken(bodymoduletaskmattermaptaskid);
                    taskObjectpropCount++;
                }

                if (bodymoduletasktype != null)
                {
                    taskObject["type"] = SourceExpressionConverter.ConvertToken(bodymoduletasktype);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdependenton != null)
                {
                    taskObject["dependenton"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdependenton);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskdaysfromdependent != null)
                {
                    taskObject["daysfromdependent"] = SourceExpressionConverter.ConvertToken(bodymoduletaskdaysfromdependent);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskignoreweekend != null)
                {
                    taskObject["ignoreweekend"] = SourceExpressionConverter.ConvertToken(bodymoduletaskignoreweekend);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskduration != null)
                {
                    taskObject["duration"] = SourceExpressionConverter.ConvertToken(bodymoduletaskduration);
                    taskObjectpropCount++;
                }

                if (bodymoduletaskresource != null)
                {
                    taskObject["resource"] = SourceExpressionConverter.ConvertToken(bodymoduletaskresource);
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
                    @eventObject["eventTitle"] = SourceExpressionConverter.ConvertToken(bodymoduleEventeventTitle);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventeventContent != null)
                {
                    @eventObject["eventContent"] = SourceExpressionConverter.ConvertToken(bodymoduleEventeventContent);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventshowComment != null)
                {
                    @eventObject["showComment"] = SourceExpressionConverter.ConvertToken(bodymoduleEventshowComment);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventtagList != null)
                {
                    @eventObject["tagList"] = SourceExpressionConverter.ConvertToken(bodymoduleEventtagList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstatus != null)
                {
                    @eventObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstatus);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventsiteId != null)
                {
                    @eventObject["siteID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventsiteId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcontact != null)
                {
                    @eventObject["contact"] = SourceExpressionConverter.ConvertToken(bodymoduleEventcontact);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventcategoryList != null)
                {
                    @eventObject["categoryList"] = SourceExpressionConverter.ConvertToken(bodymoduleEventcategoryList);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventnotificationTypeId != null)
                {
                    @eventObject["notificationTypeID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventnotificationTypeId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessage != null)
                {
                    @eventObject["message"] = SourceExpressionConverter.ConvertToken(bodymoduleEventmessage);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventmessageCode != null)
                {
                    @eventObject["messageCode"] = SourceExpressionConverter.ConvertToken(bodymoduleEventmessageCode);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventexternalId != null)
                {
                    @eventObject["externalID"] = SourceExpressionConverter.ConvertToken(bodymoduleEventexternalId);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartDate != null)
                {
                    @eventObject["startDate"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstartDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendDate != null)
                {
                    @eventObject["endDate"] = SourceExpressionConverter.ConvertToken(bodymoduleEventendDate);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventstartTime != null)
                {
                    @eventObject["startTime"] = SourceExpressionConverter.ConvertToken(bodymoduleEventstartTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventendTime != null)
                {
                    @eventObject["endTime"] = SourceExpressionConverter.ConvertToken(bodymoduleEventendTime);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventlocation != null)
                {
                    @eventObject["location"] = SourceExpressionConverter.ConvertToken(bodymoduleEventlocation);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventauthor != null)
                {
                    @eventObject["author"] = SourceExpressionConverter.ConvertToken(bodymoduleEventauthor);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventprocesstype != null)
                {
                    @eventObject["processtype"] = SourceExpressionConverter.ConvertToken(bodymoduleEventprocesstype);
                    @eventObjectpropCount++;
                }

                if (bodymoduleEventenable != null)
                {
                    @eventObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleEventenable);
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
                    isheetObject["id"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetid);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettitle != null)
                {
                    isheetObject["title"] = SourceExpressionConverter.ConvertToken(bodymoduleisheettitle);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdescription != null)
                {
                    isheetObject["description"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetdescription);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetstatus != null)
                {
                    isheetObject["status"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetstatus);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetaccesstype != null)
                {
                    isheetObject["accesstype"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetaccesstype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheettype != null)
                {
                    isheetObject["type"] = SourceExpressionConverter.ConvertToken(bodymoduleisheettype);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetviewlink != null)
                {
                    isheetObject["viewlink"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetviewlink);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowsections != null)
                {
                    isheetObject["allowsections"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowsections);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowlookup != null)
                {
                    isheetObject["allowlookup"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowlookup);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetdisplayisheet != null)
                {
                    isheetObject["displayisheet"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetdisplayisheet);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsearchasdefaultview != null)
                {
                    isheetObject["searchasdefaultview"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsearchasdefaultview);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableversion != null)
                {
                    isheetObject["enableversion"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenableversion);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablesheetalerter != null)
                {
                    isheetObject["enablesheetalerter"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablesheetalerter);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetalertercondition != null)
                {
                    isheetObject["alertercondition"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetalertercondition);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetoverrideitemmodifieddate != null)
                {
                    isheetObject["overrideitemmodifieddate"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetoverrideitemmodifieddate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablebulkinsertupdate != null)
                {
                    isheetObject["enablebulkinsertupdate"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablebulkinsertupdate);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetfielddescriptions != null)
                {
                    isheetObject["fielddescriptions"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetfielddescriptions);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenablerowlocking != null)
                {
                    isheetObject["enablerowlocking"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenablerowlocking);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextenabled != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextenabled"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsetcharlimittruncatemultilinetextenabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsetcharlimittruncatemultilinetextval != null)
                {
                    isheetObject["setcharlimittruncatemultilinetextval"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsetcharlimittruncatemultilinetextval);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowchoicelistvaluesforreuse != null)
                {
                    isheetObject["allowchoicelistvaluesforreuse"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowchoicelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowscorelistvaluesforreuse != null)
                {
                    isheetObject["allowscorelistvaluesforreuse"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowscorelistvaluesforreuse);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetallowIsheetComments != null)
                {
                    isheetObject["allowIsheetComments"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetallowIsheetComments);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimit != null)
                {
                    isheetObject["shareRecordsLimit"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetshareRecordsLimit);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetshareRecordsLimitEnabled != null)
                {
                    isheetObject["shareRecordsLimitEnabled"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetshareRecordsLimitEnabled);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetenableIsheetAddRecordFormSharing != null)
                {
                    isheetObject["enableIsheetAddRecordFormSharing"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetenableIsheetAddRecordFormSharing);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetrecordcount != null)
                {
                    isheetObject["recordcount"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetrecordcount);
                    isheetObjectpropCount++;
                }

                if (bodymoduleisheetsheettypeid != null)
                {
                    isheetObject["sheettypeid"] = SourceExpressionConverter.ConvertToken(bodymoduleisheetsheettypeid);
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
                    qaObject["enable"] = SourceExpressionConverter.ConvertToken(bodymoduleqaenable);
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
                    peopleObject["person"] = SourceExpressionConverter.ConvertToken(bodymodulepeopleperson);
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
                    contractexpressObject["enable"] = SourceExpressionConverter.ConvertToken(bodymodulecontractexpressenable);
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
                    body["adminnote"] = SourceExpressionConverter.ConvertToken(bodyadminnote);
                    bodypropCount++;
                }

                if (bodystartdate != null)
                {
                    body["startdate"] = SourceExpressionConverter.ConvertToken(bodystartdate);
                    bodypropCount++;
                }

                if (bodyenddate != null)
                {
                    body["enddate"] = SourceExpressionConverter.ConvertToken(bodyenddate);
                    bodypropCount++;
                }

                if (bodycreateddate != null)
                {
                    body["createddate"] = SourceExpressionConverter.ConvertToken(bodycreateddate);
                    bodypropCount++;
                }

                if (bodyarchiveddate != null)
                {
                    body["archiveddate"] = SourceExpressionConverter.ConvertToken(bodyarchiveddate);
                    bodypropCount++;
                }

                if (bodyclientno != null)
                {
                    body["clientno"] = SourceExpressionConverter.ConvertToken(bodyclientno);
                    bodypropCount++;
                }

                if (bodymatterno != null)
                {
                    body["matterno"] = SourceExpressionConverter.ConvertToken(bodymatterno);
                    bodypropCount++;
                }

                if (bodylandingpage != null)
                {
                    body["landingpage"] = SourceExpressionConverter.ConvertToken(bodylandingpage);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusid != null)
                {
                    body["statusid"] = SourceExpressionConverter.ConvertToken(bodystatusid);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodybillingnotes != null)
                {
                    body["billingnotes"] = SourceExpressionConverter.ConvertToken(bodybillingnotes);
                    bodypropCount++;
                }

                if (bodybillingnextinvoicedate != null)
                {
                    body["billingnextinvoicedate"] = SourceExpressionConverter.ConvertToken(bodybillingnextinvoicedate);
                    bodypropCount++;
                }

                if (bodybillinglastinvoicedate != null)
                {
                    body["billinglastinvoicedate"] = SourceExpressionConverter.ConvertToken(bodybillinglastinvoicedate);
                    bodypropCount++;
                }

                if (bodyfilepagecount != null)
                {
                    body["filepagecount"] = SourceExpressionConverter.ConvertToken(bodyfilepagecount);
                    bodypropCount++;
                }

                if (bodymaxpagecount != null)
                {
                    body["maxpagecount"] = SourceExpressionConverter.ConvertToken(bodymaxpagecount);
                    bodypropCount++;
                }

                if (bodysitehttplink != null)
                {
                    body["sitehttplink"] = SourceExpressionConverter.ConvertToken(bodysitehttplink);
                    bodypropCount++;
                }

                if (bodyisSyncable != null)
                {
                    body["isSyncable"] = SourceExpressionConverter.ConvertToken(bodyisSyncable);
                    bodypropCount++;
                }

                if (bodyenforceusergroups != null)
                {
                    body["enforceusergroups"] = SourceExpressionConverter.ConvertToken(bodyenforceusergroups);
                    bodypropCount++;
                }

                if (bodycsvSiteCategory != null)
                {
                    body["csvSiteCategory"] = SourceExpressionConverter.ConvertToken(bodycsvSiteCategory);
                    bodypropCount++;
                }

                if (bodysiteNameInDefaultLanguage != null)
                {
                    body["siteNameInDefaultLanguage"] = SourceExpressionConverter.ConvertToken(bodysiteNameInDefaultLanguage);
                    bodypropCount++;
                }

                if (bodyvisible != null)
                {
                    body["visible"] = SourceExpressionConverter.ConvertToken(bodyvisible);
                    bodypropCount++;
                }

                if (bodysiteLogoName != null)
                {
                    body["siteLogoName"] = SourceExpressionConverter.ConvertToken(bodysiteLogoName);
                    bodypropCount++;
                }

                if (bodysiteLogoFileSize != null)
                {
                    body["siteLogoFileSize"] = SourceExpressionConverter.ConvertToken(bodysiteLogoFileSize);
                    bodypropCount++;
                }

                if (bodysiteLogoHeight != null)
                {
                    body["siteLogoHeight"] = SourceExpressionConverter.ConvertToken(bodysiteLogoHeight);
                    bodypropCount++;
                }

                if (bodysiteLogoWidth != null)
                {
                    body["siteLogoWidth"] = SourceExpressionConverter.ConvertToken(bodysiteLogoWidth);
                    bodypropCount++;
                }

                if (bodysiteStatus != null)
                {
                    body["siteStatus"] = SourceExpressionConverter.ConvertToken(bodysiteStatus);
                    bodypropCount++;
                }

                if (bodyapplySiteTerms != null)
                {
                    body["applySiteTerms"] = SourceExpressionConverter.ConvertToken(bodyapplySiteTerms);
                    bodypropCount++;
                }

                if (bodysiteTerm != null)
                {
                    body["siteTerm"] = SourceExpressionConverter.ConvertToken(bodysiteTerm);
                    bodypropCount++;
                }

                if (bodytermType != null)
                {
                    body["termType"] = SourceExpressionConverter.ConvertToken(bodytermType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteTerms != null)
                {
                    body["nextLoginSiteTerms"] = SourceExpressionConverter.ConvertToken(bodynextLoginSiteTerms);
                    bodypropCount++;
                }

                if (bodydefaultSiteTermsEnable != null)
                {
                    body["defaultSiteTermsEnable"] = SourceExpressionConverter.ConvertToken(bodydefaultSiteTermsEnable);
                    bodypropCount++;
                }

                if (bodyadvancedQAPermission != null)
                {
                    body["advancedQAPermission"] = SourceExpressionConverter.ConvertToken(bodyadvancedQAPermission);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = SourceExpressionConverter.ConvertToken(bodyisInternal);
                    bodypropCount++;
                }

                if (bodypsm != null)
                {
                    body["psm"] = SourceExpressionConverter.ConvertToken(bodypsm);
                    bodypropCount++;
                }

                if (bodysiteLabelDisplay != null)
                {
                    body["siteLabelDisplay"] = SourceExpressionConverter.ConvertToken(bodysiteLabelDisplay);
                    bodypropCount++;
                }

                if (bodyallowSiteAdministration != null)
                {
                    body["allowSiteAdministration"] = SourceExpressionConverter.ConvertToken(bodyallowSiteAdministration);
                    bodypropCount++;
                }

                if (bodysiteLevelPasswordEnable != null)
                {
                    body["siteLevelPasswordEnable"] = SourceExpressionConverter.ConvertToken(bodysiteLevelPasswordEnable);
                    bodypropCount++;
                }

                if (bodysiteLevelPasscodeEnable != null)
                {
                    body["siteLevelPasscodeEnable"] = SourceExpressionConverter.ConvertToken(bodysiteLevelPasscodeEnable);
                    bodypropCount++;
                }

                if (bodypasscodeUsingAuthApp != null)
                {
                    body["passcodeUsingAuthApp"] = SourceExpressionConverter.ConvertToken(bodypasscodeUsingAuthApp);
                    bodypropCount++;
                }

                if (bodysitePassword != null)
                {
                    body["sitePassword"] = SourceExpressionConverter.ConvertToken(bodysitePassword);
                    bodypropCount++;
                }

                if (bodyipRestrictionEnable != null)
                {
                    body["ipRestrictionEnable"] = SourceExpressionConverter.ConvertToken(bodyipRestrictionEnable);
                    bodypropCount++;
                }

                if (bodyavailableIP != null)
                {
                    body["availableIP"] = SourceExpressionConverter.ConvertToken(bodyavailableIP);
                    bodypropCount++;
                }

                if (bodyhighqDrive != null)
                {
                    body["highqDrive"] = SourceExpressionConverter.ConvertToken(bodyhighqDrive);
                    bodypropCount++;
                }

                if (bodyapplySiteHomePage != null)
                {
                    body["applySiteHomePage"] = SourceExpressionConverter.ConvertToken(bodyapplySiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePage != null)
                {
                    body["siteHomePage"] = SourceExpressionConverter.ConvertToken(bodysiteHomePage);
                    bodypropCount++;
                }

                if (bodysiteHomePageType != null)
                {
                    body["siteHomePageType"] = SourceExpressionConverter.ConvertToken(bodysiteHomePageType);
                    bodypropCount++;
                }

                if (bodynextLoginSiteHomePage != null)
                {
                    body["nextLoginSiteHomePage"] = SourceExpressionConverter.ConvertToken(bodynextLoginSiteHomePage);
                    bodypropCount++;
                }

                if (bodyapplyDisplayContent != null)
                {
                    body["applyDisplayContent"] = SourceExpressionConverter.ConvertToken(bodyapplyDisplayContent);
                    bodypropCount++;
                }

                if (bodydisplayContent != null)
                {
                    body["displayContent"] = SourceExpressionConverter.ConvertToken(bodydisplayContent);
                    bodypropCount++;
                }

                if (bodyrssSecurity != null)
                {
                    body["rssSecurity"] = SourceExpressionConverter.ConvertToken(bodyrssSecurity);
                    bodypropCount++;
                }

                if (bodyencryptedPassword != null)
                {
                    body["encryptedPassword"] = SourceExpressionConverter.ConvertToken(bodyencryptedPassword);
                    bodypropCount++;
                }

                if (bodyavailableIPRangeCSV != null)
                {
                    body["availableIPRangeCSV"] = SourceExpressionConverter.ConvertToken(bodyavailableIPRangeCSV);
                    bodypropCount++;
                }

                if (bodysiteModuleId != null)
                {
                    body["siteModuleID"] = SourceExpressionConverter.ConvertToken(bodysiteModuleId);
                    bodypropCount++;
                }

                if (bodyicalSecurity != null)
                {
                    body["icalSecurity"] = SourceExpressionConverter.ConvertToken(bodyicalSecurity);
                    bodypropCount++;
                }

                if (bodydefaultDisplayContent != null)
                {
                    body["defaultDisplayContent"] = SourceExpressionConverter.ConvertToken(bodydefaultDisplayContent);
                    bodypropCount++;
                }

                if (bodydefaultEmailAlert != null)
                {
                    body["defaultEmailAlert"] = SourceExpressionConverter.ConvertToken(bodydefaultEmailAlert);
                    bodypropCount++;
                }

                if (bodyexcelReportFooter != null)
                {
                    body["excelReportFooter"] = SourceExpressionConverter.ConvertToken(bodyexcelReportFooter);
                    bodypropCount++;
                }

                if (bodyexcelReportFooterText != null)
                {
                    body["excelReportFooterText"] = SourceExpressionConverter.ConvertToken(bodyexcelReportFooterText);
                    bodypropCount++;
                }

                if (bodyannouncementMLJSON != null)
                {
                    body["announcementMLJSON"] = SourceExpressionConverter.ConvertToken(bodyannouncementMLJSON);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["templateType"] = SourceExpressionConverter.ConvertToken(bodytemplateType);
                    bodypropCount++;
                }

                if (bodytemplateLicence != null)
                {
                    body["templateLicence"] = SourceExpressionConverter.ConvertToken(bodytemplateLicence);
                    bodypropCount++;
                }

                if (bodyopenChannelAppId != null)
                {
                    body["openChannelAppID"] = SourceExpressionConverter.ConvertToken(bodyopenChannelAppId);
                    bodypropCount++;
                }

                if (bodyitemid != null)
                {
                    body["itemid"] = SourceExpressionConverter.ConvertToken(bodyitemid);
                    bodypropCount++;
                }

                if (bodysitemetadatasheetid != null)
                {
                    body["sitemetadatasheetid"] = SourceExpressionConverter.ConvertToken(bodysitemetadatasheetid);
                    bodypropCount++;
                }

                if (bodymysite != null)
                {
                    body["mysite"] = SourceExpressionConverter.ConvertToken(bodymysite);
                    bodypropCount++;
                }

                if (bodylastaccesseddate != null)
                {
                    body["lastaccesseddate"] = SourceExpressionConverter.ConvertToken(bodylastaccesseddate);
                    bodypropCount++;
                }

                if (bodydefaultViewerMetaDataTab != null)
                {
                    body["defaultViewerMetaDataTab"] = SourceExpressionConverter.ConvertToken(bodydefaultViewerMetaDataTab);
                    bodypropCount++;
                }

                if (bodydocumentMetadataViewId != null)
                {
                    body["documentMetadataViewId"] = SourceExpressionConverter.ConvertToken(bodydocumentMetadataViewId);
                    bodypropCount++;
                }

                if (bodyfolderMetadataViewId != null)
                {
                    body["folderMetadataViewId"] = SourceExpressionConverter.ConvertToken(bodyfolderMetadataViewId);
                    bodypropCount++;
                }

                if (bodydocSort != null)
                {
                    body["docSort"] = SourceExpressionConverter.ConvertToken(bodydocSort);
                    bodypropCount++;
                }

                if (bodyfolderSort != null)
                {
                    body["folderSort"] = SourceExpressionConverter.ConvertToken(bodyfolderSort);
                    bodypropCount++;
                }

                if (bodydefaultFolderRenderView != null)
                {
                    body["defaultFolderRenderView"] = SourceExpressionConverter.ConvertToken(bodydefaultFolderRenderView);
                    bodypropCount++;
                }

                if (bodyisTaskAttachmentDefault != null)
                {
                    body["isTaskAttachmentDefault"] = SourceExpressionConverter.ConvertToken(bodyisTaskAttachmentDefault);
                    bodypropCount++;
                }

                if (bodytaskAttachmentDefaultFolderId != null)
                {
                    body["taskAttachmentDefaultFolderId"] = SourceExpressionConverter.ConvertToken(bodytaskAttachmentDefaultFolderId);
                    bodypropCount++;
                }

                if (bodyfavourite != null)
                {
                    body["favourite"] = SourceExpressionConverter.ConvertToken(bodyfavourite);
                    bodypropCount++;
                }

                if (bodyenabledocumentredaction != null)
                {
                    body["enabledocumentredaction"] = SourceExpressionConverter.ConvertToken(bodyenabledocumentredaction);
                    bodypropCount++;
                }

                if (bodymentiongroups != null)
                {
                    body["mentiongroups"] = SourceExpressionConverter.ConvertToken(bodymentiongroups);
                    bodypropCount++;
                }

                if (bodyenablefilerelationships != null)
                {
                    body["enablefilerelationships"] = SourceExpressionConverter.ConvertToken(bodyenablefilerelationships);
                    bodypropCount++;
                }

                if (bodyfilerelationshipsitepermissionlevel != null)
                {
                    body["filerelationshipsitepermissionlevel"] = SourceExpressionConverter.ConvertToken(bodyfilerelationshipsitepermissionlevel);
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