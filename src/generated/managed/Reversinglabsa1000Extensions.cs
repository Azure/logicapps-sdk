//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabsa1000
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Reversinglabsa1000Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveDetailedReport(Expression<Func<string[]>> bodyhashValues, Expression<Func<string[]>> bodyfields = null, Expression<Func<string>> bodyskipReanalysis = null)
        {
            var __workflow_bodyhashValues = WorkflowExpression.Compile(bodyhashValues, nameof(bodyhashValues), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodyskipReanalysis = WorkflowExpression.Compile(bodyskipReanalysis, nameof(bodyskipReanalysis), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/samples/v2/list/details/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = ExpressionConverter.ConvertO(__workflow_bodyhashValues);
                if (__workflow_bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (__workflow_bodyskipReanalysis != null)
                {
                    body["skip_reanalysis"] = ExpressionConverter.ConvertO(__workflow_bodyskipReanalysis);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveStaticAnalysisReport(Expression<Func<string>> hashValue, Expression<Func<string[]>> fields = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/samples/{0}/ticore/", __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveDynamicAnalysisReport(Expression<Func<string>> hashValue, Expression<Func<formatInput>> format, Expression<Func<endpointInput>> endpoint)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_endpoint = WorkflowExpression.Compile(endpoint, nameof(endpoint), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rl_dynamic_analysis/export/summary/{0}/{1}/{2}/", __workflow_hashValue.WithUrlEncoding(1), __workflow_format.WithUrlEncoding(1), __workflow_endpoint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveSummaryReport(Expression<Func<string[]>> bodyhashValues, Expression<Func<string[]>> bodyfields = null, Expression<Func<string>> bodyincludeNetworkthreatintelligence = null, Expression<Func<string>> bodyskipReanalysis = null)
        {
            var __workflow_bodyhashValues = WorkflowExpression.Compile(bodyhashValues, nameof(bodyhashValues), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodyincludeNetworkthreatintelligence = WorkflowExpression.Compile(bodyincludeNetworkthreatintelligence, nameof(bodyincludeNetworkthreatintelligence), required: false);
            var __workflow_bodyskipReanalysis = WorkflowExpression.Compile(bodyskipReanalysis, nameof(bodyskipReanalysis), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/samples/v2/list/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = ExpressionConverter.ConvertO(__workflow_bodyhashValues);
                if (__workflow_bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeNetworkthreatintelligence != null)
                {
                    body["include_networkthreatintelligence"] = ExpressionConverter.ConvertO(__workflow_bodyincludeNetworkthreatintelligence);
                    bodypropCount++;
                }

                if (__workflow_bodyskipReanalysis != null)
                {
                    body["skip_reanalysis"] = ExpressionConverter.ConvertO(__workflow_bodyskipReanalysis);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveProcessingStatusFiles(Expression<Func<string[]>> bodyhashValues, Expression<Func<string>> status = null)
        {
            var __workflow_bodyhashValues = WorkflowExpression.Compile(bodyhashValues, nameof(bodyhashValues), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/samples/status/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = ExpressionConverter.ConvertO(__workflow_bodyhashValues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveProcessingStatusUrls(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/uploads/v2/url-samples/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveClassificationForSample(Expression<Func<string>> hashValue, Expression<Func<localonlyInput>> localonly = null, Expression<Func<avScannersInput>> avScanners = null)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_localonly = WorkflowExpression.Compile(localonly, nameof(localonly), required: false);
            var __workflow_avScanners = WorkflowExpression.Compile(avScanners, nameof(avScanners), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/samples/v3/{0}/classification/", __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_localonly != null)
                    callPayload.Queries["localonly"] = ExpressionConverter.Convert(__workflow_localonly);
                if (__workflow_avScanners != null)
                    callPayload.Queries["av_scanners"] = ExpressionConverter.Convert(__workflow_avScanners);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreatePdfReport(Expression<Func<string>> hash)
        {
            var __workflow_hash = WorkflowExpression.Compile(hash, nameof(hash), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/pdf/{0}/create", __workflow_hash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckPdfReportStatus(Expression<Func<string>> hash)
        {
            var __workflow_hash = WorkflowExpression.Compile(hash, nameof(hash), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/pdf/{0}/status", __workflow_hash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadPdfReport(Expression<Func<string>> hash)
        {
            var __workflow_hash = WorkflowExpression.Compile(hash, nameof(hash), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/pdf/{0}/download", __workflow_hash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveURLIntelligence(Expression<Func<string>> url)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/network-threat-intel/url/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveDomainIntelligence(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/network-threat-intel/domain/{0}/", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveIpIntelligence(Expression<Func<string>> ip)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/network-threat-intel/ip/{0}/report/", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveIpToDomainResolutions(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/network-threat-intel/ip/{0}/resolutions/", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveUrlsFromIp(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/network-threat-intel/ip/{0}/urls/", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveFilesFromIp(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> extended = null, Expression<Func<string>> classification = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_extended = WorkflowExpression.Compile(extended, nameof(extended), required: false);
            var __workflow_classification = WorkflowExpression.Compile(classification, nameof(classification), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/network-threat-intel/ip/{0}/downloaded_files/", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_extended != null)
                    callPayload.Queries["extended"] = ExpressionConverter.Convert(__workflow_extended);
                if (__workflow_classification != null)
                    callPayload.Queries["classification"] = ExpressionConverter.Convert(__workflow_classification);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PerformAdvancedSearch(Expression<Func<string>> bodyquery = null, Expression<Func<int>> bodypage = null, Expression<Func<int>> bodyrecordsPerPage = null, Expression<Func<string>> bodysort = null)
        {
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodypage = WorkflowExpression.Compile(bodypage, nameof(bodypage), required: false);
            var __workflow_bodyrecordsPerPage = WorkflowExpression.Compile(bodyrecordsPerPage, nameof(bodyrecordsPerPage), required: false);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/samples/v2/search/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                if (__workflow_bodypage != null)
                {
                    body["page"] = ExpressionConverter.ConvertO(__workflow_bodypage);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordsPerPage != null)
                {
                    body["records_per_page"] = ExpressionConverter.ConvertO(__workflow_bodyrecordsPerPage);
                    bodypropCount++;
                }

                if (__workflow_bodysort != null)
                {
                    body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveUserTagsForSample(Expression<Func<string>> sampleHash)
        {
            var __workflow_sampleHash = WorkflowExpression.Compile(sampleHash, nameof(sampleHash), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tag/{0}/", __workflow_sampleHash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUserTagsFromSample(Expression<Func<string>> sampleHash, Expression<Func<string[]>> bodytags)
        {
            var __workflow_sampleHash = WorkflowExpression.Compile(sampleHash, nameof(sampleHash), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tag/{0}/", __workflow_sampleHash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUserTagsForSample(Expression<Func<string>> sampleHash, Expression<Func<string[]>> bodytags)
        {
            var __workflow_sampleHash = WorkflowExpression.Compile(sampleHash, nameof(sampleHash), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tag/{0}/", __workflow_sampleHash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteClassificationForSample(Expression<Func<string>> hashValue, Expression<Func<string>> system)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            var __workflow_system = WorkflowExpression.Compile(system, nameof(system), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/samples/{0}/setclassification/{1}/", __workflow_hashValue.WithUrlEncoding(1), __workflow_system.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveListOfYARARulesets(Expression<Func<string>> type = null, Expression<Func<string>> status = null, Expression<Func<string>> source = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/v2/rulesets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveContentsOfYARARuleset(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/ruleset/content/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RetrieveYARAMatchesForSpecifiedRulesets(Expression<Func<string>> name, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/v2/ruleset/matches/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetYARARulesetSynchronizationTime()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/yara/ticloud/time/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckYARARetroStatusOnAppliance()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/uploads/local-retro-hunt/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> YARACloudRetroStatus(Expression<Func<string>> rulesetName)
        {
            var __workflow_rulesetName = WorkflowExpression.Compile(rulesetName, nameof(rulesetName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/yara/ruleset/{0}/cloud-retro-hunt/", __workflow_rulesetName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSample(Expression<Func<string>> hashValue)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/samples/{0}/", __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFilesExtractedFromLocalSample(Expression<Func<string>> hashValue)
        {
            var __workflow_hashValue = WorkflowExpression.Compile(hashValue, nameof(hashValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/samples/{0}/unpacked/", __workflow_hashValue.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Reversinglabsa1000Triggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "pdf")]
        Pdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum endpointInput
    {
        [EnumMember(Value = "create")]
        Create,
        [EnumMember(Value = "download")]
        Download,
        [EnumMember(Value = "status")]
        Status
    }

    public enum localonlyInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum avScannersInput
    {
        _0 = 0,
        _1 = 1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabsa1000;

    public partial class WorkflowManagedActions
    {
        public Reversinglabsa1000Actions Reversinglabsa1000(string connectionId) => new Reversinglabsa1000Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Reversinglabsa1000Triggers Reversinglabsa1000(string connectionId) => new Reversinglabsa1000Triggers(connectionId);
    }
}