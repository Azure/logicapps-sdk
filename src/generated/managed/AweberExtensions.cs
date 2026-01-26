//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aweber
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AweberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<string> CreateSubscriber(Expression<Func<int>> listid, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = String.Format("/1.0/accounts/accountid/lists/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(listid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["misc_notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<UnsubscribeEmailResponse> UnsubscribeEmail(Expression<Func<int>> listid, Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/1.0/accounts/accountid/lists/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(listid, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            var body = new JObject();
            var bodypropCount = 0;
            body["status"] = "unsubscribed";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UnsubscribeEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<ListListsResponse> ListLists()
        {
            var apiCallPath = "/1.0/accounts/accountid/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListListsResponse>(callPayload);
        }
    }

    public class AweberTriggers([ConnectionName] string connectionId)
    {
    }

    public class UnsubscribeEmailResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ListListsResponse
    {
        [JsonProperty("entries")]
        public ListListsResponseEntriesTypeItem[] Entries { get; set; }
    }

    public class ListListsResponseEntriesTypeItem
    {
        [JsonProperty("total_unconfirmed_subscribers")]
        public int UnconfirmedSubscriberCount { get; set; }

        [JsonProperty("total_subscribers_subscribed_yesterday")]
        public int SubscribedYesterdayCount { get; set; }

        [JsonProperty("unique_list_id")]
        public string UniqueId { get; set; }

        [JsonProperty("total_subscribers_subscribed_today")]
        public int SubscribedTodayCount { get; set; }

        [JsonProperty("id")]
        public int ListId { get; set; }

        [JsonProperty("total_subscribed_subscribers")]
        public int SubscriberCount { get; set; }

        [JsonProperty("total_unsubscribed_subscribers")]
        public int UnsubscribedCount { get; set; }

        [JsonProperty("total_subscribers")]
        public int ListCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aweber;

    public partial class WorkflowManagedActions
    {
        public AweberActions Aweber(string connectionId) => new AweberActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AweberTriggers Aweber(string connectionId) => new AweberTriggers(connectionId);
    }
}