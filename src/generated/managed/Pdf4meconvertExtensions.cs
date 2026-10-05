//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconvert
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertHtmlToPdf))]
        public IBodyWorkflowAction<string> ConvertHtmlToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodyindexFilePath = null, [WorkflowExpression] Func<bodylayoutInput> bodylayout = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<double> bodyscale = null, [WorkflowExpression] Func<string> bodytopMargin = null, [WorkflowExpression] Func<string> bodybottomMargin = null, [WorkflowExpression] Func<string> bodyleftMargin = null, [WorkflowExpression] Func<string> bodyrightMargin = null, [WorkflowExpression] Func<bool> bodyprintBackground = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertHtmlToPdf(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocName, WorkflowValue<string> bodyindexFilePath = null, WorkflowValue<bodylayoutInput> bodylayout = null, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<double> bodyscale = null, WorkflowValue<string> bodytopMargin = null, WorkflowValue<string> bodybottomMargin = null, WorkflowValue<string> bodyleftMargin = null, WorkflowValue<string> bodyrightMargin = null, WorkflowValue<bool> bodyprintBackground = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocName, nameof(bodydocName), required: true);
            WorkflowValue.Validate(bodyindexFilePath, nameof(bodyindexFilePath), required: false);
            WorkflowValue.Validate(bodylayout, nameof(bodylayout), required: false);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodyscale, nameof(bodyscale), required: false);
            WorkflowValue.Validate(bodytopMargin, nameof(bodytopMargin), required: false);
            WorkflowValue.Validate(bodybottomMargin, nameof(bodybottomMargin), required: false);
            WorkflowValue.Validate(bodyleftMargin, nameof(bodyleftMargin), required: false);
            WorkflowValue.Validate(bodyrightMargin, nameof(bodyrightMargin), required: false);
            WorkflowValue.Validate(bodyprintBackground, nameof(bodyprintBackground), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertJsonToExcel))]
        public IBodyWorkflowAction<string> ConvertJsonToExcel([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<int> bodyfirstRow = null, [WorkflowExpression] Func<int> bodyfirstColumn = null, [WorkflowExpression] Func<string> bodyworksheetName = null, [WorkflowExpression] Func<bool> bodyconvertNumberAndDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodynumberFormat = null, [WorkflowExpression] Func<bool> bodyignoreNullValues = null, [WorkflowExpression] Func<bool> bodyisTitleBold = null, [WorkflowExpression] Func<bool> bodyisTitleWrapText = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertJsonToExcel(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocumentname = null, WorkflowValue<int> bodyfirstRow = null, WorkflowValue<int> bodyfirstColumn = null, WorkflowValue<string> bodyworksheetName = null, WorkflowValue<bool> bodyconvertNumberAndDate = null, WorkflowValue<string> bodydateFormat = null, WorkflowValue<string> bodynumberFormat = null, WorkflowValue<bool> bodyignoreNullValues = null, WorkflowValue<bool> bodyisTitleBold = null, WorkflowValue<bool> bodyisTitleWrapText = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodyfirstRow, nameof(bodyfirstRow), required: false);
            WorkflowValue.Validate(bodyfirstColumn, nameof(bodyfirstColumn), required: false);
            WorkflowValue.Validate(bodyworksheetName, nameof(bodyworksheetName), required: false);
            WorkflowValue.Validate(bodyconvertNumberAndDate, nameof(bodyconvertNumberAndDate), required: false);
            WorkflowValue.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowValue.Validate(bodynumberFormat, nameof(bodynumberFormat), required: false);
            WorkflowValue.Validate(bodyignoreNullValues, nameof(bodyignoreNullValues), required: false);
            WorkflowValue.Validate(bodyisTitleBold, nameof(bodyisTitleBold), required: false);
            WorkflowValue.Validate(bodyisTitleWrapText, nameof(bodyisTitleWrapText), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertMdToPdf))]
        public IBodyWorkflowAction<string> ConvertMdToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodymdFilePath = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertMdToPdf(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocName, WorkflowValue<string> bodymdFilePath = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocName, nameof(bodydocName), required: true);
            WorkflowValue.Validate(bodymdFilePath, nameof(bodymdFilePath), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertToPdf))]
        public IBodyWorkflowAction<string> ConvertToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertToPdf(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertUrlToPdf))]
        public IBodyWorkflowAction<string> ConvertUrlToPdf([WorkflowExpression] Func<string> bodywebUrl, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertUrlToPdf(WorkflowValue<string> bodywebUrl, WorkflowValue<bodyauthTypeInput> bodyauthType = null, WorkflowValue<string> bodyusername = null, WorkflowValue<string> bodypassword = null)
        {
            WorkflowValue.Validate(bodywebUrl, nameof(bodywebUrl), required: true);
            WorkflowValue.Validate(bodyauthType, nameof(bodyauthType), required: false);
            WorkflowValue.Validate(bodyusername, nameof(bodyusername), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertVisio))]
        public IBodyWorkflowAction<string> ConvertVisio([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertVisio(WorkflowValue<schemaValInput> schemaVal = null, WorkflowValue<object> operation = null)
        {
            WorkflowValue.Validate(schemaVal, nameof(schemaVal), required: false);
            WorkflowValue.Validate(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertVisio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
                if (schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(schemaVal);
                callPayload.Body = ExpressionConverter.ConvertO(operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildConvertWordToPdfForm))]
        public IBodyWorkflowAction<string> ConvertWordToPdfForm([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildConvertWordToPdfForm(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocumentname = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePdfA))]
        public IBodyWorkflowAction<string> CreatePdfA([WorkflowExpression] Func<bodycomplianceInput> bodycompliance, [WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodyallowUpgrade = null, [WorkflowExpression] Func<bool> bodyallowDowngrade = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreatePdfA(WorkflowValue<bodycomplianceInput> bodycompliance, WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocumentname = null, WorkflowValue<bool> bodyallowUpgrade = null, WorkflowValue<bool> bodyallowDowngrade = null)
        {
            WorkflowValue.Validate(bodycompliance, nameof(bodycompliance), required: true);
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodyallowUpgrade, nameof(bodyallowUpgrade), required: false);
            WorkflowValue.Validate(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildCustomAPI))]
        public IWorkflowAction CustomAPI([WorkflowExpression] Func<string> featurePath, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCustomAPI(WorkflowValue<string> featurePath, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(featurePath, nameof(featurePath), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildPdfToExcel))]
        public IBodyWorkflowAction<string> PdfToExcel([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodymergeAllSheets = null, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPdfToExcel(WorkflowValue<string> bodydocContent, WorkflowValue<bodyqualityTypeInput> bodyqualityType, WorkflowValue<string> bodydocumentname = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<bool> bodymergeAllSheets = null, WorkflowValue<bodyoutputFormatInput> bodyoutputFormat = null, WorkflowValue<bool> bodyisAsync = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyqualityType, nameof(bodyqualityType), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodymergeAllSheets, nameof(bodymergeAllSheets), required: false);
            WorkflowValue.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            WorkflowValue.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildPdfToPowerPoint))]
        public IBodyWorkflowAction<string> PdfToPowerPoint([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPdfToPowerPoint(WorkflowValue<string> bodydocContent, WorkflowValue<string> bodydocumentname = null, WorkflowValue<bodyqualityTypeInput> bodyqualityType = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<bool> bodyisAsync = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodyqualityType, nameof(bodyqualityType), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        [WorkflowExpressionFactory(nameof(__BuildPdfToWord))]
        public IBodyWorkflowAction<string> PdfToWord([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPdfToWord(WorkflowValue<string> bodydocContent, WorkflowValue<bodyqualityTypeInput> bodyqualityType, WorkflowValue<string> bodydocumentname = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<bool> bodyisAsync = null)
        {
            WorkflowValue.Validate(bodydocContent, nameof(bodydocContent), required: true);
            WorkflowValue.Validate(bodyqualityType, nameof(bodyqualityType), required: true);
            WorkflowValue.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
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
