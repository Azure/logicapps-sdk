//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparkpost
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparkpostActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateRecipientList(Expression<Func<CreateRecipientListInput>> recipientList)
        {
            var __workflow_recipientList = WorkflowExpression.Compile(recipientList, nameof(recipientList), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/recipient-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_recipientList);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddUserToRecipientList(Expression<Func<string>> recipientListId, Expression<Func<AddUserToRecipientListInput>> addUserToRecipientListRequest)
        {
            var __workflow_recipientListId = WorkflowExpression.Compile(recipientListId, nameof(recipientListId), required: true);
            var __workflow_addUserToRecipientListRequest = WorkflowExpression.Compile(addUserToRecipientListRequest, nameof(addUserToRecipientListRequest), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/add-user/recipient-lists/{0}", __workflow_recipientListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addUserToRecipientListRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteUserFromRecipientList(Expression<Func<string>> recipientListId, Expression<Func<DeleteUserFromRecipientListInput>> deleteUserRequest)
        {
            var __workflow_recipientListId = WorkflowExpression.Compile(recipientListId, nameof(recipientListId), required: true);
            var __workflow_deleteUserRequest = WorkflowExpression.Compile(deleteUserRequest, nameof(deleteUserRequest), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/delete-user/recipient-lists/{0}", __workflow_recipientListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteUserRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendEmailToRecipientList(Expression<Func<SendEmailToRecipientListInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/transmissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendEmailToRecipient(Expression<Func<SendEmailToRecipientInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/transmissions/singleRecipient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SparkpostTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRecipientListsResponse, ApiConnectionTriggerConfiguration> OnNewRecipientList(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<ListRecipientListsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/recipient-lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListRecipientListsResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateRecipientListInput
    {
        [JsonProperty("id")]
        public string IdOfTheRecipientList { get; set; }

        [JsonProperty("name")]
        public string NameOfTheRecipientList { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string EmailAddressOfFirstRecipient { get; set; }
    }

    public class AddUserToRecipientListInput
    {
        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public Recipient Recipient { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public class Address
    {
        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeleteUserFromRecipientListInput
    {
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public class SendEmailToRecipientListInput
    {
        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailRecipientList Recipients { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailTemplateList Content { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }

    public class EmailRecipientList
    {
        [JsonProperty("list_id")]
        public string Recipient { get; set; }
    }

    public class EmailTemplateList
    {
        [JsonProperty("template_id")]
        public string Template { get; set; }
    }

    public class SendEmailToRecipientInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailTemplateList Content { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailRecipient[] Recipients { get; set; }
    }

    public class EmailRecipient
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }
    }

    public class ListRecipientListsResponse
    {
        [JsonProperty("results")]
        public ListRecipientListsEntry[] Recipients { get; set; }
    }

    public class ListRecipientListsEntry
    {
        [JsonProperty("id")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string ListName { get; set; }

        [JsonProperty("description")]
        public string ListDescription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sparkpost;

    public partial class WorkflowManagedActions
    {
        public SparkpostActions Sparkpost(string connectionId) => new SparkpostActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SparkpostTriggers Sparkpost(string connectionId) => new SparkpostTriggers(connectionId);
    }
}