//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Glaasspro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GlaassproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<AccountResponse> AccountGet()
        {
            var apiCallPath = "/api/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<TemplateResponse[]> CaseTypeGetList()
        {
            var apiCallPath = "/api/s";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<SearchResponse[]> SearchGet(Expression<Func<string>> query, Expression<Func<filterInput>> filter = null, Expression<Func<int>> take = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_take = take == null ? null : WorkflowExpression.Compile(take);
            WorkflowExpression.Validate(__workflow_take, nameof(take), required: false);
            return new DeferredBodyAction<SearchResponse[]>(() =>
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
        public IBodyWorkflowAction<CaseResponse> CaseGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CaseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseFieldsResponse> CaseFieldGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CaseFieldsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object> CasePrint(Expression<Func<string>> id, Expression<Func<bool>> bodyasynchronous = null, Expression<Func<bool>> bodyuseCustom = null, Expression<Func<bodydisplayGalleryInput>> bodydisplayGallery = null, Expression<Func<bodydisplayTextInput>> bodydisplayText = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyasynchronous = bodyasynchronous == null ? null : WorkflowExpression.Compile(bodyasynchronous);
            WorkflowExpression.Validate(__workflow_bodyasynchronous, nameof(bodyasynchronous), required: false);
            var __workflow_bodyuseCustom = bodyuseCustom == null ? null : WorkflowExpression.Compile(bodyuseCustom);
            WorkflowExpression.Validate(__workflow_bodyuseCustom, nameof(bodyuseCustom), required: false);
            var __workflow_bodydisplayGallery = bodydisplayGallery == null ? null : WorkflowExpression.Compile(bodydisplayGallery);
            WorkflowExpression.Validate(__workflow_bodydisplayGallery, nameof(bodydisplayGallery), required: false);
            var __workflow_bodydisplayText = bodydisplayText == null ? null : WorkflowExpression.Compile(bodydisplayText);
            WorkflowExpression.Validate(__workflow_bodydisplayText, nameof(bodydisplayText), required: false);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyasynchronous != null)
                {
                    body["Asynchronous"] = ExpressionConverter.ConvertO(__workflow_bodyasynchronous);
                    bodypropCount++;
                }

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
        public IBodyWorkflowAction<object> CasePrintGet(Expression<Func<string>> id, Expression<Func<string>> requestId)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyGet(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CaseReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReply(Expression<Func<string>> id, Expression<Func<bool>> bodywithoutNotification, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodywithoutNotification = bodywithoutNotification == null ? null : WorkflowExpression.Compile(bodywithoutNotification);
            WorkflowExpression.Validate(__workflow_bodywithoutNotification, nameof(bodywithoutNotification), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<CaseReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

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
        public IWorkflowTrigger CaseCreatedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = bodyscope == null ? null : WorkflowExpression.Compile(bodyscope);
            WorkflowExpression.Validate(__workflow_bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
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

        public IWorkflowTrigger CaseUpdatedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = bodyscope == null ? null : WorkflowExpression.Compile(bodyscope);
            WorkflowExpression.Validate(__workflow_bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
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

        public IWorkflowTrigger CaseClosedTrigger(Expression<Func<string>> bodytemplateId = null, Expression<Func<bodyscopeInput>> bodyscope = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyscope = bodyscope == null ? null : WorkflowExpression.Compile(bodyscope);
            WorkflowExpression.Validate(__workflow_bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
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

    public class SearchResponse
    {
        public string SearchType { get; set; }
        public string ItemId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
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
        public ProjectUserResponse CreatedBy { get; set; }
        public string Status { get; set; }
        public string CreatedAtUtc { get; set; }
        public string CreatedAtLocal { get; set; }
    }

    public class ProjectUserResponse
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
