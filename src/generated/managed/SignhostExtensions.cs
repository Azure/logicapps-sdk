//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signhost
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignhostActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<Transaction> Getdetails(Expression<Func<string>> transactionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Transaction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel> Delete(Expression<Func<string>> transactionId, Expression<Func<bool>> bodysendNotifications = null, Expression<Func<string>> bodyreason = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysendNotifications != null)
            {
                if (bodysendNotifications != null)
                {
                    body["SendNotifications"] = CSharpExpressionConverter.ConvertToken(bodysendNotifications);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["SendNotifications"] = false;
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["Reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ErrorModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string> Downloadpdf(Expression<Func<string>> transactionId, Expression<Func<string>> fileId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/file/{1}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string> Downloadreceipt(Expression<Func<string>> transactionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/file/receipt/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<Transaction> Create(Expression<Func<transactionlanguageInput>> transactionlanguage = null, Expression<Func<bool>> transactionseal = null, Expression<Func<transactionsignersInputItem[]>> transactionsigners = null, Expression<Func<transactionreceiversInputItem[]>> transactionreceivers = null, Expression<Func<string>> transactionreference = null, Expression<Func<string>> transactionpostbackUrl = null, Expression<Func<int>> transactionsignRequestMode = null, Expression<Func<int>> transactiondaysToExpire = null)
        {
            var apiCallPath = "/api/transaction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var transaction = new JObject();
            var transactionpropCount = 0;
            var filesObject = new JObject();
            var filesObjectpropCount = 0;
            if (filesObjectpropCount > 0)
            {
                transaction["Files"] = filesObject;
                transactionpropCount++;
            }

            if (transactionlanguage != null)
            {
                transaction["Language"] = CSharpExpressionConverter.Convert(transactionlanguage);
                transactionpropCount++;
            }

            if (transactionseal != null)
            {
                if (transactionseal != null)
                {
                    transaction["Seal"] = CSharpExpressionConverter.ConvertToken(transactionseal);
                    transactionpropCount++;
                }

                transactionpropCount++;
            }
            else
            {
                transaction["Seal"] = false;
                transactionpropCount++;
            }

            if (transactionsigners != null)
            {
                transaction["Signers"] = CSharpExpressionConverter.ConvertToken(transactionsigners);
                transactionpropCount++;
            }

            if (transactionreceivers != null)
            {
                transaction["Receivers"] = CSharpExpressionConverter.ConvertToken(transactionreceivers);
                transactionpropCount++;
            }

            if (transactionreference != null)
            {
                transaction["Reference"] = CSharpExpressionConverter.ConvertToken(transactionreference);
                transactionpropCount++;
            }

            if (transactionpostbackUrl != null)
            {
                transaction["PostbackUrl"] = CSharpExpressionConverter.ConvertToken(transactionpostbackUrl);
                transactionpropCount++;
            }

            if (transactionsignRequestMode != null)
            {
                if (transactionsignRequestMode != null)
                {
                    transaction["SignRequestMode"] = CSharpExpressionConverter.ConvertToken(transactionsignRequestMode);
                    transactionpropCount++;
                }

                transactionpropCount++;
            }
            else
            {
                transaction["SignRequestMode"] = 2;
                transactionpropCount++;
            }

            if (transactiondaysToExpire != null)
            {
                if (transactiondaysToExpire != null)
                {
                    transaction["DaysToExpire"] = CSharpExpressionConverter.ConvertToken(transactiondaysToExpire);
                    transactionpropCount++;
                }

                transactionpropCount++;
            }
            else
            {
                transaction["DaysToExpire"] = 60;
                transactionpropCount++;
            }

            if (transactionpropCount > 0)
            {
                callPayload.Body = transaction;
            }

            return new ApiConnectionAction<Transaction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IWorkflowAction Addfile(Expression<Func<string>> transactionId, Expression<Func<string>> fileId, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/file/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel> Start(Expression<Func<string>> transactionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/start", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ErrorModel>(callPayload);
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

    public enum AuthenticationTypeType
    {
        DigiD,
        PhoneNumber
    }

    public class Verification
    {
        public VerificationTypeType Type { get; set; }
    }

    public enum VerificationTypeType
    {
        Consent,
        DigiD,
        [EnumMember(Value = "eHerkenning")]
        EHerkenning,
        [EnumMember(Value = "eIDAS Login")]
        EIDASLogin,
        [EnumMember(Value = "iDeal")]
        IDeal,
        [EnumMember(Value = "iDIN")]
        IDIN,
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
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "104")]
        _104,
        [EnumMember(Value = "105")]
        _105,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "202")]
        _202,
        [EnumMember(Value = "203")]
        _203,
        [EnumMember(Value = "301")]
        _301,
        [EnumMember(Value = "302")]
        _302,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "402")]
        _402,
        [EnumMember(Value = "403")]
        _403
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
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "40")]
        _40,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "70")]
        _70
    }

    public class ErrorModel
    {
        public string Message { get; set; }
    }

    public enum transactionlanguageInput
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

    public class transactionsignersInputItem
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
        public transactionsignersInputItemLanguageType Language { get; set; }
        public string ScribbleName { get; set; }
        public int DaysToRemind { get; set; }
        public string Expires { get; set; }
        public string Reference { get; set; }
        public string RejectReason { get; set; }
        public string ReturnUrl { get; set; }
        public JToken Context { get; set; }
        public transactionsignersInputItemActivitiesTypeItem[] Activities { get; set; }
    }

    public enum transactionsignersInputItemLanguageType
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

    public class transactionsignersInputItemActivitiesTypeItem
    {
        public string Id { get; set; }
        public transactionsignersInputItemActivitiesTypeItemCodeType Code { get; set; }
        public string Info { get; set; }
        public string CreatedDateTime { get; set; }
    }

    public enum transactionsignersInputItemActivitiesTypeItemCodeType
    {
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "104")]
        _104,
        [EnumMember(Value = "105")]
        _105,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "202")]
        _202,
        [EnumMember(Value = "203")]
        _203,
        [EnumMember(Value = "301")]
        _301,
        [EnumMember(Value = "302")]
        _302,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "402")]
        _402,
        [EnumMember(Value = "403")]
        _403
    }

    public class transactionreceiversInputItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
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