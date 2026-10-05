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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecipientList(WorkflowValue<string> recipientListidOfTheRecipientList = null, WorkflowValue<string> recipientListnameOfTheRecipientList = null, WorkflowValue<string> recipientListdescription = null, WorkflowValue<string> recipientListemailAddressOfFirstRecipient = null)
        {
            WorkflowValue.Validate(recipientListidOfTheRecipientList, nameof(recipientListidOfTheRecipientList), required: false);
            WorkflowValue.Validate(recipientListnameOfTheRecipientList, nameof(recipientListnameOfTheRecipientList), required: false);
            WorkflowValue.Validate(recipientListdescription, nameof(recipientListdescription), required: false);
            WorkflowValue.Validate(recipientListemailAddressOfFirstRecipient, nameof(recipientListemailAddressOfFirstRecipient), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAddUserToRecipientList(WorkflowValue<string> recipientListId, WorkflowValue<string> addUserToRecipientListRequestrecipientaddressemailAddress, WorkflowValue<string> addUserToRecipientListRequestrecipientaddressname = null)
        {
            WorkflowValue.Validate(recipientListId, nameof(recipientListId), required: true);
            WorkflowValue.Validate(addUserToRecipientListRequestrecipientaddressemailAddress, nameof(addUserToRecipientListRequestrecipientaddressemailAddress), required: true);
            WorkflowValue.Validate(addUserToRecipientListRequestrecipientaddressname, nameof(addUserToRecipientListRequestrecipientaddressname), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteUserFromRecipientList(WorkflowValue<string> recipientListId, WorkflowValue<string> deleteUserRequestemailAddress = null)
        {
            WorkflowValue.Validate(recipientListId, nameof(recipientListId), required: true);
            WorkflowValue.Validate(deleteUserRequestemailAddress, nameof(deleteUserRequestemailAddress), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendEmailToRecipientList(WorkflowValue<string> requestrecipientsrecipient, WorkflowValue<string> requestcontenttemplate, WorkflowValue<string> requestcampaignId = null)
        {
            WorkflowValue.Validate(requestrecipientsrecipient, nameof(requestrecipientsrecipient), required: true);
            WorkflowValue.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            WorkflowValue.Validate(requestcampaignId, nameof(requestcampaignId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendEmailToRecipient(WorkflowValue<string> requestcontenttemplate, WorkflowValue<EmailRecipient[]> requestrecipients)
        {
            WorkflowValue.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            WorkflowValue.Validate(requestrecipients, nameof(requestrecipients), required: true);
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
