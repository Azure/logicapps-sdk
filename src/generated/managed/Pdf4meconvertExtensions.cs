//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodyindexFilePath = null, Expression<Func<bodylayoutInput>> bodylayout = null, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<double>> bodyscale = null, Expression<Func<string>> bodytopMargin = null, Expression<Func<string>> bodybottomMargin = null, Expression<Func<string>> bodyleftMargin = null, Expression<Func<string>> bodyrightMargin = null, Expression<Func<bool>> bodyprintBackground = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocName = WorkflowExpression.Compile(bodydocName, nameof(bodydocName), required: true);
            var __workflow_bodyindexFilePath = WorkflowExpression.Compile(bodyindexFilePath, nameof(bodyindexFilePath), required: false);
            var __workflow_bodylayout = WorkflowExpression.Compile(bodylayout, nameof(bodylayout), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyscale = WorkflowExpression.Compile(bodyscale, nameof(bodyscale), required: false);
            var __workflow_bodytopMargin = WorkflowExpression.Compile(bodytopMargin, nameof(bodytopMargin), required: false);
            var __workflow_bodybottomMargin = WorkflowExpression.Compile(bodybottomMargin, nameof(bodybottomMargin), required: false);
            var __workflow_bodyleftMargin = WorkflowExpression.Compile(bodyleftMargin, nameof(bodyleftMargin), required: false);
            var __workflow_bodyrightMargin = WorkflowExpression.Compile(bodyrightMargin, nameof(bodyrightMargin), required: false);
            var __workflow_bodyprintBackground = WorkflowExpression.Compile(bodyprintBackground, nameof(bodyprintBackground), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                bodypropCount++;
                body["docName"] = ExpressionConverter.ConvertO(__workflow_bodydocName);
                if (__workflow_bodyindexFilePath != null)
                {
                    body["indexFilePath"] = ExpressionConverter.ConvertO(__workflow_bodyindexFilePath);
                    bodypropCount++;
                }

                if (__workflow_bodylayout != null)
                {
                    if (__workflow_bodylayout != null)
                    {
                        body["layout"] = ExpressionConverter.ConvertO(__workflow_bodylayout);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["layout"] = "Portrait";
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    if (__workflow_bodyformat != null)
                    {
                        body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["format"] = "A4";
                    bodypropCount++;
                }

                if (__workflow_bodyscale != null)
                {
                    if (__workflow_bodyscale != null)
                    {
                        body["scale"] = ExpressionConverter.ConvertO(__workflow_bodyscale);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["scale"] = 0.8;
                    bodypropCount++;
                }

                if (__workflow_bodytopMargin != null)
                {
                    if (__workflow_bodytopMargin != null)
                    {
                        body["topMargin"] = ExpressionConverter.ConvertO(__workflow_bodytopMargin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["topMargin"] = "40px";
                    bodypropCount++;
                }

                if (__workflow_bodybottomMargin != null)
                {
                    if (__workflow_bodybottomMargin != null)
                    {
                        body["bottomMargin"] = ExpressionConverter.ConvertO(__workflow_bodybottomMargin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["bottomMargin"] = "40px";
                    bodypropCount++;
                }

                if (__workflow_bodyleftMargin != null)
                {
                    if (__workflow_bodyleftMargin != null)
                    {
                        body["leftMargin"] = ExpressionConverter.ConvertO(__workflow_bodyleftMargin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["leftMargin"] = "40px";
                    bodypropCount++;
                }

                if (__workflow_bodyrightMargin != null)
                {
                    if (__workflow_bodyrightMargin != null)
                    {
                        body["rightMargin"] = ExpressionConverter.ConvertO(__workflow_bodyrightMargin);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["rightMargin"] = "40px";
                    bodypropCount++;
                }

                if (__workflow_bodyprintBackground != null)
                {
                    if (__workflow_bodyprintBackground != null)
                    {
                        body["printBackground"] = ExpressionConverter.ConvertO(__workflow_bodyprintBackground);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<int>> bodyfirstRow = null, Expression<Func<int>> bodyfirstColumn = null, Expression<Func<string>> bodyworksheetName = null, Expression<Func<bool>> bodyconvertNumberAndDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodynumberFormat = null, Expression<Func<bool>> bodyignoreNullValues = null, Expression<Func<bool>> bodyisTitleBold = null, Expression<Func<bool>> bodyisTitleWrapText = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodyfirstRow = WorkflowExpression.Compile(bodyfirstRow, nameof(bodyfirstRow), required: false);
            var __workflow_bodyfirstColumn = WorkflowExpression.Compile(bodyfirstColumn, nameof(bodyfirstColumn), required: false);
            var __workflow_bodyworksheetName = WorkflowExpression.Compile(bodyworksheetName, nameof(bodyworksheetName), required: false);
            var __workflow_bodyconvertNumberAndDate = WorkflowExpression.Compile(bodyconvertNumberAndDate, nameof(bodyconvertNumberAndDate), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodynumberFormat = WorkflowExpression.Compile(bodynumberFormat, nameof(bodynumberFormat), required: false);
            var __workflow_bodyignoreNullValues = WorkflowExpression.Compile(bodyignoreNullValues, nameof(bodyignoreNullValues), required: false);
            var __workflow_bodyisTitleBold = WorkflowExpression.Compile(bodyisTitleBold, nameof(bodyisTitleBold), required: false);
            var __workflow_bodyisTitleWrapText = WorkflowExpression.Compile(bodyisTitleWrapText, nameof(bodyisTitleWrapText), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
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

                if (__workflow_bodyfirstRow != null)
                {
                    if (__workflow_bodyfirstRow != null)
                    {
                        body["firstRow"] = ExpressionConverter.ConvertO(__workflow_bodyfirstRow);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["firstRow"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodyfirstColumn != null)
                {
                    if (__workflow_bodyfirstColumn != null)
                    {
                        body["firstColumn"] = ExpressionConverter.ConvertO(__workflow_bodyfirstColumn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["firstColumn"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodyworksheetName != null)
                {
                    if (__workflow_bodyworksheetName != null)
                    {
                        body["worksheetName"] = ExpressionConverter.ConvertO(__workflow_bodyworksheetName);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["worksheetName"] = "Sheet1";
                    bodypropCount++;
                }

                if (__workflow_bodyconvertNumberAndDate != null)
                {
                    if (__workflow_bodyconvertNumberAndDate != null)
                    {
                        body["convertNumberAndDate"] = ExpressionConverter.ConvertO(__workflow_bodyconvertNumberAndDate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["convertNumberAndDate"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["dateFormat"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodynumberFormat != null)
                {
                    body["numberFormat"] = ExpressionConverter.ConvertO(__workflow_bodynumberFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyignoreNullValues != null)
                {
                    if (__workflow_bodyignoreNullValues != null)
                    {
                        body["ignoreNullValues"] = ExpressionConverter.ConvertO(__workflow_bodyignoreNullValues);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ignoreNullValues"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyisTitleBold != null)
                {
                    if (__workflow_bodyisTitleBold != null)
                    {
                        body["isTitleBold"] = ExpressionConverter.ConvertO(__workflow_bodyisTitleBold);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isTitleBold"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyisTitleWrapText != null)
                {
                    if (__workflow_bodyisTitleWrapText != null)
                    {
                        body["isTitleWrapText"] = ExpressionConverter.ConvertO(__workflow_bodyisTitleWrapText);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertMdToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodymdFilePath = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocName = WorkflowExpression.Compile(bodydocName, nameof(bodydocName), required: true);
            var __workflow_bodymdFilePath = WorkflowExpression.Compile(bodymdFilePath, nameof(bodymdFilePath), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                bodypropCount++;
                body["docName"] = ExpressionConverter.ConvertO(__workflow_bodydocName);
                if (__workflow_bodymdFilePath != null)
                {
                    body["mdFilePath"] = ExpressionConverter.ConvertO(__workflow_bodymdFilePath);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertToPdf(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertToPdf";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertUrlToPdf(Expression<Func<string>> bodywebUrl, Expression<Func<bodyauthTypeInput>> bodyauthType = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodywebUrl = WorkflowExpression.Compile(bodywebUrl, nameof(bodywebUrl), required: true);
            var __workflow_bodyauthType = WorkflowExpression.Compile(bodyauthType, nameof(bodyauthType), required: false);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["webUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebUrl);
                if (__workflow_bodyauthType != null)
                {
                    if (__workflow_bodyauthType != null)
                    {
                        body["authType"] = ExpressionConverter.ConvertO(__workflow_bodyauthType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authType"] = "NoAuth";
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertVisio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWordToPdfForm(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdfA(Expression<Func<bodycomplianceInput>> bodycompliance, Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<bool>> bodyallowUpgrade = null, Expression<Func<bool>> bodyallowDowngrade = null)
        {
            var __workflow_bodycompliance = WorkflowExpression.Compile(bodycompliance, nameof(bodycompliance), required: true);
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodyallowUpgrade = WorkflowExpression.Compile(bodyallowUpgrade, nameof(bodyallowUpgrade), required: false);
            var __workflow_bodyallowDowngrade = WorkflowExpression.Compile(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["compliance"] = ExpressionConverter.ConvertO(__workflow_bodycompliance);
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

                if (__workflow_bodyallowUpgrade != null)
                {
                    if (__workflow_bodyallowUpgrade != null)
                    {
                        body["allowUpgrade"] = ExpressionConverter.ConvertO(__workflow_bodyallowUpgrade);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allowUpgrade"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyallowDowngrade != null)
                {
                    if (__workflow_bodyallowDowngrade != null)
                    {
                        body["allowDowngrade"] = ExpressionConverter.ConvertO(__workflow_bodyallowDowngrade);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToExcel(Expression<Func<string>> bodydocContent, Expression<Func<bodyqualityTypeInput>> bodyqualityType, Expression<Func<string>> bodydocumentname = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodymergeAllSheets = null, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyqualityType = WorkflowExpression.Compile(bodyqualityType, nameof(bodyqualityType), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodymergeAllSheets = WorkflowExpression.Compile(bodymergeAllSheets, nameof(bodymergeAllSheets), required: false);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            var __workflow_bodyisAsync = WorkflowExpression.Compile(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
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

                bodypropCount++;
                body["qualityType"] = ExpressionConverter.ConvertO(__workflow_bodyqualityType);
                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodymergeAllSheets != null)
                {
                    if (__workflow_bodymergeAllSheets != null)
                    {
                        body["mergeAllSheets"] = ExpressionConverter.ConvertO(__workflow_bodymergeAllSheets);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["mergeAllSheets"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyoutputFormat != null)
                {
                    if (__workflow_bodyoutputFormat != null)
                    {
                        body["outputFormat"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["outputFormat"] = "";
                    bodypropCount++;
                }

                if (__workflow_bodyisAsync != null)
                {
                    if (__workflow_bodyisAsync != null)
                    {
                        body["isAsync"] = ExpressionConverter.ConvertO(__workflow_bodyisAsync);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToPowerPoint(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodyqualityTypeInput>> bodyqualityType = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodyqualityType = WorkflowExpression.Compile(bodyqualityType, nameof(bodyqualityType), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyisAsync = WorkflowExpression.Compile(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
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

                if (__workflow_bodyqualityType != null)
                {
                    if (__workflow_bodyqualityType != null)
                    {
                        body["qualityType"] = ExpressionConverter.ConvertO(__workflow_bodyqualityType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["qualityType"] = "High";
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyisAsync != null)
                {
                    if (__workflow_bodyisAsync != null)
                    {
                        body["isAsync"] = ExpressionConverter.ConvertO(__workflow_bodyisAsync);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToWord(Expression<Func<string>> bodydocContent, Expression<Func<bodyqualityTypeInput>> bodyqualityType, Expression<Func<string>> bodydocumentname = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var __workflow_bodydocContent = WorkflowExpression.Compile(bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyqualityType = WorkflowExpression.Compile(bodyqualityType, nameof(bodyqualityType), required: true);
            var __workflow_bodydocumentname = WorkflowExpression.Compile(bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyisAsync = WorkflowExpression.Compile(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
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

                bodypropCount++;
                body["qualityType"] = ExpressionConverter.ConvertO(__workflow_bodyqualityType);
                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyisAsync != null)
                {
                    if (__workflow_bodyisAsync != null)
                    {
                        body["isAsync"] = ExpressionConverter.ConvertO(__workflow_bodyisAsync);
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
            });
        }
    }

    public class Pdf4meconvertTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylayoutInput
    {
        [EnumMember(Value = "")]
        None,
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthTypeInput
    {
        NoAuth,
        SharePointLogin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyqualityTypeInput
    {
        Draft,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
