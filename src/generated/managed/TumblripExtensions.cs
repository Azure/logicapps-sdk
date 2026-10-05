//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tumblrip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TumblripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogGet))]
        public IBodyWorkflowAction<BlogGetResponse> BlogGet([WorkflowExpression] Func<string> blogIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogGetResponse> __BuildBlogGet(WorkflowValue<string> blogIdentifier)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<BlogGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlogGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlocksGet))]
        public IBodyWorkflowAction<BlocksGetResponse> BlocksGet([WorkflowExpression] Func<string> blogIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlocksGetResponse> __BuildBlocksGet(WorkflowValue<string> blogIdentifier)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<BlocksGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/blocks", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlocksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostUnblock))]
        public IBodyWorkflowAction<string> PostUnblock([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> bodyblockedTumblelog = null, [WorkflowExpression] Func<bool> bodyanonymousOnly = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostUnblock(WorkflowValue<string> blogIdentifier, WorkflowValue<string> bodyblockedTumblelog = null, WorkflowValue<bool> bodyanonymousOnly = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodyblockedTumblelog, nameof(bodyblockedTumblelog), required: false);
            WorkflowValue.Validate(bodyanonymousOnly, nameof(bodyanonymousOnly), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/blocks", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyblockedTumblelog != null)
                {
                    body["blocked_tumblelog"] = ExpressionConverter.ConvertO(bodyblockedTumblelog);
                    bodypropCount++;
                }

                if (bodyanonymousOnly != null)
                {
                    body["anonymous_only"] = ExpressionConverter.ConvertO(bodyanonymousOnly);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostBlock))]
        public IBodyWorkflowAction<string> PostBlock([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> bodyblockedTumblelog = null, [WorkflowExpression] Func<string> bodypostId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostBlock(WorkflowValue<string> blogIdentifier, WorkflowValue<string> bodyblockedTumblelog = null, WorkflowValue<string> bodypostId = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodyblockedTumblelog, nameof(bodyblockedTumblelog), required: false);
            WorkflowValue.Validate(bodypostId, nameof(bodypostId), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/blocks", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyblockedTumblelog != null)
                {
                    body["blocked_tumblelog"] = ExpressionConverter.ConvertO(bodyblockedTumblelog);
                    bodypropCount++;
                }

                if (bodypostId != null)
                {
                    body["post_id"] = ExpressionConverter.ConvertO(bodypostId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostsBlock))]
        public IBodyWorkflowAction<string> PostsBlock([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> bodyblockedTumblelogs = null, [WorkflowExpression] Func<bool> bodyforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostsBlock(WorkflowValue<string> blogIdentifier, WorkflowValue<string> bodyblockedTumblelogs = null, WorkflowValue<bool> bodyforce = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodyblockedTumblelogs, nameof(bodyblockedTumblelogs), required: false);
            WorkflowValue.Validate(bodyforce, nameof(bodyforce), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/blocks/bulk", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyblockedTumblelogs != null)
                {
                    body["blocked_tumblelogs"] = ExpressionConverter.ConvertO(bodyblockedTumblelogs);
                    bodypropCount++;
                }

                if (bodyforce != null)
                {
                    body["force"] = ExpressionConverter.ConvertO(bodyforce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogLikesGet))]
        public IBodyWorkflowAction<BlogLikesGetResponse> BlogLikesGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<int> after = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogLikesGetResponse> __BuildBlogLikesGet(WorkflowValue<string> blogIdentifier, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<int> before = null, WorkflowValue<int> after = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            return new DeferredBodyAction<BlogLikesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/likes", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                return new ApiConnectionAction<BlogLikesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogFollowingGet))]
        public IBodyWorkflowAction<BlogFollowingGetResponse> BlogFollowingGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogFollowingGetResponse> __BuildBlogFollowingGet(WorkflowValue<string> blogIdentifier, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<BlogFollowingGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/following", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<BlogFollowingGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogFollowersGet))]
        public IBodyWorkflowAction<BlogFollowersGetResponse> BlogFollowersGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogFollowersGetResponse> __BuildBlogFollowersGet(WorkflowValue<string> blogIdentifier, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<BlogFollowersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/followers", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<BlogFollowersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogFollowCheckGet))]
        public IBodyWorkflowAction<BlogFollowCheckGetResponse> BlogFollowCheckGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> query)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogFollowCheckGetResponse> __BuildBlogFollowCheckGet(WorkflowValue<string> blogIdentifier, WorkflowValue<string> query)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(query, nameof(query), required: true);
            return new DeferredBodyAction<BlogFollowCheckGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/followed_by", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction<BlogFollowCheckGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostsQueuedGet))]
        public IBodyWorkflowAction<PostsQueuedGetResponse> PostsQueuedGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostsQueuedGetResponse> __BuildPostsQueuedGet(WorkflowValue<string> blogIdentifier, WorkflowValue<string> filter = null, WorkflowValue<string> limit = null, WorkflowValue<int> offset = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<PostsQueuedGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/queue", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<PostsQueuedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostQueuedReorder))]
        public IBodyWorkflowAction<string> PostQueuedReorder([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> bodypostId = null, [WorkflowExpression] Func<string> bodyinsertAfter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostQueuedReorder(WorkflowValue<string> blogIdentifier, WorkflowValue<string> bodypostId = null, WorkflowValue<string> bodyinsertAfter = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodypostId, nameof(bodypostId), required: false);
            WorkflowValue.Validate(bodyinsertAfter, nameof(bodyinsertAfter), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/queue/reorder", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypostId != null)
                {
                    body["post_id"] = ExpressionConverter.ConvertO(bodypostId);
                    bodypropCount++;
                }

                if (bodyinsertAfter != null)
                {
                    body["insert_after"] = ExpressionConverter.ConvertO(bodyinsertAfter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostQueuedShuffle))]
        public IBodyWorkflowAction<string> PostQueuedShuffle([WorkflowExpression] Func<string> blogIdentifier)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostQueuedShuffle(WorkflowValue<string> blogIdentifier)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/queue/shuffle", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostDraftsGet))]
        public IBodyWorkflowAction<PostDraftsGetResponse> PostDraftsGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<double> beforeId = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostDraftsGetResponse> __BuildPostDraftsGet(WorkflowValue<string> blogIdentifier, WorkflowValue<double> beforeId = null, WorkflowValue<string> filter = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(beforeId, nameof(beforeId), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostDraftsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/draft", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (beforeId != null)
                    callPayload.Queries["before_id"] = ExpressionConverter.Convert(beforeId);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<PostDraftsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostSubmissionGet))]
        public IBodyWorkflowAction<PostSubmissionGetResponse> PostSubmissionGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostSubmissionGetResponse> __BuildPostSubmissionGet(WorkflowValue<string> blogIdentifier, WorkflowValue<string> offset = null, WorkflowValue<string> filter = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostSubmissionGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/submission", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<PostSubmissionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildActivityFeedGet))]
        public IBodyWorkflowAction<ActivityFeedGetResponse> ActivityFeedGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> types = null, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<bool> rollups = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActivityFeedGetResponse> __BuildActivityFeedGet(WorkflowValue<string> blogIdentifier, WorkflowValue<string> types = null, WorkflowValue<int> before = null, WorkflowValue<bool> rollups = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(types, nameof(types), required: false);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(rollups, nameof(rollups), required: false);
            return new DeferredBodyAction<ActivityFeedGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/notifications", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(types);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                if (rollups != null)
                    callPayload.Queries["rollups"] = ExpressionConverter.Convert(rollups);
                return new ApiConnectionAction<ActivityFeedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostCreate))]
        public IBodyWorkflowAction<PostCreatePostResponse> PostCreate([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<bodycontentInputItem[]> bodycontent = null, [WorkflowExpression] Func<bodylayoutInputItem[]> bodylayout = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypublishedOn = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodysourceUrl = null, [WorkflowExpression] Func<bool> bodysendToTwitter = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyinteractabilityReblog = null, [WorkflowExpression] Func<string> bodyparentTumblelogUuid = null, [WorkflowExpression] Func<int> bodyparentPostId = null, [WorkflowExpression] Func<string> bodyreblogKey = null, [WorkflowExpression] Func<bool> bodyhideTrail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCreatePostResponse> __BuildPostCreate(WorkflowValue<string> blogIdentifier, WorkflowValue<bodycontentInputItem[]> bodycontent = null, WorkflowValue<bodylayoutInputItem[]> bodylayout = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypublishedOn = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodytags = null, WorkflowValue<string> bodysourceUrl = null, WorkflowValue<bool> bodysendToTwitter = null, WorkflowValue<bool> bodyisPrivate = null, WorkflowValue<string> bodyslug = null, WorkflowValue<string> bodyinteractabilityReblog = null, WorkflowValue<string> bodyparentTumblelogUuid = null, WorkflowValue<int> bodyparentPostId = null, WorkflowValue<string> bodyreblogKey = null, WorkflowValue<bool> bodyhideTrail = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowValue.Validate(bodylayout, nameof(bodylayout), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypublishedOn, nameof(bodypublishedOn), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodysourceUrl, nameof(bodysourceUrl), required: false);
            WorkflowValue.Validate(bodysendToTwitter, nameof(bodysendToTwitter), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowValue.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowValue.Validate(bodyinteractabilityReblog, nameof(bodyinteractabilityReblog), required: false);
            WorkflowValue.Validate(bodyparentTumblelogUuid, nameof(bodyparentTumblelogUuid), required: false);
            WorkflowValue.Validate(bodyparentPostId, nameof(bodyparentPostId), required: false);
            WorkflowValue.Validate(bodyreblogKey, nameof(bodyreblogKey), required: false);
            WorkflowValue.Validate(bodyhideTrail, nameof(bodyhideTrail), required: false);
            return new DeferredBodyAction<PostCreatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodylayout != null)
                {
                    body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypublishedOn != null)
                {
                    body["published_on"] = ExpressionConverter.ConvertO(bodypublishedOn);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodysourceUrl != null)
                {
                    body["source_url"] = ExpressionConverter.ConvertO(bodysourceUrl);
                    bodypropCount++;
                }

                if (bodysendToTwitter != null)
                {
                    body["send_to_twitter"] = ExpressionConverter.ConvertO(bodysendToTwitter);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["is_private"] = ExpressionConverter.ConvertO(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodyinteractabilityReblog != null)
                {
                    body["interactability_reblog"] = ExpressionConverter.ConvertO(bodyinteractabilityReblog);
                    bodypropCount++;
                }

                if (bodyparentTumblelogUuid != null)
                {
                    body["parent_tumblelog_uuid"] = ExpressionConverter.ConvertO(bodyparentTumblelogUuid);
                    bodypropCount++;
                }

                if (bodyparentPostId != null)
                {
                    body["parent_post_id"] = ExpressionConverter.ConvertO(bodyparentPostId);
                    bodypropCount++;
                }

                if (bodyreblogKey != null)
                {
                    body["reblog_key"] = ExpressionConverter.ConvertO(bodyreblogKey);
                    bodypropCount++;
                }

                if (bodyhideTrail != null)
                {
                    body["hide_trail"] = ExpressionConverter.ConvertO(bodyhideTrail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCreatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostRetrieveGet))]
        public IBodyWorkflowAction<PostRetrieveGetResponse> PostRetrieveGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<postFormatInput> postFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostRetrieveGetResponse> __BuildPostRetrieveGet(WorkflowValue<string> blogIdentifier, WorkflowValue<string> postId, WorkflowValue<postFormatInput> postFormat = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(postId, nameof(postId), required: true);
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: false);
            return new DeferredBodyAction<PostRetrieveGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["post_format"] = Convert.ToString("npf");
                if (postFormat != null)
                    callPayload.Queries["post_format"] = ExpressionConverter.Convert(postFormat);
                return new ApiConnectionAction<PostRetrieveGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostEditPut))]
        public IBodyWorkflowAction<PostEditPutResponse> PostEditPut([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> postId, [WorkflowExpression] Func<bodycontentInputItem[]> bodycontent = null, [WorkflowExpression] Func<bodylayoutInputItem[]> bodylayout = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypublishedOn = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodysourceUrl = null, [WorkflowExpression] Func<bool> bodysendToTwitter = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyinteractabilityReblog = null, [WorkflowExpression] Func<string> bodyparentTumblelogUuid = null, [WorkflowExpression] Func<int> bodyparentPostId = null, [WorkflowExpression] Func<string> bodyreblogKey = null, [WorkflowExpression] Func<bool> bodyhideTrail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostEditPutResponse> __BuildPostEditPut(WorkflowValue<string> blogIdentifier, WorkflowValue<string> postId, WorkflowValue<bodycontentInputItem[]> bodycontent = null, WorkflowValue<bodylayoutInputItem[]> bodylayout = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypublishedOn = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodytags = null, WorkflowValue<string> bodysourceUrl = null, WorkflowValue<bool> bodysendToTwitter = null, WorkflowValue<bool> bodyisPrivate = null, WorkflowValue<string> bodyslug = null, WorkflowValue<string> bodyinteractabilityReblog = null, WorkflowValue<string> bodyparentTumblelogUuid = null, WorkflowValue<int> bodyparentPostId = null, WorkflowValue<string> bodyreblogKey = null, WorkflowValue<bool> bodyhideTrail = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(postId, nameof(postId), required: true);
            WorkflowValue.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowValue.Validate(bodylayout, nameof(bodylayout), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypublishedOn, nameof(bodypublishedOn), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodysourceUrl, nameof(bodysourceUrl), required: false);
            WorkflowValue.Validate(bodysendToTwitter, nameof(bodysendToTwitter), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowValue.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowValue.Validate(bodyinteractabilityReblog, nameof(bodyinteractabilityReblog), required: false);
            WorkflowValue.Validate(bodyparentTumblelogUuid, nameof(bodyparentTumblelogUuid), required: false);
            WorkflowValue.Validate(bodyparentPostId, nameof(bodyparentPostId), required: false);
            WorkflowValue.Validate(bodyreblogKey, nameof(bodyreblogKey), required: false);
            WorkflowValue.Validate(bodyhideTrail, nameof(bodyhideTrail), required: false);
            return new DeferredBodyAction<PostEditPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/posts/{1}", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1), ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodylayout != null)
                {
                    body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypublishedOn != null)
                {
                    body["published_on"] = ExpressionConverter.ConvertO(bodypublishedOn);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodysourceUrl != null)
                {
                    body["source_url"] = ExpressionConverter.ConvertO(bodysourceUrl);
                    bodypropCount++;
                }

                if (bodysendToTwitter != null)
                {
                    body["send_to_twitter"] = ExpressionConverter.ConvertO(bodysendToTwitter);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["is_private"] = ExpressionConverter.ConvertO(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodyinteractabilityReblog != null)
                {
                    body["interactability_reblog"] = ExpressionConverter.ConvertO(bodyinteractabilityReblog);
                    bodypropCount++;
                }

                if (bodyparentTumblelogUuid != null)
                {
                    body["parent_tumblelog_uuid"] = ExpressionConverter.ConvertO(bodyparentTumblelogUuid);
                    bodypropCount++;
                }

                if (bodyparentPostId != null)
                {
                    body["parent_post_id"] = ExpressionConverter.ConvertO(bodyparentPostId);
                    bodypropCount++;
                }

                if (bodyreblogKey != null)
                {
                    body["reblog_key"] = ExpressionConverter.ConvertO(bodyreblogKey);
                    bodypropCount++;
                }

                if (bodyhideTrail != null)
                {
                    body["hide_trail"] = ExpressionConverter.ConvertO(bodyhideTrail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostEditPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostDelete))]
        public IBodyWorkflowAction<PostDeleteResponse> PostDelete([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<string> bodyid)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostDeleteResponse> __BuildPostDelete(WorkflowValue<string> blogIdentifier, WorkflowValue<string> bodyid)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: true);
            return new DeferredBodyAction<PostDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/post/delete", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostNotesGet))]
        public IBodyWorkflowAction<PostNotesGetResponse> PostNotesGet([WorkflowExpression] Func<string> blogIdentifier, [WorkflowExpression] Func<double> id, [WorkflowExpression] Func<double> beforeTimestamp = null, [WorkflowExpression] Func<modeInput> mode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostNotesGetResponse> __BuildPostNotesGet(WorkflowValue<string> blogIdentifier, WorkflowValue<double> id, WorkflowValue<double> beforeTimestamp = null, WorkflowValue<modeInput> mode = null)
        {
            WorkflowValue.Validate(blogIdentifier, nameof(blogIdentifier), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(beforeTimestamp, nameof(beforeTimestamp), required: false);
            WorkflowValue.Validate(mode, nameof(mode), required: false);
            return new DeferredBodyAction<PostNotesGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/blog/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(blogIdentifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (beforeTimestamp != null)
                    callPayload.Queries["before_timestamp"] = ExpressionConverter.Convert(beforeTimestamp);
                callPayload.Queries["mode"] = Convert.ToString("all");
                if (mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(mode);
                return new ApiConnectionAction<PostNotesGetResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildBlogFollow))]
        public IBodyWorkflowAction<BlogFollowPostResponse> BlogFollow([WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogFollowPostResponse> __BuildBlogFollow(WorkflowValue<string> bodyurl = null, WorkflowValue<string> bodyemail = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<BlogFollowPostResponse>(() =>
            {
                var apiCallPath = "/v2/user/follow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BlogFollowPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildBlogUnfollow))]
        public IBodyWorkflowAction<BlogUnfollowPostResponse> BlogUnfollow([WorkflowExpression] Func<string> bodyurl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BlogUnfollowPostResponse> __BuildBlogUnfollow(WorkflowValue<string> bodyurl = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            return new DeferredBodyAction<BlogUnfollowPostResponse>(() =>
            {
                var apiCallPath = "/v2/user/unfollow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BlogUnfollowPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostLike))]
        public IBodyWorkflowAction<string> PostLike([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyreblogKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostLike(WorkflowValue<string> bodyid, WorkflowValue<string> bodyreblogKey)
        {
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowValue.Validate(bodyreblogKey, nameof(bodyreblogKey), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/user/like";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
                body["reblog_key"] = ExpressionConverter.ConvertO(bodyreblogKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostUnlike))]
        public IBodyWorkflowAction<string> PostUnlike([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyreblogKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostUnlike(WorkflowValue<string> bodyid, WorkflowValue<string> bodyreblogKey)
        {
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowValue.Validate(bodyreblogKey, nameof(bodyreblogKey), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/user/unlike";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
                body["reblog_key"] = ExpressionConverter.ConvertO(bodyreblogKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tumblrip")]
        [WorkflowExpressionFactory(nameof(__BuildPostTagGet))]
        public IBodyWorkflowAction<PostTagGetResponseItem[]> PostTagGet([WorkflowExpression] Func<string> tag, [WorkflowExpression] Func<int> before = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostTagGetResponseItem[]> __BuildPostTagGet(WorkflowValue<string> tag, WorkflowValue<int> before = null, WorkflowValue<double> limit = null, WorkflowValue<string> filter = null)
        {
            WorkflowValue.Validate(tag, nameof(tag), required: true);
            WorkflowValue.Validate(before, nameof(before), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<PostTagGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v2/tagged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
                if (before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(before);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<PostTagGetResponseItem[]>(callPayload);
            });
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
