//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tumblrip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TumblripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogGetResponse> BlogGet(Expression<Func<string>> blogIdentifier)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<BlogGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/info", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlogGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlocksGetResponse> BlocksGet(Expression<Func<string>> blogIdentifier)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<BlocksGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/blocks", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlocksGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostUnblock(Expression<Func<string>> blogIdentifier, Expression<Func<string>> bodyblockedTumblelog = null, Expression<Func<bool>> bodyanonymousOnly = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodyblockedTumblelog = WorkflowExpression.Compile(bodyblockedTumblelog, nameof(bodyblockedTumblelog), required: false);
            var __workflow_bodyanonymousOnly = WorkflowExpression.Compile(bodyanonymousOnly, nameof(bodyanonymousOnly), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/blocks", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyblockedTumblelog != null)
                {
                    body["blocked_tumblelog"] = ExpressionConverter.ConvertO(__workflow_bodyblockedTumblelog);
                    bodypropCount++;
                }

                if (__workflow_bodyanonymousOnly != null)
                {
                    body["anonymous_only"] = ExpressionConverter.ConvertO(__workflow_bodyanonymousOnly);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostBlock(Expression<Func<string>> blogIdentifier, Expression<Func<string>> bodyblockedTumblelog = null, Expression<Func<string>> bodypostId = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodyblockedTumblelog = WorkflowExpression.Compile(bodyblockedTumblelog, nameof(bodyblockedTumblelog), required: false);
            var __workflow_bodypostId = WorkflowExpression.Compile(bodypostId, nameof(bodypostId), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/blocks", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyblockedTumblelog != null)
                {
                    body["blocked_tumblelog"] = ExpressionConverter.ConvertO(__workflow_bodyblockedTumblelog);
                    bodypropCount++;
                }

                if (__workflow_bodypostId != null)
                {
                    body["post_id"] = ExpressionConverter.ConvertO(__workflow_bodypostId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostsBlock(Expression<Func<string>> blogIdentifier, Expression<Func<string>> bodyblockedTumblelogs = null, Expression<Func<bool>> bodyforce = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodyblockedTumblelogs = WorkflowExpression.Compile(bodyblockedTumblelogs, nameof(bodyblockedTumblelogs), required: false);
            var __workflow_bodyforce = WorkflowExpression.Compile(bodyforce, nameof(bodyforce), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/blocks/bulk", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyblockedTumblelogs != null)
                {
                    body["blocked_tumblelogs"] = ExpressionConverter.ConvertO(__workflow_bodyblockedTumblelogs);
                    bodypropCount++;
                }

                if (__workflow_bodyforce != null)
                {
                    body["force"] = ExpressionConverter.ConvertO(__workflow_bodyforce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogLikesGetResponse> BlogLikesGet(Expression<Func<string>> blogIdentifier, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int>> before = null, Expression<Func<int>> after = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            return new DeferredBodyAction<BlogLikesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/likes", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                return new ApiConnectionAction<BlogLikesGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogFollowingGetResponse> BlogFollowingGet(Expression<Func<string>> blogIdentifier, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<BlogFollowingGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/following", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<BlogFollowingGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogFollowersGetResponse> BlogFollowersGet(Expression<Func<string>> blogIdentifier, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<BlogFollowersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/followers", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<BlogFollowersGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogFollowCheckGetResponse> BlogFollowCheckGet(Expression<Func<string>> blogIdentifier, Expression<Func<string>> query)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<BlogFollowCheckGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/followed_by", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<BlogFollowCheckGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostsQueuedGetResponse> PostsQueuedGet(Expression<Func<string>> blogIdentifier, Expression<Func<string>> filter = null, Expression<Func<string>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<PostsQueuedGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/queue", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<PostsQueuedGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostQueuedReorder(Expression<Func<string>> blogIdentifier, Expression<Func<string>> bodypostId = null, Expression<Func<string>> bodyinsertAfter = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodypostId = WorkflowExpression.Compile(bodypostId, nameof(bodypostId), required: false);
            var __workflow_bodyinsertAfter = WorkflowExpression.Compile(bodyinsertAfter, nameof(bodyinsertAfter), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/queue/reorder", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypostId != null)
                {
                    body["post_id"] = ExpressionConverter.ConvertO(__workflow_bodypostId);
                    bodypropCount++;
                }

                if (__workflow_bodyinsertAfter != null)
                {
                    body["insert_after"] = ExpressionConverter.ConvertO(__workflow_bodyinsertAfter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostQueuedShuffle(Expression<Func<string>> blogIdentifier)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/queue/shuffle", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostDraftsGetResponse> PostDraftsGet(Expression<Func<string>> blogIdentifier, Expression<Func<double>> beforeId = null, Expression<Func<string>> filter = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_beforeId = WorkflowExpression.Compile(beforeId, nameof(beforeId), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostDraftsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/draft", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_beforeId != null)
                    callPayload.Queries["before_id"] = ExpressionConverter.Convert(__workflow_beforeId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PostDraftsGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostSubmissionGetResponse> PostSubmissionGet(Expression<Func<string>> blogIdentifier, Expression<Func<string>> offset = null, Expression<Func<string>> filter = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostSubmissionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/submission", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PostSubmissionGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<ActivityFeedGetResponse> ActivityFeedGet(Expression<Func<string>> blogIdentifier, Expression<Func<string>> types = null, Expression<Func<int>> before = null, Expression<Func<bool>> rollups = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_types = WorkflowExpression.Compile(types, nameof(types), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_rollups = WorkflowExpression.Compile(rollups, nameof(rollups), required: false);
            return new DeferredBodyAction<ActivityFeedGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/notifications", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(__workflow_types);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_rollups != null)
                    callPayload.Queries["rollups"] = ExpressionConverter.Convert(__workflow_rollups);
                return new ApiConnectionAction<ActivityFeedGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostCreatePostResponse> PostCreate(Expression<Func<string>> blogIdentifier, Expression<Func<bodycontentInputItem[]>> bodycontent = null, Expression<Func<bodylayoutInputItem[]>> bodylayout = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypublishedOn = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodysourceUrl = null, Expression<Func<bool>> bodysendToTwitter = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyinteractabilityReblog = null, Expression<Func<string>> bodyparentTumblelogUuid = null, Expression<Func<int>> bodyparentPostId = null, Expression<Func<string>> bodyreblogKey = null, Expression<Func<bool>> bodyhideTrail = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodylayout = WorkflowExpression.Compile(bodylayout, nameof(bodylayout), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypublishedOn = WorkflowExpression.Compile(bodypublishedOn, nameof(bodypublishedOn), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodysourceUrl = WorkflowExpression.Compile(bodysourceUrl, nameof(bodysourceUrl), required: false);
            var __workflow_bodysendToTwitter = WorkflowExpression.Compile(bodysendToTwitter, nameof(bodysendToTwitter), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyinteractabilityReblog = WorkflowExpression.Compile(bodyinteractabilityReblog, nameof(bodyinteractabilityReblog), required: false);
            var __workflow_bodyparentTumblelogUuid = WorkflowExpression.Compile(bodyparentTumblelogUuid, nameof(bodyparentTumblelogUuid), required: false);
            var __workflow_bodyparentPostId = WorkflowExpression.Compile(bodyparentPostId, nameof(bodyparentPostId), required: false);
            var __workflow_bodyreblogKey = WorkflowExpression.Compile(bodyreblogKey, nameof(bodyreblogKey), required: false);
            var __workflow_bodyhideTrail = WorkflowExpression.Compile(bodyhideTrail, nameof(bodyhideTrail), required: false);
            return new DeferredBodyAction<PostCreatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodylayout != null)
                {
                    body["layout"] = ExpressionConverter.ConvertO(__workflow_bodylayout);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedOn != null)
                {
                    body["published_on"] = ExpressionConverter.ConvertO(__workflow_bodypublishedOn);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodysourceUrl != null)
                {
                    body["source_url"] = ExpressionConverter.ConvertO(__workflow_bodysourceUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysendToTwitter != null)
                {
                    body["send_to_twitter"] = ExpressionConverter.ConvertO(__workflow_bodysendToTwitter);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    body["is_private"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyinteractabilityReblog != null)
                {
                    body["interactability_reblog"] = ExpressionConverter.ConvertO(__workflow_bodyinteractabilityReblog);
                    bodypropCount++;
                }

                if (__workflow_bodyparentTumblelogUuid != null)
                {
                    body["parent_tumblelog_uuid"] = ExpressionConverter.ConvertO(__workflow_bodyparentTumblelogUuid);
                    bodypropCount++;
                }

                if (__workflow_bodyparentPostId != null)
                {
                    body["parent_post_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentPostId);
                    bodypropCount++;
                }

                if (__workflow_bodyreblogKey != null)
                {
                    body["reblog_key"] = ExpressionConverter.ConvertO(__workflow_bodyreblogKey);
                    bodypropCount++;
                }

                if (__workflow_bodyhideTrail != null)
                {
                    body["hide_trail"] = ExpressionConverter.ConvertO(__workflow_bodyhideTrail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCreatePostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostRetrieveGetResponse> PostRetrieveGet(Expression<Func<string>> blogIdentifier, Expression<Func<string>> postId, Expression<Func<postFormatInput>> postFormat = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: false);
            return new DeferredBodyAction<PostRetrieveGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/{1}", __workflow_blogIdentifier.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["post_format"] = Convert.ToString("npf");
                if (__workflow_postFormat != null)
                    callPayload.Queries["post_format"] = ExpressionConverter.Convert(__workflow_postFormat);
                return new ApiConnectionAction<PostRetrieveGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostEditPutResponse> PostEditPut(Expression<Func<string>> blogIdentifier, Expression<Func<string>> postId, Expression<Func<bodycontentInputItem[]>> bodycontent = null, Expression<Func<bodylayoutInputItem[]>> bodylayout = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypublishedOn = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodysourceUrl = null, Expression<Func<bool>> bodysendToTwitter = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyinteractabilityReblog = null, Expression<Func<string>> bodyparentTumblelogUuid = null, Expression<Func<int>> bodyparentPostId = null, Expression<Func<string>> bodyreblogKey = null, Expression<Func<bool>> bodyhideTrail = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodylayout = WorkflowExpression.Compile(bodylayout, nameof(bodylayout), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypublishedOn = WorkflowExpression.Compile(bodypublishedOn, nameof(bodypublishedOn), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodysourceUrl = WorkflowExpression.Compile(bodysourceUrl, nameof(bodysourceUrl), required: false);
            var __workflow_bodysendToTwitter = WorkflowExpression.Compile(bodysendToTwitter, nameof(bodysendToTwitter), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyinteractabilityReblog = WorkflowExpression.Compile(bodyinteractabilityReblog, nameof(bodyinteractabilityReblog), required: false);
            var __workflow_bodyparentTumblelogUuid = WorkflowExpression.Compile(bodyparentTumblelogUuid, nameof(bodyparentTumblelogUuid), required: false);
            var __workflow_bodyparentPostId = WorkflowExpression.Compile(bodyparentPostId, nameof(bodyparentPostId), required: false);
            var __workflow_bodyreblogKey = WorkflowExpression.Compile(bodyreblogKey, nameof(bodyreblogKey), required: false);
            var __workflow_bodyhideTrail = WorkflowExpression.Compile(bodyhideTrail, nameof(bodyhideTrail), required: false);
            return new DeferredBodyAction<PostEditPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/posts/{1}", __workflow_blogIdentifier.WithUrlEncoding(1), __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodylayout != null)
                {
                    body["layout"] = ExpressionConverter.ConvertO(__workflow_bodylayout);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedOn != null)
                {
                    body["published_on"] = ExpressionConverter.ConvertO(__workflow_bodypublishedOn);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodysourceUrl != null)
                {
                    body["source_url"] = ExpressionConverter.ConvertO(__workflow_bodysourceUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysendToTwitter != null)
                {
                    body["send_to_twitter"] = ExpressionConverter.ConvertO(__workflow_bodysendToTwitter);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    body["is_private"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyinteractabilityReblog != null)
                {
                    body["interactability_reblog"] = ExpressionConverter.ConvertO(__workflow_bodyinteractabilityReblog);
                    bodypropCount++;
                }

                if (__workflow_bodyparentTumblelogUuid != null)
                {
                    body["parent_tumblelog_uuid"] = ExpressionConverter.ConvertO(__workflow_bodyparentTumblelogUuid);
                    bodypropCount++;
                }

                if (__workflow_bodyparentPostId != null)
                {
                    body["parent_post_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentPostId);
                    bodypropCount++;
                }

                if (__workflow_bodyreblogKey != null)
                {
                    body["reblog_key"] = ExpressionConverter.ConvertO(__workflow_bodyreblogKey);
                    bodypropCount++;
                }

                if (__workflow_bodyhideTrail != null)
                {
                    body["hide_trail"] = ExpressionConverter.ConvertO(__workflow_bodyhideTrail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostEditPutResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostDeleteResponse> PostDelete(Expression<Func<string>> blogIdentifier, Expression<Func<string>> bodyid)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredBodyAction<PostDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/post/delete", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDeleteResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostNotesGetResponse> PostNotesGet(Expression<Func<string>> blogIdentifier, Expression<Func<double>> id, Expression<Func<double>> beforeTimestamp = null, Expression<Func<modeInput>> mode = null)
        {
            var __workflow_blogIdentifier = WorkflowExpression.Compile(blogIdentifier, nameof(blogIdentifier), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_beforeTimestamp = WorkflowExpression.Compile(beforeTimestamp, nameof(beforeTimestamp), required: false);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: false);
            return new DeferredBodyAction<PostNotesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/blog/{0}/notes", __workflow_blogIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_beforeTimestamp != null)
                    callPayload.Queries["before_timestamp"] = ExpressionConverter.Convert(__workflow_beforeTimestamp);
                callPayload.Queries["mode"] = Convert.ToString("all");
                if (__workflow_mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(__workflow_mode);
                return new ApiConnectionAction<PostNotesGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<UserInfoGetResponse> UserInfoGet()
        {
            var apiCallPath = "/v2/user/info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserInfoGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<UserLimitGetResponse> UserLimitGet()
        {
            var apiCallPath = "/v2/user/limits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserLimitGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<UserDashboardGetResponse> UserDashboardGet()
        {
            var apiCallPath = "/v2/user/dashboard";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDashboardGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<UserLikesGetResponse> UserLikesGet()
        {
            var apiCallPath = "/v2/user/likes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserLikesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<UserFollowingGetResponse> UserFollowingGet()
        {
            var apiCallPath = "/v2/user/following";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserFollowingGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogFollowPostResponse> BlogFollow(Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<BlogFollowPostResponse>(() =>
            {
                var apiCallPath = "/v2/user/follow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BlogFollowPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<BlogUnfollowPostResponse> BlogUnfollow(Expression<Func<string>> bodyurl = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            return new DeferredBodyAction<BlogUnfollowPostResponse>(() =>
            {
                var apiCallPath = "/v2/user/unfollow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BlogUnfollowPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostLike(Expression<Func<string>> bodyid, Expression<Func<string>> bodyreblogKey)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyreblogKey = WorkflowExpression.Compile(bodyreblogKey, nameof(bodyreblogKey), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/user/like";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["reblog_key"] = ExpressionConverter.ConvertO(__workflow_bodyreblogKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<string> PostUnlike(Expression<Func<string>> bodyid, Expression<Func<string>> bodyreblogKey)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyreblogKey = WorkflowExpression.Compile(bodyreblogKey, nameof(bodyreblogKey), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/user/unlike";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["reblog_key"] = ExpressionConverter.ConvertO(__workflow_bodyreblogKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        public IBodyWorkflowAction<PostTagGetResponseItem[]> PostTagGet(Expression<Func<string>> tag, Expression<Func<int>> before = null, Expression<Func<double>> limit = null, Expression<Func<string>> filter = null)
        {
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: true);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostTagGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v2/tagged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<PostTagGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class TumblripTriggers([ConnectionName] string connectionId)
    {
    }

    public class BlogGetResponse
    {
        [JsonProperty("blog")]
        public BlogGetResponseBlogType Blog { get; set; }
    }

    public class BlogGetResponseBlogType
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("ask")]
        public bool Ask { get; set; }

        [JsonProperty("ask_anon")]
        public bool AskAnon { get; set; }

        [JsonProperty("ask_page_title")]
        public string AskPageTitle { get; set; }

        [JsonProperty("asks_allow_media")]
        public bool AsksAllowMedia { get; set; }

        [JsonProperty("avatar")]
        public BlogGetResponseBlogTypeAvatarTypeItem[] Avatar { get; set; }

        [JsonProperty("can_chat")]
        public bool CanChat { get; set; }

        [JsonProperty("can_send_fan_mail")]
        public bool CanSendFanMail { get; set; }

        [JsonProperty("can_subscribe")]
        public bool CanSubscribe { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("drafts")]
        public int Drafts { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("facebook_opengraph_enabled")]
        public string FacebookOpengraphEnabled { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("is_blocked_from_primary")]
        public bool IsBlockedFromPrimary { get; set; }

        [JsonProperty("is_nsfw")]
        public bool IsNsfw { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("theme")]
        public BlogGetResponseBlogTypeThemeType Theme { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_posts")]
        public int TotalPosts { get; set; }

        [JsonProperty("tweet")]
        public string Tweet { get; set; }

        [JsonProperty("twitter_enabled")]
        public bool TwitterEnabled { get; set; }

        [JsonProperty("twitter_send")]
        public bool TwitterSend { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class BlogGetResponseBlogTypeAvatarTypeItem
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BlogGetResponseBlogTypeThemeType
    {
        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class BlocksGetResponse
    {
        [JsonProperty("blocked_tumblelogs")]
        public BlocksGetResponseBlockedTumblelogsTypeItem[] BlockedTumblelogs { get; set; }

        [JsonProperty("_links")]
        public BlocksGetResponseLinksType Links { get; set; }
    }

    public class BlocksGetResponseBlockedTumblelogsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class BlocksGetResponseLinksType
    {
        [JsonProperty("next")]
        public BlocksGetResponseLinksTypeNextType Next { get; set; }
    }

    public class BlocksGetResponseLinksTypeNextType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("query_params")]
        public BlocksGetResponseLinksTypeNextTypeQueryParamsType QueryParams { get; set; }
    }

    public class BlocksGetResponseLinksTypeNextTypeQueryParamsType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class BlogLikesGetResponse
    {
        [JsonProperty("liked_posts")]
        public BlogLikesGetResponseLikedPostsTypeItem[] LikedPosts { get; set; }

        [JsonProperty("liked_count")]
        public int LikedCount { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public BlogLikesGetResponseLikedPostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("genesis_post_id")]
        public string GenesisPostId { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public BlogLikesGetResponseLikedPostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public BlogLikesGetResponseLikedPostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("liked_timestamp")]
        public int LikedTimestamp { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class BlogLikesGetResponseLikedPostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BlogFollowingGetResponse
    {
        [JsonProperty("blogs")]
        public BlogFollowingGetResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("total_blogs")]
        public int TotalBlogs { get; set; }
    }

    public class BlogFollowingGetResponseBlogsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class BlogFollowersGetResponse
    {
        [JsonProperty("total_users")]
        public int TotalUsers { get; set; }

        [JsonProperty("users")]
        public BlogFollowersGetResponseUsersTypeItem[] Users { get; set; }
    }

    public class BlogFollowersGetResponseUsersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class BlogFollowCheckGetResponse
    {
        [JsonProperty("followed_by")]
        public bool FollowedBy { get; set; }
    }

    public class PostsQueuedGetResponse
    {
        [JsonProperty("state")]
        public PostsQueuedGetResponseStateType State { get; set; }

        [JsonProperty("posts")]
        public PostsQueuedGetResponsePostsTypeItem[] Posts { get; set; }
    }

    public class PostsQueuedGetResponseStateType
    {
        [JsonProperty("paused")]
        public bool Paused { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public PostsQueuedGetResponsePostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("scheduled_publish_time")]
        public int ScheduledPublishTime { get; set; }

        [JsonProperty("queued_state")]
        public string QueuedState { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public PostsQueuedGetResponsePostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public PostsQueuedGetResponsePostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public PostsQueuedGetResponsePostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public PostsQueuedGetResponsePostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public PostsQueuedGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class PostsQueuedGetResponsePostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostDraftsGetResponse
    {
        [JsonProperty("posts")]
        public PostDraftsGetResponsePostsTypeItem[] Posts { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public PostDraftsGetResponsePostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public PostDraftsGetResponsePostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public PostDraftsGetResponsePostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public PostDraftsGetResponsePostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public PostDraftsGetResponsePostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public PostDraftsGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class PostDraftsGetResponsePostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostSubmissionGetResponse
    {
        [JsonProperty("posts")]
        public PostSubmissionGetResponsePostsTypeItem[] Posts { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public PostSubmissionGetResponsePostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("scheduled_publish_time")]
        public int ScheduledPublishTime { get; set; }

        [JsonProperty("queued_state")]
        public string QueuedState { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public PostSubmissionGetResponsePostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public PostSubmissionGetResponsePostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }

        [JsonProperty("is_submission")]
        public bool IsSubmission { get; set; }

        [JsonProperty("anonymous_name")]
        public string AnonymousName { get; set; }

        [JsonProperty("anonymous_email")]
        public string AnonymousEmail { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public PostSubmissionGetResponsePostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public PostSubmissionGetResponsePostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public PostSubmissionGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class PostSubmissionGetResponsePostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ActivityFeedGetResponse
    {
        [JsonProperty("notifications")]
        public ActivityFeedGetResponseNotificationsTypeItem[] Notifications { get; set; }

        [JsonProperty("_links")]
        public ActivityFeedGetResponseLinksType Links { get; set; }
    }

    public class ActivityFeedGetResponseNotificationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("before")]
        public int Before { get; set; }

        [JsonProperty("target_post_id")]
        public string TargetPostId { get; set; }

        [JsonProperty("target_post_summary")]
        public string TargetPostSummary { get; set; }

        [JsonProperty("target_tumblelog_name")]
        public string TargetTumblelogName { get; set; }

        [JsonProperty("target_tumblelog_uuid")]
        public string TargetTumblelogUuid { get; set; }

        [JsonProperty("from_tumblelog_name")]
        public string FromTumblelogName { get; set; }

        [JsonProperty("from_tumblelog_uuid")]
        public string FromTumblelogUuid { get; set; }

        [JsonProperty("from_tumblelog_is_adult")]
        public bool FromTumblelogIsAdult { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("target_root_post_id")]
        public string TargetRootPostId { get; set; }

        [JsonProperty("private_channel")]
        public bool PrivateChannel { get; set; }

        [JsonProperty("target_post_type")]
        public string TargetPostType { get; set; }

        [JsonProperty("post_type")]
        public string PostType { get; set; }

        [JsonProperty("post_tags")]
        public string PostTags { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("added_text")]
        public string AddedText { get; set; }

        [JsonProperty("reply_text")]
        public string ReplyText { get; set; }
    }

    public class ActivityFeedGetResponseLinksType
    {
        [JsonProperty("next")]
        public ActivityFeedGetResponseLinksTypeNextType Next { get; set; }
    }

    public class ActivityFeedGetResponseLinksTypeNextType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("query_params")]
        public ActivityFeedGetResponseLinksTypeNextTypeQueryParamsType QueryParams { get; set; }
    }

    public class ActivityFeedGetResponseLinksTypeNextTypeQueryParamsType
    {
        [JsonProperty("before")]
        public string Before { get; set; }
    }

    public class PostCreatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodycontentInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("media")]
        public bodycontentInputItemMediaTypeItem[] Media { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycontentInputItemMediaTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class bodylayoutInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("display")]
        public bodylayoutInputItemDisplayTypeItem[] Display { get; set; }
    }

    public class bodylayoutInputItemDisplayTypeItem
    {
        [JsonProperty("blocks")]
        public int[] Blocks { get; set; }
    }

    public class PostRetrieveGetResponse
    {
        [JsonProperty("object_type")]
        public string ObjectType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tumblelog_uuid")]
        public string TumblelogUuid { get; set; }

        [JsonProperty("original_type")]
        public string OriginalType { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public PostRetrieveGetResponseBlogType Blog { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("genesis_post_id")]
        public string GenesisPostId { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("content")]
        public PostRetrieveGetResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("layout")]
        public string[] Layout { get; set; }

        [JsonProperty("trail")]
        public string[] Trail { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }
    }

    public class PostRetrieveGetResponseBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class PostRetrieveGetResponseContentTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum postFormatInput
    {
        [EnumMember(Value = "npf")]
        Npf,
        [EnumMember(Value = "legacy")]
        Legacy
    }

    public class PostEditPutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostDeleteResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }
    }

    public class PostNotesGetResponse
    {
        [JsonProperty("notes")]
        public PostNotesGetResponseNotesTypeItem[] Notes { get; set; }

        [JsonProperty("total_notes")]
        public int TotalNotes { get; set; }
    }

    public class PostNotesGetResponseNotesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog_uuid")]
        public string BlogUuid { get; set; }

        [JsonProperty("blog_url")]
        public string BlogUrl { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("post_id")]
        public string PostId { get; set; }

        [JsonProperty("reblog_parent_blog_name")]
        public string ReblogParentBlogName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modeInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "likes")]
        Likes,
        [EnumMember(Value = "conversation")]
        Conversation,
        [EnumMember(Value = "rollup")]
        Rollup,
        [EnumMember(Value = "reblogs_with_tags")]
        ReblogsWithTags
    }

    public class UserInfoGetResponse
    {
        [JsonProperty("user")]
        public UserInfoGetResponseUserType User { get; set; }
    }

    public class UserInfoGetResponseUserType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("following")]
        public int Following { get; set; }

        [JsonProperty("default_post_format")]
        public string DefaultPostFormat { get; set; }

        [JsonProperty("blogs")]
        public UserInfoGetResponseUserTypeBlogsTypeItem[] Blogs { get; set; }
    }

    public class UserInfoGetResponseUserTypeBlogsTypeItem
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("ask")]
        public bool Ask { get; set; }

        [JsonProperty("ask_anon")]
        public bool AskAnon { get; set; }

        [JsonProperty("ask_page_title")]
        public string AskPageTitle { get; set; }

        [JsonProperty("asks_allow_media")]
        public bool AsksAllowMedia { get; set; }

        [JsonProperty("avatar")]
        public UserInfoGetResponseUserTypeBlogsTypeItemAvatarTypeItem[] Avatar { get; set; }

        [JsonProperty("can_chat")]
        public bool CanChat { get; set; }

        [JsonProperty("can_send_fan_mail")]
        public bool CanSendFanMail { get; set; }

        [JsonProperty("can_subscribe")]
        public bool CanSubscribe { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("drafts")]
        public int Drafts { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("facebook_opengraph_enabled")]
        public string FacebookOpengraphEnabled { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }

        [JsonProperty("is_blocked_from_primary")]
        public bool IsBlockedFromPrimary { get; set; }

        [JsonProperty("is_nsfw")]
        public bool IsNsfw { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("theme")]
        public UserInfoGetResponseUserTypeBlogsTypeItemThemeType Theme { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_posts")]
        public int TotalPosts { get; set; }

        [JsonProperty("tweet")]
        public string Tweet { get; set; }

        [JsonProperty("twitter_enabled")]
        public bool TwitterEnabled { get; set; }

        [JsonProperty("twitter_send")]
        public bool TwitterSend { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class UserInfoGetResponseUserTypeBlogsTypeItemAvatarTypeItem
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UserInfoGetResponseUserTypeBlogsTypeItemThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class UserLimitGetResponse
    {
        [JsonProperty("user")]
        public UserLimitGetResponseUserType User { get; set; }
    }

    public class UserLimitGetResponseUserType
    {
        [JsonProperty("blogs")]
        public UserLimitGetResponseUserTypeBlogsType Blogs { get; set; }

        [JsonProperty("follows")]
        public UserLimitGetResponseUserTypeFollowsType Follows { get; set; }

        [JsonProperty("likes")]
        public UserLimitGetResponseUserTypeLikesType Likes { get; set; }

        [JsonProperty("photos")]
        public UserLimitGetResponseUserTypePhotosType Photos { get; set; }

        [JsonProperty("posts")]
        public UserLimitGetResponseUserTypePostsType Posts { get; set; }

        [JsonProperty("video_seconds")]
        public UserLimitGetResponseUserTypeVideoSecondsType VideoSeconds { get; set; }

        [JsonProperty("videos")]
        public UserLimitGetResponseUserTypeVideosType Videos { get; set; }
    }

    public class UserLimitGetResponseUserTypeBlogsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypeFollowsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypeLikesType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypePhotosType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypePostsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypeVideoSecondsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserLimitGetResponseUserTypeVideosType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset_at")]
        public int ResetAt { get; set; }
    }

    public class UserDashboardGetResponse
    {
        [JsonProperty("posts")]
        public UserDashboardGetResponsePostsTypeItem[] Posts { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public UserDashboardGetResponsePostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public UserDashboardGetResponsePostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public UserDashboardGetResponsePostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }

        [JsonProperty("genesis_post_id")]
        public string GenesisPostId { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public UserDashboardGetResponsePostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public UserDashboardGetResponsePostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public UserDashboardGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class UserDashboardGetResponsePostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UserLikesGetResponse
    {
        [JsonProperty("liked_posts")]
        public UserLikesGetResponseLikedPostsTypeItem[] LikedPosts { get; set; }

        [JsonProperty("liked_count")]
        public int LikedCount { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public UserLikesGetResponseLikedPostsTypeItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("genesis_post_id")]
        public string GenesisPostId { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("reblog")]
        public UserLikesGetResponseLikedPostsTypeItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public UserLikesGetResponseLikedPostsTypeItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("liked_timestamp")]
        public int LikedTimestamp { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public UserLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public UserLikesGetResponseLikedPostsTypeItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public UserLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class UserLikesGetResponseLikedPostsTypeItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UserFollowingGetResponse
    {
        [JsonProperty("total_blogs")]
        public int TotalBlogs { get; set; }

        [JsonProperty("blogs")]
        public UserFollowingGetResponseBlogsTypeItem[] Blogs { get; set; }
    }

    public class UserFollowingGetResponseBlogsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class BlogFollowPostResponse
    {
        [JsonProperty("blog")]
        public BlogFollowPostResponseBlogType Blog { get; set; }
    }

    public class BlogFollowPostResponseBlogType
    {
        [JsonProperty("ask")]
        public bool Ask { get; set; }

        [JsonProperty("ask_anon")]
        public bool AskAnon { get; set; }

        [JsonProperty("ask_page_title")]
        public string AskPageTitle { get; set; }

        [JsonProperty("asks_allow_media")]
        public bool AsksAllowMedia { get; set; }

        [JsonProperty("avatar")]
        public BlogFollowPostResponseBlogTypeAvatarTypeItem[] Avatar { get; set; }

        [JsonProperty("can_chat")]
        public bool CanChat { get; set; }

        [JsonProperty("can_send_fan_mail")]
        public bool CanSendFanMail { get; set; }

        [JsonProperty("can_subscribe")]
        public bool CanSubscribe { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("is_blocked_from_primary")]
        public bool IsBlockedFromPrimary { get; set; }

        [JsonProperty("is_nsfw")]
        public bool IsNsfw { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("theme")]
        public BlogFollowPostResponseBlogTypeThemeType Theme { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_posts")]
        public int TotalPosts { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class BlogFollowPostResponseBlogTypeAvatarTypeItem
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BlogFollowPostResponseBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("header_focus_width")]
        public int HeaderFocusWidth { get; set; }

        [JsonProperty("header_focus_height")]
        public int HeaderFocusHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class BlogUnfollowPostResponse
    {
        [JsonProperty("blog")]
        public BlogUnfollowPostResponseBlogType Blog { get; set; }
    }

    public class BlogUnfollowPostResponseBlogType
    {
        [JsonProperty("ask")]
        public bool Ask { get; set; }

        [JsonProperty("ask_anon")]
        public bool AskAnon { get; set; }

        [JsonProperty("ask_page_title")]
        public string AskPageTitle { get; set; }

        [JsonProperty("asks_allow_media")]
        public bool AsksAllowMedia { get; set; }

        [JsonProperty("avatar")]
        public BlogUnfollowPostResponseBlogTypeAvatarTypeItem[] Avatar { get; set; }

        [JsonProperty("can_chat")]
        public bool CanChat { get; set; }

        [JsonProperty("can_send_fan_mail")]
        public bool CanSendFanMail { get; set; }

        [JsonProperty("can_subscribe")]
        public bool CanSubscribe { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("is_blocked_from_primary")]
        public bool IsBlockedFromPrimary { get; set; }

        [JsonProperty("is_nsfw")]
        public bool IsNsfw { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("posts")]
        public int Posts { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("theme")]
        public BlogUnfollowPostResponseBlogTypeThemeType Theme { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_posts")]
        public int TotalPosts { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class BlogUnfollowPostResponseBlogTypeAvatarTypeItem
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BlogUnfollowPostResponseBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("header_focus_width")]
        public int HeaderFocusWidth { get; set; }

        [JsonProperty("header_focus_height")]
        public int HeaderFocusHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class PostTagGetResponseItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blog_name")]
        public string BlogName { get; set; }

        [JsonProperty("blog")]
        public PostTagGetResponseItemBlogType Blog { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_string")]
        public string IdString { get; set; }

        [JsonProperty("post_url")]
        public string PostUrl { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("reblog_key")]
        public string ReblogKey { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("should_open_in_legacy")]
        public bool ShouldOpenInLegacy { get; set; }

        [JsonProperty("recommended_source")]
        public string RecommendedSource { get; set; }

        [JsonProperty("recommended_color")]
        public string RecommendedColor { get; set; }

        [JsonProperty("followed")]
        public bool Followed { get; set; }

        [JsonProperty("featured_in_tag")]
        public string[] FeaturedInTag { get; set; }

        [JsonProperty("featured_timestamp")]
        public int FeaturedTimestamp { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("note_count")]
        public int NoteCount { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("reblog")]
        public PostTagGetResponseItemReblogType Reblog { get; set; }

        [JsonProperty("trail")]
        public PostTagGetResponseItemTrailTypeItem[] Trail { get; set; }

        [JsonProperty("photoset_layout")]
        public string PhotosetLayout { get; set; }

        [JsonProperty("photos")]
        public PostTagGetResponseItemPhotosTypeItem[] Photos { get; set; }

        [JsonProperty("can_like")]
        public bool CanLike { get; set; }

        [JsonProperty("interactability_reblog")]
        public string InteractabilityReblog { get; set; }

        [JsonProperty("can_reblog")]
        public bool CanReblog { get; set; }

        [JsonProperty("can_send_in_message")]
        public bool CanSendInMessage { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("display_avatar")]
        public bool DisplayAvatar { get; set; }

        [JsonProperty("image_permalink")]
        public string ImagePermalink { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("source_title")]
        public string SourceTitle { get; set; }

        [JsonProperty("link_url")]
        public string LinkUrl { get; set; }

        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; }

        [JsonProperty("is_submission")]
        public bool IsSubmission { get; set; }
    }

    public class PostTagGetResponseItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class PostTagGetResponseItemReblogType
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tree_html")]
        public string TreeHtml { get; set; }
    }

    public class PostTagGetResponseItemTrailTypeItem
    {
        [JsonProperty("blog")]
        public PostTagGetResponseItemTrailTypeItemBlogType Blog { get; set; }

        [JsonProperty("post")]
        public PostTagGetResponseItemTrailTypeItemPostType Post { get; set; }

        [JsonProperty("content_raw")]
        public string ContentRaw { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("is_current_item")]
        public bool IsCurrentItem { get; set; }

        [JsonProperty("is_root_item")]
        public bool IsRootItem { get; set; }
    }

    public class PostTagGetResponseItemTrailTypeItemBlogType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("theme")]
        public PostTagGetResponseItemTrailTypeItemBlogTypeThemeType Theme { get; set; }

        [JsonProperty("share_likes")]
        public bool ShareLikes { get; set; }

        [JsonProperty("share_following")]
        public bool ShareFollowing { get; set; }

        [JsonProperty("can_be_followed")]
        public bool CanBeFollowed { get; set; }
    }

    public class PostTagGetResponseItemTrailTypeItemBlogTypeThemeType
    {
        [JsonProperty("header_full_width")]
        public int HeaderFullWidth { get; set; }

        [JsonProperty("header_full_height")]
        public int HeaderFullHeight { get; set; }

        [JsonProperty("header_focus_width")]
        public int HeaderFocusWidth { get; set; }

        [JsonProperty("header_focus_height")]
        public int HeaderFocusHeight { get; set; }

        [JsonProperty("avatar_shape")]
        public string AvatarShape { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("body_font")]
        public string BodyFont { get; set; }

        [JsonProperty("header_bounds")]
        public string HeaderBounds { get; set; }

        [JsonProperty("header_image")]
        public string HeaderImage { get; set; }

        [JsonProperty("header_image_focused")]
        public string HeaderImageFocused { get; set; }

        [JsonProperty("header_image_poster")]
        public string HeaderImagePoster { get; set; }

        [JsonProperty("header_image_scaled")]
        public string HeaderImageScaled { get; set; }

        [JsonProperty("header_stretch")]
        public bool HeaderStretch { get; set; }

        [JsonProperty("link_color")]
        public string LinkColor { get; set; }

        [JsonProperty("show_avatar")]
        public bool ShowAvatar { get; set; }

        [JsonProperty("show_description")]
        public bool ShowDescription { get; set; }

        [JsonProperty("show_header_image")]
        public bool ShowHeaderImage { get; set; }

        [JsonProperty("show_title")]
        public bool ShowTitle { get; set; }

        [JsonProperty("title_color")]
        public string TitleColor { get; set; }

        [JsonProperty("title_font")]
        public string TitleFont { get; set; }

        [JsonProperty("title_font_weight")]
        public string TitleFontWeight { get; set; }
    }

    public class PostTagGetResponseItemTrailTypeItemPostType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostTagGetResponseItemPhotosTypeItem
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("original_size")]
        public PostTagGetResponseItemPhotosTypeItemOriginalSizeType OriginalSize { get; set; }

        [JsonProperty("alt_sizes")]
        public PostTagGetResponseItemPhotosTypeItemAltSizesTypeItem[] AltSizes { get; set; }

        [JsonProperty("exif")]
        public PostTagGetResponseItemPhotosTypeItemExifType Exif { get; set; }
    }

    public class PostTagGetResponseItemPhotosTypeItemOriginalSizeType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class PostTagGetResponseItemPhotosTypeItemAltSizesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class PostTagGetResponseItemPhotosTypeItemExifType
    {
        public string Camera { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tumblrip;

    public partial class WorkflowManagedActions
    {
        public TumblripActions Tumblrip(string connectionId) => new TumblripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TumblripTriggers Tumblrip(string connectionId) => new TumblripTriggers(connectionId);
    }
}
