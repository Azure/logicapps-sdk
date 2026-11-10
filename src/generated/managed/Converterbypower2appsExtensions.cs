//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Converterbypower2appsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5102AddHtmlToWord, ApiConnectionActionConfiguration> AddHtmlToWord(Expression<Func<AddHtmlToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5102AddHtmlToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5102_AddHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5102AddHtmlToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5032AddImageToWord, ApiConnectionActionConfiguration> AddImageToWord(Expression<Func<AddImageToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5032AddImageToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5032_AddImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5032AddImageToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5043AddImageWithinTableToWord, ApiConnectionActionConfiguration> AddImageWithinTableToWord(Expression<Func<AddImageWithinTableToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5043AddImageWithinTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5043_AddImageWithinTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5043AddImageWithinTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5053AddTableToWord, ApiConnectionActionConfiguration> AddTableToWord(Expression<Func<AddTableToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5053AddTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5053_AddTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5053AddTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5062AddTextToWord, ApiConnectionActionConfiguration> AddTextToWord(Expression<Func<AddTextToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5062AddTextToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5062_AddTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5062AddTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2081CombineCsvs, ApiConnectionActionConfiguration> CombineCsvs(Expression<Func<DtoRequestV2081CombineCsvsInput>> dtoRequestV2081CombineCsvs)
        {
            var __workflow_dtoRequestV2081CombineCsvs = WorkflowExpression.Compile(dtoRequestV2081CombineCsvs, nameof(dtoRequestV2081CombineCsvs), required: true);
            return new DeferredBodyAction<DtoResponseV2081CombineCsvs, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2081_CombineCsvs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2081CombineCsvs);
                return new ApiConnectionAction<DtoResponseV2081CombineCsvs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2091CombineJsonArrays, ApiConnectionActionConfiguration> CombineJsonArrays(Expression<Func<DtoRequestV2091CombineJsonArraysInput>> dtoRequestV2091CombineJsonArrays)
        {
            var __workflow_dtoRequestV2091CombineJsonArrays = WorkflowExpression.Compile(dtoRequestV2091CombineJsonArrays, nameof(dtoRequestV2091CombineJsonArrays), required: true);
            return new DeferredBodyAction<DtoResponseV2091CombineJsonArrays, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2091_CombineJsonArrays";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2091CombineJsonArrays);
                return new ApiConnectionAction<DtoResponseV2091CombineJsonArrays>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3042CompressImage, ApiConnectionActionConfiguration> CompressImage(Expression<Func<CompressImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3042CompressImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3042_CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3042CompressImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4081CompressPdf, ApiConnectionActionConfiguration> CompressPdf(Expression<Func<CompressPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4081CompressPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4081_CompressPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4081CompressPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2071ConvertColor, ApiConnectionActionConfiguration> ConvertColor(Expression<Func<DtoRequestV2071ConvertColorInput>> dtoRequestV2071ConvertColor)
        {
            var __workflow_dtoRequestV2071ConvertColor = WorkflowExpression.Compile(dtoRequestV2071ConvertColor, nameof(dtoRequestV2071ConvertColor), required: true);
            return new DeferredBodyAction<DtoResponseV2071ConvertColor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2071_ConvertColor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2071ConvertColor);
                return new ApiConnectionAction<DtoResponseV2071ConvertColor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1035ConvertCsvToExcel, ApiConnectionActionConfiguration> ConvertCsvToExcel(Expression<Func<ConvertCsvToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1035ConvertCsvToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1035_ConvertCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1035ConvertCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml, ApiConnectionActionConfiguration> ConvertCsvToHtmlTable(Expression<Func<DtoRequestV7061ConvertCsvToHtmlTableInput>> dtoRequestV7061ConvertCsvToHtmlTable)
        {
            var __workflow_dtoRequestV7061ConvertCsvToHtmlTable = WorkflowExpression.Compile(dtoRequestV7061ConvertCsvToHtmlTable, nameof(dtoRequestV7061ConvertCsvToHtmlTable), required: true);
            return new DeferredBodyAction<DtoResponseHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7061_ConvertCsvToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV7061ConvertCsvToHtmlTable);
                return new ApiConnectionAction<DtoResponseHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1022ConvertCsvToJson, ApiConnectionActionConfiguration> ConvertCsvToJson(Expression<Func<DtoRequestV1022ConvertCsvToJsonInput>> dtoRequestV1022ConvertCsvToJson)
        {
            var __workflow_dtoRequestV1022ConvertCsvToJson = WorkflowExpression.Compile(dtoRequestV1022ConvertCsvToJson, nameof(dtoRequestV1022ConvertCsvToJson), required: true);
            return new DeferredBodyAction<DtoResponseV1022ConvertCsvToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1022_ConvertCsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1022ConvertCsvToJson);
                return new ApiConnectionAction<DtoResponseV1022ConvertCsvToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1150ConvertCsvToMarkdown, ApiConnectionActionConfiguration> ConvertCsvToMarkdown(Expression<Func<ConvertCsvToMarkdownDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1150ConvertCsvToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1150_ConvertCsvToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1150ConvertCsvToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1100ConvertExcelToJson, ApiConnectionActionConfiguration> ConvertExcelToJson(Expression<Func<DtoRequestV1100ConvertExcelToJsonInput>> dtoRequestV1100ConvertExcelToJson)
        {
            var __workflow_dtoRequestV1100ConvertExcelToJson = WorkflowExpression.Compile(dtoRequestV1100ConvertExcelToJson, nameof(dtoRequestV1100ConvertExcelToJson), required: true);
            return new DeferredBodyAction<DtoResponseV1100ConvertExcelToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1100_ConvertExcelToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1100ConvertExcelToJson);
                return new ApiConnectionAction<DtoResponseV1100ConvertExcelToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1140ConvertExcelToMarkdown, ApiConnectionActionConfiguration> ConvertExcelToMarkdown(Expression<Func<ConvertExcelToMarkdownDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1140ConvertExcelToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1140_ConvertExcelToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1140ConvertExcelToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4014ConvertFileToPdf, ApiConnectionActionConfiguration> ConvertFileToPdf(Expression<Func<ConvertFileToPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4014ConvertFileToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4014_ConvertFileToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4014ConvertFileToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7070ConvertHtmlTableToCsv, ApiConnectionActionConfiguration> ConvertHtmlTableToCsv(Expression<Func<DtoRequestV7070ConvertHtmlTableToCsvInput>> dtoRequestV7070ConvertHtmlTableToCsv)
        {
            var __workflow_dtoRequestV7070ConvertHtmlTableToCsv = WorkflowExpression.Compile(dtoRequestV7070ConvertHtmlTableToCsv, nameof(dtoRequestV7070ConvertHtmlTableToCsv), required: true);
            return new DeferredBodyAction<DtoResponseV7070ConvertHtmlTableToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7070_ConvertHtmlTableToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV7070ConvertHtmlTableToCsv);
                return new ApiConnectionAction<DtoResponseV7070ConvertHtmlTableToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7082ConvertHtmlTableToExcel, ApiConnectionActionConfiguration> ConvertHtmlTableToExcel(Expression<Func<ConvertHtmlTableToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV7082ConvertHtmlTableToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7082_ConvertHtmlTableToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV7082ConvertHtmlTableToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7013ConvertHtmlTableToJson, ApiConnectionActionConfiguration> ConvertHtmlTableToJson(Expression<Func<ConvertHtmlTableToJsonDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV7013ConvertHtmlTableToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7013_ConvertHtmlTableToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV7013ConvertHtmlTableToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7032ConvertHtmlToImage, ApiConnectionActionConfiguration> ConvertHtmlToImage(Expression<Func<ConvertHtmlToImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV7032ConvertHtmlToImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7032_ConvertHtmlToImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV7032ConvertHtmlToImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7090ConvertHtmlToMarkdown, ApiConnectionActionConfiguration> ConvertHtmlToMarkdown(Expression<Func<ConvertHtmlToMarkdownDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV7090ConvertHtmlToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7090_ConvertHtmlToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV7090ConvertHtmlToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV7023ConvertHtmlToPdf, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<ConvertHtmlToPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV7023ConvertHtmlToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7023_ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV7023ConvertHtmlToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> ConvertHtmlToWord(Expression<Func<DtoRequestV7041ConvertHtmlToWordInput>> dtoRequestV7041ConvertHtmlToWord)
        {
            var __workflow_dtoRequestV7041ConvertHtmlToWord = WorkflowExpression.Compile(dtoRequestV7041ConvertHtmlToWord, nameof(dtoRequestV7041ConvertHtmlToWord), required: true);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7041_ConvertHtmlToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV7041ConvertHtmlToWord);
                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> ConvertImage(Expression<Func<DtoRequestV3012ConvertImageInput>> dtoRequestV3012ConvertImage)
        {
            var __workflow_dtoRequestV3012ConvertImage = WorkflowExpression.Compile(dtoRequestV3012ConvertImage, nameof(dtoRequestV3012ConvertImage), required: true);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3012_ConvertImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV3012ConvertImage);
                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1013ConvertJsonToCsv, ApiConnectionActionConfiguration> ConvertJsonToCsv(Expression<Func<DtoRequestV1013ConvertJsonToCsvInput>> dtoRequestV1013ConvertJsonToCsv)
        {
            var __workflow_dtoRequestV1013ConvertJsonToCsv = WorkflowExpression.Compile(dtoRequestV1013ConvertJsonToCsv, nameof(dtoRequestV1013ConvertJsonToCsv), required: true);
            return new DeferredBodyAction<DtoResponseV1013ConvertJsonToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1013_ConvertJsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1013ConvertJsonToCsv);
                return new ApiConnectionAction<DtoResponseV1013ConvertJsonToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1064ConvertJsonToExcel, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<ConvertJsonToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1064ConvertJsonToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1064_ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1064ConvertJsonToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseHtml, ApiConnectionActionConfiguration> ConvertJsonToHtmlTable(Expression<Func<DtoRequestV7051ConvertJsonToHtmlTableInput>> dtoRequestV7051ConvertJsonToHtmlTable)
        {
            var __workflow_dtoRequestV7051ConvertJsonToHtmlTable = WorkflowExpression.Compile(dtoRequestV7051ConvertJsonToHtmlTable, nameof(dtoRequestV7051ConvertJsonToHtmlTable), required: true);
            return new DeferredBodyAction<DtoResponseHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V7051_ConvertJsonToHtmlTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV7051ConvertJsonToHtmlTable);
                return new ApiConnectionAction<DtoResponseHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1090ConvertJsonToTextTable, ApiConnectionActionConfiguration> ConvertJsonToTextTable(Expression<Func<DtoRequestV1090ConvertJsonToTextTableInput>> dtoRequestV1090ConvertJsonToTextTable)
        {
            var __workflow_dtoRequestV1090ConvertJsonToTextTable = WorkflowExpression.Compile(dtoRequestV1090ConvertJsonToTextTable, nameof(dtoRequestV1090ConvertJsonToTextTable), required: true);
            return new DeferredBodyAction<DtoResponseV1090ConvertJsonToTextTable, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1090_ConvertJsonToTextTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1090ConvertJsonToTextTable);
                return new ApiConnectionAction<DtoResponseV1090ConvertJsonToTextTable>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1042ConvertJsonToXml, ApiConnectionActionConfiguration> ConvertJsonToXml(Expression<Func<DtoRequestV1042ConvertJsonToXmlInput>> dtoRequestV1042ConvertJsonToXml)
        {
            var __workflow_dtoRequestV1042ConvertJsonToXml = WorkflowExpression.Compile(dtoRequestV1042ConvertJsonToXml, nameof(dtoRequestV1042ConvertJsonToXml), required: true);
            return new DeferredBodyAction<DtoResponseV1042ConvertJsonToXml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1042_ConvertJsonToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1042ConvertJsonToXml);
                return new ApiConnectionAction<DtoResponseV1042ConvertJsonToXml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1081ConvertJsonToYaml, ApiConnectionActionConfiguration> ConvertJsonToYaml(Expression<Func<DtoRequestV1081ConvertJsonToYamlInput>> dtoRequestV1081ConvertJsonToYaml)
        {
            var __workflow_dtoRequestV1081ConvertJsonToYaml = WorkflowExpression.Compile(dtoRequestV1081ConvertJsonToYaml, nameof(dtoRequestV1081ConvertJsonToYaml), required: true);
            return new DeferredBodyAction<DtoResponseV1081ConvertJsonToYaml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1081_ConvertJsonToYaml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1081ConvertJsonToYaml);
                return new ApiConnectionAction<DtoResponseV1081ConvertJsonToYaml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1110ConvertMultiCsvToExcel, ApiConnectionActionConfiguration> ConvertMultiCsvToExcel(Expression<Func<ConvertMultiCsvToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1110ConvertMultiCsvToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1110_ConvertMultiCsvToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1110ConvertMultiCsvToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4130ConvertPdfToMarkdown, ApiConnectionActionConfiguration> ConvertPdfToMarkdown(Expression<Func<ConvertPdfToMarkdownDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4130ConvertPdfToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4130_ConvertPdfToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4130ConvertPdfToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4071ConvertPdfToPdfA, ApiConnectionActionConfiguration> ConvertPdfToPdfA(Expression<Func<ConvertPdfToPdfADtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4071ConvertPdfToPdfA, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4071_ConvertPdfToPdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4071ConvertPdfToPdfA>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV6011ConvertSharePointSearchResults, ApiConnectionActionConfiguration> ConvertSharePointSearchResults(Expression<Func<DtoRequestV6011ConvertSharePointSearchResultsInput>> dtoRequestV6011ConvertSharePointSearchResults)
        {
            var __workflow_dtoRequestV6011ConvertSharePointSearchResults = WorkflowExpression.Compile(dtoRequestV6011ConvertSharePointSearchResults, nameof(dtoRequestV6011ConvertSharePointSearchResults), required: true);
            return new DeferredBodyAction<DtoResponseV6011ConvertSharePointSearchResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V6011_ConvertSharePointSearchResults";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV6011ConvertSharePointSearchResults);
                return new ApiConnectionAction<DtoResponseV6011ConvertSharePointSearchResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5160ConvertWordToHtml, ApiConnectionActionConfiguration> ConvertWordToHtml(Expression<Func<ConvertWordToHtmlDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5160ConvertWordToHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5160_ConvertWordToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5160ConvertWordToHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5170ConvertWordToMarkdown, ApiConnectionActionConfiguration> ConvertWordToMarkdown(Expression<Func<ConvertWordToMarkdownDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5170ConvertWordToMarkdown, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5170_ConvertWordToMarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5170ConvertWordToMarkdown>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1130ConvertXmlToCsv, ApiConnectionActionConfiguration> ConvertXmlToCsv(Expression<Func<ConvertXmlToCsvDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1130ConvertXmlToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1130_ConvertXmlToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1130ConvertXmlToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1120ConvertXmlToExcel, ApiConnectionActionConfiguration> ConvertXmlToExcel(Expression<Func<ConvertXmlToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1120ConvertXmlToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1120_ConvertXmlToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1120ConvertXmlToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1053ConvertXmlToJson, ApiConnectionActionConfiguration> ConvertXmlToJson(Expression<Func<ConvertXmlToJsonDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV1053ConvertXmlToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1053_ConvertXmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV1053ConvertXmlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV8011ConvertXRechnungToPdf, ApiConnectionActionConfiguration> ConvertXRechnungToPdf(Expression<Func<ConvertXRechnungToPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV8011ConvertXRechnungToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V8011_ConvertXRechnungToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV8011ConvertXRechnungToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV1071ConvertYamlToJson, ApiConnectionActionConfiguration> ConvertYamlToJson(Expression<Func<DtoRequestV1071YamlToJsonInput>> dtoRequestV1071YamlToJson)
        {
            var __workflow_dtoRequestV1071YamlToJson = WorkflowExpression.Compile(dtoRequestV1071YamlToJson, nameof(dtoRequestV1071YamlToJson), required: true);
            return new DeferredBodyAction<DtoResponseV1071ConvertYamlToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V1071_ConvertYamlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV1071YamlToJson);
                return new ApiConnectionAction<DtoResponseV1071ConvertYamlToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3092CreateChartImage, ApiConnectionActionConfiguration> CreateChartImage(Expression<Func<CreateChartImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3092CreateChartImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3092_CreateChartImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3092CreateChartImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3063CreateCode, ApiConnectionActionConfiguration> CreateCode(Expression<Func<CreateCodeDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3063CreateCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3063_CreateCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3063CreateCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3112CreateGraphImage, ApiConnectionActionConfiguration> CreateGraphImage(Expression<Func<CreateGraphImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3112CreateGraphImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3112_CreateGraphImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3112CreateGraphImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3102CreateTableImage, ApiConnectionActionConfiguration> CreateTableImage(Expression<Func<CreateTableImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3102CreateTableImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3102_CreateTableImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3102CreateTableImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3082CreateWatermarkImage, ApiConnectionActionConfiguration> CreateWatermarkImage(Expression<Func<CreateWatermarkImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3082CreateWatermarkImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3082_CreateWatermarkImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3082CreateWatermarkImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5012CreateWordFile, ApiConnectionActionConfiguration> CreateWordFile(Expression<Func<CreateWordFileDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5012CreateWordFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5012_CreateWordFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5012CreateWordFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4090ExtractImagesFromPdf, ApiConnectionActionConfiguration> ExtractImagesFromPdf(Expression<Func<ExtractImagesFromPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4090ExtractImagesFromPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4090_ExtractImagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4090ExtractImagesFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2100ExtractJsonObjectProperties, ApiConnectionActionConfiguration> ExtractJsonObjectProperties(Expression<Func<DtoRequestV2100ExtractJsonObjectPropertiesInput>> dtoRequestV2100ExtractJsonObjectProperties)
        {
            var __workflow_dtoRequestV2100ExtractJsonObjectProperties = WorkflowExpression.Compile(dtoRequestV2100ExtractJsonObjectProperties, nameof(dtoRequestV2100ExtractJsonObjectProperties), required: true);
            return new DeferredBodyAction<DtoResponseV2100ExtractJsonObjectProperties, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2100_ExtractJsonObjectProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2100ExtractJsonObjectProperties);
                return new ApiConnectionAction<DtoResponseV2100ExtractJsonObjectProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4061ExtractPdfPages, ApiConnectionActionConfiguration> ExtractPdfPages(Expression<Func<ExtractPdfPagesDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4061ExtractPdfPages, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4061_ExtractPdfPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4061ExtractPdfPages>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4160ExtractPdfTablesToCsv, ApiConnectionActionConfiguration> ExtractPdfTablesToCsv(Expression<Func<ExtractPdfTablesToCsvDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4160ExtractPdfTablesToCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4160_ExtractPdfTablesToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4160ExtractPdfTablesToCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4150ExtractPdfTablesToExcel, ApiConnectionActionConfiguration> ExtractPdfTablesToExcel(Expression<Func<ExtractPdfTablesToExcelDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4150ExtractPdfTablesToExcel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4150_ExtractPdfTablesToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4150ExtractPdfTablesToExcel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4170ExtractPdfTablesToHtml, ApiConnectionActionConfiguration> ExtractPdfTablesToHtml(Expression<Func<ExtractPdfTablesToHtmlDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4170ExtractPdfTablesToHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4170_ExtractPdfTablesToHtml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4170ExtractPdfTablesToHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4140ExtractPdfTablesToJson, ApiConnectionActionConfiguration> ExtractPdfTablesToJson(Expression<Func<ExtractPdfTablesToJsonDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4140ExtractPdfTablesToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4140_ExtractPdfTablesToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4140ExtractPdfTablesToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2140ExtractTextAccordingToPattern, ApiConnectionActionConfiguration> ExtractTextAccordingToPattern(Expression<Func<DtoRequestV2140ExtractTextAccordingToPatternInput>> dtoRequestV2140ExtractTextAccordingToPattern)
        {
            var __workflow_dtoRequestV2140ExtractTextAccordingToPattern = WorkflowExpression.Compile(dtoRequestV2140ExtractTextAccordingToPattern, nameof(dtoRequestV2140ExtractTextAccordingToPattern), required: true);
            return new DeferredBodyAction<DtoResponseV2140ExtractTextAccordingToPattern, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2140_ExtractTextAccordingToPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2140ExtractTextAccordingToPattern);
                return new ApiConnectionAction<DtoResponseV2140ExtractTextAccordingToPattern>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4100ExtractTextFromPdf, ApiConnectionActionConfiguration> ExtractTextFromPdf(Expression<Func<ExtractTextFromPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4100ExtractTextFromPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4100_ExtractTextFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4100ExtractTextFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5021ExtractWordBookmarks, ApiConnectionActionConfiguration> ExtractWordBookmarks(Expression<Func<DtoRequestV5021ExtractWordBookmarksInput>> dtoRequestV5021ExtractWordBookmarks)
        {
            var __workflow_dtoRequestV5021ExtractWordBookmarks = WorkflowExpression.Compile(dtoRequestV5021ExtractWordBookmarks, nameof(dtoRequestV5021ExtractWordBookmarks), required: true);
            return new DeferredBodyAction<DtoResponseV5021ExtractWordBookmarks, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5021_ExtractWordBookmarks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV5021ExtractWordBookmarks);
                return new ApiConnectionAction<DtoResponseV5021ExtractWordBookmarks>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5120ExtractWordContentControls, ApiConnectionActionConfiguration> ExtractWordContentControls(Expression<Func<DtoRequestV5120ExtractWordContentControlsInput>> dtoRequestV5120ExtractWordContentControls)
        {
            var __workflow_dtoRequestV5120ExtractWordContentControls = WorkflowExpression.Compile(dtoRequestV5120ExtractWordContentControls, nameof(dtoRequestV5120ExtractWordContentControls), required: true);
            return new DeferredBodyAction<DtoResponseV5120ExtractWordContentControls, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5120_ExtractWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV5120ExtractWordContentControls);
                return new ApiConnectionAction<DtoResponseV5120ExtractWordContentControls>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2021IbanData, ApiConnectionActionConfiguration> IbanData(Expression<Func<DtoRequestV2021IbanDataInput>> dtoRequestV2021IbanData)
        {
            var __workflow_dtoRequestV2021IbanData = WorkflowExpression.Compile(dtoRequestV2021IbanData, nameof(dtoRequestV2021IbanData), required: true);
            return new DeferredBodyAction<DtoResponseV2021IbanData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2021_IbanData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2021IbanData);
                return new ApiConnectionAction<DtoResponseV2021IbanData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3071ImageMetaData, ApiConnectionActionConfiguration> ImageMetaData(Expression<Func<DtoRequestV3071ImageMetaDataInput>> dtoRequestV3071ImageMetaData)
        {
            var __workflow_dtoRequestV3071ImageMetaData = WorkflowExpression.Compile(dtoRequestV3071ImageMetaData, nameof(dtoRequestV3071ImageMetaData), required: true);
            return new DeferredBodyAction<DtoResponseV3071ImageMetaData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3071_ImageMetaData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV3071ImageMetaData);
                return new ApiConnectionAction<DtoResponseV3071ImageMetaData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> InsertImageToPowerPoint(Expression<Func<DtoRequestV9020InsertImagePowerPointInput>> dtoRequestV9020InsertImagePowerPoint)
        {
            var __workflow_dtoRequestV9020InsertImagePowerPoint = WorkflowExpression.Compile(dtoRequestV9020InsertImagePowerPoint, nameof(dtoRequestV9020InsertImagePowerPoint), required: true);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V9020_InsertImageToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV9020InsertImagePowerPoint);
                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5082InsertImageToWord, ApiConnectionActionConfiguration> InsertImageToWord(Expression<Func<InsertImageToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5082InsertImageToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5082_InsertImageToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5082InsertImageToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5111InsertMultipleTextSectionsToWord, ApiConnectionActionConfiguration> InsertMultipleTextSectionsToWord(Expression<Func<InsertMultipleTextSectionsToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5111InsertMultipleTextSectionsToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5111_InsertMultipleTextSectionsToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5111InsertMultipleTextSectionsToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5092InsertTableToWord, ApiConnectionActionConfiguration> InsertTableToWord(Expression<Func<InsertTableToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5092InsertTableToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5092_InsertTableToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5092InsertTableToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseFile, ApiConnectionActionConfiguration> InsertTextToPowerPoint(Expression<Func<DtoRequestV9010InsertTextToPowerPointInput>> dtoRequestV9010InsertTextToPowerPoint)
        {
            var __workflow_dtoRequestV9010InsertTextToPowerPoint = WorkflowExpression.Compile(dtoRequestV9010InsertTextToPowerPoint, nameof(dtoRequestV9010InsertTextToPowerPoint), required: true);
            return new DeferredBodyAction<DtoResponseFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V9010_InsertTextToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV9010InsertTextToPowerPoint);
                return new ApiConnectionAction<DtoResponseFile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5072InsertTextToWord, ApiConnectionActionConfiguration> InsertTextToWord(Expression<Func<InsertTextToWordDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5072InsertTextToWord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5072_InsertTextToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5072InsertTextToWord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4120MergeMultiplePdfs, ApiConnectionActionConfiguration> MergeMultiplePdfs(Expression<Func<MergeMultiplePdfsDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4120MergeMultiplePdfs, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4120_MergeMultiplePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4120MergeMultiplePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4022MergePdfs, ApiConnectionActionConfiguration> MergePdfs(Expression<Func<MergePdfsDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4022MergePdfs, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4022_MergePdfs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4022MergePdfs>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2120MatchPatternCheck, ApiConnectionActionConfiguration> PatternMatchCheck(Expression<Func<DtoRequestV2120PatternMatchCheckInput>> dtoRequestV2120PatternMatchCheck)
        {
            var __workflow_dtoRequestV2120PatternMatchCheck = WorkflowExpression.Compile(dtoRequestV2120PatternMatchCheck, nameof(dtoRequestV2120PatternMatchCheck), required: true);
            return new DeferredBodyAction<DtoResponseV2120MatchPatternCheck, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2120_PatternMatchCheck";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2120PatternMatchCheck);
                return new ApiConnectionAction<DtoResponseV2120MatchPatternCheck>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4031PdfMetadata, ApiConnectionActionConfiguration> PdfMetadata(Expression<Func<DtoRequestV4031PdfMetadataInput>> dtoRequestV4031PdfMetadata)
        {
            var __workflow_dtoRequestV4031PdfMetadata = WorkflowExpression.Compile(dtoRequestV4031PdfMetadata, nameof(dtoRequestV4031PdfMetadata), required: true);
            return new DeferredBodyAction<DtoResponseV4031PdfMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4031_PdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV4031PdfMetadata);
                return new ApiConnectionAction<DtoResponseV4031PdfMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4042ProtectPdf, ApiConnectionActionConfiguration> ProtectPdf(Expression<Func<ProtectPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4042ProtectPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4042_ProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4042ProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3051ReadCode, ApiConnectionActionConfiguration> ReadCode(Expression<Func<DtoRequestReadCodeDataInput>> dtoRequestReadCodeData)
        {
            var __workflow_dtoRequestReadCodeData = WorkflowExpression.Compile(dtoRequestReadCodeData, nameof(dtoRequestReadCodeData), required: true);
            return new DeferredBodyAction<DtoResponseV3051ReadCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3051_ReadCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestReadCodeData);
                return new ApiConnectionAction<DtoResponseV3051ReadCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2011RegularExpression, ApiConnectionActionConfiguration> RegularExpression(Expression<Func<DtoRequestV2011RegularExpressionInput>> dtoRequestV2011RegularExpression)
        {
            var __workflow_dtoRequestV2011RegularExpression = WorkflowExpression.Compile(dtoRequestV2011RegularExpression, nameof(dtoRequestV2011RegularExpression), required: true);
            return new DeferredBodyAction<DtoResponseV2011RegularExpression, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2011_RegularExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2011RegularExpression);
                return new ApiConnectionAction<DtoResponseV2011RegularExpression>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4111RemovePagesFromPdf, ApiConnectionActionConfiguration> RemovePagesFromPdf(Expression<Func<RemovePagesFromPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4111RemovePagesFromPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4111_RemovePagesFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4111RemovePagesFromPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2110ReplaceTextWithPattern, ApiConnectionActionConfiguration> ReplaceTextWithPattern(Expression<Func<DtoRequestV2110ReplaceTextWithPatternInput>> dtoRequestV2110ReplaceTextWithPattern)
        {
            var __workflow_dtoRequestV2110ReplaceTextWithPattern = WorkflowExpression.Compile(dtoRequestV2110ReplaceTextWithPattern, nameof(dtoRequestV2110ReplaceTextWithPattern), required: true);
            return new DeferredBodyAction<DtoResponseV2110ReplaceTextWithPattern, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2110_ReplaceTextWithPattern";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2110ReplaceTextWithPattern);
                return new ApiConnectionAction<DtoResponseV2110ReplaceTextWithPattern>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3023ResizeImage, ApiConnectionActionConfiguration> ResizeImage(Expression<Func<ResizeImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3023ResizeImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3023_ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3023ResizeImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV3032RotateImage, ApiConnectionActionConfiguration> RotateImage(Expression<Func<RotateImageDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV3032RotateImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V3032_RotateImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV3032RotateImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2151RunCode, ApiConnectionActionConfiguration> RunCode(Expression<Func<DtoInput>> dto)
        {
            var __workflow_dto = WorkflowExpression.Compile(dto, nameof(dto), required: true);
            return new DeferredBodyAction<DtoResponseV2151RunCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2151_RunCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dto);
                return new ApiConnectionAction<DtoResponseV2151RunCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2130SmartTextSplit, ApiConnectionActionConfiguration> SmartTextSplit(Expression<Func<DtoRequestV2130SmartTextSplitInput>> dtoRequestV2130SmartTextSplit)
        {
            var __workflow_dtoRequestV2130SmartTextSplit = WorkflowExpression.Compile(dtoRequestV2130SmartTextSplit, nameof(dtoRequestV2130SmartTextSplit), required: true);
            return new DeferredBodyAction<DtoResponseV2130SmartTextSplit, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2130_SmartTextSplit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2130SmartTextSplit);
                return new ApiConnectionAction<DtoResponseV2130SmartTextSplit>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2061SortCsv, ApiConnectionActionConfiguration> SortCsv(Expression<Func<DtoRequestV2061SortCsvInput>> dtoRequestV2061SortCsv)
        {
            var __workflow_dtoRequestV2061SortCsv = WorkflowExpression.Compile(dtoRequestV2061SortCsv, nameof(dtoRequestV2061SortCsv), required: true);
            return new DeferredBodyAction<DtoResponseV2061SortCsv, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2061_SortCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2061SortCsv);
                return new ApiConnectionAction<DtoResponseV2061SortCsv>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2051SortJson, ApiConnectionActionConfiguration> SortJson(Expression<Func<DtoRequestV2051SortJsonInput>> dtoRequestV2051SortJson)
        {
            var __workflow_dtoRequestV2051SortJson = WorkflowExpression.Compile(dtoRequestV2051SortJson, nameof(dtoRequestV2051SortJson), required: true);
            return new DeferredBodyAction<DtoResponseV2051SortJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2051_SortJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2051SortJson);
                return new ApiConnectionAction<DtoResponseV2051SortJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2041Translate, ApiConnectionActionConfiguration> Translate(Expression<Func<DtoRequestV2041TranslateInput>> dtoRequestV2041Translate)
        {
            var __workflow_dtoRequestV2041Translate = WorkflowExpression.Compile(dtoRequestV2041Translate, nameof(dtoRequestV2041Translate), required: true);
            return new DeferredBodyAction<DtoResponseV2041Translate, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2041_Translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequestV2041Translate);
                return new ApiConnectionAction<DtoResponseV2041Translate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV4052UnProtectPdf, ApiConnectionActionConfiguration> UnProtectPdf(Expression<Func<UnProtectPdfDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV4052UnProtectPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V4052_UnProtectPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV4052UnProtectPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5151UpdateMultipleWordContentControls, ApiConnectionActionConfiguration> UpdateMultipleWordContentControls(Expression<Func<UpdateMultipleWordContentControlsDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5151UpdateMultipleWordContentControls, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5151_UpdateMultipleWordContentControls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5151UpdateMultipleWordContentControls>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5141UpdateWordContentControl, ApiConnectionActionConfiguration> UpdateWordContentControl(Expression<Func<UpdateWordContentControlDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5141UpdateWordContentControl, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5141_UpdateWordContentControl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5141UpdateWordContentControl>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV5131UpdateWordTableOfContents, ApiConnectionActionConfiguration> UpdateWordTableOfContents(Expression<Func<UpdateWordTableOfContentsDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV5131UpdateWordTableOfContents, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V5131_UpdateWordTableOfContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV5131UpdateWordTableOfContents>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "converterbypower2apps")]
        public IBodyWorkflowAction<DtoResponseV2032UrlToFile, ApiConnectionActionConfiguration> UrlToFile(Expression<Func<UrlToFileDtoRequestInput>> dtoRequest)
        {
            var __workflow_dtoRequest = WorkflowExpression.Compile(dtoRequest, nameof(dtoRequest), required: true);
            return new DeferredBodyAction<DtoResponseV2032UrlToFile, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/V2032_UrlToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dtoRequest);
                return new ApiConnectionAction<DtoResponseV2032UrlToFile>(callPayload);
            });
        }
    }

    public class Converterbypower2appsTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseV5102AddHtmlToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class AddHtmlToWordDtoRequestInput
    {
        public AddHtmlToWordDtoRequestInput(string hTML)
        {
            this.HTML = hTML;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5032AddImageToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class AddImageToWordDtoRequestInput
    {
        public AddImageToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent image)
        {
            this.Image = image;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Image { get; set; }

        [JsonProperty("imageText")]
        public string CaptionText { get; set; }

        [JsonProperty("maxWidth")]
        public int? MaximumImageWidth { get; set; }

        [JsonProperty("maxHeight")]
        public int? MaximumImageHeight { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5043AddImageWithinTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class AddImageWithinTableToWordDtoRequestInput
    {
        public AddImageWithinTableToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent image)
        {
            this.Image = image;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Image { get; set; }

        [JsonProperty("imageText")]
        public string DescriptionText { get; set; }

        [JsonProperty("maxWidth")]
        public int? MaximumImageWidth { get; set; }

        [JsonProperty("maxHeight")]
        public int? MaximumImageHeight { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5053AddTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class AddTableToWordDtoRequestInput
    {
        public AddTableToWordDtoRequestInput(string tableData)
        {
            this.TableData = tableData;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("table", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableData { get; set; }

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHeaders { get; set; } = true;

        [JsonProperty("tableStyle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableStyle { get; set; } = "GridTable1Light";

        [JsonProperty("tableText")]
        public string TableCaption { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5062AddTextToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class AddTextToWordDtoRequestInput
    {
        public AddTextToWordDtoRequestInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("sectionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; } = "Heading1";

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2081CombineCsvs
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoRequestV2081CombineCsvsInput
    {
        public DtoRequestV2081CombineCsvsInput(string mainCSV, string combineColumnName, string secondCSV)
        {
            this.MainCSV = mainCSV;
            this.CombineColumnName = combineColumnName;
            this.SecondCSV = secondCSV;
        }

        [JsonProperty("mainCsv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MainCSV { get; set; }

        [JsonProperty("mainCsvColumn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CombineColumnName { get; set; }

        [JsonProperty("secondCsv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondCSV { get; set; }

        [JsonProperty("secondCsvColumn")]
        public string SecondCSVColumn { get; set; }
    }

    public class DtoResponseV2091CombineJsonArrays
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoRequestV2091CombineJsonArraysInput
    {
        public DtoRequestV2091CombineJsonArraysInput(string mainJSON, string combinePropertyName, string secondJSON)
        {
            this.MainJSON = mainJSON;
            this.CombinePropertyName = combinePropertyName;
            this.SecondJSON = secondJSON;
        }

        [JsonProperty("mainJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MainJSON { get; set; }

        [JsonProperty("mainJsonProperty", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CombinePropertyName { get; set; }

        [JsonProperty("secondJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecondJSON { get; set; }

        [JsonProperty("secondJsonProperty")]
        public string SecondJSONProperty { get; set; }
    }

    public class DtoResponseV3042CompressImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CompressImageDtoRequestInput
    {
        public CompressImageDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile)
        {
            this.ImageFile = imageFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("quality")]
        public int? ImageQuality { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV4081CompressPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CompressPdfDtoRequestInput
    {
        public CompressPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("compressImages")]
        public bool? CompressImages { get; set; }

        [JsonProperty("imageQuality")]
        public int? ImageQuality { get; set; }

        [JsonProperty("optimizeFont")]
        public bool? OptimizeFonts { get; set; }

        [JsonProperty("optimizePageContents")]
        public bool? OptimizePageContents { get; set; }

        [JsonProperty("removeMetadata")]
        public bool? RemoveMetadata { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2071ConvertColor
    {
        [JsonProperty("rgb")]
        public string RGB { get; set; }

        [JsonProperty("hex")]
        public string HEX { get; set; }

        [JsonProperty("cmyk")]
        public string CMYK { get; set; }

        [JsonProperty("hsl")]
        public string HSL { get; set; }

        [JsonProperty("hsv")]
        public string HSV { get; set; }

        [JsonProperty("xyz")]
        public string XYZ { get; set; }

        [JsonProperty("yiq")]
        public string YIQ { get; set; }

        [JsonProperty("yuv")]
        public string YUV { get; set; }

        [JsonProperty("colorName")]
        public string ColorName { get; set; }
    }

    public class DtoRequestV2071ConvertColorInput
    {
        public DtoRequestV2071ConvertColorInput(string color)
        {
            this.Color = color;
        }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Color { get; set; }
    }

    public class DtoResponseV1035ConvertCsvToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("detectedEncoding")]
        public string DetectedEncoding { get; set; }

        [JsonProperty("detectedDelimiter")]
        public string DetectedDelimiter { get; set; }
    }

    public class ConvertCsvToExcelDtoRequestInput
    {
        public ConvertCsvToExcelDtoRequestInput(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("dataIncludesHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("maxScanRows")]
        public int? NumberOfRowsForFieldTypeDetection { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("skip")]
        public int? SkipANumberOfRows { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtASpecificRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("encoding")]
        public int? CSVInputEncoding { get; set; }

        [JsonProperty("adjustColumnToContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AdjustExcelColumnToContent { get; set; } = true;

        [JsonProperty("wrapColumnText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WrapExcelColumnText { get; set; } = false;

        [JsonProperty("maxColumnWidth")]
        public int? MaxExcelColumnWidth { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }
    }

    public class DtoRequestV7061ConvertCsvToHtmlTableInput
    {
        public DtoRequestV7061ConvertCsvToHtmlTableInput(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("dataIncludesHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("maxScanRows")]
        public int? NumberOfRowsForFieldTypeDetection { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("skip")]
        public int? SkipANumberOfRows { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtASpecificRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;
    }

    public class DtoResponseV1022ConvertCsvToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoRequestV1022ConvertCsvToJsonInput
    {
        public DtoRequestV1022ConvertCsvToJsonInput(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("dataIncludesHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("maxScanRows")]
        public int? NumberOfRowsForFieldTypeDetection { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("skip")]
        public int? SkipANumberOfRows { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtASpecificRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;
    }

    public class DtoResponseV1150ConvertCsvToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertCsvToMarkdownDtoRequestInput
    {
        public ConvertCsvToMarkdownDtoRequestInput(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("dataIncludesHeader")]
        public bool? FirstRowIsTheHeader { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields")]
        public bool? ValuesMayBeInQuotes { get; set; }

        [JsonProperty("ignoreEmptyLine")]
        public bool? SkipEmptyLines { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV1100ConvertExcelToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }

        [JsonProperty("schema")]
        public string JSONSchemaResponse { get; set; }
    }

    public class DtoRequestV1100ConvertExcelToJsonInput
    {
        public DtoRequestV1100ConvertExcelToJsonInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent excelFile)
        {
            this.ExcelFile = excelFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExcelFile { get; set; }

        [JsonProperty("hasHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExcelHasHeaders { get; set; } = true;

        [JsonProperty("startCell")]
        public string StartCell { get; set; }

        [JsonProperty("sheetName")]
        public string SheetName { get; set; }
    }

    public class DtoResponseV1140ConvertExcelToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertExcelToMarkdownDtoRequestInput
    {
        public ConvertExcelToMarkdownDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent excel)
        {
            this.Excel = excel;
        }

        [JsonProperty("excel", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Excel { get; set; }

        [JsonProperty("firstRowIsHeader")]
        public bool? FirstRowIsTheHeader { get; set; }

        [JsonProperty("includeSheetNames")]
        public bool? AddSheetNames { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV4014ConvertFileToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertFileToPdfDtoRequestInput
    {
        public ConvertFileToPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("fileName")]
        public string OriginFileName { get; set; }

        [JsonProperty("fileExtension")]
        public string OriginFileExtension { get; set; }

        [JsonProperty("conformanceLevel")]
        public int? ConformanceLevel { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV7070ConvertHtmlTableToCsv
    {
        [JsonProperty("firstCsvTable")]
        public string FirstCSVTableResponse { get; set; }

        [JsonProperty("csvTables")]
        public string[] AllCSVTablesResponse { get; set; }
    }

    public class DtoRequestV7070ConvertHtmlTableToCsvInput
    {
        public DtoRequestV7070ConvertHtmlTableToCsvInput(string hTMLTable)
        {
            this.HTMLTable = hTMLTable;
        }

        [JsonProperty("htmlTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTMLTable { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }
    }

    public class DtoResponseV7082ConvertHtmlTableToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class ConvertHtmlTableToExcelDtoRequestInput
    {
        public ConvertHtmlTableToExcelDtoRequestInput(string hTMLTable)
        {
            this.HTMLTable = hTMLTable;
        }

        [JsonProperty("htmlTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTMLTable { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV7013ConvertHtmlTableToJson
    {
        [JsonProperty("firstTable")]
        public string FirstJSONTableResponse { get; set; }

        [JsonProperty("tables")]
        public string[] AllJSONTablesResponse { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class ConvertHtmlTableToJsonDtoRequestInput
    {
        public ConvertHtmlTableToJsonDtoRequestInput(string hTMLTable)
        {
            this.HTMLTable = hTMLTable;
        }

        [JsonProperty("htmlTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTMLTable { get; set; }
    }

    public class DtoResponseV7032ConvertHtmlToImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertHtmlToImageDtoRequestInput
    {
        public ConvertHtmlToImageDtoRequestInput(string hTML)
        {
            this.HTML = hTML;
        }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV7090ConvertHtmlToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertHtmlToMarkdownDtoRequestInput
    {
        public ConvertHtmlToMarkdownDtoRequestInput(string hTML)
        {
            this.HTML = hTML;
        }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("removeClutter")]
        public bool? RemoveMenusAndExtras { get; set; }

        [JsonProperty("keepImagePlaceholders")]
        public bool? KeepImagePlaceholders { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV7023ConvertHtmlToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertHtmlToPdfDtoRequestInput
    {
        public ConvertHtmlToPdfDtoRequestInput(string hTML)
        {
            this.HTML = hTML;
        }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("isLandscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LandscapeFormat { get; set; } = false;

        [JsonProperty("imageQuality")]
        public int? QualityOfImageContent { get; set; }

        [JsonProperty("footerOption")]
        public int? FooterOptions { get; set; }

        [JsonProperty("headerOption")]
        public int? HeaderOptions { get; set; }

        [JsonProperty("paperFormat")]
        public string PaperFormat { get; set; }

        [JsonProperty("marginTop")]
        public int? TopMargin { get; set; }

        [JsonProperty("marginBottom")]
        public int? BottomMargin { get; set; }

        [JsonProperty("marginLeft")]
        public int? LeftMargin { get; set; }

        [JsonProperty("marginRight")]
        public int? RightMargin { get; set; }

        [JsonProperty("pageRanges")]
        public string PageRanges { get; set; }

        [JsonProperty("scale")]
        public double? Scale { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileContent")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class DtoRequestV7041ConvertHtmlToWordInput
    {
        public DtoRequestV7041ConvertHtmlToWordInput(string hTML)
        {
            this.HTML = hTML;
        }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }
    }

    public class DtoRequestV3012ConvertImageInput
    {
        public DtoRequestV3012ConvertImageInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile)
        {
            this.ImageFile = imageFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("outFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFormat { get; set; } = "JPEG";
    }

    public class DtoResponseV1013ConvertJsonToCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoRequestV1013ConvertJsonToCsvInput
    {
        public DtoRequestV1013ConvertJsonToCsvInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }
    }

    public class DtoResponseV1064ConvertJsonToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertJsonToExcelDtoRequestInput
    {
        public ConvertJsonToExcelDtoRequestInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }

        [JsonProperty("allInOneTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllInOneTable { get; set; } = true;

        [JsonProperty("adjustColumnToContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AdjustExcelColumnToContent { get; set; } = true;

        [JsonProperty("wrapColumnText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WrapExcelColumnText { get; set; } = false;

        [JsonProperty("maxColumnWidth")]
        public int? MaxExcelColumnWidth { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoRequestV7051ConvertJsonToHtmlTableInput
    {
        public DtoRequestV7051ConvertJsonToHtmlTableInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }
    }

    public class DtoResponseV1090ConvertJsonToTextTable
    {
        [JsonProperty("text")]
        public string TextResponse { get; set; }
    }

    public class DtoRequestV1090ConvertJsonToTextTableInput
    {
        public DtoRequestV1090ConvertJsonToTextTableInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }
    }

    public class DtoResponseV1042ConvertJsonToXml
    {
        [JsonProperty("xml")]
        public string XMLResponse { get; set; }
    }

    public class DtoRequestV1042ConvertJsonToXmlInput
    {
        public DtoRequestV1042ConvertJsonToXmlInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }
    }

    public class DtoResponseV1081ConvertJsonToYaml
    {
        [JsonProperty("yaml")]
        public string YAMLResponse { get; set; }
    }

    public class DtoRequestV1081ConvertJsonToYamlInput
    {
        public DtoRequestV1081ConvertJsonToYamlInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }
    }

    public class DtoResponseV1110ConvertMultiCsvToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertMultiCsvToExcelDtoRequestInput
    {
        public ConvertMultiCsvToExcelDtoRequestInput(CsvSheetItem[] sheet)
        {
            this.Sheet = sheet;
        }

        [JsonProperty("csvSheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public CsvSheetItem[] Sheet { get; set; }

        [JsonProperty("dataIncludesHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("maxScanRows")]
        public int? NumberOfRowsForFieldTypeDetection { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("skip")]
        public int? SkipANumberOfRows { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtASpecificRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("adjustColumnToContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AdjustExcelColumnToContent { get; set; } = true;

        [JsonProperty("wrapColumnText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WrapExcelColumnText { get; set; } = false;

        [JsonProperty("maxColumnWidth")]
        public int? MaxExcelColumnWidth { get; set; }

        [JsonProperty("fileName")]
        public string ExcelFileName { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class CsvSheetItem
    {
        public CsvSheetItem(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("sheetName")]
        public string Name { get; set; }
    }

    public class DtoResponseV4130ConvertPdfToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertPdfToMarkdownDtoRequestInput
    {
        public ConvertPdfToMarkdownDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("layoutBased")]
        public bool? KeepReadingOrder { get; set; }

        [JsonProperty("detectHeadings")]
        public bool? MarkHeadings { get; set; }

        [JsonProperty("addPageMarkers")]
        public bool? AddPageMarkers { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV4071ConvertPdfToPdfA
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertPdfToPdfADtoRequestInput
    {
        public ConvertPdfToPdfADtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("conformanceLevel")]
        public int? ConformanceLevel { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV6011ConvertSharePointSearchResults
    {
        [JsonProperty("sharePointSearchResults")]
        public SharePointSearchResultResponse[] CodeValue { get; set; }
    }

    public class SharePointSearchResultResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class DtoRequestV6011ConvertSharePointSearchResultsInput
    {
        public DtoRequestV6011ConvertSharePointSearchResultsInput(string sPSearchResult)
        {
            this.SPSearchResult = sPSearchResult;
        }

        [JsonProperty("sharepointResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SPSearchResult { get; set; }
    }

    public class DtoResponseV5160ConvertWordToHtml
    {
        [JsonProperty("html")]
        public string HTMLResponse { get; set; }
    }

    public class ConvertWordToHtmlDtoRequestInput
    {
        public ConvertWordToHtmlDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent word)
        {
            this.Word = word;
        }

        [JsonProperty("word", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Word { get; set; }

        [JsonProperty("embedImages")]
        public bool? EmbedImages { get; set; }

        [JsonProperty("fullHtmlDocument")]
        public bool? FullHTMLDocument { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class DtoResponseV5170ConvertWordToMarkdown
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("characterCount")]
        public int CharacterCount { get; set; }

        [JsonProperty("estimatedTokens")]
        public int EstimatedTokens { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertWordToMarkdownDtoRequestInput
    {
        public ConvertWordToMarkdownDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent word)
        {
            this.Word = word;
        }

        [JsonProperty("word", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Word { get; set; }

        [JsonProperty("keepImagePlaceholders")]
        public bool? KeepImagePlaceholders { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV1130ConvertXmlToCsv
    {
        [JsonProperty("csv")]
        public string CSV { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertXmlToCsvDtoRequestInput
    {
        public ConvertXmlToCsvDtoRequestInput(string xML)
        {
            this.XML = xML;
        }

        [JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XML { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("ignoreXmlFormatting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreXMLFormatting { get; set; } = true;

        [JsonProperty("fileName")]
        public string CSVFileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV1120ConvertXmlToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class ConvertXmlToExcelDtoRequestInput
    {
        public ConvertXmlToExcelDtoRequestInput(string xML)
        {
            this.XML = xML;
        }

        [JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XML { get; set; }

        [JsonProperty("ignoreXmlFormatting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreXMLFormatting { get; set; } = true;

        [JsonProperty("allInOneTable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllInOneTable { get; set; } = true;

        [JsonProperty("adjustColumnToContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AdjustExcelColumnToContent { get; set; } = true;

        [JsonProperty("wrapColumnText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WrapExcelColumnText { get; set; } = false;

        [JsonProperty("maxColumnWidth")]
        public int? MaxExcelColumnWidth { get; set; }

        [JsonProperty("fileName")]
        public string ExcelFileName { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV1053ConvertXmlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class ConvertXmlToJsonDtoRequestInput
    {
        public ConvertXmlToJsonDtoRequestInput(string xML)
        {
            this.XML = xML;
        }

        [JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XML { get; set; }

        [JsonProperty("ignoreXmlFormatting")]
        public bool? IgnoreXMLFormatting { get; set; }
    }

    public class DtoResponseV8011ConvertXRechnungToPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ConvertXRechnungToPdfDtoRequestInput
    {
        public ConvertXRechnungToPdfDtoRequestInput(string xRechnung)
        {
            this.XRechnung = xRechnung;
        }

        [JsonProperty("xml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XRechnung { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV1071ConvertYamlToJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoRequestV1071YamlToJsonInput
    {
        public DtoRequestV1071YamlToJsonInput(string yAML)
        {
            this.YAML = yAML;
        }

        [JsonProperty("yaml", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YAML { get; set; }
    }

    public class DtoResponseV3092CreateChartImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateChartImageDtoRequestInput
    {
        public CreateChartImageDtoRequestInput(string tableData)
        {
            this.TableData = tableData;
        }

        [JsonProperty("width")]
        public int? ImageWidth { get; set; }

        [JsonProperty("height")]
        public int? ImageHeight { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("chart", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableData { get; set; }

        [JsonProperty("type")]
        public string ChartType { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3063CreateCode
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateCodeDtoRequestInput
    {
        public CreateCodeDtoRequestInput(string content)
        {
            this.Content = content;
        }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("codeFormat")]
        public string CodeFormat { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("outFormat")]
        public string OutputFormat { get; set; }

        [JsonProperty("image")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent EmbeddedImage { get; set; }

        [JsonProperty("imageOpacity")]
        public double? EmbeddedImageOpacity { get; set; }

        [JsonProperty("imageRatio")]
        public double? EmbeddedImageRatio { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3112CreateGraphImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateGraphImageDtoRequestInput
    {
        public CreateGraphImageDtoRequestInput(string graphData)
        {
            this.GraphData = graphData;
        }

        [JsonProperty("width")]
        public int? ImageWidth { get; set; }

        [JsonProperty("height")]
        public int? ImageHeight { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("graph", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GraphData { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3102CreateTableImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateTableImageDtoRequestInput
    {
        public CreateTableImageDtoRequestInput(string tableData)
        {
            this.TableData = tableData;
        }

        [JsonProperty("width")]
        public int? ImageWidth { get; set; }

        [JsonProperty("height")]
        public int? ImageHeight { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("format")]
        public string OutputFormat { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableData { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hasLines", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowTableBorders { get; set; } = true;

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3082CreateWatermarkImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateWatermarkImageDtoRequestInput
    {
        public CreateWatermarkImageDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent mainImage, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent watermarkImage)
        {
            this.MainImage = mainImage;
            this.WatermarkImage = watermarkImage;
        }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent MainImage { get; set; }

        [JsonProperty("watermarkImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent WatermarkImage { get; set; }

        [JsonProperty("opacity")]
        public int? WatermarkOpacity { get; set; }

        [JsonProperty("ratio")]
        public int? WatermarkRatio { get; set; }

        [JsonProperty("imagePositionHorizontal")]
        public string WatermarkHorizontalPosition { get; set; }

        [JsonProperty("imagePositionVertical")]
        public string WatermarkVerticalPosition { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5012CreateWordFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class CreateWordFileDtoRequestInput
    {
        public CreateWordFileDtoRequestInput(Section[] section)
        {
            this.Section = section;
        }

        [JsonProperty("existingFileContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("sections", DefaultValueHandling = DefaultValueHandling.Include)]
        public Section[] Section { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class Section
    {
        public Section(string text)
        {
            this.Text = text;
        }

        [JsonProperty("sectionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; } = "Heading1";

        [JsonProperty("sectionContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class DtoResponseV4090ExtractImagesFromPdf
    {
        [JsonProperty("images")]
        public DtoResponseV4090ExtractedImageItem[] Images { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class DtoResponseV4090ExtractedImageItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("file")]
        public string FileBytes { get; set; }

        [JsonProperty("fileString")]
        public string FileAsBase64String { get; set; }
    }

    public class ExtractImagesFromPdfDtoRequestInput
    {
        public ExtractImagesFromPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("fileNamePrefix")]
        public string FileNamePrefix { get; set; }

        [JsonProperty("includeFileString")]
        public bool? IncludeBase64String { get; set; }
    }

    public class DtoResponseV2100ExtractJsonObjectProperties
    {
        [JsonProperty("propertyNames")]
        public string[] PropertyNamesAsList { get; set; }

        [JsonProperty("properties")]
        public JsonPropertyDetail[] PropertiesAsList { get; set; }
    }

    public class JsonPropertyDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class DtoRequestV2100ExtractJsonObjectPropertiesInput
    {
        public DtoRequestV2100ExtractJsonObjectPropertiesInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }

        [JsonProperty("nestedPropertyExtraction", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractNestedProperties { get; set; } = true;
    }

    public class DtoResponseV4061ExtractPdfPages
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ExtractPdfPagesDtoRequestInput
    {
        public ExtractPdfPagesDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDFFile, string pagesToExtract)
        {
            this.PDFFile = pDFFile;
            this.PagesToExtract = pagesToExtract;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDFFile { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PagesToExtract { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV4160ExtractPdfTablesToCsv
    {
        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class ExtractPdfTablesToCsvDtoRequestInput
    {
        public ExtractPdfTablesToCsvDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("headerMode")]
        public int? HeaderRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("fileName")]
        public string CSVFileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV4150ExtractPdfTablesToExcel
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string Base64String { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class ExtractPdfTablesToExcelDtoRequestInput
    {
        public ExtractPdfTablesToExcelDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("headerMode")]
        public int? HeaderRow { get; set; }

        [JsonProperty("fileName")]
        public string ExcelFileName { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? FileResponse { get; set; }
    }

    public class DtoResponseV4170ExtractPdfTablesToHtml
    {
        [JsonProperty("html")]
        public string HTML { get; set; }

        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class ExtractPdfTablesToHtmlDtoRequestInput
    {
        public ExtractPdfTablesToHtmlDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("headerMode")]
        public int? HeaderRow { get; set; }

        [JsonProperty("fileName")]
        public string HTMLFileName { get; set; }

        [JsonProperty("textOutputMode")]
        public int? OutputFormat { get; set; }
    }

    public class DtoResponseV4140ExtractPdfTablesToJson
    {
        [JsonProperty("firstTable")]
        public string FirstTable { get; set; }

        [JsonProperty("tables")]
        public string[] Tables { get; set; }

        [JsonProperty("tableCount")]
        public int TableCount { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class ExtractPdfTablesToJsonDtoRequestInput
    {
        public ExtractPdfTablesToJsonDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("headerMode")]
        public int? HeaderRow { get; set; }
    }

    public class DtoResponseV2140ExtractTextAccordingToPattern
    {
        [JsonProperty("matches")]
        public string[] TextMatchesAsList { get; set; }
    }

    public class DtoRequestV2140ExtractTextAccordingToPatternInput
    {
        public DtoRequestV2140ExtractTextAccordingToPatternInput(string text, string matchPattern)
        {
            this.Text = text;
            this.MatchPattern = matchPattern;
        }

        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("matchPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MatchPattern { get; set; }

        [JsonProperty("trimEnabled")]
        public bool? TrimEnabled { get; set; }

        [JsonProperty("trimStrings")]
        public string TrimStrings { get; set; }
    }

    public class DtoResponseV4100ExtractTextFromPdf
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("pages")]
        public DtoResponseV4100PageText[] Pages { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
    }

    public class DtoResponseV4100PageText
    {
        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ExtractTextFromPdfDtoRequestInput
    {
        public ExtractTextFromPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("fromPage")]
        public int? FromPage { get; set; }

        [JsonProperty("toPage")]
        public int? ToPage { get; set; }

        [JsonProperty("layoutBased")]
        public bool? LayoutBased { get; set; }

        [JsonProperty("includePages")]
        public bool? IncludePages { get; set; }

        [JsonProperty("pageSeparator")]
        public string PageSeparator { get; set; }

        [JsonProperty("normalizeWhitespace")]
        public bool? NormalizeWhitespace { get; set; }
    }

    public class DtoResponseV5021ExtractWordBookmarks
    {
        [JsonProperty("wordBookmarks")]
        public KeyValPair[] WordBookmarks { get; set; }
    }

    public class KeyValPair
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DtoRequestV5021ExtractWordBookmarksInput
    {
        public DtoRequestV5021ExtractWordBookmarksInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("includeHiddenBookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeHiddenBookmarks { get; set; } = false;

        [JsonProperty("searchKey")]
        public string SearchName { get; set; }

        [JsonProperty("searchValue")]
        public string SearchContent { get; set; }
    }

    public class DtoResponseV5120ExtractWordContentControls
    {
        [JsonProperty("wordControls")]
        public WordControl[] WordContentControls { get; set; }
    }

    public class WordControl
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lock")]
        public string Lock { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DtoRequestV5120ExtractWordContentControlsInput
    {
        public DtoRequestV5120ExtractWordContentControlsInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("searchTag")]
        public string SearchTag { get; set; }

        [JsonProperty("searchTitle")]
        public string SearchTitle { get; set; }
    }

    public class DtoResponseV2021IbanData
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isSepaCountry")]
        public bool IsValidSEPACountry { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("bban")]
        public string BBAN { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("formattedIban")]
        public string FormattedIBAN { get; set; }

        [JsonProperty("unformattedIban")]
        public string UnformattedIBAN { get; set; }

        [JsonProperty("swift_code")]
        public string SWIFTCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bank_city")]
        public string BankCity { get; set; }

        [JsonProperty("bank_zip")]
        public string BankZIP { get; set; }

        [JsonProperty("bank_adress")]
        public string BankAddress { get; set; }
    }

    public class DtoRequestV2021IbanDataInput
    {
        public DtoRequestV2021IbanDataInput(string iBAN)
        {
            this.IBAN = iBAN;
        }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IBAN { get; set; }
    }

    public class DtoResponseV3071ImageMetaData
    {
        [JsonProperty("imageFormat")]
        public string ImageFormat { get; set; }

        [JsonProperty("imageSize")]
        public double ImageSize { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("orientation")]
        public string Orientation { get; set; }

        [JsonProperty("bits")]
        public int BitsPerPixel { get; set; }

        [JsonProperty("recordingDate")]
        public string DateOfRecording { get; set; }

        [JsonProperty("horizontalResolution")]
        public double HorizontalResolution { get; set; }

        [JsonProperty("verticalResolution")]
        public double VerticalResolution { get; set; }

        [JsonProperty("hasEXIFData")]
        public bool HasEXIFData { get; set; }

        [JsonProperty("exifData")]
        public string EXIFData { get; set; }

        [JsonProperty("hasXMPData")]
        public bool HasXMPData { get; set; }
    }

    public class DtoRequestV3071ImageMetaDataInput
    {
        public DtoRequestV3071ImageMetaDataInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile)
        {
            this.ImageFile = imageFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }
    }

    public class DtoRequestV9020InsertImagePowerPointInput
    {
        public DtoRequestV9020InsertImagePowerPointInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent placeholderImage)
        {
            this.ExistingFileContent = existingFileContent;
            this.PlaceholderImage = placeholderImage;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("placeholderName")]
        public string PlaceholderName { get; set; }

        [JsonProperty("placeholderImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PlaceholderImage { get; set; }

        [JsonProperty("width")]
        public int? MaximumImageWidth { get; set; }

        [JsonProperty("height")]
        public int? MaximumImageHeight { get; set; }

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }
    }

    public class DtoResponseV5082InsertImageToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class InsertImageToWordDtoRequestInput
    {
        public InsertImageToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent image)
        {
            this.ExistingFileContent = existingFileContent;
            this.Image = image;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("placeholderName")]
        public string PlaceholderName { get; set; }

        [JsonProperty("placeholderImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Image { get; set; }

        [JsonProperty("maxWidth")]
        public int? MaximumImageWidth { get; set; }

        [JsonProperty("maxHeight")]
        public int? MaximumImageHeight { get; set; }

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5111InsertMultipleTextSectionsToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class InsertMultipleTextSectionsToWordDtoRequestInput
    {
        public InsertMultipleTextSectionsToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, InsertSection[] placeholder)
        {
            this.ExistingFileContent = existingFileContent;
            this.Placeholder = placeholder;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("insertSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public InsertSection[] Placeholder { get; set; }

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class InsertSection
    {
        public InsertSection(string name)
        {
            this.Name = name;
        }

        [JsonProperty("placeholderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("placeholderText")]
        public string Text { get; set; }
    }

    public class DtoResponseV5092InsertTableToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class InsertTableToWordDtoRequestInput
    {
        public InsertTableToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent)
        {
            this.ExistingFileContent = existingFileContent;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("placeholderName")]
        public string PlaceholderName { get; set; }

        [JsonProperty("placeholderTable")]
        public string PlaceholderTable { get; set; }

        [JsonProperty("tableStyle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableStyle { get; set; } = "GridTable1Light";

        [JsonProperty("hasHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHeaders { get; set; } = true;

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoRequestV9010InsertTextToPowerPointInput
    {
        public DtoRequestV9010InsertTextToPowerPointInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, string placeholderName)
        {
            this.ExistingFileContent = existingFileContent;
            this.PlaceholderName = placeholderName;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("placeholderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceholderName { get; set; }

        [JsonProperty("placeholderText")]
        public string PlaceholderText { get; set; }

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }
    }

    public class DtoResponseV5072InsertTextToWord
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class InsertTextToWordDtoRequestInput
    {
        public InsertTextToWordDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, string placeholderName)
        {
            this.ExistingFileContent = existingFileContent;
            this.PlaceholderName = placeholderName;
        }

        [JsonProperty("existingFileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("placeholderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceholderName { get; set; }

        [JsonProperty("placeholderText")]
        public string PlaceholderText { get; set; }

        [JsonProperty("placeholderPrefix")]
        public string PlaceholderPrefix { get; set; }

        [JsonProperty("placeholderSuffix")]
        public string PlaceholderSuffix { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV4120MergeMultiplePdfs
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class MergeMultiplePdfsDtoRequestInput
    {
        public MergeMultiplePdfsDtoRequestInput(PdfMergeItem[] pDF)
        {
            this.PDF = pDF;
        }

        [JsonProperty("pdfFiles", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfMergeItem[] PDF { get; set; }

        [JsonProperty("addPageNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddPageNumbers { get; set; } = false;

        [JsonProperty("pageNumberFormat")]
        public int? PageNumberFormat { get; set; }

        [JsonProperty("pageNumberPosition")]
        public int? PageNumberPosition { get; set; }

        [JsonProperty("addBookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddBookmarks { get; set; } = false;

        [JsonProperty("pdfTitle")]
        public string PDFTitle { get; set; }

        [JsonProperty("pdfAuthor")]
        public string PDFAuthor { get; set; }

        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class PdfMergeItem
    {
        public PdfMergeItem(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }
    }

    public class DtoResponseV4022MergePdfs
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class MergePdfsDtoRequestInput
    {
        public MergePdfsDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent file1, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent file2)
        {
            this.File1 = file1;
            this.File2 = file2;
        }

        [JsonProperty("file1", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File1 { get; set; }

        [JsonProperty("file2", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File2 { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2120MatchPatternCheck
    {
        [JsonProperty("success")]
        public bool MatchSuccess { get; set; }
    }

    public class DtoRequestV2120PatternMatchCheckInput
    {
        public DtoRequestV2120PatternMatchCheckInput(string inputText, string matchPattern)
        {
            this.InputText = inputText;
            this.MatchPattern = matchPattern;
        }

        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputText { get; set; }

        [JsonProperty("matchPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MatchPattern { get; set; }
    }

    public class DtoResponseV4031PdfMetadata
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("creationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("modificationDate")]
        public int ModificationDate { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("pdfVersion")]
        public int PDFVersion { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }
    }

    public class DtoRequestV4031PdfMetadataInput
    {
        public DtoRequestV4031PdfMetadataInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }
    }

    public class DtoResponseV4042ProtectPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ProtectPdfDtoRequestInput
    {
        public ProtectPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }

        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3051ReadCode
    {
        [JsonProperty("codeValue")]
        public string CodeValue { get; set; }

        [JsonProperty("codeType")]
        public string CodeType { get; set; }
    }

    public class DtoRequestReadCodeDataInput
    {
        public DtoRequestReadCodeDataInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent qROrBarcode)
        {
            this.QROrBarcode = qROrBarcode;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent QROrBarcode { get; set; }
    }

    public class DtoResponseV2011RegularExpression
    {
        [JsonProperty("isMatch")]
        public bool IsMatch { get; set; }

        [JsonProperty("matches")]
        public JToken[] Matches { get; set; }

        [JsonProperty("firstMatch")]
        public JToken FirstMatch { get; set; }

        [JsonProperty("firstMatchValue")]
        public string FirstMatchValue { get; set; }
    }

    public class DtoRequestV2011RegularExpressionInput
    {
        public DtoRequestV2011RegularExpressionInput(string textToMatch)
        {
            this.TextToMatch = textToMatch;
        }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TextToMatch { get; set; }

        [JsonProperty("pattern")]
        public string RegularExpression { get; set; }

        [JsonProperty("option")]
        public string RegularExpressionOption { get; set; }
    }

    public class DtoResponseV4111RemovePagesFromPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class RemovePagesFromPdfDtoRequestInput
    {
        public RemovePagesFromPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pDF, string pages)
        {
            this.PDF = pDF;
            this.Pages = pages;
        }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDF { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; }

        [JsonProperty("oneBased")]
        public bool? InputIs1Based { get; set; }

        [JsonProperty("mode")]
        public int? Mode { get; set; }

        [JsonProperty("strict")]
        public bool? FailIfPageOutOfRange { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2110ReplaceTextWithPattern
    {
        [JsonProperty("text")]
        public string ReplacedText { get; set; }
    }

    public class DtoRequestV2110ReplaceTextWithPatternInput
    {
        public DtoRequestV2110ReplaceTextWithPatternInput(string inputText, string searchPattern)
        {
            this.InputText = inputText;
            this.SearchPattern = searchPattern;
        }

        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputText { get; set; }

        [JsonProperty("searchPattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchPattern { get; set; }

        [JsonProperty("replacementText")]
        public string ReplacementText { get; set; }
    }

    public class DtoResponseV3023ResizeImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class ResizeImageDtoRequestInput
    {
        public ResizeImageDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile)
        {
            this.ImageFile = imageFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("width")]
        public double? ImageWidth { get; set; }

        [JsonProperty("height")]
        public double? ImageHeight { get; set; }

        [JsonProperty("resizeBy")]
        public string ResizeBy { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV3032RotateImage
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class RotateImageDtoRequestInput
    {
        public RotateImageDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile)
        {
            this.ImageFile = imageFile;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("rotate")]
        public double? Rotate { get; set; }

        [JsonProperty("outFormat")]
        public string OutputFormat { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2151RunCode
    {
        [JsonProperty("result")]
        public string ResultResponse { get; set; }

        [JsonProperty("error")]
        public string ErrorMessage { get; set; }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }
    }

    public class DtoInput
    {
        public DtoInput(string pythonOrJavaScriptCode)
        {
            this.PythonOrJavaScriptCode = pythonOrJavaScriptCode;
        }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PythonOrJavaScriptCode { get; set; }

        [JsonProperty("runtime")]
        public int? Runtime { get; set; }

        [JsonProperty("timeoutSec")]
        public int? TimeoutSeconds { get; set; }

        [JsonProperty("printLastExpression")]
        public bool? PrintLastExpression { get; set; }
    }

    public class DtoResponseV2130SmartTextSplit
    {
        [JsonProperty("textSegments")]
        public string[] TextSegmentsAsList { get; set; }
    }

    public class DtoRequestV2130SmartTextSplitInput
    {
        public DtoRequestV2130SmartTextSplitInput(string inputText)
        {
            this.InputText = inputText;
        }

        [JsonProperty("inputText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputText { get; set; }

        [JsonProperty("splitPattern")]
        public string SplitPattern { get; set; }

        [JsonProperty("trimEnabled")]
        public bool? TrimEnabled { get; set; }

        [JsonProperty("trimStrings")]
        public string TrimStrings { get; set; }
    }

    public class DtoResponseV2061SortCsv
    {
        [JsonProperty("csv")]
        public string CSVResponse { get; set; }
    }

    public class DtoRequestV2061SortCsvInput
    {
        public DtoRequestV2061SortCsvInput(string cSV)
        {
            this.CSV = cSV;
        }

        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("dataIncludesHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CSVHasHeaders { get; set; } = true;

        [JsonProperty("autoDiscoverFieldTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectFieldTypes { get; set; } = false;

        [JsonProperty("maxScanRows")]
        public int? NumberOfRowsForFieldTypeDetection { get; set; }

        [JsonProperty("ignoreEmptyLine", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveEmptyRows { get; set; } = true;

        [JsonProperty("skip")]
        public int? SkipANumberOfRows { get; set; }

        [JsonProperty("skipLast")]
        public int? StopAtASpecificRow { get; set; }

        [JsonProperty("delimiter")]
        public string Separator { get; set; }

        [JsonProperty("mayHaveQuotedFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectQuoteDelimiter { get; set; } = true;

        [JsonProperty("sortColumn")]
        public string SortColumn { get; set; }

        [JsonProperty("secondSortColumn")]
        public string FurtherSortingColumn { get; set; }

        [JsonProperty("isReverse", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReverseOrder { get; set; } = false;
    }

    public class DtoResponseV2051SortJson
    {
        [JsonProperty("json")]
        public string JSONResponse { get; set; }
    }

    public class DtoRequestV2051SortJsonInput
    {
        public DtoRequestV2051SortJsonInput(string jSON)
        {
            this.JSON = jSON;
        }

        [JsonProperty("json", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JSON { get; set; }

        [JsonProperty("sortProperty")]
        public string SortProperty { get; set; }

        [JsonProperty("secondSortProperty")]
        public string FurtherSortingProperty { get; set; }

        [JsonProperty("isReverse", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReverseOrder { get; set; } = false;
    }

    public class DtoResponseV2041Translate
    {
        [JsonProperty("firstTranslation")]
        public string FirstTranslationResponse { get; set; }

        [JsonProperty("translations")]
        public string[] TranslationsResponse { get; set; }
    }

    public class DtoRequestV2041TranslateInput
    {
        public DtoRequestV2041TranslateInput(string text, string to)
        {
            this.Text = text;
            this.To = to;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }
    }

    public class DtoResponseV4052UnProtectPdf
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class UnProtectPdfDtoRequestInput
    {
        public UnProtectPdfDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file)
        {
            this.File = @file;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }

        [JsonProperty("removePermissions")]
        public bool? RemovePermissions { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5151UpdateMultipleWordContentControls
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class UpdateMultipleWordContentControlsDtoRequestInput
    {
        public UpdateMultipleWordContentControlsDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, ContentControl[] contentControl)
        {
            this.ExistingFileContent = existingFileContent;
            this.ContentControl = contentControl;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("contentControls", DefaultValueHandling = DefaultValueHandling.Include)]
        public ContentControl[] ContentControl { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class ContentControl
    {
        public ContentControl(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("searchBy")]
        public int? SearchBy { get; set; }
    }

    public class DtoResponseV5141UpdateWordContentControl
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class UpdateWordContentControlDtoRequestInput
    {
        public UpdateWordContentControlDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent, string name)
        {
            this.ExistingFileContent = existingFileContent;
            this.Name = name;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV5131UpdateWordTableOfContents
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class UpdateWordTableOfContentsDtoRequestInput
    {
        public UpdateWordTableOfContentsDtoRequestInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent existingFileContent)
        {
            this.ExistingFileContent = existingFileContent;
        }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ExistingFileContent { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }

    public class DtoResponseV2032UrlToFile
    {
        [JsonProperty("file")]
        public string FileResponse { get; set; }

        [JsonProperty("fileString")]
        public string FileResponseAsString { get; set; }

        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class UrlToFileDtoRequestInput
    {
        public UrlToFileDtoRequestInput(string uRL)
        {
            this.URL = uRL;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string URL { get; set; }

        [JsonProperty("fileResponseMode")]
        public int? ReduceResponseSize { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Converterbypower2apps;

    public partial class WorkflowManagedActions
    {
        public Converterbypower2appsActions Converterbypower2apps(string connectionId) => new Converterbypower2appsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Converterbypower2appsTriggers Converterbypower2apps(string connectionId) => new Converterbypower2appsTriggers(connectionId);
    }
}