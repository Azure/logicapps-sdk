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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            bodypropCount++;
            body["docName"] = CSharpExpressionConverter.ConvertToken(bodydocName);
            if (bodyindexFilePath != null)
            {
                body["indexFilePath"] = CSharpExpressionConverter.ConvertToken(bodyindexFilePath);
                bodypropCount++;
            }

            if (bodylayout != null)
            {
                if (bodylayout != null)
                {
                    body["layout"] = CSharpExpressionConverter.Convert(bodylayout);
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
                    body["format"] = CSharpExpressionConverter.Convert(bodyformat);
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
                    body["scale"] = CSharpExpressionConverter.ConvertToken(bodyscale);
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
                    body["topMargin"] = CSharpExpressionConverter.ConvertToken(bodytopMargin);
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
                    body["bottomMargin"] = CSharpExpressionConverter.ConvertToken(bodybottomMargin);
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
                    body["leftMargin"] = CSharpExpressionConverter.ConvertToken(bodyleftMargin);
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
                    body["rightMargin"] = CSharpExpressionConverter.ConvertToken(bodyrightMargin);
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
                    body["printBackground"] = CSharpExpressionConverter.ConvertToken(bodyprintBackground);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
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
                    body["firstRow"] = CSharpExpressionConverter.ConvertToken(bodyfirstRow);
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
                    body["firstColumn"] = CSharpExpressionConverter.ConvertToken(bodyfirstColumn);
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
                    body["worksheetName"] = CSharpExpressionConverter.ConvertToken(bodyworksheetName);
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
                    body["convertNumberAndDate"] = CSharpExpressionConverter.ConvertToken(bodyconvertNumberAndDate);
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
                body["dateFormat"] = CSharpExpressionConverter.ConvertToken(bodydateFormat);
                bodypropCount++;
            }

            if (bodynumberFormat != null)
            {
                body["numberFormat"] = CSharpExpressionConverter.ConvertToken(bodynumberFormat);
                bodypropCount++;
            }

            if (bodyignoreNullValues != null)
            {
                if (bodyignoreNullValues != null)
                {
                    body["ignoreNullValues"] = CSharpExpressionConverter.ConvertToken(bodyignoreNullValues);
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
                    body["isTitleBold"] = CSharpExpressionConverter.ConvertToken(bodyisTitleBold);
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
                    body["isTitleWrapText"] = CSharpExpressionConverter.ConvertToken(bodyisTitleWrapText);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            bodypropCount++;
            body["docName"] = CSharpExpressionConverter.ConvertToken(bodydocName);
            if (bodymdFilePath != null)
            {
                body["mdFilePath"] = CSharpExpressionConverter.ConvertToken(bodymdFilePath);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
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
            body["webUrl"] = CSharpExpressionConverter.ConvertToken(bodywebUrl);
            if (bodyauthType != null)
            {
                if (bodyauthType != null)
                {
                    body["authType"] = CSharpExpressionConverter.Convert(bodyauthType);
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
                body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
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
                callPayload.Queries["schemaVal"] = CSharpExpressionConverter.Convert(schemaVal);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(operation);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
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
            body["compliance"] = CSharpExpressionConverter.Convert(bodycompliance);
            bodypropCount++;
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
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
                    body["allowUpgrade"] = CSharpExpressionConverter.ConvertToken(bodyallowUpgrade);
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
                    body["allowDowngrade"] = CSharpExpressionConverter.ConvertToken(bodyallowDowngrade);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(featurePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                body["document"] = documentObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["qualityType"] = CSharpExpressionConverter.Convert(bodyqualityType);
            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodymergeAllSheets != null)
            {
                if (bodymergeAllSheets != null)
                {
                    body["mergeAllSheets"] = CSharpExpressionConverter.ConvertToken(bodymergeAllSheets);
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
                    body["outputFormat"] = CSharpExpressionConverter.Convert(bodyoutputFormat);
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
                    body["isAsync"] = CSharpExpressionConverter.ConvertToken(bodyisAsync);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
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
                    body["qualityType"] = CSharpExpressionConverter.Convert(bodyqualityType);
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
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodyisAsync != null)
            {
                if (bodyisAsync != null)
                {
                    body["isAsync"] = CSharpExpressionConverter.ConvertToken(bodyisAsync);
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
            body["docContent"] = CSharpExpressionConverter.ConvertToken(bodydocContent);
            var documentObject = new JObject();
            var documentObjectpropCount = 0;
            if (bodydocumentname != null)
            {
                documentObject["Name"] = CSharpExpressionConverter.ConvertToken(bodydocumentname);
                documentObjectpropCount++;
            }

            if (documentObjectpropCount > 0)
            {
                body["document"] = documentObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["qualityType"] = CSharpExpressionConverter.Convert(bodyqualityType);
            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodyisAsync != null)
            {
                if (bodyisAsync != null)
                {
                    body["isAsync"] = CSharpExpressionConverter.ConvertToken(bodyisAsync);
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