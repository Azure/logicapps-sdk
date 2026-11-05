//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aquaforest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AquaforestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiRenameByBarcodePost200ApplicationJsonResponse, ApiConnectionActionConfiguration> GetBarcodeValue(Expression<Func<GetBarcodeValueInput>> getBarcode = null)
        {
            var __workflow_getBarcode = WorkflowExpression.Compile(getBarcode, nameof(getBarcode), required: false);
            return new DeferredBodyAction<ApiRenameByBarcodePost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetBarcodeValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_getBarcode != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_getBarcode);
                return new ApiConnectionAction<ApiRenameByBarcodePost200ApplicationJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<GetPDFInfoResponse, ApiConnectionActionConfiguration> GetPdfInformation(Expression<Func<GetPdfInformationInput>> getPDFInfoRequest = null)
        {
            var __workflow_getPDFInfoRequest = WorkflowExpression.Compile(getPDFInfoRequest, nameof(getPDFInfoRequest), required: false);
            return new DeferredBodyAction<GetPDFInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPDFInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_getPDFInfoRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_getPDFInfoRequest);
                return new ApiConnectionAction<GetPDFInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDataFromPdf(Expression<Func<GetDataFromPdfInput>> getDataFromPDFRequest = null)
        {
            var __workflow_getDataFromPDFRequest = WorkflowExpression.Compile(getDataFromPDFRequest, nameof(getDataFromPDFRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetPageData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_getDataFromPDFRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_getDataFromPDFRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiGetTextValueJsonResponse, ApiConnectionActionConfiguration> GetTextValue(Expression<Func<GetTextValueInput>> getText = null)
        {
            var __workflow_getText = WorkflowExpression.Compile(getText, nameof(getText), required: false);
            return new DeferredBodyAction<ApiGetTextValueJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_getText != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_getText);
                return new ApiConnectionAction<ApiGetTextValueJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<OcrResponse, ApiConnectionActionConfiguration> OcrFileToPdf(Expression<Func<OcrFileToPdfInput>> ocrData = null)
        {
            var __workflow_ocrData = WorkflowExpression.Compile(ocrData, nameof(ocrData), required: false);
            return new DeferredBodyAction<OcrResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/OcrFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ocrData != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_ocrData);
                return new ApiConnectionAction<OcrResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration> SplitByBarcode(Expression<Func<SplitByBarcodeInput>> splitBarcode = null)
        {
            var __workflow_splitBarcode = WorkflowExpression.Compile(splitBarcode, nameof(splitBarcode), required: false);
            return new DeferredBodyAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SplitByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_splitBarcode != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_splitBarcode);
                return new ApiConnectionAction<ApiSplitPost200ApplicationJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration> SplitByText(Expression<Func<SplitByTextInput>> splitText = null)
        {
            var __workflow_splitText = WorkflowExpression.Compile(splitText, nameof(splitText), required: false);
            return new DeferredBodyAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SplitByText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_splitText != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_splitText);
                return new ApiConnectionAction<ApiSplitPost200ApplicationJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiExtractPost200ApplicationJsonResponse, ApiConnectionActionConfiguration> ExtractByBarcode(Expression<Func<ExtractByBarcodeInput>> extractBarcode = null)
        {
            var __workflow_extractBarcode = WorkflowExpression.Compile(extractBarcode, nameof(extractBarcode), required: false);
            return new DeferredBodyAction<ApiExtractPost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ExtractPageByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractBarcode != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_extractBarcode);
                return new ApiConnectionAction<ApiExtractPost200ApplicationJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiExtractPost200ApplicationJsonResponse, ApiConnectionActionConfiguration> ExtractByText(Expression<Func<ExtractByTextInput>> extractText = null)
        {
            var __workflow_extractText = WorkflowExpression.Compile(extractText, nameof(extractText), required: false);
            return new DeferredBodyAction<ApiExtractPost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ExtractPageByText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extractText != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_extractText);
                return new ApiConnectionAction<ApiExtractPost200ApplicationJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aquaforest")]
        public IBodyWorkflowAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration> SplitByPageRange(Expression<Func<SplitByPageRangeInput>> splitPdfByPage = null)
        {
            var __workflow_splitPdfByPage = WorkflowExpression.Compile(splitPdfByPage, nameof(splitPdfByPage), required: false);
            return new DeferredBodyAction<ApiSplitPost200ApplicationJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SplitPdfByPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_splitPdfByPage != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_splitPdfByPage);
                return new ApiConnectionAction<ApiSplitPost200ApplicationJsonResponse>(callPayload);
            });
        }
    }

    public class AquaforestTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiRenameByBarcodePost200ApplicationJsonResponse
    {
        [JsonProperty("BarcodeResult")]
        public string Barcode { get; set; }

        [JsonProperty("BarcodeResults")]
        public ApiRenameByBarcodePost200ApplicationJsonResponseResultsTypeItem[] Results { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSuccessful { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }
    }

    public class ApiRenameByBarcodePost200ApplicationJsonResponseResultsTypeItem
    {
        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("valueExtracted")]
        public string PageBarcode { get; set; }

        [JsonProperty("zoneValues")]
        public string[] ZoneValues { get; set; }
    }

    public class GetBarcodeValueInput
    {
        [JsonProperty("barcodeResultTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeResultTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("noBarcodeTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoBarcodeTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("pageSeparator")]
        public string PageSeparator { get; set; }

        [JsonProperty("pagerange")]
        public string Pages { get; set; }

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("zones", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetBarcodeValueInputBarcodeTypeItem[] Barcode { get; set; } = new GetBarcodeValueInputBarcodeTypeItem[]
        {
        };
    }

    public class GetBarcodeValueInputBarcodeTypeItem
    {
        [JsonProperty("barcodeFormats")]
        public GetBarcodeValueInputBarcodeTypeItemTypeTypeItem[] Type { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("pagenumber")]
        public int? PageDeprecated { get; set; }

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetBarcodeValueInputBarcodeTypeItemTypeTypeItem
    {
        [EnumMember(Value = "All 1D")]
        All1D,
        AZTEC,
        CODABAR,
        [EnumMember(Value = "CODE 128")]
        CODE128,
        [EnumMember(Value = "CODE 39")]
        CODE39,
        [EnumMember(Value = "CODE 93")]
        CODE93,
        [EnumMember(Value = "DATA MATRIX")]
        DATAMATRIX,
        [EnumMember(Value = "EAN 13")]
        EAN13,
        [EnumMember(Value = "EAN 8")]
        EAN8,
        ITF,
        MAXICODE,
        MSI,
        [EnumMember(Value = "PDF 417")]
        PDF417,
        PLESSEY,
        [EnumMember(Value = "QR CODE")]
        QRCODE,
        [EnumMember(Value = "RSS 14")]
        RSS14,
        [EnumMember(Value = "RSS EXPANDED")]
        RSSEXPANDED,
        [EnumMember(Value = "UPC A")]
        UPCA,
        [EnumMember(Value = "UPC E")]
        UPCE,
        [EnumMember(Value = "UPC EAN EXTENSION")]
        UPCEANEXTENSION
    }

    public class GetPDFInfoResponse
    {
        public bool AllowAssembly { get; set; }
        public bool AllowDegradedPrinting { get; set; }
        public bool AllowExtractContents { get; set; }
        public bool AllowExtractForAccessibility { get; set; }
        public bool AllowFillInForm { get; set; }
        public bool AllowModifyAnnotations { get; set; }
        public bool AllowModifyContents { get; set; }
        public bool AllowPrinting { get; set; }
        public string Author { get; set; }
        public string CreationDate { get; set; }
        public string Creator { get; set; }
        public string ErrorMessage { get; set; }

        [JsonProperty("FileSize")]
        public double FileSizeBytes { get; set; }
        public bool HasHiddenText { get; set; }
        public bool IsEncrypted { get; set; }
        public bool IsSearchable { get; set; }
        public bool IsSuccessful { get; set; }
        public string Keywords { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }
        public string ModifiedDate { get; set; }

        [JsonProperty("NumberofPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("PDFversion")]
        public double PDFVersion { get; set; }
        public string Producer { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public string Trapped { get; set; }

        [JsonProperty("XmpMetadata")]
        public string XMPMetadata { get; set; }
    }

    public class GetPdfInformationInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("pageLimit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PageLimit { get; set; } = 10;
    }

    public class GetDataFromPdfInput
    {
        [JsonProperty("advancedFlags")]
        public GetDataFromPdfInputAdvancedSettingsTypeItem[] AdvancedSettings { get; set; }

        [JsonProperty("confidenceScore")]
        public double? ConfidenceScore { get; set; }

        [JsonProperty("dateAsISO", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDataFromPdfInputDateConversionType? DateConversion { get; set; } = GetDataFromPdfInputDateConversionType.ISOConversionDMYInputAssumed;

        [JsonProperty("expectedKeys")]
        public string ExpectedKeys { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("pageLimit")]
        public int? PageLimit { get; set; }

        [JsonProperty("pageRange")]
        public string PageRange { get; set; }

        [JsonProperty("stripCurrencySymbol", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StripCurrencySymbol { get; set; } = false;

        [JsonProperty("synonym", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchSynonym { get; set; } = true;

        [JsonProperty("synonymDictionary")]
        public string SynonymDictionary { get; set; }

        [JsonProperty("trimSymbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrimSymbols { get; set; } = true;
    }

    public class GetDataFromPdfInputAdvancedSettingsTypeItem
    {
        [JsonProperty("settingName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("settingValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetDataFromPdfInputDateConversionType
    {
        [EnumMember(Value = "Do not convert date values")]
        DoNotConvertDateValues,
        [EnumMember(Value = "ISO conversion (DMY input assumed)")]
        ISOConversionDMYInputAssumed,
        [EnumMember(Value = "ISO conversion (MDY input assumed)")]
        ISOConversionMDYInputAssumed
    }

    public class ApiGetTextValueJsonResponse
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccessful { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }
        public string TextResult { get; set; }

        [JsonProperty("TextResults")]
        public ApiGetTextValueJsonResponseResultsTypeItem[] Results { get; set; }
    }

    public class ApiGetTextValueJsonResponseResultsTypeItem
    {
        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }

        [JsonProperty("valueExtracted")]
        public string PageText { get; set; }

        [JsonProperty("zoneValues")]
        public string[] ZoneValues { get; set; }
    }

    public class GetTextValueInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("noTextTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoTextMatchTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("pageSeparator")]
        public string PageSeparator { get; set; }

        [JsonProperty("pagerange")]
        public string Pages { get; set; }

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("textResultTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextResultTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("zones", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetTextValueInputTextTypeItem[] Text { get; set; } = new GetTextValueInputTextTypeItem[]
        {
        };
    }

    public class GetTextValueInputTextTypeItem
    {
        [JsonProperty("expression")]
        public string[] Value { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("pagenumber")]
        public int? PageDeprecated { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetTextValueInputTextTypeItemSelectType? Select { get; set; } = GetTextValueInputTextTypeItemSelectType.TextInZone;

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTextValueInputTextTypeItemSelectType
    {
        [EnumMember(Value = "text in zone")]
        TextInZone,
        [EnumMember(Value = "word after value")]
        WordAfterValue,
        [EnumMember(Value = "word before value")]
        WordBeforeValue,
        [EnumMember(Value = "all text in line after value")]
        AllTextInLineAfterValue,
        [EnumMember(Value = "all text in line before value")]
        AllTextInLineBeforeValue,
        [EnumMember(Value = "all text in zone after value")]
        AllTextInZoneAfterValue,
        [EnumMember(Value = "all text in zone before value")]
        AllTextInZoneBeforeValue
    }

    public class OcrResponse
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccessful { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }
        public string LogFileContent { get; set; }

        [JsonProperty("OutputFileContent")]
        public string ProcessedFileContent { get; set; }
    }

    public class OcrFileToPdfInput
    {
        [JsonProperty("aquaforestImageTimeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? AquaforestImageTimeout { get; set; } = 120000;

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("autorotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoRotate { get; set; } = true;

        [JsonProperty("binarize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Binarize { get; set; } = 200;

        [JsonProperty("blackPixelLimit", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? BlackPixelLimit { get; set; } = 0.65;

        [JsonProperty("blankPageThreshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? BlankPageThreshold { get; set; } = -1;

        [JsonProperty("boxSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? BoxSize { get; set; } = 0;

        [JsonProperty("convertToTiff", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConvertToTiff { get; set; } = false;

        [JsonProperty("createProcess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateProcess { get; set; } = false;

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("deskew", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Deskew { get; set; } = false;

        [JsonProperty("despeckle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Despeckle { get; set; } = 0;

        [JsonProperty("dictionaryLookup", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DictionaryLookup { get; set; } = 2;

        [JsonProperty("dotmatrix", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Dotmatrix { get; set; } = false;

        [JsonProperty("enableDebugOutput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableDebugOutput { get; set; } = false;

        [JsonProperty("enableMrc", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CompressPDFMRC { get; set; } = false;

        [JsonProperty("enablePDFAOutput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PDFAOutput { get; set; } = false;

        [JsonProperty("errorMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ErrorMode { get; set; } = 7;

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("fileNameWithExtension", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileNameWithExtension { get; set; }

        [JsonProperty("flipDetect", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FlipDetect { get; set; } = 2;

        [JsonProperty("grayscaleQuality")]
        public int? GrayscaleQuality { get; set; }

        [JsonProperty("heuristics", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Heuristics { get; set; } = 2;

        [JsonProperty("jbig2EncFlags")]
        public string Jbig2EncFlags { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrFileToPdfInputLanguageType? Language { get; set; } = OcrFileToPdfInputLanguageType.English;

        [JsonProperty("libTiffSavePageAsBmp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LibTiffSavePageAsBmp { get; set; } = false;

        [JsonProperty("maxDeskew", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MaximumDeskew { get; set; } = 10;

        [JsonProperty("minDeskewConfidence", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MinimumDeskewConfidence { get; set; } = 3;

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("morph")]
        public string Morph { get; set; }

        [JsonProperty("mrcBackgroundFactor", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MrcBackgroundFactor { get; set; } = 3;

        [JsonProperty("mrcForegroundFactor", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MrcForegroundFactor { get; set; } = 3;

        [JsonProperty("mrcQuality", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MrcQuality { get; set; } = 75;

        [JsonProperty("mrcTimeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MrcTimeout { get; set; } = 120000;

        [JsonProperty("noPictures", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoPictures { get; set; } = false;

        [JsonProperty("ocrProcessSetupTimeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? OcrProcessSetupTimeout { get; set; } = 110000;

        [JsonProperty("ocrTimeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? OcrTimeout { get; set; } = 150000;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("pdfToImageBpp")]
        public OcrFileToPdfInputPdfToImageBppType? PdfToImageBpp { get; set; }

        [JsonProperty("pdfToImageCompression")]
        public OcrFileToPdfInputPdfToImageCompressionType? PdfToImageCompression { get; set; }

        [JsonProperty("pdfToImageDpi")]
        public OcrFileToPdfInputPdfToImageDpiType? PdfToImageDpi { get; set; }

        [JsonProperty("pdfToImageForceVectorCheck", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PdfToImageForceVectorCheck { get; set; } = false;

        [JsonProperty("pdfToImageIncludeText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PdfToImageIncludeText { get; set; } = false;

        [JsonProperty("pdfToImageMaxRes", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PdfToImageMaxRes { get; set; } = 600;

        [JsonProperty("pdfToImageMinRes", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PdfToImageMinRes { get; set; } = 200;

        [JsonProperty("pdfaVersion")]
        public OcrFileToPdfInputPDFAVersionType? PDFAVersion { get; set; }

        [JsonProperty("pipeClientConnectionTimeout", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PipeClientConnectionTimeout { get; set; } = 60000;

        [JsonProperty("removeBlankPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveBlankPage { get; set; } = false;

        [JsonProperty("removeLines", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveLines { get; set; } = false;

        [JsonProperty("restartEngineEvery", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RestartEngineEvery { get; set; } = 10;

        [JsonProperty("retainBookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainBookmarks { get; set; } = false;

        [JsonProperty("retainCreationDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainCreationDate { get; set; } = false;

        [JsonProperty("retainMetadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainMetadata { get; set; } = false;

        [JsonProperty("retainModifiedDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainModifiedDate { get; set; } = false;

        [JsonProperty("retainViewerPreferences", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainViewerPreferences { get; set; } = false;

        [JsonProperty("savePredespeckle", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SavePredespeckle { get; set; } = true;

        [JsonProperty("tables", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Tables { get; set; } = false;

        [JsonProperty("textLayerFilterHeight", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TextLayerFilterHeight { get; set; } = 130;

        [JsonProperty("textLayerFilterHeightInverted", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TextLayerFilterHeightInverted { get; set; } = 40;

        [JsonProperty("textLayerFilterPercentage", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TextLayerFilterPercentage { get; set; } = 0.6;

        [JsonProperty("textLayerFilterPercentageInverted", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TextLayerFilterPercentageInverted { get; set; } = 0.5;

        [JsonProperty("textLayerFilterRatio", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TextLayerFilterRatio { get; set; } = 1;

        [JsonProperty("textLayerFilterRatioInverted", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TextLayerFilterRatioInverted { get; set; } = 0.95;

        [JsonProperty("textLayerFilterWidth", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TextLayerFilterWidth { get; set; } = 130;

        [JsonProperty("textLayerFilterWidthInverted", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TextLayerFilterWidthInverted { get; set; } = 40;

        [JsonProperty("textLayerMaxBoxes", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TextLayerMaxBoxes { get; set; } = 0;

        [JsonProperty("tidyUpMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TidyUpMode { get; set; } = 1;

        [JsonProperty("validatePDFA", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidatePDFA { get; set; } = false;

        [JsonProperty("wordMatchThreshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? WordMatchThreshold { get; set; } = 10;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrFileToPdfInputLanguageType
    {
        English,
        German,
        French,
        Russian,
        Swedish,
        Spanish,
        Italian,
        [EnumMember(Value = "Russian_English")]
        RussianEnglish,
        Ukrainian,
        Serbian,
        Croatian,
        Polish,
        Danish,
        Portuguese,
        Dutch,
        Czech,
        Roman,
        Hungar,
        Bulgar,
        Slovenian,
        Latvian,
        Lithuanian,
        Estonian,
        Turkish
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrFileToPdfInputPdfToImageBppType
    {
        [EnumMember(Value = "Bpp_1")]
        Bpp1,
        [EnumMember(Value = "Bpp_24")]
        Bpp24
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrFileToPdfInputPdfToImageCompressionType
    {
        CCITT4,
        LZW
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrFileToPdfInputPdfToImageDpiType
    {
        [EnumMember(Value = "DPI_72")]
        DPI72,
        [EnumMember(Value = "DPI_100")]
        DPI100,
        [EnumMember(Value = "DPI_150")]
        DPI150,
        [EnumMember(Value = "DPI_200")]
        DPI200,
        [EnumMember(Value = "DPI_300")]
        DPI300,
        [EnumMember(Value = "DPI_400")]
        DPI400,
        [EnumMember(Value = "DPI_500")]
        DPI500,
        [EnumMember(Value = "DPI_600")]
        DPI600
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrFileToPdfInputPDFAVersionType
    {
        [EnumMember(Value = "PDF_A1b")]
        PDFA1b,
        [EnumMember(Value = "PDF_A2b")]
        PDFA2b,
        [EnumMember(Value = "PDF_A3b")]
        PDFA3b
    }

    public class ApiSplitPost200ApplicationJsonResponse
    {
        public string ErrorMessage { get; set; }
        public bool IsSuccessful { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }

        [JsonProperty("SplittedFile")]
        public ApiSplitPost200ApplicationJsonResponseSplitOutputFilesTypeItem[] SplitOutputFiles { get; set; }
    }

    public class ApiSplitPost200ApplicationJsonResponseSplitOutputFilesTypeItem
    {
        [JsonProperty("SplitFileContent")]
        public string FileContent { get; set; }

        [JsonProperty("SplitFileName")]
        public string FileName { get; set; }

        [JsonProperty("pageNumber")]
        public string PageRange { get; set; }
    }

    public class SplitByBarcodeInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileNameTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileNameTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("noMatch", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByBarcodeInputPagesWithNoMatchType? PagesWithNoMatch { get; set; } = SplitByBarcodeInputPagesWithNoMatchType.DoNotCopyToOutput;

        [JsonProperty("noTextFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoBarcodeMatchTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("splitOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByBarcodeInputOutputFileOptionsType? OutputFileOptions { get; set; } = SplitByBarcodeInputOutputFileOptionsType.BarcodeOnFirstPage;

        [JsonProperty("zones")]
        public SplitByBarcodeInputBarcodeTypeItem[] Barcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByBarcodeInputPagesWithNoMatchType
    {
        [EnumMember(Value = "Do not copy to output")]
        DoNotCopyToOutput,
        [EnumMember(Value = "Copy to output")]
        CopyToOutput,
        [EnumMember(Value = "Copy to output and rename")]
        CopyToOutputAndRename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByBarcodeInputOutputFileOptionsType
    {
        [EnumMember(Value = "Barcode on first page")]
        BarcodeOnFirstPage,
        [EnumMember(Value = "Barcode on last page")]
        BarcodeOnLastPage,
        [EnumMember(Value = "Remove barcode page")]
        RemoveBarcodePage
    }

    public class SplitByBarcodeInputBarcodeTypeItem
    {
        [JsonProperty("barcodeFormats")]
        public SplitByBarcodeInputBarcodeTypeItemTypeTypeItem[] Type { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByBarcodeInputBarcodeTypeItemTypeTypeItem
    {
        [EnumMember(Value = "All 1D")]
        All1D,
        AZTEC,
        CODABAR,
        [EnumMember(Value = "CODE 128")]
        CODE128,
        [EnumMember(Value = "CODE 39")]
        CODE39,
        [EnumMember(Value = "CODE 93")]
        CODE93,
        [EnumMember(Value = "DATA MATRIX")]
        DATAMATRIX,
        [EnumMember(Value = "EAN 13")]
        EAN13,
        [EnumMember(Value = "EAN 8")]
        EAN8,
        ITF,
        MAXICODE,
        MSI,
        [EnumMember(Value = "PDF 417")]
        PDF417,
        PLESSEY,
        [EnumMember(Value = "QR CODE")]
        QRCODE,
        [EnumMember(Value = "RSS 14")]
        RSS14,
        [EnumMember(Value = "RSS EXPANDED")]
        RSSEXPANDED,
        [EnumMember(Value = "UPC A")]
        UPCA,
        [EnumMember(Value = "UPC E")]
        UPCE,
        [EnumMember(Value = "UPC EAN EXTENSION")]
        UPCEANEXTENSION
    }

    public class SplitByTextInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileNameTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileNameTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("noMatch", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextInputPagesWithNoMatchType? PagesWithNoMatch { get; set; } = SplitByTextInputPagesWithNoMatchType.DoNotCopyToOutput;

        [JsonProperty("noTextFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoFileTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("splitOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextInputOutputFileOptionsType? OutputFileOptions { get; set; } = SplitByTextInputOutputFileOptionsType.PageThatMatchesTextOnFirstPage;

        [JsonProperty("zones")]
        public SplitByTextInputTextTypeItem[] Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByTextInputPagesWithNoMatchType
    {
        [EnumMember(Value = "Do not copy to output")]
        DoNotCopyToOutput,
        [EnumMember(Value = "Copy to output")]
        CopyToOutput,
        [EnumMember(Value = "Copy to output and rename")]
        CopyToOutputAndRename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByTextInputOutputFileOptionsType
    {
        [EnumMember(Value = "Page that matches text on first page")]
        PageThatMatchesTextOnFirstPage,
        [EnumMember(Value = "Page that matches text on last page")]
        PageThatMatchesTextOnLastPage,
        [EnumMember(Value = "Remove the page that matches text")]
        RemoveThePageThatMatchesText
    }

    public class SplitByTextInputTextTypeItem
    {
        [JsonProperty("expression")]
        public string[] Value { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextInputTextTypeItemSelectType? Select { get; set; } = SplitByTextInputTextTypeItemSelectType.TextInZone;

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByTextInputTextTypeItemSelectType
    {
        [EnumMember(Value = "text in zone")]
        TextInZone,
        [EnumMember(Value = "word after value")]
        WordAfterValue,
        [EnumMember(Value = "word before value")]
        WordBeforeValue,
        [EnumMember(Value = "all text in line after value")]
        AllTextInLineAfterValue,
        [EnumMember(Value = "all text in line before value")]
        AllTextInLineBeforeValue,
        [EnumMember(Value = "all text in zone after value")]
        AllTextInZoneAfterValue,
        [EnumMember(Value = "all text in zone before value")]
        AllTextInZoneBeforeValue
    }

    public class ApiExtractPost200ApplicationJsonResponse
    {
        [JsonProperty("ErrorMessage")]
        public string Error { get; set; }
        public bool IsSuccessful { get; set; }

        [JsonProperty("LicenceInfo")]
        public string LicenseInfo { get; set; }

        [JsonProperty("SplittedFile")]
        public ApiExtractPost200ApplicationJsonResponseExtractOutputFilesTypeItem[] ExtractOutputFiles { get; set; }
    }

    public class ApiExtractPost200ApplicationJsonResponseExtractOutputFilesTypeItem
    {
        [JsonProperty("SplitFileContent")]
        public string FileContent { get; set; }

        [JsonProperty("SplitFileName")]
        public string FileName { get; set; }

        [JsonProperty("pageNumber")]
        public string PageNumber { get; set; }
    }

    public class ExtractByBarcodeInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileNameTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileNameTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("noTextFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoFileTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("zones")]
        public ExtractByBarcodeInputBarcodeTypeItem[] Barcode { get; set; }
    }

    public class ExtractByBarcodeInputBarcodeTypeItem
    {
        [JsonProperty("barcodeFormats")]
        public ExtractByBarcodeInputBarcodeTypeItemTypeTypeItem[] Type { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractByBarcodeInputBarcodeTypeItemTypeTypeItem
    {
        [EnumMember(Value = "All 1D")]
        All1D,
        AZTEC,
        CODABAR,
        [EnumMember(Value = "CODE 128")]
        CODE128,
        [EnumMember(Value = "CODE 39")]
        CODE39,
        [EnumMember(Value = "CODE 93")]
        CODE93,
        [EnumMember(Value = "DATA MATRIX")]
        DATAMATRIX,
        [EnumMember(Value = "EAN 13")]
        EAN13,
        [EnumMember(Value = "EAN 8")]
        EAN8,
        ITF,
        MAXICODE,
        MSI,
        [EnumMember(Value = "PDF 417")]
        PDF417,
        PLESSEY,
        [EnumMember(Value = "QR CODE")]
        QRCODE,
        [EnumMember(Value = "RSS 14")]
        RSS14,
        [EnumMember(Value = "RSS EXPANDED")]
        RSSEXPANDED,
        [EnumMember(Value = "UPC A")]
        UPCA,
        [EnumMember(Value = "UPC E")]
        UPCE,
        [EnumMember(Value = "UPC EAN EXTENSION")]
        UPCEANEXTENSION
    }

    public class ExtractByTextInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileNameTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileNameTemplate { get; set; } = "%VALUE1%";

        [JsonProperty("noTextFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoFileTemplate { get; set; } = "NoText_%FILENAME%";

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("zones")]
        public ExtractByTextInputTextTypeItem[] Text { get; set; }
    }

    public class ExtractByTextInputTextTypeItem
    {
        [JsonProperty("expression")]
        public string[] Value { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; } = "all";

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractByTextInputTextTypeItemSelectType? Select { get; set; } = ExtractByTextInputTextTypeItemSelectType.TextInZone;

        [JsonProperty("regex")]
        public string Pattern { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractByTextInputTextTypeItemSelectType
    {
        [EnumMember(Value = "text in zone")]
        TextInZone,
        [EnumMember(Value = "word after value")]
        WordAfterValue,
        [EnumMember(Value = "word before value")]
        WordBeforeValue,
        [EnumMember(Value = "all text in line after value")]
        AllTextInLineAfterValue,
        [EnumMember(Value = "all text in line before value")]
        AllTextInLineBeforeValue,
        [EnumMember(Value = "all text in zone after value")]
        AllTextInZoneAfterValue,
        [EnumMember(Value = "all text in zone before value")]
        AllTextInZoneBeforeValue
    }

    public class SplitByPageRangeInput
    {
        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("fileNameTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFileName { get; set; } = "%FILENAME%UNIQUE6.pdf";

        [JsonProperty("sourceFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("splitOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByPageRangeInputSplitTypeType SplitType { get; set; } = SplitByPageRangeInputSplitTypeType.SplitIntoSinglePages;

        [JsonProperty("pageRange")]
        public string PageRange { get; set; }

        [JsonProperty("repeatEvery")]
        public int? RepeatEveryPages { get; set; }

        [JsonProperty("retainBookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainBookmarks { get; set; } = false;

        [JsonProperty("retainMetadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetainMetadata { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByPageRangeInputSplitTypeType
    {
        [EnumMember(Value = "Split into Single Pages")]
        SplitIntoSinglePages,
        [EnumMember(Value = "Split by Page Range")]
        SplitByPageRange,
        [EnumMember(Value = "Split by Repeating Range")]
        SplitByRepeatingRange,
        [EnumMember(Value = "Split by Top Level Bookmark")]
        SplitByTopLevelBookmark
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aquaforest;

    public partial class WorkflowManagedActions
    {
        public AquaforestActions Aquaforest(string connectionId) => new AquaforestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AquaforestTriggers Aquaforest(string connectionId) => new AquaforestTriggers(connectionId);
    }
}