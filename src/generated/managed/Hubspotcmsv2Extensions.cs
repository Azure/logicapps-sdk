//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcmsv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Hubspotcmsv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaBlogPosttobePublished(Expression<Func<ScheduleaBlogPosttobePublishedInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatelanguagesofmultiLanguagegroup(Expression<Func<UpdatelanguagesofmultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation1, ApiConnectionActionConfiguration> Retrievesapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation1, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation1>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheBlog(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> UpdateaBlogPostdraft(Expression<Func<string>> objectId, Expression<Func<UpdateaBlogPostdraftInput>> body)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Restoreapreviousversionofablogposttothedraftversionoftheblogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Createanewlanguagevariation(Expression<Func<CreateanewlanguagevariationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> CloneaBlog(Expression<Func<CloneaBlogPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation9, ApiConnectionActionConfiguration> GetallBlogPosts(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation9, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation9>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> CreateanewBlog(Expression<Func<CreateanewBlogPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> Restoreapreviousversionofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogPostfromamultiLanguagegroup(Expression<Func<DetachaBlogPostfromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushBlogPostdrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogPosts(Expression<Func<DeleteabatchofBlogPostsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheBlogPostdrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogPosttoamultiLanguagegroup(Expression<Func<AttachaBlogPosttoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation12, ApiConnectionActionConfiguration> Retrievesallthepreviousversionsofablogpost(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation12, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation12>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Setanewprimarylanguage(Expression<Func<SetanewprimarylanguageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/posts/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlog(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation3, ApiConnectionActionConfiguration> UpdateaBlog(Expression<Func<string>> objectId, Expression<Func<UpdateaBlogPostInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/posts/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> RetrieveaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> UpdateaBlogAuthor(Expression<Func<string>> objectId, Expression<Func<UpdateaBlogAuthorInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/authors/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogAuthorfromamultiLanguagegroup(Expression<Func<DetachaBlogAuthorfromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage(Expression<Func<PutSetanewprimarylanguageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogAuthors(Expression<Func<DeleteabatchofBlogAuthorsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation20, ApiConnectionActionConfiguration> GetallBlogAuthors(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation20, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation20>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> CreateanewBlogAuthor(Expression<Func<CreateanewBlogAuthorInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation15, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation(Expression<Func<PostCreateanewlanguagevariationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation15, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation15>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogAuthortoamultiLanguagegroup(Expression<Func<AttachaBlogAuthortoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup(Expression<Func<PostUpdatelanguagesofmultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/authors/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup1(Expression<Func<PostUpdatelanguagesofmultiLanguagegroup1Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation23, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation23, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}/revisions", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation23>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation24, ApiConnectionActionConfiguration> RetrievesapreviousversionofaBlog(Expression<Func<string>> blogId, Expression<Func<string>> revisionId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation24, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}/revisions/{1}", __workflow_blogId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation24>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25, ApiConnectionActionConfiguration> RetrieveaBlog(Expression<Func<string>> blogId)
        {
            var __workflow_blogId = WorkflowExpression.Compile(blogId, nameof(blogId), required: true);
            return new DeferredBodyAction<Successfuloperation25, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blog-settings/settings/{0}", __workflow_blogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation25>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation25, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation1(Expression<Func<PostCreateanewlanguagevariation1Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation25, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation25>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation27, ApiConnectionActionConfiguration> GetallBlogs(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation27, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation27>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage1(Expression<Func<PutSetanewprimarylanguage1Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachablogfromamultiLanguagegroup(Expression<Func<DetachablogfromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachablogtoamultiLanguagegroup(Expression<Func<AttachablogtoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blog-settings/settings/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup2(Expression<Func<PostUpdatelanguagesofmultiLanguagegroup2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachaBlogTagfromamultiLanguagegroup(Expression<Func<DetachaBlogTagfromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofBlogTags(Expression<Func<DeleteabatchofBlogTagsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage2(Expression<Func<PutSetanewprimarylanguage2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation31, ApiConnectionActionConfiguration> GetallBlogTags(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation31, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation31>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> CreateanewBlogTag(Expression<Func<CreateanewBlogTagInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachaBlogTagtoamultiLanguagegroup(Expression<Func<AttachaBlogTagtoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> RetrieveaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaBlogTag(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> UpdateaBlogTag(Expression<Func<string>> objectId, Expression<Func<UpdateaBlogTagInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blogs/tags/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation32, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation2(Expression<Func<PostCreateanewlanguagevariation2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation32, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/blogs/tags/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation32>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Exportadrafttable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/export", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36, ApiConnectionActionConfiguration> Returnalldrafttables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation36, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables/draft";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation36>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Resetadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/reset", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Exportapublishedversionofatable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/export", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("CSV");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Cloneatable(Expression<Func<string>> tableIdOrName, Expression<Func<CloneatableInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/clone", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Getdetailsforapublishedtable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Archiveatable(Expression<Func<string>> tableIdOrName)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation36, ApiConnectionActionConfiguration> Getallpublishedtables(Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation36, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation36>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Createanewtable(Expression<Func<CreateanewtableInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hubdb/tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Unpublishatable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/unpublish", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Getdetailsforadrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Updateanexistingtable(Expression<Func<string>> tableIdOrName, Expression<Func<UpdateanexistingtableInput>> body, Expression<Func<bool>> includeForeignIds = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation37, ApiConnectionActionConfiguration> Publishatablefromdraft(Expression<Func<string>> tableIdOrName, Expression<Func<bool>> includeForeignIds = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_includeForeignIds = WorkflowExpression.Compile(includeForeignIds, nameof(includeForeignIds), required: false);
            return new DeferredBodyAction<Successfuloperation37, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/draft/publish", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeForeignIds != null)
                    callPayload.Queries["includeForeignIds"] = ExpressionConverter.Convert(__workflow_includeForeignIds);
                return new ApiConnectionAction<Successfuloperation37>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47, ApiConnectionActionConfiguration> Getrowsfromdrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredBodyAction<Successfuloperation47, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction<Successfuloperation47>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Getatablerow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Clonearow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft/clone", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Getarowfromthedrafttable(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Permanentlydeletesarow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Replacesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<ReplacesanexistingrowInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Updatesanexistingrow(Expression<Func<string>> tableIdOrName, Expression<Func<int>> rowId, Expression<Func<UpdatesanexistingrowInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/{1}/draft", __workflow_tableIdOrName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation47, ApiConnectionActionConfiguration> Getrowsforatable(Expression<Func<string>> tableIdOrName, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<string>> properties = null)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredBodyAction<Successfuloperation47, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction<Successfuloperation47>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation48, ApiConnectionActionConfiguration> Addanewrowtoatable(Expression<Func<string>> tableIdOrName, Expression<Func<AddanewrowtoatableInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation48, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation48>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Permanentlydeletesrows(Expression<Func<string>> tableIdOrName, Expression<Func<PermanentlydeletesrowsInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft/batch/purge", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation55, ApiConnectionActionConfiguration> Clonerowsinbatch(Expression<Func<string>> tableIdOrName, Expression<Func<ClonerowsinbatchInput>> body)
        {
            var __workflow_tableIdOrName = WorkflowExpression.Compile(tableIdOrName, nameof(tableIdOrName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation55, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hubdb/tables/{0}/rows/draft/batch/clone", __workflow_tableIdOrName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation55>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61, ApiConnectionActionConfiguration> RetrievesapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation61, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation61>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaSitePagetobePublished(Expression<Func<ScheduleaSitePagetobePublishedInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachasitepagetoamultiLanguagegroup(Expression<Func<AttachasitepagetoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachasitepagefromamultiLanguagegroup(Expression<Func<DetachasitepagefromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaSitePage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation64, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation64>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaSitePagetothedraftversionoftheSitePage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EndanactiveABtest(Expression<Func<EndanactiveABtestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheSitePage(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaSitePagedraft(Expression<Func<string>> objectId, Expression<Func<UpdateaSitePagedraftInput>> body)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69, ApiConnectionActionConfiguration> GetallSitePages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation69, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation69>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewSitePage(Expression<Func<CreateanewSitePageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation3(Expression<Func<PostCreateanewlanguagevariation3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewABtestvariation(Expression<Func<CreateanewABtestvariationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup3(Expression<Func<PostUpdatelanguagesofmultiLanguagegroup3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofSitePages(Expression<Func<DeleteabatchofSitePagesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CloneaSitePage(Expression<Func<CloneaSitePageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage3(Expression<Func<PutSetanewprimarylanguage3Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushSitePagedrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RerunapreviousABtest(Expression<Func<RerunapreviousABtestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/site-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheSitePagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrieveaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaSitePage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaSitePage(Expression<Func<string>> objectId, Expression<Func<UpdateaSitePageInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/site-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation64, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation64, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation64>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation78, ApiConnectionActionConfiguration> RetrievesallthepreviousversionsofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> after = null, Expression<Func<string>> before = null, Expression<Func<string>> limit = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<Successfuloperation78, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<Successfuloperation78>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation79, ApiConnectionActionConfiguration> GetallLandingPageFolders(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation79, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation79>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> CreateanewFolder(Expression<Func<CreateanewFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrievethefulldraftversionoftheLandingPage(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaLandingPagedraft(Expression<Func<string>> objectId, Expression<Func<UpdateaLandingPagedraftInput>> body)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation69, ApiConnectionActionConfiguration> GetallLandingPages(Expression<Func<string>> createdAt = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> updatedAt = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> sort = null, Expression<Func<string>> after = null, Expression<Func<string>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_createdAt = WorkflowExpression.Compile(createdAt, nameof(createdAt), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_updatedAt = WorkflowExpression.Compile(updatedAt, nameof(updatedAt), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation69, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdAt != null)
                    callPayload.Queries["createdAt"] = ExpressionConverter.Convert(__workflow_createdAt);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["createdAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["createdBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_updatedAt != null)
                    callPayload.Queries["updatedAt"] = ExpressionConverter.Convert(__workflow_updatedAt);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["updatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["updatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation69>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CreateanewLandingPage(Expression<Func<CreateanewLandingPageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> CloneaLandingPage(Expression<Func<CloneaLandingPageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> RestoreapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutSetanewprimarylanguage4(Expression<Func<PutSetanewprimarylanguage4Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/set-new-lang-primary";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> RetrieveaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaFolder(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation80, ApiConnectionActionConfiguration> UpdateaFolder(Expression<Func<string>> objectId, Expression<Func<UpdateaFolderInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation80, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation80>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewABtestvariation(Expression<Func<PostCreateanewABtestvariationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/create-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachalandingpagetoamultiLanguagegroup(Expression<Func<AttachalandingpagetoamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/attach-to-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation61, ApiConnectionActionConfiguration> RetrievesapreviousversionofaLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation61, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation61>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEndanactiveABtest(Expression<Func<PostEndanactiveABtestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/end";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PushLandingPagedrafteditslive(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft/push-live", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachalandingpagefromamultiLanguagegroup(Expression<Func<DetachalandingpagefromamultiLanguagegroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/detach-from-lang-group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ScheduleaLandingPagetobePublished(Expression<Func<ScheduleaLandingPagetobePublishedInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUpdatelanguagesofmultiLanguagegroup4(Expression<Func<PostUpdatelanguagesofmultiLanguagegroup4Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/update-languages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostRerunapreviousABtest(Expression<Func<PostRerunapreviousABtestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/ab-test/rerun";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofFolders(Expression<Func<DeleteabatchofFoldersInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/folders/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation97, ApiConnectionActionConfiguration> RetrievesapreviousversionofaFolder(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation97, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/folders/{0}/revisions/{1}", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation97>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResettheLandingPagedrafttotheliveversion(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/draft/reset", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RetrieveaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null, Expression<Func<string>> property = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_property = WorkflowExpression.Compile(property, nameof(property), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_property != null)
                    callPayload.Queries["property"] = ExpressionConverter.Convert(__workflow_property);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteaLandingPage(Expression<Func<string>> objectId, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> UpdateaLandingPage(Expression<Func<string>> objectId, Expression<Func<UpdateaLandingPageInput>> body, Expression<Func<bool>> archived = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> PostCreateanewlanguagevariation4(Expression<Func<PostCreateanewlanguagevariation4Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/multi-language/create-language-variation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteabatchofLandingPages(Expression<Func<DeleteabatchofLandingPagesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pages/landing-pages/batch/archive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcmsv2")]
        public IBodyWorkflowAction<Successfuloperation63, ApiConnectionActionConfiguration> RestoreapreviousversionofaLandingPagetothedraftversionoftheLandingPage(Expression<Func<string>> objectId, Expression<Func<string>> revisionId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_revisionId = WorkflowExpression.Compile(revisionId, nameof(revisionId), required: true);
            return new DeferredBodyAction<Successfuloperation63, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pages/landing-pages/{0}/revisions/{1}/restore-to-draft", __workflow_objectId.WithUrlEncoding(1), __workflow_revisionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Successfuloperation63>(callPayload);
            });
        }
    }

    public class Hubspotcmsv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class ScheduleaBlogPosttobePublishedInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }
    }

    public class UpdatelanguagesofmultiLanguagegroupInput
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class Successfuloperation1
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public ObjectEntity ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class ObjectEntity
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Successfuloperation3
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class UpdateaBlogPostdraftInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("postBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostBody { get; set; }

        [JsonProperty("postSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssSummary { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("tagIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class CreateanewlanguagevariationInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }
    }

    public class CloneaBlogPostInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("cloneName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CloneName { get; set; }
    }

    public class Successfuloperation9
    {
        [JsonProperty("results")]
        public Result6[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result6
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Paging
    {
        [JsonProperty("next")]
        public Next Next { get; set; }
    }

    public class Next
    {
        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class CreateanewBlogPostInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("postBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostBody { get; set; }

        [JsonProperty("postSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssSummary { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("tagIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class DetachaBlogPostfromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class DeleteabatchofBlogPostsInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class AttachaBlogPosttoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class Successfuloperation12
    {
        [JsonProperty("results")]
        public Result7[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result7
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object1 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object1
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId")]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride")]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("postBody")]
        public string PostBody { get; set; }

        [JsonProperty("postSummary")]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody")]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary")]
        public string RssSummary { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tagIds")]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Paging1
    {
        [JsonProperty("next")]
        public Next Next { get; set; }

        [JsonProperty("prev")]
        public Prev Prev { get; set; }
    }

    public class Prev
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SetanewprimarylanguageInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class UpdateaBlogPostInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("blogAuthorId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BlogAuthorId { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableGoogleAmpOutputOverride", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableGoogleAmpOutputOverride { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("postBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostBody { get; set; }

        [JsonProperty("postSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostSummary { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("rssBody", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssBody { get; set; }

        [JsonProperty("rssSummary", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RssSummary { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("tagIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] TagIds { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation15
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class UpdateaBlogAuthorInput
    {
        [JsonProperty("avatar", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Avatar { get; set; }

        [JsonProperty("bio", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Bio { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("facebook", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Facebook { get; set; }

        [JsonProperty("fullName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FullName { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("linkedin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Linkedin { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Twitter { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("website", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Website { get; set; }
    }

    public class DetachaBlogAuthorfromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class PutSetanewprimarylanguageInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class DeleteabatchofBlogAuthorsInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class Successfuloperation20
    {
        [JsonProperty("results")]
        public Result8[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result8
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class CreateanewBlogAuthorInput
    {
        [JsonProperty("avatar", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Avatar { get; set; }

        [JsonProperty("bio", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Bio { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("facebook", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Facebook { get; set; }

        [JsonProperty("fullName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FullName { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("linkedin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Linkedin { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Twitter { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("website", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Website { get; set; }
    }

    public class PostCreateanewlanguagevariationInput
    {
        [JsonProperty("blogAuthor", DefaultValueHandling = DefaultValueHandling.Include)]
        public BlogAuthor BlogAuthor { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class BlogAuthor
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class AttachaBlogAuthortoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class PostUpdatelanguagesofmultiLanguagegroupInput
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class PostUpdatelanguagesofmultiLanguagegroup1Input
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class Successfuloperation23
    {
        [JsonProperty("results")]
        public Result15[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result15
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object2 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object2
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation24
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object2 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Successfuloperation25
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class PostCreateanewlanguagevariation1Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }
    }

    public class Successfuloperation27
    {
        [JsonProperty("results")]
        public Result16[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result16
    {
        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("allowComments")]
        public bool AllowComments { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publicTitle")]
        public string PublicTitle { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class PutSetanewprimarylanguage1Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class DetachablogfromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class AttachablogtoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class PostUpdatelanguagesofmultiLanguagegroup2Input
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class DetachaBlogTagfromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class DeleteabatchofBlogTagsInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class PutSetanewprimarylanguage2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class Successfuloperation31
    {
        [JsonProperty("results")]
        public Result17[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result17
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation32
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class CreateanewBlogTagInput
    {
        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }
    }

    public class AttachaBlogTagtoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class UpdateaBlogTagInput
    {
        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }
    }

    public class PostCreateanewlanguagevariation2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class Successfuloperation36
    {
        [JsonProperty("results")]
        public Result24[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result24
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("columns")]
        public Column[] Columns { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public UpdatedBy UpdatedBy { get; set; }

        [JsonProperty("useForPages")]
        public bool UseForPages { get; set; }

        [JsonProperty("allowChildTables")]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages")]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("isOrderedManually")]
        public bool IsOrderedManually { get; set; }

        [JsonProperty("dynamicMetaTags")]
        public JToken DynamicMetaTags { get; set; }

        [JsonProperty("allowPublicApiAccess")]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Column
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foreignIds")]
        public ForeignId[] ForeignIds { get; set; }

        [JsonProperty("foreignIdsByName")]
        public JToken ForeignIdsByName { get; set; }

        [JsonProperty("foreignIdsById")]
        public JToken ForeignIdsById { get; set; }

        [JsonProperty("optionCount")]
        public string OptionCount { get; set; }
    }

    public class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ForeignId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreatedBy
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class UpdatedBy
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class Successfuloperation37
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("columns")]
        public Column1[] Columns { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("columnCount")]
        public int ColumnCount { get; set; }

        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public UpdatedBy UpdatedBy { get; set; }

        [JsonProperty("useForPages")]
        public bool UseForPages { get; set; }

        [JsonProperty("allowChildTables")]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages")]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("isOrderedManually")]
        public bool IsOrderedManually { get; set; }

        [JsonProperty("dynamicMetaTags")]
        public JToken DynamicMetaTags { get; set; }

        [JsonProperty("allowPublicApiAccess")]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class Column1
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("foreignIds")]
        public ForeignId[] ForeignIds { get; set; }

        [JsonProperty("foreignIdsByName")]
        public JToken ForeignIdsByName { get; set; }

        [JsonProperty("foreignIdsById")]
        public JToken ForeignIdsById { get; set; }

        [JsonProperty("optionCount")]
        public string OptionCount { get; set; }
    }

    public class CloneatableInput
    {
        [JsonProperty("copyRows", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CopyRows { get; set; }

        [JsonProperty("newName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewName { get; set; }

        [JsonProperty("newLabel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewLabel { get; set; }
    }

    public class CreateanewtableInput
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("useForPages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseForPages { get; set; }

        [JsonProperty("allowPublicApiAccess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("allowChildTables", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("columns", DefaultValueHandling = DefaultValueHandling.Include)]
        public Column5[] Columns { get; set; }

        [JsonProperty("dynamicMetaTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken DynamicMetaTags { get; set; }
    }

    public class Column5
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("foreignTableId")]
        public string ForeignTableId { get; set; }

        [JsonProperty("foreignColumnId")]
        public string ForeignColumnId { get; set; }
    }

    public class UpdateanexistingtableInput
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("useForPages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseForPages { get; set; }

        [JsonProperty("allowPublicApiAccess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowPublicApiAccess { get; set; }

        [JsonProperty("allowChildTables", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowChildTables { get; set; }

        [JsonProperty("enableChildTablePages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableChildTablePages { get; set; }

        [JsonProperty("columns", DefaultValueHandling = DefaultValueHandling.Include)]
        public Column5[] Columns { get; set; }

        [JsonProperty("dynamicMetaTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken DynamicMetaTags { get; set; }
    }

    public class Successfuloperation47
    {
        [JsonProperty("results")]
        public Result26[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result26
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class Successfuloperation48
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class ReplacesanexistingrowInput
    {
        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Values { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("childTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChildTableId { get; set; }

        [JsonProperty("displayIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayIndex { get; set; }
    }

    public class UpdatesanexistingrowInput
    {
        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Values { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("childTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChildTableId { get; set; }

        [JsonProperty("displayIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DisplayIndex { get; set; }
    }

    public class AddanewrowtoatableInput
    {
        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Values { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Path { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("childTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChildTableId { get; set; }

        [JsonProperty("displayIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DisplayIndex { get; set; }
    }

    public class PermanentlydeletesrowsInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class Successfuloperation55
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("results")]
        public Result28[] Results { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("links")]
        public JToken Links { get; set; }
    }

    public class Result28
    {
        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("childTableId")]
        public string ChildTableId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("publishedAt")]
        public string PublishedAt { get; set; }
    }

    public class ClonerowsinbatchInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class Successfuloperation61
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object4 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object4
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation63
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules")]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class ScheduleaSitePagetobePublishedInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }
    }

    public class AttachasitepagetoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class DetachasitepagefromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class Successfuloperation64
    {
        [JsonProperty("results")]
        public Result41[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result41
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object5 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object5
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class EndanactiveABtestInput
    {
        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("winnerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WinnerId { get; set; }
    }

    public class UpdateaSitePagedraftInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation69
    {
        [JsonProperty("results")]
        public Result44[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result44
    {
        [JsonProperty("abStatus")]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId")]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard")]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets")]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId")]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory")]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished")]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId")]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType")]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId")]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets")]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets")]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage")]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText")]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml")]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml")]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle")]
        public string HtmlTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss")]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("layoutSections")]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl")]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId")]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate")]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled")]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId")]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl")]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected")]
        public bool PageRedirected { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publicAccessRulesEnabled")]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("subCategory")]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath")]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues")]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId")]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations")]
        public JToken Translations { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage")]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers")]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public JToken Widgets { get; set; }
    }

    public class CreateanewSitePageInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class PostCreateanewlanguagevariation3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class CreateanewABtestvariationInput
    {
        [JsonProperty("contentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentId { get; set; }

        [JsonProperty("variationName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VariationName { get; set; }
    }

    public class PostUpdatelanguagesofmultiLanguagegroup3Input
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class DeleteabatchofSitePagesInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class CloneaSitePageInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("cloneName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CloneName { get; set; }
    }

    public class PutSetanewprimarylanguage3Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class RerunapreviousABtestInput
    {
        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("variationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VariationId { get; set; }
    }

    public class UpdateaSitePageInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class Successfuloperation78
    {
        [JsonProperty("results")]
        public Result48[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging1 Paging { get; set; }
    }

    public class Result48
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object7 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class Object7
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation79
    {
        [JsonProperty("results")]
        public Result49[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    public class Result49
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class Successfuloperation80
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class CreateanewFolderInput
    {
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }
    }

    public class UpdateaLandingPagedraftInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class CreateanewLandingPageInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class CloneaLandingPageInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("cloneName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CloneName { get; set; }
    }

    public class PutSetanewprimarylanguage4Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class UpdateaFolderInput
    {
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("deletedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeletedAt { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }
    }

    public class PostCreateanewABtestvariationInput
    {
        [JsonProperty("contentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentId { get; set; }

        [JsonProperty("variationName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VariationName { get; set; }
    }

    public class AttachalandingpagetoamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class PostEndanactiveABtestInput
    {
        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("winnerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WinnerId { get; set; }
    }

    public class DetachalandingpagefromamultiLanguagegroupInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }

    public class ScheduleaLandingPagetobePublishedInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }
    }

    public class PostUpdatelanguagesofmultiLanguagegroup4Input
    {
        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Languages { get; set; }

        [JsonProperty("primaryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryId { get; set; }
    }

    public class PostRerunapreviousABtestInput
    {
        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("variationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VariationId { get; set; }
    }

    public class DeleteabatchofFoldersInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }

    public class Successfuloperation97
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public Object7 ObjectEntity { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class UpdateaLandingPageInput
    {
        [JsonProperty("abStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbStatus { get; set; }

        [JsonProperty("abTestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbTestId { get; set; }

        [JsonProperty("archivedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchivedAt { get; set; }

        [JsonProperty("archivedInDashboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ArchivedInDashboard { get; set; }

        [JsonProperty("attachedStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] AttachedStylesheets { get; set; }

        [JsonProperty("authorName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorName { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("contentGroupId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentGroupId { get; set; }

        [JsonProperty("contentTypeCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentTypeCategory { get; set; }

        [JsonProperty("created", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Created { get; set; }

        [JsonProperty("createdById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedById { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }

        [JsonProperty("currentlyPublished", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CurrentlyPublished { get; set; }

        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("dynamicPageDataSourceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceId { get; set; }

        [JsonProperty("dynamicPageDataSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageDataSourceType { get; set; }

        [JsonProperty("dynamicPageHubDbTableId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DynamicPageHubDbTableId { get; set; }

        [JsonProperty("enableDomainStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableDomainStylesheets { get; set; }

        [JsonProperty("enableLayoutStylesheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool EnableLayoutStylesheets { get; set; }

        [JsonProperty("featuredImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImage { get; set; }

        [JsonProperty("featuredImageAltText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FeaturedImageAltText { get; set; }

        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("footerHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FooterHtml { get; set; }

        [JsonProperty("headHtml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeadHtml { get; set; }

        [JsonProperty("htmlTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlTitle { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("includeDefaultCustomCss", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeDefaultCustomCss { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("layoutSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LayoutSections { get; set; }

        [JsonProperty("linkRelCanonicalUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LinkRelCanonicalUrl { get; set; }

        [JsonProperty("mabExperimentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MabExperimentId { get; set; }

        [JsonProperty("metaDescription", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MetaDescription { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("pageExpiryDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryDate { get; set; }

        [JsonProperty("pageExpiryEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageExpiryEnabled { get; set; }

        [JsonProperty("pageExpiryRedirectId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectId { get; set; }

        [JsonProperty("pageExpiryRedirectUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageExpiryRedirectUrl { get; set; }

        [JsonProperty("pageRedirected", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PageRedirected { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("publicAccessRules", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PublicAccessRules { get; set; }

        [JsonProperty("publicAccessRulesEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PublicAccessRulesEnabled { get; set; }

        [JsonProperty("publishDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishDate { get; set; }

        [JsonProperty("publishImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Slug { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public string State { get; set; }

        [JsonProperty("subCategory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubCategory { get; set; }

        [JsonProperty("templatePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplatePath { get; set; }

        [JsonProperty("themeSettingsValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ThemeSettingsValues { get; set; }

        [JsonProperty("translatedFromId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TranslatedFromId { get; set; }

        [JsonProperty("translations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Translations { get; set; }

        [JsonProperty("updated", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Updated { get; set; }

        [JsonProperty("updatedById", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedById { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("useFeaturedImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool UseFeaturedImage { get; set; }

        [JsonProperty("widgetContainers", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken WidgetContainers { get; set; }

        [JsonProperty("widgets", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Widgets { get; set; }
    }

    public class PostCreateanewlanguagevariation4Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("primaryLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PrimaryLanguage { get; set; }
    }

    public class DeleteabatchofLandingPagesInput
    {
        [JsonProperty("inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Inputs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcmsv2;

    public partial class WorkflowManagedActions
    {
        public Hubspotcmsv2Actions Hubspotcmsv2(string connectionId) => new Hubspotcmsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Hubspotcmsv2Triggers Hubspotcmsv2(string connectionId) => new Hubspotcmsv2Triggers(connectionId);
    }
}