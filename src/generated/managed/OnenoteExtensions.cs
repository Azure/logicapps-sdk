//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onenote
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnenoteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<CreateSectionInNotebookResponse> CreateSectionInNotebook([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> bodynameOfTheNewSection = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(bodynameOfTheNewSection, nameof(bodynameOfTheNewSection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/notebooks/Dynamic/sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynameOfTheNewSection != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodynameOfTheNewSection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSectionInNotebookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Page> CreatePageInSection([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageContent = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            SourceExpression.Validate(pageContent, nameof(pageContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(pageContent);
                return callPayload;
            }

            return new ApiConnectionAction<Page>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<GetPagesInSectionResponse> GetPagesInSection([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPagesInSectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Page> CreatePageInQuickNotes([WorkflowExpression] Func<string> pageContent = null)
        {
            SourceExpression.Validate(pageContent, nameof(pageContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(pageContent);
                return callPayload;
            }

            return new ApiConnectionAction<Page>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IWorkflowAction DeletePage([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                callPayload.Queries["pageId"] = SourceExpressionConverter.ConvertO(pageId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<string> GetPageContent([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                callPayload.Queries["pageId"] = SourceExpressionConverter.ConvertO(pageId);
                callPayload.Queries["preAuthenticated"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<string> UpdatePageContent([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<updatesInputItem[]> updates = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(updates, nameof(updates), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pages/Dynamic/content";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                callPayload.Queries["pageId"] = SourceExpressionConverter.ConvertO(pageId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(updates);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<Notebook[]> GetNotebooks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/notebooks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Notebook[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenote")]
        public IBodyWorkflowAction<GetSectionsInNotebookResponse> GetSectionsInNotebook([WorkflowExpression] Func<string> notebookKey)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetSectionsInNotebookResponse>(BuildSourceInput);
        }
    }

    public class OnenoteTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewSectionResponse> OnNewSectionInNotebook([WorkflowExpression] Func<string> notebookKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/notebooks/notebookKey/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewSectionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewSectionGroupResponse> OnNewSectionGroupInNotebook([WorkflowExpression] Func<string> notebookKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger2/notebooks/notebookKey/sectiongroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewSectionGroupResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewPageResponse> OnNewPageInSection([WorkflowExpression] Func<string> notebookKey, [WorkflowExpression] Func<string> sectionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(notebookKey, nameof(notebookKey), required: true);
            SourceExpression.Validate(sectionId, nameof(sectionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger3/sections/Dynamic/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["notebookKey"] = SourceExpressionConverter.ConvertO(notebookKey);
                callPayload.Queries["sectionId"] = SourceExpressionConverter.ConvertO(sectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<NewPageResponse>(BuildSourceInput, triggerName, recurrence);
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