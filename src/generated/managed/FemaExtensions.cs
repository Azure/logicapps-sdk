//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fema
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FemaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DeclarationDenialsResponse> GetV1DeclarationDenials(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/DeclarationDenials";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1DeclarationDenialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2DisasterDeclarationsSummariesResponse> GetV2DisasterDeclarationsSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/DisasterDeclarationsSummaries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2DisasterDeclarationsSummariesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDeclarationAreasResponse> GetV1FemaWebDeclarationAreas(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/FemaWebDeclarationAreas";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1FemaWebDeclarationAreasResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDisasterDeclarationsResponse> GetV1FemaWebDisasterDeclarations(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/FemaWebDisasterDeclarations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1FemaWebDisasterDeclarationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1FemaWebDisasterSummariesResponse> GetV1FemaWebDisasterSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/FemaWebDisasterSummaries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1FemaWebDisasterSummariesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2MissionAssignmentsResponse> GetV2MissionAssignments(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/MissionAssignments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2MissionAssignmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2EmergencyManagementPerformanceGrantsResponse> GetV2EmergencyManagementPerformanceGrants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/EmergencyManagementPerformanceGrants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2EmergencyManagementPerformanceGrantsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IpawsArchivedAlertsResponse> GetV1IpawsArchivedAlerts(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/IpawsArchivedAlerts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1IpawsArchivedAlertsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NonDisasterAssistanceFirefighterGrantsResponse> GetV1NonDisasterAssistanceFirefighterGrants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NonDisasterAssistanceFirefighterGrants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NonDisasterAssistanceFirefighterGrantsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V4HazardMitigationAssistanceMitigatedPropertiesResponse> GetV4HazardMitigationAssistanceMitigatedProperties(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v4/HazardMitigationAssistanceMitigatedProperties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V4HazardMitigationAssistanceMitigatedPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V4HazardMitigationAssistanceProjectsResponse> GetV4HazardMitigationAssistanceProjects(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v4/HazardMitigationAssistanceProjects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V4HazardMitigationAssistanceProjectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse> GetV2HazardMitigationAssistanceProjectsByNfipCrsCommunities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/HazardMitigationAssistanceProjectsByNfipCrsCommunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse> GetV1HazardMitigationAssistanceProjectsFinancialTransactions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/HazardMitigationAssistanceProjectsFinancialTransactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HazardMitigationGrantProgramDisasterSummariesResponse> GetV2HazardMitigationGrantProgramDisasterSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/HazardMitigationGrantProgramDisasterSummaries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2HazardMitigationGrantProgramDisasterSummariesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HazardMitigationPlanStatusesResponse> GetV1HazardMitigationPlanStatuses(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/HazardMitigationPlanStatuses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1HazardMitigationPlanStatusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HmaSubapplicationsResponse> GetV2HmaSubapplications(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/HmaSubapplications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2HmaSubapplicationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsByNfipCrsCommunitiesResponse> GetV1HmaSubapplicationsByNfipCrsCommunities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/HmaSubapplicationsByNfipCrsCommunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1HmaSubapplicationsByNfipCrsCommunitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsFinancialTransactionsResponse> GetV1HmaSubapplicationsFinancialTransactions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/HmaSubapplicationsFinancialTransactions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1HmaSubapplicationsFinancialTransactionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1HmaSubapplicationsProjectSiteInventoriesResponse> GetV1HmaSubapplicationsProjectSiteInventories(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/HmaSubapplicationsProjectSiteInventories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1HmaSubapplicationsProjectSiteInventoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HousingAssistanceOwnersResponse> GetV2HousingAssistanceOwners(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/HousingAssistanceOwners";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2HousingAssistanceOwnersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2HousingAssistanceRentersResponse> GetV2HousingAssistanceRenters(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/HousingAssistanceRenters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2HousingAssistanceRentersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse> GetV1IndividualAssistanceHousingRegistrantsLargeDisasters(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/IndividualAssistanceHousingRegistrantsLargeDisasters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1IndividualsAndHouseholdsProgramValidRegistrationsResponse> GetV1IndividualsAndHouseholdsProgramValidRegistrations(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/IndividualsAndHouseholdsProgramValidRegistrations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1IndividualsAndHouseholdsProgramValidRegistrationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2RegistrationIntakeIndividualsHouseholdProgramsResponse> GetV2RegistrationIntakeIndividualsHouseholdPrograms(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/RegistrationIntakeIndividualsHouseholdPrograms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2RegistrationIntakeIndividualsHouseholdProgramsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DataSetFieldsResponse> GetV1DataSetFields(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/DataSetFields";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1DataSetFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1DataSetsResponse> GetV1DataSets(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/DataSets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1DataSetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FemaRegionsResponse> GetV2FemaRegions(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/FemaRegions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2FemaRegionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FimaNfipClaimsResponse> GetV2FimaNfipClaims(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/FimaNfipClaims";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2FimaNfipClaimsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2FimaNfipPoliciesResponse> GetV2FimaNfipPolicies(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/FimaNfipPolicies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2FimaNfipPoliciesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerComprehensiveResponse> GetV1NfipCommunityLayerComprehensive(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipCommunityLayerComprehensive";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipCommunityLayerComprehensiveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerNoOverlapsSplitResponse> GetV1NfipCommunityLayerNoOverlapsSplit(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipCommunityLayerNoOverlapsSplit";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipCommunityLayerNoOverlapsSplitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityLayerNoOverlapsWholeResponse> GetV1NfipCommunityLayerNoOverlapsWhole(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipCommunityLayerNoOverlapsWhole";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipCommunityLayerNoOverlapsWholeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipCommunityStatusBookResponse> GetV1NfipCommunityStatusBook(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipCommunityStatusBook";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipCommunityStatusBookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipMultipleLossPropertiesResponse> GetV1NfipMultipleLossProperties(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipMultipleLossProperties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipMultipleLossPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1NfipResidentialPenetrationRatesResponse> GetV1NfipResidentialPenetrationRates(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/NfipResidentialPenetrationRates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1NfipResidentialPenetrationRatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceApplicantsResponse> GetV1PublicAssistanceApplicants(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/PublicAssistanceApplicants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1PublicAssistanceApplicantsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceApplicantsProgramDeliveriesResponse> GetV1PublicAssistanceApplicantsProgramDeliveries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/PublicAssistanceApplicantsProgramDeliveries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1PublicAssistanceApplicantsProgramDeliveriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceFundedProjectsDetailsResponse> GetV1PublicAssistanceFundedProjectsDetails(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/PublicAssistanceFundedProjectsDetails";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1PublicAssistanceFundedProjectsDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V1PublicAssistanceFundedProjectsSummariesResponse> GetV1PublicAssistanceFundedProjectsSummaries(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v1/PublicAssistanceFundedProjectsSummaries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V1PublicAssistanceFundedProjectsSummariesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fema")]
        public IBodyWorkflowAction<V2PublicAssistanceGrantAwardActivitiesResponse> GetV2PublicAssistanceGrantAwardActivities(Expression<Func<string>> filter = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> filename = null, Expression<Func<bool>> metadata = null, Expression<Func<string>> gzip = null, Expression<Func<orderbyInputItem[]>> orderby = null, Expression<Func<selectInputItem[]>> select = null)
        {
            var apiCallPath = "/v2/PublicAssistanceGrantAwardActivities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$top"] = Convert.ToString(1000);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["$skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["$count"] = Convert.ToString(false);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            if (filename != null)
                callPayload.Queries["$filename"] = ExpressionConverter.Convert(filename);
            callPayload.Queries["$metadata"] = Convert.ToString(true);
            if (metadata != null)
                callPayload.Queries["$metadata"] = ExpressionConverter.Convert(metadata);
            if (gzip != null)
                callPayload.Queries["$gzip"] = ExpressionConverter.Convert(gzip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$format"] = Convert.ToString("json");
            return new ApiConnectionAction<V2PublicAssistanceGrantAwardActivitiesResponse>(callPayload);
        }
    }

    public class FemaTriggers([ConnectionName] string connectionId)
    {
    }

    public class V1DeclarationDenialsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1DeclarationDenials[] DeclarationDenials { get; set; }
    }

    public class MetadataInfo
    {
        [JsonProperty("skip")]
        public double Skip { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("orderBy")]
        public string OrderBy { get; set; }

        [JsonProperty("select")]
        public string Select { get; set; }

        [JsonProperty("rundate")]
        public string Rundate { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("metadata")]
        public bool Metadata { get; set; }

        [JsonProperty("entityname")]
        public string Entityname { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }
    }

    public class V1DeclarationDenials
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("declarationRequestNumber")]
        public int DeclarationRequestNumber { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("tribalRequest")]
        public bool TribalRequest { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("declarationRequestDate")]
        public string DeclarationRequestDate { get; set; }

        [JsonProperty("declarationRequestType")]
        public string DeclarationRequestType { get; set; }

        [JsonProperty("incidentName")]
        public string IncidentName { get; set; }

        [JsonProperty("requestedIncidentTypes")]
        public string RequestedIncidentTypes { get; set; }

        [JsonProperty("currentRequestStatus")]
        public string CurrentRequestStatus { get; set; }

        [JsonProperty("requestedIncidentBeginDate")]
        public string RequestedIncidentBeginDate { get; set; }

        [JsonProperty("requestedIncidentEndDate")]
        public string RequestedIncidentEndDate { get; set; }

        [JsonProperty("requestStatusDate")]
        public string RequestStatusDate { get; set; }

        [JsonProperty("ihProgramRequested")]
        public bool IhProgramRequested { get; set; }

        [JsonProperty("iaProgramRequested")]
        public bool IaProgramRequested { get; set; }

        [JsonProperty("paProgramRequested")]
        public bool PaProgramRequested { get; set; }

        [JsonProperty("hmProgramRequested")]
        public bool HmProgramRequested { get; set; }

        [JsonProperty("incidentId")]
        public int IncidentId { get; set; }

        [JsonProperty("incidentBeginDate")]
        public string IncidentBeginDate { get; set; }
    }

    public enum orderbyInputItem
    {
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "region desc")]
        RegionDesc,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "disasterNumber desc")]
        DisasterNumberDesc,
        [EnumMember(Value = "sriaDisaster")]
        SriaDisaster,
        [EnumMember(Value = "sriaDisaster desc")]
        SriaDisasterDesc,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "declarationTitle desc")]
        DeclarationTitleDesc,
        [EnumMember(Value = "disasterType")]
        DisasterType,
        [EnumMember(Value = "disasterType desc")]
        DisasterTypeDesc,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "incidentType desc")]
        IncidentTypeDesc,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "declarationDate desc")]
        DeclarationDateDesc,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "stateAbbreviation desc")]
        StateAbbreviationDesc,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "state desc")]
        StateDesc,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "county desc")]
        CountyDesc,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "applicantId desc")]
        ApplicantIdDesc,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "applicantName desc")]
        ApplicantNameDesc,
        [EnumMember(Value = "pnpStatus")]
        PnpStatus,
        [EnumMember(Value = "pnpStatus desc")]
        PnpStatusDesc,
        [EnumMember(Value = "damageCategoryCode")]
        DamageCategoryCode,
        [EnumMember(Value = "damageCategoryCode desc")]
        DamageCategoryCodeDesc,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "federalShareObligated desc")]
        FederalShareObligatedDesc,
        [EnumMember(Value = "dateObligated")]
        DateObligated,
        [EnumMember(Value = "dateObligated desc")]
        DateObligatedDesc,
        [EnumMember(Value = "pwNumber")]
        PwNumber,
        [EnumMember(Value = "pwNumber desc")]
        PwNumberDesc,
        [EnumMember(Value = "projectTitle")]
        ProjectTitle,
        [EnumMember(Value = "projectTitle desc")]
        ProjectTitleDesc,
        [EnumMember(Value = "versionNumber")]
        VersionNumber,
        [EnumMember(Value = "versionNumber desc")]
        VersionNumberDesc,
        [EnumMember(Value = "eligibilityStatus")]
        EligibilityStatus,
        [EnumMember(Value = "eligibilityStatus desc")]
        EligibilityStatusDesc,
        [EnumMember(Value = "fundingStatus")]
        FundingStatus,
        [EnumMember(Value = "fundingStatus desc")]
        FundingStatusDesc,
        [EnumMember(Value = "paCloseoutStatus")]
        PaCloseoutStatus,
        [EnumMember(Value = "paCloseoutStatus desc")]
        PaCloseoutStatusDesc,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "id desc")]
        IdDesc
    }

    public enum selectInputItem
    {
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "disasterNumber")]
        DisasterNumber,
        [EnumMember(Value = "sriaDisaster")]
        SriaDisaster,
        [EnumMember(Value = "declarationTitle")]
        DeclarationTitle,
        [EnumMember(Value = "disasterType")]
        DisasterType,
        [EnumMember(Value = "incidentType")]
        IncidentType,
        [EnumMember(Value = "declarationDate")]
        DeclarationDate,
        [EnumMember(Value = "stateAbbreviation")]
        StateAbbreviation,
        [EnumMember(Value = "state")]
        State,
        [EnumMember(Value = "county")]
        County,
        [EnumMember(Value = "applicantId")]
        ApplicantId,
        [EnumMember(Value = "applicantName")]
        ApplicantName,
        [EnumMember(Value = "pnpStatus")]
        PnpStatus,
        [EnumMember(Value = "damageCategoryCode")]
        DamageCategoryCode,
        [EnumMember(Value = "federalShareObligated")]
        FederalShareObligated,
        [EnumMember(Value = "dateObligated")]
        DateObligated,
        [EnumMember(Value = "pwNumber")]
        PwNumber,
        [EnumMember(Value = "projectTitle")]
        ProjectTitle,
        [EnumMember(Value = "versionNumber")]
        VersionNumber,
        [EnumMember(Value = "eligibilityStatus")]
        EligibilityStatus,
        [EnumMember(Value = "fundingStatus")]
        FundingStatus,
        [EnumMember(Value = "paCloseoutStatus")]
        PaCloseoutStatus,
        [EnumMember(Value = "id")]
        Id
    }

    public class V2DisasterDeclarationsSummariesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2DisasterDeclarationsSummaries[] DisasterDeclarationsSummaries { get; set; }
    }

    public class V2DisasterDeclarationsSummaries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("femaDeclarationString")]
        public string FemaDeclarationString { get; set; }

        [JsonProperty("declarationType")]
        public string DeclarationType { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("fyDeclared")]
        public int FyDeclared { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("declarationTitle")]
        public string DeclarationTitle { get; set; }

        [JsonProperty("ihProgramDeclared")]
        public string IhProgramDeclared { get; set; }

        [JsonProperty("iaProgramDeclared")]
        public string IaProgramDeclared { get; set; }

        [JsonProperty("paProgramDeclared")]
        public string PaProgramDeclared { get; set; }

        [JsonProperty("hmProgramDeclared")]
        public string HmProgramDeclared { get; set; }

        [JsonProperty("incidentBeginDate")]
        public string IncidentBeginDate { get; set; }

        [JsonProperty("incidentEndDate")]
        public string IncidentEndDate { get; set; }

        [JsonProperty("disasterCloseoutDate")]
        public string DisasterCloseoutDate { get; set; }

        [JsonProperty("tribalRequest")]
        public string TribalRequest { get; set; }

        [JsonProperty("fipsStateCode")]
        public string FipsStateCode { get; set; }

        [JsonProperty("fipsCountyCode")]
        public string FipsCountyCode { get; set; }

        [JsonProperty("placeCode")]
        public string PlaceCode { get; set; }

        [JsonProperty("designatedArea")]
        public string DesignatedArea { get; set; }

        [JsonProperty("declarationRequestNumber")]
        public string DeclarationRequestNumber { get; set; }

        [JsonProperty("lastIAFilingDate")]
        public string LastIAFilingDate { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("designatedIncidentTypes")]
        public string DesignatedIncidentTypes { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1FemaWebDeclarationAreasResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1FemaWebDeclarationAreas[] FemaWebDeclarationAreas { get; set; }
    }

    public class V1FemaWebDeclarationAreas
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("programTypeCode")]
        public string ProgramTypeCode { get; set; }

        [JsonProperty("programTypeDescription")]
        public string ProgramTypeDescription { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("placeCode")]
        public string PlaceCode { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("designatedDate")]
        public string DesignatedDate { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("closeoutDate")]
        public string CloseoutDate { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1FemaWebDisasterDeclarationsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1FemaWebDisasterDeclarations[] FemaWebDisasterDeclarations { get; set; }
    }

    public class V1FemaWebDisasterDeclarations
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("disasterName")]
        public string DisasterName { get; set; }

        [JsonProperty("incidentBeginDate")]
        public string IncidentBeginDate { get; set; }

        [JsonProperty("incidentEndDate")]
        public string IncidentEndDate { get; set; }

        [JsonProperty("declarationType")]
        public string DeclarationType { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("entryDate")]
        public string EntryDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("closeoutDate")]
        public string CloseoutDate { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("ihProgramDeclared")]
        public string IhProgramDeclared { get; set; }

        [JsonProperty("iaProgramDeclared")]
        public string IaProgramDeclared { get; set; }

        [JsonProperty("paProgramDeclared")]
        public string PaProgramDeclared { get; set; }

        [JsonProperty("hmProgramDeclared")]
        public string HmProgramDeclared { get; set; }

        [JsonProperty("designatedIncidentTypes")]
        public string DesignatedIncidentTypes { get; set; }

        [JsonProperty("declarationRequestDate")]
        public string DeclarationRequestDate { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1FemaWebDisasterSummariesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1FemaWebDisasterSummaries[] FemaWebDisasterSummaries { get; set; }
    }

    public class V1FemaWebDisasterSummaries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("totalNumberIaApproved")]
        public double TotalNumberIaApproved { get; set; }

        [JsonProperty("totalAmountIhpApproved")]
        public double TotalAmountIhpApproved { get; set; }

        [JsonProperty("totalAmountHaApproved")]
        public double TotalAmountHaApproved { get; set; }

        [JsonProperty("totalAmountOnaApproved")]
        public double TotalAmountOnaApproved { get; set; }

        [JsonProperty("totalObligatedAmountPa")]
        public double TotalObligatedAmountPa { get; set; }

        [JsonProperty("totalObligatedAmountCatAb")]
        public double TotalObligatedAmountCatAb { get; set; }

        [JsonProperty("totalObligatedAmountCatC2g")]
        public double TotalObligatedAmountCatC2g { get; set; }

        [JsonProperty("paLoadDate")]
        public string PaLoadDate { get; set; }

        [JsonProperty("iaLoadDate")]
        public string IaLoadDate { get; set; }

        [JsonProperty("totalObligatedAmountHmgp")]
        public double TotalObligatedAmountHmgp { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V2MissionAssignmentsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2MissionAssignments[] MissionAssignments { get; set; }
    }

    public class V2MissionAssignments
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("incidentName")]
        public string IncidentName { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("declarationType")]
        public string DeclarationType { get; set; }

        [JsonProperty("declarationTitle")]
        public string DeclarationTitle { get; set; }

        [JsonProperty("maId")]
        public string MaId { get; set; }

        [JsonProperty("maAmendNumber")]
        public int MaAmendNumber { get; set; }

        [JsonProperty("actionId")]
        public int ActionId { get; set; }

        [JsonProperty("maType")]
        public string MaType { get; set; }

        [JsonProperty("supportFunction")]
        public int SupportFunction { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("stt")]
        public string Stt { get; set; }

        [JsonProperty("agencyId")]
        public string AgencyId { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("dateReceived")]
        public string DateReceived { get; set; }

        [JsonProperty("dateRequired")]
        public string DateRequired { get; set; }

        [JsonProperty("popStartDate")]
        public string PopStartDate { get; set; }

        [JsonProperty("popEndDate")]
        public string PopEndDate { get; set; }

        [JsonProperty("dateObligated")]
        public string DateObligated { get; set; }

        [JsonProperty("obligationAmount")]
        public double ObligationAmount { get; set; }

        [JsonProperty("sttCostSharePct")]
        public double SttCostSharePct { get; set; }

        [JsonProperty("fedCostSharePct")]
        public double FedCostSharePct { get; set; }

        [JsonProperty("sttCostShareAmt")]
        public double SttCostShareAmt { get; set; }

        [JsonProperty("fedCostShareAmt")]
        public double FedCostShareAmt { get; set; }

        [JsonProperty("maPopStartDate")]
        public string MaPopStartDate { get; set; }

        [JsonProperty("maPopEndDate")]
        public string MaPopEndDate { get; set; }

        [JsonProperty("maSttCostSharePct")]
        public double MaSttCostSharePct { get; set; }

        [JsonProperty("maFedCostSharePct")]
        public double MaFedCostSharePct { get; set; }

        [JsonProperty("maSttCostShareAmount")]
        public double MaSttCostShareAmount { get; set; }

        [JsonProperty("maFedCostShareAmount")]
        public double MaFedCostShareAmount { get; set; }

        [JsonProperty("maPriority")]
        public string MaPriority { get; set; }

        [JsonProperty("assistanceRequested")]
        public string AssistanceRequested { get; set; }

        [JsonProperty("statementOfWork")]
        public string StatementOfWork { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }
    }

    public class V2EmergencyManagementPerformanceGrantsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2EmergencyManagementPerformanceGrants[] EmergencyManagementPerformanceGrants { get; set; }
    }

    public class V2EmergencyManagementPerformanceGrants
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reportingPeriod")]
        public string ReportingPeriod { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("legalAgencyName")]
        public string LegalAgencyName { get; set; }

        [JsonProperty("projectType")]
        public string ProjectType { get; set; }

        [JsonProperty("projectStartDate")]
        public string ProjectStartDate { get; set; }

        [JsonProperty("projectEndDate")]
        public string ProjectEndDate { get; set; }

        [JsonProperty("nameOfProgram")]
        public string NameOfProgram { get; set; }

        [JsonProperty("fundingAmount")]
        public double FundingAmount { get; set; }
    }

    public class V1IpawsArchivedAlertsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1IpawsArchivedAlerts[] IpawsArchivedAlerts { get; set; }
    }

    public class V1IpawsArchivedAlerts
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("sent")]
        public string Sent { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("msgType")]
        public string MsgType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("restriction")]
        public string Restriction { get; set; }

        [JsonProperty("addresses")]
        public string Addresses { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("incidents")]
        public string Incidents { get; set; }

        [JsonProperty("searchGeometry")]
        public string SearchGeometry { get; set; }

        [JsonProperty("infos")]
        public JToken[] Infos { get; set; }

        [JsonProperty("cogId")]
        public int CogId { get; set; }

        [JsonProperty("xmlns")]
        public string Xmlns { get; set; }

        [JsonProperty("originalMessage")]
        public string OriginalMessage { get; set; }
    }

    public class V1NonDisasterAssistanceFirefighterGrantsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NonDisasterAssistanceFirefighterGrants[] NonDisasterAssistanceFirefighterGrants { get; set; }
    }

    public class V1NonDisasterAssistanceFirefighterGrants
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("awardNumber")]
        public string AwardNumber { get; set; }

        [JsonProperty("fiscalYear")]
        public int FiscalYear { get; set; }

        [JsonProperty("programName")]
        public string ProgramName { get; set; }

        [JsonProperty("programAbbreviation")]
        public string ProgramAbbreviation { get; set; }

        [JsonProperty("vendorState")]
        public string VendorState { get; set; }

        [JsonProperty("awardAmount")]
        public double AwardAmount { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("vendorName")]
        public string VendorName { get; set; }
    }

    public class V4HazardMitigationAssistanceMitigatedPropertiesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V4HazardMitigationAssistanceMitigatedProperties[] HazardMitigationAssistanceMitigatedProperties { get; set; }
    }

    public class V4HazardMitigationAssistanceMitigatedProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("propertyPartOfProject")]
        public string PropertyPartOfProject { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("stateNumberCode")]
        public string StateNumberCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("foundationType")]
        public string FoundationType { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("projectIdentifier")]
        public string ProjectIdentifier { get; set; }

        [JsonProperty("propertyAction")]
        public string PropertyAction { get; set; }

        [JsonProperty("structureType")]
        public string StructureType { get; set; }

        [JsonProperty("typeOfResidency")]
        public string TypeOfResidency { get; set; }

        [JsonProperty("actualAmountPaid")]
        public string ActualAmountPaid { get; set; }

        [JsonProperty("programFy")]
        public int ProgramFy { get; set; }

        [JsonProperty("programArea")]
        public string ProgramArea { get; set; }

        [JsonProperty("numberOfProperties")]
        public int NumberOfProperties { get; set; }

        [JsonProperty("damageCategory")]
        public string DamageCategory { get; set; }
    }

    public class V4HazardMitigationAssistanceProjectsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V4HazardMitigationAssistanceProjects[] HazardMitigationAssistanceProjects { get; set; }
    }

    public class V4HazardMitigationAssistanceProjects
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("stateNumberCode")]
        public string StateNumberCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("programArea")]
        public string ProgramArea { get; set; }

        [JsonProperty("projectIdentifier")]
        public string ProjectIdentifier { get; set; }

        [JsonProperty("projectType")]
        public string ProjectType { get; set; }

        [JsonProperty("projectCounties")]
        public string ProjectCounties { get; set; }

        [JsonProperty("numberOfProperties")]
        public int NumberOfProperties { get; set; }

        [JsonProperty("numberOfFinalProperties")]
        public int NumberOfFinalProperties { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subrecipient")]
        public string Subrecipient { get; set; }

        [JsonProperty("projectAmount")]
        public double ProjectAmount { get; set; }

        [JsonProperty("initialObligationDate")]
        public string InitialObligationDate { get; set; }

        [JsonProperty("initialObligationAmount")]
        public double InitialObligationAmount { get; set; }

        [JsonProperty("costSharePercentage")]
        public double CostSharePercentage { get; set; }

        [JsonProperty("federalShareObligated")]
        public double FederalShareObligated { get; set; }

        [JsonProperty("programFy")]
        public int ProgramFy { get; set; }

        [JsonProperty("dateInitiallyApproved")]
        public string DateInitiallyApproved { get; set; }

        [JsonProperty("dateApproved")]
        public string DateApproved { get; set; }

        [JsonProperty("dateClosed")]
        public string DateClosed { get; set; }

        [JsonProperty("recipientTribalIndicator")]
        public string RecipientTribalIndicator { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("benefitCostRatio")]
        public double BenefitCostRatio { get; set; }

        [JsonProperty("netValueBenefits")]
        public double NetValueBenefits { get; set; }

        [JsonProperty("subrecipientTribalIndicator")]
        public string SubrecipientTribalIndicator { get; set; }

        [JsonProperty("dataSource")]
        public string DataSource { get; set; }

        [JsonProperty("subrecipientAdminCostAmt")]
        public int SubrecipientAdminCostAmt { get; set; }

        [JsonProperty("recipientAdminCostAmt")]
        public double RecipientAdminCostAmt { get; set; }

        [JsonProperty("srmcObligatedAmt")]
        public double SrmcObligatedAmt { get; set; }
    }

    public class V2HazardMitigationAssistanceProjectsByNfipCrsCommunitiesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2HazardMitigationAssistanceProjectsByNfipCrsCommunities[] HazardMitigationAssistanceProjectsByNfipCrsCommunities { get; set; }
    }

    public class V2HazardMitigationAssistanceProjectsByNfipCrsCommunities
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("projectIdentifier")]
        public string ProjectIdentifier { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("communityNumber")]
        public string CommunityNumber { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1HazardMitigationAssistanceProjectsFinancialTransactionsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1HazardMitigationAssistanceProjectsFinancialTransactions[] HazardMitigationAssistanceProjectsFinancialTransactions { get; set; }
    }

    public class V1HazardMitigationAssistanceProjectsFinancialTransactions
    {
        [JsonProperty("projectIdentifier")]
        public string ProjectIdentifier { get; set; }

        [JsonProperty("transactionIdentifier")]
        public int TransactionIdentifier { get; set; }

        [JsonProperty("transactionDate")]
        public string TransactionDate { get; set; }

        [JsonProperty("commitmentIdentifier")]
        public string CommitmentIdentifier { get; set; }

        [JsonProperty("accsLine")]
        public string AccsLine { get; set; }

        [JsonProperty("fundCode")]
        public string FundCode { get; set; }

        [JsonProperty("federalShareProjectCostAmt")]
        public double FederalShareProjectCostAmt { get; set; }

        [JsonProperty("recipientAdminCostAmt")]
        public double RecipientAdminCostAmt { get; set; }

        [JsonProperty("subrecipientAdminCostAmt")]
        public double SubrecipientAdminCostAmt { get; set; }

        [JsonProperty("subrecipientMgmtCostAmt")]
        public double SubrecipientMgmtCostAmt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2HazardMitigationGrantProgramDisasterSummariesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2HazardMitigationGrantProgramDisasterSummaries[] HazardMitigationGrantProgramDisasterSummaries { get; set; }
    }

    public class V2HazardMitigationGrantProgramDisasterSummaries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("disasterType")]
        public string DisasterType { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("disasterCloseoutStatus")]
        public string DisasterCloseoutStatus { get; set; }

        [JsonProperty("hmgpCloseoutStatus")]
        public string HmgpCloseoutStatus { get; set; }

        [JsonProperty("disasterCloseoutDate")]
        public string DisasterCloseoutDate { get; set; }

        [JsonProperty("hmgpReconciliationDate")]
        public string HmgpReconciliationDate { get; set; }

        [JsonProperty("disasterDueDateForNewApps")]
        public string DisasterDueDateForNewApps { get; set; }

        [JsonProperty("disasterPopEndDate")]
        public string DisasterPopEndDate { get; set; }

        [JsonProperty("hmgpPopEndDate")]
        public string HmgpPopEndDate { get; set; }

        [JsonProperty("hmgpPopExtnDate")]
        public string HmgpPopExtnDate { get; set; }

        [JsonProperty("hmgpPopExtnNum")]
        public string HmgpPopExtnNum { get; set; }

        [JsonProperty("liqPeriodDate")]
        public string LiqPeriodDate { get; set; }

        [JsonProperty("liqPeriodMaxDate")]
        public string LiqPeriodMaxDate { get; set; }

        [JsonProperty("liqPeriodMaxPopNum")]
        public string LiqPeriodMaxPopNum { get; set; }

        [JsonProperty("liqPeriodMaxExtDate")]
        public string LiqPeriodMaxExtDate { get; set; }

        [JsonProperty("liqPeriodMaxExtNum")]
        public string LiqPeriodMaxExtNum { get; set; }

        [JsonProperty("mitigationDollarsAvailable")]
        public double MitigationDollarsAvailable { get; set; }

        [JsonProperty("lockedInCeilingAmount")]
        public double LockedInCeilingAmount { get; set; }

        [JsonProperty("obligatedTotalAmount")]
        public double ObligatedTotalAmount { get; set; }

        [JsonProperty("obligatedInitiativeAmount")]
        public double ObligatedInitiativeAmount { get; set; }

        [JsonProperty("obligatedPlanningAmount")]
        public double ObligatedPlanningAmount { get; set; }

        [JsonProperty("obligatedRegularAmount")]
        public double ObligatedRegularAmount { get; set; }

        [JsonProperty("obligatedRecipientMgmtAmt")]
        public double ObligatedRecipientMgmtAmt { get; set; }

        [JsonProperty("obligatedRecipientAdmin")]
        public double ObligatedRecipientAdmin { get; set; }

        [JsonProperty("obligatedSubrecipientAdmin")]
        public double ObligatedSubrecipientAdmin { get; set; }

        [JsonProperty("obligatedSubrecipMgmtAmt")]
        public double ObligatedSubrecipMgmtAmt { get; set; }

        [JsonProperty("pendingProjectsQuantity")]
        public int PendingProjectsQuantity { get; set; }

        [JsonProperty("pendingFedShareProposedAmt")]
        public string PendingFedShareProposedAmt { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1HazardMitigationPlanStatusesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1HazardMitigationPlanStatuses[] HazardMitigationPlanStatuses { get; set; }
    }

    public class V1HazardMitigationPlanStatuses
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("femaRegion")]
        public int FemaRegion { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("countyName")]
        public string CountyName { get; set; }

        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        [JsonProperty("planType")]
        public string PlanType { get; set; }

        [JsonProperty("planId")]
        public int PlanId { get; set; }

        [JsonProperty("planTitle")]
        public string PlanTitle { get; set; }

        [JsonProperty("planStatus")]
        public string PlanStatus { get; set; }

        [JsonProperty("apaDate")]
        public string ApaDate { get; set; }

        [JsonProperty("planApprovalDate")]
        public string PlanApprovalDate { get; set; }

        [JsonProperty("planExpirationDate")]
        public string PlanExpirationDate { get; set; }

        [JsonProperty("jurisdictionType")]
        public string JurisdictionType { get; set; }

        [JsonProperty("jurisdictionStatus")]
        public string JurisdictionStatus { get; set; }

        [JsonProperty("adoptionDate")]
        public string AdoptionDate { get; set; }

        [JsonProperty("jurisdictionApprovalDate")]
        public string JurisdictionApprovalDate { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("mppGeoid")]
        public string MppGeoid { get; set; }

        [JsonProperty("censusSource")]
        public string CensusSource { get; set; }

        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("popCoverage")]
        public string PopCoverage { get; set; }
    }

    public class V2HmaSubapplicationsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2HmaSubapplications[] HmaSubapplications { get; set; }
    }

    public class V2HmaSubapplications
    {
        [JsonProperty("subapplicationIdentifier")]
        public string SubapplicationIdentifier { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("fiscalYear")]
        public int FiscalYear { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("applicantUei")]
        public string ApplicantUei { get; set; }

        [JsonProperty("applicantName")]
        public string ApplicantName { get; set; }

        [JsonProperty("subapplicantUei")]
        public string SubapplicantUei { get; set; }

        [JsonProperty("subapplicantName")]
        public string SubapplicantName { get; set; }

        [JsonProperty("subapplicantCity")]
        public string SubapplicantCity { get; set; }

        [JsonProperty("subapplicantState")]
        public string SubapplicantState { get; set; }

        [JsonProperty("subapplicantStateAbbreviation")]
        public string SubapplicantStateAbbreviation { get; set; }

        [JsonProperty("subapplicantZipCode")]
        public string SubapplicantZipCode { get; set; }

        [JsonProperty("subapplicantZip4")]
        public string SubapplicantZip4 { get; set; }

        [JsonProperty("subjectEO12372")]
        public string SubjectEO12372 { get; set; }

        [JsonProperty("eo12372ReviewDate")]
        public string Eo12372ReviewDate { get; set; }

        [JsonProperty("subapplicantFederalDebt")]
        public bool SubapplicantFederalDebt { get; set; }

        [JsonProperty("dateInitiatedInSystem")]
        public string DateInitiatedInSystem { get; set; }

        [JsonProperty("dateSubmittedToApplicant")]
        public string DateSubmittedToApplicant { get; set; }

        [JsonProperty("dateSubmittedToFema")]
        public string DateSubmittedToFema { get; set; }

        [JsonProperty("subapplicationTitle")]
        public string SubapplicationTitle { get; set; }

        [JsonProperty("proposedProjectStartDate")]
        public string ProposedProjectStartDate { get; set; }

        [JsonProperty("proposedProjectEndDate")]
        public string ProposedProjectEndDate { get; set; }

        [JsonProperty("estimatedTotalDuration")]
        public int EstimatedTotalDuration { get; set; }

        [JsonProperty("fundingCategory")]
        public string FundingCategory { get; set; }

        [JsonProperty("subapplicantType")]
        public string SubapplicantType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subapplicationType")]
        public string SubapplicationType { get; set; }

        [JsonProperty("benefitingCounties")]
        public string BenefitingCounties { get; set; }

        [JsonProperty("primaryActivity")]
        public string PrimaryActivity { get; set; }

        [JsonProperty("primarySubactivity")]
        public string PrimarySubactivity { get; set; }

        [JsonProperty("secondaryActivity")]
        public string SecondaryActivity { get; set; }

        [JsonProperty("secondarySubactivity")]
        public string SecondarySubactivity { get; set; }

        [JsonProperty("tertiaryActivity")]
        public string TertiaryActivity { get; set; }

        [JsonProperty("tertiarySubactivity")]
        public string TertiarySubactivity { get; set; }

        [JsonProperty("primaryCommunityLifeline")]
        public string PrimaryCommunityLifeline { get; set; }

        [JsonProperty("primaryCommunityLifelineComponent")]
        public string PrimaryCommunityLifelineComponent { get; set; }

        [JsonProperty("secondaryCommunityLifeline")]
        public string SecondaryCommunityLifeline { get; set; }

        [JsonProperty("secondaryCommunityLifelineComponent")]
        public string SecondaryCommunityLifelineComponent { get; set; }

        [JsonProperty("tertiaryCommunityLifeline")]
        public string TertiaryCommunityLifeline { get; set; }

        [JsonProperty("tertiaryCommunityLifelineComponent")]
        public string TertiaryCommunityLifelineComponent { get; set; }

        [JsonProperty("primaryHazard")]
        public string PrimaryHazard { get; set; }

        [JsonProperty("secondaryHazard")]
        public string SecondaryHazard { get; set; }

        [JsonProperty("tertiaryHazard")]
        public string TertiaryHazard { get; set; }

        [JsonProperty("natureBasedSolution")]
        public string NatureBasedSolution { get; set; }

        [JsonProperty("smallImpoverished")]
        public bool SmallImpoverished { get; set; }

        [JsonProperty("populationAffected")]
        public string PopulationAffected { get; set; }

        [JsonProperty("phasedProject")]
        public bool PhasedProject { get; set; }

        [JsonProperty("construction")]
        public bool Construction { get; set; }

        [JsonProperty("priorSubapplication")]
        public bool PriorSubapplication { get; set; }

        [JsonProperty("communityRatingSystem")]
        public bool CommunityRatingSystem { get; set; }

        [JsonProperty("crsRating")]
        public int CrsRating { get; set; }

        [JsonProperty("cooperatingTechnicalPartner")]
        public bool CooperatingTechnicalPartner { get; set; }

        [JsonProperty("adoptedIcc")]
        public bool AdoptedIcc { get; set; }

        [JsonProperty("yearBuildingCode")]
        public int YearBuildingCode { get; set; }

        [JsonProperty("buildingCodesOnBcegs")]
        public bool BuildingCodesOnBcegs { get; set; }

        [JsonProperty("bcegsRating")]
        public int BcegsRating { get; set; }

        [JsonProperty("mitigationPlanCovered")]
        public bool MitigationPlanCovered { get; set; }

        [JsonProperty("mitigationPlanType")]
        public string MitigationPlanType { get; set; }

        [JsonProperty("mitigationPlanSubtype")]
        public string MitigationPlanSubtype { get; set; }

        [JsonProperty("dateMitigationPlanApproved")]
        public string DateMitigationPlanApproved { get; set; }

        [JsonProperty("costEffectivenessMethod")]
        public string CostEffectivenessMethod { get; set; }

        [JsonProperty("preCalculatedBenefit")]
        public string PreCalculatedBenefit { get; set; }

        [JsonProperty("environmentalBenefit")]
        public string EnvironmentalBenefit { get; set; }

        [JsonProperty("seaLevelRise")]
        public string SeaLevelRise { get; set; }

        [JsonProperty("socialBenefit")]
        public bool SocialBenefit { get; set; }

        [JsonProperty("mitigatingProjectSiteInventory")]
        public bool MitigatingProjectSiteInventory { get; set; }

        [JsonProperty("projectSiteInventoryLocationKnown")]
        public bool ProjectSiteInventoryLocationKnown { get; set; }

        [JsonProperty("numberBuildingLocations")]
        public int NumberBuildingLocations { get; set; }

        [JsonProperty("numberInfrastructureLocations")]
        public int NumberInfrastructureLocations { get; set; }

        [JsonProperty("numberVacantLandLocations")]
        public int NumberVacantLandLocations { get; set; }

        [JsonProperty("federalShareAmount")]
        public double FederalShareAmount { get; set; }

        [JsonProperty("nonFederalShareAmount")]
        public double NonFederalShareAmount { get; set; }

        [JsonProperty("mgmtFederalShareAmount")]
        public double MgmtFederalShareAmount { get; set; }

        [JsonProperty("mgmtNonFederalShareAmount")]
        public double MgmtNonFederalShareAmount { get; set; }

        [JsonProperty("totalSubapplicationAmount")]
        public double TotalSubapplicationAmount { get; set; }

        [JsonProperty("totalObligatedAmount")]
        public double TotalObligatedAmount { get; set; }

        [JsonProperty("totalPaymentAmount")]
        public double TotalPaymentAmount { get; set; }

        [JsonProperty("federalSharePercentage")]
        public double FederalSharePercentage { get; set; }

        [JsonProperty("nonFederalSharePercentage")]
        public double NonFederalSharePercentage { get; set; }

        [JsonProperty("benefitCostRatio")]
        public double BenefitCostRatio { get; set; }

        [JsonProperty("bcaTotalBenefits")]
        public double BcaTotalBenefits { get; set; }

        [JsonProperty("bcaTotalCosts")]
        public double BcaTotalCosts { get; set; }

        [JsonProperty("disasterNumber")]
        public string DisasterNumber { get; set; }

        [JsonProperty("selectionStatus")]
        public string SelectionStatus { get; set; }

        [JsonProperty("selectionFundingCategory")]
        public string SelectionFundingCategory { get; set; }

        [JsonProperty("selectionProgramActivity")]
        public string SelectionProgramActivity { get; set; }

        [JsonProperty("selectionFederalShareAmount")]
        public double SelectionFederalShareAmount { get; set; }

        [JsonProperty("selectionFundCode")]
        public string SelectionFundCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1HmaSubapplicationsByNfipCrsCommunitiesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1HmaSubapplicationsByNfipCrsCommunities[] HmaSubapplicationsByNfipCrsCommunities { get; set; }
    }

    public class V1HmaSubapplicationsByNfipCrsCommunities
    {
        [JsonProperty("subapplicationIdentifier")]
        public string SubapplicationIdentifier { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("communityNumber")]
        public string CommunityNumber { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("stateNumberCode")]
        public string StateNumberCode { get; set; }

        [JsonProperty("isCrsCommunity")]
        public string IsCrsCommunity { get; set; }

        [JsonProperty("crsRating")]
        public string CrsRating { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1HmaSubapplicationsFinancialTransactionsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1HmaSubapplicationsFinancialTransactions[] HmaSubapplicationsFinancialTransactions { get; set; }
    }

    public class V1HmaSubapplicationsFinancialTransactions
    {
        [JsonProperty("subapplicationIdentifier")]
        public string SubapplicationIdentifier { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("transactionDate")]
        public string TransactionDate { get; set; }

        [JsonProperty("commitmentIdentifier")]
        public string CommitmentIdentifier { get; set; }

        [JsonProperty("paymentNumber")]
        public string PaymentNumber { get; set; }

        [JsonProperty("accsLine")]
        public string AccsLine { get; set; }

        [JsonProperty("fundCode")]
        public string FundCode { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1HmaSubapplicationsProjectSiteInventoriesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1HmaSubapplicationsProjectSiteInventories[] HmaSubapplicationsProjectSiteInventories { get; set; }
    }

    public class V1HmaSubapplicationsProjectSiteInventories
    {
        [JsonProperty("subapplicationId")]
        public string SubapplicationId { get; set; }

        [JsonProperty("projectSiteInventoryId")]
        public int ProjectSiteInventoryId { get; set; }

        [JsonProperty("projectSiteInventoryType")]
        public string ProjectSiteInventoryType { get; set; }

        [JsonProperty("primaryActivity")]
        public string PrimaryActivity { get; set; }

        [JsonProperty("secondaryActivity")]
        public string SecondaryActivity { get; set; }

        [JsonProperty("primaryHazard")]
        public string PrimaryHazard { get; set; }

        [JsonProperty("secondaryHazard")]
        public string SecondaryHazard { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("structureType")]
        public string StructureType { get; set; }

        [JsonProperty("structurePrimarySubtype")]
        public string StructurePrimarySubtype { get; set; }

        [JsonProperty("structureSecondarySubtype")]
        public string StructureSecondarySubtype { get; set; }

        [JsonProperty("foundationType")]
        public string FoundationType { get; set; }

        [JsonProperty("buildingSize")]
        public double BuildingSize { get; set; }

        [JsonProperty("lotSize")]
        public string LotSize { get; set; }

        [JsonProperty("yearBuilt")]
        public int YearBuilt { get; set; }

        [JsonProperty("firstFloorElevation")]
        public double FirstFloorElevation { get; set; }

        [JsonProperty("feetAboveBaseFloodElevation")]
        public string FeetAboveBaseFloodElevation { get; set; }

        [JsonProperty("baseFloodElevation")]
        public double BaseFloodElevation { get; set; }

        [JsonProperty("floodZone")]
        public string FloodZone { get; set; }

        [JsonProperty("estimatedPurchasePrice")]
        public double EstimatedPurchasePrice { get; set; }

        [JsonProperty("proposedLandUse")]
        public string ProposedLandUse { get; set; }

        [JsonProperty("currentlyRented")]
        public bool CurrentlyRented { get; set; }

        [JsonProperty("criticalFacility")]
        public bool CriticalFacility { get; set; }

        [JsonProperty("alternateStructure")]
        public bool AlternateStructure { get; set; }

        [JsonProperty("substantiallyDamaged")]
        public bool SubstantiallyDamaged { get; set; }

        [JsonProperty("publiclyOwned")]
        public bool PubliclyOwned { get; set; }

        [JsonProperty("insured")]
        public string Insured { get; set; }

        [JsonProperty("insuranceType")]
        public string InsuranceType { get; set; }

        [JsonProperty("repetitiveLossStructure")]
        public bool RepetitiveLossStructure { get; set; }

        [JsonProperty("severeRepetitiveLossStructure")]
        public bool SevereRepetitiveLossStructure { get; set; }

        [JsonProperty("costEffectivenessMethod")]
        public string CostEffectivenessMethod { get; set; }

        [JsonProperty("preCalculatedBenefit")]
        public string PreCalculatedBenefit { get; set; }

        [JsonProperty("benefitCostRatio")]
        public double BenefitCostRatio { get; set; }

        [JsonProperty("ownerType")]
        public string OwnerType { get; set; }

        [JsonProperty("coownerType")]
        public string CoownerType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2HousingAssistanceOwnersResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2HousingAssistanceOwners[] HousingAssistanceOwners { get; set; }
    }

    public class V2HousingAssistanceOwners
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("validRegistrations")]
        public int ValidRegistrations { get; set; }

        [JsonProperty("averageFemaInspectedDamage")]
        public double AverageFemaInspectedDamage { get; set; }

        [JsonProperty("totalInspected")]
        public int TotalInspected { get; set; }

        [JsonProperty("totalDamage")]
        public double TotalDamage { get; set; }

        [JsonProperty("noFemaInspectedDamage")]
        public int NoFemaInspectedDamage { get; set; }

        [JsonProperty("femaInspectedDamageBetween1And10000")]
        public int FemaInspectedDamageBetween1And10000 { get; set; }

        [JsonProperty("femaInspectedDamageBetween10001And20000")]
        public int FemaInspectedDamageBetween10001And20000 { get; set; }

        [JsonProperty("femaInspectedDamageBetween20001And30000")]
        public int FemaInspectedDamageBetween20001And30000 { get; set; }

        [JsonProperty("femaInspectedDamageGreaterThan30000")]
        public int FemaInspectedDamageGreaterThan30000 { get; set; }

        [JsonProperty("approvedForFemaAssistance")]
        public int ApprovedForFemaAssistance { get; set; }

        [JsonProperty("totalApprovedIhpAmount")]
        public double TotalApprovedIhpAmount { get; set; }

        [JsonProperty("repairReplaceAmount")]
        public double RepairReplaceAmount { get; set; }

        [JsonProperty("rentalAmount")]
        public double RentalAmount { get; set; }

        [JsonProperty("otherNeedsAmount")]
        public double OtherNeedsAmount { get; set; }

        [JsonProperty("approvedBetween1And10000")]
        public int ApprovedBetween1And10000 { get; set; }

        [JsonProperty("approvedBetween10001And25000")]
        public int ApprovedBetween10001And25000 { get; set; }

        [JsonProperty("approvedBetween25001AndMax")]
        public int ApprovedBetween25001AndMax { get; set; }

        [JsonProperty("totalMaxGrants")]
        public int TotalMaxGrants { get; set; }
    }

    public class V2HousingAssistanceRentersResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2HousingAssistanceRenters[] HousingAssistanceRenters { get; set; }
    }

    public class V2HousingAssistanceRenters
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("validRegistrations")]
        public int ValidRegistrations { get; set; }

        [JsonProperty("totalInspected")]
        public int TotalInspected { get; set; }

        [JsonProperty("totalInspectedWithNoDamage")]
        public int TotalInspectedWithNoDamage { get; set; }

        [JsonProperty("totalWithModerateDamage")]
        public int TotalWithModerateDamage { get; set; }

        [JsonProperty("totalWithMajorDamage")]
        public int TotalWithMajorDamage { get; set; }

        [JsonProperty("totalWithSubstantialDamage")]
        public int TotalWithSubstantialDamage { get; set; }

        [JsonProperty("approvedForFemaAssistance")]
        public int ApprovedForFemaAssistance { get; set; }

        [JsonProperty("totalApprovedIhpAmount")]
        public double TotalApprovedIhpAmount { get; set; }

        [JsonProperty("repairReplaceAmount")]
        public double RepairReplaceAmount { get; set; }

        [JsonProperty("rentalAmount")]
        public double RentalAmount { get; set; }

        [JsonProperty("otherNeedsAmount")]
        public double OtherNeedsAmount { get; set; }

        [JsonProperty("approvedBetween1And10000")]
        public int ApprovedBetween1And10000 { get; set; }

        [JsonProperty("approvedBetween10001And25000")]
        public int ApprovedBetween10001And25000 { get; set; }

        [JsonProperty("approvedBetween25001AndMax")]
        public int ApprovedBetween25001AndMax { get; set; }

        [JsonProperty("totalMaxGrants")]
        public int TotalMaxGrants { get; set; }
    }

    public class V1IndividualAssistanceHousingRegistrantsLargeDisastersResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1IndividualAssistanceHousingRegistrantsLargeDisasters[] IndividualAssistanceHousingRegistrantsLargeDisasters { get; set; }
    }

    public class V1IndividualAssistanceHousingRegistrantsLargeDisasters
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("damagedCity")]
        public string DamagedCity { get; set; }

        [JsonProperty("damagedStateAbbreviation")]
        public string DamagedStateAbbreviation { get; set; }

        [JsonProperty("damagedZipCode")]
        public string DamagedZipCode { get; set; }

        [JsonProperty("householdComposition")]
        public int HouseholdComposition { get; set; }

        [JsonProperty("grossIncome")]
        public double GrossIncome { get; set; }

        [JsonProperty("specialNeeds")]
        public bool SpecialNeeds { get; set; }

        [JsonProperty("ownRent")]
        public string OwnRent { get; set; }

        [JsonProperty("residenceType")]
        public string ResidenceType { get; set; }

        [JsonProperty("homeOwnersInsurance")]
        public bool HomeOwnersInsurance { get; set; }

        [JsonProperty("floodInsurance")]
        public bool FloodInsurance { get; set; }

        [JsonProperty("inspected")]
        public bool Inspected { get; set; }

        [JsonProperty("rpfvl")]
        public double Rpfvl { get; set; }

        [JsonProperty("habitabilityRepairsRequired")]
        public bool HabitabilityRepairsRequired { get; set; }

        [JsonProperty("destroyed")]
        public bool Destroyed { get; set; }

        [JsonProperty("waterLevel")]
        public int WaterLevel { get; set; }

        [JsonProperty("highWaterLocation")]
        public string HighWaterLocation { get; set; }

        [JsonProperty("floodDamage")]
        public string FloodDamage { get; set; }

        [JsonProperty("foundationDamage")]
        public bool FoundationDamage { get; set; }

        [JsonProperty("foundationDamageAmount")]
        public double FoundationDamageAmount { get; set; }

        [JsonProperty("roofDamage")]
        public bool RoofDamage { get; set; }

        [JsonProperty("roofDamageAmount")]
        public double RoofDamageAmount { get; set; }

        [JsonProperty("tsaEligible")]
        public bool TsaEligible { get; set; }

        [JsonProperty("tsaCheckedIn")]
        public bool TsaCheckedIn { get; set; }

        [JsonProperty("rentalAssistanceEligible")]
        public bool RentalAssistanceEligible { get; set; }

        [JsonProperty("rentalAssistanceAmount")]
        public double RentalAssistanceAmount { get; set; }

        [JsonProperty("repairAssistanceEligible")]
        public bool RepairAssistanceEligible { get; set; }

        [JsonProperty("repairAmount")]
        public double RepairAmount { get; set; }

        [JsonProperty("replacementAssistanceEligible")]
        public bool ReplacementAssistanceEligible { get; set; }

        [JsonProperty("replacementAmount")]
        public string ReplacementAmount { get; set; }

        [JsonProperty("sbaEligible")]
        public bool SbaEligible { get; set; }

        [JsonProperty("renterDamageLevel")]
        public string RenterDamageLevel { get; set; }

        [JsonProperty("rentalAssistanceEndDate")]
        public string RentalAssistanceEndDate { get; set; }

        [JsonProperty("rentalResourceCity")]
        public string RentalResourceCity { get; set; }

        [JsonProperty("rentalResourceStateAbbreviation")]
        public string RentalResourceStateAbbreviation { get; set; }

        [JsonProperty("rentalResourceZipCode")]
        public string RentalResourceZipCode { get; set; }

        [JsonProperty("primaryResidence")]
        public bool PrimaryResidence { get; set; }

        [JsonProperty("personalPropertyEligible")]
        public string PersonalPropertyEligible { get; set; }

        [JsonProperty("ppfvl")]
        public double Ppfvl { get; set; }

        [JsonProperty("censusBlockId")]
        public string CensusBlockId { get; set; }

        [JsonProperty("censusYear")]
        public int CensusYear { get; set; }
    }

    public class V1IndividualsAndHouseholdsProgramValidRegistrationsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1IndividualsAndHouseholdsProgramValidRegistrations[] IndividualsAndHouseholdsProgramValidRegistrations { get; set; }
    }

    public class V1IndividualsAndHouseholdsProgramValidRegistrations
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("damagedStateAbbreviation")]
        public string DamagedStateAbbreviation { get; set; }

        [JsonProperty("damagedCity")]
        public string DamagedCity { get; set; }

        [JsonProperty("damagedZipCode")]
        public string DamagedZipCode { get; set; }

        [JsonProperty("applicantAge")]
        public string ApplicantAge { get; set; }

        [JsonProperty("householdComposition")]
        public string HouseholdComposition { get; set; }

        [JsonProperty("occupantsUnderTwo")]
        public string OccupantsUnderTwo { get; set; }

        [JsonProperty("occupants2to5")]
        public string Occupants2to5 { get; set; }

        [JsonProperty("occupants6to18")]
        public string Occupants6to18 { get; set; }

        [JsonProperty("occupants19to64")]
        public string Occupants19to64 { get; set; }

        [JsonProperty("occupants65andOver")]
        public string Occupants65andOver { get; set; }

        [JsonProperty("grossIncome")]
        public string GrossIncome { get; set; }

        [JsonProperty("ownRent")]
        public bool OwnRent { get; set; }

        [JsonProperty("primaryResidence")]
        public bool PrimaryResidence { get; set; }

        [JsonProperty("residenceType")]
        public string ResidenceType { get; set; }

        [JsonProperty("homeOwnersInsurance")]
        public bool HomeOwnersInsurance { get; set; }

        [JsonProperty("floodInsurance")]
        public bool FloodInsurance { get; set; }

        [JsonProperty("registrationMethod")]
        public string RegistrationMethod { get; set; }

        [JsonProperty("ihpReferral")]
        public string IhpReferral { get; set; }

        [JsonProperty("ihpEligible")]
        public string IhpEligible { get; set; }

        [JsonProperty("ihpAmount")]
        public double IhpAmount { get; set; }

        [JsonProperty("fipAmount")]
        public double FipAmount { get; set; }

        [JsonProperty("haReferral")]
        public bool HaReferral { get; set; }

        [JsonProperty("haEligible")]
        public string HaEligible { get; set; }

        [JsonProperty("haAmount")]
        public double HaAmount { get; set; }

        [JsonProperty("haStatus")]
        public string HaStatus { get; set; }

        [JsonProperty("onaReferral")]
        public bool OnaReferral { get; set; }

        [JsonProperty("onaEligible")]
        public bool OnaEligible { get; set; }

        [JsonProperty("onaAmount")]
        public double OnaAmount { get; set; }

        [JsonProperty("utilitiesOut")]
        public bool UtilitiesOut { get; set; }

        [JsonProperty("homeDamage")]
        public bool HomeDamage { get; set; }

        [JsonProperty("autoDamage")]
        public bool AutoDamage { get; set; }

        [JsonProperty("emergencyNeeds")]
        public bool EmergencyNeeds { get; set; }

        [JsonProperty("foodNeed")]
        public bool FoodNeed { get; set; }

        [JsonProperty("shelterNeed")]
        public bool ShelterNeed { get; set; }

        [JsonProperty("accessFunctionalNeeds")]
        public bool AccessFunctionalNeeds { get; set; }

        [JsonProperty("sbaEligible")]
        public string SbaEligible { get; set; }

        [JsonProperty("sbaApproved")]
        public string SbaApproved { get; set; }

        [JsonProperty("inspnIssued")]
        public bool InspnIssued { get; set; }

        [JsonProperty("inspnReturned")]
        public bool InspnReturned { get; set; }

        [JsonProperty("habitabilityRepairsRequired")]
        public bool HabitabilityRepairsRequired { get; set; }

        [JsonProperty("rpfvl")]
        public double Rpfvl { get; set; }

        [JsonProperty("ppfvl")]
        public double Ppfvl { get; set; }

        [JsonProperty("renterDamageLevel")]
        public string RenterDamageLevel { get; set; }

        [JsonProperty("destroyed")]
        public bool Destroyed { get; set; }

        [JsonProperty("waterLevel")]
        public int WaterLevel { get; set; }

        [JsonProperty("highWaterLocation")]
        public string HighWaterLocation { get; set; }

        [JsonProperty("floodDamage")]
        public bool FloodDamage { get; set; }

        [JsonProperty("floodDamageAmount")]
        public double FloodDamageAmount { get; set; }

        [JsonProperty("foundationDamage")]
        public bool FoundationDamage { get; set; }

        [JsonProperty("foundationDamageAmount")]
        public double FoundationDamageAmount { get; set; }

        [JsonProperty("roofDamage")]
        public bool RoofDamage { get; set; }

        [JsonProperty("roofDamageAmount")]
        public double RoofDamageAmount { get; set; }

        [JsonProperty("tsaEligible")]
        public bool TsaEligible { get; set; }

        [JsonProperty("tsaCheckedIn")]
        public bool TsaCheckedIn { get; set; }

        [JsonProperty("rentalAssistanceEligible")]
        public bool RentalAssistanceEligible { get; set; }

        [JsonProperty("rentalAssistanceAmount")]
        public double RentalAssistanceAmount { get; set; }

        [JsonProperty("repairAssistanceEligible")]
        public bool RepairAssistanceEligible { get; set; }

        [JsonProperty("repairAmount")]
        public double RepairAmount { get; set; }

        [JsonProperty("replacementAssistanceEligible")]
        public bool ReplacementAssistanceEligible { get; set; }

        [JsonProperty("replacementAmount")]
        public double ReplacementAmount { get; set; }

        [JsonProperty("personalPropertyEligible")]
        public bool PersonalPropertyEligible { get; set; }

        [JsonProperty("personalPropertyAmount")]
        public double PersonalPropertyAmount { get; set; }

        [JsonProperty("ihpMax")]
        public bool IhpMax { get; set; }

        [JsonProperty("haMax")]
        public bool HaMax { get; set; }

        [JsonProperty("onaMax")]
        public bool OnaMax { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }
    }

    public class V2RegistrationIntakeIndividualsHouseholdProgramsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2RegistrationIntakeIndividualsHouseholdPrograms[] RegistrationIntakeIndividualsHouseholdPrograms { get; set; }
    }

    public class V2RegistrationIntakeIndividualsHouseholdPrograms
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("totalValidRegistrations")]
        public int TotalValidRegistrations { get; set; }

        [JsonProperty("validCallCenterRegistrations")]
        public int ValidCallCenterRegistrations { get; set; }

        [JsonProperty("validWebRegistrations")]
        public int ValidWebRegistrations { get; set; }

        [JsonProperty("validMobileRegistrations")]
        public int ValidMobileRegistrations { get; set; }

        [JsonProperty("ihpReferrals")]
        public int IhpReferrals { get; set; }

        [JsonProperty("ihpEligible")]
        public int IhpEligible { get; set; }

        [JsonProperty("ihpAmount")]
        public double IhpAmount { get; set; }

        [JsonProperty("haReferrals")]
        public int HaReferrals { get; set; }

        [JsonProperty("haEligible")]
        public int HaEligible { get; set; }

        [JsonProperty("haAmount")]
        public double HaAmount { get; set; }

        [JsonProperty("onaReferrals")]
        public int OnaReferrals { get; set; }

        [JsonProperty("onaEligible")]
        public int OnaEligible { get; set; }

        [JsonProperty("onaAmount")]
        public double OnaAmount { get; set; }
    }

    public class V1DataSetFieldsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1DataSetFields[] DataSetFields { get; set; }
    }

    public class V1DataSetFields
    {
        [JsonProperty("datasetId")]
        public string DatasetId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("openFemaDataSet")]
        public string OpenFemaDataSet { get; set; }

        [JsonProperty("datasetVersion")]
        public int DatasetVersion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("isSearchable")]
        public bool IsSearchable { get; set; }

        [JsonProperty("isNestedObject")]
        public bool IsNestedObject { get; set; }

        [JsonProperty("isNullable")]
        public bool IsNullable { get; set; }

        [JsonProperty("srid")]
        public string Srid { get; set; }

        [JsonProperty("primaryKey")]
        public bool PrimaryKey { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1DataSetsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1DataSets[] DataSets { get; set; }
    }

    public class V1DataSets
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distribution")]
        public JToken[] Distribution { get; set; }

        [JsonProperty("webService")]
        public string WebService { get; set; }

        [JsonProperty("dataDictionary")]
        public string DataDictionary { get; set; }

        [JsonProperty("keyword")]
        public JToken[] Keyword { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("contactPoint")]
        public string ContactPoint { get; set; }

        [JsonProperty("mbox")]
        public string Mbox { get; set; }

        [JsonProperty("accessLevel")]
        public string AccessLevel { get; set; }

        [JsonProperty("landingPage")]
        public string LandingPage { get; set; }

        [JsonProperty("temporal")]
        public string Temporal { get; set; }

        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("recordCount")]
        public int RecordCount { get; set; }

        [JsonProperty("bureauCode")]
        public JToken[] BureauCode { get; set; }

        [JsonProperty("programCode")]
        public JToken[] ProgramCode { get; set; }

        [JsonProperty("accessLevelComment")]
        public string AccessLevelComment { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("spatial")]
        public string Spatial { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("dataQuality")]
        public string DataQuality { get; set; }

        [JsonProperty("accrualPeriodicity")]
        public string AccrualPeriodicity { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("primaryITInvestmentUII")]
        public string PrimaryITInvestmentUII { get; set; }

        [JsonProperty("references")]
        public JToken[] References { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("systemOfRecords")]
        public string SystemOfRecords { get; set; }

        [JsonProperty("depDate")]
        public string DepDate { get; set; }

        [JsonProperty("depApiMessage")]
        public string DepApiMessage { get; set; }

        [JsonProperty("depWebMessage")]
        public string DepWebMessage { get; set; }

        [JsonProperty("depNewURL")]
        public string DepNewURL { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("lastDataSetRefresh")]
        public string LastDataSetRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2FemaRegionsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2FemaRegions[] FemaRegions { get; set; }
    }

    public class V2FemaRegions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("address")]
        public double Address { get; set; }

        [JsonProperty("city")]
        public double City { get; set; }

        [JsonProperty("state")]
        public double State { get; set; }

        [JsonProperty("zipCode")]
        public double ZipCode { get; set; }

        [JsonProperty("states")]
        public JToken[] States { get; set; }

        [JsonProperty("loc")]
        public JToken Loc { get; set; }

        [JsonProperty("regionGeometry")]
        public JToken RegionGeometry { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V2FimaNfipClaimsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2FimaNfipClaims[] FimaNfipClaims { get; set; }
    }

    public class V2FimaNfipClaims
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("agricultureStructureIndicator")]
        public string AgricultureStructureIndicator { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("basementEnclosureCrawlspaceType")]
        public int BasementEnclosureCrawlspaceType { get; set; }

        [JsonProperty("policyCount")]
        public int PolicyCount { get; set; }

        [JsonProperty("crsClassificationCode")]
        public int CrsClassificationCode { get; set; }

        [JsonProperty("dateOfLoss")]
        public string DateOfLoss { get; set; }

        [JsonProperty("elevatedBuildingIndicator")]
        public string ElevatedBuildingIndicator { get; set; }

        [JsonProperty("elevationCertificateIndicator")]
        public string ElevationCertificateIndicator { get; set; }

        [JsonProperty("elevationDifference")]
        public double ElevationDifference { get; set; }

        [JsonProperty("baseFloodElevation")]
        public string BaseFloodElevation { get; set; }

        [JsonProperty("ratedFloodZone")]
        public string RatedFloodZone { get; set; }

        [JsonProperty("houseWorship")]
        public string HouseWorship { get; set; }

        [JsonProperty("locationOfContents")]
        public int LocationOfContents { get; set; }

        [JsonProperty("lowestAdjacentGrade")]
        public double LowestAdjacentGrade { get; set; }

        [JsonProperty("lowestFloorElevation")]
        public double LowestFloorElevation { get; set; }

        [JsonProperty("numberOfFloorsInTheInsuredBuilding")]
        public int NumberOfFloorsInTheInsuredBuilding { get; set; }

        [JsonProperty("nonProfitIndicator")]
        public string NonProfitIndicator { get; set; }

        [JsonProperty("obstructionType")]
        public string ObstructionType { get; set; }

        [JsonProperty("occupancyType")]
        public int OccupancyType { get; set; }

        [JsonProperty("originalConstructionDate")]
        public string OriginalConstructionDate { get; set; }

        [JsonProperty("originalNBDate")]
        public string OriginalNBDate { get; set; }

        [JsonProperty("amountPaidOnBuildingClaim")]
        public double AmountPaidOnBuildingClaim { get; set; }

        [JsonProperty("amountPaidOnContentsClaim")]
        public double AmountPaidOnContentsClaim { get; set; }

        [JsonProperty("amountPaidOnIncreasedCostOfComplianceClaim")]
        public double AmountPaidOnIncreasedCostOfComplianceClaim { get; set; }

        [JsonProperty("postFIRMConstructionIndicator")]
        public string PostFIRMConstructionIndicator { get; set; }

        [JsonProperty("rateMethod")]
        public string RateMethod { get; set; }

        [JsonProperty("smallBusinessIndicatorBuilding")]
        public string SmallBusinessIndicatorBuilding { get; set; }

        [JsonProperty("totalBuildingInsuranceCoverage")]
        public int TotalBuildingInsuranceCoverage { get; set; }

        [JsonProperty("totalContentsInsuranceCoverage")]
        public int TotalContentsInsuranceCoverage { get; set; }

        [JsonProperty("yearOfLoss")]
        public int YearOfLoss { get; set; }

        [JsonProperty("primaryResidenceIndicator")]
        public string PrimaryResidenceIndicator { get; set; }

        [JsonProperty("buildingDamageAmount")]
        public int BuildingDamageAmount { get; set; }

        [JsonProperty("buildingDeductibleCode")]
        public string BuildingDeductibleCode { get; set; }

        [JsonProperty("netBuildingPaymentAmount")]
        public double NetBuildingPaymentAmount { get; set; }

        [JsonProperty("buildingPropertyValue")]
        public int BuildingPropertyValue { get; set; }

        [JsonProperty("causeOfDamage")]
        public string CauseOfDamage { get; set; }

        [JsonProperty("condominiumCoverageTypeCode")]
        public string CondominiumCoverageTypeCode { get; set; }

        [JsonProperty("contentsDamageAmount")]
        public int ContentsDamageAmount { get; set; }

        [JsonProperty("contentsDeductibleCode")]
        public string ContentsDeductibleCode { get; set; }

        [JsonProperty("netContentsPaymentAmount")]
        public double NetContentsPaymentAmount { get; set; }

        [JsonProperty("contentsPropertyValue")]
        public int ContentsPropertyValue { get; set; }

        [JsonProperty("disasterAssistanceCoverageRequired")]
        public int DisasterAssistanceCoverageRequired { get; set; }

        [JsonProperty("eventDesignationNumber")]
        public string EventDesignationNumber { get; set; }

        [JsonProperty("ficoNumber")]
        public int FicoNumber { get; set; }

        [JsonProperty("floodCharacteristicsIndicator")]
        public int FloodCharacteristicsIndicator { get; set; }

        [JsonProperty("floodWaterDuration")]
        public int FloodWaterDuration { get; set; }

        [JsonProperty("floodproofedIndicator")]
        public string FloodproofedIndicator { get; set; }

        [JsonProperty("floodEvent")]
        public string FloodEvent { get; set; }

        [JsonProperty("iccCoverage")]
        public int IccCoverage { get; set; }

        [JsonProperty("netIccPaymentAmount")]
        public double NetIccPaymentAmount { get; set; }

        [JsonProperty("nfipRatedCommunityNumber")]
        public string NfipRatedCommunityNumber { get; set; }

        [JsonProperty("nfipCommunityNumberCurrent")]
        public string NfipCommunityNumberCurrent { get; set; }

        [JsonProperty("nfipCommunityName")]
        public string NfipCommunityName { get; set; }

        [JsonProperty("nonPaymentReasonContents")]
        public string NonPaymentReasonContents { get; set; }

        [JsonProperty("nonPaymentReasonBuilding")]
        public string NonPaymentReasonBuilding { get; set; }

        [JsonProperty("numberOfUnits")]
        public int NumberOfUnits { get; set; }

        [JsonProperty("buildingReplacementCost")]
        public int BuildingReplacementCost { get; set; }

        [JsonProperty("contentsReplacementCost")]
        public int ContentsReplacementCost { get; set; }

        [JsonProperty("replacementCostBasis")]
        public string ReplacementCostBasis { get; set; }

        [JsonProperty("stateOwnedIndicator")]
        public string StateOwnedIndicator { get; set; }

        [JsonProperty("waterDepth")]
        public int WaterDepth { get; set; }

        [JsonProperty("floodZoneCurrent")]
        public string FloodZoneCurrent { get; set; }

        [JsonProperty("buildingDescriptionCode")]
        public int BuildingDescriptionCode { get; set; }

        [JsonProperty("rentalPropertyIndicator")]
        public string RentalPropertyIndicator { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("reportedCity")]
        public string ReportedCity { get; set; }

        [JsonProperty("reportedZipCode")]
        public string ReportedZipCode { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("censusTract")]
        public string CensusTract { get; set; }

        [JsonProperty("censusBlockGroupFips")]
        public string CensusBlockGroupFips { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class V2FimaNfipPoliciesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2FimaNfipPolicies[] FimaNfipPolicies { get; set; }
    }

    public class V2FimaNfipPolicies
    {
        [JsonProperty("agricultureStructureIndicator")]
        public string AgricultureStructureIndicator { get; set; }

        [JsonProperty("baseFloodElevation")]
        public double BaseFloodElevation { get; set; }

        [JsonProperty("basementEnclosureCrawlspaceType")]
        public int BasementEnclosureCrawlspaceType { get; set; }

        [JsonProperty("cancellationDateOfFloodPolicy")]
        public string CancellationDateOfFloodPolicy { get; set; }

        [JsonProperty("condominiumCoverageTypeCode")]
        public string CondominiumCoverageTypeCode { get; set; }

        [JsonProperty("construction")]
        public string Construction { get; set; }

        [JsonProperty("crsClassCode")]
        public int CrsClassCode { get; set; }

        [JsonProperty("buildingDeductibleCode")]
        public string BuildingDeductibleCode { get; set; }

        [JsonProperty("contentsDeductibleCode")]
        public string ContentsDeductibleCode { get; set; }

        [JsonProperty("elevatedBuildingIndicator")]
        public string ElevatedBuildingIndicator { get; set; }

        [JsonProperty("elevationCertificateIndicator")]
        public string ElevationCertificateIndicator { get; set; }

        [JsonProperty("elevationDifference")]
        public string ElevationDifference { get; set; }

        [JsonProperty("federalPolicyFee")]
        public int FederalPolicyFee { get; set; }

        [JsonProperty("ratedFloodZone")]
        public string RatedFloodZone { get; set; }

        [JsonProperty("hfiaaSurcharge")]
        public int HfiaaSurcharge { get; set; }

        [JsonProperty("houseOfWorshipIndicator")]
        public bool HouseOfWorshipIndicator { get; set; }

        [JsonProperty("locationOfContents")]
        public int LocationOfContents { get; set; }

        [JsonProperty("lowestAdjacentGrade")]
        public double LowestAdjacentGrade { get; set; }

        [JsonProperty("lowestFloorElevation")]
        public double LowestFloorElevation { get; set; }

        [JsonProperty("nonProfitIndicator")]
        public string NonProfitIndicator { get; set; }

        [JsonProperty("numberOfFloorsInInsuredBuilding")]
        public int NumberOfFloorsInInsuredBuilding { get; set; }

        [JsonProperty("obstructionType")]
        public string ObstructionType { get; set; }

        [JsonProperty("occupancyType")]
        public int OccupancyType { get; set; }

        [JsonProperty("originalConstructionDate")]
        public string OriginalConstructionDate { get; set; }

        [JsonProperty("originalNBDate")]
        public string OriginalNBDate { get; set; }

        [JsonProperty("policyCost")]
        public int PolicyCost { get; set; }

        [JsonProperty("policyCount")]
        public int PolicyCount { get; set; }

        [JsonProperty("policyEffectiveDate")]
        public string PolicyEffectiveDate { get; set; }

        [JsonProperty("policyTerminationDate")]
        public string PolicyTerminationDate { get; set; }

        [JsonProperty("policyTermIndicator")]
        public int PolicyTermIndicator { get; set; }

        [JsonProperty("postFIRMConstructionIndicator")]
        public string PostFIRMConstructionIndicator { get; set; }

        [JsonProperty("primaryResidenceIndicator")]
        public string PrimaryResidenceIndicator { get; set; }

        [JsonProperty("rateMethod")]
        public string RateMethod { get; set; }

        [JsonProperty("regularEmergencyProgramIndicator")]
        public string RegularEmergencyProgramIndicator { get; set; }

        [JsonProperty("smallBusinessIndicatorBuilding")]
        public string SmallBusinessIndicatorBuilding { get; set; }

        [JsonProperty("totalBuildingInsuranceCoverage")]
        public int TotalBuildingInsuranceCoverage { get; set; }

        [JsonProperty("totalContentsInsuranceCoverage")]
        public int TotalContentsInsuranceCoverage { get; set; }

        [JsonProperty("totalInsurancePremiumOfThePolicy")]
        public int TotalInsurancePremiumOfThePolicy { get; set; }

        [JsonProperty("cancellationVoidanceReasonCode")]
        public string CancellationVoidanceReasonCode { get; set; }

        [JsonProperty("subsidizedRateType")]
        public string SubsidizedRateType { get; set; }

        [JsonProperty("iccPremium")]
        public int IccPremium { get; set; }

        [JsonProperty("reserveFundAssessment")]
        public int ReserveFundAssessment { get; set; }

        [JsonProperty("communityProbationSurcharge")]
        public int CommunityProbationSurcharge { get; set; }

        [JsonProperty("premiumPaymentIndicator")]
        public int PremiumPaymentIndicator { get; set; }

        [JsonProperty("buildingReplacementCost")]
        public int BuildingReplacementCost { get; set; }

        [JsonProperty("basicBuildingRate")]
        public double BasicBuildingRate { get; set; }

        [JsonProperty("additionalBuildingRate")]
        public double AdditionalBuildingRate { get; set; }

        [JsonProperty("basicContentsRate")]
        public double BasicContentsRate { get; set; }
        public double AdditionalContentsRate { get; set; }

        [JsonProperty("enclosureTypeCode")]
        public string EnclosureTypeCode { get; set; }

        [JsonProperty("buildingDescriptionCode")]
        public int BuildingDescriptionCode { get; set; }

        [JsonProperty("insuranceToValueCode")]
        public int InsuranceToValueCode { get; set; }

        [JsonProperty("postFirmVzoneIndicator")]
        public bool PostFirmVzoneIndicator { get; set; }

        [JsonProperty("floodproofedIndicator")]
        public string FloodproofedIndicator { get; set; }

        [JsonProperty("waitingPeriodType")]
        public string WaitingPeriodType { get; set; }

        [JsonProperty("rolloverTransferCode")]
        public string RolloverTransferCode { get; set; }

        [JsonProperty("endorsementEffectiveDate")]
        public string EndorsementEffectiveDate { get; set; }

        [JsonProperty("propertyPurchaseDate")]
        public string PropertyPurchaseDate { get; set; }

        [JsonProperty("rentalPropertyIndicator")]
        public string RentalPropertyIndicator { get; set; }

        [JsonProperty("tenantIndicator")]
        public string TenantIndicator { get; set; }

        [JsonProperty("stateOwnedIndicator")]
        public string StateOwnedIndicator { get; set; }

        [JsonProperty("disasterAssistanceCoverageRequiredCode")]
        public int DisasterAssistanceCoverageRequiredCode { get; set; }

        [JsonProperty("mandatoryPurchaseFlag")]
        public string MandatoryPurchaseFlag { get; set; }

        [JsonProperty("grandfatheringTypeCode")]
        public int GrandfatheringTypeCode { get; set; }

        [JsonProperty("nfipRatedCommunityNumber")]
        public string NfipRatedCommunityNumber { get; set; }

        [JsonProperty("nfipCommunityNumberCurrent")]
        public string NfipCommunityNumberCurrent { get; set; }

        [JsonProperty("nfipCommunityName")]
        public string NfipCommunityName { get; set; }

        [JsonProperty("programTypeIndicator")]
        public string ProgramTypeIndicator { get; set; }

        [JsonProperty("mapPanelNumber")]
        public string MapPanelNumber { get; set; }

        [JsonProperty("mapPanelSuffix")]
        public string MapPanelSuffix { get; set; }

        [JsonProperty("floodZoneCurrent")]
        public string FloodZoneCurrent { get; set; }

        [JsonProperty("femaRegion")]
        public int FemaRegion { get; set; }

        [JsonProperty("propertyState")]
        public string PropertyState { get; set; }

        [JsonProperty("reportedCity")]
        public string ReportedCity { get; set; }

        [JsonProperty("reportedZipCode")]
        public string ReportedZipCode { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("censusTract")]
        public string CensusTract { get; set; }

        [JsonProperty("censusBlockGroupFips")]
        public string CensusBlockGroupFips { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1NfipCommunityLayerComprehensiveResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipCommunityLayerComprehensive[] NfipCommunityLayerComprehensive { get; set; }
    }

    public class V1NfipCommunityLayerComprehensive
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("censusGeoid")]
        public string CensusGeoid { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("communityNameShort")]
        public string CommunityNameShort { get; set; }

        [JsonProperty("censusYear")]
        public int CensusYear { get; set; }

        [JsonProperty("censusPopulationEntire")]
        public int CensusPopulationEntire { get; set; }

        [JsonProperty("censusHousingUnitsEntire")]
        public int CensusHousingUnitsEntire { get; set; }

        [JsonProperty("landAreaEntire")]
        public double LandAreaEntire { get; set; }

        [JsonProperty("cisType")]
        public string CisType { get; set; }

        [JsonProperty("cisSource")]
        public string CisSource { get; set; }

        [JsonProperty("geometrySource")]
        public string GeometrySource { get; set; }

        [JsonProperty("alternateGeoid")]
        public string AlternateGeoid { get; set; }

        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }

        [JsonProperty("alternateLongName")]
        public string AlternateLongName { get; set; }

        [JsonProperty("layerCreationNotes")]
        public string LayerCreationNotes { get; set; }

        [JsonProperty("censusClassCodes")]
        public string CensusClassCodes { get; set; }

        [JsonProperty("censusFunctionalStatusCodes")]
        public string CensusFunctionalStatusCodes { get; set; }

        [JsonProperty("layerTypeCode")]
        public string LayerTypeCode { get; set; }

        [JsonProperty("layerGeometry")]
        public JToken LayerGeometry { get; set; }
    }

    public class V1NfipCommunityLayerNoOverlapsSplitResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipCommunityLayerNoOverlapsSplit[] NfipCommunityLayerNoOverlapsSplit { get; set; }
    }

    public class V1NfipCommunityLayerNoOverlapsSplit
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("censusGeoid")]
        public string CensusGeoid { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("communityNameShort")]
        public string CommunityNameShort { get; set; }

        [JsonProperty("censusYear")]
        public int CensusYear { get; set; }

        [JsonProperty("censusPopulationEntire")]
        public int CensusPopulationEntire { get; set; }

        [JsonProperty("censusHousingUnitsEntire")]
        public int CensusHousingUnitsEntire { get; set; }

        [JsonProperty("landAreaEntire")]
        public double LandAreaEntire { get; set; }

        [JsonProperty("censusPopulationPunched")]
        public int CensusPopulationPunched { get; set; }

        [JsonProperty("censusHousingUnitsPunched")]
        public int CensusHousingUnitsPunched { get; set; }

        [JsonProperty("landArea2D")]
        public double LandArea2D { get; set; }

        [JsonProperty("cisType")]
        public string CisType { get; set; }

        [JsonProperty("cisSource")]
        public string CisSource { get; set; }

        [JsonProperty("geometrySource")]
        public string GeometrySource { get; set; }

        [JsonProperty("alternateGeoid")]
        public string AlternateGeoid { get; set; }

        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }

        [JsonProperty("alternateLongName")]
        public string AlternateLongName { get; set; }

        [JsonProperty("layerCreationNotes")]
        public string LayerCreationNotes { get; set; }

        [JsonProperty("censusClassCodes")]
        public string CensusClassCodes { get; set; }

        [JsonProperty("censusFunctionalStatusCodes")]
        public string CensusFunctionalStatusCodes { get; set; }

        [JsonProperty("layerTypeCode")]
        public string LayerTypeCode { get; set; }

        [JsonProperty("layerGeometry")]
        public JToken LayerGeometry { get; set; }
    }

    public class V1NfipCommunityLayerNoOverlapsWholeResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipCommunityLayerNoOverlapsWhole[] NfipCommunityLayerNoOverlapsWhole { get; set; }
    }

    public class V1NfipCommunityLayerNoOverlapsWhole
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("censusGeoid")]
        public string CensusGeoid { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("communityNameShort")]
        public string CommunityNameShort { get; set; }

        [JsonProperty("censusYear")]
        public int CensusYear { get; set; }

        [JsonProperty("censusPopulationEntire")]
        public int CensusPopulationEntire { get; set; }

        [JsonProperty("censusHousingUnitsEntire")]
        public int CensusHousingUnitsEntire { get; set; }

        [JsonProperty("landAreaEntire")]
        public double LandAreaEntire { get; set; }

        [JsonProperty("censusPopulationPunched")]
        public int CensusPopulationPunched { get; set; }

        [JsonProperty("censusHousingUnitsPunched")]
        public int CensusHousingUnitsPunched { get; set; }

        [JsonProperty("landAreaPunched")]
        public double LandAreaPunched { get; set; }

        [JsonProperty("cisType")]
        public string CisType { get; set; }

        [JsonProperty("cisSource")]
        public string CisSource { get; set; }

        [JsonProperty("geometrySource")]
        public string GeometrySource { get; set; }

        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }

        [JsonProperty("censusClassCodes")]
        public string CensusClassCodes { get; set; }

        [JsonProperty("censusFunctionalStatusCodes")]
        public string CensusFunctionalStatusCodes { get; set; }

        [JsonProperty("layerTypeCode")]
        public string LayerTypeCode { get; set; }

        [JsonProperty("layerGeometry")]
        public JToken LayerGeometry { get; set; }
    }

    public class V1NfipCommunityStatusBookResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipCommunityStatusBook[] NfipCommunityStatusBook { get; set; }
    }

    public class V1NfipCommunityStatusBook
    {
        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("initialFloodHazardBoundaryMap")]
        public string InitialFloodHazardBoundaryMap { get; set; }

        [JsonProperty("initialFloodInsuranceRateMap")]
        public string InitialFloodInsuranceRateMap { get; set; }

        [JsonProperty("currentlyEffectiveMapDate")]
        public string CurrentlyEffectiveMapDate { get; set; }

        [JsonProperty("regularEmergencyProgramDate")]
        public string RegularEmergencyProgramDate { get; set; }

        [JsonProperty("tribal")]
        public string Tribal { get; set; }

        [JsonProperty("participatingInNFIP")]
        public string ParticipatingInNFIP { get; set; }

        [JsonProperty("originalEntryDate")]
        public string OriginalEntryDate { get; set; }

        [JsonProperty("classRatingEffectiveDate")]
        public string ClassRatingEffectiveDate { get; set; }

        [JsonProperty("classRating")]
        public string ClassRating { get; set; }

        [JsonProperty("sfhaDiscount")]
        public string SfhaDiscount { get; set; }

        [JsonProperty("nonSfhaDiscount")]
        public string NonSfhaDiscount { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }
    }

    public class V1NfipMultipleLossPropertiesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipMultipleLossProperties[] NfipMultipleLossProperties { get; set; }
    }

    public class V1NfipMultipleLossProperties
    {
        [JsonProperty("fipsCountyCode")]
        public string FipsCountyCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("reportedCity")]
        public string ReportedCity { get; set; }

        [JsonProperty("communityIdNumber")]
        public string CommunityIdNumber { get; set; }

        [JsonProperty("communityName")]
        public string CommunityName { get; set; }

        [JsonProperty("censusBlockGroup")]
        public string CensusBlockGroup { get; set; }

        [JsonProperty("nfipRl")]
        public bool NfipRl { get; set; }

        [JsonProperty("nfipSrl")]
        public bool NfipSrl { get; set; }

        [JsonProperty("fmaRl")]
        public bool FmaRl { get; set; }

        [JsonProperty("fmaSrl")]
        public bool FmaSrl { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("floodZone")]
        public string FloodZone { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("occupancyType")]
        public int OccupancyType { get; set; }

        [JsonProperty("originalConstructionDate")]
        public string OriginalConstructionDate { get; set; }

        [JsonProperty("originalNBDate")]
        public string OriginalNBDate { get; set; }

        [JsonProperty("postFIRMConstructionIndicator")]
        public bool PostFIRMConstructionIndicator { get; set; }

        [JsonProperty("primaryResidenceIndicator")]
        public bool PrimaryResidenceIndicator { get; set; }

        [JsonProperty("mitigatedIndicator")]
        public bool MitigatedIndicator { get; set; }

        [JsonProperty("insuredIndicator")]
        public bool InsuredIndicator { get; set; }

        [JsonProperty("totalLosses")]
        public int TotalLosses { get; set; }

        [JsonProperty("mostRecentDateofLoss")]
        public string MostRecentDateofLoss { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1NfipResidentialPenetrationRatesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1NfipResidentialPenetrationRates[] NfipResidentialPenetrationRates { get; set; }
    }

    public class V1NfipResidentialPenetrationRates
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("resPenetrationRate")]
        public double ResPenetrationRate { get; set; }

        [JsonProperty("resContractsInForce")]
        public int ResContractsInForce { get; set; }

        [JsonProperty("totalResStructures")]
        public int TotalResStructures { get; set; }

        [JsonProperty("fipsCode")]
        public string FipsCode { get; set; }

        [JsonProperty("asOfDate")]
        public string AsOfDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V1PublicAssistanceApplicantsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1PublicAssistanceApplicants[] PublicAssistanceApplicants { get; set; }
    }

    public class V1PublicAssistanceApplicants
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("applicantName")]
        public string ApplicantName { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1PublicAssistanceApplicantsProgramDeliveriesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1PublicAssistanceApplicantsProgramDeliveries[] PublicAssistanceApplicantsProgramDeliveries { get; set; }
    }

    public class V1PublicAssistanceApplicantsProgramDeliveries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("declarationType")]
        public string DeclarationType { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateName")]
        public string StateName { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("declarationTitle")]
        public string DeclarationTitle { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("consolidatedResourceCenter")]
        public string ConsolidatedResourceCenter { get; set; }

        [JsonProperty("countyApplicantJurisdiction")]
        public string CountyApplicantJurisdiction { get; set; }

        [JsonProperty("utilizingDirectApplication")]
        public string UtilizingDirectApplication { get; set; }

        [JsonProperty("applicantIdGm")]
        public int ApplicantIdGm { get; set; }

        [JsonProperty("applicantIdEmmie")]
        public string ApplicantIdEmmie { get; set; }

        [JsonProperty("applicantName")]
        public string ApplicantName { get; set; }

        [JsonProperty("applicantType")]
        public string ApplicantType { get; set; }

        [JsonProperty("isPnp")]
        public string IsPnp { get; set; }

        [JsonProperty("applicantStatus")]
        public string ApplicantStatus { get; set; }

        [JsonProperty("applicantProcessStatus")]
        public string ApplicantProcessStatus { get; set; }

        [JsonProperty("numberActiveDamages")]
        public int NumberActiveDamages { get; set; }

        [JsonProperty("totalAppDamageCost")]
        public double TotalAppDamageCost { get; set; }

        [JsonProperty("numberActiveProjects")]
        public int NumberActiveProjects { get; set; }

        [JsonProperty("currentProjectCost")]
        public double CurrentProjectCost { get; set; }

        [JsonProperty("numberPhase2Projects")]
        public int NumberPhase2Projects { get; set; }

        [JsonProperty("phase2ProjectCost")]
        public double Phase2ProjectCost { get; set; }

        [JsonProperty("numberPhase3Projects")]
        public int NumberPhase3Projects { get; set; }

        [JsonProperty("phase3ProjectCost")]
        public double Phase3ProjectCost { get; set; }

        [JsonProperty("numberPhase4Projects")]
        public int NumberPhase4Projects { get; set; }

        [JsonProperty("phase4ProjectCost")]
        public double Phase4ProjectCost { get; set; }

        [JsonProperty("numberPhase5Projects")]
        public int NumberPhase5Projects { get; set; }

        [JsonProperty("phase5ProjectCost")]
        public double Phase5ProjectCost { get; set; }

        [JsonProperty("numberObligatedProjects")]
        public int NumberObligatedProjects { get; set; }

        [JsonProperty("federalShareObligated")]
        public double FederalShareObligated { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V1PublicAssistanceFundedProjectsDetailsResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1PublicAssistanceFundedProjectsDetails[] PublicAssistanceFundedProjectsDetails { get; set; }
    }

    public class V1PublicAssistanceFundedProjectsDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("pwNumber")]
        public int PwNumber { get; set; }

        [JsonProperty("applicationTitle")]
        public string ApplicationTitle { get; set; }

        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("damageCategoryCode")]
        public string DamageCategoryCode { get; set; }

        [JsonProperty("dcc")]
        public string Dcc { get; set; }

        [JsonProperty("damageCategory")]
        public string DamageCategory { get; set; }

        [JsonProperty("projectSize")]
        public string ProjectSize { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("countyCode")]
        public string CountyCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("stateNumberCode")]
        public string StateNumberCode { get; set; }

        [JsonProperty("projectAmount")]
        public double ProjectAmount { get; set; }

        [JsonProperty("federalShareObligated")]
        public double FederalShareObligated { get; set; }

        [JsonProperty("totalObligated")]
        public double TotalObligated { get; set; }

        [JsonProperty("obligatedDate")]
        public string ObligatedDate { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }
    }

    public class V1PublicAssistanceFundedProjectsSummariesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V1PublicAssistanceFundedProjectsSummaries[] PublicAssistanceFundedProjectsSummaries { get; set; }
    }

    public class V1PublicAssistanceFundedProjectsSummaries
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("applicantName")]
        public string ApplicantName { get; set; }

        [JsonProperty("educationApplicant")]
        public string EducationApplicant { get; set; }

        [JsonProperty("numberOfProjects")]
        public int NumberOfProjects { get; set; }

        [JsonProperty("federalObligatedAmount")]
        public double FederalObligatedAmount { get; set; }

        [JsonProperty("lastRefresh")]
        public string LastRefresh { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class V2PublicAssistanceGrantAwardActivitiesResponse
    {
        [JsonProperty("metadata")]
        public MetadataInfo Metadata { get; set; }
        public V2PublicAssistanceGrantAwardActivities[] PublicAssistanceGrantAwardActivities { get; set; }
    }

    public class V2PublicAssistanceGrantAwardActivities
    {
        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("disasterNumber")]
        public int DisasterNumber { get; set; }

        [JsonProperty("sriaDisaster")]
        public string SriaDisaster { get; set; }

        [JsonProperty("declarationTitle")]
        public string DeclarationTitle { get; set; }

        [JsonProperty("disasterType")]
        public string DisasterType { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("declarationDate")]
        public string DeclarationDate { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("applicantName")]
        public string ApplicantName { get; set; }

        [JsonProperty("pnpStatus")]
        public string PnpStatus { get; set; }

        [JsonProperty("damageCategoryCode")]
        public string DamageCategoryCode { get; set; }

        [JsonProperty("federalShareObligated")]
        public double FederalShareObligated { get; set; }

        [JsonProperty("dateObligated")]
        public string DateObligated { get; set; }

        [JsonProperty("pwNumber")]
        public int PwNumber { get; set; }

        [JsonProperty("projectTitle")]
        public string ProjectTitle { get; set; }

        [JsonProperty("versionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("eligibilityStatus")]
        public string EligibilityStatus { get; set; }

        [JsonProperty("fundingStatus")]
        public string FundingStatus { get; set; }

        [JsonProperty("paCloseoutStatus")]
        public string PaCloseoutStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fema;

    public partial class WorkflowManagedActions
    {
        public FemaActions Fema(string connectionId) => new FemaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FemaTriggers Fema(string connectionId) => new FemaTriggers(connectionId);
    }
}