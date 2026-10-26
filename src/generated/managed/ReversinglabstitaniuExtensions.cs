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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileReputationSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileReputationBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<GetFileReputationBulkInput>> body, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetHistoricalAvRecordsSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetHistoricalAvRecordsBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<GetHistoricalAvRecordsBulkInput>> body, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<GetFileAnalysisBulkInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisNonMaliciousSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileAnalysisNonMaliciousBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<GetFileAnalysisNonMaliciousBulkInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisSpecific(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> analysisId, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisArchiveMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDynamicAnalysisArchiveLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadSample(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSampleDownloadStatus(Expression<Func<postFormatInput>> postFormat, Expression<Func<GetSampleDownloadStatusInput>> body, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> deleteOn = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSamplesBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<DeleteSamplesBulkInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ReanalyzeSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ReanalyzeSampleBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<ReanalyzeSampleBulkInput>> body, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SubscribeToReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<SubscribeToReputationChangesInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> UnsubscribeFromReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<UnsubscribeFromReputationChangesInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SetStartTimeForReputationChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetReputationDataChanges(Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null, Expression<Func<int>> limit = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContinuousReputationDataChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitSampleForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<SubmitSampleForDynamicAnalysisInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitArchiveForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<SubmitArchiveForDynamicAnalysisInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchSha1FirstPage(Expression<Func<string>> uriSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchSha1Paging(Expression<Func<string>> uriSha1, Expression<Func<string>> nextPageSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> URIToHashSearchTextPaging(Expression<Func<string>> contentType, Expression<Func<formatInput>> format = null, Expression<Func<URIToHashSearchTextPagingInput>> body = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLReport(Expression<Func<formatInput>> format, Expression<Func<GetURLReportInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromURL(Expression<Func<formatInput>> format, Expression<Func<ListFilesFromURLInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetLatestURLAnalysesFirst(Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetLatestURLAnalysesPaging(Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTimestampedURLAnalysesFirst(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTimestampedURLAnalysesPaging(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AnalyzeURL(Expression<Func<formatInput>> format, Expression<Func<AnalyzeURLInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainReport(Expression<Func<formatInput>> format, Expression<Func<GetDomainReportInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromDomain(Expression<Func<formatInput>> format, Expression<Func<ListFilesFromDomainInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLFromDomain(Expression<Func<formatInput>> format, Expression<Func<GetURLFromDomainInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainResolutions(Expression<Func<formatInput>> format, Expression<Func<GetDomainResolutionsInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDomainRelatedDomains(Expression<Func<formatInput>> format, Expression<Func<GetDomainRelatedDomainsInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetIPAddressReport(Expression<Func<formatInput>> format, Expression<Func<GetIPAddressReportInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ListFilesFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<ListFilesFromIPAddressInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetURLFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<GetURLFromIPAddressInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetIPAddressResolutions(Expression<Func<formatInput>> format, Expression<Func<GetIPAddressResolutionsInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DailyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DailyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> MonthlyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> MonthlyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DateRangeAPIUsageUser(Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DateRangeAPIUsageCompany(Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetActiveYARARulesets(Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAPIQuotaLimitsUser(Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAPIQuotaLimitsCompany(Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> NetworkReputationApi(Expression<Func<postFormatInput>> postFormat, Expression<Func<NetworkReputationApiInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> NetworkReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<NetworkReputationUserOverrideInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSpecificDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSpecificDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateYaraRuleset(Expression<Func<CreateYaraRulesetInput>> body, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYaraRetroMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> StartYaraRetroHunt(Expression<Func<StartYaraRetroHuntInput>> body, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CancelYaraRetroHunt(Expression<Func<CancelYaraRetroHuntInput>> body, Expression<Func<string>> contentType = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AdvancedSearch(Expression<Func<AdvancedSearchInput>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/search/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupByRha1SingleQuery(Expression<Func<string>> rha1Type, Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null, Expression<Func<bool>> extended = null, Expression<Func<classificationInput>> classification = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ImportHashSimilarity(Expression<Func<string>> hashValue, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> ImportHashSimilarityPaginated(Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FileReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<FileReputationUserOverrideInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FileReputationListUserOverrides(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> startHash = null, Expression<Func<formatInput>> format = null)
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
    public enum hashTypeInput
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum postFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class GetFileReputationBulkInput
    {
        [JsonProperty("rl")]
        public GetFileReputationBulkInputRlType Rl { get; set; }
    }

    public class GetFileReputationBulkInputRlType
    {
        [JsonProperty("query")]
        public GetFileReputationBulkInputRlTypeQueryType Query { get; set; }
    }

    public class GetFileReputationBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public GetFileReputationBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetFileReputationBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class GetHistoricalAvRecordsBulkInput
    {
        [JsonProperty("rl")]
        public GetHistoricalAvRecordsBulkInputRlType Rl { get; set; }
    }

    public class GetHistoricalAvRecordsBulkInputRlType
    {
        [JsonProperty("query")]
        public GetHistoricalAvRecordsBulkInputRlTypeQueryType Query { get; set; }
    }

    public class GetHistoricalAvRecordsBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public GetHistoricalAvRecordsBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetHistoricalAvRecordsBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class GetFileAnalysisBulkInput
    {
        [JsonProperty("rl")]
        public GetFileAnalysisBulkInputRlType Rl { get; set; }
    }

    public class GetFileAnalysisBulkInputRlType
    {
        [JsonProperty("query")]
        public GetFileAnalysisBulkInputRlTypeQueryType Query { get; set; }
    }

    public class GetFileAnalysisBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public GetFileAnalysisBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetFileAnalysisBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class GetFileAnalysisNonMaliciousBulkInput
    {
        [JsonProperty("rl")]
        public GetFileAnalysisNonMaliciousBulkInputRlType Rl { get; set; }
    }

    public class GetFileAnalysisNonMaliciousBulkInputRlType
    {
        [JsonProperty("query")]
        public GetFileAnalysisNonMaliciousBulkInputRlTypeQueryType Query { get; set; }
    }

    public class GetFileAnalysisNonMaliciousBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public GetFileAnalysisNonMaliciousBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetFileAnalysisNonMaliciousBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class GetSampleDownloadStatusInput
    {
        [JsonProperty("rl")]
        public GetSampleDownloadStatusInputRlType Rl { get; set; }
    }

    public class GetSampleDownloadStatusInputRlType
    {
        [JsonProperty("query")]
        public GetSampleDownloadStatusInputRlTypeQueryType Query { get; set; }
    }

    public class GetSampleDownloadStatusInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public GetSampleDownloadStatusInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetSampleDownloadStatusInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class DeleteSamplesBulkInput
    {
        [JsonProperty("rl")]
        public DeleteSamplesBulkInputRlType Rl { get; set; }
    }

    public class DeleteSamplesBulkInputRlType
    {
        [JsonProperty("query")]
        public DeleteSamplesBulkInputRlTypeQueryType Query { get; set; }
    }

    public class DeleteSamplesBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public DeleteSamplesBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("delete_on")]
        public string DeleteOn { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteSamplesBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class ReanalyzeSampleBulkInput
    {
        [JsonProperty("rl")]
        public ReanalyzeSampleBulkInputRlType Rl { get; set; }
    }

    public class ReanalyzeSampleBulkInputRlType
    {
        [JsonProperty("query")]
        public ReanalyzeSampleBulkInputRlTypeQueryType Query { get; set; }
    }

    public class ReanalyzeSampleBulkInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public ReanalyzeSampleBulkInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReanalyzeSampleBulkInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class SubscribeToReputationChangesInput
    {
        [JsonProperty("rl")]
        public SubscribeToReputationChangesInputRlType Rl { get; set; }
    }

    public class SubscribeToReputationChangesInputRlType
    {
        [JsonProperty("query")]
        public SubscribeToReputationChangesInputRlTypeQueryType Query { get; set; }
    }

    public class SubscribeToReputationChangesInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public SubscribeToReputationChangesInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscribeToReputationChangesInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public class UnsubscribeFromReputationChangesInput
    {
        [JsonProperty("rl")]
        public UnsubscribeFromReputationChangesInputRlType Rl { get; set; }
    }

    public class UnsubscribeFromReputationChangesInputRlType
    {
        [JsonProperty("query")]
        public UnsubscribeFromReputationChangesInputRlTypeQueryType Query { get; set; }
    }

    public class UnsubscribeFromReputationChangesInputRlTypeQueryType
    {
        [JsonProperty("hash_type")]
        public UnsubscribeFromReputationChangesInputRlTypeQueryTypeHashTypeType? HashType { get; set; }

        [JsonProperty("hashes")]
        public string[] Hashes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnsubscribeFromReputationChangesInputRlTypeQueryTypeHashTypeType
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum timeFormatInput
    {
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "utc")]
        Utc
    }

    public class SubmitSampleForDynamicAnalysisInput
    {
        [JsonProperty("rl")]
        public SubmitSampleForDynamicAnalysisInputRlType Rl { get; set; }
    }

    public class SubmitSampleForDynamicAnalysisInputRlType
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubmitSampleForDynamicAnalysisInputRlTypeResponseFormatType? ResponseFormat { get; set; } = SubmitSampleForDynamicAnalysisInputRlTypeResponseFormatType.Json;

        [JsonProperty("optional_parameters")]
        public string OptionalParameters { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubmitSampleForDynamicAnalysisInputRlTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class SubmitArchiveForDynamicAnalysisInput
    {
        [JsonProperty("rl")]
        public SubmitArchiveForDynamicAnalysisInputRlType Rl { get; set; }
    }

    public class SubmitArchiveForDynamicAnalysisInputRlType
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

    public class URIToHashSearchTextPagingInput
    {
        [JsonProperty("rl")]
        public URIToHashSearchTextPagingInputRlType Rl { get; set; }
    }

    public class URIToHashSearchTextPagingInputRlType
    {
        [JsonProperty("query")]
        public URIToHashSearchTextPagingInputRlTypeQueryType Query { get; set; }
    }

    public class URIToHashSearchTextPagingInputRlTypeQueryType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("next_page_sha1")]
        public string NextPageSha1 { get; set; }
    }

    public class GetURLReportInput
    {
        [JsonProperty("rl")]
        public GetURLReportInputRlType Rl { get; set; }
    }

    public class GetURLReportInputRlType
    {
        [JsonProperty("query")]
        public GetURLReportInputRlTypeQueryType Query { get; set; }
    }

    public class GetURLReportInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("response_format")]
        public GetURLReportInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetURLReportInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class ListFilesFromURLInput
    {
        [JsonProperty("rl")]
        public ListFilesFromURLInputRlType Rl { get; set; }
    }

    public class ListFilesFromURLInputRlType
    {
        [JsonProperty("query")]
        public ListFilesFromURLInputRlTypeQueryType Query { get; set; }
    }

    public class ListFilesFromURLInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("analysis_id")]
        public string AnalysisId { get; set; }

        [JsonProperty("last_analysis")]
        public bool? LastAnalysis { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromURLInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = ListFilesFromURLInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListFilesFromURLInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class AnalyzeURLInput
    {
        [JsonProperty("rl")]
        public AnalyzeURLInputRlType Rl { get; set; }
    }

    public class AnalyzeURLInputRlType
    {
        [JsonProperty("query")]
        public AnalyzeURLInputRlTypeQueryType Query { get; set; }
    }

    public class AnalyzeURLInputRlTypeQueryType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public AnalyzeURLInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = AnalyzeURLInputRlTypeQueryTypeResponseFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AnalyzeURLInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetDomainReportInput
    {
        [JsonProperty("rl")]
        public GetDomainReportInputRlType Rl { get; set; }
    }

    public class GetDomainReportInputRlType
    {
        [JsonProperty("query")]
        public GetDomainReportInputRlTypeQueryType Query { get; set; }
    }

    public class GetDomainReportInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainReportInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetDomainReportInputRlTypeQueryTypeResponseFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetDomainReportInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class ListFilesFromDomainInput
    {
        [JsonProperty("rl")]
        public ListFilesFromDomainInputRlType Rl { get; set; }
    }

    public class ListFilesFromDomainInputRlType
    {
        [JsonProperty("query")]
        public ListFilesFromDomainInputRlTypeQueryType Query { get; set; }
    }

    public class ListFilesFromDomainInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromDomainInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = ListFilesFromDomainInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListFilesFromDomainInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetURLFromDomainInput
    {
        [JsonProperty("rl")]
        public GetURLFromDomainInputRlType Rl { get; set; }
    }

    public class GetURLFromDomainInputRlType
    {
        [JsonProperty("query")]
        public GetURLFromDomainInputRlTypeQueryType Query { get; set; }
    }

    public class GetURLFromDomainInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetURLFromDomainInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetURLFromDomainInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetURLFromDomainInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetDomainResolutionsInput
    {
        [JsonProperty("rl")]
        public GetDomainResolutionsInputRlType Rl { get; set; }
    }

    public class GetDomainResolutionsInputRlType
    {
        [JsonProperty("query")]
        public GetDomainResolutionsInputRlTypeQueryType Query { get; set; }
    }

    public class GetDomainResolutionsInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainResolutionsInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetDomainResolutionsInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetDomainResolutionsInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetDomainRelatedDomainsInput
    {
        [JsonProperty("rl")]
        public GetDomainRelatedDomainsInputRlType Rl { get; set; }
    }

    public class GetDomainRelatedDomainsInputRlType
    {
        [JsonProperty("query")]
        public GetDomainRelatedDomainsInputRlTypeQueryType Query { get; set; }
    }

    public class GetDomainRelatedDomainsInputRlTypeQueryType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetDomainRelatedDomainsInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetDomainRelatedDomainsInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetDomainRelatedDomainsInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetIPAddressReportInput
    {
        [JsonProperty("rl")]
        public GetIPAddressReportInputRlType Rl { get; set; }
    }

    public class GetIPAddressReportInputRlType
    {
        [JsonProperty("query")]
        public GetIPAddressReportInputRlTypeQueryType Query { get; set; }
    }

    public class GetIPAddressReportInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressReportInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetIPAddressReportInputRlTypeQueryTypeResponseFormatType.Json;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetIPAddressReportInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class ListFilesFromIPAddressInput
    {
        [JsonProperty("rl")]
        public ListFilesFromIPAddressInputRlType Rl { get; set; }
    }

    public class ListFilesFromIPAddressInputRlType
    {
        [JsonProperty("query")]
        public ListFilesFromIPAddressInputRlTypeQueryType Query { get; set; }
    }

    public class ListFilesFromIPAddressInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListFilesFromIPAddressInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = ListFilesFromIPAddressInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("extended")]
        public bool? Extended { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListFilesFromIPAddressInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetURLFromIPAddressInput
    {
        [JsonProperty("rl")]
        public GetURLFromIPAddressInputRlType Rl { get; set; }
    }

    public class GetURLFromIPAddressInputRlType
    {
        [JsonProperty("query")]
        public GetURLFromIPAddressInputRlTypeQueryType Query { get; set; }
    }

    public class GetURLFromIPAddressInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetURLFromIPAddressInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetURLFromIPAddressInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetURLFromIPAddressInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class GetIPAddressResolutionsInput
    {
        [JsonProperty("rl")]
        public GetIPAddressResolutionsInputRlType Rl { get; set; }
    }

    public class GetIPAddressResolutionsInputRlType
    {
        [JsonProperty("query")]
        public GetIPAddressResolutionsInputRlTypeQueryType Query { get; set; }
    }

    public class GetIPAddressResolutionsInputRlTypeQueryType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetIPAddressResolutionsInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = GetIPAddressResolutionsInputRlTypeQueryTypeResponseFormatType.Json;

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetIPAddressResolutionsInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    public class NetworkReputationApiInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiInputRlType Rl { get; set; }
    }

    public class NetworkReputationApiInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiInputRlTypeQueryType Query { get; set; }
    }

    public class NetworkReputationApiInputRlTypeQueryType
    {
        [JsonProperty("network_locations", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiInputRlTypeQueryTypeNetworkLocationsTypeItem[] NetworkLocations { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationApiInputRlTypeQueryTypeResponseFormatType? ResponseFormat { get; set; } = NetworkReputationApiInputRlTypeQueryTypeResponseFormatType.Json;
    }

    public class NetworkReputationApiInputRlTypeQueryTypeNetworkLocationsTypeItem
    {
        [JsonProperty("network_location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NetworkLocation { get; set; }

        [JsonProperty("type")]
        public NetworkReputationApiInputRlTypeQueryTypeNetworkLocationsTypeItemTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NetworkReputationApiInputRlTypeQueryTypeNetworkLocationsTypeItemTypeType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "ip")]
        Ip,
        [EnumMember(Value = "domain")]
        Domain
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NetworkReputationApiInputRlTypeQueryTypeResponseFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class NetworkReputationUserOverrideInput
    {
        [JsonProperty("rl", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideInputRlType Rl { get; set; }
    }

    public class NetworkReputationUserOverrideInputRlType
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideInputRlTypeQueryType Query { get; set; }

        [JsonProperty("response_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseFormat { get; set; } = "json";
    }

    public class NetworkReputationUserOverrideInputRlTypeQueryType
    {
        [JsonProperty("user_override", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideType UserOverride { get; set; }
    }

    public class NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideType
    {
        [JsonProperty("override_network_locations", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem[] OverrideNetworkLocations { get; set; }
    }

    public class NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItem
    {
        [JsonProperty("network_location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NetworkLocation { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItemTypeType Type { get; set; }

        [JsonProperty("classification", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Classification { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NetworkReputationUserOverrideInputRlTypeQueryTypeUserOverrideTypeOverrideNetworkLocationsTypeItemTypeType
    {
        [EnumMember(Value = "url")]
        Url
    }

    public class CreateYaraRulesetInput
    {
        [JsonProperty("ruleset_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RulesetName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("sample_available", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SampleAvailable { get; set; }
    }

    public class StartYaraRetroHuntInput
    {
        [JsonProperty("ruleset_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RulesetName { get; set; }
    }

    public class CancelYaraRetroHuntInput
    {
        [JsonProperty("ruleset_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RulesetName { get; set; }
    }

    public class AdvancedSearchInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public AdvancedSearchInputQueryTypeItem[] Query { get; set; }

        [JsonProperty("format")]
        public AdvancedSearchInputFormatType? Format { get; set; }

        [JsonProperty("records_per_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RecordsPerPage { get; set; } = 1000;

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty("sort", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sort { get; set; } = "firstseen desc";
    }

    public class AdvancedSearchInputQueryTypeItem
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("criteria", DefaultValueHandling = DefaultValueHandling.Include)]
        public AdvancedSearchInputQueryTypeItemCriteriaType Criteria { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AdvancedSearchInputQueryTypeItemCriteriaType
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
    public enum AdvancedSearchInputFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum classificationInput
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

    public class FileReputationUserOverrideInput
    {
        [JsonProperty("rl")]
        public FileReputationUserOverrideInputRlType Rl { get; set; }
    }

    public class FileReputationUserOverrideInputRlType
    {
        [JsonProperty("query")]
        public FileReputationUserOverrideInputRlTypeQueryType Query { get; set; }
    }

    public class FileReputationUserOverrideInputRlTypeQueryType
    {
        [JsonProperty("override_samples")]
        public FileReputationUserOverrideInputRlTypeQueryTypeOverrideSamplesTypeItem[] OverrideSamples { get; set; }

        [JsonProperty("remove_override")]
        public FileReputationUserOverrideInputRlTypeQueryTypeRemoveOverrideTypeItem[] RemoveOverride { get; set; }
    }

    public class FileReputationUserOverrideInputRlTypeQueryTypeOverrideSamplesTypeItem
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

    public class FileReputationUserOverrideInputRlTypeQueryTypeRemoveOverrideTypeItem
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