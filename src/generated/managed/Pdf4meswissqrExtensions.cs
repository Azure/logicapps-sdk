//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meswissqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string> CreateSwissQrBill(Expression<Func<bodycrAddressTypeInput>> bodycrAddressType, Expression<Func<string>> bodycrName, Expression<Func<string>> bodydocContent, Expression<Func<string>> bodyiban, Expression<Func<string>> bodyamount = null, Expression<Func<string>> bodyav1Parameters = null, Expression<Func<string>> bodyav2Parameters = null, Expression<Func<string>> bodybillingInfo = null, Expression<Func<string>> bodycrCity = null, Expression<Func<string>> bodycrPostalCode = null, Expression<Func<string>> bodycrStreetOrAddressLine1 = null, Expression<Func<string>> bodycrStreetOrAddressLine2 = null, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodylanguageTypeInput>> bodylanguageType = null, Expression<Func<string>> bodyreference = null, Expression<Func<bodyreferenceTypeInput>> bodyreferenceType = null, Expression<Func<bodyseperatorLineInput>> bodyseperatorLine = null, Expression<Func<bodyudAddressTypeInput>> bodyudAddressType = null, Expression<Func<string>> bodyudCity = null, Expression<Func<string>> bodyudName = null, Expression<Func<string>> bodyudPostalCode = null, Expression<Func<string>> bodyudStreetOrAddressLine1 = null, Expression<Func<string>> bodyudStreetOrAddressLine2 = null, Expression<Func<string>> bodyunstructuredMessage = null)
        {
            var __workflow_bodycrAddressType = WorkflowExpression.Compile(bodycrAddressType, nameof(bodycrAddressType), required: true);
            var __workflow_bodycrName = WorkflowExpression.Compile(bodycrName, nameof(bodycrName), required: true);
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyiban = WorkflowExpression.Compile(bodyiban, nameof(bodyiban), required: true);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyav1Parameters = WorkflowExpression.Compile(bodyav1Parameters, nameof(bodyav1Parameters), required: false);
            var __workflow_bodyav2Parameters = WorkflowExpression.Compile(bodyav2Parameters, nameof(bodyav2Parameters), required: false);
            var __workflow_bodybillingInfo = WorkflowExpression.Compile(bodybillingInfo, nameof(bodybillingInfo), required: false);
            var __workflow_bodycrCity = WorkflowExpression.Compile(bodycrCity, nameof(bodycrCity), required: false);
            var __workflow_bodycrPostalCode = WorkflowExpression.Compile(bodycrPostalCode, nameof(bodycrPostalCode), required: false);
            var __workflow_bodycrStreetOrAddressLine1 = WorkflowExpression.Compile(bodycrStreetOrAddressLine1, nameof(bodycrStreetOrAddressLine1), required: false);
            var __workflow_bodycrStreetOrAddressLine2 = WorkflowExpression.Compile(bodycrStreetOrAddressLine2, nameof(bodycrStreetOrAddressLine2), required: false);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodylanguageType = WorkflowExpression.Compile(bodylanguageType, nameof(bodylanguageType), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyreferenceType = WorkflowExpression.Compile(bodyreferenceType, nameof(bodyreferenceType), required: false);
            var __workflow_bodyseperatorLine = WorkflowExpression.Compile(bodyseperatorLine, nameof(bodyseperatorLine), required: false);
            var __workflow_bodyudAddressType = WorkflowExpression.Compile(bodyudAddressType, nameof(bodyudAddressType), required: false);
            var __workflow_bodyudCity = WorkflowExpression.Compile(bodyudCity, nameof(bodyudCity), required: false);
            var __workflow_bodyudName = WorkflowExpression.Compile(bodyudName, nameof(bodyudName), required: false);
            var __workflow_bodyudPostalCode = WorkflowExpression.Compile(bodyudPostalCode, nameof(bodyudPostalCode), required: false);
            var __workflow_bodyudStreetOrAddressLine1 = WorkflowExpression.Compile(bodyudStreetOrAddressLine1, nameof(bodyudStreetOrAddressLine1), required: false);
            var __workflow_bodyudStreetOrAddressLine2 = WorkflowExpression.Compile(bodyudStreetOrAddressLine2, nameof(bodyudStreetOrAddressLine2), required: false);
            var __workflow_bodyunstructuredMessage = WorkflowExpression.Compile(bodyunstructuredMessage, nameof(bodyunstructuredMessage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyav1Parameters != null)
                {
                    body["av1Parameters"] = ExpressionConverter.ConvertO(__workflow_bodyav1Parameters);
                    bodypropCount++;
                }

                if (__workflow_bodyav2Parameters != null)
                {
                    body["av2Parameters"] = ExpressionConverter.ConvertO(__workflow_bodyav2Parameters);
                    bodypropCount++;
                }

                if (__workflow_bodybillingInfo != null)
                {
                    body["billingInfo"] = ExpressionConverter.ConvertO(__workflow_bodybillingInfo);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crAddressType"] = ExpressionConverter.ConvertO(__workflow_bodycrAddressType);
                if (__workflow_bodycrCity != null)
                {
                    body["crCity"] = ExpressionConverter.ConvertO(__workflow_bodycrCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crName"] = ExpressionConverter.ConvertO(__workflow_bodycrName);
                if (__workflow_bodycrPostalCode != null)
                {
                    body["crPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodycrPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycrStreetOrAddressLine1 != null)
                {
                    body["crStreetOrAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodycrStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodycrStreetOrAddressLine2 != null)
                {
                    body["crStreetOrAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodycrStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    if (__workflow_bodycurrency != null)
                    {
                        body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["currency"] = "CHF";
                    bodypropCount++;
                }

                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["iban"] = ExpressionConverter.ConvertO(__workflow_bodyiban);
                if (__workflow_bodylanguageType != null)
                {
                    if (__workflow_bodylanguageType != null)
                    {
                        body["languageType"] = ExpressionConverter.ConvertO(__workflow_bodylanguageType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["languageType"] = "English";
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceType != null)
                {
                    if (__workflow_bodyreferenceType != null)
                    {
                        body["referenceType"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["referenceType"] = "QRR";
                    bodypropCount++;
                }

                if (__workflow_bodyseperatorLine != null)
                {
                    if (__workflow_bodyseperatorLine != null)
                    {
                        body["seperatorLine"] = ExpressionConverter.ConvertO(__workflow_bodyseperatorLine);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["seperatorLine"] = "LineWithScissor";
                    bodypropCount++;
                }

                if (__workflow_bodyudAddressType != null)
                {
                    if (__workflow_bodyudAddressType != null)
                    {
                        body["udAddressType"] = ExpressionConverter.ConvertO(__workflow_bodyudAddressType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["udAddressType"] = "S";
                    bodypropCount++;
                }

                if (__workflow_bodyudCity != null)
                {
                    body["udCity"] = ExpressionConverter.ConvertO(__workflow_bodyudCity);
                    bodypropCount++;
                }

                if (__workflow_bodyudName != null)
                {
                    body["udName"] = ExpressionConverter.ConvertO(__workflow_bodyudName);
                    bodypropCount++;
                }

                if (__workflow_bodyudPostalCode != null)
                {
                    body["udPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyudPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyudStreetOrAddressLine1 != null)
                {
                    body["udStreetOrAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyudStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyudStreetOrAddressLine2 != null)
                {
                    body["udStreetOrAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyudStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyunstructuredMessage != null)
                {
                    body["unstructuredMessage"] = ExpressionConverter.ConvertO(__workflow_bodyunstructuredMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string> ReadSwissQrBill(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response> SplitDocBySwissQrCode(Expression<Func<string>> bodydocContent, Expression<Func<bodysplitBarcodePageInput>> bodysplitBarcodePage, Expression<Func<string>> bodydocumentname = null, Expression<Func<bool>> bodycombinePagesWithSameConsecutiveBarcodes = null, Expression<Func<string>> bodypdfRenderDpi = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodysplitBarcodePage = WorkflowExpression.Compile(bodysplitBarcodePage, nameof(bodysplitBarcodePage), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodycombinePagesWithSameConsecutiveBarcodes = WorkflowExpression.Compile(bodycombinePagesWithSameConsecutiveBarcodes, nameof(bodycombinePagesWithSameConsecutiveBarcodes), required: false);
            var __workflow_bodypdfRenderDpi = WorkflowExpression.Compile(bodypdfRenderDpi, nameof(bodypdfRenderDpi), required: false);
            return new DeferredBodyAction<SplitDocBySwissQrCodeV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["barcodeFilter"] = "startsWith";
                bodypropCount++;
                body["barcodeString"] = "SPC";
                bodypropCount++;
                body["barcodeType"] = "qrcode";
                bodypropCount++;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["splitBarcodePage"] = ExpressionConverter.ConvertO(__workflow_bodysplitBarcodePage);
                if (__workflow_bodycombinePagesWithSameConsecutiveBarcodes != null)
                {
                    if (__workflow_bodycombinePagesWithSameConsecutiveBarcodes != null)
                    {
                        body["combinePagesWithSameConsecutiveBarcodes"] = ExpressionConverter.ConvertO(__workflow_bodycombinePagesWithSameConsecutiveBarcodes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["combinePagesWithSameConsecutiveBarcodes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodypdfRenderDpi != null)
                {
                    if (__workflow_bodypdfRenderDpi != null)
                    {
                        body["pdfRenderDpi"] = ExpressionConverter.ConvertO(__workflow_bodypdfRenderDpi);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pdfRenderDpi"] = "150";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SplitDocBySwissQrCodeV1Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class Pdf4meswissqrTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycrAddressTypeInput
    {
        S,
        K
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurrencyInput
    {
        CHF,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylanguageTypeInput
    {
        German,
        French,
        Italian,
        English
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreferenceTypeInput
    {
        QRR,
        SCOR,
        NON
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyseperatorLineInput
    {
        LineWithScissor,
        Line,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyudAddressTypeInput
    {
        S,
        K
    }

    public class SplitDocBySwissQrCodeV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocBySwissQrCodeV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocBySwissQrCodeV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysplitBarcodePageInput
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr;

    public partial class WorkflowManagedActions
    {
        public Pdf4meswissqrActions Pdf4meswissqr(string connectionId) => new Pdf4meswissqrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meswissqrTriggers Pdf4meswissqr(string connectionId) => new Pdf4meswissqrTriggers(connectionId);
    }
}
