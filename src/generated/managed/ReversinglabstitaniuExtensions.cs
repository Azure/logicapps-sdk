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
        public IWorkflowAction GetFileReputationSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["extended"] = Convert.ToString(true);
            if (extended != null)
                callPayload.Queries["extended"] = CSharpExpressionConverter.ConvertO(extended);
            callPayload.Queries["show_hashes"] = Convert.ToString(true);
            if (showHashes != null)
                callPayload.Queries["show_hashes"] = CSharpExpressionConverter.ConvertO(showHashes);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileReputationBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bool>> extended = null, Expression<Func<bool>> showHashes = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extended != null)
                callPayload.Queries["extended"] = CSharpExpressionConverter.ConvertO(extended);
            if (showHashes != null)
                callPayload.Queries["show_hashes"] = CSharpExpressionConverter.ConvertO(showHashes);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (bodyrlqueryhashType != null)
            {
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetHistoricalAvRecordsSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/xref/v2/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["history"] = Convert.ToString(false);
            if (history != null)
                callPayload.Queries["history"] = CSharpExpressionConverter.ConvertO(history);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetHistoricalAvRecordsBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bool>> history = null, Expression<Func<formatInput>> format = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/xref/v2/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (history != null)
                callPayload.Queries["history"] = CSharpExpressionConverter.ConvertO(history);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (bodyrlqueryhashType != null)
            {
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetFileAnalysisNonMaliciousBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/rldata/goodware/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/latest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisSpecific(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> analysisId, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(analysisId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisArchiveMerged(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisArchiveLatest(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/archive/query/{0}/{1}/latest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DownloadSample(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSampleDownloadStatus(Expression<Func<postFormatInput>> postFormat, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/spex/download/v2/status/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/octet-stream");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (bodyrlqueryhashType != null)
            {
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSample(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UploadSampleMetadata(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType, Expression<Func<string>> subscribe = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/spex/upload/{0}/meta", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (subscribe != null)
                callPayload.Queries["subscribe"] = CSharpExpressionConverter.ConvertO(subscribe);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue, Expression<Func<string>> deleteOn = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deleteOn != null)
                callPayload.Queries["delete_on"] = CSharpExpressionConverter.ConvertO(deleteOn);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteSamplesBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string>> bodyrlquerydeleteOn = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/delete/sample/v1/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlquerydeleteOn != null)
            {
                queryObject["delete_on"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydeleteOn);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleSingle(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> hashValue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ReanalyzeSampleBulk(Expression<Func<postFormatInput>> postFormat, Expression<Func<formatInput>> format = null, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/rescan/v1/bulk_query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (bodyrlqueryhashType != null)
            {
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubscribeToReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/subscribe/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction UnsubscribeFromReputationChanges(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryhashTypeInput>> bodyrlqueryhashType = null, Expression<Func<string[]>> bodyrlqueryhashes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/subscription/data_change/v1/bulk_query/unsubscribe/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["hash_type"] = CSharpExpressionConverter.Convert(bodyrlqueryhashType);
                queryObjectpropCount++;
            }

            if (bodyrlqueryhashes != null)
            {
                queryObject["hashes"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryhashes);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SetStartTimeForReputationChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/start/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetReputationDataChanges(Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/api/feed/data_change/v3/pull";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (events != null)
                callPayload.Queries["events"] = CSharpExpressionConverter.ConvertO(events);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetContinuousReputationDataChanges(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null, Expression<Func<string>> events = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/feed/data_change/v3/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (events != null)
                callPayload.Queries["events"] = CSharpExpressionConverter.ConvertO(events);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubmitSampleForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<string>> bodyrlsha1 = null, Expression<Func<string>> bodyrlurl = null, Expression<Func<string>> bodyrlplatform = null, Expression<Func<bodyrlresponseFormatInput>> bodyrlresponseFormat = null, Expression<Func<string>> bodyrloptionalParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            if (bodyrlsha1 != null)
            {
                rlObject["sha1"] = CSharpExpressionConverter.ConvertToken(bodyrlsha1);
                rlObjectpropCount++;
            }

            if (bodyrlurl != null)
            {
                rlObject["url"] = CSharpExpressionConverter.ConvertToken(bodyrlurl);
                rlObjectpropCount++;
            }

            if (bodyrlplatform != null)
            {
                rlObject["platform"] = CSharpExpressionConverter.ConvertToken(bodyrlplatform);
                rlObjectpropCount++;
            }

            if (bodyrlresponseFormat != null)
            {
                if (bodyrlresponseFormat != null)
                {
                    rlObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlresponseFormat);
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
                rlObject["optional_parameters"] = CSharpExpressionConverter.ConvertToken(bodyrloptionalParameters);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction SubmitArchiveForDynamicAnalysis(Expression<Func<postFormatInput>> postFormat, Expression<Func<string>> bodyrlsha1 = null, Expression<Func<string>> bodyrlplatform = null, Expression<Func<string>> bodyrlresponseFormat = null, Expression<Func<string>> bodyrloptionalParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/analyze/v1/archive/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            if (bodyrlsha1 != null)
            {
                rlObject["sha1"] = CSharpExpressionConverter.ConvertToken(bodyrlsha1);
                rlObjectpropCount++;
            }

            if (bodyrlplatform != null)
            {
                rlObject["platform"] = CSharpExpressionConverter.ConvertToken(bodyrlplatform);
                rlObjectpropCount++;
            }

            if (bodyrlresponseFormat != null)
            {
                rlObject["response_format"] = CSharpExpressionConverter.ConvertToken(bodyrlresponseFormat);
                rlObjectpropCount++;
            }

            if (bodyrloptionalParameters != null)
            {
                rlObject["optional_parameters"] = CSharpExpressionConverter.ConvertToken(bodyrloptionalParameters);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchSha1FirstPage(Expression<Func<string>> uriSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(uriSha1, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (classification != null)
                callPayload.Queries["classification"] = CSharpExpressionConverter.ConvertO(classification);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchSha1Paging(Expression<Func<string>> uriSha1, Expression<Func<string>> nextPageSha1, Expression<Func<formatInput>> format = null, Expression<Func<string>> classification = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/uri_index/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(uriSha1, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (classification != null)
                callPayload.Queries["classification"] = CSharpExpressionConverter.ConvertO(classification);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction URIToHashSearchTextPaging(Expression<Func<string>> contentType, Expression<Func<formatInput>> format = null, Expression<Func<string>> bodyrlqueryuri = null, Expression<Func<string>> bodyrlquerynextPageSha1 = null)
        {
            var apiCallPath = "/api/uri_index/v1/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (bodyrlqueryuri != null)
            {
                queryObject["uri"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryuri);
                queryObjectpropCount++;
            }

            if (bodyrlquerynextPageSha1 != null)
            {
                queryObject["next_page_sha1"] = CSharpExpressionConverter.ConvertToken(bodyrlquerynextPageSha1);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/report/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["url"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryurl);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromURL(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<string>> bodyrlqueryanalysisId = null, Expression<Func<bool>> bodyrlquerylastAnalysis = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/downloaded_files/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["url"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryurl);
                queryObjectpropCount++;
            }

            if (bodyrlqueryanalysisId != null)
            {
                queryObject["analysis_id"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryanalysisId);
                queryObjectpropCount++;
            }

            if (bodyrlquerylastAnalysis != null)
            {
                queryObject["last_analysis"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylastAnalysis);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlqueryextended != null)
            {
                queryObject["extended"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryextended);
                queryObjectpropCount++;
            }

            if (bodyrlqueryclassification != null)
            {
                queryObject["classification"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryclassification);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetLatestURLAnalysesFirst(Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/api/networking/url/v1/notifications/query/latest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetLatestURLAnalysesPaging(Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/latest/page/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetTimestampedURLAnalysesFirst(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(startTime, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetTimestampedURLAnalysesPaging(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> startTime, Expression<Func<string>> page, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/notifications/query/from/{0}/{1}/page/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(startTime, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction AnalyzeURL(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryurl = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/url/v1/analyze/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["url"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryurl);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/domain/report/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["domain"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydomain);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromDomain(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/domain/downloaded_files/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["domain"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydomain);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlqueryextended != null)
            {
                queryObject["extended"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryextended);
                queryObjectpropCount++;
            }

            if (bodyrlqueryclassification != null)
            {
                queryObject["classification"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryclassification);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromDomain(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/domain/urls/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["domain"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydomain);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainResolutions(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/domain/resolutions/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["domain"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydomain);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDomainRelatedDomains(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlquerydomain = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/domain/related_domains/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["domain"] = CSharpExpressionConverter.ConvertToken(bodyrlquerydomain);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressReport(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/ip/report/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["ip"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryip);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListFilesFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<bool>> bodyrlqueryextended = null, Expression<Func<string>> bodyrlqueryclassification = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/ip/downloaded_files/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["ip"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryip);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlqueryextended != null)
            {
                queryObject["extended"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryextended);
                queryObjectpropCount++;
            }

            if (bodyrlqueryclassification != null)
            {
                queryObject["classification"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryclassification);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetURLFromIPAddress(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/ip/urls/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["ip"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryip);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetIPAddressResolutions(Expression<Func<formatInput>> format, Expression<Func<string>> bodyrlqueryip = null, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null, Expression<Func<int>> bodyrlquerylimit = null, Expression<Func<string>> bodyrlquerypage = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/ip/resolutions/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
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
                queryObject["ip"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryip);
                queryObjectpropCount++;
            }

            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
                queryObject["limit"] = CSharpExpressionConverter.ConvertToken(bodyrlquerylimit);
                queryObjectpropCount++;
            }

            if (bodyrlquerypage != null)
            {
                queryObject["page"] = CSharpExpressionConverter.ConvertToken(bodyrlquerypage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DailyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/daily";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DailyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> date = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/company/daily";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction MonthlyAPIUsageUser(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/monthly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (month != null)
                callPayload.Queries["month"] = CSharpExpressionConverter.ConvertO(month);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction MonthlyAPIUsageCompany(Expression<Func<formatInput>> format = null, Expression<Func<string>> month = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/company/monthly";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (month != null)
                callPayload.Queries["month"] = CSharpExpressionConverter.ConvertO(month);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DateRangeAPIUsageUser(Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/date_range";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DateRangeAPIUsageCompany(Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/company/date_range";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetActiveYARARulesets(Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = "/api/customer_usage/v1/usage/yara";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetAPIQuotaLimitsUser(Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = "/api/customer_usage/v1/limits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetAPIQuotaLimitsCompany(Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = "/api/customer_usage/v1/limits/company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction NetworkReputationApi(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlquerynetworkLocationsInputItem[]>> bodyrlquerynetworkLocations, Expression<Func<bodyrlqueryresponseFormatInput>> bodyrlqueryresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/reputation/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var rlObject = new JObject();
            var rlObjectpropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            queryObjectpropCount++;
            queryObject["network_locations"] = CSharpExpressionConverter.ConvertToken(bodyrlquerynetworkLocations);
            if (bodyrlqueryresponseFormat != null)
            {
                if (bodyrlqueryresponseFormat != null)
                {
                    queryObject["response_format"] = CSharpExpressionConverter.Convert(bodyrlqueryresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ListUserOverride(Expression<Func<string>> format = null, Expression<Func<string>> nextNetworkLocation = null)
        {
            var apiCallPath = "/api/networking/user_override/v1/query/list_overrides";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (nextNetworkLocation != null)
                callPayload.Queries["next_network_location"] = CSharpExpressionConverter.ConvertO(nextNetworkLocation);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction NetworkReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryuserOverrideoverrideNetworkLocationsInputItem[]>> bodyrlqueryuserOverrideoverrideNetworkLocations = null, Expression<Func<string>> bodyrlresponseFormat = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/networking/user_override/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                userOverrideObject["override_network_locations"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryuserOverrideoverrideNetworkLocations);
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
                    rlObject["response_format"] = CSharpExpressionConverter.ConvertToken(bodyrlresponseFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(specificReport, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetSpecificDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> specificReport, Expression<Func<formatInput>> format = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(base64Value, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(specificReport, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisReportForUrlSha1(Expression<Func<string>> sha1Value, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/sha1/{0}/latest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sha1Value, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetDynamicAnalysisReportForUrlBase64(Expression<Func<string>> base64Value, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/dynamic/analysis/report/v1/query/url/base64/{0}/latest", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(base64Value, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRulesetInformation(Expression<Func<string>> rulesetName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction DeleteYaraRuleset(Expression<Func<string>> rulesetName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRulesetText(Expression<Func<string>> rulesetName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/text", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/feed/yara/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction CreateYaraRuleset(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> bodytext, Expression<Func<bool>> bodysampleAvailable, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/api/yara/admin/v1/ruleset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ruleset_name"] = CSharpExpressionConverter.ConvertToken(bodyrulesetName);
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            bodypropCount++;
            body["sample_available"] = CSharpExpressionConverter.ConvertToken(bodysampleAvailable);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroHuntingStatus(Expression<Func<string>> rulesetName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/yara/admin/v1/ruleset/{0}/status-retro-hunt", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GetYaraRetroMatchesFeed(Expression<Func<timeFormatInput>> timeFormat, Expression<Func<string>> timeValue, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/feed/yara/retro/v1/query/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeFormat, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction StartYaraRetroHunt(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/api/yara/admin/v1/ruleset/start-retro-hunt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ruleset_name"] = CSharpExpressionConverter.ConvertToken(bodyrulesetName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction CancelYaraRetroHunt(Expression<Func<string>> bodyrulesetName, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/api/yara/admin/v1/ruleset/cancel-retro-hunt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ruleset_name"] = CSharpExpressionConverter.ConvertToken(bodyrulesetName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction AdvancedSearch(Expression<Func<bodyqueryInputItem[]>> bodyquery, Expression<Func<bodyformatInput>> bodyformat = null, Expression<Func<int>> bodyrecordsPerPage = null, Expression<Func<int>> bodypage = null, Expression<Func<string>> bodysort = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/api/search/v1/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
            if (bodyformat != null)
            {
                body["format"] = CSharpExpressionConverter.Convert(bodyformat);
                bodypropCount++;
            }

            if (bodyrecordsPerPage != null)
            {
                if (bodyrecordsPerPage != null)
                {
                    body["records_per_page"] = CSharpExpressionConverter.ConvertToken(bodyrecordsPerPage);
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
                    body["page"] = CSharpExpressionConverter.ConvertToken(bodypage);
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
                    body["sort"] = CSharpExpressionConverter.ConvertToken(bodysort);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction GroupByRha1SingleQuery(Expression<Func<string>> rha1Type, Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null, Expression<Func<int>> limit = null, Expression<Func<bool>> extended = null, Expression<Func<classificationInput>> classification = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/group_by_rha1/v1/query/{0}/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rha1Type, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            callPayload.Queries["limit"] = Convert.ToString(1000);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            callPayload.Queries["extended"] = Convert.ToString(false);
            if (extended != null)
                callPayload.Queries["extended"] = CSharpExpressionConverter.ConvertO(extended);
            if (classification != null)
                callPayload.Queries["classification"] = CSharpExpressionConverter.Convert(classification);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ImportHashSimilarity(Expression<Func<string>> hashValue, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction ImportHashSimilarityPaginated(Expression<Func<string>> hashValue, Expression<Func<string>> nextPageSha1, Expression<Func<string>> contentType = null, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/imphash_index/v1/query/{0}/start_sha1/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(nextPageSha1, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction FileReputationUserOverride(Expression<Func<postFormatInput>> postFormat, Expression<Func<bodyrlqueryoverrideSamplesInputItem[]>> bodyrlqueryoverrideSamples = null, Expression<Func<bodyrlqueryremoveOverrideInputItem[]>> bodyrlqueryremoveOverride = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(postFormat, 1));
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
                queryObject["override_samples"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryoverrideSamples);
                queryObjectpropCount++;
            }

            if (bodyrlqueryremoveOverride != null)
            {
                queryObject["remove_override"] = CSharpExpressionConverter.ConvertToken(bodyrlqueryremoveOverride);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabstitaniu")]
        public IWorkflowAction FileReputationListUserOverrides(Expression<Func<hashTypeInput>> hashType, Expression<Func<string>> startHash = null, Expression<Func<formatInput>> format = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/databrowser/malware_presence/user_override/list_hashes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startHash != null)
                callPayload.Queries["start_hash"] = CSharpExpressionConverter.ConvertO(startHash);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            return new ApiConnectionAction(callPayload);
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