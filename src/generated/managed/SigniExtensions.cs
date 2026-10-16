//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SigniActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IWorkflowAction RegisterWebhookV2New(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/registerwebhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contractId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewResponse> SignContractFromProvidedFileV2New(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodypeopleInputItem[]>> bodypeople, Expression<Func<string>> bodycontractNumber = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<bodysettingsrulesForSendingEMailsAndSignaturesInput>> bodysettingsrulesForSendingEMailsAndSignatures = null, Expression<Func<string>> bodysettingsautosignByProposer = null, Expression<Func<bodysettingsautomaticSignPlacementInput>> bodysettingsautomaticSignPlacement = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: true);
            var __workflow_bodypeople = WorkflowExpression.Compile(bodypeople, nameof(bodypeople), required: true);
            var __workflow_bodycontractNumber = WorkflowExpression.Compile(bodycontractNumber, nameof(bodycontractNumber), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodysettingsrulesForSendingEMailsAndSignatures = WorkflowExpression.Compile(bodysettingsrulesForSendingEMailsAndSignatures, nameof(bodysettingsrulesForSendingEMailsAndSignatures), required: false);
            var __workflow_bodysettingsautosignByProposer = WorkflowExpression.Compile(bodysettingsautosignByProposer, nameof(bodysettingsautosignByProposer), required: false);
            var __workflow_bodysettingsautomaticSignPlacement = WorkflowExpression.Compile(bodysettingsautomaticSignPlacement, nameof(bodysettingsautomaticSignPlacement), required: false);
            return new DeferredBodyAction<SignContractFromProvidedFileV2NewResponse>(() =>
            {
                var apiCallPath = "/v2.1/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileName"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodycontractNumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodycontractNumber);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["fileContent"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                bodypropCount++;
                body["people"] = ExpressionConverter.ConvertO(__workflow_bodypeople);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsrulesForSendingEMailsAndSignatures != null)
                {
                    settingsObject["signing_order"] = ExpressionConverter.ConvertO(__workflow_bodysettingsrulesForSendingEMailsAndSignatures);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsautosignByProposer != null)
                {
                    settingsObject["autosign_proposers"] = ExpressionConverter.ConvertO(__workflow_bodysettingsautosignByProposer);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsautomaticSignPlacement != null)
                {
                    settingsObject["missing_positions"] = ExpressionConverter.ConvertO(__workflow_bodysettingsautomaticSignPlacement);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewWaitResponse> SignContractFromProvidedFileV2NewWait(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodypeopleInputItem2[]>> bodypeople, Expression<Func<string>> bodycontractNumber = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<bodysettingsrulesForSendingEMailsAndSignaturesInput>> bodysettingsrulesForSendingEMailsAndSignatures = null, Expression<Func<string>> bodysettingsautosignByProposer = null, Expression<Func<bodysettingsautomaticSignPlacementInput>> bodysettingsautomaticSignPlacement = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: true);
            var __workflow_bodypeople = WorkflowExpression.Compile(bodypeople, nameof(bodypeople), required: true);
            var __workflow_bodycontractNumber = WorkflowExpression.Compile(bodycontractNumber, nameof(bodycontractNumber), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodysettingsrulesForSendingEMailsAndSignatures = WorkflowExpression.Compile(bodysettingsrulesForSendingEMailsAndSignatures, nameof(bodysettingsrulesForSendingEMailsAndSignatures), required: false);
            var __workflow_bodysettingsautosignByProposer = WorkflowExpression.Compile(bodysettingsautosignByProposer, nameof(bodysettingsautosignByProposer), required: false);
            var __workflow_bodysettingsautomaticSignPlacement = WorkflowExpression.Compile(bodysettingsautomaticSignPlacement, nameof(bodysettingsautomaticSignPlacement), required: false);
            return new DeferredBodyAction<SignContractFromProvidedFileV2NewWaitResponse>(() =>
            {
                var apiCallPath = "/v2.1/contract/sign/provided/wait";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["fileName"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                if (__workflow_bodycontractNumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodycontractNumber);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["fileContent"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                bodypropCount++;
                body["people"] = ExpressionConverter.ConvertO(__workflow_bodypeople);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsrulesForSendingEMailsAndSignatures != null)
                {
                    settingsObject["signing_order"] = ExpressionConverter.ConvertO(__workflow_bodysettingsrulesForSendingEMailsAndSignatures);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsautosignByProposer != null)
                {
                    settingsObject["autosign_proposers"] = ExpressionConverter.ConvertO(__workflow_bodysettingsautosignByProposer);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodysettingsautomaticSignPlacement != null)
                {
                    settingsObject["missing_positions"] = ExpressionConverter.ConvertO(__workflow_bodysettingsautomaticSignPlacement);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetContractDetailV2Response> GetContractDetail(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredBodyAction<GetContractDetailV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contract/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<GetContractDetailV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetContractPdf(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/contract/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contractId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetRevisionListPdf(Expression<Func<string>> workspaceId, Expression<Func<string>> bodycontractID = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_bodycontractID = WorkflowExpression.Compile(bodycontractID, nameof(bodycontractID), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/contract/revisionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontractID != null)
                {
                    body["contract_id"] = ExpressionConverter.ConvertO(__workflow_bodycontractID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetTemplatesV2Response> GetTemplates(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GetTemplatesV2Response>(() =>
            {
                var apiCallPath = "/v2/contract/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<GetTemplatesV2Response>(callPayload);
            });
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
        public IBodyWorkflowAction<SignContractFromProvidedFileV2Response> SignContractFromProvidedFile(Expression<Func<string>> workspaceId, Expression<Func<int>> bodysignatureSignerPage, Expression<Func<string>> bodysignerEMail, Expression<Func<bodysignerTypeInput>> bodysignerType, Expression<Func<string>> bodycontractSignDate, Expression<Func<string>> bodyauthorEMail, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodycontractName, Expression<Func<string>> bodysignerPhone, Expression<Func<string>> bodyfile, Expression<Func<string>> bodysignerSurname, Expression<Func<string>> bodysignerFirstName, Expression<Func<int>> bodysignatureSignerX, Expression<Func<bool>> bodysignerShouldSign, Expression<Func<int>> bodysignatureSignerY, Expression<Func<bool>> bodyauthorShouldSign, Expression<Func<int>> bodysignatureAuthorPage = null, Expression<Func<string>> bodysignerDateOfBirth = null, Expression<Func<string>> bodysignerStreet = null, Expression<Func<string>> bodysignerVATID = null, Expression<Func<string>> bodysignerCity = null, Expression<Func<string>> bodysignerCompanyName = null, Expression<Func<int>> bodysignatureAuthorX = null, Expression<Func<string>> bodysignerCompanyID = null, Expression<Func<string>> bodysignerZIP = null, Expression<Func<int>> bodysignatureAuthorY = null, Expression<Func<string>> bodycontractNumber = null, Expression<Func<string>> bodycontractSignLocation = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_bodysignatureSignerPage = WorkflowExpression.Compile(bodysignatureSignerPage, nameof(bodysignatureSignerPage), required: true);
            var __workflow_bodysignerEMail = WorkflowExpression.Compile(bodysignerEMail, nameof(bodysignerEMail), required: true);
            var __workflow_bodysignerType = WorkflowExpression.Compile(bodysignerType, nameof(bodysignerType), required: true);
            var __workflow_bodycontractSignDate = WorkflowExpression.Compile(bodycontractSignDate, nameof(bodycontractSignDate), required: true);
            var __workflow_bodyauthorEMail = WorkflowExpression.Compile(bodyauthorEMail, nameof(bodyauthorEMail), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodycontractName = WorkflowExpression.Compile(bodycontractName, nameof(bodycontractName), required: true);
            var __workflow_bodysignerPhone = WorkflowExpression.Compile(bodysignerPhone, nameof(bodysignerPhone), required: true);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: true);
            var __workflow_bodysignerSurname = WorkflowExpression.Compile(bodysignerSurname, nameof(bodysignerSurname), required: true);
            var __workflow_bodysignerFirstName = WorkflowExpression.Compile(bodysignerFirstName, nameof(bodysignerFirstName), required: true);
            var __workflow_bodysignatureSignerX = WorkflowExpression.Compile(bodysignatureSignerX, nameof(bodysignatureSignerX), required: true);
            var __workflow_bodysignerShouldSign = WorkflowExpression.Compile(bodysignerShouldSign, nameof(bodysignerShouldSign), required: true);
            var __workflow_bodysignatureSignerY = WorkflowExpression.Compile(bodysignatureSignerY, nameof(bodysignatureSignerY), required: true);
            var __workflow_bodyauthorShouldSign = WorkflowExpression.Compile(bodyauthorShouldSign, nameof(bodyauthorShouldSign), required: true);
            var __workflow_bodysignatureAuthorPage = WorkflowExpression.Compile(bodysignatureAuthorPage, nameof(bodysignatureAuthorPage), required: false);
            var __workflow_bodysignerDateOfBirth = WorkflowExpression.Compile(bodysignerDateOfBirth, nameof(bodysignerDateOfBirth), required: false);
            var __workflow_bodysignerStreet = WorkflowExpression.Compile(bodysignerStreet, nameof(bodysignerStreet), required: false);
            var __workflow_bodysignerVATID = WorkflowExpression.Compile(bodysignerVATID, nameof(bodysignerVATID), required: false);
            var __workflow_bodysignerCity = WorkflowExpression.Compile(bodysignerCity, nameof(bodysignerCity), required: false);
            var __workflow_bodysignerCompanyName = WorkflowExpression.Compile(bodysignerCompanyName, nameof(bodysignerCompanyName), required: false);
            var __workflow_bodysignatureAuthorX = WorkflowExpression.Compile(bodysignatureAuthorX, nameof(bodysignatureAuthorX), required: false);
            var __workflow_bodysignerCompanyID = WorkflowExpression.Compile(bodysignerCompanyID, nameof(bodysignerCompanyID), required: false);
            var __workflow_bodysignerZIP = WorkflowExpression.Compile(bodysignerZIP, nameof(bodysignerZIP), required: false);
            var __workflow_bodysignatureAuthorY = WorkflowExpression.Compile(bodysignatureAuthorY, nameof(bodysignatureAuthorY), required: false);
            var __workflow_bodycontractNumber = WorkflowExpression.Compile(bodycontractNumber, nameof(bodycontractNumber), required: false);
            var __workflow_bodycontractSignLocation = WorkflowExpression.Compile(bodycontractSignLocation, nameof(bodycontractSignLocation), required: false);
            return new DeferredBodyAction<SignContractFromProvidedFileV2Response>(() =>
            {
                var apiCallPath = "/v2/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sign_negotiator[position][page]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureSignerPage);
                bodypropCount++;
                body["email_signer"] = ExpressionConverter.ConvertO(__workflow_bodysignerEMail);
                bodypropCount++;
                body["person_type"] = ExpressionConverter.ConvertO(__workflow_bodysignerType);
                bodypropCount++;
                body["sign_date"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignDate);
                if (__workflow_bodysignatureAuthorPage != null)
                {
                    body["sign_proposer[position][page]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureAuthorPage);
                    bodypropCount++;
                }

                if (__workflow_bodysignerDateOfBirth != null)
                {
                    body["date_of_birth"] = ExpressionConverter.ConvertO(__workflow_bodysignerDateOfBirth);
                    bodypropCount++;
                }

                body["webhooks[0][state]"] = "signed";
                bodypropCount++;
                bodypropCount++;
                body["email_author"] = ExpressionConverter.ConvertO(__workflow_bodyauthorEMail);
                if (__workflow_bodysignerStreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(__workflow_bodysignerStreet);
                    bodypropCount++;
                }

                if (__workflow_bodysignerVATID != null)
                {
                    body["dic"] = ExpressionConverter.ConvertO(__workflow_bodysignerVATID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                body["webhooks[1][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["webhooks[1][state]"] = "rejected";
                bodypropCount++;
                bodypropCount++;
                body["contract_name"] = ExpressionConverter.ConvertO(__workflow_bodycontractName);
                if (__workflow_bodysignerCity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodysignerCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phone_signer"] = ExpressionConverter.ConvertO(__workflow_bodysignerPhone);
                body["last_document"] = true;
                bodypropCount++;
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                bodypropCount++;
                body["lastname_signer"] = ExpressionConverter.ConvertO(__workflow_bodysignerSurname);
                if (__workflow_bodysignerCompanyName != null)
                {
                    body["company_name"] = ExpressionConverter.ConvertO(__workflow_bodysignerCompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodysignatureAuthorX != null)
                {
                    body["sign_proposer[position][x]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureAuthorX);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstname_signer"] = ExpressionConverter.ConvertO(__workflow_bodysignerFirstName);
                if (__workflow_bodysignerCompanyID != null)
                {
                    body["ic"] = ExpressionConverter.ConvertO(__workflow_bodysignerCompanyID);
                    bodypropCount++;
                }

                body["webhooks[0][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodysignerZIP != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodysignerZIP);
                    bodypropCount++;
                }

                bodypropCount++;
                body["sign_negotiator[position][x]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureSignerX);
                body["webhooks[2][state]"] = "expired";
                bodypropCount++;
                bodypropCount++;
                body["negotiator_sign"] = ExpressionConverter.ConvertO(__workflow_bodysignerShouldSign);
                bodypropCount++;
                body["sign_negotiator[position][y]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureSignerY);
                if (__workflow_bodysignatureAuthorY != null)
                {
                    body["sign_proposer[position][y]"] = ExpressionConverter.ConvertO(__workflow_bodysignatureAuthorY);
                    bodypropCount++;
                }

                if (__workflow_bodycontractNumber != null)
                {
                    body["contract_number"] = ExpressionConverter.ConvertO(__workflow_bodycontractNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycontractSignLocation != null)
                {
                    body["sign_place"] = ExpressionConverter.ConvertO(__workflow_bodycontractSignLocation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["proposer_sign"] = ExpressionConverter.ConvertO(__workflow_bodyauthorShouldSign);
                body["webhooks[2][url]"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SignContractFromProvidedFileV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromTemplateV2Response> SignContractFromTemplate(Expression<Func<string>> workspaceId, Expression<Func<bodypersonTypeInput>> bodypersonType, Expression<Func<string>> bodyemailSigner, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodycontractName, Expression<Func<bool>> bodynegotiatorSign, Expression<Func<bool>> bodyproposerSign, Expression<Func<string>> bodyemailAuthor, Expression<Func<string>> bodystreet = null, Expression<Func<string>> bodylastnameSigner = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodydic = null, Expression<Func<object>> bodyparameters = null, Expression<Func<string>> bodyic = null, Expression<Func<string>> bodysignDate = null, Expression<Func<string>> bodysignPlace = null, Expression<Func<string>> bodyfirstnameSigner = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodyphoneSigner = null, Expression<Func<string>> bodydateOfBirth = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<string>> bodycontractNumber = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_bodypersonType = WorkflowExpression.Compile(bodypersonType, nameof(bodypersonType), required: true);
            var __workflow_bodyemailSigner = WorkflowExpression.Compile(bodyemailSigner, nameof(bodyemailSigner), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodycontractName = WorkflowExpression.Compile(bodycontractName, nameof(bodycontractName), required: true);
            var __workflow_bodynegotiatorSign = WorkflowExpression.Compile(bodynegotiatorSign, nameof(bodynegotiatorSign), required: true);
            var __workflow_bodyproposerSign = WorkflowExpression.Compile(bodyproposerSign, nameof(bodyproposerSign), required: true);
            var __workflow_bodyemailAuthor = WorkflowExpression.Compile(bodyemailAuthor, nameof(bodyemailAuthor), required: true);
            var __workflow_bodystreet = WorkflowExpression.Compile(bodystreet, nameof(bodystreet), required: false);
            var __workflow_bodylastnameSigner = WorkflowExpression.Compile(bodylastnameSigner, nameof(bodylastnameSigner), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodydic = WorkflowExpression.Compile(bodydic, nameof(bodydic), required: false);
            var __workflow_bodyparameters = WorkflowExpression.Compile(bodyparameters, nameof(bodyparameters), required: false);
            var __workflow_bodyic = WorkflowExpression.Compile(bodyic, nameof(bodyic), required: false);
            var __workflow_bodysignDate = WorkflowExpression.Compile(bodysignDate, nameof(bodysignDate), required: false);
            var __workflow_bodysignPlace = WorkflowExpression.Compile(bodysignPlace, nameof(bodysignPlace), required: false);
            var __workflow_bodyfirstnameSigner = WorkflowExpression.Compile(bodyfirstnameSigner, nameof(bodyfirstnameSigner), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodyphoneSigner = WorkflowExpression.Compile(bodyphoneSigner, nameof(bodyphoneSigner), required: false);
            var __workflow_bodydateOfBirth = WorkflowExpression.Compile(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            var __workflow_bodyzipCode = WorkflowExpression.Compile(bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodycontractNumber = WorkflowExpression.Compile(bodycontractNumber, nameof(bodycontractNumber), required: false);
            return new DeferredBodyAction<SignContractFromTemplateV2Response>(() =>
            {
                var apiCallPath = "/v2/contract/sign/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystreet != null)
                {
                    body["street"] = ExpressionConverter.ConvertO(__workflow_bodystreet);
                    bodypropCount++;
                }

                bodypropCount++;
                body["person_type"] = ExpressionConverter.ConvertO(__workflow_bodypersonType);
                bodypropCount++;
                body["email_signer"] = ExpressionConverter.ConvertO(__workflow_bodyemailSigner);
                if (__workflow_bodylastnameSigner != null)
                {
                    body["lastname_signer"] = ExpressionConverter.ConvertO(__workflow_bodylastnameSigner);
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
                if (__workflow_bodycompanyName != null)
                {
                    body["company_name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodydic != null)
                {
                    body["dic"] = ExpressionConverter.ConvertO(__workflow_bodydic);
                    bodypropCount++;
                }

                if (__workflow_bodyparameters != null)
                {
                    body["parameters"] = ExpressionConverter.ConvertO(__workflow_bodyparameters);
                    bodypropCount++;
                }

                bodypropCount++;
                body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                if (__workflow_bodyic != null)
                {
                    body["ic"] = ExpressionConverter.ConvertO(__workflow_bodyic);
                    bodypropCount++;
                }

                if (__workflow_bodysignDate != null)
                {
                    body["sign_date"] = ExpressionConverter.ConvertO(__workflow_bodysignDate);
                    bodypropCount++;
                }

                if (__workflow_bodysignPlace != null)
                {
                    body["sign_place"] = ExpressionConverter.ConvertO(__workflow_bodysignPlace);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contract_name"] = ExpressionConverter.ConvertO(__workflow_bodycontractName);
                bodypropCount++;
                body["negotiator_sign"] = ExpressionConverter.ConvertO(__workflow_bodynegotiatorSign);
                if (__workflow_bodyfirstnameSigner != null)
                {
                    body["firstname_signer"] = ExpressionConverter.ConvertO(__workflow_bodyfirstnameSigner);
                    bodypropCount++;
                }

                bodypropCount++;
                body["proposer_sign"] = ExpressionConverter.ConvertO(__workflow_bodyproposerSign);
                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneSigner != null)
                {
                    body["phone_signer"] = ExpressionConverter.ConvertO(__workflow_bodyphoneSigner);
                    bodypropCount++;
                }

                if (__workflow_bodydateOfBirth != null)
                {
                    body["date_of_birth"] = ExpressionConverter.ConvertO(__workflow_bodydateOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycontractNumber != null)
                {
                    body["contract_number"] = ExpressionConverter.ConvertO(__workflow_bodycontractNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email_author"] = ExpressionConverter.ConvertO(__workflow_bodyemailAuthor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SignContractFromTemplateV2Response>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypeopleInputItemContractRoleType
    {
        [EnumMember(Value = "sign")]
        Sign,
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "stamp")]
        Stamp
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypeopleInputItemTypeOfPersonType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysettingsrulesForSendingEMailsAndSignaturesInput
    {
        [EnumMember(Value = "all_at_once")]
        AllAtOnce,
        [EnumMember(Value = "proposers_before_counterparties")]
        ProposersBeforeCounterparties,
        [EnumMember(Value = "one_at_a_time")]
        OneAtATime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
