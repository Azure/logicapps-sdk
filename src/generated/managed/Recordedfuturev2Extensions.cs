//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfuturev2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Recordedfuturev2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<IPEResponse> IPE([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<bool> intelligenceCloud = null, [WorkflowExpression] Func<bool> htmlresponse = null)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: true);
            SourceExpression.Validate(intelligenceCloud, nameof(intelligenceCloud), required: false);
            SourceExpression.Validate(htmlresponse, nameof(htmlresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/ip/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = SourceExpressionConverter.ConvertO(intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = SourceExpressionConverter.ConvertO(htmlresponse);
                return callPayload;
            }

            return new ApiConnectionAction<IPEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<DEResponse> DE([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<bool> intelligenceCloud = null, [WorkflowExpression] Func<bool> htmlresponse = null)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: true);
            SourceExpression.Validate(intelligenceCloud, nameof(intelligenceCloud), required: false);
            SourceExpression.Validate(htmlresponse, nameof(htmlresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/domain/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = SourceExpressionConverter.ConvertO(intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = SourceExpressionConverter.ConvertO(htmlresponse);
                return callPayload;
            }

            return new ApiConnectionAction<DEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<UEResponse> UE([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<bool> intelligenceCloud = null, [WorkflowExpression] Func<bool> htmlresponse = null)
        {
            SourceExpression.Validate(url, nameof(url), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: true);
            SourceExpression.Validate(intelligenceCloud, nameof(intelligenceCloud), required: false);
            SourceExpression.Validate(htmlresponse, nameof(htmlresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/url/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(url, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = SourceExpressionConverter.ConvertO(intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = SourceExpressionConverter.ConvertO(htmlresponse);
                return callPayload;
            }

            return new ApiConnectionAction<UEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<HEResponse> HE([WorkflowExpression] Func<string> hash, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<bool> intelligenceCloud = null, [WorkflowExpression] Func<bool> htmlresponse = null)
        {
            SourceExpression.Validate(hash, nameof(hash), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: true);
            SourceExpression.Validate(intelligenceCloud, nameof(intelligenceCloud), required: false);
            SourceExpression.Validate(htmlresponse, nameof(htmlresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/hash/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hash, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = SourceExpressionConverter.ConvertO(intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = SourceExpressionConverter.ConvertO(htmlresponse);
                return callPayload;
            }

            return new ApiConnectionAction<HEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<VulnEResponse> VulnE([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<bool> intelligenceCloud = null, [WorkflowExpression] Func<bool> htmlresponse = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: true);
            SourceExpression.Validate(intelligenceCloud, nameof(intelligenceCloud), required: false);
            SourceExpression.Validate(htmlresponse, nameof(htmlresponse), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/vulnerability/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (intelligenceCloud != null)
                    callPayload.Queries["IntelligenceCloud"] = SourceExpressionConverter.ConvertO(intelligenceCloud);
                callPayload.Queries["htmlresponse"] = Convert.ToString(false);
                if (htmlresponse != null)
                    callPayload.Queries["htmlresponse"] = SourceExpressionConverter.ConvertO(htmlresponse);
                return callPayload;
            }

            return new ApiConnectionAction<VulnEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertRulesSearchResponse> AlertRulesSearch([WorkflowExpression] Func<string> freetext = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(freetext, nameof(freetext), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alert/rules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (freetext != null)
                    callPayload.Queries["freetext"] = SourceExpressionConverter.ConvertO(freetext);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<AlertRulesSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearch> AlertNotSearch([WorkflowExpression] Func<string> alertRule, [WorkflowExpression] Func<string> triggered = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> from = null)
        {
            SourceExpression.Validate(alertRule, nameof(alertRule), required: true);
            SourceExpression.Validate(triggered, nameof(triggered), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alert/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (triggered != null)
                    callPayload.Queries["triggered"] = SourceExpressionConverter.ConvertO(triggered);
                callPayload.Queries["alertRule"] = SourceExpressionConverter.ConvertO(alertRule);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                return callPayload;
            }

            return new ApiConnectionAction<AlertSearch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertLookup> AlertNotLookup([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alert/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AlertLookup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<PlaybookAlertSearchItem[]> PlaybookAlertSearch([WorkflowExpression] Func<string> bodylimit = null, [WorkflowExpression] Func<bodyentitiesInputItem[]> bodyentities = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null, [WorkflowExpression] Func<bodyprioritiesInputItem[]> bodypriorities = null, [WorkflowExpression] Func<bodycategoriesInputItem[]> bodycategories = null, [WorkflowExpression] Func<bodycreatedFromRelativeInput> bodycreatedFromRelative = null, [WorkflowExpression] Func<bodycreatedUntilRelativeInput> bodycreatedUntilRelative = null, [WorkflowExpression] Func<bodyupdatedFromRelativeInput> bodyupdatedFromRelative = null, [WorkflowExpression] Func<bodyupdatedUntilRelativeInput> bodyupdatedUntilRelative = null)
        {
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            SourceExpression.Validate(bodyentities, nameof(bodyentities), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            SourceExpression.Validate(bodypriorities, nameof(bodypriorities), required: false);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            SourceExpression.Validate(bodycreatedFromRelative, nameof(bodycreatedFromRelative), required: false);
            SourceExpression.Validate(bodycreatedUntilRelative, nameof(bodycreatedUntilRelative), required: false);
            SourceExpression.Validate(bodyupdatedFromRelative, nameof(bodyupdatedFromRelative), required: false);
            SourceExpression.Validate(bodyupdatedUntilRelative, nameof(bodyupdatedUntilRelative), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/playbook-alert/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodyentities != null)
                {
                    body["entities"] = SourceExpressionConverter.ConvertToken(bodyentities);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypriorities != null)
                {
                    body["priorities"] = SourceExpressionConverter.ConvertToken(bodypriorities);
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodycreatedFromRelative != null)
                {
                    body["created_from_relative"] = SourceExpressionConverter.Convert(bodycreatedFromRelative);
                    bodypropCount++;
                }

                if (bodycreatedUntilRelative != null)
                {
                    body["created_until_relative"] = SourceExpressionConverter.Convert(bodycreatedUntilRelative);
                    bodypropCount++;
                }

                if (bodyupdatedFromRelative != null)
                {
                    body["updated_from_relative"] = SourceExpressionConverter.Convert(bodyupdatedFromRelative);
                    bodypropCount++;
                }

                if (bodyupdatedUntilRelative != null)
                {
                    body["updated_until_relative"] = SourceExpressionConverter.Convert(bodyupdatedUntilRelative);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlaybookAlertSearchItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<PlaybookAlertLookup> PlaybookAlertLookup([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/playbook-alert/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PlaybookAlertLookup>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<DetectionRuleSearchResponse> DetectionRuleSearch([WorkflowExpression] Func<bodytypesInputItem[]> bodytypes = null, [WorkflowExpression] Func<bodyentitiesInputItem[]> bodyentities = null, [WorkflowExpression] Func<string> bodycreatedbefore = null, [WorkflowExpression] Func<string> bodycreatedafter = null, [WorkflowExpression] Func<bodylimitInput> bodylimit = null)
        {
            SourceExpression.Validate(bodytypes, nameof(bodytypes), required: false);
            SourceExpression.Validate(bodyentities, nameof(bodyentities), required: false);
            SourceExpression.Validate(bodycreatedbefore, nameof(bodycreatedbefore), required: false);
            SourceExpression.Validate(bodycreatedafter, nameof(bodycreatedafter), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/detection-rules/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypes != null)
                {
                    body["types"] = SourceExpressionConverter.ConvertToken(bodytypes);
                    bodypropCount++;
                }

                if (bodyentities != null)
                {
                    body["entities"] = SourceExpressionConverter.ConvertToken(bodyentities);
                    bodypropCount++;
                }

                var createdObject = new JObject();
                var createdObjectpropCount = 0;
                if (bodycreatedbefore != null)
                {
                    createdObject["before"] = SourceExpressionConverter.ConvertToken(bodycreatedbefore);
                    createdObjectpropCount++;
                }

                if (bodycreatedafter != null)
                {
                    createdObject["after"] = SourceExpressionConverter.ConvertToken(bodycreatedafter);
                    createdObjectpropCount++;
                }

                if (createdObjectpropCount > 0)
                {
                    body["created"] = createdObject;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.Convert(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DetectionRuleSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<RListDResponseItem[]> RListD([WorkflowExpression] Func<pathInput> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fusion/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.Convert(path);
                return callPayload;
            }

            return new ApiConnectionAction<RListDResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<SoarBulkLookupResponse> SoarBulkLookup([WorkflowExpression] Func<string[]> bodyip = null, [WorkflowExpression] Func<string[]> bodyurl = null, [WorkflowExpression] Func<string[]> bodydomain = null, [WorkflowExpression] Func<string[]> bodyhash = null, [WorkflowExpression] Func<string[]> bodyvulnerability = null)
        {
            SourceExpression.Validate(bodyip, nameof(bodyip), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            SourceExpression.Validate(bodyhash, nameof(bodyhash), required: false);
            SourceExpression.Validate(bodyvulnerability, nameof(bodyvulnerability), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/soar/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyip != null)
                {
                    body["ip"] = SourceExpressionConverter.ConvertToken(bodyip);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodyhash != null)
                {
                    body["hash"] = SourceExpressionConverter.ConvertToken(bodyhash);
                    bodypropCount++;
                }

                if (bodyvulnerability != null)
                {
                    body["vulnerability"] = SourceExpressionConverter.ConvertToken(bodyvulnerability);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SoarBulkLookupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<ThreatMapActorsResponse> ThreatMapActors([WorkflowExpression] Func<string[]> bodyactors, [WorkflowExpression] Func<string[]> bodycategories, [WorkflowExpression] Func<string[]> bodywatchlists)
        {
            SourceExpression.Validate(bodyactors, nameof(bodyactors), required: true);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: true);
            SourceExpression.Validate(bodywatchlists, nameof(bodywatchlists), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threat/map/actors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["actors"] = SourceExpressionConverter.ConvertToken(bodyactors);
                bodypropCount++;
                body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                bodypropCount++;
                body["watchlists"] = SourceExpressionConverter.ConvertToken(bodywatchlists);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThreatMapActorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<ThreatMapMalwareResponse> ThreatMapMalware([WorkflowExpression] Func<string[]> bodymalware, [WorkflowExpression] Func<string[]> bodycategories, [WorkflowExpression] Func<string[]> bodywatchlists)
        {
            SourceExpression.Validate(bodymalware, nameof(bodymalware), required: true);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: true);
            SourceExpression.Validate(bodywatchlists, nameof(bodywatchlists), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threat/map/malware";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["malware"] = SourceExpressionConverter.ConvertToken(bodymalware);
                bodypropCount++;
                body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                bodypropCount++;
                body["watchlists"] = SourceExpressionConverter.ConvertToken(bodywatchlists);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ThreatMapMalwareResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<STIXIndicatorsResponse> STIXIndicators([WorkflowExpression] Func<string[]> bodyactors = null, [WorkflowExpression] Func<string[]> bodycategories = null, [WorkflowExpression] Func<string[]> bodywatchlists = null, [WorkflowExpression] Func<int> bodytriggerScoreIp = null, [WorkflowExpression] Func<int> bodytriggerScoreUrl = null, [WorkflowExpression] Func<int> bodytriggerScoreDomain = null, [WorkflowExpression] Func<int> bodytriggerScoreHash = null, [WorkflowExpression] Func<int> bodyvalidUntilDeltaHours = null, [WorkflowExpression] Func<string> bodythreatHuntDescription = null)
        {
            SourceExpression.Validate(bodyactors, nameof(bodyactors), required: false);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            SourceExpression.Validate(bodywatchlists, nameof(bodywatchlists), required: false);
            SourceExpression.Validate(bodytriggerScoreIp, nameof(bodytriggerScoreIp), required: false);
            SourceExpression.Validate(bodytriggerScoreUrl, nameof(bodytriggerScoreUrl), required: false);
            SourceExpression.Validate(bodytriggerScoreDomain, nameof(bodytriggerScoreDomain), required: false);
            SourceExpression.Validate(bodytriggerScoreHash, nameof(bodytriggerScoreHash), required: false);
            SourceExpression.Validate(bodyvalidUntilDeltaHours, nameof(bodyvalidUntilDeltaHours), required: false);
            SourceExpression.Validate(bodythreatHuntDescription, nameof(bodythreatHuntDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threat/indicators/actors";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyactors != null)
                {
                    body["actors"] = SourceExpressionConverter.ConvertToken(bodyactors);
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodywatchlists != null)
                {
                    body["watchlists"] = SourceExpressionConverter.ConvertToken(bodywatchlists);
                    bodypropCount++;
                }

                if (bodytriggerScoreIp != null)
                {
                    body["trigger_score_ip"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreIp);
                    bodypropCount++;
                }

                if (bodytriggerScoreUrl != null)
                {
                    body["trigger_score_url"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreUrl);
                    bodypropCount++;
                }

                if (bodytriggerScoreDomain != null)
                {
                    body["trigger_score_domain"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreDomain);
                    bodypropCount++;
                }

                if (bodytriggerScoreHash != null)
                {
                    body["trigger_score_hash"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreHash);
                    bodypropCount++;
                }

                if (bodyvalidUntilDeltaHours != null)
                {
                    body["valid_until_delta_hours"] = SourceExpressionConverter.ConvertToken(bodyvalidUntilDeltaHours);
                    bodypropCount++;
                }

                if (bodythreatHuntDescription != null)
                {
                    body["threat_hunt_description"] = SourceExpressionConverter.ConvertToken(bodythreatHuntDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<STIXIndicatorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<STIXMalwareIndicatorsResponse> STIXMalwareIndicators([WorkflowExpression] Func<string[]> bodymalware = null, [WorkflowExpression] Func<string[]> bodycategories = null, [WorkflowExpression] Func<string[]> bodywatchlists = null, [WorkflowExpression] Func<int> bodytriggerScoreIp = null, [WorkflowExpression] Func<int> bodytriggerScoreUrl = null, [WorkflowExpression] Func<int> bodytriggerScoreDomain = null, [WorkflowExpression] Func<int> bodytriggerScoreHash = null, [WorkflowExpression] Func<int> bodyvalidUntilDeltaHours = null, [WorkflowExpression] Func<string> bodythreatHuntDescription = null)
        {
            SourceExpression.Validate(bodymalware, nameof(bodymalware), required: false);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            SourceExpression.Validate(bodywatchlists, nameof(bodywatchlists), required: false);
            SourceExpression.Validate(bodytriggerScoreIp, nameof(bodytriggerScoreIp), required: false);
            SourceExpression.Validate(bodytriggerScoreUrl, nameof(bodytriggerScoreUrl), required: false);
            SourceExpression.Validate(bodytriggerScoreDomain, nameof(bodytriggerScoreDomain), required: false);
            SourceExpression.Validate(bodytriggerScoreHash, nameof(bodytriggerScoreHash), required: false);
            SourceExpression.Validate(bodyvalidUntilDeltaHours, nameof(bodyvalidUntilDeltaHours), required: false);
            SourceExpression.Validate(bodythreatHuntDescription, nameof(bodythreatHuntDescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/threat/indicators/malware";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymalware != null)
                {
                    body["malware"] = SourceExpressionConverter.ConvertToken(bodymalware);
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodywatchlists != null)
                {
                    body["watchlists"] = SourceExpressionConverter.ConvertToken(bodywatchlists);
                    bodypropCount++;
                }

                if (bodytriggerScoreIp != null)
                {
                    body["trigger_score_ip"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreIp);
                    bodypropCount++;
                }

                if (bodytriggerScoreUrl != null)
                {
                    body["trigger_score_url"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreUrl);
                    bodypropCount++;
                }

                if (bodytriggerScoreDomain != null)
                {
                    body["trigger_score_domain"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreDomain);
                    bodypropCount++;
                }

                if (bodytriggerScoreHash != null)
                {
                    body["trigger_score_hash"] = SourceExpressionConverter.ConvertToken(bodytriggerScoreHash);
                    bodypropCount++;
                }

                if (bodyvalidUntilDeltaHours != null)
                {
                    body["valid_until_delta_hours"] = SourceExpressionConverter.ConvertToken(bodyvalidUntilDeltaHours);
                    bodypropCount++;
                }

                if (bodythreatHuntDescription != null)
                {
                    body["threat_hunt_description"] = SourceExpressionConverter.ConvertToken(bodythreatHuntDescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<STIXMalwareIndicatorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearchV2Response> AlertSearch([WorkflowExpression] Func<string> triggered = null, [WorkflowExpression] Func<string> alertRule = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> from = null, [WorkflowExpression] Func<fieldsInput> fields = null)
        {
            SourceExpression.Validate(triggered, nameof(triggered), required: false);
            SourceExpression.Validate(alertRule, nameof(alertRule), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (triggered != null)
                    callPayload.Queries["triggered"] = SourceExpressionConverter.ConvertO(triggered);
                if (alertRule != null)
                    callPayload.Queries["alertRule"] = SourceExpressionConverter.ConvertO(alertRule);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.Convert(fields);
                return callPayload;
            }

            return new ApiConnectionAction<AlertSearchV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfuturev2")]
        public IBodyWorkflowAction<AlertSearchIdV2Response> AlertSearchId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<fieldsInput> fields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/alerts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.Convert(fields);
                return callPayload;
            }

            return new ApiConnectionAction<AlertSearchIdV2Response>(BuildSourceInput);
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

    public enum bodyentitiesInputItem
    {
        [EnumMember(Value = "CVE-2000-01")]
        CVE200001,
        [EnumMember(Value = "mitre:TA0001")]
        MitreTA0001
    }

    public enum bodystatusesInputItem
    {
        New,
        InProgress,
        Dismissed,
        Resolved
    }

    public enum bodyprioritiesInputItem
    {
        High,
        Moderate,
        Informational
    }

    public enum bodycategoriesInputItem
    {
        [EnumMember(Value = "domain_abuse")]
        DomainAbuse,
        [EnumMember(Value = "cyber_vulnerability")]
        CyberVulnerability,
        [EnumMember(Value = "code_repo_leakage")]
        CodeRepoLeakage
    }

    public enum bodycreatedFromRelativeInput
    {
        [EnumMember(Value = "-5m")]
        _5m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    public enum bodycreatedUntilRelativeInput
    {
        [EnumMember(Value = "-0m")]
        _0m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    public enum bodyupdatedFromRelativeInput
    {
        [EnumMember(Value = "-5m")]
        _5m,
        [EnumMember(Value = "-2h")]
        _2h,
        [EnumMember(Value = "-1d")]
        _1d
    }

    public enum bodyupdatedUntilRelativeInput
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

    public enum bodytypesInputItem
    {
        [EnumMember(Value = "sigma")]
        Sigma,
        [EnumMember(Value = "yara")]
        Yara,
        [EnumMember(Value = "snort")]
        Snort
    }

    public enum bodylimitInput
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