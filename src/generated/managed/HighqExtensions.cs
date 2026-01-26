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
        public IWorkflowAction InsertDocument(Expression<Func<string>> version, Expression<Func<object>> file, Expression<Func<string>> parentfolderid, Expression<Func<string>> filename, Expression<Func<bool>> overrideduplicate = null, Expression<Func<string>> versionnote = null, Expression<Func<string>> progressiveoperkey = null, Expression<Func<string>> dmsdatabasename = null, Expression<Func<string>> dmseditdate = null, Expression<Func<string>> dmsparentfolderid = null, Expression<Func<string>> dmsdocid = null, Expression<Func<string>> dmsversion = null, Expression<Func<string>> notification = null, Expression<Func<string>> batchid = null, Expression<Func<string>> rootfolderid = null)
        {
            var apiCallPath = String.Format("/{0}/files/content", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction MoveDocuments(Expression<Func<string>> version, Expression<Func<string>> targetfolder, Expression<Func<string>> fileidcsvfileidCSV = null)
        {
            var apiCallPath = String.Format("/{0}/files/move", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IBodyWorkflowAction<Site> CreateSite(Expression<Func<string>> version, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodysitename = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysitedescription = null, Expression<Func<string>> bodyenabledmodules = null, Expression<Func<string>> bodysitefolderID = null, Expression<Func<string>> bodysitefolderpermission = null, Expression<Func<string>> bodymodulehomeenable = null, Expression<Func<string>> bodymoduleactivityenable = null, Expression<Func<string>> bodymoduleactivitymicroblog = null, Expression<Func<string>> bodymoduledocumentdocid = null, Expression<Func<string>> bodymoduleblogblogTitle = null, Expression<Func<string>> bodymoduleblogblogContent = null, Expression<Func<int>> bodymoduleblogshowComment = null, Expression<Func<string[]>> bodymoduleblogtagList = null, Expression<Func<int>> bodymoduleblogstatus = null, Expression<Func<int>> bodymoduleblogsiteID = null, Expression<Func<string>> bodymoduleblogauthor = null, Expression<Func<string[]>> bodymoduleblogcategoryList = null, Expression<Func<int>> bodymoduleblognotificationTypeID = null, Expression<Func<string>> bodymoduleblogmessage = null, Expression<Func<int>> bodymoduleblogmessageCode = null, Expression<Func<string>> bodymoduleblogexternalID = null, Expression<Func<string>> bodymoduleblogpublishDate = null, Expression<Func<string>> bodymoduleblogprocesstype = null, Expression<Func<string>> bodymoduleblogenable = null, Expression<Func<int>> bodymodulewikiwikiid = null, Expression<Func<int>> bodymodulewikicurrentversionid = null, Expression<Func<int>> bodymodulewikiparentwikiid = null, Expression<Func<string>> bodymodulewikiwikititle = null, Expression<Func<string>> bodymodulewikiwikicontent = null, Expression<Func<int>> bodymodulewikishowcomment = null, Expression<Func<string>> bodymodulewikicreateddate = null, Expression<Func<string>> bodymodulewikimodifieddate = null, Expression<Func<string>> bodymodulewikitaglist = null, Expression<Func<string>> bodymodulewikiwikipath = null, Expression<Func<int>> bodymodulewikiwikidraftid = null, Expression<Func<string>> bodymodulewikidrafttype = null, Expression<Func<int>> bodymodulewikistatus = null, Expression<Func<int>> bodymodulewikiwikiversionid = null, Expression<Func<string>> bodymoduletaskindex = null, Expression<Func<int>> bodymoduletaskparenttaskid = null, Expression<Func<int>> bodymoduletasktaskid = null, Expression<Func<string>> bodymoduletasktitle = null, Expression<Func<string>> bodymoduletaskdescription = null, Expression<Func<string>> bodymoduletaskduedate = null, Expression<Func<string>> bodymoduletaskstartdate = null, Expression<Func<string>> bodymoduletaskmattermaptaskid = null, Expression<Func<string>> bodymoduletasktype = null, Expression<Func<string>> bodymoduletaskdependenton = null, Expression<Func<string>> bodymoduletaskdaysfromdependent = null, Expression<Func<int>> bodymoduletaskignoreweekend = null, Expression<Func<int>> bodymoduletaskduration = null, Expression<Func<string>> bodymoduletaskresource = null, Expression<Func<string>> bodymoduleeventeventTitle = null, Expression<Func<string>> bodymoduleeventeventContent = null, Expression<Func<int>> bodymoduleeventshowComment = null, Expression<Func<string[]>> bodymoduleeventtagList = null, Expression<Func<int>> bodymoduleeventstatus = null, Expression<Func<int>> bodymoduleeventsiteID = null, Expression<Func<string>> bodymoduleeventcontact = null, Expression<Func<string[]>> bodymoduleeventcategoryList = null, Expression<Func<int>> bodymoduleeventnotificationTypeID = null, Expression<Func<string>> bodymoduleeventmessage = null, Expression<Func<int>> bodymoduleeventmessageCode = null, Expression<Func<string>> bodymoduleeventexternalID = null, Expression<Func<string>> bodymoduleeventstartDate = null, Expression<Func<string>> bodymoduleeventendDate = null, Expression<Func<string>> bodymoduleeventstartTime = null, Expression<Func<string>> bodymoduleeventendTime = null, Expression<Func<string>> bodymoduleeventlocation = null, Expression<Func<string>> bodymoduleeventauthor = null, Expression<Func<string>> bodymoduleeventprocesstype = null, Expression<Func<string>> bodymoduleeventenable = null, Expression<Func<int>> bodymoduleisheetid = null, Expression<Func<string>> bodymoduleisheettitle = null, Expression<Func<string>> bodymoduleisheetdescription = null, Expression<Func<string>> bodymoduleisheetstatus = null, Expression<Func<string>> bodymoduleisheetaccesstype = null, Expression<Func<string>> bodymoduleisheettype = null, Expression<Func<string>> bodymoduleisheetviewlink = null, Expression<Func<string>> bodymoduleisheetallowsections = null, Expression<Func<string>> bodymoduleisheetallowlookup = null, Expression<Func<string>> bodymoduleisheetdisplayisheet = null, Expression<Func<string>> bodymoduleisheetsearchasdefaultview = null, Expression<Func<string>> bodymoduleisheetenableversion = null, Expression<Func<string>> bodymoduleisheetenablesheetalerter = null, Expression<Func<string>> bodymoduleisheetalertercondition = null, Expression<Func<string>> bodymoduleisheetoverrideitemmodifieddate = null, Expression<Func<string>> bodymoduleisheetenablebulkinsertupdate = null, Expression<Func<string>> bodymoduleisheetfielddescriptions = null, Expression<Func<string>> bodymoduleisheetenablerowlocking = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, Expression<Func<string>> bodymoduleisheetallowchoicelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowscorelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowIsheetComments = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimit = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimitEnabled = null, Expression<Func<string>> bodymoduleisheetenableIsheetAddRecordFormSharing = null, Expression<Func<string>> bodymoduleisheetrecordcount = null, Expression<Func<int>> bodymoduleisheetsheettypeid = null, Expression<Func<string>> bodymoduleqaenable = null, Expression<Func<PersonDBO[]>> bodymodulepeopleperson = null, Expression<Func<string>> bodymodulecontractexpressenable = null, Expression<Func<string>> bodyadminnote = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyenddate = null, Expression<Func<string>> bodycreateddate = null, Expression<Func<string>> bodyarchiveddate = null, Expression<Func<string>> bodyclientno = null, Expression<Func<string>> bodymatterno = null, Expression<Func<string>> bodylandingpage = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodystatusid = null, Expression<Func<string>> bodysize = null, Expression<Func<string>> bodybillingnotes = null, Expression<Func<string>> bodybillingnextinvoicedate = null, Expression<Func<string>> bodybillinglastinvoicedate = null, Expression<Func<string>> bodyfilepagecount = null, Expression<Func<string>> bodymaxpagecount = null, Expression<Func<string>> bodysitehttplink = null, Expression<Func<int>> bodyisSyncable = null, Expression<Func<string>> bodyenforceusergroups = null, Expression<Func<string>> bodycsvSiteCategory = null, Expression<Func<string>> bodysiteNameInDefaultLanguage = null, Expression<Func<int>> bodyvisible = null, Expression<Func<string>> bodysiteLogoName = null, Expression<Func<int>> bodysiteLogoFileSize = null, Expression<Func<int>> bodysiteLogoHeight = null, Expression<Func<int>> bodysiteLogoWidth = null, Expression<Func<int>> bodysiteStatus = null, Expression<Func<int>> bodyapplySiteTerms = null, Expression<Func<string>> bodysiteTerm = null, Expression<Func<int>> bodytermType = null, Expression<Func<int>> bodynextLoginSiteTerms = null, Expression<Func<int>> bodydefaultSiteTermsEnable = null, Expression<Func<int>> bodyadvancedQAPermission = null, Expression<Func<int>> bodyisInternal = null, Expression<Func<int>> bodypsm = null, Expression<Func<string>> bodysiteLabelDisplay = null, Expression<Func<int>> bodyallowSiteAdministration = null, Expression<Func<int>> bodysiteLevelPasswordEnable = null, Expression<Func<int>> bodysiteLevelPasscodeEnable = null, Expression<Func<int>> bodypasscodeUsingAuthApp = null, Expression<Func<string>> bodysitePassword = null, Expression<Func<int>> bodyipRestrictionEnable = null, Expression<Func<string>> bodyavailableIP = null, Expression<Func<int>> bodyhighqDrive = null, Expression<Func<int>> bodyapplySiteHomePage = null, Expression<Func<string>> bodysiteHomePage = null, Expression<Func<int>> bodysiteHomePageType = null, Expression<Func<int>> bodynextLoginSiteHomePage = null, Expression<Func<int>> bodyapplyDisplayContent = null, Expression<Func<string>> bodydisplayContent = null, Expression<Func<int>> bodyrssSecurity = null, Expression<Func<int>> bodyencryptedPassword = null, Expression<Func<string>> bodyavailableIPRangeCSV = null, Expression<Func<int>> bodysiteModuleID = null, Expression<Func<int>> bodyicalSecurity = null, Expression<Func<string>> bodydefaultDisplayContent = null, Expression<Func<int>> bodydefaultEmailAlert = null, Expression<Func<int>> bodyexcelReportFooter = null, Expression<Func<string>> bodyexcelReportFooterText = null, Expression<Func<string>> bodyannouncementMLJSON = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<int>> bodytemplateLicence = null, Expression<Func<string>> bodyopenChannelAppID = null, Expression<Func<int>> bodyitemid = null, Expression<Func<int>> bodysitemetadatasheetid = null, Expression<Func<bool>> bodymysite = null, Expression<Func<string>> bodylastaccesseddate = null, Expression<Func<int>> bodydefaultViewerMetaDataTab = null, Expression<Func<int>> bodydocumentMetadataViewId = null, Expression<Func<int>> bodyfolderMetadataViewId = null, Expression<Func<int>> bodydocSort = null, Expression<Func<int>> bodyfolderSort = null, Expression<Func<int>> bodydefaultFolderRenderView = null, Expression<Func<int>> bodyisTaskAttachmentDefault = null, Expression<Func<int>> bodytaskAttachmentDefaultFolderId = null, Expression<Func<string>> bodyfavourite = null, Expression<Func<bool>> bodyenabledocumentredaction = null, Expression<Func<int>> bodymentiongroups = null, Expression<Func<bool>> bodyenablefilerelationships = null, Expression<Func<int>> bodyfilerelationshipsitepermissionlevel = null)
        {
            var apiCallPath = String.Format("/{0}/sites", ExpressionConverter.ConvertWithUrlEncoding(version, 1));
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

            var eventObject = new JObject();
            var eventObjectpropCount = 0;
            if (bodymoduleeventeventTitle != null)
            {
                eventObject["eventTitle"] = ExpressionConverter.ConvertO(bodymoduleeventeventTitle);
                eventObjectpropCount++;
            }

            if (bodymoduleeventeventContent != null)
            {
                eventObject["eventContent"] = ExpressionConverter.ConvertO(bodymoduleeventeventContent);
                eventObjectpropCount++;
            }

            if (bodymoduleeventshowComment != null)
            {
                eventObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleeventshowComment);
                eventObjectpropCount++;
            }

            if (bodymoduleeventtagList != null)
            {
                eventObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleeventtagList);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstatus != null)
            {
                eventObject["status"] = ExpressionConverter.ConvertO(bodymoduleeventstatus);
                eventObjectpropCount++;
            }

            if (bodymoduleeventsiteID != null)
            {
                eventObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleeventsiteID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventcontact != null)
            {
                eventObject["contact"] = ExpressionConverter.ConvertO(bodymoduleeventcontact);
                eventObjectpropCount++;
            }

            if (bodymoduleeventcategoryList != null)
            {
                eventObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleeventcategoryList);
                eventObjectpropCount++;
            }

            if (bodymoduleeventnotificationTypeID != null)
            {
                eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleeventnotificationTypeID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventmessage != null)
            {
                eventObject["message"] = ExpressionConverter.ConvertO(bodymoduleeventmessage);
                eventObjectpropCount++;
            }

            if (bodymoduleeventmessageCode != null)
            {
                eventObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleeventmessageCode);
                eventObjectpropCount++;
            }

            if (bodymoduleeventexternalID != null)
            {
                eventObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleeventexternalID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstartDate != null)
            {
                eventObject["startDate"] = ExpressionConverter.ConvertO(bodymoduleeventstartDate);
                eventObjectpropCount++;
            }

            if (bodymoduleeventendDate != null)
            {
                eventObject["endDate"] = ExpressionConverter.ConvertO(bodymoduleeventendDate);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstartTime != null)
            {
                eventObject["startTime"] = ExpressionConverter.ConvertO(bodymoduleeventstartTime);
                eventObjectpropCount++;
            }

            if (bodymoduleeventendTime != null)
            {
                eventObject["endTime"] = ExpressionConverter.ConvertO(bodymoduleeventendTime);
                eventObjectpropCount++;
            }

            if (bodymoduleeventlocation != null)
            {
                eventObject["location"] = ExpressionConverter.ConvertO(bodymoduleeventlocation);
                eventObjectpropCount++;
            }

            if (bodymoduleeventauthor != null)
            {
                eventObject["author"] = ExpressionConverter.ConvertO(bodymoduleeventauthor);
                eventObjectpropCount++;
            }

            if (bodymoduleeventprocesstype != null)
            {
                eventObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleeventprocesstype);
                eventObjectpropCount++;
            }

            if (bodymoduleeventenable != null)
            {
                eventObject["enable"] = ExpressionConverter.ConvertO(bodymoduleeventenable);
                eventObjectpropCount++;
            }

            if (eventObjectpropCount > 0)
            {
                moduleObject["event"] = eventObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction UpdateSite(Expression<Func<string>> version, Expression<Func<string>> siteid, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodysitename = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysitedescription = null, Expression<Func<string>> bodyenabledmodules = null, Expression<Func<string>> bodysitefolderID = null, Expression<Func<string>> bodysitefolderpermission = null, Expression<Func<string>> bodymodulehomeenable = null, Expression<Func<string>> bodymoduleactivityenable = null, Expression<Func<string>> bodymoduleactivitymicroblog = null, Expression<Func<string>> bodymoduledocumentdocid = null, Expression<Func<string>> bodymoduleblogblogTitle = null, Expression<Func<string>> bodymoduleblogblogContent = null, Expression<Func<int>> bodymoduleblogshowComment = null, Expression<Func<string[]>> bodymoduleblogtagList = null, Expression<Func<int>> bodymoduleblogstatus = null, Expression<Func<int>> bodymoduleblogsiteID = null, Expression<Func<string>> bodymoduleblogauthor = null, Expression<Func<string[]>> bodymoduleblogcategoryList = null, Expression<Func<int>> bodymoduleblognotificationTypeID = null, Expression<Func<string>> bodymoduleblogmessage = null, Expression<Func<int>> bodymoduleblogmessageCode = null, Expression<Func<string>> bodymoduleblogexternalID = null, Expression<Func<string>> bodymoduleblogpublishDate = null, Expression<Func<string>> bodymoduleblogprocesstype = null, Expression<Func<string>> bodymoduleblogenable = null, Expression<Func<int>> bodymodulewikiwikiid = null, Expression<Func<int>> bodymodulewikicurrentversionid = null, Expression<Func<int>> bodymodulewikiparentwikiid = null, Expression<Func<string>> bodymodulewikiwikititle = null, Expression<Func<string>> bodymodulewikiwikicontent = null, Expression<Func<int>> bodymodulewikishowcomment = null, Expression<Func<string>> bodymodulewikicreateddate = null, Expression<Func<string>> bodymodulewikimodifieddate = null, Expression<Func<string>> bodymodulewikitaglist = null, Expression<Func<string>> bodymodulewikiwikipath = null, Expression<Func<int>> bodymodulewikiwikidraftid = null, Expression<Func<string>> bodymodulewikidrafttype = null, Expression<Func<int>> bodymodulewikistatus = null, Expression<Func<int>> bodymodulewikiwikiversionid = null, Expression<Func<string>> bodymoduletaskindex = null, Expression<Func<int>> bodymoduletaskparenttaskid = null, Expression<Func<int>> bodymoduletasktaskid = null, Expression<Func<string>> bodymoduletasktitle = null, Expression<Func<string>> bodymoduletaskdescription = null, Expression<Func<string>> bodymoduletaskduedate = null, Expression<Func<string>> bodymoduletaskstartdate = null, Expression<Func<string>> bodymoduletaskmattermaptaskid = null, Expression<Func<string>> bodymoduletasktype = null, Expression<Func<string>> bodymoduletaskdependenton = null, Expression<Func<string>> bodymoduletaskdaysfromdependent = null, Expression<Func<int>> bodymoduletaskignoreweekend = null, Expression<Func<int>> bodymoduletaskduration = null, Expression<Func<string>> bodymoduletaskresource = null, Expression<Func<string>> bodymoduleeventeventTitle = null, Expression<Func<string>> bodymoduleeventeventContent = null, Expression<Func<int>> bodymoduleeventshowComment = null, Expression<Func<string[]>> bodymoduleeventtagList = null, Expression<Func<int>> bodymoduleeventstatus = null, Expression<Func<int>> bodymoduleeventsiteID = null, Expression<Func<string>> bodymoduleeventcontact = null, Expression<Func<string[]>> bodymoduleeventcategoryList = null, Expression<Func<int>> bodymoduleeventnotificationTypeID = null, Expression<Func<string>> bodymoduleeventmessage = null, Expression<Func<int>> bodymoduleeventmessageCode = null, Expression<Func<string>> bodymoduleeventexternalID = null, Expression<Func<string>> bodymoduleeventstartDate = null, Expression<Func<string>> bodymoduleeventendDate = null, Expression<Func<string>> bodymoduleeventstartTime = null, Expression<Func<string>> bodymoduleeventendTime = null, Expression<Func<string>> bodymoduleeventlocation = null, Expression<Func<string>> bodymoduleeventauthor = null, Expression<Func<string>> bodymoduleeventprocesstype = null, Expression<Func<string>> bodymoduleeventenable = null, Expression<Func<int>> bodymoduleisheetid = null, Expression<Func<string>> bodymoduleisheettitle = null, Expression<Func<string>> bodymoduleisheetdescription = null, Expression<Func<string>> bodymoduleisheetstatus = null, Expression<Func<string>> bodymoduleisheetaccesstype = null, Expression<Func<string>> bodymoduleisheettype = null, Expression<Func<string>> bodymoduleisheetviewlink = null, Expression<Func<string>> bodymoduleisheetallowsections = null, Expression<Func<string>> bodymoduleisheetallowlookup = null, Expression<Func<string>> bodymoduleisheetdisplayisheet = null, Expression<Func<string>> bodymoduleisheetsearchasdefaultview = null, Expression<Func<string>> bodymoduleisheetenableversion = null, Expression<Func<string>> bodymoduleisheetenablesheetalerter = null, Expression<Func<string>> bodymoduleisheetalertercondition = null, Expression<Func<string>> bodymoduleisheetoverrideitemmodifieddate = null, Expression<Func<string>> bodymoduleisheetenablebulkinsertupdate = null, Expression<Func<string>> bodymoduleisheetfielddescriptions = null, Expression<Func<string>> bodymoduleisheetenablerowlocking = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextenabled = null, Expression<Func<string>> bodymoduleisheetsetcharlimittruncatemultilinetextval = null, Expression<Func<string>> bodymoduleisheetallowchoicelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowscorelistvaluesforreuse = null, Expression<Func<string>> bodymoduleisheetallowIsheetComments = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimit = null, Expression<Func<int>> bodymoduleisheetshareRecordsLimitEnabled = null, Expression<Func<string>> bodymoduleisheetenableIsheetAddRecordFormSharing = null, Expression<Func<string>> bodymoduleisheetrecordcount = null, Expression<Func<int>> bodymoduleisheetsheettypeid = null, Expression<Func<string>> bodymoduleqaenable = null, Expression<Func<PersonDBO[]>> bodymodulepeopleperson = null, Expression<Func<string>> bodymodulecontractexpressenable = null, Expression<Func<string>> bodyadminnote = null, Expression<Func<string>> bodystartdate = null, Expression<Func<string>> bodyenddate = null, Expression<Func<string>> bodycreateddate = null, Expression<Func<string>> bodyarchiveddate = null, Expression<Func<string>> bodyclientno = null, Expression<Func<string>> bodymatterno = null, Expression<Func<string>> bodylandingpage = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodystatusid = null, Expression<Func<string>> bodysize = null, Expression<Func<string>> bodybillingnotes = null, Expression<Func<string>> bodybillingnextinvoicedate = null, Expression<Func<string>> bodybillinglastinvoicedate = null, Expression<Func<string>> bodyfilepagecount = null, Expression<Func<string>> bodymaxpagecount = null, Expression<Func<string>> bodysitehttplink = null, Expression<Func<int>> bodyisSyncable = null, Expression<Func<string>> bodyenforceusergroups = null, Expression<Func<string>> bodycsvSiteCategory = null, Expression<Func<string>> bodysiteNameInDefaultLanguage = null, Expression<Func<int>> bodyvisible = null, Expression<Func<string>> bodysiteLogoName = null, Expression<Func<int>> bodysiteLogoFileSize = null, Expression<Func<int>> bodysiteLogoHeight = null, Expression<Func<int>> bodysiteLogoWidth = null, Expression<Func<int>> bodysiteStatus = null, Expression<Func<int>> bodyapplySiteTerms = null, Expression<Func<string>> bodysiteTerm = null, Expression<Func<int>> bodytermType = null, Expression<Func<int>> bodynextLoginSiteTerms = null, Expression<Func<int>> bodydefaultSiteTermsEnable = null, Expression<Func<int>> bodyadvancedQAPermission = null, Expression<Func<int>> bodyisInternal = null, Expression<Func<int>> bodypsm = null, Expression<Func<string>> bodysiteLabelDisplay = null, Expression<Func<int>> bodyallowSiteAdministration = null, Expression<Func<int>> bodysiteLevelPasswordEnable = null, Expression<Func<int>> bodysiteLevelPasscodeEnable = null, Expression<Func<int>> bodypasscodeUsingAuthApp = null, Expression<Func<string>> bodysitePassword = null, Expression<Func<int>> bodyipRestrictionEnable = null, Expression<Func<string>> bodyavailableIP = null, Expression<Func<int>> bodyhighqDrive = null, Expression<Func<int>> bodyapplySiteHomePage = null, Expression<Func<string>> bodysiteHomePage = null, Expression<Func<int>> bodysiteHomePageType = null, Expression<Func<int>> bodynextLoginSiteHomePage = null, Expression<Func<int>> bodyapplyDisplayContent = null, Expression<Func<string>> bodydisplayContent = null, Expression<Func<int>> bodyrssSecurity = null, Expression<Func<int>> bodyencryptedPassword = null, Expression<Func<string>> bodyavailableIPRangeCSV = null, Expression<Func<int>> bodysiteModuleID = null, Expression<Func<int>> bodyicalSecurity = null, Expression<Func<string>> bodydefaultDisplayContent = null, Expression<Func<int>> bodydefaultEmailAlert = null, Expression<Func<int>> bodyexcelReportFooter = null, Expression<Func<string>> bodyexcelReportFooterText = null, Expression<Func<string>> bodyannouncementMLJSON = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<int>> bodytemplateLicence = null, Expression<Func<string>> bodyopenChannelAppID = null, Expression<Func<int>> bodyitemid = null, Expression<Func<int>> bodysitemetadatasheetid = null, Expression<Func<bool>> bodymysite = null, Expression<Func<string>> bodylastaccesseddate = null, Expression<Func<int>> bodydefaultViewerMetaDataTab = null, Expression<Func<int>> bodydocumentMetadataViewId = null, Expression<Func<int>> bodyfolderMetadataViewId = null, Expression<Func<int>> bodydocSort = null, Expression<Func<int>> bodyfolderSort = null, Expression<Func<int>> bodydefaultFolderRenderView = null, Expression<Func<int>> bodyisTaskAttachmentDefault = null, Expression<Func<int>> bodytaskAttachmentDefaultFolderId = null, Expression<Func<string>> bodyfavourite = null, Expression<Func<bool>> bodyenabledocumentredaction = null, Expression<Func<int>> bodymentiongroups = null, Expression<Func<bool>> bodyenablefilerelationships = null, Expression<Func<int>> bodyfilerelationshipsitepermissionlevel = null)
        {
            var apiCallPath = String.Format("/{0}/sites/{1}", ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(siteid, 1));
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

            var eventObject = new JObject();
            var eventObjectpropCount = 0;
            if (bodymoduleeventeventTitle != null)
            {
                eventObject["eventTitle"] = ExpressionConverter.ConvertO(bodymoduleeventeventTitle);
                eventObjectpropCount++;
            }

            if (bodymoduleeventeventContent != null)
            {
                eventObject["eventContent"] = ExpressionConverter.ConvertO(bodymoduleeventeventContent);
                eventObjectpropCount++;
            }

            if (bodymoduleeventshowComment != null)
            {
                eventObject["showComment"] = ExpressionConverter.ConvertO(bodymoduleeventshowComment);
                eventObjectpropCount++;
            }

            if (bodymoduleeventtagList != null)
            {
                eventObject["tagList"] = ExpressionConverter.ConvertO(bodymoduleeventtagList);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstatus != null)
            {
                eventObject["status"] = ExpressionConverter.ConvertO(bodymoduleeventstatus);
                eventObjectpropCount++;
            }

            if (bodymoduleeventsiteID != null)
            {
                eventObject["siteID"] = ExpressionConverter.ConvertO(bodymoduleeventsiteID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventcontact != null)
            {
                eventObject["contact"] = ExpressionConverter.ConvertO(bodymoduleeventcontact);
                eventObjectpropCount++;
            }

            if (bodymoduleeventcategoryList != null)
            {
                eventObject["categoryList"] = ExpressionConverter.ConvertO(bodymoduleeventcategoryList);
                eventObjectpropCount++;
            }

            if (bodymoduleeventnotificationTypeID != null)
            {
                eventObject["notificationTypeID"] = ExpressionConverter.ConvertO(bodymoduleeventnotificationTypeID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventmessage != null)
            {
                eventObject["message"] = ExpressionConverter.ConvertO(bodymoduleeventmessage);
                eventObjectpropCount++;
            }

            if (bodymoduleeventmessageCode != null)
            {
                eventObject["messageCode"] = ExpressionConverter.ConvertO(bodymoduleeventmessageCode);
                eventObjectpropCount++;
            }

            if (bodymoduleeventexternalID != null)
            {
                eventObject["externalID"] = ExpressionConverter.ConvertO(bodymoduleeventexternalID);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstartDate != null)
            {
                eventObject["startDate"] = ExpressionConverter.ConvertO(bodymoduleeventstartDate);
                eventObjectpropCount++;
            }

            if (bodymoduleeventendDate != null)
            {
                eventObject["endDate"] = ExpressionConverter.ConvertO(bodymoduleeventendDate);
                eventObjectpropCount++;
            }

            if (bodymoduleeventstartTime != null)
            {
                eventObject["startTime"] = ExpressionConverter.ConvertO(bodymoduleeventstartTime);
                eventObjectpropCount++;
            }

            if (bodymoduleeventendTime != null)
            {
                eventObject["endTime"] = ExpressionConverter.ConvertO(bodymoduleeventendTime);
                eventObjectpropCount++;
            }

            if (bodymoduleeventlocation != null)
            {
                eventObject["location"] = ExpressionConverter.ConvertO(bodymoduleeventlocation);
                eventObjectpropCount++;
            }

            if (bodymoduleeventauthor != null)
            {
                eventObject["author"] = ExpressionConverter.ConvertO(bodymoduleeventauthor);
                eventObjectpropCount++;
            }

            if (bodymoduleeventprocesstype != null)
            {
                eventObject["processtype"] = ExpressionConverter.ConvertO(bodymoduleeventprocesstype);
                eventObjectpropCount++;
            }

            if (bodymoduleeventenable != null)
            {
                eventObject["enable"] = ExpressionConverter.ConvertO(bodymoduleeventenable);
                eventObjectpropCount++;
            }

            if (eventObjectpropCount > 0)
            {
                moduleObject["event"] = eventObject;
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