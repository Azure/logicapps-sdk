//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabstitaniu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReversinglabstitaniuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileReputationSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<bool> showHashes = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(extended, nameof(extended), required: false);
            SourceExpression.Validate(showHashes, nameof(showHashes), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["extended"] = Convert.ToString(true);
                if (extended != null)
                    callPayload.Queries["extended"] = SourceExpressionConverter.ConvertO(extended);
                callPayload.Queries["show_hashes"] = Convert.ToString(true);
                if (showHashes != null)
                    callPayload.Queries["show_hashes"] = SourceExpressionConverter.ConvertO(showHashes);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileReputationBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<bool> showHashes = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(extended, nameof(extended), required: false);
            SourceExpression.Validate(showHashes, nameof(showHashes), required: false);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extended != null)
                    callPayload.Queries["extended"] = SourceExpressionConverter.ConvertO(extended);
                if (showHashes != null)
                    callPayload.Queries["show_hashes"] = SourceExpressionConverter.ConvertO(showHashes);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetHistoricalAvRecordsSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<bool> history = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(history, nameof(history), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/xref/v2/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["history"] = Convert.ToString(false);
                if (history != null)
                    callPayload.Queries["history"] = SourceExpressionConverter.ConvertO(history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetHistoricalAvRecordsBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bool> history = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(history, nameof(history), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/xref/v2/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (history != null)
                    callPayload.Queries["history"] = SourceExpressionConverter.ConvertO(history);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisMerged([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisLatest([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisSpecific([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> analysisId, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(analysisId, nameof(analysisId), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(analysisId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisArchiveMerged([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisArchiveLatest([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DownloadSample([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSampleDownloadStatus([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/status/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/octet-stream");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSample([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType)
        {
            SourceExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSampleMetadata([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> subscribe = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(subscribe, nameof(subscribe), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}/meta", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (subscribe != null)
                    callPayload.Queries["subscribe"] = SourceExpressionConverter.ConvertO(subscribe);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteSampleSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> deleteOn = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(deleteOn, nameof(deleteOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deleteOn != null)
                    callPayload.Queries["delete_on"] = SourceExpressionConverter.ConvertO(deleteOn);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteSamplesBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string> bodyrlquerydeleteOn = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlquerydeleteOn, nameof(bodyrlquerydeleteOn), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlquerydeleteOn != null)
                {
                    queryObject["delete_on"] = SourceExpressionConverter.ConvertToken(bodyrlquerydeleteOn);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleSingle([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> hashValue)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleBulk([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/bulk_query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryhashType != null)
                {
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubscribeToReputationChanges([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/subscribe/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UnsubscribeFromReputationChanges([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryhashTypeInput> bodyrlqueryhashType = null, [WorkflowExpression] Func<string[]> bodyrlqueryhashes = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryhashType, nameof(bodyrlqueryhashType), required: false);
            SourceExpression.Validate(bodyrlqueryhashes, nameof(bodyrlqueryhashes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/unsubscribe/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["hash_type"] = SourceExpressionConverter.Convert(bodyrlqueryhashType);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryhashes != null)
                {
                    queryObject["hashes"] = SourceExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SetStartTimeForReputationChanges([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(timeValue, nameof(timeValue), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/start/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetReputationDataChanges([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> events = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(events, nameof(events), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/feed/data_change/v3/pull";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (events != null)
                    callPayload.Queries["events"] = SourceExpressionConverter.ConvertO(events);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetContinuousReputationDataChanges([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> events = null)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(timeValue, nameof(timeValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(events, nameof(events), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (events != null)
                    callPayload.Queries["events"] = SourceExpressionConverter.ConvertO(events);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubmitSampleForDynamicAnalysis([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<string> bodyrlsha1 = null, [WorkflowExpression] Func<string> bodyrlurl = null, [WorkflowExpression] Func<string> bodyrlplatform = null, [WorkflowExpression] Func<bodyrlresponseFormatInput> bodyrlresponseFormat = null, [WorkflowExpression] Func<string> bodyrloptionalParameters = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            SourceExpression.Validate(bodyrlurl, nameof(bodyrlurl), required: false);
            SourceExpression.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            SourceExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            SourceExpression.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (bodyrlsha1 != null)
                {
                    rlObject["sha1"] = SourceExpressionConverter.ConvertToken(bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (bodyrlurl != null)
                {
                    rlObject["url"] = SourceExpressionConverter.ConvertToken(bodyrlurl);
                    rlObjectpropCount++;
                }

                if (bodyrlplatform != null)
                {
                    rlObject["platform"] = SourceExpressionConverter.ConvertToken(bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (bodyrlresponseFormat != null)
                {
                    if (bodyrlresponseFormat != null)
                    {
                        rlObject["response_format"] = SourceExpressionConverter.Convert(bodyrlresponseFormat);
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
                    rlObject["optional_parameters"] = SourceExpressionConverter.ConvertToken(bodyrloptionalParameters);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubmitArchiveForDynamicAnalysis([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<string> bodyrlsha1 = null, [WorkflowExpression] Func<string> bodyrlplatform = null, [WorkflowExpression] Func<string> bodyrlresponseFormat = null, [WorkflowExpression] Func<string> bodyrloptionalParameters = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlsha1, nameof(bodyrlsha1), required: false);
            SourceExpression.Validate(bodyrlplatform, nameof(bodyrlplatform), required: false);
            SourceExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            SourceExpression.Validate(bodyrloptionalParameters, nameof(bodyrloptionalParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/archive/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                if (bodyrlsha1 != null)
                {
                    rlObject["sha1"] = SourceExpressionConverter.ConvertToken(bodyrlsha1);
                    rlObjectpropCount++;
                }

                if (bodyrlplatform != null)
                {
                    rlObject["platform"] = SourceExpressionConverter.ConvertToken(bodyrlplatform);
                    rlObjectpropCount++;
                }

                if (bodyrlresponseFormat != null)
                {
                    rlObject["response_format"] = SourceExpressionConverter.ConvertToken(bodyrlresponseFormat);
                    rlObjectpropCount++;
                }

                if (bodyrloptionalParameters != null)
                {
                    rlObject["optional_parameters"] = SourceExpressionConverter.ConvertToken(bodyrloptionalParameters);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchSha1FirstPage([WorkflowExpression] Func<string> uriSha1, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> classification = null)
        {
            SourceExpression.Validate(uriSha1, nameof(uriSha1), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(classification, nameof(classification), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uriSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (classification != null)
                    callPayload.Queries["classification"] = SourceExpressionConverter.ConvertO(classification);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchSha1Paging([WorkflowExpression] Func<string> uriSha1, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> classification = null)
        {
            SourceExpression.Validate(uriSha1, nameof(uriSha1), required: true);
            SourceExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(classification, nameof(classification), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uriSha1, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (classification != null)
                    callPayload.Queries["classification"] = SourceExpressionConverter.ConvertO(classification);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchTextPaging([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> bodyrlqueryuri = null, [WorkflowExpression] Func<string> bodyrlquerynextPageSha1 = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(bodyrlqueryuri, nameof(bodyrlqueryuri), required: false);
            SourceExpression.Validate(bodyrlquerynextPageSha1, nameof(bodyrlquerynextPageSha1), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/uri_index/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyrlqueryuri != null)
                {
                    queryObject["uri"] = SourceExpressionConverter.ConvertToken(bodyrlqueryuri);
                    queryObjectpropCount++;
                }

                if (bodyrlquerynextPageSha1 != null)
                {
                    queryObject["next_page_sha1"] = SourceExpressionConverter.ConvertToken(bodyrlquerynextPageSha1);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/report/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["url"] = SourceExpressionConverter.ConvertToken(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromURL([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<string> bodyrlqueryanalysisId = null, [WorkflowExpression] Func<bool> bodyrlquerylastAnalysis = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            SourceExpression.Validate(bodyrlqueryanalysisId, nameof(bodyrlqueryanalysisId), required: false);
            SourceExpression.Validate(bodyrlquerylastAnalysis, nameof(bodyrlquerylastAnalysis), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            SourceExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/downloaded_files/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["url"] = SourceExpressionConverter.ConvertToken(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryanalysisId != null)
                {
                    queryObject["analysis_id"] = SourceExpressionConverter.ConvertToken(bodyrlqueryanalysisId);
                    queryObjectpropCount++;
                }

                if (bodyrlquerylastAnalysis != null)
                {
                    queryObject["last_analysis"] = SourceExpressionConverter.ConvertToken(bodyrlquerylastAnalysis);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = SourceExpressionConverter.ConvertToken(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = SourceExpressionConverter.ConvertToken(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetLatestURLAnalysesFirst([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/networking/url/v1/notifications/query/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetLatestURLAnalysesPaging([WorkflowExpression] Func<string> page, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/latest/page/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetTimestampedURLAnalysesFirst([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(startTime, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetTimestampedURLAnalysesPaging([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> startTime, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(startTime, nameof(startTime), required: true);
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}/page/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(startTime, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction AnalyzeURL([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryurl = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryurl, nameof(bodyrlqueryurl), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/analyze/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["url"] = SourceExpressionConverter.ConvertToken(bodyrlqueryurl);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/domain/report/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["domain"] = SourceExpressionConverter.ConvertToken(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromDomain([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            SourceExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/domain/downloaded_files/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["domain"] = SourceExpressionConverter.ConvertToken(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = SourceExpressionConverter.ConvertToken(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = SourceExpressionConverter.ConvertToken(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromDomain([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/domain/urls/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["domain"] = SourceExpressionConverter.ConvertToken(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainResolutions([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/domain/resolutions/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["domain"] = SourceExpressionConverter.ConvertToken(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainRelatedDomains([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlquerydomain = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlquerydomain, nameof(bodyrlquerydomain), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/domain/related_domains/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["domain"] = SourceExpressionConverter.ConvertToken(bodyrlquerydomain);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressReport([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/ip/report/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["ip"] = SourceExpressionConverter.ConvertToken(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromIPAddress([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<bool> bodyrlqueryextended = null, [WorkflowExpression] Func<string> bodyrlqueryclassification = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlqueryextended, nameof(bodyrlqueryextended), required: false);
            SourceExpression.Validate(bodyrlqueryclassification, nameof(bodyrlqueryclassification), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/ip/downloaded_files/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["ip"] = SourceExpressionConverter.ConvertToken(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryextended != null)
                {
                    queryObject["extended"] = SourceExpressionConverter.ConvertToken(bodyrlqueryextended);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryclassification != null)
                {
                    queryObject["classification"] = SourceExpressionConverter.ConvertToken(bodyrlqueryclassification);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromIPAddress([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/ip/urls/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["ip"] = SourceExpressionConverter.ConvertToken(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressResolutions([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> bodyrlqueryip = null, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null, [WorkflowExpression] Func<int> bodyrlquerylimit = null, [WorkflowExpression] Func<string> bodyrlquerypage = null)
        {
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(bodyrlqueryip, nameof(bodyrlqueryip), required: false);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            SourceExpression.Validate(bodyrlquerylimit, nameof(bodyrlquerylimit), required: false);
            SourceExpression.Validate(bodyrlquerypage, nameof(bodyrlquerypage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/ip/resolutions/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                    queryObject["ip"] = SourceExpressionConverter.ConvertToken(bodyrlqueryip);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyrlquerylimit);
                    queryObjectpropCount++;
                }

                if (bodyrlquerypage != null)
                {
                    queryObject["page"] = SourceExpressionConverter.ConvertToken(bodyrlquerypage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DailyAPIUsageUser([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DailyAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/daily";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction MonthlyAPIUsageUser([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> month = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(month, nameof(month), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (month != null)
                    callPayload.Queries["month"] = SourceExpressionConverter.ConvertO(month);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction MonthlyAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> month = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(month, nameof(month), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/monthly";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (month != null)
                    callPayload.Queries["month"] = SourceExpressionConverter.ConvertO(month);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DateRangeAPIUsageUser([WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DateRangeAPIUsageCompany([WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/company/date_range";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetActiveYARARulesets([WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/usage/yara";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetAPIQuotaLimitsUser([WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/limits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetAPIQuotaLimitsCompany([WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/customer_usage/v1/limits/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction NetworkReputationApi([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlquerynetworkLocationsInputItem[]> bodyrlquerynetworkLocations, [WorkflowExpression] Func<bodyrlqueryresponseFormatInput> bodyrlqueryresponseFormat = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlquerynetworkLocations, nameof(bodyrlquerynetworkLocations), required: true);
            SourceExpression.Validate(bodyrlqueryresponseFormat, nameof(bodyrlqueryresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/reputation/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rlObject = new JObject();
                var rlObjectpropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                queryObjectpropCount++;
                queryObject["network_locations"] = SourceExpressionConverter.ConvertToken(bodyrlquerynetworkLocations);
                if (bodyrlqueryresponseFormat != null)
                {
                    if (bodyrlqueryresponseFormat != null)
                    {
                        queryObject["response_format"] = SourceExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListUserOverride([WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> nextNetworkLocation = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(nextNetworkLocation, nameof(nextNetworkLocation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/networking/user_override/v1/query/list_overrides";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (nextNetworkLocation != null)
                    callPayload.Queries["next_network_location"] = SourceExpressionConverter.ConvertO(nextNetworkLocation);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction NetworkReputationUserOverride([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]> bodyrlqueryuserOverrideoverrideNetworkLocations = null, [WorkflowExpression] Func<string> bodyrlresponseFormat = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryuserOverrideoverrideNetworkLocations, nameof(bodyrlqueryuserOverrideoverrideNetworkLocations), required: false);
            SourceExpression.Validate(bodyrlresponseFormat, nameof(bodyrlresponseFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/networking/user_override/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    userOverrideObject["override_network_locations"] = SourceExpressionConverter.ConvertToken(bodyrlqueryuserOverrideoverrideNetworkLocations);
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
                        rlObject["response_format"] = SourceExpressionConverter.ConvertToken(bodyrlresponseFormat);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlSha1([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> specificReport, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            SourceExpression.Validate(specificReport, nameof(specificReport), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(specificReport, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlBase64([WorkflowExpression] Func<string> base64Value, [WorkflowExpression] Func<string> specificReport, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(base64Value, nameof(base64Value), required: true);
            SourceExpression.Validate(specificReport, nameof(specificReport), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(base64Value, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(specificReport, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisReportForUrlSha1([WorkflowExpression] Func<string> sha1Value, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(sha1Value, nameof(sha1Value), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisReportForUrlBase64([WorkflowExpression] Func<string> base64Value, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(base64Value, nameof(base64Value), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(base64Value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRulesetInformation([WorkflowExpression] Func<string> rulesetName)
        {
            SourceExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteYaraRuleset([WorkflowExpression] Func<string> rulesetName)
        {
            SourceExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRulesetText([WorkflowExpression] Func<string> rulesetName)
        {
            SourceExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/text", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraMatchesFeed([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(timeValue, nameof(timeValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/feed/yara/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction CreateYaraRuleset([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<bool> bodysampleAvailable, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodysampleAvailable, nameof(bodysampleAvailable), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = SourceExpressionConverter.ConvertToken(bodyrulesetName);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["sample_available"] = SourceExpressionConverter.ConvertToken(bodysampleAvailable);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroHuntingStatus([WorkflowExpression] Func<string> rulesetName)
        {
            SourceExpression.Validate(rulesetName, nameof(rulesetName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/status-retro-hunt", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroMatchesFeed([WorkflowExpression] Func<timeFormatInput> timeFormat, [WorkflowExpression] Func<string> timeValue, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(timeFormat, nameof(timeFormat), required: true);
            SourceExpression.Validate(timeValue, nameof(timeValue), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/feed/yara/retro/v1/query/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction StartYaraRetroHunt([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/start-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = SourceExpressionConverter.ConvertToken(bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction CancelYaraRetroHunt([WorkflowExpression] Func<string> bodyrulesetName, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyrulesetName, nameof(bodyrulesetName), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/admin/v1/ruleset/cancel-retro-hunt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ruleset_name"] = SourceExpressionConverter.ConvertToken(bodyrulesetName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction AdvancedSearch([WorkflowExpression] Func<bodyqueryInputItem[]> bodyquery, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<int> bodyrecordsPerPage = null, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<string> bodysort = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: false);
            SourceExpression.Validate(bodypage, nameof(bodypage), required: false);
            SourceExpression.Validate(bodysort, nameof(bodysort), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/search/v1/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodyformat != null)
                {
                    body["format"] = SourceExpressionConverter.Convert(bodyformat);
                    bodypropCount++;
                }

                if (bodyrecordsPerPage != null)
                {
                    if (bodyrecordsPerPage != null)
                    {
                        body["records_per_page"] = SourceExpressionConverter.ConvertToken(bodyrecordsPerPage);
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
                        body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
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
                        body["sort"] = SourceExpressionConverter.ConvertToken(bodysort);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GroupByRha1SingleQuery([WorkflowExpression] Func<string> rha1Type, [WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<classificationInput> classification = null)
        {
            SourceExpression.Validate(rha1Type, nameof(rha1Type), required: true);
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(extended, nameof(extended), required: false);
            SourceExpression.Validate(classification, nameof(classification), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/group_by_rha1/v1/query/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rha1Type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["extended"] = Convert.ToString(false);
                if (extended != null)
                    callPayload.Queries["extended"] = SourceExpressionConverter.ConvertO(extended);
                if (classification != null)
                    callPayload.Queries["classification"] = SourceExpressionConverter.Convert(classification);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ImportHashSimilarity([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ImportHashSimilarityPaginated([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> nextPageSha1, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashValue, nameof(hashValue), required: true);
            SourceExpression.Validate(nextPageSha1, nameof(nextPageSha1), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}/start_sha1/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction FileReputationUserOverride([WorkflowExpression] Func<postFormatInput> postFormat, [WorkflowExpression] Func<bodyrlqueryoverrideSamplesInputItem[]> bodyrlqueryoverrideSamples = null, [WorkflowExpression] Func<bodyrlqueryremoveOverrideInputItem[]> bodyrlqueryremoveOverride = null)
        {
            SourceExpression.Validate(postFormat, nameof(postFormat), required: true);
            SourceExpression.Validate(bodyrlqueryoverrideSamples, nameof(bodyrlqueryoverrideSamples), required: false);
            SourceExpression.Validate(bodyrlqueryremoveOverride, nameof(bodyrlqueryremoveOverride), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                    queryObject["override_samples"] = SourceExpressionConverter.ConvertToken(bodyrlqueryoverrideSamples);
                    queryObjectpropCount++;
                }

                if (bodyrlqueryremoveOverride != null)
                {
                    queryObject["remove_override"] = SourceExpressionConverter.ConvertToken(bodyrlqueryremoveOverride);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction FileReputationListUserOverrides([WorkflowExpression] Func<hashTypeInput> hashType, [WorkflowExpression] Func<string> startHash = null, [WorkflowExpression] Func<formatInput> format = null)
        {
            SourceExpression.Validate(hashType, nameof(hashType), required: true);
            SourceExpression.Validate(startHash, nameof(startHash), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/list_hashes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startHash != null)
                    callPayload.Queries["start_hash"] = SourceExpressionConverter.ConvertO(startHash);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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