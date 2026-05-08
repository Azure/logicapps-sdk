//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertHtmlToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodyindexFilePath = null, Expression<Func<bodylayoutInput>> bodylayout = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<double>> bodyscale = null, Expression<Func<string>> bodytopMargin = null, Expression<Func<string>> bodybottomMargin = null, Expression<Func<string>> bodyleftMargin = null, Expression<Func<string>> bodyrightMargin = null, Expression<Func<bool>> bodyprintBackground = null)
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
                if (bodylayout != null)
                {
                    body["layout"] = ExpressionConverter.ConvertO(bodylayout);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["layout"] = "Portrait";
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["format"] = "A4";
                bodypropCount++;
            }

            if (bodyscale != null)
            {
                if (bodyscale != null)
                {
                    body["scale"] = ExpressionConverter.ConvertO(bodyscale);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["scale"] = 0.8;
                bodypropCount++;
            }

            if (bodytopMargin != null)
            {
                if (bodytopMargin != null)
                {
                    body["topMargin"] = ExpressionConverter.ConvertO(bodytopMargin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["topMargin"] = "40px";
                bodypropCount++;
            }

            if (bodybottomMargin != null)
            {
                if (bodybottomMargin != null)
                {
                    body["bottomMargin"] = ExpressionConverter.ConvertO(bodybottomMargin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["bottomMargin"] = "40px";
                bodypropCount++;
            }

            if (bodyleftMargin != null)
            {
                if (bodyleftMargin != null)
                {
                    body["leftMargin"] = ExpressionConverter.ConvertO(bodyleftMargin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["leftMargin"] = "40px";
                bodypropCount++;
            }

            if (bodyrightMargin != null)
            {
                if (bodyrightMargin != null)
                {
                    body["rightMargin"] = ExpressionConverter.ConvertO(bodyrightMargin);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["rightMargin"] = "40px";
                bodypropCount++;
            }

            if (bodyprintBackground != null)
            {
                if (bodyprintBackground != null)
                {
                    body["printBackground"] = ExpressionConverter.ConvertO(bodyprintBackground);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["printBackground"] = true;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertJsonToExcel(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<int>> bodyfirstRow = null, Expression<Func<int>> bodyfirstColumn = null, Expression<Func<string>> bodyworksheetName = null, Expression<Func<bool>> bodyconvertNumberAndDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodynumberFormat = null, Expression<Func<bool>> bodyignoreNullValues = null, Expression<Func<bool>> bodyisTitleBold = null, Expression<Func<bool>> bodyisTitleWrapText = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
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

            if (bodyfirstRow != null)
            {
                if (bodyfirstRow != null)
                {
                    body["firstRow"] = ExpressionConverter.ConvertO(bodyfirstRow);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["firstRow"] = 0;
                bodypropCount++;
            }

            if (bodyfirstColumn != null)
            {
                if (bodyfirstColumn != null)
                {
                    body["firstColumn"] = ExpressionConverter.ConvertO(bodyfirstColumn);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["firstColumn"] = 0;
                bodypropCount++;
            }

            if (bodyworksheetName != null)
            {
                if (bodyworksheetName != null)
                {
                    body["worksheetName"] = ExpressionConverter.ConvertO(bodyworksheetName);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["worksheetName"] = "Sheet1";
                bodypropCount++;
            }

            if (bodyconvertNumberAndDate != null)
            {
                if (bodyconvertNumberAndDate != null)
                {
                    body["convertNumberAndDate"] = ExpressionConverter.ConvertO(bodyconvertNumberAndDate);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["convertNumberAndDate"] = false;
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["dateFormat"] = ExpressionConverter.ConvertO(bodydateFormat);
                bodypropCount++;
            }

            if (bodynumberFormat != null)
            {
                body["numberFormat"] = ExpressionConverter.ConvertO(bodynumberFormat);
                bodypropCount++;
            }

            if (bodyignoreNullValues != null)
            {
                if (bodyignoreNullValues != null)
                {
                    body["ignoreNullValues"] = ExpressionConverter.ConvertO(bodyignoreNullValues);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["ignoreNullValues"] = false;
                bodypropCount++;
            }

            if (bodyisTitleBold != null)
            {
                if (bodyisTitleBold != null)
                {
                    body["isTitleBold"] = ExpressionConverter.ConvertO(bodyisTitleBold);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["isTitleBold"] = true;
                bodypropCount++;
            }

            if (bodyisTitleWrapText != null)
            {
                if (bodyisTitleWrapText != null)
                {
                    body["isTitleWrapText"] = ExpressionConverter.ConvertO(bodyisTitleWrapText);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["isTitleWrapText"] = true;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertMdToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodymdFilePath = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertToPdf";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertUrlToPdf(Expression<Func<string>> bodywebUrl, Expression<Func<bodyauthTypeInput>> bodyauthType = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
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
                if (bodyauthType != null)
                {
                    body["authType"] = ExpressionConverter.ConvertO(bodyauthType);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["authType"] = "NoAuth";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertVisio(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertWordToPdfForm(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> CreatePdfA(Expression<Func<bodycomplianceInput>> bodycompliance, Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<bool>> bodyallowUpgrade = null, Expression<Func<bool>> bodyallowDowngrade = null)
        {
            var apiCallPath = "/v2/FlowV2/PdfA";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["compliance"] = ExpressionConverter.ConvertO(bodycompliance);
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

            if (bodyallowUpgrade != null)
            {
                if (bodyallowUpgrade != null)
                {
                    body["allowUpgrade"] = ExpressionConverter.ConvertO(bodyallowUpgrade);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["allowUpgrade"] = true;
                bodypropCount++;
            }

            if (bodyallowDowngrade != null)
            {
                if (bodyallowDowngrade != null)
                {
                    body["allowDowngrade"] = ExpressionConverter.ConvertO(bodyallowDowngrade);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["allowDowngrade"] = true;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IWorkflowAction CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToExcel(Expression<Func<string>> bodydocContent, Expression<Func<bodyqualityTypeInput>> bodyqualityType, Expression<Func<string>> bodydocumentname = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodymergeAllSheets = null, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
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
            body["qualityType"] = ExpressionConverter.ConvertO(bodyqualityType);
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodymergeAllSheets != null)
            {
                if (bodymergeAllSheets != null)
                {
                    body["mergeAllSheets"] = ExpressionConverter.ConvertO(bodymergeAllSheets);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["mergeAllSheets"] = false;
                bodypropCount++;
            }

            if (bodyoutputFormat != null)
            {
                if (bodyoutputFormat != null)
                {
                    body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["outputFormat"] = "";
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

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToPowerPoint(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodyqualityTypeInput>> bodyqualityType = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
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

            if (bodyqualityType != null)
            {
                if (bodyqualityType != null)
                {
                    body["qualityType"] = ExpressionConverter.ConvertO(bodyqualityType);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["qualityType"] = "High";
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToWord(Expression<Func<string>> bodydocContent, Expression<Func<bodyqualityTypeInput>> bodyqualityType, Expression<Func<string>> bodydocumentname = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
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
            body["qualityType"] = ExpressionConverter.ConvertO(bodyqualityType);
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
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

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class Pdf4meconvertTriggers([ConnectionName] string connectionId)
    {
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

    public enum schemaValInput
    {
        PDF,
        BMP,
        GIF,
        PNG,
        JPG,
        SVG,
        TIFF,
        HTML,
        VSDX
    }

    public enum bodycomplianceInput
    {
        PdfA1b,
        PdfA1a,
        PdfA2b,
        PdfA2u,
        PdfA2a,
        PdfA3b,
        PdfA3u,
        PdfA3a
    }

    public enum bodyqualityTypeInput
    {
        Draft,
        High
    }

    public enum bodyoutputFormatInput
    {
        [EnumMember(Value = "")]
        None,
        Excel,
        CSV
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert;

    public partial class WorkflowManagedActions
    {
        public Pdf4meconvertActions Pdf4meconvert(string connectionId) => new Pdf4meconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meconvertTriggers Pdf4meconvert(string connectionId) => new Pdf4meconvertTriggers(connectionId);
    }
}