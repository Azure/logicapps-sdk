//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onenotepersonalip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildNotebook))]
        public IBodyWorkflowAction<NotebookPostResponse> Notebook([WorkflowExpression] Func<string> bodydisplayName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NotebookPostResponse> __BuildNotebook(WorkflowExpression<string> bodydisplayName)
        {
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            return new DeferredBodyAction<NotebookPostResponse>(() =>
            {
                var apiCallPath = "/notebooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NotebookPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [WorkflowExpressionFactory(nameof(__BuildNotebookGetA))]
        public IBodyWorkflowAction<NotebookGetAResponse> NotebookGetA([WorkflowExpression] Func<string> notebookId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NotebookGetAResponse> __BuildNotebookGetA(WorkflowExpression<string> notebookId)
        {
            WorkflowExpression.Validate(notebookId, nameof(notebookId), required: true);
            return new DeferredBodyAction<NotebookGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(notebookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NotebookGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [WorkflowExpressionFactory(nameof(__BuildSectionGet))]
        public IBodyWorkflowAction<SectionGetResponse> SectionGet([WorkflowExpression] Func<string> notebookId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SectionGetResponse> __BuildSectionGet(WorkflowExpression<string> notebookId, WorkflowExpression<string> filter = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> search = null, WorkflowExpression<string> select = null, WorkflowExpression<int> skip = null, WorkflowExpression<int> top = null, WorkflowExpression<bool> count = null, WorkflowExpression<string> skiptoken = null)
        {
            WorkflowExpression.Validate(notebookId, nameof(notebookId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<SectionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}/sections", ExpressionConverter.ConvertWithUrlEncoding(notebookId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                return new ApiConnectionAction<SectionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [WorkflowExpressionFactory(nameof(__BuildSection))]
        public IBodyWorkflowAction<SectionPostResponse> Section([WorkflowExpression] Func<string> notebookId, [WorkflowExpression] Func<string> bodydisplayName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SectionPostResponse> __BuildSection(WorkflowExpression<string> notebookId, WorkflowExpression<string> bodydisplayName)
        {
            WorkflowExpression.Validate(notebookId, nameof(notebookId), required: true);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: true);
            return new DeferredBodyAction<SectionPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/notebooks/{0}/sections", ExpressionConverter.ConvertWithUrlEncoding(notebookId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SectionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [WorkflowExpressionFactory(nameof(__BuildPageGet))]
        public IBodyWorkflowAction<PageGetResponse> PageGet([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageGetResponse> __BuildPageGet(WorkflowExpression<string> sectionId, WorkflowExpression<string> filter = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> search = null, WorkflowExpression<string> select = null, WorkflowExpression<int> skip = null, WorkflowExpression<int> top = null, WorkflowExpression<bool> count = null, WorkflowExpression<string> skiptoken = null)
        {
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<PageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sections/{0}/pages", ExpressionConverter.ConvertWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                return new ApiConnectionAction<PageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [WorkflowExpressionFactory(nameof(__BuildPage))]
        public IBodyWorkflowAction<PagePostResponse> Page([WorkflowExpression] Func<string> sectionId, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onenotepersonalip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PagePostResponse> __BuildPage(WorkflowExpression<string> sectionId, WorkflowExpression<string> contentType, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(sectionId, nameof(sectionId), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<PagePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sections/{0}/pages", ExpressionConverter.ConvertWithUrlEncoding(sectionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
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