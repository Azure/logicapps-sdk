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
        public IWorkflowAction GetFileReputationSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_showHashes = WorkflowExpression.Compile(showHashes, nameof(showHashes), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetFileReputationBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_showHashes = WorkflowExpression.Compile(showHashes, nameof(showHashes), required: false);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(__workflow_extended);
                if (__workflow_showHashes != null)
                    callPayload.Queries["show_hashes"] = ExpressionConverter.Convert(__workflow_showHashes);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetHistoricalAvRecordsSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_history = WorkflowExpression.Compile(history, nameof(history), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetHistoricalAvRecordsBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_history = WorkflowExpression.Compile(history, nameof(history), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/xref/v2/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_history != null)
                    callPayload.Queries["history"] = ExpressionConverter.Convert(__workflow_history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetFileAnalysisBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/goodware/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/rldata/goodware/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisSpecific(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> analysisId, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_analysisId = WorkflowExpression.Compile(analysisId, nameof(analysisId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisArchiveMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisArchiveLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DownloadSample(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/download/v2/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSampleDownloadStatus(Expression<Func<postFormatInput>> postFormat, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
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
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSample(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/spex/upload/{0}", __workflow_sha1Value.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSampleMetadata(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType, Expression<Func<string>> subscribe = null, Expression<Func<string>> body = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_subscribe = WorkflowExpression.Compile(subscribe, nameof(subscribe), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DeleteSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> deleteOn = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_deleteOn = WorkflowExpression.Compile(deleteOn, nameof(deleteOn), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DeleteSamplesBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string>> bodyrlquerydeleteOn = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlquerydeleteOn = WorkflowExpression.Compile(bodyrlquerydeleteOn, nameof(bodyrlquerydeleteOn), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/delete/sample/v1/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerydeleteOn != null)
                {
                    queryObject["delete_on"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydeleteOn);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rescan/v1/query/{0}/{1}", __workflow_hashType.WithUrlEncoding(1), __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<formatInput>> format = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rescan/v1/bulk_query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubscribeToReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/subscription/data_change/v1/bulk_query/subscribe/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UnsubscribeFromReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryhashType = WorkflowExpression.Compile(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            var __workflow_bodyrlqueryhashes = WorkflowExpression.Compile(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/subscription/data_change/v1/bulk_query/unsubscribe/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryhashes);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SetStartTimeForReputationChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/feed/data_change/v3/start/{0}/{1}", __workflow_timeFormat.WithUrlEncoding(1), __workflow_timeValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetReputationDataChanges(Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null, Expression<Func<int>> limit = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetContinuousReputationDataChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_events = WorkflowExpression.Compile(events, nameof(events), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SubmitSampleForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<string>> bodyrlsha1 = null, Expression<Func<string>> bodyrlurl = null, Expression<Func<string>> bodyrlplatform = null, Expression<Func<bodyrlresponseFormatInput>> bodyrlresponseFormat = null, Expression<Func<string>> bodyrloptionalParameters = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlsha1 = WorkflowExpression.Compile(bodyrlsha1, nameof(bodyrlsha1), required: false);
            var __workflow_bodyrlurl = WorkflowExpression.Compile(bodyrlurl, nameof(bodyrlurl), required: false);
            var __workflow_bodyrlplatform = WorkflowExpression.Compile(bodyrlplatform, nameof(bodyrlplatform), required: false);
            var __workflow_bodyrlresponseFormat = WorkflowExpression.Compile(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            var __workflow_bodyrloptionalParameters = WorkflowExpression.Compile(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/analyze/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (__workflow_bodyrlsha1 != null)
                {
                    rlObject["sha1"] = ExpressionConverter.ConvertO(__workflow_bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlurl != null)
                {
                    rlObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyrlurl);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlplatform != null)
                {
                    rlObject["platform"] = ExpressionConverter.ConvertO(__workflow_bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlresponseFormat != null)
                {
                    if (__workflow_bodyrlresponseFormat != null)
                    {
                        rlObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlresponseFormat);
                        rlObjectpropCount++;
                    }

                    rlObjectpropCount++;
                }
                else
                {
                    rlObject["response_format"] = "json";
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrloptionalParameters != null)
                {
                    rlObject["optional_parameters"] = ExpressionConverter.ConvertO(__workflow_bodyrloptionalParameters);
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubmitArchiveForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<string>> bodyrlsha1 = null, Expression<Func<string>> bodyrlplatform = null, Expression<Func<string>> bodyrlresponseFormat = null, Expression<Func<string>> bodyrloptionalParameters = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlsha1 = WorkflowExpression.Compile(bodyrlsha1, nameof(bodyrlsha1), required: false);
            var __workflow_bodyrlplatform = WorkflowExpression.Compile(bodyrlplatform, nameof(bodyrlplatform), required: false);
            var __workflow_bodyrlresponseFormat = WorkflowExpression.Compile(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            var __workflow_bodyrloptionalParameters = WorkflowExpression.Compile(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/dynamic/analysis/analyze/v1/archive/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (__workflow_bodyrlsha1 != null)
                {
                    rlObject["sha1"] = ExpressionConverter.ConvertO(__workflow_bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlplatform != null)
                {
                    rlObject["platform"] = ExpressionConverter.ConvertO(__workflow_bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlresponseFormat != null)
                {
                    rlObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlresponseFormat);
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrloptionalParameters != null)
                {
                    rlObject["optional_parameters"] = ExpressionConverter.ConvertO(__workflow_bodyrloptionalParameters);
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchSha1FirstPage(Expression<Func<string>> uriSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var __workflow_uriSha1 = WorkflowExpression.Compile(uriSha1, nameof(uriSha1), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction URIToHashSearchSha1Paging(Expression<Func<string>> uriSha1, Expression<Func<string>> nextPageSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var __workflow_uriSha1 = WorkflowExpression.Compile(uriSha1, nameof(uriSha1), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction URIToHashSearchTextPaging(Expression<Func<string>> contentType, Expression<Func<formatInput>> format = null, Expression<Func<string>> bodyrlqueryuri = null, Expression<Func<string>> bodyrlquerynextPageSha1 = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_bodyrlqueryuri = WorkflowExpression.Compile(bodyrlqueryuri, nameof(bodyrlqueryuri), required: false);
            var __workflow_bodyrlquerynextPageSha1 = WorkflowExpression.Compile(bodyrlquerynextPageSha1, nameof(bodyrlquerynextPageSha1), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/uri_index/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryuri != null)
                {
                    queryObject["uri"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryuri);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerynextPageSha1 != null)
                {
                    queryObject["next_page_sha1"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerynextPageSha1);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryurl = WorkflowExpression.Compile(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/report/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromURL(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<string>> bodyrlqueryanalysisId = null, Expression<Func<bool>> bodyrlquerylastAnalysis = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryurl = WorkflowExpression.Compile(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            var __workflow_bodyrlqueryanalysisId = WorkflowExpression.Compile(bodyrlqueryanalysisId, nameof(bodyrlqueryanalysisId), required: false);
            var __workflow_bodyrlquerylastAnalysis = WorkflowExpression.Compile(bodyrlquerylastAnalysis, nameof(bodyrlquerylastAnalysis), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlqueryextended = WorkflowExpression.Compile(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            var __workflow_bodyrlqueryclassification = WorkflowExpression.Compile(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/downloaded_files/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryanalysisId != null)
                {
                    queryObject["analysis_id"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryanalysisId);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylastAnalysis != null)
                {
                    queryObject["last_analysis"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylastAnalysis);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetLatestURLAnalysesFirst(Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetLatestURLAnalysesPaging(Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetTimestampedURLAnalysesFirst(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetTimestampedURLAnalysesPaging(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction AnalyzeURL(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryurl = WorkflowExpression.Compile(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/url/v1/analyze/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlquerydomain = WorkflowExpression.Compile(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/report/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromDomain(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlquerydomain = WorkflowExpression.Compile(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlqueryextended = WorkflowExpression.Compile(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            var __workflow_bodyrlqueryclassification = WorkflowExpression.Compile(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/downloaded_files/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromDomain(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlquerydomain = WorkflowExpression.Compile(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/urls/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainResolutions(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlquerydomain = WorkflowExpression.Compile(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/resolutions/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainRelatedDomains(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlquerydomain = WorkflowExpression.Compile(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/domain/related_domains/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryip = WorkflowExpression.Compile(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/report/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryip = WorkflowExpression.Compile(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlqueryextended = WorkflowExpression.Compile(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            var __workflow_bodyrlqueryclassification = WorkflowExpression.Compile(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/downloaded_files/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryip = WorkflowExpression.Compile(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/urls/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressResolutions(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_bodyrlqueryip = WorkflowExpression.Compile(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            var __workflow_bodyrlquerylimit = WorkflowExpression.Compile(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            var __workflow_bodyrlquerypage = WorkflowExpression.Compile(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/ip/resolutions/v1/query/{0}", __workflow_format.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerypage);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DailyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DailyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction MonthlyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction MonthlyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DateRangeAPIUsageUser(Expression<Func<formatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DateRangeAPIUsageCompany(Expression<Func<formatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetActiveYARARulesets(Expression<Func<formatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetAPIQuotaLimitsUser(Expression<Func<formatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetAPIQuotaLimitsCompany(Expression<Func<formatInput>> format = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction NetworkReputationApi(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlquerynetworkLocationsInputItem[]>> bodyrlquerynetworkLocations, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlquerynetworkLocations = WorkflowExpression.Compile(bodyrlquerynetworkLocations, nameof(bodyrlquerynetworkLocations), required: true);
            var __workflow_bodyrlqueryresponseFormat = WorkflowExpression.Compile(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/reputation/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                queryObjectpropCount++;
                queryObject["network_locations"] = ExpressionConverter.ConvertO(__workflow_bodyrlquerynetworkLocations);
                if (__workflow_bodyrlqueryresponseFormat != null)
                {
                    if (__workflow_bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListUserOverride(Expression<Func<string>> format = null, Expression<Func<string>> nextNetworkLocation = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_nextNetworkLocation = WorkflowExpression.Compile(nextNetworkLocation, nameof(nextNetworkLocation), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction NetworkReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]>> bodyrlqueryuserOverrideoverrideNetworkLocations = null, Expression<Func<string>> bodyrlresponseFormat = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryuserOverrideoverrideNetworkLocations = WorkflowExpression.Compile(bodyrlqueryuserOverrideoverrideNetworkLocations, nameof(bodyrlqueryuserOverrideoverrideNetworkLocations), required: false);
            var __workflow_bodyrlresponseFormat = WorkflowExpression.Compile(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/networking/user_override/v1/query/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var userOverrideObject = new JObject();
                var userOverrideObjectpropCount = 0;
                if (__workflow_bodyrlqueryuserOverrideoverrideNetworkLocations != null)
                {
                    userOverrideObject["override_network_locations"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryuserOverrideoverrideNetworkLocations);
                    userOverrideObjectpropCount++;
                }

                if (userOverrideObjectpropCount > 0)
                {
                    queryObject["user_override"] = userOverrideObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (__workflow_bodyrlresponseFormat != null)
                {
                    if (__workflow_bodyrlresponseFormat != null)
                    {
                        rlObject["response_format"] = ExpressionConverter.ConvertO(__workflow_bodyrlresponseFormat);
                        rlObjectpropCount++;
                    }

                    rlObjectpropCount++;
                }
                else
                {
                    rlObject["response_format"] = "json";
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_specificReport = WorkflowExpression.Compile(specificReport, nameof(specificReport), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_base64Value = WorkflowExpression.Compile(base64Value, nameof(base64Value), required: true);
            var __workflow_specificReport = WorkflowExpression.Compile(specificReport, nameof(specificReport), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType = null)
        {
            var __workflow_sha1Value = WorkflowExpression.Compile(sha1Value, nameof(sha1Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> contentType = null)
        {
            var __workflow_base64Value = WorkflowExpression.Compile(base64Value, nameof(base64Value), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetYaraRulesetInformation(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteYaraRuleset(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRulesetText(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}/text", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction CreateYaraRuleset(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> bodytext, Expression<Func<bool>> bodysampleAvailable, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyrulesetName = WorkflowExpression.Compile(bodyrulesetName, nameof(bodyrulesetName), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodysampleAvailable = WorkflowExpression.Compile(bodysampleAvailable, nameof(bodysampleAvailable), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(__workflow_bodyrulesetName);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["sample_available"] = ExpressionConverter.ConvertO(__workflow_bodysampleAvailable);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroHuntingStatus(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/admin/v1/ruleset/{0}/status-retro-hunt", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
        {
            var __workflow_timeFormat = WorkflowExpression.Compile(timeFormat, nameof(timeFormat), required: true);
            var __workflow_timeValue = WorkflowExpression.Compile(timeValue, nameof(timeValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction StartYaraRetroHunt(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyrulesetName = WorkflowExpression.Compile(bodyrulesetName, nameof(bodyrulesetName), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/start-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(__workflow_bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction CancelYaraRetroHunt(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyrulesetName = WorkflowExpression.Compile(bodyrulesetName, nameof(bodyrulesetName), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/cancel-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(__workflow_bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction AdvancedSearch(Expression<Func<bodyqueryInputItem[]>> bodyquery, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<int>> bodyrecordsPerPage = null, Expression<Func<int>> bodypage = null, Expression<Func<string>> bodysort = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyrecordsPerPage = WorkflowExpression.Compile(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: false);
            var __workflow_bodypage = WorkflowExpression.Compile(bodypage, nameof(bodypage), required: false);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/search/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordsPerPage != null)
                {
                    if (__workflow_bodyrecordsPerPage != null)
                    {
                        body["records_per_page"] = ExpressionConverter.ConvertO(__workflow_bodyrecordsPerPage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["records_per_page"] = 1000;
                    bodypropCount++;
                }

                if (__workflow_bodypage != null)
                {
                    if (__workflow_bodypage != null)
                    {
                        body["page"] = ExpressionConverter.ConvertO(__workflow_bodypage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["page"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodysort != null)
                {
                    if (__workflow_bodysort != null)
                    {
                        body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sort"] = "firstseen desc";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GroupByRha1SingleQuery(Expression<Func<string>> rha1Type, Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null, Expression<Func<bool>> extended = null, Expression<Func<classificationInput>> classification = null)
        {
            var __workflow_rha1Type = WorkflowExpression.Compile(rha1Type, nameof(rha1Type), required: true);
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction ImportHashSimilarity(Expression<Func<string>> hashValue, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction ImportHashSimilarityPaginated(Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_nextPageSha1 = WorkflowExpression.Compile(nextPageSha1, nameof(nextPageSha1), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction FileReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryoverrideSamplesInputItem[]>> bodyrlqueryoverrideSamples = null, Expression<Func<bodyrlqueryremoveOverrideInputItem[]>> bodyrlqueryremoveOverride = null)
        {
            var __workflow_postFormat = WorkflowExpression.Compile(postFormat, nameof(postFormat), required: true);
            var __workflow_bodyrlqueryoverrideSamples = WorkflowExpression.Compile(bodyrlqueryoverrideSamples, nameof(bodyrlqueryoverrideSamples), required: false);
            var __workflow_bodyrlqueryremoveOverride = WorkflowExpression.Compile(bodyrlqueryremoveOverride, nameof(bodyrlqueryremoveOverride), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/databrowser/malware_presence/user_override/{0}", __workflow_postFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyrlqueryoverrideSamples != null)
                {
                    queryObject["override_samples"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryoverrideSamples);
                    queryObjectpropCount++;
                }

                if (__workflow_bodyrlqueryremoveOverride != null)
                {
                    queryObject["remove_override"] = ExpressionConverter.ConvertO(__workflow_bodyrlqueryremoveOverride);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    rlObject["query"] = queryObject;
                    rlObjectpropCount++;
                }

                if (rlObjectpropCount > 0)
                {
                    body["rl"] = rlObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction FileReputationListUserOverrides(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> startHash = null, Expression<Func<formatInput>> format = null)
        {
            var __workflow_hashType = WorkflowExpression.Compile(hashType, nameof(hashType), required: true);
            var __workflow_startHash = WorkflowExpression.Compile(startHash, nameof(startHash), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrlqueryhashTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrlresponseFormatInput
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrlqueryresponseFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public class bodyrlquerynetworkLocationsInputItem
    {
        [JsonProperty("network_location")]
        public string NetworkLocation { get; set; }

        [JsonProperty("type")]
        public bodyrlquerynetworkLocationsInputItemTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrlquerynetworkLocationsInputItemTypeType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "ip")]
        Ip,
        [EnumMember(Value = "domain")]
        Domain
    }

    public class bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem
    {
        [JsonProperty("network_location")]
        public string NetworkLocation { get; set; }

        [JsonProperty("type")]
        public bodyrlqueryuserOverrideoverrideNetworkLocationsInputItemTypeType Type { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrlqueryuserOverrideoverrideNetworkLocationsInputItemTypeType
    {
        [EnumMember(Value = "url")]
        Url
    }

    public class bodyqueryInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("criteria")]
        public bodyqueryInputItemCriteriaType Criteria { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyqueryInputItemCriteriaType
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
    public enum bodyformatInput
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

    public class bodyrlqueryoverrideSamplesInputItem
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
        public int TrustFactor { get; set; }

        [JsonProperty("threat_level")]
        public int ThreatLevel { get; set; }

        [JsonProperty("threat_name")]
        public string ThreatName { get; set; }
    }

    public class bodyrlqueryremoveOverrideInputItem
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
