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
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityactivityProcessKeyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> processKey, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[]>(() =>
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
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityForUseractivityuserGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<string>> user = null, Expression<Func<string>> processKey = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[]>(() =>
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
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityByCompanyactivitycompanyGet(Expression<Func<string>> startDate, Expression<Func<string>> endDate, Expression<Func<int>> take = null, Expression<Func<int>> skip = null, Expression<Func<string>> user = null, Expression<Func<flowTypeInput>> flowType = null, Expression<Func<string>> flowKey = null)
        {
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            var __workflow_flowType = WorkflowExpression.Compile(flowType, nameof(flowType), required: false);
            var __workflow_flowKey = WorkflowExpression.Compile(flowKey, nameof(flowKey), required: false);
            return new DeferredBodyAction<SigningProcessActivityLogWrapper[]>(() =>
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
        public IBodyWorkflowAction<SealingResponse> SealingRequestsealing(Expression<Func<string>> bodypdfDocument, Expression<Func<string>> bodyflowKey, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylanguageType = null)
        {
            var __workflow_bodypdfDocument = WorkflowExpression.Compile(bodypdfDocument, nameof(bodypdfDocument), required: true);
            var __workflow_bodyflowKey = WorkflowExpression.Compile(bodyflowKey, nameof(bodyflowKey), required: true);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodylanguageType = WorkflowExpression.Compile(bodylanguageType, nameof(bodylanguageType), required: false);
            return new DeferredBodyAction<SealingResponse>(() =>
            {
                var apiCallPath = "/management/sealing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfDocument"] = ExpressionConverter.ConvertO(__workflow_bodypdfDocument);
                bodypropCount++;
                body["flowKey"] = ExpressionConverter.ConvertO(__workflow_bodyflowKey);
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodylanguageType != null)
                {
                    body["languageType"] = ExpressionConverter.ConvertO(__workflow_bodylanguageType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SealingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CancelSigningProcesssigningDelete(Expression<Func<string>> processKey = null, Expression<Func<string>> user = null)
        {
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: false);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: false);
            return new DeferredBodyAction<SigningProcess>(() =>
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
        public IBodyWorkflowAction<SigningProcess> CreateSigningProcesssigning(Expression<Func<string>> bodyflowKey, Expression<Func<string>> bodypdfDocument = null, Expression<Func<string>> bodypdfFileName = null, Expression<Func<CreateSignee[]>> bodycreateSignees = null, Expression<Func<SigningAttachment[]>> bodyattachments = null, Expression<Func<AttachmentReference[]>> bodyattachmentReferences = null, Expression<Func<bool>> bodyrequiresAuth = null, Expression<Func<bool>> bodysignInOrder = null, Expression<Func<bodysignatureLocationInput>> bodysignatureLocation = null, Expression<Func<string>> bodyuser = null, Expression<Func<string>> bodysequenceKey = null, Expression<Func<string>> bodyactivityDisplayName = null, Expression<Func<bool>> bodyflattenDocument = null, Expression<Func<string>> bodyreminderRule = null)
        {
            var __workflow_bodyflowKey = WorkflowExpression.Compile(bodyflowKey, nameof(bodyflowKey), required: true);
            var __workflow_bodypdfDocument = WorkflowExpression.Compile(bodypdfDocument, nameof(bodypdfDocument), required: false);
            var __workflow_bodypdfFileName = WorkflowExpression.Compile(bodypdfFileName, nameof(bodypdfFileName), required: false);
            var __workflow_bodycreateSignees = WorkflowExpression.Compile(bodycreateSignees, nameof(bodycreateSignees), required: false);
            var __workflow_bodyattachments = WorkflowExpression.Compile(bodyattachments, nameof(bodyattachments), required: false);
            var __workflow_bodyattachmentReferences = WorkflowExpression.Compile(bodyattachmentReferences, nameof(bodyattachmentReferences), required: false);
            var __workflow_bodyrequiresAuth = WorkflowExpression.Compile(bodyrequiresAuth, nameof(bodyrequiresAuth), required: false);
            var __workflow_bodysignInOrder = WorkflowExpression.Compile(bodysignInOrder, nameof(bodysignInOrder), required: false);
            var __workflow_bodysignatureLocation = WorkflowExpression.Compile(bodysignatureLocation, nameof(bodysignatureLocation), required: false);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: false);
            var __workflow_bodysequenceKey = WorkflowExpression.Compile(bodysequenceKey, nameof(bodysequenceKey), required: false);
            var __workflow_bodyactivityDisplayName = WorkflowExpression.Compile(bodyactivityDisplayName, nameof(bodyactivityDisplayName), required: false);
            var __workflow_bodyflattenDocument = WorkflowExpression.Compile(bodyflattenDocument, nameof(bodyflattenDocument), required: false);
            var __workflow_bodyreminderRule = WorkflowExpression.Compile(bodyreminderRule, nameof(bodyreminderRule), required: false);
            return new DeferredBodyAction<SigningProcess>(() =>
            {
                var apiCallPath = "/management/signing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypdfDocument != null)
                {
                    body["pdfDocument"] = ExpressionConverter.ConvertO(__workflow_bodypdfDocument);
                    bodypropCount++;
                }

                if (__workflow_bodypdfFileName != null)
                {
                    body["pdfFileName"] = ExpressionConverter.ConvertO(__workflow_bodypdfFileName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["flowKey"] = ExpressionConverter.ConvertO(__workflow_bodyflowKey);
                if (__workflow_bodycreateSignees != null)
                {
                    body["createSignees"] = ExpressionConverter.ConvertO(__workflow_bodycreateSignees);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (__workflow_bodyattachments != null)
                {
                    body["attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (__workflow_bodyattachmentReferences != null)
                {
                    body["attachmentReferences"] = ExpressionConverter.ConvertO(__workflow_bodyattachmentReferences);
                    bodypropCount++;
                }

                if (__workflow_bodyrequiresAuth != null)
                {
                    body["requiresAuth"] = ExpressionConverter.ConvertO(__workflow_bodyrequiresAuth);
                    bodypropCount++;
                }

                if (__workflow_bodysignInOrder != null)
                {
                    body["signInOrder"] = ExpressionConverter.ConvertO(__workflow_bodysignInOrder);
                    bodypropCount++;
                }

                if (__workflow_bodysignatureLocation != null)
                {
                    body["signatureLocation"] = ExpressionConverter.ConvertO(__workflow_bodysignatureLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (__workflow_bodysequenceKey != null)
                {
                    body["sequenceKey"] = ExpressionConverter.ConvertO(__workflow_bodysequenceKey);
                    bodypropCount++;
                }

                if (__workflow_bodyactivityDisplayName != null)
                {
                    body["activityDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodyactivityDisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodyflattenDocument != null)
                {
                    body["flattenDocument"] = ExpressionConverter.ConvertO(__workflow_bodyflattenDocument);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderRule != null)
                {
                    body["reminderRule"] = ExpressionConverter.ConvertO(__workflow_bodyreminderRule);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SigningProcess>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<JToken> SealingXmlRequestsealingxml(Expression<Func<string>> bodyxmlDocument, Expression<Func<string>> bodyflowKey)
        {
            var __workflow_bodyxmlDocument = WorkflowExpression.Compile(bodyxmlDocument, nameof(bodyxmlDocument), required: true);
            var __workflow_bodyflowKey = WorkflowExpression.Compile(bodyflowKey, nameof(bodyflowKey), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/management/sealing/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["xmlDocument"] = ExpressionConverter.ConvertO(__workflow_bodyxmlDocument);
                bodypropCount++;
                body["flowKey"] = ExpressionConverter.ConvertO(__workflow_bodyflowKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CancelSequenceSigningsigningsequentialDelete(Expression<Func<string>> sequenceKey, Expression<Func<string>> user)
        {
            var __workflow_sequenceKey = WorkflowExpression.Compile(sequenceKey, nameof(sequenceKey), required: true);
            var __workflow_user = WorkflowExpression.Compile(user, nameof(user), required: true);
            return new DeferredBodyAction<SequentialSigning>(() =>
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
        public IBodyWorkflowAction<SequentialSigning> CreateSequentialSigningsigningsequential(Expression<Func<CreateSigningProcess[]>> bodycreateSigningProcesses, Expression<Func<string>> bodyuser, Expression<Func<bool>> bodyrequiresAuth = null, Expression<Func<bool>> bodysignInOrder = null)
        {
            var __workflow_bodycreateSigningProcesses = WorkflowExpression.Compile(bodycreateSigningProcesses, nameof(bodycreateSigningProcesses), required: true);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: true);
            var __workflow_bodyrequiresAuth = WorkflowExpression.Compile(bodyrequiresAuth, nameof(bodyrequiresAuth), required: false);
            var __workflow_bodysignInOrder = WorkflowExpression.Compile(bodysignInOrder, nameof(bodysignInOrder), required: false);
            return new DeferredBodyAction<SequentialSigning>(() =>
            {
                var apiCallPath = "/management/signing/sequential";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["createSigningProcesses"] = ExpressionConverter.ConvertO(__workflow_bodycreateSigningProcesses);
                bodypropCount++;
                body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                if (__workflow_bodyrequiresAuth != null)
                {
                    body["requiresAuth"] = ExpressionConverter.ConvertO(__workflow_bodyrequiresAuth);
                    bodypropCount++;
                }

                if (__workflow_bodysignInOrder != null)
                {
                    body["signInOrder"] = ExpressionConverter.ConvertO(__workflow_bodysignInOrder);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SequentialSigning>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> AuthStartStart(Expression<Func<string>> bodyflowKey, Expression<Func<bodyauthenticationContextTypeInput>> bodyauthenticationContextType, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodyphoneNumber = null)
        {
            var __workflow_bodyflowKey = WorkflowExpression.Compile(bodyflowKey, nameof(bodyflowKey), required: true);
            var __workflow_bodyauthenticationContextType = WorkflowExpression.Compile(bodyauthenticationContextType, nameof(bodyauthenticationContextType), required: true);
            var __workflow_bodyssn = WorkflowExpression.Compile(bodyssn, nameof(bodyssn), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            return new DeferredBodyAction<StartAuthResponse>(() =>
            {
                var apiCallPath = "/Auth/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyssn != null)
                {
                    body["ssn"] = ExpressionConverter.ConvertO(__workflow_bodyssn);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["flowKey"] = ExpressionConverter.ConvertO(__workflow_bodyflowKey);
                bodypropCount++;
                body["authenticationContextType"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationContextType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartAuthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<PollCustomer> AuthPollPoll(Expression<Func<string>> bodyauthRequestId, Expression<Func<string>> bodyflowKey, Expression<Func<bodylookupTypeInput>> bodylookupType)
        {
            var __workflow_bodyauthRequestId = WorkflowExpression.Compile(bodyauthRequestId, nameof(bodyauthRequestId), required: true);
            var __workflow_bodyflowKey = WorkflowExpression.Compile(bodyflowKey, nameof(bodyflowKey), required: true);
            var __workflow_bodylookupType = WorkflowExpression.Compile(bodylookupType, nameof(bodylookupType), required: true);
            return new DeferredBodyAction<PollCustomer>(() =>
            {
                var apiCallPath = "/Auth/Poll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["authRequestId"] = ExpressionConverter.ConvertO(__workflow_bodyauthRequestId);
                bodypropCount++;
                body["flowKey"] = ExpressionConverter.ConvertO(__workflow_bodyflowKey);
                bodypropCount++;
                body["lookupType"] = ExpressionConverter.ConvertO(__workflow_bodylookupType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PollCustomer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> RequestToViewSequenceStartsequentialSequenceKeyauth(Expression<Func<string>> sequenceKey, Expression<Func<string>> bodysequenceKey, Expression<Func<string>> bodyloginHint, Expression<Func<bodyauthenticationContextTypeInput>> bodyauthenticationContextType)
        {
            var __workflow_sequenceKey = WorkflowExpression.Compile(sequenceKey, nameof(sequenceKey), required: true);
            var __workflow_bodysequenceKey = WorkflowExpression.Compile(bodysequenceKey, nameof(bodysequenceKey), required: true);
            var __workflow_bodyloginHint = WorkflowExpression.Compile(bodyloginHint, nameof(bodyloginHint), required: true);
            var __workflow_bodyauthenticationContextType = WorkflowExpression.Compile(bodyauthenticationContextType, nameof(bodyauthenticationContextType), required: true);
            return new DeferredBodyAction<StartAuthResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/sequential/{0}/auth", __workflow_sequenceKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sequenceKey"] = ExpressionConverter.ConvertO(__workflow_bodysequenceKey);
                bodypropCount++;
                body["loginHint"] = ExpressionConverter.ConvertO(__workflow_bodyloginHint);
                bodypropCount++;
                body["authenticationContextType"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationContextType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartAuthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> GetSigningProcessBySigneeProcessKeysigneeSigneeKeyGet(Expression<Func<string>> processKey, Expression<Func<string>> signeeKey, Expression<Func<string>> userAgent = null)
        {
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_signeeKey = WorkflowExpression.Compile(signeeKey, nameof(signeeKey), required: true);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            return new DeferredBodyAction<SigningProcess>(() =>
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
        public IBodyWorkflowAction<Signee> UpdateSigneeProcessKeysigneeSigneeKeyCreate(Expression<Func<string>> signeeKey, Expression<Func<string>> processKey, Expression<Func<string>> bodysigneeKey, Expression<Func<string>> bodyprocessKey, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodyuser = null)
        {
            var __workflow_signeeKey = WorkflowExpression.Compile(signeeKey, nameof(signeeKey), required: true);
            var __workflow_processKey = WorkflowExpression.Compile(processKey, nameof(processKey), required: true);
            var __workflow_bodysigneeKey = WorkflowExpression.Compile(bodysigneeKey, nameof(bodysigneeKey), required: true);
            var __workflow_bodyprocessKey = WorkflowExpression.Compile(bodyprocessKey, nameof(bodyprocessKey), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: false);
            return new DeferredBodyAction<Signee>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signing/{0}/signee/{1}", __workflow_processKey.WithUrlEncoding(1), __workflow_signeeKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["signeeKey"] = ExpressionConverter.ConvertO(__workflow_bodysigneeKey);
                bodypropCount++;
                body["processKey"] = ExpressionConverter.ConvertO(__workflow_bodyprocessKey);
                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
