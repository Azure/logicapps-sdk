//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meswissqr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meswissqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string> CreateSwissQrBillV1(Expression<Func<bodycrAddressTypeInput>> bodycrAddressType, Expression<Func<string>> bodycrName, Expression<Func<string>> bodydocContent, Expression<Func<string>> bodyiban, Expression<Func<string>> bodyamount = null, Expression<Func<string>> bodyav1Parameters = null, Expression<Func<string>> bodyav2Parameters = null, Expression<Func<string>> bodybillingInfo = null, Expression<Func<string>> bodycrCity = null, Expression<Func<string>> bodycrPostalCode = null, Expression<Func<string>> bodycrStreetOrAddressLine1 = null, Expression<Func<string>> bodycrStreetOrAddressLine2 = null, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodylanguageTypeInput>> bodylanguageType = null, Expression<Func<string>> bodyreference = null, Expression<Func<bodyreferenceTypeInput>> bodyreferenceType = null, Expression<Func<bodyseperatorLineInput>> bodyseperatorLine = null, Expression<Func<bodyudAddressTypeInput>> bodyudAddressType = null, Expression<Func<string>> bodyudCity = null, Expression<Func<string>> bodyudName = null, Expression<Func<string>> bodyudPostalCode = null, Expression<Func<string>> bodyudStreetOrAddressLine1 = null, Expression<Func<string>> bodyudStreetOrAddressLine2 = null, Expression<Func<string>> bodyunstructuredMessage = null)
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
                body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
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
                body["languageType"] = ExpressionConverter.ConvertO(bodylanguageType);
                bodypropCount++;
            }

            if (bodyreference != null)
            {
                body["reference"] = ExpressionConverter.ConvertO(bodyreference);
                bodypropCount++;
            }

            if (bodyreferenceType != null)
            {
                body["referenceType"] = ExpressionConverter.ConvertO(bodyreferenceType);
                bodypropCount++;
            }

            if (bodyseperatorLine != null)
            {
                body["seperatorLine"] = ExpressionConverter.ConvertO(bodyseperatorLine);
                bodypropCount++;
            }

            if (bodyudAddressType != null)
            {
                body["udAddressType"] = ExpressionConverter.ConvertO(bodyudAddressType);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string> ReadSwissQrBillV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response> SplitDocBySwissQrCodeV1(Expression<Func<string>> bodydocContent, Expression<Func<bodysplitBarcodePageInput>> bodysplitBarcodePage, Expression<Func<string>> bodydocumentname = null, Expression<Func<bool>> bodycombinePagesWithSameConsecutiveBarcodes = null, Expression<Func<string>> bodypdfRenderDpi = null)
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
                body["combinePagesWithSameConsecutiveBarcodes"] = ExpressionConverter.ConvertO(bodycombinePagesWithSameConsecutiveBarcodes);
                bodypropCount++;
            }

            if (bodypdfRenderDpi != null)
            {
                body["pdfRenderDpi"] = ExpressionConverter.ConvertO(bodypdfRenderDpi);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SplitDocBySwissQrCodeV1Response>(callPayload);
        }
    }

    public class Pdf4meswissqrTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodycrAddressTypeInput
    {
        S,
        K
    }

    public enum bodycurrencyInput
    {
        CHF,
        EUR
    }

    public enum bodylanguageTypeInput
    {
        German,
        French,
        Italian,
        English
    }

    public enum bodyreferenceTypeInput
    {
        QRR,
        SCOR,
        NON
    }

    public enum bodyseperatorLineInput
    {
        LineWithScissor,
        Line,
        None
    }

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