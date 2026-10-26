//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alvao
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlvaoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alvao")]
        public IBodyWorkflowAction<AMObjectsExpandedApiResponse, ApiConnectionActionConfiguration> GetObjects(Expression<Func<int>> top = null, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<AMObjectsExpandedApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["$expand"] = Convert.ToString("properties");
                return new ApiConnectionAction<AMObjectsExpandedApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alvao")]
        public IBodyWorkflowAction<CommonUsersApiResponse, ApiConnectionActionConfiguration> GetUsers(Expression<Func<int>> top = null, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<CommonUsersApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction<CommonUsersApiResponse>(callPayload);
            });
        }
    }

    public class AlvaoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration> TicketTransitionsToStatus(Expression<Func<TicketTransitionsToStatusInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/tickettransitionstostatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AMObjectsExpandedApiResponse
    {
        [JsonProperty("value")]
        public AMObjectExpanded[] Value { get; set; }
    }

    public class AMObjectExpanded
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("kindId")]
        public int KindId { get; set; }

        [JsonProperty("kindName")]
        public string KindName { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("parentObjectId")]
        public int ParentObjectId { get; set; }

        [JsonProperty("properties")]
        public AMObjectExpandedPropertiesTypeItem[] Properties { get; set; }
    }

    public class AMObjectExpandedPropertiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("nameOrder")]
        public int NameOrder { get; set; }
    }

    public class CommonUsersApiResponse
    {
        [JsonProperty("value")]
        public CommonPerson[] Value { get; set; }
    }

    public class CommonPerson
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("email2")]
        public string EMail2 { get; set; }

        [JsonProperty("phone")]
        public string WorkPhone { get; set; }

        [JsonProperty("phone2")]
        public string WorkPhone2 { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("workPosition")]
        public string Position { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("otherContacts")]
        public string OtherContacts { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("sAMAccountName")]
        public string UsernameForOlderSystems { get; set; }

        [JsonProperty("login")]
        public string Username { get; set; }

        [JsonProperty("createdDate")]
        public string Created { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("isGuest")]
        public bool IsGuest { get; set; }

        [JsonProperty("isApp")]
        public bool IsApp { get; set; }

        [JsonProperty("removedDate")]
        public string Removed { get; set; }

        [JsonProperty("managerId")]
        public int ManagerId { get; set; }

        [JsonProperty("substituteId")]
        public int SubstituteId { get; set; }

        [JsonProperty("personalNumber")]
        public string PersonalNumber { get; set; }

        [JsonProperty("localeId")]
        public int PreferredLanguageId { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("customItems")]
        public JToken CustomItems { get; set; }

        [JsonProperty("adGuid")]
        public string ADGUID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("sid")]
        public string SId { get; set; }

        [JsonProperty("adPath")]
        public string ADPath { get; set; }

        [JsonProperty("azureAdObjectId")]
        public string AzureId { get; set; }
    }

    public class WebhookCreatedResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TicketTransitionsToStatusInput
    {
        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("process", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessName { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketStatusName { get; set; }

        [JsonProperty("service")]
        public string ServiceName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alvao;

    public partial class WorkflowManagedActions
    {
        public AlvaoActions Alvao(string connectionId) => new AlvaoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlvaoTriggers Alvao(string connectionId) => new AlvaoTriggers(connectionId);
    }
}