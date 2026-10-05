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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileReputationSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<bool> extended = null, WorkflowValue<bool> showHashes = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(extended, nameof(extended), required: false);
            WorkflowValue.Validate(showHashes, nameof(showHashes), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileReputationBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bool> extended = null, WorkflowValue<bool> showHashes = null, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(extended, nameof(extended), required: false);
            WorkflowValue.Validate(showHashes, nameof(showHashes), required: false);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetHistoricalAvRecordsSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<bool> history = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(history, nameof(history), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetHistoricalAvRecordsBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bool> history = null, WorkflowValue<formatInput> format = null, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(history, nameof(history), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisNonMaliciousSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFileAnalysisNonMaliciousBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisMerged(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisLatest(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisSpecific(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<string> analysisId, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(analysisId, nameof(analysisId), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisArchiveMerged(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisArchiveLatest(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDownloadSample(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSampleDownloadStatus(WorkflowValue<postFormatInput> postFormat, WorkflowValue<formatInput> format = null, WorkflowValue<string> contentType = null, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadSample(WorkflowValue<string> sha1Value, WorkflowValue<string> contentType)
        {
            WorkflowValue.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadSampleMetadata(WorkflowValue<string> sha1Value, WorkflowValue<string> contentType, WorkflowValue<string> subscribe = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(subscribe, nameof(subscribe), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSampleSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue, WorkflowValue<string> deleteOn = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(deleteOn, nameof(deleteOn), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSamplesBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string> bodyrlquerydeleteOn = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlquerydeleteOn, nameof(bodyrlquerydeleteOn), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReanalyzeSampleSingle(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> hashValue)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReanalyzeSampleBulk(WorkflowValue<postFormatInput> postFormat, WorkflowValue<formatInput> format = null, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubscribeToReputationChanges(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnsubscribeFromReputationChanges(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, WorkflowValue<string[]> bodyrlqueryhashes = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            WorkflowValue.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetStartTimeForReputationChanges(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> timeValue)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(timeValue, nameof(timeValue), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetReputationDataChanges(WorkflowValue<formatInput> format = null, WorkflowValue<string> events = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(events, nameof(events), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContinuousReputationDataChanges(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> timeValue, WorkflowValue<formatInput> format = null, WorkflowValue<string> events = null)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(events, nameof(events), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubmitSampleForDynamicAnalysis(WorkflowValue<postFormatInput> postFormat, WorkflowValue<string> bodyrlsha1 = null, WorkflowValue<string> bodyrlurl = null, WorkflowValue<string> bodyrlplatform = null, WorkflowValue<bodyrlresponseFormatInput> bodyrlresponseFormat = null, WorkflowValue<string> bodyrloptionalParameters = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            WorkflowValue.Validate(bodyrlurl, nameof(bodyrlurl), required: false);
            WorkflowValue.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            WorkflowValue.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            WorkflowValue.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSubmitArchiveForDynamicAnalysis(WorkflowValue<postFormatInput> postFormat, WorkflowValue<string> bodyrlsha1 = null, WorkflowValue<string> bodyrlplatform = null, WorkflowValue<string> bodyrlresponseFormat = null, WorkflowValue<string> bodyrloptionalParameters = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            WorkflowValue.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            WorkflowValue.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            WorkflowValue.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchSha1FirstPage(WorkflowValue<string> uriSha1, WorkflowValue<formatInput> format = null, WorkflowValue<string> classification = null)
        {
            WorkflowValue.Validate(uriSha1, nameof(uriSha1), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(classification, nameof(classification), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchSha1Paging(WorkflowValue<string> uriSha1, WorkflowValue<string> nextPageSha1, WorkflowValue<formatInput> format = null, WorkflowValue<string> classification = null)
        {
            WorkflowValue.Validate(uriSha1, nameof(uriSha1), required: true);
            WorkflowValue.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(classification, nameof(classification), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildURIToHashSearchTextPaging(WorkflowValue<string> contentType, WorkflowValue<formatInput> format = null, WorkflowValue<string> bodyrlqueryuri = null, WorkflowValue<string> bodyrlquerynextPageSha1 = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(bodyrlqueryuri, nameof(bodyrlqueryuri), required: false);
            WorkflowValue.Validate(bodyrlquerynextPageSha1, nameof(bodyrlquerynextPageSha1), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLReport(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryurl = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromURL(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryurl = null, WorkflowValue<string> bodyrlqueryanalysisId = null, WorkflowValue<bool> bodyrlquerylastAnalysis = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<bool> bodyrlqueryextended = null, WorkflowValue<string> bodyrlqueryclassification = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowValue.Validate(bodyrlqueryanalysisId, nameof(bodyrlqueryanalysisId), required: false);
            WorkflowValue.Validate(bodyrlquerylastAnalysis, nameof(bodyrlquerylastAnalysis), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowValue.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLatestURLAnalysesFirst(WorkflowValue<formatInput> format = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLatestURLAnalysesPaging(WorkflowValue<string> page, WorkflowValue<formatInput> format = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetTimestampedURLAnalysesFirst(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> startTime, WorkflowValue<formatInput> format = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetTimestampedURLAnalysesPaging(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> startTime, WorkflowValue<string> page, WorkflowValue<formatInput> format = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: true);
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAnalyzeURL(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryurl = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainReport(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlquerydomain = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromDomain(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlquerydomain = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<bool> bodyrlqueryextended = null, WorkflowValue<string> bodyrlqueryclassification = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowValue.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLFromDomain(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlquerydomain = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainResolutions(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlquerydomain = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDomainRelatedDomains(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlquerydomain = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetIPAddressReport(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryip = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListFilesFromIPAddress(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryip = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<bool> bodyrlqueryextended = null, WorkflowValue<string> bodyrlqueryclassification = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            WorkflowValue.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetURLFromIPAddress(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryip = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetIPAddressResolutions(WorkflowValue<formatInput> format, WorkflowValue<string> bodyrlqueryip = null, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, WorkflowValue<int> bodyrlquerylimit = null, WorkflowValue<string> bodyrlquerypage = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: true);
            WorkflowValue.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            WorkflowValue.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            WorkflowValue.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDailyAPIUsageUser(WorkflowValue<formatInput> format = null, WorkflowValue<string> date = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(date, nameof(date), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDailyAPIUsageCompany(WorkflowValue<formatInput> format = null, WorkflowValue<string> date = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(date, nameof(date), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMonthlyAPIUsageUser(WorkflowValue<formatInput> format = null, WorkflowValue<string> month = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(month, nameof(month), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMonthlyAPIUsageCompany(WorkflowValue<formatInput> format = null, WorkflowValue<string> month = null, WorkflowValue<string> from = null, WorkflowValue<string> to = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(month, nameof(month), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDateRangeAPIUsageUser(WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDateRangeAPIUsageCompany(WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetActiveYARARulesets(WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAPIQuotaLimitsUser(WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAPIQuotaLimitsCompany(WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNetworkReputationApi(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlquerynetworkLocationsInputItem[]> bodyrlquerynetworkLocations, WorkflowValue<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlquerynetworkLocations, nameof(bodyrlquerynetworkLocations), required: true);
            WorkflowValue.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildListUserOverride(WorkflowValue<string> format = null, WorkflowValue<string> nextNetworkLocation = null)
        {
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(nextNetworkLocation, nameof(nextNetworkLocation), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNetworkReputationUserOverride(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]> bodyrlqueryuserOverrideoverrideNetworkLocations = null, WorkflowValue<string> bodyrlresponseFormat = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryuserOverrideoverrideNetworkLocations, nameof(bodyrlqueryuserOverrideoverrideNetworkLocations), required: false);
            WorkflowValue.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSpecificDynamicAnalysisReportForUrlSha1(WorkflowValue<string> sha1Value, WorkflowValue<string> specificReport, WorkflowValue<formatInput> format = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowValue.Validate(specificReport, nameof(specificReport), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSpecificDynamicAnalysisReportForUrlBase64(WorkflowValue<string> base64Value, WorkflowValue<string> specificReport, WorkflowValue<formatInput> format = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(base64Value, nameof(base64Value), required: true);
            WorkflowValue.Validate(specificReport, nameof(specificReport), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisReportForUrlSha1(WorkflowValue<string> sha1Value, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(sha1Value, nameof(sha1Value), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDynamicAnalysisReportForUrlBase64(WorkflowValue<string> base64Value, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(base64Value, nameof(base64Value), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRulesetInformation(WorkflowValue<string> rulesetName)
        {
            WorkflowValue.Validate(rulesetName, nameof(rulesetName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteYaraRuleset(WorkflowValue<string> rulesetName)
        {
            WorkflowValue.Validate(rulesetName, nameof(rulesetName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRulesetText(WorkflowValue<string> rulesetName)
        {
            WorkflowValue.Validate(rulesetName, nameof(rulesetName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraMatchesFeed(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> timeValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateYaraRuleset(WorkflowValue<string> bodyrulesetName, WorkflowValue<string> bodytext, WorkflowValue<bool> bodysampleAvailable, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowValue.Validate(bodysampleAvailable, nameof(bodysampleAvailable), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRetroHuntingStatus(WorkflowValue<string> rulesetName)
        {
            WorkflowValue.Validate(rulesetName, nameof(rulesetName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetYaraRetroMatchesFeed(WorkflowValue<timeFormatInput> timeFormat, WorkflowValue<string> timeValue, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(timeFormat, nameof(timeFormat), required: true);
            WorkflowValue.Validate(timeValue, nameof(timeValue), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStartYaraRetroHunt(WorkflowValue<string> bodyrulesetName, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancelYaraRetroHunt(WorkflowValue<string> bodyrulesetName, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAdvancedSearch(WorkflowValue<bodyqueryInputItem[]> bodyquery, WorkflowValue<bodyformatInput> bodyformat = null, WorkflowValue<int> bodyrecordsPerPage = null, WorkflowValue<int> bodypage = null, WorkflowValue<string> bodysort = null, WorkflowValue<string> contentType = null)
        {
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: true);
            WorkflowValue.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowValue.Validate(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: false);
            WorkflowValue.Validate(bodypage, nameof(bodypage), required: false);
            WorkflowValue.Validate(bodysort, nameof(bodysort), required: false);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGroupByRha1SingleQuery(WorkflowValue<string> rha1Type, WorkflowValue<string> hashValue, WorkflowValue<string> nextPageSha1, WorkflowValue<string> contentType = null, WorkflowValue<formatInput> format = null, WorkflowValue<int> limit = null, WorkflowValue<bool> extended = null, WorkflowValue<classificationInput> classification = null)
        {
            WorkflowValue.Validate(rha1Type, nameof(rha1Type), required: true);
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(extended, nameof(extended), required: false);
            WorkflowValue.Validate(classification, nameof(classification), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportHashSimilarity(WorkflowValue<string> hashValue, WorkflowValue<string> contentType = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildImportHashSimilarityPaginated(WorkflowValue<string> hashValue, WorkflowValue<string> nextPageSha1, WorkflowValue<string> contentType = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashValue, nameof(hashValue), required: true);
            WorkflowValue.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileReputationUserOverride(WorkflowValue<postFormatInput> postFormat, WorkflowValue<bodyrlqueryoverrideSamplesInputItem[]> bodyrlqueryoverrideSamples = null, WorkflowValue<bodyrlqueryremoveOverrideInputItem[]> bodyrlqueryremoveOverride = null)
        {
            WorkflowValue.Validate(postFormat, nameof(postFormat), required: true);
            WorkflowValue.Validate(bodyrlqueryoverrideSamples, nameof(bodyrlqueryoverrideSamples), required: false);
            WorkflowValue.Validate(bodyrlqueryremoveOverride, nameof(bodyrlqueryremoveOverride), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileReputationListUserOverrides(WorkflowValue<hashTypeInput> hashType, WorkflowValue<string> startHash = null, WorkflowValue<formatInput> format = null)
        {
            WorkflowValue.Validate(hashType, nameof(hashType), required: true);
            WorkflowValue.Validate(startHash, nameof(startHash), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
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

    public enum hashTypeInput
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum postFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum bodyrlqueryhashTypeInput
    {
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256
    }

    public enum timeFormatInput
    {
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "utc")]
        Utc
    }

    public enum bodyrlresponseFormatInput
    {
        [EnumMember(Value = "xml")]
        Xml,
        [EnumMember(Value = "json")]
        Json
    }

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

    public enum bodyformatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "xml")]
        Xml
    }

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
