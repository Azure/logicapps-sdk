//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Glaasspro
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<SearchResponse[]> SearchGet(Expression<Func<string>> query, Expression<Func<filterInput>> filter = null, Expression<Func<int>> take = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseResponse> CaseGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/c/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseFieldsResponse> CaseFieldGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/c/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CaseFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object> CasePrintPost(Expression<Func<string>> id, Expression<Func<bool>> bodyAsynchronous = null, Expression<Func<bool>> bodyUseCustom = null, Expression<Func<bodyDisplayGalleryInput>> bodyDisplayGallery = null, Expression<Func<bodyDisplayTextInput>> bodyDisplayText = null)
        {
            var apiCallPath = String.Format("/api/c/{0}/print", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAsynchronous != null)
            {
                body["Asynchronous"] = ExpressionConverter.ConvertO(bodyAsynchronous);
                bodypropCount++;
            }

            if (bodyUseCustom != null)
            {
                body["UseCustom"] = ExpressionConverter.ConvertO(bodyUseCustom);
                bodypropCount++;
            }

            if (bodyDisplayGallery != null)
            {
                body["DisplayGallery"] = ExpressionConverter.ConvertO(bodyDisplayGallery);
                bodypropCount++;
            }

            if (bodyDisplayText != null)
            {
                body["DisplayText"] = ExpressionConverter.ConvertO(bodyDisplayText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object> CasePrintGet(Expression<Func<string>> id, Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/api/c/{0}/print/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CaseReplyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyPost(Expression<Func<string>> id, Expression<Func<bool>> bodyWithoutNotification, Expression<Func<string>> bodyMessage = null)
        {
            var apiCallPath = String.Format("/api/c/{0}/reply", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyMessage != null)
            {
                body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
                bodypropCount++;
            }

            bodypropCount++;
            body["WithoutNotification"] = ExpressionConverter.ConvertO(bodyWithoutNotification);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CaseReplyResponse>(callPayload);
        }
    }

    public class GlaassproTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CaseCreatedTrigger(Expression<Func<string>> bodyTemplateId = null, Expression<Func<bodyScopeInput>> bodyScope = null, string triggerName = null)
        {
            var apiCallPath = "/api/t/casecreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTemplateId != null)
            {
                body["TemplateId"] = ExpressionConverter.ConvertO(bodyTemplateId);
                bodypropCount++;
            }

            if (bodyScope != null)
            {
                body["Scope"] = ExpressionConverter.ConvertO(bodyScope);
                bodypropCount++;
            }

            body["Notification"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CaseUpdatedTrigger(Expression<Func<string>> bodyTemplateId = null, Expression<Func<bodyScopeInput>> bodyScope = null, string triggerName = null)
        {
            var apiCallPath = "/api/t/caseupdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTemplateId != null)
            {
                body["TemplateId"] = ExpressionConverter.ConvertO(bodyTemplateId);
                bodypropCount++;
            }

            if (bodyScope != null)
            {
                body["Scope"] = ExpressionConverter.ConvertO(bodyScope);
                bodypropCount++;
            }

            body["Notification"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CaseClosedTrigger(Expression<Func<string>> bodyTemplateId = null, Expression<Func<bodyScopeInput>> bodyScope = null, string triggerName = null)
        {
            var apiCallPath = "/api/t/caseclosed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTemplateId != null)
            {
                body["TemplateId"] = ExpressionConverter.ConvertO(bodyTemplateId);
                bodypropCount++;
            }

            if (bodyScope != null)
            {
                body["Scope"] = ExpressionConverter.ConvertO(bodyScope);
                bodypropCount++;
            }

            body["Notification"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

    public enum bodyDisplayGalleryInput
    {
        Gallery,
        List
    }

    public enum bodyDisplayTextInput
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

    public enum bodyScopeInput
    {
        ByMe,
        ForMe,
        All
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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