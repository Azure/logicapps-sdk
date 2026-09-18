//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expirationreminder
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpirationreminderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<FindExpirationResponse> FindExpiration([WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> name = null)
        {
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/expirationitems/find";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindExpirationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IWorkflowAction CreateContact([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<RenewExpirationResponse> RenewExpiration([WorkflowExpression] Func<string> expirationItemId, [WorkflowExpression] Func<string> bodyexpirationDate = null, [WorkflowExpression] Func<string> bodydetails = null)
        {
            SourceExpression.Validate(expirationItemId, nameof(expirationItemId), required: true);
            SourceExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            SourceExpression.Validate(bodydetails, nameof(bodydetails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/expirationitems/{0}/renew", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(expirationItemId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexpirationDate != null)
                {
                    body["expiration_date"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodydetails != null)
                {
                    body["details"] = SourceExpressionConverter.ConvertToken(bodydetails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RenewExpirationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expirationreminder")]
        public IBodyWorkflowAction<CreateExpirationItemResponse> CreateExpirationItem([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycategoryName = null, [WorkflowExpression] Func<string> bodyexpirationDate = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycategoryName, nameof(bodycategoryName), required: false);
            SourceExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/expirationitems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycategoryName != null)
                {
                    body["category_name"] = SourceExpressionConverter.ConvertToken(bodycategoryName);
                    bodypropCount++;
                }

                if (bodyexpirationDate != null)
                {
                    body["expiration_date"] = SourceExpressionConverter.ConvertToken(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateExpirationItemResponse>(BuildSourceInput);
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