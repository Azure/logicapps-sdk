//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Revueip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RevueipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<List[]> GetAllLists()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<List[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<List> GetList([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<List>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Export> GetExport([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/exports/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Export>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Export> StartExport([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/exports/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Export>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Item[]> GetItems()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Item[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<SentIssue> GetLatestIssue()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SentIssue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<SentIssue[]> GetAllSentIssues()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SentIssue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Issue[]> GetCurrentIssue()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/issues/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Issue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber[]> GetAllSubscribers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Subscriber[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber> AddSubscriber([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodydoubleOptIn = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodydoubleOptIn, nameof(bodydoubleOptIn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodydoubleOptIn != null)
                {
                    body["double_opt_in"] = SourceExpressionConverter.ConvertToken(bodydoubleOptIn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Subscriber>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber> UpdateSubscriber([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodydoubleOptIn = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodydoubleOptIn, nameof(bodydoubleOptIn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodydoubleOptIn != null)
                {
                    body["double_opt_in"] = SourceExpressionConverter.ConvertToken(bodydoubleOptIn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Subscriber>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber[]> GetUnsubscribed()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers/unsubscribed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Subscriber[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Subscriber> UnsubscribeSubscriber([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<bool> bodydoubleOptIn = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodydoubleOptIn, nameof(bodydoubleOptIn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers/unsubscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodydoubleOptIn != null)
                {
                    if (bodydoubleOptIn != null)
                    {
                        body["double_opt_in"] = SourceExpressionConverter.ConvertToken(bodydoubleOptIn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["double_opt_in"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Subscriber>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "revueip")]
        public IBodyWorkflowAction<Account> GetProfileURL()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/accounts/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Account>(BuildSourceInput);
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