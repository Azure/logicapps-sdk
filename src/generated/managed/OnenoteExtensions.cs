//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onenote
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnenoteActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSectionInNotebook))]
        public IBodyWorkflowAction<CreateSectionInNotebookResponse> CreateSectionInNotebook([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> bodynameOfTheNewSection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSectionInNotebookResponse> __BuildCreateSectionInNotebook(WorkflowExpression<string> notebookKey, WorkflowExpression<string> bodynameOfTheNewSection = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(bodynameOfTheNewSection, nameof(bodynameOfTheNewSection), required: false);
            return new DeferredBodyAction<CreateSectionInNotebookResponse>(() =>
            {
                var apiCallPath = "/notebooks/Dynamic/sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynameOfTheNewSection != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodynameOfTheNewSection);
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
        [WorkflowExpressionFactory(nameof(__BuildCreatePageInSection))]
        public IBodyWorkflowAction<Page> CreatePageInSection([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Page> __BuildCreatePageInSection(WorkflowExpression<string> notebookKey, WorkflowExpression<string> sectionId, WorkflowExpression<string> pageContent = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(pageContent, nameof(pageContent), required: false);
            return new DeferredBodyAction<Page>(() =>
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
                callPayload.Body = ExpressionConverter.ConvertO(pageContent);
                return new ApiConnectionAction<Page>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildGetPagesInSection))]
        public IBodyWorkflowAction<GetPagesInSectionResponse> GetPagesInSection([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPagesInSectionResponse> __BuildGetPagesInSection(WorkflowExpression<string> notebookKey, WorkflowExpression<string> sectionId)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            return new DeferredBodyAction<GetPagesInSectionResponse>(() =>
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
                return new ApiConnectionAction<GetPagesInSectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePageInQuickNotes))]
        public IBodyWorkflowAction<Page> CreatePageInQuickNotes([WorkflowExpression] Func<string> pageContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Page> __BuildCreatePageInQuickNotes(WorkflowExpression<string> pageContent = null)
        {
            WorkflowExpression.Validate(pageContent, nameof(pageContent), required: false);
            return new DeferredBodyAction<Page>(() =>
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(pageContent);
                return new ApiConnectionAction<Page>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePage))]
        public IWorkflowAction DeletePage([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletePage(WorkflowExpression<string> notebookKey, WorkflowExpression<string> sectionId, WorkflowExpression<string> pageId)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(pageId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildGetPageContent))]
        public IBodyWorkflowAction<string> GetPageContent([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetPageContent(WorkflowExpression<string> notebookKey, WorkflowExpression<string> sectionId, WorkflowExpression<string> pageId)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(pageId);
                callPayload.Queries["preAuthenticated"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePageContent))]
        public IBodyWorkflowAction<string> UpdatePageContent([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<updatesInputItem[]> updates = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUpdatePageContent(WorkflowExpression<string> notebookKey, WorkflowExpression<string> sectionId, WorkflowExpression<string> pageId, WorkflowExpression<updatesInputItem[]> updates = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            WorkflowExpression.Validate(updates, nameof(updates), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
                callPayload.Queries["pageId"] = ExpressionConverter.Convert(pageId);
                callPayload.Body = ExpressionConverter.ConvertO(updates);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSectionsInNotebook))]
        public IBodyWorkflowAction<GetSectionsInNotebookResponse> GetSectionsInNotebook([WorkflowExpression] Func<string> notebookKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSectionsInNotebookResponse> __BuildGetSectionsInNotebook(WorkflowExpression<string> notebookKey)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyAction<GetSectionsInNotebookResponse>(() =>
            {
                var apiCallPath = "/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                return new ApiConnectionAction<GetSectionsInNotebookResponse>(callPayload);
            });
        }
    }

    public class OnenoteTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewSectionInNotebook))]
        public IBodyWorkflowTrigger<NewSectionResponse> OnNewSectionInNotebook([WorkflowExpression] Func<string> notebookKey,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewSectionResponse> __BuildOnNewSectionInNotebook(WorkflowExpression<string> notebookKey,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyTrigger<NewSectionResponse>(() =>
            {
                var apiCallPath = "/trigger1/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                return new ApiConnectionTrigger<NewSectionResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewSectionGroupInNotebook))]
        public IBodyWorkflowTrigger<NewSectionGroupResponse> OnNewSectionGroupInNotebook([WorkflowExpression] Func<string> notebookKey,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewSectionGroupResponse> __BuildOnNewSectionGroupInNotebook(WorkflowExpression<string> notebookKey,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            return new DeferredBodyTrigger<NewSectionGroupResponse>(() =>
            {
                var apiCallPath = "/trigger2/notebooks/notebookKey/sectiongroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                return new ApiConnectionTrigger<NewSectionGroupResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewPageInSection))]
        public IBodyWorkflowTrigger<NewPageResponse> OnNewPageInSection([WorkflowExpression] Func<string> notebookKey,[WorkflowExpression] Func<string> sectionId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewPageResponse> __BuildOnNewPageInSection(WorkflowExpression<string> notebookKey,WorkflowExpression<string> sectionId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            return new DeferredBodyTrigger<NewPageResponse>(() =>
            {
                var apiCallPath = "/trigger3/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = ExpressionConverter.Convert(notebookKey);
                callPayload.Queries["sectionId"] = ExpressionConverter.Convert(sectionId);
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