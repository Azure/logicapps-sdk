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
        public IBodyWorkflowAction<string> CreateSubscriber([WorkflowExpression] Func<int> listid, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.0/accounts/accountid/lists/{0}/subscribers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["misc_notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<UnsubscribeEmailResponse> UnsubscribeEmail([WorkflowExpression] Func<int> listid, [WorkflowExpression] Func<string> email)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1.0/accounts/accountid/lists/{0}/subscribers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(listid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                var body = new JObject();
                var bodypropCount = 0;
                body["status"] = "unsubscribed";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnsubscribeEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<ListListsResponse> ListLists()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/accounts/accountid/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListListsResponse>(BuildSourceInput);
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