//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taktikalcore
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaktikalcoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityactivityProcessKeyGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> processKey, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            var apiCallPath = String.Format("/signing/activity/{0}", ExpressionConverter.ConvertWithUrlEncoding(processKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (user != null)
                callPayload.Queries["User"] = ExpressionConverter.Convert(user);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            if (flowType != null)
                callPayload.Queries["FlowType"] = ExpressionConverter.Convert(flowType);
            if (take != null)
                callPayload.Queries["Take"] = ExpressionConverter.Convert(take);
            if (skip != null)
                callPayload.Queries["Skip"] = ExpressionConverter.Convert(skip);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityForUseractivityuserGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<string> processKey = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            var apiCallPath = "/signing/activity/user/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (user != null)
                callPayload.Queries["User"] = ExpressionConverter.Convert(user);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            if (processKey != null)
                callPayload.Queries["ProcessKey"] = ExpressionConverter.Convert(processKey);
            if (flowType != null)
                callPayload.Queries["FlowType"] = ExpressionConverter.Convert(flowType);
            if (take != null)
                callPayload.Queries["Take"] = ExpressionConverter.Convert(take);
            if (skip != null)
                callPayload.Queries["Skip"] = ExpressionConverter.Convert(skip);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityByCompanyactivitycompanyGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            var apiCallPath = "/signing/activity/company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            if (take != null)
                callPayload.Queries["Take"] = ExpressionConverter.Convert(take);
            if (skip != null)
                callPayload.Queries["Skip"] = ExpressionConverter.Convert(skip);
            if (user != null)
                callPayload.Queries["User"] = ExpressionConverter.Convert(user);
            if (flowType != null)
                callPayload.Queries["FlowType"] = ExpressionConverter.Convert(flowType);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SealingResponse> SealingRequestsealing([WorkflowExpression] Func<string> bodypdfDocument, [WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylanguageType = null)
        {
            var apiCallPath = "/management/sealing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pdfDocument"] = ExpressionConverter.ConvertO(bodypdfDocument);
            bodypropCount++;
            body["flowKey"] = ExpressionConverter.ConvertO(bodyflowKey);
            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodylanguageType != null)
            {
                body["languageType"] = ExpressionConverter.ConvertO(bodylanguageType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SealingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CancelSigningProcesssigningDelete([WorkflowExpression] Func<string> processKey = null, [WorkflowExpression] Func<string> user = null)
        {
            var apiCallPath = "/management/signing";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (processKey != null)
                callPayload.Queries["ProcessKey"] = ExpressionConverter.Convert(processKey);
            if (user != null)
                callPayload.Queries["User"] = ExpressionConverter.Convert(user);
            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CreateSigningProcesssigning([WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<string> bodypdfDocument = null, [WorkflowExpression] Func<string> bodypdfFileName = null, [WorkflowExpression] Func<CreateSignee[]> bodycreateSignees = null, [WorkflowExpression] Func<SigningAttachment[]> bodyattachments = null, [WorkflowExpression] Func<AttachmentReference[]> bodyattachmentReferences = null, [WorkflowExpression] Func<bool> bodyrequiresAuth = null, [WorkflowExpression] Func<bool> bodysignInOrder = null, [WorkflowExpression] Func<bodysignatureLocationInput> bodysignatureLocation = null, [WorkflowExpression] Func<string> bodyuser = null, [WorkflowExpression] Func<string> bodysequenceKey = null, [WorkflowExpression] Func<string> bodyactivityDisplayName = null, [WorkflowExpression] Func<bool> bodyflattenDocument = null, [WorkflowExpression] Func<string> bodyreminderRule = null)
        {
            var apiCallPath = "/management/signing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypdfDocument != null)
            {
                body["pdfDocument"] = ExpressionConverter.ConvertO(bodypdfDocument);
                bodypropCount++;
            }

            if (bodypdfFileName != null)
            {
                body["pdfFileName"] = ExpressionConverter.ConvertO(bodypdfFileName);
                bodypropCount++;
            }

            bodypropCount++;
            body["flowKey"] = ExpressionConverter.ConvertO(bodyflowKey);
            if (bodycreateSignees != null)
            {
                body["createSignees"] = ExpressionConverter.ConvertO(bodycreateSignees);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodyattachments != null)
            {
                body["attachments"] = ExpressionConverter.ConvertO(bodyattachments);
                bodypropCount++;
            }

            if (bodyattachmentReferences != null)
            {
                body["attachmentReferences"] = ExpressionConverter.ConvertO(bodyattachmentReferences);
                bodypropCount++;
            }

            if (bodyrequiresAuth != null)
            {
                body["requiresAuth"] = ExpressionConverter.ConvertO(bodyrequiresAuth);
                bodypropCount++;
            }

            if (bodysignInOrder != null)
            {
                body["signInOrder"] = ExpressionConverter.ConvertO(bodysignInOrder);
                bodypropCount++;
            }

            if (bodysignatureLocation != null)
            {
                body["signatureLocation"] = ExpressionConverter.ConvertO(bodysignatureLocation);
                bodypropCount++;
            }

            if (bodyuser != null)
            {
                body["user"] = ExpressionConverter.ConvertO(bodyuser);
                bodypropCount++;
            }

            if (bodysequenceKey != null)
            {
                body["sequenceKey"] = ExpressionConverter.ConvertO(bodysequenceKey);
                bodypropCount++;
            }

            if (bodyactivityDisplayName != null)
            {
                body["activityDisplayName"] = ExpressionConverter.ConvertO(bodyactivityDisplayName);
                bodypropCount++;
            }

            if (bodyflattenDocument != null)
            {
                body["flattenDocument"] = ExpressionConverter.ConvertO(bodyflattenDocument);
                bodypropCount++;
            }

            if (bodyreminderRule != null)
            {
                body["reminderRule"] = ExpressionConverter.ConvertO(bodyreminderRule);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<JToken> SealingXmlRequestsealingxml([WorkflowExpression] Func<string> bodyxmlDocument, [WorkflowExpression] Func<string> bodyflowKey)
        {
            var apiCallPath = "/management/sealing/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["xmlDocument"] = ExpressionConverter.ConvertO(bodyxmlDocument);
            bodypropCount++;
            body["flowKey"] = ExpressionConverter.ConvertO(bodyflowKey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CancelSequenceSigningsigningsequentialDelete([WorkflowExpression] Func<string> sequenceKey, [WorkflowExpression] Func<string> user)
        {
            var apiCallPath = "/management/signing/sequential";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SequenceKey"] = ExpressionConverter.Convert(sequenceKey);
            callPayload.Queries["User"] = ExpressionConverter.Convert(user);
            return new ApiConnectionAction<SequentialSigning>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CreateSequentialSigningsigningsequential([WorkflowExpression] Func<CreateSigningProcess[]> bodycreateSigningProcesses, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodyrequiresAuth = null, [WorkflowExpression] Func<bool> bodysignInOrder = null)
        {
            var apiCallPath = "/management/signing/sequential";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["createSigningProcesses"] = ExpressionConverter.ConvertO(bodycreateSigningProcesses);
            bodypropCount++;
            body["user"] = ExpressionConverter.ConvertO(bodyuser);
            if (bodyrequiresAuth != null)
            {
                body["requiresAuth"] = ExpressionConverter.ConvertO(bodyrequiresAuth);
                bodypropCount++;
            }

            if (bodysignInOrder != null)
            {
                body["signInOrder"] = ExpressionConverter.ConvertO(bodysignInOrder);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SequentialSigning>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> AuthStartStart([WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<bodyauthenticationContextTypeInput> bodyauthenticationContextType, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodyphoneNumber = null)
        {
            var apiCallPath = "/Auth/Start";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyssn != null)
            {
                body["ssn"] = ExpressionConverter.ConvertO(bodyssn);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["flowKey"] = ExpressionConverter.ConvertO(bodyflowKey);
            bodypropCount++;
            body["authenticationContextType"] = ExpressionConverter.ConvertO(bodyauthenticationContextType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartAuthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<PollCustomer> AuthPollPoll([WorkflowExpression] Func<string> bodyauthRequestId, [WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<bodylookupTypeInput> bodylookupType)
        {
            var apiCallPath = "/Auth/Poll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["authRequestId"] = ExpressionConverter.ConvertO(bodyauthRequestId);
            bodypropCount++;
            body["flowKey"] = ExpressionConverter.ConvertO(bodyflowKey);
            bodypropCount++;
            body["lookupType"] = ExpressionConverter.ConvertO(bodylookupType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PollCustomer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> RequestToViewSequenceStartsequentialSequenceKeyauth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sequenceKey, [WorkflowExpression] Func<string> bodysequenceKey, [WorkflowExpression] Func<string> bodyloginHint, [WorkflowExpression] Func<bodyauthenticationContextTypeInput> bodyauthenticationContextType)
        {
            var apiCallPath = String.Format("/signing/sequential/{0}/auth", ExpressionConverter.ConvertWithUrlEncoding(sequenceKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sequenceKey"] = ExpressionConverter.ConvertO(bodysequenceKey);
            bodypropCount++;
            body["loginHint"] = ExpressionConverter.ConvertO(bodyloginHint);
            bodypropCount++;
            body["authenticationContextType"] = ExpressionConverter.ConvertO(bodyauthenticationContextType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartAuthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> GetSigningProcessBySigneeProcessKeysigneeSigneeKeyGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> processKey, [WorkflowExpression] Func<string> signeeKey, [WorkflowExpression] Func<string> userAgent = null)
        {
            var apiCallPath = String.Format("/signing/{0}/signee/{1}", ExpressionConverter.ConvertWithUrlEncoding(processKey, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userAgent != null)
                callPayload.Queries["UserAgent"] = ExpressionConverter.Convert(userAgent);
            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<Signee> UpdateSigneeProcessKeysigneeSigneeKeyCreate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> signeeKey, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> processKey, [WorkflowExpression] Func<string> bodysigneeKey, [WorkflowExpression] Func<string> bodyprocessKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            var apiCallPath = String.Format("/signing/{0}/signee/{1}", ExpressionConverter.ConvertWithUrlEncoding(processKey, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postalCode"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            bodypropCount++;
            body["signeeKey"] = ExpressionConverter.ConvertO(bodysigneeKey);
            bodypropCount++;
            body["processKey"] = ExpressionConverter.ConvertO(bodyprocessKey);
            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodyuser != null)
            {
                body["user"] = ExpressionConverter.ConvertO(bodyuser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Signee>(callPayload);
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

    public enum bodysignatureLocationInput
    {
        TopFirstPage,
        BottomLastPage
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

    public enum bodyauthenticationContextTypeInput
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

    public enum bodylookupTypeInput
    {
        NameAddress,
        Name,
        NameAddressFamily
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