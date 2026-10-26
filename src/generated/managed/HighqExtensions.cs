//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Highq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HighqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveDocuments(Expression<Func<string>> version, Expression<Func<string>> targetfolder, Expression<Func<MoveDocumentsInput>> fileidcsv = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_targetfolder = WorkflowExpression.Compile(targetfolder, nameof(targetfolder), required: true);
            var __workflow_fileidcsv = WorkflowExpression.Compile(fileidcsv, nameof(fileidcsv), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/files/move", __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["targetfolder"] = ExpressionConverter.Convert(__workflow_targetfolder);
                if (__workflow_fileidcsv != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileidcsv);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IBodyWorkflowAction<Site, ApiConnectionActionConfiguration> CreateSite(Expression<Func<string>> version, Expression<Func<CreateSiteInput>> body)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Site, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/sites", __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Site>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "highq")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateSite(Expression<Func<string>> version, Expression<Func<string>> siteid, Expression<Func<UpdateSiteInput>> body)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_siteid = WorkflowExpression.Compile(siteid, nameof(siteid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/sites/{1}", __workflow_version.WithUrlEncoding(1), __workflow_siteid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HighqTriggers([ConnectionName] string connectionId)
    {
    }

    public class MoveDocumentsInput
    {
        [JsonProperty("fileidCSV")]
        public string FileidCSV { get; set; }
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
        public string SitefolderId { get; set; }

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
        public int SiteModuleId { get; set; }

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
        public string OpenChannelAppId { get; set; }

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
        public int SiteId { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("categoryList")]
        public string[] CategoryList { get; set; }

        [JsonProperty("notificationTypeID")]
        public int NotificationTypeId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageCode")]
        public int MessageCode { get; set; }

        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

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
        public int SiteId { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("categoryList")]
        public string[] CategoryList { get; set; }

        [JsonProperty("notificationTypeID")]
        public int NotificationTypeId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageCode")]
        public int MessageCode { get; set; }

        [JsonProperty("externalID")]
        public string ExternalId { get; set; }

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

    public class CreateSiteInput
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("sitename")]
        public string Sitename { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("sitedescription")]
        public string Sitedescription { get; set; }

        [JsonProperty("enabledmodules")]
        public string Enabledmodules { get; set; }

        [JsonProperty("sitefolderID")]
        public string SitefolderId { get; set; }

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
        public int? Statusid { get; set; }

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
        public int? IsSyncable { get; set; }

        [JsonProperty("enforceusergroups")]
        public string Enforceusergroups { get; set; }

        [JsonProperty("csvSiteCategory")]
        public string CsvSiteCategory { get; set; }

        [JsonProperty("siteNameInDefaultLanguage")]
        public string SiteNameInDefaultLanguage { get; set; }

        [JsonProperty("visible")]
        public int? Visible { get; set; }

        [JsonProperty("siteLogoName")]
        public string SiteLogoName { get; set; }

        [JsonProperty("siteLogoFileSize")]
        public int? SiteLogoFileSize { get; set; }

        [JsonProperty("siteLogoHeight")]
        public int? SiteLogoHeight { get; set; }

        [JsonProperty("siteLogoWidth")]
        public int? SiteLogoWidth { get; set; }

        [JsonProperty("siteStatus")]
        public int? SiteStatus { get; set; }

        [JsonProperty("applySiteTerms")]
        public int? ApplySiteTerms { get; set; }

        [JsonProperty("siteTerm")]
        public string SiteTerm { get; set; }

        [JsonProperty("termType")]
        public int? TermType { get; set; }

        [JsonProperty("nextLoginSiteTerms")]
        public int? NextLoginSiteTerms { get; set; }

        [JsonProperty("defaultSiteTermsEnable")]
        public int? DefaultSiteTermsEnable { get; set; }

        [JsonProperty("advancedQAPermission")]
        public int? AdvancedQAPermission { get; set; }

        [JsonProperty("isInternal")]
        public int? IsInternal { get; set; }

        [JsonProperty("psm")]
        public int? Psm { get; set; }

        [JsonProperty("siteLabelDisplay")]
        public string SiteLabelDisplay { get; set; }

        [JsonProperty("allowSiteAdministration")]
        public int? AllowSiteAdministration { get; set; }

        [JsonProperty("siteLevelPasswordEnable")]
        public int? SiteLevelPasswordEnable { get; set; }

        [JsonProperty("siteLevelPasscodeEnable")]
        public int? SiteLevelPasscodeEnable { get; set; }

        [JsonProperty("passcodeUsingAuthApp")]
        public int? PasscodeUsingAuthApp { get; set; }

        [JsonProperty("sitePassword")]
        public string SitePassword { get; set; }

        [JsonProperty("ipRestrictionEnable")]
        public int? IpRestrictionEnable { get; set; }

        [JsonProperty("availableIP")]
        public string AvailableIP { get; set; }

        [JsonProperty("highqDrive")]
        public int? HighqDrive { get; set; }

        [JsonProperty("applySiteHomePage")]
        public int? ApplySiteHomePage { get; set; }

        [JsonProperty("siteHomePage")]
        public string SiteHomePage { get; set; }

        [JsonProperty("siteHomePageType")]
        public int? SiteHomePageType { get; set; }

        [JsonProperty("nextLoginSiteHomePage")]
        public int? NextLoginSiteHomePage { get; set; }

        [JsonProperty("applyDisplayContent")]
        public int? ApplyDisplayContent { get; set; }

        [JsonProperty("displayContent")]
        public string DisplayContent { get; set; }

        [JsonProperty("rssSecurity")]
        public int? RssSecurity { get; set; }

        [JsonProperty("encryptedPassword")]
        public int? EncryptedPassword { get; set; }

        [JsonProperty("availableIPRangeCSV")]
        public string AvailableIPRangeCSV { get; set; }

        [JsonProperty("siteModuleID")]
        public int? SiteModuleId { get; set; }

        [JsonProperty("icalSecurity")]
        public int? IcalSecurity { get; set; }

        [JsonProperty("defaultDisplayContent")]
        public string DefaultDisplayContent { get; set; }

        [JsonProperty("defaultEmailAlert")]
        public int? DefaultEmailAlert { get; set; }

        [JsonProperty("excelReportFooter")]
        public int? ExcelReportFooter { get; set; }

        [JsonProperty("excelReportFooterText")]
        public string ExcelReportFooterText { get; set; }

        [JsonProperty("announcementMLJSON")]
        public string AnnouncementMLJSON { get; set; }

        [JsonProperty("templateType")]
        public int? TemplateType { get; set; }

        [JsonProperty("templateLicence")]
        public int? TemplateLicence { get; set; }

        [JsonProperty("openChannelAppID")]
        public string OpenChannelAppId { get; set; }

        [JsonProperty("itemid")]
        public int? Itemid { get; set; }

        [JsonProperty("sitemetadatasheetid")]
        public int? Sitemetadatasheetid { get; set; }

        [JsonProperty("mysite")]
        public bool? Mysite { get; set; }

        [JsonProperty("lastaccesseddate")]
        public string Lastaccesseddate { get; set; }

        [JsonProperty("defaultViewerMetaDataTab")]
        public int? DefaultViewerMetaDataTab { get; set; }

        [JsonProperty("documentMetadataViewId")]
        public int? DocumentMetadataViewId { get; set; }

        [JsonProperty("folderMetadataViewId")]
        public int? FolderMetadataViewId { get; set; }

        [JsonProperty("docSort")]
        public int? DocSort { get; set; }

        [JsonProperty("folderSort")]
        public int? FolderSort { get; set; }

        [JsonProperty("defaultFolderRenderView")]
        public int? DefaultFolderRenderView { get; set; }

        [JsonProperty("isTaskAttachmentDefault")]
        public int? IsTaskAttachmentDefault { get; set; }

        [JsonProperty("taskAttachmentDefaultFolderId")]
        public int? TaskAttachmentDefaultFolderId { get; set; }

        [JsonProperty("favourite")]
        public string Favourite { get; set; }

        [JsonProperty("enabledocumentredaction")]
        public bool? Enabledocumentredaction { get; set; }

        [JsonProperty("mentiongroups")]
        public int? Mentiongroups { get; set; }

        [JsonProperty("enablefilerelationships")]
        public bool? Enablefilerelationships { get; set; }

        [JsonProperty("filerelationshipsitepermissionlevel")]
        public int? Filerelationshipsitepermissionlevel { get; set; }
    }

    public class UpdateSiteInput
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("sitename")]
        public string Sitename { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("sitedescription")]
        public string Sitedescription { get; set; }

        [JsonProperty("enabledmodules")]
        public string Enabledmodules { get; set; }

        [JsonProperty("sitefolderID")]
        public string SitefolderId { get; set; }

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
        public int? Statusid { get; set; }

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
        public int? IsSyncable { get; set; }

        [JsonProperty("enforceusergroups")]
        public string Enforceusergroups { get; set; }

        [JsonProperty("csvSiteCategory")]
        public string CsvSiteCategory { get; set; }

        [JsonProperty("siteNameInDefaultLanguage")]
        public string SiteNameInDefaultLanguage { get; set; }

        [JsonProperty("visible")]
        public int? Visible { get; set; }

        [JsonProperty("siteLogoName")]
        public string SiteLogoName { get; set; }

        [JsonProperty("siteLogoFileSize")]
        public int? SiteLogoFileSize { get; set; }

        [JsonProperty("siteLogoHeight")]
        public int? SiteLogoHeight { get; set; }

        [JsonProperty("siteLogoWidth")]
        public int? SiteLogoWidth { get; set; }

        [JsonProperty("siteStatus")]
        public int? SiteStatus { get; set; }

        [JsonProperty("applySiteTerms")]
        public int? ApplySiteTerms { get; set; }

        [JsonProperty("siteTerm")]
        public string SiteTerm { get; set; }

        [JsonProperty("termType")]
        public int? TermType { get; set; }

        [JsonProperty("nextLoginSiteTerms")]
        public int? NextLoginSiteTerms { get; set; }

        [JsonProperty("defaultSiteTermsEnable")]
        public int? DefaultSiteTermsEnable { get; set; }

        [JsonProperty("advancedQAPermission")]
        public int? AdvancedQAPermission { get; set; }

        [JsonProperty("isInternal")]
        public int? IsInternal { get; set; }

        [JsonProperty("psm")]
        public int? Psm { get; set; }

        [JsonProperty("siteLabelDisplay")]
        public string SiteLabelDisplay { get; set; }

        [JsonProperty("allowSiteAdministration")]
        public int? AllowSiteAdministration { get; set; }

        [JsonProperty("siteLevelPasswordEnable")]
        public int? SiteLevelPasswordEnable { get; set; }

        [JsonProperty("siteLevelPasscodeEnable")]
        public int? SiteLevelPasscodeEnable { get; set; }

        [JsonProperty("passcodeUsingAuthApp")]
        public int? PasscodeUsingAuthApp { get; set; }

        [JsonProperty("sitePassword")]
        public string SitePassword { get; set; }

        [JsonProperty("ipRestrictionEnable")]
        public int? IpRestrictionEnable { get; set; }

        [JsonProperty("availableIP")]
        public string AvailableIP { get; set; }

        [JsonProperty("highqDrive")]
        public int? HighqDrive { get; set; }

        [JsonProperty("applySiteHomePage")]
        public int? ApplySiteHomePage { get; set; }

        [JsonProperty("siteHomePage")]
        public string SiteHomePage { get; set; }

        [JsonProperty("siteHomePageType")]
        public int? SiteHomePageType { get; set; }

        [JsonProperty("nextLoginSiteHomePage")]
        public int? NextLoginSiteHomePage { get; set; }

        [JsonProperty("applyDisplayContent")]
        public int? ApplyDisplayContent { get; set; }

        [JsonProperty("displayContent")]
        public string DisplayContent { get; set; }

        [JsonProperty("rssSecurity")]
        public int? RssSecurity { get; set; }

        [JsonProperty("encryptedPassword")]
        public int? EncryptedPassword { get; set; }

        [JsonProperty("availableIPRangeCSV")]
        public string AvailableIPRangeCSV { get; set; }

        [JsonProperty("siteModuleID")]
        public int? SiteModuleId { get; set; }

        [JsonProperty("icalSecurity")]
        public int? IcalSecurity { get; set; }

        [JsonProperty("defaultDisplayContent")]
        public string DefaultDisplayContent { get; set; }

        [JsonProperty("defaultEmailAlert")]
        public int? DefaultEmailAlert { get; set; }

        [JsonProperty("excelReportFooter")]
        public int? ExcelReportFooter { get; set; }

        [JsonProperty("excelReportFooterText")]
        public string ExcelReportFooterText { get; set; }

        [JsonProperty("announcementMLJSON")]
        public string AnnouncementMLJSON { get; set; }

        [JsonProperty("templateType")]
        public int? TemplateType { get; set; }

        [JsonProperty("templateLicence")]
        public int? TemplateLicence { get; set; }

        [JsonProperty("openChannelAppID")]
        public string OpenChannelAppId { get; set; }

        [JsonProperty("itemid")]
        public int? Itemid { get; set; }

        [JsonProperty("sitemetadatasheetid")]
        public int? Sitemetadatasheetid { get; set; }

        [JsonProperty("mysite")]
        public bool? Mysite { get; set; }

        [JsonProperty("lastaccesseddate")]
        public string Lastaccesseddate { get; set; }

        [JsonProperty("defaultViewerMetaDataTab")]
        public int? DefaultViewerMetaDataTab { get; set; }

        [JsonProperty("documentMetadataViewId")]
        public int? DocumentMetadataViewId { get; set; }

        [JsonProperty("folderMetadataViewId")]
        public int? FolderMetadataViewId { get; set; }

        [JsonProperty("docSort")]
        public int? DocSort { get; set; }

        [JsonProperty("folderSort")]
        public int? FolderSort { get; set; }

        [JsonProperty("defaultFolderRenderView")]
        public int? DefaultFolderRenderView { get; set; }

        [JsonProperty("isTaskAttachmentDefault")]
        public int? IsTaskAttachmentDefault { get; set; }

        [JsonProperty("taskAttachmentDefaultFolderId")]
        public int? TaskAttachmentDefaultFolderId { get; set; }

        [JsonProperty("favourite")]
        public string Favourite { get; set; }

        [JsonProperty("enabledocumentredaction")]
        public bool? Enabledocumentredaction { get; set; }

        [JsonProperty("mentiongroups")]
        public int? Mentiongroups { get; set; }

        [JsonProperty("enablefilerelationships")]
        public bool? Enablefilerelationships { get; set; }

        [JsonProperty("filerelationshipsitepermissionlevel")]
        public int? Filerelationshipsitepermissionlevel { get; set; }
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