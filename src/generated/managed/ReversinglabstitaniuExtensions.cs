//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReversinglabstitaniuActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileReputationSingle))]
        public IWorkflowAction GetFileReputationSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<bool> showHashes = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileReputationSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<bool> extended = null, WorkflowExpression<bool> showHashes = null, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(extended, nameof(extended), required: false);
            WorkflowExpression.Validate(showHashes, nameof(showHashes), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["extended"] = Convert.ToString(true);
                if (extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(extended);
                callPayload.Queries["show_hashes"] = Convert.ToString(true);
                if (showHashes != null)
                    callPayload.Queries["show_hashes"] = ExpressionConverter.Convert(showHashes);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileReputationBulk))]
        public IWorkflowAction GetFileReputationBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<bool> showHashes = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileReputationBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bool> extended = null, WorkflowExpression<bool> showHashes = null, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(extended, nameof(extended), required: false);
            WorkflowExpression.Validate(showHashes, nameof(showHashes), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(extended);
                if (showHashes != null)
                    callPayload.Queries["show_hashes"] = ExpressionConverter.Convert(showHashes);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildGetHistoricalAvRecordsSingle))]
        public IWorkflowAction GetHistoricalAvRecordsSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<bool> history = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetHistoricalAvRecordsSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<bool> history = null, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(history, nameof(history), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/xref/v2/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["history"] = Convert.ToString(false);
                if (history != null)
                    callPayload.Queries["history"] = ExpressionConverter.Convert(history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetHistoricalAvRecordsBulk))]
        public IWorkflowAction GetHistoricalAvRecordsBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bool> history = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetHistoricalAvRecordsBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bool> history = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(history, nameof(history), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/xref/v2/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (history != null)
                    callPayload.Queries["history"] = ExpressionConverter.Convert(history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFileAnalysisSingle))]
        public IWorkflowAction GetFileAnalysisSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileAnalysisBulk))]
        public IWorkflowAction GetFileAnalysisBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFileAnalysisNonMaliciousSingle))]
        public IWorkflowAction GetFileAnalysisNonMaliciousSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisNonMaliciousSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileAnalysisNonMaliciousBulk))]
        public IWorkflowAction GetFileAnalysisNonMaliciousBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisNonMaliciousBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisMerged))]
        public IWorkflowAction GetDynamicAnalysisMerged([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisMerged(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisLatest))]
        public IWorkflowAction GetDynamicAnalysisLatest([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisLatest(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/latest", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisSpecific))]
        public IWorkflowAction GetDynamicAnalysisSpecific([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> analysisId, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisSpecific(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<string> analysisId, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(analysisId, nameof(analysisId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(analysisId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisArchiveMerged))]
        public IWorkflowAction GetDynamicAnalysisArchiveMerged([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisArchiveMerged(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisArchiveLatest))]
        public IWorkflowAction GetDynamicAnalysisArchiveLatest([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisArchiveLatest(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}/latest", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadSample))]
        public IWorkflowAction DownloadSample([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDownloadSample(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetSampleDownloadStatus))]
        public IWorkflowAction GetSampleDownloadStatus([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSampleDownloadStatus(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> contentType = null, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/status/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/octet-stream");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildUploadSample))]
        public IWorkflowAction UploadSample([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadSample(WorkflowExpression<string> sha1Value, WorkflowExpression<string> contentType)
        {
            WorkflowExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}", ExpressionConverter.ConvertWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
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
        [WorkflowExpressionFactory(nameof(__BuildUploadSampleMetadata))]
        public IWorkflowAction UploadSampleMetadata([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> subscribe = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadSampleMetadata(WorkflowExpression<string> sha1Value, WorkflowExpression<string> contentType, WorkflowExpression<string> subscribe = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(subscribe, nameof(subscribe), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}/meta", ExpressionConverter.ConvertWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (subscribe != null)
                    callPayload.Queries["subscribe"] = ExpressionConverter.Convert(subscribe);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSampleSingle))]
        public IWorkflowAction DeleteSampleSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> deleteOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSampleSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue, WorkflowExpression<string> deleteOn = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(deleteOn, nameof(deleteOn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deleteOn != null)
                    callPayload.Queries["delete_on"] = ExpressionConverter.Convert(deleteOn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSamplesBulk))]
        public IWorkflowAction DeleteSamplesBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string> bodyrlquerydeleteOn = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSamplesBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string> bodyrlquerydeleteOn = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlquerydeleteOn, nameof(bodyrlquerydeleteOn), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlquerydeleteOn != null)
                {
                    queryObject["delete_on"] = ExpressionConverter.ConvertO(bodyrlquerydeleteOn);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildReanalyzeSampleSingle))]
        public IWorkflowAction ReanalyzeSampleSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReanalyzeSampleSingle(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> hashValue)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildReanalyzeSampleBulk))]
        public IWorkflowAction ReanalyzeSampleBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReanalyzeSampleBulk(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<formatInput> format = null, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/bulk_query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildSubscribeToReputationChanges))]
        public IWorkflowAction SubscribeToReputationChanges([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubscribeToReputationChanges(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/subscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildUnsubscribeFromReputationChanges))]
        public IWorkflowAction UnsubscribeFromReputationChanges([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnsubscribeFromReputationChanges(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowExpression<string[]> bodyrlqueryhashes = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/unsubscribe/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = ExpressionConverter.ConvertO(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = ExpressionConverter.ConvertO(bodyrlqueryhashes);
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
        [WorkflowExpressionFactory(nameof(__BuildSetStartTimeForReputationChanges))]
        public IWorkflowAction SetStartTimeForReputationChanges([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetStartTimeForReputationChanges(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> timeValue)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(timeValue, nameof(timeValue), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/start/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetReputationDataChanges))]
        public IWorkflowAction GetReputationDataChanges([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> events = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetReputationDataChanges(WorkflowExpression<formatInput> format = null, WorkflowExpression<string> events = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(events, nameof(events), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/feed/data_change/v3/pull";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (events != null)
                    callPayload.Queries["events"] = ExpressionConverter.Convert(events);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetContinuousReputationDataChanges))]
        public IWorkflowAction GetContinuousReputationDataChanges([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> events = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContinuousReputationDataChanges(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> timeValue, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> events = null)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(events, nameof(events), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (events != null)
                    callPayload.Queries["events"] = ExpressionConverter.Convert(events);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildSubmitSampleForDynamicAnalysis))]
        public IWorkflowAction SubmitSampleForDynamicAnalysis([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<string> bodyrlsha1 = null, [WorkflowExpression] Func<string> bodyrlurl = null, [WorkflowExpression] Func<string> bodyrlplatform = null, [WorkflowExpression] Func<bodyrlresponseFormatInput> bodyrlresponseFormat = null, [WorkflowExpression] Func<string> bodyrloptionalParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubmitSampleForDynamicAnalysis(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<string> bodyrlsha1 = null, WorkflowExpression<string> bodyrlurl = null, WorkflowExpression<string> bodyrlplatform = null, WorkflowExpression<bodyrlresponseFormatInput> bodyrlresponseFormat = null, WorkflowExpression<string> bodyrloptionalParameters = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            WorkflowExpression.Validate(bodyrlurl, nameof(bodyrlurl), required: false);
            WorkflowExpression.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            WorkflowExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (bodyrlsha1 != null)
                {
                    rlObject["sha1"] = ExpressionConverter.ConvertO(bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (bodyrlurl != null)
                {
                    rlObject["url"] = ExpressionConverter.ConvertO(bodyrlurl);
                    rlObjectpropCount++;
                }

                if (bodyrlplatform != null)
                {
                    rlObject["platform"] = ExpressionConverter.ConvertO(bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (bodyrlresponseFormat != null)
                {
                    if (bodyrlresponseFormat != null)
                    {
                        rlObject["response_format"] = ExpressionConverter.ConvertO(bodyrlresponseFormat);
                        rlObjectpropCount++;
                    }

                    rlObjectpropCount++;
                }
                else
                {
                    rlObject["response_format"] = "json";
                    rlObjectpropCount++;
                }

                if (bodyrloptionalParameters != null)
                {
                    rlObject["optional_parameters"] = ExpressionConverter.ConvertO(bodyrloptionalParameters);
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
        [WorkflowExpressionFactory(nameof(__BuildSubmitArchiveForDynamicAnalysis))]
        public IWorkflowAction SubmitArchiveForDynamicAnalysis([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<string> bodyrlsha1 = null, [WorkflowExpression] Func<string> bodyrlplatform = null, [WorkflowExpression] Func<string> bodyrlresponseFormat = null, [WorkflowExpression] Func<string> bodyrloptionalParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubmitArchiveForDynamicAnalysis(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<string> bodyrlsha1 = null, WorkflowExpression<string> bodyrlplatform = null, WorkflowExpression<string> bodyrlresponseFormat = null, WorkflowExpression<string> bodyrloptionalParameters = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            WorkflowExpression.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            WorkflowExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/archive/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (bodyrlsha1 != null)
                {
                    rlObject["sha1"] = ExpressionConverter.ConvertO(bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (bodyrlplatform != null)
                {
                    rlObject["platform"] = ExpressionConverter.ConvertO(bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (bodyrlresponseFormat != null)
                {
                    rlObject["response_format"] = ExpressionConverter.ConvertO(bodyrlresponseFormat);
                    rlObjectpropCount++;
                }

                if (bodyrloptionalParameters != null)
                {
                    rlObject["optional_parameters"] = ExpressionConverter.ConvertO(bodyrloptionalParameters);
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
        [WorkflowExpressionFactory(nameof(__BuildURIToHashSearchSha1FirstPage))]
        public IWorkflowAction URIToHashSearchSha1FirstPage([WorkflowExpression] Func<string> uriSha1, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> classification = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchSha1FirstPage(WorkflowExpression<string> uriSha1, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> classification = null)
        {
            WorkflowExpression.Validate(uriSha1, nameof(uriSha1), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(uriSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(classification);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildURIToHashSearchSha1Paging))]
        public IWorkflowAction URIToHashSearchSha1Paging([WorkflowExpression] Func<string> uriSha1, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> classification = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchSha1Paging(WorkflowExpression<string> uriSha1, WorkflowExpression<string> nextPageSha1, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> classification = null)
        {
            WorkflowExpression.Validate(uriSha1, nameof(uriSha1), required: true);
            WorkflowExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(uriSha1, 1), ExpressionConverter.ConvertWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(classification);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildURIToHashSearchTextPaging))]
        public IWorkflowAction URIToHashSearchTextPaging([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> bodyrlqueryuri = null, [WorkflowExpression] Func<string> bodyrlquerynextPageSha1 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchTextPaging(WorkflowExpression<string> contentType, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> bodyrlqueryuri = null, WorkflowExpression<string> bodyrlquerynextPageSha1 = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(bodyrlqueryuri, nameof(bodyrlqueryuri), required: false);
            WorkflowExpression.Validate(bodyrlquerynextPageSha1, nameof(bodyrlquerynextPageSha1), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/uri_index/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryuri != null)
                {
                    queryObject["uri"] = ExpressionConverter.ConvertO(bodyrlqueryuri);
                    queryObjectpropCount++;
                }

                if (bodyrlquerynextPageSha1 != null)
                {
                    queryObject["next_page_sha1"] = ExpressionConverter.ConvertO(bodyrlquerynextPageSha1);
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
        [WorkflowExpressionFactory(nameof(__BuildGetURLReport))]
        public IWorkflowAction GetURLReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLReport(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryurl = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/report/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildListFilesFromURL))]
        public IWorkflowAction ListFilesFromURL([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<string> bodyrlqueryanalysisId = null, [WorkflowExpression] Func<bool> bodyrlquerylastAnalysis = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromURL(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryurl = null, WorkflowExpression<string> bodyrlqueryanalysisId = null, WorkflowExpression<bool> bodyrlquerylastAnalysis = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<bool> bodyrlqueryextended = null, WorkflowExpression<string> bodyrlqueryclassification = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowExpression.Validate(bodyrlqueryanalysisId, nameof(bodyrlqueryanalysisId), required: false);
            WorkflowExpression.Validate(bodyrlquerylastAnalysis, nameof(bodyrlquerylastAnalysis), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/downloaded_files/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryanalysisId != null)
                {
                    queryObject["analysis_id"] = ExpressionConverter.ConvertO(bodyrlqueryanalysisId);
                    queryObjectpropCount++;
                }

                if (bodyrlquerylastAnalysis != null)
                {
                    queryObject["last_analysis"] = ExpressionConverter.ConvertO(bodyrlquerylastAnalysis);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLatestURLAnalysesFirst))]
        public IWorkflowAction GetLatestURLAnalysesFirst([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLatestURLAnalysesFirst(WorkflowExpression<formatInput> format = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/networking/url/v1/notifications/query/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetLatestURLAnalysesPaging))]
        public IWorkflowAction GetLatestURLAnalysesPaging([WorkflowExpression] Func<string> page, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLatestURLAnalysesPaging(WorkflowExpression<string> page, WorkflowExpression<formatInput> format = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/latest/page/{0}", ExpressionConverter.ConvertWithUrlEncoding(page, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimestampedURLAnalysesFirst))]
        public IWorkflowAction GetTimestampedURLAnalysesFirst([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetTimestampedURLAnalysesFirst(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> startTime, WorkflowExpression<formatInput> format = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(startTime, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimestampedURLAnalysesPaging))]
        public IWorkflowAction GetTimestampedURLAnalysesPaging([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetTimestampedURLAnalysesPaging(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> startTime, WorkflowExpression<string> page, WorkflowExpression<formatInput> format = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}/page/{2}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(startTime, 1), ExpressionConverter.ConvertWithUrlEncoding(page, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildAnalyzeURL))]
        public IWorkflowAction AnalyzeURL([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAnalyzeURL(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryurl = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/analyze/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryurl != null)
                {
                    queryObject["url"] = ExpressionConverter.ConvertO(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDomainReport))]
        public IWorkflowAction GetDomainReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainReport(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlquerydomain = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/domain/report/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildListFilesFromDomain))]
        public IWorkflowAction ListFilesFromDomain([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromDomain(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlquerydomain = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<bool> bodyrlqueryextended = null, WorkflowExpression<string> bodyrlqueryclassification = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/domain/downloaded_files/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetURLFromDomain))]
        public IWorkflowAction GetURLFromDomain([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLFromDomain(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlquerydomain = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/domain/urls/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDomainResolutions))]
        public IWorkflowAction GetDomainResolutions([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainResolutions(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlquerydomain = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/domain/resolutions/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDomainRelatedDomains))]
        public IWorkflowAction GetDomainRelatedDomains([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainRelatedDomains(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlquerydomain = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/domain/related_domains/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlquerydomain != null)
                {
                    queryObject["domain"] = ExpressionConverter.ConvertO(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetIPAddressReport))]
        public IWorkflowAction GetIPAddressReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetIPAddressReport(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryip = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/ip/report/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildListFilesFromIPAddress))]
        public IWorkflowAction ListFilesFromIPAddress([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromIPAddress(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryip = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<bool> bodyrlqueryextended = null, WorkflowExpression<string> bodyrlqueryclassification = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/ip/downloaded_files/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = ExpressionConverter.ConvertO(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = ExpressionConverter.ConvertO(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetURLFromIPAddress))]
        public IWorkflowAction GetURLFromIPAddress([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLFromIPAddress(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryip = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/ip/urls/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildGetIPAddressResolutions))]
        public IWorkflowAction GetIPAddressResolutions([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetIPAddressResolutions(WorkflowExpression<formatInput> format, WorkflowExpression<string> bodyrlqueryip = null, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowExpression<int> bodyrlquerylimit = null, WorkflowExpression<string> bodyrlquerypage = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/ip/resolutions/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryip != null)
                {
                    queryObject["ip"] = ExpressionConverter.ConvertO(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
                        queryObjectpropCount++;
                    }

                    queryObjectpropCount++;
                }
                else
                {
                    queryObject["response_format"] = "json";
                    queryObjectpropCount++;
                }

                if (bodyrlquerylimit != null)
                {
                    queryObject["limit"] = ExpressionConverter.ConvertO(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = ExpressionConverter.ConvertO(bodyrlquerypage);
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
        [WorkflowExpressionFactory(nameof(__BuildDailyAPIUsageUser))]
        public IWorkflowAction DailyAPIUsageUser([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDailyAPIUsageUser(WorkflowExpression<formatInput> format = null, WorkflowExpression<string> date = null, WorkflowExpression<string> from = null, WorkflowExpression<string> to = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDailyAPIUsageCompany))]
        public IWorkflowAction DailyAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDailyAPIUsageCompany(WorkflowExpression<formatInput> format = null, WorkflowExpression<string> date = null, WorkflowExpression<string> from = null, WorkflowExpression<string> to = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildMonthlyAPIUsageUser))]
        public IWorkflowAction MonthlyAPIUsageUser([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> month = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMonthlyAPIUsageUser(WorkflowExpression<formatInput> format = null, WorkflowExpression<string> month = null, WorkflowExpression<string> from = null, WorkflowExpression<string> to = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(month, nameof(month), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(month);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildMonthlyAPIUsageCompany))]
        public IWorkflowAction MonthlyAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> month = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMonthlyAPIUsageCompany(WorkflowExpression<formatInput> format = null, WorkflowExpression<string> month = null, WorkflowExpression<string> from = null, WorkflowExpression<string> to = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(month, nameof(month), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(month);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDateRangeAPIUsageUser))]
        public IWorkflowAction DateRangeAPIUsageUser([WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDateRangeAPIUsageUser(WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDateRangeAPIUsageCompany))]
        public IWorkflowAction DateRangeAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDateRangeAPIUsageCompany(WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetActiveYARARulesets))]
        public IWorkflowAction GetActiveYARARulesets([WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetActiveYARARulesets(WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/usage/yara";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetAPIQuotaLimitsUser))]
        public IWorkflowAction GetAPIQuotaLimitsUser([WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAPIQuotaLimitsUser(WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/limits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetAPIQuotaLimitsCompany))]
        public IWorkflowAction GetAPIQuotaLimitsCompany([WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAPIQuotaLimitsCompany(WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/customer_usage/v1/limits/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkReputationApi))]
        public IWorkflowAction NetworkReputationApi([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlquerynetworkLocationsInputItem[]> bodyrlquerynetworkLocations, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNetworkReputationApi(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlquerynetworkLocationsInputItem[]> bodyrlquerynetworkLocations, WorkflowExpression<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlquerynetworkLocations, nameof(bodyrlquerynetworkLocations), required: true);
            WorkflowExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/reputation/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                queryObjectpropCount++;
                queryObject["network_locations"] = ExpressionConverter.ConvertO(bodyrlquerynetworkLocations);
                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = ExpressionConverter.ConvertO(bodyrlqueryresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildListUserOverride))]
        public IWorkflowAction ListUserOverride([WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> nextNetworkLocation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListUserOverride(WorkflowExpression<string> format = null, WorkflowExpression<string> nextNetworkLocation = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(nextNetworkLocation, nameof(nextNetworkLocation), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/networking/user_override/v1/query/list_overrides";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (nextNetworkLocation != null)
                    callPayload.Queries["next_network_location"] = ExpressionConverter.Convert(nextNetworkLocation);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildNetworkReputationUserOverride))]
        public IWorkflowAction NetworkReputationUserOverride([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]> bodyrlqueryuserOverrideoverrideNetworkLocations = null, [WorkflowExpression] Func<string> bodyrlresponseFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNetworkReputationUserOverride(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]> bodyrlqueryuserOverrideoverrideNetworkLocations = null, WorkflowExpression<string> bodyrlresponseFormat = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryuserOverrideoverrideNetworkLocations, nameof(bodyrlqueryuserOverrideoverrideNetworkLocations), required: false);
            WorkflowExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/networking/user_override/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
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
                if (bodyrlqueryuserOverrideoverrideNetworkLocations != null)
                {
                    userOverrideObject["override_network_locations"] = ExpressionConverter.ConvertO(bodyrlqueryuserOverrideoverrideNetworkLocations);
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

                if (bodyrlresponseFormat != null)
                {
                    if (bodyrlresponseFormat != null)
                    {
                        rlObject["response_format"] = ExpressionConverter.ConvertO(bodyrlresponseFormat);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSpecificDynamicAnalysisReportForUrlSha1))]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlSha1([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> specificReport, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSpecificDynamicAnalysisReportForUrlSha1(WorkflowExpression<string> sha1Value, WorkflowExpression<string> specificReport, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowExpression.Validate(specificReport, nameof(specificReport), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(sha1Value, 1), ExpressionConverter.ConvertWithUrlEncoding(specificReport, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpecificDynamicAnalysisReportForUrlBase64))]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlBase64([WorkflowExpression] Func<string> base64Value, [WorkflowExpression] Func<string> specificReport, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSpecificDynamicAnalysisReportForUrlBase64(WorkflowExpression<string> base64Value, WorkflowExpression<string> specificReport, WorkflowExpression<formatInput> format = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(base64Value, nameof(base64Value), required: true);
            WorkflowExpression.Validate(specificReport, nameof(specificReport), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(base64Value, 1), ExpressionConverter.ConvertWithUrlEncoding(specificReport, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisReportForUrlSha1))]
        public IWorkflowAction GetDynamicAnalysisReportForUrlSha1([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisReportForUrlSha1(WorkflowExpression<string> sha1Value, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/latest", ExpressionConverter.ConvertWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetDynamicAnalysisReportForUrlBase64))]
        public IWorkflowAction GetDynamicAnalysisReportForUrlBase64([WorkflowExpression] Func<string> base64Value, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisReportForUrlBase64(WorkflowExpression<string> base64Value, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(base64Value, nameof(base64Value), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/latest", ExpressionConverter.ConvertWithUrlEncoding(base64Value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetYaraRulesetInformation))]
        public IWorkflowAction GetYaraRulesetInformation([WorkflowExpression] Func<string> rulesetName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRulesetInformation(WorkflowExpression<string> rulesetName)
        {
            WorkflowExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteYaraRuleset))]
        public IWorkflowAction DeleteYaraRuleset([WorkflowExpression] Func<string> rulesetName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteYaraRuleset(WorkflowExpression<string> rulesetName)
        {
            WorkflowExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetYaraRulesetText))]
        public IWorkflowAction GetYaraRulesetText([WorkflowExpression] Func<string> rulesetName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRulesetText(WorkflowExpression<string> rulesetName)
        {
            WorkflowExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/text", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetYaraMatchesFeed))]
        public IWorkflowAction GetYaraMatchesFeed([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraMatchesFeed(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> timeValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/feed/yara/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateYaraRuleset))]
        public IWorkflowAction CreateYaraRuleset([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodysampleAvailable, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateYaraRuleset(WorkflowExpression<string> bodyrulesetName, WorkflowExpression<string> bodytext, WorkflowExpression<bool> bodysampleAvailable, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodysampleAvailable, nameof(bodysampleAvailable), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(bodyrulesetName);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
                body["sample_available"] = ExpressionConverter.ConvertO(bodysampleAvailable);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetYaraRetroHuntingStatus))]
        public IWorkflowAction GetYaraRetroHuntingStatus([WorkflowExpression] Func<string> rulesetName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRetroHuntingStatus(WorkflowExpression<string> rulesetName)
        {
            WorkflowExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/status-retro-hunt", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildGetYaraRetroMatchesFeed))]
        public IWorkflowAction GetYaraRetroMatchesFeed([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRetroMatchesFeed(WorkflowExpression<timeFormatInput> timeFormat, WorkflowExpression<string> timeValue, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowExpression.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/feed/yara/retro/v1/query/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(timeFormat, 1), ExpressionConverter.ConvertWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildStartYaraRetroHunt))]
        public IWorkflowAction StartYaraRetroHunt([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStartYaraRetroHunt(WorkflowExpression<string> bodyrulesetName, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/start-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildCancelYaraRetroHunt))]
        public IWorkflowAction CancelYaraRetroHunt([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelYaraRetroHunt(WorkflowExpression<string> bodyrulesetName, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/cancel-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = ExpressionConverter.ConvertO(bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildAdvancedSearch))]
        public IWorkflowAction AdvancedSearch([WorkflowExpression] Func<bodyqueryInputItem[]> bodyquery, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<int> bodyrecordsPerPage = null, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<string> bodysort = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAdvancedSearch(WorkflowExpression<bodyqueryInputItem[]> bodyquery, WorkflowExpression<bodyformatInput> bodyformat = null, WorkflowExpression<int> bodyrecordsPerPage = null, WorkflowExpression<int> bodypage = null, WorkflowExpression<string> bodysort = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowExpression.Validate(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: false);
            WorkflowExpression.Validate(bodypage, nameof(bodypage), required: false);
            WorkflowExpression.Validate(bodysort, nameof(bodysort), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/search/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                if (bodyrecordsPerPage != null)
                {
                    if (bodyrecordsPerPage != null)
                    {
                        body["records_per_page"] = ExpressionConverter.ConvertO(bodyrecordsPerPage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["records_per_page"] = 1000;
                    bodypropCount++;
                }

                if (bodypage != null)
                {
                    if (bodypage != null)
                    {
                        body["page"] = ExpressionConverter.ConvertO(bodypage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["page"] = 1;
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    if (bodysort != null)
                    {
                        body["sort"] = ExpressionConverter.ConvertO(bodysort);
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
        [WorkflowExpressionFactory(nameof(__BuildGroupByRha1SingleQuery))]
        public IWorkflowAction GroupByRha1SingleQuery([WorkflowExpression] Func<string> rha1Type, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<classificationInput> classification = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGroupByRha1SingleQuery(WorkflowExpression<string> rha1Type, WorkflowExpression<string> hashValue, WorkflowExpression<string> nextPageSha1, WorkflowExpression<string> contentType = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> extended = null, WorkflowExpression<classificationInput> classification = null)
        {
            WorkflowExpression.Validate(rha1Type, nameof(rha1Type), required: true);
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(extended, nameof(extended), required: false);
            WorkflowExpression.Validate(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/group_by_rha1/v1/query/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(rha1Type, 1), ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["extended"] = Convert.ToString(false);
                if (extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(extended);
                if (classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(classification);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildImportHashSimilarity))]
        public IWorkflowAction ImportHashSimilarity([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportHashSimilarity(WorkflowExpression<string> hashValue, WorkflowExpression<string> contentType = null, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildImportHashSimilarityPaginated))]
        public IWorkflowAction ImportHashSimilarityPaginated([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportHashSimilarityPaginated(WorkflowExpression<string> hashValue, WorkflowExpression<string> nextPageSha1, WorkflowExpression<string> contentType = null, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}/start_sha1/{1}", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        [WorkflowExpressionFactory(nameof(__BuildFileReputationUserOverride))]
        public IWorkflowAction FileReputationUserOverride([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryoverrideSamplesInputItem[]> bodyrlqueryoverrideSamples = null, [WorkflowExpression] Func<bodyrlqueryremoveOverrideInputItem[]> bodyrlqueryremoveOverride = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileReputationUserOverride(WorkflowExpression<postFormatInput> postFormat, WorkflowExpression<bodyrlqueryoverrideSamplesInputItem[]> bodyrlqueryoverrideSamples = null, WorkflowExpression<bodyrlqueryremoveOverrideInputItem[]> bodyrlqueryremoveOverride = null)
        {
            WorkflowExpression.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowExpression.Validate(bodyrlqueryoverrideSamples, nameof(bodyrlqueryoverrideSamples), required: false);
            WorkflowExpression.Validate(bodyrlqueryremoveOverride, nameof(bodyrlqueryremoveOverride), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/{0}", ExpressionConverter.ConvertWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryoverrideSamples != null)
                {
                    queryObject["override_samples"] = ExpressionConverter.ConvertO(bodyrlqueryoverrideSamples);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryremoveOverride != null)
                {
                    queryObject["remove_override"] = ExpressionConverter.ConvertO(bodyrlqueryremoveOverride);
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
        [WorkflowExpressionFactory(nameof(__BuildFileReputationListUserOverrides))]
        public IWorkflowAction FileReputationListUserOverrides([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> startHash = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileReputationListUserOverrides(WorkflowExpression<hashTypeInput> hashType, WorkflowExpression<string> startHash = null, WorkflowExpression<formatInput> format = null)
        {
            WorkflowExpression.Validate(hashType, nameof(hashType), required: true);
            WorkflowExpression.Validate(startHash, nameof(startHash), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/list_hashes/{0}", ExpressionConverter.ConvertWithUrlEncoding(hashType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startHash != null)
                    callPayload.Queries["start_hash"] = ExpressionConverter.Convert(startHash);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
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