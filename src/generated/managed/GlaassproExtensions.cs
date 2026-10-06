//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Glaasspro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildSearchGet))]
        public IBodyWorkflowAction<SearchResponse[]> SearchGet([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<int> take = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse[]> __BuildSearchGet(WorkflowExpression<string> query, WorkflowExpression<filterInput> filter = null, WorkflowExpression<int> take = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(take, nameof(take), required: false);
            return new DeferredBodyAction<SearchResponse[]>(() =>
            {
                var apiCallPath = "/api/q";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(take);
                return new ApiConnectionAction<SearchResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [WorkflowExpressionFactory(nameof(__BuildCaseGet))]
        public IBodyWorkflowAction<CaseResponse> CaseGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CaseResponse> __BuildCaseGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [WorkflowExpressionFactory(nameof(__BuildCaseFieldGet))]
        public IBodyWorkflowAction<CaseFieldsResponse> CaseFieldGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CaseFieldsResponse> __BuildCaseFieldGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseFieldsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [WorkflowExpressionFactory(nameof(__BuildCasePrint))]
        public IBodyWorkflowAction<object> CasePrint([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodyasynchronous = null, [WorkflowExpression] Func<bool> bodyuseCustom = null, [WorkflowExpression] Func<bodydisplayGalleryInput> bodydisplayGallery = null, [WorkflowExpression] Func<bodydisplayTextInput> bodydisplayText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildCasePrint(WorkflowExpression<string> id, WorkflowExpression<bool> bodyasynchronous = null, WorkflowExpression<bool> bodyuseCustom = null, WorkflowExpression<bodydisplayGalleryInput> bodydisplayGallery = null, WorkflowExpression<bodydisplayTextInput> bodydisplayText = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyasynchronous, nameof(bodyasynchronous), required: false);
            WorkflowExpression.Validate(bodyuseCustom, nameof(bodyuseCustom), required: false);
            WorkflowExpression.Validate(bodydisplayGallery, nameof(bodydisplayGallery), required: false);
            WorkflowExpression.Validate(bodydisplayText, nameof(bodydisplayText), required: false);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyasynchronous != null)
                {
                    body["Asynchronous"] = ExpressionConverter.ConvertO(bodyasynchronous);
                    bodypropCount++;
                }

                if (bodyuseCustom != null)
                {
                    body["UseCustom"] = ExpressionConverter.ConvertO(bodyuseCustom);
                    bodypropCount++;
                }

                if (bodydisplayGallery != null)
                {
                    body["DisplayGallery"] = ExpressionConverter.ConvertO(bodydisplayGallery);
                    bodypropCount++;
                }

                if (bodydisplayText != null)
                {
                    body["DisplayText"] = ExpressionConverter.ConvertO(bodydisplayText);
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
        [WorkflowExpressionFactory(nameof(__BuildCasePrintGet))]
        public IBodyWorkflowAction<object> CasePrintGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildCasePrintGet(WorkflowExpression<string> id, WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [WorkflowExpressionFactory(nameof(__BuildCaseReplyGet))]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CaseReplyResponse> __BuildCaseReplyGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CaseReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [WorkflowExpressionFactory(nameof(__BuildCaseReply))]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReply([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodywithoutNotification, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CaseReplyResponse> __BuildCaseReply(WorkflowExpression<string> id, WorkflowExpression<bool> bodywithoutNotification, WorkflowExpression<string> bodymessage = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodywithoutNotification, nameof(bodywithoutNotification), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredBodyAction<CaseReplyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["WithoutNotification"] = ExpressionConverter.ConvertO(bodywithoutNotification);
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

        [WorkflowExpressionFactory(nameof(__BuildCaseCreatedTrigger))]
        public IWorkflowTrigger CaseCreatedTrigger([WorkflowExpression] Func<string> bodytemplateId = null,[WorkflowExpression] Func<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCaseCreatedTrigger(WorkflowExpression<string> bodytemplateId = null,WorkflowExpression<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            WorkflowExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/t/casecreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(bodyscope);
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

        [WorkflowExpressionFactory(nameof(__BuildCaseUpdatedTrigger))]
        public IWorkflowTrigger CaseUpdatedTrigger([WorkflowExpression] Func<string> bodytemplateId = null,[WorkflowExpression] Func<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCaseUpdatedTrigger(WorkflowExpression<string> bodytemplateId = null,WorkflowExpression<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            WorkflowExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/t/caseupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(bodyscope);
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

        [WorkflowExpressionFactory(nameof(__BuildCaseClosedTrigger))]
        public IWorkflowTrigger CaseClosedTrigger([WorkflowExpression] Func<string> bodytemplateId = null,[WorkflowExpression] Func<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCaseClosedTrigger(WorkflowExpression<string> bodytemplateId = null,WorkflowExpression<bodyscopeInput> bodyscope = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            WorkflowExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/t/caseclosed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = ExpressionConverter.ConvertO(bodyscope);
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

    public enum bodydisplayGalleryInput
    {
        Gallery,
        List
    }

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