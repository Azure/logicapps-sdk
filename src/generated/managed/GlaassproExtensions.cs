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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<TemplateResponse[]> CaseTypeGetList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/s";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<SearchResponse[]> SearchGet([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<int> take = null)
        {
            SourceExpression.Validate(query, nameof(query), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(take, nameof(take), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/q";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (take != null)
                    callPayload.Queries["take"] = SourceExpressionConverter.ConvertO(take);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseResponse> CaseGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CaseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseFieldsResponse> CaseFieldGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CaseFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object> CasePrint([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodyasynchronous = null, [WorkflowExpression] Func<bool> bodyuseCustom = null, [WorkflowExpression] Func<bodydisplayGalleryInput> bodydisplayGallery = null, [WorkflowExpression] Func<bodydisplayTextInput> bodydisplayText = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyasynchronous, nameof(bodyasynchronous), required: false);
            SourceExpression.Validate(bodyuseCustom, nameof(bodyuseCustom), required: false);
            SourceExpression.Validate(bodydisplayGallery, nameof(bodydisplayGallery), required: false);
            SourceExpression.Validate(bodydisplayText, nameof(bodydisplayText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyasynchronous != null)
                {
                    body["Asynchronous"] = SourceExpressionConverter.ConvertToken(bodyasynchronous);
                    bodypropCount++;
                }

                if (bodyuseCustom != null)
                {
                    body["UseCustom"] = SourceExpressionConverter.ConvertToken(bodyuseCustom);
                    bodypropCount++;
                }

                if (bodydisplayGallery != null)
                {
                    body["DisplayGallery"] = SourceExpressionConverter.Convert(bodydisplayGallery);
                    bodypropCount++;
                }

                if (bodydisplayText != null)
                {
                    body["DisplayText"] = SourceExpressionConverter.Convert(bodydisplayText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<object> CasePrintGet([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CaseReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<CaseReplyResponse> CaseReply([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodywithoutNotification, [WorkflowExpression] Func<string> bodymessage = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodywithoutNotification, nameof(bodywithoutNotification), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["WithoutNotification"] = SourceExpressionConverter.ConvertToken(bodywithoutNotification);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CaseReplyResponse>(BuildSourceInput);
        }
    }

    public class GlaassproTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CaseCreatedTrigger([WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<bodyscopeInput> bodyscope = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/t/casecreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = SourceExpressionConverter.Convert(bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CaseUpdatedTrigger([WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<bodyscopeInput> bodyscope = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/t/caseupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = SourceExpressionConverter.Convert(bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CaseClosedTrigger([WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<bodyscopeInput> bodyscope = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/t/caseclosed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["TemplateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["Scope"] = SourceExpressionConverter.Convert(bodyscope);
                    bodypropCount++;
                }

                body["Notification"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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