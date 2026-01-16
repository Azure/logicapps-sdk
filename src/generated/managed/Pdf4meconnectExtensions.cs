//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ImageStampV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodyimageFile, Expression<Func<string>> bodyimageName, Expression<Func<string>> bodypages, Expression<Func<bodyalignXInput>> bodyalignX, Expression<Func<bodyalignYInput>> bodyalignY, Expression<Func<string>> bodyheightInMM, Expression<Func<string>> bodywidthInMM, Expression<Func<string>> bodymarginXInMM, Expression<Func<string>> bodymarginYInMM, Expression<Func<int>> bodyopacity, Expression<Func<bool>> bodyshowOnlyInPrint = null)
        {
            var apiCallPath = "/v2/FlowV2/ImageStamp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["imageFile"] = ExpressionConverter.ConvertO(bodyimageFile);
            bodypropCount++;
            body["imageName"] = ExpressionConverter.ConvertO(bodyimageName);
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
            if (bodyshowOnlyInPrint != null)
            {
                body["showOnlyInPrint"] = ExpressionConverter.ConvertO(bodyshowOnlyInPrint);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> SignPdfV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodyimageFile, Expression<Func<string>> bodyimageName, Expression<Func<bodyalignXInput>> bodyalignX, Expression<Func<bodyalignYInput>> bodyalignY, Expression<Func<string>> bodypages, Expression<Func<string>> bodymarginXInMM, Expression<Func<string>> bodymarginYInMM, Expression<Func<int>> bodyopacity, Expression<Func<string>> bodyheightInMM = null, Expression<Func<string>> bodywidthInMM = null)
        {
            var apiCallPath = "/v2/FlowV2/SignPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["imageFile"] = ExpressionConverter.ConvertO(bodyimageFile);
            bodypropCount++;
            body["imageName"] = ExpressionConverter.ConvertO(bodyimageName);
            bodypropCount++;
            body["alignX"] = ExpressionConverter.ConvertO(bodyalignX);
            bodypropCount++;
            body["alignY"] = ExpressionConverter.ConvertO(bodyalignY);
            bodypropCount++;
            body["pages"] = ExpressionConverter.ConvertO(bodypages);
            if (bodyheightInMM != null)
            {
                body["heightInMM"] = ExpressionConverter.ConvertO(bodyheightInMM);
                bodypropCount++;
            }

            if (bodywidthInMM != null)
            {
                body["widthInMM"] = ExpressionConverter.ConvertO(bodywidthInMM);
                bodypropCount++;
            }

            bodypropCount++;
            body["marginXInMM"] = ExpressionConverter.ConvertO(bodymarginXInMM);
            bodypropCount++;
            body["marginYInMM"] = ExpressionConverter.ConvertO(bodymarginYInMM);
            bodypropCount++;
            body["opacity"] = ExpressionConverter.ConvertO(bodyopacity);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ProduceDocWithDataStringV1Response> ProduceDocWithDataStringV1(Expression<Func<string>> bodytemplateDocContent, Expression<Func<string>> bodytemplateDocName, Expression<Func<string>> bodydataArray)
        {
            var apiCallPath = "/v2/FlowV2/MailMergeData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templateDocContent"] = ExpressionConverter.ConvertO(bodytemplateDocContent);
            bodypropCount++;
            body["templateDocName"] = ExpressionConverter.ConvertO(bodytemplateDocName);
            bodypropCount++;
            body["dataArray"] = ExpressionConverter.ConvertO(bodydataArray);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProduceDocWithDataStringV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ConvertHtmlToPdfV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodyindexFilePath = null, Expression<Func<bodylayoutInput>> bodylayout = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<double>> bodyscale = null, Expression<Func<string>> bodytopMargin = null, Expression<Func<string>> bodybottomMargin = null, Expression<Func<string>> bodyleftMargin = null, Expression<Func<string>> bodyrightMargin = null, Expression<Func<bool>> bodyprintBackground = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            if (bodyindexFilePath != null)
            {
                body["indexFilePath"] = ExpressionConverter.ConvertO(bodyindexFilePath);
                bodypropCount++;
            }

            if (bodylayout != null)
            {
                body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["format"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodyscale != null)
            {
                body["scale"] = ExpressionConverter.ConvertO(bodyscale);
                bodypropCount++;
            }

            if (bodytopMargin != null)
            {
                body["topMargin"] = ExpressionConverter.ConvertO(bodytopMargin);
                bodypropCount++;
            }

            if (bodybottomMargin != null)
            {
                body["bottomMargin"] = ExpressionConverter.ConvertO(bodybottomMargin);
                bodypropCount++;
            }

            if (bodyleftMargin != null)
            {
                body["leftMargin"] = ExpressionConverter.ConvertO(bodyleftMargin);
                bodypropCount++;
            }

            if (bodyrightMargin != null)
            {
                body["rightMargin"] = ExpressionConverter.ConvertO(bodyrightMargin);
                bodypropCount++;
            }

            if (bodyprintBackground != null)
            {
                body["printBackground"] = ExpressionConverter.ConvertO(bodyprintBackground);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ConvertMdToPdfV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodymdFilePath = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            if (bodymdFilePath != null)
            {
                body["mdFilePath"] = ExpressionConverter.ConvertO(bodymdFilePath);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ConvertUrlToPdfV1(Expression<Func<string>> bodywebUrl, Expression<Func<bodyauthTypeInput>> bodyauthType = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["webUrl"] = ExpressionConverter.ConvertO(bodywebUrl);
            if (bodyauthType != null)
            {
                body["authType"] = ExpressionConverter.ConvertO(bodyauthType);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> MergeOverlayV1(Expression<Func<string>> bodybaseDocContent, Expression<Func<string>> bodybaseDocName, Expression<Func<string>> bodylayerDocContent, Expression<Func<string>> bodylayerDocName)
        {
            var apiCallPath = "/v2/FlowV2/MergeOverlay";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["baseDocContent"] = ExpressionConverter.ConvertO(bodybaseDocContent);
            bodypropCount++;
            body["baseDocName"] = ExpressionConverter.ConvertO(bodybaseDocName);
            bodypropCount++;
            body["layerDocContent"] = ExpressionConverter.ConvertO(bodylayerDocContent);
            bodypropCount++;
            body["layerDocName"] = ExpressionConverter.ConvertO(bodylayerDocName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<StartPDF4meWfV1Response> StartPDF4meWfV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodywfName)
        {
            var apiCallPath = "/v2/FlowV2/ExecuteWfTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["wfName"] = ExpressionConverter.ConvertO(bodywfName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartPDF4meWfV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> AddBarcodeV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodytext, Expression<Func<bodybarcodeTypeInput>> bodybarcodeType, Expression<Func<string>> bodypages, Expression<Func<bodyalignXInput>> bodyalignX, Expression<Func<bodyalignYInput>> bodyalignY, Expression<Func<string>> bodyheightInMM, Expression<Func<string>> bodywidthInMM, Expression<Func<string>> bodymarginXInMM, Expression<Func<string>> bodymarginYInMM, Expression<Func<int>> bodyopacity, Expression<Func<string>> bodydisplayText = null, Expression<Func<bool>> bodyisTextAbove = null)
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
                body["isTextAbove"] = ExpressionConverter.ConvertO(bodyisTextAbove);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> CreatebarcodeV1(Expression<Func<bodybarcodeTypeInput>> bodybarcodeType, Expression<Func<string>> bodytext, Expression<Func<bool>> bodyhideText = null)
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
                body["hideText"] = ExpressionConverter.ConvertO(bodyhideText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> UnlockV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodypassword)
        {
            var apiCallPath = "/v2/FlowV2/Unlock";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> RotatePageV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<int>> bodypage, Expression<Func<bodyrotationTypeInput>> bodyrotationType)
        {
            var apiCallPath = "/v2/FlowV2/RotatePage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            bodypropCount++;
            body["page"] = ExpressionConverter.ConvertO(bodypage);
            bodypropCount++;
            body["rotationType"] = ExpressionConverter.ConvertO(bodyrotationType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> GenerateDocumentSingleV1(Expression<Func<bodytemplateFileTypeInput>> bodytemplateFileType, Expression<Func<string>> bodytemplateFileName, Expression<Func<string>> bodytemplateFileData, Expression<Func<bodydocumentDataTypeInput>> bodydocumentDataType, Expression<Func<bodyoutputTypeInput>> bodyoutputType, Expression<Func<string>> bodydocumentDataFile = null, Expression<Func<string>> bodydocumentDataText = null, Expression<Func<string>> bodymetaDataJson = null, Expression<Func<bool>> bodykeepPdfEditable = null)
        {
            var apiCallPath = "/v2/FlowV2/GenerateDocumentSingle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templateFileType"] = ExpressionConverter.ConvertO(bodytemplateFileType);
            bodypropCount++;
            body["templateFileName"] = ExpressionConverter.ConvertO(bodytemplateFileName);
            bodypropCount++;
            body["templateFileData"] = ExpressionConverter.ConvertO(bodytemplateFileData);
            bodypropCount++;
            body["documentDataType"] = ExpressionConverter.ConvertO(bodydocumentDataType);
            if (bodydocumentDataFile != null)
            {
                body["documentDataFile"] = ExpressionConverter.ConvertO(bodydocumentDataFile);
                bodypropCount++;
            }

            if (bodydocumentDataText != null)
            {
                body["documentDataText"] = ExpressionConverter.ConvertO(bodydocumentDataText);
                bodypropCount++;
            }

            if (bodymetaDataJson != null)
            {
                body["metaDataJson"] = ExpressionConverter.ConvertO(bodymetaDataJson);
                bodypropCount++;
            }

            bodypropCount++;
            body["outputType"] = ExpressionConverter.ConvertO(bodyoutputType);
            if (bodykeepPdfEditable != null)
            {
                body["keepPdfEditable"] = ExpressionConverter.ConvertO(bodykeepPdfEditable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<GenerateDocumentMultipleV1Response> GenerateDocumentMultipleV1(Expression<Func<bodytemplateFileTypeInput>> bodytemplateFileType, Expression<Func<string>> bodytemplateFileName, Expression<Func<string>> bodytemplateFileData, Expression<Func<bodydocumentDataTypeInput>> bodydocumentDataType, Expression<Func<bodyoutputTypeInput>> bodyoutputType, Expression<Func<string>> bodydocumentDataFile = null, Expression<Func<string>> bodydocumentDataText = null, Expression<Func<string>> bodymetaDataJson = null, Expression<Func<bool>> bodykeepPdfEditable = null)
        {
            var apiCallPath = "/v2/FlowV2/GenerateDocumentMultiple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templateFileType"] = ExpressionConverter.ConvertO(bodytemplateFileType);
            bodypropCount++;
            body["templateFileName"] = ExpressionConverter.ConvertO(bodytemplateFileName);
            bodypropCount++;
            body["templateFileData"] = ExpressionConverter.ConvertO(bodytemplateFileData);
            bodypropCount++;
            body["documentDataType"] = ExpressionConverter.ConvertO(bodydocumentDataType);
            if (bodydocumentDataFile != null)
            {
                body["documentDataFile"] = ExpressionConverter.ConvertO(bodydocumentDataFile);
                bodypropCount++;
            }

            if (bodydocumentDataText != null)
            {
                body["documentDataText"] = ExpressionConverter.ConvertO(bodydocumentDataText);
                bodypropCount++;
            }

            if (bodymetaDataJson != null)
            {
                body["metaDataJson"] = ExpressionConverter.ConvertO(bodymetaDataJson);
                bodypropCount++;
            }

            bodypropCount++;
            body["outputType"] = ExpressionConverter.ConvertO(bodyoutputType);
            if (bodykeepPdfEditable != null)
            {
                body["keepPdfEditable"] = ExpressionConverter.ConvertO(bodykeepPdfEditable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GenerateDocumentMultipleV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> GenerateDocumentFromPdfV2(Expression<Func<string>> bodytemplateDocContent, Expression<Func<string>> bodytemplateDocName, Expression<Func<string>> bodydataArray, Expression<Func<bool>> bodykeepPdfEditable = null)
        {
            var apiCallPath = "/v2/FlowV2/GenerateDocumentFromPdfV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templateDocContent"] = ExpressionConverter.ConvertO(bodytemplateDocContent);
            bodypropCount++;
            body["templateDocName"] = ExpressionConverter.ConvertO(bodytemplateDocName);
            bodypropCount++;
            body["dataArray"] = ExpressionConverter.ConvertO(bodydataArray);
            if (bodykeepPdfEditable != null)
            {
                body["keepPdfEditable"] = ExpressionConverter.ConvertO(bodykeepPdfEditable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> AddPageNumber(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<bodyalignXInput>> bodyalignX, Expression<Func<bodyalignYInput>> bodyalignY, Expression<Func<int>> bodyfontSize, Expression<Func<string>> bodypageNumberFormat = null, Expression<Func<int>> bodymarginXinMM = null, Expression<Func<int>> bodymarginYinMM = null, Expression<Func<bool>> bodyisBold = null, Expression<Func<bool>> bodyisItalic = null, Expression<Func<bool>> bodyskipFirstPage = null)
        {
            var apiCallPath = "/v2/FlowV2/AddPageNumber";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            bodypropCount++;
            body["docName"] = ExpressionConverter.ConvertO(bodydocName);
            if (bodypageNumberFormat != null)
            {
                body["pageNumberFormat"] = ExpressionConverter.ConvertO(bodypageNumberFormat);
                bodypropCount++;
            }

            bodypropCount++;
            body["alignX"] = ExpressionConverter.ConvertO(bodyalignX);
            bodypropCount++;
            body["alignY"] = ExpressionConverter.ConvertO(bodyalignY);
            if (bodymarginXinMM != null)
            {
                body["marginXinMM"] = ExpressionConverter.ConvertO(bodymarginXinMM);
                bodypropCount++;
            }

            if (bodymarginYinMM != null)
            {
                body["marginYinMM"] = ExpressionConverter.ConvertO(bodymarginYinMM);
                bodypropCount++;
            }

            bodypropCount++;
            body["fontSize"] = ExpressionConverter.ConvertO(bodyfontSize);
            if (bodyisBold != null)
            {
                body["isBold"] = ExpressionConverter.ConvertO(bodyisBold);
                bodypropCount++;
            }

            if (bodyisItalic != null)
            {
                body["isItalic"] = ExpressionConverter.ConvertO(bodyisItalic);
                bodypropCount++;
            }

            if (bodyskipFirstPage != null)
            {
                body["skipFirstPage"] = ExpressionConverter.ConvertO(bodyskipFirstPage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ClassifyDocumentV1Response> ClassifyDocumentV1(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentName = null)
        {
            var apiCallPath = "/v2/FlowV2/ClassifyDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentName != null)
            {
                documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentName);
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

            return new ApiConnectionAction<ClassifyDocumentV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ParseDocumentV1Response> ParseDocumentV1(Expression<Func<string>> bodydocContent = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<string>> bodyTemplateName = null)
        {
            var apiCallPath = "/v2/FlowV2/ParseDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocContent != null)
            {
                body["docContent"] = ExpressionConverter.ConvertO(bodydocContent);
                bodypropCount++;
            }

            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentName != null)
            {
                documentObject["Name"] = ExpressionConverter.ConvertO(bodydocumentName);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                body["document"] = documentObject;
                bodypropCount++;
            }

            if (bodyTemplateName != null)
            {
                body["TemplateName"] = ExpressionConverter.ConvertO(bodyTemplateName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ParseDocumentV1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ConvertVisioV1(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertVisio";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> CropImageV1(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/CropImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("Border");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> ResizeImageV1(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/ResizeImage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string> PrepareForPrintV1(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var apiCallPath = "/v2/FlowV2/PrepareForPrint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["schemaVal"] = Convert.ToString("A4");
            if (schemaVal != null)
                callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
            callPayload.Body = ExpressionConverter.ConvertO(operation);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IWorkflowAction CustomAPIV1(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Pdf4meconnectTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<string> GetDocumentFromPDF4me(Expression<Func<string>> bodyName)
        {
            var apiCallPath = "/v2/FlowV2/WebhookSubscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Name"] = ExpressionConverter.ConvertO(bodyName);
            body["CallBackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }
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

    public class ProduceDocWithDataStringV1Response
    {
        [JsonProperty("outputDocuments")]
        public ProduceDocWithDataStringV1ResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class ProduceDocWithDataStringV1ResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public enum bodylayoutInput
    {
        [EnumMember(Value = "")]
        None,
        Portrait,
        Landscape
    }

    public enum bodyformatInput
    {
        [EnumMember(Value = "")]
        None,
        Letter,
        Legal,
        Tabloid,
        Ledger,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6
    }

    public enum bodyauthTypeInput
    {
        NoAuth,
        SharePointLogin
    }

    public class StartPDF4meWfV1Response
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public enum bodybarcodeTypeInput
    {
        QrCode,
        Datamatrix,
        Code128,
        Aztec,
        Pdf417,
        Hanxin
    }

    public enum bodyrotationTypeInput
    {
        NoRotation,
        Clockwise,
        CounterClockwise,
        UpsideDown
    }

    public enum bodytemplateFileTypeInput
    {
        Docx,
        Html,
        Pdf
    }

    public enum bodydocumentDataTypeInput
    {
        Json,
        XML
    }

    public enum bodyoutputTypeInput
    {
        PDF,
        Docx,
        Html
    }

    public class GenerateDocumentMultipleV1Response
    {
        [JsonProperty("outputDocuments")]
        public GenerateDocumentMultipleV1ResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class GenerateDocumentMultipleV1ResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class ClassifyDocumentV1Response
    {
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }

    public class ParseDocumentV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("parseInfo")]
        public JToken ParseInfo { get; set; }
    }

    public enum schemaValInput
    {
        Default,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        B5,
        PageLetter,
        PageLegal,
        PageLedger,
        P11x17,
        Custom
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect;

    public partial class WorkflowManagedActions
    {
        public Pdf4meconnectActions Pdf4meconnect(string connectionId) => new Pdf4meconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meconnectTriggers Pdf4meconnect(string connectionId) => new Pdf4meconnectTriggers(connectionId);
    }
}