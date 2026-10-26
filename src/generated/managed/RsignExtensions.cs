//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rsign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<GetAuthTokenResponse, ApiConnectionActionConfiguration> GetAuthToken(Expression<Func<GetAuthTokenInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAuthTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/V1/Authentication/AuthenticateUserV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAuthTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<SendEnvelopeFromTemplateResponse, ApiConnectionActionConfiguration> SendEnvelopeFromTemplate(Expression<Func<string>> authToken, Expression<Func<SendEnvelopeFromTemplateInput>> body)
        {
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEnvelopeFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/V1/Envelope/SendEnvelopeFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AuthToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEnvelopeFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<SendEnvelopeFromRuleResponse, ApiConnectionActionConfiguration> SendEnvelopeFromRule(Expression<Func<string>> authToken, Expression<Func<SendEnvelopeFromRuleInput>> body)
        {
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEnvelopeFromRuleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/V1/Envelope/SendEnvelopeFromRule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AuthToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEnvelopeFromRuleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<GetEnvelopeStatusInfoResponse, ApiConnectionActionConfiguration> GetEnvelopeStatusInfo(Expression<Func<string>> authToken, Expression<Func<GetEnvelopeStatusInfoInput>> body)
        {
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetEnvelopeStatusInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/V1/Envelope/GetEnvelopeStatusInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AuthToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetEnvelopeStatusInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<GetTemplateInfoResponse, ApiConnectionActionConfiguration> GetTemplateInfo(Expression<Func<string>> templateCode, Expression<Func<string>> authToken)
        {
            var __workflow_templateCode = WorkflowExpression.Compile(templateCode, nameof(templateCode), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<GetTemplateInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/V1/Template/GetTemplateInfo/{0}", __workflow_templateCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AuthToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<GetTemplateInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rsign")]
        public IBodyWorkflowAction<DownloadEnvelopeDocumentsResponse, ApiConnectionActionConfiguration> DownloadEnvelopeDocuments(Expression<Func<string>> envelopeCode, Expression<Func<string>> authToken)
        {
            var __workflow_envelopeCode = WorkflowExpression.Compile(envelopeCode, nameof(envelopeCode), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<DownloadEnvelopeDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/V1/Manage/DownloadEnvelopeDocuments/{0}", __workflow_envelopeCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["AuthToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<DownloadEnvelopeDocumentsResponse>(callPayload);
            });
        }
    }

    public class RsignTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAuthTokenResponse
    {
        [JsonProperty("AuthMessage")]
        public string AuthenticationMessage { get; set; }

        [JsonProperty("AuthToken")]
        public string AuthenticationToken { get; set; }
        public string RefreshToken { get; set; }
        public string RefreshTokenExpires { get; set; }

        [JsonProperty("AuthTokenExpires")]
        public string AuthenticationTokenExpires { get; set; }
        public string EmailId { get; set; }

        [JsonProperty("ApiId")]
        public string APIId { get; set; }
    }

    public class GetAuthTokenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceKey { get; set; }

        [JsonProperty("EmailId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class SendEnvelopeFromTemplateResponse
    {
        public string EnvelopeCode { get; set; }
        public string TransparencyChangedMessage { get; set; }

        [JsonProperty("LanguageBasedApiMessge")]
        public string LanguageBasedApiMessage { get; set; }
        public string PrefillRecipientId { get; set; }
        public string PostSendingNavigationPage { get; set; }
        public bool IsNewSignerUIEnabled { get; set; }
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Message { get; set; }
        public string EnvelopeId { get; set; }

        [JsonProperty("SignDoumentUrl")]
        public string SignDocumentURL { get; set; }
        public SendEnvelopeFromTemplateResponseRecipientListTypeItem[] RecipientList { get; set; }
        public string DialCodeDropdownList { get; set; }
        public string EnableMessageToMobile { get; set; }
    }

    public class SendEnvelopeFromTemplateResponseRecipientListTypeItem
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public int DeliveryMode { get; set; }
        public string DialCode { get; set; }
        public string CountryCode { get; set; }

        [JsonProperty("Mobile")]
        public string MobileNumber { get; set; }
        public int MobileMode { get; set; }

        [JsonProperty("SigningUrl")]
        public string SigningURL { get; set; }
    }

    public class SendEnvelopeFromTemplateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateCode { get; set; }
        public string AppKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEnvelopeFromTemplateInputTemplateRoleRecipientMappingTypeItem[] TemplateRoleRecipientMapping { get; set; }
    }

    public class SendEnvelopeFromTemplateInputTemplateRoleRecipientMappingTypeItem
    {
        [JsonProperty("RoleID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientName { get; set; }

        [JsonProperty("Mobile")]
        public string MobileNumber { get; set; }
    }

    public class SendEnvelopeFromRuleResponse
    {
        public string EnvelopeCode { get; set; }
        public string TransparencyChangedMessage { get; set; }

        [JsonProperty("LanguageBasedApiMessge")]
        public string LanguageBasedApiMessage { get; set; }
        public string PrefillRecipientId { get; set; }
        public string PostSendingNavigationPage { get; set; }
        public bool IsNewSignerUIEnabled { get; set; }
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Message { get; set; }
        public string EnvelopeId { get; set; }

        [JsonProperty("SignDoumentUrl")]
        public string SignDocumentURL { get; set; }
        public SendEnvelopeFromRuleResponseRecipientListTypeItem[] RecipientList { get; set; }
        public string DialCodeDropdownList { get; set; }
        public string EnableMessageToMobile { get; set; }
    }

    public class SendEnvelopeFromRuleResponseRecipientListTypeItem
    {
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public int DeliveryMode { get; set; }
        public string DialCode { get; set; }
        public string CountryCode { get; set; }

        [JsonProperty("Mobile")]
        public string MobileNumber { get; set; }
        public int MobileMode { get; set; }
        public string SigningUrl { get; set; }
    }

    public class SendEnvelopeFromRuleInput
    {
        [JsonProperty("TemplateCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RuleCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEnvelopeFromRuleInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEnvelopeFromRuleInputTemplateRoleRecipientMappingTypeItem[] TemplateRoleRecipientMapping { get; set; }
    }

    public class SendEnvelopeFromRuleInputDocumentsTypeItem
    {
        [JsonProperty("Name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentName { get; set; }

        [JsonProperty("DocumentBase64Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentBase64String { get; set; }
        public string AppKey { get; set; }
    }

    public class SendEnvelopeFromRuleInputTemplateRoleRecipientMappingTypeItem
    {
        [JsonProperty("RoleID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientEmail { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientName { get; set; }

        [JsonProperty("Mobile")]
        public string MobileNumber { get; set; }
    }

    public class GetEnvelopeStatusInfoResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StatusMessage { get; set; }
        public GetEnvelopeStatusInfoResponseDataTypeItem[] Data { get; set; }
        public int TotalCount { get; set; }
        public string IsAttachmentUploadsExist { get; set; }
    }

    public class GetEnvelopeStatusInfoResponseDataTypeItem
    {
        public string EnvelopeCode { get; set; }

        [JsonProperty("EnvelopeID")]
        public string EnvelopeId { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
        public bool IsEnvelopeComplete { get; set; }
        public string SentDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public GetEnvelopeStatusInfoResponseDataTypeItemRecipientDetailsTypeItem[] RecipientDetails { get; set; }
        public string ReferenceCode { get; set; }
        public string ReferenceEmail { get; set; }
    }

    public class GetEnvelopeStatusInfoResponseDataTypeItemRecipientDetailsTypeItem
    {
        [JsonProperty("RecipientID")]
        public string RecipientId { get; set; }

        [JsonProperty("RecipientTypeID")]
        public string RecipientTypeId { get; set; }
        public string RecipientType { get; set; }
        public string RecipientName { get; set; }
        public string Email { get; set; }
        public int Order { get; set; }
        public string StatusId { get; set; }
        public string SigningStatus { get; set; }
        public string LastModifiedDate { get; set; }
    }

    public class GetEnvelopeStatusInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnvelopeCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GetEnvelopeStatusInfoInputDetailOrSummaryType DetailOrSummary { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEnvelopeStatusInfoInputDetailOrSummaryType
    {
        Detail,
        Summary
    }

    public class GetTemplateInfoResponse
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Message { get; set; }
        public string TemplateId { get; set; }
        public GetTemplateInfoResponseTemplateBasicInfoType TemplateBasicInfo { get; set; }
        public string TemplateList { get; set; }
    }

    public class GetTemplateInfoResponseTemplateBasicInfoType
    {
        public string TemplateId { get; set; }
        public int TemplateCode { get; set; }
        public string UserEmail { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
        public string IsStatic { get; set; }
        public string ExpiryDate { get; set; }
        public string CreatedDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string TypeName { get; set; }
        public GetTemplateInfoResponseTemplateBasicInfoTypeDocumentListTypeItem[] DocumentList { get; set; }
        public GetTemplateInfoResponseTemplateBasicInfoTypeTemplateRoleListTypeItem[] TemplateRoleList { get; set; }
        public bool EnableMessageToMobile { get; set; }
        public string StaticLinkExpiryDate { get; set; }
    }

    public class GetTemplateInfoResponseTemplateBasicInfoTypeDocumentListTypeItem
    {
        public string DocumentId { get; set; }
        public string DocumentName { get; set; }
        public int Order { get; set; }

        [JsonProperty("documentContentDetails")]
        public GetTemplateInfoResponseTemplateBasicInfoTypeDocumentListTypeItemDocumentContentDetailsTypeItem[] DocumentContentDetails { get; set; }
    }

    public class GetTemplateInfoResponseTemplateBasicInfoTypeDocumentListTypeItemDocumentContentDetailsTypeItem
    {
        [JsonProperty("ControlID")]
        public string ControlId { get; set; }
        public string ControlName { get; set; }

        [JsonProperty("ControlHtmlID")]
        public string ControlHtmlId { get; set; }
        public string GroupName { get; set; }
        public string Label { get; set; }
        public int PageNo { get; set; }
        public bool Required { get; set; }
        public string ControlValue { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string[] SelectControlOptions { get; set; }
    }

    public class GetTemplateInfoResponseTemplateBasicInfoTypeTemplateRoleListTypeItem
    {
        [JsonProperty("RoleID")]
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public int Order { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }

        [JsonProperty("RecipientTypeID")]
        public string RecipientTypeId { get; set; }

        [JsonProperty("RecipientID")]
        public string RecipientId { get; set; }
        public string RecipientType { get; set; }
        public string CcSignerType { get; set; }
        public string CultureInfo { get; set; }
        public int DeliveryMode { get; set; }
        public string DialCode { get; set; }
        public string CountryCode { get; set; }

        [JsonProperty("Mobile")]
        public string MobileNumber { get; set; }
        public int MobileMode { get; set; }
        public string EmailAddress { get; set; }
    }

    public class DownloadEnvelopeDocumentsResponse
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StatusMessage { get; set; }
        public DownloadEnvelopeDocumentsResponseDataType Data { get; set; }
        public int TotalCount { get; set; }
        public string IsAttachmentUploadsExist { get; set; }
    }

    public class DownloadEnvelopeDocumentsResponseDataType
    {
        public string EnvelopeCode { get; set; }
        public DownloadEnvelopeDocumentsResponseDataTypeDocumentListTypeItem[] DocumentList { get; set; }
        public string ReadMe { get; set; }
        public string CombinedZip { get; set; }
    }

    public class DownloadEnvelopeDocumentsResponseDataTypeDocumentListTypeItem
    {
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ByteArray { get; set; }
        public string AdditionalInfo { get; set; }
        public string AttachmentDescription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rsign;

    public partial class WorkflowManagedActions
    {
        public RsignActions Rsign(string connectionId) => new RsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RsignTriggers Rsign(string connectionId) => new RsignTriggers(connectionId);
    }
}