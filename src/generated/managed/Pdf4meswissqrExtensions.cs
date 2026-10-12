//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meswissqrActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSwissQrBill))]
        public IBodyWorkflowAction<string> CreateSwissQrBill([WorkflowExpression] Func<bodycrAddressTypeInput> bodycrAddressType, [WorkflowExpression] Func<string> bodycrName, [WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodyiban, [WorkflowExpression] Func<string> bodyamount = null, [WorkflowExpression] Func<string> bodyav1Parameters = null, [WorkflowExpression] Func<string> bodyav2Parameters = null, [WorkflowExpression] Func<string> bodybillingInfo = null, [WorkflowExpression] Func<string> bodycrCity = null, [WorkflowExpression] Func<string> bodycrPostalCode = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine2 = null, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency = null, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodylanguageTypeInput> bodylanguageType = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bodyreferenceTypeInput> bodyreferenceType = null, [WorkflowExpression] Func<bodyseperatorLineInput> bodyseperatorLine = null, [WorkflowExpression] Func<bodyudAddressTypeInput> bodyudAddressType = null, [WorkflowExpression] Func<string> bodyudCity = null, [WorkflowExpression] Func<string> bodyudName = null, [WorkflowExpression] Func<string> bodyudPostalCode = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine2 = null, [WorkflowExpression] Func<string> bodyunstructuredMessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateSwissQrBill(WorkflowExpression<bodycrAddressTypeInput> bodycrAddressType, WorkflowExpression<string> bodycrName, WorkflowExpression<string> bodydocContent, WorkflowExpression<string> bodyiban, WorkflowExpression<string> bodyamount = null, WorkflowExpression<string> bodyav1Parameters = null, WorkflowExpression<string> bodyav2Parameters = null, WorkflowExpression<string> bodybillingInfo = null, WorkflowExpression<string> bodycrCity = null, WorkflowExpression<string> bodycrPostalCode = null, WorkflowExpression<string> bodycrStreetOrAddressLine1 = null, WorkflowExpression<string> bodycrStreetOrAddressLine2 = null, WorkflowExpression<bodycurrencyInput> bodycurrency = null, WorkflowExpression<string> bodydocumentname = null, WorkflowExpression<bodylanguageTypeInput> bodylanguageType = null, WorkflowExpression<string> bodyreference = null, WorkflowExpression<bodyreferenceTypeInput> bodyreferenceType = null, WorkflowExpression<bodyseperatorLineInput> bodyseperatorLine = null, WorkflowExpression<bodyudAddressTypeInput> bodyudAddressType = null, WorkflowExpression<string> bodyudCity = null, WorkflowExpression<string> bodyudName = null, WorkflowExpression<string> bodyudPostalCode = null, WorkflowExpression<string> bodyudStreetOrAddressLine1 = null, WorkflowExpression<string> bodyudStreetOrAddressLine2 = null, WorkflowExpression<string> bodyunstructuredMessage = null)
        {
            WorkflowExpression.Validate(bodycrAddressType, nameof(bodycrAddressType), required: true);
            WorkflowExpression.Validate(bodycrName, nameof(bodycrName), required: true);
            WorkflowExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowExpression.Validate(bodyiban, nameof(bodyiban), required: true);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyav1Parameters, nameof(bodyav1Parameters), required: false);
            WorkflowExpression.Validate(bodyav2Parameters, nameof(bodyav2Parameters), required: false);
            WorkflowExpression.Validate(bodybillingInfo, nameof(bodybillingInfo), required: false);
            WorkflowExpression.Validate(bodycrCity, nameof(bodycrCity), required: false);
            WorkflowExpression.Validate(bodycrPostalCode, nameof(bodycrPostalCode), required: false);
            WorkflowExpression.Validate(bodycrStreetOrAddressLine1, nameof(bodycrStreetOrAddressLine1), required: false);
            WorkflowExpression.Validate(bodycrStreetOrAddressLine2, nameof(bodycrStreetOrAddressLine2), required: false);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowExpression.Validate(bodylanguageType, nameof(bodylanguageType), required: false);
            WorkflowExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            WorkflowExpression.Validate(bodyreferenceType, nameof(bodyreferenceType), required: false);
            WorkflowExpression.Validate(bodyseperatorLine, nameof(bodyseperatorLine), required: false);
            WorkflowExpression.Validate(bodyudAddressType, nameof(bodyudAddressType), required: false);
            WorkflowExpression.Validate(bodyudCity, nameof(bodyudCity), required: false);
            WorkflowExpression.Validate(bodyudName, nameof(bodyudName), required: false);
            WorkflowExpression.Validate(bodyudPostalCode, nameof(bodyudPostalCode), required: false);
            WorkflowExpression.Validate(bodyudStreetOrAddressLine1, nameof(bodyudStreetOrAddressLine1), required: false);
            WorkflowExpression.Validate(bodyudStreetOrAddressLine2, nameof(bodyudStreetOrAddressLine2), required: false);
            WorkflowExpression.Validate(bodyunstructuredMessage, nameof(bodyunstructuredMessage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                    bodypropCount++;
                }

                if (bodyav1Parameters != null)
                {
                    body["av1Parameters"] = ExpressionConverter.ConvertO(bodyav1Parameters);
                    bodypropCount++;
                }

                if (bodyav2Parameters != null)
                {
                    body["av2Parameters"] = ExpressionConverter.ConvertO(bodyav2Parameters);
                    bodypropCount++;
                }

                if (bodybillingInfo != null)
                {
                    body["billingInfo"] = ExpressionConverter.ConvertO(bodybillingInfo);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crAddressType"] = ExpressionConverter.ConvertO(bodycrAddressType);
                if (bodycrCity != null)
                {
                    body["crCity"] = ExpressionConverter.ConvertO(bodycrCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crName"] = ExpressionConverter.ConvertO(bodycrName);
                if (bodycrPostalCode != null)
                {
                    body["crPostalCode"] = ExpressionConverter.ConvertO(bodycrPostalCode);
                    bodypropCount++;
                }

                if (bodycrStreetOrAddressLine1 != null)
                {
                    body["crStreetOrAddressLine1"] = ExpressionConverter.ConvertO(bodycrStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (bodycrStreetOrAddressLine2 != null)
                {
                    body["crStreetOrAddressLine2"] = ExpressionConverter.ConvertO(bodycrStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    if (bodycurrency != null)
                    {
                        body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
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
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["iban"] = ExpressionConverter.ConvertO(bodyiban);
                if (bodylanguageType != null)
                {
                    if (bodylanguageType != null)
                    {
                        body["languageType"] = ExpressionConverter.ConvertO(bodylanguageType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["languageType"] = "English";
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(bodyreference);
                    bodypropCount++;
                }

                if (bodyreferenceType != null)
                {
                    if (bodyreferenceType != null)
                    {
                        body["referenceType"] = ExpressionConverter.ConvertO(bodyreferenceType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["referenceType"] = "QRR";
                    bodypropCount++;
                }

                if (bodyseperatorLine != null)
                {
                    if (bodyseperatorLine != null)
                    {
                        body["seperatorLine"] = ExpressionConverter.ConvertO(bodyseperatorLine);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["seperatorLine"] = "LineWithScissor";
                    bodypropCount++;
                }

                if (bodyudAddressType != null)
                {
                    if (bodyudAddressType != null)
                    {
                        body["udAddressType"] = ExpressionConverter.ConvertO(bodyudAddressType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["udAddressType"] = "S";
                    bodypropCount++;
                }

                if (bodyudCity != null)
                {
                    body["udCity"] = ExpressionConverter.ConvertO(bodyudCity);
                    bodypropCount++;
                }

                if (bodyudName != null)
                {
                    body["udName"] = ExpressionConverter.ConvertO(bodyudName);
                    bodypropCount++;
                }

                if (bodyudPostalCode != null)
                {
                    body["udPostalCode"] = ExpressionConverter.ConvertO(bodyudPostalCode);
                    bodypropCount++;
                }

                if (bodyudStreetOrAddressLine1 != null)
                {
                    body["udStreetOrAddressLine1"] = ExpressionConverter.ConvertO(bodyudStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (bodyudStreetOrAddressLine2 != null)
                {
                    body["udStreetOrAddressLine2"] = ExpressionConverter.ConvertO(bodyudStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (bodyunstructuredMessage != null)
                {
                    body["unstructuredMessage"] = ExpressionConverter.ConvertO(bodyunstructuredMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        [WorkflowExpressionFactory(nameof(__BuildReadSwissQrBill))]
        public IBodyWorkflowAction<string> ReadSwissQrBill([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReadSwissQrBill(WorkflowExpression<string> bodydocContent, WorkflowExpression<string> bodydocumentname = null)
        {
            WorkflowExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        [WorkflowExpressionFactory(nameof(__BuildSplitDocBySwissQrCode))]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response> SplitDocBySwissQrCode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodysplitBarcodePageInput> bodysplitBarcodePage, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodycombinePagesWithSameConsecutiveBarcodes = null, [WorkflowExpression] Func<string> bodypdfRenderDpi = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response> __BuildSplitDocBySwissQrCode(WorkflowExpression<string> bodydocContent, WorkflowExpression<bodysplitBarcodePageInput> bodysplitBarcodePage, WorkflowExpression<string> bodydocumentname = null, WorkflowExpression<bool> bodycombinePagesWithSameConsecutiveBarcodes = null, WorkflowExpression<string> bodypdfRenderDpi = null)
        {
            WorkflowExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowExpression.Validate(bodysplitBarcodePage, nameof(bodysplitBarcodePage), required: true);
            WorkflowExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowExpression.Validate(bodycombinePagesWithSameConsecutiveBarcodes, nameof(bodycombinePagesWithSameConsecutiveBarcodes), required: false);
            WorkflowExpression.Validate(bodypdfRenderDpi, nameof(bodypdfRenderDpi), required: false);
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
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["splitBarcodePage"] = ExpressionConverter.ConvertO(bodysplitBarcodePage);
                if (bodycombinePagesWithSameConsecutiveBarcodes != null)
                {
                    if (bodycombinePagesWithSameConsecutiveBarcodes != null)
                    {
                        body["combinePagesWithSameConsecutiveBarcodes"] = ExpressionConverter.ConvertO(bodycombinePagesWithSameConsecutiveBarcodes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["combinePagesWithSameConsecutiveBarcodes"] = false;
                    bodypropCount++;
                }

                if (bodypdfRenderDpi != null)
                {
                    if (bodypdfRenderDpi != null)
                    {
                        body["pdfRenderDpi"] = ExpressionConverter.ConvertO(bodypdfRenderDpi);
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
            });
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