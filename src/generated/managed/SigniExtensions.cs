//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigniActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IWorkflowAction RegisterWebhookV2New([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            var apiCallPath = String.Format("/v2/registerwebhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewResponse> SignContractFromProvidedFileV2New([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent, [WorkflowExpression] Func<bodypeopleInputItem[]> bodypeople, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodysettingsrulesForSendingEMailsAndSignaturesInput> bodysettingsrulesForSendingEMailsAndSignatures = null, [WorkflowExpression] Func<string> bodysettingsautosignByProposer = null, [WorkflowExpression] Func<bodysettingsautomaticSignPlacementInput> bodysettingsautomaticSignPlacement = null)
        {
            var apiCallPath = "/v2.1/contract/sign/provided";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodycontractNumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodycontractNumber);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["locale"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            bodypropCount++;
            body["fileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            bodypropCount++;
            body["people"] = ExpressionConverter.ConvertO(bodypeople);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsrulesForSendingEMailsAndSignatures != null)
            {
                settingsObject["signing_order"] = ExpressionConverter.ConvertO(bodysettingsrulesForSendingEMailsAndSignatures);
                settingsObjectpropCount++;
            }

            if (bodysettingsautosignByProposer != null)
            {
                settingsObject["autosign_proposers"] = ExpressionConverter.ConvertO(bodysettingsautosignByProposer);
                settingsObjectpropCount++;
            }

            if (bodysettingsautomaticSignPlacement != null)
            {
                settingsObject["missing_positions"] = ExpressionConverter.ConvertO(bodysettingsautomaticSignPlacement);
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

            return new ApiConnectionAction<SignContractFromProvidedFileV2NewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewWaitResponse> SignContractFromProvidedFileV2NewWait([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodyfileContent, [WorkflowExpression] Func<bodypeopleInputItem2[]> bodypeople, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodysettingsrulesForSendingEMailsAndSignaturesInput> bodysettingsrulesForSendingEMailsAndSignatures = null, [WorkflowExpression] Func<string> bodysettingsautosignByProposer = null, [WorkflowExpression] Func<bodysettingsautomaticSignPlacementInput> bodysettingsautomaticSignPlacement = null)
        {
            var apiCallPath = "/v2.1/contract/sign/provided/wait";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodycontractNumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodycontractNumber);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["locale"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            bodypropCount++;
            body["fileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            bodypropCount++;
            body["people"] = ExpressionConverter.ConvertO(bodypeople);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsrulesForSendingEMailsAndSignatures != null)
            {
                settingsObject["signing_order"] = ExpressionConverter.ConvertO(bodysettingsrulesForSendingEMailsAndSignatures);
                settingsObjectpropCount++;
            }

            if (bodysettingsautosignByProposer != null)
            {
                settingsObject["autosign_proposers"] = ExpressionConverter.ConvertO(bodysettingsautosignByProposer);
                settingsObjectpropCount++;
            }

            if (bodysettingsautomaticSignPlacement != null)
            {
                settingsObject["missing_positions"] = ExpressionConverter.ConvertO(bodysettingsautomaticSignPlacement);
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

            return new ApiConnectionAction<SignContractFromProvidedFileV2NewWaitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetContractDetailV2Response> GetContractDetail([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            var apiCallPath = String.Format("/v2/contract/{0}", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<GetContractDetailV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetContractPdf([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> workspaceId, [WorkflowExpression] Func<string> contractId)
        {
            var apiCallPath = String.Format("/v2/contract/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetRevisionListPdf([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> bodycontractID = null)
        {
            var apiCallPath = "/v2/contract/revisionList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractID != null)
            {
                body["contract_id"] = ExpressionConverter.ConvertO(bodycontractID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetTemplatesV2Response> GetTemplates([WorkflowExpression] Func<string> workspaceId)
        {
            var apiCallPath = "/v2/contract/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<GetTemplatesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetWorkspacesV2ResponseItem[]> GetWorkspaces()
        {
            var apiCallPath = "/v2/workspaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWorkspacesV2ResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2Response> SignContractFromProvidedFile([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<int> bodysignatureSignerPage, [WorkflowExpression] Func<string> bodysignerEMail, [WorkflowExpression] Func<bodysignerTypeInput> bodysignerType, [WorkflowExpression] Func<string> bodycontractSignDate, [WorkflowExpression] Func<string> bodyauthorEMail, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodycontractName, [WorkflowExpression] Func<string> bodysignerPhone, [WorkflowExpression] Func<string> bodyfile, [WorkflowExpression] Func<string> bodysignerSurname, [WorkflowExpression] Func<string> bodysignerFirstName, [WorkflowExpression] Func<int> bodysignatureSignerX, [WorkflowExpression] Func<bool> bodysignerShouldSign, [WorkflowExpression] Func<int> bodysignatureSignerY, [WorkflowExpression] Func<bool> bodyauthorShouldSign, [WorkflowExpression] Func<int> bodysignatureAuthorPage = null, [WorkflowExpression] Func<string> bodysignerDateOfBirth = null, [WorkflowExpression] Func<string> bodysignerStreet = null, [WorkflowExpression] Func<string> bodysignerVATID = null, [WorkflowExpression] Func<string> bodysignerCity = null, [WorkflowExpression] Func<string> bodysignerCompanyName = null, [WorkflowExpression] Func<int> bodysignatureAuthorX = null, [WorkflowExpression] Func<string> bodysignerCompanyID = null, [WorkflowExpression] Func<string> bodysignerZIP = null, [WorkflowExpression] Func<int> bodysignatureAuthorY = null, [WorkflowExpression] Func<string> bodycontractNumber = null, [WorkflowExpression] Func<string> bodycontractSignLocation = null)
        {
            var apiCallPath = "/v2/contract/sign/provided";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sign_negotiator[position][page]"] = ExpressionConverter.ConvertO(bodysignatureSignerPage);
            bodypropCount++;
            body["email_signer"] = ExpressionConverter.ConvertO(bodysignerEMail);
            bodypropCount++;
            body["person_type"] = ExpressionConverter.ConvertO(bodysignerType);
            bodypropCount++;
            body["sign_date"] = ExpressionConverter.ConvertO(bodycontractSignDate);
            if (bodysignatureAuthorPage != null)
            {
                body["sign_proposer[position][page]"] = ExpressionConverter.ConvertO(bodysignatureAuthorPage);
                bodypropCount++;
            }

            if (bodysignerDateOfBirth != null)
            {
                body["date_of_birth"] = ExpressionConverter.ConvertO(bodysignerDateOfBirth);
                bodypropCount++;
            }

            body["webhooks[0][state]"] = "signed";
            bodypropCount++;
            bodypropCount++;
            body["email_author"] = ExpressionConverter.ConvertO(bodyauthorEMail);
            if (bodysignerStreet != null)
            {
                body["street"] = ExpressionConverter.ConvertO(bodysignerStreet);
                bodypropCount++;
            }

            if (bodysignerVATID != null)
            {
                body["dic"] = ExpressionConverter.ConvertO(bodysignerVATID);
                bodypropCount++;
            }

            bodypropCount++;
            body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
            body["webhooks[1][url]"] = "#{listCallbackUrl()}";
            bodypropCount++;
            body["webhooks[1][state]"] = "rejected";
            bodypropCount++;
            bodypropCount++;
            body["contract_name"] = ExpressionConverter.ConvertO(bodycontractName);
            if (bodysignerCity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodysignerCity);
                bodypropCount++;
            }

            bodypropCount++;
            body["phone_signer"] = ExpressionConverter.ConvertO(bodysignerPhone);
            body["last_document"] = true;
            bodypropCount++;
            bodypropCount++;
            body["file"] = ExpressionConverter.ConvertO(bodyfile);
            bodypropCount++;
            body["lastname_signer"] = ExpressionConverter.ConvertO(bodysignerSurname);
            if (bodysignerCompanyName != null)
            {
                body["company_name"] = ExpressionConverter.ConvertO(bodysignerCompanyName);
                bodypropCount++;
            }

            if (bodysignatureAuthorX != null)
            {
                body["sign_proposer[position][x]"] = ExpressionConverter.ConvertO(bodysignatureAuthorX);
                bodypropCount++;
            }

            bodypropCount++;
            body["firstname_signer"] = ExpressionConverter.ConvertO(bodysignerFirstName);
            if (bodysignerCompanyID != null)
            {
                body["ic"] = ExpressionConverter.ConvertO(bodysignerCompanyID);
                bodypropCount++;
            }

            body["webhooks[0][url]"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodysignerZIP != null)
            {
                body["zip_code"] = ExpressionConverter.ConvertO(bodysignerZIP);
                bodypropCount++;
            }

            bodypropCount++;
            body["sign_negotiator[position][x]"] = ExpressionConverter.ConvertO(bodysignatureSignerX);
            body["webhooks[2][state]"] = "expired";
            bodypropCount++;
            bodypropCount++;
            body["negotiator_sign"] = ExpressionConverter.ConvertO(bodysignerShouldSign);
            bodypropCount++;
            body["sign_negotiator[position][y]"] = ExpressionConverter.ConvertO(bodysignatureSignerY);
            if (bodysignatureAuthorY != null)
            {
                body["sign_proposer[position][y]"] = ExpressionConverter.ConvertO(bodysignatureAuthorY);
                bodypropCount++;
            }

            if (bodycontractNumber != null)
            {
                body["contract_number"] = ExpressionConverter.ConvertO(bodycontractNumber);
                bodypropCount++;
            }

            if (bodycontractSignLocation != null)
            {
                body["sign_place"] = ExpressionConverter.ConvertO(bodycontractSignLocation);
                bodypropCount++;
            }

            bodypropCount++;
            body["proposer_sign"] = ExpressionConverter.ConvertO(bodyauthorShouldSign);
            body["webhooks[2][url]"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignContractFromProvidedFileV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromTemplateV2Response> SignContractFromTemplate([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<bodypersonTypeInput> bodypersonType, [WorkflowExpression] Func<string> bodyemailSigner, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycontractName, [WorkflowExpression] Func<bool> bodynegotiatorSign, [WorkflowExpression] Func<bool> bodyproposerSign, [WorkflowExpression] Func<string> bodyemailAuthor, [WorkflowExpression] Func<string> bodystreet = null, [WorkflowExpression] Func<string> bodylastnameSigner = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodydic = null, [WorkflowExpression] Func<object> bodyparameters = null, [WorkflowExpression] Func<string> bodyic = null, [WorkflowExpression] Func<string> bodysignDate = null, [WorkflowExpression] Func<string> bodysignPlace = null, [WorkflowExpression] Func<string> bodyfirstnameSigner = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodyphoneSigner = null, [WorkflowExpression] Func<string> bodydateOfBirth = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<string> bodycontractNumber = null)
        {
            var apiCallPath = "/v2/contract/sign/template";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystreet != null)
            {
                body["street"] = ExpressionConverter.ConvertO(bodystreet);
                bodypropCount++;
            }

            bodypropCount++;
            body["person_type"] = ExpressionConverter.ConvertO(bodypersonType);
            bodypropCount++;
            body["email_signer"] = ExpressionConverter.ConvertO(bodyemailSigner);
            if (bodylastnameSigner != null)
            {
                body["lastname_signer"] = ExpressionConverter.ConvertO(bodylastnameSigner);
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
                body["company_name"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodydic != null)
            {
                body["dic"] = ExpressionConverter.ConvertO(bodydic);
                bodypropCount++;
            }

            if (bodyparameters != null)
            {
                body["parameters"] = ExpressionConverter.ConvertO(bodyparameters);
                bodypropCount++;
            }

            bodypropCount++;
            body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
            if (bodyic != null)
            {
                body["ic"] = ExpressionConverter.ConvertO(bodyic);
                bodypropCount++;
            }

            if (bodysignDate != null)
            {
                body["sign_date"] = ExpressionConverter.ConvertO(bodysignDate);
                bodypropCount++;
            }

            if (bodysignPlace != null)
            {
                body["sign_place"] = ExpressionConverter.ConvertO(bodysignPlace);
                bodypropCount++;
            }

            bodypropCount++;
            body["contract_name"] = ExpressionConverter.ConvertO(bodycontractName);
            bodypropCount++;
            body["negotiator_sign"] = ExpressionConverter.ConvertO(bodynegotiatorSign);
            if (bodyfirstnameSigner != null)
            {
                body["firstname_signer"] = ExpressionConverter.ConvertO(bodyfirstnameSigner);
                bodypropCount++;
            }

            bodypropCount++;
            body["proposer_sign"] = ExpressionConverter.ConvertO(bodyproposerSign);
            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodyphoneSigner != null)
            {
                body["phone_signer"] = ExpressionConverter.ConvertO(bodyphoneSigner);
                bodypropCount++;
            }

            if (bodydateOfBirth != null)
            {
                body["date_of_birth"] = ExpressionConverter.ConvertO(bodydateOfBirth);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["zip_code"] = ExpressionConverter.ConvertO(bodyzipCode);
                bodypropCount++;
            }

            if (bodycontractNumber != null)
            {
                body["contract_number"] = ExpressionConverter.ConvertO(bodycontractNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["email_author"] = ExpressionConverter.ConvertO(bodyemailAuthor);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignContractFromTemplateV2Response>(callPayload);
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

    public class bodypeopleInputItem2
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