//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Glaasspro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GlaassproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<AccountResponse, ApiConnectionActionConfiguration> AccountGet()
        {
            return new DeferredBodyAction<AccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<TemplateResponse[], ApiConnectionActionConfiguration> CaseTypeGetList()
        {
            return new DeferredBodyAction<TemplateResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/s";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserListResponse[], ApiConnectionActionConfiguration> UserGetAll()
        {
            return new DeferredBodyAction<UserListResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/u";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserListResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> User(Expression<Func<string>> requestemail, Expression<Func<string>> requestfirstName, Expression<Func<string>> requestlastName, Expression<Func<bool>> requestisAdmin, Expression<Func<bool>> requestisReadOnly, Expression<Func<bool>> requestisDocumentController, Expression<Func<bool>> requestisFolderController, Expression<Func<bool>> requestisManagerial, Expression<Func<string>> requestcompany = null, Expression<Func<string>> requestposition = null, Expression<Func<string>> requestphone = null)
        {
            var __workflow_requestemail = WorkflowExpression.Compile(requestemail, nameof(requestemail), required: true);
            var __workflow_requestfirstName = WorkflowExpression.Compile(requestfirstName, nameof(requestfirstName), required: true);
            var __workflow_requestlastName = WorkflowExpression.Compile(requestlastName, nameof(requestlastName), required: true);
            var __workflow_requestisAdmin = WorkflowExpression.Compile(requestisAdmin, nameof(requestisAdmin), required: true);
            var __workflow_requestisReadOnly = WorkflowExpression.Compile(requestisReadOnly, nameof(requestisReadOnly), required: true);
            var __workflow_requestisDocumentController = WorkflowExpression.Compile(requestisDocumentController, nameof(requestisDocumentController), required: true);
            var __workflow_requestisFolderController = WorkflowExpression.Compile(requestisFolderController, nameof(requestisFolderController), required: true);
            var __workflow_requestisManagerial = WorkflowExpression.Compile(requestisManagerial, nameof(requestisManagerial), required: true);
            var __workflow_requestcompany = WorkflowExpression.Compile(requestcompany, nameof(requestcompany), required: false);
            var __workflow_requestposition = WorkflowExpression.Compile(requestposition, nameof(requestposition), required: false);
            var __workflow_requestphone = WorkflowExpression.Compile(requestphone, nameof(requestphone), required: false);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/u";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Email"] = ExpressionConverter.ConvertO(__workflow_requestemail);
                requestpropCount++;
                request["FirstName"] = ExpressionConverter.ConvertO(__workflow_requestfirstName);
                requestpropCount++;
                request["LastName"] = ExpressionConverter.ConvertO(__workflow_requestlastName);
                if (__workflow_requestcompany != null)
                {
                    request["Company"] = ExpressionConverter.ConvertO(__workflow_requestcompany);
                    requestpropCount++;
                }

                if (__workflow_requestposition != null)
                {
                    request["Position"] = ExpressionConverter.ConvertO(__workflow_requestposition);
                    requestpropCount++;
                }

                if (__workflow_requestphone != null)
                {
                    request["Phone"] = ExpressionConverter.ConvertO(__workflow_requestphone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["IsAdmin"] = ExpressionConverter.ConvertO(__workflow_requestisAdmin);
                requestpropCount++;
                request["IsReadOnly"] = ExpressionConverter.ConvertO(__workflow_requestisReadOnly);
                requestpropCount++;
                request["IsDocumentController"] = ExpressionConverter.ConvertO(__workflow_requestisDocumentController);
                requestpropCount++;
                request["IsFolderController"] = ExpressionConverter.ConvertO(__workflow_requestisFolderController);
                requestpropCount++;
                request["IsManagerial"] = ExpressionConverter.ConvertO(__workflow_requestisManagerial);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> UserGet(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/u/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> UserPost2(Expression<Func<string>> userId, Expression<Func<bool>> requestactive)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_requestactive = WorkflowExpression.Compile(requestactive, nameof(requestactive), required: true);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/u/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Active"] = ExpressionConverter.ConvertO(__workflow_requestactive);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataListResponse[], ApiConnectionActionConfiguration> MetadataGetAll()
        {
            return new DeferredBodyAction<MetadataListResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/m";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MetadataListResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataResponse, ApiConnectionActionConfiguration> MetadataGet(Expression<Func<string>> metadataId)
        {
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            return new DeferredBodyAction<MetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/m/{0}", __workflow_metadataId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse[], ApiConnectionActionConfiguration> MetadataGetSwitches(Expression<Func<string>> metadataId)
        {
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            return new DeferredBodyAction<MetadataSwitchResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/m/{0}/switch", __workflow_metadataId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MetadataSwitchResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse, ApiConnectionActionConfiguration> MetadataPostSwitch(Expression<Func<string>> metadataId, Expression<Func<string>> requestlabel)
        {
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            var __workflow_requestlabel = WorkflowExpression.Compile(requestlabel, nameof(requestlabel), required: true);
            return new DeferredBodyAction<MetadataSwitchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/m/{0}/switch", __workflow_metadataId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Label"] = ExpressionConverter.ConvertO(__workflow_requestlabel);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<MetadataSwitchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse[], ApiConnectionActionConfiguration> MetadataPutSwitches(Expression<Func<string>> metadataId, Expression<Func<switchesInputItem[]>> switches = null)
        {
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            var __workflow_switches = WorkflowExpression.Compile(switches, nameof(switches), required: false);
            return new DeferredBodyAction<MetadataSwitchResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/m/{0}/switch", __workflow_metadataId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_switches);
                return new ApiConnectionAction<MetadataSwitchResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse, ApiConnectionActionConfiguration> MetadataPutSwitch(Expression<Func<string>> metadataId, Expression<Func<string>> switchId, Expression<Func<string>> requestlabel)
        {
            var __workflow_metadataId = WorkflowExpression.Compile(metadataId, nameof(metadataId), required: true);
            var __workflow_switchId = WorkflowExpression.Compile(switchId, nameof(switchId), required: true);
            var __workflow_requestlabel = WorkflowExpression.Compile(requestlabel, nameof(requestlabel), required: true);
            return new DeferredBodyAction<MetadataSwitchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/m/{0}/switch/{1}", __workflow_metadataId.WithUrlEncoding(1), __workflow_switchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Label"] = ExpressionConverter.ConvertO(__workflow_requestlabel);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<MetadataSwitchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<SearchResponse[], ApiConnectionActionConfiguration> SearchGet(Expression<Func<string>> query, Expression<Func<filterInput>> filter = null, Expression<Func<int>> take = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            return new DeferredBodyAction<SearchResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/q";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                return new ApiConnectionAction<SearchResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseResponse, ApiConnectionActionConfiguration> CaseGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/c/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseFieldsResponse, ApiConnectionActionConfiguration> CaseFieldGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/c/{0}/fields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> CasePrint(Expression<Func<string>> id, Expression<Func<bool>> bodyuseCustom = null, Expression<Func<bodydisplayGalleryInput>> bodydisplayGallery = null, Expression<Func<bodydisplayTextInput>> bodydisplayText = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyuseCustom = WorkflowExpression.Compile(bodyuseCustom, nameof(bodyuseCustom), required: false);
            var __workflow_bodydisplayGallery = WorkflowExpression.Compile(bodydisplayGallery, nameof(bodydisplayGallery), required: false);
            var __workflow_bodydisplayText = WorkflowExpression.Compile(bodydisplayText, nameof(bodydisplayText), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/c/{0}/print", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuseCustom != null)
                {
                    body["UseCustom"] = ExpressionConverter.ConvertO(__workflow_bodyuseCustom);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayGallery != null)
                {
                    body["DisplayGallery"] = ExpressionConverter.ConvertO(__workflow_bodydisplayGallery);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayText != null)
                {
                    body["DisplayText"] = ExpressionConverter.ConvertO(__workflow_bodydisplayText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse, ApiConnectionActionConfiguration> CaseReplyGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/c/{0}/reply", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse, ApiConnectionActionConfiguration> CaseReply(Expression<Func<string>> id, Expression<Func<string>> bodymessage, Expression<Func<bool>> bodywithoutNotification)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodywithoutNotification = WorkflowExpression.Compile(bodywithoutNotification, nameof(bodywithoutNotification), required: true);
            return new DeferredBodyAction<CaseReplyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/c/{0}/reply", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                bodypropCount++;
                body["WithoutNotification"] = ExpressionConverter.ConvertO(__workflow_bodywithoutNotification);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CaseReplyResponse>(callPayload);
            });
        }
    }

    public class GlaassproTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CaseCreatedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/t/casecreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CaseUpdatedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/t/caseupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CaseClosedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = WorkflowExpression.Compile(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/t/caseclosed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(__workflow_bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MetadataCreatedTrigger(Expression<Func<string>> requestmetadataId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestmetadataId = WorkflowExpression.Compile(requestmetadataId, nameof(requestmetadataId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/mt/metadatacreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmetadataId != null)
                {
                    request["MetadataId"] = ExpressionConverter.ConvertO(__workflow_requestmetadataId);
                    requestpropCount++;
                }

                request["Notification"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MetadataUpdatedTrigger(Expression<Func<string>> requestmetadataId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestmetadataId = WorkflowExpression.Compile(requestmetadataId, nameof(requestmetadataId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/mt/metadataupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmetadataId != null)
                {
                    request["MetadataId"] = ExpressionConverter.ConvertO(__workflow_requestmetadataId);
                    requestpropCount++;
                }

                request["Notification"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AccountResponse
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProjectLink { get; set; }
    }

    public class TemplateResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
    }

    public class UserListResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool Active { get; set; }
        public bool Pending { get; set; }
        public bool SsoLogin { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDocumentController { get; set; }
        public bool IsFolderController { get; set; }
        public bool IsManagerial { get; set; }
        public bool IsReadOnly { get; set; }
    }

    public class UserResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool Active { get; set; }
        public bool Pending { get; set; }
        public bool SsoLogin { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDocumentController { get; set; }
        public bool IsFolderController { get; set; }
        public bool IsManagerial { get; set; }
        public bool IsReadOnly { get; set; }
        public string ApplicationUrl { get; set; }
    }

    public class MetadataListResponse
    {
        public string MetadataId { get; set; }
        public string Name { get; set; }
        public string FieldType { get; set; }
    }

    public class MetadataResponse
    {
        public string MetadataId { get; set; }
        public string Name { get; set; }
        public string FieldType { get; set; }
        public bool Active { get; set; }
        public bool Analytics { get; set; }
        public bool Register { get; set; }
        public string ControlType { get; set; }
        public MetadataSwitchResponse[] Switches { get; set; }
        public string ApplicationLink { get; set; }
    }

    public class MetadataSwitchResponse
    {
        public string Id { get; set; }
        public string Label { get; set; }
    }

    public class switchesInputItem
    {
        public string Id { get; set; }
        public string Label { get; set; }
    }

    public class SearchResponse
    {
        public string SearchType { get; set; }
        public string ItemId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public string ApplicationLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterInput
    {
        Location,
        Company,
        Case,
        User,
        Group
    }

    public class CaseResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string CaseId { get; set; }
        public string Revision { get; set; }
        public CaseCreatedByUserResponse CreatedBy { get; set; }
        public string Status { get; set; }
        public string CreatedAtUtc { get; set; }
        public string CreatedAtLocal { get; set; }
        public string ApplicationLink { get; set; }
    }

    public class CaseCreatedByUserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CaseFieldsResponse
    {
        public string Id { get; set; }
        public CaseFieldSectionsResponse[] Sections { get; set; }
    }

    public class CaseFieldSectionsResponse
    {
        public string SectionId { get; set; }
        public CaseFieldsFieldResponse[] Fields { get; set; }
    }

    public class CaseFieldsFieldResponse
    {
        public string FieldId { get; set; }
        public string FieldLabel { get; set; }
        public JToken Value { get; set; }
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydisplayGalleryInput
    {
        Gallery,
        List
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydisplayTextInput
    {
        Beside,
        Below
    }

    public class CaseReplyResponse
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public ProjectUserResponse[] RecipientsTo { get; set; }
        public ProjectUserResponse[] RecipientsCc { get; set; }
    }

    public class ProjectUserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyscopeInput
    {
        ByMe,
        ForMe,
        All
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Glaasspro;

    public partial class WorkflowManagedActions
    {
        public GlaassproActions Glaasspro(string connectionId) => new GlaassproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GlaassproTriggers Glaasspro(string connectionId) => new GlaassproTriggers(connectionId);
    }
}