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
        public IBodyWorkflowAction<UserListResponse[]> UserGetAll()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/u";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserListResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse> User([WorkflowExpression] Func<string> requestemail, [WorkflowExpression] Func<string> requestfirstName, [WorkflowExpression] Func<string> requestlastName, [WorkflowExpression] Func<bool> requestisAdmin, [WorkflowExpression] Func<bool> requestisReadOnly, [WorkflowExpression] Func<bool> requestisDocumentController, [WorkflowExpression] Func<bool> requestisFolderController, [WorkflowExpression] Func<bool> requestisManagerial, [WorkflowExpression] Func<string> requestcompany = null, [WorkflowExpression] Func<string> requestposition = null, [WorkflowExpression] Func<string> requestphone = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/u";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Email"] = SourceExpressionConverter.ConvertToken(requestemail);
                requestpropCount++;
                request["FirstName"] = SourceExpressionConverter.ConvertToken(requestfirstName);
                requestpropCount++;
                request["LastName"] = SourceExpressionConverter.ConvertToken(requestlastName);
                if (requestcompany != null)
                {
                    request["Company"] = SourceExpressionConverter.ConvertToken(requestcompany);
                    requestpropCount++;
                }

                if (requestposition != null)
                {
                    request["Position"] = SourceExpressionConverter.ConvertToken(requestposition);
                    requestpropCount++;
                }

                if (requestphone != null)
                {
                    request["Phone"] = SourceExpressionConverter.ConvertToken(requestphone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["IsAdmin"] = SourceExpressionConverter.ConvertToken(requestisAdmin);
                requestpropCount++;
                request["IsReadOnly"] = SourceExpressionConverter.ConvertToken(requestisReadOnly);
                requestpropCount++;
                request["IsDocumentController"] = SourceExpressionConverter.ConvertToken(requestisDocumentController);
                requestpropCount++;
                request["IsFolderController"] = SourceExpressionConverter.ConvertToken(requestisFolderController);
                requestpropCount++;
                request["IsManagerial"] = SourceExpressionConverter.ConvertToken(requestisManagerial);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse> UserGet([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/u/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<UserResponse> UserPost2([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<bool> requestactive)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/u/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Active"] = SourceExpressionConverter.ConvertToken(requestactive);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataListResponse[]> MetadataGetAll()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/m";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MetadataListResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataResponse> MetadataGet([WorkflowExpression] Func<string> metadataId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/m/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(metadataId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse[]> MetadataGetSwitches([WorkflowExpression] Func<string> metadataId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/m/{0}/switch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(metadataId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MetadataSwitchResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse> MetadataPostSwitch([WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> requestlabel)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/m/{0}/switch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(metadataId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Label"] = SourceExpressionConverter.ConvertToken(requestlabel);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MetadataSwitchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse[]> MetadataPutSwitches([WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<switchesInputItem[]> switches = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/m/{0}/switch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(metadataId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(switches);
                return callPayload;
            }

            return new ApiConnectionAction<MetadataSwitchResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<MetadataSwitchResponse> MetadataPutSwitch([WorkflowExpression] Func<string> metadataId, [WorkflowExpression] Func<string> switchId, [WorkflowExpression] Func<string> requestlabel)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/m/{0}/switch/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(metadataId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(switchId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["Label"] = SourceExpressionConverter.ConvertToken(requestlabel);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MetadataSwitchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "glaasspro")]
        public IBodyWorkflowAction<SearchResponse[]> SearchGet([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<int> take = null)
        {
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
        public IBodyWorkflowAction<object> CasePrint([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodyuseCustom = null, [WorkflowExpression] Func<bodydisplayGalleryInput> bodydisplayGallery = null, [WorkflowExpression] Func<bodydisplayTextInput> bodydisplayText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/print", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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
        public IBodyWorkflowAction<CaseReplyResponse> CaseReplyGet([WorkflowExpression] Func<string> id)
        {
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
        public IBodyWorkflowAction<CaseReplyResponse> CaseReply([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bool> bodywithoutNotification)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/c/{0}/reply", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
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

                body["Notification"] = "#{listCallbackUrl()}";
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

                body["Notification"] = "#{listCallbackUrl()}";
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

                body["Notification"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger MetadataCreatedTrigger([WorkflowExpression] Func<string> requestmetadataId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/mt/metadatacreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmetadataId != null)
                {
                    request["MetadataId"] = SourceExpressionConverter.ConvertToken(requestmetadataId);
                    requestpropCount++;
                }

                request["Notification"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger MetadataUpdatedTrigger([WorkflowExpression] Func<string> requestmetadataId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/mt/metadataupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmetadataId != null)
                {
                    request["MetadataId"] = SourceExpressionConverter.ConvertToken(requestmetadataId);
                    requestpropCount++;
                }

                request["Notification"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
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

    public class ProjectUserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
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