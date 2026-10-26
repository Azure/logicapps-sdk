//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipelinercrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipelinercrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsDeleteResponse, ApiConnectionActionConfiguration> AccountsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AccountsDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<AccountsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsGetResponse, ApiConnectionActionConfiguration> AccountsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AccountsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<AccountsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsUpdateResponse, ApiConnectionActionConfiguration> AccountsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<AccountsUpdateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AccountsUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccountsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<AccountsCreateResponse, ApiConnectionActionConfiguration> AccountsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<AccountsCreateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AccountsCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Accounts", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccountsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsCreateResponse, ApiConnectionActionConfiguration> ContactsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<ContactsCreateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ContactsCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsDeleteResponse, ApiConnectionActionConfiguration> ContactsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactsDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<ContactsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsGetResponse, ApiConnectionActionConfiguration> ContactsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ContactsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<ContactsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<ContactsUpdateResponse, ApiConnectionActionConfiguration> ContactsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<ContactsUpdateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ContactsUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Contacts/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsCreateResponse, ApiConnectionActionConfiguration> LeadsCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<LeadsCreateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LeadsCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LeadsCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsDeleteResponse, ApiConnectionActionConfiguration> LeadsDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadsDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<LeadsDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsGetResponse, ApiConnectionActionConfiguration> LeadsGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LeadsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<LeadsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<LeadsUpdateResponse, ApiConnectionActionConfiguration> LeadsUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<LeadsUpdateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LeadsUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Leads/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LeadsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksCreateResponse, ApiConnectionActionConfiguration> TasksCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<TasksCreateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TasksCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TasksCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksDeleteResponse, ApiConnectionActionConfiguration> TasksDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TasksDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<TasksDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksGetResponse, ApiConnectionActionConfiguration> TasksGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TasksGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<TasksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<TasksUpdateResponse, ApiConnectionActionConfiguration> TasksUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<TasksUpdateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TasksUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Tasks/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TasksUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesCreateResponse, ApiConnectionActionConfiguration> OpportunitiesCreate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<OpportunitiesCreateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OpportunitiesCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities", __workflow_spaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OpportunitiesCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesDeleteResponse, ApiConnectionActionConfiguration> OpportunitiesDelete(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<OpportunitiesDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<OpportunitiesDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesGetResponse, ApiConnectionActionConfiguration> OpportunitiesGet(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<OpportunitiesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                return new ApiConnectionAction<OpportunitiesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipelinercrm")]
        public IBodyWorkflowAction<OpportunitiesUpdateResponse, ApiConnectionActionConfiguration> OpportunitiesUpdate(Expression<Func<string>> serviceUrl, Expression<Func<string>> spaceId, Expression<Func<string>> id, Expression<Func<OpportunitiesUpdateInput>> body)
        {
            var __workflow_serviceUrl = WorkflowExpression.Compile(serviceUrl, nameof(serviceUrl), required: true);
            var __workflow_spaceId = WorkflowExpression.Compile(spaceId, nameof(spaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OpportunitiesUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v100/rest/spaces/{0}/entities/Opportunities/{1}", __workflow_spaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["service_url"] = ExpressionConverter.Convert(__workflow_serviceUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OpportunitiesUpdateResponse>(callPayload);
            });
        }
    }

    public class PipelinercrmTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class AccountsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsGetResponseDataType Data { get; set; }
    }

    public class AccountsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class AccountsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsUpdateResponseDataType Data { get; set; }
    }

    public class AccountsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class AccountsUpdateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("account_class")]
        public AccountsUpdateInputAccountClassType? AccountClass { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public enum AccountsUpdateInputAccountClassType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class AccountsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public AccountsCreateResponseDataType Data { get; set; }
    }

    public class AccountsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("customer_type")]
        public string CustomerType { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("parent_account")]
        public string ParentAccount { get; set; }

        [JsonProperty("parent_account_relation_type")]
        public string ParentAccountRelationType { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("account_class")]
        public int AccountClass { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("customer_type_id")]
        public string CustomerTypeId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("health_category")]
        public string HealthCategory { get; set; }

        [JsonProperty("health_status")]
        public int HealthStatus { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("industry_id")]
        public string IndustryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("parent_account_id")]
        public string ParentAccountId { get; set; }

        [JsonProperty("parent_account_relation_type_id")]
        public string ParentAccountRelationTypeId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("quick_parent_account_name")]
        public string QuickParentAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("health")]
        public JToken Health { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class AccountsCreateInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("owner_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty("account_type_id")]
        public string AccountTypeId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("account_class")]
        public AccountsCreateInputAccountClassType? AccountClass { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("home_page")]
        public string HomePage { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public enum AccountsCreateInputAccountClassType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class ContactsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsCreateResponseDataType Data { get; set; }
    }

    public class ContactsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class ContactsCreateInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public ContactsCreateInputGenderType? Gender { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("account_relations")]
        public ContactsCreateInputAccountRelationsTypeItem[] AccountRelations { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public enum ContactsCreateInputGenderType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class ContactsCreateInputAccountRelationsTypeItem
    {
        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class ContactsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class ContactsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsGetResponseDataType Data { get; set; }
    }

    public class ContactsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class ContactsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public ContactsUpdateResponseDataType Data { get; set; }
    }

    public class ContactsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("email3")]
        public string Email3 { get; set; }

        [JsonProperty("email4")]
        public string Email4 { get; set; }

        [JsonProperty("email5")]
        public string Email5 { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("phone3")]
        public string Phone3 { get; set; }

        [JsonProperty("phone4")]
        public string Phone4 { get; set; }

        [JsonProperty("phone5")]
        public string Phone5 { get; set; }

        [JsonProperty("picture_id")]
        public string PictureId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("primary_account_account_roles")]
        public string[] PrimaryAccountAccountRoles { get; set; }

        [JsonProperty("primary_account_position")]
        public string PrimaryAccountPosition { get; set; }

        [JsonProperty("account_position")]
        public string AccountPosition { get; set; }

        [JsonProperty("is_unsubscribed")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("primary_account_relationship")]
        public int PrimaryAccountRelationship { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class ContactsUpdateInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public ContactsUpdateInputGenderType? Gender { get; set; }

        [JsonProperty("contact_type_id")]
        public string ContactTypeId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("email1")]
        public string Email1 { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public enum ContactsUpdateInputGenderType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class LeadsCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsCreateResponseDataType Data { get; set; }
    }

    public class LeadsCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class LeadsCreateInput
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ranking")]
        public int? Ranking { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("owner_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("unit_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UnitId { get; set; }

        [JsonProperty("contact_relations")]
        public LeadsCreateInputContactRelationsTypeItem[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public LeadsCreateInputAccountRelationsTypeItem[] AccountRelations { get; set; }
    }

    public class LeadsCreateInputContactRelationsTypeItem
    {
        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class LeadsCreateInputAccountRelationsTypeItem
    {
        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class LeadsDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class LeadsGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsGetResponseDataType Data { get; set; }
    }

    public class LeadsGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class LeadsUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public LeadsUpdateResponseDataType Data { get; set; }
    }

    public class LeadsUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("scoring")]
        public JToken Scoring { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class LeadsUpdateInput
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ranking")]
        public int? Ranking { get; set; }

        [JsonProperty("lead_type_id")]
        public string LeadTypeId { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }
    }

    public class TasksCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksCreateResponseDataType Data { get; set; }
    }

    public class TasksCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class TasksCreateInput
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("unit_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UnitId { get; set; }

        [JsonProperty("owner_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public TasksCreateInputPriorityType? Priority { get; set; }

        [JsonProperty("status")]
        public TasksCreateInputStatusType? Status { get; set; }

        [JsonProperty("account_relations")]
        public TasksCreateInputAccountRelationsTypeItem[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public TasksCreateInputContactRelationsTypeItem[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public TasksCreateInputLeadRelationsTypeItem[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public TasksCreateInputOpportunityRelationsTypeItem[] OpportunityRelations { get; set; }
    }

    public enum TasksCreateInputPriorityType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum TasksCreateInputStatusType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class TasksCreateInputAccountRelationsTypeItem
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class TasksCreateInputContactRelationsTypeItem
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class TasksCreateInputLeadRelationsTypeItem
    {
        [JsonProperty("lead_oppty_id")]
        public string LeadOpptyId { get; set; }
    }

    public class TasksCreateInputOpportunityRelationsTypeItem
    {
        [JsonProperty("lead_oppty_id")]
        public string LeadOpptyId { get; set; }
    }

    public class TasksDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class TasksGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksGetResponseDataType Data { get; set; }
    }

    public class TasksGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class TasksUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public TasksUpdateResponseDataType Data { get; set; }
    }

    public class TasksUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active_reminder")]
        public string ActiveReminder { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        [JsonProperty("call_outcome")]
        public string CallOutcome { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("call_duration")]
        public int CallDuration { get; set; }

        [JsonProperty("call_outcome_id")]
        public string CallOutcomeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("lead_relations")]
        public string[] LeadRelations { get; set; }

        [JsonProperty("opportunity_relations")]
        public string[] OpportunityRelations { get; set; }

        [JsonProperty("project_relations")]
        public string[] ProjectRelations { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("reminder")]
        public string Reminder { get; set; }

        [JsonProperty("task_recurrence")]
        public string TaskRecurrence { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class TasksUpdateInput
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("activity_type_id")]
        public string ActivityTypeId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public TasksUpdateInputPriorityType? Priority { get; set; }

        [JsonProperty("status")]
        public TasksUpdateInputStatusType? Status { get; set; }
    }

    public enum TasksUpdateInputPriorityType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum TasksUpdateInputStatusType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class OpportunitiesCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesCreateResponseDataType Data { get; set; }
    }

    public class OpportunitiesCreateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesCreateResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesCreateResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }

    public class OpportunitiesCreateInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public OpportunitiesCreateInputValueType Value { get; set; }

        [JsonProperty("closing_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ranking")]
        public int? Ranking { get; set; }

        [JsonProperty("oppty_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OpptyTypeId { get; set; }

        [JsonProperty("step_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StepId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty("account_relations", DefaultValueHandling = DefaultValueHandling.Include)]
        public OpportunitiesCreateInputAccountRelationsTypeItem[] AccountRelations { get; set; }

        [JsonProperty("contact_relations")]
        public OpportunitiesCreateInputContactRelationsTypeItem[] ContactRelations { get; set; }
    }

    public class OpportunitiesCreateInputValueType
    {
        [JsonProperty("base_value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double? ValueForeign { get; set; }
    }

    public class OpportunitiesCreateInputAccountRelationsTypeItem
    {
        [JsonProperty("is_primary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPrimary { get; set; }

        [JsonProperty("account_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccountId { get; set; }
    }

    public class OpportunitiesCreateInputContactRelationsTypeItem
    {
        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }
    }

    public class OpportunitiesDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class OpportunitiesGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesGetResponseDataType Data { get; set; }
    }

    public class OpportunitiesGetResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesGetResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesGetResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }

    public class OpportunitiesUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public OpportunitiesUpdateResponseDataType Data { get; set; }
    }

    public class OpportunitiesUpdateResponseDataType
    {
        [JsonProperty("is_delete_protected")]
        public bool IsDeleteProtected { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("active_quote")]
        public string ActiveQuote { get; set; }

        [JsonProperty("oppty_type")]
        public string OpptyType { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("product_currency")]
        public string ProductCurrency { get; set; }

        [JsonProperty("product_price_list")]
        public string ProductPriceList { get; set; }

        [JsonProperty("reason_of_close")]
        public string ReasonOfClose { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("active_quote_id")]
        public string ActiveQuoteId { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_value_auto_calculate")]
        public bool IsValueAutoCalculate { get; set; }

        [JsonProperty("label_flag")]
        public int LabelFlag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("product_currency_id")]
        public string ProductCurrencyId { get; set; }

        [JsonProperty("product_price_list_id")]
        public string ProductPriceListId { get; set; }

        [JsonProperty("product_sections")]
        public JToken ProductSections { get; set; }

        [JsonProperty("quick_account_email")]
        public string QuickAccountEmail { get; set; }

        [JsonProperty("quick_account_name")]
        public string QuickAccountName { get; set; }

        [JsonProperty("quick_account_phone")]
        public string QuickAccountPhone { get; set; }

        [JsonProperty("quick_contact_name")]
        public string QuickContactName { get; set; }

        [JsonProperty("quick_email")]
        public string QuickEmail { get; set; }

        [JsonProperty("quick_phone")]
        public string QuickPhone { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("reason_of_close_description")]
        public string ReasonOfCloseDescription { get; set; }

        [JsonProperty("reason_of_close_id")]
        public string ReasonOfCloseId { get; set; }

        [JsonProperty("share_mode")]
        public int ShareMode { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("was_qualified")]
        public bool WasQualified { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("value")]
        public OpportunitiesUpdateResponseDataTypeValueType Value { get; set; }

        [JsonProperty("oppty_recurrence")]
        public string OpptyRecurrence { get; set; }

        [JsonProperty("revenue_schedule")]
        public string RevenueSchedule { get; set; }

        [JsonProperty("product_relations")]
        public string[] ProductRelations { get; set; }

        [JsonProperty("primary_contact")]
        public string PrimaryContact { get; set; }

        [JsonProperty("primary_account")]
        public string PrimaryAccount { get; set; }

        [JsonProperty("contact_relations")]
        public string[] ContactRelations { get; set; }

        [JsonProperty("account_relations")]
        public string[] AccountRelations { get; set; }

        [JsonProperty("documents")]
        public string[] Documents { get; set; }

        [JsonProperty("quote_relations")]
        public string[] QuoteRelations { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("qualify_date")]
        public string QualifyDate { get; set; }

        [JsonProperty("won_date")]
        public string WonDate { get; set; }

        [JsonProperty("lost_date")]
        public string LostDate { get; set; }

        [JsonProperty("days_in_step")]
        public int DaysInStep { get; set; }

        [JsonProperty("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("sharing_units")]
        public string[] SharingUnits { get; set; }

        [JsonProperty("sharing_clients")]
        public string[] SharingClients { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }

        [JsonProperty("modified_by_user")]
        public string ModifiedByUser { get; set; }
    }

    public class OpportunitiesUpdateResponseDataTypeValueType
    {
        [JsonProperty("base_value")]
        public double BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double ValueForeign { get; set; }
    }

    public class OpportunitiesUpdateInput
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public OpportunitiesUpdateInputValueType Value { get; set; }

        [JsonProperty("closing_date")]
        public string ClosingDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ranking")]
        public int? Ranking { get; set; }

        [JsonProperty("oppty_type_id")]
        public string OpptyTypeId { get; set; }

        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }
    }

    public class OpportunitiesUpdateInputValueType
    {
        [JsonProperty("base_value")]
        public double? BaseValue { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("value_foreign")]
        public double? ValueForeign { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pipelinercrm;

    public partial class WorkflowManagedActions
    {
        public PipelinercrmActions Pipelinercrm(string connectionId) => new PipelinercrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PipelinercrmTriggers Pipelinercrm(string connectionId) => new PipelinercrmTriggers(connectionId);
    }
}