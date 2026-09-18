//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4mebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> AddBarcode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<string> bodypages, [WorkflowExpression] Func<bodyalignXInput> bodyalignX, [WorkflowExpression] Func<bodyalignYInput> bodyalignY, [WorkflowExpression] Func<string> bodyheightInMM, [WorkflowExpression] Func<string> bodywidthInMM, [WorkflowExpression] Func<string> bodymarginXInMM, [WorkflowExpression] Func<string> bodymarginYInMM, [WorkflowExpression] Func<int> bodyopacity, [WorkflowExpression] Func<string> bodydisplayText = null, [WorkflowExpression] Func<bool> bodyisTextAbove = null)
        {
            var apiCallPath = "/v2/FlowV2/AddBarcode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            bodypropCount++;
            body["barcodeType"] = ExpressionConverter.ConvertO(bodybarcodeType);
            bodypropCount++;
            body["pages"] = ExpressionConverter.ConvertO(bodypages);
            bodypropCount++;
            body["alignX"] = ExpressionConverter.ConvertO(bodyalignX);
            bodypropCount++;
            body["alignY"] = ExpressionConverter.ConvertO(bodyalignY);
            bodypropCount++;
            body["heightInMM"] = ExpressionConverter.ConvertO(bodyheightInMM);
            bodypropCount++;
            body["widthInMM"] = ExpressionConverter.ConvertO(bodywidthInMM);
            bodypropCount++;
            body["marginXInMM"] = ExpressionConverter.ConvertO(bodymarginXInMM);
            bodypropCount++;
            body["marginYInMM"] = ExpressionConverter.ConvertO(bodymarginYInMM);
            bodypropCount++;
            body["opacity"] = ExpressionConverter.ConvertO(bodyopacity);
            if (bodydisplayText != null)
            {
                body["displayText"] = ExpressionConverter.ConvertO(bodydisplayText);
                bodypropCount++;
            }

            if (bodyisTextAbove != null)
            {
                if (bodyisTextAbove != null)
                {
                    body["isTextAbove"] = ExpressionConverter.ConvertO(bodyisTextAbove);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["isTextAbove"] = false;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> Createbarcode([WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodyhideText = null)
        {
            var apiCallPath = "/v2/FlowV2/CreateBarcode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["barcodeType"] = ExpressionConverter.ConvertO(bodybarcodeType);
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodyhideText != null)
            {
                if (bodyhideText != null)
                {
                    body["hideText"] = ExpressionConverter.ConvertO(bodyhideText);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["hideText"] = true;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateEpcQrCode([WorkflowExpression] Func<bodyepcQrCodeActionversionInput> bodyepcQrCodeActionversion = null, [WorkflowExpression] Func<bodyepcQrCodeActioncharacterSetInput> bodyepcQrCodeActioncharacterSet = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionbic = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionreceiverName = null, [WorkflowExpression] Func<string> bodyepcQrCodeActioniban = null, [WorkflowExpression] Func<double> bodyepcQrCodeActionamount = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionpurpose = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionremittanceReference = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionremittanceText = null, [WorkflowExpression] Func<string> bodyepcQrCodeActioninformation = null)
        {
            var apiCallPath = "/v2/FlowV2/CreateEpcQrCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var epcQrCodeActionObject = new JObject();
            var epcQrCodeActionObjectpropCount = 0;
            epcQrCodeActionObject["serviceTag"] = "BCD";
            epcQrCodeActionObjectpropCount++;
            if (bodyepcQrCodeActionversion != null)
            {
                if (bodyepcQrCodeActionversion != null)
                {
                    epcQrCodeActionObject["version"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionversion);
                    epcQrCodeActionObjectpropCount++;
                }

                epcQrCodeActionObjectpropCount++;
            }
            else
            {
                epcQrCodeActionObject["version"] = "V2";
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActioncharacterSet != null)
            {
                if (bodyepcQrCodeActioncharacterSet != null)
                {
                    epcQrCodeActionObject["characterSet"] = ExpressionConverter.ConvertO(bodyepcQrCodeActioncharacterSet);
                    epcQrCodeActionObjectpropCount++;
                }

                epcQrCodeActionObjectpropCount++;
            }
            else
            {
                epcQrCodeActionObject["characterSet"] = "UTF8";
                epcQrCodeActionObjectpropCount++;
            }

            epcQrCodeActionObject["identificationCode"] = "SCT";
            epcQrCodeActionObjectpropCount++;
            if (bodyepcQrCodeActionbic != null)
            {
                epcQrCodeActionObject["bic"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionbic);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActionreceiverName != null)
            {
                epcQrCodeActionObject["receiverName"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionreceiverName);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActioniban != null)
            {
                epcQrCodeActionObject["iban"] = ExpressionConverter.ConvertO(bodyepcQrCodeActioniban);
                epcQrCodeActionObjectpropCount++;
            }

            epcQrCodeActionObject["currency"] = "EUR";
            epcQrCodeActionObjectpropCount++;
            if (bodyepcQrCodeActionamount != null)
            {
                epcQrCodeActionObject["amount"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionamount);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActionpurpose != null)
            {
                epcQrCodeActionObject["purpose"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionpurpose);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActionremittanceReference != null)
            {
                epcQrCodeActionObject["remittanceReference"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionremittanceReference);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActionremittanceText != null)
            {
                epcQrCodeActionObject["remittanceText"] = ExpressionConverter.ConvertO(bodyepcQrCodeActionremittanceText);
                epcQrCodeActionObjectpropCount++;
            }

            if (bodyepcQrCodeActioninformation != null)
            {
                epcQrCodeActionObject["information"] = ExpressionConverter.ConvertO(bodyepcQrCodeActioninformation);
                epcQrCodeActionObjectpropCount++;
            }

            if (epcQrCodeActionObjectpropCount > 0)
            {
                body["epcQrCodeAction"] = epcQrCodeActionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateSwissQrBill([WorkflowExpression] Func<bodycrAddressTypeInput> bodycrAddressType, [WorkflowExpression] Func<string> bodycrName, [WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodyiban, [WorkflowExpression] Func<string> bodyamount = null, [WorkflowExpression] Func<string> bodyav1Parameters = null, [WorkflowExpression] Func<string> bodyav2Parameters = null, [WorkflowExpression] Func<string> bodybillingInfo = null, [WorkflowExpression] Func<string> bodycrCity = null, [WorkflowExpression] Func<string> bodycrPostalCode = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodycrStreetOrAddressLine2 = null, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency = null, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodylanguageTypeInput> bodylanguageType = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bodyreferenceTypeInput> bodyreferenceType = null, [WorkflowExpression] Func<bodyseperatorLineInput> bodyseperatorLine = null, [WorkflowExpression] Func<bodyudAddressTypeInput> bodyudAddressType = null, [WorkflowExpression] Func<string> bodyudCity = null, [WorkflowExpression] Func<string> bodyudName = null, [WorkflowExpression] Func<string> bodyudPostalCode = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine1 = null, [WorkflowExpression] Func<string> bodyudStreetOrAddressLine2 = null, [WorkflowExpression] Func<string> bodyunstructuredMessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IWorkflowAction CustomAPI([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> featurePath, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesV1Response> ReadBarcodes([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodybarcodeTypeInputItem[]> bodybarcodeType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodypages = null)
        {
            var apiCallPath = "/v2/FlowV2/ReadBarcodes";
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

            bodypropCount++;
            body["barcodeType"] = ExpressionConverter.ConvertO(bodybarcodeType);
            if (bodypages != null)
            {
                if (bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(bodypages);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["pages"] = "all";
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ReadBarcodesV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesFromImageV1Response> ReadBarcodesFromImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            var apiCallPath = "/v2/FlowV2/ReadBarcodesFromImage";
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

            return new ApiConnectionAction<ReadBarcodesFromImageV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> ReadSwissQrBill([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<SplitDocByBarcodeV1Response> SplitDocByBarcode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodybarcodeFilterInput> bodybarcodeFilter, [WorkflowExpression] Func<string> bodybarcodeString, [WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<bodysplitBarcodePageInput> bodysplitBarcodePage, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodycombinePagesWithSameConsecutiveBarcodes = null, [WorkflowExpression] Func<string> bodypdfRenderDpi = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
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

            bodypropCount++;
            body["barcodeFilter"] = ExpressionConverter.ConvertO(bodybarcodeFilter);
            bodypropCount++;
            body["barcodeString"] = ExpressionConverter.ConvertO(bodybarcodeString);
            bodypropCount++;
            body["barcodeType"] = ExpressionConverter.ConvertO(bodybarcodeType);
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

            if (bodyisAsync != null)
            {
                if (bodyisAsync != null)
                {
                    body["isAsync"] = ExpressionConverter.ConvertO(bodyisAsync);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["isAsync"] = false;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SplitDocByBarcodeV1Response>(callPayload);
        }
    }

    public class Pdf4mebarcodeTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodybarcodeTypeInput
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    public enum bodyalignXInput
    {
        Left,
        Center,
        Right
    }

    public enum bodyalignYInput
    {
        Top,
        Middle,
        Bottom
    }

    public enum bodyepcQrCodeActionversionInput
    {
        V1,
        V2
    }

    public enum bodyepcQrCodeActioncharacterSetInput
    {
        UTF8,
        [EnumMember(Value = "ISO8859_1")]
        ISO88591,
        [EnumMember(Value = "ISO8859_2")]
        ISO88592,
        [EnumMember(Value = "ISO8859_4")]
        ISO88594,
        [EnumMember(Value = "ISO8859_5")]
        ISO88595,
        [EnumMember(Value = "ISO8859_7")]
        ISO88597,
        [EnumMember(Value = "ISO8859_10")]
        ISO885910,
        [EnumMember(Value = "ISO8859_15")]
        ISO885915
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

    public class ReadBarcodesV1Response
    {
        [JsonProperty("barcodes")]
        public ReadBarcodesV1ResponseBarcodesTypeItem[] Barcodes { get; set; }
    }

    public class ReadBarcodesV1ResponseBarcodesTypeItem
    {
        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }
        public string Value { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public enum bodybarcodeTypeInputItem
    {
        All,
        QrCode,
        Datamatrix,
        Code128,
        Code39,
        Pdf417,
        Code93
    }

    public class ReadBarcodesFromImageV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public class SplitDocByBarcodeV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("barcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public enum bodybarcodeFilterInput
    {
        [EnumMember(Value = "startsWith")]
        StartsWith,
        [EnumMember(Value = "endsWith")]
        EndsWith,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "exact")]
        Exact
    }

    public enum bodysplitBarcodePageInput
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "remove")]
        Remove
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode;

    public partial class WorkflowManagedActions
    {
        public Pdf4mebarcodeActions Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4mebarcodeTriggers Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeTriggers(connectionId);
    }
}