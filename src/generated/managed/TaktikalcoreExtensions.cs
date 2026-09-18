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
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityactivityProcessKeyGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> processKey, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            SourceExpression.Validate(processKey, nameof(processKey), required: true);
            SourceExpression.Validate(user, nameof(user), required: false);
            SourceExpression.Validate(flowType, nameof(flowType), required: false);
            SourceExpression.Validate(take, nameof(take), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(flowKey, nameof(flowKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signing/activity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (user != null)
                    callPayload.Queries["User"] = SourceExpressionConverter.ConvertO(user);
                callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (flowType != null)
                    callPayload.Queries["FlowType"] = SourceExpressionConverter.Convert(flowType);
                if (take != null)
                    callPayload.Queries["Take"] = SourceExpressionConverter.ConvertO(take);
                if (skip != null)
                    callPayload.Queries["Skip"] = SourceExpressionConverter.ConvertO(skip);
                if (flowKey != null)
                    callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityForUseractivityuserGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<string> processKey = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            SourceExpression.Validate(user, nameof(user), required: false);
            SourceExpression.Validate(processKey, nameof(processKey), required: false);
            SourceExpression.Validate(flowType, nameof(flowType), required: false);
            SourceExpression.Validate(take, nameof(take), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(flowKey, nameof(flowKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signing/activity/user/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (user != null)
                    callPayload.Queries["User"] = SourceExpressionConverter.ConvertO(user);
                callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (processKey != null)
                    callPayload.Queries["ProcessKey"] = SourceExpressionConverter.ConvertO(processKey);
                if (flowType != null)
                    callPayload.Queries["FlowType"] = SourceExpressionConverter.Convert(flowType);
                if (take != null)
                    callPayload.Queries["Take"] = SourceExpressionConverter.ConvertO(take);
                if (skip != null)
                    callPayload.Queries["Skip"] = SourceExpressionConverter.ConvertO(skip);
                if (flowKey != null)
                    callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcessActivityLogWrapper[]> GetSigningProcessActivityByCompanyactivitycompanyGet([WorkflowExpression] Func<string> startDate, [WorkflowExpression] Func<string> endDate, [WorkflowExpression] Func<int> take = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> user = null, [WorkflowExpression] Func<flowTypeInput> flowType = null, [WorkflowExpression] Func<string> flowKey = null)
        {
            SourceExpression.Validate(startDate, nameof(startDate), required: true);
            SourceExpression.Validate(endDate, nameof(endDate), required: true);
            SourceExpression.Validate(take, nameof(take), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(user, nameof(user), required: false);
            SourceExpression.Validate(flowType, nameof(flowType), required: false);
            SourceExpression.Validate(flowKey, nameof(flowKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/signing/activity/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                callPayload.Queries["EndDate"] = SourceExpressionConverter.ConvertO(endDate);
                if (take != null)
                    callPayload.Queries["Take"] = SourceExpressionConverter.ConvertO(take);
                if (skip != null)
                    callPayload.Queries["Skip"] = SourceExpressionConverter.ConvertO(skip);
                if (user != null)
                    callPayload.Queries["User"] = SourceExpressionConverter.ConvertO(user);
                if (flowType != null)
                    callPayload.Queries["FlowType"] = SourceExpressionConverter.Convert(flowType);
                if (flowKey != null)
                    callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcessActivityLogWrapper[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SealingResponse> SealingRequestsealing([WorkflowExpression] Func<string> bodypdfDocument, [WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylanguageType = null)
        {
            SourceExpression.Validate(bodypdfDocument, nameof(bodypdfDocument), required: true);
            SourceExpression.Validate(bodyflowKey, nameof(bodyflowKey), required: true);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            SourceExpression.Validate(bodylanguageType, nameof(bodylanguageType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/sealing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfDocument"] = SourceExpressionConverter.ConvertToken(bodypdfDocument);
                bodypropCount++;
                body["flowKey"] = SourceExpressionConverter.ConvertToken(bodyflowKey);
                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodylanguageType != null)
                {
                    body["languageType"] = SourceExpressionConverter.ConvertToken(bodylanguageType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SealingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CancelSigningProcesssigningDelete([WorkflowExpression] Func<string> processKey = null, [WorkflowExpression] Func<string> user = null)
        {
            SourceExpression.Validate(processKey, nameof(processKey), required: false);
            SourceExpression.Validate(user, nameof(user), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/signing";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (processKey != null)
                    callPayload.Queries["ProcessKey"] = SourceExpressionConverter.ConvertO(processKey);
                if (user != null)
                    callPayload.Queries["User"] = SourceExpressionConverter.ConvertO(user);
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcess>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> CreateSigningProcesssigning([WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<string> bodypdfDocument = null, [WorkflowExpression] Func<string> bodypdfFileName = null, [WorkflowExpression] Func<CreateSignee[]> bodycreateSignees = null, [WorkflowExpression] Func<SigningAttachment[]> bodyattachments = null, [WorkflowExpression] Func<AttachmentReference[]> bodyattachmentReferences = null, [WorkflowExpression] Func<bool> bodyrequiresAuth = null, [WorkflowExpression] Func<bool> bodysignInOrder = null, [WorkflowExpression] Func<bodysignatureLocationInput> bodysignatureLocation = null, [WorkflowExpression] Func<string> bodyuser = null, [WorkflowExpression] Func<string> bodysequenceKey = null, [WorkflowExpression] Func<string> bodyactivityDisplayName = null, [WorkflowExpression] Func<bool> bodyflattenDocument = null, [WorkflowExpression] Func<string> bodyreminderRule = null)
        {
            SourceExpression.Validate(bodyflowKey, nameof(bodyflowKey), required: true);
            SourceExpression.Validate(bodypdfDocument, nameof(bodypdfDocument), required: false);
            SourceExpression.Validate(bodypdfFileName, nameof(bodypdfFileName), required: false);
            SourceExpression.Validate(bodycreateSignees, nameof(bodycreateSignees), required: false);
            SourceExpression.Validate(bodyattachments, nameof(bodyattachments), required: false);
            SourceExpression.Validate(bodyattachmentReferences, nameof(bodyattachmentReferences), required: false);
            SourceExpression.Validate(bodyrequiresAuth, nameof(bodyrequiresAuth), required: false);
            SourceExpression.Validate(bodysignInOrder, nameof(bodysignInOrder), required: false);
            SourceExpression.Validate(bodysignatureLocation, nameof(bodysignatureLocation), required: false);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            SourceExpression.Validate(bodysequenceKey, nameof(bodysequenceKey), required: false);
            SourceExpression.Validate(bodyactivityDisplayName, nameof(bodyactivityDisplayName), required: false);
            SourceExpression.Validate(bodyflattenDocument, nameof(bodyflattenDocument), required: false);
            SourceExpression.Validate(bodyreminderRule, nameof(bodyreminderRule), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/signing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypdfDocument != null)
                {
                    body["pdfDocument"] = SourceExpressionConverter.ConvertToken(bodypdfDocument);
                    bodypropCount++;
                }

                if (bodypdfFileName != null)
                {
                    body["pdfFileName"] = SourceExpressionConverter.ConvertToken(bodypdfFileName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["flowKey"] = SourceExpressionConverter.ConvertToken(bodyflowKey);
                if (bodycreateSignees != null)
                {
                    body["createSignees"] = SourceExpressionConverter.ConvertToken(bodycreateSignees);
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
                    body["attachments"] = SourceExpressionConverter.ConvertToken(bodyattachments);
                    bodypropCount++;
                }

                if (bodyattachmentReferences != null)
                {
                    body["attachmentReferences"] = SourceExpressionConverter.ConvertToken(bodyattachmentReferences);
                    bodypropCount++;
                }

                if (bodyrequiresAuth != null)
                {
                    body["requiresAuth"] = SourceExpressionConverter.ConvertToken(bodyrequiresAuth);
                    bodypropCount++;
                }

                if (bodysignInOrder != null)
                {
                    body["signInOrder"] = SourceExpressionConverter.ConvertToken(bodysignInOrder);
                    bodypropCount++;
                }

                if (bodysignatureLocation != null)
                {
                    body["signatureLocation"] = SourceExpressionConverter.Convert(bodysignatureLocation);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodysequenceKey != null)
                {
                    body["sequenceKey"] = SourceExpressionConverter.ConvertToken(bodysequenceKey);
                    bodypropCount++;
                }

                if (bodyactivityDisplayName != null)
                {
                    body["activityDisplayName"] = SourceExpressionConverter.ConvertToken(bodyactivityDisplayName);
                    bodypropCount++;
                }

                if (bodyflattenDocument != null)
                {
                    body["flattenDocument"] = SourceExpressionConverter.ConvertToken(bodyflattenDocument);
                    bodypropCount++;
                }

                if (bodyreminderRule != null)
                {
                    body["reminderRule"] = SourceExpressionConverter.ConvertToken(bodyreminderRule);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcess>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<JToken> SealingXmlRequestsealingxml([WorkflowExpression] Func<string> bodyxmlDocument, [WorkflowExpression] Func<string> bodyflowKey)
        {
            SourceExpression.Validate(bodyxmlDocument, nameof(bodyxmlDocument), required: true);
            SourceExpression.Validate(bodyflowKey, nameof(bodyflowKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/sealing/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["xmlDocument"] = SourceExpressionConverter.ConvertToken(bodyxmlDocument);
                bodypropCount++;
                body["flowKey"] = SourceExpressionConverter.ConvertToken(bodyflowKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CancelSequenceSigningsigningsequentialDelete([WorkflowExpression] Func<string> sequenceKey, [WorkflowExpression] Func<string> user)
        {
            SourceExpression.Validate(sequenceKey, nameof(sequenceKey), required: true);
            SourceExpression.Validate(user, nameof(user), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/signing/sequential";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SequenceKey"] = SourceExpressionConverter.ConvertO(sequenceKey);
                callPayload.Queries["User"] = SourceExpressionConverter.ConvertO(user);
                return callPayload;
            }

            return new ApiConnectionAction<SequentialSigning>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SequentialSigning> CreateSequentialSigningsigningsequential([WorkflowExpression] Func<CreateSigningProcess[]> bodycreateSigningProcesses, [WorkflowExpression] Func<string> bodyuser, [WorkflowExpression] Func<bool> bodyrequiresAuth = null, [WorkflowExpression] Func<bool> bodysignInOrder = null)
        {
            SourceExpression.Validate(bodycreateSigningProcesses, nameof(bodycreateSigningProcesses), required: true);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: true);
            SourceExpression.Validate(bodyrequiresAuth, nameof(bodyrequiresAuth), required: false);
            SourceExpression.Validate(bodysignInOrder, nameof(bodysignInOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/management/signing/sequential";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["createSigningProcesses"] = SourceExpressionConverter.ConvertToken(bodycreateSigningProcesses);
                bodypropCount++;
                body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                if (bodyrequiresAuth != null)
                {
                    body["requiresAuth"] = SourceExpressionConverter.ConvertToken(bodyrequiresAuth);
                    bodypropCount++;
                }

                if (bodysignInOrder != null)
                {
                    body["signInOrder"] = SourceExpressionConverter.ConvertToken(bodysignInOrder);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SequentialSigning>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> AuthStartStart([WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<bodyauthenticationContextTypeInput> bodyauthenticationContextType, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodyphoneNumber = null)
        {
            SourceExpression.Validate(bodyflowKey, nameof(bodyflowKey), required: true);
            SourceExpression.Validate(bodyauthenticationContextType, nameof(bodyauthenticationContextType), required: true);
            SourceExpression.Validate(bodyssn, nameof(bodyssn), required: false);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Auth/Start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyssn != null)
                {
                    body["ssn"] = SourceExpressionConverter.ConvertToken(bodyssn);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["flowKey"] = SourceExpressionConverter.ConvertToken(bodyflowKey);
                bodypropCount++;
                body["authenticationContextType"] = SourceExpressionConverter.Convert(bodyauthenticationContextType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StartAuthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<PollCustomer> AuthPollPoll([WorkflowExpression] Func<string> bodyauthRequestId, [WorkflowExpression] Func<string> bodyflowKey, [WorkflowExpression] Func<bodylookupTypeInput> bodylookupType)
        {
            SourceExpression.Validate(bodyauthRequestId, nameof(bodyauthRequestId), required: true);
            SourceExpression.Validate(bodyflowKey, nameof(bodyflowKey), required: true);
            SourceExpression.Validate(bodylookupType, nameof(bodylookupType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Auth/Poll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["authRequestId"] = SourceExpressionConverter.ConvertToken(bodyauthRequestId);
                bodypropCount++;
                body["flowKey"] = SourceExpressionConverter.ConvertToken(bodyflowKey);
                bodypropCount++;
                body["lookupType"] = SourceExpressionConverter.Convert(bodylookupType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PollCustomer>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<StartAuthResponse> RequestToViewSequenceStartsequentialSequenceKeyauth([WorkflowExpression] Func<string> sequenceKey, [WorkflowExpression] Func<string> bodysequenceKey, [WorkflowExpression] Func<string> bodyloginHint, [WorkflowExpression] Func<bodyauthenticationContextTypeInput> bodyauthenticationContextType)
        {
            SourceExpression.Validate(sequenceKey, nameof(sequenceKey), required: true);
            SourceExpression.Validate(bodysequenceKey, nameof(bodysequenceKey), required: true);
            SourceExpression.Validate(bodyloginHint, nameof(bodyloginHint), required: true);
            SourceExpression.Validate(bodyauthenticationContextType, nameof(bodyauthenticationContextType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signing/sequential/{0}/auth", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sequenceKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sequenceKey"] = SourceExpressionConverter.ConvertToken(bodysequenceKey);
                bodypropCount++;
                body["loginHint"] = SourceExpressionConverter.ConvertToken(bodyloginHint);
                bodypropCount++;
                body["authenticationContextType"] = SourceExpressionConverter.Convert(bodyauthenticationContextType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StartAuthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<SigningProcess> GetSigningProcessBySigneeProcessKeysigneeSigneeKeyGet([WorkflowExpression] Func<string> processKey, [WorkflowExpression] Func<string> signeeKey, [WorkflowExpression] Func<string> userAgent = null)
        {
            SourceExpression.Validate(processKey, nameof(processKey), required: true);
            SourceExpression.Validate(signeeKey, nameof(signeeKey), required: true);
            SourceExpression.Validate(userAgent, nameof(userAgent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signing/{0}/signee/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userAgent != null)
                    callPayload.Queries["UserAgent"] = SourceExpressionConverter.ConvertO(userAgent);
                return callPayload;
            }

            return new ApiConnectionAction<SigningProcess>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "taktikalcore")]
        public IBodyWorkflowAction<Signee> UpdateSigneeProcessKeysigneeSigneeKeyCreate([WorkflowExpression] Func<string> signeeKey, [WorkflowExpression] Func<string> processKey, [WorkflowExpression] Func<string> bodysigneeKey, [WorkflowExpression] Func<string> bodyprocessKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            SourceExpression.Validate(signeeKey, nameof(signeeKey), required: true);
            SourceExpression.Validate(processKey, nameof(processKey), required: true);
            SourceExpression.Validate(bodysigneeKey, nameof(bodysigneeKey), required: true);
            SourceExpression.Validate(bodyprocessKey, nameof(bodyprocessKey), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signing/{0}/signee/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(processKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postalCode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["signeeKey"] = SourceExpressionConverter.ConvertToken(bodysigneeKey);
                bodypropCount++;
                body["processKey"] = SourceExpressionConverter.ConvertToken(bodyprocessKey);
                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Signee>(BuildSourceInput);
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