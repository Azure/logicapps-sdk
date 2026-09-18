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
        public IBodyWorkflowAction<string> CreateSwissQrBill([WorkflowExpression] Func<bodycrAddressTypeInput> bodycrAddressType, [WorkflowExpression] Func<string> bodycrName, [WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodyiban, [WorkflowExpression] Func<string> bodyamount = null, [WorkflowExpression] Func<string> bodyav1Parameters = null, [WorkflowExpression] Func<string> bodyav2Parameters = null, [WorkflowExpression] Func<string> bodybillingInfo = null, [WorkflowExpression] Func<string> bodycrCity = null, [WorkflowExpression] Func<string> bodycrPostalCode = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine2 = null, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency = null, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodylanguageTypeInput> bodylanguageType = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bodyreferenceTypeInput> bodyreferenceType = null, [WorkflowExpression] Func<bodyseperatorLineInput> bodyseperatorLine = null, [WorkflowExpression] Func<bodyudAddressTypeInput> bodyudAddressType = null, [WorkflowExpression] Func<string> bodyudCity = null, [WorkflowExpression] Func<string> bodyudName = null, [WorkflowExpression] Func<string> bodyudPostalCode = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine2 = null, [WorkflowExpression] Func<string> bodyunstructuredMessage = null)
        {
            SourceExpression.Validate(bodycrAddressType, nameof(bodycrAddressType), required: true);
            SourceExpression.Validate(bodycrName, nameof(bodycrName), required: true);
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodyiban, nameof(bodyiban), required: true);
            SourceExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            SourceExpression.Validate(bodyav1Parameters, nameof(bodyav1Parameters), required: false);
            SourceExpression.Validate(bodyav2Parameters, nameof(bodyav2Parameters), required: false);
            SourceExpression.Validate(bodybillingInfo, nameof(bodybillingInfo), required: false);
            SourceExpression.Validate(bodycrCity, nameof(bodycrCity), required: false);
            SourceExpression.Validate(bodycrPostalCode, nameof(bodycrPostalCode), required: false);
            SourceExpression.Validate(bodycrStreetOrAddressLine1, nameof(bodycrStreetOrAddressLine1), required: false);
            SourceExpression.Validate(bodycrStreetOrAddressLine2, nameof(bodycrStreetOrAddressLine2), required: false);
            SourceExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodylanguageType, nameof(bodylanguageType), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodyreferenceType, nameof(bodyreferenceType), required: false);
            SourceExpression.Validate(bodyseperatorLine, nameof(bodyseperatorLine), required: false);
            SourceExpression.Validate(bodyudAddressType, nameof(bodyudAddressType), required: false);
            SourceExpression.Validate(bodyudCity, nameof(bodyudCity), required: false);
            SourceExpression.Validate(bodyudName, nameof(bodyudName), required: false);
            SourceExpression.Validate(bodyudPostalCode, nameof(bodyudPostalCode), required: false);
            SourceExpression.Validate(bodyudStreetOrAddressLine1, nameof(bodyudStreetOrAddressLine1), required: false);
            SourceExpression.Validate(bodyudStreetOrAddressLine2, nameof(bodyudStreetOrAddressLine2), required: false);
            SourceExpression.Validate(bodyunstructuredMessage, nameof(bodyunstructuredMessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodyav1Parameters != null)
                {
                    body["av1Parameters"] = SourceExpressionConverter.ConvertToken(bodyav1Parameters);
                    bodypropCount++;
                }

                if (bodyav2Parameters != null)
                {
                    body["av2Parameters"] = SourceExpressionConverter.ConvertToken(bodyav2Parameters);
                    bodypropCount++;
                }

                if (bodybillingInfo != null)
                {
                    body["billingInfo"] = SourceExpressionConverter.ConvertToken(bodybillingInfo);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crAddressType"] = SourceExpressionConverter.Convert(bodycrAddressType);
                if (bodycrCity != null)
                {
                    body["crCity"] = SourceExpressionConverter.ConvertToken(bodycrCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crName"] = SourceExpressionConverter.ConvertToken(bodycrName);
                if (bodycrPostalCode != null)
                {
                    body["crPostalCode"] = SourceExpressionConverter.ConvertToken(bodycrPostalCode);
                    bodypropCount++;
                }

                if (bodycrStreetOrAddressLine1 != null)
                {
                    body["crStreetOrAddressLine1"] = SourceExpressionConverter.ConvertToken(bodycrStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (bodycrStreetOrAddressLine2 != null)
                {
                    body["crStreetOrAddressLine2"] = SourceExpressionConverter.ConvertToken(bodycrStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    if (bodycurrency != null)
                    {
                        body["currency"] = SourceExpressionConverter.Convert(bodycurrency);
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
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = SourceExpressionConverter.ConvertToken(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["iban"] = SourceExpressionConverter.ConvertToken(bodyiban);
                if (bodylanguageType != null)
                {
                    if (bodylanguageType != null)
                    {
                        body["languageType"] = SourceExpressionConverter.Convert(bodylanguageType);
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
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyreferenceType != null)
                {
                    if (bodyreferenceType != null)
                    {
                        body["referenceType"] = SourceExpressionConverter.Convert(bodyreferenceType);
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
                        body["seperatorLine"] = SourceExpressionConverter.Convert(bodyseperatorLine);
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
                        body["udAddressType"] = SourceExpressionConverter.Convert(bodyudAddressType);
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
                    body["udCity"] = SourceExpressionConverter.ConvertToken(bodyudCity);
                    bodypropCount++;
                }

                if (bodyudName != null)
                {
                    body["udName"] = SourceExpressionConverter.ConvertToken(bodyudName);
                    bodypropCount++;
                }

                if (bodyudPostalCode != null)
                {
                    body["udPostalCode"] = SourceExpressionConverter.ConvertToken(bodyudPostalCode);
                    bodypropCount++;
                }

                if (bodyudStreetOrAddressLine1 != null)
                {
                    body["udStreetOrAddressLine1"] = SourceExpressionConverter.ConvertToken(bodyudStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (bodyudStreetOrAddressLine2 != null)
                {
                    body["udStreetOrAddressLine2"] = SourceExpressionConverter.ConvertToken(bodyudStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (bodyunstructuredMessage != null)
                {
                    body["unstructuredMessage"] = SourceExpressionConverter.ConvertToken(bodyunstructuredMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<string> ReadSwissQrBill([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = SourceExpressionConverter.ConvertToken(bodydocumentname);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meswissqr")]
        public IBodyWorkflowAction<SplitDocBySwissQrCodeV1Response> SplitDocBySwissQrCode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodysplitBarcodePageInput> bodysplitBarcodePage, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodycombinePagesWithSameConsecutiveBarcodes = null, [WorkflowExpression] Func<string> bodypdfRenderDpi = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodysplitBarcodePage, nameof(bodysplitBarcodePage), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodycombinePagesWithSameConsecutiveBarcodes, nameof(bodycombinePagesWithSameConsecutiveBarcodes), required: false);
            SourceExpression.Validate(bodypdfRenderDpi, nameof(bodypdfRenderDpi), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodydocumentname != null)
                {
                    documentObject["Name"] = SourceExpressionConverter.ConvertToken(bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["splitBarcodePage"] = SourceExpressionConverter.Convert(bodysplitBarcodePage);
                if (bodycombinePagesWithSameConsecutiveBarcodes != null)
                {
                    if (bodycombinePagesWithSameConsecutiveBarcodes != null)
                    {
                        body["combinePagesWithSameConsecutiveBarcodes"] = SourceExpressionConverter.ConvertToken(bodycombinePagesWithSameConsecutiveBarcodes);
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
                        body["pdfRenderDpi"] = SourceExpressionConverter.ConvertToken(bodypdfRenderDpi);
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
                return callPayload;
            }

            return new ApiConnectionAction<SplitDocBySwissQrCodeV1Response>(BuildSourceInput);
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