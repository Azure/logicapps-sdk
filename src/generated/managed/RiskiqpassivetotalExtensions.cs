//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqpassivetotal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RiskiqpassivetotalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AccountResponse> Account()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<HistoryResponse> History([WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> dt = null, [WorkflowExpression] Func<string> focus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (dt != null)
                    callPayload.Queries["dt"] = SourceExpressionConverter.ConvertO(dt);
                if (focus != null)
                    callPayload.Queries["focus"] = SourceExpressionConverter.ConvertO(focus);
                return callPayload;
            }

            return new ApiConnectionAction<HistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<MonitorsResponse> Monitors()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/monitors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MonitorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<OrganizationResponse> Organization()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/organization";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<QuotaResponse> Quota()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/quota";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QuotaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SourcesResponse> Sources([WorkflowExpression] Func<string> source = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                return callPayload;
            }

            return new ApiConnectionAction<SourcesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TeamstreamResponse> Teamstream([WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> dt = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> focus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/organization/teamstream";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (dt != null)
                    callPayload.Queries["dt"] = SourceExpressionConverter.ConvertO(dt);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (focus != null)
                    callPayload.Queries["focus"] = SourceExpressionConverter.ConvertO(focus);
                return callPayload;
            }

            return new ApiConnectionAction<TeamstreamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ClassificationsResponse> Classifications([WorkflowExpression] Func<string> classification = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/classifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (classification != null)
                    callPayload.Queries["classification"] = SourceExpressionConverter.ConvertO(classification);
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TagActionResponse> GetTags([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<TagActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TagActionResponse> DeleteTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/tags";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TagActionResponse> AddTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TagActionResponse> SetTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/tags";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<BulkClassificationResponse> GetBulkClassificationStatus([WorkflowExpression] Func<string[]> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/bulk/classification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<BulkClassificationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ClassificationInfo> SetBulkClassificationStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/bulk/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ClassificationInfo> GetClassificationStatus([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/classification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ClassificationInfo> SetClassificationStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/classification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CompromisedStatusResponse> GetCompromisedStatus([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/ever-compromised";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<CompromisedStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CompromisedStatusResponse> SetCompromisedStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/ever-compromised";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompromisedStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<DynamicDnsResponse> GetDynamicDNSStatus([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/dynamic-dns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<DynamicDnsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<DynamicDnsResponse> SetDynamicDNSStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/dynamic-dns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DynamicDnsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<MonitorStatusResponse> GetMonitorStatus([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/monitor";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<MonitorStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SinkholeStatusResponse> GetSinkholeStatus([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/sinkhole";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SinkholeStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SinkholeStatusResponse> SetSinkholeStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/sinkhole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SinkholeStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ActionSearchTagResponse> SearchTags([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/tags/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ActionSearchTagResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> FindArtifact([WorkflowExpression] Func<string> artifact = null, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> owner = null, [WorkflowExpression] Func<string> creator = null, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (artifact != null)
                    callPayload.Queries["artifact"] = SourceExpressionConverter.ConvertO(artifact);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (owner != null)
                    callPayload.Queries["owner"] = SourceExpressionConverter.ConvertO(owner);
                if (creator != null)
                    callPayload.Queries["creator"] = SourceExpressionConverter.ConvertO(creator);
                if (organization != null)
                    callPayload.Queries["organization"] = SourceExpressionConverter.ConvertO(organization);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SingleArtifactResponse> DeleteArtifact()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleArtifactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SingleArtifactResponse> UpdateArtifact()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleArtifactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SingleArtifactResponse> CreateArtifact()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SingleArtifactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> BulkArtifactDelete()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/bulk";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var artifacts = new JObject();
                var artifactspropCount = 0;
                if (artifactspropCount > 0)
                {
                    callPayload.Body = artifacts;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> BulkArtifactUpdate()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var artifacts = new JObject();
                var artifactspropCount = 0;
                if (artifactspropCount > 0)
                {
                    callPayload.Body = artifacts;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> BulkArtifactCreate()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/bulk";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var artifacts = new JObject();
                var artifactspropCount = 0;
                if (artifactspropCount > 0)
                {
                    callPayload.Body = artifacts;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ArticlesIndicatorsResponse> GetArticlesIndicators([WorkflowExpression] Func<string> articleGuid = null, [WorkflowExpression] Func<string> startDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/articles/indicators";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (articleGuid != null)
                    callPayload.Queries["articleGuid"] = SourceExpressionConverter.ConvertO(articleGuid);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                return callPayload;
            }

            return new ApiConnectionAction<ArticlesIndicatorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ArticlesListResponse> GetArticlesByIndicator([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/articles/indicator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<ArticlesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ArticlesResponse> GetArticleDetails([WorkflowExpression] Func<string> article)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/articles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(article, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ArticlesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ArticlesListResponse> GetArticles([WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort"] = Convert.ToString("created");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<ArticlesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SummaryDataCardResponse> SummaryDataCard([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cards/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SummaryDataCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<EnrichmentResponse> GetEnrichment([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<EnrichmentMalwareResponse> GetMalware([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/malware";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentMalwareResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<EnrichmentOsintResponse> GetOSINT([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/osint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentOsintResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<EnrichmentSubdomainsResponse> GetSubDomains([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/subdomains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentSubdomainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ServicesResponse> GetOpenPorts([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/services";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ServicesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<MonitorResponse> GetAlerts([WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> artifact = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/monitor";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (artifact != null)
                    callPayload.Queries["artifact"] = SourceExpressionConverter.ConvertO(artifact);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<MonitorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> FindProject([WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> owner = null, [WorkflowExpression] Func<string> creator = null, [WorkflowExpression] Func<string> organization = null, [WorkflowExpression] Func<visibilityInput> visibility = null, [WorkflowExpression] Func<bool> featured = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (owner != null)
                    callPayload.Queries["owner"] = SourceExpressionConverter.ConvertO(owner);
                if (creator != null)
                    callPayload.Queries["creator"] = SourceExpressionConverter.ConvertO(creator);
                if (organization != null)
                    callPayload.Queries["organization"] = SourceExpressionConverter.ConvertO(organization);
                if (visibility != null)
                    callPayload.Queries["visibility"] = SourceExpressionConverter.Convert(visibility);
                if (featured != null)
                    callPayload.Queries["featured"] = SourceExpressionConverter.ConvertO(featured);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> DeleteProject()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> UpdateProject()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> CreateProject()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> RemoveProjectTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project/tag";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> AddProjectTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project/tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ProjectResponse> SetProjectTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/project/tag";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SSLResponse> GetSSLCertificate([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ssl-certificate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SSLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SSLHistoryResponse> GetSSLCertificateHistory([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ssl-certificate/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SSLHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SSLSearchResponse> SearchSSLCertificates([WorkflowExpression] Func<fieldInput> field, [WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ssl-certificate/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["field"] = SourceExpressionConverter.Convert(field);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SSLSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<SSLSearchKeywordResponse> SearchSSLCertificatesByKeyword([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ssl-certificate/search/keyword";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<SSLSearchKeywordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ArtifactTagResponse> GetArtifactTags([WorkflowExpression] Func<string> artifact)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["artifact"] = SourceExpressionConverter.ConvertO(artifact);
                return callPayload;
            }

            return new ApiConnectionAction<ArtifactTagResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> RemoveArtifactTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/tag";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> UpdateArtifactTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> SetArtifactTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/artifact/tag";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TrackersSearchResponse> SearchTrackers([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trackers/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<TrackersSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ComponentInfo> GetComponents([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/host-attributes/components";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<PairInfo> GetPairs([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<directionInput> direction, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/host-attributes/pairs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["direction"] = SourceExpressionConverter.Convert(direction);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<PairInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<TrackerInfo> GetTrackers([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/host-attributes/trackers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<TrackerInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CookiesResponse> GetCookies([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/host-attributes/cookies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<CookiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CookiesSearchResponse> GetAddressesByCookieDomain([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cookies/domain/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<CookiesSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CookiesSearchResponse> GetAddressesByCookieName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cookies/name/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<CookiesSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CookiesSearchResponse> GetHostsByCookieDomain([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cookies/domain/{0}/hosts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<CookiesSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<CookiesSearchResponse> GetHostsByCookieName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cookies/name/{0}/hosts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<CookiesSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ComponentsSearchAddressesResponse> GetAddressesByComponentName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/components/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.ConvertO(version);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentsSearchAddressesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ComponentsSearchHostsResponse> GetHostsByComponentName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<orderInput> order = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/components/{0}/hosts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.ConvertO(version);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort"] = Convert.ToString("lastSeen");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentsSearchHostsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<PassiveDnsSearchResponse> GetPassiveDNS([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> timeout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dns/passive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["timeout"] = Convert.ToString(7);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                return callPayload;
            }

            return new ApiConnectionAction<PassiveDnsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<PassiveUniqueDnsSearchResponse> GetUniquePassiveDNS([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> timeout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dns/passive/unique";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["timeout"] = Convert.ToString(7);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                return callPayload;
            }

            return new ApiConnectionAction<PassiveUniqueDnsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<KeywordDnsSearchResponse> SearchByKeyword([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dns/search/keyword";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<KeywordDnsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<JToken> GetWHOIS([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<bool> compactRecord = null, [WorkflowExpression] Func<bool> history = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/whois";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (compactRecord != null)
                    callPayload.Queries["compact_record"] = SourceExpressionConverter.ConvertO(compactRecord);
                if (history != null)
                    callPayload.Queries["history"] = SourceExpressionConverter.ConvertO(history);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<WhoisKeywordSearchResponse> SearchWHOISKeyword([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/whois/search/keyword";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<WhoisKeywordSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ResultListResponse> SearchWHOIS([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<fieldInput> field)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/whois/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["field"] = SourceExpressionConverter.Convert(field);
                return callPayload;
            }

            return new ApiConnectionAction<ResultListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<EnrichmentBulkResponse> GetBulkEnrichment([WorkflowExpression] Func<string[]> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/bulk";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<EnrichmentBulkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<MalwareBulkSearchResults> GetMalwareBulk([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/bulk/malware";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<MalwareBulkSearchResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<OsintBulkResponse> GetOSINTBulk([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/enrichment/bulk/osint";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<OsintBulkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<ReputationResponse> Reputation([WorkflowExpression] Func<string> query)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reputation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<ReputationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<IntelProfilesResponse> GetProfile([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intel-profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IntelProfilesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<IntelProfilesIndicatorListResponse> GetIndicatorsOfProfile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> types = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> sources = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intel-profiles/{0}/indicators", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (types != null)
                    callPayload.Queries["types"] = SourceExpressionConverter.ConvertO(types);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                if (sources != null)
                    callPayload.Queries["sources"] = SourceExpressionConverter.ConvertO(sources);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<IntelProfilesIndicatorListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<IntelProfilesListResponse> GetAllProfiles([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intel-profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<IntelProfilesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<IntelProfilesListResponse> GetAllProfilesByIndicators([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> types = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> sources = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intel-profiles/indicator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (types != null)
                    callPayload.Queries["types"] = SourceExpressionConverter.ConvertO(types);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                if (sources != null)
                    callPayload.Queries["sources"] = SourceExpressionConverter.ConvertO(sources);
                return callPayload;
            }

            return new ApiConnectionAction<IntelProfilesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<VendorInfo> GetAttackSurface()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attack-surface";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VendorInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfacePriorityResponse> GetAttackSurfaceByLevel([WorkflowExpression] Func<levelInput> level)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/priority/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(level, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfacePriorityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceInsightResponse> GetAttackSurfaceByInsight([WorkflowExpression] Func<int> insightId, [WorkflowExpression] Func<string> groupBy = null, [WorkflowExpression] Func<string> segmentBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/insight/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(insightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupBy"] = Convert.ToString("RISK_CATEGORY");
                if (groupBy != null)
                    callPayload.Queries["groupBy"] = SourceExpressionConverter.ConvertO(groupBy);
                if (segmentBy != null)
                    callPayload.Queries["segmentBy"] = SourceExpressionConverter.ConvertO(segmentBy);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceInsightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<VendorInfo> GetVendorById([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/third-party/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VendorInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceResponse> GetVendors([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attack-surface/third-party";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfacePriorityResponse> GetVendorsByLevel([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<levelInput> level)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/third-party/{0}/priority/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(level, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfacePriorityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceInsightResponse> GetVendorsByInsightId([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> insightId, [WorkflowExpression] Func<string> groupBy = null, [WorkflowExpression] Func<string> segmentBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/third-party/{0}/insight/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(insightId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupBy"] = Convert.ToString("RISK_CATEGORY");
                if (groupBy != null)
                    callPayload.Queries["groupBy"] = SourceExpressionConverter.ConvertO(groupBy);
                if (segmentBy != null)
                    callPayload.Queries["segmentBy"] = SourceExpressionConverter.ConvertO(segmentBy);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceInsightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<VulnerableComponentResponse> GetVulnComponents([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attack-surface/vuln-intel/components";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<VulnerableComponentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<VulnerableComponentResponse> GetThirdPartyVulnComponents([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/vuln-intel/third-party/{0}/components", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<VulnerableComponentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceCveResponse> GetVulnInfo([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attack-surface/vuln-intel/cves";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceCveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceCveResponse> GetThirdPartyVulnInfo([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/vuln-intel/third-party/{0}/cves", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceCveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceCveObservationsResponse> GetVulnObservation([WorkflowExpression] Func<string> cveId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/vuln-intel/cves/{0}/observations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cveId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceCveObservationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "riskiqpassivetotal")]
        public IBodyWorkflowAction<AttackSurfaceCveObservationsResponse> GetThirdPartyVulnObservation([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> cveId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attack-surface/vuln-intel/third-party/{0}/cves/{1}/observations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cveId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["size"] = Convert.ToString(25);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<AttackSurfaceCveObservationsResponse>(BuildSourceInput);
        }
    }

    public class RiskiqpassivetotalTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountResponse
    {
        [JsonProperty("features")]
        public AccountResponseFeaturesType Features { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("guest")]
        public bool Guest { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("firstActive")]
        public string FirstActive { get; set; }

        [JsonProperty("lastActive")]
        public string LastActive { get; set; }

        [JsonProperty("verified")]
        public string Verified { get; set; }

        [JsonProperty("suppliedOrganization")]
        public string SuppliedOrganization { get; set; }

        [JsonProperty("jobRole")]
        public JToken JobRole { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("enterpriseUser")]
        public string EnterpriseUser { get; set; }

        [JsonProperty("approvedSources")]
        public string ApprovedSources { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("stateOrRegion")]
        public string StateOrRegion { get; set; }

        [JsonProperty("searchWebQuotaExceeded")]
        public bool SearchWebQuotaExceeded { get; set; }

        [JsonProperty("searchApiQuotaExceeded")]
        public bool SearchApiQuotaExceeded { get; set; }

        [JsonProperty("projectPublicQuotaExceeded")]
        public bool ProjectPublicQuotaExceeded { get; set; }

        [JsonProperty("projectPrivateQuotaExceeded")]
        public bool ProjectPrivateQuotaExceeded { get; set; }

        [JsonProperty("accountStatus")]
        public string AccountStatus { get; set; }

        [JsonProperty("monitorFrequency")]
        public string MonitorFrequency { get; set; }

        [JsonProperty("emailDigestFrequency")]
        public string EmailDigestFrequency { get; set; }

        [JsonProperty("workspaceId")]
        public int WorkspaceId { get; set; }

        [JsonProperty("permissions")]
        public JToken[] Permissions { get; set; }

        [JsonProperty("disableHistory")]
        public bool DisableHistory { get; set; }

        [JsonProperty("ssoIntegrationId")]
        public JToken SsoIntegrationId { get; set; }

        [JsonProperty("ssoAuthPartnerId")]
        public JToken SsoAuthPartnerId { get; set; }

        [JsonProperty("ssoSuccess")]
        public bool SsoSuccess { get; set; }

        [JsonProperty("daysLeftOnTrial")]
        public JToken DaysLeftOnTrial { get; set; }

        [JsonProperty("darkMode")]
        public bool DarkMode { get; set; }

        [JsonProperty("homeOptIn")]
        public bool HomeOptIn { get; set; }

        [JsonProperty("hideHomeOptIn")]
        public bool HideHomeOptIn { get; set; }

        [JsonProperty("preferences")]
        public AccountResponsePreferencesType Preferences { get; set; }

        [JsonProperty("datasets")]
        public AccountResponseDatasetsType Datasets { get; set; }

        [JsonProperty("event_code")]
        public JToken EventCode { get; set; }

        [JsonProperty("user_id")]
        public JToken UserId { get; set; }

        [JsonProperty("user_hash")]
        public JToken UserHash { get; set; }
    }

    public class AccountResponseFeaturesType
    {
        [JsonProperty("two_factor_enabled")]
        public bool TwoFactorEnabled { get; set; }

        [JsonProperty("calendly_integration")]
        public bool CalendlyIntegration { get; set; }

        [JsonProperty("analyst_insights")]
        public bool AnalystInsights { get; set; }

        [JsonProperty("analyst_projects")]
        public bool AnalystProjects { get; set; }

        [JsonProperty("async_heatmap")]
        public bool AsyncHeatmap { get; set; }

        [JsonProperty("tab_update")]
        public bool TabUpdate { get; set; }

        [JsonProperty("msft_integration")]
        public bool MsftIntegration { get; set; }

        [JsonProperty("exposed_services")]
        public bool ExposedServices { get; set; }

        [JsonProperty("community_relaunch")]
        public bool CommunityRelaunch { get; set; }

        [JsonProperty("data_table_improvement")]
        public bool DataTableImprovement { get; set; }

        [JsonProperty("project_selector_v2")]
        public bool ProjectSelectorV2 { get; set; }

        [JsonProperty("whois_history")]
        public bool WhoisHistory { get; set; }

        [JsonProperty("server_side_facets")]
        public bool ServerSideFacets { get; set; }

        [JsonProperty("projects_tabs")]
        public bool ProjectsTabs { get; set; }

        [JsonProperty("projects_share")]
        public bool ProjectsShare { get; set; }

        [JsonProperty("illuminate")]
        public bool Illuminate { get; set; }

        [JsonProperty("triage")]
        public bool Triage { get; set; }

        [JsonProperty("data_table_paginated")]
        public bool DataTablePaginated { get; set; }
    }

    public class AccountResponsePreferencesType
    {
        [JsonProperty("darkMode")]
        public bool DarkMode { get; set; }

        [JsonProperty("articlePageSize")]
        public int ArticlePageSize { get; set; }

        [JsonProperty("ptClassicMode")]
        public bool PtClassicMode { get; set; }

        [JsonProperty("neverLoggedIn")]
        public bool NeverLoggedIn { get; set; }

        [JsonProperty("homeOptIn")]
        public bool HomeOptIn { get; set; }

        [JsonProperty("hideHomeOptIn")]
        public bool HideHomeOptIn { get; set; }
    }

    public class AccountResponseDatasetsType
    {
        [JsonProperty("trackers")]
        public bool Trackers { get; set; }

        [JsonProperty("components")]
        public bool Components { get; set; }

        [JsonProperty("hostPairs")]
        public bool HostPairs { get; set; }

        [JsonProperty("malware")]
        public JToken Malware { get; set; }

        [JsonProperty("whoisHistory")]
        public bool WhoisHistory { get; set; }

        [JsonProperty("whois")]
        public bool Whois { get; set; }

        [JsonProperty("sslCerts")]
        public JToken SslCerts { get; set; }

        [JsonProperty("attackSurfaceIntel")]
        public bool AttackSurfaceIntel { get; set; }

        [JsonProperty("services")]
        public bool Services { get; set; }

        [JsonProperty("pdns")]
        public JToken Pdns { get; set; }

        [JsonProperty("cookies")]
        public bool Cookies { get; set; }

        [JsonProperty("reputation")]
        public bool Reputation { get; set; }

        [JsonProperty("analystInsights")]
        public bool AnalystInsights { get; set; }

        [JsonProperty("deepDarkWeb")]
        public bool DeepDarkWeb { get; set; }

        [JsonProperty("brandIntel")]
        public bool BrandIntel { get; set; }

        [JsonProperty("riskiqArticleIndicators")]
        public bool RiskiqArticleIndicators { get; set; }

        [JsonProperty("adversaryIntel")]
        public bool AdversaryIntel { get; set; }
    }

    public class HistoryResponse
    {
        [JsonProperty("history")]
        public History[] History { get; set; }

        [JsonProperty("teamstream")]
        public JToken Teamstream { get; set; }
    }

    public class History
    {
        [JsonProperty("focus")]
        public string Focus { get; set; }

        [JsonProperty("context")]
        public int Context { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MonitorsResponse
    {
        [JsonProperty("monitors")]
        public Monitor[] Monitors { get; set; }
    }

    public class Monitor
    {
        [JsonProperty("focus")]
        public string Focus { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class OrganizationResponse
    {
        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("watchQuota")]
        public JToken WatchQuota { get; set; }

        [JsonProperty("licenses")]
        public OrganizationLicenses Licenses { get; set; }

        [JsonProperty("seats")]
        public int Seats { get; set; }

        [JsonProperty("features")]
        public OrganizationResponseFeaturesType Features { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("licensedMembers")]
        public OrganizationLicensedMembers LicensedMembers { get; set; }

        [JsonProperty("activeMembers")]
        public string[] ActiveMembers { get; set; }

        [JsonProperty("searchQuota")]
        public JToken SearchQuota { get; set; }

        [JsonProperty("showTeamSearchHistory")]
        public bool ShowTeamSearchHistory { get; set; }

        [JsonProperty("disableIndividualSearchHistory")]
        public JToken DisableIndividualSearchHistory { get; set; }

        [JsonProperty("disableTeamSearchHistory")]
        public JToken DisableTeamSearchHistory { get; set; }

        [JsonProperty("lastActive")]
        public string LastActive { get; set; }

        [JsonProperty("defaultDomains")]
        public string[] DefaultDomains { get; set; }

        [JsonProperty("acceptableDomains")]
        public string[] AcceptableDomains { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("inactiveMembers")]
        public JToken[] InactiveMembers { get; set; }

        [JsonProperty("admins")]
        public string[] Admins { get; set; }

        [JsonProperty("disabledMembers")]
        public JToken DisabledMembers { get; set; }

        [JsonProperty("usersNotSignedUpYet")]
        public JToken UsersNotSignedUpYet { get; set; }

        [JsonProperty("hasFalconCreds")]
        public bool HasFalconCreds { get; set; }

        [JsonProperty("sources")]
        public JToken Sources { get; set; }

        [JsonProperty("enhancedAttackSurfaceData")]
        public OrganizationResponseEnhancedAttackSurfaceDataType EnhancedAttackSurfaceData { get; set; }
    }

    public class OrganizationLicenses
    {
        [JsonProperty("enterprise")]
        public int Enterprise { get; set; }

        [JsonProperty("cyberThreatIntel")]
        public int CyberThreatIntel { get; set; }

        [JsonProperty("secOpsIntel")]
        public int SecOpsIntel { get; set; }

        [JsonProperty("illuminate")]
        public int Illuminate { get; set; }
    }

    public class OrganizationResponseFeaturesType
    {
        [JsonProperty("illuminate")]
        public bool Illuminate { get; set; }

        [JsonProperty("triage")]
        public bool Triage { get; set; }
    }

    public class OrganizationLicensedMembers
    {
        [JsonProperty("enterprise")]
        public string[] Enterprise { get; set; }

        [JsonProperty("illuminate")]
        public string[] Illuminate { get; set; }

        [JsonProperty("cyberThreatIntel")]
        public string[] CyberThreatIntel { get; set; }

        [JsonProperty("secOpsIntel")]
        public string[] SecOpsIntel { get; set; }
    }

    public class OrganizationResponseEnhancedAttackSurfaceDataType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("primary")]
        public JToken[] Primary { get; set; }

        [JsonProperty("maxVendors")]
        public int MaxVendors { get; set; }

        [JsonProperty("vendors")]
        public JToken[] Vendors { get; set; }
    }

    public class QuotaResponse
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("organization")]
        public OrganizationInfo Organization { get; set; }
    }

    public class User
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("counts")]
        public UserCountsType Counts { get; set; }

        [JsonProperty("freebies")]
        public UserFreebiesType Freebies { get; set; }

        [JsonProperty("profile")]
        public UserProfileType Profile { get; set; }

        [JsonProperty("limits")]
        public UserLimitsType Limits { get; set; }

        [JsonProperty("quotaInterval")]
        public string QuotaInterval { get; set; }

        [JsonProperty("useMonthlyQuotaInactive")]
        public bool UseMonthlyQuotaInactive { get; set; }

        [JsonProperty("licenseCounts")]
        public UserLicenseCountsType LicenseCounts { get; set; }

        [JsonProperty("licenseLimits")]
        public UserLicenseLimitsType LicenseLimits { get; set; }

        [JsonProperty("next_reset")]
        public string NextReset { get; set; }

        [JsonProperty("last_reset")]
        public string LastReset { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("event_code")]
        public JToken EventCode { get; set; }

        [JsonProperty("event_code_expiration")]
        public JToken EventCodeExpiration { get; set; }
    }

    public class UserCountsType
    {
        [JsonProperty("keyword_monitors")]
        public int KeywordMonitors { get; set; }

        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("basic_monitors")]
        public int BasicMonitors { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }

        [JsonProperty("projects_private")]
        public int ProjectsPrivate { get; set; }

        [JsonProperty("projects_public")]
        public int ProjectsPublic { get; set; }
    }

    public class UserFreebiesType
    {
        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }
    }

    public class UserProfileType
    {
        [JsonProperty("analysis")]
        public string Analysis { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }
    }

    public class UserLimitsType
    {
        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("basic_monitors")]
        public int BasicMonitors { get; set; }

        [JsonProperty("monitor_results")]
        public int MonitorResults { get; set; }

        [JsonProperty("projects_private")]
        public int ProjectsPrivate { get; set; }

        [JsonProperty("monitor_frequency")]
        public string MonitorFrequency { get; set; }

        [JsonProperty("keyword_monitors")]
        public int KeywordMonitors { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }

        [JsonProperty("projects_public")]
        public int ProjectsPublic { get; set; }

        [JsonProperty("create_crawls")]
        public int CreateCrawls { get; set; }

        [JsonProperty("crawl_submissions")]
        public int CrawlSubmissions { get; set; }
    }

    public class UserLicenseCountsType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class UserLicenseLimitsType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationInfo
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("counts")]
        public OrganizationCountsType Counts { get; set; }

        [JsonProperty("freebies")]
        public OrganizationFreebiesType Freebies { get; set; }

        [JsonProperty("profile")]
        public OrganizationProfileType Profile { get; set; }

        [JsonProperty("limits")]
        public OrganizationLimitsType Limits { get; set; }

        [JsonProperty("quotaInterval")]
        public string QuotaInterval { get; set; }

        [JsonProperty("licenseCounts")]
        public OrganizationLicenseCounts LicenseCounts { get; set; }

        [JsonProperty("licenseLimits")]
        public OrganizationLicenseLimits LicenseLimits { get; set; }

        [JsonProperty("useMonthlyQuotaInactive")]
        public bool UseMonthlyQuotaInactive { get; set; }

        [JsonProperty("next_reset")]
        public string NextReset { get; set; }

        [JsonProperty("last_reset")]
        public string LastReset { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("event_code")]
        public JToken EventCode { get; set; }

        [JsonProperty("event_code_expiration")]
        public JToken EventCodeExpiration { get; set; }
    }

    public class OrganizationCountsType
    {
        [JsonProperty("keyword_monitors")]
        public int KeywordMonitors { get; set; }

        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("basic_monitors")]
        public int BasicMonitors { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }

        [JsonProperty("projects_private")]
        public int ProjectsPrivate { get; set; }

        [JsonProperty("projects_public")]
        public int ProjectsPublic { get; set; }
    }

    public class OrganizationFreebiesType
    {
        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationProfileType
    {
        [JsonProperty("analysis")]
        public string Analysis { get; set; }

        [JsonProperty("workflow")]
        public string Workflow { get; set; }
    }

    public class OrganizationLimitsType
    {
        [JsonProperty("search_api")]
        public int SearchApi { get; set; }

        [JsonProperty("basic_monitors")]
        public int BasicMonitors { get; set; }

        [JsonProperty("monitor_results")]
        public int MonitorResults { get; set; }

        [JsonProperty("projects_private")]
        public int ProjectsPrivate { get; set; }

        [JsonProperty("monitor_frequency")]
        public string MonitorFrequency { get; set; }

        [JsonProperty("keyword_monitors")]
        public int KeywordMonitors { get; set; }

        [JsonProperty("search_web")]
        public int SearchWeb { get; set; }

        [JsonProperty("projects_public")]
        public int ProjectsPublic { get; set; }

        [JsonProperty("create_crawls")]
        public int CreateCrawls { get; set; }

        [JsonProperty("crawl_submissions")]
        public int CrawlSubmissions { get; set; }
    }

    public class OrganizationLicenseCounts
    {
        [JsonProperty("enterprise")]
        public OrganizationLicenseCountsEnterpriseType Enterprise { get; set; }

        [JsonProperty("cyberThreatIntel")]
        public OrganizationLicenseCountsCyberThreatIntelType CyberThreatIntel { get; set; }

        [JsonProperty("secOpsIntel")]
        public OrganizationLicenseCountsSecOpsIntelType SecOpsIntel { get; set; }

        [JsonProperty("illuminate")]
        public OrganizationLicenseCountsIlluminateType Illuminate { get; set; }
    }

    public class OrganizationLicenseCountsEnterpriseType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseCountsCyberThreatIntelType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseCountsSecOpsIntelType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseCountsIlluminateType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseLimits
    {
        [JsonProperty("enterprise")]
        public OrganizationLicenseLimitsEnterpriseType Enterprise { get; set; }

        [JsonProperty("cyberThreatIntel")]
        public OrganizationLicenseLimitsCyberThreatIntelType CyberThreatIntel { get; set; }

        [JsonProperty("secOpsIntel")]
        public OrganizationLicenseLimitsSecOpsIntelType SecOpsIntel { get; set; }

        [JsonProperty("illuminate")]
        public OrganizationLicenseLimitsIlluminateType Illuminate { get; set; }
    }

    public class OrganizationLicenseLimitsEnterpriseType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseLimitsCyberThreatIntelType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseLimitsSecOpsIntelType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class OrganizationLicenseLimitsIlluminateType
    {
        [JsonProperty("searchApi")]
        public int SearchApi { get; set; }

        [JsonProperty("searchWeb")]
        public int SearchWeb { get; set; }
    }

    public class SourcesResponse
    {
        [JsonProperty("sources")]
        public SourceInfo[] Sources { get; set; }
    }

    public class SourceInfo
    {
        [JsonProperty("controllable")]
        public bool Controllable { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("configuration")]
        public SourceConfigurationType Configuration { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("access")]
        public string[] Access { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("authRequired")]
        public bool AuthRequired { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("auth")]
        public bool Auth { get; set; }

        [JsonProperty("authMethod")]
        public SourceAuthMethodType AuthMethod { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("org_configuration")]
        public JToken OrgConfiguration { get; set; }
    }

    public class SourceConfigurationType
    {
        [JsonProperty("settings")]
        public JToken Settings { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class SourceAuthMethodType
    {
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("token_key")]
        public string TokenKey { get; set; }

        [JsonProperty("token_secret")]
        public string TokenSecret { get; set; }

        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }
    }

    public class TeamstreamResponse
    {
        [JsonProperty("history")]
        public JToken History { get; set; }

        [JsonProperty("teamstream")]
        public Teamstream[] Teamstream { get; set; }
    }

    public class Teamstream
    {
        [JsonProperty("focus")]
        public string Focus { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("context")]
        public int Context { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }
    }

    public class ClassificationsResponse
    {
        [JsonProperty("malicious")]
        public string[] Malicious { get; set; }

        [JsonProperty("non_malicious")]
        public string[] NonMalicious { get; set; }

        [JsonProperty("suspicious")]
        public string[] Suspicious { get; set; }

        [JsonProperty("unknown")]
        public string[] Unknown { get; set; }
    }

    public class TagActionResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class BulkClassificationResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public JToken Results { get; set; }
    }

    public class ClassificationInfo
    {
        [JsonProperty("classification")]
        public string Classification { get; set; }
    }

    public class CompromisedStatusResponse
    {
        [JsonProperty("everCompromised")]
        public bool EverCompromised { get; set; }
    }

    public class DynamicDnsResponse
    {
        [JsonProperty("dynamicDns")]
        public bool DynamicDns { get; set; }
    }

    public class MonitorStatusResponse
    {
        [JsonProperty("monitor")]
        public bool Monitor { get; set; }
    }

    public class SinkholeStatusResponse
    {
        [JsonProperty("sinkhole")]
        public bool Sinkhole { get; set; }
    }

    public class ActionSearchTagResponse
    {
        [JsonProperty("results")]
        public SearchTagElementItem[] Results { get; set; }
    }

    public class SearchTagElementItem
    {
        [JsonProperty("focus")]
        public string Focus { get; set; }

        [JsonProperty("user_tags")]
        public string[] UserTags { get; set; }

        [JsonProperty("system_tags")]
        public string[] SystemTags { get; set; }

        [JsonProperty("global_tags")]
        public string[] GlobalTags { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("tag_meta")]
        public JToken TagMeta { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class SingleArtifactResponse
    {
        [JsonProperty("monitor")]
        public bool Monitor { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("monitorable")]
        public bool Monitorable { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("system_tags")]
        public string[] SystemTags { get; set; }

        [JsonProperty("user_tags")]
        public string[] UserTags { get; set; }

        [JsonProperty("global_tags")]
        public string[] GlobalTags { get; set; }

        [JsonProperty("tag_meta")]
        public JToken TagMeta { get; set; }

        [JsonProperty("links")]
        public SingleArtifactResponseLinksType Links { get; set; }
    }

    public class SingleArtifactResponseLinksType
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }

    public class ArticlesIndicatorsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("indicators")]
        public Indicators[] Indicators { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
    }

    public class Indicators
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class ArticlesListResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("articles")]
        public JToken Articles { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }
    }

    public class ArticlesResponse
    {
        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("indicators")]
        public ArticlesResponseIndicatorsTypeItem[] Indicators { get; set; }
    }

    public class ArticlesResponseIndicatorsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public enum orderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    public class SummaryDataCardResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("netblock")]
        public string Netblock { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("asn")]
        public string Asn { get; set; }

        [JsonProperty("hosting_provider")]
        public string HostingProvider { get; set; }

        [JsonProperty("data_summary")]
        public SummaryDataCardResponseDataSummaryType DataSummary { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryType
    {
        [JsonProperty("resolutions")]
        public SummaryDataCardResponseDataSummaryTypeResolutionsType Resolutions { get; set; }

        [JsonProperty("certificates")]
        public SummaryDataCardResponseDataSummaryTypeCertificatesType Certificates { get; set; }

        [JsonProperty("hashes")]
        public SummaryDataCardResponseDataSummaryTypeHashesType Hashes { get; set; }

        [JsonProperty("projects")]
        public SummaryDataCardResponseDataSummaryTypeProjectsType Projects { get; set; }

        [JsonProperty("articles")]
        public SummaryDataCardResponseDataSummaryTypeArticlesType Articles { get; set; }

        [JsonProperty("trackers")]
        public SummaryDataCardResponseDataSummaryTypeTrackersType Trackers { get; set; }

        [JsonProperty("components")]
        public SummaryDataCardResponseDataSummaryTypeComponentsType Components { get; set; }

        [JsonProperty("host_pairs")]
        public SummaryDataCardResponseDataSummaryTypeHostPairsType HostPairs { get; set; }

        [JsonProperty("cookies")]
        public SummaryDataCardResponseDataSummaryTypeCookiesType Cookies { get; set; }

        [JsonProperty("reverse_dns")]
        public SummaryDataCardResponseDataSummaryTypeReverseDnsType ReverseDns { get; set; }

        [JsonProperty("services")]
        public SummaryDataCardResponseDataSummaryTypeServicesType Services { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeResolutionsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeCertificatesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeHashesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeProjectsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeArticlesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeTrackersType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeComponentsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeHostPairsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeCookiesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeReverseDnsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SummaryDataCardResponseDataSummaryTypeServicesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class EnrichmentResponse
    {
        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("sinkhole")]
        public bool Sinkhole { get; set; }

        [JsonProperty("everCompromised")]
        public bool EverCompromised { get; set; }

        [JsonProperty("queryType")]
        public string QueryType { get; set; }

        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }

        [JsonProperty("primaryDomain")]
        public string PrimaryDomain { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }

        [JsonProperty("subdomains")]
        public string[] Subdomains { get; set; }

        [JsonProperty("tag_meta")]
        public JToken TagMeta { get; set; }

        [JsonProperty("global_tags")]
        public string[] GlobalTags { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("system_tags")]
        public string[] SystemTags { get; set; }

        [JsonProperty("dynamicDns")]
        public bool DynamicDns { get; set; }

        [JsonProperty("autonomousSystemNumber")]
        public int AutonomousSystemNumber { get; set; }

        [JsonProperty("autonomousSystemName")]
        public string AutonomousSystemName { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("dynamic")]
        public JToken Dynamic { get; set; }
    }

    public class EnrichmentMalwareResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public EnrichmentMalwareResult[] Results { get; set; }
    }

    public class EnrichmentMalwareResult
    {
        [JsonProperty("collectionDate")]
        public string CollectionDate { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }
    }

    public class EnrichmentOsintResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public EnrichmentOsintResult[] Results { get; set; }
    }

    public class EnrichmentOsintResult
    {
        [JsonProperty("derived")]
        public JToken[] Derived { get; set; }

        [JsonProperty("inReport")]
        public string[] InReport { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("indicators")]
        public JToken[] Indicators { get; set; }

        [JsonProperty("compromised")]
        public JToken[] Compromised { get; set; }
    }

    public class EnrichmentSubdomainsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("primaryDomain")]
        public string PrimaryDomain { get; set; }

        [JsonProperty("subdomains")]
        public string[] Subdomains { get; set; }

        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }
    }

    public class ServicesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public ServicesResponseResultsTypeItem[] Results { get; set; }
    }

    public class ServicesResponseResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("lastScan")]
        public string LastScan { get; set; }

        [JsonProperty("portNumber")]
        public int PortNumber { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("banners")]
        public ServicesResponseResultsTypeItemBannersTypeItem[] Banners { get; set; }

        [JsonProperty("currentServices")]
        public ServicesResponseResultsTypeItemCurrentServicesTypeItem[] CurrentServices { get; set; }

        [JsonProperty("recentServices")]
        public ServicesResponseResultsTypeItemRecentServicesTypeItem[] RecentServices { get; set; }

        [JsonProperty("mostRecentSslCert")]
        public ServicesResponseResultsTypeItemMostRecentSslCertType MostRecentSslCert { get; set; }
    }

    public class ServicesResponseResultsTypeItemBannersTypeItem
    {
        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("scanType")]
        public string ScanType { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ServicesResponseResultsTypeItemCurrentServicesTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ServicesResponseResultsTypeItemRecentServicesTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ServicesResponseResultsTypeItemMostRecentSslCertType
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("sslVersion")]
        public string SslVersion { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("subjectCountry")]
        public string SubjectCountry { get; set; }

        [JsonProperty("issuerCommonName")]
        public string IssuerCommonName { get; set; }

        [JsonProperty("issuerProvince")]
        public string IssuerProvince { get; set; }

        [JsonProperty("subjectStateOrProvinceName")]
        public string SubjectStateOrProvinceName { get; set; }

        [JsonProperty("subjectStreetAddress")]
        public string SubjectStreetAddress { get; set; }

        [JsonProperty("issuerStateOrProvinceName")]
        public string IssuerStateOrProvinceName { get; set; }

        [JsonProperty("subjectSurname")]
        public string SubjectSurname { get; set; }

        [JsonProperty("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonProperty("subjectLocalityName")]
        public string SubjectLocalityName { get; set; }

        [JsonProperty("issuerOrganizationUnitName")]
        public string IssuerOrganizationUnitName { get; set; }

        [JsonProperty("issuerOrganizationName")]
        public string IssuerOrganizationName { get; set; }

        [JsonProperty("subjectEmailAddress")]
        public string SubjectEmailAddress { get; set; }

        [JsonProperty("subjectOrganizationName")]
        public string SubjectOrganizationName { get; set; }

        [JsonProperty("issuerLocalityName")]
        public string IssuerLocalityName { get; set; }

        [JsonProperty("subjectCommonName")]
        public string SubjectCommonName { get; set; }

        [JsonProperty("subjectProvince")]
        public string SubjectProvince { get; set; }

        [JsonProperty("issuerGivenName")]
        public string IssuerGivenName { get; set; }

        [JsonProperty("subjectOrganizationUnitName")]
        public string SubjectOrganizationUnitName { get; set; }

        [JsonProperty("issuerEmailAddress")]
        public string IssuerEmailAddress { get; set; }

        [JsonProperty("subjectGivenName")]
        public string SubjectGivenName { get; set; }

        [JsonProperty("subjectSerialNumber")]
        public string SubjectSerialNumber { get; set; }

        [JsonProperty("issuerStreetAddress")]
        public string IssuerStreetAddress { get; set; }

        [JsonProperty("issuerSerialNumber")]
        public string IssuerSerialNumber { get; set; }

        [JsonProperty("issuerSurname")]
        public string IssuerSurname { get; set; }

        [JsonProperty("subjectAlternativeNames")]
        public string[] SubjectAlternativeNames { get; set; }
    }

    public class MonitorResponse
    {
        [JsonProperty("results")]
        public JToken Results { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public enum visibilityInput
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "analyst")]
        Analyst
    }

    public class ProjectResponse
    {
        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("collaborators")]
        public string[] Collaborators { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("links")]
        public ProjectResponseLinksType Links { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        [JsonProperty("link")]
        public JToken Link { get; set; }
    }

    public class ProjectResponseLinksType
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("artifact")]
        public string Artifact { get; set; }
    }

    public class SSLResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("overallTotalRecords")]
        public int OverallTotalRecords { get; set; }

        [JsonProperty("results")]
        public SSLResponseResult[] Results { get; set; }
    }

    public class SSLResponseResult
    {
        [JsonProperty("firstSeen")]
        public int FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public int LastSeen { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("sslVersion")]
        public string SslVersion { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("subjectCountry")]
        public string SubjectCountry { get; set; }

        [JsonProperty("issuerCommonName")]
        public string IssuerCommonName { get; set; }

        [JsonProperty("issuerProvince")]
        public string IssuerProvince { get; set; }

        [JsonProperty("subjectStateOrProvinceName")]
        public string SubjectStateOrProvinceName { get; set; }

        [JsonProperty("subjectStreetAddress")]
        public string SubjectStreetAddress { get; set; }

        [JsonProperty("issuerStateOrProvinceName")]
        public string IssuerStateOrProvinceName { get; set; }

        [JsonProperty("subjectSurname")]
        public string SubjectSurname { get; set; }

        [JsonProperty("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonProperty("subjectLocalityName")]
        public string SubjectLocalityName { get; set; }

        [JsonProperty("issuerOrganizationUnitName")]
        public string IssuerOrganizationUnitName { get; set; }

        [JsonProperty("issuerOrganizationName")]
        public string IssuerOrganizationName { get; set; }

        [JsonProperty("subjectEmailAddress")]
        public string SubjectEmailAddress { get; set; }

        [JsonProperty("subjectOrganizationName")]
        public string SubjectOrganizationName { get; set; }

        [JsonProperty("issuerLocalityName")]
        public string IssuerLocalityName { get; set; }

        [JsonProperty("subjectCommonName")]
        public string SubjectCommonName { get; set; }

        [JsonProperty("subjectProvince")]
        public string SubjectProvince { get; set; }

        [JsonProperty("issuerGivenName")]
        public string IssuerGivenName { get; set; }

        [JsonProperty("subjectOrganizationUnitName")]
        public string SubjectOrganizationUnitName { get; set; }

        [JsonProperty("issuerEmailAddress")]
        public string IssuerEmailAddress { get; set; }

        [JsonProperty("subjectGivenName")]
        public string SubjectGivenName { get; set; }

        [JsonProperty("subjectSerialNumber")]
        public string SubjectSerialNumber { get; set; }

        [JsonProperty("issuerStreetAddress")]
        public string IssuerStreetAddress { get; set; }

        [JsonProperty("issuerSerialNumber")]
        public string IssuerSerialNumber { get; set; }

        [JsonProperty("issuerSurname")]
        public string IssuerSurname { get; set; }

        [JsonProperty("subjectAlternativeNames")]
        public string[] SubjectAlternativeNames { get; set; }
    }

    public class SSLHistoryResponse
    {
        [JsonProperty("results")]
        public SSLHistoryResult[] Results { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SSLHistoryResult
    {
        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("ipAddresses")]
        public string[] IpAddresses { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }
    }

    public class SSLSearchResponse
    {
        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }

        [JsonProperty("results")]
        public SSLResponseResult[] Results { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("overallTotalRecords")]
        public int OverallTotalRecords { get; set; }
    }

    public enum fieldInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "address")]
        Address,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "nameserver")]
        Nameserver
    }

    public class SSLSearchKeywordResponse
    {
        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }

        [JsonProperty("results")]
        public SSLSearchKeywordResult[] Results { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class SSLSearchKeywordResult
    {
        [JsonProperty("matchType")]
        public string MatchType { get; set; }

        [JsonProperty("fieldMatch")]
        public string FieldMatch { get; set; }

        [JsonProperty("focusPoint")]
        public string FocusPoint { get; set; }
    }

    public class ArtifactTagResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("system_tags")]
        public string[] SystemTags { get; set; }

        [JsonProperty("tag_meta")]
        public JToken TagMeta { get; set; }

        [JsonProperty("user_tags")]
        public string[] UserTags { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class TrackersSearchResponse
    {
        [JsonProperty("results")]
        public TrackersSearchResult[] Results { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class TrackersSearchResult
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "51laId")]
        _51laId,
        AboutmeId,
        AddThisPubId,
        AddThisUsername,
        AuthorstreamId,
        BitbucketcomId,
        BitlyId,
        CheezburgerId,
        ClickyId,
        ColourloversId,
        DiigoId,
        DispusId,
        EngadgetId,
        EtsyId,
        FacebookId,
        FavstarId,
        FfffoundId,
        FlavorsId,
        FlickrId,
        FoodspottingId,
        FreesoundId,
        GitHubId,
        GithubId,
        GoogleAnalyticsTrackingId,
        GooglePlusId,
        GoogleTagManagerId,
        HubpagesId,
        ImgurId,
        InstagramId,
        KloutId,
        LanyrdId,
        LastfmId,
        LibrarythingId,
        LinkedInId,
        LinkedinId,
        MarketinglandcomId,
        MixpanelId,
        MuckrackId,
        MyanimelistId,
        MyfitnesspalId,
        NewRelicId,
        OptimizelyId,
        PandoraId,
        PicasaId,
        PinkbikeId,
        PinterestId,
        PlancastId,
        PlurkId,
        PornhubId,
        RaptorId,
        ReadabilityId,
        RedditId,
        RedtubeId,
        SlideshareId,
        SmugmugId,
        SmuleId,
        SoundcloudId,
        SoupId,
        SpeakerdeckId,
        SporcleId,
        StackoverflowId,
        SteamcommunityId,
        StumbleuponId,
        ThesixtyoneId,
        TribeId,
        TripitId,
        TumblrId,
        TwitpicId,
        TwitterId,
        UntappdId,
        UstreamId,
        WattpadId,
        WefollowId,
        WhosAmungUsId,
        WordPressId,
        Wordpress,
        SupportId,
        XangaId,
        Xfire,
        SocialId,
        XhamsterId,
        XvideosId,
        YandexMetricaCounterId,
        YouTubeChannel,
        YouTubeId,
        YoutubeId
    }

    public class ComponentInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public ComponentInfoResultsTypeItem[] Results { get; set; }
    }

    public class ComponentInfoResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class PairInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public PairInfoResultsTypeItem[] Results { get; set; }
    }

    public class PairInfoResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("child")]
        public string Child { get; set; }
    }

    public enum directionInput
    {
        [EnumMember(Value = "children")]
        Children,
        [EnumMember(Value = "parents")]
        Parents
    }

    public class TrackerInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public TrackerInfoResultsTypeItem[] Results { get; set; }
    }

    public class TrackerInfoResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("attributeValue")]
        public string AttributeValue { get; set; }

        [JsonProperty("attributeType")]
        public string AttributeType { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class CookiesResponse
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public CookieInfo[] Results { get; set; }
    }

    public class CookieInfo
    {
        [JsonProperty("cookieDomain")]
        public string CookieDomain { get; set; }

        [JsonProperty("cookieName")]
        public string CookieName { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }
    }

    public class CookiesSearchResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public CookiesSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CookiesSearchResponseResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("cookieName")]
        public string CookieName { get; set; }

        [JsonProperty("cookieDomain")]
        public string CookieDomain { get; set; }
    }

    public enum sortInput
    {
        [EnumMember(Value = "lastSeen")]
        LastSeen,
        [EnumMember(Value = "firstSeen")]
        FirstSeen
    }

    public class ComponentsSearchAddressesResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public ComponentsSearchAddressesResponseResultsTypeItem[] Results { get; set; }
    }

    public class ComponentsSearchAddressesResponseResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class ComponentsSearchHostsResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("results")]
        public ComponentsSearchHostsResponseResultsTypeItem[] Results { get; set; }
    }

    public class ComponentsSearchHostsResponseResultsTypeItem
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }
    }

    public class PassiveDnsSearchResponse
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("results")]
        public DnsSearchResult[] Results { get; set; }

        [JsonProperty("queryType")]
        public string QueryType { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }
    }

    public class DnsSearchResult
    {
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("resolveType")]
        public string ResolveType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("recordHash")]
        public string RecordHash { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("resolve")]
        public string Resolve { get; set; }

        [JsonProperty("source")]
        public string[] Source { get; set; }

        [JsonProperty("recordType")]
        public string RecordType { get; set; }

        [JsonProperty("collected")]
        public string Collected { get; set; }
    }

    public class PassiveUniqueDnsSearchResponse
    {
        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("frequency")]
        public JToken[][] Frequency { get; set; }

        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }

        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("queryType")]
        public string QueryType { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class KeywordDnsSearchResponse
    {
        [JsonProperty("results")]
        public DnsKeywordSearchMatch[] Results { get; set; }

        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }
    }

    public class DnsKeywordSearchMatch
    {
        [JsonProperty("fieldMatch")]
        public string FieldMatch { get; set; }

        [JsonProperty("focusPoint")]
        public string FocusPoint { get; set; }

        [JsonProperty("matchType")]
        public string MatchType { get; set; }
    }

    public class WhoisKeywordSearchResponse
    {
        [JsonProperty("queryValue")]
        public string QueryValue { get; set; }

        [JsonProperty("results")]
        public KeywordSearchResult[] Results { get; set; }

        [JsonProperty("totalrecords")]
        public int Totalrecords { get; set; }
    }

    public class KeywordSearchResult
    {
        [JsonProperty("matchType")]
        public string MatchType { get; set; }

        [JsonProperty("fieldMatch")]
        public string FieldMatch { get; set; }

        [JsonProperty("focusPoint")]
        public string FocusPoint { get; set; }
    }

    public class ResultListResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public WhoisSearchResult[] Results { get; set; }

        [JsonProperty("totalrecords")]
        public int Totalrecords { get; set; }
    }

    public class WhoisSearchResult
    {
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("nameServers")]
        public string[] NameServers { get; set; }

        [JsonProperty("billing")]
        public JToken Billing { get; set; }

        [JsonProperty("zone")]
        public JToken Zone { get; set; }

        [JsonProperty("admin")]
        public JToken Admin { get; set; }

        [JsonProperty("tech")]
        public JToken Tech { get; set; }

        [JsonProperty("registrant")]
        public JToken Registrant { get; set; }

        [JsonProperty("registryUpdatedAt")]
        public string RegistryUpdatedAt { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("lastLoadedAt")]
        public string LastLoadedAt { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("whoisServer")]
        public string WhoisServer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("rawText")]
        public string RawText { get; set; }
    }

    public class EnrichmentBulkResponse
    {
        [JsonProperty("results")]
        public JToken Results { get; set; }
    }

    public class MalwareBulkSearchResults
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public JToken Results { get; set; }
    }

    public class OsintBulkResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public JToken Results { get; set; }
    }

    public class ReputationResponse
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("rules")]
        public ReputationRules[] Rules { get; set; }
    }

    public class ReputationRules
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class IntelProfilesResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("osintIndicatorsCount")]
        public int OsintIndicatorsCount { get; set; }

        [JsonProperty("riskIqIndicatorsCount")]
        public int RiskIqIndicatorsCount { get; set; }

        [JsonProperty("indicators")]
        public string Indicators { get; set; }

        [JsonProperty("tags")]
        public IntelProfileTag[] Tags { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }
    }

    public class IntelProfileTag
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class IntelProfilesIndicatorListResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("results")]
        public IntelProfileIndicator[] Results { get; set; }
    }

    public class IntelProfileIndicator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profileId")]
        public string ProfileId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("osint")]
        public bool Osint { get; set; }

        [JsonProperty("osintUrl")]
        public string OsintUrl { get; set; }

        [JsonProperty("articleGuids")]
        public string[] ArticleGuids { get; set; }
    }

    public class IntelProfilesListResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("results")]
        public IntelProfilesResponse[] Results { get; set; }
    }

    public class VendorInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priorities")]
        public VendorInfoPrioritiesType Priorities { get; set; }
    }

    public class VendorInfoPrioritiesType
    {
        [JsonProperty("high")]
        public VendorInfoPrioritiesTypeHighType High { get; set; }

        [JsonProperty("medium")]
        public VendorInfoPrioritiesTypeMediumType Medium { get; set; }

        [JsonProperty("low")]
        public VendorInfoPrioritiesTypeLowType Low { get; set; }
    }

    public class VendorInfoPrioritiesTypeHighType
    {
        [JsonProperty("observationCount")]
        public int ObservationCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class VendorInfoPrioritiesTypeMediumType
    {
        [JsonProperty("observationCount")]
        public int ObservationCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class VendorInfoPrioritiesTypeLowType
    {
        [JsonProperty("observationCount")]
        public int ObservationCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class AttackSurfacePriorityResponse
    {
        [JsonProperty("activeInsightCount")]
        public int ActiveInsightCount { get; set; }

        [JsonProperty("totalInsightCount")]
        public int TotalInsightCount { get; set; }

        [JsonProperty("totalObservations")]
        public int TotalObservations { get; set; }

        [JsonProperty("insights")]
        public InsightInfo[] Insights { get; set; }
    }

    public class InsightInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("observationCount")]
        public int ObservationCount { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public enum levelInput
    {
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "low")]
        Low
    }

    public class AttackSurfaceInsightResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("assets")]
        public AssetInfo[] Assets { get; set; }
    }

    public class AssetInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }
    }

    public class AttackSurfaceResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("vendors")]
        public VendorInfo[] Vendors { get; set; }
    }

    public class VulnerableComponentResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("vulnerableComponents")]
        public VulnerableComponent[] VulnerableComponents { get; set; }
    }

    public class VulnerableComponent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class AttackSurfaceCveResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("cves")]
        public CveInfo[] Cves { get; set; }
    }

    public class CveInfo
    {
        [JsonProperty("cveId")]
        public string CveId { get; set; }

        [JsonProperty("priorityScore")]
        public double PriorityScore { get; set; }

        [JsonProperty("observationCount")]
        public int ObservationCount { get; set; }

        [JsonProperty("cveLink")]
        public string CveLink { get; set; }

        [JsonProperty("cwes")]
        public CweInfo[] Cwes { get; set; }
    }

    public class CweInfo
    {
        [JsonProperty("cweId")]
        public string CweId { get; set; }
    }

    public class AttackSurfaceCveObservationsResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("cveId")]
        public string CveId { get; set; }

        [JsonProperty("cwes")]
        public CweInfo[] Cwes { get; set; }

        [JsonProperty("assets")]
        public AssetInfo[] Assets { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Riskiqpassivetotal;

    public partial class WorkflowManagedActions
    {
        public RiskiqpassivetotalActions Riskiqpassivetotal(string connectionId) => new RiskiqpassivetotalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RiskiqpassivetotalTriggers Riskiqpassivetotal(string connectionId) => new RiskiqpassivetotalTriggers(connectionId);
    }
}