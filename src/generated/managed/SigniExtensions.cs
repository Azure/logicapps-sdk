//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigniActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IWorkflowAction RegisterWebhookV2New([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/registerwebhook/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contractId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewResponse> SignContractFromProvidedFileV2New([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent, [WorkflowExpression] Func<bodypeopleInputItem[]> bodypeople, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodysettingsrulesForSendingEMailsAndSignaturesInput> bodysettingsrulesForSendingEMailsAndSignatures = null, [WorkflowExpression] Func<string> bodysettingsautosignByProposer = null, [WorkflowExpression] Func<bodysettingsautomaticSignPlacementInput> bodysettingsautomaticSignPlacement = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.1/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodycontractNumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodycontractNumber);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["locale"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["fileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
                body["people"] = SourceExpressionConverter.ConvertToken(bodypeople);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodysettingsrulesForSendingEMailsAndSignatures != null)
                {
                    settingsObject["signing_order"] = SourceExpressionConverter.Convert(bodysettingsrulesForSendingEMailsAndSignatures);
                    settingsObjectpropCount++;
                }

                if (bodysettingsautosignByProposer != null)
                {
                    settingsObject["autosign_proposers"] = SourceExpressionConverter.ConvertToken(bodysettingsautosignByProposer);
                    settingsObjectpropCount++;
                }

                if (bodysettingsautomaticSignPlacement != null)
                {
                    settingsObject["missing_positions"] = SourceExpressionConverter.Convert(bodysettingsautomaticSignPlacement);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                body["file"] = "uploaded_file_key";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SignContractFromProvidedFileV2NewResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewWaitResponse> SignContractFromProvidedFileV2NewWait([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent, [WorkflowExpression] Func<bodypeopleInputItem22[]> bodypeople, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodysettingsrulesForSendingEMailsAndSignaturesInput> bodysettingsrulesForSendingEMailsAndSignatures = null, [WorkflowExpression] Func<string> bodysettingsautosignByProposer = null, [WorkflowExpression] Func<bodysettingsautomaticSignPlacementInput> bodysettingsautomaticSignPlacement = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2.1/contract/sign/provided/wait";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodycontractNumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodycontractNumber);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["locale"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["fileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                bodypropCount++;
                body["people"] = SourceExpressionConverter.ConvertToken(bodypeople);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodysettingsrulesForSendingEMailsAndSignatures != null)
                {
                    settingsObject["signing_order"] = SourceExpressionConverter.Convert(bodysettingsrulesForSendingEMailsAndSignatures);
                    settingsObjectpropCount++;
                }

                if (bodysettingsautosignByProposer != null)
                {
                    settingsObject["autosign_proposers"] = SourceExpressionConverter.ConvertToken(bodysettingsautosignByProposer);
                    settingsObjectpropCount++;
                }

                if (bodysettingsautomaticSignPlacement != null)
                {
                    settingsObject["missing_positions"] = SourceExpressionConverter.Convert(bodysettingsautomaticSignPlacement);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                body["file"] = "uploaded_file_key";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SignContractFromProvidedFileV2NewWaitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetContractDetailV2Response> GetContractDetail([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contract/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContractDetailV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetContractPdf([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/contract/{0}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetRevisionListPdf([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodycontractId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contract/revisionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontractId != null)
                {
                    body["contract_id"] = SourceExpressionConverter.ConvertToken(bodycontractId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetTemplatesV2Response> GetTemplates([WorkflowExpression] Func<string> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contract/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplatesV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetWorkspacesV2ResponseItem[]> GetWorkspaces()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWorkspacesV2ResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2Response> SignContractFromProvidedFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<int> bodysignatureSignerPage, [WorkflowExpression] Func<string> bodysignerEMail, [WorkflowExpression] Func<bodysignerTypeInput> bodysignerType, [WorkflowExpression] Func<string> bodycontractSignDate, [WorkflowExpression] Func<string> bodyauthorEMail, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodycontractName, [WorkflowExpression] Func<string> bodysignerPhone, [WorkflowExpression] Func<string> bodyFile, [WorkflowExpression] Func<string> bodysignerSurname, [WorkflowExpression] Func<string> bodysignerFirstName, [WorkflowExpression] Func<int> bodysignatureSignerX, [WorkflowExpression] Func<bool> bodysignerShouldSign, [WorkflowExpression] Func<int> bodysignatureSignerY, [WorkflowExpression] Func<bool> bodyauthorShouldSign, [WorkflowExpression] Func<int> bodysignatureAuthorPage = null, [WorkflowExpression] Func<string> bodysignerDateOfBirth = null, [WorkflowExpression] Func<string> bodysignerStreet = null, [WorkflowExpression] Func<string> bodysignerVATId = null, [WorkflowExpression] Func<string> bodysignerCity = null, [WorkflowExpression] Func<string> bodysignerCompanyName = null, [WorkflowExpression] Func<int> bodysignatureAuthorX = null, [WorkflowExpression] Func<string> bodysignerCompanyId = null, [WorkflowExpression] Func<string> bodysignerZIP = null, [WorkflowExpression] Func<int> bodysignatureAuthorY = null, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<string> bodycontractSignLocation = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sign_negotiator[position][page]"] = SourceExpressionConverter.ConvertToken(bodysignatureSignerPage);
                bodypropCount++;
                body["email_signer"] = SourceExpressionConverter.ConvertToken(bodysignerEMail);
                bodypropCount++;
                body["person_type"] = SourceExpressionConverter.Convert(bodysignerType);
                bodypropCount++;
                body["sign_date"] = SourceExpressionConverter.ConvertToken(bodycontractSignDate);
                if (bodysignatureAuthorPage != null)
                {
                    body["sign_proposer[position][page]"] = SourceExpressionConverter.ConvertToken(bodysignatureAuthorPage);
                    bodypropCount++;
                }

                if (bodysignerDateOfBirth != null)
                {
                    body["date_of_birth"] = SourceExpressionConverter.ConvertToken(bodysignerDateOfBirth);
                    bodypropCount++;
                }

                body["webhooks[0][state]"] = "signed";
                bodypropCount++;
                bodypropCount++;
                body["email_author"] = SourceExpressionConverter.ConvertToken(bodyauthorEMail);
                if (bodysignerStreet != null)
                {
                    body["street"] = SourceExpressionConverter.ConvertToken(bodysignerStreet);
                    bodypropCount++;
                }

                if (bodysignerVATId != null)
                {
                    body["dic"] = SourceExpressionConverter.ConvertToken(bodysignerVATId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                body["webhooks[1][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["webhooks[1][state]"] = "rejected";
                bodypropCount++;
                bodypropCount++;
                body["contract_name"] = SourceExpressionConverter.ConvertToken(bodycontractName);
                if (bodysignerCity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodysignerCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phone_signer"] = SourceExpressionConverter.ConvertToken(bodysignerPhone);
                body["last_document"] = true;
                bodypropCount++;
                bodypropCount++;
                body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                bodypropCount++;
                body["lastname_signer"] = SourceExpressionConverter.ConvertToken(bodysignerSurname);
                if (bodysignerCompanyName != null)
                {
                    body["company_name"] = SourceExpressionConverter.ConvertToken(bodysignerCompanyName);
                    bodypropCount++;
                }

                if (bodysignatureAuthorX != null)
                {
                    body["sign_proposer[position][x]"] = SourceExpressionConverter.ConvertToken(bodysignatureAuthorX);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstname_signer"] = SourceExpressionConverter.ConvertToken(bodysignerFirstName);
                if (bodysignerCompanyId != null)
                {
                    body["ic"] = SourceExpressionConverter.ConvertToken(bodysignerCompanyId);
                    bodypropCount++;
                }

                body["webhooks[0][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodysignerZIP != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodysignerZIP);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sign_negotiator[position][x]"] = SourceExpressionConverter.ConvertToken(bodysignatureSignerX);
                body["webhooks[2][state]"] = "expired";
                bodypropCount++;
                bodypropCount++;
                body["negotiator_sign"] = SourceExpressionConverter.ConvertToken(bodysignerShouldSign);
                bodypropCount++;
                body["sign_negotiator[position][y]"] = SourceExpressionConverter.ConvertToken(bodysignatureSignerY);
                if (bodysignatureAuthorY != null)
                {
                    body["sign_proposer[position][y]"] = SourceExpressionConverter.ConvertToken(bodysignatureAuthorY);
                    bodypropCount++;
                }

                if (bodycontractNumber != null)
                {
                    body["contract_number"] = SourceExpressionConverter.ConvertToken(bodycontractNumber);
                    bodypropCount++;
                }

                if (bodycontractSignLocation != null)
                {
                    body["sign_place"] = SourceExpressionConverter.ConvertToken(bodycontractSignLocation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["proposer_sign"] = SourceExpressionConverter.ConvertToken(bodyauthorShouldSign);
                body["webhooks[2][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SignContractFromProvidedFileV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromTemplateV2Response> SignContractFromTemplate([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<bodypersonTypeInput> bodypersonType, [WorkflowExpression] Func<string> bodyemailSigner, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycontractName, [WorkflowExpression] Func<bool> bodynegotiatorSign, [WorkflowExpression] Func<bool> bodyproposerSign, [WorkflowExpression] Func<string> bodyemailAuthor, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodylastnameSigner = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodydic = null, [WorkflowExpression] Func<object> bodyparameters = null, [WorkflowExpression] Func<string> bodyic = null, [WorkflowExpression] Func<string> bodysignDate = null, [WorkflowExpression] Func<string> bodysignPlace = null, [WorkflowExpression] Func<string> bodyfirstnameSigner = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodyphoneSigner = null, [WorkflowExpression] Func<string> bodydateOfBirth = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycontractNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/contract/sign/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = SourceExpressionConverter.ConvertO(workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystreet != null)
                {
                    body["street"] = SourceExpressionConverter.ConvertToken(bodystreet);
                    bodypropCount++;
                }

                bodypropCount++;
                body["person_type"] = SourceExpressionConverter.Convert(bodypersonType);
                bodypropCount++;
                body["email_signer"] = SourceExpressionConverter.ConvertToken(bodyemailSigner);
                if (bodylastnameSigner != null)
                {
                    body["lastname_signer"] = SourceExpressionConverter.ConvertToken(bodylastnameSigner);
                    bodypropCount++;
                }

                var webhooksObject = new JObject();
                var webhooksObjectpropCount = 0;
                var _2Object = new JObject();
                var _2ObjectpropCount = 0;
                _2Object["state"] = "expired";
                _2ObjectpropCount++;
                _2Object["url"] = "#{listCallbackUrl()}";
                _2ObjectpropCount++;
                if (_2ObjectpropCount > 0)
                {
                    webhooksObject["2"] = _2Object;
                    webhooksObjectpropCount++;
                }

                var _1Object = new JObject();
                var _1ObjectpropCount = 0;
                _1Object["state"] = "rejected";
                _1ObjectpropCount++;
                _1Object["url"] = "#{listCallbackUrl()}";
                _1ObjectpropCount++;
                if (_1ObjectpropCount > 0)
                {
                    webhooksObject["1"] = _1Object;
                    webhooksObjectpropCount++;
                }

                var _0Object = new JObject();
                var _0ObjectpropCount = 0;
                _0Object["state"] = "signed";
                _0ObjectpropCount++;
                _0Object["url"] = "#{listCallbackUrl()}";
                _0ObjectpropCount++;
                if (_0ObjectpropCount > 0)
                {
                    webhooksObject["0"] = _0Object;
                    webhooksObjectpropCount++;
                }

                if (webhooksObjectpropCount > 0)
                {
                    body["webhooks"] = webhooksObject;
                    bodypropCount++;
                }

                body["last_document"] = true;
                bodypropCount++;
                if (bodycompanyName != null)
                {
                    body["company_name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodydic != null)
                {
                    body["dic"] = SourceExpressionConverter.ConvertToken(bodydic);
                    bodypropCount++;
                }

                if (bodyparameters != null)
                {
                    body["parameters"] = SourceExpressionConverter.ConvertToken(bodyparameters);
                    bodypropCount++;
                }

                bodypropCount++;
                body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                if (bodyic != null)
                {
                    body["ic"] = SourceExpressionConverter.ConvertToken(bodyic);
                    bodypropCount++;
                }

                if (bodysignDate != null)
                {
                    body["sign_date"] = SourceExpressionConverter.ConvertToken(bodysignDate);
                    bodypropCount++;
                }

                if (bodysignPlace != null)
                {
                    body["sign_place"] = SourceExpressionConverter.ConvertToken(bodysignPlace);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contract_name"] = SourceExpressionConverter.ConvertToken(bodycontractName);
                bodypropCount++;
                body["negotiator_sign"] = SourceExpressionConverter.ConvertToken(bodynegotiatorSign);
                if (bodyfirstnameSigner != null)
                {
                    body["firstname_signer"] = SourceExpressionConverter.ConvertToken(bodyfirstnameSigner);
                    bodypropCount++;
                }

                bodypropCount++;
                body["proposer_sign"] = SourceExpressionConverter.ConvertToken(bodyproposerSign);
                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodyphoneSigner != null)
                {
                    body["phone_signer"] = SourceExpressionConverter.ConvertToken(bodyphoneSigner);
                    bodypropCount++;
                }

                if (bodydateOfBirth != null)
                {
                    body["date_of_birth"] = SourceExpressionConverter.ConvertToken(bodydateOfBirth);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["zip_code"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodycontractNumber != null)
                {
                    body["contract_number"] = SourceExpressionConverter.ConvertToken(bodycontractNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email_author"] = SourceExpressionConverter.ConvertToken(bodyemailAuthor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SignContractFromTemplateV2Response>(BuildSourceInput);
        }
    }

    public class SigniTriggers([ConnectionName] string connectionId)
    {
    }

    public class SignContractFromProvidedFileV2NewResponse
    {
        [JsonProperty("notifications")]
        public SignContractFromProvidedFileV2NewResponseNotificationsTypeItem[] Notifications { get; set; }

        [JsonProperty("state")]
        public string StateOfContract { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("contract_id")]
        public int ContractID { get; set; }
    }

    public class SignContractFromProvidedFileV2NewResponseNotificationsTypeItem
    {
        [JsonProperty("email")]
        public string Notifications { get; set; }

        [JsonProperty("links")]
        public SignContractFromProvidedFileV2NewResponseNotificationsTypeItemLinksType Links { get; set; }
    }

    public class SignContractFromProvidedFileV2NewResponseNotificationsTypeItemLinksType
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }
    }

    public class bodypeopleInputItem
    {
        [JsonProperty("street")]
        public string SignerStreet { get; set; }

        [JsonProperty("company_name")]
        public string SignerCompanyName { get; set; }

        [JsonProperty("party_order")]
        public double OrderOfParty { get; set; }

        [JsonProperty("dic")]
        public string SignerVATID { get; set; }

        [JsonProperty("email")]
        public string SignerEmail { get; set; }

        [JsonProperty("ic")]
        public string SignerCompanyID { get; set; }

        [JsonProperty("positions")]
        public bodypeopleInputItemPositionsTypeItem[] Positions { get; set; }

        [JsonProperty("contract_role")]
        public bodypeopleInputItemContractRoleType ContractRole { get; set; }

        [JsonProperty("person_type")]
        public bodypeopleInputItemTypeOfPersonType TypeOfPerson { get; set; }

        [JsonProperty("zip_code")]
        public string SignerZIP { get; set; }

        [JsonProperty("is_proposer")]
        public bool ProposerOrNot { get; set; }

        [JsonProperty("city")]
        public string SignerCity { get; set; }

        [JsonProperty("last_name")]
        public string SignerLastName { get; set; }

        [JsonProperty("date_of_birth")]
        public string SignerDateOfBirth { get; set; }

        [JsonProperty("autosign_place")]
        public string PlaceOfAutosign { get; set; }

        [JsonProperty("first_name")]
        public string SignerFirstName { get; set; }

        [JsonProperty("phone")]
        public string SignerPhone { get; set; }
    }

    public class bodypeopleInputItemPositionsTypeItem
    {
        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("page")]
        public double NumberOfPage { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }
    }

    public enum bodypeopleInputItemContractRoleType
    {
        [EnumMember(Value = "sign")]
        Sign,
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "stamp")]
        Stamp
    }

    public enum bodypeopleInputItemTypeOfPersonType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    public enum bodylanguageInput
    {
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "vi")]
        Vi,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "hu")]
        Hu
    }

    public enum bodysettingsrulesForSendingEMailsAndSignaturesInput
    {
        [EnumMember(Value = "all_at_once")]
        AllAtOnce,
        [EnumMember(Value = "proposers_before_counterparties")]
        ProposersBeforeCounterparties,
        [EnumMember(Value = "one_at_a_time")]
        OneAtATime
    }

    public enum bodysettingsautomaticSignPlacementInput
    {
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "append_to_the_end")]
        AppendToTheEnd
    }

    public class SignContractFromProvidedFileV2NewWaitResponse
    {
        [JsonProperty("notifications")]
        public SignContractFromProvidedFileV2NewWaitResponseNotificationsTypeItem[] Notifications { get; set; }

        [JsonProperty("state")]
        public string StateOfContract { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("contract_id")]
        public int ContractID { get; set; }
    }

    public class SignContractFromProvidedFileV2NewWaitResponseNotificationsTypeItem
    {
        [JsonProperty("email")]
        public string Notifications { get; set; }

        [JsonProperty("links")]
        public SignContractFromProvidedFileV2NewWaitResponseNotificationsTypeItemLinksType Links { get; set; }
    }

    public class SignContractFromProvidedFileV2NewWaitResponseNotificationsTypeItemLinksType
    {
        [JsonProperty("contract")]
        public string Contract { get; set; }
    }

    public class bodypeopleInputItem22
    {
        [JsonProperty("street")]
        public string SignerStreet { get; set; }

        [JsonProperty("company_name")]
        public string SignerCompanyName { get; set; }

        [JsonProperty("party_order")]
        public double OrderOfParty { get; set; }

        [JsonProperty("dic")]
        public string SignerVATID { get; set; }

        [JsonProperty("email")]
        public string SignerEmail { get; set; }

        [JsonProperty("ic")]
        public string SignerCompanyID { get; set; }

        [JsonProperty("positions")]
        public bodypeopleInputItemPositionsTypeItem[] Positions { get; set; }

        [JsonProperty("contract_role")]
        public bodypeopleInputItemContractRoleType ContractRole { get; set; }

        [JsonProperty("person_type")]
        public bodypeopleInputItemTypeOfPersonType TypeOfPerson { get; set; }

        [JsonProperty("zip_code")]
        public string SignerZIP { get; set; }

        [JsonProperty("is_proposer")]
        public bool ProposerOrNot { get; set; }

        [JsonProperty("city")]
        public string SignerCity { get; set; }

        [JsonProperty("last_name")]
        public string SignerLastName { get; set; }

        [JsonProperty("date_of_birth")]
        public string SignerDateOfBirth { get; set; }

        [JsonProperty("autosign_place")]
        public string PlaceOfAutosign { get; set; }

        [JsonProperty("first_name")]
        public string SignerFirstName { get; set; }

        [JsonProperty("phone")]
        public string SignerPhone { get; set; }
    }

    public class GetContractDetailV2Response
    {
        [JsonProperty("signer_data")]
        public GetContractDetailV2ResponseSignerDataType SignerData { get; set; }

        [JsonProperty("contract_id")]
        public string ContractID { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("attachments")]
        public GetContractDetailV2ResponseAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class GetContractDetailV2ResponseSignerDataType
    {
        [JsonProperty("birthdate")]
        public string Birthday { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }
    }

    public class GetContractDetailV2ResponseAttachmentsTypeItem
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("contract_id")]
        public string ContractID { get; set; }
    }

    public class GetTemplatesV2Response
    {
        [JsonProperty("templates")]
        public GetTemplatesV2ResponseTemplatesTypeItem[] Templates { get; set; }
    }

    public class GetTemplatesV2ResponseTemplatesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parameters")]
        public GetTemplatesV2ResponseTemplatesTypeItemParametersTypeItem[] Parameters { get; set; }
    }

    public class GetTemplatesV2ResponseTemplatesTypeItemParametersTypeItem
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetWorkspacesV2ResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SignContractFromProvidedFileV2Response
    {
        [JsonProperty("contract_id")]
        public string ContractID { get; set; }
    }

    public enum bodysignerTypeInput
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    public class SignContractFromTemplateV2Response
    {
        [JsonProperty("contract_id")]
        public string ContractID { get; set; }
    }

    public enum bodypersonTypeInput
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signi;

    public partial class WorkflowManagedActions
    {
        public SigniActions Signi(string connectionId) => new SigniActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigniTriggers Signi(string connectionId) => new SigniTriggers(connectionId);
    }
}