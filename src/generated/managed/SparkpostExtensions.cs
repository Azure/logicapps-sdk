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
        public IBodyWorkflowAction<JToken> CreateRecipientList(Expression<Func<string>> recipientListidOfTheRecipientList = null, Expression<Func<string>> recipientListnameOfTheRecipientList = null, Expression<Func<string>> recipientListdescription = null, Expression<Func<string>> recipientListemailAddressOfFirstRecipient = null)
        {
            var __workflow_recipientListidOfTheRecipientList = WorkflowExpression.Compile(recipientListidOfTheRecipientList, nameof(recipientListidOfTheRecipientList), required: false);
            var __workflow_recipientListnameOfTheRecipientList = WorkflowExpression.Compile(recipientListnameOfTheRecipientList, nameof(recipientListnameOfTheRecipientList), required: false);
            var __workflow_recipientListdescription = WorkflowExpression.Compile(recipientListdescription, nameof(recipientListdescription), required: false);
            var __workflow_recipientListemailAddressOfFirstRecipient = WorkflowExpression.Compile(recipientListemailAddressOfFirstRecipient, nameof(recipientListemailAddressOfFirstRecipient), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/recipient-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var recipientList = new JObject();
                var recipientListpropCount = 0;
                if (__workflow_recipientListidOfTheRecipientList != null)
                {
                    recipientList["id"] = ExpressionConverter.ConvertO(__workflow_recipientListidOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (__workflow_recipientListnameOfTheRecipientList != null)
                {
                    recipientList["name"] = ExpressionConverter.ConvertO(__workflow_recipientListnameOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (__workflow_recipientListdescription != null)
                {
                    recipientList["description"] = ExpressionConverter.ConvertO(__workflow_recipientListdescription);
                    recipientListpropCount++;
                }

                if (__workflow_recipientListemailAddressOfFirstRecipient != null)
                {
                    recipientList["email"] = ExpressionConverter.ConvertO(__workflow_recipientListemailAddressOfFirstRecipient);
                    recipientListpropCount++;
                }

                if (recipientListpropCount > 0)
                {
                    callPayload.Body = recipientList;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> AddUserToRecipientList(Expression<Func<string>> recipientListId, Expression<Func<string>> addUserToRecipientListRequestrecipientaddressemailAddress, Expression<Func<string>> addUserToRecipientListRequestrecipientaddressname = null)
        {
            var __workflow_recipientListId = WorkflowExpression.Compile(recipientListId, nameof(recipientListId), required: true);
            var __workflow_addUserToRecipientListRequestrecipientaddressemailAddress = WorkflowExpression.Compile(addUserToRecipientListRequestrecipientaddressemailAddress, nameof(addUserToRecipientListRequestrecipientaddressemailAddress), required: true);
            var __workflow_addUserToRecipientListRequestrecipientaddressname = WorkflowExpression.Compile(addUserToRecipientListRequestrecipientaddressname, nameof(addUserToRecipientListRequestrecipientaddressname), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/add-user/recipient-lists/{0}", __workflow_recipientListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addUserToRecipientListRequest = new JObject();
                var addUserToRecipientListRequestpropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["email"] = ExpressionConverter.ConvertO(__workflow_addUserToRecipientListRequestrecipientaddressemailAddress);
                if (__workflow_addUserToRecipientListRequestrecipientaddressname != null)
                {
                    addressObject["name"] = ExpressionConverter.ConvertO(__workflow_addUserToRecipientListRequestrecipientaddressname);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    recipientObject["address"] = addressObject;
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    addUserToRecipientListRequest["recipient"] = recipientObject;
                    addUserToRecipientListRequestpropCount++;
                }

                if (addUserToRecipientListRequestpropCount > 0)
                {
                    callPayload.Body = addUserToRecipientListRequest;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> DeleteUserFromRecipientList(Expression<Func<string>> recipientListId, Expression<Func<string>> deleteUserRequestemailAddress = null)
        {
            var __workflow_recipientListId = WorkflowExpression.Compile(recipientListId, nameof(recipientListId), required: true);
            var __workflow_deleteUserRequestemailAddress = WorkflowExpression.Compile(deleteUserRequestemailAddress, nameof(deleteUserRequestemailAddress), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/delete-user/recipient-lists/{0}", __workflow_recipientListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteUserRequest = new JObject();
                var deleteUserRequestpropCount = 0;
                if (__workflow_deleteUserRequestemailAddress != null)
                {
                    deleteUserRequest["email_address"] = ExpressionConverter.ConvertO(__workflow_deleteUserRequestemailAddress);
                    deleteUserRequestpropCount++;
                }

                if (deleteUserRequestpropCount > 0)
                {
                    callPayload.Body = deleteUserRequest;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> SendEmailToRecipientList(Expression<Func<string>> requestrecipientsrecipient, Expression<Func<string>> requestcontenttemplate, Expression<Func<string>> requestcampaignId = null)
        {
            var __workflow_requestrecipientsrecipient = WorkflowExpression.Compile(requestrecipientsrecipient, nameof(requestrecipientsrecipient), required: true);
            var __workflow_requestcontenttemplate = WorkflowExpression.Compile(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            var __workflow_requestcampaignId = WorkflowExpression.Compile(requestcampaignId, nameof(requestcampaignId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/transmissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                recipientsObjectpropCount++;
                recipientsObject["list_id"] = ExpressionConverter.ConvertO(__workflow_requestrecipientsrecipient);
                if (recipientsObjectpropCount > 0)
                {
                    request["recipients"] = recipientsObject;
                    requestpropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObjectpropCount++;
                contentObject["template_id"] = ExpressionConverter.ConvertO(__workflow_requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                if (__workflow_requestcampaignId != null)
                {
                    request["campaign_id"] = ExpressionConverter.ConvertO(__workflow_requestcampaignId);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> SendEmailToRecipient(Expression<Func<string>> requestcontenttemplate, Expression<Func<EmailRecipient[]>> requestrecipients)
        {
            var __workflow_requestcontenttemplate = WorkflowExpression.Compile(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            var __workflow_requestrecipients = WorkflowExpression.Compile(requestrecipients, nameof(requestrecipients), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/transmissions/singleRecipient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObjectpropCount++;
                contentObject["template_id"] = ExpressionConverter.ConvertO(__workflow_requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["recipients"] = ExpressionConverter.ConvertO(__workflow_requestrecipients);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class SparkpostTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRecipientListsResponse> OnNewRecipientList(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/recipient-lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListRecipientListsResponse>(callPayload, recurrence: recurrence);
        }
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
        public string ListID { get; set; }

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
