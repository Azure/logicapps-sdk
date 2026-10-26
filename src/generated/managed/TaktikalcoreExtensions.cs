//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taktikalcore
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaktikalcoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration> GetSigningProcessActivityactivityProcessKeyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> processKey, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/activity/{0}", __workflow_processKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_user != null)
                    callPayload.Queries["User"] = ExpressionConverter.Convert(__workflow_user);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_flowType != null)
                    callPayload.Queries["FlowType"] = ExpressionConverter.Convert(__workflow_flowType);
                if (__workflow_take != null)
                    callPayload.Queries["Take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["Skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_flowKey != null)
                    callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration> GetSigningProcessActivityForUseractivityuserGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> user = null, Expression<Func<string>> processKey = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/signing/activity/user/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_user != null)
                    callPayload.Queries["User"] = ExpressionConverter.Convert(__workflow_user);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_processKey != null)
                    callPayload.Queries["ProcessKey"] = ExpressionConverter.Convert(__workflow_processKey);
                if (__workflow_flowType != null)
                    callPayload.Queries["FlowType"] = ExpressionConverter.Convert(__workflow_flowType);
                if (__workflow_take != null)
                    callPayload.Queries["Take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["Skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_flowKey != null)
                    callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration> GetSigningProcessActivityByCompanyactivitycompanyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/signing/activity/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_take != null)
                    callPayload.Queries["Take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["Skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_user != null)
                    callPayload.Queries["User"] = ExpressionConverter.Convert(__workflow_user);
                if (__workflow_flowType != null)
                    callPayload.Queries["FlowType"] = ExpressionConverter.Convert(__workflow_flowType);
                if (__workflow_flowKey != null)
                    callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SealingResponse, ApiConnectionActionConfiguration> SealingRequestsealing(Expression<Func<SealingRequestsealingPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SealingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/sealing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SealingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess, ApiConnectionActionConfiguration> CancelSigningProcesssigningDelete(Expression<Func<string>> processKey = null, Expression<Func<string>> user = null)
        {
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: false);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            return new DeferredBodyAction<SigningProcess, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/signing";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_processKey != null)
                    callPayload.Queries["ProcessKey"] = ExpressionConverter.Convert(__workflow_processKey);
                if (__workflow_user != null)
                    callPayload.Queries["User"] = ExpressionConverter.Convert(__workflow_user);
                return new ApiConnectionAction<SigningProcess>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess, ApiConnectionActionConfiguration> CreateSigningProcesssigning(Expression<Func<CreateSigningProcesssigningPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SigningProcess, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/signing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SigningProcess>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SealingXmlRequestsealingxml(Expression<Func<SealingXmlRequestsealingxmlPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/sealing/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning, ApiConnectionActionConfiguration> CancelSequenceSigningsigningsequentialDelete(Expression<Func<string>> sequenceKey, Expression<Func<string>> user)
        {
            var __workflow_sequenceKey = WorkflowExpression.Compile(sequenceKey, nameof(sequenceKey), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: true);
            return new DeferredBodyAction<SequentialSigning, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/signing/sequential";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SequenceKey"] = ExpressionConverter.Convert(__workflow_sequenceKey);
                callPayload.Queries["User"] = ExpressionConverter.Convert(__workflow_user);
                return new ApiConnectionAction<SequentialSigning>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning, ApiConnectionActionConfiguration> CreateSequentialSigningsigningsequential(Expression<Func<CreateSequentialSigningsigningsequentialPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SequentialSigning, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/management/signing/sequential";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SequentialSigning>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse, ApiConnectionActionConfiguration> AuthStartStart(Expression<Func<AuthStartStartPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StartAuthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Auth/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartAuthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<PollCustomer, ApiConnectionActionConfiguration> AuthPollPoll(Expression<Func<AuthPollPollPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PollCustomer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Auth/Poll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PollCustomer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse, ApiConnectionActionConfiguration> RequestToViewSequenceStartsequentialSequenceKeyauth(Expression<Func<string>> sequenceKey, Expression<Func<RequestToViewSequenceStartsequentialSequenceKeyauthPostInput>> body = null)
        {
            var __workflow_sequenceKey = WorkflowExpression.Compile(sequenceKey, nameof(sequenceKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StartAuthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/sequential/{0}/auth", __workflow_sequenceKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartAuthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess, ApiConnectionActionConfiguration> GetSigningProcessBySigneeProcessKeysigneeSigneeKeyGet(Expression<Func<string>> processKey, Expression<Func<string>> signeeKey, Expression<Func<string>> userAgent = null)
        {
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_signeeKey = WorkflowExpression.Compile(signeeKey, nameof(signeeKey), required: true);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            return new DeferredBodyAction<SigningProcess, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/{0}/signee/{1}", __workflow_processKey.WithUrlEncoding(1), __workflow_signeeKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userAgent != null)
                    callPayload.Queries["UserAgent"] = ExpressionConverter.Convert(__workflow_userAgent);
                return new ApiConnectionAction<SigningProcess>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<Signee, ApiConnectionActionConfiguration> UpdateSigneeProcessKeysigneeSigneeKeyCreate(Expression<Func<string>> signeeKey, Expression<Func<string>> processKey, Expression<Func<UpdateSigneeProcessKeysigneeSigneeKeyCreateInput>> body = null)
        {
            var __workflow_signeeKey = WorkflowExpression.Compile(signeeKey, nameof(signeeKey), required: true);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Signee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/{0}/signee/{1}", __workflow_processKey.WithUrlEncoding(1), __workflow_signeeKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Signee>(callPayload);
            });
        }
    }

    public class TaktikalcoreTriggers([ConnectionName] string connectionId)
    {
    }

    public class SigningProcessActivityLogWrapper
    {
        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("activityLog")]
        public SigningProcessActivityLog[] ActivityLog { get; set; }

        [JsonProperty("signees")]
        public SigneeActivityLog[] Signees { get; set; }

        [JsonProperty("sequenceSignees")]
        public SequentialSigningSigneeActivityLog[] SequenceSignees { get; set; }

        [JsonProperty("attachmentReferences")]
        public AttachmentReference[] AttachmentReferences { get; set; }

        [JsonProperty("activityDisplayName")]
        public string ActivityDisplayName { get; set; }
    }

    public class SigningProcessActivityLog
    {
        [JsonProperty("flowKey")]
        public string FlowKey { get; set; }

        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("signeeKey")]
        public string SigneeKey { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("requiresAuth")]
        public bool RequiresAuth { get; set; }

        [JsonProperty("signInOrder")]
        public bool SignInOrder { get; set; }

        [JsonProperty("signatureLocation")]
        public string SignatureLocation { get; set; }

        [JsonProperty("sequenceKey")]
        public string SequenceKey { get; set; }
    }

    public class SigneeActivityLog
    {
        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("signeeKey")]
        public string SigneeKey { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }
    }

    public class SequentialSigningSigneeActivityLog
    {
        [JsonProperty("sequenceKey")]
        public string SequenceKey { get; set; }

        [JsonProperty("signeeKey")]
        public string SigneeKey { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signingKeys")]
        public SigneeKeys[] SigningKeys { get; set; }
    }

    public class SigneeKeys
    {
        [JsonProperty("signeeKey")]
        public string SigneeKey { get; set; }

        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }
    }

    public class AttachmentReference
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("contentLength")]
        public int ContentLength { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("attachmentType")]
        public string AttachmentType { get; set; }

        [JsonProperty("signeeKey")]
        public string SigneeKey { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum flowTypeInput
    {
        RenderFlow,
        DropAndSign,
        FillAndSign,
        PEP,
        Thinglysingar,
        Compliance,
        CompanyLookup
    }

    public class SealingResponse
    {
        [JsonProperty("pdfDocument")]
        public string PdfDocument { get; set; }
    }

    public class SealingRequestsealingPostInput
    {
        [JsonProperty("pdfDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfDocument { get; set; }

        [JsonProperty("flowKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowKey { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("languageType")]
        public string LanguageType { get; set; }
    }

    public class SigningProcess
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("signees")]
        public Signee[] Signees { get; set; }

        [JsonProperty("flowKey")]
        public string FlowKey { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("meta")]
        public JToken Meta { get; set; }

        [JsonProperty("pdfFileName")]
        public string PdfFileName { get; set; }

        [JsonProperty("attachments")]
        public SigningAttachment[] Attachments { get; set; }

        [JsonProperty("attachmentReferences")]
        public AttachmentReference[] AttachmentReferences { get; set; }

        [JsonProperty("requiresAuth")]
        public bool RequiresAuth { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("signInOrder")]
        public bool SignInOrder { get; set; }

        [JsonProperty("signatureLocation")]
        public string SignatureLocation { get; set; }

        [JsonProperty("sequenceKey")]
        public string SequenceKey { get; set; }

        [JsonProperty("flattenDocument")]
        public bool FlattenDocument { get; set; }
    }

    public class Signee
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signedAt")]
        public string SignedAt { get; set; }

        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("hidePersonalCode")]
        public bool HidePersonalCode { get; set; }

        [JsonProperty("communicationDeliveryType")]
        public string CommunicationDeliveryType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("customSmsText")]
        public string CustomSmsText { get; set; }
    }

    public class SigningAttachment
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }
    }

    public class CreateSigningProcesssigningPostInput
    {
        [JsonProperty("pdfDocument")]
        public string PdfDocument { get; set; }

        [JsonProperty("pdfFileName")]
        public string PdfFileName { get; set; }

        [JsonProperty("flowKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowKey { get; set; }

        [JsonProperty("createSignees")]
        public CreateSignee[] CreateSignees { get; set; }

        [JsonProperty("meta")]
        public JToken Meta { get; set; }

        [JsonProperty("attachments")]
        public SigningAttachment[] Attachments { get; set; }

        [JsonProperty("attachmentReferences")]
        public AttachmentReference[] AttachmentReferences { get; set; }

        [JsonProperty("requiresAuth")]
        public bool? RequiresAuth { get; set; }

        [JsonProperty("signInOrder")]
        public bool? SignInOrder { get; set; }

        [JsonProperty("signatureLocation")]
        public CreateSigningProcesssigningPostInputSignatureLocationType? SignatureLocation { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("sequenceKey")]
        public string SequenceKey { get; set; }

        [JsonProperty("activityDisplayName")]
        public string ActivityDisplayName { get; set; }

        [JsonProperty("flattenDocument")]
        public bool? FlattenDocument { get; set; }

        [JsonProperty("reminderRule")]
        public string ReminderRule { get; set; }
    }

    public class CreateSignee
    {
        [JsonProperty("processKey")]
        public string ProcessKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("hidePersonalCode")]
        public bool HidePersonalCode { get; set; }

        [JsonProperty("communicationDeliveryType")]
        public string CommunicationDeliveryType { get; set; }

        [JsonProperty("customSmsText")]
        public string CustomSmsText { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSigningProcesssigningPostInputSignatureLocationType
    {
        TopFirstPage,
        BottomLastPage
    }

    public class SealingXmlRequestsealingxmlPostInput
    {
        [JsonProperty("xmlDocument", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XmlDocument { get; set; }

        [JsonProperty("flowKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowKey { get; set; }
    }

    public class SequentialSigning
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requiresAuth")]
        public bool RequiresAuth { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("signInOrder")]
        public bool SignInOrder { get; set; }

        [JsonProperty("signees")]
        public SequentialSigningSignee[] Signees { get; set; }

        [JsonProperty("signingProcesses")]
        public SigningProcess[] SigningProcesses { get; set; }
    }

    public class SequentialSigningSignee
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signingKeys")]
        public SigneeKeys[] SigningKeys { get; set; }
    }

    public class CreateSequentialSigningsigningsequentialPostInput
    {
        [JsonProperty("createSigningProcesses", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSigningProcess[] CreateSigningProcesses { get; set; }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("requiresAuth")]
        public bool? RequiresAuth { get; set; }

        [JsonProperty("signInOrder")]
        public bool? SignInOrder { get; set; }
    }

    public class CreateSigningProcess
    {
        [JsonProperty("pdfDocument")]
        public string PdfDocument { get; set; }

        [JsonProperty("pdfFileName")]
        public string PdfFileName { get; set; }

        [JsonProperty("flowKey")]
        public string FlowKey { get; set; }

        [JsonProperty("createSignees")]
        public CreateSignee[] CreateSignees { get; set; }

        [JsonProperty("meta")]
        public JToken Meta { get; set; }

        [JsonProperty("attachments")]
        public SigningAttachment[] Attachments { get; set; }

        [JsonProperty("attachmentReferences")]
        public AttachmentReference[] AttachmentReferences { get; set; }

        [JsonProperty("requiresAuth")]
        public bool RequiresAuth { get; set; }

        [JsonProperty("signInOrder")]
        public bool SignInOrder { get; set; }

        [JsonProperty("signatureLocation")]
        public CreateSigningProcessSignatureLocationType SignatureLocation { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("sequenceKey")]
        public string SequenceKey { get; set; }

        [JsonProperty("activityDisplayName")]
        public string ActivityDisplayName { get; set; }

        [JsonProperty("flattenDocument")]
        public bool FlattenDocument { get; set; }

        [JsonProperty("reminderRule")]
        public string ReminderRule { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSigningProcessSignatureLocationType
    {
        TopFirstPage,
        BottomLastPage
    }

    public class StartAuthResponse
    {
        [JsonProperty("authRequestId")]
        public string AuthRequestId { get; set; }

        [JsonProperty("verificationCode")]
        public string VerificationCode { get; set; }
    }

    public class AuthStartStartPostInput
    {
        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("flowKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowKey { get; set; }

        [JsonProperty("authenticationContextType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AuthStartStartPostInputAuthenticationContextTypeType AuthenticationContextType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthStartStartPostInputAuthenticationContextTypeType
    {
        Sim,
        App
    }

    public class PollCustomer
    {
        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("waitingForUserInput")]
        public bool WaitingForUserInput { get; set; }
    }

    public class Customer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("flowKey")]
        public string FlowKey { get; set; }

        [JsonProperty("meta")]
        public JToken Meta { get; set; }
    }

    public class AuthPollPollPostInput
    {
        [JsonProperty("authRequestId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthRequestId { get; set; }

        [JsonProperty("flowKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowKey { get; set; }

        [JsonProperty("lookupType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AuthPollPollPostInputLookupTypeType LookupType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthPollPollPostInputLookupTypeType
    {
        NameAddress,
        Name,
        NameAddressFamily
    }

    public class RequestToViewSequenceStartsequentialSequenceKeyauthPostInput
    {
        [JsonProperty("sequenceKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SequenceKey { get; set; }

        [JsonProperty("loginHint", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LoginHint { get; set; }

        [JsonProperty("authenticationContextType", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequestToViewSequenceStartsequentialSequenceKeyauthPostInputAuthenticationContextTypeType AuthenticationContextType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RequestToViewSequenceStartsequentialSequenceKeyauthPostInputAuthenticationContextTypeType
    {
        Sim,
        App
    }

    public class UpdateSigneeProcessKeysigneeSigneeKeyCreateInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("signeeKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SigneeKey { get; set; }

        [JsonProperty("processKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessKey { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Taktikalcore;

    public partial class WorkflowManagedActions
    {
        public TaktikalcoreActions Taktikalcore(string connectionId) => new TaktikalcoreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TaktikalcoreTriggers Taktikalcore(string connectionId) => new TaktikalcoreTriggers(connectionId);
    }
}