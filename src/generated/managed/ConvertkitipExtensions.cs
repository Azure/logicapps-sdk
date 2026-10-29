//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Convertkitip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConvertkitipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<AccountResponse, ApiConnectionActionConfiguration> Account()
        {
            return new DeferredBodyAction<AccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormListResponse, ApiConnectionActionConfiguration> FormList()
        {
            return new DeferredBodyAction<FormListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/forms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FormListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormSubAddResponse, ApiConnectionActionConfiguration> FormSubAdd(Expression<Func<string>> formId, Expression<Func<FormSubAddInput>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FormSubAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/forms/{0}/subscribe", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FormSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormSubListResponse, ApiConnectionActionConfiguration> FormSubList(Expression<Func<string>> formId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<FormSubListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/forms/{0}/subscriptions", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<FormSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceListResponse, ApiConnectionActionConfiguration> SequenceList()
        {
            return new DeferredBodyAction<SequenceListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sequences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SequenceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceSubAddResponse, ApiConnectionActionConfiguration> SequenceSubAdd(Expression<Func<string>> sequenceId, Expression<Func<SequenceSubAddInput>> body)
        {
            var __workflow_sequenceId = WorkflowExpression.Compile(sequenceId, nameof(sequenceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SequenceSubAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sequences/{0}/subscribe", __workflow_sequenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SequenceSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceSubListResponse, ApiConnectionActionConfiguration> SequenceSubList(Expression<Func<string>> sequenceId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_sequenceId = WorkflowExpression.Compile(sequenceId, nameof(sequenceId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SequenceSubListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sequences/{0}/subscriptions", __workflow_sequenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SequenceSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagListResponse, ApiConnectionActionConfiguration> TagList()
        {
            return new DeferredBodyAction<TagListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagAddResponse, ApiConnectionActionConfiguration> TagAdd(Expression<Func<TagAddInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TagAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TagAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubResponse, ApiConnectionActionConfiguration> TagSub(Expression<Func<string>> tagId, Expression<Func<TagSubInput>> body = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TagSubResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/subscribe", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TagSubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveResponse, ApiConnectionActionConfiguration> TagSubRemove(Expression<Func<string>> subscriberId, Expression<Func<string>> tagId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<TagSubRemoveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/tags/{1}", __workflow_subscriberId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagSubRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveEmailResponse, ApiConnectionActionConfiguration> TagSubRemoveEmail(Expression<Func<string>> tagId, Expression<Func<TagSubRemoveEmailInput>> body)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TagSubRemoveEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/unsubscribe", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TagSubRemoveEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubListResponse, ApiConnectionActionConfiguration> TagSubList(Expression<Func<string>> tagId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<TagSubListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/subscriptions", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<TagSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberListResponse, ApiConnectionActionConfiguration> SubscriberList(Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> updatedFrom = null, Expression<Func<string>> updatedTo = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<string>> emailAddress = null, Expression<Func<int>> page = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_updatedFrom = WorkflowExpression.Compile(updatedFrom, nameof(updatedFrom), required: false);
            var __workflow_updatedTo = WorkflowExpression.Compile(updatedTo, nameof(updatedTo), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SubscriberListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_updatedFrom != null)
                    callPayload.Queries["updated_from"] = ExpressionConverter.Convert(__workflow_updatedFrom);
                if (__workflow_updatedTo != null)
                    callPayload.Queries["updated_to"] = ExpressionConverter.Convert(__workflow_updatedTo);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["sort_field"] = Convert.ToString("");
                if (__workflow_sortField != null)
                    callPayload.Queries["sort_field"] = ExpressionConverter.Convert(__workflow_sortField);
                if (__workflow_emailAddress != null)
                    callPayload.Queries["email_address"] = ExpressionConverter.Convert(__workflow_emailAddress);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SubscriberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberGetResponse, ApiConnectionActionConfiguration> SubscriberGet(Expression<Func<string>> subscriberId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse, ApiConnectionActionConfiguration> SubscriberUpdate(Expression<Func<string>> subscriberId, Expression<Func<SubscriberUpdateInput>> body)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriberUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriberUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUnsubResponse, ApiConnectionActionConfiguration> SubscriberUnsub(Expression<Func<SubscriberUnsubInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriberUnsubResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/unsubscribe";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriberUnsubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberTagsResponse, ApiConnectionActionConfiguration> SubscriberTags(Expression<Func<string>> subscriberId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/tags", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastListResponse, ApiConnectionActionConfiguration> BroadcastList()
        {
            return new DeferredBodyAction<BroadcastListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/broadcasts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastAddResponse, ApiConnectionActionConfiguration> BroadcastAdd(Expression<Func<BroadcastAddInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BroadcastAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/broadcasts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BroadcastAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetResponse, ApiConnectionActionConfiguration> BroadcastGet(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastUpdateResponse, ApiConnectionActionConfiguration> BroadcastUpdate(Expression<Func<string>> broadcastId, Expression<Func<BroadcastUpdateInput>> body)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BroadcastUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BroadcastUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> BroadcastDelete(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetStatResponse, ApiConnectionActionConfiguration> BroadcastGetStat(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetStatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}/stats", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetStatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseListResponse, ApiConnectionActionConfiguration> PurchaseList(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<PurchaseListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PurchaseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseAddResponse, ApiConnectionActionConfiguration> PurchaseAdd(Expression<Func<PurchaseAddInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PurchaseAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PurchaseAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseGetResponse, ApiConnectionActionConfiguration> PurchaseGet(Expression<Func<string>> purchaseId)
        {
            var __workflow_purchaseId = WorkflowExpression.Compile(purchaseId, nameof(purchaseId), required: true);
            return new DeferredBodyAction<PurchaseGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchases/{0}", __workflow_purchaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PurchaseGetResponse>(callPayload);
            });
        }
    }

    public class ConvertkitipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        [JsonProperty("primary_email_address")]
        public string PrimaryEmailAddress { get; set; }
    }

    public class FormListResponse
    {
        [JsonProperty("forms")]
        public FormListResponseFormsTypeItem[] Forms { get; set; }
    }

    public class FormListResponseFormsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("embed_js")]
        public string EmbedJs { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sign_up_button_text")]
        public string SignUpButtonText { get; set; }

        [JsonProperty("success_message")]
        public string SuccessMessage { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class FormSubAddResponse
    {
        [JsonProperty("subscription")]
        public FormSubAddResponseSubscriptionType Subscription { get; set; }
    }

    public class FormSubAddResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public FormSubAddResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class FormSubAddResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class FormSubAddInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }
    }

    public class FormSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public FormSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public FormSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public FormSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum subscriberStateInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class SequenceListResponse
    {
        [JsonProperty("courses")]
        public SequenceListResponseCoursesTypeItem[] Courses { get; set; }
    }

    public class SequenceListResponseCoursesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class SequenceSubAddResponse
    {
        [JsonProperty("subscription")]
        public SequenceSubAddResponseSubscriptionType Subscription { get; set; }
    }

    public class SequenceSubAddResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public SequenceSubAddResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class SequenceSubAddResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class SequenceSubAddInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }
    }

    public class SequenceSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public SequenceSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public SequenceSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SequenceSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class TagListResponse
    {
        [JsonProperty("tags")]
        public TagListResponseTagsTypeItem[] Tags { get; set; }
    }

    public class TagListResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagAddResponse
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TagAddInput
    {
        [JsonProperty("tag", DefaultValueHandling = DefaultValueHandling.Include)]
        public TagAddInputTagType Tag { get; set; }
    }

    public class TagAddInputTagType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class TagSubResponse
    {
        [JsonProperty("subscription")]
        public TagSubResponseSubscriptionType Subscription { get; set; }
    }

    public class TagSubResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public TagSubResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class TagSubResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TagSubInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }
    }

    public class TagSubRemoveResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagSubRemoveEmailResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagSubRemoveEmailInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class TagSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public TagSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public TagSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public TagSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberListResponse
    {
        [JsonProperty("total_subscribers")]
        public int TotalSubscribers { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscribers")]
        public SubscriberListResponseSubscribersTypeItem[] Subscribers { get; set; }
    }

    public class SubscriberListResponseSubscribersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberListResponseSubscribersTypeItemFieldsType Fields { get; set; }
    }

    public class SubscriberListResponseSubscribersTypeItemFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortFieldInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "cancelled_at")]
        CancelledAt
    }

    public class SubscriberGetResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberGetResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberGetResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberGetResponseSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SubscriberGetResponseSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberUpdateResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberUpdateResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberUpdateResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class SubscriberUpdateInput
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class SubscriberUnsubResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberUnsubResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberUnsubResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberUnsubResponseSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SubscriberUnsubResponseSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberUnsubInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class SubscriberTagsResponse
    {
        [JsonProperty("tags")]
        public SubscriberTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    public class SubscriberTagsResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class BroadcastListResponse
    {
        [JsonProperty("broadcasts")]
        public BroadcastListResponseBroadcastsTypeItem[] Broadcasts { get; set; }
    }

    public class BroadcastListResponseBroadcastsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class BroadcastAddResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastAddResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastAddResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastAddInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }

        [JsonProperty("public")]
        public bool? Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }

    public class BroadcastGetResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastGetResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastGetResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastUpdateResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastUpdateResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastUpdateResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastUpdateInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }

        [JsonProperty("public")]
        public bool? Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
    }

    public class BroadcastGetStatResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastGetStatResponseBroadcastTypeItem[] Broadcast { get; set; }
    }

    public class BroadcastGetStatResponseBroadcastTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public BroadcastGetStatResponseBroadcastTypeItemStatsType Stats { get; set; }
    }

    public class BroadcastGetStatResponseBroadcastTypeItemStatsType
    {
        [JsonProperty("recipients")]
        public int Recipients { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        [JsonProperty("unsubscribes")]
        public int Unsubscribes { get; set; }

        [JsonProperty("total_clicks")]
        public int TotalClicks { get; set; }

        [JsonProperty("show_total_clicks")]
        public bool ShowTotalClicks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

    public class PurchaseListResponse
    {
        [JsonProperty("total_purchases")]
        public int TotalPurchases { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("purchases")]
        public PurchaseListResponsePurchasesTypeItem[] Purchases { get; set; }
    }

    public class PurchaseListResponsePurchasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseListResponsePurchasesTypeItemProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseListResponsePurchasesTypeItemProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PurchaseAddResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseAddResponseProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseAddResponseProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PurchaseAddInput
    {
        [JsonProperty("purchase", DefaultValueHandling = DefaultValueHandling.Include)]
        public PurchaseAddInputPurchaseType Purchase { get; set; }
    }

    public class PurchaseAddInputPurchaseType
    {
        [JsonProperty("transaction_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty("email_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int? Subtotal { get; set; }

        [JsonProperty("tax")]
        public int? Tax { get; set; }

        [JsonProperty("shipping")]
        public int? Shipping { get; set; }

        [JsonProperty("discount")]
        public int? Discount { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("products", DefaultValueHandling = DefaultValueHandling.Include)]
        public PurchaseAddInputPurchaseTypeProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseAddInputPurchaseTypeProductsTypeItem
    {
        [JsonProperty("pid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Pid { get; set; }

        [JsonProperty("lid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Lid { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("unit_price", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Quantity { get; set; }
    }

    public class PurchaseGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseGetResponseProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseGetResponseProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Convertkitip;

    public partial class WorkflowManagedActions
    {
        public ConvertkitipActions Convertkitip(string connectionId) => new ConvertkitipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConvertkitipTriggers Convertkitip(string connectionId) => new ConvertkitipTriggers(connectionId);
    }
}