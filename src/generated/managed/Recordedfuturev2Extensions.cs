//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturev2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Recordedfuturev2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<IPEResponse, ApiConnectionActionConfiguration> IPE(Expression<Func<string>> ip, Expression<Func<string>> fields, Expression<Func<bool>> intelligenceCloud = null, Expression<Func<bool>> htmlresponse = null)
        {
            var __workflow_ip = WorkflowExpression.Compile(ip, nameof(ip), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_intelligenceCloud = WorkflowExpression.Compile(intelligenceCloud, nameof(intelligenceCloud), required: false);
            var __workflow_htmlresponse = WorkflowExpression.Compile(htmlresponse, nameof(htmlresponse), required: false);
            return new DeferredBodyAction<IPEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup/ip/{0}", __workflow_ip.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = ExpressionConverter.Convert(__workflow_intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (__workflow_htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = ExpressionConverter.Convert(__workflow_htmlresponse);
                return new ApiConnectionAction<IPEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<DEResponse, ApiConnectionActionConfiguration> DE(Expression<Func<string>> domain, Expression<Func<string>> fields, Expression<Func<bool>> intelligenceCloud = null, Expression<Func<bool>> htmlresponse = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_intelligenceCloud = WorkflowExpression.Compile(intelligenceCloud, nameof(intelligenceCloud), required: false);
            var __workflow_htmlresponse = WorkflowExpression.Compile(htmlresponse, nameof(htmlresponse), required: false);
            return new DeferredBodyAction<DEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup/domain/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = ExpressionConverter.Convert(__workflow_intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (__workflow_htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = ExpressionConverter.Convert(__workflow_htmlresponse);
                return new ApiConnectionAction<DEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<UEResponse, ApiConnectionActionConfiguration> UE(Expression<Func<string>> url, Expression<Func<string>> fields, Expression<Func<bool>> intelligenceCloud = null, Expression<Func<bool>> htmlresponse = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_intelligenceCloud = WorkflowExpression.Compile(intelligenceCloud, nameof(intelligenceCloud), required: false);
            var __workflow_htmlresponse = WorkflowExpression.Compile(htmlresponse, nameof(htmlresponse), required: false);
            return new DeferredBodyAction<UEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup/url/{0}", __workflow_url.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = ExpressionConverter.Convert(__workflow_intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (__workflow_htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = ExpressionConverter.Convert(__workflow_htmlresponse);
                return new ApiConnectionAction<UEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<HEResponse, ApiConnectionActionConfiguration> HE(Expression<Func<string>> hash, Expression<Func<string>> fields, Expression<Func<bool>> intelligenceCloud = null, Expression<Func<bool>> htmlresponse = null)
        {
            var __workflow_hash = WorkflowExpression.Compile(hash, nameof(hash), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_intelligenceCloud = WorkflowExpression.Compile(intelligenceCloud, nameof(intelligenceCloud), required: false);
            var __workflow_htmlresponse = WorkflowExpression.Compile(htmlresponse, nameof(htmlresponse), required: false);
            return new DeferredBodyAction<HEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup/hash/{0}", __workflow_hash.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = ExpressionConverter.Convert(__workflow_intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (__workflow_htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = ExpressionConverter.Convert(__workflow_htmlresponse);
                return new ApiConnectionAction<HEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<VulnEResponse, ApiConnectionActionConfiguration> VulnE(Expression<Func<string>> id, Expression<Func<string>> fields, Expression<Func<bool>> intelligenceCloud = null, Expression<Func<bool>> htmlresponse = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_intelligenceCloud = WorkflowExpression.Compile(intelligenceCloud, nameof(intelligenceCloud), required: false);
            var __workflow_htmlresponse = WorkflowExpression.Compile(htmlresponse, nameof(htmlresponse), required: false);
            return new DeferredBodyAction<VulnEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lookup/vulnerability/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = ExpressionConverter.Convert(__workflow_intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (__workflow_htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = ExpressionConverter.Convert(__workflow_htmlresponse);
                return new ApiConnectionAction<VulnEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertRulesSearchResponse, ApiConnectionActionConfiguration> AlertRulesSearch(Expression<Func<string>> freetext = null, Expression<Func<int>> limit = null)
        {
            var __workflow_freetext = WorkflowExpression.Compile(freetext, nameof(freetext), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AlertRulesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alert/rules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_freetext != null)
                    callPayload.Queries["freetext"] = ExpressionConverter.Convert(__workflow_freetext);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<AlertRulesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearch, ApiConnectionActionConfiguration> AlertNotSearch(Expression<Func<string>> alertRule, Expression<Func<string>> triggered = null, Expression<Func<int>> limit = null, Expression<Func<int>> from = null)
        {
            var __workflow_alertRule = WorkflowExpression.Compile(alertRule, nameof(alertRule), required: true);
            var __workflow_triggered = WorkflowExpression.Compile(triggered, nameof(triggered), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            return new DeferredBodyAction<AlertSearch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alert/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_triggered != null)
                    callPayload.Queries["triggered"] = ExpressionConverter.Convert(__workflow_triggered);
                callPayload.Queries["alertRule"] = ExpressionConverter.Convert(__workflow_alertRule);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                return new ApiConnectionAction<AlertSearch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertLookup, ApiConnectionActionConfiguration> AlertNotLookup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AlertLookup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/alert/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlertLookup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<PlaybookAlertSearchItem[], ApiConnectionActionConfiguration> PlaybookAlertSearch(Expression<Func<PlaybookAlertSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaybookAlertSearchItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/playbook-alert/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlaybookAlertSearchItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<PlaybookAlertLookup, ApiConnectionActionConfiguration> PlaybookAlertLookup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PlaybookAlertLookup, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/playbook-alert/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PlaybookAlertLookup>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<DetectionRuleSearchResponse, ApiConnectionActionConfiguration> DetectionRuleSearch(Expression<Func<DetectionRuleSearchInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DetectionRuleSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detection-rules/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DetectionRuleSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<RListDResponseItem[], ApiConnectionActionConfiguration> RListD(Expression<Func<pathInput>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<RListDResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fusion/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<RListDResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<SoarBulkLookupResponse, ApiConnectionActionConfiguration> SoarBulkLookup(Expression<Func<SoarBulkLookupInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SoarBulkLookupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/soar/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SoarBulkLookupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<ThreatMapActorsResponse, ApiConnectionActionConfiguration> ThreatMapActors(Expression<Func<ThreatMapActorsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ThreatMapActorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threat/map/actors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreatMapActorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<ThreatMapMalwareResponse, ApiConnectionActionConfiguration> ThreatMapMalware(Expression<Func<ThreatMapMalwareInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ThreatMapMalwareResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threat/map/malware";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ThreatMapMalwareResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<STIXIndicatorsResponse, ApiConnectionActionConfiguration> STIXIndicators(Expression<Func<STIXIndicatorsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<STIXIndicatorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threat/indicators/actors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<STIXIndicatorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<STIXMalwareIndicatorsResponse, ApiConnectionActionConfiguration> STIXMalwareIndicators(Expression<Func<STIXMalwareIndicatorsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<STIXMalwareIndicatorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threat/indicators/malware";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<STIXMalwareIndicatorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearchV2Response, ApiConnectionActionConfiguration> AlertSearch(Expression<Func<string>> triggered = null, Expression<Func<string>> alertRule = null, Expression<Func<int>> limit = null, Expression<Func<int>> from = null, Expression<Func<fieldsInput>> fields = null)
        {
            var __workflow_triggered = WorkflowExpression.Compile(triggered, nameof(triggered), required: false);
            var __workflow_alertRule = WorkflowExpression.Compile(alertRule, nameof(alertRule), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<AlertSearchV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_triggered != null)
                    callPayload.Queries["triggered"] = ExpressionConverter.Convert(__workflow_triggered);
                if (__workflow_alertRule != null)
                    callPayload.Queries["alertRule"] = ExpressionConverter.Convert(__workflow_alertRule);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<AlertSearchV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearchIdV2Response, ApiConnectionActionConfiguration> AlertSearchId(Expression<Func<string>> id, Expression<Func<fieldsInput>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<AlertSearchIdV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/alerts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<AlertSearchIdV2Response>(callPayload);
            });
        }
    }

    public class Recordedfuturev2Triggers([ConnectionName] string connectionId)
    {
    }

    public class IPEResponse
    {
        [JsonProperty("data")]
        public IPEResponseDataType Data { get; set; }
    }

    public class IPEResponseDataType
    {
        [JsonProperty("intelCard")]
        public string IntelCard { get; set; }

        [JsonProperty("risk")]
        public IPEResponseDataTypeRiskType Risk { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("html_response")]
        public string HtmlResponse { get; set; }
    }

    public class IPEResponseDataTypeRiskType
    {
        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("evidenceDetails")]
        public IPEResponseDataTypeRiskTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }

        [JsonProperty("riskString")]
        public string RiskString { get; set; }

        [JsonProperty("rules")]
        public int Rules { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }

        [JsonProperty("riskSummary")]
        public string RiskSummary { get; set; }
    }

    public class IPEResponseDataTypeRiskTypeEvidenceDetailsTypeItem
    {
        [JsonProperty("mitigationString")]
        public string MitigationString { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("evidenceString")]
        public string EvidenceString { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }
    }

    public class Links
    {
        [JsonProperty("technical")]
        public LinksTechnicalType Technical { get; set; }

        [JsonProperty("research")]
        public LinksResearchType Research { get; set; }
    }

    public class LinksTechnicalType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("stop_date")]
        public string StopDate { get; set; }

        [JsonProperty("entities")]
        public LinkEntities[] Entities { get; set; }
    }

    public class LinkEntities
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class LinksResearchType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("stop_date")]
        public string StopDate { get; set; }

        [JsonProperty("entities")]
        public LinkEntities[] Entities { get; set; }
    }

    public class DEResponse
    {
        [JsonProperty("data")]
        public DEResponseDataType Data { get; set; }
    }

    public class DEResponseDataType
    {
        [JsonProperty("intelCard")]
        public string IntelCard { get; set; }

        [JsonProperty("risk")]
        public DEResponseDataTypeRiskType Risk { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("html_response")]
        public string HtmlResponse { get; set; }
    }

    public class DEResponseDataTypeRiskType
    {
        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("evidenceDetails")]
        public DEResponseDataTypeRiskTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }

        [JsonProperty("riskString")]
        public string RiskString { get; set; }

        [JsonProperty("rules")]
        public int Rules { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }

        [JsonProperty("riskSummary")]
        public string RiskSummary { get; set; }
    }

    public class DEResponseDataTypeRiskTypeEvidenceDetailsTypeItem
    {
        [JsonProperty("mitigationString")]
        public string MitigationString { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("evidenceString")]
        public string EvidenceString { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }
    }

    public class UEResponse
    {
        [JsonProperty("data")]
        public UEResponseDataType Data { get; set; }
    }

    public class UEResponseDataType
    {
        [JsonProperty("risk")]
        public UEResponseDataTypeRiskType Risk { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("html_response")]
        public string HtmlResponse { get; set; }
    }

    public class UEResponseDataTypeRiskType
    {
        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("evidenceDetails")]
        public UEResponseDataTypeRiskTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }

        [JsonProperty("riskString")]
        public string RiskString { get; set; }

        [JsonProperty("rules")]
        public int Rules { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }

        [JsonProperty("riskSummary")]
        public string RiskSummary { get; set; }
    }

    public class UEResponseDataTypeRiskTypeEvidenceDetailsTypeItem
    {
        [JsonProperty("mitigationString")]
        public string MitigationString { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("evidenceString")]
        public string EvidenceString { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }
    }

    public class HEResponse
    {
        [JsonProperty("data")]
        public HEResponseDataType Data { get; set; }
    }

    public class HEResponseDataType
    {
        [JsonProperty("intelCard")]
        public string IntelCard { get; set; }

        [JsonProperty("risk")]
        public HEResponseDataTypeRiskType Risk { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("html_response")]
        public string HtmlResponse { get; set; }
    }

    public class HEResponseDataTypeRiskType
    {
        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("evidenceDetails")]
        public HEResponseDataTypeRiskTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }

        [JsonProperty("riskString")]
        public string RiskString { get; set; }

        [JsonProperty("rules")]
        public int Rules { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }

        [JsonProperty("riskSummary")]
        public string RiskSummary { get; set; }
    }

    public class HEResponseDataTypeRiskTypeEvidenceDetailsTypeItem
    {
        [JsonProperty("mitigationString")]
        public string MitigationString { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("evidenceString")]
        public string EvidenceString { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }
    }

    public class VulnEResponse
    {
        [JsonProperty("data")]
        public VulnEResponseDataType Data { get; set; }
    }

    public class VulnEResponseDataType
    {
        [JsonProperty("intelCard")]
        public string IntelCard { get; set; }

        [JsonProperty("risk")]
        public VulnEResponseDataTypeRiskType Risk { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("html_response")]
        public string HtmlResponse { get; set; }
    }

    public class VulnEResponseDataTypeRiskType
    {
        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("evidenceDetails")]
        public VulnEResponseDataTypeRiskTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }

        [JsonProperty("riskString")]
        public string RiskString { get; set; }

        [JsonProperty("rules")]
        public int Rules { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }

        [JsonProperty("riskSummary")]
        public string RiskSummary { get; set; }
    }

    public class VulnEResponseDataTypeRiskTypeEvidenceDetailsTypeItem
    {
        [JsonProperty("mitigationString")]
        public string MitigationString { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("criticalityLabel")]
        public string CriticalityLabel { get; set; }

        [JsonProperty("evidenceString")]
        public string EvidenceString { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }

        [JsonProperty("criticality")]
        public int Criticality { get; set; }
    }

    public class AlertRulesSearchResponse
    {
        [JsonProperty("data")]
        public AlertRulesSearchResponseDataType Data { get; set; }

        [JsonProperty("counts")]
        public AlertRulesSearchResponseCountsType Counts { get; set; }
    }

    public class AlertRulesSearchResponseDataType
    {
        [JsonProperty("results")]
        public AlertRulesSearchResponseDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class AlertRulesSearchResponseDataTypeResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AlertRulesSearchResponseCountsType
    {
        [JsonProperty("returned")]
        public int Returned { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlertSearch
    {
        [JsonProperty("data")]
        public AlertSearchDataType Data { get; set; }

        [JsonProperty("counts")]
        public AlertSearchCountsType Counts { get; set; }
    }

    public class AlertSearchDataType
    {
        [JsonProperty("results")]
        public AlertSearchDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class AlertSearchDataTypeResultsTypeItem
    {
        [JsonProperty("review")]
        public AlertReview Review { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rule")]
        public AlertRule Rule { get; set; }

        [JsonProperty("triggered")]
        public string Triggered { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertReview
    {
        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("noteDate")]
        public string NoteDate { get; set; }

        [JsonProperty("noteAuthor")]
        public string NoteAuthor { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class AlertRule
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AlertSearchCountsType
    {
        [JsonProperty("returned")]
        public int Returned { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlertLookup
    {
        [JsonProperty("data")]
        public AlertLookupDataType Data { get; set; }
    }

    public class AlertLookupDataType
    {
        [JsonProperty("review")]
        public AlertReview Review { get; set; }

        [JsonProperty("entities")]
        public AlertEntitiesItem[] Entities { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rule")]
        public AlertRule Rule { get; set; }

        [JsonProperty("triggered")]
        public string Triggered { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("counts")]
        public AlertLookupDataTypeCountsType Counts { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertEntitiesItem
    {
        [JsonProperty("trend")]
        public JToken Trend { get; set; }

        [JsonProperty("documents")]
        public AlertEntitiesItemDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("risk")]
        public JToken Risk { get; set; }

        [JsonProperty("entity")]
        public AlertEntitiesItemEntityType Entity { get; set; }
    }

    public class AlertEntitiesItemDocumentsTypeItem
    {
        [JsonProperty("references")]
        public AlertEntitiesItemDocumentsTypeItemReferencesTypeItem[] References { get; set; }

        [JsonProperty("source")]
        public AlertEntitiesItemDocumentsTypeItemSourceType Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AlertEntitiesItemDocumentsTypeItemReferencesTypeItem
    {
        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("entities")]
        public AlertEntitiesItemDocumentsTypeItemReferencesTypeItemEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class AlertEntitiesItemDocumentsTypeItemReferencesTypeItemEntitiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertEntitiesItemDocumentsTypeItemSourceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertEntitiesItemEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertLookupDataTypeCountsType
    {
        [JsonProperty("references")]
        public int References { get; set; }

        [JsonProperty("entities")]
        public int Entities { get; set; }

        [JsonProperty("documents")]
        public int Documents { get; set; }
    }

    public class PlaybookAlertSearchItem
    {
        [JsonProperty("playbook_alert_id")]
        public string PlaybookAlertId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("organisation_id")]
        public string OrganisationId { get; set; }

        [JsonProperty("organistaion_name")]
        public string OrganistaionName { get; set; }

        [JsonProperty("owner_organisation_details")]
        public PlaybookAlertSearchItemOwnerOrganisationDetailsType OwnerOrganisationDetails { get; set; }
    }

    public class PlaybookAlertSearchItemOwnerOrganisationDetailsType
    {
        [JsonProperty("organisations")]
        public PlaybookAlertSearchItemOwnerOrganisationDetailsTypeOrganisationsTypeItem[] Organisations { get; set; }

        [JsonProperty("enterprise_id")]
        public string EnterpriseId { get; set; }

        [JsonProperty("enterprise_name")]
        public string EnterpriseName { get; set; }
    }

    public class PlaybookAlertSearchItemOwnerOrganisationDetailsTypeOrganisationsTypeItem
    {
        [JsonProperty("organisation_id")]
        public string OrganisationId { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }
    }

    public class PlaybookAlertSearchInput
    {
        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("entities")]
        public PlaybookAlertSearchInputEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("statuses")]
        public PlaybookAlertSearchInputStatusesTypeItem[] Statuses { get; set; }

        [JsonProperty("priorities")]
        public PlaybookAlertSearchInputPrioritiesTypeItem[] Priorities { get; set; }

        [JsonProperty("categories")]
        public PlaybookAlertSearchInputCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("created_from_relative")]
        public PlaybookAlertSearchInputCreatedFromRelativeType? CreatedFromRelative { get; set; }

        [JsonProperty("created_until_relative")]
        public PlaybookAlertSearchInputCreatedUntilRelativeType? CreatedUntilRelative { get; set; }

        [JsonProperty("updated_from_relative")]
        public PlaybookAlertSearchInputUpdatedFromRelativeType? UpdatedFromRelative { get; set; }

        [JsonProperty("updated_until_relative")]
        public PlaybookAlertSearchInputUpdatedUntilRelativeType? UpdatedUntilRelative { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputEntitiesTypeItem
    {
        [EnumMember(Value = "ip:8.8.8.8")]
        Ip8888,
        [EnumMember(Value = "idn:google.com")]
        IdnGoogleCom,
        [EnumMember(Value = "url:https://google.com")]
        UrlHttpsGoogleCom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputStatusesTypeItem
    {
        New,
        InProgress,
        Dismissed,
        Resolved
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputPrioritiesTypeItem
    {
        High,
        Moderate,
        Informational
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputCategoriesTypeItem
    {
        [EnumMember(Value = "domain_abuse")]
        DomainAbuse,
        [EnumMember(Value = "cyber_vulnerability")]
        CyberVulnerability,
        [EnumMember(Value = "code_repo_leakage")]
        CodeRepoLeakage
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputCreatedFromRelativeType
    {
        [EnumMember(Value = "-5m")]
        _5m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputCreatedUntilRelativeType
    {
        [EnumMember(Value = "-0m")]
        _0m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputUpdatedFromRelativeType
    {
        [EnumMember(Value = "-5m")]
        _5m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaybookAlertSearchInputUpdatedUntilRelativeType
    {
        [EnumMember(Value = "-0m")]
        _0m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    public class PlaybookAlertLookup
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("rule_label")]
        public string RuleLabel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("targets")]
        public string Targets { get; set; }

        [JsonProperty("created_date")]
        public string CreatedDate { get; set; }

        [JsonProperty("updated_date")]
        public string UpdatedDate { get; set; }

        [JsonProperty("evidence_summary")]
        public string EvidenceSummary { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("json_alert")]
        public string JsonAlert { get; set; }

        [JsonProperty("alert_description")]
        public string AlertDescription { get; set; }
    }

    public class DetectionRuleSearchResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("result")]
        public DetectionRuleSearchResponseResultTypeItem[] Result { get; set; }
    }

    public class DetectionRuleSearchResponseResultTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rules")]
        public DetectionRuleSearchResponseResultTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class DetectionRuleSearchResponseResultTypeItemRulesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("entities")]
        public DetectionRuleSearchResponseResultTypeItemRulesTypeItemEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class DetectionRuleSearchResponseResultTypeItemRulesTypeItemEntitiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public class DetectionRuleSearchInput
    {
        [JsonProperty("types")]
        public DetectionRuleSearchInputTypesTypeItem[] Types { get; set; }

        [JsonProperty("entities")]
        public DetectionRuleSearchInputEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("created")]
        public DetectionRuleSearchInputCreatedType Created { get; set; }

        [JsonProperty("limit")]
        public DetectionRuleSearchInputLimitType? Limit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DetectionRuleSearchInputTypesTypeItem
    {
        [EnumMember(Value = "sigma")]
        Sigma,
        [EnumMember(Value = "yara")]
        Yara,
        [EnumMember(Value = "snort")]
        Snort
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DetectionRuleSearchInputEntitiesTypeItem
    {
        [EnumMember(Value = "CVE-2000-01")]
        CVE200001,
        [EnumMember(Value = "mitre:TA0001")]
        MitreTA0001
    }

    public class DetectionRuleSearchInputCreatedType
    {
        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }
    }

    public enum DetectionRuleSearchInputLimitType
    {
        _1 = 1,
        _10 = 10,
        _100 = 100
    }

    public class RListDResponseItem
    {
        public string Name { get; set; }
        public int Risk { get; set; }
        public string RiskString { get; set; }
        public RListDResponseItemEvidenceDetailsType EvidenceDetails { get; set; }
    }

    public class RListDResponseItemEvidenceDetailsType
    {
        public RListDResponseItemEvidenceDetailsTypeEvidenceDetailsTypeItem[] EvidenceDetails { get; set; }
    }

    public class RListDResponseItemEvidenceDetailsTypeEvidenceDetailsTypeItem
    {
        public string Rule { get; set; }
        public string EvidenceString { get; set; }
        public string CriticalityLabel { get; set; }
        public int Timestamp { get; set; }
        public string MitigationString { get; set; }
        public int Criticality { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum pathInput
    {
        [EnumMember(Value = "/public/MicrosoftAzure/ip_default.json")]
        PublicMicrosoftAzureIpDefaultJson,
        [EnumMember(Value = "/public/MicrosoftAzure/ip_gt_90.json")]
        PublicMicrosoftAzureIpGt90Json,
        [EnumMember(Value = "/public/MicrosoftAzure/ip_active_c2.json")]
        PublicMicrosoftAzureIpActiveC2Json,
        [EnumMember(Value = "/public/MicrosoftAzure/ip_current_c2.json")]
        PublicMicrosoftAzureIpCurrentC2Json,
        [EnumMember(Value = "/public/MicrosoftAzure/ip_botnet.json")]
        PublicMicrosoftAzureIpBotnetJson,
        [EnumMember(Value = "/public/MicrosoftAzure/ip_insikt.json")]
        PublicMicrosoftAzureIpInsiktJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_default.json")]
        PublicMicrosoftAzureDomainDefaultJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_c2_dns.json")]
        PublicMicrosoftAzureDomainC2DnsJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_recent_weaponized.json")]
        PublicMicrosoftAzureDomainRecentWeaponizedJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_insikt.json")]
        PublicMicrosoftAzureDomainInsiktJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_covid_lure.json")]
        PublicMicrosoftAzureDomainCovidLureJson,
        [EnumMember(Value = "/public/MicrosoftAzure/domain_phishing.json")]
        PublicMicrosoftAzureDomainPhishingJson,
        [EnumMember(Value = "/public/MicrosoftAzure/url_insikt.json")]
        PublicMicrosoftAzureUrlInsiktJson,
        [EnumMember(Value = "/public/MicrosoftAzure/hash_targeting_vulns.json")]
        PublicMicrosoftAzureHashTargetingVulnsJson,
        [EnumMember(Value = "/public/MicrosoftAzure/hash_observed_testing.json")]
        PublicMicrosoftAzureHashObservedTestingJson,
        [EnumMember(Value = "/public/MicrosoftAzure/hash_malware_ssl.json")]
        PublicMicrosoftAzureHashMalwareSslJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_default.json")]
        PublicMicrosoftAzureVulnDefaultJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_gt_90.json")]
        PublicMicrosoftAzureVulnGt90Json,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_recent_active_malware.json")]
        PublicMicrosoftAzureVulnRecentActiveMalwareJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_recent_exploit_kit.json")]
        PublicMicrosoftAzureVulnRecentExploitKitJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_recent_ransomware.json")]
        PublicMicrosoftAzureVulnRecentRansomwareJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_recent_rat.json")]
        PublicMicrosoftAzureVulnRecentRatJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_exploited_itw_malware.json")]
        PublicMicrosoftAzureVulnExploitedItwMalwareJson,
        [EnumMember(Value = "/public/MicrosoftAzure/vuln_critical_cyber_signal.json")]
        PublicMicrosoftAzureVulnCriticalCyberSignalJson,
        [EnumMember(Value = "/public/prevent/c2_communicating_ips.json")]
        PublicPreventC2CommunicatingIpsJson,
        [EnumMember(Value = "/public/prevent/weaponized_domains.json")]
        PublicPreventWeaponizedDomainsJson,
        [EnumMember(Value = "/public/prevent/weaponized_urls.json")]
        PublicPreventWeaponizedUrlsJson,
        [EnumMember(Value = "/public/ukraine/ukraine_russia_ip.csv")]
        PublicUkraineUkraineRussiaIpCsv,
        [EnumMember(Value = "/public/ukraine/ukraine_russia_domain.csv")]
        PublicUkraineUkraineRussiaDomainCsv,
        [EnumMember(Value = "/public/ukraine/ukraine_russia_hash.csv")]
        PublicUkraineUkraineRussiaHashCsv,
        [EnumMember(Value = "/public/ukraine/ukraine_russia_url.csv")]
        PublicUkraineUkraineRussiaUrlCsv
    }

    public class SoarBulkLookupResponse
    {
        [JsonProperty("counts")]
        public SoarBulkLookupResponseCountsType Counts { get; set; }

        [JsonProperty("data")]
        public SoarBulkLookupResponseDataType Data { get; set; }
    }

    public class SoarBulkLookupResponseCountsType
    {
        [JsonProperty("returned")]
        public int Returned { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class SoarBulkLookupResponseDataType
    {
        [JsonProperty("results")]
        public SoarBulkLookupResponseDataTypeResultsTypeItem[] Results { get; set; }
    }

    public class SoarBulkLookupResponseDataTypeResultsTypeItem
    {
        [JsonProperty("entity")]
        public SoarBulkLookupResponseDataTypeResultsTypeItemEntityType Entity { get; set; }

        [JsonProperty("risk")]
        public SoarBulkLookupResponseDataTypeResultsTypeItemRiskType Risk { get; set; }
    }

    public class SoarBulkLookupResponseDataTypeResultsTypeItemEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SoarBulkLookupResponseDataTypeResultsTypeItemRiskType
    {
        [JsonProperty("context")]
        public JToken Context { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("rule")]
        public JToken Rule { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class SoarBulkLookupInput
    {
        [JsonProperty("ip")]
        public string[] Ip { get; set; }

        [JsonProperty("url")]
        public string[] Url { get; set; }

        [JsonProperty("domain")]
        public string[] Domain { get; set; }

        [JsonProperty("hash")]
        public string[] Hash { get; set; }

        [JsonProperty("vulnerability")]
        public string[] Vulnerability { get; set; }
    }

    public class ThreatMapActorsResponse
    {
        [JsonProperty("data")]
        public ThreatMapActors Data { get; set; }
    }

    public class ThreatMapActors
    {
        [JsonProperty("data")]
        public ThreatMapActorsDataType Data { get; set; }
    }

    public class ThreatMapActorsDataType
    {
        [JsonProperty("threat_map")]
        public ThreatMapActorsDataTypeThreatMapTypeItem[] ThreatMap { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ThreatMapActorsDataTypeThreatMapTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("categories")]
        public ThreatMapActorsDataTypeThreatMapTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("intent")]
        public int Intent { get; set; }

        [JsonProperty("opportunity")]
        public int Opportunity { get; set; }

        [JsonProperty("log_entries")]
        public ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItem[] LogEntries { get; set; }
    }

    public class ThreatMapActorsDataTypeThreatMapTypeItemCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItem
    {
        [JsonProperty("watchlist")]
        public ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItemWatchlistType Watchlist { get; set; }

        [JsonProperty("entity")]
        public ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItemEntityType Entity { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("axis")]
        public string Axis { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItemWatchlistType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapActorsDataTypeThreatMapTypeItemLogEntriesTypeItemEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapActorsInput
    {
        [JsonProperty("actors", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Actors { get; set; }

        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Categories { get; set; }

        [JsonProperty("watchlists", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Watchlists { get; set; }
    }

    public class ThreatMapMalwareResponse
    {
        [JsonProperty("data")]
        public ThreatMapMalware Data { get; set; }
    }

    public class ThreatMapMalware
    {
        [JsonProperty("data")]
        public ThreatMapMalwareDataType Data { get; set; }
    }

    public class ThreatMapMalwareDataType
    {
        [JsonProperty("threat_map")]
        public ThreatMapMalwareDataTypeThreatMapTypeItem[] ThreatMap { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ThreatMapMalwareDataTypeThreatMapTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("categories")]
        public ThreatMapMalwareDataTypeThreatMapTypeItemCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("intent")]
        public int Intent { get; set; }

        [JsonProperty("opportunity")]
        public int Opportunity { get; set; }

        [JsonProperty("log_entries")]
        public ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItem[] LogEntries { get; set; }
    }

    public class ThreatMapMalwareDataTypeThreatMapTypeItemCategoriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItem
    {
        [JsonProperty("watchlist")]
        public ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItemWatchlistType Watchlist { get; set; }

        [JsonProperty("entity")]
        public ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItemEntityType Entity { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("axis")]
        public string Axis { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItemWatchlistType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapMalwareDataTypeThreatMapTypeItemLogEntriesTypeItemEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThreatMapMalwareInput
    {
        [JsonProperty("malware", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Malware { get; set; }

        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Categories { get; set; }

        [JsonProperty("watchlists", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Watchlists { get; set; }
    }

    public class STIXIndicatorsResponse
    {
        [JsonProperty("data")]
        public ThreatHuntActorsItem[] Data { get; set; }
    }

    public class ThreatHuntActorsItem
    {
        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indicator_types")]
        public string[] IndicatorTypes { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("pattern_type")]
        public string PatternType { get; set; }

        [JsonProperty("spec_version")]
        public string SpecVersion { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("valid_from")]
        public string ValidFrom { get; set; }

        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }

        [JsonProperty("external_references")]
        public ThreatHuntActorsItemExternalReferencesTypeItem[] ExternalReferences { get; set; }
    }

    public class ThreatHuntActorsItemExternalReferencesTypeItem
    {
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class STIXIndicatorsInput
    {
        [JsonProperty("actors")]
        public string[] Actors { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("watchlists")]
        public string[] Watchlists { get; set; }

        [JsonProperty("trigger_score_ip")]
        public int? TriggerScoreIp { get; set; }

        [JsonProperty("trigger_score_url")]
        public int? TriggerScoreUrl { get; set; }

        [JsonProperty("trigger_score_domain")]
        public int? TriggerScoreDomain { get; set; }

        [JsonProperty("trigger_score_hash")]
        public int? TriggerScoreHash { get; set; }

        [JsonProperty("valid_until_delta_hours")]
        public int? ValidUntilDeltaHours { get; set; }

        [JsonProperty("threat_hunt_description")]
        public string ThreatHuntDescription { get; set; }
    }

    public class STIXMalwareIndicatorsResponse
    {
        [JsonProperty("data")]
        public ThreatHuntMalwareItem[] Data { get; set; }
    }

    public class ThreatHuntMalwareItem
    {
        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("indicator_types")]
        public string[] IndicatorTypes { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("pattern_type")]
        public string PatternType { get; set; }

        [JsonProperty("spec_version")]
        public string SpecVersion { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("valid_from")]
        public string ValidFrom { get; set; }

        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }

        [JsonProperty("external_references")]
        public ThreatHuntMalwareItemExternalReferencesTypeItem[] ExternalReferences { get; set; }
    }

    public class ThreatHuntMalwareItemExternalReferencesTypeItem
    {
        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class STIXMalwareIndicatorsInput
    {
        [JsonProperty("malware")]
        public string[] Malware { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("watchlists")]
        public string[] Watchlists { get; set; }

        [JsonProperty("trigger_score_ip")]
        public int? TriggerScoreIp { get; set; }

        [JsonProperty("trigger_score_url")]
        public int? TriggerScoreUrl { get; set; }

        [JsonProperty("trigger_score_domain")]
        public int? TriggerScoreDomain { get; set; }

        [JsonProperty("trigger_score_hash")]
        public int? TriggerScoreHash { get; set; }

        [JsonProperty("valid_until_delta_hours")]
        public int? ValidUntilDeltaHours { get; set; }

        [JsonProperty("threat_hunt_description")]
        public string ThreatHuntDescription { get; set; }
    }

    public class AlertSearchV2Response
    {
        [JsonProperty("data")]
        public AlertSearchV2[] Data { get; set; }

        [JsonProperty("counts")]
        public AlertSearchV2ResponseCountsType Counts { get; set; }
    }

    public class AlertSearchV2
    {
        [JsonProperty("review")]
        public AlertReviewV2 Review { get; set; }

        [JsonProperty("owner_organisation_details")]
        public AlertOwnerV2 OwnerOrganisationDetails { get; set; }

        [JsonProperty("url")]
        public AlertURLV2 Url { get; set; }

        [JsonProperty("rule")]
        public AlertRuleV2 Rule { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hits")]
        public AlertHitsV2Item[] Hits { get; set; }

        [JsonProperty("log")]
        public AlertLogV2 Log { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ai_insights")]
        public AlertAiV2 AiInsights { get; set; }
    }

    public class AlertReviewV2
    {
        [JsonProperty("assignee")]
        public string Assignee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_in_portal")]
        public string StatusInPortal { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class AlertOwnerV2
    {
        [JsonProperty("organisations")]
        public AlertOwnerV2OrganisationsTypeItem[] Organisations { get; set; }

        [JsonProperty("enterprise_id")]
        public string EnterpriseId { get; set; }

        [JsonProperty("enterprise_name")]
        public string EnterpriseName { get; set; }
    }

    public class AlertOwnerV2OrganisationsTypeItem
    {
        [JsonProperty("organisation_id")]
        public string OrganisationId { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }
    }

    public class AlertURLV2
    {
        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("portal")]
        public string Portal { get; set; }
    }

    public class AlertRuleV2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public AlertRuleV2UrlType Url { get; set; }
    }

    public class AlertRuleV2UrlType
    {
        [JsonProperty("portal")]
        public string Portal { get; set; }
    }

    public class AlertHitsV2Item
    {
        [JsonProperty("entities")]
        public AlertHitsV2ItemEntitiesTypeItem[] Entities { get; set; }

        [JsonProperty("document")]
        public AlertHitsV2ItemDocumentType Document { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("primary_entity")]
        public AlertHitsV2ItemPrimaryEntityType PrimaryEntity { get; set; }

        [JsonProperty("analyst_note")]
        public string AnalystNote { get; set; }
    }

    public class AlertHitsV2ItemEntitiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertHitsV2ItemDocumentType
    {
        [JsonProperty("source")]
        public AlertHitsV2ItemDocumentTypeSourceType Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("authors")]
        public AlertHitsV2ItemDocumentTypeAuthorsTypeItem[] Authors { get; set; }
    }

    public class AlertHitsV2ItemDocumentTypeSourceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertHitsV2ItemDocumentTypeAuthorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertHitsV2ItemPrimaryEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AlertLogV2
    {
        [JsonProperty("note_author")]
        public string NoteAuthor { get; set; }

        [JsonProperty("note_date")]
        public string NoteDate { get; set; }

        [JsonProperty("status_date")]
        public string StatusDate { get; set; }

        [JsonProperty("triggered")]
        public string Triggered { get; set; }

        [JsonProperty("status_change_by")]
        public string StatusChangeBy { get; set; }
    }

    public class AlertAiV2
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AlertSearchV2ResponseCountsType
    {
        [JsonProperty("returned")]
        public int Returned { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldsInput
    {
        [EnumMember(Value = "ai_insights")]
        AiInsights,
        [EnumMember(Value = "hits")]
        Hits,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "log")]
        Log,
        [EnumMember(Value = "owner_organisation_details")]
        OwnerOrganisationDetails,
        [EnumMember(Value = "review")]
        Review,
        [EnumMember(Value = "rule")]
        Rule,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "id, hits")]
        IdHits
    }

    public class AlertSearchIdV2Response
    {
        [JsonProperty("data")]
        public AlertSearchV2 Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturev2;

    public partial class WorkflowManagedActions
    {
        public Recordedfuturev2Actions Recordedfuturev2(string connectionId) => new Recordedfuturev2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Recordedfuturev2Triggers Recordedfuturev2(string connectionId) => new Recordedfuturev2Triggers(connectionId);
    }
}