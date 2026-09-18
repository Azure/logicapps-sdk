//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Urlbaeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UrlbaeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<AccountUpdateResponse> AccountUpdate([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AccountUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainListResponse> DomainList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<DomainListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainCreateResponse> DomainCreate([WorkflowExpression] Func<string> bodydomain, [WorkflowExpression] Func<string> bodyredirectroot = null, [WorkflowExpression] Func<string> bodyredirect404 = null)
        {
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: true);
            SourceExpression.Validate(bodyredirectroot, nameof(bodyredirectroot), required: false);
            SourceExpression.Validate(bodyredirect404, nameof(bodyredirect404), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domain/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                if (bodyredirectroot != null)
                {
                    body["redirectroot"] = SourceExpressionConverter.ConvertToken(bodyredirectroot);
                    bodypropCount++;
                }

                if (bodyredirect404 != null)
                {
                    body["redirect404"] = SourceExpressionConverter.ConvertToken(bodyredirect404);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DomainCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainUpdateResponse> DomainUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyredirectroot = null, [WorkflowExpression] Func<string> bodyredirect404 = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyredirectroot, nameof(bodyredirectroot), required: false);
            SourceExpression.Validate(bodyredirect404, nameof(bodyredirect404), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domain/{0}/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyredirectroot != null)
                {
                    body["redirectroot"] = SourceExpressionConverter.ConvertToken(bodyredirectroot);
                    bodypropCount++;
                }

                if (bodyredirect404 != null)
                {
                    body["redirect404"] = SourceExpressionConverter.ConvertToken(bodyredirect404);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DomainUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<DomainDeleteResponse> DomainDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domain/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DomainDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<SplashListResponse> SplashList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/splash";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<SplashListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<CTAListResponse> CTAList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/overlay";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<CTAListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkListResponse> LinkList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> order = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(order, nameof(order), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/urls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.ConvertO(order);
                return callPayload;
            }

            return new ApiConnectionAction<LinkListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkGetResponse> LinkGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/url/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LinkGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkShortenResponse> LinkShorten([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string> bodycustom = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodygeotargetInputItem[]> bodygeotarget = null, [WorkflowExpression] Func<bodydevicetargetInputItem[]> bodydevicetarget = null, [WorkflowExpression] Func<bodyparametersInputItem[]> bodyparameters = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodycustom, nameof(bodycustom), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyexpiry, nameof(bodyexpiry), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodygeotarget, nameof(bodygeotarget), required: false);
            SourceExpression.Validate(bodydevicetarget, nameof(bodydevicetarget), required: false);
            SourceExpression.Validate(bodyparameters, nameof(bodyparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/url/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodycustom != null)
                {
                    body["custom"] = SourceExpressionConverter.ConvertToken(bodycustom);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyexpiry != null)
                {
                    body["expiry"] = SourceExpressionConverter.ConvertToken(bodyexpiry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodygeotarget != null)
                {
                    body["geotarget"] = SourceExpressionConverter.ConvertToken(bodygeotarget);
                    bodypropCount++;
                }

                if (bodydevicetarget != null)
                {
                    body["devicetarget"] = SourceExpressionConverter.ConvertToken(bodydevicetarget);
                    bodypropCount++;
                }

                if (bodyparameters != null)
                {
                    body["parameters"] = SourceExpressionConverter.ConvertToken(bodyparameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkShortenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkUpdateResponse> LinkUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodycustom = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyexpiry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodygeotargetInputItem[]> bodygeotarget = null, [WorkflowExpression] Func<bodydevicetargetInputItem[]> bodydevicetarget = null, [WorkflowExpression] Func<bodyparametersInputItem[]> bodyparameters = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodycustom, nameof(bodycustom), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyexpiry, nameof(bodyexpiry), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodygeotarget, nameof(bodygeotarget), required: false);
            SourceExpression.Validate(bodydevicetarget, nameof(bodydevicetarget), required: false);
            SourceExpression.Validate(bodyparameters, nameof(bodyparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/url/{0}/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodycustom != null)
                {
                    body["custom"] = SourceExpressionConverter.ConvertToken(bodycustom);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyexpiry != null)
                {
                    body["expiry"] = SourceExpressionConverter.ConvertToken(bodyexpiry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodygeotarget != null)
                {
                    body["geotarget"] = SourceExpressionConverter.ConvertToken(bodygeotarget);
                    bodypropCount++;
                }

                if (bodydevicetarget != null)
                {
                    body["devicetarget"] = SourceExpressionConverter.ConvertToken(bodydevicetarget);
                    bodypropCount++;
                }

                if (bodyparameters != null)
                {
                    body["parameters"] = SourceExpressionConverter.ConvertToken(bodyparameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<LinkDeleteResponse> LinkDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/url/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LinkDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelListResponse> PixelList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<PixelListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelCreateResponse> PixelCreate([WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytag)
        {
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytag, nameof(bodytag), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pixel/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelUpdateResponse> PixelUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytag, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytag, nameof(bodytag), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pixel/{0}/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                bodypropCount++;
                body["tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PixelDeleteResponse> PixelDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pixel/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PixelDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRListResponse> QRList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/qr";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<QRListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRGetResponse> QRGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/qr/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QRGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRCreateResponse> QRCreate([WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodybackground = null, [WorkflowExpression] Func<string> bodyforeground = null, [WorkflowExpression] Func<string> bodylogo = null)
        {
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            SourceExpression.Validate(bodybackground, nameof(bodybackground), required: false);
            SourceExpression.Validate(bodyforeground, nameof(bodyforeground), required: false);
            SourceExpression.Validate(bodylogo, nameof(bodylogo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/qr/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodybackground != null)
                {
                    body["background"] = SourceExpressionConverter.ConvertToken(bodybackground);
                    bodypropCount++;
                }

                if (bodyforeground != null)
                {
                    body["foreground"] = SourceExpressionConverter.ConvertToken(bodyforeground);
                    bodypropCount++;
                }

                if (bodylogo != null)
                {
                    body["logo"] = SourceExpressionConverter.ConvertToken(bodylogo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QRCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRUpdateResponse> QRUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodybackground = null, [WorkflowExpression] Func<string> bodyforeground = null, [WorkflowExpression] Func<string> bodylogo = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodybackground, nameof(bodybackground), required: false);
            SourceExpression.Validate(bodyforeground, nameof(bodyforeground), required: false);
            SourceExpression.Validate(bodylogo, nameof(bodylogo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/qr/{0}/update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodybackground != null)
                {
                    body["background"] = SourceExpressionConverter.ConvertToken(bodybackground);
                    bodypropCount++;
                }

                if (bodyforeground != null)
                {
                    body["foreground"] = SourceExpressionConverter.ConvertToken(bodyforeground);
                    bodypropCount++;
                }

                if (bodylogo != null)
                {
                    body["logo"] = SourceExpressionConverter.ConvertToken(bodylogo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QRUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<QRDeleteResponse> QRDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/qr/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QRDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PlanListResponse> PlanList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/plans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlanListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<PlanSubscribeResponse> PlanSubscribe([WorkflowExpression] Func<string> planid, [WorkflowExpression] Func<string> userid, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyexpiration = null)
        {
            SourceExpression.Validate(planid, nameof(planid), required: true);
            SourceExpression.Validate(userid, nameof(userid), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/plan/{0}/user/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlanSubscribeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserListResponse> UserList([WorkflowExpression] Func<filterInput> filter = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                return callPayload;
            }

            return new ApiConnectionAction<UserListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserGetResponse> UserGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserCreateResponse> UserCreate([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<int> bodyplanid = null, [WorkflowExpression] Func<string> bodyexpiration = null)
        {
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyplanid, nameof(bodyplanid), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodyplanid != null)
                {
                    body["planid"] = SourceExpressionConverter.ConvertToken(bodyplanid);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "urlbaeip")]
        public IBodyWorkflowAction<UserDeleteResponse> UserDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/{0}/delete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDeleteResponse>(BuildSourceInput);
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