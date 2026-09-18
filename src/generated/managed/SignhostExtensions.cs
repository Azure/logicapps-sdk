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
        public IBodyWorkflowAction<Transaction> Getdetails([WorkflowExpression] Func<string> transactionId)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Transaction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel> Delete([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<bool> bodysendNotifications = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            SourceExpression.Validate(bodysendNotifications, nameof(bodysendNotifications), required: false);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysendNotifications != null)
                {
                    if (bodysendNotifications != null)
                    {
                        body["SendNotifications"] = SourceExpressionConverter.ConvertToken(bodysendNotifications);
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
                    body["Reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ErrorModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string> Downloadpdf([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/file/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<string> Downloadreceipt([WorkflowExpression] Func<string> transactionId)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/file/receipt/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<Transaction> Create([WorkflowExpression] Func<transactionlanguageInput> transactionlanguage = null, [WorkflowExpression] Func<bool> transactionseal = null, [WorkflowExpression] Func<transactionsignersInputItem[]> transactionsigners = null, [WorkflowExpression] Func<transactionreceiversInputItem[]> transactionreceivers = null, [WorkflowExpression] Func<string> transactionreference = null, [WorkflowExpression] Func<string> transactionpostbackUrl = null, [WorkflowExpression] Func<int> transactionsignRequestMode = null, [WorkflowExpression] Func<int> transactiondaysToExpire = null)
        {
            SourceExpression.Validate(transactionlanguage, nameof(transactionlanguage), required: false);
            SourceExpression.Validate(transactionseal, nameof(transactionseal), required: false);
            SourceExpression.Validate(transactionsigners, nameof(transactionsigners), required: false);
            SourceExpression.Validate(transactionreceivers, nameof(transactionreceivers), required: false);
            SourceExpression.Validate(transactionreference, nameof(transactionreference), required: false);
            SourceExpression.Validate(transactionpostbackUrl, nameof(transactionpostbackUrl), required: false);
            SourceExpression.Validate(transactionsignRequestMode, nameof(transactionsignRequestMode), required: false);
            SourceExpression.Validate(transactiondaysToExpire, nameof(transactiondaysToExpire), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    transaction["Language"] = SourceExpressionConverter.Convert(transactionlanguage);
                    transactionpropCount++;
                }

                if (transactionseal != null)
                {
                    if (transactionseal != null)
                    {
                        transaction["Seal"] = SourceExpressionConverter.ConvertToken(transactionseal);
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
                    transaction["Signers"] = SourceExpressionConverter.ConvertToken(transactionsigners);
                    transactionpropCount++;
                }

                if (transactionreceivers != null)
                {
                    transaction["Receivers"] = SourceExpressionConverter.ConvertToken(transactionreceivers);
                    transactionpropCount++;
                }

                if (transactionreference != null)
                {
                    transaction["Reference"] = SourceExpressionConverter.ConvertToken(transactionreference);
                    transactionpropCount++;
                }

                if (transactionpostbackUrl != null)
                {
                    transaction["PostbackUrl"] = SourceExpressionConverter.ConvertToken(transactionpostbackUrl);
                    transactionpropCount++;
                }

                if (transactionsignRequestMode != null)
                {
                    if (transactionsignRequestMode != null)
                    {
                        transaction["SignRequestMode"] = SourceExpressionConverter.ConvertToken(transactionsignRequestMode);
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
                        transaction["DaysToExpire"] = SourceExpressionConverter.ConvertToken(transactiondaysToExpire);
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
                return callPayload;
            }

            return new ApiConnectionAction<Transaction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IWorkflowAction Addfile([WorkflowExpression] Func<string> transactionId, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/file/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signhost")]
        public IBodyWorkflowAction<ErrorModel> Start([WorkflowExpression] Func<string> transactionId)
        {
            SourceExpression.Validate(transactionId, nameof(transactionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/transaction/{0}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ErrorModel>(BuildSourceInput);
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