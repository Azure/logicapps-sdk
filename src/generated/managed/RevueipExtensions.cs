//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revueip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevueipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<List[], ApiConnectionActionConfiguration> GetAllLists()
        {
            return new DeferredBodyAction<List[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<List[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<List, ApiConnectionActionConfiguration> GetList(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<List, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<List>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Export, ApiConnectionActionConfiguration> GetExport(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Export, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/exports/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Export>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Export, ApiConnectionActionConfiguration> StartExport(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Export, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/exports/lists/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Export>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> GetItems()
        {
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<SentIssue, ApiConnectionActionConfiguration> GetLatestIssue()
        {
            return new DeferredBodyAction<SentIssue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SentIssue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<SentIssue[], ApiConnectionActionConfiguration> GetAllSentIssues()
        {
            return new DeferredBodyAction<SentIssue[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SentIssue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Issue[], ApiConnectionActionConfiguration> GetCurrentIssue()
        {
            return new DeferredBodyAction<Issue[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/issues/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Issue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber[], ApiConnectionActionConfiguration> GetAllSubscribers()
        {
            return new DeferredBodyAction<Subscriber[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Subscriber[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber, ApiConnectionActionConfiguration> AddSubscriber(Expression<Func<AddSubscriberInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Subscriber, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Subscriber>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber, ApiConnectionActionConfiguration> UpdateSubscriber(Expression<Func<UpdateSubscriberInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Subscriber, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Subscriber>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber[], ApiConnectionActionConfiguration> GetUnsubscribed()
        {
            return new DeferredBodyAction<Subscriber[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers/unsubscribed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Subscriber[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber, ApiConnectionActionConfiguration> UnsubscribeSubscriber(Expression<Func<UnsubscribeSubscriberInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Subscriber, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers/unsubscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Subscriber>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Account, ApiConnectionActionConfiguration> GetProfileURL()
        {
            return new DeferredBodyAction<Account, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Account>(callPayload);
            });
        }
    }

    public class RevueipTriggers([ConnectionName] string connectionId)
    {
    }

    public class List
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("manually_verified_at")]
        public string ManuallyVerifiedAt { get; set; }
    }

    public class Export
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("subscribed_file_name")]
        public string SubscribedFileName { get; set; }

        [JsonProperty("subscribed_file_size")]
        public int SubscribedFileSize { get; set; }

        [JsonProperty("subscribed_content_type")]
        public string SubscribedContentType { get; set; }

        [JsonProperty("subscribed_url")]
        public string SubscribedUrl { get; set; }

        [JsonProperty("unsubscribed_file_name")]
        public string UnsubscribedFileName { get; set; }

        [JsonProperty("unsubscribed_file_size")]
        public int UnsubscribedFileSize { get; set; }

        [JsonProperty("unsubscribed_content_type")]
        public string UnsubscribedContentType { get; set; }

        [JsonProperty("unsubscribe_url")]
        public string UnsubscribeUrl { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title_display")]
        public string TitleDisplay { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        [JsonProperty("default_image")]
        public string DefaultImage { get; set; }

        [JsonProperty("hash_id")]
        public string HashId { get; set; }
    }

    public class SentIssue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class Issue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class Subscriber
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("double_opt_in")]
        public bool DoubleOptIn { get; set; }
    }

    public class AddSubscriberInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("double_opt_in")]
        public bool? DoubleOptIn { get; set; }
    }

    public class UpdateSubscriberInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("double_opt_in")]
        public bool? DoubleOptIn { get; set; }
    }

    public class UnsubscribeSubscriberInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("double_opt_in", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DoubleOptIn { get; set; } = true;
    }

    public class Account
    {
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Revueip;

    public partial class WorkflowManagedActions
    {
        public RevueipActions Revueip(string connectionId) => new RevueipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RevueipTriggers Revueip(string connectionId) => new RevueipTriggers(connectionId);
    }
}