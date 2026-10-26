//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urlbaeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrlbaeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<AccountGetResponse, ApiConnectionActionConfiguration> AccountGet()
        {
            return new DeferredBodyAction<AccountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<AccountUpdateResponse, ApiConnectionActionConfiguration> AccountUpdate(Expression<Func<AccountUpdateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AccountUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccountUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainListResponse, ApiConnectionActionConfiguration> DomainList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<DomainListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<DomainListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainCreateResponse, ApiConnectionActionConfiguration> DomainCreate(Expression<Func<DomainCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DomainCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domain/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DomainCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainUpdateResponse, ApiConnectionActionConfiguration> DomainUpdate(Expression<Func<string>> id, Expression<Func<DomainUpdateInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DomainUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domain/{0}/update", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DomainUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainDeleteResponse, ApiConnectionActionConfiguration> DomainDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DomainDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domain/{0}/delete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DomainDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<SplashListResponse, ApiConnectionActionConfiguration> SplashList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SplashListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/splash";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SplashListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<CTAListResponse, ApiConnectionActionConfiguration> CTAList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<CTAListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/overlay";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<CTAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkListResponse, ApiConnectionActionConfiguration> LinkList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> order = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            return new DeferredBodyAction<LinkListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/urls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                return new ApiConnectionAction<LinkListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkGetResponse, ApiConnectionActionConfiguration> LinkGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LinkGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/url/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinkGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkShortenResponse, ApiConnectionActionConfiguration> LinkShorten(Expression<Func<LinkShortenInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LinkShortenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/url/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkShortenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkUpdateResponse, ApiConnectionActionConfiguration> LinkUpdate(Expression<Func<string>> id, Expression<Func<LinkUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LinkUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/url/{0}/update", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LinkUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkDeleteResponse, ApiConnectionActionConfiguration> LinkDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LinkDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/url/{0}/delete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinkDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelListResponse, ApiConnectionActionConfiguration> PixelList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<PixelListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PixelListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelCreateResponse, ApiConnectionActionConfiguration> PixelCreate(Expression<Func<PixelCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PixelCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pixel/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PixelCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelUpdateResponse, ApiConnectionActionConfiguration> PixelUpdate(Expression<Func<string>> id, Expression<Func<PixelUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PixelUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pixel/{0}/update", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PixelUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelDeleteResponse, ApiConnectionActionConfiguration> PixelDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PixelDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pixel/{0}/delete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRListResponse, ApiConnectionActionConfiguration> QRList(Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<QRListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<QRListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRGetResponse, ApiConnectionActionConfiguration> QRGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QRGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/qr/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRCreateResponse, ApiConnectionActionConfiguration> QRCreate(Expression<Func<QRCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QRCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/qr/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QRCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRUpdateResponse, ApiConnectionActionConfiguration> QRUpdate(Expression<Func<string>> id, Expression<Func<QRUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QRUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/qr/{0}/update", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QRUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRDeleteResponse, ApiConnectionActionConfiguration> QRDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QRDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/qr/{0}/delete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PlanListResponse, ApiConnectionActionConfiguration> PlanList()
        {
            return new DeferredBodyAction<PlanListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/plans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PlanListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PlanSubscribeResponse, ApiConnectionActionConfiguration> PlanSubscribe(Expression<Func<string>> planid, Expression<Func<string>> userid, Expression<Func<PlanSubscribeInput>> body = null)
        {
            var __workflow_planid = WorkflowExpression.Compile(planid, nameof(planid), required: true);
            var __workflow_userid = WorkflowExpression.Compile(userid, nameof(userid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PlanSubscribeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/plan/{0}/user/{1}", __workflow_planid.WithUrlEncoding(1), __workflow_userid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlanSubscribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserListResponse, ApiConnectionActionConfiguration> UserList(Expression<Func<filterInput>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<UserListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserGetResponse, ApiConnectionActionConfiguration> UserGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserCreateResponse, ApiConnectionActionConfiguration> UserCreate(Expression<Func<UserCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserDeleteResponse, ApiConnectionActionConfiguration> UserDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/{0}/delete", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteResponse>(callPayload);
            });
        }
    }

    public class UrlbaeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountGetResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public AccountGetResponseDataType Data { get; set; }
    }

    public class AccountGetResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }
    }

    public class AccountUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class AccountUpdateInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class DomainListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("data")]
        public DomainListResponseDataType Data { get; set; }
    }

    public class DomainListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("domains")]
        public DomainListResponseDataTypeDomainsTypeItem[] Domains { get; set; }
    }

    public class DomainListResponseDataTypeDomainsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("redirectroot")]
        public string Redirectroot { get; set; }

        [JsonProperty("redirect404")]
        public string Redirect404 { get; set; }
    }

    public class DomainCreateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class DomainCreateInput
    {
        [JsonProperty("domain", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Domain { get; set; }

        [JsonProperty("redirectroot")]
        public string Redirectroot { get; set; }

        [JsonProperty("redirect404")]
        public string Redirect404 { get; set; }
    }

    public class DomainUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DomainUpdateInput
    {
        [JsonProperty("redirectroot")]
        public string Redirectroot { get; set; }

        [JsonProperty("redirect404")]
        public string Redirect404 { get; set; }
    }

    public class DomainDeleteResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SplashListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public SplashListResponseDataType Data { get; set; }
    }

    public class SplashListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("splash")]
        public SplashListResponseDataTypeSplashTypeItem[] Splash { get; set; }
    }

    public class SplashListResponseDataTypeSplashTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class CTAListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public CTAListResponseDataType Data { get; set; }
    }

    public class CTAListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("cta")]
        public CTAListResponseDataTypeCtaTypeItem[] Cta { get; set; }
    }

    public class CTAListResponseDataTypeCtaTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class LinkListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("data")]
        public LinkListResponseDataType Data { get; set; }
    }

    public class LinkListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("urls")]
        public LinkListResponseDataTypeUrlsTypeItem[] Urls { get; set; }
    }

    public class LinkListResponseDataTypeUrlsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("shorturl")]
        public string Shorturl { get; set; }

        [JsonProperty("longurl")]
        public string Longurl { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class LinkGetResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("details")]
        public LinkGetResponseDetailsType Details { get; set; }

        [JsonProperty("data")]
        public LinkGetResponseDataType Data { get; set; }
    }

    public class LinkGetResponseDetailsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("shorturl")]
        public string Shorturl { get; set; }

        [JsonProperty("longurl")]
        public string Longurl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public LinkGetResponseDetailsTypeLocationType Location { get; set; }

        [JsonProperty("device")]
        public LinkGetResponseDetailsTypeDeviceType Device { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class LinkGetResponseDetailsTypeLocationType
    {
        [JsonProperty("canada")]
        public string Canada { get; set; }

        [JsonProperty("united states")]
        public string UnitedStates { get; set; }
    }

    public class LinkGetResponseDetailsTypeDeviceType
    {
        [JsonProperty("iphone")]
        public string Iphone { get; set; }

        [JsonProperty("android")]
        public string Android { get; set; }
    }

    public class LinkGetResponseDataType
    {
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("uniqueClicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("topCountries")]
        public int TopCountries { get; set; }

        [JsonProperty("topReferrers")]
        public int TopReferrers { get; set; }

        [JsonProperty("topBrowsers")]
        public int TopBrowsers { get; set; }

        [JsonProperty("topOs")]
        public int TopOs { get; set; }

        [JsonProperty("socialCount")]
        public LinkGetResponseDataTypeSocialCountType SocialCount { get; set; }
    }

    public class LinkGetResponseDataTypeSocialCountType
    {
        [JsonProperty("facebook")]
        public int Facebook { get; set; }

        [JsonProperty("twitter")]
        public int Twitter { get; set; }

        [JsonProperty("google")]
        public int Google { get; set; }
    }

    public class LinkShortenResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("shorturl")]
        public string Shorturl { get; set; }
    }

    public class LinkShortenInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geotarget")]
        public LinkShortenInputGeotargetTypeItem[] Geotarget { get; set; }

        [JsonProperty("devicetarget")]
        public LinkShortenInputDevicetargetTypeItem[] Devicetarget { get; set; }

        [JsonProperty("parameters")]
        public LinkShortenInputParametersTypeItem[] Parameters { get; set; }
    }

    public class LinkShortenInputGeotargetTypeItem
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkShortenInputDevicetargetTypeItem
    {
        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkShortenInputParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }
    }

    public class LinkUpdateInput
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geotarget")]
        public LinkUpdateInputGeotargetTypeItem[] Geotarget { get; set; }

        [JsonProperty("devicetarget")]
        public LinkUpdateInputDevicetargetTypeItem[] Devicetarget { get; set; }

        [JsonProperty("parameters")]
        public LinkUpdateInputParametersTypeItem[] Parameters { get; set; }
    }

    public class LinkUpdateInputGeotargetTypeItem
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkUpdateInputDevicetargetTypeItem
    {
        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkUpdateInputParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class LinkDeleteResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PixelListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public PixelListResponseDataType Data { get; set; }
    }

    public class PixelListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("pixels")]
        public PixelListResponseDataTypePixelsTypeItem[] Pixels { get; set; }
    }

    public class PixelListResponseDataTypePixelsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class PixelCreateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class PixelCreateInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("tag", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Tag { get; set; }
    }

    public class PixelUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PixelUpdateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Tag { get; set; }
    }

    public class PixelDeleteResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class QRListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public QRListResponseDataType Data { get; set; }
    }

    public class QRListResponseDataType
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("perpage")]
        public int Perpage { get; set; }

        [JsonProperty("currentpage")]
        public int Currentpage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("maxpage")]
        public int Maxpage { get; set; }

        [JsonProperty("qrs")]
        public QRListResponseDataTypeQrsTypeItem[] Qrs { get; set; }
    }

    public class QRListResponseDataTypeQrsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("scans")]
        public int Scans { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class QRGetResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("details")]
        public QRGetResponseDetailsType Details { get; set; }

        [JsonProperty("data")]
        public QRGetResponseDataType Data { get; set; }
    }

    public class QRGetResponseDetailsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("scans")]
        public int Scans { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class QRGetResponseDataType
    {
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("uniqueClicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("topCountries")]
        public QRGetResponseDataTypeTopCountriesType TopCountries { get; set; }

        [JsonProperty("topReferrers")]
        public QRGetResponseDataTypeTopReferrersType TopReferrers { get; set; }

        [JsonProperty("topBrowsers")]
        public QRGetResponseDataTypeTopBrowsersType TopBrowsers { get; set; }

        [JsonProperty("topOs")]
        public QRGetResponseDataTypeTopOsType TopOs { get; set; }

        [JsonProperty("socialCount")]
        public QRGetResponseDataTypeSocialCountType SocialCount { get; set; }
    }

    public class QRGetResponseDataTypeTopCountriesType
    {
        public string Unknown { get; set; }
    }

    public class QRGetResponseDataTypeTopReferrersType
    {
        [JsonProperty("Direct, email and other")]
        public string DirectEmailAndOther { get; set; }
    }

    public class QRGetResponseDataTypeTopBrowsersType
    {
        public string Chrome { get; set; }
    }

    public class QRGetResponseDataTypeTopOsType
    {
        [JsonProperty("Windows 10")]
        public string Windows10 { get; set; }
    }

    public class QRGetResponseDataTypeSocialCountType
    {
        [JsonProperty("facebook")]
        public int Facebook { get; set; }

        [JsonProperty("twitter")]
        public int Twitter { get; set; }

        [JsonProperty("instagram")]
        public int Instagram { get; set; }
    }

    public class QRCreateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class QRCreateInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("foreground")]
        public string Foreground { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }

    public class QRUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class QRUpdateInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("foreground")]
        public string Foreground { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }

    public class QRDeleteResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PlanListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public PlanListResponseDataTypeItem[] Data { get; set; }
    }

    public class PlanListResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("free")]
        public bool Free { get; set; }

        [JsonProperty("prices")]
        public string Prices { get; set; }

        [JsonProperty("limits")]
        public PlanListResponseDataTypeItemLimitsType Limits { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsType
    {
        [JsonProperty("links")]
        public int Links { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("retention")]
        public int Retention { get; set; }

        [JsonProperty("custom")]
        public PlanListResponseDataTypeItemLimitsTypeCustomType Custom { get; set; }

        [JsonProperty("team")]
        public PlanListResponseDataTypeItemLimitsTypeTeamType Team { get; set; }

        [JsonProperty("splash")]
        public PlanListResponseDataTypeItemLimitsTypeSplashType Splash { get; set; }

        [JsonProperty("overlay")]
        public PlanListResponseDataTypeItemLimitsTypeOverlayType Overlay { get; set; }

        [JsonProperty("pixels")]
        public PlanListResponseDataTypeItemLimitsTypePixelsType Pixels { get; set; }

        [JsonProperty("domain")]
        public PlanListResponseDataTypeItemLimitsTypeDomainType Domain { get; set; }

        [JsonProperty("multiple")]
        public PlanListResponseDataTypeItemLimitsTypeMultipleType Multiple { get; set; }

        [JsonProperty("alias")]
        public PlanListResponseDataTypeItemLimitsTypeAliasType Alias { get; set; }

        [JsonProperty("device")]
        public PlanListResponseDataTypeItemLimitsTypeDeviceType Device { get; set; }

        [JsonProperty("geo")]
        public PlanListResponseDataTypeItemLimitsTypeGeoType Geo { get; set; }

        [JsonProperty("bundle")]
        public PlanListResponseDataTypeItemLimitsTypeBundleType Bundle { get; set; }

        [JsonProperty("parameters")]
        public PlanListResponseDataTypeItemLimitsTypeParametersType Parameters { get; set; }

        [JsonProperty("export")]
        public PlanListResponseDataTypeItemLimitsTypeExportType Export { get; set; }

        [JsonProperty("api")]
        public PlanListResponseDataTypeItemLimitsTypeApiType Api { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeCustomType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeTeamType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeSplashType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeOverlayType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypePixelsType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeDomainType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeMultipleType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeAliasType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeDeviceType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeGeoType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeBundleType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeParametersType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeExportType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanListResponseDataTypeItemLimitsTypeApiType
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public class PlanSubscribeResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PlanSubscribeInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }
    }

    public class UserListResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public UserListResponseDataTypeItem[] Data { get; set; }
    }

    public class UserListResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("planid")]
        public int Planid { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("apikey")]
        public string Apikey { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterInput
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "pro")]
        Pro
    }

    public class UserGetResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("data")]
        public UserGetResponseDataType Data { get; set; }
    }

    public class UserGetResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("planid")]
        public int Planid { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("apikey")]
        public string Apikey { get; set; }
    }

    public class UserCreateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public UserCreateResponseDataType Data { get; set; }
    }

    public class UserCreateResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class UserCreateInput
    {
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("planid")]
        public int? Planid { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }
    }

    public class UserDeleteResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Urlbaeip;

    public partial class WorkflowManagedActions
    {
        public UrlbaeipActions Urlbaeip(string connectionId) => new UrlbaeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UrlbaeipTriggers Urlbaeip(string connectionId) => new UrlbaeipTriggers(connectionId);
    }
}