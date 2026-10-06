//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparkpost
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparkpostActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecipientList))]
        public IBodyWorkflowAction<JToken> CreateRecipientList([WorkflowExpression] Func<string> recipientListidOfTheRecipientList = null, [WorkflowExpression] Func<string> recipientListnameOfTheRecipientList = null, [WorkflowExpression] Func<string> recipientListdescription = null, [WorkflowExpression] Func<string> recipientListemailAddressOfFirstRecipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecipientList(WorkflowExpression<string> recipientListidOfTheRecipientList = null, WorkflowExpression<string> recipientListnameOfTheRecipientList = null, WorkflowExpression<string> recipientListdescription = null, WorkflowExpression<string> recipientListemailAddressOfFirstRecipient = null)
        {
            WorkflowExpression.Validate(recipientListidOfTheRecipientList, nameof(recipientListidOfTheRecipientList), required: false);
            WorkflowExpression.Validate(recipientListnameOfTheRecipientList, nameof(recipientListnameOfTheRecipientList), required: false);
            WorkflowExpression.Validate(recipientListdescription, nameof(recipientListdescription), required: false);
            WorkflowExpression.Validate(recipientListemailAddressOfFirstRecipient, nameof(recipientListemailAddressOfFirstRecipient), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/recipient-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var recipientList = new JObject();
                var recipientListpropCount = 0;
                if (recipientListidOfTheRecipientList != null)
                {
                    recipientList["id"] = ExpressionConverter.ConvertO(recipientListidOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (recipientListnameOfTheRecipientList != null)
                {
                    recipientList["name"] = ExpressionConverter.ConvertO(recipientListnameOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (recipientListdescription != null)
                {
                    recipientList["description"] = ExpressionConverter.ConvertO(recipientListdescription);
                    recipientListpropCount++;
                }

                if (recipientListemailAddressOfFirstRecipient != null)
                {
                    recipientList["email"] = ExpressionConverter.ConvertO(recipientListemailAddressOfFirstRecipient);
                    recipientListpropCount++;
                }

                if (recipientListpropCount > 0)
                {
                    callPayload.Body = recipientList;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [WorkflowExpressionFactory(nameof(__BuildAddUserToRecipientList))]
        public IBodyWorkflowAction<JToken> AddUserToRecipientList([WorkflowExpression] Func<string> recipientListId, [WorkflowExpression] Func<string> addUserToRecipientListRequestrecipientaddressemailAddress, [WorkflowExpression] Func<string> addUserToRecipientListRequestrecipientaddressname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAddUserToRecipientList(WorkflowExpression<string> recipientListId, WorkflowExpression<string> addUserToRecipientListRequestrecipientaddressemailAddress, WorkflowExpression<string> addUserToRecipientListRequestrecipientaddressname = null)
        {
            WorkflowExpression.Validate(recipientListId, nameof(recipientListId), required: true);
            WorkflowExpression.Validate(addUserToRecipientListRequestrecipientaddressemailAddress, nameof(addUserToRecipientListRequestrecipientaddressemailAddress), required: true);
            WorkflowExpression.Validate(addUserToRecipientListRequestrecipientaddressname, nameof(addUserToRecipientListRequestrecipientaddressname), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/add-user/recipient-lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addUserToRecipientListRequest = new JObject();
                var addUserToRecipientListRequestpropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["email"] = ExpressionConverter.ConvertO(addUserToRecipientListRequestrecipientaddressemailAddress);
                if (addUserToRecipientListRequestrecipientaddressname != null)
                {
                    addressObject["name"] = ExpressionConverter.ConvertO(addUserToRecipientListRequestrecipientaddressname);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteUserFromRecipientList))]
        public IBodyWorkflowAction<JToken> DeleteUserFromRecipientList([WorkflowExpression] Func<string> recipientListId, [WorkflowExpression] Func<string> deleteUserRequestemailAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteUserFromRecipientList(WorkflowExpression<string> recipientListId, WorkflowExpression<string> deleteUserRequestemailAddress = null)
        {
            WorkflowExpression.Validate(recipientListId, nameof(recipientListId), required: true);
            WorkflowExpression.Validate(deleteUserRequestemailAddress, nameof(deleteUserRequestemailAddress), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/delete-user/recipient-lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteUserRequest = new JObject();
                var deleteUserRequestpropCount = 0;
                if (deleteUserRequestemailAddress != null)
                {
                    deleteUserRequest["email_address"] = ExpressionConverter.ConvertO(deleteUserRequestemailAddress);
                    deleteUserRequestpropCount++;
                }

                if (deleteUserRequestpropCount > 0)
                {
                    callPayload.Body = deleteUserRequest;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmailToRecipientList))]
        public IBodyWorkflowAction<JToken> SendEmailToRecipientList([WorkflowExpression] Func<string> requestrecipientsrecipient, [WorkflowExpression] Func<string> requestcontenttemplate, [WorkflowExpression] Func<string> requestcampaignId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendEmailToRecipientList(WorkflowExpression<string> requestrecipientsrecipient, WorkflowExpression<string> requestcontenttemplate, WorkflowExpression<string> requestcampaignId = null)
        {
            WorkflowExpression.Validate(requestrecipientsrecipient, nameof(requestrecipientsrecipient), required: true);
            WorkflowExpression.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            WorkflowExpression.Validate(requestcampaignId, nameof(requestcampaignId), required: false);
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
                recipientsObject["list_id"] = ExpressionConverter.ConvertO(requestrecipientsrecipient);
                if (recipientsObjectpropCount > 0)
                {
                    request["recipients"] = recipientsObject;
                    requestpropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObjectpropCount++;
                contentObject["template_id"] = ExpressionConverter.ConvertO(requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                if (requestcampaignId != null)
                {
                    request["campaign_id"] = ExpressionConverter.ConvertO(requestcampaignId);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmailToRecipient))]
        public IBodyWorkflowAction<JToken> SendEmailToRecipient([WorkflowExpression] Func<string> requestcontenttemplate, [WorkflowExpression] Func<EmailRecipient[]> requestrecipients)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendEmailToRecipient(WorkflowExpression<string> requestcontenttemplate, WorkflowExpression<EmailRecipient[]> requestrecipients)
        {
            WorkflowExpression.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            WorkflowExpression.Validate(requestrecipients, nameof(requestrecipients), required: true);
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
                contentObject["template_id"] = ExpressionConverter.ConvertO(requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["recipients"] = ExpressionConverter.ConvertO(requestrecipients);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SparkpostTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRecipientListsResponse> OnNewRecipientList(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/recipient-lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListRecipientListsResponse>(callPayload, triggerName, recurrence);
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