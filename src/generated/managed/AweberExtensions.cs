//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aweber
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AweberActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSubscriber(Expression<Func<int>> listid, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_listid = WorkflowExpression.Compile(listid, nameof(listid), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/1.0/accounts/accountid/lists/{0}/subscribers", __workflow_listid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["misc_notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<UnsubscribeEmailResponse, ApiConnectionActionConfiguration> UnsubscribeEmail(Expression<Func<int>> listid, Expression<Func<string>> email)
        {
            var __workflow_listid = WorkflowExpression.Compile(listid, nameof(listid), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<UnsubscribeEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/1.0/accounts/accountid/lists/{0}/subscribers", __workflow_listid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                var body = new JObject();
                var bodypropCount = 0;
                body["status"] = "unsubscribed";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribeEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aweber")]
        public IBodyWorkflowAction<ListListsResponse, ApiConnectionActionConfiguration> ListLists()
        {
            return new DeferredBodyAction<ListListsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/accounts/accountid/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListListsResponse>(callPayload);
            });
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