//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signhost
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignhostActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<Transaction, ApiConnectionActionConfiguration> Getdetails(Expression<Func<string>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<Transaction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/transaction/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Transaction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel, ApiConnectionActionConfiguration> Delete(Expression<Func<string>> transactionId, Expression<Func<DeleteInput>> body = null)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ErrorModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/transaction/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ErrorModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Downloadpdf(Expression<Func<string>> transactionId, Expression<Func<string>> fileId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/transaction/{0}/file/{1}/", __workflow_transactionId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Downloadreceipt(Expression<Func<string>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/file/receipt/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<Transaction, ApiConnectionActionConfiguration> Create(Expression<Func<CreateInput>> transaction)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            return new DeferredBodyAction<Transaction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/transaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_transaction);
                return new ApiConnectionAction<Transaction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Addfile(Expression<Func<string>> transactionId, Expression<Func<string>> fileId, Expression<Func<string>> body)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/transaction/{0}/file/{1}", __workflow_transactionId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel, ApiConnectionActionConfiguration> Start(Expression<Func<string>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<ErrorModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/transaction/{0}/start", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ErrorModel>(callPayload);
            });
        }
    }

    public class SignhostTriggers([ConnectionName] string connectionId)
    {
    }

    public class Transaction
    {
        public string Id { get; set; }
        public TransactionFilesTypeItem[] Files { get; set; }
        public TransactionLanguageType Language { get; set; }
        public bool Seal { get; set; }
        public TransactionSignersTypeItem[] Signers { get; set; }
        public TransactionReceiversTypeItem[] Receivers { get; set; }
        public string Reference { get; set; }
        public string PostbackUrl { get; set; }
        public int SignRequestMode { get; set; }
        public int DaysToExpire { get; set; }
        public bool SendEmailNotifications { get; set; }
        public TransactionStatusType Status { get; set; }
        public string CancelationReason { get; set; }
        public JToken Context { get; set; }
    }

    public class TransactionFilesTypeItem
    {
        public TransactionFilesTypeItemLinksTypeItem[] Links { get; set; }
        public string DisplayName { get; set; }
    }

    public class TransactionFilesTypeItemLinksTypeItem
    {
        public string Rel { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TransactionLanguageType
    {
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "nl-NL")]
        NlNL
    }

    public class TransactionSignersTypeItem
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string IntroText { get; set; }
        public Authentication[] Authentications { get; set; }
        public Verification[] Verifications { get; set; }
        public bool SendSignRequest { get; set; }
        public string SignUrl { get; set; }
        public string SignRequestSubject { get; set; }
        public string SignRequestMessage { get; set; }
        public bool SendSignConfirmation { get; set; }
        public TransactionSignersTypeItemLanguageType Language { get; set; }
        public string ScribbleName { get; set; }
        public int DaysToRemind { get; set; }
        public string Expires { get; set; }
        public string Reference { get; set; }
        public string RejectReason { get; set; }
        public string ReturnUrl { get; set; }
        public JToken Context { get; set; }
        public TransactionSignersTypeItemActivitiesTypeItem[] Activities { get; set; }
    }

    public class Authentication
    {
        public AuthenticationTypeType Type { get; set; }
        public string Number { get; set; }
        public double Bsn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthenticationTypeType
    {
        DigiD,
        PhoneNumber
    }

    public class Verification
    {
        public VerificationTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VerificationTypeType
    {
        Consent,
        DigiD,
        [EnumMember(Value = "eHerkenning")]
        EHerkenning,
        [EnumMember(Value = "eIDAS Login")]
        EIdASLogin,
        [EnumMember(Value = "iDeal")]
        IDeal,
        [EnumMember(Value = "iDIN")]
        IdIN,
        [EnumMember(Value = "itsme Identification")]
        ItsmeIdentification,
        PhoneNumber,
        Scribble,
        [EnumMember(Value = "itsme sign")]
        ItsmeSign,
        SigningCertificate,
        SURFnet,
        [EnumMember(Value = "ZealiD Qualified")]
        ZealiDQualified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TransactionSignersTypeItemLanguageType
    {
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "nl-NL")]
        NlNL
    }

    public class TransactionSignersTypeItemActivitiesTypeItem
    {
        public string Id { get; set; }
        public TransactionSignersTypeItemActivitiesTypeItemCodeType Code { get; set; }
        public string Info { get; set; }
        public string CreatedDateTime { get; set; }
    }

    public enum TransactionSignersTypeItemActivitiesTypeItemCodeType
    {
        _101 = 101,
        _102 = 102,
        _103 = 103,
        _104 = 104,
        _105 = 105,
        _201 = 201,
        _202 = 202,
        _203 = 203,
        _301 = 301,
        _302 = 302,
        _303 = 303,
        _401 = 401,
        _402 = 402,
        _403 = 403
    }

    public class TransactionReceiversTypeItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Reference { get; set; }
        public JToken Context { get; set; }
    }

    public enum TransactionStatusType
    {
        _5 = 5,
        _10 = 10,
        _20 = 20,
        _30 = 30,
        _40 = 40,
        _50 = 50,
        _60 = 60,
        _70 = 70
    }

    public class ErrorModel
    {
        public string Message { get; set; }
    }

    public class DeleteInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendNotifications { get; set; } = false;
        public string Reason { get; set; }
    }

    public class CreateInput
    {
        public JToken Files { get; set; }
        public CreateInputLanguageType? Language { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Seal { get; set; } = false;
        public CreateInputSignersTypeItem[] Signers { get; set; }
        public CreateInputReceiversTypeItem[] Receivers { get; set; }
        public string Reference { get; set; }
        public string PostbackUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SignRequestMode { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DaysToExpire { get; set; } = 60;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateInputLanguageType
    {
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "nl-NL")]
        NlNL
    }

    public class CreateInputSignersTypeItem
    {
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
        public string IntroText { get; set; }
        public Authentication[] Authentications { get; set; }
        public Verification[] Verifications { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendSignRequest { get; set; } = true;
        public string SignUrl { get; set; }
        public string SignRequestSubject { get; set; }
        public string SignRequestMessage { get; set; }
        public bool? SendSignConfirmation { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateInputSignersTypeItemLanguageType? Language { get; set; } = CreateInputSignersTypeItemLanguageType.NlNL;
        public string ScribbleName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DaysToRemind { get; set; } = 7;
        public string Expires { get; set; }
        public string Reference { get; set; }
        public string RejectReason { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReturnUrl { get; set; } = "https://signhost.com";
        public JToken Context { get; set; }
        public CreateInputSignersTypeItemActivitiesTypeItem[] Activities { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateInputSignersTypeItemLanguageType
    {
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "nl-NL")]
        NlNL
    }

    public class CreateInputSignersTypeItemActivitiesTypeItem
    {
        public string Id { get; set; }
        public CreateInputSignersTypeItemActivitiesTypeItemCodeType? Code { get; set; }
        public string Info { get; set; }
        public string CreatedDateTime { get; set; }
    }

    public enum CreateInputSignersTypeItemActivitiesTypeItemCodeType
    {
        _101 = 101,
        _102 = 102,
        _103 = 103,
        _104 = 104,
        _105 = 105,
        _201 = 201,
        _202 = 202,
        _203 = 203,
        _301 = 301,
        _302 = 302,
        _303 = 303,
        _401 = 401,
        _402 = 402,
        _403 = 403
    }

    public class CreateInputReceiversTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; } = "nl-NL";
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
        public string Reference { get; set; }
        public JToken Context { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signhost;

    public partial class WorkflowManagedActions
    {
        public SignhostActions Signhost(string connectionId) => new SignhostActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignhostTriggers Signhost(string connectionId) => new SignhostTriggers(connectionId);
    }
}