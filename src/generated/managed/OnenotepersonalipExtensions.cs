//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onenotepersonalip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class OnenotepersonalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<NotebookGetResponse> NotebookGet()
        {
            var apiCallPath = "/notebooks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NotebookGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<NotebookPostResponse> Notebook(Expression<Func<string>> bodydisplayName)
        {
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: true);
            return new DeferredBodyAction<NotebookPostResponse>(() =>
            {
                var apiCallPath = "/notebooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NotebookPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<NotebookGetAResponse> NotebookGetA(Expression<Func<string>> notebookId)
        {
            var __workflow_notebookId = notebookId == null ? null : WorkflowExpression.Compile(notebookId);
            WorkflowExpression.Validate(__workflow_notebookId, nameof(notebookId), required: true);
            return new DeferredBodyAction<NotebookGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_notebookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NotebookGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<SectionGetResponse> SectionGet(Expression<Func<string>> notebookId, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<bool>> count = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_notebookId = notebookId == null ? null : WorkflowExpression.Compile(notebookId);
            WorkflowExpression.Validate(__workflow_notebookId, nameof(notebookId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<SectionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}/sections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_notebookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<SectionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<SectionPostResponse> Section(Expression<Func<string>> notebookId, Expression<Func<string>> bodydisplayName)
        {
            var __workflow_notebookId = notebookId == null ? null : WorkflowExpression.Compile(notebookId);
            WorkflowExpression.Validate(__workflow_notebookId, nameof(notebookId), required: true);
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: true);
            return new DeferredBodyAction<SectionPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}/sections", ExpressionConverter.ConvertWithUrlEncoding(__workflow_notebookId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SectionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<PageGetResponse> PageGet(Expression<Func<string>> sectionId, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<bool>> count = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_count = count == null ? null : WorkflowExpression.Compile(count);
            WorkflowExpression.Validate(__workflow_count, nameof(count), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<PageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sections/{0}/pages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_sectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<PageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        public IBodyWorkflowAction<PagePostResponse> Page(Expression<Func<string>> sectionId, Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_sectionId = sectionId == null ? null : WorkflowExpression.Compile(sectionId);
            WorkflowExpression.Validate(__workflow_sectionId, nameof(sectionId), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<PagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sections/{0}/pages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_sectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PagePostResponse>(callPayload);
            });
        }
    }

    public class OnenotepersonalipTriggers([ConnectionName] string connectionId)
    {
    }

    public class NotebookGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public NotebookGetResponseValueTypeItem[] Value { get; set; }
    }

    public class NotebookGetResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }

        [JsonProperty("sectionsUrl")]
        public string SectionsUrl { get; set; }

        [JsonProperty("sectionGroupsUrl")]
        public string SectionGroupsUrl { get; set; }

        [JsonProperty("createdBy")]
        public NotebookGetResponseValueTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public NotebookGetResponseValueTypeItemLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("links")]
        public NotebookGetResponseValueTypeItemLinksType Links { get; set; }
    }

    public class NotebookGetResponseValueTypeItemCreatedByType
    {
        [JsonProperty("user")]
        public NotebookGetResponseValueTypeItemCreatedByTypeUserType User { get; set; }
    }

    public class NotebookGetResponseValueTypeItemCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NotebookGetResponseValueTypeItemLastModifiedByType
    {
        [JsonProperty("user")]
        public NotebookGetResponseValueTypeItemLastModifiedByTypeUserType User { get; set; }
    }

    public class NotebookGetResponseValueTypeItemLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NotebookGetResponseValueTypeItemLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public NotebookGetResponseValueTypeItemLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public NotebookGetResponseValueTypeItemLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class NotebookGetResponseValueTypeItemLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class NotebookGetResponseValueTypeItemLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class NotebookPostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }

        [JsonProperty("sectionsUrl")]
        public string SectionsUrl { get; set; }

        [JsonProperty("sectionGroupsUrl")]
        public string SectionGroupsUrl { get; set; }

        [JsonProperty("links")]
        public NotebookPostResponseLinksType Links { get; set; }
    }

    public class NotebookPostResponseLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public NotebookPostResponseLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public NotebookPostResponseLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class NotebookPostResponseLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class NotebookPostResponseLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class NotebookGetAResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }

        [JsonProperty("sectionsUrl")]
        public string SectionsUrl { get; set; }

        [JsonProperty("sectionGroupsUrl")]
        public string SectionGroupsUrl { get; set; }

        [JsonProperty("createdBy")]
        public NotebookGetAResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public NotebookGetAResponseLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("links")]
        public NotebookGetAResponseLinksType Links { get; set; }
    }

    public class NotebookGetAResponseCreatedByType
    {
        [JsonProperty("user")]
        public NotebookGetAResponseCreatedByTypeUserType User { get; set; }
    }

    public class NotebookGetAResponseCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NotebookGetAResponseLastModifiedByType
    {
        [JsonProperty("user")]
        public NotebookGetAResponseLastModifiedByTypeUserType User { get; set; }
    }

    public class NotebookGetAResponseLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class NotebookGetAResponseLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public NotebookGetAResponseLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public NotebookGetAResponseLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class NotebookGetAResponseLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class NotebookGetAResponseLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class SectionGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public SectionGetResponseValueTypeItem[] Value { get; set; }
    }

    public class SectionGetResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("pagesUrl")]
        public string PagesUrl { get; set; }

        [JsonProperty("createdBy")]
        public SectionGetResponseValueTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public SectionGetResponseValueTypeItemLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("parentNotebook@odata.context")]
        public string ParentNotebookOdataContext { get; set; }

        [JsonProperty("parentNotebook")]
        public SectionGetResponseValueTypeItemParentNotebookType ParentNotebook { get; set; }

        [JsonProperty("parentSectionGroup@odata.context")]
        public string ParentSectionGroupOdataContext { get; set; }

        [JsonProperty("parentSectionGroup")]
        public string ParentSectionGroup { get; set; }
    }

    public class SectionGetResponseValueTypeItemCreatedByType
    {
        [JsonProperty("user")]
        public SectionGetResponseValueTypeItemCreatedByTypeUserType User { get; set; }
    }

    public class SectionGetResponseValueTypeItemCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class SectionGetResponseValueTypeItemLastModifiedByType
    {
        [JsonProperty("user")]
        public SectionGetResponseValueTypeItemLastModifiedByTypeUserType User { get; set; }
    }

    public class SectionGetResponseValueTypeItemLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class SectionGetResponseValueTypeItemParentNotebookType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class SectionPostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("pagesUrl")]
        public string PagesUrl { get; set; }

        [JsonProperty("createdBy")]
        public SectionPostResponseCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public SectionPostResponseLastModifiedByType LastModifiedBy { get; set; }
    }

    public class SectionPostResponseCreatedByType
    {
        [JsonProperty("user")]
        public SectionPostResponseCreatedByTypeUserType User { get; set; }
    }

    public class SectionPostResponseCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class SectionPostResponseLastModifiedByType
    {
        [JsonProperty("user")]
        public SectionPostResponseLastModifiedByTypeUserType User { get; set; }
    }

    public class SectionPostResponseLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class PageGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public PageGetResponseValueTypeItem[] Value { get; set; }
    }

    public class PageGetResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdByAppId")]
        public string CreatedByAppId { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("links")]
        public PageGetResponseValueTypeItemLinksType Links { get; set; }

        [JsonProperty("parentSection@odata.context")]
        public string ParentSectionOdataContext { get; set; }

        [JsonProperty("parentSection")]
        public string ParentSection { get; set; }
    }

    public class PageGetResponseValueTypeItemLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public PageGetResponseValueTypeItemLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public PageGetResponseValueTypeItemLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class PageGetResponseValueTypeItemLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class PageGetResponseValueTypeItemLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class PagePostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("createdByAppId")]
        public string CreatedByAppId { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("links")]
        public PagePostResponseLinksType Links { get; set; }
    }

    public class PagePostResponseLinksType
    {
        [JsonProperty("oneNoteClientUrl")]
        public PagePostResponseLinksTypeOneNoteClientUrlType OneNoteClientUrl { get; set; }

        [JsonProperty("oneNoteWebUrl")]
        public PagePostResponseLinksTypeOneNoteWebUrlType OneNoteWebUrl { get; set; }
    }

    public class PagePostResponseLinksTypeOneNoteClientUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class PagePostResponseLinksTypeOneNoteWebUrlType
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Onenotepersonalip;

    public partial class WorkflowManagedActions
    {
        public OnenotepersonalipActions Onenotepersonalip(string connectionId) => new OnenotepersonalipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OnenotepersonalipTriggers Onenotepersonalip(string connectionId) => new OnenotepersonalipTriggers(connectionId);
    }
}
