//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparkpost
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparkpostActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> CreateRecipientList([WorkflowExpression] Func<string> recipientListidOfTheRecipientList = null, [WorkflowExpression] Func<string> recipientListnameOfTheRecipientList = null, [WorkflowExpression] Func<string> recipientListdescription = null, [WorkflowExpression] Func<string> recipientListemailAddressOfFirstRecipient = null)
        {
            SourceExpression.Validate(recipientListidOfTheRecipientList, nameof(recipientListidOfTheRecipientList), required: false);
            SourceExpression.Validate(recipientListnameOfTheRecipientList, nameof(recipientListnameOfTheRecipientList), required: false);
            SourceExpression.Validate(recipientListdescription, nameof(recipientListdescription), required: false);
            SourceExpression.Validate(recipientListemailAddressOfFirstRecipient, nameof(recipientListemailAddressOfFirstRecipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/recipient-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var recipientList = new JObject();
                var recipientListpropCount = 0;
                if (recipientListidOfTheRecipientList != null)
                {
                    recipientList["id"] = SourceExpressionConverter.ConvertToken(recipientListidOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (recipientListnameOfTheRecipientList != null)
                {
                    recipientList["name"] = SourceExpressionConverter.ConvertToken(recipientListnameOfTheRecipientList);
                    recipientListpropCount++;
                }

                if (recipientListdescription != null)
                {
                    recipientList["description"] = SourceExpressionConverter.ConvertToken(recipientListdescription);
                    recipientListpropCount++;
                }

                if (recipientListemailAddressOfFirstRecipient != null)
                {
                    recipientList["email"] = SourceExpressionConverter.ConvertToken(recipientListemailAddressOfFirstRecipient);
                    recipientListpropCount++;
                }

                if (recipientListpropCount > 0)
                {
                    callPayload.Body = recipientList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> AddUserToRecipientList([WorkflowExpression] Func<string> recipientListId, [WorkflowExpression] Func<string> addUserToRecipientListRequestrecipientaddressemailAddress, [WorkflowExpression] Func<string> addUserToRecipientListRequestrecipientaddressname = null)
        {
            SourceExpression.Validate(recipientListId, nameof(recipientListId), required: true);
            SourceExpression.Validate(addUserToRecipientListRequestrecipientaddressemailAddress, nameof(addUserToRecipientListRequestrecipientaddressemailAddress), required: true);
            SourceExpression.Validate(addUserToRecipientListRequestrecipientaddressname, nameof(addUserToRecipientListRequestrecipientaddressname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/add-user/recipient-lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addUserToRecipientListRequest = new JObject();
                var addUserToRecipientListRequestpropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["email"] = SourceExpressionConverter.ConvertToken(addUserToRecipientListRequestrecipientaddressemailAddress);
                if (addUserToRecipientListRequestrecipientaddressname != null)
                {
                    addressObject["name"] = SourceExpressionConverter.ConvertToken(addUserToRecipientListRequestrecipientaddressname);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> DeleteUserFromRecipientList([WorkflowExpression] Func<string> recipientListId, [WorkflowExpression] Func<string> deleteUserRequestemailAddress = null)
        {
            SourceExpression.Validate(recipientListId, nameof(recipientListId), required: true);
            SourceExpression.Validate(deleteUserRequestemailAddress, nameof(deleteUserRequestemailAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/delete-user/recipient-lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientListId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var deleteUserRequest = new JObject();
                var deleteUserRequestpropCount = 0;
                if (deleteUserRequestemailAddress != null)
                {
                    deleteUserRequest["email_address"] = SourceExpressionConverter.ConvertToken(deleteUserRequestemailAddress);
                    deleteUserRequestpropCount++;
                }

                if (deleteUserRequestpropCount > 0)
                {
                    callPayload.Body = deleteUserRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> SendEmailToRecipientList([WorkflowExpression] Func<string> requestrecipientsrecipient, [WorkflowExpression] Func<string> requestcontenttemplate, [WorkflowExpression] Func<string> requestcampaignId = null)
        {
            SourceExpression.Validate(requestrecipientsrecipient, nameof(requestrecipientsrecipient), required: true);
            SourceExpression.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            SourceExpression.Validate(requestcampaignId, nameof(requestcampaignId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/transmissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var recipientsObject = new JObject();
                var recipientsObjectpropCount = 0;
                recipientsObjectpropCount++;
                recipientsObject["list_id"] = SourceExpressionConverter.ConvertToken(requestrecipientsrecipient);
                if (recipientsObjectpropCount > 0)
                {
                    request["recipients"] = recipientsObject;
                    requestpropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObjectpropCount++;
                contentObject["template_id"] = SourceExpressionConverter.ConvertToken(requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                if (requestcampaignId != null)
                {
                    request["campaign_id"] = SourceExpressionConverter.ConvertToken(requestcampaignId);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparkpost")]
        public IBodyWorkflowAction<JToken> SendEmailToRecipient([WorkflowExpression] Func<string> requestcontenttemplate, [WorkflowExpression] Func<EmailRecipient[]> requestrecipients)
        {
            SourceExpression.Validate(requestcontenttemplate, nameof(requestcontenttemplate), required: true);
            SourceExpression.Validate(requestrecipients, nameof(requestrecipients), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/transmissions/singleRecipient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObjectpropCount++;
                contentObject["template_id"] = SourceExpressionConverter.ConvertToken(requestcontenttemplate);
                if (contentObjectpropCount > 0)
                {
                    request["content"] = contentObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["recipients"] = SourceExpressionConverter.ConvertToken(requestrecipients);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class SparkpostTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListRecipientListsResponse> OnNewRecipientList(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/recipient-lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListRecipientListsResponse>(BuildSourceInput, triggerName, recurrence);
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