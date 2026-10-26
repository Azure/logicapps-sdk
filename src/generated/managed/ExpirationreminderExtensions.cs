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
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<RenewExpirationResponse, ApiConnectionActionConfiguration> RenewExpiration(Expression<Func<string>> expirationItemId, Expression<Func<RenewExpirationInput>> body)
        {
            var __workflow_expirationItemId = WorkflowExpression.Compile(expirationItemId, nameof(expirationItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RenewExpirationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/expirationitems/{0}/renew", __workflow_expirationItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RenewExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<CreateExpirationItemResponse, ApiConnectionActionConfiguration> CreateExpirationItem(Expression<Func<CreateExpirationItemInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateExpirationItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/expirationitems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateContactInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
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

    public class RenewExpirationInput
    {
        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
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

    public class CreateExpirationItemInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }
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