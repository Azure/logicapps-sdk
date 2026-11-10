//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReversinglabstitaniuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileReputationSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_showHashes = WorkflowExpression.Compile(showHashes, nameof(showHashes), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["extended"] = Convert.ToString(true);
                if (__workflow_extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(__workflow_extended);
                callPayload.Queries["show_hashes"] = Convert.ToString(true);
                if (__workflow_showHashes != null)
                    callPayload.Queries["show_hashes"] = ExpressionConverter.Convert(__workflow_showHashes);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileReputationBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_showHashes = WorkflowExpression.Compile(showHashes, nameof(showHashes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(__workflow_extended);
                if (__workflow_showHashes != null)
                    callPayload.Queries["show_hashes"] = ExpressionConverter.Convert(__workflow_showHashes);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetHistoricalAvRecordsSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> history = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_history = WorkflowExpression.Compile(history, nameof(history), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/xref/v2/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["history"] = Convert.ToString(false);
                if (__workflow_history != null)
                    callPayload.Queries["history"] = ExpressionConverter.Convert(__workflow_history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetHistoricalAvRecordsBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body, Expression<Func<bool>> history = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_history = WorkflowExpression.Compile(history, nameof(history), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/xref/v2/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_history != null)
                    callPayload.Queries["history"] = ExpressionConverter.Convert(__workflow_history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisNonMaliciousSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/goodware/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisNonMaliciousBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/goodware/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisMerged(Expression<Func<GetDynamicAnalysisArchiveLatestHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisLatest(Expression<Func<GetDynamicAnalysisArchiveLatestHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/latest", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisSpecific(Expression<Func<GetDynamicAnalysisArchiveLatestHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> analysisId, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_analysisId = WorkflowExpression.Compile(analysisId, nameof(analysisId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/{2}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1), __workflow_analysisId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisArchiveMerged(Expression<Func<GetDynamicAnalysisArchiveLatestHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisArchiveLatest(Expression<Func<GetDynamicAnalysisArchiveLatestHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}/latest", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadSample(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/download/v2/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSampleDownloadStatus(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/download/v2/status/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/octet-stream");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadSample(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType, Expression<Func<object>> body)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/upload/{0}", __workflow_sha1Value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadSampleMetadata(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType, Expression<Func<string>> body, Expression<Func<string>> subscribe = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_subscribe = WorkflowExpression.Compile(subscribe, nameof(subscribe), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/upload/{0}/meta", __workflow_sha1Value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_subscribe != null)
                    callPayload.Queries["subscribe"] = ExpressionConverter.Convert(__workflow_subscribe);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSampleSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> deleteOn = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_deleteOn = WorkflowExpression.Compile(deleteOn, nameof(deleteOn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/delete/sample/v1/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deleteOn != null)
                    callPayload.Queries["delete_on"] = ExpressionConverter.Convert(__workflow_deleteOn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSamplesBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<DeleteSamplesBulkBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/delete/sample/v1/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReanalyzeSampleSingle(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rescan/v1/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReanalyzeSampleBulk(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rescan/v1/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubscribeToReputationChanges(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/subscription/data_change/v1/bulk_query/subscribe/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnsubscribeFromReputationChanges(Expression<Func<PostFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/subscription/data_change/v1/bulk_query/unsubscribe/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetStartTimeForReputationChanges(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> timeValue)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/feed/data_change/v3/start/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_timeValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetReputationDataChanges(Expression<Func<GetReputationDataChangesFormatInput>> format = null, Expression<Func<string>> events = null, Expression<Func<int>> limit = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/feed/data_change/v3/pull";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_events != null)
                    callPayload.Queries["events"] = ExpressionConverter.Convert(__workflow_events);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContinuousReputationDataChanges(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> events = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/feed/data_change/v3/query/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_timeValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_events != null)
                    callPayload.Queries["events"] = ExpressionConverter.Convert(__workflow_events);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitSampleForDynamicAnalysis(Expression<Func<PostFormatInput>> postFormat, Expression<Func<SubmitSampleForDynamicAnalysisBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/analyze/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitArchiveForDynamicAnalysis(Expression<Func<PostFormatInput>> postFormat, Expression<Func<SubmitArchiveForDynamicAnalysisBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/analyze/v1/archive/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchSha1FirstPage(Expression<Func<string>> uriSha1, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var __workflow_uriSha1 = WorkflowExpression.Compile(uriSha1, nameof(uriSha1), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/uri_index/v1/query/{0}", __workflow_uriSha1.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(__workflow_classification);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchSha1Paging(Expression<Func<string>> uriSha1, Expression<Func<string>> nextPageSha1, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var __workflow_uriSha1 = WorkflowExpression.Compile(uriSha1, nameof(uriSha1), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/uri_index/v1/query/{0}/{1}", __workflow_uriSha1.WithUrlEncoding(1), __workflow_nextPageSha1.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(__workflow_classification);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchTextPaging(Expression<Func<string>> contentType, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<URIToHashSearchTextPagingBodyInput>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/uri_index/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLReport(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetURLReportBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/report/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromURL(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<ListFilesFromURLBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/downloaded_files/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetLatestURLAnalysesFirst(Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/networking/url/v1/notifications/query/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetLatestURLAnalysesPaging(Expression<Func<string>> page, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/notifications/query/latest/page/{0}", __workflow_page.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTimestampedURLAnalysesFirst(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_startTime.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTimestampedURLAnalysesPaging(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<string>> page, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}/page/{2}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_startTime.WithUrlEncoding(1), __workflow_page.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AnalyzeURL(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<AnalyzeURLBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/analyze/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainReport(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetDomainReportBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/report/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromDomain(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<ListFilesFromDomainBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/downloaded_files/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLFromDomain(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetDomainRelatedDomainsBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/urls/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainResolutions(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetDomainRelatedDomainsBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/resolutions/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainRelatedDomains(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetDomainRelatedDomainsBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/related_domains/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetIPAddressReport(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetIPAddressReportBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/report/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromIPAddress(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<ListFilesFromIPAddressBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/downloaded_files/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLFromIPAddress(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetIPAddressResolutionsBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/urls/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetIPAddressResolutions(Expression<Func<AnalyzeURLFormatInput>> format, Expression<Func<GetIPAddressResolutionsBodyInput>> body)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/resolutions/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DailyAPIUsageUser(Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DailyAPIUsageCompany(Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MonthlyAPIUsageUser(Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MonthlyAPIUsageCompany(Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DateRangeAPIUsageUser(Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DateRangeAPIUsageCompany(Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetActiveYARARulesets(Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/yara";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAPIQuotaLimitsUser(Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/limits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAPIQuotaLimitsCompany(Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/limits/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NetworkReputationApi(Expression<Func<PostFormatInput>> postFormat, Expression<Func<NetworkReputationApiBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/reputation/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListUserOverride(Expression<Func<string>> format = null, Expression<Func<string>> nextNetworkLocation = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_nextNetworkLocation = WorkflowExpression.Compile(nextNetworkLocation, nameof(nextNetworkLocation), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/networking/user_override/v1/query/list_overrides";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_nextNetworkLocation != null)
                    callPayload.Queries["next_network_location"] = ExpressionConverter.Convert(__workflow_nextNetworkLocation);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NetworkReputationUserOverride(Expression<Func<PostFormatInput>> postFormat, Expression<Func<NetworkReputationUserOverrideBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/user_override/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSpecificDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> specificReport, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_specificReport = WorkflowExpression.Compile(specificReport, nameof(specificReport), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/{1}", __workflow_sha1Value.WithUrlEncoding(1), __workflow_specificReport.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSpecificDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> specificReport, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_base64Value = WorkflowExpression.Compile(base64Value, nameof(base64Value), required: true);
            var __workflow_specificReport = WorkflowExpression.Compile(specificReport, nameof(specificReport), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/{1}", __workflow_base64Value.WithUrlEncoding(1), __workflow_specificReport.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/latest", __workflow_sha1Value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> contentType = null)
        {
            var __workflow_base64Value = WorkflowExpression.Compile(base64Value, nameof(base64Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/latest", __workflow_base64Value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraRulesetInformation(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteYaraRuleset(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraRulesetText(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}/text", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraMatchesFeed(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/feed/yara/v1/query/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_timeValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateYaraRuleset(Expression<Func<CreateYaraRulesetBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraRetroHuntingStatus(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}/status-retro-hunt", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraRetroMatchesFeed(Expression<Func<TimeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/feed/yara/retro/v1/query/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_timeValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StartYaraRetroHunt(Expression<Func<CancelYaraRetroHuntBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/start-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CancelYaraRetroHunt(Expression<Func<CancelYaraRetroHuntBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/cancel-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AdvancedSearch(Expression<Func<AdvancedSearchBodyInput>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/search/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupByRha1SingleQuery(Expression<Func<string>> rha1Type, Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<AnalyzeURLFormatInput>> format = null, Expression<Func<int>> limit = null, Expression<Func<bool>> extended = null, Expression<Func<ClassificationInput>> classification = null)
        {
            var __workflow_rha1Type = WorkflowExpression.Compile(rha1Type, nameof(rha1Type), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/group_by_rha1/v1/query/{0}/{1}/{2}", __workflow_rha1Type.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1), __workflow_nextPageSha1.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["extended"] = Convert.ToString(false);
                if (__workflow_extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(__workflow_extended);
                if (__workflow_classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(__workflow_classification);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ImportHashSimilarity(Expression<Func<string>> hashValue, Expression<Func<string>> contentType = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/imphash_index/v1/query/{0}", __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ImportHashSimilarityPaginated(Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/imphash_index/v1/query/{0}/start_sha1/{1}", __workflow_hashValue.WithUrlEncoding(1), __workflow_nextPageSha1.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FileReputationUserOverride(Expression<Func<PostFormatInput>> postFormat, Expression<Func<FileReputationUserOverrideBodyInput>> body)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/user_override/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FileReputationListUserOverrides(Expression<Func<DeleteSampleSingleHashTypeInput>> hashType, Expression<Func<string>> startHash = null, Expression<Func<AnalyzeURLFormatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_startHash = WorkflowExpression.Compile(startHash, nameof(startHash), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/user_override/list_hashes/{0}", __workflow_hashType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startHash != null)
                    callPayload.Queries["start_hash"] = ExpressionConverter.Convert(__workflow_startHash);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ReversinglabstitaniuTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteSampleSingleHashTypeInput
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AnalyzeURLFormatInput
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class GetFileAnalysisBulkBodyInput
    {
        [JsonProperty("rl")]
        public GetFileAnalysisBulkBodyInputRlType Rl { get; set; }
    }

    public class GetFileAnalysisBulkBodyInputRlType
    {
        [JsonProperty("query")]
        public GetFileAnalysisBulkBodyInputRlTypeQueryType Query { get; set; }
    }

    public class GetFileAnalysisBulkBodyInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public BodyInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetDynamicAnalysisArchiveLatestHashTypeInput
    {
        [EnumMember(Value = "sha1")]
        Sha1
    }

    public class DeleteSamplesBulkBodyInput
    {
        [JsonProperty("rl")]
        public DeleteSamplesBulkBodyInputRlType Rl { get; set; }
    }

    public class DeleteSamplesBulkBodyInputRlType
    {
        [JsonProperty("query")]
        public DeleteSamplesBulkBodyInputRlTypeQueryType Query { get; set; }
    }

    public class DeleteSamplesBulkBodyInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public BodyInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("delete_on")]
        public string DeleteOn { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeFormatInput
    {
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "utc")]
        Utc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetReputationDataChangesFormatInput
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "tsv")]
        Tsv
    }

    public class SubmitSampleForDynamicAnalysisBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubmitSampleForDynamicAnalysisBodyInputRlType Rl { get; set; } = new SubmitSampleForDynamicAnalysisBodyInputRlType();
    }

    public class SubmitSampleForDynamicAnalysisBodyInputRlType
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeResponseFormatType.Json;

        [JsonProperty("optional_parameters")]
        public string OptionalParameters { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRlTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class SubmitArchiveForDynamicAnalysisBodyInput
    {
        [JsonProperty("rl")]
        public SubmitArchiveForDynamicAnalysisBodyInputRlType Rl { get; set; }
    }

    public class SubmitArchiveForDynamicAnalysisBodyInputRlType
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("response_format")]
        public string ResponseFormat { get; set; }

        [JsonProperty("optional_parameters")]
        public string OptionalParameters { get; set; }
    }

    public class URIToHashSearchTextPagingBodyInput
    {
        [JsonProperty("rl")]
        public URIToHashSearchTextPagingBodyInputRlType Rl { get; set; }
    }

    public class URIToHashSearchTextPagingBodyInputRlType
    {
        [JsonProperty("query")]
        public URIToHashSearchTextPagingBodyInputRlTypeQueryType Query { get; set; }
    }

    public class URIToHashSearchTextPagingBodyInputRlTypeQueryType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("next_page_sha1")]
        public string NextPageSha1 { get; set; }
    }

    public class GetURLReportBodyInput
    {
        [JsonProperty("rl")]
        public GetURLReportBodyInputRlType Rl { get; set; }
    }

    public class GetURLReportBodyInputRlType
    {
        [JsonProperty("query")]
        public GetURLReportBodyInputRlTypeQueryType Query { get; set; }
    }

    public class GetURLReportBodyInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("response_format")]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class ListFilesFromURLBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromURLBodyInputRlType Rl { get; set; } = new ListFilesFromURLBodyInputRlType();
    }

    public class ListFilesFromURLBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromURLBodyInputRlTypeQueryType Query { get; set; } = new ListFilesFromURLBodyInputRlTypeQueryType();
    }

    public class ListFilesFromURLBodyInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("analysis_id")]
        public string AnalysisId { get; set; }

        [JsonProperty("last_analysis")]
        public bool? LastAnalysis { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    public class AnalyzeURLBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public AnalyzeURLBodyInputRlType Rl { get; set; } = new AnalyzeURLBodyInputRlType();
    }

    public class AnalyzeURLBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public AnalyzeURLBodyInputRlTypeQueryType Query { get; set; } = new AnalyzeURLBodyInputRlTypeQueryType();
    }

    public class AnalyzeURLBodyInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;
    }

    public class GetDomainReportBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainReportBodyInputRlType Rl { get; set; } = new GetDomainReportBodyInputRlType();
    }

    public class GetDomainReportBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainReportBodyInputRlTypeQueryType Query { get; set; } = new GetDomainReportBodyInputRlTypeQueryType();
    }

    public class GetDomainReportBodyInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;
    }

    public class ListFilesFromDomainBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromDomainBodyInputRlType Rl { get; set; } = new ListFilesFromDomainBodyInputRlType();
    }

    public class ListFilesFromDomainBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromDomainBodyInputRlTypeQueryType Query { get; set; } = new ListFilesFromDomainBodyInputRlTypeQueryType();
    }

    public class ListFilesFromDomainBodyInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    public class GetDomainRelatedDomainsBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainRelatedDomainsBodyInputRlType Rl { get; set; } = new GetDomainRelatedDomainsBodyInputRlType();
    }

    public class GetDomainRelatedDomainsBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainRelatedDomainsBodyInputRlTypeQueryType Query { get; set; } = new GetDomainRelatedDomainsBodyInputRlTypeQueryType();
    }

    public class GetDomainRelatedDomainsBodyInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    public class GetIPAddressReportBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressReportBodyInputRlType Rl { get; set; } = new GetIPAddressReportBodyInputRlType();
    }

    public class GetIPAddressReportBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressReportBodyInputRlTypeQueryType Query { get; set; } = new GetIPAddressReportBodyInputRlTypeQueryType();
    }

    public class GetIPAddressReportBodyInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;
    }

    public class ListFilesFromIPAddressBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromIPAddressBodyInputRlType Rl { get; set; } = new ListFilesFromIPAddressBodyInputRlType();
    }

    public class ListFilesFromIPAddressBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromIPAddressBodyInputRlTypeQueryType Query { get; set; } = new ListFilesFromIPAddressBodyInputRlTypeQueryType();
    }

    public class ListFilesFromIPAddressBodyInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    public class GetIPAddressResolutionsBodyInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressResolutionsBodyInputRlType Rl { get; set; } = new GetIPAddressResolutionsBodyInputRlType();
    }

    public class GetIPAddressResolutionsBodyInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressResolutionsBodyInputRlTypeQueryType Query { get; set; } = new GetIPAddressResolutionsBodyInputRlTypeQueryType();
    }

    public class GetIPAddressResolutionsBodyInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    public class NetworkReputationApiBodyInput
    {
        public NetworkReputationApiBodyInput(NetworkReputationApiBodyInputRlType rl)
        {
            this.Rl = rl;
        }

        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiBodyInputRlType Rl { get; set; }
    }

    public class NetworkReputationApiBodyInputRlType
    {
        public NetworkReputationApiBodyInputRlType(NetworkReputationApiBodyInputRlTypeQueryType query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiBodyInputRlTypeQueryType Query { get; set; }
    }

    public class NetworkReputationApiBodyInputRlTypeQueryType
    {
        public NetworkReputationApiBodyInputRlTypeQueryType(BodyInputRlTypeQueryTypeNetworkLocationsTypeItem[] networkLocations)
        {
            this.NetworkLocations = networkLocations;
        }

        [JsonProperty("network_locations", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeNetworkLocationsTypeItem[] NetworkLocations { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu.BodyInputRlTypeQueryTypeResponseFormatType.Json;
    }

    public class BodyInputRlTypeQueryTypeNetworkLocationsTypeItem
    {
        public BodyInputRlTypeQueryTypeNetworkLocationsTypeItem(string networkLocation)
        {
            this.NetworkLocation = networkLocation;
        }

        [JsonProperty("network_location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NetworkLocation { get; set; }

        [JsonProperty("type")]
        public BodyInputRlTypeQueryTypeNetworkLocationsTypeItemTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRlTypeQueryTypeNetworkLocationsTypeItemTypeType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "ip")]
        Ip,
        [EnumMember(Value = "domain")]
        Domain
    }

    public class NetworkReputationUserOverrideBodyInput
    {
        public NetworkReputationUserOverrideBodyInput(NetworkReputationUserOverrideBodyInputRlType rl)
        {
            this.Rl = rl;
        }

        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideBodyInputRlType Rl { get; set; }
    }

    public class NetworkReputationUserOverrideBodyInputRlType
    {
        public NetworkReputationUserOverrideBodyInputRlType(NetworkReputationUserOverrideBodyInputRlTypeQueryType query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideBodyInputRlTypeQueryType Query { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseFormat { get; set; } = "json";
    }

    public class NetworkReputationUserOverrideBodyInputRlTypeQueryType
    {
        public NetworkReputationUserOverrideBodyInputRlTypeQueryType(BodyInputRlTypeQueryTypeUserOverrideType userOverride)
        {
            this.UserOverride = userOverride;
        }

        [JsonProperty("user_override", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeUserOverrideType UserOverride { get; set; }
    }

    public class BodyInputRlTypeQueryTypeUserOverrideType
    {
        public BodyInputRlTypeQueryTypeUserOverrideType(BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem[] overrideNetworkLocations)
        {
            this.OverrideNetworkLocations = overrideNetworkLocations;
        }

        [JsonProperty("override_network_locations", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem[] OverrideNetworkLocations { get; set; }
    }

    public class BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem
    {
        public BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem(string networkLocation, BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItemTypeType type, string classification)
        {
            this.NetworkLocation = networkLocation;
            this.Type = type;
            this.Classification = classification;
        }

        [JsonProperty("network_location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NetworkLocation { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItemTypeType Type { get; set; }

        [JsonProperty("classification", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Classification { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItemTypeType
    {
        [EnumMember(Value = "url")]
        Url
    }

    public class CreateYaraRulesetBodyInput
    {
        public CreateYaraRulesetBodyInput(string rulesetName, string text, bool sampleAvailable)
        {
            this.RulesetName = rulesetName;
            this.Text = text;
            this.SampleAvailable = sampleAvailable;
        }

        [JsonProperty("ruleset_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RulesetName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("sample_available", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SampleAvailable { get; set; }
    }

    public class CancelYaraRetroHuntBodyInput
    {
        public CancelYaraRetroHuntBodyInput(string rulesetName)
        {
            this.RulesetName = rulesetName;
        }

        [JsonProperty("ruleset_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RulesetName { get; set; }
    }

    public class AdvancedSearchBodyInput
    {
        public AdvancedSearchBodyInput(BodyInputQueryTypeItem[] query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQueryTypeItem[] Query { get; set; }

        [JsonProperty("format")]
        public BodyInputFormatType? Format { get; set; }

        [JsonProperty("records_per_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RecordsPerPage { get; set; } = 1000;

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty("sort", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sort { get; set; } = "firstseen desc";
    }

    public class BodyInputQueryTypeItem
    {
        public BodyInputQueryTypeItem(string name, BodyInputQueryTypeItemCriteriaType criteria, string value)
        {
            this.Name = name;
            this.Criteria = criteria;
            this.Value = value;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("criteria", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQueryTypeItemCriteriaType Criteria { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputQueryTypeItemCriteriaType
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "neq")]
        Neq,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "gte")]
        Gte,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "lte")]
        Lte,
        [EnumMember(Value = "range")]
        Range,
        [EnumMember(Value = "in")]
        In,
        [EnumMember(Value = "nin")]
        Nin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ClassificationInput
    {
        [EnumMember(Value = "known")]
        Known,
        [EnumMember(Value = "malicious")]
        Malicious,
        [EnumMember(Value = "suspicious")]
        Suspicious,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public class FileReputationUserOverrideBodyInput
    {
        [JsonProperty("rl")]
        public FileReputationUserOverrideBodyInputRlType Rl { get; set; }
    }

    public class FileReputationUserOverrideBodyInputRlType
    {
        [JsonProperty("query")]
        public FileReputationUserOverrideBodyInputRlTypeQueryType Query { get; set; }
    }

    public class FileReputationUserOverrideBodyInputRlTypeQueryType
    {
        [JsonProperty("override_samples")]
        public BodyInputRlTypeQueryTypeOverrideSamplesTypeItem[] OverrideSamples { get; set; }

        [JsonProperty("remove_override")]
        public BodyInputRlTypeQueryTypeRemoveOverrideTypeItem[] RemoveOverride { get; set; }
    }

    public class BodyInputRlTypeQueryTypeOverrideSamplesTypeItem
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("trust_factor")]
        public int? TrustFactor { get; set; }

        [JsonProperty("threat_level")]
        public int? ThreatLevel { get; set; }

        [JsonProperty("threat_name")]
        public string ThreatName { get; set; }
    }

    public class BodyInputRlTypeQueryTypeRemoveOverrideTypeItem
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu;

    public partial class WorkflowManagedActions
    {
        public ReversinglabstitaniuActions Reversinglabstitaniu(string connectionId) => new ReversinglabstitaniuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReversinglabstitaniuTriggers Reversinglabstitaniu(string connectionId) => new ReversinglabstitaniuTriggers(connectionId);
    }
}