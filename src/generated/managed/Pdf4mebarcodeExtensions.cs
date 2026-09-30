//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4mebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> AddBarcode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<string> bodypages, [WorkflowExpression] Func<bodyalignXInput> bodyalignX, [WorkflowExpression] Func<bodyalignYInput> bodyalignY, [WorkflowExpression] Func<string> bodyheightInMM, [WorkflowExpression] Func<string> bodywidthInMM, [WorkflowExpression] Func<string> bodymarginXInMM, [WorkflowExpression] Func<string> bodymarginYInMM, [WorkflowExpression] Func<int> bodyopacity, [WorkflowExpression] Func<string> bodydisplayText = null, [WorkflowExpression] Func<bool> bodyisTextAbove = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocName, nameof(bodydocName), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodybarcodeType, nameof(bodybarcodeType), required: true);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: true);
            SourceExpression.Validate(bodyalignX, nameof(bodyalignX), required: true);
            SourceExpression.Validate(bodyalignY, nameof(bodyalignY), required: true);
            SourceExpression.Validate(bodyheightInMM, nameof(bodyheightInMM), required: true);
            SourceExpression.Validate(bodywidthInMM, nameof(bodywidthInMM), required: true);
            SourceExpression.Validate(bodymarginXInMM, nameof(bodymarginXInMM), required: true);
            SourceExpression.Validate(bodymarginYInMM, nameof(bodymarginYInMM), required: true);
            SourceExpression.Validate(bodyopacity, nameof(bodyopacity), required: true);
            SourceExpression.Validate(bodydisplayText, nameof(bodydisplayText), required: false);
            SourceExpression.Validate(bodyisTextAbove, nameof(bodyisTextAbove), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/AddBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                bodypropCount++;
                body["docName"] = SourceExpressionConverter.ConvertToken(bodydocName);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["barcodeType"] = SourceExpressionConverter.Convert(bodybarcodeType);
                bodypropCount++;
                body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                bodypropCount++;
                body["alignX"] = SourceExpressionConverter.Convert(bodyalignX);
                bodypropCount++;
                body["alignY"] = SourceExpressionConverter.Convert(bodyalignY);
                bodypropCount++;
                body["heightInMM"] = SourceExpressionConverter.ConvertToken(bodyheightInMM);
                bodypropCount++;
                body["widthInMM"] = SourceExpressionConverter.ConvertToken(bodywidthInMM);
                bodypropCount++;
                body["marginXInMM"] = SourceExpressionConverter.ConvertToken(bodymarginXInMM);
                bodypropCount++;
                body["marginYInMM"] = SourceExpressionConverter.ConvertToken(bodymarginYInMM);
                bodypropCount++;
                body["opacity"] = SourceExpressionConverter.ConvertToken(bodyopacity);
                if (bodydisplayText != null)
                {
                    body["displayText"] = SourceExpressionConverter.ConvertToken(bodydisplayText);
                    bodypropCount++;
                }

                if (bodyisTextAbove != null)
                {
                    if (bodyisTextAbove != null)
                    {
                        body["isTextAbove"] = SourceExpressionConverter.ConvertToken(bodyisTextAbove);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> Createbarcode([WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodyhideText = null)
        {
            SourceExpression.Validate(bodybarcodeType, nameof(bodybarcodeType), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyhideText, nameof(bodyhideText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/CreateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["barcodeType"] = SourceExpressionConverter.Convert(bodybarcodeType);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyhideText != null)
                {
                    if (bodyhideText != null)
                    {
                        body["hideText"] = SourceExpressionConverter.ConvertToken(bodyhideText);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateEpcQrCode([WorkflowExpression] Func<bodyepcQrCodeActionversionInput> bodyepcQrCodeActionversion = null, [WorkflowExpression] Func<bodyepcQrCodeActioncharacterSetInput> bodyepcQrCodeActioncharacterSet = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionbic = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionreceiverName = null, [WorkflowExpression] Func<string> bodyepcQrCodeActioniban = null, [WorkflowExpression] Func<double> bodyepcQrCodeActionamount = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionpurpose = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionremittanceReference = null, [WorkflowExpression] Func<string> bodyepcQrCodeActionremittanceText = null, [WorkflowExpression] Func<string> bodyepcQrCodeActioninformation = null)
        {
            SourceExpression.Validate(bodyepcQrCodeActionversion, nameof(bodyepcQrCodeActionversion), required: false);
            SourceExpression.Validate(bodyepcQrCodeActioncharacterSet, nameof(bodyepcQrCodeActioncharacterSet), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionbic, nameof(bodyepcQrCodeActionbic), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionreceiverName, nameof(bodyepcQrCodeActionreceiverName), required: false);
            SourceExpression.Validate(bodyepcQrCodeActioniban, nameof(bodyepcQrCodeActioniban), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionamount, nameof(bodyepcQrCodeActionamount), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionpurpose, nameof(bodyepcQrCodeActionpurpose), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionremittanceReference, nameof(bodyepcQrCodeActionremittanceReference), required: false);
            SourceExpression.Validate(bodyepcQrCodeActionremittanceText, nameof(bodyepcQrCodeActionremittanceText), required: false);
            SourceExpression.Validate(bodyepcQrCodeActioninformation, nameof(bodyepcQrCodeActioninformation), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        epcQrCodeActionObject["version"] = SourceExpressionConverter.Convert(bodyepcQrCodeActionversion);
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
                        epcQrCodeActionObject["characterSet"] = SourceExpressionConverter.Convert(bodyepcQrCodeActioncharacterSet);
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
                    epcQrCodeActionObject["bic"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionbic);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActionreceiverName != null)
                {
                    epcQrCodeActionObject["receiverName"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionreceiverName);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActioniban != null)
                {
                    epcQrCodeActionObject["iban"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActioniban);
                    epcQrCodeActionObjectpropCount++;
                }

                epcQrCodeActionObject["currency"] = "EUR";
                epcQrCodeActionObjectpropCount++;
                if (bodyepcQrCodeActionamount != null)
                {
                    epcQrCodeActionObject["amount"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionamount);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActionpurpose != null)
                {
                    epcQrCodeActionObject["purpose"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionpurpose);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActionremittanceReference != null)
                {
                    epcQrCodeActionObject["remittanceReference"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionremittanceReference);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActionremittanceText != null)
                {
                    epcQrCodeActionObject["remittanceText"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActionremittanceText);
                    epcQrCodeActionObjectpropCount++;
                }

                if (bodyepcQrCodeActioninformation != null)
                {
                    epcQrCodeActionObject["information"] = SourceExpressionConverter.ConvertToken(bodyepcQrCodeActioninformation);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateSwissQrBill([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            SourceExpression.Validate(schemaVal, nameof(schemaVal), required: false);
            SourceExpression.Validate(operation, nameof(operation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBillV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
                if (schemaVal != null)
                    callPayload.Queries["schemaVal"] = SourceExpressionConverter.Convert(schemaVal);
                callPayload.Body = SourceExpressionConverter.ConvertToken(operation);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IWorkflowAction CustomAPI([WorkflowExpression] Func<string> featurePath, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(featurePath, nameof(featurePath), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesV1Response> ReadBarcodes([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodybarcodeTypeInputItem[]> bodybarcodeType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodypages = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodybarcodeType, nameof(bodybarcodeType), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodypages, nameof(bodypages), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodes";
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

                bodypropCount++;
                body["barcodeType"] = SourceExpressionConverter.ConvertToken(bodybarcodeType);
                if (bodypages != null)
                {
                    if (bodypages != null)
                    {
                        body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
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
                return callPayload;
            }

            return new ApiConnectionAction<ReadBarcodesV1Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesFromImageV1Response> ReadBarcodesFromImage([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodesFromImage";
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

            return new ApiConnectionAction<ReadBarcodesFromImageV1Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<SplitDocByBarcodeV1Response> SplitDocByBarcode([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodybarcodeFilterInput> bodybarcodeFilter, [WorkflowExpression] Func<string> bodybarcodeString, [WorkflowExpression] Func<bodybarcodeTypeInput> bodybarcodeType, [WorkflowExpression] Func<bodysplitBarcodePageInput> bodysplitBarcodePage, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodycombinePagesWithSameConsecutiveBarcodes = null, [WorkflowExpression] Func<string> bodypdfRenderDpi = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodybarcodeFilter, nameof(bodybarcodeFilter), required: true);
            SourceExpression.Validate(bodybarcodeString, nameof(bodybarcodeString), required: true);
            SourceExpression.Validate(bodybarcodeType, nameof(bodybarcodeType), required: true);
            SourceExpression.Validate(bodysplitBarcodePage, nameof(bodysplitBarcodePage), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodycombinePagesWithSameConsecutiveBarcodes, nameof(bodycombinePagesWithSameConsecutiveBarcodes), required: false);
            SourceExpression.Validate(bodypdfRenderDpi, nameof(bodypdfRenderDpi), required: false);
            SourceExpression.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
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

                bodypropCount++;
                body["barcodeFilter"] = SourceExpressionConverter.Convert(bodybarcodeFilter);
                bodypropCount++;
                body["barcodeString"] = SourceExpressionConverter.ConvertToken(bodybarcodeString);
                bodypropCount++;
                body["barcodeType"] = SourceExpressionConverter.Convert(bodybarcodeType);
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

                if (bodyisAsync != null)
                {
                    if (bodyisAsync != null)
                    {
                        body["isAsync"] = SourceExpressionConverter.ConvertToken(bodyisAsync);
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
                return callPayload;
            }

            return new ApiConnectionAction<SplitDocByBarcodeV1Response>(BuildSourceInput);
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

    public enum schemaValInput
    {
        PDF,
        PNG,
        JPEG,
        Tiff
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