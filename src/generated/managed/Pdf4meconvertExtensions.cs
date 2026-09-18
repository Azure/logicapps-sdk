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
        public IBodyWorkflowAction<string> ConvertHtmlToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodyindexFilePath = null, [WorkflowExpression] Func<bodylayoutInput> bodylayout = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<double> bodyscale = null, [WorkflowExpression] Func<string> bodytopMargin = null, [WorkflowExpression] Func<string> bodybottomMargin = null, [WorkflowExpression] Func<string> bodyleftMargin = null, [WorkflowExpression] Func<string> bodyrightMargin = null, [WorkflowExpression] Func<bool> bodyprintBackground = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocName, nameof(bodydocName), required: true);
            SourceExpression.Validate(bodyindexFilePath, nameof(bodyindexFilePath), required: false);
            SourceExpression.Validate(bodylayout, nameof(bodylayout), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyscale, nameof(bodyscale), required: false);
            SourceExpression.Validate(bodytopMargin, nameof(bodytopMargin), required: false);
            SourceExpression.Validate(bodybottomMargin, nameof(bodybottomMargin), required: false);
            SourceExpression.Validate(bodyleftMargin, nameof(bodyleftMargin), required: false);
            SourceExpression.Validate(bodyrightMargin, nameof(bodyrightMargin), required: false);
            SourceExpression.Validate(bodyprintBackground, nameof(bodyprintBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                bodypropCount++;
                body["docName"] = SourceExpressionConverter.ConvertToken(bodydocName);
                if (bodyindexFilePath != null)
                {
                    body["indexFilePath"] = SourceExpressionConverter.ConvertToken(bodyindexFilePath);
                    bodypropCount++;
                }

                if (bodylayout != null)
                {
                    if (bodylayout != null)
                    {
                        body["layout"] = SourceExpressionConverter.Convert(bodylayout);
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
                        body["format"] = SourceExpressionConverter.Convert(bodyformat);
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
                        body["scale"] = SourceExpressionConverter.ConvertToken(bodyscale);
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
                        body["topMargin"] = SourceExpressionConverter.ConvertToken(bodytopMargin);
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
                        body["bottomMargin"] = SourceExpressionConverter.ConvertToken(bodybottomMargin);
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
                        body["leftMargin"] = SourceExpressionConverter.ConvertToken(bodyleftMargin);
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
                        body["rightMargin"] = SourceExpressionConverter.ConvertToken(bodyrightMargin);
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
                        body["printBackground"] = SourceExpressionConverter.ConvertToken(bodyprintBackground);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertJsonToExcel([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<int> bodyfirstRow = null, [WorkflowExpression] Func<int> bodyfirstColumn = null, [WorkflowExpression] Func<string> bodyworksheetName = null, [WorkflowExpression] Func<bool> bodyconvertNumberAndDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodynumberFormat = null, [WorkflowExpression] Func<bool> bodyignoreNullValues = null, [WorkflowExpression] Func<bool> bodyisTitleBold = null, [WorkflowExpression] Func<bool> bodyisTitleWrapText = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodyfirstRow, nameof(bodyfirstRow), required: false);
            SourceExpression.Validate(bodyfirstColumn, nameof(bodyfirstColumn), required: false);
            SourceExpression.Validate(bodyworksheetName, nameof(bodyworksheetName), required: false);
            SourceExpression.Validate(bodyconvertNumberAndDate, nameof(bodyconvertNumberAndDate), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodynumberFormat, nameof(bodynumberFormat), required: false);
            SourceExpression.Validate(bodyignoreNullValues, nameof(bodyignoreNullValues), required: false);
            SourceExpression.Validate(bodyisTitleBold, nameof(bodyisTitleBold), required: false);
            SourceExpression.Validate(bodyisTitleWrapText, nameof(bodyisTitleWrapText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
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

                if (bodyfirstRow != null)
                {
                    if (bodyfirstRow != null)
                    {
                        body["firstRow"] = SourceExpressionConverter.ConvertToken(bodyfirstRow);
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
                        body["firstColumn"] = SourceExpressionConverter.ConvertToken(bodyfirstColumn);
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
                        body["worksheetName"] = SourceExpressionConverter.ConvertToken(bodyworksheetName);
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
                        body["convertNumberAndDate"] = SourceExpressionConverter.ConvertToken(bodyconvertNumberAndDate);
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
                    body["dateFormat"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodynumberFormat != null)
                {
                    body["numberFormat"] = SourceExpressionConverter.ConvertToken(bodynumberFormat);
                    bodypropCount++;
                }

                if (bodyignoreNullValues != null)
                {
                    if (bodyignoreNullValues != null)
                    {
                        body["ignoreNullValues"] = SourceExpressionConverter.ConvertToken(bodyignoreNullValues);
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
                        body["isTitleBold"] = SourceExpressionConverter.ConvertToken(bodyisTitleBold);
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
                        body["isTitleWrapText"] = SourceExpressionConverter.ConvertToken(bodyisTitleWrapText);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertMdToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocName, [WorkflowExpression] Func<string> bodymdFilePath = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocName, nameof(bodydocName), required: true);
            SourceExpression.Validate(bodymdFilePath, nameof(bodymdFilePath), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = SourceExpressionConverter.ConvertToken(bodydocContent);
                bodypropCount++;
                body["docName"] = SourceExpressionConverter.ConvertToken(bodydocName);
                if (bodymdFilePath != null)
                {
                    body["mdFilePath"] = SourceExpressionConverter.ConvertToken(bodymdFilePath);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertToPdf([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertToPdf";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertUrlToPdf([WorkflowExpression] Func<string> bodywebUrl, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            SourceExpression.Validate(bodywebUrl, nameof(bodywebUrl), required: true);
            SourceExpression.Validate(bodyauthType, nameof(bodyauthType), required: false);
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["webUrl"] = SourceExpressionConverter.ConvertToken(bodywebUrl);
                if (bodyauthType != null)
                {
                    if (bodyauthType != null)
                    {
                        body["authType"] = SourceExpressionConverter.Convert(bodyauthType);
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
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertVisio([WorkflowExpression] Func<schemaValInput> schemaVal = null, [WorkflowExpression] Func<object> operation = null)
        {
            SourceExpression.Validate(schemaVal, nameof(schemaVal), required: false);
            SourceExpression.Validate(operation, nameof(operation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertVisio";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> ConvertWordToPdfForm([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> CreatePdfA([WorkflowExpression] Func<bodycomplianceInput> bodycompliance, [WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bool> bodyallowUpgrade = null, [WorkflowExpression] Func<bool> bodyallowDowngrade = null)
        {
            SourceExpression.Validate(bodycompliance, nameof(bodycompliance), required: true);
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodyallowUpgrade, nameof(bodyallowUpgrade), required: false);
            SourceExpression.Validate(bodyallowDowngrade, nameof(bodyallowDowngrade), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["compliance"] = SourceExpressionConverter.Convert(bodycompliance);
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

                if (bodyallowUpgrade != null)
                {
                    if (bodyallowUpgrade != null)
                    {
                        body["allowUpgrade"] = SourceExpressionConverter.ConvertToken(bodyallowUpgrade);
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
                        body["allowDowngrade"] = SourceExpressionConverter.ConvertToken(bodyallowDowngrade);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IWorkflowAction CustomAPI([WorkflowExpression] Func<string> featurePath, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(featurePath, nameof(featurePath), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToExcel([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodymergeAllSheets = null, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodyqualityType, nameof(bodyqualityType), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodymergeAllSheets, nameof(bodymergeAllSheets), required: false);
            SourceExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            SourceExpression.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
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
                body["qualityType"] = SourceExpressionConverter.Convert(bodyqualityType);
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodymergeAllSheets != null)
                {
                    if (bodymergeAllSheets != null)
                    {
                        body["mergeAllSheets"] = SourceExpressionConverter.ConvertToken(bodymergeAllSheets);
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
                        body["outputFormat"] = SourceExpressionConverter.Convert(bodyoutputFormat);
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

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToPowerPoint([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodyqualityType, nameof(bodyqualityType), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
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

                if (bodyqualityType != null)
                {
                    if (bodyqualityType != null)
                    {
                        body["qualityType"] = SourceExpressionConverter.Convert(bodyqualityType);
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
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
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

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconvert")]
        public IBodyWorkflowAction<string> PdfToWord([WorkflowExpression] Func<string> bodydocContent, [WorkflowExpression] Func<bodyqualityTypeInput> bodyqualityType, [WorkflowExpression] Func<string> bodydocumentname = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyisAsync = null)
        {
            SourceExpression.Validate(bodydocContent, nameof(bodydocContent), required: true);
            SourceExpression.Validate(bodyqualityType, nameof(bodyqualityType), required: true);
            SourceExpression.Validate(bodydocumentname, nameof(bodydocumentname), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodyisAsync, nameof(bodyisAsync), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
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
                body["qualityType"] = SourceExpressionConverter.Convert(bodyqualityType);
                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
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

            return new ApiConnectionAction<string>(BuildSourceInput);
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