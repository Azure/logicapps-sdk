//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expirationreminder
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpirationreminderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<FindExpirationResponse, ApiConnectionActionConfiguration> FindExpiration(Expression<Func<string>> category = null, Expression<Func<string>> email = null, Expression<Func<string>> name = null)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredBodyAction<FindExpirationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/expirationitems/find";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                return new ApiConnectionAction<FindExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<RenewExpirationResponse, ApiConnectionActionConfiguration> RenewExpiration(Expression<Func<string>> expirationItemId, Expression<Func<string>> bodyexpirationDate = null, Expression<Func<string>> bodydetails = null)
        {
            var __workflow_expirationItemId = WorkflowExpression.Compile(expirationItemId, nameof(expirationItemId), required: true);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            var __workflow_bodydetails = WorkflowExpression.Compile(bodydetails, nameof(bodydetails), required: false);
            return new DeferredBodyAction<RenewExpirationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/expirationitems/{0}/renew", __workflow_expirationItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexpirationDate != null)
                {
                    body["expiration_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (__workflow_bodydetails != null)
                {
                    body["details"] = ExpressionConverter.ConvertO(__workflow_bodydetails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RenewExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<CreateExpirationItemResponse, ApiConnectionActionConfiguration> CreateExpirationItem(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycategoryName = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycategoryName = WorkflowExpression.Compile(bodycategoryName, nameof(bodycategoryName), required: false);
            var __workflow_bodyexpirationDate = WorkflowExpression.Compile(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyAction<CreateExpirationItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/expirationitems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryName != null)
                {
                    body["category_name"] = ExpressionConverter.ConvertO(__workflow_bodycategoryName);
                    bodypropCount++;
                }

                if (__workflow_bodyexpirationDate != null)
                {
                    body["expiration_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateExpirationItemResponse>(callPayload);
            });
        }
    }

    public class ExpirationreminderTriggers([ConnectionName] string connectionId)
    {
    }

    public class FindExpirationResponse
    {
        [JsonProperty("expiration_items")]
        public FindExpirationResponseExpirationItemsTypeItem[] ExpirationItems { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class FindExpirationResponseExpirationItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonProperty("category")]
        public FindExpirationResponseExpirationItemsTypeItemCategoryType Category { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("assigned_to")]
        public FindExpirationResponseExpirationItemsTypeItemAssignedToType AssignedTo { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class FindExpirationResponseExpirationItemsTypeItemCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FindExpirationResponseExpirationItemsTypeItemAssignedToType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }
    }

    public class RenewExpirationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonProperty("category")]
        public RenewExpirationResponseCategoryType Category { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("assigned_to")]
        public RenewExpirationResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class RenewExpirationResponseCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RenewExpirationResponseAssignedToType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }
    }

    public class CreateExpirationItemResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonProperty("category")]
        public CreateExpirationItemResponseCategoryType Category { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("assigned_to")]
        public CreateExpirationItemResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
    }

    public class CreateExpirationItemResponseCategoryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateExpirationItemResponseAssignedToType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_id")]
        public string TeamId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Expirationreminder;

    public partial class WorkflowManagedActions
    {
        public ExpirationreminderActions Expirationreminder(string connectionId) => new ExpirationreminderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExpirationreminderTriggers Expirationreminder(string connectionId) => new ExpirationreminderTriggers(connectionId);
    }
}
