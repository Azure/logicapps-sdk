//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Reversinglabsa1000
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Reversinglabsa1000Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveDetailedReport(Expression<Func<string[]>> bodyhashValues, Expression<Func<string[]>> bodyfields = null, Expression<Func<string>> bodyskipReanalysis = null)
        {
            var apiCallPath = "/api/samples/v2/list/details/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["hash_values"] = ExpressionConverter.ConvertO(bodyhashValues);
            if (bodyfields != null)
            {
                body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                bodypropCount++;
            }

            if (bodyskipReanalysis != null)
            {
                body["skip_reanalysis"] = ExpressionConverter.ConvertO(bodyskipReanalysis);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction SubmitSampleForAnalysis(Expression<Func<object>> file = null, Expression<Func<string>> url = null, Expression<Func<string>> filename = null, Expression<Func<analysisInput>> analysis = null, Expression<Func<string>> tags = null, Expression<Func<string>> comment = null, Expression<Func<crawlerInput>> crawler = null, Expression<Func<string>> archivePassword = null, Expression<Func<rlCloudSandboxPlatformInput>> rlCloudSandboxPlatform = null)
        {
            var apiCallPath = "/api/uploads/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveStaticAnalysisReport(Expression<Func<string>> hashValue, Expression<Func<string[]>> fields = null)
        {
            var apiCallPath = String.Format("/api/v2/samples/{0}/ticore/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveDynamicAnalysisReport(Expression<Func<string>> hashValue, Expression<Func<formatInput>> format, Expression<Func<endpointInput>> endpoint)
        {
            var apiCallPath = String.Format("/api/rl_dynamic_analysis/export/summary/{0}/{1}/{2}/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(format, 1), ExpressionConverter.ConvertWithUrlEncoding(endpoint, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveSummaryReport(Expression<Func<string[]>> bodyhashValues, Expression<Func<string[]>> bodyfields = null, Expression<Func<string>> bodyincludeNetworkthreatintelligence = null, Expression<Func<string>> bodyskipReanalysis = null)
        {
            var apiCallPath = "/api/samples/v2/list/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["hash_values"] = ExpressionConverter.ConvertO(bodyhashValues);
            if (bodyfields != null)
            {
                body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                bodypropCount++;
            }

            if (bodyincludeNetworkthreatintelligence != null)
            {
                body["include_networkthreatintelligence"] = ExpressionConverter.ConvertO(bodyincludeNetworkthreatintelligence);
                bodypropCount++;
            }

            if (bodyskipReanalysis != null)
            {
                body["skip_reanalysis"] = ExpressionConverter.ConvertO(bodyskipReanalysis);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveProcessingStatusFiles(Expression<Func<string[]>> bodyhashValues, Expression<Func<string>> status = null)
        {
            var apiCallPath = "/api/samples/status/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["hash_values"] = ExpressionConverter.ConvertO(bodyhashValues);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveProcessingStatusUrls(Expression<Func<int>> iD)
        {
            var apiCallPath = String.Format("/api/uploads/v2/url-samples/{0}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveClassificationForSample(Expression<Func<string>> hashValue, Expression<Func<localonlyInput>> localonly = null, Expression<Func<avScannersInput>> avScanners = null)
        {
            var apiCallPath = String.Format("/api/samples/v3/{0}/classification/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (localonly != null)
                callPayload.Queries["localonly"] = ExpressionConverter.Convert(localonly);
            if (avScanners != null)
                callPayload.Queries["av_scanners"] = ExpressionConverter.Convert(avScanners);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CreatePdfReport(Expression<Func<string>> hash)
        {
            var apiCallPath = String.Format("/api/pdf/{0}/create", ExpressionConverter.ConvertWithUrlEncoding(hash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CheckPdfReportStatus(Expression<Func<string>> hash)
        {
            var apiCallPath = String.Format("/api/pdf/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(hash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DownloadPdfReport(Expression<Func<string>> hash)
        {
            var apiCallPath = String.Format("/api/pdf/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(hash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveURLIntelligence(Expression<Func<string>> url)
        {
            var apiCallPath = "/api/network-threat-intel/url/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = ExpressionConverter.Convert(url);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveDomainIntelligence(Expression<Func<string>> domain)
        {
            var apiCallPath = String.Format("/api/network-threat-intel/domain/{0}/", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveIpIntelligence(Expression<Func<string>> ip)
        {
            var apiCallPath = String.Format("/api/network-threat-intel/ip/{0}/report/", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveIpToDomainResolutions(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/api/network-threat-intel/ip/{0}/resolutions/", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveUrlsFromIp(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/api/network-threat-intel/ip/{0}/urls/", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveFilesFromIp(Expression<Func<string>> ip, Expression<Func<string>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> extended = null, Expression<Func<string>> classification = null)
        {
            var apiCallPath = String.Format("/api/network-threat-intel/ip/{0}/downloaded_files/", ExpressionConverter.ConvertWithUrlEncoding(ip, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            if (extended != null)
                callPayload.Queries["extended"] = ExpressionConverter.Convert(extended);
            if (classification != null)
                callPayload.Queries["classification"] = ExpressionConverter.Convert(classification);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction PerformAdvancedSearch(Expression<Func<string>> bodyquery = null, Expression<Func<int>> bodypage = null, Expression<Func<int>> bodyrecordsPerPage = null, Expression<Func<string>> bodysort = null)
        {
            var apiCallPath = "/api/samples/v2/search/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquery != null)
            {
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
            }

            if (bodypage != null)
            {
                body["page"] = ExpressionConverter.ConvertO(bodypage);
                bodypropCount++;
            }

            if (bodyrecordsPerPage != null)
            {
                body["records_per_page"] = ExpressionConverter.ConvertO(bodyrecordsPerPage);
                bodypropCount++;
            }

            if (bodysort != null)
            {
                body["sort"] = ExpressionConverter.ConvertO(bodysort);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveUserTagsForSample(Expression<Func<string>> sampleHash)
        {
            var apiCallPath = String.Format("/api/tag/{0}/", ExpressionConverter.ConvertWithUrlEncoding(sampleHash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteUserTagsFromSample(Expression<Func<string>> sampleHash, Expression<Func<string[]>> bodytags)
        {
            var apiCallPath = String.Format("/api/tag/{0}/", ExpressionConverter.ConvertWithUrlEncoding(sampleHash, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["tags"] = ExpressionConverter.ConvertO(bodytags);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CreateUserTagsForSample(Expression<Func<string>> sampleHash, Expression<Func<string[]>> bodytags)
        {
            var apiCallPath = String.Format("/api/tag/{0}/", ExpressionConverter.ConvertWithUrlEncoding(sampleHash, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["tags"] = ExpressionConverter.ConvertO(bodytags);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteClassificationForSample(Expression<Func<string>> hashValue, Expression<Func<string>> system)
        {
            var apiCallPath = String.Format("/api/samples/{0}/setclassification/{1}/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(system, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction SetClassificationForSample(Expression<Func<string>> hashValue, Expression<Func<string>> system, Expression<Func<string>> classification, Expression<Func<string>> riskScore = null, Expression<Func<string>> threatPlatform = null, Expression<Func<string>> threatType = null, Expression<Func<string>> threatName = null)
        {
            var apiCallPath = String.Format("/api/samples/{0}/setclassification/{1}/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1), ExpressionConverter.ConvertWithUrlEncoding(system, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveListOfYARARulesets(Expression<Func<string>> type = null, Expression<Func<string>> status = null, Expression<Func<string>> source = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/api/yara/v2/rulesets/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (source != null)
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveContentsOfYARARuleset(Expression<Func<string>> name)
        {
            var apiCallPath = "/api/yara/ruleset/content/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveYARAMatchesForSpecifiedRulesets(Expression<Func<string>> name, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/api/yara/v2/ruleset/matches/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteYARARuleset(Expression<Func<string>> name, Expression<Func<bool>> publish = null)
        {
            var apiCallPath = "/api/yara/ruleset/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CreateUpdateYARARuleset(Expression<Func<string>> name, Expression<Func<string>> content, Expression<Func<bool>> publish = null, Expression<Func<bool>> ticloud = null)
        {
            var apiCallPath = "/api/yara/ruleset/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction EnableDisableYARARuleset(Expression<Func<string>> enableDisable, Expression<Func<string>> name, Expression<Func<bool>> publish = null)
        {
            var apiCallPath = String.Format("/api/yara/ruleset/{0}/", ExpressionConverter.ConvertWithUrlEncoding(enableDisable, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction GetYARARulesetSynchronizationTime()
        {
            var apiCallPath = "/api/yara/ticloud/time/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction SetYARARulesetSynchronizationTime(Expression<Func<string>> time)
        {
            var apiCallPath = "/api/yara/ticloud/time/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CheckYARARetroStatusOnAppliance()
        {
            var apiCallPath = "/api/uploads/local-retro-hunt/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction StartStopYARARetroScan(Expression<Func<string>> operation)
        {
            var apiCallPath = "/api/uploads/local-retro-hunt/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction YARACloudRetroStatus(Expression<Func<string>> rulesetName)
        {
            var apiCallPath = String.Format("/api/yara/ruleset/{0}/cloud-retro-hunt/", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction ManageYARACloudRetroScans(Expression<Func<string>> rulesetName, Expression<Func<string>> operation)
        {
            var apiCallPath = String.Format("/api/yara/ruleset/{0}/cloud-retro-hunt/", ExpressionConverter.ConvertWithUrlEncoding(rulesetName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction ListContainersForEveryHash(Expression<Func<string[]>> hashValues)
        {
            var apiCallPath = "/api/samples/containers/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteSample(Expression<Func<string>> hashValue)
        {
            var apiCallPath = String.Format("/api/samples/{0}/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DownloadFilesExtractedFromLocalSample(Expression<Func<string>> hashValue)
        {
            var apiCallPath = String.Format("/api/samples/{0}/unpacked/", ExpressionConverter.ConvertWithUrlEncoding(hashValue, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction ReanalyzeMultipleSamples(Expression<Func<string>> analysis, Expression<Func<string[]>> hashValue, Expression<Func<string>> rlCloudSandboxPlatform = null)
        {
            var apiCallPath = "/api/samples/v2/analyze_bulk/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class Reversinglabsa1000Triggers([ConnectionName] string connectionId)
    {
    }

    public enum analysisInput
    {
        [EnumMember(Value = "cloud")]
        Cloud
    }

    public enum crawlerInput
    {
        [EnumMember(Value = "local")]
        Local,
        [EnumMember(Value = "cloud")]
        Cloud
    }

    public enum rlCloudSandboxPlatformInput
    {
        [EnumMember(Value = "windows7")]
        Windows7,
        [EnumMember(Value = "windows10")]
        Windows10,
        [EnumMember(Value = "macos_11")]
        Macos11
    }

    public enum formatInput
    {
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "pdf")]
        Pdf
    }

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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum avScannersInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
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