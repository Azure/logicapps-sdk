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
        public IBodyWorkflowAction<GetWorkspacesV2ResponseItem[]> GetWorkspacesV2()
        {
            var apiCallPath = "/v2/workspaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWorkspacesV2ResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IWorkflowAction RegisterWebhookV2New(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var apiCallPath = String.Format("/v2/registerwebhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetContractPdfV2(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var apiCallPath = String.Format("/v2/contract/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewResponse> SignContractFromProvidedFileV2New(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodypeopleInputItem[]>> bodypeople, Expression<Func<string>> bodycontractNumber = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<bodysettingsrulesForSendingEMailsAndSignaturesInput>> bodysettingsrulesForSendingEMailsAndSignatures = null, Expression<Func<string>> bodysettingsautosignByProposer = null, Expression<Func<bodysettingsautomaticSignPlacementInput>> bodysettingsautomaticSignPlacement = null)
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
        public IBodyWorkflowAction<SignContractFromProvidedFileV2Response> SignContractFromProvidedFileV2(Expression<Func<string>> workspaceId, Expression<Func<int>> bodysignatureSignerPage, Expression<Func<string>> bodysignerEMail, Expression<Func<bodysignerTypeInput>> bodysignerType, Expression<Func<string>> bodycontractSignDate, Expression<Func<string>> bodyauthorEMail, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodycontractName, Expression<Func<string>> bodysignerPhone, Expression<Func<string>> bodyfile, Expression<Func<string>> bodysignerSurname, Expression<Func<string>> bodysignerFirstName, Expression<Func<int>> bodysignatureSignerX, Expression<Func<bool>> bodysignerShouldSign, Expression<Func<int>> bodysignatureSignerY, Expression<Func<bool>> bodyauthorShouldSign, Expression<Func<int>> bodysignatureAuthorPage = null, Expression<Func<string>> bodysignerDateOfBirth = null, Expression<Func<string>> bodysignerStreet = null, Expression<Func<string>> bodysignerVATID = null, Expression<Func<string>> bodysignerCity = null, Expression<Func<string>> bodysignerCompanyName = null, Expression<Func<int>> bodysignatureAuthorX = null, Expression<Func<string>> bodysignerCompanyID = null, Expression<Func<string>> bodysignerZIP = null, Expression<Func<int>> bodysignatureAuthorY = null, Expression<Func<string>> bodycontractNumber = null, Expression<Func<string>> bodycontractSignLocation = null)
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
            body["webhooks[1][url]"] = "@listcallbackurl()";
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

            body["webhooks[0][url]"] = "@listcallbackurl()";
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
            body["webhooks[2][url]"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SignContractFromProvidedFileV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetContractDetailV2Response> GetContractDetailV2(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var apiCallPath = String.Format("/v2/contract/{0}", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<GetContractDetailV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetTemplatesV2Response> GetTemplatesV2(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = "/v2/contract/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            return new ApiConnectionAction<GetTemplatesV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string> GetRevisionListPdfV2(Expression<Func<string>> workspaceId, Expression<Func<string>> bodycontractID = null)
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
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewWaitResponse> SignContractFromProvidedFileV2NewWait(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodypeopleInputItem2[]>> bodypeople, Expression<Func<string>> bodycontractNumber = null, Expression<Func<bodylanguageInput>> bodylanguage = null, Expression<Func<bodysettingsrulesForSendingEMailsAndSignaturesInput>> bodysettingsrulesForSendingEMailsAndSignatures = null, Expression<Func<string>> bodysettingsautosignByProposer = null, Expression<Func<bodysettingsautomaticSignPlacementInput>> bodysettingsautomaticSignPlacement = null)
        {
            var apiCallPath = "/v2.1/contract/sign/provided/wait";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(workspaceId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
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
    }

    public class SigniTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetWorkspacesV2ResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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
        public bodypeopleInputItemContractRoleIfSignIsChosenPositionMustBeFilledInType ContractRoleIfSignIsChosenPositionMustBeFilledIn { get; set; }

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
        public double PositionOfSignatureGivenInFromTheLengthOfTheDocument { get; set; }

        [JsonProperty("page")]
        public double NumberOfPage { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("x")]
        public double PositionOfSignatureGivenInFromTheWidthOfTheDocument { get; set; }
    }

    public enum bodypeopleInputItemContractRoleIfSignIsChosenPositionMustBeFilledInType
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
        public bodypeopleInputItemContractRoleIfSignIsChosenPositionMustBeFilledInType ContractRoleIfSignIsChosenPositionMustBeFilledIn { get; set; }

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