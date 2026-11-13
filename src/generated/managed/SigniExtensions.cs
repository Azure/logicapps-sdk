//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigniActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RegisterWebhookV2New(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/registerwebhook/{0}", __workflow_contractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = new RegisterWebhookV2NewBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewResponse, ApiConnectionActionConfiguration> SignContractFromProvidedFileV2New(Expression<Func<string>> workspaceId, Expression<Func<SignContractFromProvidedFileV2NewBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignContractFromProvidedFileV2NewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.1/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignContractFromProvidedFileV2NewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileV2NewWaitResponse, ApiConnectionActionConfiguration> SignContractFromProvidedFileV2NewWait(Expression<Func<string>> workspaceId, Expression<Func<SignContractFromProvidedFileV2NewWaitBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignContractFromProvidedFileV2NewWaitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.1/contract/sign/provided/wait";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignContractFromProvidedFileV2NewWaitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetContractDetailResponse, ApiConnectionActionConfiguration> GetContractDetail(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredBodyAction<GetContractDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contract/{0}", __workflow_contractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<GetContractDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetContractPdf(Expression<Func<string>> workspaceId, Expression<Func<string>> contractId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_contractId = WorkflowExpression.Compile(contractId, nameof(contractId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/contract/{0}/download", __workflow_contractId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetRevisionListPdf(Expression<Func<string>> workspaceId, Expression<Func<GetRevisionListPdfBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contract/revisionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetTemplatesResponse, ApiConnectionActionConfiguration> GetTemplates(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GetTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contract/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                return new ApiConnectionAction<GetTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<GetWorkspacesResponseItem[], ApiConnectionActionConfiguration> GetWorkspaces()
        {
            return new DeferredBodyAction<GetWorkspacesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWorkspacesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromProvidedFileResponse, ApiConnectionActionConfiguration> SignContractFromProvidedFile(Expression<Func<string>> workspaceId, Expression<Func<SignContractFromProvidedFileBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignContractFromProvidedFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contract/sign/provided";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignContractFromProvidedFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signi")]
        public IBodyWorkflowAction<SignContractFromTemplateResponse, ApiConnectionActionConfiguration> SignContractFromTemplate(Expression<Func<string>> workspaceId, Expression<Func<SignContractFromTemplateBodyInput>> body)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignContractFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/contract/sign/template";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceId"] = ExpressionConverter.Convert(__workflow_workspaceId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignContractFromTemplateResponse>(callPayload);
            });
        }
    }

    public class SigniTriggers([ConnectionName] string connectionId)
    {
    }

    public class RegisterWebhookV2NewBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
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
        public int ContractId { get; set; }
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

    public class SignContractFromProvidedFileV2NewBodyInput
    {
        public SignContractFromProvidedFileV2NewBodyInput(string fileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, BodyInputPeopleTypeItem[] people)
        {
            this.FileName = fileName;
            this.FileContent = fileContent;
            this.People = people;
        }

        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("number")]
        public string ContractNumber { get; set; }

        [JsonProperty("locale")]
        public BodyInputLanguageType? Language { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("people", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPeopleTypeItem[] People { get; set; }

        [JsonProperty("settings")]
        public BodyInputSettingsType Settings { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string File { get; set; } = "uploaded_file_key";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLanguageType
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

    public class BodyInputPeopleTypeItem
    {
        public BodyInputPeopleTypeItem(string signerEmail, BodyInputPeopleTypeItemContractRoleType contractRole, bool proposerOrNot)
        {
            this.SignerEmail = signerEmail;
            this.ContractRole = contractRole;
            this.ProposerOrNot = proposerOrNot;
        }

        [JsonProperty("street")]
        public string SignerStreet { get; set; }

        [JsonProperty("company_name")]
        public string SignerCompanyName { get; set; }

        [JsonProperty("party_order")]
        public double? OrderOfParty { get; set; }

        [JsonProperty("dic")]
        public string SignerVATId { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerEmail { get; set; }

        [JsonProperty("ic")]
        public string SignerCompanyId { get; set; }

        [JsonProperty("positions")]
        public BodyInputPeopleTypeItemPositionsTypeItem[] Positions { get; set; }

        [JsonProperty("contract_role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPeopleTypeItemContractRoleType ContractRole { get; set; }

        [JsonProperty("person_type")]
        public BodyInputPeopleTypeItemTypeOfPersonType? TypeOfPerson { get; set; }

        [JsonProperty("zip_code")]
        public string SignerZIP { get; set; }

        [JsonProperty("is_proposer", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class BodyInputPeopleTypeItemPositionsTypeItem
    {
        [JsonProperty("y")]
        public double? Y { get; set; }

        [JsonProperty("page")]
        public double? NumberOfPage { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("x")]
        public double? X { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPeopleTypeItemContractRoleType
    {
        [EnumMember(Value = "sign")]
        Sign,
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "stamp")]
        Stamp
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPeopleTypeItemTypeOfPersonType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    public class BodyInputSettingsType
    {
        [JsonProperty("signing_order")]
        public BodyInputSettingsTypeRulesForSendingEMailsAndSignaturesType? RulesForSendingEMailsAndSignatures { get; set; }

        [JsonProperty("autosign_proposers")]
        public string AutosignByProposer { get; set; }

        [JsonProperty("missing_positions")]
        public BodyInputSettingsTypeAutomaticSignPlacementType? AutomaticSignPlacement { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSettingsTypeRulesForSendingEMailsAndSignaturesType
    {
        [EnumMember(Value = "all_at_once")]
        AllAtOnce,
        [EnumMember(Value = "proposers_before_counterparties")]
        ProposersBeforeCounterparties,
        [EnumMember(Value = "one_at_a_time")]
        OneAtATime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSettingsTypeAutomaticSignPlacementType
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
        public int ContractId { get; set; }
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

    public class SignContractFromProvidedFileV2NewWaitBodyInput
    {
        public SignContractFromProvidedFileV2NewWaitBodyInput(string fileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, BodyInputPeopleTypeItem[] people)
        {
            this.FileName = fileName;
            this.FileContent = fileContent;
            this.People = people;
        }

        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("number")]
        public string ContractNumber { get; set; }

        [JsonProperty("locale")]
        public BodyInputLanguageType? Language { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("people", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPeopleTypeItem[] People { get; set; }

        [JsonProperty("settings")]
        public BodyInputSettingsType Settings { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string File { get; set; } = "uploaded_file_key";
    }

    public class GetContractDetailResponse
    {
        [JsonProperty("signer_data")]
        public GetContractDetailResponseSignerDataType SignerData { get; set; }

        [JsonProperty("contract_id")]
        public string ContractId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("attachments")]
        public GetContractDetailResponseAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class GetContractDetailResponseSignerDataType
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

    public class GetContractDetailResponseAttachmentsTypeItem
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("contract_id")]
        public string ContractId { get; set; }
    }

    public class GetRevisionListPdfBodyInput
    {
        [JsonProperty("contract_id")]
        public string ContractId { get; set; }
    }

    public class GetTemplatesResponse
    {
        [JsonProperty("templates")]
        public GetTemplatesResponseTemplatesTypeItem[] Templates { get; set; }
    }

    public class GetTemplatesResponseTemplatesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parameters")]
        public GetTemplatesResponseTemplatesTypeItemParametersTypeItem[] Parameters { get; set; }
    }

    public class GetTemplatesResponseTemplatesTypeItemParametersTypeItem
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

    public class GetWorkspacesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SignContractFromProvidedFileResponse
    {
        [JsonProperty("contract_id")]
        public string ContractId { get; set; }
    }

    public class SignContractFromProvidedFileBodyInput
    {
        public SignContractFromProvidedFileBodyInput(int signatureSignerPage, string signerEMail, BodyInputSignerTypeType signerType, string contractSignDate, string authorEMail, string fileName, string contractName, string signerPhone, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file, string signerSurname, string signerFirstName, int signatureSignerX, int signatureSignerY)
        {
            this.SignatureSignerPage = signatureSignerPage;
            this.SignerEMail = signerEMail;
            this.SignerType = signerType;
            this.ContractSignDate = contractSignDate;
            this.AuthorEMail = authorEMail;
            this.FileName = fileName;
            this.ContractName = contractName;
            this.SignerPhone = signerPhone;
            this.File = @file;
            this.SignerSurname = signerSurname;
            this.SignerFirstName = signerFirstName;
            this.SignatureSignerX = signatureSignerX;
            this.SignatureSignerY = signatureSignerY;
        }

        [JsonProperty("sign_negotiator[position][page]", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SignatureSignerPage { get; set; }

        [JsonProperty("email_signer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerEMail { get; set; }

        [JsonProperty("person_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSignerTypeType SignerType { get; set; }

        [JsonProperty("sign_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContractSignDate { get; set; }

        [JsonProperty("sign_proposer[position][page]")]
        public int? SignatureAuthorPage { get; set; }

        [JsonProperty("date_of_birth")]
        public string SignerDateOfBirth { get; set; }

        [JsonProperty("webhooks[0][state]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks0State { get; set; } = "signed";

        [JsonProperty("email_author", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthorEMail { get; set; }

        [JsonProperty("street")]
        public string SignerStreet { get; set; }

        [JsonProperty("dic")]
        public string SignerVATId { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("webhooks[1][url]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks1Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhooks[1][state]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks1State { get; set; } = "rejected";

        [JsonProperty("contract_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContractName { get; set; }

        [JsonProperty("city")]
        public string SignerCity { get; set; }

        [JsonProperty("phone_signer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerPhone { get; set; }

        [JsonProperty("last_document", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool LastDocument { get; set; } = true;

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("lastname_signer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerSurname { get; set; }

        [JsonProperty("company_name")]
        public string SignerCompanyName { get; set; }

        [JsonProperty("sign_proposer[position][x]")]
        public int? SignatureAuthorX { get; set; }

        [JsonProperty("firstname_signer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerFirstName { get; set; }

        [JsonProperty("ic")]
        public string SignerCompanyId { get; set; }

        [JsonProperty("webhooks[0][url]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks0Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("zip_code")]
        public string SignerZIP { get; set; }

        [JsonProperty("sign_negotiator[position][x]", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SignatureSignerX { get; set; }

        [JsonProperty("webhooks[2][state]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks2State { get; set; } = "expired";

        [JsonProperty("negotiator_sign", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SignerShouldSign { get; set; } = true;

        [JsonProperty("sign_negotiator[position][y]", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SignatureSignerY { get; set; }

        [JsonProperty("sign_proposer[position][y]")]
        public int? SignatureAuthorY { get; set; }

        [JsonProperty("contract_number")]
        public string ContractNumber { get; set; }

        [JsonProperty("sign_place")]
        public string ContractSignLocation { get; set; }

        [JsonProperty("proposer_sign", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AuthorShouldSign { get; set; } = true;

        [JsonProperty("webhooks[2][url]", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhooks2Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSignerTypeType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    public class SignContractFromTemplateResponse
    {
        [JsonProperty("contract_id")]
        public string ContractId { get; set; }
    }

    public class SignContractFromTemplateBodyInput
    {
        public SignContractFromTemplateBodyInput(BodyInputPersonTypeType personType, string emailSigner, string templateId, string contractName, bool negotiatorSign, bool proposerSign, string emailAuthor)
        {
            this.PersonType = personType;
            this.EmailSigner = emailSigner;
            this.TemplateId = templateId;
            this.ContractName = contractName;
            this.NegotiatorSign = negotiatorSign;
            this.ProposerSign = proposerSign;
            this.EmailAuthor = emailAuthor;
        }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("person_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPersonTypeType PersonType { get; set; }

        [JsonProperty("email_signer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailSigner { get; set; }

        [JsonProperty("lastname_signer")]
        public string LastnameSigner { get; set; }

        [JsonProperty("webhooks", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputWebhooksType Webhooks { get; set; } = new BodyInputWebhooksType();

        [JsonProperty("last_document", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool LastDocument { get; set; } = true;

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("dic")]
        public string Dic { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("template_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("ic")]
        public string Ic { get; set; }

        [JsonProperty("sign_date")]
        public string SignDate { get; set; }

        [JsonProperty("sign_place")]
        public string SignPlace { get; set; }

        [JsonProperty("contract_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContractName { get; set; }

        [JsonProperty("negotiator_sign", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool NegotiatorSign { get; set; }

        [JsonProperty("firstname_signer")]
        public string FirstnameSigner { get; set; }

        [JsonProperty("proposer_sign", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProposerSign { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("phone_signer")]
        public string PhoneSigner { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("contract_number")]
        public string ContractNumber { get; set; }

        [JsonProperty("email_author", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailAuthor { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPersonTypeType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "citizen")]
        Citizen
    }

    public class BodyInputWebhooksType
    {
        [JsonProperty("2", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputWebhooksType_2Type _2 { get; set; } = new BodyInputWebhooksType_2Type();

        [JsonProperty("1", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputWebhooksType_1Type _1 { get; set; } = new BodyInputWebhooksType_1Type();

        [JsonProperty("0", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputWebhooksType_0Type _0 { get; set; } = new BodyInputWebhooksType_0Type();
    }

    public class BodyInputWebhooksType_2Type
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "expired";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class BodyInputWebhooksType_1Type
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "rejected";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    public class BodyInputWebhooksType_0Type
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string State { get; set; } = "signed";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
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