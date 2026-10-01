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
        public IWorkflowAction RetrieveDetailedReport([WorkflowExpression] Func<string[]> bodyhashValues, [WorkflowExpression] Func<string[]> bodyfields = null, [WorkflowExpression] Func<string> bodyskipReanalysis = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/samples/v2/list/details/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = SourceExpressionConverter.ConvertToken(bodyhashValues);
                if (bodyfields != null)
                {
                    body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodyskipReanalysis != null)
                {
                    body["skip_reanalysis"] = SourceExpressionConverter.ConvertToken(bodyskipReanalysis);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveStaticAnalysisReport([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string[]> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/samples/{0}/ticore/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveDynamicAnalysisReport([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<endpointInput> endpoint)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/rl_dynamic_analysis/export/summary/{0}/{1}/{2}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(endpoint, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveSummaryReport([WorkflowExpression] Func<string[]> bodyhashValues, [WorkflowExpression] Func<string[]> bodyfields = null, [WorkflowExpression] Func<string> bodyincludeNetworkthreatintelligence = null, [WorkflowExpression] Func<string> bodyskipReanalysis = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/samples/v2/list/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = SourceExpressionConverter.ConvertToken(bodyhashValues);
                if (bodyfields != null)
                {
                    body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodyincludeNetworkthreatintelligence != null)
                {
                    body["include_networkthreatintelligence"] = SourceExpressionConverter.ConvertToken(bodyincludeNetworkthreatintelligence);
                    bodypropCount++;
                }

                if (bodyskipReanalysis != null)
                {
                    body["skip_reanalysis"] = SourceExpressionConverter.ConvertToken(bodyskipReanalysis);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveProcessingStatusFiles([WorkflowExpression] Func<string[]> bodyhashValues, [WorkflowExpression] Func<string> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/samples/status/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["hash_values"] = SourceExpressionConverter.ConvertToken(bodyhashValues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveProcessingStatusUrls([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/uploads/v2/url-samples/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveClassificationForSample([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<localonlyInput> localonly = null, [WorkflowExpression] Func<avScannersInput> avScanners = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/samples/v3/{0}/classification/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (localonly != null)
                    callPayload.Queries["localonly"] = SourceExpressionConverter.Convert(localonly);
                if (avScanners != null)
                    callPayload.Queries["av_scanners"] = SourceExpressionConverter.Convert(avScanners);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CreatePdfReport([WorkflowExpression] Func<string> hash)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/pdf/{0}/create", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hash, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CheckPdfReportStatus([WorkflowExpression] Func<string> hash)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/pdf/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hash, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DownloadPdfReport([WorkflowExpression] Func<string> hash)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/pdf/{0}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hash, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveURLIntelligence([WorkflowExpression] Func<string> url)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/network-threat-intel/url/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveDomainIntelligence([WorkflowExpression] Func<string> domain)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/network-threat-intel/domain/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveIpIntelligence([WorkflowExpression] Func<string> ip)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/network-threat-intel/ip/{0}/report/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveIpToDomainResolutions([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/network-threat-intel/ip/{0}/resolutions/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveUrlsFromIp([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/network-threat-intel/ip/{0}/urls/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveFilesFromIp([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> extended = null, [WorkflowExpression] Func<string> classification = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/network-threat-intel/ip/{0}/downloaded_files/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (extended != null)
                    callPayload.Queries["extended"] = SourceExpressionConverter.ConvertO(extended);
                if (classification != null)
                    callPayload.Queries["classification"] = SourceExpressionConverter.ConvertO(classification);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction PerformAdvancedSearch([WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<int> bodyrecordsPerPage = null, [WorkflowExpression] Func<string> bodysort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/samples/v2/search/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodypage != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                if (bodyrecordsPerPage != null)
                {
                    body["records_per_page"] = SourceExpressionConverter.ConvertToken(bodyrecordsPerPage);
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    body["sort"] = SourceExpressionConverter.ConvertToken(bodysort);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveUserTagsForSample([WorkflowExpression] Func<string> sampleHash)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tag/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleHash, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteUserTagsFromSample([WorkflowExpression] Func<string> sampleHash, [WorkflowExpression] Func<string[]> bodytags)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tag/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleHash, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CreateUserTagsForSample([WorkflowExpression] Func<string> sampleHash, [WorkflowExpression] Func<string[]> bodytags)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/tag/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sampleHash, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteClassificationForSample([WorkflowExpression] Func<string> hashValue, [WorkflowExpression] Func<string> system)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/samples/{0}/setclassification/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(system, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveListOfYARARulesets([WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/v2/rulesets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveContentsOfYARARuleset([WorkflowExpression] Func<string> name)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/ruleset/content/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction RetrieveYARAMatchesForSpecifiedRulesets([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/v2/ruleset/matches/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction GetYARARulesetSynchronizationTime()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/yara/ticloud/time/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction CheckYARARetroStatusOnAppliance()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/uploads/local-retro-hunt/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction YARACloudRetroStatus([WorkflowExpression] Func<string> rulesetName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/yara/ruleset/{0}/cloud-retro-hunt/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rulesetName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DeleteSample([WorkflowExpression] Func<string> hashValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/samples/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "reversinglabsa1000")]
        public IWorkflowAction DownloadFilesExtractedFromLocalSample([WorkflowExpression] Func<string> hashValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/samples/{0}/unpacked/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hashValue, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class Reversinglabsa1000Triggers([ConnectionName] string connectionId)
    {
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