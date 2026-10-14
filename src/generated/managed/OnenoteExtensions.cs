//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onenote
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OnenoteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<CreateSectionInNotebookResponse> CreateSectionInNotebook(Expression<Func<string>> notebookKey, Expression<Func<string>> bodynameOfTheNewSection = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_bodynameOfTheNewSection = bodynameOfTheNewSection == null ? null : WorkflowExpression.Compile(bodynameOfTheNewSection);
            WorkflowExpression.Validate(__workflow_bodynameOfTheNewSection, nameof(bodynameOfTheNewSection), required: false);
            return new DeferredBodyAction<CreateSectionInNotebookResponse>(() =>
            {
                var apiCallPath = "/notebooks/Dynamic/sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynameOfTheNewSection != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodynameOfTheNewSection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateSectionInNotebookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Page> CreatePageInSection(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId, Expression<Func<string>> pageContent = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_pageContent = pageContent == null ? null : WorkflowExpression.Compile(pageContent);
            WorkflowExpression.Validate(__workflow_pageContent, nameof(pageContent), required: false);
            return new DeferredBodyAction<Page>(() =>
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pageContent);
                return new ApiConnectionAction<Page>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<GetPagesInSectionResponse> GetPagesInSection(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            return new DeferredBodyAction<GetPagesInSectionResponse>(() =>
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                return new ApiConnectionAction<GetPagesInSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Page> CreatePageInQuickNotes(Expression<Func<string>> pageContent = null)
        {
            var __workflow_pageContent = pageContent == null ? null : WorkflowExpression.Compile(pageContent);
            WorkflowExpression.Validate(__workflow_pageContent, nameof(pageContent), required: false);
            return new DeferredBodyAction<Page>(() =>
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_pageContent);
                return new ApiConnectionAction<Page>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IWorkflowAction DeletePage(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId, Expression<Func<string>> pageId)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_pageId = pageId == null ? null : WorkflowExpression.Compile(pageId);
            WorkflowExpression.Validate(__workflow_pageId, nameof(pageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(__workflow_pageId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<string> GetPageContent(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId, Expression<Func<string>> pageId)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_pageId = pageId == null ? null : WorkflowExpression.Compile(pageId);
            WorkflowExpression.Validate(__workflow_pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(__workflow_pageId);
                callPayload.Queries["preAuthenticated"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<string> UpdatePageContent(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId, Expression<Func<string>> pageId, Expression<Func<updatesInputItem[]>> updates = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_pageId = pageId == null ? null : WorkflowExpression.Compile(pageId);
            WorkflowExpression.Validate(__workflow_pageId, nameof(pageId), required: true);
            var __workflow_updates = updates == null ? null : WorkflowExpression.Compile(updates);
            WorkflowExpression.Validate(__workflow_updates, nameof(updates), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(__workflow_pageId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updates);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Notebook[]> GetNotebooks()
        {
            var apiCallPath = "/notebooks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Notebook[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<GetSectionsInNotebookResponse> GetSectionsInNotebook(Expression<Func<string>> notebookKey)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyAction<GetSectionsInNotebookResponse>(() =>
            {
                var apiCallPath = "/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                return new ApiConnectionAction<GetSectionsInNotebookResponse>(callPayload);
            });
        }
    }

    public class OnenoteTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSectionResponse> OnNewSectionInNotebook(Expression<Func<string>> notebookKey, FlowRecurrence recurrence = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyTrigger<NewSectionResponse>(() =>
            {
                var apiCallPath = "/trigger1/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                return new ApiConnectionTrigger<NewSectionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewSectionGroupResponse> OnNewSectionGroupInNotebook(Expression<Func<string>> notebookKey, FlowRecurrence recurrence = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyTrigger<NewSectionGroupResponse>(() =>
            {
                var apiCallPath = "/trigger2/notebooks/notebookKey/sectiongroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                return new ApiConnectionTrigger<NewSectionGroupResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewPageResponse> OnNewPageInSection(Expression<Func<string>> notebookKey, Expression<Func<string>> sectionId, FlowRecurrence recurrence = null)
        {
            var __workflow_notebookKey = notebookKey == null ? null : WorkflowExpression.Compile(notebookKey);
            WorkflowExpression.Validate(__workflow_notebookKey, nameof(notebookKey), required: true);
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            return new DeferredBodyTrigger<NewPageResponse>(() =>
            {
                var apiCallPath = "/trigger3/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(__workflow_notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(__workflow_sectionId);
                return new ApiConnectionTrigger<NewPageResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateSectionInNotebookResponse
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedByName { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("id")]
        public string CreateSectionInNotebookObjectId { get; set; }

        [JsonProperty("isDefault")]
        public bool DefaultSectionFlag { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("links")]
        public CreateSectionInNotebookResponseOneNoteClientLinksType OneNoteClientLinks { get; set; }

        [JsonProperty("name")]
        public string SectionName { get; set; }

        [JsonProperty("pagesUrl")]
        public string ThePagesUrl { get; set; }

        [JsonProperty("self")]
        public string UrlToCreateSectionInNotebook { get; set; }
    }

    public class CreateSectionInNotebookResponseOneNoteClientLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public CreateSectionInNotebookResponseOneNoteClientLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public CreateSectionInNotebookResponseOneNoteClientLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class CreateSectionInNotebookResponseOneNoteClientLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string DesktopClientHref { get; set; }
    }

    public class CreateSectionInNotebookResponseOneNoteClientLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string WebClientHref { get; set; }
    }

    public class Page
    {
        [JsonProperty("title")]
        public string PageTitle { get; set; }

        [JsonProperty("links")]
        public Link Links { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Link
    {
        [JsonProperty("oneNoteClientUrl")]
        public OneNoteClientUrlInfo OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public OneNoteWebUrlInfo OneNoteWebUrl { get; set; }
    }

    public class OneNoteClientUrlInfo
    {
        [JsonProperty("href")]
        public string OneNoteClientUrl { get; set; }
    }

    public class OneNoteWebUrlInfo
    {
        [JsonProperty("href")]
        public string OneNoteWebUrl { get; set; }
    }

    public class GetPagesInSectionResponse
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }

        [JsonProperty("value")]
        public GetPagesInSectionResponsePagesInSectionValueObjectTypeItem[] PagesInSectionValueObject { get; set; }
    }

    public class GetPagesInSectionResponsePagesInSectionValueObjectTypeItem
    {
        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("createdByAppId")]
        public string CreatedByAppId { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("id")]
        public string UniqueIdentifierForResponse { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("links")]
        public GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectType CollectionOfLinksForThisObject { get; set; }

        [JsonProperty("parentSection")]
        public GetPagesInSectionResponsePagesInSectionValueObjectTypeItemParentSectionType ParentSection { get; set; }

        [JsonProperty("parentSection@odata.context")]
        public string ParentSectionODataContext { get; set; }

        [JsonProperty("self")]
        public string PagesInSectionGroup { get; set; }

        [JsonProperty("title")]
        public string PageTitle { get; set; }
    }

    public class GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectType
    {
        [JsonProperty("oneNoteClientUrl")]
        public GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectTypeOneNoteWebClientUrlType OneNoteWebClientUrl { get; set; }
    }

    public class GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string OneNoteDesktopClientHref { get; set; }
    }

    public class GetPagesInSectionResponsePagesInSectionValueObjectTypeItemCollectionOfLinksForThisObjectTypeOneNoteWebClientUrlType
    {
        [JsonProperty("href")]
        public string OneNoteWebClientHref { get; set; }
    }

    public class GetPagesInSectionResponsePagesInSectionValueObjectTypeItemParentSectionType
    {
        [JsonProperty("id")]
        public string ParentSectionUniqueIdentifier { get; set; }

        [JsonProperty("name")]
        public string ParentSectionName { get; set; }

        [JsonProperty("self")]
        public string PagesInSectionParentSection { get; set; }
    }

    public class updatesInputItem
    {
        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("action")]
        public updatesInputItemActionType Action { get; set; }

        [JsonProperty("position")]
        public updatesInputItemLocationType Location { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum updatesInputItemActionType
    {
        [EnumMember(Value = "append")]
        Append,
        [EnumMember(Value = "insert")]
        Insert,
        [EnumMember(Value = "prepend")]
        Prepend,
        [EnumMember(Value = "replace")]
        Replace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum updatesInputItemLocationType
    {
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "before")]
        Before
    }

    public class Notebook
    {
        public string FileName { get; set; }
        public string Key { get; set; }
    }

    public class GetSectionsInNotebookResponse
    {
        [JsonProperty("value")]
        public SectionListItem[] Value { get; set; }
    }

    public class SectionListItem
    {
        [JsonProperty("name")]
        public string SectionName { get; set; }

        [JsonProperty("pagesUrl")]
        public string SectionKey { get; set; }

        [JsonProperty("id")]
        public string SectionIdentifier { get; set; }
    }

    public class NewSectionResponse
    {
        [JsonProperty("value")]
        public SectionResponse[] Sections { get; set; }
    }

    public class SectionResponse
    {
        [JsonProperty("createdBy")]
        public string Creator { get; set; }

        [JsonProperty("createdTime")]
        public string CreationDate { get; set; }

        [JsonProperty("id")]
        public string SectionIdentifier { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("name")]
        public string SectionName { get; set; }

        [JsonProperty("pagesUrl")]
        public string PagesUrl { get; set; }

        [JsonProperty("parentNotebook")]
        public ParentNotebook ParentNotebook { get; set; }

        [JsonProperty("self")]
        public string Url { get; set; }
    }

    public class ParentNotebook
    {
        [JsonProperty("id")]
        public string ParentNotebookKey { get; set; }

        [JsonProperty("name")]
        public string ParentNotebookName { get; set; }

        [JsonProperty("self")]
        public string ParentNotebookUrl { get; set; }
    }

    public class NewSectionGroupResponse
    {
        [JsonProperty("value")]
        public SectionGroupResponse[] SectionGroups { get; set; }
    }

    public class SectionGroupResponse
    {
        [JsonProperty("createdTime")]
        public string CreationDate { get; set; }

        [JsonProperty("createdBy")]
        public string Creator { get; set; }

        [JsonProperty("id")]
        public string Identifier { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifier { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sectionsUrl")]
        public string SectionsUrl { get; set; }

        [JsonProperty("self")]
        public string SectionGroupUrl { get; set; }
    }

    public class NewPageResponse
    {
        [JsonProperty("value")]
        public Page[] Pages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Onenote;

    public partial class WorkflowManagedActions
    {
        public OnenoteActions Onenote(string connectionId) => new OnenoteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OnenoteTriggers Onenote(string connectionId) => new OnenoteTriggers(connectionId);
    }
}
