//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urlbaeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrlbaeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            var apiCallPath = "/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildAccountUpdate))]
        public IBodyWorkflowAction<AccountUpdateResponse> AccountUpdate([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountUpdateResponse> __BuildAccountUpdate(WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodypassword = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<AccountUpdateResponse>(() =>
            {
                var apiCallPath = "/account/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AccountUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildDomainList))]
        public IBodyWorkflowAction<DomainListResponse> DomainList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainListResponse> __BuildDomainList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<DomainListResponse>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<DomainListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildDomainCreate))]
        public IBodyWorkflowAction<DomainCreateResponse> DomainCreate([WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodyredirectroot = null, [WorkflowExpression] Func<string> bodyredirect404 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainCreateResponse> __BuildDomainCreate(WorkflowExpression<string> bodydomain, WorkflowExpression<string> bodyredirectroot = null, WorkflowExpression<string> bodyredirect404 = null)
        {
            WorkflowExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            WorkflowExpression.Validate(bodyredirectroot, nameof(bodyredirectroot), required: false);
            WorkflowExpression.Validate(bodyredirect404, nameof(bodyredirect404), required: false);
            return new DeferredBodyAction<DomainCreateResponse>(() =>
            {
                var apiCallPath = "/domain/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                if (bodyredirectroot != null)
                {
                    body["redirectroot"] = ExpressionConverter.ConvertO(bodyredirectroot);
                    bodypropCount++;
                }

                if (bodyredirect404 != null)
                {
                    body["redirect404"] = ExpressionConverter.ConvertO(bodyredirect404);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DomainCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildDomainUpdate))]
        public IBodyWorkflowAction<DomainUpdateResponse> DomainUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyredirectroot = null, [WorkflowExpression] Func<string> bodyredirect404 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainUpdateResponse> __BuildDomainUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodyredirectroot = null, WorkflowExpression<string> bodyredirect404 = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyredirectroot, nameof(bodyredirectroot), required: false);
            WorkflowExpression.Validate(bodyredirect404, nameof(bodyredirect404), required: false);
            return new DeferredBodyAction<DomainUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domain/{0}/update", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyredirectroot != null)
                {
                    body["redirectroot"] = ExpressionConverter.ConvertO(bodyredirectroot);
                    bodypropCount++;
                }

                if (bodyredirect404 != null)
                {
                    body["redirect404"] = ExpressionConverter.ConvertO(bodyredirect404);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DomainUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildDomainDelete))]
        public IBodyWorkflowAction<DomainDeleteResponse> DomainDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainDeleteResponse> __BuildDomainDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<DomainDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domain/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DomainDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildSplashList))]
        public IBodyWorkflowAction<SplashListResponse> SplashList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SplashListResponse> __BuildSplashList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<SplashListResponse>(() =>
            {
                var apiCallPath = "/splash";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<SplashListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildCTAList))]
        public IBodyWorkflowAction<CTAListResponse> CTAList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CTAListResponse> __BuildCTAList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<CTAListResponse>(() =>
            {
                var apiCallPath = "/overlay";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<CTAListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkList))]
        public IBodyWorkflowAction<LinkListResponse> LinkList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> order = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkListResponse> __BuildLinkList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> order = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            return new DeferredBodyAction<LinkListResponse>(() =>
            {
                var apiCallPath = "/urls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                return new ApiConnectionAction<LinkListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkGet))]
        public IBodyWorkflowAction<LinkGetResponse> LinkGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkGetResponse> __BuildLinkGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LinkGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/url/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinkGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkShorten))]
        public IBodyWorkflowAction<LinkShortenResponse> LinkShorten([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodycustom = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodygeotargetInputItem[]> bodygeotarget = null, [WorkflowExpression] Func<bodydevicetargetInputItem[]> bodydevicetarget = null, [WorkflowExpression] Func<bodyparametersInputItem[]> bodyparameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkShortenResponse> __BuildLinkShorten(WorkflowExpression<string> bodyurl, WorkflowExpression<string> bodycustom = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodyexpiry = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<bodygeotargetInputItem[]> bodygeotarget = null, WorkflowExpression<bodydevicetargetInputItem[]> bodydevicetarget = null, WorkflowExpression<bodyparametersInputItem[]> bodyparameters = null)
        {
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowExpression.Validate(bodycustom, nameof(bodycustom), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodyexpiry, nameof(bodyexpiry), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodygeotarget, nameof(bodygeotarget), required: false);
            WorkflowExpression.Validate(bodydevicetarget, nameof(bodydevicetarget), required: false);
            WorkflowExpression.Validate(bodyparameters, nameof(bodyparameters), required: false);
            return new DeferredBodyAction<LinkShortenResponse>(() =>
            {
                var apiCallPath = "/url/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodycustom != null)
                {
                    body["custom"] = ExpressionConverter.ConvertO(bodycustom);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodyexpiry != null)
                {
                    body["expiry"] = ExpressionConverter.ConvertO(bodyexpiry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodygeotarget != null)
                {
                    body["geotarget"] = ExpressionConverter.ConvertO(bodygeotarget);
                    bodypropCount++;
                }

                if (bodydevicetarget != null)
                {
                    body["devicetarget"] = ExpressionConverter.ConvertO(bodydevicetarget);
                    bodypropCount++;
                }

                if (bodyparameters != null)
                {
                    body["parameters"] = ExpressionConverter.ConvertO(bodyparameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkShortenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkUpdate))]
        public IBodyWorkflowAction<LinkUpdateResponse> LinkUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodycustom = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodygeotargetInputItem[]> bodygeotarget = null, [WorkflowExpression] Func<bodydevicetargetInputItem[]> bodydevicetarget = null, [WorkflowExpression] Func<bodyparametersInputItem[]> bodyparameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkUpdateResponse> __BuildLinkUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodyurl = null, WorkflowExpression<string> bodycustom = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodyexpiry = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<bodygeotargetInputItem[]> bodygeotarget = null, WorkflowExpression<bodydevicetargetInputItem[]> bodydevicetarget = null, WorkflowExpression<bodyparametersInputItem[]> bodyparameters = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowExpression.Validate(bodycustom, nameof(bodycustom), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodyexpiry, nameof(bodyexpiry), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodygeotarget, nameof(bodygeotarget), required: false);
            WorkflowExpression.Validate(bodydevicetarget, nameof(bodydevicetarget), required: false);
            WorkflowExpression.Validate(bodyparameters, nameof(bodyparameters), required: false);
            return new DeferredBodyAction<LinkUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/url/{0}/update", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodycustom != null)
                {
                    body["custom"] = ExpressionConverter.ConvertO(bodycustom);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodyexpiry != null)
                {
                    body["expiry"] = ExpressionConverter.ConvertO(bodyexpiry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodygeotarget != null)
                {
                    body["geotarget"] = ExpressionConverter.ConvertO(bodygeotarget);
                    bodypropCount++;
                }

                if (bodydevicetarget != null)
                {
                    body["devicetarget"] = ExpressionConverter.ConvertO(bodydevicetarget);
                    bodypropCount++;
                }

                if (bodyparameters != null)
                {
                    body["parameters"] = ExpressionConverter.ConvertO(bodyparameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildLinkDelete))]
        public IBodyWorkflowAction<LinkDeleteResponse> LinkDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkDeleteResponse> __BuildLinkDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LinkDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/url/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LinkDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildPixelList))]
        public IBodyWorkflowAction<PixelListResponse> PixelList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelListResponse> __BuildPixelList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<PixelListResponse>(() =>
            {
                var apiCallPath = "/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<PixelListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildPixelCreate))]
        public IBodyWorkflowAction<PixelCreateResponse> PixelCreate([WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytag)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelCreateResponse> __BuildPixelCreate(WorkflowExpression<string> bodytype, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodytag)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: true);
            return new DeferredBodyAction<PixelCreateResponse>(() =>
            {
                var apiCallPath = "/pixel/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildPixelUpdate))]
        public IBodyWorkflowAction<PixelUpdateResponse> PixelUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytag, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelUpdateResponse> __BuildPixelUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodytag, WorkflowExpression<string> bodyname = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<PixelUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pixel/{0}/update", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildPixelDelete))]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelDeleteResponse> __BuildPixelDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PixelDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pixel/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildQRList))]
        public IBodyWorkflowAction<QRListResponse> QRList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRListResponse> __BuildQRList(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<QRListResponse>(() =>
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<QRListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildQRGet))]
        public IBodyWorkflowAction<QRGetResponse> QRGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRGetResponse> __BuildQRGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<QRGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/qr/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildQRCreate))]
        public IBodyWorkflowAction<QRCreateResponse> QRCreate([WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodybackground = null, [WorkflowExpression] Func<string> bodyforeground = null, [WorkflowExpression] Func<string> bodylogo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRCreateResponse> __BuildQRCreate(WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodydata = null, WorkflowExpression<string> bodybackground = null, WorkflowExpression<string> bodyforeground = null, WorkflowExpression<string> bodylogo = null)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: false);
            WorkflowExpression.Validate(bodybackground, nameof(bodybackground), required: false);
            WorkflowExpression.Validate(bodyforeground, nameof(bodyforeground), required: false);
            WorkflowExpression.Validate(bodylogo, nameof(bodylogo), required: false);
            return new DeferredBodyAction<QRCreateResponse>(() =>
            {
                var apiCallPath = "/qr/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = ExpressionConverter.ConvertO(bodydata);
                    bodypropCount++;
                }

                if (bodybackground != null)
                {
                    body["background"] = ExpressionConverter.ConvertO(bodybackground);
                    bodypropCount++;
                }

                if (bodyforeground != null)
                {
                    body["foreground"] = ExpressionConverter.ConvertO(bodyforeground);
                    bodypropCount++;
                }

                if (bodylogo != null)
                {
                    body["logo"] = ExpressionConverter.ConvertO(bodylogo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QRCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildQRUpdate))]
        public IBodyWorkflowAction<QRUpdateResponse> QRUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodybackground = null, [WorkflowExpression] Func<string> bodyforeground = null, [WorkflowExpression] Func<string> bodylogo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRUpdateResponse> __BuildQRUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodydata, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodybackground = null, WorkflowExpression<string> bodyforeground = null, WorkflowExpression<string> bodylogo = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodybackground, nameof(bodybackground), required: false);
            WorkflowExpression.Validate(bodyforeground, nameof(bodyforeground), required: false);
            WorkflowExpression.Validate(bodylogo, nameof(bodylogo), required: false);
            return new DeferredBodyAction<QRUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/qr/{0}/update", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodybackground != null)
                {
                    body["background"] = ExpressionConverter.ConvertO(bodybackground);
                    bodypropCount++;
                }

                if (bodyforeground != null)
                {
                    body["foreground"] = ExpressionConverter.ConvertO(bodyforeground);
                    bodypropCount++;
                }

                if (bodylogo != null)
                {
                    body["logo"] = ExpressionConverter.ConvertO(bodylogo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QRUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildQRDelete))]
        public IBodyWorkflowAction<QRDeleteResponse> QRDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QRDeleteResponse> __BuildQRDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<QRDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/qr/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PlanListResponse> PlanList()
        {
            var apiCallPath = "/plans";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PlanListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildPlanSubscribe))]
        public IBodyWorkflowAction<PlanSubscribeResponse> PlanSubscribe([WorkflowExpression] Func<string> planid, [WorkflowExpression] Func<string> userid, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyexpiration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PlanSubscribeResponse> __BuildPlanSubscribe(WorkflowExpression<string> planid, WorkflowExpression<string> userid, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodyexpiration = null)
        {
            WorkflowExpression.Validate(planid, nameof(planid), required: true);
            WorkflowExpression.Validate(userid, nameof(userid), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            return new DeferredBodyAction<PlanSubscribeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/plan/{0}/user/{1}", ExpressionConverter.ConvertWithUrlEncoding(planid, 1), ExpressionConverter.ConvertWithUrlEncoding(userid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PlanSubscribeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildUserList))]
        public IBodyWorkflowAction<UserListResponse> UserList([WorkflowExpression] Func<filterInput> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserListResponse> __BuildUserList(WorkflowExpression<filterInput> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<UserListResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<UserListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildUserGet))]
        public IBodyWorkflowAction<UserGetResponse> UserGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserGetResponse> __BuildUserGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<UserGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildUserCreate))]
        public IBodyWorkflowAction<UserCreateResponse> UserCreate([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<int> bodyplanid = null, [WorkflowExpression] Func<string> bodyexpiration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserCreateResponse> __BuildUserCreate(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodypassword, WorkflowExpression<string> bodyemail, WorkflowExpression<int> bodyplanid = null, WorkflowExpression<string> bodyexpiration = null)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyplanid, nameof(bodyplanid), required: false);
            WorkflowExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            return new DeferredBodyAction<UserCreateResponse>(() =>
            {
                var apiCallPath = "/user/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyplanid != null)
                {
                    body["planid"] = ExpressionConverter.ConvertO(bodyplanid);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        [WorkflowExpressionFactory(nameof(__BuildUserDelete))]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDeleteResponse> __BuildUserDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<UserDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/{0}/delete", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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

    public class DomainUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class bodygeotargetInputItem
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class bodydevicetargetInputItem
    {
        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class bodyparametersInputItem
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

    public class PixelUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class QRUpdateResponse
    {
        [JsonProperty("error")]
        public int Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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