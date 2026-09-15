//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Taktikalcore
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TaktikalcoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityactivityProcessKeyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> processKey, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/signing/activity/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (user != null)
                callPayload.Queries["User"] = CSharpExpressionConverter.ConvertO(user);
            callPayload.Queries["StartDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["EndDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (flowType != null)
                callPayload.Queries["FlowType"] = CSharpExpressionConverter.Convert(flowType);
            if (take != null)
                callPayload.Queries["Take"] = CSharpExpressionConverter.ConvertO(take);
            if (skip != null)
                callPayload.Queries["Skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityForUseractivityuserGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> user = null, Expression<Func<string>> processKey = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var apiCallPath = "/signing/activity/user/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (user != null)
                callPayload.Queries["User"] = CSharpExpressionConverter.ConvertO(user);
            callPayload.Queries["StartDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["EndDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (processKey != null)
                callPayload.Queries["ProcessKey"] = CSharpExpressionConverter.ConvertO(processKey);
            if (flowType != null)
                callPayload.Queries["FlowType"] = CSharpExpressionConverter.Convert(flowType);
            if (take != null)
                callPayload.Queries["Take"] = CSharpExpressionConverter.ConvertO(take);
            if (skip != null)
                callPayload.Queries["Skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityByCompanyactivitycompanyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<string>> flowKey = null)
        {
            var apiCallPath = "/signing/activity/company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StartDate"] = CSharpExpressionConverter.ConvertO(startDate);
            callPayload.Queries["EndDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (take != null)
                callPayload.Queries["Take"] = CSharpExpressionConverter.ConvertO(take);
            if (skip != null)
                callPayload.Queries["Skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (user != null)
                callPayload.Queries["User"] = CSharpExpressionConverter.ConvertO(user);
            if (flowType != null)
                callPayload.Queries["FlowType"] = CSharpExpressionConverter.Convert(flowType);
            if (flowKey != null)
                callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SealingResponse> SealingRequestsealing(Expression<Func<string>> bodypdfDocument, Expression<Func<string>> bodyflowKey, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylanguageType = null)
        {
            var apiCallPath = "/management/sealing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pdfDocument"] = CSharpExpressionConverter.ConvertToken(bodypdfDocument);
            bodypropCount++;
            body["flowKey"] = CSharpExpressionConverter.ConvertToken(bodyflowKey);
            if (bodyreason != null)
            {
                body["reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodylanguageType != null)
            {
                body["languageType"] = CSharpExpressionConverter.ConvertToken(bodylanguageType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SealingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CancelSigningProcesssigningDelete(Expression<Func<string>> processKey = null, Expression<Func<string>> user = null)
        {
            var apiCallPath = "/management/signing";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (processKey != null)
                callPayload.Queries["ProcessKey"] = CSharpExpressionConverter.ConvertO(processKey);
            if (user != null)
                callPayload.Queries["User"] = CSharpExpressionConverter.ConvertO(user);
            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CreateSigningProcesssigning(Expression<Func<string>> bodyflowKey, Expression<Func<string>> bodypdfDocument = null, Expression<Func<string>> bodypdfFileName = null, Expression<Func<CreateSignee[]>> bodycreateSignees = null, Expression<Func<SigningAttachment[]>> bodyattachments = null, Expression<Func<AttachmentReference[]>> bodyattachmentReferences = null, Expression<Func<bool>> bodyrequiresAuth = null, Expression<Func<bool>> bodysignInOrder = null, Expression<Func<bodysignatureLocationInput>> bodysignatureLocation = null, Expression<Func<string>> bodyuser = null, Expression<Func<string>> bodysequenceKey = null, Expression<Func<string>> bodyactivityDisplayName = null, Expression<Func<bool>> bodyflattenDocument = null, Expression<Func<string>> bodyreminderRule = null)
        {
            var apiCallPath = "/management/signing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypdfDocument != null)
            {
                body["pdfDocument"] = CSharpExpressionConverter.ConvertToken(bodypdfDocument);
                bodypropCount++;
            }

            if (bodypdfFileName != null)
            {
                body["pdfFileName"] = CSharpExpressionConverter.ConvertToken(bodypdfFileName);
                bodypropCount++;
            }

            bodypropCount++;
            body["flowKey"] = CSharpExpressionConverter.ConvertToken(bodyflowKey);
            if (bodycreateSignees != null)
            {
                body["createSignees"] = CSharpExpressionConverter.ConvertToken(bodycreateSignees);
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
                body["attachments"] = CSharpExpressionConverter.ConvertToken(bodyattachments);
                bodypropCount++;
            }

            if (bodyattachmentReferences != null)
            {
                body["attachmentReferences"] = CSharpExpressionConverter.ConvertToken(bodyattachmentReferences);
                bodypropCount++;
            }

            if (bodyrequiresAuth != null)
            {
                body["requiresAuth"] = CSharpExpressionConverter.ConvertToken(bodyrequiresAuth);
                bodypropCount++;
            }

            if (bodysignInOrder != null)
            {
                body["signInOrder"] = CSharpExpressionConverter.ConvertToken(bodysignInOrder);
                bodypropCount++;
            }

            if (bodysignatureLocation != null)
            {
                body["signatureLocation"] = CSharpExpressionConverter.Convert(bodysignatureLocation);
                bodypropCount++;
            }

            if (bodyuser != null)
            {
                body["user"] = CSharpExpressionConverter.ConvertToken(bodyuser);
                bodypropCount++;
            }

            if (bodysequenceKey != null)
            {
                body["sequenceKey"] = CSharpExpressionConverter.ConvertToken(bodysequenceKey);
                bodypropCount++;
            }

            if (bodyactivityDisplayName != null)
            {
                body["activityDisplayName"] = CSharpExpressionConverter.ConvertToken(bodyactivityDisplayName);
                bodypropCount++;
            }

            if (bodyflattenDocument != null)
            {
                body["flattenDocument"] = CSharpExpressionConverter.ConvertToken(bodyflattenDocument);
                bodypropCount++;
            }

            if (bodyreminderRule != null)
            {
                body["reminderRule"] = CSharpExpressionConverter.ConvertToken(bodyreminderRule);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<JToken> SealingXmlRequestsealingxml(Expression<Func<string>> bodyxmlDocument, Expression<Func<string>> bodyflowKey)
        {
            var apiCallPath = "/management/sealing/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["xmlDocument"] = CSharpExpressionConverter.ConvertToken(bodyxmlDocument);
            bodypropCount++;
            body["flowKey"] = CSharpExpressionConverter.ConvertToken(bodyflowKey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CancelSequenceSigningsigningsequentialDelete(Expression<Func<string>> sequenceKey, Expression<Func<string>> user)
        {
            var apiCallPath = "/management/signing/sequential";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SequenceKey"] = CSharpExpressionConverter.ConvertO(sequenceKey);
            callPayload.Queries["User"] = CSharpExpressionConverter.ConvertO(user);
            return new ApiConnectionAction<SequentialSigning>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CreateSequentialSigningsigningsequential(Expression<Func<CreateSigningProcess[]>> bodycreateSigningProcesses, Expression<Func<string>> bodyuser, Expression<Func<bool>> bodyrequiresAuth = null, Expression<Func<bool>> bodysignInOrder = null)
        {
            var apiCallPath = "/management/signing/sequential";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["createSigningProcesses"] = CSharpExpressionConverter.ConvertToken(bodycreateSigningProcesses);
            bodypropCount++;
            body["user"] = CSharpExpressionConverter.ConvertToken(bodyuser);
            if (bodyrequiresAuth != null)
            {
                body["requiresAuth"] = CSharpExpressionConverter.ConvertToken(bodyrequiresAuth);
                bodypropCount++;
            }

            if (bodysignInOrder != null)
            {
                body["signInOrder"] = CSharpExpressionConverter.ConvertToken(bodysignInOrder);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SequentialSigning>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> AuthStartStart(Expression<Func<string>> bodyflowKey, Expression<Func<bodyauthenticationContextTypeInput>> bodyauthenticationContextType, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodyphoneNumber = null)
        {
            var apiCallPath = "/Auth/Start";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyssn != null)
            {
                body["ssn"] = CSharpExpressionConverter.ConvertToken(bodyssn);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["flowKey"] = CSharpExpressionConverter.ConvertToken(bodyflowKey);
            bodypropCount++;
            body["authenticationContextType"] = CSharpExpressionConverter.Convert(bodyauthenticationContextType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartAuthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<PollCustomer> AuthPollPoll(Expression<Func<string>> bodyauthRequestId, Expression<Func<string>> bodyflowKey, Expression<Func<bodylookupTypeInput>> bodylookupType)
        {
            var apiCallPath = "/Auth/Poll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["authRequestId"] = CSharpExpressionConverter.ConvertToken(bodyauthRequestId);
            bodypropCount++;
            body["flowKey"] = CSharpExpressionConverter.ConvertToken(bodyflowKey);
            bodypropCount++;
            body["lookupType"] = CSharpExpressionConverter.Convert(bodylookupType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PollCustomer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> RequestToViewSequenceStartsequentialSequenceKeyauth(Expression<Func<string>> sequenceKey, Expression<Func<string>> bodysequenceKey, Expression<Func<string>> bodyloginHint, Expression<Func<bodyauthenticationContextTypeInput>> bodyauthenticationContextType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/signing/sequential/{0}/auth", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sequenceKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sequenceKey"] = CSharpExpressionConverter.ConvertToken(bodysequenceKey);
            bodypropCount++;
            body["loginHint"] = CSharpExpressionConverter.ConvertToken(bodyloginHint);
            bodypropCount++;
            body["authenticationContextType"] = CSharpExpressionConverter.Convert(bodyauthenticationContextType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartAuthResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> GetSigningProcessBySigneeProcessKeysigneeSigneeKeyGet(Expression<Func<string>> processKey, Expression<Func<string>> signeeKey, Expression<Func<string>> userAgent = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/signing/{0}/signee/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userAgent != null)
                callPayload.Queries["UserAgent"] = CSharpExpressionConverter.ConvertO(userAgent);
            return new ApiConnectionAction<SigningProcess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<Signee> UpdateSigneeProcessKeysigneeSigneeKeyCreate(Expression<Func<string>> signeeKey, Expression<Func<string>> processKey, Expression<Func<string>> bodysigneeKey, Expression<Func<string>> bodyprocessKey, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodyuser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/signing/{0}/signee/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postalCode"] = CSharpExpressionConverter.ConvertToken(bodypostalCode);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            bodypropCount++;
            body["signeeKey"] = CSharpExpressionConverter.ConvertToken(bodysigneeKey);
            bodypropCount++;
            body["processKey"] = CSharpExpressionConverter.ConvertToken(bodyprocessKey);
            if (bodyreason != null)
            {
                body["reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodyuser != null)
            {
                body["user"] = CSharpExpressionConverter.ConvertToken(bodyuser);
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